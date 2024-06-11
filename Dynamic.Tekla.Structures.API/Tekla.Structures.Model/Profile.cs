using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;

namespace Dynamic.Tekla.Structures.Model;
public  class Profile 
    {


        public string ProfileString
        {
            get
            {
                try
                {
                return teklaObject.ProfileString;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ProfileString), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.ProfileString = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ProfileString), ex); 
                }
            }
        }
        

        internal dynamic teklaObject;

		public Profile()
		{
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Profile");
		}
		
		public Profile(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			teklaObject = tsObject;
		}


        public static string ParseProfileString(
			string profileString)
        {
            var result = (string) MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Profile", "ParseProfileString", profileString);
            return result;
        }



        public static string FormatProfileString(
			string profileString)
        {
            var result = (string) MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Profile", "FormatProfileString", profileString);
            return result;
        }






    }

    internal static class Profile_
    {
        public static dynamic GetTSObject(Profile dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static Profile FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Profile)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ProfileArray_
    {
        public static dynamic GetTSObject(Profile[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Profile_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Profile[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<Profile>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Profile_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    
