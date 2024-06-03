using System;
using System.Collections;
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
[TypeConverter(typeof(DistanceListConverter))]
public struct DistanceList : IXmlSerializable, IList<Distance>, ICollection<Distance>, IEnumerable<Distance>, IEnumerable, IFormattable
{/// <summary>
 /// List of <see cref="T:Dynamic.Tekla.Structures.Datatype.Distance" />s.
 /// </summary>
    private List<Distance> distances;

    /// <summary>
    /// Gets or sets the item at the specified index.
    /// </summary>
    /// <param name="index">The index of an item in the list.</param>
    /// <returns>The item at the specified index.</returns>
    public Distance this[int index]
    {
        get
        {
            return Distances[index];
        }
        set
        {
            Distances[index] = value;
        }
    }

    public int Count => Distances.Count;
    public bool IsReadOnly => false;

    /// <summary>
    /// Gets the list of <see cref="T:Dynamic.Tekla.Structures.Datatype.Distance" />s.
    /// </summary>
    private List<Distance> Distances
    {
        get
        {
            if (distances == null)
            {
                distances = new List<Distance>();
            }
            return distances;
        }
    }

    /// <summary>
    /// Initializes a new instance of the structure.
    /// </summary>
    /// <param name="distanceList">The distance list.</param>
    public DistanceList(IEnumerable<Distance> distanceList)
    {
        distances = new List<Distance>(distanceList);
    }

    /// <summary>
    /// Parses a distance list from a string representation.
    /// </summary>
    /// <param name="input">The input string.</param>
    /// <returns>The distance list.</returns>
    public static DistanceList Parse(string input)
    {
        return new DistanceList(ValueList.Parse<Distance>(input, Distance.TryParse));
    }

    /// <summary>
    /// Parses a distance list from a string representation.
    /// </summary>
    /// <param name="input">The input string.</param>
    /// <param name="formatProvider">The format provider.</param>
    /// <returns>The distance list.</returns>
    public static DistanceList Parse(string input, IFormatProvider formatProvider)
    {
        return new DistanceList(ValueList.Parse(input, delegate (string text, out Distance result)
        {
            return Distance.TryParse(text, formatProvider, out result);
        }));
    }

    /// <summary>
    /// Parses a distance list from a string representation.
    /// </summary>
    /// <param name="input">The input string.</param>
    /// <param name="formatProvider">The format provider.</param>
    /// <param name="defaultUnitType">The default unit type.</param>
    /// <returns>The distance list.</returns>
    public static DistanceList Parse(string input, IFormatProvider formatProvider, Distance.UnitType defaultUnitType)
    {
        return new DistanceList(ValueList.Parse(input, delegate (string text, out Distance value)
        {
            return Distance.TryParse(text, formatProvider, defaultUnitType, out value);
        }));
    }

    /// <summary>
    /// Returns the string representation of the distance list.
    /// </summary>
    /// <returns>The string representation of the distance list.</returns>
    public override string ToString()
    {
        return ToString(null, null);
    }

    /// <summary>
    /// Returns the string representation of the distance list.
    /// </summary>
    /// <param name="formatProvider">The format provider.</param>
    /// <returns>The string representation of the distance list.</returns>
    public string ToString(IFormatProvider formatProvider)
    {
        return ValueList.ToString(Distances, (Distance value) => value.ToString(formatProvider));
    }

    /// <summary>
    /// Returns the string representation of the distance list.
    /// </summary>
    /// <param name="format">The format string.</param>
    /// <param name="formatProvider">The format provider.</param>
    /// <returns>The string representation of the distance list.</returns>
    public string ToString(string format, IFormatProvider formatProvider)
    {
        return ValueList.ToString(Distances, (Distance value) => value.ToString(format, formatProvider));
    }

    /// <summary>
    /// Returns the string representation of the distance list.
    /// </summary>
    /// <param name="format">The format string.</param>
    /// <param name="formatProvider">The format provider.</param>
    /// <param name="unitType">The distance unit type.</param>
    /// <returns>The string representation of the distance list.</returns>
    public string ToString(string format, IFormatProvider formatProvider, Distance.UnitType unitType)
    {
        return ValueList.ToString(Distances, (Distance value) => value.ToString(format, formatProvider, unitType));
    }

    /// <summary>
    /// Adds the specified item at the end of the list.
    /// </summary>
    /// <param name="item">The item to be added.</param>
    public void Add(Distance item)
    {
        Distances.Add(item);
    }

    /// <summary>
    /// Clears the list.
    /// </summary>
    public void Clear()
    {
        Distances.Clear();
    }

    /// <summary>
    /// Determines whether the specified item is in the list.
    /// </summary>
    /// <param name="item">The item to be matched.</param>
    /// <returns>A boolean value indicating whether the item was found.</returns>
    public bool Contains(Distance item)
    {
        return Distances.Contains(item);
    }

    /// <summary>
    /// Copies the contents of the list to an array.
    /// </summary>
    /// <param name="array">The target array.</param>
    /// <param name="arrayIndex">The starting index in the array.</param>
    public void CopyTo(Distance[] array, int arrayIndex)
    {
        Distances.CopyTo(array, arrayIndex);
    }

    /// <summary>
    /// Removes the specified item.
    /// </summary>
    /// <param name="item">The item to be removed.</param>
    /// <returns>A boolean value indicating whether the item was removed.</returns>
    public bool Remove(Distance item)
    {
        return Distances.Remove(item);
    }

    /// <summary>
    /// Returns the index of the first matching item in the list.
    /// </summary>
    /// <param name="item">The item to be matched.</param>
    /// <returns>The index of the first matching item.</returns>
    public int IndexOf(Distance item)
    {
        return Distances.IndexOf(item);
    }

    /// <summary>
    /// Inserts an item at the specified position.
    /// </summary>
    /// <param name="index">The index of the insertion point.</param>
    /// <param name="item">The item to be inserted.</param>
    public void Insert(int index, Distance item)
    {
        Distances.Insert(index, item);
    }

    /// <summary>
    /// Removes an item at the specified position.
    /// </summary>
    /// <param name="index">The index of the item to be removed.</param>
    public void RemoveAt(int index)
    {
        Distances.RemoveAt(index);
    }

    /// <summary>
    /// Copies the contents of the list into a new array.
    /// </summary>
    /// <returns>The array of distances.</returns>
    public Distance[] ToArray()
    {
        return Distances.ToArray();
    }

    /// <summary>
    /// Gets an enumerator for enumeraring through the list.
    /// </summary>
    /// <returns>The list enumerator.</returns>
    public IEnumerator<Distance> GetEnumerator()
    {
        return Distances.GetEnumerator();
    }

    /// <summary>
    /// Gets an enumerator for enumeraring through the list.
    /// </summary>
    IEnumerator IEnumerable.GetEnumerator()
    {
        return Distances.GetEnumerator();
    }

    /// <exclude />
    public XmlSchema GetSchema()
    {
        throw new Exception("The method or operation is not implemented.");
    }

    /// <exclude />
    public void ReadXml(XmlReader reader)
    {
        string name = reader.Name;
        string text = name;
        while (text == name || text == "Millimeters")
        {
            Distance item = default(Distance);
            item.GetXmlElement(reader);
            Add(item);
            text = reader.Name;
            if (text == name)
            {
                reader.ReadEndElement();
                text = reader.Name;
            }
        }
    }

    /// <exclude />
    public void WriteXml(XmlWriter writer)
    {
        foreach (Distance distance in Distances)
        {
            distance.WriteXml(writer);
        }
    }
}
