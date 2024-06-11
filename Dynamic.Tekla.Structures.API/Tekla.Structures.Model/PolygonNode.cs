using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;

namespace Dynamic.Tekla.Structures.Model;

public  class PolygonNode 
    {


        public bool IsAutomatic
        {
            get
            {
                try
                {
                return teklaObject.IsAutomatic;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(IsAutomatic), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.IsAutomatic = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(IsAutomatic), ex); 
                }
            }
        }

        public Contour Contour
        {
            get
            {
                try
                {
                var value = teklaObject.Contour;
                var value_ = Contour_.FromTSObject(value);
                return (Contour) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Contour), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Contour_.GetTSObject(value);
                teklaObject.Contour = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Contour), ex); 
                }
            }
        }
        

        internal dynamic teklaObject;

		internal PolygonNode() {}
		
		public PolygonNode(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			teklaObject = tsObject;
		}
		public PolygonNode(Contour contour, bool isAutomaticNode)
		{
			var args = new object[2];
			args[0] = Contour_.GetTSObject(contour);
			args[1] = isAutomaticNode;
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.PolygonNode", args);
		}


        public void AcceptVisitor(
			IGeometryNodeVisitor visitor_)
        {
            var visitor = IGeometryNodeVisitor_.GetTSObject(visitor_);
            try
            {
                teklaObject.AcceptVisitor(visitor);
            
                
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(AcceptVisitor), ex);
            }
        }






    }

    internal static class PolygonNode_
    {
        public static dynamic GetTSObject(PolygonNode dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static PolygonNode FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (PolygonNode)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PolygonNodeArray_
    {
        public static dynamic GetTSObject(PolygonNode[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(PolygonNode_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static PolygonNode[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<PolygonNode>();
            foreach(var tsItem in tsArray)
            {
                list.Add(PolygonNode_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


   
