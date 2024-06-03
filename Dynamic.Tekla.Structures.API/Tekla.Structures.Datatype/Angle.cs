using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic.Tekla.Structures.Datatype;
/// <summary>
/// Provides support for angles using either the current Tekla Structures units, or user defined units
/// </summary>
public class Angle : IFormattable, IComparable<Angle>, IEquatable<Angle>
{
    /// <summary>
    /// The angle units.
    /// </summary>
    public enum UnitType
    {
        /// <summary>
        /// Represents an angle in degrees, with 0 degrees representing the empty angle and 360 the full angle
        /// </summary>
        Degrees,
        /// <summary>
        /// Represents an angle in radians, with 0 radians representing the empty angle and 2*PI the full angle
        /// </summary>
        Radians
    }
    /// <summary>
	/// The constant to obtain radians from a value in degrees
	/// </summary>
	private const double ToRadiansMultiplier = Math.PI / 180.0;

    /// <summary>
    /// The constant to obtain degrees from a value in radians
    /// </summary>
    private const double ToDegreesMultiplier = 180.0 / Math.PI;

    /// <summary>
    /// Gets or sets the Tekla Structures current angle type
    /// </summary>
    public static UnitType CurrentUnitType
    {
        get
        {
            if (Settings.TryGetValue("angle_unit", out UnitType obj))
            {
                return obj;
            }
            return UnitType.Degrees;
        }
        set
        {
            Settings.SetValue("angle_unit", value);
        }
    }

    /// <summary>
    /// Gets the number of decimal places used for angles.
    /// </summary>
    public static int DecimalPlaces
    {
        get
        {
            if (Settings.TryGetValue("angle_decimals", out int obj))
            {
                return obj;
            }
            return 2;
        }
        set
        {
            Settings.SetValue("angle_decimals", value);
        }
    }

    /// <summary>
    /// Gets the angle value in degrees
    /// </summary>
    public double Degrees { get; }

    /// <summary>
    /// Gets the angle value in radians
    /// </summary>
    public double Radians => Degrees * (Math.PI / 180.0);

    /// <summary>
    /// Gets the value of the angle in the current unit
    /// </summary>
    public double CurrentUnitValue
    {
        get
        {
            if (CurrentUnitType == UnitType.Radians)
            {
                return Radians;
            }
            return Degrees;
        }
    }

    /// <summary>
    /// Constructs an angle instance with an angle in degrees
    /// </summary>
    /// <param name="degrees">Angle value in degrees.</param>
    private Angle(double degrees)
    {
        Degrees = degrees;
    }

    /// <summary>
    /// Creates an angle from a value in degrees
    /// </summary>
    /// <param name="degrees">The angle in degrees</param>
    /// <returns>An Angle object representing the given angle</returns>
    public static Angle FromDegrees(double degrees)
    {
        return new Angle(degrees);
    }

    /// <summary>
    /// Creates an angle from a value in radians
    /// </summary>
    /// <param name="radians">The angle in radians</param>
    /// <returns>An Angle object representing the given angle</returns>
    public static Angle FromRadians(double radians)
    {
        return new Angle(radians * (180.0 / Math.PI));
    }

    /// <summary>
    /// Creates an angle given in the current unit type
    /// </summary>
    /// <param name="angle">Angle given in the current unit type</param>
    /// <returns>An Angle object representing the given angle</returns>
    public static Angle FromCurrentUnit(double angle)
    {
        if (CurrentUnitType == UnitType.Radians)
        {
            return FromRadians(angle);
        }
        return FromDegrees(angle);
    }

    /// <summary>
    /// Parses the given text as an angle in the current unit type
    /// </summary>
    /// <param name="text">Text to parse</param>
    /// <returns>Resulting angle from the text</returns>
    public static Angle Parse(string text)
    {
        return Parse(text, CultureInfo.CurrentCulture, CurrentUnitType);
    }

    /// <summary>
    /// Parses the given text as an angle in the current unit type
    /// </summary>
    /// <param name="text">Text to parse</param>
    /// <param name="formatProvider">Format provider</param>
    /// <returns>Resulting angle from the text</returns>
    public static Angle Parse(string text, IFormatProvider formatProvider)
    {
        return Parse(text, formatProvider, CurrentUnitType);
    }

    /// <summary>
    /// Parses the given text as an angle in the current unit type
    /// </summary>
    /// <param name="text">Text to parse</param>
    /// <param name="formatProvider">Format provider</param>
    /// <param name="unitType">Input unit type</param>
    /// <returns>Resulting angle from the text</returns>
    public static Angle Parse(string text, IFormatProvider formatProvider, UnitType unitType)
    {
        double num = double.Parse(text, NumberStyles.Float, formatProvider);
        if (unitType == UnitType.Radians)
        {
            return FromRadians(num);
        }
        return FromDegrees(num);
    }

