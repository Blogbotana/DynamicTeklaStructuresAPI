using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;
namespace Dynamic.Tekla.Structures.Model;

    public  class LogicalWeld  : BaseWeld
    {

        

        

		internal LogicalWeld() {}
		
		public LogicalWeld(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			teklaObject = tsObject;
		}
		public LogicalWeld(BaseWeld MainWeld)
		{
			var args = new object[1];
			args[0] = BaseWeld_.GetTSObject(MainWeld);
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.LogicalWeld", args);
		}


        public bool AddWeld(
			BaseWeld Weld_)
        {
            var Weld = BaseWeld_.GetTSObject(Weld_);
            try
            {
                var result = (bool) teklaObject.AddWeld(Weld);
            
                return result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(AddWeld), ex);
            }
        }



        public BaseWeld GetMainWeld()
        {
            
            try
            {
                var result = teklaObject.GetMainWeld();
            
                var _result = BaseWeld_.FromTSObject(result);
				return _result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetMainWeld), ex);
            }
        }



        public bool SetMainWeld(
			BaseWeld Weld_)
        {
            var Weld = BaseWeld_.GetTSObject(Weld_);
            try
            {
                var result = (bool) teklaObject.SetMainWeld(Weld);
            
                return result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SetMainWeld), ex);
            }
        }



        public bool RemoveWeld(
			BaseWeld Weld_)
        {
            var Weld = BaseWeld_.GetTSObject(Weld_);
            try
            {
                var result = (bool) teklaObject.RemoveWeld(Weld);
            
                return result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(RemoveWeld), ex);
            }
        }



        public bool Explode()
        {
            
            try
            {
                var result = (bool) teklaObject.Explode();
            
                return result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Explode), ex);
            }
        }



        public bool Select(
			BaseWeld ChildWeld_)
        {
            var ChildWeld = BaseWeld_.GetTSObject(ChildWeld_);
            try
            {
                var result = (bool) teklaObject.Select(ChildWeld);
            
                return result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Select), ex);
            }
        }






    }

    internal static class LogicalWeld_
    {
        public static dynamic GetTSObject(LogicalWeld dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static LogicalWeld FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (LogicalWeld)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


    
