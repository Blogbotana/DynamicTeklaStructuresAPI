using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;

namespace Dynamic.Tekla.Structures.Model;
public  class RebarSet  : ModelObject
    {


        public RebarProperties RebarProperties
        {
            get
            {
                try
                {
                var value = teklaObject.RebarProperties;
                var value_ = RebarProperties_.FromTSObject(value);
                return (RebarProperties) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(RebarProperties), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = RebarProperties_.GetTSObject(value);
                teklaObject.RebarProperties = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(RebarProperties), ex); 
                }
            }
        }

        public System.Collections.Generic.List<RebarLegFace> LegFaces
        {
            get
            {
                try
                {
                var value = teklaObject.LegFaces;
                var value_ = ListConverter.FromTSObjects<RebarLegFace>(value);
                return (System.Collections.Generic.List<RebarLegFace>) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LegFaces), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = ListConverter.ToTSObjects(value);
                teklaObject.LegFaces = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LegFaces), ex); 
                }
            }
        }

        public System.Collections.Generic.List<RebarGuideline> Guidelines
        {
            get
            {
                try
                {
                var value = teklaObject.Guidelines;
                var value_ = ListConverter.FromTSObjects<RebarGuideline>(value);
                return (System.Collections.Generic.List<RebarGuideline>) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Guidelines), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = ListConverter.ToTSObjects(value);
                teklaObject.Guidelines = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Guidelines), ex); 
                }
            }
        }

        public int LayerOrderNumber
        {
            get
            {
                try
                {
                return teklaObject.LayerOrderNumber;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LayerOrderNumber), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.LayerOrderNumber = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LayerOrderNumber), ex); 
                }
            }
        }

        public Dynamic.Tekla.Structures.Geometry3d.LineSegment BarOrientation
        {
            get
            {
                try
                {
                var value = teklaObject.BarOrientation;
                var value_ = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Geometry3d.LineSegment) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(BarOrientation), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(value);
                teklaObject.BarOrientation = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(BarOrientation), ex); 
                }
            }
        }

        public Part FatherPart
        {
            get
            {
                try
                {
                var value = teklaObject.FatherPart;
                var value_ = Part_.FromTSObject(value);
                return (Part) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(FatherPart), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Part_.GetTSObject(value);
                teklaObject.FatherPart = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(FatherPart), ex); 
                }
            }
        }
        

        

		public RebarSet()
		{
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.RebarSet");
		}
		
		public RebarSet(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			teklaObject = tsObject;
		}


        public ModelObjectEnumerator GetRebarSetAdditions()
        {
            
            try
            {
                var result = teklaObject.GetRebarSetAdditions();
            
                var _result = ModelObjectEnumerator_.FromTSObject(result);
				return _result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetRebarSetAdditions), ex);
            }
        }



        public ModelObjectEnumerator GetRebarModifiers()
        {
            
            try
            {
                var result = teklaObject.GetRebarModifiers();
            
                var _result = ModelObjectEnumerator_.FromTSObject(result);
				return _result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetRebarModifiers), ex);
            }
        }



        public ModelObjectEnumerator GetRebarLegSurfaces()
        {
            
            try
            {
                var result = teklaObject.GetRebarLegSurfaces();
            
                var _result = ModelObjectEnumerator_.FromTSObject(result);
				return _result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetRebarLegSurfaces), ex);
            }
        }



        public ModelObjectEnumerator GetReinforcements()
        {
            
            try
            {
                var result = teklaObject.GetReinforcements();
            
                var _result = ModelObjectEnumerator_.FromTSObject(result);
				return _result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetReinforcements), ex);
            }
        }



        public Assembly GetAssembly()
        {
            
            try
            {
                var result = teklaObject.GetAssembly();
            
                var _result = Assembly_.FromTSObject(result);
				return _result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetAssembly), ex);
            }
        }






    }

    internal static class RebarSet_
    {
        public static dynamic GetTSObject(RebarSet dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static RebarSet FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (RebarSet)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class RebarSetArray_
    {
        public static dynamic GetTSObject(RebarSet[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(RebarSet_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static RebarSet[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<RebarSet>();
            foreach(var tsItem in tsArray)
            {
                list.Add(RebarSet_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    
