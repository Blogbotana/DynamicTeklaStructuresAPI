using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using System;

namespace Dynamic.Tekla.Structures;
/// <summary>
/// The ComponentOptions class represents the component options.
/// </summary>
public class ComponentOptions
{
    public string PlateProfileName
    {
        get
        {
            try
            {
                return teklaObject.PlateProfileName;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(PlateProfileName), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.PlateProfileName = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(PlateProfileName), ex);
            }
        }
    }

    public string FoldedPlateProfileName
    {
        get
        {
            try
            {
                return teklaObject.FoldedPlateProfileName;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(FoldedPlateProfileName), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.FoldedPlateProfileName = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(FoldedPlateProfileName), ex);
            }
        }
    }

    public double BoltEdgeDistanceFactor
    {
        get
        {
            try
            {
                return teklaObject.BoltEdgeDistanceFactor;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(BoltEdgeDistanceFactor), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.BoltEdgeDistanceFactor = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(BoltEdgeDistanceFactor), ex);
            }
        }
    }

    public BoltEdgeDistanceReferenceEnum BoltEdgeDistanceReference
    {
        get
        {
            try
            {
                var value = teklaObject.BoltEdgeDistanceReference;
                var value_ = BoltEdgeDistanceReferenceEnum_.FromTSObject(value);
                return (BoltEdgeDistanceReferenceEnum)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(BoltEdgeDistanceReference), ex);
            }
        }
        set
        {
            try
            {
                var value_ = BoltEdgeDistanceReferenceEnum_.GetTSObject(value);
                teklaObject.BoltEdgeDistanceReference = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(BoltEdgeDistanceReference), ex);
            }
        }
    }

    public string BoltStandard
    {
        get
        {
            try
            {
                return teklaObject.BoltStandard;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(BoltStandard), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.BoltStandard = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(BoltStandard), ex);
            }
        }
    }

    public string BoltSize
    {
        get
        {
            try
            {
                return teklaObject.BoltSize;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(BoltSize), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.BoltSize = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(BoltSize), ex);
            }
        }
    }

    public string PartMaterial
    {
        get
        {
            try
            {
                return teklaObject.PartMaterial;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(PartMaterial), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.PartMaterial = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(PartMaterial), ex);
            }
        }
    }

    public int PartWeldedToPrimaryStartNumber
    {
        get
        {
            try
            {
                return teklaObject.PartWeldedToPrimaryStartNumber;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(PartWeldedToPrimaryStartNumber), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.PartWeldedToPrimaryStartNumber = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(PartWeldedToPrimaryStartNumber), ex);
            }
        }
    }

    public string PartWeldedToPrimaryPositionPrefix
    {
        get
        {
            try
            {
                return teklaObject.PartWeldedToPrimaryPositionPrefix;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(PartWeldedToPrimaryPositionPrefix), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.PartWeldedToPrimaryPositionPrefix = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(PartWeldedToPrimaryPositionPrefix), ex);
            }
        }
    }

    public int PartWeldedToSecondaryStartNumber
    {
        get
        {
            try
            {
                return teklaObject.PartWeldedToSecondaryStartNumber;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(PartWeldedToSecondaryStartNumber), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.PartWeldedToSecondaryStartNumber = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(PartWeldedToSecondaryStartNumber), ex);
            }
        }
    }

    public string PartWeldedToSecondaryPositionPrefix
    {
        get
        {
            try
            {
                return teklaObject.PartWeldedToSecondaryPositionPrefix;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(PartWeldedToSecondaryPositionPrefix), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.PartWeldedToSecondaryPositionPrefix = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(PartWeldedToSecondaryPositionPrefix), ex);
            }
        }
    }

    public int LoosePartStartNumber
    {
        get
        {
            try
            {
                return teklaObject.LoosePartStartNumber;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LoosePartStartNumber), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.LoosePartStartNumber = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LoosePartStartNumber), ex);
            }
        }
    }

    public string LoosePartPositionPrefix
    {
        get
        {
            try
            {
                return teklaObject.LoosePartPositionPrefix;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LoosePartPositionPrefix), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.LoosePartPositionPrefix = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LoosePartPositionPrefix), ex);
            }
        }
    }

    public int AssemblyLoosePartStartNumber
    {
        get
        {
            try
            {
                return teklaObject.AssemblyLoosePartStartNumber;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(AssemblyLoosePartStartNumber), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.AssemblyLoosePartStartNumber = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(AssemblyLoosePartStartNumber), ex);
            }
        }
    }

    public string AssemblyLoosePartPositionPrefix
    {
        get
        {
            try
            {
                return teklaObject.AssemblyLoosePartPositionPrefix;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(AssemblyLoosePartPositionPrefix), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.AssemblyLoosePartPositionPrefix = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(AssemblyLoosePartPositionPrefix), ex);
            }
        }
    }

    internal dynamic teklaObject;

    public ComponentOptions()
    {
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.ComponentOptions");
    }

    public ComponentOptions(dynamic tsObject, DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }

    public enum BoltEdgeDistanceReferenceEnum
    {
        BOLT_DIAMETER,
        HOLE_DIAMETER
    }

    internal static class BoltEdgeDistanceReferenceEnum_
    {
        public static dynamic GetTSObject(BoltEdgeDistanceReferenceEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.ComponentOptions.BoltEdgeDistanceReferenceEnum").GetType();

            switch (dynEnum)
            {
                case BoltEdgeDistanceReferenceEnum.BOLT_DIAMETER:
                    return System.Enum.Parse(tsType, "BOLT_DIAMETER");
                case BoltEdgeDistanceReferenceEnum.HOLE_DIAMETER:
                    return System.Enum.Parse(tsType, "HOLE_DIAMETER");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }

        public static BoltEdgeDistanceReferenceEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);

            if (tsEnumValue.Equals("BOLT_DIAMETER", System.StringComparison.InvariantCulture))
                return BoltEdgeDistanceReferenceEnum.BOLT_DIAMETER;
            else if (tsEnumValue.Equals("HOLE_DIAMETER", System.StringComparison.InvariantCulture))
                return BoltEdgeDistanceReferenceEnum.HOLE_DIAMETER;

            else
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");

        }
    }
}
internal static class ComponentOptions_
{
    public static dynamic GetTSObject(ComponentOptions dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static ComponentOptions FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new DateTime();

        var dynObject = (Dynamic.Tekla.Structures.ComponentOptions)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}