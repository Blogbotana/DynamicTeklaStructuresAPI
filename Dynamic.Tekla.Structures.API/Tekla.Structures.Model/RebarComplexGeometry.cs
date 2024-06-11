using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;

namespace Dynamic.Tekla.Structures.Model;
public  class RebarComplexGeometry 
    {


        public System.Collections.Generic.List<RebarLeg> Legs
        {
            get
            {
                try
                {
                var value = teklaObject.Legs;
                var value_ = ListConverter.FromTSObjects<RebarLeg>(value);
                return (System.Collections.Generic.List<RebarLeg>) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Legs), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = ListConverter.ToTSObjects(value);
                teklaObject.Legs = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Legs), ex); 
                }
            }
        }

        public double Diameter
        {
            get
            {
                try
                {
                return teklaObject.Diameter;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Diameter), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.Diameter = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Diameter), ex); 
                }
            }
        }

        public System.Collections.Generic.List<double> BendingRadiuses
        {
            get
            {
                try
                {
                return teklaObject.BendingRadiuses;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(BendingRadiuses), ex); 
                }
            }
            
        }
        

        internal dynamic teklaObject;

		internal RebarComplexGeometry() {}
		
		public RebarComplexGeometry(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			teklaObject = tsObject;
		}





    }

    internal static class RebarComplexGeometry_
    {
        public static dynamic GetTSObject(RebarComplexGeometry dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static RebarComplexGeometry FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (RebarComplexGeometry)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class RebarComplexGeometryArray_
    {
        public static dynamic GetTSObject(RebarComplexGeometry[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(RebarComplexGeometry_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static RebarComplexGeometry[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<RebarComplexGeometry>();
            foreach(var tsItem in tsArray)
            {
                list.Add(RebarComplexGeometry_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    
