using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using System;

namespace Dynamic.Tekla.Structures.Model;
public class RadialGrid : GridBase
{
    public string RadialCoordinates
    {
        get
        {
            try
            {
                return teklaObject.RadialCoordinates;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(RadialCoordinates), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.RadialCoordinates = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(RadialCoordinates), ex);
            }
        }
    }

    public string AngularCoordinates
    {
        get
        {
            try
            {
                return teklaObject.AngularCoordinates;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(AngularCoordinates), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.AngularCoordinates = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(AngularCoordinates), ex);
            }
        }
    }

    public string CoordinateZ
    {
        get
        {
            try
            {
                return teklaObject.CoordinateZ;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(CoordinateZ), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.CoordinateZ = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(CoordinateZ), ex);
            }
        }
    }

    public string RadialLabels
    {
        get
        {
            try
            {
                return teklaObject.RadialLabels;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(RadialLabels), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.RadialLabels = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(RadialLabels), ex);
            }
        }
    }

    public string AngularLabels
    {
        get
        {
            try
            {
                return teklaObject.AngularLabels;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(AngularLabels), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.AngularLabels = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(AngularLabels), ex);
            }
        }
    }

    public string LabelZ
    {
        get
        {
            try
            {
                return teklaObject.LabelZ;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LabelZ), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.LabelZ = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LabelZ), ex);
            }
        }
    }

    public double ArcStartExtension
    {
        get
        {
            try
            {
                return teklaObject.ArcStartExtension;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ArcStartExtension), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.ArcStartExtension = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ArcStartExtension), ex);
            }
        }
    }

    public double AngularLinesStartExtension
    {
        get
        {
            try
            {
                return teklaObject.AngularLinesStartExtension;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(AngularLinesStartExtension), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.AngularLinesStartExtension = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(AngularLinesStartExtension), ex);
            }
        }
    }

    public double ExtensionBelowZ
    {
        get
        {
            try
            {
                return teklaObject.ExtensionBelowZ;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ExtensionBelowZ), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.ExtensionBelowZ = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ExtensionBelowZ), ex);
            }
        }
    }

    public double ArcEndExtension
    {
        get
        {
            try
            {
                return teklaObject.ArcEndExtension;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ArcEndExtension), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.ArcEndExtension = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ArcEndExtension), ex);
            }
        }
    }

    public double AngularLinesEndExtension
    {
        get
        {
            try
            {
                return teklaObject.AngularLinesEndExtension;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(AngularLinesEndExtension), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.AngularLinesEndExtension = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(AngularLinesEndExtension), ex);
            }
        }
    }

    public double ExtensionAboveZ
    {
        get
        {
            try
            {
                return teklaObject.ExtensionAboveZ;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ExtensionAboveZ), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.ExtensionAboveZ = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ExtensionAboveZ), ex);
            }
        }
    }

    public System.Drawing.Color Color
    {
        get
        {
            try
            {
                return teklaObject.Color;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Color), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.Color = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Color), ex);
            }
        }
    }


    public RadialGrid()
    {
        if (TeklaProcess.TeklaFileVersion < new Version("2019.0.0.0"))
            return;

        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.RadialGrid");
    }

    public RadialGrid(dynamic tsObject, System.DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }

}

internal static class RadialGrid_
{
    public static dynamic GetTSObject(RadialGrid dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static RadialGrid FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (RadialGrid)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}


