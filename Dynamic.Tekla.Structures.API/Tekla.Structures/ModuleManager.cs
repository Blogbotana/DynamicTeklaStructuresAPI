using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dynamic.Tekla.Structures.Internal.Invoker;

namespace Dynamic.Tekla.Structures;
/// <summary>
/// The ModuleManager class handles the product model module configuration information: the
/// information that defines what configuration the customer is currently running.
/// </summary>
public class ModuleManager
{
    public static Dynamic.Tekla.Structures.ModuleManager.ProgramConfigurationEnum Configuration
    {
        get
        {
            var value = PropertyInvoker.GetStaticPropertyOrFieldValue("Tekla.Structures.ModuleManager", "Configuration");
            var value_ = Dynamic.Tekla.Structures.ModuleManager.ProgramConfigurationEnum_.FromTSObject(value);
            return (Dynamic.Tekla.Structures.ModuleManager.ProgramConfigurationEnum)value_;
        }

    }
    public static bool MultimaterialModeling
    {
        get
        {
            var value = PropertyInvoker.GetStaticPropertyOrFieldValue("Tekla.Structures.ModuleManager", "MultimaterialModeling");
            return (bool)value;
        }

    }
    public static bool LoadModeling
    {
        get
        {
            var value = PropertyInvoker.GetStaticPropertyOrFieldValue("Tekla.Structures.ModuleManager", "LoadModeling");
            return (bool)value;
        }

    }
    public static bool SteelDetailing
    {
        get
        {
            var value = PropertyInvoker.GetStaticPropertyOrFieldValue("Tekla.Structures.ModuleManager", "SteelDetailing");
            return (bool)value;
        }

    }
    public static bool ConcreteDetailing
    {
        get
        {
            var value = PropertyInvoker.GetStaticPropertyOrFieldValue("Tekla.Structures.ModuleManager", "ConcreteDetailing");
            return (bool)value;
        }

    }
    public static bool RebarModeling
    {
        get
        {
            var value = PropertyInvoker.GetStaticPropertyOrFieldValue("Tekla.Structures.ModuleManager", "RebarModeling");
            return (bool)value;
        }

    }
    public static bool AnalysisAndDesign
    {
        get
        {
            var value = PropertyInvoker.GetStaticPropertyOrFieldValue("Tekla.Structures.ModuleManager", "AnalysisAndDesign");
            return (bool)value;
        }

    }
    public static bool TaskManagement
    {
        get
        {
            var value = PropertyInvoker.GetStaticPropertyOrFieldValue("Tekla.Structures.ModuleManager", "TaskManagement");
            return (bool)value;
        }

    }


    internal dynamic teklaObject;

    public ModuleManager()
    {
        this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.ModuleManager");
    }
    //This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
    public ModuleManager(dynamic tsObject, DateTime nonConflictParameter)
    {
        this.teklaObject = tsObject;
    }

