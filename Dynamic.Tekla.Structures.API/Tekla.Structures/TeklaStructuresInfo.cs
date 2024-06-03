using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Invoker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic.Tekla.Structures;
/// <summary>The TeklaStructuresInfo class provides information about Tekla Structures.</summary>
public sealed class TeklaStructuresInfo
{
    internal dynamic teklaObject;

    public TeklaStructuresInfo()
    {
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.TeklaStructuresInfo");
    }

    public TeklaStructuresInfo(dynamic tsObject, DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }
    public static System.String GetCurrentProgramVersion()
    {
        var result = (System.String)MethodInvoker.InvokeStaticMethod("Tekla.Structures.TeklaStructuresInfo", "GetCurrentProgramVersion");
        return result;
    }



    public static System.String GetBuildNumber()
    {
        var result = (System.String)MethodInvoker.InvokeStaticMethod("Tekla.Structures.TeklaStructuresInfo", "GetBuildNumber");
        return result;
    }



    public static System.String GetRevisionDate()
    {
        var result = (System.String)MethodInvoker.InvokeStaticMethod("Tekla.Structures.TeklaStructuresInfo", "GetRevisionDate");
        return result;
    }



    public static System.String GetCopyRightText()
    {
        var result = (System.String)MethodInvoker.InvokeStaticMethod("Tekla.Structures.TeklaStructuresInfo", "GetCopyRightText");
        return result;
    }



    public static System.String GetLocalAppDataFolder()
    {
        var result = (System.String)MethodInvoker.InvokeStaticMethod("Tekla.Structures.TeklaStructuresInfo", "GetLocalAppDataFolder");
        return result;
    }



    public static System.String GetCommonAppDataFolder()
    {
        var result = (System.String)MethodInvoker.InvokeStaticMethod("Tekla.Structures.TeklaStructuresInfo", "GetCommonAppDataFolder");
        return result;
    }



    public static System.String GetFullTSRegistryKeyText()
    {
        var result = (System.String)MethodInvoker.InvokeStaticMethod("Tekla.Structures.TeklaStructuresInfo", "GetFullTSRegistryKeyText");
        return result;
    }



    public static System.String GetCurrentUser()
    {
        var result = (System.String)MethodInvoker.InvokeStaticMethod("Tekla.Structures.TeklaStructuresInfo", "GetCurrentUser");
        return result;
    }



    public static System.String GetPluginsFolder()
    {
        var result = (System.String)MethodInvoker.InvokeStaticMethod("Tekla.Structures.TeklaStructuresInfo", "GetPluginsFolder");
        return result;
    }
}

internal static class TeklaStructuresInfo_
{
    public static dynamic GetTSObject(TeklaStructuresInfo dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static TeklaStructuresInfo FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new DateTime();

        var dynObject = (Dynamic.Tekla.Structures.TeklaStructuresInfo)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}