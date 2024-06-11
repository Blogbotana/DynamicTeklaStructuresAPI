using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic.Tekla.Structures.Model;
/// <summary>
/// BentPlateGeometrySolver is a solver class to handle ConnectiveGeometry modification related computations.
/// </summary>
public sealed class BentPlateGeometrySolver
{


    internal dynamic teklaObject;

    public BentPlateGeometrySolver()
    {
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.BentPlateGeometrySolver");
    }
    
    public BentPlateGeometrySolver(dynamic tsObject, System.DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }


    public ConnectiveGeometry AddLeg(
        ConnectiveGeometry geometry_,
        Contour polygon_,
        BentPlate.BendShape bendShape_)
    {
        var geometry = ConnectiveGeometry_.GetTSObject(geometry_);
        var polygon = Contour_.GetTSObject(polygon_);
        var bendShape = BentPlate.BendShape_.GetTSObject(bendShape_);
        try
        {
            var result = teklaObject.AddLeg(geometry, polygon, bendShape);

            var _result = ConnectiveGeometry_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(AddLeg), ex);
        }
    }



    public ConnectiveGeometry AddLeg(
        ConnectiveGeometry geometry_,
        Contour polygon_)
    {
        var geometry = ConnectiveGeometry_.GetTSObject(geometry_);
        var polygon = Contour_.GetTSObject(polygon_);
        try
        {
            var result = teklaObject.AddLeg(geometry, polygon);

            var _result = ConnectiveGeometry_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(AddLeg), ex);
        }
    }



    public ConnectiveGeometry AddLeg(
        ConnectiveGeometry geometry_,
        Contour polygon_,
        double radius)
    {
        var geometry = ConnectiveGeometry_.GetTSObject(geometry_);
        var polygon = Contour_.GetTSObject(polygon_);
        try
        {
            var result = teklaObject.AddLeg(geometry, polygon, radius);

            var _result = ConnectiveGeometry_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(AddLeg), ex);
        }
    }



    public ConnectiveGeometry AddLeg(
        ConnectiveGeometry geometry_,
        Contour polygon_,
        double largestRadius,
        double halfAperture)
    {
        var geometry = ConnectiveGeometry_.GetTSObject(geometry_);
        var polygon = Contour_.GetTSObject(polygon_);

        try
        {
            var result = teklaObject.AddLeg(geometry, polygon, largestRadius, halfAperture);

            var _result = ConnectiveGeometry_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(AddLeg), ex);
        }
    }



    public ConnectiveGeometry AddLeg(
        ConnectiveGeometry geometry_,
        Dynamic.Tekla.Structures.Geometry3d.LineSegment segment1_,
        Contour polygon_,
        Dynamic.Tekla.Structures.Geometry3d.LineSegment segment2_,
        BentPlate.BendShape bendShape_)
    {
        var geometry = ConnectiveGeometry_.GetTSObject(geometry_);
        var segment1 = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(segment1_);
        var polygon = Contour_.GetTSObject(polygon_);
        var segment2 = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(segment2_);
        var bendShape = BentPlate.BendShape_.GetTSObject(bendShape_);
        try
        {
            var result = teklaObject.AddLeg(geometry, segment1, polygon, segment2, bendShape);

            var _result = ConnectiveGeometry_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(AddLeg), ex);
        }
    }



    public ConnectiveGeometry AddLeg(
        ConnectiveGeometry geometry_,
        Dynamic.Tekla.Structures.Geometry3d.LineSegment segment1_,
        Contour polygon_,
        Dynamic.Tekla.Structures.Geometry3d.LineSegment segment2_)
    {
        var geometry = ConnectiveGeometry_.GetTSObject(geometry_);
        var segment1 = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(segment1_);
        var polygon = Contour_.GetTSObject(polygon_);
        var segment2 = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(segment2_);
        try
        {
            var result = teklaObject.AddLeg(geometry, segment1, polygon, segment2);

            var _result = ConnectiveGeometry_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(AddLeg), ex);
        }
    }



    public ConnectiveGeometry AddLeg(
        ConnectiveGeometry geometry_,
        Dynamic.Tekla.Structures.Geometry3d.LineSegment segment1_,
        Contour polygon_,
        Dynamic.Tekla.Structures.Geometry3d.LineSegment segment2_,
        double radius)
    {
        var geometry = ConnectiveGeometry_.GetTSObject(geometry_);
        var segment1 = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(segment1_);
        var polygon = Contour_.GetTSObject(polygon_);
        var segment2 = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(segment2_);
        try
        {
            var result = teklaObject.AddLeg(geometry, segment1, polygon, segment2, radius);

            var _result = ConnectiveGeometry_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(AddLeg), ex);
        }
    }



    public ConnectiveGeometry AddLeg(
        ConnectiveGeometry geometry_,
        Dynamic.Tekla.Structures.Geometry3d.LineSegment segment1_,
        Contour polygon_,
        Dynamic.Tekla.Structures.Geometry3d.LineSegment segment2_,
        double largestRadius,
        double halfAperture)
    {
        var geometry = ConnectiveGeometry_.GetTSObject(geometry_);
        var segment1 = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(segment1_);
        var polygon = Contour_.GetTSObject(polygon_);
        var segment2 = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(segment2_);

        try
        {
            var result = teklaObject.AddLeg(geometry, segment1, polygon, segment2, largestRadius, halfAperture);

            var _result = ConnectiveGeometry_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(AddLeg), ex);
        }
    }



    public ConnectiveGeometry RemoveLeg(
        ConnectiveGeometry geometry_,
        GeometrySection legSection_)
    {
        var geometry = ConnectiveGeometry_.GetTSObject(geometry_);
        var legSection = GeometrySection_.GetTSObject(legSection_);
        try
        {
            var result = teklaObject.RemoveLeg(geometry, legSection);

            var _result = ConnectiveGeometry_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(RemoveLeg), ex);
        }
    }



    public ConnectiveGeometry ModifyBendSurface(
        ConnectiveGeometry geometry_,
        GeometrySection bendSection_,
        BendSurface surface_)
    {
        var geometry = ConnectiveGeometry_.GetTSObject(geometry_);
        var bendSection = GeometrySection_.GetTSObject(bendSection_);
        var surface = BendSurface_.GetTSObject(surface_);
        try
        {
            var result = teklaObject.ModifyBendSurface(geometry, bendSection, surface);

            var _result = ConnectiveGeometry_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(ModifyBendSurface), ex);
        }
    }



    public ConnectiveGeometry ModifyCylindricalSurface(
        ConnectiveGeometry geometry_,
        GeometrySection cylindricalSection_,
        CylindricalSurface surface_)
    {
        var geometry = ConnectiveGeometry_.GetTSObject(geometry_);
        var cylindricalSection = GeometrySection_.GetTSObject(cylindricalSection_);
        var surface = CylindricalSurface_.GetTSObject(surface_);
        try
        {
            var result = teklaObject.ModifyCylindricalSurface(geometry, cylindricalSection, surface);

            var _result = ConnectiveGeometry_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(ModifyCylindricalSurface), ex);
        }
    }



    public ConnectiveGeometry ModifyRadius(
        ConnectiveGeometry geometry_,
        GeometrySection cylindricalSection_,
        double radius)
    {
        var geometry = ConnectiveGeometry_.GetTSObject(geometry_);
        var cylindricalSection = GeometrySection_.GetTSObject(cylindricalSection_);
        try
        {
            var result = teklaObject.ModifyRadius(geometry, cylindricalSection, radius);

            var _result = ConnectiveGeometry_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(ModifyRadius), ex);
        }
    }



    public ConnectiveGeometry ModifyConicalRadiuses(
        ConnectiveGeometry geometry_,
        GeometrySection conicalSection_,
        double radius1,
        double radius2)
    {
        var geometry = ConnectiveGeometry_.GetTSObject(geometry_);
        var conicalSection = GeometrySection_.GetTSObject(conicalSection_);

        try
        {
            var result = teklaObject.ModifyConicalRadiuses(geometry, conicalSection, radius1, radius2);

            var _result = ConnectiveGeometry_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(ModifyConicalRadiuses), ex);
        }
    }



    public ConnectiveGeometry ScaleConeSection(
        ConnectiveGeometry geometry_,
        GeometrySection conicalSection_,
        double scale)
    {
        var geometry = ConnectiveGeometry_.GetTSObject(geometry_);
        var conicalSection = GeometrySection_.GetTSObject(conicalSection_);
        try
        {
            var result = teklaObject.ScaleConeSection(geometry, conicalSection, scale);

            var _result = ConnectiveGeometry_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(ScaleConeSection), ex);
        }
    }



    public ConnectiveGeometry ModifyPolygon(
        ConnectiveGeometry geometry_,
        GeometrySection polygonSection_,
        Contour points_)
    {
        var geometry = ConnectiveGeometry_.GetTSObject(geometry_);
        var polygonSection = GeometrySection_.GetTSObject(polygonSection_);
        var points = Contour_.GetTSObject(points_);
        try
        {
            var result = teklaObject.ModifyPolygon(geometry, polygonSection, points);

            var _result = ConnectiveGeometry_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(ModifyPolygon), ex);
        }
    }



    public ConnectiveGeometry SetMainSection(
        GeometrySection newMainSection_,
        ConnectiveGeometry geometry_)
    {
        var newMainSection = GeometrySection_.GetTSObject(newMainSection_);
        var geometry = ConnectiveGeometry_.GetTSObject(geometry_);
        try
        {
            var result = teklaObject.SetMainSection(newMainSection, geometry);

            var _result = ConnectiveGeometry_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SetMainSection), ex);
        }
    }



    public ConnectiveGeometry SetBendAngle(
        double angle,
        GeometrySection sectionToSetAngle_,
        GeometrySection sectionToMove_,
        ConnectiveGeometry geometry_)
    {
        var sectionToSetAngle = GeometrySection_.GetTSObject(sectionToSetAngle_);
        var sectionToMove = GeometrySection_.GetTSObject(sectionToMove_);
        var geometry = ConnectiveGeometry_.GetTSObject(geometry_);
        try
        {
            var result = teklaObject.SetBendAngle(angle, sectionToSetAngle, sectionToMove, geometry);

            var _result = ConnectiveGeometry_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SetBendAngle), ex);
        }
    }





    public enum OperationStatus
    {
        Success,
        Failure,
        FacePerpendicularToIntersectionLine,
        PlateIntersectsWithIntersectionLine,
        ExtensionIntersectsWithPlate,
        FacesTooNearEachOther,
        FacesAtAnObtuseAngle,
        UndefinedCurveDirection,
        UnsupportedChamfer,
        InvalidRadius,
        InvalidFacePoints
    }

    internal static class OperationStatus_
    {
        public static dynamic GetTSObject(OperationStatus dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.BentPlateGeometrySolver.OperationStatus").GetType();

            switch (dynEnum)
            {
                case OperationStatus.Success:
                    return System.Enum.Parse(tsType, "Success");
                case OperationStatus.Failure:
                    return System.Enum.Parse(tsType, "Failure");
                case OperationStatus.FacePerpendicularToIntersectionLine:
                    return System.Enum.Parse(tsType, "FacePerpendicularToIntersectionLine");
                case OperationStatus.PlateIntersectsWithIntersectionLine:
                    return System.Enum.Parse(tsType, "PlateIntersectsWithIntersectionLine");
                case OperationStatus.ExtensionIntersectsWithPlate:
                    return System.Enum.Parse(tsType, "ExtensionIntersectsWithPlate");
                case OperationStatus.FacesTooNearEachOther:
                    return System.Enum.Parse(tsType, "FacesTooNearEachOther");
                case OperationStatus.FacesAtAnObtuseAngle:
                    return System.Enum.Parse(tsType, "FacesAtAnObtuseAngle");
                case OperationStatus.UndefinedCurveDirection:
                    return System.Enum.Parse(tsType, "UndefinedCurveDirection");
                case OperationStatus.UnsupportedChamfer:
                    return System.Enum.Parse(tsType, "UnsupportedChamfer");
                case OperationStatus.InvalidRadius:
                    return System.Enum.Parse(tsType, "InvalidRadius");
                case OperationStatus.InvalidFacePoints:
                    return System.Enum.Parse(tsType, "InvalidFacePoints");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }

        public static OperationStatus FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);

            if (tsEnumValue.Equals("Success", System.StringComparison.InvariantCulture))
                return OperationStatus.Success;
            else if (tsEnumValue.Equals("Failure", System.StringComparison.InvariantCulture))
                return OperationStatus.Failure;
            else if (tsEnumValue.Equals("FacePerpendicularToIntersectionLine", System.StringComparison.InvariantCulture))
                return OperationStatus.FacePerpendicularToIntersectionLine;
            else if (tsEnumValue.Equals("PlateIntersectsWithIntersectionLine", System.StringComparison.InvariantCulture))
                return OperationStatus.PlateIntersectsWithIntersectionLine;
            else if (tsEnumValue.Equals("ExtensionIntersectsWithPlate", System.StringComparison.InvariantCulture))
                return OperationStatus.ExtensionIntersectsWithPlate;
            else if (tsEnumValue.Equals("FacesTooNearEachOther", System.StringComparison.InvariantCulture))
                return OperationStatus.FacesTooNearEachOther;
            else if (tsEnumValue.Equals("FacesAtAnObtuseAngle", System.StringComparison.InvariantCulture))
                return OperationStatus.FacesAtAnObtuseAngle;
            else if (tsEnumValue.Equals("UndefinedCurveDirection", System.StringComparison.InvariantCulture))
                return OperationStatus.UndefinedCurveDirection;
            else if (tsEnumValue.Equals("UnsupportedChamfer", System.StringComparison.InvariantCulture))
                return OperationStatus.UnsupportedChamfer;
            else if (tsEnumValue.Equals("InvalidRadius", System.StringComparison.InvariantCulture))
                return OperationStatus.InvalidRadius;
            else if (tsEnumValue.Equals("InvalidFacePoints", System.StringComparison.InvariantCulture))
                return OperationStatus.InvalidFacePoints;

            else
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");

        }
    }



}

internal static class BentPlateGeometrySolver_
{
    public static dynamic GetTSObject(BentPlateGeometrySolver dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static BentPlateGeometrySolver FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (BentPlateGeometrySolver)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

