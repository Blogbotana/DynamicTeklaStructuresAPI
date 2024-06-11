using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Exceptions;

namespace Dynamic.Tekla.Structures.Model;
public class Phase
{
    public int PhaseNumber
    {
        get
        {
            try
            {
                return teklaObject.PhaseNumber;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(PhaseNumber), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.PhaseNumber = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(PhaseNumber), ex);
            }
        }
    }

    public string PhaseName
    {
        get
        {
            try
            {
                return teklaObject.PhaseName;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(PhaseName), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.PhaseName = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(PhaseName), ex);
            }
        }
    }

    public string PhaseComment
    {
        get
        {
            try
            {
                return teklaObject.PhaseComment;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(PhaseComment), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.PhaseComment = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(PhaseComment), ex);
            }
        }
    }

    public int IsCurrentPhase
    {
        get
        {
            try
            {
                return teklaObject.IsCurrentPhase;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(IsCurrentPhase), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.IsCurrentPhase = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(IsCurrentPhase), ex);
            }
        }
    }


    internal dynamic teklaObject;

    public Phase() : this(0, "", "", 0)
    { }

    public Phase(dynamic tsObject, System.DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }
    public Phase(int PhaseNumber)
    {
        var args = new object[1];
        args[0] = PhaseNumber;
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Phase", args);
    }
    public Phase(int PhaseNumber, string PhaseName, string PhaseComment, int IsCurrentPhase)
    {
        var args = new object[4];
        args[0] = PhaseNumber;
        args[1] = PhaseName;
        args[2] = PhaseComment;
        args[3] = IsCurrentPhase;
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Phase", args);
    }


    public bool Insert()
    {

        try
        {
            var result = (bool)teklaObject.Insert();

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Insert), ex);
        }
    }



    public bool Select()
    {

        try
        {
            var result = (bool)teklaObject.Select();

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Select), ex);
        }
    }



    public bool Modify()
    {

        try
        {
            var result = (bool)teklaObject.Modify();

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Modify), ex);
        }
    }



    public bool Delete()
    {

        try
        {
            var result = (bool)teklaObject.Delete();

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Delete), ex);
        }
    }



    public bool SetUserProperty(string Name, string Value)
    {
        try
        {
            var result = (bool)teklaObject.SetUserProperty(Name, Value);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SetUserProperty), ex);
        }
    }



    public bool SetUserProperty(string Name, double Value)
    {
        try
        {
            var result = (bool)teklaObject.SetUserProperty(Name, Value);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SetUserProperty), ex);
        }
    }



    public bool SetUserProperty(string Name, int Value)
    {
        try
        {
            var result = (bool)teklaObject.SetUserProperty(Name, Value);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SetUserProperty), ex);
        }
    }



    public bool GetUserProperty(string Name, ref string Value)
    {
        try
        {
            var result = (bool)teklaObject.GetUserProperty(Name, ref Value);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetUserProperty), ex);
        }
    }



    public bool GetUserProperty(string Name, ref double Value)
    {
        try
        {
            var result = (bool)teklaObject.GetUserProperty(Name, ref Value);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetUserProperty), ex);
        }
    }



    public bool GetUserProperty(string Name, ref int Value)
    {
        try
        {
            var result = (bool)teklaObject.GetUserProperty(Name, ref Value);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetUserProperty), ex);
        }
    }
}

internal static class Phase_
{
    public static dynamic GetTSObject(Phase dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static Phase FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (Phase)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}
