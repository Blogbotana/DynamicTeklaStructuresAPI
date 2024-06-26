using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;

namespace Dynamic.Tekla.Structures.Model;


public abstract class Load  : ModelObject
{


    public Dynamic.Tekla.Structures.Identifier FatherId
    {
        get
        {
            try
            {
            var value = teklaObject.FatherId;
            var value_ = Dynamic.Tekla.Structures.Identifier_.FromTSObject(value);
            return (Dynamic.Tekla.Structures.Identifier) value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(FatherId), ex); 
            }
        }
        set
        {
            try
            {
            var value_ = Dynamic.Tekla.Structures.Identifier_.GetTSObject(value);
            teklaObject.FatherId = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(FatherId), ex); 
            }
        }
    }

    public Load.LoadSpanningEnum Spanning
    {
        get
        {
            try
            {
            var value = teklaObject.Spanning;
            var value_ = Load.LoadSpanningEnum_.FromTSObject(value);
            return (Load.LoadSpanningEnum) value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Spanning), ex); 
            }
        }
        set
        {
            try
            {
            var value_ = Load.LoadSpanningEnum_.GetTSObject(value);
            teklaObject.Spanning = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Spanning), ex); 
            }
        }
    }

    public Dynamic.Tekla.Structures.Geometry3d.Vector PrimaryAxisDirection
    {
        get
        {
            try
            {
            var value = teklaObject.PrimaryAxisDirection;
            var value_ = Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(value);
            return (Dynamic.Tekla.Structures.Geometry3d.Vector) value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(PrimaryAxisDirection), ex); 
            }
        }
        set
        {
            try
            {
            var value_ = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value);
            teklaObject.PrimaryAxisDirection = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(PrimaryAxisDirection), ex); 
            }
        }
    }

    public bool AutomaticPrimaryAxisWeight
    {
        get
        {
            try
            {
            return teklaObject.AutomaticPrimaryAxisWeight;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(AutomaticPrimaryAxisWeight), ex); 
            }
        }
        set
        {
            try
            {
            teklaObject.AutomaticPrimaryAxisWeight = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(AutomaticPrimaryAxisWeight), ex); 
            }
        }
    }

    public double Weight
    {
        get
        {
            try
            {
            return teklaObject.Weight;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Weight), ex); 
            }
        }
        set
        {
            try
            {
            teklaObject.Weight = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Weight), ex); 
            }
        }
    }

    public double LoadDispersionAngle
    {
        get
        {
            try
            {
            return teklaObject.LoadDispersionAngle;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LoadDispersionAngle), ex); 
            }
        }
        set
        {
            try
            {
            teklaObject.LoadDispersionAngle = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LoadDispersionAngle), ex); 
            }
        }
    }

    public bool CreateFixedSupportConditionsAutomatically
    {
        get
        {
            try
            {
            return teklaObject.CreateFixedSupportConditionsAutomatically;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(CreateFixedSupportConditionsAutomatically), ex); 
            }
        }
        set
        {
            try
            {
            teklaObject.CreateFixedSupportConditionsAutomatically = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(CreateFixedSupportConditionsAutomatically), ex); 
            }
        }
    }

    public Load.LoadAttachmentEnum LoadAttachment
    {
        get
        {
            try
            {
            var value = teklaObject.LoadAttachment;
            var value_ = Load.LoadAttachmentEnum_.FromTSObject(value);
            return (Load.LoadAttachmentEnum) value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LoadAttachment), ex); 
            }
        }
        set
        {
            try
            {
            var value_ = Load.LoadAttachmentEnum_.GetTSObject(value);
            teklaObject.LoadAttachment = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LoadAttachment), ex); 
            }
        }
    }

    public Load.LoadPartNamesEnum PartNames
    {
        get
        {
            try
            {
            var value = teklaObject.PartNames;
            var value_ = Load.LoadPartNamesEnum_.FromTSObject(value);
            return (Load.LoadPartNamesEnum) value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(PartNames), ex); 
            }
        }
        set
        {
            try
            {
            var value_ = Load.LoadPartNamesEnum_.GetTSObject(value);
            teklaObject.PartNames = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(PartNames), ex); 
            }
        }
    }

    public string PartFilter
    {
        get
        {
            try
            {
            return teklaObject.PartFilter;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(PartFilter), ex); 
            }
        }
        set
        {
            try
            {
            teklaObject.PartFilter = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(PartFilter), ex); 
            }
        }
    }

    public double BoundingBoxDx
    {
        get
        {
            try
            {
            return teklaObject.BoundingBoxDx;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(BoundingBoxDx), ex); 
            }
        }
        set
        {
            try
            {
            teklaObject.BoundingBoxDx = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(BoundingBoxDx), ex); 
            }
        }
    }

    public double BoundingBoxDy
    {
        get
        {
            try
            {
            return teklaObject.BoundingBoxDy;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(BoundingBoxDy), ex); 
            }
        }
        set
        {
            try
            {
            teklaObject.BoundingBoxDy = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(BoundingBoxDy), ex); 
            }
        }
    }

    public double BoundingBoxDz
    {
        get
        {
            try
            {
            return teklaObject.BoundingBoxDz;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(BoundingBoxDz), ex); 
            }
        }
        set
        {
            try
            {
            teklaObject.BoundingBoxDz = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(BoundingBoxDz), ex); 
            }
        }
    }

    public LoadGroup Group
    {
        get
        {
            try
            {
            var value = teklaObject.Group;
            var value_ = LoadGroup_.FromTSObject(value);
            return (LoadGroup) value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Group), ex); 
            }
        }
        set
        {
            try
            {
            var value_ = LoadGroup_.GetTSObject(value);
            teklaObject.Group = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Group), ex); 
            }
        }
    }
    

    





