using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic.Tekla.Structures.Model;
/// <summary>
/// The BoltGroup class is an abstract base class for all bolt shapes, such as array, circle and XY list.
/// See the Tekla Structures help file for further information about the attributes.
/// </summary>
public abstract class BoltGroup : ModelObject
{
    public double BoltSize
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

    public BoltGroup.BoltTypeEnum BoltType
    {
        get
        {
            try
            {
                var value = teklaObject.BoltType;
                var value_ = BoltGroup.BoltTypeEnum_.FromTSObject(value);
                return (BoltGroup.BoltTypeEnum)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(BoltType), ex);
            }
        }
        set
        {
            try
            {
                var value_ = BoltGroup.BoltTypeEnum_.GetTSObject(value);
                teklaObject.BoltType = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(BoltType), ex);
            }
        }
    }

    public BoltGroup.BoltThreadInMaterialEnum ThreadInMaterial
    {
        get
        {
            try
            {
                var value = teklaObject.ThreadInMaterial;
                var value_ = BoltGroup.BoltThreadInMaterialEnum_.FromTSObject(value);
                return (BoltGroup.BoltThreadInMaterialEnum)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ThreadInMaterial), ex);
            }
        }
        set
        {
            try
            {
                var value_ = BoltGroup.BoltThreadInMaterialEnum_.GetTSObject(value);
                teklaObject.ThreadInMaterial = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ThreadInMaterial), ex);
            }
        }
    }

    public double Length
    {
        get
        {
            try
            {
                return teklaObject.Length;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Length), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.Length = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Length), ex);
            }
        }
    }

    public double CutLength
    {
        get
        {
            try
            {
                return teklaObject.CutLength;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(CutLength), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.CutLength = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(CutLength), ex);
            }
        }
    }

    public double ExtraLength
    {
        get
        {
            try
            {
                return teklaObject.ExtraLength;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ExtraLength), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.ExtraLength = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ExtraLength), ex);
            }
        }
    }

    public double Tolerance
    {
        get
        {
            try
            {
                return teklaObject.Tolerance;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Tolerance), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.Tolerance = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Tolerance), ex);
            }
        }
    }

    public BoltGroup.BoltHoleTypeEnum HoleType
    {
        get
        {
            try
            {
                var value = teklaObject.HoleType;
                var value_ = BoltGroup.BoltHoleTypeEnum_.FromTSObject(value);
                return (BoltGroup.BoltHoleTypeEnum)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(HoleType), ex);
            }
        }
        set
        {
            try
            {
                var value_ = BoltGroup.BoltHoleTypeEnum_.GetTSObject(value);
                teklaObject.HoleType = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(HoleType), ex);
            }
        }
    }

    public double SlottedHoleX
    {
        get
        {
            try
            {
                return teklaObject.SlottedHoleX;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(SlottedHoleX), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.SlottedHoleX = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(SlottedHoleX), ex);
            }
        }
    }

    public double SlottedHoleY
    {
        get
        {
            try
            {
                return teklaObject.SlottedHoleY;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(SlottedHoleY), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.SlottedHoleY = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(SlottedHoleY), ex);
            }
        }
    }

    public double SlotOffsetX
    {
        get
        {
            try
            {
                return teklaObject.SlotOffsetX;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(SlotOffsetX), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.SlotOffsetX = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(SlotOffsetX), ex);
            }
        }
    }

    public double SlotOffsetY
    {
        get
        {
            try
            {
                return teklaObject.SlotOffsetY;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(SlotOffsetY), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.SlotOffsetY = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(SlotOffsetY), ex);
            }
        }
    }

    public double BlindHoleDepth
    {
        get
        {
            try
            {
                return teklaObject.BlindHoleDepth;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(BlindHoleDepth), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.BlindHoleDepth = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(BlindHoleDepth), ex);
            }
        }
    }

    public BoltGroup.BoltPlainHoleTypeEnum PlainHoleType
    {
        get
        {
            try
            {
                var value = teklaObject.PlainHoleType;
                var value_ = BoltGroup.BoltPlainHoleTypeEnum_.FromTSObject(value);
                return (BoltGroup.BoltPlainHoleTypeEnum)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(PlainHoleType), ex);
            }
        }
        set
        {
            try
            {
                var value_ = BoltGroup.BoltPlainHoleTypeEnum_.GetTSObject(value);
                teklaObject.PlainHoleType = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(PlainHoleType), ex);
            }
        }
    }

    public BoltGroup.BoltRotateSlotsEnum RotateSlots
    {
        get
        {
            try
            {
                var value = teklaObject.RotateSlots;
                var value_ = BoltGroup.BoltRotateSlotsEnum_.FromTSObject(value);
                return (BoltGroup.BoltRotateSlotsEnum)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(RotateSlots), ex);
            }
        }
        set
        {
            try
            {
                var value_ = BoltGroup.BoltRotateSlotsEnum_.GetTSObject(value);
                teklaObject.RotateSlots = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(RotateSlots), ex);
            }
        }
    }

    public Position Position
    {
        get
        {
            try
            {
                var value = teklaObject.Position;
                var value_ = Position_.FromTSObject(value);
                return (Position)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Position), ex);
            }
        }
        set
        {
            try
            {
                var value_ = Position_.GetTSObject(value);
                teklaObject.Position = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Position), ex);
            }
        }
    }

    public Offset StartPointOffset
    {
        get
        {
            try
            {
                var value = teklaObject.StartPointOffset;
                var value_ = Offset_.FromTSObject(value);
                return (Offset)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(StartPointOffset), ex);
            }
        }
        set
        {
            try
            {
                var value_ = Offset_.GetTSObject(value);
                teklaObject.StartPointOffset = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(StartPointOffset), ex);
            }
        }
    }

    public Offset EndPointOffset
    {
        get
        {
            try
            {
                var value = teklaObject.EndPointOffset;
                var value_ = Offset_.FromTSObject(value);
                return (Offset)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(EndPointOffset), ex);
            }
        }
        set
        {
            try
            {
                var value_ = Offset_.GetTSObject(value);
                teklaObject.EndPointOffset = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(EndPointOffset), ex);
            }
        }
    }

    public bool Washer1
    {
        get
        {
            try
            {
                return teklaObject.Washer1;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Washer1), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.Washer1 = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Washer1), ex);
            }
        }
    }

    public bool Washer2
    {
        get
        {
            try
            {
                return teklaObject.Washer2;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Washer2), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.Washer2 = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Washer2), ex);
            }
        }
    }

    public bool Washer3
    {
        get
        {
            try
            {
                return teklaObject.Washer3;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Washer3), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.Washer3 = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Washer3), ex);
            }
        }
    }

    public bool Nut1
    {
        get
        {
            try
            {
                return teklaObject.Nut1;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Nut1), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.Nut1 = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Nut1), ex);
            }
        }
    }

    public bool Nut2
    {
        get
        {
            try
            {
                return teklaObject.Nut2;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Nut2), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.Nut2 = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Nut2), ex);
            }
        }
    }

    public bool Bolt
    {
        get
        {
            try
            {
                return teklaObject.Bolt;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Bolt), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.Bolt = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Bolt), ex);
            }
        }
    }

    public bool Hole1
    {
        get
        {
            try
            {
                return teklaObject.Hole1;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Hole1), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.Hole1 = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Hole1), ex);
            }
        }
    }

    public bool Hole2
    {
        get
        {
            try
            {
                return teklaObject.Hole2;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Hole2), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.Hole2 = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Hole2), ex);
            }
        }
    }

    public bool Hole3
    {
        get
        {
            try
            {
                return teklaObject.Hole3;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Hole3), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.Hole3 = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Hole3), ex);
            }
        }
    }

    public bool Hole4
    {
        get
        {
            try
            {
                return teklaObject.Hole4;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Hole4), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.Hole4 = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Hole4), ex);
            }
        }
    }

    public bool Hole5
    {
        get
        {
            try
            {
                return teklaObject.Hole5;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Hole5), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.Hole5 = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Hole5), ex);
            }
        }
    }

    public Part PartToBoltTo
    {
        get
        {
            try
            {
                var value = teklaObject.PartToBoltTo;
                var value_ = Part_.FromTSObject(value);
                return (Part)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(PartToBoltTo), ex);
            }
        }
        set
        {
            try
            {
                var value_ = Part_.GetTSObject(value);
                teklaObject.PartToBoltTo = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(PartToBoltTo), ex);
            }
        }
    }

    public Part PartToBeBolted
    {
        get
        {
            try
            {
                var value = teklaObject.PartToBeBolted;
                var value_ = Part_.FromTSObject(value);
                return (Part)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(PartToBeBolted), ex);
            }
        }
        set
        {
            try
            {
                var value_ = Part_.GetTSObject(value);
                teklaObject.PartToBeBolted = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(PartToBeBolted), ex);
            }
        }
    }

    public System.Collections.ArrayList OtherPartsToBolt
    {
        get
        {
            try
            {
                var value = teklaObject.OtherPartsToBolt;
                var value_ = ArrayListConverter.FromTSObjects(value);
                return (System.Collections.ArrayList)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(OtherPartsToBolt), ex);
            }
        }

    }



    public Dynamic.Tekla.Structures.Geometry3d.Point FirstPosition
    {
        get
        {
            try
            {
                var value = teklaObject.FirstPosition;
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Geometry3d.Point)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(FirstPosition), ex);
            }
        }
        set
        {
            try
            {
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
                teklaObject.FirstPosition = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(FirstPosition), ex);
            }
        }
    }

    public Dynamic.Tekla.Structures.Geometry3d.Point SecondPosition
    {
        get
        {
            try
            {
                var value = teklaObject.SecondPosition;
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Geometry3d.Point)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(SecondPosition), ex);
            }
        }
        set
        {
            try
            {
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
                teklaObject.SecondPosition = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(SecondPosition), ex);
            }
        }
    }

    public bool ConnectAssemblies
    {
        get
        {
            try
            {
                return teklaObject.ConnectAssemblies;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ConnectAssemblies), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.ConnectAssemblies = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ConnectAssemblies), ex);
            }
        }
    }

    public System.Collections.ArrayList BoltPositions
    {
        get
        {
            try
            {
                var value = teklaObject.BoltPositions;
                var value_ = ArrayListConverter.FromTSObjects(value);
                return (System.Collections.ArrayList)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(BoltPositions), ex);
            }
        }

    }






    public bool AddOtherPartToBolt(
        Part M_)
    {
        var M = Part_.GetTSObject(M_);
        try
        {
            var result = (bool)teklaObject.AddOtherPartToBolt(M);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(AddOtherPartToBolt), ex);
        }
    }



    public bool RemoveOtherPartToBolt(
        Part M_)
    {
        var M = Part_.GetTSObject(M_);
        try
        {
            var result = (bool)teklaObject.RemoveOtherPartToBolt(M);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(RemoveOtherPartToBolt), ex);
        }
    }



    public System.Collections.ArrayList GetOtherPartsToBolt()
    {

        try
        {
            var result = teklaObject.GetOtherPartsToBolt();

            var _result = ArrayListConverter.FromTSObjects(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetOtherPartsToBolt), ex);
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



    public Solid GetSolid(
        bool withHighAccuracy)
    {

        try
        {
            var result = teklaObject.GetSolid(withHighAccuracy);

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





    public enum BoltTypeEnum
    {
        BOLT_TYPE_SITE,
        BOLT_TYPE_WORKSHOP
    }

    internal static class BoltTypeEnum_
    {
        public static dynamic GetTSObject(BoltTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.BoltGroup.BoltTypeEnum").GetType();

            switch (dynEnum)
            {
                case BoltTypeEnum.BOLT_TYPE_SITE:
                    return System.Enum.Parse(tsType, "BOLT_TYPE_SITE");
                case BoltTypeEnum.BOLT_TYPE_WORKSHOP:
                    return System.Enum.Parse(tsType, "BOLT_TYPE_WORKSHOP");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }

        public static BoltTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);

            if (tsEnumValue.Equals("BOLT_TYPE_SITE", System.StringComparison.InvariantCulture))
                return BoltTypeEnum.BOLT_TYPE_SITE;
            else if (tsEnumValue.Equals("BOLT_TYPE_WORKSHOP", System.StringComparison.InvariantCulture))
                return BoltTypeEnum.BOLT_TYPE_WORKSHOP;

            else
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");

        }
    }


    public enum BoltThreadInMaterialEnum
    {
        THREAD_IN_MATERIAL_NO,
        THREAD_IN_MATERIAL_YES
    }

    internal static class BoltThreadInMaterialEnum_
    {
        public static dynamic GetTSObject(BoltThreadInMaterialEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.BoltGroup.BoltThreadInMaterialEnum").GetType();

            switch (dynEnum)
            {
                case BoltThreadInMaterialEnum.THREAD_IN_MATERIAL_NO:
                    return System.Enum.Parse(tsType, "THREAD_IN_MATERIAL_NO");
                case BoltThreadInMaterialEnum.THREAD_IN_MATERIAL_YES:
                    return System.Enum.Parse(tsType, "THREAD_IN_MATERIAL_YES");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }

        public static BoltThreadInMaterialEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);

            if (tsEnumValue.Equals("THREAD_IN_MATERIAL_NO", System.StringComparison.InvariantCulture))
                return BoltThreadInMaterialEnum.THREAD_IN_MATERIAL_NO;
            else if (tsEnumValue.Equals("THREAD_IN_MATERIAL_YES", System.StringComparison.InvariantCulture))
                return BoltThreadInMaterialEnum.THREAD_IN_MATERIAL_YES;

            else
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");

        }
    }


    public enum BoltHoleTypeEnum
    {
        HOLE_TYPE_OVERSIZED,
        HOLE_TYPE_SLOTTED,
        HOLE_TYPE_NO_HOLE,
        HOLE_TYPE_TAPPED
    }

    internal static class BoltHoleTypeEnum_
    {
        public static dynamic GetTSObject(BoltHoleTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.BoltGroup.BoltHoleTypeEnum").GetType();

            switch (dynEnum)
            {
                case BoltHoleTypeEnum.HOLE_TYPE_OVERSIZED:
                    return System.Enum.Parse(tsType, "HOLE_TYPE_OVERSIZED");
                case BoltHoleTypeEnum.HOLE_TYPE_SLOTTED:
                    return System.Enum.Parse(tsType, "HOLE_TYPE_SLOTTED");
                case BoltHoleTypeEnum.HOLE_TYPE_NO_HOLE:
                    return System.Enum.Parse(tsType, "HOLE_TYPE_NO_HOLE");
                case BoltHoleTypeEnum.HOLE_TYPE_TAPPED:
                    return System.Enum.Parse(tsType, "HOLE_TYPE_TAPPED");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }

        public static BoltHoleTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);

            if (tsEnumValue.Equals("HOLE_TYPE_OVERSIZED", System.StringComparison.InvariantCulture))
                return BoltHoleTypeEnum.HOLE_TYPE_OVERSIZED;
            else if (tsEnumValue.Equals("HOLE_TYPE_SLOTTED", System.StringComparison.InvariantCulture))
                return BoltHoleTypeEnum.HOLE_TYPE_SLOTTED;
            else if (tsEnumValue.Equals("HOLE_TYPE_NO_HOLE", System.StringComparison.InvariantCulture))
                return BoltHoleTypeEnum.HOLE_TYPE_NO_HOLE;
            else if (tsEnumValue.Equals("HOLE_TYPE_TAPPED", System.StringComparison.InvariantCulture))
                return BoltHoleTypeEnum.HOLE_TYPE_TAPPED;

            else
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");

        }
    }


    public enum BoltPlainHoleTypeEnum
    {
        HOLE_TYPE_THROUGH,
        HOLE_TYPE_BLIND
    }

    internal static class BoltPlainHoleTypeEnum_
    {
        public static dynamic GetTSObject(BoltPlainHoleTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.BoltGroup.BoltPlainHoleTypeEnum").GetType();

            switch (dynEnum)
            {
                case BoltPlainHoleTypeEnum.HOLE_TYPE_THROUGH:
                    return System.Enum.Parse(tsType, "HOLE_TYPE_THROUGH");
                case BoltPlainHoleTypeEnum.HOLE_TYPE_BLIND:
                    return System.Enum.Parse(tsType, "HOLE_TYPE_BLIND");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }

        public static BoltPlainHoleTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);

            if (tsEnumValue.Equals("HOLE_TYPE_THROUGH", System.StringComparison.InvariantCulture))
                return BoltPlainHoleTypeEnum.HOLE_TYPE_THROUGH;
            else if (tsEnumValue.Equals("HOLE_TYPE_BLIND", System.StringComparison.InvariantCulture))
                return BoltPlainHoleTypeEnum.HOLE_TYPE_BLIND;

            else
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");

        }
    }


    public enum BoltRotateSlotsEnum
    {
        ROTATE_SLOTS_ODD,
        ROTATE_SLOTS_EVEN,
        ROTATE_SLOTS_PARALLEL
    }

    internal static class BoltRotateSlotsEnum_
    {
        public static dynamic GetTSObject(BoltRotateSlotsEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.BoltGroup.BoltRotateSlotsEnum").GetType();

            switch (dynEnum)
            {
                case BoltRotateSlotsEnum.ROTATE_SLOTS_ODD:
                    return System.Enum.Parse(tsType, "ROTATE_SLOTS_ODD");
                case BoltRotateSlotsEnum.ROTATE_SLOTS_EVEN:
                    return System.Enum.Parse(tsType, "ROTATE_SLOTS_EVEN");
                case BoltRotateSlotsEnum.ROTATE_SLOTS_PARALLEL:
                    return System.Enum.Parse(tsType, "ROTATE_SLOTS_PARALLEL");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }

        public static BoltRotateSlotsEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);

            if (tsEnumValue.Equals("ROTATE_SLOTS_ODD", System.StringComparison.InvariantCulture))
                return BoltRotateSlotsEnum.ROTATE_SLOTS_ODD;
            else if (tsEnumValue.Equals("ROTATE_SLOTS_EVEN", System.StringComparison.InvariantCulture))
                return BoltRotateSlotsEnum.ROTATE_SLOTS_EVEN;
            else if (tsEnumValue.Equals("ROTATE_SLOTS_PARALLEL", System.StringComparison.InvariantCulture))
                return BoltRotateSlotsEnum.ROTATE_SLOTS_PARALLEL;

            else
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");

        }
    }


    public enum ErrorStatus
    {
        CommonSettingFromDiffPropertiesException,
        SlottedHoleOffsetsTooBigException
    }

    internal static class ErrorStatus_
    {
        public static dynamic GetTSObject(ErrorStatus dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.BoltGroup.ErrorStatus").GetType();

            switch (dynEnum)
            {
                case ErrorStatus.CommonSettingFromDiffPropertiesException:
                    return System.Enum.Parse(tsType, "CommonSettingFromDiffPropertiesException");
                case ErrorStatus.SlottedHoleOffsetsTooBigException:
                    return System.Enum.Parse(tsType, "SlottedHoleOffsetsTooBigException");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }

        public static ErrorStatus FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);

            if (tsEnumValue.Equals("CommonSettingFromDiffPropertiesException", System.StringComparison.InvariantCulture))
                return ErrorStatus.CommonSettingFromDiffPropertiesException;
            else if (tsEnumValue.Equals("SlottedHoleOffsetsTooBigException", System.StringComparison.InvariantCulture))
                return ErrorStatus.SlottedHoleOffsetsTooBigException;

            else
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");

        }
    }



}

internal static class BoltGroup_
{
    public static dynamic GetTSObject(BoltGroup dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static BoltGroup FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (BoltGroup)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

