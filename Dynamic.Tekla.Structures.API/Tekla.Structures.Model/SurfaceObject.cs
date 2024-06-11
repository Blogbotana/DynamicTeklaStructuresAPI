using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;

namespace Dynamic.Tekla.Structures.Model;

public  class SurfaceObject  : ModelObject
    {


        public Dynamic.Tekla.Structures.Geometry3d.FacetedBrep Polymesh
        {
            get
            {
                try
                {
                var value = teklaObject.Polymesh;
                var value_ = Dynamic.Tekla.Structures.Geometry3d.FacetedBrep_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Geometry3d.FacetedBrep) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Polymesh), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Dynamic.Tekla.Structures.Geometry3d.FacetedBrep_.GetTSObject(value);
                teklaObject.Polymesh = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Polymesh), ex); 
                }
            }
        }

        public string Class
        {
            get
            {
                try
                {
                return teklaObject.Class;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Class), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.Class = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Class), ex); 
                }
            }
        }

        public string Name
        {
            get
            {
                try
                {
                return teklaObject.Name;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Name), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.Name = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Name), ex); 
                }
            }
        }

        public bool CreateHoles
        {
            get
            {
                try
                {
                return teklaObject.CreateHoles;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(CreateHoles), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.CreateHoles = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(CreateHoles), ex); 
                }
            }
        }

        public string Type
        {
            get
            {
                try
                {
                return teklaObject.Type;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Type), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.Type = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Type), ex); 
                }
            }
        }

        public ModelObject Father
        {
            get
            {
                try
                {
                var value = teklaObject.Father;
                var value_ = ModelObject_.FromTSObject(value);
                return (ModelObject) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Father), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = ModelObject_.GetTSObject(value);
                teklaObject.Father = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Father), ex); 
                }
            }
        }
        

        

		public SurfaceObject()
		{
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.SurfaceObject");
		}
		
		public SurfaceObject(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			teklaObject = tsObject;
		}





    }

    internal static class SurfaceObject_
    {
        public static dynamic GetTSObject(SurfaceObject dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static SurfaceObject FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (SurfaceObject)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class SurfaceObjectArray_
    {
        public static dynamic GetTSObject(SurfaceObject[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(SurfaceObject_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static SurfaceObject[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<SurfaceObject>();
            foreach(var tsItem in tsArray)
            {
                list.Add(SurfaceObject_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


   
