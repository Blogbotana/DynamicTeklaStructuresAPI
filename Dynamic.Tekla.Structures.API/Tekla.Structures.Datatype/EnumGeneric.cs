using System;
using System.ComponentModel;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Dynamic.Tekla.Structures.Datatype;
/// <summary>The Enum datatype generic.</summary>
/// <typeparam name="E">The enum to handle.</typeparam>
[TypeConverter(typeof(EnumConverter))]
public struct Enum<E> : IXmlSerializable, IDataType where E : struct
{
    /// <summary>Gets or sets the value.</summary>
    public E Value { get; set; }

    /// <inheritdocs />
    public XmlSchema GetSchema()
    {
        throw new NotImplementedException();
    }

    /// <inheritdocs />
    public void ReadXml(XmlReader reader)
    {
        if (reader == null)
        {
            throw new ArgumentNullException("reader");
        }
        string text = reader.ReadElementString();
        if (Enum.TryParse<E>(text, out var result))
        {
            Value = result;
            return;
        }
        throw new InvalidOperationException("Usupported value of " + typeof(E).Name + ": " + text);
    }

    /// <inheritdocs />
    public void WriteXml(XmlWriter writer)
    {
        if (writer == null)
        {
            throw new ArgumentNullException("writer");
        }
        writer.WriteValue(Value.ToString());
    }
}
