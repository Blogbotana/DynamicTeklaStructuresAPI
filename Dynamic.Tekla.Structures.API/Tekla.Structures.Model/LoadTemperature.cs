using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;

namespace Dynamic.Tekla.Structures.Model;

    public  class LoadTemperature  : Load
    {


       

        public Dynamic.Tekla.Structures.Geometry3d.Point Position1
        {
            get
            {
                try
                {
                var value = teklaObject.Position1;
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Geometry3d.Point) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Position1), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
                teklaObject.Position1 = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Position1), ex); 
                }
            }
        }

        public Dynamic.Tekla.Structures.Geometry3d.Point Position2
        {
            get
            {
                try
                {
                var value = teklaObject.Position2;
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Geometry3d.Point) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Position2), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
                teklaObject.Position2 = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Position2), ex); 
                }
            }
        }

        public double TemperatureChangeForAxialElongation
        {
            get
            {
                try
                {
                return teklaObject.TemperatureChangeForAxialElongation;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(TemperatureChangeForAxialElongation), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.TemperatureChangeForAxialElongation = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(TemperatureChangeForAxialElongation), ex); 
                }
            }
        }

        public double TemperatureDifferentialTopToBottom
        {
            get
            {
                try
                {
                return teklaObject.TemperatureDifferentialTopToBottom;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(TemperatureDifferentialTopToBottom), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.TemperatureDifferentialTopToBottom = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(TemperatureDifferentialTopToBottom), ex); 
                }
            }
        }

        public double TemperatureDifferentialSideToSide
        {
            get
            {
                try
                {
                return teklaObject.TemperatureDifferentialSideToSide;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(TemperatureDifferentialSideToSide), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.TemperatureDifferentialSideToSide = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(TemperatureDifferentialSideToSide), ex); 
                }
            }
        }

        public double InitialAxialElongation
        {
            get
            {
                try
                {
                return teklaObject.InitialAxialElongation;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(InitialAxialElongation), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.InitialAxialElongation = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(InitialAxialElongation), ex); 
                }
            }
        }
        

        

		public LoadTemperature()
		{
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.LoadTemperature");
		}
		
		public LoadTemperature(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			teklaObject = tsObject;
		}





    }

    internal static class LoadTemperature_
    {
        public static dynamic GetTSObject(LoadTemperature dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static LoadTemperature FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (LoadTemperature)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class LoadTemperatureArray_
    {
        public static dynamic GetTSObject(LoadTemperature[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(LoadTemperature_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static LoadTemperature[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<LoadTemperature>();
            foreach(var tsItem in tsArray)
            {
                list.Add(LoadTemperature_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }

