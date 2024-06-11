using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic.Tekla.Structures.Model;
public class ChangeData
{


    public ModelObject Object
    {
        get
        {
            try
            {
                var value = teklaObject.Object;
                var value_ = ModelObject_.FromTSObject(value);
                return (ModelObject)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Object), ex);
            }
        }

    }

    public ChangeData.ChangeTypeEnum Type
    {
        get
        {
            try
            {
                var value = teklaObject.Type;
                var value_ = ChangeData.ChangeTypeEnum_.FromTSObject(value);
                return (ChangeData.ChangeTypeEnum)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Type), ex);
            }
        }

    }

    public ChangeData.ChangeSourceTypeEnum Source
    {
        get
        {
            try
            {
                var value = teklaObject.Source;
                var value_ = ChangeData.ChangeSourceTypeEnum_.FromTSObject(value);
                return (ChangeData.ChangeSourceTypeEnum)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Source), ex);
            }
        }

    }


    internal dynamic teklaObject;

    internal ChangeData() { }
    
    public ChangeData(dynamic tsObject, System.DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }




    public enum ChangeSourceTypeEnum
    {
        COMMIT,
        UNDO_REDO,
        ROLLBACK
    }

    internal static class ChangeSourceTypeEnum_
    {
        public static dynamic GetTSObject(ChangeSourceTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.ChangeData.ChangeSourceTypeEnum").GetType();

            switch (dynEnum)
            {
                case ChangeSourceTypeEnum.COMMIT:
                    return System.Enum.Parse(tsType, "COMMIT");
                case ChangeSourceTypeEnum.UNDO_REDO:
                    return System.Enum.Parse(tsType, "UNDO_REDO");
                case ChangeSourceTypeEnum.ROLLBACK:
                    return System.Enum.Parse(tsType, "ROLLBACK");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }

        public static ChangeSourceTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);

            if (tsEnumValue.Equals("COMMIT", System.StringComparison.InvariantCulture))
                return ChangeSourceTypeEnum.COMMIT;
            else if (tsEnumValue.Equals("UNDO_REDO", System.StringComparison.InvariantCulture))
                return ChangeSourceTypeEnum.UNDO_REDO;
            else if (tsEnumValue.Equals("ROLLBACK", System.StringComparison.InvariantCulture))
                return ChangeSourceTypeEnum.ROLLBACK;

            else
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");

        }
    }


    public enum ChangeTypeEnum
    {
        OBJECT_INSERT,
        OBJECT_MODIFY,
        OBJECT_DELETE,
        USERPROPERTY_CHANGED
    }

    internal static class ChangeTypeEnum_
    {
        public static dynamic GetTSObject(ChangeTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.ChangeData.ChangeTypeEnum").GetType();

            switch (dynEnum)
            {
                case ChangeTypeEnum.OBJECT_INSERT:
                    return System.Enum.Parse(tsType, "OBJECT_INSERT");
                case ChangeTypeEnum.OBJECT_MODIFY:
                    return System.Enum.Parse(tsType, "OBJECT_MODIFY");
                case ChangeTypeEnum.OBJECT_DELETE:
                    return System.Enum.Parse(tsType, "OBJECT_DELETE");
                case ChangeTypeEnum.USERPROPERTY_CHANGED:
                    return System.Enum.Parse(tsType, "USERPROPERTY_CHANGED");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }

        public static ChangeTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);

            if (tsEnumValue.Equals("OBJECT_INSERT", System.StringComparison.InvariantCulture))
                return ChangeTypeEnum.OBJECT_INSERT;
            else if (tsEnumValue.Equals("OBJECT_MODIFY", System.StringComparison.InvariantCulture))
                return ChangeTypeEnum.OBJECT_MODIFY;
            else if (tsEnumValue.Equals("OBJECT_DELETE", System.StringComparison.InvariantCulture))
                return ChangeTypeEnum.OBJECT_DELETE;
            else if (tsEnumValue.Equals("USERPROPERTY_CHANGED", System.StringComparison.InvariantCulture))
                return ChangeTypeEnum.USERPROPERTY_CHANGED;

            else
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");

        }
    }



}

internal static class ChangeData_
{
    public static dynamic GetTSObject(ChangeData dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static ChangeData FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (ChangeData)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

