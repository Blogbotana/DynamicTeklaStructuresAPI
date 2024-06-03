using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic.Tekla.Structures.Datatype;
internal class ValueList
{
    public delegate string ToStringFunc<T>(T value);
    public delegate bool TryParseFunc<T>(string text, out T value);
    private static readonly string separator = " ";
    private static readonly string multiplier = "*";
    public static string ToString<T>(IEnumerable<T> values, ToStringFunc<T> toString) where T : IEquatable<T>
    {
        StringBuilder stringBuilder = new StringBuilder();
        T value = default(T);
        int num = 0;
        foreach (T value2 in values)
        {
            if (num == 0)
            {
                value = value2;
                num = 1;
                continue;
            }
            if (value.Equals(value2))
            {
                num++;
                continue;
            }
            if (stringBuilder.Length > 0)
            {
                stringBuilder.Append(separator);
            }
            if (num > 1)
            {
                stringBuilder.Append(num).Append(multiplier);
            }
            stringBuilder.Append(toString(value));
            value = value2;
            num = 1;
        }
        if (num > 0)
        {
            if (stringBuilder.Length > 0)
            {
                stringBuilder.Append(separator);
            }
            if (num > 1)
            {
                stringBuilder.Append(num).Append(multiplier);
            }
            stringBuilder.Append(toString(value));
        }
        return stringBuilder.ToString();
    }
    public static IEnumerable<T> Parse<T>(string input, TryParseFunc<T> tryParse)
    {
        string[] array = input.Split(new string[1] { separator }, StringSplitOptions.RemoveEmptyEntries);
        foreach (string text in array)
        {
            T value;
            if (text.Contains(multiplier))
            {
                string[] array2 = text.Split(new string[1] { multiplier }, StringSplitOptions.RemoveEmptyEntries);
                if (array2.Length == 2 && int.TryParse(array2[0], out var count) && tryParse(array2[1], out value))
                {
                    for (int i = 0; i < count; i++)
                    {
                        yield return value;
                    }
                }
            }
            else if (tryParse(text, out value))
            {
                yield return value;
            }
            value = default(T);
        }
    }
}
