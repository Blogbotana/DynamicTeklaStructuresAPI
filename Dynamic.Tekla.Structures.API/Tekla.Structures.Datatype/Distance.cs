using System;
using System.ComponentModel;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Dynamic.Tekla.Structures.Datatype;
[Serializable]
[TypeConverter(typeof(DistanceConverter))]
public struct Distance : IXmlSerializable, IEquatable<Distance>, IComparable<Distance>, IDoubleDataType, IDataType, IFormattable
{
    /// <summary>
    /// The distance units.
    /// </summary>
    public enum UnitType
    {
        /// <summary>
        /// The millimeter unit type.
        /// </summary>
        Millimeter,
        /// <summary>
        /// The centimeter unit type.
        /// </summary>
        Centimeter,
        /// <summary>
        /// The meter unit type.
        /// </summary>
        Meter,
        /// <summary>
        /// The inch unit type.
        /// </summary>
        Inch,
        /// <summary>
        /// The foot unit type.
        /// </summary>
        Foot
    }

    /// <summary>
    /// Conversion factor from inches to feet.
    /// </summary>
    private const double FeetPerInch = 0.083333333333333329;

    /// <summary>
    /// Conversion factor from feet to inches.
    /// </summary>
    private const double InchesPerFoot = 12.0;

    /// <summary>
    /// Conversion factor from millimeters to inches.
    /// </summary>
    private const double InchesPerMillimeter = 0.03937007874015748;

    /// <summary>
    /// Conversion factor from inches to millimeters.
    /// </summary>
    private const double MillimetersPerInch = 25.4;

    /// <summary>
    /// Maximum Fractions of an inch.
    /// </summary>
    private const int Fractions = 128;

    /// <summary>
    /// Decimal number format.
    /// </summary>
    private static readonly Regex decimalNumberFormat = new Regex("^\\s*([-+]?\\d*[.,]?\\d+([eE][-+]?\\d+)?)\\s*([^0-9\\'\\\"]*)\\s*$", RegexOptions.Compiled);

    /// <summary>
    /// Fractional number formats.
    /// </summary>
    private static readonly Regex[] fractionalNumberFormat = new Regex[3]
    {
        new Regex("^\\s*([-+]?\\d+)[^0-9]+(\\d+)/(\\d+)\\s*$", RegexOptions.Compiled),
        new Regex("^\\s*([-+]?\\d+)/(\\d+)\\s*$", RegexOptions.Compiled),
        new Regex("^\\s*([-+]?\\d*[.,]?\\d+([eE][-+]?\\d+)?)\\s*$", RegexOptions.Compiled)
    };

    /// <summary>
    /// Fractional US imperial formats.
    /// </summary>
    private static readonly Regex[] fractionalFeetAndInchesFormat = new Regex[15]
    {
        new Regex("^\\s*([-+]?\\d+)\\'[^0-9]*(\\d+)\\\"[^0-9]*(\\d+/\\d+)\\s*$", RegexOptions.Compiled),
        new Regex("^\\s*([-+]?\\d+)\\'[^0-9]*(\\d+/\\d+)\\s*$", RegexOptions.Compiled),
        new Regex("^\\s*([-+]?\\d+)\\'[^0-9]*(\\d+)[\\\"]?\\s*$", RegexOptions.Compiled),
        new Regex("^\\s*([-+]?\\d+)\\'\\s*$", RegexOptions.Compiled),
        new Regex("^\\s*([-+]?\\d+)\\\"[^0-9]*(\\d+/\\d+)\\s*$", RegexOptions.Compiled),
        new Regex("^\\s*([-+]?\\d+)\\\"\\s*$", RegexOptions.Compiled),
        new Regex("^\\s*([-+]?)[^0-9]*(\\d+/\\d+)\\s*$", RegexOptions.Compiled),
        new Regex("^\\s*([-+]?\\d+[.,]?\\d+)\\'\\s*$", RegexOptions.Compiled),
        new Regex("^\\s*([-+]?\\d+[.,]?\\d+)\\\"\\s*$", RegexOptions.Compiled),
        new Regex("^\\s*([-+]?\\d+)[-]?(\\d+)[+]?(\\d+/\\d+)\\s*$", RegexOptions.Compiled),
        new Regex("^\\s*([-+]?\\d+)[-]?(\\d+)[\\\"]?\\s*$", RegexOptions.Compiled),
        new Regex("^\\s*([-+]?\\d+)[\\']?[-]?(\\d*[\\.]?\\d*)[\\\"]?\\s*$", RegexOptions.Compiled),
        new Regex("^\\s*([-+]?\\d+)[+]?(\\d+/\\d+)\\s*$", RegexOptions.Compiled),
        new Regex("^\\s*([-+]?\\d+)[\\']?[-](\\d+)\\\"([\\.]\\d+)\\s*$", RegexOptions.Compiled),
        new Regex("^\\s*([-+]?\\d+)\\\"([\\.]\\d+)\\s*$", RegexOptions.Compiled)
    };

