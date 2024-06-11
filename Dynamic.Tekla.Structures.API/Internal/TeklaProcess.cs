using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace Dynamic.Tekla.Structures.Internal;

internal static class TeklaProcess
{
    private const string TEKLA_PROCESS_NAME = "TeklaStructures";
    internal static Dictionary<string, Assembly> APIAssemblies { get; private set; } = new Dictionary<string, Assembly>();
    public static string BinPath { get; private set; } = string.Empty;
    public static Version TeklaFileVersion { get; private set; }
    public static Process teklaProcess { get; private set; }

    public static bool IsTeklaRunning()
    {
        return teklaProcess is null ? GetTeklaProcess() : !teklaProcess.HasExited || GetTeklaProcess();
    }

    private static bool GetTeklaProcess()
    {
        Process teklaProcess = Process.GetProcessesByName(TEKLA_PROCESS_NAME)
            .FirstOrDefault();

        if (teklaProcess is null)
        {
            return false;
        }

        string teklaFilePath = GetProcessFilename(teklaProcess);
        BinPath = Path.GetDirectoryName(teklaFilePath);
        TeklaFileVersion = GetFileVersion(teklaFilePath);
        APIAssemblies = GetAssemblies();
        return true;
    }


    private static string GetProcessFilename(Process process)
    {
        return GetMainModuleFileName(process);
    }

    //https://stackoverflow.com/questions/5497064/how-to-get-the-full-path-of-running-process
    [DllImport("Kernel32.dll")]
    private static extern bool QueryFullProcessImageName([In] IntPtr hProcess, [In] uint dwFlags, [Out] StringBuilder lpExeName, [In, Out] ref uint lpdwSize);
    private static string GetMainModuleFileName(Process process, int buffer = 1024)
    {
        StringBuilder fileNameBuilder = new(buffer);
        uint bufferLength = (uint)fileNameBuilder.Capacity + 1;
        return QueryFullProcessImageName(process.Handle, 0, fileNameBuilder, ref bufferLength)
            ? fileNameBuilder.ToString()
            : null;
    }

    private static Version GetFileVersion(string teklaFilePath)
    {
        FileVersionInfo fvinfo = FileVersionInfo.GetVersionInfo(teklaFilePath);
        return new Version
        (
            fvinfo.FileMajorPart,
            fvinfo.FileMinorPart,
            fvinfo.FileBuildPart,
            fvinfo.FilePrivatePart
        );
    }

    private static Dictionary<string, Assembly> GetAssemblies()
    {
        Dictionary<string, Assembly> output = new();

        foreach (string dllPath in GetDllPathes(BinPath))
        {
            if (!File.Exists(dllPath))
                continue;

            Assembly assembly = Assembly.LoadFrom(dllPath);

            foreach (Type tsType in assembly.GetTypes().Where(t => t.IsPublic))
            {
                var typeFullName = TypeFullName.GetTypeFullName(tsType);
                output.Add(typeFullName, assembly);

                foreach (Type nestedType in NestedTypes(tsType))
                {
                    var nestedTypeFullName = TypeFullName.GetTypeFullName(nestedType);
                    output.Add(nestedTypeFullName, assembly);
                }
            }
        }

        return output;
    }

    private static List<Type> NestedTypes(Type type)
    {
        List<Type> output = new();

        foreach (Type nestedType in type.GetNestedTypes())
        {
            output.Add(nestedType);
            output.AddRange(NestedTypes(nestedType));
        }
        return output;
    }

    private static List<string> GetDllPathes(string binPath)
    {
        return new List<string>()
        {
            Path.Combine(binPath, "plugins", "Tekla.Structures.dll"),
            Path.Combine(binPath, "plugins",  "Tekla.Structures.Model.dll"),
            Path.Combine(binPath, "plugins",  "Tekla.Structures.Datatype.dll"),
            Path.Combine(binPath, "plugins",  "Tekla.Structures.Drawing.dll"),
            Path.Combine(binPath, "plugins",  "Tekla.Structures.Catalogs.dll"),
            Path.Combine(binPath, "Tekla.Structures.dll"),
            Path.Combine(binPath, "Tekla.Structures.Model.dll"),
            Path.Combine(binPath, "Tekla.Structures.Datatype.dll"),
            Path.Combine(binPath, "Tekla.Structures.Drawing.dll"),
            Path.Combine(binPath, "Tekla.Structures.Catalogs.dll"),
            Path.Combine(binPath, "applications", "Tekla", "Common", "Tekla.Application.Library.dll"),
            Path.Combine(binPath, "dialogs", "Tekla.Structures.Dialog.dll"),
        };
    }
}
