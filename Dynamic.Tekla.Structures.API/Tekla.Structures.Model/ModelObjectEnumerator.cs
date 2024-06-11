using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;
using System.Collections;

namespace Dynamic.Tekla.Structures.Model;
public sealed class ModelObjectEnumerator : IEnumerator
{
    public bool SelectInstances
    {
        get
        {
            try
            {
                return teklaObject.SelectInstances;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(SelectInstances), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.SelectInstances = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(SelectInstances), ex);
            }
        }
    }

    public static bool AutoFetch
    {
        get
        {
            var value = PropertyInvoker.GetStaticPropertyOrFieldValue("Tekla.Structures.Model.ModelObjectEnumerator", "AutoFetch");
            return (bool)value;
        }
        set
        {
            var value_ = value;
            PropertyInvoker.SetStaticPropertyOrFieldValue("Tekla.Structures.Model.ModelObjectEnumerator", "AutoFetch", value_);
        }
    }
    public ModelObject Current
    {
        get
        {
            try
            {
                var value = teklaObject.Current;
                var value_ = ModelObject_.FromTSObject(value);
                return (ModelObject)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Current), ex);
            }
        }

    }
    object IEnumerator.Current => Current;

    internal dynamic teklaObject;

    internal ModelObjectEnumerator() { }
    
    public ModelObjectEnumerator(dynamic tsObject, System.DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }

    public bool MoveNext()
    {

        try
        {
            var result = (bool)teklaObject.MoveNext();

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(MoveNext), ex);
        }
    }
    public void Reset()
    {

        try
        {
            teklaObject.Reset();


        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Reset), ex);
        }
    }
    public int GetSize()
    {

        try
        {
            var result = (int)teklaObject.GetSize();

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetSize), ex);
        }
    }

    public enum EnumeratorTypeEnum
    {
        /// <summary>
        /// Selects all user selected objects from the model.
        /// </summary>
        ALL_SELECTED = 1,
        /// <summary>
        /// Selects all objects from the model.
        /// </summary>
        ALL_OBJECTS = 2,
        /// <summary>
        /// Selects children of specified type of given ModelObject
        /// </summary>
        MODELOBJECT_CHILDREN = 3,
        /// <summary>
        /// Selects all the ModelObjects for a given filter name
        /// </summary>
        BY_FILTER_NAME = 4,
        /// <summary>
        /// Selects all connected components of given ModelObject
        /// </summary>
        CONNECTED_COMPONENTS = 5,
        /// <summary>
        /// Selects all objects intersecting with given bounding box
        /// </summary>
        BY_BOUNDING_BOX = 6,
        /// <summary>
        /// All Objects with type given in type in the "subtype".
        /// </summary>
        ALL_OBJECTS_WITH_TYPE = 7,
        /// <summary>
        /// Selects sub objects of given ReferenceModel.
        /// </summary>
        REFERENCE_MODEL_OBJECTS = 8,
        /// <summary>
        /// Selects fathers of specified type of given ModelObject (Tasks mainly)
        /// </summary>
        MODELOBJECT_FATHERS = 9,
        /// <summary>
        /// Selects all connected dependencies of given ModelObject (Tasks mainly)
        /// </summary>
        CONNECTED_DEPENDENCIES = 10,
        /// <summary>
        /// Selects all tasks of selected objects
        /// </summary>
        TASKS_OF_SELECTED_OBJECTS = 11,
        /// <summary>
        /// Selects all modified and created objects
        /// </summary>
        MODIFIED_OBJECTS_AFTER_STAMP = 12,
        /// <summary>
        /// Filtered objects with type given in type in the "subtype".
        /// </summary>
        FILTERED_OBJECTS_WITH_TYPE = 13,
        /// <summary>
        /// Selects all modified objects 
        /// </summary>
        DELETED_OBJECTS_AFTER_STAMP = 14,
        /// <summary>
        /// Selects all preselected objects.
        /// </summary>
        ALL_PRESELECTED = 0xF,
        /// <summary>
        /// Selects all objects that intersect with the given bounding box and that are visible in the given view.
        /// </summary>
        BY_BOUNDING_BOX_AND_VIEW = 0x10,
        /// <summary>
        /// Selects objects that were converted from a given reference model (if they weren't unlinked)
        /// </summary>
        CONVERTED_FROM_REFERENCE_MODEL = 17,
        /// <summary>
        /// Selects all objects of which attributes (UDA) have been modified after the stamp. 
        /// </summary>
        ATTRIBUTE_MODIFIED_OBJECTS_AFTER_STAMP = 18,
        /// <summary>
        /// Selects all objects of which numbering has been modified after the stamp. 
        /// </summary>
        NUMBERING_MODIFIED_OBJECTS_AFTER_STAMP = 19,
        /// <summary>
        /// Selects all created objects
        /// </summary>
        CREATED_OBJECTS_AFTER_STAMP = 20,
        /// <summary>
        /// Selects all objects which are new, modified, numbered or which phase has changed after the stamp and pass the filter of given name. 
        /// </summary>
        MODIFIED_OBJECTS_BY_FILTER_NAME = 21,
        /// <summary>
        /// Selects all objects of which phase has been modified after the stamp. 
        /// </summary>
        PHASE_MODIFIED_OBJECTS_AFTER_STAMP = 22,
        /// <summary>
        /// Selects all objects with any type of modification or are created after the stamp. 
        /// </summary>
        OBJECTS_WITH_ANY_MODIFICATION_AFTER_STAMP = 23,
        /// <summary>
        /// Selects all model objects with the specified type. 
        /// </summary>
        BY_MODEL_OBJECT_TYPE = 25
    }

    internal static class EnumeratorTypeEnum_
    {
        public static dynamic GetTSObject(EnumeratorTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.ModelObjectEnumerator.EnumeratorTypeEnum").GetType();

            switch (dynEnum)
            {
                case EnumeratorTypeEnum.ALL_SELECTED:
                    return System.Enum.Parse(tsType, "ALL_SELECTED");
                case EnumeratorTypeEnum.ALL_OBJECTS:
                    return System.Enum.Parse(tsType, "ALL_OBJECTS");
                case EnumeratorTypeEnum.MODELOBJECT_CHILDREN:
                    return System.Enum.Parse(tsType, "MODELOBJECT_CHILDREN");
                case EnumeratorTypeEnum.BY_FILTER_NAME:
                    return System.Enum.Parse(tsType, "BY_FILTER_NAME");
                case EnumeratorTypeEnum.CONNECTED_COMPONENTS:
                    return System.Enum.Parse(tsType, "CONNECTED_COMPONENTS");
                case EnumeratorTypeEnum.BY_BOUNDING_BOX:
                    return System.Enum.Parse(tsType, "BY_BOUNDING_BOX");
                case EnumeratorTypeEnum.ALL_OBJECTS_WITH_TYPE:
                    return System.Enum.Parse(tsType, "ALL_OBJECTS_WITH_TYPE");
                case EnumeratorTypeEnum.REFERENCE_MODEL_OBJECTS:
                    return System.Enum.Parse(tsType, "REFERENCE_MODEL_OBJECTS");
                case EnumeratorTypeEnum.MODELOBJECT_FATHERS:
                    return System.Enum.Parse(tsType, "MODELOBJECT_FATHERS");
                case EnumeratorTypeEnum.CONNECTED_DEPENDENCIES:
                    return System.Enum.Parse(tsType, "CONNECTED_DEPENDENCIES");
                case EnumeratorTypeEnum.TASKS_OF_SELECTED_OBJECTS:
                    return System.Enum.Parse(tsType, "TASKS_OF_SELECTED_OBJECTS");
                case EnumeratorTypeEnum.MODIFIED_OBJECTS_AFTER_STAMP:
                    return System.Enum.Parse(tsType, "MODIFIED_OBJECTS_AFTER_STAMP");
                case EnumeratorTypeEnum.FILTERED_OBJECTS_WITH_TYPE:
                    return System.Enum.Parse(tsType, "FILTERED_OBJECTS_WITH_TYPE");
                case EnumeratorTypeEnum.DELETED_OBJECTS_AFTER_STAMP:
                    return System.Enum.Parse(tsType, "DELETED_OBJECTS_AFTER_STAMP");
                case EnumeratorTypeEnum.ALL_PRESELECTED:
                    return System.Enum.Parse(tsType, "ALL_PRESELECTED");
                case EnumeratorTypeEnum.BY_BOUNDING_BOX_AND_VIEW:
                    return System.Enum.Parse(tsType, "BY_BOUNDING_BOX_AND_VIEW");
                case EnumeratorTypeEnum.CONVERTED_FROM_REFERENCE_MODEL:
                    return System.Enum.Parse(tsType, "CONVERTED_FROM_REFERENCE_MODEL");
                case EnumeratorTypeEnum.ATTRIBUTE_MODIFIED_OBJECTS_AFTER_STAMP:
                    return System.Enum.Parse(tsType, "ATTRIBUTE_MODIFIED_OBJECTS_AFTER_STAMP");
                case EnumeratorTypeEnum.NUMBERING_MODIFIED_OBJECTS_AFTER_STAMP:
                    return System.Enum.Parse(tsType, "NUMBERING_MODIFIED_OBJECTS_AFTER_STAMP");
                case EnumeratorTypeEnum.CREATED_OBJECTS_AFTER_STAMP:
                    return System.Enum.Parse(tsType, "CREATED_OBJECTS_AFTER_STAMP");
                case EnumeratorTypeEnum.MODIFIED_OBJECTS_BY_FILTER_NAME:
                    return System.Enum.Parse(tsType, "MODIFIED_OBJECTS_BY_FILTER_NAME");
                case EnumeratorTypeEnum.PHASE_MODIFIED_OBJECTS_AFTER_STAMP:
                    return System.Enum.Parse(tsType, "PHASE_MODIFIED_OBJECTS_AFTER_STAMP");
                case EnumeratorTypeEnum.OBJECTS_WITH_ANY_MODIFICATION_AFTER_STAMP:
                    return System.Enum.Parse(tsType, "OBJECTS_WITH_ANY_MODIFICATION_AFTER_STAMP");
                case EnumeratorTypeEnum.BY_MODEL_OBJECT_TYPE:
                    return System.Enum.Parse(tsType, "BY_MODEL_OBJECT_TYPE");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }

        public static EnumeratorTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);

            if (tsEnumValue.Equals("ALL_SELECTED", System.StringComparison.InvariantCulture))
                return EnumeratorTypeEnum.ALL_SELECTED;
            else if (tsEnumValue.Equals("ALL_OBJECTS", System.StringComparison.InvariantCulture))
                return EnumeratorTypeEnum.ALL_OBJECTS;
            else if (tsEnumValue.Equals("MODELOBJECT_CHILDREN", System.StringComparison.InvariantCulture))
                return EnumeratorTypeEnum.MODELOBJECT_CHILDREN;
            else if (tsEnumValue.Equals("BY_FILTER_NAME", System.StringComparison.InvariantCulture))
                return EnumeratorTypeEnum.BY_FILTER_NAME;
            else if (tsEnumValue.Equals("CONNECTED_COMPONENTS", System.StringComparison.InvariantCulture))
                return EnumeratorTypeEnum.CONNECTED_COMPONENTS;
            else if (tsEnumValue.Equals("BY_BOUNDING_BOX", System.StringComparison.InvariantCulture))
                return EnumeratorTypeEnum.BY_BOUNDING_BOX;
            else if (tsEnumValue.Equals("ALL_OBJECTS_WITH_TYPE", System.StringComparison.InvariantCulture))
                return EnumeratorTypeEnum.ALL_OBJECTS_WITH_TYPE;
            else if (tsEnumValue.Equals("REFERENCE_MODEL_OBJECTS", System.StringComparison.InvariantCulture))
                return EnumeratorTypeEnum.REFERENCE_MODEL_OBJECTS;
            else if (tsEnumValue.Equals("MODELOBJECT_FATHERS", System.StringComparison.InvariantCulture))
                return EnumeratorTypeEnum.MODELOBJECT_FATHERS;
            else if (tsEnumValue.Equals("CONNECTED_DEPENDENCIES", System.StringComparison.InvariantCulture))
                return EnumeratorTypeEnum.CONNECTED_DEPENDENCIES;
            else if (tsEnumValue.Equals("TASKS_OF_SELECTED_OBJECTS", System.StringComparison.InvariantCulture))
                return EnumeratorTypeEnum.TASKS_OF_SELECTED_OBJECTS;
            else if (tsEnumValue.Equals("MODIFIED_OBJECTS_AFTER_STAMP", System.StringComparison.InvariantCulture))
                return EnumeratorTypeEnum.MODIFIED_OBJECTS_AFTER_STAMP;
            else if (tsEnumValue.Equals("FILTERED_OBJECTS_WITH_TYPE", System.StringComparison.InvariantCulture))
                return EnumeratorTypeEnum.FILTERED_OBJECTS_WITH_TYPE;
            else if (tsEnumValue.Equals("DELETED_OBJECTS_AFTER_STAMP", System.StringComparison.InvariantCulture))
                return EnumeratorTypeEnum.DELETED_OBJECTS_AFTER_STAMP;
            else if (tsEnumValue.Equals("ALL_PRESELECTED", System.StringComparison.InvariantCulture))
                return EnumeratorTypeEnum.ALL_PRESELECTED;
            else if (tsEnumValue.Equals("BY_BOUNDING_BOX_AND_VIEW", System.StringComparison.InvariantCulture))
                return EnumeratorTypeEnum.BY_BOUNDING_BOX_AND_VIEW;
            else if (tsEnumValue.Equals("CONVERTED_FROM_REFERENCE_MODEL", System.StringComparison.InvariantCulture))
                return EnumeratorTypeEnum.CONVERTED_FROM_REFERENCE_MODEL;
            else if (tsEnumValue.Equals("ATTRIBUTE_MODIFIED_OBJECTS_AFTER_STAMP", System.StringComparison.InvariantCulture))
                return EnumeratorTypeEnum.ATTRIBUTE_MODIFIED_OBJECTS_AFTER_STAMP;
            else if (tsEnumValue.Equals("NUMBERING_MODIFIED_OBJECTS_AFTER_STAMP", System.StringComparison.InvariantCulture))
                return EnumeratorTypeEnum.NUMBERING_MODIFIED_OBJECTS_AFTER_STAMP;
            else if (tsEnumValue.Equals("CREATED_OBJECTS_AFTER_STAMP", System.StringComparison.InvariantCulture))
                return EnumeratorTypeEnum.CREATED_OBJECTS_AFTER_STAMP;
            else if (tsEnumValue.Equals("MODIFIED_OBJECTS_BY_FILTER_NAME", System.StringComparison.InvariantCulture))
                return EnumeratorTypeEnum.MODIFIED_OBJECTS_BY_FILTER_NAME;
            else if (tsEnumValue.Equals("PHASE_MODIFIED_OBJECTS_AFTER_STAMP", System.StringComparison.InvariantCulture))
                return EnumeratorTypeEnum.PHASE_MODIFIED_OBJECTS_AFTER_STAMP;
            else if (tsEnumValue.Equals("OBJECTS_WITH_ANY_MODIFICATION_AFTER_STAMP", System.StringComparison.InvariantCulture))
                return EnumeratorTypeEnum.OBJECTS_WITH_ANY_MODIFICATION_AFTER_STAMP;
            else if (tsEnumValue.Equals("BY_MODEL_OBJECT_TYPE", System.StringComparison.InvariantCulture))
                return EnumeratorTypeEnum.BY_MODEL_OBJECT_TYPE;

            else
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");

        }
    }

}

internal static class ModelObjectEnumerator_
{
    public static dynamic GetTSObject(ModelObjectEnumerator dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static ModelObjectEnumerator FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (ModelObjectEnumerator)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}