    /// <summary>
    /// Indicates whether to use units in decimal string representation.
    /// </summary>
    private static bool useUnitsInDecimalString;

    /// <summary>
    /// Indicates whether to use fractional format for US imperial units.
    /// </summary>
    private static bool useFractionalFormat;

    /// <summary>
    /// Distance in millimeters.
    /// </summary>
    private double millimeters;

    /// <exclude />
    public const string MILLIMETERS = "Millimeters";

    /// <summary>
    /// Gets or sets the current unit type.
    /// </summary>
    /// <value>
    /// The current unit type.
    /// </value>
    public static UnitType CurrentUnitType
    {
        get
        {
            if (Settings.TryGetValue("distance_unit", out var obj) && obj is UnitType)
            {
                return (UnitType)obj;
            }
            return UnitType.Millimeter;
        }
        set
        {
            Settings.SetValue("distance_unit", value);
        }
    }

    /// <summary>
    /// Gets or sets a boolean value indicating whether to use units in the decimal string representation.
    /// </summary>
    /// <value>
    /// Indicates whether to use units in the decimal string representation.
    /// </value>

    public static bool UseUnitsInDecimalString
    {
        get
        {
            return useUnitsInDecimalString;
        }
        set
        {
            useUnitsInDecimalString = value;
        }
    }

    /// <summary>
    /// Gets or sets a boolean value indicating whether to use the fractional format for US imperial units.
    /// </summary>
    /// <value>
    /// Indicates whether to use the fractional format for US imperial units.
    /// </value>
    public static bool UseFractionalFormat
    {
        get
        {
            return useFractionalFormat;
        }
        set
        {
            useFractionalFormat = value;
        }
    }

    /// <summary>
    /// Gets or sets the distance in millimeters.
    /// </summary>
    /// <value>
    /// The distance in millimeters.
    /// </value>
    public double Millimeters
    {
        get
        {
            return millimeters;
        }
        set
        {
            millimeters = value;
        }
    }

    /// <summary>
    /// Gets or sets the distance value in current units.
    /// </summary>
    /// <value>
    /// The distance value in current units.
    /// </value>
    [XmlIgnore]
    public double Value
    {
        get
        {
            return ConvertMillimetersTo(millimeters, CurrentUnitType);
        }
        set
        {
            millimeters = ConvertToMillimeters(value, CurrentUnitType);
        }
    }

    /// <summary>
    /// Gets the number of decimal places used for distances.
    /// </summary>
    /// <value>
    /// Number of decimal places used for distances.
    /// </value>
    private static int? DecimalPlaces
    {
        get
        {
            if (Settings.TryGetValue("distance_decimals", out var obj) && obj is int)
            {
                return (int)obj;
            }
            return null;
        }
    }

    /// <summary>
    /// Initializes a new instance of the structure.
    /// </summary>
    /// <param name="millimeters">The distance in millimeters.</param>
    public Distance(double millimeters)
    {
        this.millimeters = millimeters;
    }

    /// <summary>
    /// Initializes a new instance of the structure.
    /// </summary>
    /// <param name="distance">The distance in the specified units.</param>
    /// <param name="unitType">The distance unit type.</param>
    /// <exception cref="T:System.ArgumentException">Thrown if an invalid unit type is specified.</exception>
    public Distance(double distance, UnitType unitType)
    {
        millimeters = ConvertToMillimeters(distance, unitType);
    }

    /// <summary>
    /// Returns the hash code for the current instance.
    /// </summary>
    /// <returns>A 32-bit signed integer that is the hash code for the current instance.</returns>
    public override int GetHashCode()
    {
        return millimeters.GetHashCode();
    }

