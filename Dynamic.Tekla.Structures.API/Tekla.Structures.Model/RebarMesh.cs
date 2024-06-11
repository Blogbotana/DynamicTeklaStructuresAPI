using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;

namespace Dynamic.Tekla.Structures.Model;
public  class RebarMesh  : Reinforcement
    {


        public RebarMesh.RebarMeshTypeEnum MeshType
        {
            get
            {
                try
                {
                var value = teklaObject.MeshType;
                var value_ = RebarMesh.RebarMeshTypeEnum_.FromTSObject(value);
                return (RebarMesh.RebarMeshTypeEnum) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(MeshType), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = RebarMesh.RebarMeshTypeEnum_.GetTSObject(value);
                teklaObject.MeshType = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(MeshType), ex); 
                }
            }
        }

        public RebarMesh.RebarMeshSpacingMethodEnum LongitudinalSpacingMethod
        {
            get
            {
                try
                {
                var value = teklaObject.LongitudinalSpacingMethod;
                var value_ = RebarMesh.RebarMeshSpacingMethodEnum_.FromTSObject(value);
                return (RebarMesh.RebarMeshSpacingMethodEnum) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LongitudinalSpacingMethod), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = RebarMesh.RebarMeshSpacingMethodEnum_.GetTSObject(value);
                teklaObject.LongitudinalSpacingMethod = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LongitudinalSpacingMethod), ex); 
                }
            }
        }

        public Polygon Polygon
        {
            get
            {
                try
                {
                var value = teklaObject.Polygon;
                var value_ = Polygon_.FromTSObject(value);
                return (Polygon) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Polygon), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Polygon_.GetTSObject(value);
                teklaObject.Polygon = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Polygon), ex); 
                }
            }
        }

        public System.Collections.ArrayList LongitudinalDistances
        {
            get
            {
                try
                {
                var value = teklaObject.LongitudinalDistances;
                var value_ = ArrayListConverter.FromTSObjects(value);
                return (System.Collections.ArrayList) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LongitudinalDistances), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = ArrayListConverter.ToTSObjects(value);
                teklaObject.LongitudinalDistances = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LongitudinalDistances), ex); 
                }
            }
        }

        public System.Collections.ArrayList CrossDistances
        {
            get
            {
                try
                {
                var value = teklaObject.CrossDistances;
                var value_ = ArrayListConverter.FromTSObjects(value);
                return (System.Collections.ArrayList) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(CrossDistances), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = ArrayListConverter.ToTSObjects(value);
                teklaObject.CrossDistances = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(CrossDistances), ex); 
                }
            }
        }

        public double FromPlaneOffset
        {
            get
            {
                try
                {
                return teklaObject.FromPlaneOffset;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(FromPlaneOffset), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.FromPlaneOffset = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(FromPlaneOffset), ex); 
                }
            }
        }

        public double StartFromPlaneOffset
        {
            get
            {
                try
                {
                return teklaObject.StartFromPlaneOffset;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(StartFromPlaneOffset), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.StartFromPlaneOffset = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(StartFromPlaneOffset), ex); 
                }
            }
        }

        public double EndFromPlaneOffset
        {
            get
            {
                try
                {
                return teklaObject.EndFromPlaneOffset;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(EndFromPlaneOffset), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.EndFromPlaneOffset = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(EndFromPlaneOffset), ex); 
                }
            }
        }

        public Dynamic.Tekla.Structures.Geometry3d.Point StartPoint
        {
            get
            {
                try
                {
                var value = teklaObject.StartPoint;
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Geometry3d.Point) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(StartPoint), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
                teklaObject.StartPoint = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(StartPoint), ex); 
                }
            }
        }

        public Dynamic.Tekla.Structures.Geometry3d.Point EndPoint
        {
            get
            {
                try
                {
                var value = teklaObject.EndPoint;
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Geometry3d.Point) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(EndPoint), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
                teklaObject.EndPoint = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(EndPoint), ex); 
                }
            }
        }

        public double LeftOverhangLongitudinal
        {
            get
            {
                try
                {
                return teklaObject.LeftOverhangLongitudinal;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LeftOverhangLongitudinal), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.LeftOverhangLongitudinal = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LeftOverhangLongitudinal), ex); 
                }
            }
        }

        public double LeftOverhangCross
        {
            get
            {
                try
                {
                return teklaObject.LeftOverhangCross;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LeftOverhangCross), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.LeftOverhangCross = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LeftOverhangCross), ex); 
                }
            }
        }

        public double RightOverhangLongitudinal
        {
            get
            {
                try
                {
                return teklaObject.RightOverhangLongitudinal;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(RightOverhangLongitudinal), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.RightOverhangLongitudinal = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(RightOverhangLongitudinal), ex); 
                }
            }
        }

        public double RightOverhangCross
        {
            get
            {
                try
                {
                return teklaObject.RightOverhangCross;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(RightOverhangCross), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.RightOverhangCross = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(RightOverhangCross), ex); 
                }
            }
        }

        public string LongitudinalSize
        {
            get
            {
                try
                {
                return teklaObject.LongitudinalSize;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LongitudinalSize), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.LongitudinalSize = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LongitudinalSize), ex); 
                }
            }
        }

        public string CrossSize
        {
            get
            {
                try
                {
                return teklaObject.CrossSize;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(CrossSize), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.CrossSize = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(CrossSize), ex); 
                }
            }
        }

        public double Width
        {
            get
            {
                try
                {
                return teklaObject.Width;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Width), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.Width = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Width), ex); 
                }
            }
        }

        public double Length
        {
            get
            {
                try
                {
                return teklaObject.Length;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Length), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.Length = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Length), ex); 
                }
            }
        }

        public bool CutByFatherPartCuts
        {
            get
            {
                try
                {
                return teklaObject.CutByFatherPartCuts;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(CutByFatherPartCuts), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.CutByFatherPartCuts = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(CutByFatherPartCuts), ex); 
                }
            }
        }

        public string CatalogName
        {
            get
            {
                try
                {
                return teklaObject.CatalogName;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(CatalogName), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.CatalogName = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(CatalogName), ex); 
                }
            }
        }

        public RebarMesh.RebarMeshCrossBarLocationEnum CrossBarLocation
        {
            get
            {
                try
                {
                var value = teklaObject.CrossBarLocation;
                var value_ = RebarMesh.RebarMeshCrossBarLocationEnum_.FromTSObject(value);
                return (RebarMesh.RebarMeshCrossBarLocationEnum) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(CrossBarLocation), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = RebarMesh.RebarMeshCrossBarLocationEnum_.GetTSObject(value);
                teklaObject.CrossBarLocation = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(CrossBarLocation), ex); 
                }
            }
        }

        public RebarHookData StartHook
        {
            get
            {
                try
                {
                var value = teklaObject.StartHook;
                var value_ = RebarHookData_.FromTSObject(value);
                return (RebarHookData) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(StartHook), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = RebarHookData_.GetTSObject(value);
                teklaObject.StartHook = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(StartHook), ex); 
                }
            }
        }

        public RebarHookData EndHook
        {
            get
            {
                try
                {
                var value = teklaObject.EndHook;
                var value_ = RebarHookData_.FromTSObject(value);
                return (RebarHookData) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(EndHook), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = RebarHookData_.GetTSObject(value);
                teklaObject.EndHook = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(EndHook), ex); 
                }
            }
        }
        

        

		public RebarMesh()
		{
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.RebarMesh");
		}
		
		public RebarMesh(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			teklaObject = tsObject;
		}




    public enum RebarMeshTypeEnum
    {
			UNKNOWN_MESH,
			RECTANGULAR_MESH,
			POLYGON_MESH,
			BENT_MESH        
    }

    internal static class RebarMeshTypeEnum_
    {
        public static dynamic GetTSObject(RebarMeshTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.RebarMesh.RebarMeshTypeEnum").GetType();

            switch (dynEnum)
            {
				case RebarMeshTypeEnum.UNKNOWN_MESH:
					return System.Enum.Parse(tsType, "UNKNOWN_MESH");
				case RebarMeshTypeEnum.RECTANGULAR_MESH:
					return System.Enum.Parse(tsType, "RECTANGULAR_MESH");
				case RebarMeshTypeEnum.POLYGON_MESH:
					return System.Enum.Parse(tsType, "POLYGON_MESH");
				case RebarMeshTypeEnum.BENT_MESH:
					return System.Enum.Parse(tsType, "BENT_MESH");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static RebarMeshTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("UNKNOWN_MESH", System.StringComparison.InvariantCulture))
				return RebarMeshTypeEnum.UNKNOWN_MESH;
			else if (tsEnumValue.Equals("RECTANGULAR_MESH", System.StringComparison.InvariantCulture))
				return RebarMeshTypeEnum.RECTANGULAR_MESH;
			else if (tsEnumValue.Equals("POLYGON_MESH", System.StringComparison.InvariantCulture))
				return RebarMeshTypeEnum.POLYGON_MESH;
			else if (tsEnumValue.Equals("BENT_MESH", System.StringComparison.InvariantCulture))
				return RebarMeshTypeEnum.BENT_MESH;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public enum RebarMeshSpacingMethodEnum
    {
			SPACING_TYPE_UNDEFINED,
			SPACING_TYPE_SAME_DISTANCE,
			SPACING_TYPE_MULTIPLE_VARYING_DISTANCES        
    }

    internal static class RebarMeshSpacingMethodEnum_
    {
        public static dynamic GetTSObject(RebarMeshSpacingMethodEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.RebarMesh.RebarMeshSpacingMethodEnum").GetType();

            switch (dynEnum)
            {
				case RebarMeshSpacingMethodEnum.SPACING_TYPE_UNDEFINED:
					return System.Enum.Parse(tsType, "SPACING_TYPE_UNDEFINED");
				case RebarMeshSpacingMethodEnum.SPACING_TYPE_SAME_DISTANCE:
					return System.Enum.Parse(tsType, "SPACING_TYPE_SAME_DISTANCE");
				case RebarMeshSpacingMethodEnum.SPACING_TYPE_MULTIPLE_VARYING_DISTANCES:
					return System.Enum.Parse(tsType, "SPACING_TYPE_MULTIPLE_VARYING_DISTANCES");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static RebarMeshSpacingMethodEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("SPACING_TYPE_UNDEFINED", System.StringComparison.InvariantCulture))
				return RebarMeshSpacingMethodEnum.SPACING_TYPE_UNDEFINED;
			else if (tsEnumValue.Equals("SPACING_TYPE_SAME_DISTANCE", System.StringComparison.InvariantCulture))
				return RebarMeshSpacingMethodEnum.SPACING_TYPE_SAME_DISTANCE;
			else if (tsEnumValue.Equals("SPACING_TYPE_MULTIPLE_VARYING_DISTANCES", System.StringComparison.InvariantCulture))
				return RebarMeshSpacingMethodEnum.SPACING_TYPE_MULTIPLE_VARYING_DISTANCES;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public enum RebarMeshCrossBarLocationEnum
    {
			LOCATION_TYPE_ABOVE,
			LOCATION_TYPE_BELOW,
			LOCATION_TYPE_UNDEFINED        
    }

    internal static class RebarMeshCrossBarLocationEnum_
    {
        public static dynamic GetTSObject(RebarMeshCrossBarLocationEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.RebarMesh.RebarMeshCrossBarLocationEnum").GetType();

            switch (dynEnum)
            {
				case RebarMeshCrossBarLocationEnum.LOCATION_TYPE_ABOVE:
					return System.Enum.Parse(tsType, "LOCATION_TYPE_ABOVE");
				case RebarMeshCrossBarLocationEnum.LOCATION_TYPE_BELOW:
					return System.Enum.Parse(tsType, "LOCATION_TYPE_BELOW");
				case RebarMeshCrossBarLocationEnum.LOCATION_TYPE_UNDEFINED:
					return System.Enum.Parse(tsType, "LOCATION_TYPE_UNDEFINED");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static RebarMeshCrossBarLocationEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("LOCATION_TYPE_ABOVE", System.StringComparison.InvariantCulture))
				return RebarMeshCrossBarLocationEnum.LOCATION_TYPE_ABOVE;
			else if (tsEnumValue.Equals("LOCATION_TYPE_BELOW", System.StringComparison.InvariantCulture))
				return RebarMeshCrossBarLocationEnum.LOCATION_TYPE_BELOW;
			else if (tsEnumValue.Equals("LOCATION_TYPE_UNDEFINED", System.StringComparison.InvariantCulture))
				return RebarMeshCrossBarLocationEnum.LOCATION_TYPE_UNDEFINED;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class RebarMesh_
    {
        public static dynamic GetTSObject(RebarMesh dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static RebarMesh FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (RebarMesh)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class RebarMeshArray_
    {
        public static dynamic GetTSObject(RebarMesh[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(RebarMesh_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static RebarMesh[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<RebarMesh>();
            foreach(var tsItem in tsArray)
            {
                list.Add(RebarMesh_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    
