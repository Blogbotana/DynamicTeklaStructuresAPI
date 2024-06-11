using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;

namespace Dynamic.Tekla.Structures.Model;

public  class TaskWorktype  : ModelObject
    {


        public string Name
        {
            get
            {
                try
                {
                return teklaObject.Name;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Name), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.Name = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Name), ex); 
                }
            }
        }
        

        

		public TaskWorktype()
		{
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.TaskWorktype");
		}
		
		public TaskWorktype(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			teklaObject = tsObject;
		}





    }

    internal static class TaskWorktype_
    {
        public static dynamic GetTSObject(TaskWorktype dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static TaskWorktype FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (TaskWorktype)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class TaskWorktypeArray_
    {
        public static dynamic GetTSObject(TaskWorktype[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(TaskWorktype_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static TaskWorktype[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<TaskWorktype>();
            foreach(var tsItem in tsArray)
            {
                list.Add(TaskWorktype_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


   