    /// <summary>
    /// Indicates whether the current instance and the specified object are equal.
    /// </summary>
    /// <param name="obj">The object to be compared with the current object.</param>
    /// <returns>True if the specified object and the current instance are of the same type and represent the same value; otherwise, false.</returns>
    public override bool Equals(object obj)
    {
        if (obj is Distance)
        {
            return Equals((Distance)obj);
        }
        return false;
    }

    /// <summary>
    /// Indicates whether the current object is equal to another object of the same type.
    /// </summary>
    /// <param name="other">The object to be compared with the current object.</param>
    /// <returns>True if the current object is equal to the other object; otherwise, false.</returns>
    public bool Equals(Distance other)
    {
        if (UseFractionalFormat)
        {
            return Math.Abs(millimeters - other.millimeters) < 0.0001;
        }
        return Math.Abs(millimeters - other.millimeters) < 1E-06;
    }

    /// <summary>
    /// Compares the current object with another object of the same type.
    /// </summary>
    public int CompareTo(Distance other)
    {
        if (Equals(other))
        {
            return 0;
        }
        return millimeters.CompareTo(other.millimeters);
    }

    /// <summary>
    /// Converts the distance to the specified units.
    /// </summary>
    /// <param name="unitType">The distance unit type.</param>
    /// <returns>The distance in the specified units.</returns>
    public double ConvertTo(UnitType unitType)
    {
        return ConvertMillimetersTo(millimeters, unitType);
    }

    /// <summary>
    /// Creates a distance from a decimal string representation.
    /// </summary>
    /// <param name="text">The distance string.</param>
    /// <returns>The representation of the specified distance.</returns>
    /// <exception cref="T:System.FormatException">Thrown if the text does not represent a distance.</exception>
    public static Distance FromDecimalString(string text)
    {
        return FromDecimalString(text, null, CurrentUnitType);
    }

    /// <summary>
    /// Creates a distance from a decimal string representation.
    /// </summary>
    /// <param name="text">The distance string.</param>
    /// <param name="formatProvider">The number format provider.</param>
    /// <returns>The representation of the specified distance.</returns>
    /// <exception cref="T:System.FormatException">Thrown if the text does not represent a distance.</exception>
    public static Distance FromDecimalString(string text, IFormatProvider formatProvider)
    {
        return FromDecimalString(text, formatProvider, CurrentUnitType);
    }

    /// <summary>
    /// Creates a distance from a decimal string representation.
    /// </summary>
    /// <param name="text">The distance string.</param>
    /// <param name="formatProvider">The number format provider.</param>
    /// <param name="unitType">The unit type of the distance to parse.</param>
    /// <returns>The representation of the specified distance.</returns>
    /// <exception cref="T:System.FormatException">Thrown if the text does not represent a distance.</exception>
    /// <exception cref="T:System.ArgumentException">Thrown if an invalid unit type is specified.</exception>
    public static Distance FromDecimalString(string text, IFormatProvider formatProvider, UnitType unitType)
    {
        if (string.IsNullOrEmpty(text))
        {
            return default(Distance);
        }
        Match match = decimalNumberFormat.Match(text);
        if (match.Success)
        {
            double num = ParseNumberAsDouble(match.Groups[1].Value, NumberStyles.Float, formatProvider);
            int? decimalPlaces = DecimalPlaces;
            if (decimalPlaces.HasValue)
            {
                num = Math.Round(num, decimalPlaces.Value);
            }
            return match.Groups[3].Value switch
            {
                "mm" => new Distance(num, UnitType.Millimeter),
                "cm" => new Distance(num, UnitType.Centimeter),
                "m" => new Distance(num, UnitType.Meter),
                "in" => new Distance(num, UnitType.Inch),
                "ft" => new Distance(num, UnitType.Foot),
                _ => new Distance(num, unitType),
            };
        }
        throw new FormatException();
    }

    /// <summary>
    /// Converts the distance to a decimal string representation.
    /// </summary>
    /// <returns>The string representation of the distance.</returns>
    public string ToDecimalString()
    {
        return ToDecimalString(null, null, CurrentUnitType);
    }

    /// <summary>
    /// Converts the distance to a decimal string representation.
    /// </summary>
    /// <param name="format">The format string.</param>
    /// <returns>The string representation of the distance.</returns>
    public string ToDecimalString(string format)
    {
        return ToDecimalString(format, null, CurrentUnitType);
    }

