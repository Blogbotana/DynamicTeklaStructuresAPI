using Dynamic.Tekla.Structures.Internal.Exceptions;
using System;
using System.Collections;
using System.Reflection;

namespace Dynamic.Tekla.Structures.Internal.Converters;

internal static class ArrayListConverter
{
    public static ArrayList ToTSObjects(ArrayList dynAPIObjects)
    {
        try
        {
            if (dynAPIObjects.Count.Equals(0))
                return new ArrayList();

            ArrayList output = new(dynAPIObjects.Count);
            Assembly assembly = Assembly.GetExecutingAssembly();

            foreach (dynamic dynObject in dynAPIObjects)
            {
                if (dynObject is ArrayList)
                {
                    output.Add(ToTSObjects(dynObject));
                }
                else if (dynObject.GetType().ToString().StartsWith("Dynamic.Tekla.Structures.", StringComparison.InvariantCulture))
                {
                    string converterName = dynObject.GetType().ToString() + "_";
                    Type converterType = assembly.GetType(converterName);
                    object[] parameters = new object[] { dynObject };
                    MethodInfo getTSObjectMethod = TSActivator.GetMethod("GetTSObject", parameters, converterType);

                    _ = output.Add(getTSObjectMethod.Invoke(null, parameters));
                }
                else
                {
                    output.Add(dynObject);
                }
            }
            return output;
        }
        catch (Exception ex)
        {
            throw new DynamicAPIException("Error in method ArrayListConverter.ToTSObjects() Input type: "
                                                               + dynAPIObjects.GetType().ToString() + "\n Internal error message: " + ex.Message, ex);
        }
    }

    public static ArrayList FromTSObjects(ArrayList tsObjects)
    {
        try
        {
            if (tsObjects.Count.Equals(0))
                return new ArrayList();

            ArrayList output = new(tsObjects.Count);
            Assembly assembly = Assembly.GetExecutingAssembly();

            foreach (dynamic tsObject in tsObjects)
            {
                if (tsObject is ArrayList)
                {
                    output.Add(FromTSObjects(tsObject));
                }
                else if (tsObject.GetType().ToString().StartsWith("Tekla.Structures.", StringComparison.InvariantCulture))
                {
                    string converterName = "Dynamic." + tsObject.GetType().ToString() + "_";
                    Type converterType = assembly.GetType(converterName);
                    object[] parameters = new object[] { tsObject };
                    MethodInfo fromTSObjectMethod = TSActivator.GetMethod("FromTSObject", parameters, converterType);

                    _ = output.Add(fromTSObjectMethod.Invoke(null, parameters));
                }
                else
                {
                    output.Add(tsObject);
                }
            }
            return output;
        }
        catch (Exception ex)
        {
            throw new DynamicAPIException("Error in method ArrayListConverter.FromTSObjects() Input type: "
                                                                + tsObjects.GetType().ToString() + "\n Internal error message: " + ex.Message, ex);
        }
    }
}
