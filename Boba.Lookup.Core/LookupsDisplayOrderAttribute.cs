namespace Boba.Lookup;

[AttributeUsage(AttributeTargets.Class, Inherited = false)]
public class LookupsDisplayOrderAttribute : Attribute
{
    public int Order { get; }

    public LookupsDisplayOrderAttribute(int order)
    {
        Order = order;
    }
}

[AttributeUsage(AttributeTargets.Property, Inherited = false)]
public class LookupPropertyDisplayOrderAttribute : Attribute
{
    public int Order { get; }

    public LookupPropertyDisplayOrderAttribute(int order)
    {
        Order = order;
    }
}