    /// <summary>
    /// Converts the distance to a decimal string representation.
    /// </summary>
    /// <param name="formatProvider">The number format provider.</param>
    /// <returns>The string representation of the distance.</returns>
    public string ToDecimalString(IFormatProvider formatProvider)
    {
        return ToDecimalString(null, formatProvider, CurrentUnitType);
    }

    /// <summary>
    /// Converts the distance to a decimal string representation.
    /// </summary>
    /// <param name="format">The format string.</param>
    /// <param name="formatProvider">The number format provider.</param>
    /// <returns>The string representation of the distance.</returns>
    public string ToDecimalString(string format, IFormatProvider formatProvider)
    {
        return ToDecimalString(format, formatProvider, CurrentUnitType);
    }

    /// <summary>
    /// Converts the distance to a decimal string representation.
    /// </summary>
    /// <param name="format">The format string.</param>
    /// <param name="formatProvider">The number format provider.</param>
    /// <param name="unitType">The unit type.</param>
    /// <returns>The string representation of the distance.</returns>
    /// <exception cref="T:System.ArgumentException">Thrown if an invalid unit type is specified.</exception>

    public string ToDecimalString(string format, IFormatProvider formatProvider, UnitType unitType)
    {
        if (millimeters == -2147483648.0)
        {
            return string.Empty;
        }
        if (format == null)
        {
            int? decimalPlaces = DecimalPlaces;
            if (decimalPlaces.HasValue)
            {
                format = "F" + decimalPlaces.Value;
            }
        }
        double num = ConvertMillimetersTo(millimeters, unitType);
        if (useUnitsInDecimalString)
        {
            return unitType switch
            {
                UnitType.Millimeter => num.ToString(format, formatProvider) + "mm",
                UnitType.Centimeter => num.ToString(format, formatProvider) + "cm",
                UnitType.Meter => num.ToString(format, formatProvider) + "m",
                UnitType.Inch => num.ToString(format, formatProvider) + "in",
                UnitType.Foot => num.ToString(format, formatProvider) + "ft",
                _ => throw new ArgumentException("Invalid unit type.", "unitType"),
            };
        }
        return num.ToString(format, formatProvider);
    }

    /// <summary>
    /// Creates a distance from a string representation of fractional feet and inches.
    /// </summary>
    /// <param name="text">The distance string.</param>
    /// <returns>The representation of the specified distance.</returns>
    /// <exception cref="T:System.FormatException">Thrown if the text does not represent a distance.</exception>

    public static Distance FromFractionalFeetAndInchesString(string text)
    {
        return FromFractionalFeetAndInchesString(text, null, CurrentUnitType);
    }

    /// <summary>
    /// Creates a distance from a string representation of fractional feet and inches.
    /// </summary>
    /// <param name="text">The distance string.</param>
    /// <param name="formatProvider">The number format provider.</param>
    /// <param name="unitType">The unit type of the distance to parse.</param>
    /// <returns>The representation of the specified distance.</returns>
    /// <exception cref="T:System.FormatException">Thrown if the text does not represent a distance.</exception>

