using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Xml;

namespace Dynamic.Tekla.Structures.Datatype;
[Serializable]
[TypeConverter(typeof(StringConverter))]
public struct String : IXmlSerializable, IStringDataType, IDataType
{
    private string _string;

    /// <summary>
    /// The value of the string datatype.
    /// </summary>
    public string Value
    {
        get
        {
            if (_string != null)
            {
                return _string;
            }
            return "";
        }
        set
        {
            _string = value;
        }
    }

    /// <summary>
    /// Creates a new string datatype instance.
    /// </summary>
    /// <param name="text">The value for the string datatype.</param>
    public String(string text)
    {
        _string = text;
    }

    /// <summary>
    /// Converts from Datatype.String to string.
    /// </summary>
    /// <param name="From">The value to be converted.</param>
    /// <returns>The converted string value.</returns>
    public static implicit operator string(String From)
    {
        return From.Value;
    }

    /// <summary>
    /// Converts from string to Datatype.String.
    /// </summary>
    /// <param name="From">The value to be converted.</param>
    /// <returns>The converted Datatype.String value.</returns>
    public static implicit operator String(string From)
    {
        return new String(From);
    }

    /// <summary>
    /// Compares a string value with a Datatype.String value.
    /// </summary>
    /// <param name="Left">The string value to be compared.</param>
    /// <param name="Right">The Datatype.String value to be compared.</param>
    /// <returns>True if the values are the same.</returns>
    public static bool operator ==(string Left, String Right)
    {
        return Right.Equals(Left);
    }

    /// <summary>
    /// Compares a string value with a Datatype.String value.
    /// </summary>
    /// <param name="Left">The string value to be compared.</param>
    /// <param name="Right">The Datatype.String value to be compared.</param>
    /// <returns>True if the values are different.</returns>
    public static bool operator !=(string Left, String Right)
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
        if (Obj is String)
        {
            return Value == (String)Obj;
        }
        if (Obj is string)
        {
            return Value == (string)Obj;
        }
        return false;
    }

    /// <summary>
    /// Returns the hash code for the current instance.
    /// </summary>
    /// <returns>A hash code for the current String instance.</returns>
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
        if (_string != null)
        {
            return _string;
        }
        return "";
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
        string text = (_string = reader.ReadElementString());
    }

    /// <summary>
    /// Writes the value as XML to the given writer.
    /// </summary>
    /// <param name="writer">The writer to be used.</param>
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteValue(ToString());
    }
}
