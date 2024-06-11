using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;

namespace Dynamic.Tekla.Structures.Model;


public enum HierarchicDefinitionTypeEnum
{
			DOT_HIERARCHIC_CUSTOM_TYPE,
			DOT_HIERARCHIC_LOGICAL_BUILDING_AREA,
			DOT_HIERARCHIC_OBJECT_TYPE,
			DOT_HIERARCHIC_TASK_WORK_TYPE,
			DOT_HIERARCHIC_TASK_SCENARIO        
}

internal static class HierarchicDefinitionTypeEnum_
{
    public static dynamic GetTSObject(HierarchicDefinitionTypeEnum dynEnum)
    {
        var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.HierarchicDefinitionTypeEnum").GetType();

        switch (dynEnum)
        {
				case HierarchicDefinitionTypeEnum.DOT_HIERARCHIC_CUSTOM_TYPE:
					return System.Enum.Parse(tsType, "DOT_HIERARCHIC_CUSTOM_TYPE");
				case HierarchicDefinitionTypeEnum.DOT_HIERARCHIC_LOGICAL_BUILDING_AREA:
					return System.Enum.Parse(tsType, "DOT_HIERARCHIC_LOGICAL_BUILDING_AREA");
				case HierarchicDefinitionTypeEnum.DOT_HIERARCHIC_OBJECT_TYPE:
					return System.Enum.Parse(tsType, "DOT_HIERARCHIC_OBJECT_TYPE");
				case HierarchicDefinitionTypeEnum.DOT_HIERARCHIC_TASK_WORK_TYPE:
					return System.Enum.Parse(tsType, "DOT_HIERARCHIC_TASK_WORK_TYPE");
				case HierarchicDefinitionTypeEnum.DOT_HIERARCHIC_TASK_SCENARIO:
					return System.Enum.Parse(tsType, "DOT_HIERARCHIC_TASK_SCENARIO");

            default:
                throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
        }
    }

    public static HierarchicDefinitionTypeEnum FromTSObject(dynamic tsEnum)
    {
        string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
        
			if (tsEnumValue.Equals("DOT_HIERARCHIC_CUSTOM_TYPE", System.StringComparison.InvariantCulture))
				return HierarchicDefinitionTypeEnum.DOT_HIERARCHIC_CUSTOM_TYPE;
			else if (tsEnumValue.Equals("DOT_HIERARCHIC_LOGICAL_BUILDING_AREA", System.StringComparison.InvariantCulture))
				return HierarchicDefinitionTypeEnum.DOT_HIERARCHIC_LOGICAL_BUILDING_AREA;
			else if (tsEnumValue.Equals("DOT_HIERARCHIC_OBJECT_TYPE", System.StringComparison.InvariantCulture))
				return HierarchicDefinitionTypeEnum.DOT_HIERARCHIC_OBJECT_TYPE;
			else if (tsEnumValue.Equals("DOT_HIERARCHIC_TASK_WORK_TYPE", System.StringComparison.InvariantCulture))
				return HierarchicDefinitionTypeEnum.DOT_HIERARCHIC_TASK_WORK_TYPE;
			else if (tsEnumValue.Equals("DOT_HIERARCHIC_TASK_SCENARIO", System.StringComparison.InvariantCulture))
				return HierarchicDefinitionTypeEnum.DOT_HIERARCHIC_TASK_SCENARIO;

        else 
            throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
        
    }
}

