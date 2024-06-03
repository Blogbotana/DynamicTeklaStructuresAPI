using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Invoker;
using System;

namespace Dynamic.Tekla.Structures;
/// <summary>
/// The TeklaStructuresSettings class provides methods to inquire application settings.
/// </summary>
public sealed class TeklaStructuresSettings
{

    internal dynamic teklaObject;

    public TeklaStructuresSettings()
    {
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.TeklaStructuresSettings");
    }

    public TeklaStructuresSettings(dynamic tsObject, DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }
    public static bool GetAdvancedOption(string VariableName, ref bool Value)
    {
        var result = (bool)MethodInvoker.InvokeStaticMethod("Tekla.Structures.TeklaStructuresSettings", "GetAdvancedOption", VariableName, ref Value);
        return result;
    }



    public static bool GetAdvancedOption(string VariableName, ref System.Int32 Value)
    {
        var result = (bool)MethodInvoker.InvokeStaticMethod("Tekla.Structures.TeklaStructuresSettings", "GetAdvancedOption", VariableName, ref Value);
        return result;
    }



    public static bool GetAdvancedOption(string VariableName, ref string Value)
    {
        var result = (bool)MethodInvoker.InvokeStaticMethod("Tekla.Structures.TeklaStructuresSettings", "GetAdvancedOption", VariableName, ref Value);
        return result;
    }



    public static bool GetAdvancedOption(string VariableName, ref double Value)
    {
        var result = (bool)MethodInvoker.InvokeStaticMethod("Tekla.Structures.TeklaStructuresSettings", "GetAdvancedOption", VariableName, ref Value);
        return result;
    }
    public static bool GetOptions(
            ref Dynamic.Tekla.Structures.ClashCheckOptions Options_)
    {
        var Options = Dynamic.Tekla.Structures.ClashCheckOptions_.GetTSObject(Options_);
        var result = (bool)MethodInvoker.InvokeStaticMethod("Tekla.Structures.TeklaStructuresSettings", "GetOptions", ref Options);
        Options_ = Dynamic.Tekla.Structures.ClashCheckOptions_.FromTSObject(Options);
        return result;
    }



    public static bool SetOptions(
        Dynamic.Tekla.Structures.ClashCheckOptions Options_)
    {
        var Options = Dynamic.Tekla.Structures.ClashCheckOptions_.GetTSObject(Options_);
        var result = (bool)MethodInvoker.InvokeStaticMethod("Tekla.Structures.TeklaStructuresSettings", "SetOptions", Options);
        return result;
    }



    public static bool GetOptions(
        ref Dynamic.Tekla.Structures.ComponentOptions Options_)
    {
        var Options = Dynamic.Tekla.Structures.ComponentOptions_.GetTSObject(Options_);
        var result = (bool)MethodInvoker.InvokeStaticMethod("Tekla.Structures.TeklaStructuresSettings", "GetOptions", ref Options);
        Options_ = Dynamic.Tekla.Structures.ComponentOptions_.FromTSObject(Options);
        return result;
    }



    public static bool SetOptions(Dynamic.Tekla.Structures.ComponentOptions Options_)
    {
        var Options = Dynamic.Tekla.Structures.ComponentOptions_.GetTSObject(Options_);
        var result = (bool)MethodInvoker.InvokeStaticMethod("Tekla.Structures.TeklaStructuresSettings", "SetOptions", Options);
        return result;
    }



    public static bool IsToolOptionOn(string toolOptionName)
    {
        var result = (bool)MethodInvoker.InvokeStaticMethod("Tekla.Structures.TeklaStructuresSettings", "IsToolOptionOn", toolOptionName);
        return result;
    }



    public static bool IsPourEnabled()
    {
        var result = (bool)MethodInvoker.InvokeStaticMethod("Tekla.Structures.TeklaStructuresSettings", "IsPourEnabled");
        return result;
    }
}