    /// <summary> The configuration information of the program. </summary>
	public enum ProgramConfigurationEnum
    {
        /// <summary> The viewer configuration. </summary>
        CONFIGURATION_VIEWER = 0,
        /// <summary> The production planner configuration. </summary>
        CONFIGURATION_PRODUCTION_PLANNER = 1,
        /// <summary> The drafter configuration. </summary>
        CONFIGURATION_DRAFTER = 2,
        /// <summary> The project management configuration. </summary>
        CONFIGURATION_PROJECT_MANAGEMENT = 3,
        /// <summary> The construction management configuration. </summary>
        CONFIGURATION_ENGINEERING = 4,
        /// <summary> The reinforced concrete detailing configuration. </summary>
        CONFIGURATION_REINFORCED_CONCRETE_DETAILING = 5,
        /// <summary> The precast concrete detailing configuration. </summary>
        CONFIGURATION_PRECAST_CONCRETE_DETAILING = 6,
        /// <summary> The steel detailing configuration. </summary>
        CONFIGURATION_STEEL_DETAILING = 7,
        /// <summary> The full detailing configuration. </summary>
        CONFIGURATION_FULL = 8,
        /// <summary> The Primary configuration. </summary>
        CONFIGURATION_PRIMARY = 9,
        /// <summary> The educational configuration. </summary>
        CONFIGURATION_EDUCATIONAL = 10,
        /// <summary> The developer configuration. </summary>
        CONFIGURATION_DEVELOPER = 11,
        /// <summary> The construction management configuration with modeling capabilities. </summary>
        CONFIGURATION_CONSTRUCTION_MODELING = 12,
        /// <obsolete>Deprecated since 19.0 </obsolete><summary> The old steel detailing limited configuration. This definition was left here to enable old macros in 19.0. </summary>
        CONFIGURATION_STEEL_DETAILING_LIMITED = 9,
        /// <obsolete>Deprecated since 20.0 </obsolete><summary> The construction management configuration restricted to viewer mode. </summary>
        CONFIGURATION_CONSTRUCTION_VIEWER = 12,
        /// <obsolete>Deprecated since 20.0 </obsolete>
        CONFIGURATION_CONSTRUCTION_MANAGEMENT = 12,
        /// <summary> The partner configuration. </summary>
        CONFIGURATION_PARTNER = 13,
        /// <summary> The EPM Modeler configuration. </summary>
        CONFIGURATION_EPM_MODELER = 14,
        /// <summary> The Carbon configuration. </summary>
        CONFIGURATION_CARBON = 0xF,
        /// <summary> The Graphite configuration. </summary>
        CONFIGURATION_GRAPHITE = 0x10,
        /// <summary> The Diamond configuration. </summary>
        CONFIGURATION_DIAMOND = 17,
        /// <summary> The MEP configuration. </summary>
        CONFIGURATION_MEP = 18,
        /// <summary> The Trial Configuration. </summary>
        CONFIGURATION_TRIAL = 19
    }
    internal static class ProgramConfigurationEnum_
    {
        public static dynamic GetTSObject(ProgramConfigurationEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.ModuleManager.ProgramConfigurationEnum").GetType();

            switch (dynEnum)
            {
                case ProgramConfigurationEnum.CONFIGURATION_VIEWER:
                    return System.Enum.Parse(tsType, "CONFIGURATION_VIEWER");
                case ProgramConfigurationEnum.CONFIGURATION_PRODUCTION_PLANNER:
                    return System.Enum.Parse(tsType, "CONFIGURATION_PRODUCTION_PLANNER");
                case ProgramConfigurationEnum.CONFIGURATION_DRAFTER:
                    return System.Enum.Parse(tsType, "CONFIGURATION_DRAFTER");
                case ProgramConfigurationEnum.CONFIGURATION_PROJECT_MANAGEMENT:
                    return System.Enum.Parse(tsType, "CONFIGURATION_PROJECT_MANAGEMENT");
                case ProgramConfigurationEnum.CONFIGURATION_ENGINEERING:
                    return System.Enum.Parse(tsType, "CONFIGURATION_ENGINEERING");
                case ProgramConfigurationEnum.CONFIGURATION_REINFORCED_CONCRETE_DETAILING:
                    return System.Enum.Parse(tsType, "CONFIGURATION_REINFORCED_CONCRETE_DETAILING");
                case ProgramConfigurationEnum.CONFIGURATION_PRECAST_CONCRETE_DETAILING:
                    return System.Enum.Parse(tsType, "CONFIGURATION_PRECAST_CONCRETE_DETAILING");
                case ProgramConfigurationEnum.CONFIGURATION_STEEL_DETAILING:
                    return System.Enum.Parse(tsType, "CONFIGURATION_STEEL_DETAILING");
                case ProgramConfigurationEnum.CONFIGURATION_FULL:
                    return System.Enum.Parse(tsType, "CONFIGURATION_FULL");
                case ProgramConfigurationEnum.CONFIGURATION_STEEL_DETAILING_LIMITED:
                    return System.Enum.Parse(tsType, "CONFIGURATION_STEEL_DETAILING_LIMITED");
                case ProgramConfigurationEnum.CONFIGURATION_EDUCATIONAL:
                    return System.Enum.Parse(tsType, "CONFIGURATION_EDUCATIONAL");
                case ProgramConfigurationEnum.CONFIGURATION_DEVELOPER:
                    return System.Enum.Parse(tsType, "CONFIGURATION_DEVELOPER");
                case ProgramConfigurationEnum.CONFIGURATION_CONSTRUCTION_MANAGEMENT:
                    return System.Enum.Parse(tsType, "CONFIGURATION_CONSTRUCTION_MANAGEMENT");
                case ProgramConfigurationEnum.CONFIGURATION_PARTNER:
                    return System.Enum.Parse(tsType, "CONFIGURATION_PARTNER");
                case ProgramConfigurationEnum.CONFIGURATION_EPM_MODELER:
                    return System.Enum.Parse(tsType, "CONFIGURATION_EPM_MODELER");
                case ProgramConfigurationEnum.CONFIGURATION_CARBON:
                    return System.Enum.Parse(tsType, "CONFIGURATION_CARBON");
                case ProgramConfigurationEnum.CONFIGURATION_GRAPHITE:
                    return System.Enum.Parse(tsType, "CONFIGURATION_GRAPHITE");
                case ProgramConfigurationEnum.CONFIGURATION_DIAMOND:
                    return System.Enum.Parse(tsType, "CONFIGURATION_DIAMOND");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }

        public static ProgramConfigurationEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);

