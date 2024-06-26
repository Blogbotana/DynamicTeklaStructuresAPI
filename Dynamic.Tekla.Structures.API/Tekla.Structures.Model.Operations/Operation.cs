﻿using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;

namespace Dynamic.Tekla.Structures.Model.Operations;
public abstract class Operation
{

    internal dynamic teklaObject;



    public static System.Boolean IsNumberingUpToDate(
        Dynamic.Tekla.Structures.Model.ModelObject InputModelObject_)
    {
        var InputModelObject = Dynamic.Tekla.Structures.Model.ModelObject_.GetTSObject(InputModelObject_);
        var result = (System.Boolean)MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "IsNumberingUpToDate", InputModelObject);
        return result;
    }



    public static System.Boolean IsNumberingUpToDateAll()
    {
        var result = (System.Boolean)MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "IsNumberingUpToDateAll");
        return result;
    }



    public static System.Boolean IsNumberingAllowed()
    {
        var result = (System.Boolean)MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "IsNumberingAllowed");
        return result;
    }



    public static System.Collections.Generic.List<Dynamic.Tekla.Structures.Model.ModelObject> GetSimilarNumberedObjects(
        Dynamic.Tekla.Structures.Model.ModelObject ObjectToCompare_)
    {
        var ObjectToCompare = Dynamic.Tekla.Structures.Model.ModelObject_.GetTSObject(ObjectToCompare_);
        var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "GetSimilarNumberedObjects", ObjectToCompare);
        var _result = ListConverter.FromTSObjects<Dynamic.Tekla.Structures.Model.ModelObject>(result);
        return _result;
    }



    public static System.Boolean CreateReportFromSelected(
        System.String TemplateName,
        System.String FileName,
        System.String Title1,
        System.String Title2,
        System.String Title3)
    {


        var result = (System.Boolean)MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CreateReportFromSelected", TemplateName, FileName, Title1, Title2, Title3);
        return result;
    }



    public static System.Boolean DisplayReport(
        System.String FileName)
    {
        var result = (System.Boolean)MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "DisplayReport", FileName);
        return result;
    }



    public static System.Boolean CreateReportFromAll(
        System.String TemplateName,
        System.String FileName,
        System.String Title1,
        System.String Title2,
        System.String Title3)
    {


        var result = (System.Boolean)MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CreateReportFromAll", TemplateName, FileName, Title1, Title2, Title3);
        return result;
    }



    public static System.Boolean CreateNCFilesFromSelected(
        System.String NCFileSettings,
        System.String DestinationFolder)
    {
        var result = (System.Boolean)MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CreateNCFilesFromSelected", NCFileSettings, DestinationFolder);
        return result;
    }



    public static System.Boolean CreateNCFilesFromSelected(
        System.String NCFileSettings,
        System.String DestinationFolder,
        System.Boolean CreatePopMarks,
        System.String PopMarkSettingsFileName,
        System.Boolean CreateContourMarking,
        System.String ContourMarkingSettingsFileName)
    {


        var result = (System.Boolean)MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CreateNCFilesFromSelected", NCFileSettings, DestinationFolder, CreatePopMarks, PopMarkSettingsFileName, CreateContourMarking, ContourMarkingSettingsFileName);
        return result;
    }



    public static System.Boolean CreateNCFilesFromAll(
        System.String NCFileSettings,
        System.String DestinationFolder)
    {
        var result = (System.Boolean)MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CreateNCFilesFromAll", NCFileSettings, DestinationFolder);
        return result;
    }



    public static System.Boolean CreateNCFilesFromAll(
        System.String NCFileSettings,
        System.String DestinationFolder,
        System.Boolean CreatePopMarks,
        System.String PopMarkSettingsFileName,
        System.Boolean CreateContourMarking,
        System.String ContourMarkingSettingsFileName)
    {


        var result = (System.Boolean)MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CreateNCFilesFromAll", NCFileSettings, DestinationFolder, CreatePopMarks, PopMarkSettingsFileName, CreateContourMarking, ContourMarkingSettingsFileName);
        return result;
    }



    public static System.Boolean CreateNCFilesByPartId(
        System.String NCFileSettings,
        System.String DestinationFolder,
        Dynamic.Tekla.Structures.Identifier PartID_,
        out System.String DstvOutput,
        System.Boolean CreatePopMarks,
        System.String PopMarkSettingsFileName,
        System.Boolean CreateContourMarking,
        System.String ContourMarkingSettingsFileName)
    {
        var PartID = Dynamic.Tekla.Structures.Identifier_.GetTSObject(PartID_);
        DstvOutput = null;


        var result = (System.Boolean)MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CreateNCFilesByPartId", NCFileSettings, DestinationFolder, PartID, ref DstvOutput, CreatePopMarks, PopMarkSettingsFileName, CreateContourMarking, ContourMarkingSettingsFileName);
        return result;
    }



    public static System.Boolean CreateMISFileFromSelected(
        Dynamic.Tekla.Structures.Model.Operations.Operation.MISExportTypeEnum MISType_,
        System.String FileName)
    {
        var MISType = Dynamic.Tekla.Structures.Model.Operations.Operation.MISExportTypeEnum_.GetTSObject(MISType_);
        var result = (System.Boolean)MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CreateMISFileFromSelected", MISType, FileName);
        return result;
    }



    public static System.Boolean CreateMISFileFromAll(
        Dynamic.Tekla.Structures.Model.Operations.Operation.MISExportTypeEnum MISType_,
        System.String FileName)
    {
        var MISType = Dynamic.Tekla.Structures.Model.Operations.Operation.MISExportTypeEnum_.GetTSObject(MISType_);
        var result = (System.Boolean)MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CreateMISFileFromAll", MISType, FileName);
        return result;
    }



    public static System.Boolean CreateIFC4ExportFromSelected(
        System.String fullPathAndFileName,
        Dynamic.Tekla.Structures.Model.Operations.Operation.IFCExportViewTypeEnum exportViewType_,
        System.Collections.Generic.IEnumerable<System.String> propertySets,
        Dynamic.Tekla.Structures.Model.Operations.Operation.ExportBasePoint locationByValue_,
        System.String exportLayersAsValue,
        System.String objectColoring,
        Dynamic.Tekla.Structures.Model.Operations.Operation.IFCExportFlags flags_,
        System.String basePointGuid)
    {
        var exportViewType = Dynamic.Tekla.Structures.Model.Operations.Operation.IFCExportViewTypeEnum_.GetTSObject(exportViewType_);
        var locationByValue = Dynamic.Tekla.Structures.Model.Operations.Operation.ExportBasePoint_.GetTSObject(locationByValue_);

        var flags = Dynamic.Tekla.Structures.Model.Operations.Operation.IFCExportFlags_.GetTSObject(flags_);
        var result = (System.Boolean)MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CreateIFC4ExportFromSelected", fullPathAndFileName, exportViewType, propertySets, locationByValue, exportLayersAsValue, objectColoring, flags, basePointGuid);
        return result;
    }



    public static System.Boolean CreateIFC4ExportFromAll(
        System.String fullPathAndFileName,
        Dynamic.Tekla.Structures.Model.Operations.Operation.IFCExportViewTypeEnum exportViewType_,
        System.Collections.Generic.IEnumerable<System.String> propertySets,
        Dynamic.Tekla.Structures.Model.Operations.Operation.ExportBasePoint locationByValue_,
        System.String exportLayersAsValue,
        System.String objectColoring,
        Dynamic.Tekla.Structures.Model.Operations.Operation.IFCExportFlags flags_,
        System.String basePointGuid)
    {
        var exportViewType = Dynamic.Tekla.Structures.Model.Operations.Operation.IFCExportViewTypeEnum_.GetTSObject(exportViewType_);
        var locationByValue = Dynamic.Tekla.Structures.Model.Operations.Operation.ExportBasePoint_.GetTSObject(locationByValue_);

        var flags = Dynamic.Tekla.Structures.Model.Operations.Operation.IFCExportFlags_.GetTSObject(flags_);
        var result = (System.Boolean)MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CreateIFC4ExportFromAll", fullPathAndFileName, exportViewType, propertySets, locationByValue, exportLayersAsValue, objectColoring, flags, basePointGuid);
        return result;
    }



    public static System.Boolean CreateDGNv8Export(
        System.String FileName,
        System.String Folder,
        Dynamic.Tekla.Structures.Model.Operations.Operation.ExportBasePoint BasePoint_,
        System.String BasePointGuid,
        System.String ObjectColoring,
        System.String ExportLayersAs,
        System.Boolean OnlyFromSelectedObjects)
    {
        var BasePoint = Dynamic.Tekla.Structures.Model.Operations.Operation.ExportBasePoint_.GetTSObject(BasePoint_);


        var result = (System.Boolean)MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CreateDGNv8Export", FileName, Folder, BasePoint, BasePointGuid, ObjectColoring, ExportLayersAs, OnlyFromSelectedObjects);
        return result;
    }



    public static System.Boolean RunMacro(
        System.String FileName)
    {
        var result = (System.Boolean)MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "RunMacro", FileName);
        return result;
    }



    public static System.Boolean IsMacroRunning()
    {
        var result = (System.Boolean)MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "IsMacroRunning");
        return result;
    }



    public static System.Boolean Open(
        System.String ModelFolder)
    {
        var result = (System.Boolean)MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "Open", ModelFolder);
        return result;
    }



    public static System.Boolean Open(
        System.String ModelFolder,
        System.Boolean OpenAutoSaved)
    {
        var result = (System.Boolean)MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "Open", ModelFolder, OpenAutoSaved);
        return result;
    }



    public static System.Boolean IsModelAutoSaved(
        System.String ModelFolder)
    {
        var result = (System.Boolean)MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "IsModelAutoSaved", ModelFolder);
        return result;
    }



    public static System.Boolean SaveAsWebModel(
        System.String Filename)
    {
        var result = (System.Boolean)MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "SaveAsWebModel", Filename);
        return result;
    }



    public static System.Boolean SaveSelectedAsWebModel(
        System.String Filename)
    {
        var result = (System.Boolean)MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "SaveSelectedAsWebModel", Filename);
        return result;
    }



    //        public static System.Boolean ConvertPartToItem(
    //			ref Dynamic.Tekla.Structures.Model.Part originalPart_,
    //			out Dynamic.Tekla.Structures.Model.Brep newItem_)
    //        {
    //            var originalPart = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(originalPart_);
    //var newItem = Dynamic.Tekla.Structures.Model.Brep_.GetTSObject(null);
    //            var result = (System.Boolean) MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "ConvertPartToItem", ref originalPart, ref newItem);
    //            originalPart_ = Dynamic.Tekla.Structures.Model.Part_.FromTSObject(originalPart);
    //newItem_ = Dynamic.Tekla.Structures.Model.Brep_.FromTSObject(newItem);
    //            return result;
    //        }



    public static System.Boolean MoveObject(
        Dynamic.Tekla.Structures.Model.ModelObject Object_,
        Dynamic.Tekla.Structures.Geometry3d.Vector TranslationVector_)
    {
        var Object = Dynamic.Tekla.Structures.Model.ModelObject_.GetTSObject(Object_);
        var TranslationVector = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(TranslationVector_);
        var result = (System.Boolean)MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "MoveObject", Object, TranslationVector);
        return result;
    }



    public static System.Boolean MoveObject(
        Dynamic.Tekla.Structures.Model.ModelObject Object_,
        Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem StartCoordinateSystem_,
        Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem EndCoordinateSystem_)
    {
        var Object = Dynamic.Tekla.Structures.Model.ModelObject_.GetTSObject(Object_);
        var StartCoordinateSystem = Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.GetTSObject(StartCoordinateSystem_);
        var EndCoordinateSystem = Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.GetTSObject(EndCoordinateSystem_);
        var result = (System.Boolean)MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "MoveObject", Object, StartCoordinateSystem, EndCoordinateSystem);
        return result;
    }



    public static Dynamic.Tekla.Structures.Model.ModelObject CopyObject(
        Dynamic.Tekla.Structures.Model.ModelObject Object_,
        Dynamic.Tekla.Structures.Geometry3d.Vector CopyVector_)
    {
        var Object = Dynamic.Tekla.Structures.Model.ModelObject_.GetTSObject(Object_);
        var CopyVector = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(CopyVector_);
        var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CopyObject", Object, CopyVector);
        var _result = Dynamic.Tekla.Structures.Model.ModelObject_.FromTSObject(result);
        return _result;
    }



    public static Dynamic.Tekla.Structures.Model.ModelObject CopyObject(
        Dynamic.Tekla.Structures.Model.ModelObject Object_,
        Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem StartCoordinateSystem_,
        Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem EndCoordinateSystem_)
    {
        var Object = Dynamic.Tekla.Structures.Model.ModelObject_.GetTSObject(Object_);
        var StartCoordinateSystem = Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.GetTSObject(StartCoordinateSystem_);
        var EndCoordinateSystem = Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.GetTSObject(EndCoordinateSystem_);
        var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CopyObject", Object, StartCoordinateSystem, EndCoordinateSystem);
        var _result = Dynamic.Tekla.Structures.Model.ModelObject_.FromTSObject(result);
        return _result;
    }



    public static Dynamic.Tekla.Structures.Model.Beam Combine(
        Dynamic.Tekla.Structures.Model.Beam ObjectToCombineTo_,
        Dynamic.Tekla.Structures.Model.Beam ObjectToBeCombined_)
    {
        var ObjectToCombineTo = Dynamic.Tekla.Structures.Model.Beam_.GetTSObject(ObjectToCombineTo_);
        var ObjectToBeCombined = Dynamic.Tekla.Structures.Model.Beam_.GetTSObject(ObjectToBeCombined_);
        var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "Combine", ObjectToCombineTo, ObjectToBeCombined);
        var _result = Dynamic.Tekla.Structures.Model.Beam_.FromTSObject(result);
        return _result;
    }



    public static Dynamic.Tekla.Structures.Model.SingleRebar Combine(
        Dynamic.Tekla.Structures.Model.SingleRebar ObjectToCombineTo_,
        Dynamic.Tekla.Structures.Model.SingleRebar ObjectToBeCombined_)
    {
        var ObjectToCombineTo = Dynamic.Tekla.Structures.Model.SingleRebar_.GetTSObject(ObjectToCombineTo_);
        var ObjectToBeCombined = Dynamic.Tekla.Structures.Model.SingleRebar_.GetTSObject(ObjectToBeCombined_);
        var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "Combine", ObjectToCombineTo, ObjectToBeCombined);
        var _result = Dynamic.Tekla.Structures.Model.SingleRebar_.FromTSObject(result);
        return _result;
    }



    public static Dynamic.Tekla.Structures.Model.RebarGroup Combine(
        Dynamic.Tekla.Structures.Model.RebarGroup ObjectToCombineTo_,
        Dynamic.Tekla.Structures.Model.RebarGroup ObjectToBeCombined_)
    {
        var ObjectToCombineTo = Dynamic.Tekla.Structures.Model.RebarGroup_.GetTSObject(ObjectToCombineTo_);
        var ObjectToBeCombined = Dynamic.Tekla.Structures.Model.RebarGroup_.GetTSObject(ObjectToBeCombined_);
        var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "Combine", ObjectToCombineTo, ObjectToBeCombined);
        var _result = Dynamic.Tekla.Structures.Model.RebarGroup_.FromTSObject(result);
        return _result;
    }



    public static Dynamic.Tekla.Structures.Model.Beam Split(
        Dynamic.Tekla.Structures.Model.Beam Object_,
        Dynamic.Tekla.Structures.Geometry3d.Point SplitPoint_)
    {
        var Object = Dynamic.Tekla.Structures.Model.Beam_.GetTSObject(Object_);
        var SplitPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(SplitPoint_);
        var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "Split", Object, SplitPoint);
        var _result = Dynamic.Tekla.Structures.Model.Beam_.FromTSObject(result);
        return _result;
    }



    public static Dynamic.Tekla.Structures.Model.PolyBeam Split(
        Dynamic.Tekla.Structures.Model.PolyBeam Object_,
        Dynamic.Tekla.Structures.Geometry3d.Point SplitPoint_)
    {
        var Object = Dynamic.Tekla.Structures.Model.PolyBeam_.GetTSObject(Object_);
        var SplitPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(SplitPoint_);
        var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "Split", Object, SplitPoint);
        var _result = Dynamic.Tekla.Structures.Model.PolyBeam_.FromTSObject(result);
        return _result;
    }



    public static Dynamic.Tekla.Structures.Model.LoftedPlate Split(
        Dynamic.Tekla.Structures.Model.LoftedPlate Object_,
        Dynamic.Tekla.Structures.Geometry3d.Point SplitPoint_)
    {
        var Object = Dynamic.Tekla.Structures.Model.LoftedPlate_.GetTSObject(Object_);
        var SplitPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(SplitPoint_);
        var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "Split", Object, SplitPoint);
        var _result = Dynamic.Tekla.Structures.Model.LoftedPlate_.FromTSObject(result);
        return _result;
    }



    public static Dynamic.Tekla.Structures.Model.SingleRebar Split(
        Dynamic.Tekla.Structures.Model.SingleRebar Object_,
        Dynamic.Tekla.Structures.Geometry3d.Line SplitLine_)
    {
        var Object = Dynamic.Tekla.Structures.Model.SingleRebar_.GetTSObject(Object_);
        var SplitLine = Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(SplitLine_);
        var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "Split", Object, SplitLine);
        var _result = Dynamic.Tekla.Structures.Model.SingleRebar_.FromTSObject(result);
        return _result;
    }



    public static Dynamic.Tekla.Structures.Model.CurvedRebarGroup Split(
        Dynamic.Tekla.Structures.Model.CurvedRebarGroup Object_,
        Dynamic.Tekla.Structures.Geometry3d.Line SplitLine_)
    {
        var Object = Dynamic.Tekla.Structures.Model.CurvedRebarGroup_.GetTSObject(Object_);
        var SplitLine = Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(SplitLine_);
        var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "Split", Object, SplitLine);
        var _result = Dynamic.Tekla.Structures.Model.CurvedRebarGroup_.FromTSObject(result);
        return _result;
    }



    public static Dynamic.Tekla.Structures.Model.CircleRebarGroup Split(
        Dynamic.Tekla.Structures.Model.CircleRebarGroup Object_,
        Dynamic.Tekla.Structures.Geometry3d.Line SplitLine_)
    {
        var Object = Dynamic.Tekla.Structures.Model.CircleRebarGroup_.GetTSObject(Object_);
        var SplitLine = Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(SplitLine_);
        var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "Split", Object, SplitLine);
        var _result = Dynamic.Tekla.Structures.Model.CircleRebarGroup_.FromTSObject(result);
        return _result;
    }



    public static Dynamic.Tekla.Structures.Model.RebarGroup Split(
        Dynamic.Tekla.Structures.Model.RebarGroup Object_,
        Dynamic.Tekla.Structures.Geometry3d.Line SplitLine_)
    {
        var Object = Dynamic.Tekla.Structures.Model.RebarGroup_.GetTSObject(Object_);
        var SplitLine = Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(SplitLine_);
        var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "Split", Object, SplitLine);
        var _result = Dynamic.Tekla.Structures.Model.RebarGroup_.FromTSObject(result);
        return _result;
    }



    public static Dynamic.Tekla.Structures.Model.ContourPlate Split(
        Dynamic.Tekla.Structures.Model.ContourPlate Object_,
        Dynamic.Tekla.Structures.Model.Polygon SplitPolygon_)
    {
        var Object = Dynamic.Tekla.Structures.Model.ContourPlate_.GetTSObject(Object_);
        var SplitPolygon = Dynamic.Tekla.Structures.Model.Polygon_.GetTSObject(SplitPolygon_);
        var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "Split", Object, SplitPolygon);
        var _result = Dynamic.Tekla.Structures.Model.ContourPlate_.FromTSObject(result);
        return _result;
    }



    public static System.Boolean SplitSlab(
        System.Int32 PartId,
        Dynamic.Tekla.Structures.Geometry3d.FacetedBrep Polymesh_)
    {
        var Polymesh = Dynamic.Tekla.Structures.Geometry3d.FacetedBrep_.GetTSObject(Polymesh_);
        var result = (System.Boolean)MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "SplitSlab", PartId, Polymesh);
        return result;
    }



    public static Dynamic.Tekla.Structures.Model.ModelObjectEnumerator Ungrouping(
        Dynamic.Tekla.Structures.Model.RebarGroup Reinforcement_)
    {
        var Reinforcement = Dynamic.Tekla.Structures.Model.RebarGroup_.GetTSObject(Reinforcement_);
        var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "Ungrouping", Reinforcement);
        var _result = Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(result);
        return _result;
    }



    public static Dynamic.Tekla.Structures.Model.ModelObjectEnumerator Ungrouping(
        Dynamic.Tekla.Structures.Model.RebarMesh Reinforcement_)
    {
        var Reinforcement = Dynamic.Tekla.Structures.Model.RebarMesh_.GetTSObject(Reinforcement_);
        var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "Ungrouping", Reinforcement);
        var _result = Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(result);
        return _result;
    }



    public static Dynamic.Tekla.Structures.Model.RebarGroup Group(
        System.Collections.IEnumerable RebarList)
    {
        var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "Group", RebarList);
        var _result = Dynamic.Tekla.Structures.Model.RebarGroup_.FromTSObject(result);
        return _result;
    }



    public static void ShowOnlySelected(
        Dynamic.Tekla.Structures.Model.Operations.Operation.UnselectedModeEnum UnselectedMode_)
    {
        var UnselectedMode = Dynamic.Tekla.Structures.Model.Operations.Operation.UnselectedModeEnum_.GetTSObject(UnselectedMode_);
        MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "ShowOnlySelected", UnselectedMode);

    }



    public static Dynamic.Tekla.Structures.Model.BentPlate CreateBentPlateByParts(
        Dynamic.Tekla.Structures.Model.Part part1_,
        Dynamic.Tekla.Structures.Model.Part part2_,
        Dynamic.Tekla.Structures.Model.BentPlate.BendShape bendShape_)
    {
        var part1 = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part1_);
        var part2 = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part2_);
        var bendShape = Dynamic.Tekla.Structures.Model.BentPlate.BendShape_.GetTSObject(bendShape_);
        var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CreateBentPlateByParts", part1, part2, bendShape);
        var _result = Dynamic.Tekla.Structures.Model.BentPlate_.FromTSObject(result);
        return _result;
    }



    public static Dynamic.Tekla.Structures.Model.BentPlate CreateBentPlateByParts(
        Dynamic.Tekla.Structures.Model.Part part1_,
        Dynamic.Tekla.Structures.Model.Part part2_)
    {
        var part1 = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part1_);
        var part2 = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part2_);
        var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CreateBentPlateByParts", part1, part2);
        var _result = Dynamic.Tekla.Structures.Model.BentPlate_.FromTSObject(result);
        return _result;
    }



    public static Dynamic.Tekla.Structures.Model.BentPlate CreateBentPlateByParts(
        Dynamic.Tekla.Structures.Model.Part part1_,
        Dynamic.Tekla.Structures.Model.Part part2_,
        System.Double radius)
    {
        var part1 = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part1_);
        var part2 = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part2_);
        var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CreateBentPlateByParts", part1, part2, radius);
        var _result = Dynamic.Tekla.Structures.Model.BentPlate_.FromTSObject(result);
        return _result;
    }



    public static Dynamic.Tekla.Structures.Model.BentPlate CreateConicalBentPlateByPartsAndAperture(
        Dynamic.Tekla.Structures.Model.Part part1_,
        Dynamic.Tekla.Structures.Model.Part part2_,
        System.Double largestRadius,
        System.Double halfAperture)
    {
        var part1 = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part1_);
        var part2 = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part2_);

        var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CreateConicalBentPlateByPartsAndAperture", part1, part2, largestRadius, halfAperture);
        var _result = Dynamic.Tekla.Structures.Model.BentPlate_.FromTSObject(result);
        return _result;
    }



    public static Dynamic.Tekla.Structures.Model.BentPlate CreateConicalBentPlateByPartsAndTwoRadiuses(
        Dynamic.Tekla.Structures.Model.Part part1_,
        Dynamic.Tekla.Structures.Model.Part part2_,
        System.Double firstRadius,
        System.Double secondRadius)
    {
        var part1 = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part1_);
        var part2 = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part2_);

        var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CreateConicalBentPlateByPartsAndTwoRadiuses", part1, part2, firstRadius, secondRadius);
        var _result = Dynamic.Tekla.Structures.Model.BentPlate_.FromTSObject(result);
        return _result;
    }



    public static Dynamic.Tekla.Structures.Model.BentPlate CreateBentPlateByFaces(
        Dynamic.Tekla.Structures.Model.Part part1_,
        System.Collections.Generic.IList<Dynamic.Tekla.Structures.Geometry3d.Point> face1_,
        Dynamic.Tekla.Structures.Model.Part part2_,
        System.Collections.Generic.IList<Dynamic.Tekla.Structures.Geometry3d.Point> face2_,
        Dynamic.Tekla.Structures.Model.BentPlate.BendShape bendShape_)
    {
        var part1 = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part1_);
        var face1 = ListConverter.ToTSObjects(face1_);
        var part2 = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part2_);
        var face2 = ListConverter.ToTSObjects(face2_);
        var bendShape = Dynamic.Tekla.Structures.Model.BentPlate.BendShape_.GetTSObject(bendShape_);
        var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CreateBentPlateByFaces", part1, face1, part2, face2, bendShape);
        var _result = Dynamic.Tekla.Structures.Model.BentPlate_.FromTSObject(result);
        return _result;
    }



    public static Dynamic.Tekla.Structures.Model.BentPlate CreateBentPlateByFaces(
        Dynamic.Tekla.Structures.Model.Part part1_,
        System.Collections.Generic.IList<Dynamic.Tekla.Structures.Geometry3d.Point> face1_,
        Dynamic.Tekla.Structures.Model.Part part2_,
        System.Collections.Generic.IList<Dynamic.Tekla.Structures.Geometry3d.Point> face2_)
    {
        var part1 = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part1_);
        var face1 = ListConverter.ToTSObjects(face1_);
        var part2 = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part2_);
        var face2 = ListConverter.ToTSObjects(face2_);
        var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CreateBentPlateByFaces", part1, face1, part2, face2);
        var _result = Dynamic.Tekla.Structures.Model.BentPlate_.FromTSObject(result);
        return _result;
    }



    public static Dynamic.Tekla.Structures.Model.BentPlate CreateBentPlateByFaces(
        Dynamic.Tekla.Structures.Model.Part part1_,
        Dynamic.Tekla.Structures.Solid.Face face1_,
        Dynamic.Tekla.Structures.Model.Part part2_,
        Dynamic.Tekla.Structures.Solid.Face face2_,
        Dynamic.Tekla.Structures.Model.BentPlate.BendShape bendShape_)
    {
        var part1 = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part1_);
        var face1 = Dynamic.Tekla.Structures.Solid.Face_.GetTSObject(face1_);
        var part2 = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part2_);
        var face2 = Dynamic.Tekla.Structures.Solid.Face_.GetTSObject(face2_);
        var bendShape = Dynamic.Tekla.Structures.Model.BentPlate.BendShape_.GetTSObject(bendShape_);
        var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CreateBentPlateByFaces", part1, face1, part2, face2, bendShape);
        var _result = Dynamic.Tekla.Structures.Model.BentPlate_.FromTSObject(result);
        return _result;
    }



    public static Dynamic.Tekla.Structures.Model.BentPlate CreateBentPlateByFaces(
        Dynamic.Tekla.Structures.Model.Part part1_,
        Dynamic.Tekla.Structures.Solid.Face face1_,
        Dynamic.Tekla.Structures.Model.Part part2_,
        Dynamic.Tekla.Structures.Solid.Face face2_)
    {
        var part1 = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part1_);
        var face1 = Dynamic.Tekla.Structures.Solid.Face_.GetTSObject(face1_);
        var part2 = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part2_);
        var face2 = Dynamic.Tekla.Structures.Solid.Face_.GetTSObject(face2_);
        var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CreateBentPlateByFaces", part1, face1, part2, face2);
        var _result = Dynamic.Tekla.Structures.Model.BentPlate_.FromTSObject(result);
        return _result;
    }



    public static Dynamic.Tekla.Structures.Model.BentPlate CreateBentPlateByFaces(
        Dynamic.Tekla.Structures.Model.Part part1_,
        System.Collections.Generic.IList<Dynamic.Tekla.Structures.Geometry3d.Point> face1_,
        Dynamic.Tekla.Structures.Model.Part part2_,
        System.Collections.Generic.IList<Dynamic.Tekla.Structures.Geometry3d.Point> face2_,
        System.Double radius)
    {
        var part1 = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part1_);
        var face1 = ListConverter.ToTSObjects(face1_);
        var part2 = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part2_);
        var face2 = ListConverter.ToTSObjects(face2_);
        var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CreateBentPlateByFaces", part1, face1, part2, face2, radius);
        var _result = Dynamic.Tekla.Structures.Model.BentPlate_.FromTSObject(result);
        return _result;
    }



    public static Dynamic.Tekla.Structures.Model.BentPlate CreateBentPlateByFaces(
        Dynamic.Tekla.Structures.Model.Part part1_,
        Dynamic.Tekla.Structures.Solid.Face face1_,
        Dynamic.Tekla.Structures.Model.Part part2_,
        Dynamic.Tekla.Structures.Solid.Face face2_,
        System.Double radius)
    {
        var part1 = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part1_);
        var face1 = Dynamic.Tekla.Structures.Solid.Face_.GetTSObject(face1_);
        var part2 = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part2_);
        var face2 = Dynamic.Tekla.Structures.Solid.Face_.GetTSObject(face2_);
        var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CreateBentPlateByFaces", part1, face1, part2, face2, radius);
        var _result = Dynamic.Tekla.Structures.Model.BentPlate_.FromTSObject(result);
        return _result;
    }



    public static Dynamic.Tekla.Structures.Model.BentPlate CreateConicalBentPlateByFaces(
        Dynamic.Tekla.Structures.Model.Part part1_,
        System.Collections.Generic.IList<Dynamic.Tekla.Structures.Geometry3d.Point> face1_,
        Dynamic.Tekla.Structures.Model.Part part2_,
        System.Collections.Generic.IList<Dynamic.Tekla.Structures.Geometry3d.Point> face2_,
        System.Double largestRadius,
        System.Double halfAperture)
    {
        var part1 = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part1_);
        var face1 = ListConverter.ToTSObjects(face1_);
        var part2 = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part2_);
        var face2 = ListConverter.ToTSObjects(face2_);

        var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CreateConicalBentPlateByFaces", part1, face1, part2, face2, largestRadius, halfAperture);
        var _result = Dynamic.Tekla.Structures.Model.BentPlate_.FromTSObject(result);
        return _result;
    }



    public static Dynamic.Tekla.Structures.Model.BentPlate CreateConicalBentPlateByFaces(
        Dynamic.Tekla.Structures.Model.Part part1_,
        Dynamic.Tekla.Structures.Solid.Face face1_,
        Dynamic.Tekla.Structures.Model.Part part2_,
        Dynamic.Tekla.Structures.Solid.Face face2_,
        System.Double largestRadius,
        System.Double halfAperture)
    {
        var part1 = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part1_);
        var face1 = Dynamic.Tekla.Structures.Solid.Face_.GetTSObject(face1_);
        var part2 = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part2_);
        var face2 = Dynamic.Tekla.Structures.Solid.Face_.GetTSObject(face2_);

        var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CreateConicalBentPlateByFaces", part1, face1, part2, face2, largestRadius, halfAperture);
        var _result = Dynamic.Tekla.Structures.Model.BentPlate_.FromTSObject(result);
        return _result;
    }



    public static System.Boolean ExplodeBentPlate(
        Dynamic.Tekla.Structures.Model.BentPlate bentPlate_)
    {
        var bentPlate = Dynamic.Tekla.Structures.Model.BentPlate_.GetTSObject(bentPlate_);
        var result = (System.Boolean)MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "ExplodeBentPlate", bentPlate);
        return result;
    }



    public static System.Boolean AddToPourUnit(
        Dynamic.Tekla.Structures.Model.PourUnit inputPourUnit_,
        System.Collections.Generic.List<Dynamic.Tekla.Structures.Model.ModelObject> objectsToBeAdded_)
    {
        var inputPourUnit = Dynamic.Tekla.Structures.Model.PourUnit_.GetTSObject(inputPourUnit_);
        var objectsToBeAdded = ListConverter.ToTSObjects(objectsToBeAdded_);
        var result = (System.Boolean)MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "AddToPourUnit", inputPourUnit, objectsToBeAdded);
        return result;
    }



    public static System.Boolean RemoveFromPourUnit(
        System.Collections.Generic.List<Dynamic.Tekla.Structures.Model.ModelObject> objectsToBeRemoved_)
    {
        var objectsToBeRemoved = ListConverter.ToTSObjects(objectsToBeRemoved_);
        var result = (System.Boolean)MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "RemoveFromPourUnit", objectsToBeRemoved);
        return result;
    }



    public static System.Boolean CalculatePourUnits()
    {
        var result = (System.Boolean)MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CalculatePourUnits");
        return result;
    }



    public static System.Collections.Generic.List<Dynamic.Tekla.Structures.Geometry3d.Point> GetHandlePoints(
        System.String guid)
    {
        var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "GetHandlePoints", guid);
        var _result = ListConverter.FromTSObjects<Dynamic.Tekla.Structures.Geometry3d.Point>(result);
        return _result;
    }



    public static System.Boolean SetHandlePoints(
        System.String guid,
        System.Collections.Generic.List<Dynamic.Tekla.Structures.Geometry3d.Point> HandlePoints_)
    {
        var HandlePoints = ListConverter.ToTSObjects(HandlePoints_);
        var result = (System.Boolean)MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "SetHandlePoints", guid, HandlePoints);
        return result;
    }



    public static System.Boolean Highlight(
        System.Collections.Generic.List<Dynamic.Tekla.Structures.Model.ModelObject> ModelObjects_)
    {
        var ModelObjects = ListConverter.ToTSObjects(ModelObjects_);
        var result = (System.Boolean)MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "Highlight", ModelObjects);
        return result;
    }



    public static System.Boolean DisplayPrompt(
        System.String Message)
    {
        var result = (System.Boolean)MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "DisplayPrompt", Message);
        return result;
    }



    public static System.Boolean ObjectMatchesToFilter(
        Dynamic.Tekla.Structures.Model.ModelObject ModelObject_,
        System.String FilterName)
    {
        var ModelObject = Dynamic.Tekla.Structures.Model.ModelObject_.GetTSObject(ModelObject_);
        var result = (System.Boolean)MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "ObjectMatchesToFilter", ModelObject, FilterName);
        return result;
    }



    //public static System.Boolean ObjectMatchesToFilter(
    //    Dynamic.Tekla.Structures.Model.ModelObject ModelObject_,
    //    Dynamic.Tekla.Structures.Filtering.FilterExpression FilterExpression_)
    //{
    //    var ModelObject = Dynamic.Tekla.Structures.Model.ModelObject_.GetTSObject(ModelObject_);
    //    var FilterExpression = Dynamic.Tekla.Structures.Filtering.FilterExpression_.GetTSObject(FilterExpression_);
    //    var result = (System.Boolean)MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "ObjectMatchesToFilter", ModelObject, FilterExpression);
    //    return result;
    //}





    public enum MISExportTypeEnum
    {
        DSTV,
        KISS,
        EJE,
        EPC,
        STEEL2000
    }

    internal static class MISExportTypeEnum_
    {
        public static dynamic GetTSObject(MISExportTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.Operations.Operation.MISExportTypeEnum").GetType();

            switch (dynEnum)
            {
                case MISExportTypeEnum.DSTV:
                    return System.Enum.Parse(tsType, "DSTV");
                case MISExportTypeEnum.KISS:
                    return System.Enum.Parse(tsType, "KISS");
                case MISExportTypeEnum.EJE:
                    return System.Enum.Parse(tsType, "EJE");
                case MISExportTypeEnum.EPC:
                    return System.Enum.Parse(tsType, "EPC");
                case MISExportTypeEnum.STEEL2000:
                    return System.Enum.Parse(tsType, "STEEL2000");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }

        public static MISExportTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);

            if (tsEnumValue.Equals("DSTV", System.StringComparison.InvariantCulture))
                return MISExportTypeEnum.DSTV;
            else if (tsEnumValue.Equals("KISS", System.StringComparison.InvariantCulture))
                return MISExportTypeEnum.KISS;
            else if (tsEnumValue.Equals("EJE", System.StringComparison.InvariantCulture))
                return MISExportTypeEnum.EJE;
            else if (tsEnumValue.Equals("EPC", System.StringComparison.InvariantCulture))
                return MISExportTypeEnum.EPC;
            else if (tsEnumValue.Equals("STEEL2000", System.StringComparison.InvariantCulture))
                return MISExportTypeEnum.STEEL2000;

            else
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");

        }
    }


    public enum UnselectedModeEnum
    {
        Hidden,
        Transparent,
        AsSticks
    }

    internal static class UnselectedModeEnum_
    {
        public static dynamic GetTSObject(UnselectedModeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.Operations.Operation.UnselectedModeEnum").GetType();

            switch (dynEnum)
            {
                case UnselectedModeEnum.Hidden:
                    return System.Enum.Parse(tsType, "Hidden");
                case UnselectedModeEnum.Transparent:
                    return System.Enum.Parse(tsType, "Transparent");
                case UnselectedModeEnum.AsSticks:
                    return System.Enum.Parse(tsType, "AsSticks");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }

        public static UnselectedModeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);

            if (tsEnumValue.Equals("Hidden", System.StringComparison.InvariantCulture))
                return UnselectedModeEnum.Hidden;
            else if (tsEnumValue.Equals("Transparent", System.StringComparison.InvariantCulture))
                return UnselectedModeEnum.Transparent;
            else if (tsEnumValue.Equals("AsSticks", System.StringComparison.InvariantCulture))
                return UnselectedModeEnum.AsSticks;

            else
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");

        }
    }


    public enum ShapeMetadataResult
    {
        NoResult,
        OK,
        DuplicateKeyExist,
        NoMatchingShape,
        NoMatchingKey
    }

    internal static class ShapeMetadataResult_
    {
        public static dynamic GetTSObject(ShapeMetadataResult dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.Operations.Operation.ShapeMetadataResult").GetType();

            switch (dynEnum)
            {
                case ShapeMetadataResult.NoResult:
                    return System.Enum.Parse(tsType, "NoResult");
                case ShapeMetadataResult.OK:
                    return System.Enum.Parse(tsType, "OK");
                case ShapeMetadataResult.DuplicateKeyExist:
                    return System.Enum.Parse(tsType, "DuplicateKeyExist");
                case ShapeMetadataResult.NoMatchingShape:
                    return System.Enum.Parse(tsType, "NoMatchingShape");
                case ShapeMetadataResult.NoMatchingKey:
                    return System.Enum.Parse(tsType, "NoMatchingKey");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }

        public static ShapeMetadataResult FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);

            if (tsEnumValue.Equals("NoResult", System.StringComparison.InvariantCulture))
                return ShapeMetadataResult.NoResult;
            else if (tsEnumValue.Equals("OK", System.StringComparison.InvariantCulture))
                return ShapeMetadataResult.OK;
            else if (tsEnumValue.Equals("DuplicateKeyExist", System.StringComparison.InvariantCulture))
                return ShapeMetadataResult.DuplicateKeyExist;
            else if (tsEnumValue.Equals("NoMatchingShape", System.StringComparison.InvariantCulture))
                return ShapeMetadataResult.NoMatchingShape;
            else if (tsEnumValue.Equals("NoMatchingKey", System.StringComparison.InvariantCulture))
                return ShapeMetadataResult.NoMatchingKey;

            else
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");

        }
    }


    public enum IFCExportViewTypeEnum
    {
        UNDEFINED,
        REFERENCE_VIEW,
        DESIGN_TRANSFER_VIEW,
        PRECAST_VIEW,
        MEP_REFERENCE_VIEW,
        MEP_DESIGN_TRANSFER_VIEW,
        BRIDGE_VIEW
    }

    internal static class IFCExportViewTypeEnum_
    {
        public static dynamic GetTSObject(IFCExportViewTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.Operations.Operation.IFCExportViewTypeEnum").GetType();

            switch (dynEnum)
            {
                case IFCExportViewTypeEnum.UNDEFINED:
                    return System.Enum.Parse(tsType, "UNDEFINED");
                case IFCExportViewTypeEnum.REFERENCE_VIEW:
                    return System.Enum.Parse(tsType, "REFERENCE_VIEW");
                case IFCExportViewTypeEnum.DESIGN_TRANSFER_VIEW:
                    return System.Enum.Parse(tsType, "DESIGN_TRANSFER_VIEW");
                case IFCExportViewTypeEnum.PRECAST_VIEW:
                    return System.Enum.Parse(tsType, "PRECAST_VIEW");
                case IFCExportViewTypeEnum.MEP_REFERENCE_VIEW:
                    return System.Enum.Parse(tsType, "MEP_REFERENCE_VIEW");
                case IFCExportViewTypeEnum.MEP_DESIGN_TRANSFER_VIEW:
                    return System.Enum.Parse(tsType, "MEP_DESIGN_TRANSFER_VIEW");
                case IFCExportViewTypeEnum.BRIDGE_VIEW:
                    return System.Enum.Parse(tsType, "BRIDGE_VIEW");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }

        public static IFCExportViewTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);

            if (tsEnumValue.Equals("UNDEFINED", System.StringComparison.InvariantCulture))
                return IFCExportViewTypeEnum.UNDEFINED;
            else if (tsEnumValue.Equals("REFERENCE_VIEW", System.StringComparison.InvariantCulture))
                return IFCExportViewTypeEnum.REFERENCE_VIEW;
            else if (tsEnumValue.Equals("DESIGN_TRANSFER_VIEW", System.StringComparison.InvariantCulture))
                return IFCExportViewTypeEnum.DESIGN_TRANSFER_VIEW;
            else if (tsEnumValue.Equals("PRECAST_VIEW", System.StringComparison.InvariantCulture))
                return IFCExportViewTypeEnum.PRECAST_VIEW;
            else if (tsEnumValue.Equals("MEP_REFERENCE_VIEW", System.StringComparison.InvariantCulture))
                return IFCExportViewTypeEnum.MEP_REFERENCE_VIEW;
            else if (tsEnumValue.Equals("MEP_DESIGN_TRANSFER_VIEW", System.StringComparison.InvariantCulture))
                return IFCExportViewTypeEnum.MEP_DESIGN_TRANSFER_VIEW;
            else if (tsEnumValue.Equals("BRIDGE_VIEW", System.StringComparison.InvariantCulture))
                return IFCExportViewTypeEnum.BRIDGE_VIEW;

            else
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");

        }
    }


    public enum ExportBasePoint
    {
        GLOBAL,
        WORK_PLANE,
        BASE_POINT
    }

    internal static class ExportBasePoint_
    {
        public static dynamic GetTSObject(ExportBasePoint dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.Operations.Operation.ExportBasePoint").GetType();

            switch (dynEnum)
            {
                case ExportBasePoint.GLOBAL:
                    return System.Enum.Parse(tsType, "GLOBAL");
                case ExportBasePoint.WORK_PLANE:
                    return System.Enum.Parse(tsType, "WORK_PLANE");
                case ExportBasePoint.BASE_POINT:
                    return System.Enum.Parse(tsType, "BASE_POINT");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }

        public static ExportBasePoint FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);

            if (tsEnumValue.Equals("GLOBAL", System.StringComparison.InvariantCulture))
                return ExportBasePoint.GLOBAL;
            else if (tsEnumValue.Equals("WORK_PLANE", System.StringComparison.InvariantCulture))
                return ExportBasePoint.WORK_PLANE;
            else if (tsEnumValue.Equals("BASE_POINT", System.StringComparison.InvariantCulture))
                return ExportBasePoint.BASE_POINT;

            else
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");

        }
    }


    public struct IFCExportFlags
    {
        public System.Boolean IsFlatBeamsAsPlates;
        public System.Boolean IsLocationFromOrganizer;
        public System.Boolean IsLocationFromBuildingHierarchy;
        public System.Boolean IsPoursEnabled;
        public System.Boolean ExportRebarSetGroupAsIndividualBars;
        public System.Boolean IsAssembliesEnabled;
        public System.Boolean IsBoltsEnabled;
        public System.Boolean IsWeldsEnabled;
        public System.Boolean IsGridsEnabled;
        public System.Boolean IsRebarsEnabled;
        public System.Boolean IsSurfaceTreatmentsAndSurfacesEnabled;

    }

    internal static class IFCExportFlags_
    {
        public static dynamic GetTSObject(IFCExportFlags dynStruct)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.Operations.IFCExportFlags");
            tsType.IsFlatBeamsAsPlates = dynStruct.IsFlatBeamsAsPlates;
            tsType.IsLocationFromOrganizer = dynStruct.IsLocationFromOrganizer;
            tsType.IsLocationFromBuildingHierarchy = dynStruct.IsLocationFromBuildingHierarchy;
            tsType.IsPoursEnabled = dynStruct.IsPoursEnabled;
            tsType.ExportRebarSetGroupAsIndividualBars = dynStruct.ExportRebarSetGroupAsIndividualBars;
            tsType.IsAssembliesEnabled = dynStruct.IsAssembliesEnabled;
            tsType.IsBoltsEnabled = dynStruct.IsBoltsEnabled;
            tsType.IsWeldsEnabled = dynStruct.IsWeldsEnabled;
            tsType.IsGridsEnabled = dynStruct.IsGridsEnabled;
            tsType.IsRebarsEnabled = dynStruct.IsRebarsEnabled;
            tsType.IsSurfaceTreatmentsAndSurfacesEnabled = dynStruct.IsSurfaceTreatmentsAndSurfacesEnabled;

            return tsType;
        }

        public static IFCExportFlags FromTSObject(dynamic tsStruct)
        {
            var dynStruct = new IFCExportFlags();
            dynStruct.IsFlatBeamsAsPlates = tsStruct.IsFlatBeamsAsPlates;
            dynStruct.IsLocationFromOrganizer = tsStruct.IsLocationFromOrganizer;
            dynStruct.IsLocationFromBuildingHierarchy = tsStruct.IsLocationFromBuildingHierarchy;
            dynStruct.IsPoursEnabled = tsStruct.IsPoursEnabled;
            dynStruct.ExportRebarSetGroupAsIndividualBars = tsStruct.ExportRebarSetGroupAsIndividualBars;
            dynStruct.IsAssembliesEnabled = tsStruct.IsAssembliesEnabled;
            dynStruct.IsBoltsEnabled = tsStruct.IsBoltsEnabled;
            dynStruct.IsWeldsEnabled = tsStruct.IsWeldsEnabled;
            dynStruct.IsGridsEnabled = tsStruct.IsGridsEnabled;
            dynStruct.IsRebarsEnabled = tsStruct.IsRebarsEnabled;
            dynStruct.IsSurfaceTreatmentsAndSurfacesEnabled = tsStruct.IsSurfaceTreatmentsAndSurfacesEnabled;

            return dynStruct;
        }
    }


    public class ProgressBar
    {



        internal dynamic teklaObject;

        public ProgressBar()
        {
            this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Operations.Operation.ProgressBar");
        }
        
        public ProgressBar(dynamic tsObject, System.DateTime nonConflictParameter)
        {
            this.teklaObject = tsObject;
        }


        public System.Boolean Display(
            System.Int32 SleepTime,
            System.String Title,
            System.String Message,
            System.String CancelButtonLabel,
            System.String ProgressLabel)
        {


            try
            {
                var result = (System.Boolean)teklaObject.Display(SleepTime, Title, Message, CancelButtonLabel, ProgressLabel);

                return result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Display), ex);
            }
        }



        public void Close()
        {

            try
            {
                teklaObject.Close();


            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Close), ex);
            }
        }



        public void SetProgress(
            System.String ProgressLabel,
            System.Int32 Progress)
        {
            try
            {
                teklaObject.SetProgress(ProgressLabel, Progress);


            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SetProgress), ex);
            }
        }



        public System.Boolean Canceled()
        {

            try
            {
                var result = (System.Boolean)teklaObject.Canceled();

                return result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Canceled), ex);
            }
        }






    }

    internal static class ProgressBar_
    {
        public static dynamic GetTSObject(ProgressBar dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static ProgressBar FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.Operations.Operation.ProgressBar)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }
}
internal static class Operation_
{
    public static dynamic GetTSObject(Operation dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static Operation FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (Dynamic.Tekla.Structures.Model.Operations.Operation)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}