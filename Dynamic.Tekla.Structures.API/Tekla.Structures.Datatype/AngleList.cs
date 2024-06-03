using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic.Tekla.Structures.Datatype;
/// <summary>
/// This class provides methods to handle lists of angles
/// </summary>
public static class AngleList
{
    /// <summary>
    /// Converts the given angles to a string in the current units
    /// </summary>
    /// <param name="angleList">List of angles to convert</param>
    /// <returns>The angle list as a string</returns>
    public static string ToString(IEnumerable<Angle> angleList)
    {
        return ValueList.ToString(angleList, (Angle angle) => angle.ToString());
    }

    /// <summary>
    /// Converts the given angles to a string in the given units
    /// </summary>
    /// <param name="angleList">List of angles to convert</param>
    /// <param name="unitType">Input unit type</param>
    /// <returns>The angle list as a string</returns>
    public static string ToString(IEnumerable<Angle> angleList, Angle.UnitType unitType)
    {
        return ValueList.ToString(angleList, (Angle angle) => angle.ToString(unitType));
    }

    /// <summary>
    /// Converts the given angles to a string with the given parameters in the current unit
    /// </summary>
    /// <param name="angleList">List of angles to convert</param>
    /// <param name="format">The format string. Can be null.</param>
    /// <param name="formatProvider">The number format provider.</param>
    /// <returns>The angle as a string</returns>
    public static string ToString(IEnumerable<Angle> angleList, string format, IFormatProvider formatProvider)
    {
        return ValueList.ToString(angleList, (Angle angle) => angle.ToString(format, formatProvider, Angle.CurrentUnitType));
    }

    /// <summary>
    /// Converts the given angles to a string with the given parameters in the current unit
    /// </summary>
    /// <param name="angleList">List of angles to convert</param>
    /// <param name="format">The format string. Can be null.</param>
    /// <param name="formatProvider">The number format provider.</param>
    /// <param name="angleUnit">The unit type.</param>
    /// <returns>The angle as a string</returns>
    public static string ToString(IEnumerable<Angle> angleList, string format, IFormatProvider formatProvider, Angle.UnitType angleUnit)
    {
        return ValueList.ToString(angleList, (Angle angle) => angle.ToString(format, formatProvider, angleUnit));
    }

    /// <summary>
    /// Parses the given text as an angle list in the current unit type
    /// </summary>
    /// <param name="text">Text to parse</param>
    /// <returns>Resulting angle list from the text</returns>
    public static List<Angle> Parse(string text)
    {
        return ValueList.Parse(text, delegate (string input, out Angle angle)
        {
            return Angle.TryParse(input, out angle);
        }).ToList();
    }

    /// <summary>
    /// Parses the given text as an angle list in the current unit type
    /// </summary>
    /// <param name="text">Text to parse</param>
    /// <param name="formatProvider">Format provider</param>
    /// <returns>Resulting angle list from the text</returns>
    public static List<Angle> Parse(string text, IFormatProvider formatProvider)
    {
        return ValueList.Parse(text, delegate (string input, out Angle angle)
        {
            return Angle.TryParse(input, formatProvider, out angle);
        }).ToList();
    }

    /// <summary>
    /// Parses the given text as an angle list in the current unit type
    /// </summary>
    /// <param name="text">Text to parse</param>
    /// <param name="formatProvider">Format provider</param>
    /// <param name="unitType">Input unit type</param>
    /// <returns>Resulting angle list from the text</returns>
    public static List<Angle> Parse(string text, IFormatProvider formatProvider, Angle.UnitType unitType)
    {
        return ValueList.Parse(text, delegate (string input, out Angle angle)
        {
            return Angle.TryParse(input, formatProvider, unitType, out angle);
        }).ToList();
    }
}
