using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic.Tekla.Structures.Model;
public abstract class Part : ModelObject, IAssemblable
{
    public new dynamic teklaObject { get => teklaObject; set => teklaObject = value; }
    public Profile Profile
    {
        get
        {
            try
            {
                var value = teklaObject.Profile;
                var value_ = Profile_.FromTSObject(value);
                return (Profile)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Profile), ex);
            }
        }
        set
        {
            try
            {
                var value_ = Profile_.GetTSObject(value);
                teklaObject.Profile = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Profile), ex);
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
                return (Material)value_;
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

    public DeformingData DeformingData
    {
        get
        {
            try
            {
                var value = teklaObject.DeformingData;
                var value_ = DeformingData_.FromTSObject(value);
                return (DeformingData)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(DeformingData), ex);
            }
        }
        set
        {
            try
            {
                var value_ = DeformingData_.GetTSObject(value);
                teklaObject.DeformingData = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(DeformingData), ex);
            }
        }
    }

    public NumberingSeries PartNumber
    {
        get
        {
            try
            {
                var value = teklaObject.PartNumber;
                var value_ = NumberingSeries_.FromTSObject(value);
                return (NumberingSeries)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(PartNumber), ex);
            }
        }
        set
        {
            try
            {
                var value_ = NumberingSeries_.GetTSObject(value);
                teklaObject.PartNumber = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(PartNumber), ex);
            }
        }
    }

    public NumberingSeries AssemblyNumber
    {
        get
        {
            try
            {
                var value = teklaObject.AssemblyNumber;
                var value_ = NumberingSeries_.FromTSObject(value);
                return (NumberingSeries)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(AssemblyNumber), ex);
            }
        }
        set
        {
            try
            {
                var value_ = NumberingSeries_.GetTSObject(value);
                teklaObject.AssemblyNumber = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(AssemblyNumber), ex);
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

    public string Finish
    {
        get
        {
            try
            {
                return teklaObject.Finish;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Finish), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.Finish = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Finish), ex);
            }
        }
    }

    public Part.CastUnitTypeEnum CastUnitType
    {
        get
        {
            try
            {
                var value = teklaObject.CastUnitType;
                var value_ = Part.CastUnitTypeEnum_.FromTSObject(value);
                return (Part.CastUnitTypeEnum)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(CastUnitType), ex);
            }
        }
        set
        {
            try
            {
                var value_ = Part.CastUnitTypeEnum_.GetTSObject(value);
                teklaObject.CastUnitType = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(CastUnitType), ex);
            }
        }
    }

    public int PourPhase
    {
        get
        {
            try
            {
                return teklaObject.PourPhase;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(PourPhase), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.PourPhase = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(PourPhase), ex);
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
                return (Position)value_;
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






    public Solid GetSolid()
    {

        try
        {
            var result = teklaObject.GetSolid();

            var _result = Solid_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetSolid), ex);
        }
    }



    public Solid GetSolid(
        Solid.SolidCreationTypeEnum solidCreationType_)
    {
        var solidCreationType = Solid.SolidCreationTypeEnum_.GetTSObject(solidCreationType_);
        try
        {
            var result = teklaObject.GetSolid(solidCreationType);

            var _result = Solid_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetSolid), ex);
        }
    }



    //public Solid GetSolid(
    //    Dynamic.Tekla.Structures.Forming.FormingStates formingStates_)
    //{
    //    var formingStates = Dynamic.Tekla.Structures.Forming.FormingStates_.GetTSObject(formingStates_);
    //    try
    //    {
    //        var result = teklaObject.GetSolid(formingStates);

    //        var _result = Solid_.FromTSObject(result);
    //        return _result;
    //    }
    //    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    //    {
    //        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetSolid), ex);
    //    }
    //}



    public Assembly GetAssembly()
    {

        try
        {
            var result = teklaObject.GetAssembly();

            var _result = Assembly_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetAssembly), ex);
        }
    }



    public string GetPartMark()
    {

        try
        {
            var result = (string)teklaObject.GetPartMark();

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetPartMark), ex);
        }
    }



    public System.Collections.ArrayList GetCenterLine(
        bool withCutsFittings)
    {

        try
        {
            var result = teklaObject.GetCenterLine(withCutsFittings);

            var _result = ArrayListConverter.FromTSObjects(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetCenterLine), ex);
        }
    }



    public System.Collections.ArrayList GetReferenceLine(
        bool withCutsFittings)
    {

        try
        {
            var result = teklaObject.GetReferenceLine(withCutsFittings);

            var _result = ArrayListConverter.FromTSObjects(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetReferenceLine), ex);
        }
    }



    public ModelObjectEnumerator GetComponents()
    {

        try
        {
            var result = teklaObject.GetComponents();

            var _result = ModelObjectEnumerator_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetComponents), ex);
        }
    }



    public ModelObjectEnumerator GetBooleans()
    {

        try
        {
            var result = teklaObject.GetBooleans();

            var _result = ModelObjectEnumerator_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetBooleans), ex);
        }
    }



    public ModelObjectEnumerator GetBolts()
    {

        try
        {
            var result = teklaObject.GetBolts();

            var _result = ModelObjectEnumerator_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetBolts), ex);
        }
    }



    public ModelObjectEnumerator GetWelds()
    {

        try
        {
            var result = teklaObject.GetWelds();

            var _result = ModelObjectEnumerator_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetWelds), ex);
        }
    }



    public ModelObjectEnumerator GetReinforcements()
    {

        try
        {
            var result = teklaObject.GetReinforcements();

            var _result = ModelObjectEnumerator_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetReinforcements), ex);
        }
    }



    public ModelObjectEnumerator GetSurfaceTreatments()
    {

        try
        {
            var result = teklaObject.GetSurfaceTreatments();

            var _result = ModelObjectEnumerator_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetSurfaceTreatments), ex);
        }
    }



    public ModelObjectEnumerator GetSurfaceObjects()
    {

        try
        {
            var result = teklaObject.GetSurfaceObjects();

            var _result = ModelObjectEnumerator_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetSurfaceObjects), ex);
        }
    }



    public ModelObjectEnumerator GetPours()
    {

        try
        {
            var result = teklaObject.GetPours();

            var _result = ModelObjectEnumerator_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetPours), ex);
        }
    }



    public bool CompareTo(
        Part partToCompare_)
    {
        var partToCompare = Part_.GetTSObject(partToCompare_);
        try
        {
            var result = (bool)teklaObject.CompareTo(partToCompare);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(CompareTo), ex);
        }
    }



    public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem GetDSTVCoordinateSystem()
    {

        try
        {
            var result = teklaObject.GetDSTVCoordinateSystem();

            var _result = Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetDSTVCoordinateSystem), ex);
        }
    }





    public enum CastUnitTypeEnum
    {
        PRECAST,
        CAST_IN_PLACE
    }

    internal static class CastUnitTypeEnum_
    {
        public static dynamic GetTSObject(CastUnitTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.Part.CastUnitTypeEnum").GetType();

            switch (dynEnum)
            {
                case CastUnitTypeEnum.PRECAST:
                    return System.Enum.Parse(tsType, "PRECAST");
                case CastUnitTypeEnum.CAST_IN_PLACE:
                    return System.Enum.Parse(tsType, "CAST_IN_PLACE");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }

        public static CastUnitTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);

            if (tsEnumValue.Equals("PRECAST", System.StringComparison.InvariantCulture))
                return CastUnitTypeEnum.PRECAST;
            else if (tsEnumValue.Equals("CAST_IN_PLACE", System.StringComparison.InvariantCulture))
                return CastUnitTypeEnum.CAST_IN_PLACE;

            else
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");

        }
    }



}

internal static class Part_
{
    public static dynamic GetTSObject(Part dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static Part FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (Part)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}


