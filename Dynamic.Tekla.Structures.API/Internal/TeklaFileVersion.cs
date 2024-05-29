namespace Dynamic.Tekla.Structures.Internal;

public struct TeklaFileVersion
{
    public int Major;
    public int Minor;
    public int Build;
    public int Build2;

    public override bool Equals(object obj)
    {
        if (obj is not TeklaFileVersion)
            return false;

        TeklaFileVersion version = (TeklaFileVersion)obj;
        return Major == version.Major &&
               Minor == version.Minor &&
               Build == version.Build &&
               Build2 == version.Build2;
    }

    public override int GetHashCode()
    {
        int hashCode = -1197760834;
        hashCode = (hashCode * -1521134295) + Major.GetHashCode();
        hashCode = (hashCode * -1521134295) + Minor.GetHashCode();
        hashCode = (hashCode * -1521134295) + Build.GetHashCode();
        hashCode = (hashCode * -1521134295) + Build2.GetHashCode();
        return hashCode;
    }

    public override string ToString()
    {
        System.Text.StringBuilder sb = new();
        _ = sb
            .Append(Major)
            .Append(".")
            .Append(Minor)
            .Append(".")
            .Append(Build)
            .Append(".")
            .Append(Build2);

        return sb.ToString();
    }

    public static bool operator ==(TeklaFileVersion version1, TeklaFileVersion version2)
    {
        return version1.Equals(version2);
    }

    public static bool operator !=(TeklaFileVersion version1, TeklaFileVersion version2)
    {
        return !(version1 == version2);
    }
}
