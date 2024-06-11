using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic.Tekla.Structures.Model;
public abstract class Reinforcement : ModelObject, IAssemblable
{
    public dynamic teklaObject1 { get => teklaObject; set => teklaObject = value; }

    public ModelObject Father
    {
        get
        {
            try
            {
                var value = teklaObject.Father;
                var value_ = ModelObject_.FromTSObject(value);
                return (ModelObject)value_;
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
                var value_ = ModelObject_.GetTSObject(value);
                teklaObject.Father = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Father), ex);
            }
        }
    }

    public string Grade
    {
        get
        {
            try
            {
                return teklaObject.Grade;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Grade), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.Grade = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Grade), ex);
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

    public NumberingSeries NumberingSeries
    {
        get
        {
            try
            {
                var value = teklaObject.NumberingSeries;
                var value_ = NumberingSeries_.FromTSObject(value);
                return (NumberingSeries)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(NumberingSeries), ex);
            }
        }
        set
        {
            try
            {
                var value_ = NumberingSeries_.GetTSObject(value);
                teklaObject.NumberingSeries = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(NumberingSeries), ex);
            }
        }
    }

    public System.Collections.ArrayList OnPlaneOffsets
    {
        get
        {
            try
            {
                var value = teklaObject.OnPlaneOffsets;
                var value_ = ArrayListConverter.FromTSObjects(value);
                return (System.Collections.ArrayList)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(OnPlaneOffsets), ex);
            }
        }
        set
        {
            try
            {
                var value_ = ArrayListConverter.ToTSObjects(value);
                teklaObject.OnPlaneOffsets = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(OnPlaneOffsets), ex);
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

    public Reinforcement.RebarOffsetTypeEnum StartPointOffsetType
    {
        get
        {
            try
            {
                var value = teklaObject.StartPointOffsetType;
                var value_ = Reinforcement.RebarOffsetTypeEnum_.FromTSObject(value);
                return (Reinforcement.RebarOffsetTypeEnum)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(StartPointOffsetType), ex);
            }
        }
        set
        {
            try
            {
                var value_ = Reinforcement.RebarOffsetTypeEnum_.GetTSObject(value);
                teklaObject.StartPointOffsetType = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(StartPointOffsetType), ex);
            }
        }
    }

    public double StartPointOffsetValue
    {
        get
        {
            try
            {
                return teklaObject.StartPointOffsetValue;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(StartPointOffsetValue), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.StartPointOffsetValue = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(StartPointOffsetValue), ex);
            }
        }
    }

    public Reinforcement.RebarOffsetTypeEnum EndPointOffsetType
    {
        get
        {
            try
            {
                var value = teklaObject.EndPointOffsetType;
                var value_ = Reinforcement.RebarOffsetTypeEnum_.FromTSObject(value);
                return (Reinforcement.RebarOffsetTypeEnum)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(EndPointOffsetType), ex);
            }
        }
        set
        {
            try
            {
                var value_ = Reinforcement.RebarOffsetTypeEnum_.GetTSObject(value);
                teklaObject.EndPointOffsetType = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(EndPointOffsetType), ex);
            }
        }
    }

    public double EndPointOffsetValue
    {
        get
        {
            try
            {
                return teklaObject.EndPointOffsetValue;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(EndPointOffsetValue), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.EndPointOffsetValue = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(EndPointOffsetValue), ex);
            }
        }
    }

    public System.Collections.ArrayList RadiusValues
    {
        get
        {
            try
            {
                var value = teklaObject.RadiusValues;
                var value_ = ArrayListConverter.FromTSObjects(value);
                return (System.Collections.ArrayList)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(RadiusValues), ex);
            }
        }
        set
        {
            try
            {
                var value_ = ArrayListConverter.ToTSObjects(value);
                teklaObject.RadiusValues = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(RadiusValues), ex);
            }
        }
    }

    //public Dynamic.Tekla.Structures.Forming.DeformingType InputPointDeformingState
    //{
    //    get
    //    {
    //        try
    //        {
    //            var value = teklaObject.InputPointDeformingState;
    //            var value_ = Dynamic.Tekla.Structures.Forming.DeformingType_.FromTSObject(value);
    //            return (Dynamic.Tekla.Structures.Forming.DeformingType)value_;
    //        }
    //        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    //        {
    //            throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(InputPointDeformingState), ex);
    //        }
    //    }
    //    set
    //    {
    //        try
    //        {
    //            var value_ = Dynamic.Tekla.Structures.Forming.DeformingType_.GetTSObject(value);
    //            teklaObject.InputPointDeformingState = value_;
    //        }
    //        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    //        {
    //            throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(InputPointDeformingState), ex);
    //        }
    //    }
    //}






    public System.Collections.ArrayList GetRebarGeometries(
        Reinforcement.RebarGeometryOptionEnum options_)
    {
        var options = Reinforcement.RebarGeometryOptionEnum_.GetTSObject(options_);
        try
        {
            var result = teklaObject.GetRebarGeometries(options);

            var _result = ArrayListConverter.FromTSObjects(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetRebarGeometries), ex);
        }
    }



    public System.Collections.ArrayList GetRebarGeometries(
        bool withHooks)
    {

        try
        {
            var result = teklaObject.GetRebarGeometries(withHooks);

            var _result = ArrayListConverter.FromTSObjects(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetRebarGeometries), ex);
        }
    }



    public System.Collections.ArrayList GetRebarGeometriesWithoutClashes(
        bool withHooks)
    {

        try
        {
            var result = teklaObject.GetRebarGeometriesWithoutClashes(withHooks);

            var _result = ArrayListConverter.FromTSObjects(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetRebarGeometriesWithoutClashes), ex);
        }
    }
    public bool IsGeometryValid()
    {

        try
        {
            var result = (bool)teklaObject.IsGeometryValid();

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(IsGeometryValid), ex);
        }
    }



    public int GetNumberOfRebars()
    {

        try
        {
            var result = (int)teklaObject.GetNumberOfRebars();

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetNumberOfRebars), ex);
        }
    }



    public RebarGeometry GetSingleRebar(
        int index,
        bool withHooks)
    {
        try
        {
            var result = teklaObject.GetSingleRebar(index, withHooks);

            var _result = RebarGeometry_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetSingleRebar), ex);
        }
    }



    public RebarGeometry GetSingleRebarWithoutClash(
        int index,
        bool withHooks)
    {
        try
        {
            var result = teklaObject.GetSingleRebarWithoutClash(index, withHooks);

            var _result = RebarGeometry_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetSingleRebarWithoutClash), ex);
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



    public PourObject GetFatherPour()
    {

        try
        {
            var result = teklaObject.GetFatherPour();

            var _result = PourObject_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetFatherPour), ex);
        }
    }



    public PourUnit GetFatherPourUnit()
    {

        try
        {
            var result = teklaObject.GetFatherPourUnit();

            var _result = PourUnit_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetFatherPourUnit), ex);
        }
    }



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





    public enum RebarGeometryOptionEnum
    {
        NONE,
        HOOKS,
        AVOID_CLASH,
        LENGTH_ADJUSTMENTS
    }

    internal static class RebarGeometryOptionEnum_
    {
        public static dynamic GetTSObject(RebarGeometryOptionEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.Reinforcement.RebarGeometryOptionEnum").GetType();

            switch (dynEnum)
            {
                case RebarGeometryOptionEnum.NONE:
                    return System.Enum.Parse(tsType, "NONE");
                case RebarGeometryOptionEnum.HOOKS:
                    return System.Enum.Parse(tsType, "HOOKS");
                case RebarGeometryOptionEnum.AVOID_CLASH:
                    return System.Enum.Parse(tsType, "AVOID_CLASH");
                case RebarGeometryOptionEnum.LENGTH_ADJUSTMENTS:
                    return System.Enum.Parse(tsType, "LENGTH_ADJUSTMENTS");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }

        public static RebarGeometryOptionEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);

            if (tsEnumValue.Equals("NONE", System.StringComparison.InvariantCulture))
                return RebarGeometryOptionEnum.NONE;
            else if (tsEnumValue.Equals("HOOKS", System.StringComparison.InvariantCulture))
                return RebarGeometryOptionEnum.HOOKS;
            else if (tsEnumValue.Equals("AVOID_CLASH", System.StringComparison.InvariantCulture))
                return RebarGeometryOptionEnum.AVOID_CLASH;
            else if (tsEnumValue.Equals("LENGTH_ADJUSTMENTS", System.StringComparison.InvariantCulture))
                return RebarGeometryOptionEnum.LENGTH_ADJUSTMENTS;

            else
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");

        }
    }


    public enum RebarGeometrySimplificationTypeEnum
    {
        NONE,
        RATIONALIZED,
        FABRICATION
    }

    internal static class RebarGeometrySimplificationTypeEnum_
    {
        public static dynamic GetTSObject(RebarGeometrySimplificationTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.Reinforcement.RebarGeometrySimplificationTypeEnum").GetType();

            switch (dynEnum)
            {
                case RebarGeometrySimplificationTypeEnum.NONE:
                    return System.Enum.Parse(tsType, "NONE");
                case RebarGeometrySimplificationTypeEnum.RATIONALIZED:
                    return System.Enum.Parse(tsType, "RATIONALIZED");
                case RebarGeometrySimplificationTypeEnum.FABRICATION:
                    return System.Enum.Parse(tsType, "FABRICATION");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }

        public static RebarGeometrySimplificationTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);

            if (tsEnumValue.Equals("NONE", System.StringComparison.InvariantCulture))
                return RebarGeometrySimplificationTypeEnum.NONE;
            else if (tsEnumValue.Equals("RATIONALIZED", System.StringComparison.InvariantCulture))
                return RebarGeometrySimplificationTypeEnum.RATIONALIZED;
            else if (tsEnumValue.Equals("FABRICATION", System.StringComparison.InvariantCulture))
                return RebarGeometrySimplificationTypeEnum.FABRICATION;

            else
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");

        }
    }


    public enum RebarOffsetTypeEnum
    {
        OFFSET_TYPE_COVER_THICKNESS,
        OFFSET_TYPE_LEG_LENGTH
    }

    internal static class RebarOffsetTypeEnum_
    {
        public static dynamic GetTSObject(RebarOffsetTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.Reinforcement.RebarOffsetTypeEnum").GetType();

            switch (dynEnum)
            {
                case RebarOffsetTypeEnum.OFFSET_TYPE_COVER_THICKNESS:
                    return System.Enum.Parse(tsType, "OFFSET_TYPE_COVER_THICKNESS");
                case RebarOffsetTypeEnum.OFFSET_TYPE_LEG_LENGTH:
                    return System.Enum.Parse(tsType, "OFFSET_TYPE_LEG_LENGTH");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }

        public static RebarOffsetTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);

            if (tsEnumValue.Equals("OFFSET_TYPE_COVER_THICKNESS", System.StringComparison.InvariantCulture))
                return RebarOffsetTypeEnum.OFFSET_TYPE_COVER_THICKNESS;
            else if (tsEnumValue.Equals("OFFSET_TYPE_LEG_LENGTH", System.StringComparison.InvariantCulture))
                return RebarOffsetTypeEnum.OFFSET_TYPE_LEG_LENGTH;

            else
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");

        }
    }



}

internal static class Reinforcement_
{
    public static dynamic GetTSObject(Reinforcement dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static Reinforcement FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (Reinforcement)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}