public enum LoadSpanningEnum
{
			LOAD_SPANNING_SINGLE,
			LOAD_SPANNING_DOUBLE        
}

internal static class LoadSpanningEnum_
{
    public static dynamic GetTSObject(LoadSpanningEnum dynEnum)
    {
        var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.Load.LoadSpanningEnum").GetType();

        switch (dynEnum)
        {
				case LoadSpanningEnum.LOAD_SPANNING_SINGLE:
					return System.Enum.Parse(tsType, "LOAD_SPANNING_SINGLE");
				case LoadSpanningEnum.LOAD_SPANNING_DOUBLE:
					return System.Enum.Parse(tsType, "LOAD_SPANNING_DOUBLE");

            default:
                throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
        }
    }

    public static LoadSpanningEnum FromTSObject(dynamic tsEnum)
    {
        string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
        
			if (tsEnumValue.Equals("LOAD_SPANNING_SINGLE", System.StringComparison.InvariantCulture))
				return LoadSpanningEnum.LOAD_SPANNING_SINGLE;
			else if (tsEnumValue.Equals("LOAD_SPANNING_DOUBLE", System.StringComparison.InvariantCulture))
				return LoadSpanningEnum.LOAD_SPANNING_DOUBLE;

        else 
            throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
        
    }
}


public enum LoadAttachmentEnum
{
			LOAD_ATTACHMENT_ATTACH_TO_MEMBER,
			LOAD_ATTACHMENT_DONT_ATTACH        
}

internal static class LoadAttachmentEnum_
{
    public static dynamic GetTSObject(LoadAttachmentEnum dynEnum)
    {
        var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.Load.LoadAttachmentEnum").GetType();

        switch (dynEnum)
        {
				case LoadAttachmentEnum.LOAD_ATTACHMENT_ATTACH_TO_MEMBER:
					return System.Enum.Parse(tsType, "LOAD_ATTACHMENT_ATTACH_TO_MEMBER");
				case LoadAttachmentEnum.LOAD_ATTACHMENT_DONT_ATTACH:
					return System.Enum.Parse(tsType, "LOAD_ATTACHMENT_DONT_ATTACH");

            default:
                throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
        }
    }

    public static LoadAttachmentEnum FromTSObject(dynamic tsEnum)
    {
        string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
        
			if (tsEnumValue.Equals("LOAD_ATTACHMENT_ATTACH_TO_MEMBER", System.StringComparison.InvariantCulture))
				return LoadAttachmentEnum.LOAD_ATTACHMENT_ATTACH_TO_MEMBER;
			else if (tsEnumValue.Equals("LOAD_ATTACHMENT_DONT_ATTACH", System.StringComparison.InvariantCulture))
				return LoadAttachmentEnum.LOAD_ATTACHMENT_DONT_ATTACH;

        else 
            throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
        
    }
}


public enum LoadPartNamesEnum
{
			LOAD_PART_NAMES_EXCLUDE,
			LOAD_PART_NAMES_INCLUDE        
}

internal static class LoadPartNamesEnum_
{
    public static dynamic GetTSObject(LoadPartNamesEnum dynEnum)
    {
        var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.Load.LoadPartNamesEnum").GetType();

        switch (dynEnum)
        {
				case LoadPartNamesEnum.LOAD_PART_NAMES_EXCLUDE:
					return System.Enum.Parse(tsType, "LOAD_PART_NAMES_EXCLUDE");
				case LoadPartNamesEnum.LOAD_PART_NAMES_INCLUDE:
					return System.Enum.Parse(tsType, "LOAD_PART_NAMES_INCLUDE");

            default:
                throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
        }
    }

    public static LoadPartNamesEnum FromTSObject(dynamic tsEnum)
    {
        string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
        
			if (tsEnumValue.Equals("LOAD_PART_NAMES_EXCLUDE", System.StringComparison.InvariantCulture))
				return LoadPartNamesEnum.LOAD_PART_NAMES_EXCLUDE;
			else if (tsEnumValue.Equals("LOAD_PART_NAMES_INCLUDE", System.StringComparison.InvariantCulture))
				return LoadPartNamesEnum.LOAD_PART_NAMES_INCLUDE;

        else 
            throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
        
    }
}



}

internal static class Load_
{
    public static dynamic GetTSObject(Load dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static Load FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
        
        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (Load)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

internal static class LoadArray_
{
    public static dynamic GetTSObject(Load[] dynArray)
    {
        if (dynArray is null) return null;
        var list = new System.Collections.Generic.List<dynamic>();
        foreach(var dynItem in dynArray)
        {
            list.Add(Load_.GetTSObject(dynItem));
        }
        return list.ToArray();
    }

    public static Load[] FromTSObject(dynamic[] tsArray)
    {
        if (tsArray is null) return null;
        var list = new System.Collections.Generic.List<Load>();
        foreach(var tsItem in tsArray)
        {
            list.Add(Load_.FromTSObject(tsItem));
        }
        return list.ToArray();
    }
}

