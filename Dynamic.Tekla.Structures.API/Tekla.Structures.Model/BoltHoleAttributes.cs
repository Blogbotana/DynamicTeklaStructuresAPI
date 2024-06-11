using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic.Tekla.Structures.Model;
public sealed class BoltHoleAttributes
{

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

    public double LongHoleX
    {
        get
        {
            try
            {
                return teklaObject.LongHoleX;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LongHoleX), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.LongHoleX = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LongHoleX), ex);
            }
        }
    }

    public double LongHoleY
    {
        get
        {
            try
            {
                return teklaObject.LongHoleY;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LongHoleY), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.LongHoleY = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LongHoleY), ex);
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


    internal dynamic teklaObject;

    public BoltHoleAttributes()
    {
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.BoltHoleAttributes");
    }
    
    public BoltHoleAttributes(dynamic tsObject, System.DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }





}

internal static class BoltHoleAttributes_
{
    public static dynamic GetTSObject(BoltHoleAttributes dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static BoltHoleAttributes FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (BoltHoleAttributes)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