    public static Distance FromFractionalFeetAndInchesString(string text, IFormatProvider formatProvider, UnitType unitType)
    {
        bool flag = false;
        if (string.IsNullOrEmpty(text))
        {
            return new Distance(-2147483648.0);
        }
        string text2 = text.TrimStart(' ');
        if (text2.StartsWith("-"))
        {
            flag = true;
            text2 = text2.Remove(text2.IndexOf("-"), 1);
        }
        if (text2.EndsWith("-"))
        {
            text2 = text2.Remove(text2.LastIndexOf("-"), 1);
            if (!text2.EndsWith("'"))
            {
                text2 += "'";
            }
        }
        if (!text2.Contains("/") && !text2.Contains("\"") && !text2.EndsWith("'") && !text2.Contains("-"))
        {
            if (unitType == UnitType.Inch)
            {
                text2 += "\"";
            }
            if (unitType == UnitType.Foot)
            {
                text2 += "'";
            }
        }
        if (unitType == UnitType.Inch || unitType == UnitType.Foot)
        {
            for (int i = 0; i < fractionalFeetAndInchesFormat.Length; i++)
            {
                Match match = fractionalFeetAndInchesFormat[i].Match(text2);
                if (match.Success)
                {
                    double num = 0.0;
                    double num2 = 0.0;
                    double num3 = 0.0;
                    switch (i)
                    {
                        case 0:
                        case 13:
                            num = ParseNumberAsInt(match.Groups[1].Value, NumberStyles.Integer, formatProvider);
                            num2 = ParseNumberAsInt(match.Groups[2].Value, NumberStyles.Integer, formatProvider);
                            num3 = ParseFractionalDouble(match.Groups[3].Value, formatProvider, UnitType.Inch);
                            break;
                        case 1:
                            num = ParseNumberAsInt(match.Groups[1].Value, NumberStyles.Integer, formatProvider);
                            num3 = ParseFractionalDouble(match.Groups[2].Value, formatProvider, UnitType.Inch);
                            break;
                        case 2:
                            num = ParseNumberAsInt(match.Groups[1].Value, NumberStyles.Integer, formatProvider);
                            num2 = ParseNumberAsInt(match.Groups[2].Value, NumberStyles.Integer, formatProvider);
                            break;
                        case 3:
                            num = ParseNumberAsInt(match.Groups[1].Value, NumberStyles.Integer, formatProvider);
                            break;
                        case 4:
                        case 12:
                        case 14:
                            num2 = ParseNumberAsInt(match.Groups[1].Value, NumberStyles.Integer, formatProvider);
                            num3 = ParseFractionalDouble(match.Groups[2].Value, formatProvider, UnitType.Inch);
                            break;
                        case 5:
                            num2 = ParseNumberAsInt(match.Groups[1].Value, NumberStyles.Integer, formatProvider);
                            break;
                        case 6:
                            num3 = ParseFractionalDouble(match.Groups[2].Value, formatProvider, UnitType.Inch);
                            break;
                        case 7:
                            num = ParseNumberAsDouble(match.Groups[1].Value, NumberStyles.Float, formatProvider);
                            break;
                        case 8:
                            num2 = ParseNumberAsDouble(match.Groups[1].Value, NumberStyles.Float, formatProvider);
                            break;
                        case 9:
                            num = ParseNumberAsInt(match.Groups[1].Value, NumberStyles.Integer, formatProvider);
                            num2 = ParseNumberAsInt(match.Groups[2].Value, NumberStyles.Integer, formatProvider);
                            num3 = ParseFractionalDouble(match.Groups[3].Value, formatProvider, UnitType.Inch);
                            break;
                        case 10:
                            num = ParseNumberAsInt(match.Groups[1].Value, NumberStyles.Integer, formatProvider);
                            num2 = ParseNumberAsInt(match.Groups[2].Value, NumberStyles.Integer, formatProvider);
                            break;
                        case 11:
                            num = ParseNumberAsInt(match.Groups[1].Value, NumberStyles.Integer, formatProvider);
                            num2 = ParseNumberAsDouble(match.Groups[2].Value, NumberStyles.Float, formatProvider);
                            break;
                    }
                    double num4 = num * 12.0 + num2 + num3;
                    if (flag)
                    {
                        num4 *= -1.0;
                    }
                    return new Distance(num4, UnitType.Inch);
                }
            }
        }
        return FromDecimalString(text, formatProvider, unitType);
    }

    /// <summary>
    /// Creates a string representation of the distance in feet and inches.
    /// </summary>
    /// <returns>The string representation of the distance.</returns>
    public string ToFractionalFeetAndInchesString()
    {
        return ToFractionalFeetAndInchesString(null);
    }

    /// <summary>
    /// Creates a string representation of the distance in feet and inches.
    /// </summary>
    /// <param name="formatProvider">The number format provider.</param>
    /// <returns>The string representation of the distance.</returns>
    public string ToFractionalFeetAndInchesString(IFormatProvider formatProvider)
    {
        if (millimeters == -2147483648.0)
        {
            return string.Empty;
        }
        double num = Math.Abs(ConvertMillimetersTo(millimeters, UnitType.Inch));
        int num2 = (int)Math.Truncate(num / 12.0);
        double num3 = num - (double)num2 * 12.0;
        int num4 = (int)Math.Truncate(num3);
        int num5 = (int)Math.Round((num3 - (double)num4) * 128.0);
        int num6 = 128;
        num4 += num5 / num6;
        num5 %= num6;
        num2 += num4 / 12;
        num4 %= 12;
        while (num5 > 1 && num5 % 2 == 0 && num6 > 1 && num6 % 2 == 0)
        {
            num5 /= 2;
            num6 /= 2;
        }
        if (num2 == 0 && num4 == 0 && num5 == 0)
        {
            return "0\"";
        }
        string text = string.Empty;
        if (millimeters < 0.0)
        {
            text += "-";
        }
        if (num2 > 0)
        {
            text = text + num2.ToString(formatProvider) + "'";
            if (num4 >= 0)
            {
                text += "-";
            }
        }
        if (num4 >= 0 || (num2 > 0 && num5 > 0))
        {
            text = text + num4.ToString(formatProvider) + "\"";
        }
        if (num5 > 0)
        {
            text += num5.ToString(formatProvider);
            text += "/";
            text += num6.ToString(formatProvider);
        }
        return text;
    }

    /// <summary>
    /// Creates a string representation of the distance in inches.
    /// </summary>
    /// <returns>The string representation of the distance.</returns>
    public string ToFractionalInchesString()
    {
        return ToFractionalInchesString(null);
    }

    /// <summary>
    /// Creates a string representation of the distance in inches.
    /// </summary>
    /// <param name="formatProvider">The number format provider.</param>
    /// <returns>The string representation of the distance.</returns>
    public string ToFractionalInchesString(IFormatProvider formatProvider)
    {
        if (millimeters == -2147483648.0)
        {
            return string.Empty;
        }
        double num = Math.Abs(ConvertMillimetersTo(millimeters, UnitType.Inch));
        int num2 = (int)Math.Truncate(num);
        int num3 = (int)Math.Round((num - (double)num2) * 128.0);
        int num4 = 128;
        num2 += num3 / num4;
        num3 %= num4;
        while (num3 > 1 && num3 % 2 == 0 && num4 > 1 && num4 % 2 == 0)
        {
            num3 /= 2;
            num4 /= 2;
        }
        if (num2 == 0 && num3 == 0)
        {
            return "0\"";
        }
        string text = string.Empty;
        if (millimeters < 0.0)
        {
            text += "-";
        }
        if (num2 >= 0)
        {
            text = text + num2.ToString(formatProvider) + "\"";
        }
        if (num3 > 0)
        {
            text += num3.ToString(formatProvider);
            text += "/";
            text += num4.ToString(formatProvider);
        }
        return text;
    }

    /// <summary>
    /// Parses a distance from a string representation using the current unit type and culture.
    /// </summary>
    /// <param name="text">The text to parse.</param>
    /// <returns>The representation of the specified distance.</returns>
    /// <exception cref="T:System.FormatException">Thrown if the text does not represent a distance.</exception>
    public static Distance Parse(string text)
    {
        try
        {
            return Parse(text, null);
        }
        catch (FormatException)
        {
            return Parse(text, CultureInfo.InvariantCulture);
        }
    }

    /// <summary>
    /// Parses a distance from a string representation using the current unit type and the given culture.
    /// </summary>
    /// <param name="text">The text to parse.</param>
    /// <param name="formatProvider">The number format provider.</param>
    /// <returns>The representation of the specified distance.</returns>
    /// <exception cref="T:System.FormatException">Thrown if the text does not represent a distance.</exception>
    public static Distance Parse(string text, IFormatProvider formatProvider)
    {
        return Parse(text, formatProvider, CurrentUnitType);
    }

    /// <summary>
    /// Parses a distance from a string representation using the given unit type and culture.
    /// </summary>
    /// <param name="text">The text to parse.</param>
    /// <param name="formatProvider">The number format provider.</param>
    /// <param name="unitType">The unit type of the distance to parse. Determines the parsing process.</param>
    /// <returns>The representation of the specified distance.</returns>
    /// <exception cref="T:System.FormatException">Thrown if the text does not represent a distance.</exception>
    /// <exception cref="T:System.ArgumentException">Thrown if an invalid unit type is specified.</exception>
    public static Distance Parse(string text, IFormatProvider formatProvider, UnitType unitType)
    {
        if (formatProvider == null)
        {
            formatProvider = CultureInfo.InvariantCulture;
        }
        return FromFractionalFeetAndInchesString(text, formatProvider, unitType);
    }

    /// <summary>
    /// Attempts to parse a distance from a string representation using the current units.
    /// </summary>
    /// <param name="text">The text to parse.</param>
    /// <param name="result">The output variable for the result.</param>
    /// <returns>A boolean value indicating whether the operation succeeded.</returns>
    public static bool TryParse(string text, out Distance result)
    {
        try
        {
            result = Parse(text);
            return true;
        }
        catch (FormatException)
        {
            result = default(Distance);
            return false;
        }
    }

