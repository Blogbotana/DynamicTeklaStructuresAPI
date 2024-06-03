using System;
using System.ComponentModel;
using System.Globalization;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Dynamic.Tekla.Structures.Datatype;

[Serializable]
[TypeConverter(typeof(Dynamic.Tekla.Structures.Datatype.DoubleConverter))]
public struct Double : IXmlSerializable, IDoubleDataType, IDataType, IEquatable<Dynamic.Tekla.Structures.Datatype.Double>, IComparable<Dynamic.Tekla.Structures.Datatype.Double>
{
    private double _value;

    /// <summary>
    /// The value of the double datatype.
    /// </summary>
    public double Value
    {
        get => _value;
        set => _value = value;
    }

    /// <summary>
    /// Creates a new double datatype instance.
    /// </summary>
    /// <param name="value">The value for the double datatype.</param>
    public Double(double value)
    {
        _value = value;
    }

    /// <summary>
    /// Converts from Datatype.Double to double.
    /// </summary>
    /// <param name="From">The value to be converted.</param>
    /// <returns>The converted double value.</returns>
    public static implicit operator double(Dynamic.Tekla.Structures.Datatype.Double From)
    {
        return From.Value;
    }

    /// <summary>
    /// Converts from double to Datatype.Double.
    /// </summary>
    /// <param name="From">The value to be converted.</param>
    /// <returns>The converted Datatype.Double value.</returns>
    public static implicit operator Dynamic.Tekla.Structures.Datatype.Double(double From)
    {
        return new Dynamic.Tekla.Structures.Datatype.Double(From);
    }

    /// <summary>
    /// Compares a double value with a Datatype.Double value.
    /// </summary>
    /// <param name="Left">The double value to be compared.</param>
    /// <param name="Right">The Datatype.Double value to be compared.</param>
    /// <returns>True if the values are the same.</returns>
    public static bool operator ==(double Left, Dynamic.Tekla.Structures.Datatype.Double Right)
    {
        return Right.Equals(Left);
    }

    /// <summary>
    /// Compares a double value with a Datatype.Double value.
    /// </summary>
    /// <param name="Left">The double value to be compared.</param>
    /// <param name="Right">The Datatype.Double value to be compared.</param>
    /// <returns>True if the values are different.</returns>
    public static bool operator !=(double Left, Dynamic.Tekla.Structures.Datatype.Double Right)
    {
        return !Right.Equals(Left);
    }

    /// <summary>
    /// Returns a value that indicates whether the current instance is equal to the given object.
    /// </summary>
    /// <param name="Obj">The object to be used for comparing.</param>
    /// <returns>True if the given object has the same value as the current instance.</returns>
    public override bool Equals(object Obj)
    {
        if (Obj is Dynamic.Tekla.Structures.Datatype.Double)
        {
            return Equals((Dynamic.Tekla.Structures.Datatype.Double)Obj);
        }
        return Obj.GetType() == typeof(double) && Equals(new Dynamic.Tekla.Structures.Datatype.Double((double)Obj));
    }

    /// <summary>
    /// Indicates whether the current object is equal to another object of the same type.
    /// </summary>
    /// <param name="other">The object to be compared with the current object.</param>
    /// <returns>True if the current object is equal to the other object; otherwise, false.</returns>
    public bool Equals(Dynamic.Tekla.Structures.Datatype.Double other)
    {
        return Math.Abs(Value - other.Value) < 1E-06;
    }

    public int CompareTo(Dynamic.Tekla.Structures.Datatype.Double other)
    {
        return Equals(other.Value) ? 0 : Value.CompareTo(other.Value);
    }

    /// <summary>
    /// Returns the hash code for the current instance.
    /// </summary>
    /// <returns>A hash code for the current Double instance.</returns>
    public override int GetHashCode()
    {
        return Value.GetHashCode();
    }

    /// <summary>
    /// Returns the string representation of the object.
    /// </summary>
    /// <returns>The string representation of the object.</returns>
    public override string ToString()
    {
        return _value.Equals(-2147483648.0) ? string.Empty : _value.ToString(CultureInfo.InvariantCulture.NumberFormat);
    }

    /// <summary>
    /// Gets the XML Schema for the datatype.
    /// </summary>
    /// <returns>The datatype's XML Schema.</returns>
    public XmlSchema GetSchema()
    {
        throw new NotImplementedException("The method or operation is not implemented.");
    }

    /// <summary>
    /// Parses a new value from the given reader.
    /// </summary>
    /// <param name="reader">The reader to be used.</param>
    public void ReadXml(XmlReader reader)
    {
        if (!double.TryParse(reader.ReadElementString(), NumberStyles.Number, CultureInfo.InvariantCulture, out _value))
        {
            _value = 0.0;
        }
    }

    /// <summary>
    /// Writes the value as XML to the given writer.
    /// </summary>
    /// <param name="writer">The writer to be used.</param>
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteValue(_value);
    }
}
