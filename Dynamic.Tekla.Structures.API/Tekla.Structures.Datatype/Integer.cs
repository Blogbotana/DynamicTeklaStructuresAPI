using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Xml;
using System.Xml.Serialization;

namespace Dynamic.Tekla.Structures.Datatype;
[Serializable]
[TypeConverter(typeof(IntegerConverter))]
public struct Integer : IXmlSerializable, IIntDataType, IDataType
{
    private int _value;

    /// <summary>
    /// The value of the integer datatype.
    /// </summary>
    public int Value
    {
        get
        {
            return _value;
        }
        set
        {
            _value = value;
        }
    }

    /// <summary>
    /// Creates a new integer datatype instance.
    /// </summary>
    /// <param name="value">The value for the integer datatype.</param>
    public Integer(int value)
    {
        _value = value;
    }

    /// <summary>
    /// Converts from Datatype.Integer to int.
    /// </summary>
    /// <param name="From">The value to be converted.</param>
    /// <returns>The converted int value.</returns>
    public static implicit operator int(Integer From)
    {
        return From.Value;
    }

    /// <summary>
    /// Converts from int to Datatype.Integer.
    /// </summary>
    /// <param name="From">The value to be converted.</param>
    /// <returns>The converted Datatype.Integer value.</returns>
    public static implicit operator Integer(int From)
    {
        return new Integer(From);
    }

    /// <summary>
    /// Compares an int value with a Datatype.Integer value.
    /// </summary>
    /// <param name="Left">The int value to be compared.</param>
    /// <param name="Right">The Datatype.Integer value to be compared.</param>
    /// <returns>True if the values are the same.</returns>
    public static bool operator ==(int Left, Integer Right)
    {
        return Right.Equals(Left);
    }

    /// <summary>
    /// Compares an int value with a Datatype.Integer value.
    /// </summary>
    /// <param name="Left">The int value to be compared.</param>
    /// <param name="Right">The Datatype.Integer value to be compared.</param>
    /// <returns>True if the values are different.</returns>
    public static bool operator !=(int Left, Integer Right)
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
        if (Obj is Integer)
        {
            return Value == (Integer)Obj;
        }
        if (Obj is int)
        {
            return Value == (int)Obj;
        }
        return false;
    }

    /// <summary>
    /// Returns the hash code for the current instance.
    /// </summary>
    /// <returns>A hash code for the current Integer instance.</returns>
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
        if (_value.Equals(int.MinValue))
        {
            return string.Empty;
        }
        return _value.ToString();
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
        if (!int.TryParse(reader.ReadElementString(), out _value))
        {
            _value = 0;
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
