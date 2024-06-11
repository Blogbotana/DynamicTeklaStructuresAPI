using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;

namespace Dynamic.Tekla.Structures.Model;

public  class RebarGuideline 
    {


        public int Id
        {
            get
            {
                try
                {
                return teklaObject.Id;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Id), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.Id = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Id), ex); 
                }
            }
        }

        public Contour Curve
        {
            get
            {
                try
                {
                var value = teklaObject.Curve;
                var value_ = Contour_.FromTSObject(value);
                return (Contour) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Curve), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Contour_.GetTSObject(value);
                teklaObject.Curve = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Curve), ex); 
                }
            }
        }

        public RebarSpacing Spacing
        {
            get
            {
                try
                {
                var value = teklaObject.Spacing;
                var value_ = RebarSpacing_.FromTSObject(value);
                return (RebarSpacing) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Spacing), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = RebarSpacing_.GetTSObject(value);
                teklaObject.Spacing = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Spacing), ex); 
                }
            }
        }

        public bool FollowEdges
        {
            get
            {
                try
                {
                return teklaObject.FollowEdges;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(FollowEdges), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.FollowEdges = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(FollowEdges), ex); 
                }
            }
        }
        

        internal dynamic teklaObject;

		public RebarGuideline()
		{
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.RebarGuideline");
		}
		
		public RebarGuideline(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			teklaObject = tsObject;
		}





    }

    internal static class RebarGuideline_
    {
        public static dynamic GetTSObject(RebarGuideline dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static RebarGuideline FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (RebarGuideline)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class RebarGuidelineArray_
    {
        public static dynamic GetTSObject(RebarGuideline[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(RebarGuideline_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static RebarGuideline[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<RebarGuideline>();
            foreach(var tsItem in tsArray)
            {
                list.Add(RebarGuideline_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    
