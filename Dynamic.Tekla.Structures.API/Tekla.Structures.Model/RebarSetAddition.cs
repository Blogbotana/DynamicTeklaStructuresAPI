using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;

namespace Dynamic.Tekla.Structures.Model;

public  class RebarSetAddition  : ModelObject
    {


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

        public RebarSet Father
        {
            get
            {
                try
                {
                var value = teklaObject.Father;
                var value_ = RebarSet_.FromTSObject(value);
                return (RebarSet) value_;
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
                var value_ = RebarSet_.GetTSObject(value);
                teklaObject.Father = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Father), ex); 
                }
            }
        }
        

        

		public RebarSetAddition()
		{
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.RebarSetAddition");
		}
		
		public RebarSetAddition(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			teklaObject = tsObject;
		}





    }

    internal static class RebarSetAddition_
    {
        public static dynamic GetTSObject(RebarSetAddition dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static RebarSetAddition FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (RebarSetAddition)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class RebarSetAdditionArray_
    {
        public static dynamic GetTSObject(RebarSetAddition[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(RebarSetAddition_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static RebarSetAddition[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<RebarSetAddition>();
            foreach(var tsItem in tsArray)
            {
                list.Add(RebarSetAddition_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    
