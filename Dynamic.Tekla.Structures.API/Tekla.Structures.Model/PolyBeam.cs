using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;

namespace Dynamic.Tekla.Structures.Model;

public  class PolyBeam  : Part
    {


        public PolyBeam.PolyBeamTypeEnum Type
        {
            get
            {
                try
                {
                var value = teklaObject.Type;
                var value_ = PolyBeam.PolyBeamTypeEnum_.FromTSObject(value);
                return (PolyBeam.PolyBeamTypeEnum) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Type), ex); 
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
        

        

		public PolyBeam()
		{
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.PolyBeam");
		}
		
		public PolyBeam(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			teklaObject = tsObject;
		}
		public PolyBeam(PolyBeam.PolyBeamTypeEnum polyBeamType)
		{
			var args = new object[1];
			args[0] = PolyBeam.PolyBeamTypeEnum_.GetTSObject(polyBeamType);
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.PolyBeam", args);
		}


        public bool AddContourPoint(
			ContourPoint contourPoint_)
        {
            var contourPoint = ContourPoint_.GetTSObject(contourPoint_);
            try
            {
                var result = (bool) teklaObject.AddContourPoint(contourPoint);
            
                return result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(AddContourPoint), ex);
            }
        }



        public System.Collections.ArrayList GetPolybeamCoordinateSystems()
        {
            
            try
            {
                var result = teklaObject.GetPolybeamCoordinateSystems();
            
                var _result = ArrayListConverter.FromTSObjects(result);
				return _result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetPolybeamCoordinateSystems), ex);
            }
        }



        public Dynamic.Tekla.Structures.Geometry3d.Polycurve GetCenterLinePolycurve()
        {
            
            try
            {
                var result = teklaObject.GetCenterLinePolycurve();
            
                var _result = Dynamic.Tekla.Structures.Geometry3d.Polycurve_.FromTSObject(result);
				return _result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetCenterLinePolycurve), ex);
            }
        }





    public enum PolyBeamTypeEnum
    {
			BEAM,
			PANEL,
			STRIP_FOOTING,
			COLUMN        
    }

    internal static class PolyBeamTypeEnum_
    {
        public static dynamic GetTSObject(PolyBeamTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.PolyBeam.PolyBeamTypeEnum").GetType();

            switch (dynEnum)
            {
				case PolyBeamTypeEnum.BEAM:
					return System.Enum.Parse(tsType, "BEAM");
				case PolyBeamTypeEnum.PANEL:
					return System.Enum.Parse(tsType, "PANEL");
				case PolyBeamTypeEnum.STRIP_FOOTING:
					return System.Enum.Parse(tsType, "STRIP_FOOTING");
				case PolyBeamTypeEnum.COLUMN:
					return System.Enum.Parse(tsType, "COLUMN");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static PolyBeamTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("BEAM", System.StringComparison.InvariantCulture))
				return PolyBeamTypeEnum.BEAM;
			else if (tsEnumValue.Equals("PANEL", System.StringComparison.InvariantCulture))
				return PolyBeamTypeEnum.PANEL;
			else if (tsEnumValue.Equals("STRIP_FOOTING", System.StringComparison.InvariantCulture))
				return PolyBeamTypeEnum.STRIP_FOOTING;
			else if (tsEnumValue.Equals("COLUMN", System.StringComparison.InvariantCulture))
				return PolyBeamTypeEnum.COLUMN;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class PolyBeam_
    {
        public static dynamic GetTSObject(PolyBeam dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static PolyBeam FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (PolyBeam)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PolyBeamArray_
    {
        public static dynamic GetTSObject(PolyBeam[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(PolyBeam_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static PolyBeam[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<PolyBeam>();
            foreach(var tsItem in tsArray)
            {
                list.Add(PolyBeam_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    
