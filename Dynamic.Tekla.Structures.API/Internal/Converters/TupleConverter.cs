﻿using Dynamic.Tekla.Structures.Internal.Exceptions;
using System;
using System.Linq;

namespace Dynamic.Tekla.Structures.Internal.Converters;
internal static class TupleConverter
{
    public static System.Tuple<T1, T2> FromTSObject<T1, T2>(object input)
    {
        var array = ConvertTupleTSTypes(input);

        if (array.Length != 2)
            throw new ArgumentException("Input array should have 2 elements but has " + array.Length);
        return new Tuple<T1, T2>((T1)array[0], (T2)array[1]);
    }

    public static System.Tuple<T1, T2, T3> FromTSObject<T1, T2, T3>(object input)
    {
        var array = ConvertTupleTSTypes(input);

        if (array.Length != 3)
            throw new ArgumentException("Input array should have 3 elements but has " + array.Length);
        return new Tuple<T1, T2, T3>((T1)array[0], (T2)array[1], (T3)array[2]);
    }

    public static System.Tuple<T1, T2, T3, T4> FromTSObject<T1, T2, T3, T4>(object input)
    {
        var array = ConvertTupleTSTypes(input);

        if (array.Length != 4)
            throw new ArgumentException("Input array should have 4 elements but has " + array.Length);
        return new Tuple<T1, T2, T3, T4>((T1)array[0], (T2)array[1], (T3)array[2], (T4)array[3]);
    }

    private static object[] ConvertTupleTSTypes(object input)
    {
        try
        {
            object[] values = input.GetType()
                      .GetProperties()
                      .Select(property => property.GetValue(input))
                      .ToArray();
            if (values.Length.Equals(0)) return values;

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            for (int i = 0; i < values.Length; i++)
            {
                var currentValue = values[i];
                if (currentValue.GetType().ToString().StartsWith("Tekla.Structures.", StringComparison.InvariantCulture))
                {
                    string converterName = "Dynamic." + currentValue.GetType().ToString() + "_";
                    var converterType = assembly.GetType(converterName);
                    var parameters = new object[] { currentValue };
                    var fromTSObjectMethod = TSActivator.GetMethod("FromTSObject", parameters, converterType);
                    var converted = fromTSObjectMethod.Invoke(null, parameters);
                    values[i] = converted;
                }
            }
            return values;
        }
        catch (Exception ex)
        {
            throw new DynamicAPIException("Error in method TupleConverter.ConvertTupleTSTypes() Input type: "
                                                              + input.GetType().ToString() + "\n Internal error message: " + ex.Message, ex);
        }
    }

}
