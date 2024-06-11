using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;

namespace Dynamic.Tekla.Structures.Model;

    public  class LoadUniform  : Load
    {


        public Polygon Polygon
        {
            get
            {
                try
                {
                var value = teklaObject.Polygon;
                var value_ = Polygon_.FromTSObject(value);
                return (Polygon) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Polygon), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Polygon_.GetTSObject(value);
                teklaObject.Polygon = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Polygon), ex); 
                }
            }
        }

        public Dynamic.Tekla.Structures.Geometry3d.Vector P1
        {
            get
            {
                try
                {
                var value = teklaObject.P1;
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Geometry3d.Vector) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(P1), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value);
                teklaObject.P1 = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(P1), ex); 
                }
            }
        }

        public double DistanceA
        {
            get
            {
                try
                {
                return teklaObject.DistanceA;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(DistanceA), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.DistanceA = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(DistanceA), ex); 
                }
            }
        }
        

        

		public LoadUniform()
		{
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.LoadUniform");
		}
		
		public LoadUniform(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			teklaObject = tsObject;
		}





    }

    internal static class LoadUniform_
    {
        public static dynamic GetTSObject(LoadUniform dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static LoadUniform FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (LoadUniform)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class LoadUniformArray_
    {
        public static dynamic GetTSObject(LoadUniform[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(LoadUniform_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static LoadUniform[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<LoadUniform>();
            foreach(var tsItem in tsArray)
            {
                list.Add(LoadUniform_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }
  
