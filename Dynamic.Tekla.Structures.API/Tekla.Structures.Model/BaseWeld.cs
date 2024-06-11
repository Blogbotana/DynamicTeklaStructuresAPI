using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;

namespace Dynamic.Tekla.Structures.Model;
public abstract class BaseWeld : ModelObject
{
    public ModelObject MainObject
    {
        get
        {
            try
            {
                var value = teklaObject.MainObject;
                var value_ = ModelObject_.FromTSObject(value);
                return (ModelObject)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(MainObject), ex);
            }
        }
        set
        {
            try
            {
                var value_ = ModelObject_.GetTSObject(value);
                teklaObject.MainObject = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(MainObject), ex);
            }
        }
    }

    public ModelObject SecondaryObject
    {
        get
        {
            try
            {
                var value = teklaObject.SecondaryObject;
                var value_ = ModelObject_.FromTSObject(value);
                return (ModelObject)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(SecondaryObject), ex);
            }
        }
        set
        {
            try
            {
                var value_ = ModelObject_.GetTSObject(value);
                teklaObject.SecondaryObject = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(SecondaryObject), ex);
            }
        }
    }

    public double SizeAbove
    {
        get
        {
            try
            {
                return teklaObject.SizeAbove;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(SizeAbove), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.SizeAbove = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(SizeAbove), ex);
            }
        }
    }

    public double AdditionalSizeAbove
    {
        get
        {
            try
            {
                return teklaObject.AdditionalSizeAbove;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(AdditionalSizeAbove), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.AdditionalSizeAbove = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(AdditionalSizeAbove), ex);
            }
        }
    }

    public BaseWeld.WeldTypeEnum TypeAbove
    {
        get
        {
            try
            {
                var value = teklaObject.TypeAbove;
                var value_ = BaseWeld.WeldTypeEnum_.FromTSObject(value);
                return (BaseWeld.WeldTypeEnum)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(TypeAbove), ex);
            }
        }
        set
        {
            try
            {
                var value_ = BaseWeld.WeldTypeEnum_.GetTSObject(value);
                teklaObject.TypeAbove = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(TypeAbove), ex);
            }
        }
    }

    public double AngleAbove
    {
        get
        {
            try
            {
                return teklaObject.AngleAbove;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(AngleAbove), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.AngleAbove = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(AngleAbove), ex);
            }
        }
    }

    public double LengthAbove
    {
        get
        {
            try
            {
                return teklaObject.LengthAbove;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LengthAbove), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.LengthAbove = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LengthAbove), ex);
            }
        }
    }

    public BaseWeld.WeldContourEnum ContourAbove
    {
        get
        {
            try
            {
                var value = teklaObject.ContourAbove;
                var value_ = BaseWeld.WeldContourEnum_.FromTSObject(value);
                return (BaseWeld.WeldContourEnum)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ContourAbove), ex);
            }
        }
        set
        {
            try
            {
                var value_ = BaseWeld.WeldContourEnum_.GetTSObject(value);
                teklaObject.ContourAbove = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ContourAbove), ex);
            }
        }
    }

    public BaseWeld.WeldFinishEnum FinishAbove
    {
        get
        {
            try
            {
                var value = teklaObject.FinishAbove;
                var value_ = BaseWeld.WeldFinishEnum_.FromTSObject(value);
                return (BaseWeld.WeldFinishEnum)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(FinishAbove), ex);
            }
        }
        set
        {
            try
            {
                var value_ = BaseWeld.WeldFinishEnum_.GetTSObject(value);
                teklaObject.FinishAbove = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(FinishAbove), ex);
            }
        }
    }

    public double PitchAbove
    {
        get
        {
            try
            {
                return teklaObject.PitchAbove;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(PitchAbove), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.PitchAbove = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(PitchAbove), ex);
            }
        }
    }

    public double SizeBelow
    {
        get
        {
            try
            {
                return teklaObject.SizeBelow;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(SizeBelow), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.SizeBelow = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(SizeBelow), ex);
            }
        }
    }

    public double AdditionalSizeBelow
    {
        get
        {
            try
            {
                return teklaObject.AdditionalSizeBelow;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(AdditionalSizeBelow), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.AdditionalSizeBelow = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(AdditionalSizeBelow), ex);
            }
        }
    }

    public BaseWeld.WeldTypeEnum TypeBelow
    {
        get
        {
            try
            {
                var value = teklaObject.TypeBelow;
                var value_ = BaseWeld.WeldTypeEnum_.FromTSObject(value);
                return (BaseWeld.WeldTypeEnum)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(TypeBelow), ex);
            }
        }
        set
        {
            try
            {
                var value_ = BaseWeld.WeldTypeEnum_.GetTSObject(value);
                teklaObject.TypeBelow = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(TypeBelow), ex);
            }
        }
    }

    public double AngleBelow
    {
        get
        {
            try
            {
                return teklaObject.AngleBelow;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(AngleBelow), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.AngleBelow = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(AngleBelow), ex);
            }
        }
    }

    public double LengthBelow
    {
        get
        {
            try
            {
                return teklaObject.LengthBelow;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LengthBelow), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.LengthBelow = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LengthBelow), ex);
            }
        }
    }

    public BaseWeld.WeldContourEnum ContourBelow
    {
        get
        {
            try
            {
                var value = teklaObject.ContourBelow;
                var value_ = BaseWeld.WeldContourEnum_.FromTSObject(value);
                return (BaseWeld.WeldContourEnum)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ContourBelow), ex);
            }
        }
        set
        {
            try
            {
                var value_ = BaseWeld.WeldContourEnum_.GetTSObject(value);
                teklaObject.ContourBelow = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ContourBelow), ex);
            }
        }
    }

    public BaseWeld.WeldFinishEnum FinishBelow
    {
        get
        {
            try
            {
                var value = teklaObject.FinishBelow;
                var value_ = BaseWeld.WeldFinishEnum_.FromTSObject(value);
                return (BaseWeld.WeldFinishEnum)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(FinishBelow), ex);
            }
        }
        set
        {
            try
            {
                var value_ = BaseWeld.WeldFinishEnum_.GetTSObject(value);
                teklaObject.FinishBelow = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(FinishBelow), ex);
            }
        }
    }

    public double PitchBelow
    {
        get
        {
            try
            {
                return teklaObject.PitchBelow;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(PitchBelow), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.PitchBelow = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(PitchBelow), ex);
            }
        }
    }

    public bool ShopWeld
    {
        get
        {
            try
            {
                return teklaObject.ShopWeld;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ShopWeld), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.ShopWeld = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ShopWeld), ex);
            }
        }
    }

    public bool AroundWeld
    {
        get
        {
            try
            {
                return teklaObject.AroundWeld;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(AroundWeld), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.AroundWeld = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(AroundWeld), ex);
            }
        }
    }

    public bool StitchWeld
    {
        get
        {
            try
            {
                return teklaObject.StitchWeld;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(StitchWeld), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.StitchWeld = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(StitchWeld), ex);
            }
        }
    }

    public double RootOpeningAbove
    {
        get
        {
            try
            {
                return teklaObject.RootOpeningAbove;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(RootOpeningAbove), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.RootOpeningAbove = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(RootOpeningAbove), ex);
            }
        }
    }

    public double RootFaceAbove
    {
        get
        {
            try
            {
                return teklaObject.RootFaceAbove;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(RootFaceAbove), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.RootFaceAbove = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(RootFaceAbove), ex);
            }
        }
    }

    public double EffectiveThroatAbove
    {
        get
        {
            try
            {
                return teklaObject.EffectiveThroatAbove;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(EffectiveThroatAbove), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.EffectiveThroatAbove = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(EffectiveThroatAbove), ex);
            }
        }
    }

    public int IncrementAmountAbove
    {
        get
        {
            try
            {
                return teklaObject.IncrementAmountAbove;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(IncrementAmountAbove), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.IncrementAmountAbove = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(IncrementAmountAbove), ex);
            }
        }
    }

    public double RootOpeningBelow
    {
        get
        {
            try
            {
                return teklaObject.RootOpeningBelow;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(RootOpeningBelow), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.RootOpeningBelow = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(RootOpeningBelow), ex);
            }
        }
    }

    public double RootFaceBelow
    {
        get
        {
            try
            {
                return teklaObject.RootFaceBelow;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(RootFaceBelow), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.RootFaceBelow = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(RootFaceBelow), ex);
            }
        }
    }

    public double EffectiveThroatBelow
    {
        get
        {
            try
            {
                return teklaObject.EffectiveThroatBelow;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(EffectiveThroatBelow), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.EffectiveThroatBelow = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(EffectiveThroatBelow), ex);
            }
        }
    }

    public int IncrementAmountBelow
    {
        get
        {
            try
            {
                return teklaObject.IncrementAmountBelow;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(IncrementAmountBelow), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.IncrementAmountBelow = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(IncrementAmountBelow), ex);
            }
        }
    }

    public BaseWeld.WeldElectrodeClassificationEnum ElectrodeClassification
    {
        get
        {
            try
            {
                var value = teklaObject.ElectrodeClassification;
                var value_ = BaseWeld.WeldElectrodeClassificationEnum_.FromTSObject(value);
                return (BaseWeld.WeldElectrodeClassificationEnum)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ElectrodeClassification), ex);
            }
        }
        set
        {
            try
            {
                var value_ = BaseWeld.WeldElectrodeClassificationEnum_.GetTSObject(value);
                teklaObject.ElectrodeClassification = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ElectrodeClassification), ex);
            }
        }
    }

    public double ElectrodeStrength
    {
        get
        {
            try
            {
                return teklaObject.ElectrodeStrength;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ElectrodeStrength), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.ElectrodeStrength = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ElectrodeStrength), ex);
            }
        }
    }

    public double ElectrodeCoefficient
    {
        get
        {
            try
            {
                return teklaObject.ElectrodeCoefficient;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ElectrodeCoefficient), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.ElectrodeCoefficient = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ElectrodeCoefficient), ex);
            }
        }
    }

    public BaseWeld.WeldProcessTypeEnum ProcessType
    {
        get
        {
            try
            {
                var value = teklaObject.ProcessType;
                var value_ = BaseWeld.WeldProcessTypeEnum_.FromTSObject(value);
                return (BaseWeld.WeldProcessTypeEnum)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ProcessType), ex);
            }
        }
        set
        {
            try
            {
                var value_ = BaseWeld.WeldProcessTypeEnum_.GetTSObject(value);
                teklaObject.ProcessType = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ProcessType), ex);
            }
        }
    }

    public BaseWeld.WeldNDTInspectionEnum NDTInspection
    {
        get
        {
            try
            {
                var value = teklaObject.NDTInspection;
                var value_ = BaseWeld.WeldNDTInspectionEnum_.FromTSObject(value);
                return (BaseWeld.WeldNDTInspectionEnum)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(NDTInspection), ex);
            }
        }
        set
        {
            try
            {
                var value_ = BaseWeld.WeldNDTInspectionEnum_.GetTSObject(value);
                teklaObject.NDTInspection = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(NDTInspection), ex);
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

    public string ReferenceText
    {
        get
        {
            try
            {
                return teklaObject.ReferenceText;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ReferenceText), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.ReferenceText = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ReferenceText), ex);
            }
        }
    }

    public string PrefixAboveLine
    {
        get
        {
            try
            {
                return teklaObject.PrefixAboveLine;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(PrefixAboveLine), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.PrefixAboveLine = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(PrefixAboveLine), ex);
            }
        }
    }

    public string PrefixBelowLine
    {
        get
        {
            try
            {
                return teklaObject.PrefixBelowLine;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(PrefixBelowLine), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.PrefixBelowLine = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(PrefixBelowLine), ex);
            }
        }
    }

    public string Standard
    {
        get
        {
            try
            {
                return teklaObject.Standard;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Standard), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.Standard = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Standard), ex);
            }
        }
    }

    public int WeldNumber
    {
        get
        {
            try
            {
                return teklaObject.WeldNumber;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(WeldNumber), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.WeldNumber = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(WeldNumber), ex);
            }
        }
    }

    public string WeldNumberPrefix
    {
        get
        {
            try
            {
                return teklaObject.WeldNumberPrefix;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(WeldNumberPrefix), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.WeldNumberPrefix = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(WeldNumberPrefix), ex);
            }
        }
    }

    public BaseWeld.WeldIntermittentTypeEnum IntermittentType
    {
        get
        {
            try
            {
                var value = teklaObject.IntermittentType;
                var value_ = BaseWeld.WeldIntermittentTypeEnum_.FromTSObject(value);
                return (BaseWeld.WeldIntermittentTypeEnum)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(IntermittentType), ex);
            }
        }
        set
        {
            try
            {
                var value_ = BaseWeld.WeldIntermittentTypeEnum_.GetTSObject(value);
                teklaObject.IntermittentType = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(IntermittentType), ex);
            }
        }
    }

    public BaseWeld.WeldPlacementTypeEnum Placement
    {
        get
        {
            try
            {
                var value = teklaObject.Placement;
                var value_ = BaseWeld.WeldPlacementTypeEnum_.FromTSObject(value);
                return (BaseWeld.WeldPlacementTypeEnum)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Placement), ex);
            }
        }
        set
        {
            try
            {
                var value_ = BaseWeld.WeldPlacementTypeEnum_.GetTSObject(value);
                teklaObject.Placement = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Placement), ex);
            }
        }
    }

    public BaseWeld.WeldPreparationTypeEnum Preparation
    {
        get
        {
            try
            {
                var value = teklaObject.Preparation;
                var value_ = BaseWeld.WeldPreparationTypeEnum_.FromTSObject(value);
                return (BaseWeld.WeldPreparationTypeEnum)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Preparation), ex);
            }
        }
        set
        {
            try
            {
                var value_ = BaseWeld.WeldPreparationTypeEnum_.GetTSObject(value);
                teklaObject.Preparation = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Preparation), ex);
            }
        }
    }






    public System.Collections.ArrayList GetWeldGeometries()
    {

        try
        {
            var result = teklaObject.GetWeldGeometries();

            var _result = ArrayListConverter.FromTSObjects(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetWeldGeometries), ex);
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

    /// <summary> The weld types. </summary>
    public enum WeldTypeEnum
    {
        /// <summary> No weld type. </summary>
        WELD_TYPE_NONE,
        /// <summary> The edge-flange weld. </summary>
        WELD_TYPE_EDGE_FLANGE,
        /// <summary> The square-groove (square butt) weld. </summary>
        WELD_TYPE_SQUARE_GROOVE_SQUARE_BUTT,
        /// <summary> The bevel-groove (single-V butt) weld.  </summary>
        WELD_TYPE_BEVEL_GROOVE_SINGLE_V_BUTT,
        /// <summary> The bevel-groove (single-bevel butt) weld. </summary>
        WELD_TYPE_BEVEL_GROOVE_SINGLE_BEVEL_BUTT,
        /// <summary> The single-V butt weld with broad root face. </summary>
        WELD_TYPE_SINGLE_V_BUTT_WITH_BROAD_ROOT_FACE,
        /// <summary> The single-bevel butt weld with broad root face. </summary>
        WELD_TYPE_SINGLE_BEVEL_BUTT_WITH_BROAD_ROOT_FACE,
        /// <summary> The U-groove (single U-butt) weld. </summary>
        WELD_TYPE_U_GROOVE_SINGLE_U_BUTT,
        /// <summary> The J-groove (single J-butt) weld. </summary>
        WELD_TYPE_J_GROOVE_J_BUTT,
        /// <summary> The bevel backing weld. </summary>
        WELD_TYPE_BEVEL_BACKING,
        /// <summary> The fillet weld. </summary>
        WELD_TYPE_FILLET,
        /// <summary> The plug weld. </summary>
        WELD_TYPE_PLUG,
        /// <summary> The spot weld. </summary>
        WELD_TYPE_SPOT,
        /// <summary> The seam weld.  </summary>
        WELD_TYPE_SEAM,
        /// <summary> The slot weld. </summary>
        WELD_TYPE_SLOT,
        /// <summary> The flare-bevel-groove weld. </summary>
        WELD_TYPE_FLARE_BEVEL_GROOVE,
        /// <summary> The flare V-groove weld. </summary>
        WELD_TYPE_FLARE_V_GROOVE,
        /// <summary> The corner-flange weld. </summary>
        WELD_TYPE_CORNER_FLANGE,
        /// <summary> The partial penetration (single-bevel butt + fillet) weld. </summary>
        WELD_TYPE_PARTIAL_PENETRATION_SINGLE_BEVEL_BUTT_PLUS_FILLET,
        /// <summary> The partial penetration (square groove + fillet) weld. </summary>
        WELD_TYPE_PARTIAL_PENETRATION_SQUARE_GROOVE_PLUS_FILLET,
        /// <summary> The melt-through weld. </summary>
        WELD_TYPE_MELT_THROUGH,
        /// <summary> The steep flanked bevel groove single-V butt weld. </summary>
        STEEP_FLANKED_BEVEL_GROOVE_SINGLE_V_BUTT,
        /// <summary> The steep flanked bevel groove single-bevel butt weld. </summary>
        STEEP_FLANKED_BEVEL_GROOVE_SINGLE_BEVEL_BUTT,
        /// <summary> The edge weld. </summary>
        WELD_TYPE_EDGE,
        /// <summary> The ISO surfacing weld. </summary>
        WELD_TYPE_ISO_SURFACING,
        /// <summary> The fold weld. </summary>
        WELD_TYPE_FOLD,
        /// <summary> The inclined weld. </summary>
        WELD_TYPE_INCLINED
    }

    internal static class WeldTypeEnum_
    {
        public static dynamic GetTSObject(WeldTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.BaseWeld.WeldTypeEnum").GetType();

            switch (dynEnum)
            {
                case WeldTypeEnum.WELD_TYPE_NONE:
                    return System.Enum.Parse(tsType, "WELD_TYPE_NONE");
                case WeldTypeEnum.WELD_TYPE_EDGE_FLANGE:
                    return System.Enum.Parse(tsType, "WELD_TYPE_EDGE_FLANGE");
                case WeldTypeEnum.WELD_TYPE_SQUARE_GROOVE_SQUARE_BUTT:
                    return System.Enum.Parse(tsType, "WELD_TYPE_SQUARE_GROOVE_SQUARE_BUTT");
                case WeldTypeEnum.WELD_TYPE_BEVEL_GROOVE_SINGLE_V_BUTT:
                    return System.Enum.Parse(tsType, "WELD_TYPE_BEVEL_GROOVE_SINGLE_V_BUTT");
                case WeldTypeEnum.WELD_TYPE_BEVEL_GROOVE_SINGLE_BEVEL_BUTT:
                    return System.Enum.Parse(tsType, "WELD_TYPE_BEVEL_GROOVE_SINGLE_BEVEL_BUTT");
                case WeldTypeEnum.WELD_TYPE_SINGLE_V_BUTT_WITH_BROAD_ROOT_FACE:
                    return System.Enum.Parse(tsType, "WELD_TYPE_SINGLE_V_BUTT_WITH_BROAD_ROOT_FACE");
                case WeldTypeEnum.WELD_TYPE_SINGLE_BEVEL_BUTT_WITH_BROAD_ROOT_FACE:
                    return System.Enum.Parse(tsType, "WELD_TYPE_SINGLE_BEVEL_BUTT_WITH_BROAD_ROOT_FACE");
                case WeldTypeEnum.WELD_TYPE_U_GROOVE_SINGLE_U_BUTT:
                    return System.Enum.Parse(tsType, "WELD_TYPE_U_GROOVE_SINGLE_U_BUTT");
                case WeldTypeEnum.WELD_TYPE_J_GROOVE_J_BUTT:
                    return System.Enum.Parse(tsType, "WELD_TYPE_J_GROOVE_J_BUTT");
                case WeldTypeEnum.WELD_TYPE_BEVEL_BACKING:
                    return System.Enum.Parse(tsType, "WELD_TYPE_BEVEL_BACKING");
                case WeldTypeEnum.WELD_TYPE_FILLET:
                    return System.Enum.Parse(tsType, "WELD_TYPE_FILLET");
                case WeldTypeEnum.WELD_TYPE_PLUG:
                    return System.Enum.Parse(tsType, "WELD_TYPE_PLUG");
                case WeldTypeEnum.WELD_TYPE_SPOT:
                    return System.Enum.Parse(tsType, "WELD_TYPE_SPOT");
                case WeldTypeEnum.WELD_TYPE_SEAM:
                    return System.Enum.Parse(tsType, "WELD_TYPE_SEAM");
                case WeldTypeEnum.WELD_TYPE_SLOT:
                    return System.Enum.Parse(tsType, "WELD_TYPE_SLOT");
                case WeldTypeEnum.WELD_TYPE_FLARE_BEVEL_GROOVE:
                    return System.Enum.Parse(tsType, "WELD_TYPE_FLARE_BEVEL_GROOVE");
                case WeldTypeEnum.WELD_TYPE_FLARE_V_GROOVE:
                    return System.Enum.Parse(tsType, "WELD_TYPE_FLARE_V_GROOVE");
                case WeldTypeEnum.WELD_TYPE_CORNER_FLANGE:
                    return System.Enum.Parse(tsType, "WELD_TYPE_CORNER_FLANGE");
                case WeldTypeEnum.WELD_TYPE_PARTIAL_PENETRATION_SINGLE_BEVEL_BUTT_PLUS_FILLET:
                    return System.Enum.Parse(tsType, "WELD_TYPE_PARTIAL_PENETRATION_SINGLE_BEVEL_BUTT_PLUS_FILLET");
                case WeldTypeEnum.WELD_TYPE_PARTIAL_PENETRATION_SQUARE_GROOVE_PLUS_FILLET:
                    return System.Enum.Parse(tsType, "WELD_TYPE_PARTIAL_PENETRATION_SQUARE_GROOVE_PLUS_FILLET");
                case WeldTypeEnum.WELD_TYPE_MELT_THROUGH:
                    return System.Enum.Parse(tsType, "WELD_TYPE_MELT_THROUGH");
                case WeldTypeEnum.STEEP_FLANKED_BEVEL_GROOVE_SINGLE_V_BUTT:
                    return System.Enum.Parse(tsType, "STEEP_FLANKED_BEVEL_GROOVE_SINGLE_V_BUTT");
                case WeldTypeEnum.STEEP_FLANKED_BEVEL_GROOVE_SINGLE_BEVEL_BUTT:
                    return System.Enum.Parse(tsType, "STEEP_FLANKED_BEVEL_GROOVE_SINGLE_BEVEL_BUTT");
                case WeldTypeEnum.WELD_TYPE_EDGE:
                    return System.Enum.Parse(tsType, "WELD_TYPE_EDGE");
                case WeldTypeEnum.WELD_TYPE_ISO_SURFACING:
                    return System.Enum.Parse(tsType, "WELD_TYPE_ISO_SURFACING");
                case WeldTypeEnum.WELD_TYPE_FOLD:
                    return System.Enum.Parse(tsType, "WELD_TYPE_FOLD");
                case WeldTypeEnum.WELD_TYPE_INCLINED:
                    return System.Enum.Parse(tsType, "WELD_TYPE_INCLINED");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }

        public static WeldTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);

            if (tsEnumValue.Equals("WELD_TYPE_NONE", System.StringComparison.InvariantCulture))
                return WeldTypeEnum.WELD_TYPE_NONE;
            else if (tsEnumValue.Equals("WELD_TYPE_EDGE_FLANGE", System.StringComparison.InvariantCulture))
                return WeldTypeEnum.WELD_TYPE_EDGE_FLANGE;
            else if (tsEnumValue.Equals("WELD_TYPE_SQUARE_GROOVE_SQUARE_BUTT", System.StringComparison.InvariantCulture))
                return WeldTypeEnum.WELD_TYPE_SQUARE_GROOVE_SQUARE_BUTT;
            else if (tsEnumValue.Equals("WELD_TYPE_BEVEL_GROOVE_SINGLE_V_BUTT", System.StringComparison.InvariantCulture))
                return WeldTypeEnum.WELD_TYPE_BEVEL_GROOVE_SINGLE_V_BUTT;
            else if (tsEnumValue.Equals("WELD_TYPE_BEVEL_GROOVE_SINGLE_BEVEL_BUTT", System.StringComparison.InvariantCulture))
                return WeldTypeEnum.WELD_TYPE_BEVEL_GROOVE_SINGLE_BEVEL_BUTT;
            else if (tsEnumValue.Equals("WELD_TYPE_SINGLE_V_BUTT_WITH_BROAD_ROOT_FACE", System.StringComparison.InvariantCulture))
                return WeldTypeEnum.WELD_TYPE_SINGLE_V_BUTT_WITH_BROAD_ROOT_FACE;
            else if (tsEnumValue.Equals("WELD_TYPE_SINGLE_BEVEL_BUTT_WITH_BROAD_ROOT_FACE", System.StringComparison.InvariantCulture))
                return WeldTypeEnum.WELD_TYPE_SINGLE_BEVEL_BUTT_WITH_BROAD_ROOT_FACE;
            else if (tsEnumValue.Equals("WELD_TYPE_U_GROOVE_SINGLE_U_BUTT", System.StringComparison.InvariantCulture))
                return WeldTypeEnum.WELD_TYPE_U_GROOVE_SINGLE_U_BUTT;
            else if (tsEnumValue.Equals("WELD_TYPE_J_GROOVE_J_BUTT", System.StringComparison.InvariantCulture))
                return WeldTypeEnum.WELD_TYPE_J_GROOVE_J_BUTT;
            else if (tsEnumValue.Equals("WELD_TYPE_BEVEL_BACKING", System.StringComparison.InvariantCulture))
                return WeldTypeEnum.WELD_TYPE_BEVEL_BACKING;
            else if (tsEnumValue.Equals("WELD_TYPE_FILLET", System.StringComparison.InvariantCulture))
                return WeldTypeEnum.WELD_TYPE_FILLET;
            else if (tsEnumValue.Equals("WELD_TYPE_PLUG", System.StringComparison.InvariantCulture))
                return WeldTypeEnum.WELD_TYPE_PLUG;
            else if (tsEnumValue.Equals("WELD_TYPE_SPOT", System.StringComparison.InvariantCulture))
                return WeldTypeEnum.WELD_TYPE_SPOT;
            else if (tsEnumValue.Equals("WELD_TYPE_SEAM", System.StringComparison.InvariantCulture))
                return WeldTypeEnum.WELD_TYPE_SEAM;
            else if (tsEnumValue.Equals("WELD_TYPE_SLOT", System.StringComparison.InvariantCulture))
                return WeldTypeEnum.WELD_TYPE_SLOT;
            else if (tsEnumValue.Equals("WELD_TYPE_FLARE_BEVEL_GROOVE", System.StringComparison.InvariantCulture))
                return WeldTypeEnum.WELD_TYPE_FLARE_BEVEL_GROOVE;
            else if (tsEnumValue.Equals("WELD_TYPE_FLARE_V_GROOVE", System.StringComparison.InvariantCulture))
                return WeldTypeEnum.WELD_TYPE_FLARE_V_GROOVE;
            else if (tsEnumValue.Equals("WELD_TYPE_CORNER_FLANGE", System.StringComparison.InvariantCulture))
                return WeldTypeEnum.WELD_TYPE_CORNER_FLANGE;
            else if (tsEnumValue.Equals("WELD_TYPE_PARTIAL_PENETRATION_SINGLE_BEVEL_BUTT_PLUS_FILLET", System.StringComparison.InvariantCulture))
                return WeldTypeEnum.WELD_TYPE_PARTIAL_PENETRATION_SINGLE_BEVEL_BUTT_PLUS_FILLET;
            else if (tsEnumValue.Equals("WELD_TYPE_PARTIAL_PENETRATION_SQUARE_GROOVE_PLUS_FILLET", System.StringComparison.InvariantCulture))
                return WeldTypeEnum.WELD_TYPE_PARTIAL_PENETRATION_SQUARE_GROOVE_PLUS_FILLET;
            else if (tsEnumValue.Equals("WELD_TYPE_MELT_THROUGH", System.StringComparison.InvariantCulture))
                return WeldTypeEnum.WELD_TYPE_MELT_THROUGH;
            else if (tsEnumValue.Equals("STEEP_FLANKED_BEVEL_GROOVE_SINGLE_V_BUTT", System.StringComparison.InvariantCulture))
                return WeldTypeEnum.STEEP_FLANKED_BEVEL_GROOVE_SINGLE_V_BUTT;
            else if (tsEnumValue.Equals("STEEP_FLANKED_BEVEL_GROOVE_SINGLE_BEVEL_BUTT", System.StringComparison.InvariantCulture))
                return WeldTypeEnum.STEEP_FLANKED_BEVEL_GROOVE_SINGLE_BEVEL_BUTT;
            else if (tsEnumValue.Equals("WELD_TYPE_EDGE", System.StringComparison.InvariantCulture))
                return WeldTypeEnum.WELD_TYPE_EDGE;
            else if (tsEnumValue.Equals("WELD_TYPE_ISO_SURFACING", System.StringComparison.InvariantCulture))
                return WeldTypeEnum.WELD_TYPE_ISO_SURFACING;
            else if (tsEnumValue.Equals("WELD_TYPE_FOLD", System.StringComparison.InvariantCulture))
                return WeldTypeEnum.WELD_TYPE_FOLD;
            else if (tsEnumValue.Equals("WELD_TYPE_INCLINED", System.StringComparison.InvariantCulture))
                return WeldTypeEnum.WELD_TYPE_INCLINED;

            else
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");

        }
    }


    public enum WeldContourEnum
    {
        WELD_CONTOUR_NONE,
        WELD_CONTOUR_FLUSH,
        WELD_CONTOUR_CONVEX,
        WELD_CONTOUR_CONCAVE
    }

    internal static class WeldContourEnum_
    {
        public static dynamic GetTSObject(WeldContourEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.BaseWeld.WeldContourEnum").GetType();

            switch (dynEnum)
            {
                case WeldContourEnum.WELD_CONTOUR_NONE:
                    return System.Enum.Parse(tsType, "WELD_CONTOUR_NONE");
                case WeldContourEnum.WELD_CONTOUR_FLUSH:
                    return System.Enum.Parse(tsType, "WELD_CONTOUR_FLUSH");
                case WeldContourEnum.WELD_CONTOUR_CONVEX:
                    return System.Enum.Parse(tsType, "WELD_CONTOUR_CONVEX");
                case WeldContourEnum.WELD_CONTOUR_CONCAVE:
                    return System.Enum.Parse(tsType, "WELD_CONTOUR_CONCAVE");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }

        public static WeldContourEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);

            if (tsEnumValue.Equals("WELD_CONTOUR_NONE", System.StringComparison.InvariantCulture))
                return WeldContourEnum.WELD_CONTOUR_NONE;
            else if (tsEnumValue.Equals("WELD_CONTOUR_FLUSH", System.StringComparison.InvariantCulture))
                return WeldContourEnum.WELD_CONTOUR_FLUSH;
            else if (tsEnumValue.Equals("WELD_CONTOUR_CONVEX", System.StringComparison.InvariantCulture))
                return WeldContourEnum.WELD_CONTOUR_CONVEX;
            else if (tsEnumValue.Equals("WELD_CONTOUR_CONCAVE", System.StringComparison.InvariantCulture))
                return WeldContourEnum.WELD_CONTOUR_CONCAVE;

            else
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");

        }
    }


    public enum WeldFinishEnum
    {
        WELD_FINISH_NONE,
        WELD_FINISH_GRIND,
        WELD_FINISH_MACHINE,
        WELD_FINISH_CHIP,
        WELD_FINISH_FINISHED_WELD,
        WELS_FINISH_SMOOTH_TRANSITION
    }

    internal static class WeldFinishEnum_
    {
        public static dynamic GetTSObject(WeldFinishEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.BaseWeld.WeldFinishEnum").GetType();

            switch (dynEnum)
            {
                case WeldFinishEnum.WELD_FINISH_NONE:
                    return System.Enum.Parse(tsType, "WELD_FINISH_NONE");
                case WeldFinishEnum.WELD_FINISH_GRIND:
                    return System.Enum.Parse(tsType, "WELD_FINISH_GRIND");
                case WeldFinishEnum.WELD_FINISH_MACHINE:
                    return System.Enum.Parse(tsType, "WELD_FINISH_MACHINE");
                case WeldFinishEnum.WELD_FINISH_CHIP:
                    return System.Enum.Parse(tsType, "WELD_FINISH_CHIP");
                case WeldFinishEnum.WELD_FINISH_FINISHED_WELD:
                    return System.Enum.Parse(tsType, "WELD_FINISH_FINISHED_WELD");
                case WeldFinishEnum.WELS_FINISH_SMOOTH_TRANSITION:
                    return System.Enum.Parse(tsType, "WELS_FINISH_SMOOTH_TRANSITION");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }

        public static WeldFinishEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);

            if (tsEnumValue.Equals("WELD_FINISH_NONE", System.StringComparison.InvariantCulture))
                return WeldFinishEnum.WELD_FINISH_NONE;
            else if (tsEnumValue.Equals("WELD_FINISH_GRIND", System.StringComparison.InvariantCulture))
                return WeldFinishEnum.WELD_FINISH_GRIND;
            else if (tsEnumValue.Equals("WELD_FINISH_MACHINE", System.StringComparison.InvariantCulture))
                return WeldFinishEnum.WELD_FINISH_MACHINE;
            else if (tsEnumValue.Equals("WELD_FINISH_CHIP", System.StringComparison.InvariantCulture))
                return WeldFinishEnum.WELD_FINISH_CHIP;
            else if (tsEnumValue.Equals("WELD_FINISH_FINISHED_WELD", System.StringComparison.InvariantCulture))
                return WeldFinishEnum.WELD_FINISH_FINISHED_WELD;
            else if (tsEnumValue.Equals("WELS_FINISH_SMOOTH_TRANSITION", System.StringComparison.InvariantCulture))
                return WeldFinishEnum.WELS_FINISH_SMOOTH_TRANSITION;

            else
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");

        }
    }


    public enum WeldElectrodeClassificationEnum
    {
        WELD_ELECTRODE_CLASSIFICATION_NONE,
        WELD_ELECTRODE_CLASSIFICATION_35,
        WELD_ELECTRODE_CLASSIFICATION_42,
        WELD_ELECTRODE_CLASSIFICATION_50,
        WELD_ELECTRODE_CLASSIFICATION_E60XX,
        WELD_ELECTRODE_CLASSIFICATION_E70XX,
        WELD_ELECTRODE_CLASSIFICATION_E80XX,
        WELD_ELECTRODE_CLASSIFICATION_E90XX
    }

    internal static class WeldElectrodeClassificationEnum_
    {
        public static dynamic GetTSObject(WeldElectrodeClassificationEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.BaseWeld.WeldElectrodeClassificationEnum").GetType();

            switch (dynEnum)
            {
                case WeldElectrodeClassificationEnum.WELD_ELECTRODE_CLASSIFICATION_NONE:
                    return System.Enum.Parse(tsType, "WELD_ELECTRODE_CLASSIFICATION_NONE");
                case WeldElectrodeClassificationEnum.WELD_ELECTRODE_CLASSIFICATION_35:
                    return System.Enum.Parse(tsType, "WELD_ELECTRODE_CLASSIFICATION_35");
                case WeldElectrodeClassificationEnum.WELD_ELECTRODE_CLASSIFICATION_42:
                    return System.Enum.Parse(tsType, "WELD_ELECTRODE_CLASSIFICATION_42");
                case WeldElectrodeClassificationEnum.WELD_ELECTRODE_CLASSIFICATION_50:
                    return System.Enum.Parse(tsType, "WELD_ELECTRODE_CLASSIFICATION_50");
                case WeldElectrodeClassificationEnum.WELD_ELECTRODE_CLASSIFICATION_E60XX:
                    return System.Enum.Parse(tsType, "WELD_ELECTRODE_CLASSIFICATION_E60XX");
                case WeldElectrodeClassificationEnum.WELD_ELECTRODE_CLASSIFICATION_E70XX:
                    return System.Enum.Parse(tsType, "WELD_ELECTRODE_CLASSIFICATION_E70XX");
                case WeldElectrodeClassificationEnum.WELD_ELECTRODE_CLASSIFICATION_E80XX:
                    return System.Enum.Parse(tsType, "WELD_ELECTRODE_CLASSIFICATION_E80XX");
                case WeldElectrodeClassificationEnum.WELD_ELECTRODE_CLASSIFICATION_E90XX:
                    return System.Enum.Parse(tsType, "WELD_ELECTRODE_CLASSIFICATION_E90XX");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }

        public static WeldElectrodeClassificationEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);

            if (tsEnumValue.Equals("WELD_ELECTRODE_CLASSIFICATION_NONE", System.StringComparison.InvariantCulture))
                return WeldElectrodeClassificationEnum.WELD_ELECTRODE_CLASSIFICATION_NONE;
            else if (tsEnumValue.Equals("WELD_ELECTRODE_CLASSIFICATION_35", System.StringComparison.InvariantCulture))
                return WeldElectrodeClassificationEnum.WELD_ELECTRODE_CLASSIFICATION_35;
            else if (tsEnumValue.Equals("WELD_ELECTRODE_CLASSIFICATION_42", System.StringComparison.InvariantCulture))
                return WeldElectrodeClassificationEnum.WELD_ELECTRODE_CLASSIFICATION_42;
            else if (tsEnumValue.Equals("WELD_ELECTRODE_CLASSIFICATION_50", System.StringComparison.InvariantCulture))
                return WeldElectrodeClassificationEnum.WELD_ELECTRODE_CLASSIFICATION_50;
            else if (tsEnumValue.Equals("WELD_ELECTRODE_CLASSIFICATION_E60XX", System.StringComparison.InvariantCulture))
                return WeldElectrodeClassificationEnum.WELD_ELECTRODE_CLASSIFICATION_E60XX;
            else if (tsEnumValue.Equals("WELD_ELECTRODE_CLASSIFICATION_E70XX", System.StringComparison.InvariantCulture))
                return WeldElectrodeClassificationEnum.WELD_ELECTRODE_CLASSIFICATION_E70XX;
            else if (tsEnumValue.Equals("WELD_ELECTRODE_CLASSIFICATION_E80XX", System.StringComparison.InvariantCulture))
                return WeldElectrodeClassificationEnum.WELD_ELECTRODE_CLASSIFICATION_E80XX;
            else if (tsEnumValue.Equals("WELD_ELECTRODE_CLASSIFICATION_E90XX", System.StringComparison.InvariantCulture))
                return WeldElectrodeClassificationEnum.WELD_ELECTRODE_CLASSIFICATION_E90XX;

            else
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");

        }
    }


    public enum WeldProcessTypeEnum
    {
        WELD_PROCESS_NONE,
        WELD_PROCESS_SMAW,
        WELD_PROCESS_SAW,
        WELD_PROCESS_GMAW,
        WELD_PROCESS_FCAW,
        WELD_PROCESS_ESW,
        WELD_PROCESS_EGW
    }

    internal static class WeldProcessTypeEnum_
    {
        public static dynamic GetTSObject(WeldProcessTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.BaseWeld.WeldProcessTypeEnum").GetType();

            switch (dynEnum)
            {
                case WeldProcessTypeEnum.WELD_PROCESS_NONE:
                    return System.Enum.Parse(tsType, "WELD_PROCESS_NONE");
                case WeldProcessTypeEnum.WELD_PROCESS_SMAW:
                    return System.Enum.Parse(tsType, "WELD_PROCESS_SMAW");
                case WeldProcessTypeEnum.WELD_PROCESS_SAW:
                    return System.Enum.Parse(tsType, "WELD_PROCESS_SAW");
                case WeldProcessTypeEnum.WELD_PROCESS_GMAW:
                    return System.Enum.Parse(tsType, "WELD_PROCESS_GMAW");
                case WeldProcessTypeEnum.WELD_PROCESS_FCAW:
                    return System.Enum.Parse(tsType, "WELD_PROCESS_FCAW");
                case WeldProcessTypeEnum.WELD_PROCESS_ESW:
                    return System.Enum.Parse(tsType, "WELD_PROCESS_ESW");
                case WeldProcessTypeEnum.WELD_PROCESS_EGW:
                    return System.Enum.Parse(tsType, "WELD_PROCESS_EGW");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }

        public static WeldProcessTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);

            if (tsEnumValue.Equals("WELD_PROCESS_NONE", System.StringComparison.InvariantCulture))
                return WeldProcessTypeEnum.WELD_PROCESS_NONE;
            else if (tsEnumValue.Equals("WELD_PROCESS_SMAW", System.StringComparison.InvariantCulture))
                return WeldProcessTypeEnum.WELD_PROCESS_SMAW;
            else if (tsEnumValue.Equals("WELD_PROCESS_SAW", System.StringComparison.InvariantCulture))
                return WeldProcessTypeEnum.WELD_PROCESS_SAW;
            else if (tsEnumValue.Equals("WELD_PROCESS_GMAW", System.StringComparison.InvariantCulture))
                return WeldProcessTypeEnum.WELD_PROCESS_GMAW;
            else if (tsEnumValue.Equals("WELD_PROCESS_FCAW", System.StringComparison.InvariantCulture))
                return WeldProcessTypeEnum.WELD_PROCESS_FCAW;
            else if (tsEnumValue.Equals("WELD_PROCESS_ESW", System.StringComparison.InvariantCulture))
                return WeldProcessTypeEnum.WELD_PROCESS_ESW;
            else if (tsEnumValue.Equals("WELD_PROCESS_EGW", System.StringComparison.InvariantCulture))
                return WeldProcessTypeEnum.WELD_PROCESS_EGW;

            else
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");

        }
    }


    public enum WeldNDTInspectionEnum
    {
        WELD_NDT_INSPECTION_NONE,
        WELD_NDT_INSPECTION_A,
        WELD_NDT_INSPECTION_B,
        WELD_NDT_INSPECTION_C,
        WELD_NDT_INSPECTION_D,
        WELD_NDT_INSPECTION_E
    }

    internal static class WeldNDTInspectionEnum_
    {
        public static dynamic GetTSObject(WeldNDTInspectionEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.BaseWeld.WeldNDTInspectionEnum").GetType();

            switch (dynEnum)
            {
                case WeldNDTInspectionEnum.WELD_NDT_INSPECTION_NONE:
                    return System.Enum.Parse(tsType, "WELD_NDT_INSPECTION_NONE");
                case WeldNDTInspectionEnum.WELD_NDT_INSPECTION_A:
                    return System.Enum.Parse(tsType, "WELD_NDT_INSPECTION_A");
                case WeldNDTInspectionEnum.WELD_NDT_INSPECTION_B:
                    return System.Enum.Parse(tsType, "WELD_NDT_INSPECTION_B");
                case WeldNDTInspectionEnum.WELD_NDT_INSPECTION_C:
                    return System.Enum.Parse(tsType, "WELD_NDT_INSPECTION_C");
                case WeldNDTInspectionEnum.WELD_NDT_INSPECTION_D:
                    return System.Enum.Parse(tsType, "WELD_NDT_INSPECTION_D");
                case WeldNDTInspectionEnum.WELD_NDT_INSPECTION_E:
                    return System.Enum.Parse(tsType, "WELD_NDT_INSPECTION_E");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }

        public static WeldNDTInspectionEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);

            if (tsEnumValue.Equals("WELD_NDT_INSPECTION_NONE", System.StringComparison.InvariantCulture))
                return WeldNDTInspectionEnum.WELD_NDT_INSPECTION_NONE;
            else if (tsEnumValue.Equals("WELD_NDT_INSPECTION_A", System.StringComparison.InvariantCulture))
                return WeldNDTInspectionEnum.WELD_NDT_INSPECTION_A;
            else if (tsEnumValue.Equals("WELD_NDT_INSPECTION_B", System.StringComparison.InvariantCulture))
                return WeldNDTInspectionEnum.WELD_NDT_INSPECTION_B;
            else if (tsEnumValue.Equals("WELD_NDT_INSPECTION_C", System.StringComparison.InvariantCulture))
                return WeldNDTInspectionEnum.WELD_NDT_INSPECTION_C;
            else if (tsEnumValue.Equals("WELD_NDT_INSPECTION_D", System.StringComparison.InvariantCulture))
                return WeldNDTInspectionEnum.WELD_NDT_INSPECTION_D;
            else if (tsEnumValue.Equals("WELD_NDT_INSPECTION_E", System.StringComparison.InvariantCulture))
                return WeldNDTInspectionEnum.WELD_NDT_INSPECTION_E;

            else
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");

        }
    }


    public enum WeldIntermittentTypeEnum
    {
        CONTINUOUS,
        CHAIN_INTERMITTENT,
        STAGGERED_INTERMITTENT
    }

    internal static class WeldIntermittentTypeEnum_
    {
        public static dynamic GetTSObject(WeldIntermittentTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.BaseWeld.WeldIntermittentTypeEnum").GetType();

            switch (dynEnum)
            {
                case WeldIntermittentTypeEnum.CONTINUOUS:
                    return System.Enum.Parse(tsType, "CONTINUOUS");
                case WeldIntermittentTypeEnum.CHAIN_INTERMITTENT:
                    return System.Enum.Parse(tsType, "CHAIN_INTERMITTENT");
                case WeldIntermittentTypeEnum.STAGGERED_INTERMITTENT:
                    return System.Enum.Parse(tsType, "STAGGERED_INTERMITTENT");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }

        public static WeldIntermittentTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);

            if (tsEnumValue.Equals("CONTINUOUS", System.StringComparison.InvariantCulture))
                return WeldIntermittentTypeEnum.CONTINUOUS;
            else if (tsEnumValue.Equals("CHAIN_INTERMITTENT", System.StringComparison.InvariantCulture))
                return WeldIntermittentTypeEnum.CHAIN_INTERMITTENT;
            else if (tsEnumValue.Equals("STAGGERED_INTERMITTENT", System.StringComparison.InvariantCulture))
                return WeldIntermittentTypeEnum.STAGGERED_INTERMITTENT;

            else
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");

        }
    }


    public enum WeldPlacementTypeEnum
    {
        PLACEMENT_AUTO,
        PLACEMENT_MAIN,
        PLACEMENT_SECONDARY
    }

    internal static class WeldPlacementTypeEnum_
    {
        public static dynamic GetTSObject(WeldPlacementTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.BaseWeld.WeldPlacementTypeEnum").GetType();

            switch (dynEnum)
            {
                case WeldPlacementTypeEnum.PLACEMENT_AUTO:
                    return System.Enum.Parse(tsType, "PLACEMENT_AUTO");
                case WeldPlacementTypeEnum.PLACEMENT_MAIN:
                    return System.Enum.Parse(tsType, "PLACEMENT_MAIN");
                case WeldPlacementTypeEnum.PLACEMENT_SECONDARY:
                    return System.Enum.Parse(tsType, "PLACEMENT_SECONDARY");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }

        public static WeldPlacementTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);

            if (tsEnumValue.Equals("PLACEMENT_AUTO", System.StringComparison.InvariantCulture))
                return WeldPlacementTypeEnum.PLACEMENT_AUTO;
            else if (tsEnumValue.Equals("PLACEMENT_MAIN", System.StringComparison.InvariantCulture))
                return WeldPlacementTypeEnum.PLACEMENT_MAIN;
            else if (tsEnumValue.Equals("PLACEMENT_SECONDARY", System.StringComparison.InvariantCulture))
                return WeldPlacementTypeEnum.PLACEMENT_SECONDARY;

            else
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");

        }
    }


    public enum WeldPreparationTypeEnum
    {
        PREPARATION_NONE,
        PREPARATION_AUTO,
        PREPARATION_MAIN,
        PREPARATION_SECONDARY
    }

    internal static class WeldPreparationTypeEnum_
    {
        public static dynamic GetTSObject(WeldPreparationTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.BaseWeld.WeldPreparationTypeEnum").GetType();

            switch (dynEnum)
            {
                case WeldPreparationTypeEnum.PREPARATION_NONE:
                    return System.Enum.Parse(tsType, "PREPARATION_NONE");
                case WeldPreparationTypeEnum.PREPARATION_AUTO:
                    return System.Enum.Parse(tsType, "PREPARATION_AUTO");
                case WeldPreparationTypeEnum.PREPARATION_MAIN:
                    return System.Enum.Parse(tsType, "PREPARATION_MAIN");
                case WeldPreparationTypeEnum.PREPARATION_SECONDARY:
                    return System.Enum.Parse(tsType, "PREPARATION_SECONDARY");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }

        public static WeldPreparationTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);

            if (tsEnumValue.Equals("PREPARATION_NONE", System.StringComparison.InvariantCulture))
                return WeldPreparationTypeEnum.PREPARATION_NONE;
            else if (tsEnumValue.Equals("PREPARATION_AUTO", System.StringComparison.InvariantCulture))
                return WeldPreparationTypeEnum.PREPARATION_AUTO;
            else if (tsEnumValue.Equals("PREPARATION_MAIN", System.StringComparison.InvariantCulture))
                return WeldPreparationTypeEnum.PREPARATION_MAIN;
            else if (tsEnumValue.Equals("PREPARATION_SECONDARY", System.StringComparison.InvariantCulture))
                return WeldPreparationTypeEnum.PREPARATION_SECONDARY;

            else
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");

        }
    }



}

internal static class BaseWeld_
{
    public static dynamic GetTSObject(BaseWeld dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static BaseWeld FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (BaseWeld)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}
