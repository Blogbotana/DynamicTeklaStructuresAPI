using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;

namespace Dynamic.Tekla.Structures.Model;



public sealed class ConnectiveGeometry
{


    public static int InvalidGeometrySectionIndex
    {
        get
        {
            var value = PropertyInvoker.GetStaticPropertyOrFieldValue("Tekla.Structures.Model.ConnectiveGeometry", "InvalidGeometrySectionIndex");
            return (int) value;
        }
        
    }        

    internal dynamic teklaObject;

		internal ConnectiveGeometry() {}
		
		public ConnectiveGeometry(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			teklaObject = tsObject;
		}
		public ConnectiveGeometry(Contour contour)
		{
			var args = new object[1];
			args[0] = Contour_.GetTSObject(contour);
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ConnectiveGeometry", args);
		}
		public ConnectiveGeometry(BendSurface bendSurface)
		{
			var args = new object[1];
			args[0] = BendSurface_.GetTSObject(bendSurface);
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ConnectiveGeometry", args);
		}


    public bool IsEmpty()
    {
        
        try
        {
            var result = (bool) teklaObject.IsEmpty();
        
            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(IsEmpty), ex);
        }
    }



    public GeometrySectionEnumerator GetGeometryEnumerator()
    {
        
        try
        {
            var result = teklaObject.GetGeometryEnumerator();
        
            var _result = GeometrySectionEnumerator_.FromTSObject(result);
				return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetGeometryEnumerator), ex);
        }
    }






}

internal static class ConnectiveGeometry_
{
    public static dynamic GetTSObject(ConnectiveGeometry dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static ConnectiveGeometry FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
        
        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (ConnectiveGeometry)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}


