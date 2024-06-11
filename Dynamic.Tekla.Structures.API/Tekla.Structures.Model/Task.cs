using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;

namespace Dynamic.Tekla.Structures.Model;

public  class Task  : ModelObject
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

        public int Completeness
        {
            get
            {
                try
                {
                return teklaObject.Completeness;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Completeness), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.Completeness = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Completeness), ex); 
                }
            }
        }

        public bool Critical
        {
            get
            {
                try
                {
                return teklaObject.Critical;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Critical), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.Critical = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Critical), ex); 
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

        public HierarchicObject Scenario
        {
            get
            {
                try
                {
                var value = teklaObject.Scenario;
                var value_ = HierarchicObject_.FromTSObject(value);
                return (HierarchicObject) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Scenario), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = HierarchicObject_.GetTSObject(value);
                teklaObject.Scenario = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Scenario), ex); 
                }
            }
        }

        public string Description
        {
            get
            {
                try
                {
                return teklaObject.Description;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Description), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.Description = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Description), ex); 
                }
            }
        }

        public string Url
        {
            get
            {
                try
                {
                return teklaObject.Url;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Url), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.Url = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Url), ex); 
                }
            }
        }

        public System.DateTime PlannedStartDate
        {
            get
            {
                try
                {
                return teklaObject.PlannedStartDate;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(PlannedStartDate), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.PlannedStartDate = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(PlannedStartDate), ex); 
                }
            }
        }

        public System.DateTime PlannedEndDate
        {
            get
            {
                try
                {
                return teklaObject.PlannedEndDate;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(PlannedEndDate), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.PlannedEndDate = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(PlannedEndDate), ex); 
                }
            }
        }

        public double PlannedWorkAmount
        {
            get
            {
                try
                {
                return teklaObject.PlannedWorkAmount;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(PlannedWorkAmount), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.PlannedWorkAmount = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(PlannedWorkAmount), ex); 
                }
            }
        }

        public System.DateTime ActualStartDate
        {
            get
            {
                try
                {
                return teklaObject.ActualStartDate;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ActualStartDate), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.ActualStartDate = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ActualStartDate), ex); 
                }
            }
        }

        public System.DateTime ActualEndDate
        {
            get
            {
                try
                {
                return teklaObject.ActualEndDate;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ActualEndDate), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.ActualEndDate = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ActualEndDate), ex); 
                }
            }
        }

        public double ActualWorkAmount
        {
            get
            {
                try
                {
                return teklaObject.ActualWorkAmount;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ActualWorkAmount), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.ActualWorkAmount = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ActualWorkAmount), ex); 
                }
            }
        }
        

        

		public Task()
		{
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Task");
		}
		
		public Task(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			teklaObject = tsObject;
		}
		public Task(Dynamic.Tekla.Structures.Identifier ID)
		{
			var args = new object[1];
			args[0] = Dynamic.Tekla.Structures.Identifier_.GetTSObject(ID);
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Task", args);
		}


        public bool AddObjectsToTask(
			System.Collections.ArrayList ModelObjects_)
        {
            var ModelObjects = ArrayListConverter.ToTSObjects(ModelObjects_);
            try
            {
                var result = (bool) teklaObject.AddObjectsToTask(ModelObjects);
            
                return result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(AddObjectsToTask), ex);
            }
        }



        public bool RemoveObjectsFromTask(
			System.Collections.ArrayList ModelObjects_)
        {
            var ModelObjects = ArrayListConverter.ToTSObjects(ModelObjects_);
            try
            {
                var result = (bool) teklaObject.RemoveObjectsFromTask(ModelObjects);
            
                return result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(RemoveObjectsFromTask), ex);
            }
        }



        public ModelObjectEnumerator GetFathers()
        {
            
            try
            {
                var result = teklaObject.GetFathers();
            
                var _result = ModelObjectEnumerator_.FromTSObject(result);
				return _result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetFathers), ex);
            }
        }



        public ModelObjectEnumerator GetDependencies()
        {
            
            try
            {
                var result = teklaObject.GetDependencies();
            
                var _result = ModelObjectEnumerator_.FromTSObject(result);
				return _result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetDependencies), ex);
            }
        }



        public static ModelObjectEnumerator GetAllTasksOfSelectedObjects()
        {
            var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Task", "GetAllTasksOfSelectedObjects");
            var _result = ModelObjectEnumerator_.FromTSObject(result);
				return _result;
        }






    }

    internal static class Task_
    {
        public static dynamic GetTSObject(Task dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static Task FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Task)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class TaskArray_
    {
        public static dynamic GetTSObject(Task[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Task_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Task[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<Task>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Task_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    
