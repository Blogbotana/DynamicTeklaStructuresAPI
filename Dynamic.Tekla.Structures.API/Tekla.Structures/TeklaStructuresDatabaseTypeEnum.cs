using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Exceptions;

namespace Dynamic.Tekla.Structures;
/// <summary> The object types to be used in filter expressions.</summary>
public enum TeklaStructuresDatabaseTypeEnum
{
    /// <summary> The unknown type. </summary>
    UNKNOWN = 0,
    /// <summary> The point type, this is not a ModelObject. </summary>
    POINT = 1,
    /// <summary> The part type. </summary>
    PART = 2,
    /// <summary> The connection type, used for details and seams as well. </summary>
    CONNECTION = 3,
    /// <summary> The component type, used for macros, plug-ins and custom parts. </summary>
    COMPONENT = 4,
    /// <summary> The grid type. </summary>
    GRID = 7,
    /// <summary> The fitting type. </summary>
    FITTING = 9,
    /// <summary> The bolt type. </summary>
    BOLT = 10,
    /// <summary> The part cut type. </summary>
    PART_CUT = 11,
    /// <summary> The plane cut type. </summary>
    PLANE_CUT = 12,
    /// <summary> The welding type. </summary>
    WELDING = 13,
    /// <summary> The assembly type. </summary>
    ASSEMBLY = 0xF,
    /// <summary> The construction line type, this is not a ModelObject. </summary>
    CONSTRUCTION_LINE = 24,
    /// <summary> The plane type, used for control planes and grid planes.</summary>
    PLANE = 30,
    /// <summary>The drawing.</summary>
    DRAWING = 34,
    /// <summary>The connection type.</summary>
    DB_CONNECTION = 35,
    /// <summary> The part add type. </summary>
    PART_ADD = 38,
    /// <summary> The weld preparation.</summary>
    WELD_CUT = 39,
    /// <summary> The construction circle type, this is not a ModelObject. </summary>
    CONSTRUCTION_CIRCLE = 42,
    /// <summary>The construction arc</summary>
    CONSTRUCTION_ARC = 43,
    /// <summary> The component type.</summary>
    DB_COMPONENT = 46,
    /// <summary> The rebar type, used for single rebars, groups, meshes and strands.</summary>
    REBAR = 47,
    /// <summary>The foreign object.</summary>
    FOREIGN_OBJECT = 48,
    /// <summary> The load type. </summary>
    LOAD_LOAD = 49,
    /// <summary> The load point type. </summary>
    LOAD_POINT = 50,
    /// <summary> The load line type. </summary>
    LOAD_LINE = 51,
    /// <summary> The load area type. </summary>
    LOAD_AREA = 52,
    /// <summary> The load uniform type. </summary>
    LOAD_UNIFORM = 53,
    /// <summary> The load group type. </summary>
    LOAD_GROUP = 54,
    /// <summary> The temperature load type. </summary>
    LOAD_TEMPERATURELOAD = 72,
    /// <summary> The surface treatment type. </summary>
    SURFACE_TREATMENT = 73,
    /// <summary> The rebar splice type. </summary>
    REBAR_SPLICE = 74,
    /// <summary>The analysis model.</summary>
    ANALYSIS_MODEL = 75,
    /// <summary>The analysis part.</summary>
    ANALYSIS_PART = 76,
    /// <summary>The analysis node.</summary>
    ANALYSIS_NODE = 77,
    /// <summary> The edge chamfer type. </summary>
    EDGE_CHAMFER = 79,
    /// <summary> The task type. </summary>
    TASK = 80,
    /// <summary> The task dependency type. </summary>
    TASK_DEPENDENCY = 81,
    /// <summary> The task worktype type. </summary>
    TASK_WORKTYPE = 83,
    /// <summary> The hierarchic definition type. </summary>
    HIERARCHIC_DEFINITION = 84,
    /// <summary> The hierarchic object type. </summary>
    HIERARCHIC_OBJECT = 85,
    /// <summary> The pour break type. </summary>
    DB_POUR_BREAK = 89,
    /// <summary> The pour object type. </summary>
    DB_POUR_OBJECT = 90,
    /// <summary>The rebar set addition type.</summary>
    REBARSET_ADDITION = 95,
    /// <summary>The rebar set modifier type.</summary>
    REBARSET_MODIFIER = 96,
    /// <summary>The surface object type</summary>
    SURFACE_OBJECT = 97,
    /// <summary>The bent plate type</summary>
    BENT_PLATE = 98,
    /// <summary>The helix type</summary>
    HELIX = 99,
    /// <summary> The pour unit type</summary>
    DB_POUR_UNIT = 101,
    /// <summary>The construction polycurve</summary>
    CONSTRUCTION_POLYCURVE = 103,
    /// <summary>Building Hierarchy Storey</summary>
    STOREY = 104,
    /// <summary>Building Hierarchy Building</summary>
    BUILDING_SITE = 105,
    /// <summary>Building Hierarchy Site</summary>
    BUILDING = 106,
    /// <summary>Building Hierarchy Space</summary>
    SPACE = 108
}

