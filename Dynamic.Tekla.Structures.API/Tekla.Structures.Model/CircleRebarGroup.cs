using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic.Tekla.Structures.Model;
public sealed class CircleRebarGroup : BaseRebarGroup
{

    public Polygon Polygon
    {
        get
        {
            try
            {
                var value = teklaObject.Polygon;
                var value_ = Polygon_.FromTSObject(value);
                return (Polygon)value_;
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

    public CircleRebarGroup.CircleRebarGroupStirrupTypeEnum StirrupType
    {
        get
        {
            try
            {
                var value = teklaObject.StirrupType;
                var value_ = CircleRebarGroup.CircleRebarGroupStirrupTypeEnum_.FromTSObject(value);
                return (CircleRebarGroup.CircleRebarGroupStirrupTypeEnum)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(StirrupType), ex);
            }
        }
        set
        {
            try
            {
                var value_ = CircleRebarGroup.CircleRebarGroupStirrupTypeEnum_.GetTSObject(value);
                teklaObject.StirrupType = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(StirrupType), ex);
            }
        }
    }




    public CircleRebarGroup()
    {
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.CircleRebarGroup");
    }
    
    public CircleRebarGroup(dynamic tsObject, System.DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }




    public enum CircleRebarGroupStirrupTypeEnum
    {
        STIRRUP_TYPE_CIRCLE,
        STIRRUP_TYPE_SPIRAL
    }

    internal static class CircleRebarGroupStirrupTypeEnum_
    {
        public static dynamic GetTSObject(CircleRebarGroupStirrupTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.CircleRebarGroup.CircleRebarGroupStirrupTypeEnum").GetType();

            switch (dynEnum)
            {
                case CircleRebarGroupStirrupTypeEnum.STIRRUP_TYPE_CIRCLE:
                    return System.Enum.Parse(tsType, "STIRRUP_TYPE_CIRCLE");
                case CircleRebarGroupStirrupTypeEnum.STIRRUP_TYPE_SPIRAL:
                    return System.Enum.Parse(tsType, "STIRRUP_TYPE_SPIRAL");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }

        public static CircleRebarGroupStirrupTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);

            if (tsEnumValue.Equals("STIRRUP_TYPE_CIRCLE", System.StringComparison.InvariantCulture))
                return CircleRebarGroupStirrupTypeEnum.STIRRUP_TYPE_CIRCLE;
            else if (tsEnumValue.Equals("STIRRUP_TYPE_SPIRAL", System.StringComparison.InvariantCulture))
                return CircleRebarGroupStirrupTypeEnum.STIRRUP_TYPE_SPIRAL;

            else
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");

        }
    }



}

internal static class CircleRebarGroup_
{
    public static dynamic GetTSObject(CircleRebarGroup dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static CircleRebarGroup FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (CircleRebarGroup)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

