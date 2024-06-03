namespace Dynamic.Tekla.Structures.Datatype;
/// <summary>
/// The IDoubleDataType interface is an interface for the Tekla.Structures.Datatype.*
/// types whose value is a double.
/// </summary>
public interface IDoubleDataType : IDataType
{
    /// <summary>
    /// The double value of the field.
    /// </summary>
    double Value { get; set; }
}
