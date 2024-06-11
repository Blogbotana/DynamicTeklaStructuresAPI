using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;

namespace Dynamic.Tekla.Structures.Model;

public  class RebarLegFace 
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

        public double AdditonalOffset
        {
            get
            {
                try
                {
                return teklaObject.AdditonalOffset;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(AdditonalOffset), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.AdditonalOffset = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(AdditonalOffset), ex); 
                }
            }
        }

        public int LayerOrderNumber
        {
            get
            {
                try
                {
                return teklaObject.LayerOrderNumber;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LayerOrderNumber), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.LayerOrderNumber = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LayerOrderNumber), ex); 
                }
            }
        }

        public bool Reversed
        {
            get
            {
                try
                {
                return teklaObject.Reversed;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Reversed), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.Reversed = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Reversed), ex); 
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

		public RebarLegFace()
		{
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.RebarLegFace");
		}
		
		public RebarLegFace(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			teklaObject = tsObject;
		}
		public RebarLegFace(Contour contour)
		{
			var args = new object[1];
			args[0] = Contour_.GetTSObject(contour);
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.RebarLegFace", args);
		}





    }

    internal static class RebarLegFace_
    {
        public static dynamic GetTSObject(RebarLegFace dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static RebarLegFace FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (RebarLegFace)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class RebarLegFaceArray_
    {
        public static dynamic GetTSObject(RebarLegFace[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(RebarLegFace_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static RebarLegFace[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<RebarLegFace>();
            foreach(var tsItem in tsArray)
            {
                list.Add(RebarLegFace_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    