internal static class TeklaStructuresDatabaseTypeEnum_
{
    public static dynamic GetTSObject(TeklaStructuresDatabaseTypeEnum dynEnum)
    {
        var tsType = TSActivator.CreateInstance("Tekla.Structures.TeklaStructuresDatabaseTypeEnum").GetType();

        switch (dynEnum)
        {
            case TeklaStructuresDatabaseTypeEnum.UNKNOWN:
                return System.Enum.Parse(tsType, "UNKNOWN");
            case TeklaStructuresDatabaseTypeEnum.POINT:
                return System.Enum.Parse(tsType, "POINT");
            case TeklaStructuresDatabaseTypeEnum.PART:
                return System.Enum.Parse(tsType, "PART");
            case TeklaStructuresDatabaseTypeEnum.CONNECTION:
                return System.Enum.Parse(tsType, "CONNECTION");
            case TeklaStructuresDatabaseTypeEnum.COMPONENT:
                return System.Enum.Parse(tsType, "COMPONENT");
            case TeklaStructuresDatabaseTypeEnum.GRID:
                return System.Enum.Parse(tsType, "GRID");
            case TeklaStructuresDatabaseTypeEnum.FITTING:
                return System.Enum.Parse(tsType, "FITTING");
            case TeklaStructuresDatabaseTypeEnum.BOLT:
                return System.Enum.Parse(tsType, "BOLT");
            case TeklaStructuresDatabaseTypeEnum.PART_CUT:
                return System.Enum.Parse(tsType, "PART_CUT");
            case TeklaStructuresDatabaseTypeEnum.PLANE_CUT:
                return System.Enum.Parse(tsType, "PLANE_CUT");
            case TeklaStructuresDatabaseTypeEnum.WELDING:
                return System.Enum.Parse(tsType, "WELDING");
            case TeklaStructuresDatabaseTypeEnum.ASSEMBLY:
                return System.Enum.Parse(tsType, "ASSEMBLY");
            case TeklaStructuresDatabaseTypeEnum.CONSTRUCTION_LINE:
                return System.Enum.Parse(tsType, "CONSTRUCTION_LINE");
            case TeklaStructuresDatabaseTypeEnum.PLANE:
                return System.Enum.Parse(tsType, "PLANE");
            case TeklaStructuresDatabaseTypeEnum.DRAWING:
                return System.Enum.Parse(tsType, "DRAWING");
            case TeklaStructuresDatabaseTypeEnum.DB_CONNECTION:
                return System.Enum.Parse(tsType, "DB_CONNECTION");
            case TeklaStructuresDatabaseTypeEnum.PART_ADD:
                return System.Enum.Parse(tsType, "PART_ADD");
            case TeklaStructuresDatabaseTypeEnum.WELD_CUT:
                return System.Enum.Parse(tsType, "WELD_CUT");
            case TeklaStructuresDatabaseTypeEnum.CONSTRUCTION_CIRCLE:
                return System.Enum.Parse(tsType, "CONSTRUCTION_CIRCLE");
            case TeklaStructuresDatabaseTypeEnum.CONSTRUCTION_ARC:
                return System.Enum.Parse(tsType, "CONSTRUCTION_ARC");
            case TeklaStructuresDatabaseTypeEnum.DB_COMPONENT:
                return System.Enum.Parse(tsType, "DB_COMPONENT");
            case TeklaStructuresDatabaseTypeEnum.REBAR:
                return System.Enum.Parse(tsType, "REBAR");
            case TeklaStructuresDatabaseTypeEnum.FOREIGN_OBJECT:
                return System.Enum.Parse(tsType, "FOREIGN_OBJECT");
            case TeklaStructuresDatabaseTypeEnum.LOAD_LOAD:
                return System.Enum.Parse(tsType, "LOAD_LOAD");
            case TeklaStructuresDatabaseTypeEnum.LOAD_POINT:
                return System.Enum.Parse(tsType, "LOAD_POINT");
            case TeklaStructuresDatabaseTypeEnum.LOAD_LINE:
                return System.Enum.Parse(tsType, "LOAD_LINE");
            case TeklaStructuresDatabaseTypeEnum.LOAD_AREA:
                return System.Enum.Parse(tsType, "LOAD_AREA");
            case TeklaStructuresDatabaseTypeEnum.LOAD_UNIFORM:
                return System.Enum.Parse(tsType, "LOAD_UNIFORM");
            case TeklaStructuresDatabaseTypeEnum.LOAD_GROUP:
                return System.Enum.Parse(tsType, "LOAD_GROUP");
            case TeklaStructuresDatabaseTypeEnum.LOAD_TEMPERATURELOAD:
                return System.Enum.Parse(tsType, "LOAD_TEMPERATURELOAD");
            case TeklaStructuresDatabaseTypeEnum.SURFACE_TREATMENT:
                return System.Enum.Parse(tsType, "SURFACE_TREATMENT");
            case TeklaStructuresDatabaseTypeEnum.REBAR_SPLICE:
                return System.Enum.Parse(tsType, "REBAR_SPLICE");
            case TeklaStructuresDatabaseTypeEnum.ANALYSIS_MODEL:
                return System.Enum.Parse(tsType, "ANALYSIS_MODEL");
            case TeklaStructuresDatabaseTypeEnum.ANALYSIS_PART:
                return System.Enum.Parse(tsType, "ANALYSIS_PART");
            case TeklaStructuresDatabaseTypeEnum.ANALYSIS_NODE:
                return System.Enum.Parse(tsType, "ANALYSIS_NODE");
            case TeklaStructuresDatabaseTypeEnum.EDGE_CHAMFER:
                return System.Enum.Parse(tsType, "EDGE_CHAMFER");
            case TeklaStructuresDatabaseTypeEnum.TASK:
                return System.Enum.Parse(tsType, "TASK");
            case TeklaStructuresDatabaseTypeEnum.TASK_DEPENDENCY:
                return System.Enum.Parse(tsType, "TASK_DEPENDENCY");
            case TeklaStructuresDatabaseTypeEnum.TASK_WORKTYPE:
                return System.Enum.Parse(tsType, "TASK_WORKTYPE");
            case TeklaStructuresDatabaseTypeEnum.HIERARCHIC_DEFINITION:
                return System.Enum.Parse(tsType, "HIERARCHIC_DEFINITION");
            case TeklaStructuresDatabaseTypeEnum.HIERARCHIC_OBJECT:
                return System.Enum.Parse(tsType, "HIERARCHIC_OBJECT");
            case TeklaStructuresDatabaseTypeEnum.DB_POUR_BREAK:
                return System.Enum.Parse(tsType, "DB_POUR_BREAK");
            case TeklaStructuresDatabaseTypeEnum.DB_POUR_OBJECT:
                return System.Enum.Parse(tsType, "DB_POUR_OBJECT");
            case TeklaStructuresDatabaseTypeEnum.REBARSET_ADDITION:
                return System.Enum.Parse(tsType, "REBARSET_ADDITION");
            case TeklaStructuresDatabaseTypeEnum.REBARSET_MODIFIER:
                return System.Enum.Parse(tsType, "REBARSET_MODIFIER");
            case TeklaStructuresDatabaseTypeEnum.SURFACE_OBJECT:
                return System.Enum.Parse(tsType, "SURFACE_OBJECT");
            case TeklaStructuresDatabaseTypeEnum.BENT_PLATE:
                return System.Enum.Parse(tsType, "BENT_PLATE");
            case TeklaStructuresDatabaseTypeEnum.HELIX:
                return System.Enum.Parse(tsType, "HELIX");
            case TeklaStructuresDatabaseTypeEnum.DB_POUR_UNIT:
                return System.Enum.Parse(tsType, "DB_POUR_UNIT");
            case TeklaStructuresDatabaseTypeEnum.CONSTRUCTION_POLYCURVE:
                return System.Enum.Parse(tsType, "CONSTRUCTION_POLYCURVE");
            case TeklaStructuresDatabaseTypeEnum.STOREY:
                return System.Enum.Parse(tsType, "STOREY");
            case TeklaStructuresDatabaseTypeEnum.BUILDING_SITE:
                return System.Enum.Parse(tsType, "BUILDING_SITE");
            case TeklaStructuresDatabaseTypeEnum.BUILDING:
                return System.Enum.Parse(tsType, "BUILDING");

            default:
                throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
        }
    }

