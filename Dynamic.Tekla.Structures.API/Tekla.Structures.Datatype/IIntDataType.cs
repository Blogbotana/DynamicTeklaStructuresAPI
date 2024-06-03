namespace Dynamic.Tekla.Structures.Datatype;
/// <summary>
/// The IIntDataType interface is an interface for the Tekla.Structures.Datatype.*
/// types whose value is an integer.
/// </summary>
public interface IIntDataType : IDataType
{
    /// <summary>
    /// The integer value of the field.
    /// </summary>
    int Value { get; set; }
}
