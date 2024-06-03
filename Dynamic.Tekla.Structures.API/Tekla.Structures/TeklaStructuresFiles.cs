using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using System;
using System.Collections.Generic;
using System.IO;

namespace Dynamic.Tekla.Structures;
/// <summary>
/// The TeklaStructuresFiles class is for the paths where the attributes file will be searched for.
/// </summary>
public class TeklaStructuresFiles
{
    internal dynamic teklaObject;

    internal TeklaStructuresFiles() { }

    public TeklaStructuresFiles(dynamic tsObject, DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }
    public TeklaStructuresFiles(string modelpath)
    {
        var args = new object[1];
        args[0] = modelpath;
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.TeklaStructuresFiles", args);
    }
    public List<string> GetMultiDirectoryFileList(string fileExtension, bool fullpath)
    {
        try
        {
            var result = (List<string>)teklaObject.GetMultiDirectoryFileList(fileExtension, fullpath);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetMultiDirectoryFileList), ex);
        }
    }



    public FileInfo GetAttributeFile(string fileName)
    {
        try
        {
            var result = (FileInfo)teklaObject.GetAttributeFile(fileName);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetAttributeFile), ex);
        }
    }

    public FileInfo GetAttributeFile(List<string> searchDirectories, string fileName)
    {
        try
        {
            var result = (FileInfo)teklaObject.GetAttributeFile(searchDirectories, fileName);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetAttributeFile), ex);
        }
    }
}
internal static class TeklaStructuresFiles_
{
    public static dynamic GetTSObject(TeklaStructuresFiles dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static TeklaStructuresFiles FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new DateTime();

        var dynObject = (TeklaStructuresFiles)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}