    /// <summary>
    /// Parses the given text as an angle in the current unit type
    /// </summary>
    /// <param name="text">Text to parse</param>
    /// <param name="result">Resulting angle if success</param>
    /// <returns>True if the conversion succeeds, false otherwise</returns>
    public static bool TryParse(string text, out Angle result)
    {
        return TryParse(text, CultureInfo.CurrentCulture, CurrentUnitType, out result);
    }

    /// <summary>
    /// Parses the given text as an angle in the current unit type
    /// </summary>
    /// <param name="text">Text to parse</param>
    /// <param name="formatProvider">Format provider</param>
    /// <param name="result">Resulting angle if success</param>
    /// <returns>True if the conversion succeeds, false otherwise</returns>
    public static bool TryParse(string text, IFormatProvider formatProvider, out Angle result)
    {
        return TryParse(text, formatProvider, CurrentUnitType, out result);
    }

    /// <summary>
    /// Parses the given text as an angle in the current unit type
    /// </summary>
    /// <param name="text">Text to parse</param>
    /// <param name="formatProvider">Format provider</param>
    /// <param name="unitType">Input unit type</param>
    /// <param name="result">Resulting angle if success</param>
    /// <returns>True if the conversion succeeds, false otherwise</returns>
    public static bool TryParse(string text, IFormatProvider formatProvider, UnitType unitType, out Angle result)
    {
        if (!double.TryParse(text, NumberStyles.Float, formatProvider, out var result2))
        {
            result = FromDegrees(0.0);
            return false;
        }
        if (unitType == UnitType.Radians)
        {
            result = FromRadians(result2);
        }
        else
        {
            result = FromDegrees(result2);
        }
        return true;
    }

    /// <summary>
    /// Converts the represented angle to a string in the current units
    /// </summary>
    /// <returns>This angle as a string</returns>
    public override string ToString()
    {
        return ToString(null, CultureInfo.CurrentCulture, CurrentUnitType);
    }

    /// <summary>
    /// Converts the represented angle to a string in the given units
    /// </summary>
    /// <param name="unitType">Input unit type</param>
    /// <returns>This angle as a string</returns>
    public string ToString(UnitType unitType)
    {
        return ToString(null, CultureInfo.CurrentCulture, unitType);
    }

    /// <summary>
    /// Converts the represented angle to a string with the given parameters
    /// </summary>
    /// <param name="format">The format string. Can be null.</param>
    /// <param name="formatProvider">The number format provider.</param>
    /// <returns>This angle as a string</returns>
    public string ToString(string format, IFormatProvider formatProvider)
    {
        return ToString(format, formatProvider, CurrentUnitType);
    }

    /// <summary>
    /// Converts the represented angle to a string with the given parameters
    /// </summary>
    /// <param name="format">The format string. Can be null.</param>
    /// <param name="formatProvider">The number format provider.</param>
    /// <param name="angleUnit">The unit type.</param>
    /// <returns>This angle as a string</returns>
    public string ToString(string format, IFormatProvider formatProvider, UnitType angleUnit)
    {
        string text = format;
        if (string.IsNullOrEmpty(format))
        {
            text = "F" + DecimalPlaces;
        }
        double num = Degrees;
        if (angleUnit == UnitType.Radians)
        {
            num *= Math.PI / 180.0;
        }
        return num.ToString(text, formatProvider);
    }

    /// <summary>
    /// Compares this angle with another angle
    /// </summary>
    /// <param name="other">Angle to compare to</param>
    /// <returns>Greater than zero if this angle is greater than <paramref name="other" />, otherwise less than zero
    /// if this angle is less than <paramref name="other" />, otherwise 0 if they are equal</returns>
    public int CompareTo(Angle other)
    {
        if (Equals(other))
        {
            return 0;
        }
        return Degrees.CompareTo(other.Degrees);
    }

    /// <summary>
    /// Checks for approximate angle equality
    /// </summary>
    /// <param name="other">Angle to compare to</param>
    /// <returns>True if the angles are the same, false otherwise</returns>
    public bool Equals(Angle other)
    {
        Angle angle = FromCurrentUnit(Math.Pow(10.0, -1.0 * (double)DecimalPlaces) / 2.0);
        return Math.Abs(Degrees - other.Degrees) < angle.Degrees;
    }
}
