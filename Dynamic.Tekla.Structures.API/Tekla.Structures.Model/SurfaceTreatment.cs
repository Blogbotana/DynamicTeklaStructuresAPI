using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;

namespace Dynamic.Tekla.Structures.Model;
public  class SurfaceTreatment  : ModelObject
    {


        public SurfaceTreatment.SurfaceTypeEnum Type
        {
            get
            {
                try
                {
                var value = teklaObject.Type;
                var value_ = SurfaceTreatment.SurfaceTypeEnum_.FromTSObject(value);
                return (SurfaceTreatment.SurfaceTypeEnum) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Type), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = SurfaceTreatment.SurfaceTypeEnum_.GetTSObject(value);
                teklaObject.Type = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Type), ex); 
                }
            }
        }

        public SurfaceTreatment.SurfaceColorEnum Color
        {
            get
            {
                try
                {
                var value = teklaObject.Color;
                var value_ = SurfaceTreatment.SurfaceColorEnum_.FromTSObject(value);
                return (SurfaceTreatment.SurfaceColorEnum) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Color), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = SurfaceTreatment.SurfaceColorEnum_.GetTSObject(value);
                teklaObject.Color = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Color), ex); 
                }
            }
        }

        public Material Material
        {
            get
            {
                try
                {
                var value = teklaObject.Material;
                var value_ = Material_.FromTSObject(value);
                return (Material) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Material), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Material_.GetTSObject(value);
                teklaObject.Material = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Material), ex); 
                }
            }
        }

        public Position Position
        {
            get
            {
                try
                {
                var value = teklaObject.Position;
                var value_ = Position_.FromTSObject(value);
                return (Position) value_;
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
                var value_ = Position_.GetTSObject(value);
                teklaObject.Position = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Position), ex); 
                }
            }
        }

        public Contour Polygon
        {
            get
            {
                try
                {
                var value = teklaObject.Polygon;
                var value_ = Contour_.FromTSObject(value);
                return (Contour) value_;
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
                var value_ = Contour_.GetTSObject(value);
                teklaObject.Polygon = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Polygon), ex); 
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

        public Part Father
        {
            get
            {
                try
                {
                var value = teklaObject.Father;
                var value_ = Part_.FromTSObject(value);
                return (Part) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Father), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Part_.GetTSObject(value);
                teklaObject.Father = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Father), ex); 
                }
            }
        }

        public double Thickness
        {
            get
            {
                try
                {
                return teklaObject.Thickness;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Thickness), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.Thickness = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Thickness), ex); 
                }
            }
        }

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

        public string Class
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

        public bool CutByFatherBooleans
        {
            get
            {
                try
                {
                return teklaObject.CutByFatherBooleans;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(CutByFatherBooleans), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.CutByFatherBooleans = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(CutByFatherBooleans), ex); 
                }
            }
        }

        public string TypeName
        {
            get
            {
                try
                {
                return teklaObject.TypeName;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(TypeName), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.TypeName = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(TypeName), ex); 
                }
            }
        }
        

        

		public SurfaceTreatment()
		{
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.SurfaceTreatment");
		}
		
		public SurfaceTreatment(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			teklaObject = tsObject;
		}




    public enum SurfaceTypeEnum
    {
			CONCRETE_FINISH,
			SPECIAL_MIX,
			TILE_SURFACE,
			STEEL_FINISH        
    }

    internal static class SurfaceTypeEnum_
    {
        public static dynamic GetTSObject(SurfaceTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.SurfaceTreatment.SurfaceTypeEnum").GetType();

            switch (dynEnum)
            {
				case SurfaceTypeEnum.CONCRETE_FINISH:
					return System.Enum.Parse(tsType, "CONCRETE_FINISH");
				case SurfaceTypeEnum.SPECIAL_MIX:
					return System.Enum.Parse(tsType, "SPECIAL_MIX");
				case SurfaceTypeEnum.TILE_SURFACE:
					return System.Enum.Parse(tsType, "TILE_SURFACE");
				case SurfaceTypeEnum.STEEL_FINISH:
					return System.Enum.Parse(tsType, "STEEL_FINISH");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static SurfaceTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("CONCRETE_FINISH", System.StringComparison.InvariantCulture))
				return SurfaceTypeEnum.CONCRETE_FINISH;
			else if (tsEnumValue.Equals("SPECIAL_MIX", System.StringComparison.InvariantCulture))
				return SurfaceTypeEnum.SPECIAL_MIX;
			else if (tsEnumValue.Equals("TILE_SURFACE", System.StringComparison.InvariantCulture))
				return SurfaceTypeEnum.TILE_SURFACE;
			else if (tsEnumValue.Equals("STEEL_FINISH", System.StringComparison.InvariantCulture))
				return SurfaceTypeEnum.STEEL_FINISH;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public enum SurfaceColorEnum
    {
			WHITE,
			RED,
			GREEN,
			BLUE,
			CYAN,
			YELLOW,
			MAGENTA        
    }

    internal static class SurfaceColorEnum_
    {
        public static dynamic GetTSObject(SurfaceColorEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.SurfaceTreatment.SurfaceColorEnum").GetType();

            switch (dynEnum)
            {
				case SurfaceColorEnum.WHITE:
					return System.Enum.Parse(tsType, "WHITE");
				case SurfaceColorEnum.RED:
					return System.Enum.Parse(tsType, "RED");
				case SurfaceColorEnum.GREEN:
					return System.Enum.Parse(tsType, "GREEN");
				case SurfaceColorEnum.BLUE:
					return System.Enum.Parse(tsType, "BLUE");
				case SurfaceColorEnum.CYAN:
					return System.Enum.Parse(tsType, "CYAN");
				case SurfaceColorEnum.YELLOW:
					return System.Enum.Parse(tsType, "YELLOW");
				case SurfaceColorEnum.MAGENTA:
					return System.Enum.Parse(tsType, "MAGENTA");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static SurfaceColorEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("WHITE", System.StringComparison.InvariantCulture))
				return SurfaceColorEnum.WHITE;
			else if (tsEnumValue.Equals("RED", System.StringComparison.InvariantCulture))
				return SurfaceColorEnum.RED;
			else if (tsEnumValue.Equals("GREEN", System.StringComparison.InvariantCulture))
				return SurfaceColorEnum.GREEN;
			else if (tsEnumValue.Equals("BLUE", System.StringComparison.InvariantCulture))
				return SurfaceColorEnum.BLUE;
			else if (tsEnumValue.Equals("CYAN", System.StringComparison.InvariantCulture))
				return SurfaceColorEnum.CYAN;
			else if (tsEnumValue.Equals("YELLOW", System.StringComparison.InvariantCulture))
				return SurfaceColorEnum.YELLOW;
			else if (tsEnumValue.Equals("MAGENTA", System.StringComparison.InvariantCulture))
				return SurfaceColorEnum.MAGENTA;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class SurfaceTreatment_
    {
        public static dynamic GetTSObject(SurfaceTreatment dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static SurfaceTreatment FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (SurfaceTreatment)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class SurfaceTreatmentArray_
    {
        public static dynamic GetTSObject(SurfaceTreatment[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(SurfaceTreatment_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static SurfaceTreatment[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<SurfaceTreatment>();
            foreach(var tsItem in tsArray)
            {
                list.Add(SurfaceTreatment_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    
