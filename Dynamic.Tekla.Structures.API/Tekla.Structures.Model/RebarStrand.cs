
using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;

namespace Dynamic.Tekla.Structures.Model;

public  class RebarStrand  : Reinforcement
    {


        public string Size
        {
            get
            {
                try
                {
                return teklaObject.Size;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Size), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.Size = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Size), ex); 
                }
            }
        }

        public double PullPerStrand
        {
            get
            {
                try
                {
                return teklaObject.PullPerStrand;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(PullPerStrand), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.PullPerStrand = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(PullPerStrand), ex); 
                }
            }
        }

        public System.Collections.ArrayList Patterns
        {
            get
            {
                try
                {
                var value = teklaObject.Patterns;
                var value_ = ArrayListConverter.FromTSObjects(value);
                return (System.Collections.ArrayList) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Patterns), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = ArrayListConverter.ToTSObjects(value);
                teklaObject.Patterns = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Patterns), ex); 
                }
            }
        }

        public System.Collections.ArrayList Unbondings
        {
            get
            {
                try
                {
                var value = teklaObject.Unbondings;
                var value_ = ArrayListConverter.FromTSObjects(value);
                return (System.Collections.ArrayList) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Unbondings), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = ArrayListConverter.ToTSObjects(value);
                teklaObject.Unbondings = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Unbondings), ex); 
                }
            }
        }

        public Dynamic.Tekla.Structures.Geometry3d.Point StartPoint
        {
            get
            {
                try
                {
                var value = teklaObject.StartPoint;
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Geometry3d.Point) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(StartPoint), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
                teklaObject.StartPoint = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(StartPoint), ex); 
                }
            }
        }

        public Dynamic.Tekla.Structures.Geometry3d.Point EndPoint
        {
            get
            {
                try
                {
                var value = teklaObject.EndPoint;
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Geometry3d.Point) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(EndPoint), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
                teklaObject.EndPoint = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(EndPoint), ex); 
                }
            }
        }

        public System.Collections.ArrayList OnPlaneOffsets
        {
            get
            {
                try
                {
                var value = teklaObject.OnPlaneOffsets;
                var value_ = ArrayListConverter.FromTSObjects(value);
                return (System.Collections.ArrayList) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(OnPlaneOffsets), ex); 
                }
            }
            
        }
        

        

		public RebarStrand()
		{
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.RebarStrand");
		}
		
		public RebarStrand(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			teklaObject = tsObject;
		}





    }

    internal static class RebarStrand_
    {
        public static dynamic GetTSObject(RebarStrand dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static RebarStrand FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (RebarStrand)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class RebarStrandArray_
    {
        public static dynamic GetTSObject(RebarStrand[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(RebarStrand_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static RebarStrand[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<RebarStrand>();
            foreach(var tsItem in tsArray)
            {
                list.Add(RebarStrand_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    
