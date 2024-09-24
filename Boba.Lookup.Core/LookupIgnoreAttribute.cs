namespace Boba.Lookup;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
public class LookupIgnoreAttribute : Attribute { }
