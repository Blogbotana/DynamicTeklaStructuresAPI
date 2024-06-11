using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;

namespace Dynamic.Tekla.Structures.Model;

public  class TaskDependency  : ModelObject
    {


        public int Lag
        {
            get
            {
                try
                {
                return teklaObject.Lag;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Lag), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.Lag = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Lag), ex); 
                }
            }
        }

        public bool Local
        {
            get
            {
                try
                {
                return teklaObject.Local;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Local), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.Local = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Local), ex); 
                }
            }
        }

        public Task Primary
        {
            get
            {
                try
                {
                var value = teklaObject.Primary;
                var value_ = Task_.FromTSObject(value);
                return (Task) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Primary), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Task_.GetTSObject(value);
                teklaObject.Primary = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Primary), ex); 
                }
            }
        }

        public Task Secondary
        {
            get
            {
                try
                {
                var value = teklaObject.Secondary;
                var value_ = Task_.FromTSObject(value);
                return (Task) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Secondary), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Task_.GetTSObject(value);
                teklaObject.Secondary = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Secondary), ex); 
                }
            }
        }

        public TaskDependency.DependencyTypeEnum DependencyType
        {
            get
            {
                try
                {
                var value = teklaObject.DependencyType;
                var value_ = TaskDependency.DependencyTypeEnum_.FromTSObject(value);
                return (TaskDependency.DependencyTypeEnum) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(DependencyType), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = TaskDependency.DependencyTypeEnum_.GetTSObject(value);
                teklaObject.DependencyType = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(DependencyType), ex); 
                }
            }
        }
        

        

		public TaskDependency()
		{
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.TaskDependency");
		}
		
		public TaskDependency(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			teklaObject = tsObject;
		}
		public TaskDependency(Task primary, Task secondary)
		{
			var args = new object[2];
			args[0] = Task_.GetTSObject(primary);
			args[1] = Task_.GetTSObject(secondary);
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.TaskDependency", args);
		}




    public enum DependencyTypeEnum
    {
			FINISH_TO_FINISH,
			FINISH_TO_START,
			START_TO_FINISH,
			START_TO_START        
    }

    internal static class DependencyTypeEnum_
    {
        public static dynamic GetTSObject(DependencyTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.TaskDependency.DependencyTypeEnum").GetType();

            switch (dynEnum)
            {
				case DependencyTypeEnum.FINISH_TO_FINISH:
					return System.Enum.Parse(tsType, "FINISH_TO_FINISH");
				case DependencyTypeEnum.FINISH_TO_START:
					return System.Enum.Parse(tsType, "FINISH_TO_START");
				case DependencyTypeEnum.START_TO_FINISH:
					return System.Enum.Parse(tsType, "START_TO_FINISH");
				case DependencyTypeEnum.START_TO_START:
					return System.Enum.Parse(tsType, "START_TO_START");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static DependencyTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("FINISH_TO_FINISH", System.StringComparison.InvariantCulture))
				return DependencyTypeEnum.FINISH_TO_FINISH;
			else if (tsEnumValue.Equals("FINISH_TO_START", System.StringComparison.InvariantCulture))
				return DependencyTypeEnum.FINISH_TO_START;
			else if (tsEnumValue.Equals("START_TO_FINISH", System.StringComparison.InvariantCulture))
				return DependencyTypeEnum.START_TO_FINISH;
			else if (tsEnumValue.Equals("START_TO_START", System.StringComparison.InvariantCulture))
				return DependencyTypeEnum.START_TO_START;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class TaskDependency_
    {
        public static dynamic GetTSObject(TaskDependency dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static TaskDependency FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (TaskDependency)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class TaskDependencyArray_
    {
        public static dynamic GetTSObject(TaskDependency[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(TaskDependency_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static TaskDependency[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<TaskDependency>();
            foreach(var tsItem in tsArray)
            {
                list.Add(TaskDependency_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    
