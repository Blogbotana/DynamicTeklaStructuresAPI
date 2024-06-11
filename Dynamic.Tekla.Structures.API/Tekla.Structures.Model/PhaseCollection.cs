using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic.Tekla.Structures.Model;

public  class PhaseCollection 
    {


        public int Count
        {
            get
            {
                try
                {
                return teklaObject.Count;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Count), ex); 
                }
            }
            
        }

        public bool IsSynchronized
        {
            get
            {
                try
                {
                return teklaObject.IsSynchronized;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(IsSynchronized), ex); 
                }
            }
            
        }

        public System.Object SyncRoot
        {
            get
            {
                try
                {
                return teklaObject.SyncRoot;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(SyncRoot), ex); 
                }
            }
            
        }
        

        internal dynamic teklaObject;

		internal PhaseCollection() {}
		
		public PhaseCollection(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			teklaObject = tsObject;
		}


        public System.Collections.IEnumerator GetEnumerator()
        {
            var list = new System.Collections.Generic.List<Phase>();
            foreach (var tsPhase in teklaObject)
            {
                list.Add(Phase_.FromTSObject(tsPhase));
            }
            return list.GetEnumerator();
        }





    }

    internal static class PhaseCollection_
    {
        public static dynamic GetTSObject(PhaseCollection dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static PhaseCollection FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (PhaseCollection)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PhaseCollectionArray_
    {
        public static dynamic GetTSObject(PhaseCollection[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(PhaseCollection_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static PhaseCollection[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<PhaseCollection>();
            foreach(var tsItem in tsArray)
            {
                list.Add(PhaseCollection_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    
