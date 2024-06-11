using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;

namespace Dynamic.Tekla.Structures.Model;

public  class Polygon 
    {


        public System.Collections.ArrayList Points
        {
            get
            {
                try
                {
                var value = teklaObject.Points;
                var value_ = ArrayListConverter.FromTSObjects(value);
                return (System.Collections.ArrayList) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Points), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = ArrayListConverter.ToTSObjects(value);
                teklaObject.Points = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Points), ex); 
                }
            }
        }

        public static int MAX_POLYGON_POINTS
        {
            get
            {
                var value = PropertyInvoker.GetStaticPropertyOrFieldValue("Tekla.Structures.Model.Polygon", "MAX_POLYGON_POINTS");
                return (int) value;
            }
            
        }
        public static int MIN_POLYGON_POINTS
        {
            get
            {
                var value = PropertyInvoker.GetStaticPropertyOrFieldValue("Tekla.Structures.Model.Polygon", "MIN_POLYGON_POINTS");
                return (int) value;
            }
            
        }        

        internal dynamic teklaObject;

		public Polygon()
		{
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Polygon");
		}
		
		public Polygon(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			teklaObject = tsObject;
		}





    }

    internal static class Polygon_
    {
        public static dynamic GetTSObject(Polygon dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static Polygon FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Polygon)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PolygonArray_
    {
        public static dynamic GetTSObject(Polygon[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Polygon_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Polygon[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<Polygon>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Polygon_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    
