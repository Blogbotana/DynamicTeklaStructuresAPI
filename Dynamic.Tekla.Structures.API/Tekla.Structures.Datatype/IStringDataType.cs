using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic.Tekla.Structures.Datatype;
public interface IStringDataType : IDataType
{
    /// <summary>
    /// The string value of the field.
    /// </summary>
    string Value { get; set; }
}