    /// <summary>
    /// Attempts to parse a distance from a string representation using the current units.
    /// </summary>
    /// <param name="text">The text to parse.</param>
    /// <param name="formatProvider">The number format provider.</param>
    /// <param name="result">The output variable for the result.</param>
    /// <returns>A boolean value indicating whether the operation succeeded.</returns>
    public static bool TryParse(string text, IFormatProvider formatProvider, out Distance result)
    {
        try
        {
            result = Parse(text, formatProvider);
            return true;
        }
        catch (FormatException)
        {
            result = default(Distance);
            return false;
        }
    }

    /// <summary>
    /// Attempts to parse a distance from a string representation using the current units.
    /// </summary>
    /// <param name="text">The text to parse.</param>
    /// <param name="formatProvider">The number format provider.</param>
    /// <param name="defaultUnitType">The default unit type if the unit cannot be determined.</param>
    /// <param name="result">The output variable for the result.</param>
    /// <returns>A boolean value indicating whether the operation succeeded.</returns>
    /// <exception cref="T:System.ArgumentException">Thrown if an invalid unit type is specified.</exception>
    public static bool TryParse(string text, IFormatProvider formatProvider, UnitType defaultUnitType, out Distance result)
    {
        try
        {
            result = Parse(text, formatProvider, defaultUnitType);
            return true;
        }
        catch (FormatException)
        {
            result = default(Distance);
            return false;
        }
    }

    /// <summary>
    /// Creates a string representation of the distance.
    /// </summary>
    /// <returns>The string representation of the distance using CultureInfo.InvariantCulture.</returns>
    public override string ToString()
    {
        return ToString(null, CultureInfo.InvariantCulture, CurrentUnitType);
    }

    /// <summary>
    /// Creates a string representation of the distance.
    /// </summary>
    /// <param name="format">The format string.</param>
    /// <returns>The string representation of the distance.</returns>
    public string ToString(string format)
    {
        return ToString(format, null, CurrentUnitType);
    }

    /// <summary>
    /// Creates a string representation of the distance.
    /// </summary>
    /// <param name="formatProvider">The number format provider.</param>
    /// <returns>The string representation of the distance.</returns>
    public string ToString(IFormatProvider formatProvider)
    {
        return ToString(null, formatProvider, CurrentUnitType);
    }

    /// <summary>
    /// Creates a string representation of the distance.
    /// </summary>
    /// <param name="format">The format string.</param>
    /// <param name="formatProvider">The number format provider.</param>
    /// <returns>The string representation of the distance.</returns>
    public string ToString(string format, IFormatProvider formatProvider)
    {
        return ToString(format, formatProvider, CurrentUnitType);
    }

    /// <summary>
    /// Creates a string representation of the distance.
    /// </summary>
    /// <param name="format">The format string.</param>
    /// <param name="formatProvider">The number format provider.</param>
    /// <param name="unitType">The unit type.</param>
    /// <returns>The string representation of the distance.</returns>
    /// <exception cref="T:System.ArgumentException">Thrown if an invalid unit type is specified.</exception>
    public string ToString(string format, IFormatProvider formatProvider, UnitType unitType)
    {
        if (millimeters.Equals(-2147483648.0))
        {
            return string.Empty;
        }
        if (UseFractionalFormat && (unitType == UnitType.Inch || unitType == UnitType.Foot))
        {
            return ToFractionalFeetAndInchesString(formatProvider);
        }
        return ToDecimalString(format, formatProvider, unitType);
    }

    /// <summary>
    /// Parses a fractional representation of a double precision floating point number.
    /// </summary>
    /// <param name="text">The text to parse.</param>
    /// <param name="formatProvider">The number format provider.</param>
    /// <param name="unitType">The unit type to parse to.</param>
    /// <returns>The parsed double value.</returns>
    /// <exception cref="T:System.FormatException">Thrown if the text does not represent a double value.</exception>
    private static double ParseFractionalDouble(string text, IFormatProvider formatProvider, UnitType unitType)
    {
        if (string.IsNullOrEmpty(text))
        {
            return 0.0;
        }
        for (int i = 0; i < fractionalNumberFormat.Length; i++)
        {
            Match match = fractionalNumberFormat[i].Match(text);
            if (!match.Success)
            {
                continue;
            }
            double num = 0.0;
            double num2 = 0.0;
            double num3 = 1.0;
            switch (i)
            {
                case 0:
                    num = ParseNumberAsInt(match.Groups[1].Value, NumberStyles.Integer, formatProvider);
                    num2 = ParseNumberAsInt(match.Groups[2].Value, NumberStyles.Integer, formatProvider);
                    num3 = ParseNumberAsInt(match.Groups[3].Value, NumberStyles.Integer, formatProvider);
                    break;
                case 1:
                    num2 = ParseNumberAsInt(match.Groups[1].Value, NumberStyles.Integer, formatProvider);
                    num3 = ParseNumberAsInt(match.Groups[2].Value, NumberStyles.Integer, formatProvider);
                    if (unitType == UnitType.Foot)
                    {
                        num3 *= 12.0;
                    }
                    break;
                case 2:
                    num = ParseNumberAsDouble(text, NumberStyles.Float, formatProvider);
                    break;
            }
            return num + num2 / num3;
        }
        return ParseNumberAsDouble(text, NumberStyles.Float, formatProvider);
    }

