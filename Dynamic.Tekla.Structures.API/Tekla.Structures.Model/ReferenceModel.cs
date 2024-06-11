using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;

namespace Dynamic.Tekla.Structures.Model;

public  class ReferenceModel  : ModelObject
    {


        public string Filename
        {
            get
            {
                try
                {
                return teklaObject.Filename;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Filename), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.Filename = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Filename), ex); 
                }
            }
        }

        public string ActiveFilePath
        {
            get
            {
                try
                {
                return teklaObject.ActiveFilePath;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ActiveFilePath), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.ActiveFilePath = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ActiveFilePath), ex); 
                }
            }
        }

        public string Title
        {
            get
            {
                try
                {
                return teklaObject.Title;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Title), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.Title = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Title), ex); 
                }
            }
        }

        public Dynamic.Tekla.Structures.Geometry3d.Point Position
        {
            get
            {
                try
                {
                var value = teklaObject.Position;
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Geometry3d.Point) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Position), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
                teklaObject.Position = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Position), ex); 
                }
            }
        }

        public double Scale
        {
            get
            {
                try
                {
                return teklaObject.Scale;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Scale), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.Scale = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Scale), ex); 
                }
            }
        }

        public ReferenceModel.VisibilityEnum Visibility
        {
            get
            {
                try
                {
                var value = teklaObject.Visibility;
                var value_ = ReferenceModel.VisibilityEnum_.FromTSObject(value);
                return (ReferenceModel.VisibilityEnum) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Visibility), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = ReferenceModel.VisibilityEnum_.GetTSObject(value);
                teklaObject.Visibility = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Visibility), ex); 
                }
            }
        }

        public System.Guid BasePointGuid
        {
            get
            {
                try
                {
                return teklaObject.BasePointGuid;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(BasePointGuid), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.BasePointGuid = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(BasePointGuid), ex); 
                }
            }
        }

        public bool UseWorkplane
        {
            get
            {
                try
                {
                return teklaObject.UseWorkplane;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(UseWorkplane), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.UseWorkplane = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(UseWorkplane), ex); 
                }
            }
        }

        public double Rotation
        {
            get
            {
                try
                {
                return teklaObject.Rotation;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Rotation), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.Rotation = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Rotation), ex); 
                }
            }
        }

        //public Geometry.Rotation3D Rotation3D
        //{
        //    get
        //    {
        //        try
        //        {
        //        var value = teklaObject.Rotation3D;
        //        var value_ = Geometry.Rotation3D_.FromTSObject(value);
        //        return (Geometry.Rotation3D) value_;
        //        }
        //        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        //        {
        //            throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Rotation3D), ex); 
        //        }
        //    }
        //    set
        //    {
        //        try
        //        {
        //        var value_ = Geometry.Rotation3D_.GetTSObject(value);
        //        teklaObject.Rotation3D = value_;
        //        }
        //        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        //        {
        //            throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Rotation3D), ex); 
        //        }
        //    }
        //}

        public System.Guid ProjectGUID
        {
            get
            {
                try
                {
                return teklaObject.ProjectGUID;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ProjectGUID), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.ProjectGUID = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ProjectGUID), ex); 
                }
            }
        }

        public System.Guid ModelGUID
        {
            get
            {
                try
                {
                return teklaObject.ModelGUID;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ModelGUID), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.ModelGUID = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ModelGUID), ex); 
                }
            }
        }

        public System.Guid VersionGUID
        {
            get
            {
                try
                {
                return teklaObject.VersionGUID;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(VersionGUID), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.VersionGUID = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(VersionGUID), ex); 
                }
            }
        }
        

        

		public ReferenceModel()
		{
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ReferenceModel");
		}
		
		public ReferenceModel(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			teklaObject = tsObject;
		}
		public ReferenceModel(string filename, Dynamic.Tekla.Structures.Geometry3d.Point position, double scale)
		{
			var args = new object[3];
			args[0] = filename;
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(position);
			args[2] = scale;
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ReferenceModel", args);
		}


        public ModelObjectEnumerator GetConvertedObjects()
        {
            
            try
            {
                var result = teklaObject.GetConvertedObjects();
            
                var _result = ModelObjectEnumerator_.FromTSObject(result);
				return _result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetConvertedObjects), ex);
            }
        }



        public bool RefreshFile()
        {
            
            try
            {
                var result = (bool) teklaObject.RefreshFile();
            
                return result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(RefreshFile), ex);
            }
        }



        public System.Collections.Generic.List<ReferenceModel.Revision> GetRevisions()
        {
            
            try
            {
                var result = teklaObject.GetRevisions();
            
                var _result = ListConverter.FromTSObjects<ReferenceModel.Revision>(result);
				return _result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetRevisions), ex);
            }
        }



        public ReferenceModelObject GetReferenceModelObjectByExternalGuid(
			string externalGuid)
        {
            
            try
            {
                var result = teklaObject.GetReferenceModelObjectByExternalGuid(externalGuid);
            
                var _result = ReferenceModelObject_.FromTSObject(result);
				return _result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetReferenceModelObjectByExternalGuid), ex);
            }
        }



        public System.Collections.Generic.List<string> GetReferenceModelObjectGuidsByExternalGuids(
			System.Collections.Generic.List<string> externalGuids)
        {
            
            try
            {
                var result = (System.Collections.Generic.List<string>) teklaObject.GetReferenceModelObjectGuidsByExternalGuids(externalGuids);
            
                return result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetReferenceModelObjectGuidsByExternalGuids), ex);
            }
        }



        public bool SetAsCurrentRevision(
			ReferenceModel.Revision revision_)
        {
            var revision = ReferenceModel.Revision_.GetTSObject(revision_);
            try
            {
                var result = (bool) teklaObject.SetAsCurrentRevision(revision);
            
                return result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SetAsCurrentRevision), ex);
            }
        }



        public bool SetAsCurrentRevision(
			int modelId,
			int revisionId)
        {
            try
            {
                var result = (bool) teklaObject.SetAsCurrentRevision(modelId, revisionId);
            
                return result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SetAsCurrentRevision), ex);
            }
        }



        public ReferenceModel.Revision GetCurrentRevision()
        {
            
            try
            {
                var result = teklaObject.GetCurrentRevision();
            
                var _result = ReferenceModel.Revision_.FromTSObject(result);
				return _result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetCurrentRevision), ex);
            }
        }



        public bool RemoveRevision(
			ReferenceModel.Revision revision_)
        {
            var revision = ReferenceModel.Revision_.GetTSObject(revision_);
            try
            {
                var result = (bool) teklaObject.RemoveRevision(revision);
            
                return result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(RemoveRevision), ex);
            }
        }





    public struct Revision
    {
       
    }

    internal static class Revision_
    {
        public static dynamic GetTSObject(Revision dynStruct)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.Revision");

            return tsType;
        }
    
        public static Revision FromTSObject(dynamic tsStruct)
        {
            var dynStruct = new Revision();
 
            return dynStruct;
        }
    }


    public enum VisibilityEnum
    {
			HIDDEN,
			VISIBLE        
    }

    internal static class VisibilityEnum_
    {
        public static dynamic GetTSObject(VisibilityEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.ReferenceModel.VisibilityEnum").GetType();

            switch (dynEnum)
            {
				case VisibilityEnum.HIDDEN:
					return System.Enum.Parse(tsType, "HIDDEN");
				case VisibilityEnum.VISIBLE:
					return System.Enum.Parse(tsType, "VISIBLE");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static VisibilityEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("HIDDEN", System.StringComparison.InvariantCulture))
				return VisibilityEnum.HIDDEN;
			else if (tsEnumValue.Equals("VISIBLE", System.StringComparison.InvariantCulture))
				return VisibilityEnum.VISIBLE;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class ReferenceModel_
    {
        public static dynamic GetTSObject(ReferenceModel dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static ReferenceModel FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (ReferenceModel)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ReferenceModelArray_
    {
        public static dynamic GetTSObject(ReferenceModel[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ReferenceModel_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ReferenceModel[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<ReferenceModel>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ReferenceModel_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


   
