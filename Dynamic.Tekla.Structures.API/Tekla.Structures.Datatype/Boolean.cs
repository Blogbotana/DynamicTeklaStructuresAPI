using System;
using System.ComponentModel;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Dynamic.Tekla.Structures.Datatype;
[Serializable]
[TypeConverter(typeof(BooleanConverter))]
public struct Boolean : IXmlSerializable, IDataType
{
    /// <summary>
    /// Boolean value.
    /// </summary>
    private bool boolValue;

    /// <summary>
    /// Gets or sets the boolean value.
    /// </summary>
    public bool Value
    {
        get
        {
            return boolValue;
        }
        set
        {
            boolValue = value;
        }
    }

    /// <summary>
    /// Initializes a new instance of the structure.
    /// </summary>
    /// <param name="boolValue">The boolean value.</param>
    public Boolean(bool boolValue)
    {
        this.boolValue = boolValue;
    }

    /// <exclude />
    public XmlSchema GetSchema()
    {
        throw new Exception("The method or operation is not implemented.");
    }

    /// <exclude />
    public void ReadXml(XmlReader reader)
    {
        if (!bool.TryParse(reader.ReadElementString(), out boolValue))
        {
            boolValue = false;
        }
    }

    /// <exclude />
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteValue(boolValue);
    }
}
