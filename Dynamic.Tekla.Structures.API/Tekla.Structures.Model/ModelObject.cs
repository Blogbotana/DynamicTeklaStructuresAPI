using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Dynamic.Tekla.Structures.Model;
/// <summary>
/// The ModelObject class is an abstract base class for all model objects, such as parts, bolts,
/// welds and reinforcements.
/// </summary>
public abstract class ModelObject : Object
{
    public DateTime? ModificationTime
    {
        get
        {
            try
            {
                return teklaObject.ModificationTime;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ModificationTime), ex);
            }
        }

    }

    public bool IsUpToDate
    {
        get
        {
            try
            {
                return teklaObject.IsUpToDate;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(IsUpToDate), ex);
            }
        }

    }
    public bool Insert()
    {

        try
        {
            var result = (bool)teklaObject.Insert();

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Insert), ex);
        }
    }



    public bool Select()
    {

        try
        {
            var result = (bool)teklaObject.Select();

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Select), ex);
        }
    }



    public bool Modify()
    {

        try
        {
            var result = (bool)teklaObject.Modify();

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Modify), ex);
        }
    }



    public bool Delete()
    {

        try
        {
            var result = (bool)teklaObject.Delete();

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Delete), ex);
        }
    }



    public ModelObjectEnumerator GetChildren()
    {

        try
        {
            var result = teklaObject.GetChildren();

            var _result = ModelObjectEnumerator_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetChildren), ex);
        }
    }



    public BaseComponent GetFatherComponent()
    {

        try
        {
            var result = teklaObject.GetFatherComponent();

            var _result = BaseComponent_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetFatherComponent), ex);
        }
    }



    public ModelObjectEnumerator GetHierarchicObjects()
    {

        try
        {
            var result = teklaObject.GetHierarchicObjects();

            var _result = ModelObjectEnumerator_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetHierarchicObjects), ex);
        }
    }



    public bool GetAllUserProperties(ref Hashtable values)
    {

        try
        {
            var result = (bool)teklaObject.GetAllUserProperties(ref values);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetAllUserProperties), ex);
        }
    }



    public bool GetIntegerUserProperties(ref Hashtable values)
    {

        try
        {
            var result = (bool)teklaObject.GetIntegerUserProperties(ref values);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetIntegerUserProperties), ex);
        }
    }



    public bool GetDoubleUserProperties(ref Hashtable values)
    {

        try
        {
            var result = (bool)teklaObject.GetDoubleUserProperties(ref values);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetDoubleUserProperties), ex);
        }
    }



    public bool GetStringUserProperties(ref Hashtable values)
    {

        try
        {
            var result = (bool)teklaObject.GetStringUserProperties(ref values);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetStringUserProperties), ex);
        }
    }



    public bool GetAllReportProperties(ArrayList stringNames_, ArrayList doubleNames_,
        ArrayList integerNames_,
        ref Hashtable values)
    {
        var stringNames = ArrayListConverter.ToTSObjects(stringNames_);
        var doubleNames = ArrayListConverter.ToTSObjects(doubleNames_);
        var integerNames = ArrayListConverter.ToTSObjects(integerNames_);
        try
        {
            var result = (bool)teklaObject.GetAllReportProperties(stringNames, doubleNames, integerNames, ref values);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetAllReportProperties), ex);
        }
    }



    public bool GetIntegerReportProperties(ArrayList names_, ref Hashtable values)
    {
        var names = ArrayListConverter.ToTSObjects(names_);
        try
        {
            var result = (bool)teklaObject.GetIntegerReportProperties(names, ref values);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetIntegerReportProperties), ex);
        }
    }



    public bool GetDoubleReportProperties(ArrayList names_, ref Hashtable values)
    {
        var names = ArrayListConverter.ToTSObjects(names_);
        try
        {
            var result = (bool)teklaObject.GetDoubleReportProperties(names, ref values);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetDoubleReportProperties), ex);
        }
    }



    public bool GetStringReportProperties(ArrayList names_, ref Hashtable values)
    {
        var names = ArrayListConverter.ToTSObjects(names_);
        try
        {
            var result = (bool)teklaObject.GetStringReportProperties(names, ref values);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetStringReportProperties), ex);
        }
    }



    public bool GetUserProperty(string name, ref string value)
    {
        try
        {
            var result = (bool)teklaObject.GetUserProperty(name, ref value);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetUserProperty), ex);
        }
    }



    public bool GetReportProperty(string name, ref string value)
    {
        try
        {
            var result = (bool)teklaObject.GetReportProperty(name, ref value);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetReportProperty), ex);
        }
    }



    public bool GetUserProperty(string name, ref double value)
    {
        try
        {
            var result = (bool)teklaObject.GetUserProperty(name, ref value);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetUserProperty), ex);
        }
    }



    public bool GetReportProperty(string name, ref double value)
    {
        try
        {
            var result = (bool)teklaObject.GetReportProperty(name, ref value);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetReportProperty), ex);
        }
    }



    public bool GetUserProperty(string name, ref int value)
    {
        try
        {
            var result = (bool)teklaObject.GetUserProperty(name, ref value);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetUserProperty), ex);
        }
    }



    public bool GetReportProperty(string name, ref int value)
    {
        try
        {
            var result = (bool)teklaObject.GetReportProperty(name, ref value);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetReportProperty), ex);
        }
    }



    public bool GetDynamicStringProperty(string name, ref string value)
    {
        try
        {
            var result = (bool)teklaObject.GetDynamicStringProperty(name, ref value);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetDynamicStringProperty), ex);
        }
    }



    public bool SetDynamicStringProperty(string name, string value)
    {
        try
        {
            var result = (bool)teklaObject.SetDynamicStringProperty(name, value);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SetDynamicStringProperty), ex);
        }
    }



    public bool SetUserProperty(string name, string value)
    {
        try
        {
            var result = (bool)teklaObject.SetUserProperty(name, value);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SetUserProperty), ex);
        }
    }



    public bool SetUserProperty(string name, double value)
    {
        try
        {
            var result = (bool)teklaObject.SetUserProperty(name, value);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SetUserProperty), ex);
        }
    }



    public bool SetUserProperty(string name, int value)
    {
        try
        {
            var result = (bool)teklaObject.SetUserProperty(name, value);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SetUserProperty), ex);
        }
    }



    public bool SetUserProperties(
        List<string> stringPropertyNames,
        List<string> stringValues,
        List<string> doublePropertyNames,
        List<double> doubleValues,
        List<string> intPropertyNames,
        List<int> intValues)
    {


        try
        {
            var result = (bool)teklaObject.SetUserProperties(stringPropertyNames, stringValues, doublePropertyNames, doubleValues, intPropertyNames, intValues);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SetUserProperties), ex);
        }
    }



    public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem GetCoordinateSystem()
    {

        try
        {
            var result = teklaObject.GetCoordinateSystem();

            var _result = Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetCoordinateSystem), ex);
        }
    }

    public bool SetPhase(Phase phase_)
    {
        var phase = Phase_.GetTSObject(phase_);
        try
        {
            var result = (bool)teklaObject.SetPhase(phase);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SetPhase), ex);
        }
    }

    public bool GetPhase(out Phase phase_)
    {
        var phase = Phase_.GetTSObject(null);
        try
        {
            var result = (bool)MethodInvoker.InvokeMethod("Tekla.Structures.Model.ModelObject", "GetPhase", teklaObject, out phase);
            phase_ = Phase_.FromTSObject(phase);
            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetPhase), ex);
        }
    }

    public bool SetLabel(string label)
    {

        try
        {
            var result = (bool)teklaObject.SetLabel(label);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SetLabel), ex);
        }
    }


    public int CompareTo(object obj)
    {

        try
        {
            var result = (int)teklaObject.CompareTo(obj);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(CompareTo), ex);
        }
    }
    public enum ModelObjectEnum
    {
        UNKNOWN,
        BEAM,
        POLYBEAM,
        CONTOURPLATE,
        BOOLEANPART,
        FITTING,
        CUTPLANE,
        SURFACE_TREATMENT,
        WELD,
        ASSEMBLY,
        SINGLEREBAR,
        REBARGROUP,
        REBARMESH,
        REBARSTRAND,
        CONTROL_PLANE,
        BOLT_ARRAY,
        BOLT_CIRCLE,
        BOLT_XYLIST,
        LOAD_POINT,
        LOAD_LINE,
        LOAD_AREA,
        LOAD_UNIFORM,
        GRID,
        GRIDPLANE,
        CONNECTION,
        COMPONENT,
        SEAM,
        DETAIL,
        REFERENCE_MODEL,
        REBAR_SPLICE,
        LOAD_GROUP,
        TASK,
        TASK_DEPENDENCY,
        TASK_WORKTYPE,
        POLYGON_WELD,
        LOGICAL_WELD,
        CIRCLEREBAR,
        HIERARCHIC_DEFINITION,
        HIERARCHIC_OBJECT,
        ANALYSIS_GEOMETRY,
        ANALYSIS_PART,
        REFERENCE_MODEL_OBJECT,
        CUSTOM_PART,
        CIRCLE_REBARGROUP,
        CURVED_REBARGROUP,
        EDGE_CHAMFER,
        POUR_OBJECT,
        POUR_BREAK,
        CONTROL_LINE,
        LOAD_TEMPERATURE,
        BREP,
        CONTROL_CIRCLE,
        CONTROL_POINT,
        REBAR_SET,
        REBAR_SET_ADDITION,
        REBAR_PROPERTY_MODIFIER,
        REBAR_END_DETAIL_MODIFIER,
        REBAR_SPLITTER,
        SURFACE_OBJECT,
        BENT_PLATE,
        SPIRAL_BEAM,
        POUR_UNIT,
        CONTROL_ARC,
        CONTROL_SPLINE,
        CONTROL_POLYCURVE,
        RADIAL_GRID,
        GRID_CYLINDRICAL_SURFACE,
        LOFTED_PLATE,
        LEG_SURFACE_OBJECT,
        STOREY,
        SPACE,
        BUILDING
    }

    internal static class ModelObjectEnum_
    {
        public static dynamic GetTSObject(ModelObjectEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.ModelObject.ModelObjectEnum").GetType();

            switch (dynEnum)
            {
                case ModelObjectEnum.UNKNOWN:
                    return System.Enum.Parse(tsType, "UNKNOWN");
                case ModelObjectEnum.BEAM:
                    return System.Enum.Parse(tsType, "BEAM");
                case ModelObjectEnum.POLYBEAM:
                    return System.Enum.Parse(tsType, "POLYBEAM");
                case ModelObjectEnum.CONTOURPLATE:
                    return System.Enum.Parse(tsType, "CONTOURPLATE");
                case ModelObjectEnum.BOOLEANPART:
                    return System.Enum.Parse(tsType, "BOOLEANPART");
                case ModelObjectEnum.FITTING:
                    return System.Enum.Parse(tsType, "FITTING");
                case ModelObjectEnum.CUTPLANE:
                    return System.Enum.Parse(tsType, "CUTPLANE");
                case ModelObjectEnum.SURFACE_TREATMENT:
                    return System.Enum.Parse(tsType, "SURFACE_TREATMENT");
                case ModelObjectEnum.WELD:
                    return System.Enum.Parse(tsType, "WELD");
                case ModelObjectEnum.ASSEMBLY:
                    return System.Enum.Parse(tsType, "ASSEMBLY");
                case ModelObjectEnum.SINGLEREBAR:
                    return System.Enum.Parse(tsType, "SINGLEREBAR");
                case ModelObjectEnum.REBARGROUP:
                    return System.Enum.Parse(tsType, "REBARGROUP");
                case ModelObjectEnum.REBARMESH:
                    return System.Enum.Parse(tsType, "REBARMESH");
                case ModelObjectEnum.REBARSTRAND:
                    return System.Enum.Parse(tsType, "REBARSTRAND");
                case ModelObjectEnum.CONTROL_PLANE:
                    return System.Enum.Parse(tsType, "CONTROL_PLANE");
                case ModelObjectEnum.BOLT_ARRAY:
                    return System.Enum.Parse(tsType, "BOLT_ARRAY");
                case ModelObjectEnum.BOLT_CIRCLE:
                    return System.Enum.Parse(tsType, "BOLT_CIRCLE");
                case ModelObjectEnum.BOLT_XYLIST:
                    return System.Enum.Parse(tsType, "BOLT_XYLIST");
                case ModelObjectEnum.LOAD_POINT:
                    return System.Enum.Parse(tsType, "LOAD_POINT");
                case ModelObjectEnum.LOAD_LINE:
                    return System.Enum.Parse(tsType, "LOAD_LINE");
                case ModelObjectEnum.LOAD_AREA:
                    return System.Enum.Parse(tsType, "LOAD_AREA");
                case ModelObjectEnum.LOAD_UNIFORM:
                    return System.Enum.Parse(tsType, "LOAD_UNIFORM");
                case ModelObjectEnum.GRID:
                    return System.Enum.Parse(tsType, "GRID");
                case ModelObjectEnum.GRIDPLANE:
                    return System.Enum.Parse(tsType, "GRIDPLANE");
                case ModelObjectEnum.CONNECTION:
                    return System.Enum.Parse(tsType, "CONNECTION");
                case ModelObjectEnum.COMPONENT:
                    return System.Enum.Parse(tsType, "COMPONENT");
                case ModelObjectEnum.SEAM:
                    return System.Enum.Parse(tsType, "SEAM");
                case ModelObjectEnum.DETAIL:
                    return System.Enum.Parse(tsType, "DETAIL");
                case ModelObjectEnum.REFERENCE_MODEL:
                    return System.Enum.Parse(tsType, "REFERENCE_MODEL");
                case ModelObjectEnum.REBAR_SPLICE:
                    return System.Enum.Parse(tsType, "REBAR_SPLICE");
                case ModelObjectEnum.LOAD_GROUP:
                    return System.Enum.Parse(tsType, "LOAD_GROUP");
                case ModelObjectEnum.TASK:
                    return System.Enum.Parse(tsType, "TASK");
                case ModelObjectEnum.TASK_DEPENDENCY:
                    return System.Enum.Parse(tsType, "TASK_DEPENDENCY");
                case ModelObjectEnum.TASK_WORKTYPE:
                    return System.Enum.Parse(tsType, "TASK_WORKTYPE");
                case ModelObjectEnum.POLYGON_WELD:
                    return System.Enum.Parse(tsType, "POLYGON_WELD");
                case ModelObjectEnum.LOGICAL_WELD:
                    return System.Enum.Parse(tsType, "LOGICAL_WELD");
                case ModelObjectEnum.CIRCLEREBAR:
                    return System.Enum.Parse(tsType, "CIRCLEREBAR");
                case ModelObjectEnum.HIERARCHIC_DEFINITION:
                    return System.Enum.Parse(tsType, "HIERARCHIC_DEFINITION");
                case ModelObjectEnum.HIERARCHIC_OBJECT:
                    return System.Enum.Parse(tsType, "HIERARCHIC_OBJECT");
                case ModelObjectEnum.ANALYSIS_GEOMETRY:
                    return System.Enum.Parse(tsType, "ANALYSIS_GEOMETRY");
                case ModelObjectEnum.ANALYSIS_PART:
                    return System.Enum.Parse(tsType, "ANALYSIS_PART");
                case ModelObjectEnum.REFERENCE_MODEL_OBJECT:
                    return System.Enum.Parse(tsType, "REFERENCE_MODEL_OBJECT");
                case ModelObjectEnum.CUSTOM_PART:
                    return System.Enum.Parse(tsType, "CUSTOM_PART");
                case ModelObjectEnum.CIRCLE_REBARGROUP:
                    return System.Enum.Parse(tsType, "CIRCLE_REBARGROUP");
                case ModelObjectEnum.CURVED_REBARGROUP:
                    return System.Enum.Parse(tsType, "CURVED_REBARGROUP");
                case ModelObjectEnum.EDGE_CHAMFER:
                    return System.Enum.Parse(tsType, "EDGE_CHAMFER");
                case ModelObjectEnum.POUR_OBJECT:
                    return System.Enum.Parse(tsType, "POUR_OBJECT");
                case ModelObjectEnum.POUR_BREAK:
                    return System.Enum.Parse(tsType, "POUR_BREAK");
                case ModelObjectEnum.CONTROL_LINE:
                    return System.Enum.Parse(tsType, "CONTROL_LINE");
                case ModelObjectEnum.LOAD_TEMPERATURE:
                    return System.Enum.Parse(tsType, "LOAD_TEMPERATURE");
                case ModelObjectEnum.BREP:
                    return System.Enum.Parse(tsType, "BREP");
                case ModelObjectEnum.CONTROL_CIRCLE:
                    return System.Enum.Parse(tsType, "CONTROL_CIRCLE");
                case ModelObjectEnum.CONTROL_POINT:
                    return System.Enum.Parse(tsType, "CONTROL_POINT");
                case ModelObjectEnum.REBAR_SET:
                    return System.Enum.Parse(tsType, "REBAR_SET");
                case ModelObjectEnum.REBAR_SET_ADDITION:
                    return System.Enum.Parse(tsType, "REBAR_SET_ADDITION");
                case ModelObjectEnum.REBAR_PROPERTY_MODIFIER:
                    return System.Enum.Parse(tsType, "REBAR_PROPERTY_MODIFIER");
                case ModelObjectEnum.REBAR_END_DETAIL_MODIFIER:
                    return System.Enum.Parse(tsType, "REBAR_END_DETAIL_MODIFIER");
                case ModelObjectEnum.REBAR_SPLITTER:
                    return System.Enum.Parse(tsType, "REBAR_SPLITTER");
                case ModelObjectEnum.SURFACE_OBJECT:
                    return System.Enum.Parse(tsType, "SURFACE_OBJECT");
                case ModelObjectEnum.BENT_PLATE:
                    return System.Enum.Parse(tsType, "BENT_PLATE");
                case ModelObjectEnum.SPIRAL_BEAM:
                    return System.Enum.Parse(tsType, "SPIRAL_BEAM");
                case ModelObjectEnum.POUR_UNIT:
                    return System.Enum.Parse(tsType, "POUR_UNIT");
                case ModelObjectEnum.CONTROL_ARC:
                    return System.Enum.Parse(tsType, "CONTROL_ARC");
                case ModelObjectEnum.CONTROL_SPLINE:
                    return System.Enum.Parse(tsType, "CONTROL_SPLINE");
                case ModelObjectEnum.CONTROL_POLYCURVE:
                    return System.Enum.Parse(tsType, "CONTROL_POLYCURVE");
                case ModelObjectEnum.RADIAL_GRID:
                    return System.Enum.Parse(tsType, "RADIAL_GRID");
                case ModelObjectEnum.GRID_CYLINDRICAL_SURFACE:
                    return System.Enum.Parse(tsType, "GRID_CYLINDRICAL_SURFACE");
                case ModelObjectEnum.LOFTED_PLATE:
                    return System.Enum.Parse(tsType, "LOFTED_PLATE");
                case ModelObjectEnum.LEG_SURFACE_OBJECT:
                    return System.Enum.Parse(tsType, "LEG_SURFACE_OBJECT");
                case ModelObjectEnum.STOREY:
                    return System.Enum.Parse(tsType, "STOREY");
                case ModelObjectEnum.SPACE:
                    return System.Enum.Parse(tsType, "SPACE");
                case ModelObjectEnum.BUILDING:
                    return System.Enum.Parse(tsType, "BUILDING");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }

        public static ModelObjectEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);

            if (tsEnumValue.Equals("UNKNOWN", System.StringComparison.InvariantCulture))
                return ModelObjectEnum.UNKNOWN;
            else if (tsEnumValue.Equals("BEAM", System.StringComparison.InvariantCulture))
                return ModelObjectEnum.BEAM;
            else if (tsEnumValue.Equals("POLYBEAM", System.StringComparison.InvariantCulture))
                return ModelObjectEnum.POLYBEAM;
            else if (tsEnumValue.Equals("CONTOURPLATE", System.StringComparison.InvariantCulture))
                return ModelObjectEnum.CONTOURPLATE;
            else if (tsEnumValue.Equals("BOOLEANPART", System.StringComparison.InvariantCulture))
                return ModelObjectEnum.BOOLEANPART;
            else if (tsEnumValue.Equals("FITTING", System.StringComparison.InvariantCulture))
                return ModelObjectEnum.FITTING;
            else if (tsEnumValue.Equals("CUTPLANE", System.StringComparison.InvariantCulture))
                return ModelObjectEnum.CUTPLANE;
            else if (tsEnumValue.Equals("SURFACE_TREATMENT", System.StringComparison.InvariantCulture))
                return ModelObjectEnum.SURFACE_TREATMENT;
            else if (tsEnumValue.Equals("WELD", System.StringComparison.InvariantCulture))
                return ModelObjectEnum.WELD;
            else if (tsEnumValue.Equals("ASSEMBLY", System.StringComparison.InvariantCulture))
                return ModelObjectEnum.ASSEMBLY;
            else if (tsEnumValue.Equals("SINGLEREBAR", System.StringComparison.InvariantCulture))
                return ModelObjectEnum.SINGLEREBAR;
            else if (tsEnumValue.Equals("REBARGROUP", System.StringComparison.InvariantCulture))
                return ModelObjectEnum.REBARGROUP;
            else if (tsEnumValue.Equals("REBARMESH", System.StringComparison.InvariantCulture))
                return ModelObjectEnum.REBARMESH;
            else if (tsEnumValue.Equals("REBARSTRAND", System.StringComparison.InvariantCulture))
                return ModelObjectEnum.REBARSTRAND;
            else if (tsEnumValue.Equals("CONTROL_PLANE", System.StringComparison.InvariantCulture))
                return ModelObjectEnum.CONTROL_PLANE;
            else if (tsEnumValue.Equals("BOLT_ARRAY", System.StringComparison.InvariantCulture))
                return ModelObjectEnum.BOLT_ARRAY;
            else if (tsEnumValue.Equals("BOLT_CIRCLE", System.StringComparison.InvariantCulture))
                return ModelObjectEnum.BOLT_CIRCLE;
            else if (tsEnumValue.Equals("BOLT_XYLIST", System.StringComparison.InvariantCulture))
                return ModelObjectEnum.BOLT_XYLIST;
            else if (tsEnumValue.Equals("LOAD_POINT", System.StringComparison.InvariantCulture))
                return ModelObjectEnum.LOAD_POINT;
            else if (tsEnumValue.Equals("LOAD_LINE", System.StringComparison.InvariantCulture))
                return ModelObjectEnum.LOAD_LINE;
            else if (tsEnumValue.Equals("LOAD_AREA", System.StringComparison.InvariantCulture))
                return ModelObjectEnum.LOAD_AREA;
            else if (tsEnumValue.Equals("LOAD_UNIFORM", System.StringComparison.InvariantCulture))
                return ModelObjectEnum.LOAD_UNIFORM;
            else if (tsEnumValue.Equals("GRID", System.StringComparison.InvariantCulture))
                return ModelObjectEnum.GRID;
            else if (tsEnumValue.Equals("GRIDPLANE", System.StringComparison.InvariantCulture))
                return ModelObjectEnum.GRIDPLANE;
            else if (tsEnumValue.Equals("CONNECTION", System.StringComparison.InvariantCulture))
                return ModelObjectEnum.CONNECTION;
            else if (tsEnumValue.Equals("COMPONENT", System.StringComparison.InvariantCulture))
                return ModelObjectEnum.COMPONENT;
            else if (tsEnumValue.Equals("SEAM", System.StringComparison.InvariantCulture))
                return ModelObjectEnum.SEAM;
            else if (tsEnumValue.Equals("DETAIL", System.StringComparison.InvariantCulture))
                return ModelObjectEnum.DETAIL;
            else if (tsEnumValue.Equals("REFERENCE_MODEL", System.StringComparison.InvariantCulture))
                return ModelObjectEnum.REFERENCE_MODEL;
            else if (tsEnumValue.Equals("REBAR_SPLICE", System.StringComparison.InvariantCulture))
                return ModelObjectEnum.REBAR_SPLICE;
            else if (tsEnumValue.Equals("LOAD_GROUP", System.StringComparison.InvariantCulture))
                return ModelObjectEnum.LOAD_GROUP;
            else if (tsEnumValue.Equals("TASK", System.StringComparison.InvariantCulture))
                return ModelObjectEnum.TASK;
            else if (tsEnumValue.Equals("TASK_DEPENDENCY", System.StringComparison.InvariantCulture))
                return ModelObjectEnum.TASK_DEPENDENCY;
            else if (tsEnumValue.Equals("TASK_WORKTYPE", System.StringComparison.InvariantCulture))
                return ModelObjectEnum.TASK_WORKTYPE;
            else if (tsEnumValue.Equals("POLYGON_WELD", System.StringComparison.InvariantCulture))
                return ModelObjectEnum.POLYGON_WELD;
            else if (tsEnumValue.Equals("LOGICAL_WELD", System.StringComparison.InvariantCulture))
                return ModelObjectEnum.LOGICAL_WELD;
            else if (tsEnumValue.Equals("CIRCLEREBAR", System.StringComparison.InvariantCulture))
                return ModelObjectEnum.CIRCLEREBAR;
            else if (tsEnumValue.Equals("HIERARCHIC_DEFINITION", System.StringComparison.InvariantCulture))
                return ModelObjectEnum.HIERARCHIC_DEFINITION;
            else if (tsEnumValue.Equals("HIERARCHIC_OBJECT", System.StringComparison.InvariantCulture))
                return ModelObjectEnum.HIERARCHIC_OBJECT;
            else if (tsEnumValue.Equals("ANALYSIS_GEOMETRY", System.StringComparison.InvariantCulture))
                return ModelObjectEnum.ANALYSIS_GEOMETRY;
            else if (tsEnumValue.Equals("ANALYSIS_PART", System.StringComparison.InvariantCulture))
                return ModelObjectEnum.ANALYSIS_PART;
            else if (tsEnumValue.Equals("REFERENCE_MODEL_OBJECT", System.StringComparison.InvariantCulture))
                return ModelObjectEnum.REFERENCE_MODEL_OBJECT;
            else if (tsEnumValue.Equals("CUSTOM_PART", System.StringComparison.InvariantCulture))
                return ModelObjectEnum.CUSTOM_PART;
            else if (tsEnumValue.Equals("CIRCLE_REBARGROUP", System.StringComparison.InvariantCulture))
                return ModelObjectEnum.CIRCLE_REBARGROUP;
            else if (tsEnumValue.Equals("CURVED_REBARGROUP", System.StringComparison.InvariantCulture))
                return ModelObjectEnum.CURVED_REBARGROUP;
            else if (tsEnumValue.Equals("EDGE_CHAMFER", System.StringComparison.InvariantCulture))
                return ModelObjectEnum.EDGE_CHAMFER;
            else if (tsEnumValue.Equals("POUR_OBJECT", System.StringComparison.InvariantCulture))
                return ModelObjectEnum.POUR_OBJECT;
            else if (tsEnumValue.Equals("POUR_BREAK", System.StringComparison.InvariantCulture))
                return ModelObjectEnum.POUR_BREAK;
            else if (tsEnumValue.Equals("CONTROL_LINE", System.StringComparison.InvariantCulture))
                return ModelObjectEnum.CONTROL_LINE;
            else if (tsEnumValue.Equals("LOAD_TEMPERATURE", System.StringComparison.InvariantCulture))
                return ModelObjectEnum.LOAD_TEMPERATURE;
            else if (tsEnumValue.Equals("BREP", System.StringComparison.InvariantCulture))
                return ModelObjectEnum.BREP;
            else if (tsEnumValue.Equals("CONTROL_CIRCLE", System.StringComparison.InvariantCulture))
                return ModelObjectEnum.CONTROL_CIRCLE;
            else if (tsEnumValue.Equals("CONTROL_POINT", System.StringComparison.InvariantCulture))
                return ModelObjectEnum.CONTROL_POINT;
            else if (tsEnumValue.Equals("REBAR_SET", System.StringComparison.InvariantCulture))
                return ModelObjectEnum.REBAR_SET;
            else if (tsEnumValue.Equals("REBAR_SET_ADDITION", System.StringComparison.InvariantCulture))
                return ModelObjectEnum.REBAR_SET_ADDITION;
            else if (tsEnumValue.Equals("REBAR_PROPERTY_MODIFIER", System.StringComparison.InvariantCulture))
                return ModelObjectEnum.REBAR_PROPERTY_MODIFIER;
            else if (tsEnumValue.Equals("REBAR_END_DETAIL_MODIFIER", System.StringComparison.InvariantCulture))
                return ModelObjectEnum.REBAR_END_DETAIL_MODIFIER;
            else if (tsEnumValue.Equals("REBAR_SPLITTER", System.StringComparison.InvariantCulture))
                return ModelObjectEnum.REBAR_SPLITTER;
            else if (tsEnumValue.Equals("SURFACE_OBJECT", System.StringComparison.InvariantCulture))
                return ModelObjectEnum.SURFACE_OBJECT;
            else if (tsEnumValue.Equals("BENT_PLATE", System.StringComparison.InvariantCulture))
                return ModelObjectEnum.BENT_PLATE;
            else if (tsEnumValue.Equals("SPIRAL_BEAM", System.StringComparison.InvariantCulture))
                return ModelObjectEnum.SPIRAL_BEAM;
            else if (tsEnumValue.Equals("POUR_UNIT", System.StringComparison.InvariantCulture))
                return ModelObjectEnum.POUR_UNIT;
            else if (tsEnumValue.Equals("CONTROL_ARC", System.StringComparison.InvariantCulture))
                return ModelObjectEnum.CONTROL_ARC;
            else if (tsEnumValue.Equals("CONTROL_SPLINE", System.StringComparison.InvariantCulture))
                return ModelObjectEnum.CONTROL_SPLINE;
            else if (tsEnumValue.Equals("CONTROL_POLYCURVE", System.StringComparison.InvariantCulture))
                return ModelObjectEnum.CONTROL_POLYCURVE;
            else if (tsEnumValue.Equals("RADIAL_GRID", System.StringComparison.InvariantCulture))
                return ModelObjectEnum.RADIAL_GRID;
            else if (tsEnumValue.Equals("GRID_CYLINDRICAL_SURFACE", System.StringComparison.InvariantCulture))
                return ModelObjectEnum.GRID_CYLINDRICAL_SURFACE;
            else if (tsEnumValue.Equals("LOFTED_PLATE", System.StringComparison.InvariantCulture))
                return ModelObjectEnum.LOFTED_PLATE;
            else if (tsEnumValue.Equals("LEG_SURFACE_OBJECT", System.StringComparison.InvariantCulture))
                return ModelObjectEnum.LEG_SURFACE_OBJECT;
            else if (tsEnumValue.Equals("STOREY", System.StringComparison.InvariantCulture))
                return ModelObjectEnum.STOREY;
            else if (tsEnumValue.Equals("SPACE", System.StringComparison.InvariantCulture))
                return ModelObjectEnum.SPACE;
            else if (tsEnumValue.Equals("BUILDING", System.StringComparison.InvariantCulture))
                return ModelObjectEnum.BUILDING;

            else
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");

        }
    }

}
internal static class ModelObject_
{
    public static dynamic GetTSObject(ModelObject dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static ModelObject FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (ModelObject)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}