            if (tsEnumValue.Equals("CONFIGURATION_VIEWER", System.StringComparison.InvariantCulture))
                return ProgramConfigurationEnum.CONFIGURATION_VIEWER;
            else if (tsEnumValue.Equals("CONFIGURATION_PRODUCTION_PLANNER", System.StringComparison.InvariantCulture))
                return ProgramConfigurationEnum.CONFIGURATION_PRODUCTION_PLANNER;
            else if (tsEnumValue.Equals("CONFIGURATION_DRAFTER", System.StringComparison.InvariantCulture))
                return ProgramConfigurationEnum.CONFIGURATION_DRAFTER;
            else if (tsEnumValue.Equals("CONFIGURATION_PROJECT_MANAGEMENT", System.StringComparison.InvariantCulture))
                return ProgramConfigurationEnum.CONFIGURATION_PROJECT_MANAGEMENT;
            else if (tsEnumValue.Equals("CONFIGURATION_ENGINEERING", System.StringComparison.InvariantCulture))
                return ProgramConfigurationEnum.CONFIGURATION_ENGINEERING;
            else if (tsEnumValue.Equals("CONFIGURATION_REINFORCED_CONCRETE_DETAILING", System.StringComparison.InvariantCulture))
                return ProgramConfigurationEnum.CONFIGURATION_REINFORCED_CONCRETE_DETAILING;
            else if (tsEnumValue.Equals("CONFIGURATION_PRECAST_CONCRETE_DETAILING", System.StringComparison.InvariantCulture))
                return ProgramConfigurationEnum.CONFIGURATION_PRECAST_CONCRETE_DETAILING;
            else if (tsEnumValue.Equals("CONFIGURATION_STEEL_DETAILING", System.StringComparison.InvariantCulture))
                return ProgramConfigurationEnum.CONFIGURATION_STEEL_DETAILING;
            else if (tsEnumValue.Equals("CONFIGURATION_FULL", System.StringComparison.InvariantCulture))
                return ProgramConfigurationEnum.CONFIGURATION_FULL;
            else if (tsEnumValue.Equals("CONFIGURATION_STEEL_DETAILING_LIMITED", System.StringComparison.InvariantCulture))
                return ProgramConfigurationEnum.CONFIGURATION_STEEL_DETAILING_LIMITED;
            else if (tsEnumValue.Equals("CONFIGURATION_EDUCATIONAL", System.StringComparison.InvariantCulture))
                return ProgramConfigurationEnum.CONFIGURATION_EDUCATIONAL;
            else if (tsEnumValue.Equals("CONFIGURATION_DEVELOPER", System.StringComparison.InvariantCulture))
                return ProgramConfigurationEnum.CONFIGURATION_DEVELOPER;
            else if (tsEnumValue.Equals("CONFIGURATION_CONSTRUCTION_MANAGEMENT", System.StringComparison.InvariantCulture))
                return ProgramConfigurationEnum.CONFIGURATION_CONSTRUCTION_MANAGEMENT;
            else if (tsEnumValue.Equals("CONFIGURATION_PARTNER", System.StringComparison.InvariantCulture))
                return ProgramConfigurationEnum.CONFIGURATION_PARTNER;
            else if (tsEnumValue.Equals("CONFIGURATION_EPM_MODELER", System.StringComparison.InvariantCulture))
                return ProgramConfigurationEnum.CONFIGURATION_EPM_MODELER;
            else if (tsEnumValue.Equals("CONFIGURATION_CARBON", System.StringComparison.InvariantCulture))
                return ProgramConfigurationEnum.CONFIGURATION_CARBON;
            else if (tsEnumValue.Equals("CONFIGURATION_GRAPHITE", System.StringComparison.InvariantCulture))
                return ProgramConfigurationEnum.CONFIGURATION_GRAPHITE;
            else if (tsEnumValue.Equals("CONFIGURATION_DIAMOND", System.StringComparison.InvariantCulture))
                return ProgramConfigurationEnum.CONFIGURATION_DIAMOND;

            else
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");

        }
    }
}