    /// <summary>
    /// Converts the specified distance units to millimeters.
    /// </summary>
    /// <param name="distance">The distance in specified units.</param>
    /// <param name="unitType">The distance unit type.</param>
    /// <returns>The converted distance.</returns>
    /// <exception cref="T:System.ArgumentException">Thrown if an invalid unit type is specified.</exception>
    private static double ConvertToMillimeters(double distance, UnitType unitType)
    {
        return unitType switch
        {
            UnitType.Millimeter => distance,
            UnitType.Centimeter => distance * 10.0,
            UnitType.Meter => distance * 1000.0,
            UnitType.Inch => distance * 25.4,
            UnitType.Foot => distance * 12.0 * 25.4,
            _ => throw new ArgumentException("Invalid unit type.", "unitType"),
        };
    }

    /// <summary>
    /// Converts millimeters to the specified distance units.
    /// </summary>
    /// <param name="millimeters">The distance in millimeters.</param>
    /// <param name="unitType">The target unit type.</param>
    /// <returns>The converted distance.</returns>
    /// <exception cref="T:System.ArgumentException">Thrown if an invalid unit type is specified.</exception>
    private static double ConvertMillimetersTo(double millimeters, UnitType unitType)
    {
        return unitType switch
        {
            UnitType.Millimeter => millimeters,
            UnitType.Centimeter => millimeters / 10.0,
            UnitType.Meter => millimeters / 1000.0,
            UnitType.Inch => millimeters * 0.03937007874015748,
            UnitType.Foot => millimeters * 0.03937007874015748 * 0.083333333333333329,
            _ => throw new ArgumentException("Invalid unit type.", "unitType"),
        };
    }

    /// <summary>
    /// Try and parse the number string into integer.
    /// </summary>
    /// <param name="value">The string value to be parsed.</param>
    /// <param name="style">The number style.</param>
    /// <param name="format">The format provider.</param>
    /// <returns>The parsed integer value as a <see cref="T:Dynamic.Tekla.Structures.Datatype.Double" />.</returns>
    private static double ParseNumberAsInt(string value, NumberStyles style, IFormatProvider format)
    {
        if (int.TryParse(value, style, format, out var result))
        {
            return result;
        }
        throw new FormatException("value");
    }

    /// <summary>
    /// Parse number as double.
    /// </summary>
    /// <param name="value">The string value to be parsed.</param>
    /// <param name="style">The number style.</param>
    /// <param name="format">The format provider.</param>
    /// <returns>The parsed value as a <see cref="T:Dynamic.Structures.Datatype.Double" />.</returns>
    private static double ParseNumberAsDouble(string value, NumberStyles style, IFormatProvider format)
    {
        if (double.TryParse(value, style, format, out var result))
        {
            return result;
        }
        throw new FormatException("value");
    }
    /// <exclude />
	public XmlSchema GetSchema()
    {
        throw new Exception("The method or operation is not implemented.");
    }

    /// <exclude />
    public void GetXmlElement(XmlReader reader)
    {
        if (!double.TryParse(reader.ReadElementString(), NumberStyles.Float, CultureInfo.InvariantCulture, out millimeters))
        {
            millimeters = 0.0;
        }
    }

    /// <exclude />
    public void ReadXml(XmlReader reader)
    {
        reader.ReadStartElement();
        GetXmlElement(reader);
        reader.ReadEndElement();
    }

    /// <exclude />
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement("Millimeters");
        writer.WriteValue(millimeters);
        writer.WriteEndElement();
    }
}