    public static TeklaStructuresDatabaseTypeEnum FromTSObject(dynamic tsEnum)
    {
        string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);

        if (tsEnumValue.Equals("UNKNOWN", System.StringComparison.InvariantCulture))
            return TeklaStructuresDatabaseTypeEnum.UNKNOWN;
        else if (tsEnumValue.Equals("POINT", System.StringComparison.InvariantCulture))
            return TeklaStructuresDatabaseTypeEnum.POINT;
        else if (tsEnumValue.Equals("PART", System.StringComparison.InvariantCulture))
            return TeklaStructuresDatabaseTypeEnum.PART;
        else if (tsEnumValue.Equals("CONNECTION", System.StringComparison.InvariantCulture))
            return TeklaStructuresDatabaseTypeEnum.CONNECTION;
        else if (tsEnumValue.Equals("COMPONENT", System.StringComparison.InvariantCulture))
            return TeklaStructuresDatabaseTypeEnum.COMPONENT;
        else if (tsEnumValue.Equals("GRID", System.StringComparison.InvariantCulture))
            return TeklaStructuresDatabaseTypeEnum.GRID;
        else if (tsEnumValue.Equals("FITTING", System.StringComparison.InvariantCulture))
            return TeklaStructuresDatabaseTypeEnum.FITTING;
        else if (tsEnumValue.Equals("BOLT", System.StringComparison.InvariantCulture))
            return TeklaStructuresDatabaseTypeEnum.BOLT;
        else if (tsEnumValue.Equals("PART_CUT", System.StringComparison.InvariantCulture))
            return TeklaStructuresDatabaseTypeEnum.PART_CUT;
        else if (tsEnumValue.Equals("PLANE_CUT", System.StringComparison.InvariantCulture))
            return TeklaStructuresDatabaseTypeEnum.PLANE_CUT;
        else if (tsEnumValue.Equals("WELDING", System.StringComparison.InvariantCulture))
            return TeklaStructuresDatabaseTypeEnum.WELDING;
        else if (tsEnumValue.Equals("ASSEMBLY", System.StringComparison.InvariantCulture))
            return TeklaStructuresDatabaseTypeEnum.ASSEMBLY;
        else if (tsEnumValue.Equals("CONSTRUCTION_LINE", System.StringComparison.InvariantCulture))
            return TeklaStructuresDatabaseTypeEnum.CONSTRUCTION_LINE;
        else if (tsEnumValue.Equals("PLANE", System.StringComparison.InvariantCulture))
            return TeklaStructuresDatabaseTypeEnum.PLANE;
        else if (tsEnumValue.Equals("DRAWING", System.StringComparison.InvariantCulture))
            return TeklaStructuresDatabaseTypeEnum.DRAWING;
        else if (tsEnumValue.Equals("DB_CONNECTION", System.StringComparison.InvariantCulture))
            return TeklaStructuresDatabaseTypeEnum.DB_CONNECTION;
        else if (tsEnumValue.Equals("PART_ADD", System.StringComparison.InvariantCulture))
            return TeklaStructuresDatabaseTypeEnum.PART_ADD;
        else if (tsEnumValue.Equals("WELD_CUT", System.StringComparison.InvariantCulture))
            return TeklaStructuresDatabaseTypeEnum.WELD_CUT;
        else if (tsEnumValue.Equals("CONSTRUCTION_CIRCLE", System.StringComparison.InvariantCulture))
            return TeklaStructuresDatabaseTypeEnum.CONSTRUCTION_CIRCLE;
        else if (tsEnumValue.Equals("CONSTRUCTION_ARC", System.StringComparison.InvariantCulture))
            return TeklaStructuresDatabaseTypeEnum.CONSTRUCTION_ARC;
        else if (tsEnumValue.Equals("DB_COMPONENT", System.StringComparison.InvariantCulture))
            return TeklaStructuresDatabaseTypeEnum.DB_COMPONENT;
        else if (tsEnumValue.Equals("REBAR", System.StringComparison.InvariantCulture))
            return TeklaStructuresDatabaseTypeEnum.REBAR;
        else if (tsEnumValue.Equals("FOREIGN_OBJECT", System.StringComparison.InvariantCulture))
            return TeklaStructuresDatabaseTypeEnum.FOREIGN_OBJECT;
        else if (tsEnumValue.Equals("LOAD_LOAD", System.StringComparison.InvariantCulture))
            return TeklaStructuresDatabaseTypeEnum.LOAD_LOAD;
        else if (tsEnumValue.Equals("LOAD_POINT", System.StringComparison.InvariantCulture))
            return TeklaStructuresDatabaseTypeEnum.LOAD_POINT;
        else if (tsEnumValue.Equals("LOAD_LINE", System.StringComparison.InvariantCulture))
            return TeklaStructuresDatabaseTypeEnum.LOAD_LINE;
        else if (tsEnumValue.Equals("LOAD_AREA", System.StringComparison.InvariantCulture))
            return TeklaStructuresDatabaseTypeEnum.LOAD_AREA;
        else if (tsEnumValue.Equals("LOAD_UNIFORM", System.StringComparison.InvariantCulture))
            return TeklaStructuresDatabaseTypeEnum.LOAD_UNIFORM;
        else if (tsEnumValue.Equals("LOAD_GROUP", System.StringComparison.InvariantCulture))
            return TeklaStructuresDatabaseTypeEnum.LOAD_GROUP;
        else if (tsEnumValue.Equals("LOAD_TEMPERATURELOAD", System.StringComparison.InvariantCulture))
            return TeklaStructuresDatabaseTypeEnum.LOAD_TEMPERATURELOAD;
        else if (tsEnumValue.Equals("SURFACE_TREATMENT", System.StringComparison.InvariantCulture))
            return TeklaStructuresDatabaseTypeEnum.SURFACE_TREATMENT;
        else if (tsEnumValue.Equals("REBAR_SPLICE", System.StringComparison.InvariantCulture))
            return TeklaStructuresDatabaseTypeEnum.REBAR_SPLICE;
        else if (tsEnumValue.Equals("ANALYSIS_MODEL", System.StringComparison.InvariantCulture))
            return TeklaStructuresDatabaseTypeEnum.ANALYSIS_MODEL;
        else if (tsEnumValue.Equals("ANALYSIS_PART", System.StringComparison.InvariantCulture))
            return TeklaStructuresDatabaseTypeEnum.ANALYSIS_PART;
        else if (tsEnumValue.Equals("ANALYSIS_NODE", System.StringComparison.InvariantCulture))
            return TeklaStructuresDatabaseTypeEnum.ANALYSIS_NODE;
        else if (tsEnumValue.Equals("EDGE_CHAMFER", System.StringComparison.InvariantCulture))
            return TeklaStructuresDatabaseTypeEnum.EDGE_CHAMFER;
        else if (tsEnumValue.Equals("TASK", System.StringComparison.InvariantCulture))
            return TeklaStructuresDatabaseTypeEnum.TASK;
        else if (tsEnumValue.Equals("TASK_DEPENDENCY", System.StringComparison.InvariantCulture))
            return TeklaStructuresDatabaseTypeEnum.TASK_DEPENDENCY;
        else if (tsEnumValue.Equals("TASK_WORKTYPE", System.StringComparison.InvariantCulture))
            return TeklaStructuresDatabaseTypeEnum.TASK_WORKTYPE;
        else if (tsEnumValue.Equals("HIERARCHIC_DEFINITION", System.StringComparison.InvariantCulture))
            return TeklaStructuresDatabaseTypeEnum.HIERARCHIC_DEFINITION;
        else if (tsEnumValue.Equals("HIERARCHIC_OBJECT", System.StringComparison.InvariantCulture))
            return TeklaStructuresDatabaseTypeEnum.HIERARCHIC_OBJECT;
        else if (tsEnumValue.Equals("DB_POUR_BREAK", System.StringComparison.InvariantCulture))
            return TeklaStructuresDatabaseTypeEnum.DB_POUR_BREAK;
        else if (tsEnumValue.Equals("DB_POUR_OBJECT", System.StringComparison.InvariantCulture))
            return TeklaStructuresDatabaseTypeEnum.DB_POUR_OBJECT;
        else if (tsEnumValue.Equals("REBARSET_ADDITION", System.StringComparison.InvariantCulture))
            return TeklaStructuresDatabaseTypeEnum.REBARSET_ADDITION;
        else if (tsEnumValue.Equals("REBARSET_MODIFIER", System.StringComparison.InvariantCulture))
            return TeklaStructuresDatabaseTypeEnum.REBARSET_MODIFIER;
        else if (tsEnumValue.Equals("SURFACE_OBJECT", System.StringComparison.InvariantCulture))
            return TeklaStructuresDatabaseTypeEnum.SURFACE_OBJECT;
        else if (tsEnumValue.Equals("BENT_PLATE", System.StringComparison.InvariantCulture))
            return TeklaStructuresDatabaseTypeEnum.BENT_PLATE;
        else if (tsEnumValue.Equals("HELIX", System.StringComparison.InvariantCulture))
            return TeklaStructuresDatabaseTypeEnum.HELIX;
        else if (tsEnumValue.Equals("DB_POUR_UNIT", System.StringComparison.InvariantCulture))
            return TeklaStructuresDatabaseTypeEnum.DB_POUR_UNIT;
        else if (tsEnumValue.Equals("CONSTRUCTION_POLYCURVE", System.StringComparison.InvariantCulture))
            return TeklaStructuresDatabaseTypeEnum.CONSTRUCTION_POLYCURVE;
        else if (tsEnumValue.Equals("STOREY", System.StringComparison.InvariantCulture))
            return TeklaStructuresDatabaseTypeEnum.STOREY;
        else if (tsEnumValue.Equals("BUILDING_SITE", System.StringComparison.InvariantCulture))
            return TeklaStructuresDatabaseTypeEnum.BUILDING_SITE;
        else if (tsEnumValue.Equals("BUILDING", System.StringComparison.InvariantCulture))
            return TeklaStructuresDatabaseTypeEnum.BUILDING;

        else
            throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");

    }
}
