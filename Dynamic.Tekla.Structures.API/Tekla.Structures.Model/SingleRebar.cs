using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;

namespace Dynamic.Tekla.Structures.Model;

public  class SingleRebar  : Reinforcement
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

        public RebarHookData StartHook
        {
            get
            {
                try
                {
                var value = teklaObject.StartHook;
                var value_ = RebarHookData_.FromTSObject(value);
                return (RebarHookData) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(StartHook), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = RebarHookData_.GetTSObject(value);
                teklaObject.StartHook = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(StartHook), ex); 
                }
            }
        }

        public RebarHookData EndHook
        {
            get
            {
                try
                {
                var value = teklaObject.EndHook;
                var value_ = RebarHookData_.FromTSObject(value);
                return (RebarHookData) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(EndHook), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = RebarHookData_.GetTSObject(value);
                teklaObject.EndHook = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(EndHook), ex); 
                }
            }
        }

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
        

        

		public SingleRebar()
		{
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.SingleRebar");
		}
		
		public SingleRebar(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			teklaObject = tsObject;
		}


        public RebarSet GetRebarSet()
        {
            
            try
            {
                var result = teklaObject.GetRebarSet();
            
                var _result = RebarSet_.FromTSObject(result);
				return _result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetRebarSet), ex);
            }
        }






    }

    internal static class SingleRebar_
    {
        public static dynamic GetTSObject(SingleRebar dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static SingleRebar FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (SingleRebar)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class SingleRebarArray_
    {
        public static dynamic GetTSObject(SingleRebar[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(SingleRebar_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static SingleRebar[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<SingleRebar>();
            foreach(var tsItem in tsArray)
            {
                list.Add(SingleRebar_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    
