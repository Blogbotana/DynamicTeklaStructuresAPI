using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;

namespace Dynamic.Tekla.Structures.Model;

    public  class ModelHandler 
    {

        

        internal dynamic teklaObject;

		public ModelHandler()
		{
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ModelHandler");
		}
		
		public ModelHandler(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			teklaObject = tsObject;
		}


        public bool CreateNewSingleUserModel(
			string ModelName,
			string ModelFolder,
			string Template)
        {

            try
            {
                var result = (bool) teklaObject.CreateNewSingleUserModel(ModelName, ModelFolder, Template);
            
                return result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(CreateNewSingleUserModel), ex);
            }
        }



        public bool CreateNewMultiUserModel(
			string ModelName,
			string ModelFolder,
			string ServerName)
        {

            try
            {
                var result = (bool) teklaObject.CreateNewMultiUserModel(ModelName, ModelFolder, ServerName);
            
                return result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(CreateNewMultiUserModel), ex);
            }
        }



        public bool Save(
			string Comment,
			string User)
        {
            try
            {
                var result = (bool) teklaObject.Save(Comment, User);
            
                return result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Save), ex);
            }
        }



        public bool Save(
			string Comment,
			string User,
			string Reason)
        {

            try
            {
                var result = (bool) teklaObject.Save(Comment, User, Reason);
            
                return result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Save), ex);
            }
        }



        public bool Open(
			string ModelFolder,
			bool OpenAutoSaved)
        {
            try
            {
                var result = (bool) teklaObject.Open(ModelFolder, OpenAutoSaved);
            
                return result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Open), ex);
            }
        }



        public void Close()
        {
            
            try
            {
                teklaObject.Close();
            
                
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Close), ex);
            }
        }



        public bool IsModelSaved()
        {
            
            try
            {
                var result = (bool) teklaObject.IsModelSaved();
            
                return result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(IsModelSaved), ex);
            }
        }



        public bool IsModelAutoSaved(
			string ModelFolder)
        {
            
            try
            {
                var result = (bool) teklaObject.IsModelAutoSaved(ModelFolder);
            
                return result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(IsModelAutoSaved), ex);
            }
        }






    }

    internal static class ModelHandler_
    {
        public static dynamic GetTSObject(ModelHandler dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static ModelHandler FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (ModelHandler)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ModelHandlerArray_
    {
        public static dynamic GetTSObject(ModelHandler[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ModelHandler_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ModelHandler[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<ModelHandler>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ModelHandler_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    
