using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;
using System;
using System.Globalization;
using System.Reflection;

namespace Dynamic.Tekla.Structures.Model;


public class BasePoint
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

    public Guid Guid
    {
        get
        {
            try
            {
                return teklaObject.Guid;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Guid), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.Guid = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Guid), ex);
            }
        }
    }

    public string InitialGuid
    {
        get
        {
            try
            {
                return teklaObject.InitialGuid;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(InitialGuid), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.InitialGuid = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(InitialGuid), ex);
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

    public string CoordinateSystem
    {
        get
        {
            try
            {
                return teklaObject.CoordinateSystem;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(CoordinateSystem), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.CoordinateSystem = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(CoordinateSystem), ex);
            }
        }
    }

    public double NorthSouth
    {
        get
        {
            try
            {
                return teklaObject.NorthSouth;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(NorthSouth), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.NorthSouth = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(NorthSouth), ex);
            }
        }
    }

    public double EastWest
    {
        get
        {
            try
            {
                return teklaObject.EastWest;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(EastWest), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.EastWest = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(EastWest), ex);
            }
        }
    }

    public double Elevation
    {
        get
        {
            try
            {
                return teklaObject.Elevation;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Elevation), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.Elevation = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Elevation), ex);
            }
        }
    }

    public double Latitude
    {
        get
        {
            try
            {
                return teklaObject.Latitude;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Latitude), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.Latitude = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Latitude), ex);
            }
        }
    }

    public double Longitude
    {
        get
        {
            try
            {
                return teklaObject.Longitude;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Longitude), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.Longitude = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Longitude), ex);
            }
        }
    }

    public double LocationInModelX
    {
        get
        {
            try
            {
                return teklaObject.LocationInModelX;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LocationInModelX), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.LocationInModelX = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LocationInModelX), ex);
            }
        }
    }

    public double LocationInModelY
    {
        get
        {
            try
            {
                return teklaObject.LocationInModelY;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LocationInModelY), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.LocationInModelY = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LocationInModelY), ex);
            }
        }
    }

    public double LocationInModelZ
    {
        get
        {
            try
            {
                return teklaObject.LocationInModelZ;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LocationInModelZ), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.LocationInModelZ = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LocationInModelZ), ex);
            }
        }
    }

    public double AngleToNorth
    {
        get
        {
            try
            {
                return teklaObject.AngleToNorth;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(AngleToNorth), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.AngleToNorth = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(AngleToNorth), ex);
            }
        }
    }

    public bool IsProjectBasePoint
    {
        get
        {
            try
            {
                return teklaObject.IsProjectBasePoint;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(IsProjectBasePoint), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.IsProjectBasePoint = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(IsProjectBasePoint), ex);
            }
        }
    }

    public bool IsCurrentBasePoint
    {
        get
        {
            try
            {
                return teklaObject.IsCurrentBasePoint;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(IsCurrentBasePoint), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.IsCurrentBasePoint = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(IsCurrentBasePoint), ex);
            }
        }
    }

    public bool IsLocked
    {
        get
        {
            try
            {
                return teklaObject.IsLocked;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(IsLocked), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.IsLocked = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(IsLocked), ex);
            }
        }
    }

    public bool IsScopedCurrentBasePoint
    {
        get
        {
            try
            {
                return teklaObject.IsScopedCurrentBasePoint;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(IsScopedCurrentBasePoint), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.IsScopedCurrentBasePoint = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(IsScopedCurrentBasePoint), ex);
            }
        }
    }


    internal dynamic teklaObject;

    internal BasePoint() { }
    public BasePoint(dynamic tsObject, DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }
    public BasePoint(string name)
    {
        var args = new object[1];
        args[0] = name;
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.BasePoint", args);
    }
    public BasePoint(int id, Guid guid, string initialGuid, string name, string description, string coordinateSystem, double northSouth, double eastWest, double elevation, double latitude, double longitude, double locationInModelX, double locationInModelY, double locationInModelZ, double angleToNorth, bool isProjectBasePoint, bool isCurrentBasePoint)
    {
        var args = new object[17];
        args[0] = id;
        args[1] = guid;
        args[2] = initialGuid;
        args[3] = name;
        args[4] = description;
        args[5] = coordinateSystem;
        args[6] = northSouth;
        args[7] = eastWest;
        args[8] = elevation;
        args[9] = latitude;
        args[10] = longitude;
        args[11] = locationInModelX;
        args[12] = locationInModelY;
        args[13] = locationInModelZ;
        args[14] = angleToNorth;
        args[15] = isProjectBasePoint;
        args[16] = isCurrentBasePoint;
        this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.BasePoint", args);
    }
    public bool Insert()
    {

        try
        {
            var result = (bool)teklaObject.Insert();

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Insert), ex);
        }
    }
    public bool Modify()
    {

        try
        {
            var result = (bool)teklaObject.Modify();

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Modify), ex);
        }
    }
    public bool Delete()
    {

        try
        {
            var result = (bool)teklaObject.Delete();

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Delete), ex);
        }
    }
    public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem GetCoordinateSystem(
            Dynamic.Tekla.Structures.Model.BasePoint.CoordinateSystemType CoordsysType_)
    {
        var CoordsysType = Dynamic.Tekla.Structures.Model.BasePoint.CoordinateSystemType_.GetTSObject(CoordsysType_);
        try
        {
            var result = teklaObject.GetCoordinateSystem(CoordsysType);

            var _result = Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetCoordinateSystem), ex);
        }
    }

    public Tuple<bool, int, int, int> GetCompoundPlaneAngleLatitude()
    {

        try
        {
            var result = (Tuple<bool, int, int, int>)teklaObject.GetCompoundPlaneAngleLatitude();

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetCompoundPlaneAngleLatitude), ex);
        }
    }

    public Tuple<bool, int, int, int> GetCompoundPlaneAngleLongitude()
    {

        try
        {
            var result = (Tuple<bool, int, int, int>)teklaObject.GetCompoundPlaneAngleLongitude();

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetCompoundPlaneAngleLongitude), ex);
        }
    }

    public Dynamic.Tekla.Structures.Geometry3d.Point ConvertToBasePoint(
            Dynamic.Tekla.Structures.Geometry3d.Point point_)
    {
        var point = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(point_);
        try
        {
            var result = teklaObject.ConvertToBasePoint(point);

            var _result = Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(ConvertToBasePoint), ex);
        }
    }

    public Dynamic.Tekla.Structures.Geometry3d.Point ConvertFromBasePoint(
            Dynamic.Tekla.Structures.Geometry3d.Point point_)
    {
        var point = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(point_);
        try
        {
            var result = teklaObject.ConvertFromBasePoint(point);

            var _result = Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(ConvertFromBasePoint), ex);
        }
    }

    public static Dynamic.Tekla.Structures.Geometry3d.Point ConvertToBasePoint(
            Dynamic.Tekla.Structures.Model.BasePoint basePoint_,
            Dynamic.Tekla.Structures.Geometry3d.Point point_)
    {
        var basePoint = Dynamic.Tekla.Structures.Model.BasePoint_.GetTSObject(basePoint_);
        var point = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(point_);
        var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.BasePoint", "ConvertToBasePoint", basePoint, point);
        var _result = Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(result);
        return _result;
    }

    public static Dynamic.Tekla.Structures.Geometry3d.Point ConvertFromBasePoint(
            Dynamic.Tekla.Structures.Model.BasePoint basePoint_,
            Dynamic.Tekla.Structures.Geometry3d.Point point_)
    {
        var basePoint = Dynamic.Tekla.Structures.Model.BasePoint_.GetTSObject(basePoint_);
        var point = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(point_);
        var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.BasePoint", "ConvertFromBasePoint", basePoint, point);
        var _result = Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(result);
        return _result;
    }

    public enum CoordinateSystemType
    {
        GLOBAL,
        WORKPLANE
    }

    internal static class CoordinateSystemType_
    {
        public static dynamic GetTSObject(CoordinateSystemType dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.BasePoint.CoordinateSystemType").GetType();

            switch (dynEnum)
            {
                case CoordinateSystemType.GLOBAL:
                    return Enum.Parse(tsType, "GLOBAL");
                case CoordinateSystemType.WORKPLANE:
                    return Enum.Parse(tsType, "WORKPLANE");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }

        public static CoordinateSystemType FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", CultureInfo.InvariantCulture);

            if (tsEnumValue.Equals("GLOBAL", StringComparison.InvariantCulture))
                return CoordinateSystemType.GLOBAL;
            else if (tsEnumValue.Equals("WORKPLANE", StringComparison.InvariantCulture))
                return CoordinateSystemType.WORKPLANE;

            else
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");

        }
    }
}

internal static class BasePoint_
{
    public static dynamic GetTSObject(BasePoint dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static BasePoint FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new DateTime();

        var dynObject = (Dynamic.Tekla.Structures.Model.BasePoint)Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}
