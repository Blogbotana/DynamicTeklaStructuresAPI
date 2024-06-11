using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;

namespace Dynamic.Tekla.Structures.Model;

public  class Seam  : BaseComponent
    {


        public Dynamic.Tekla.Structures.Geometry3d.Vector UpVector
        {
            get
            {
                try
                {
                var value = teklaObject.UpVector;
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Geometry3d.Vector) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(UpVector), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value);
                teklaObject.UpVector = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(UpVector), ex); 
                }
            }
        }

        public Dynamic.Tekla.Structures.AutoDirectionTypeEnum AutoDirectionType
        {
            get
            {
                try
                {
                var value = teklaObject.AutoDirectionType;
                var value_ = Dynamic.Tekla.Structures.AutoDirectionTypeEnum_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.AutoDirectionTypeEnum) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(AutoDirectionType), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Dynamic.Tekla.Structures.AutoDirectionTypeEnum_.GetTSObject(value);
                teklaObject.AutoDirectionType = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(AutoDirectionType), ex); 
                }
            }
        }

        public bool AutoPosition
        {
            get
            {
                try
                {
                return teklaObject.AutoPosition;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(AutoPosition), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.AutoPosition = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(AutoPosition), ex); 
                }
            }
        }

        public string Code
        {
            get
            {
                try
                {
                return teklaObject.Code;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Code), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.Code = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Code), ex); 
                }
            }
        }

        public int Class
        {
            get
            {
                try
                {
                return teklaObject.Class;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Class), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.Class = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Class), ex); 
                }
            }
        }

        public Dynamic.Tekla.Structures.ConnectionStatusEnum Status
        {
            get
            {
                try
                {
                var value = teklaObject.Status;
                var value_ = Dynamic.Tekla.Structures.ConnectionStatusEnum_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.ConnectionStatusEnum) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Status), ex); 
                }
            }
            
        }
        

        

		public Seam()
		{
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Seam");
		}
		
		public Seam(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			teklaObject = tsObject;
		}


        public bool SetPrimaryObject(
			ModelObject M_)
        {
            var M = ModelObject_.GetTSObject(M_);
            try
            {
                var result = (bool) teklaObject.SetPrimaryObject(M);
            
                return result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SetPrimaryObject), ex);
            }
        }



        public ModelObject GetPrimaryObject()
        {
            
            try
            {
                var result = teklaObject.GetPrimaryObject();
            
                var _result = ModelObject_.FromTSObject(result);
				return _result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetPrimaryObject), ex);
            }
        }



        public bool SetSecondaryObject(
			ModelObject M_)
        {
            var M = ModelObject_.GetTSObject(M_);
            try
            {
                var result = (bool) teklaObject.SetSecondaryObject(M);
            
                return result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SetSecondaryObject), ex);
            }
        }



        public bool SetSecondaryObjects(
			System.Collections.ArrayList Secondaries_)
        {
            var Secondaries = ArrayListConverter.ToTSObjects(Secondaries_);
            try
            {
                var result = (bool) teklaObject.SetSecondaryObjects(Secondaries);
            
                return result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SetSecondaryObjects), ex);
            }
        }



        public System.Collections.ArrayList GetSecondaryObjects()
        {
            
            try
            {
                var result = teklaObject.GetSecondaryObjects();
            
                var _result = ArrayListConverter.FromTSObjects(result);
				return _result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetSecondaryObjects), ex);
            }
        }



        public bool SetInputPositions(
			Dynamic.Tekla.Structures.Geometry3d.Point StartPoint_,
			Dynamic.Tekla.Structures.Geometry3d.Point EndPoint_)
        {
            var StartPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(StartPoint_);
var EndPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(EndPoint_);
            try
            {
                var result = (bool) teklaObject.SetInputPositions(StartPoint, EndPoint);
            
                return result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SetInputPositions), ex);
            }
        }



        public bool GetStartAndEndPositions(
			ref Dynamic.Tekla.Structures.Geometry3d.Point StartPoint_,
			ref Dynamic.Tekla.Structures.Geometry3d.Point EndPoint_)
        {
            var StartPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(StartPoint_);
var EndPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(EndPoint_);
            try
            {
                var result = (bool) teklaObject.GetStartAndEndPositions(ref StartPoint, ref EndPoint);
            StartPoint_ = Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(StartPoint);
EndPoint_ = Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(EndPoint);
                return result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetStartAndEndPositions), ex);
            }
        }



        public bool SetInputPolygon(
			Polygon InputPolygon_)
        {
            var InputPolygon = Polygon_.GetTSObject(InputPolygon_);
            try
            {
                var result = (bool) teklaObject.SetInputPolygon(InputPolygon);
            
                return result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SetInputPolygon), ex);
            }
        }



        public Polygon GetInputPolygon()
        {
            
            try
            {
                var result = teklaObject.GetInputPolygon();
            
                var _result = Polygon_.FromTSObject(result);
				return _result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetInputPolygon), ex);
            }
        }






    }

    internal static class Seam_
    {
        public static dynamic GetTSObject(Seam dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static Seam FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Seam)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class SeamArray_
    {
        public static dynamic GetTSObject(Seam[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Seam_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Seam[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<Seam>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Seam_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    
