using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;

namespace Dynamic.Tekla.Structures.Model;

public  class RebarHookDataNullable 
    {


        public System.Nullable<RebarHookData.RebarHookShapeEnum> Shape
        {
            get
            {
                try
                {
                var value = teklaObject.Shape;
                var value_ = NullableConverter.FromTSObject<RebarHookData.RebarHookShapeEnum>(value);
                return (System.Nullable<RebarHookData.RebarHookShapeEnum>) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Shape), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = NullableConverter.ToTSObjects(value);
                teklaObject.Shape = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Shape), ex); 
                }
            }
        }

        public System.Nullable<double> Angle
        {
            get
            {
                try
                {
                return teklaObject.Angle;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Angle), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.Angle = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Angle), ex); 
                }
            }
        }

        public System.Nullable<double> Radius
        {
            get
            {
                try
                {
                return teklaObject.Radius;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Radius), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.Radius = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Radius), ex); 
                }
            }
        }

        public System.Nullable<double> Length
        {
            get
            {
                try
                {
                return teklaObject.Length;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Length), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.Length = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Length), ex); 
                }
            }
        }

        public System.Nullable<double> Rotation
        {
            get
            {
                try
                {
                return teklaObject.Rotation;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Rotation), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.Rotation = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Rotation), ex); 
                }
            }
        }
        

        internal dynamic teklaObject;

		public RebarHookDataNullable()
		{
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.RebarHookDataNullable");
		}
		
		public RebarHookDataNullable(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			teklaObject = tsObject;
		}





    }

    internal static class RebarHookDataNullable_
    {
        public static dynamic GetTSObject(RebarHookDataNullable dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static RebarHookDataNullable FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (RebarHookDataNullable)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class RebarHookDataNullableArray_
    {
        public static dynamic GetTSObject(RebarHookDataNullable[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(RebarHookDataNullable_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static RebarHookDataNullable[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<RebarHookDataNullable>();
            foreach(var tsItem in tsArray)
            {
                list.Add(RebarHookDataNullable_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    
