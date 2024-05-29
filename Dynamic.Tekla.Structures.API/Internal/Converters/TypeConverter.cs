using Dynamic.Tekla.Structures.Internal.Exceptions;
using System;

namespace Dynamic.Tekla.Structures.Internal.Converters;

public static class TypeConverter
{
    public static Type ToTSObjects(Type input)
    {
        try
        {
            string typeFullName = TypeFullName.GetTypeFullName(input);

            if (typeFullName.StartsWith("Dynamic.Tekla.Structures.", System.StringComparison.InvariantCulture))
            {
                string typeName = typeFullName.Replace("Dynamic.Tekla.Structures.", "Tekla.Structures.");
                return TSActivator.GetTypeFromTypeName(typeName);
            }
            else
            {
                return input;
            }
        }
        catch (Exception ex)
        {
            throw new DynamicAPIException("Error in method TypeConverter.ToTSObjects() Input type: "
                                + input.GetType().ToString() + "\n Internal error message: " + ex.Message, ex);
        }
    }

    public static Type[] ToTSObjects(Type[] input)
    {
        Type[] output = new Type[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            output[i] = ToTSObjects(input[i]);
        }

        return output;
    }

    public static Type FromTSObjects(Type input)
    {
        try
        {
            string typeFullName = TypeFullName.GetTypeFullName(input);

            if (typeFullName.StartsWith("Tekla.Structures.", System.StringComparison.InvariantCulture))
            {
                string typeName = typeFullName.Replace("Tekla.Structures.", "Dynamic.Tekla.Structures.");
                return TSActivator.GetTypeFromTypeName(typeName);
            }
            else
            {
                return input;
            }
        }
        catch (Exception ex)
        {
            throw new DynamicAPIException("Error in method TypeConverter.FromTSObjects() Input type: "
                                               + input.GetType().ToString() + "\n Internal error message: " + ex.Message, ex);
        }
    }

    public static Type[] FromTSObjects(Type[] input)
    {
        Type[] output = new Type[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            output[i] = FromTSObjects(input[i]);
        }

        return output;
    }
}
