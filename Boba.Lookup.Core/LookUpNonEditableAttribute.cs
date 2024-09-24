namespace Shared.Domain.Common;

[AttributeUsage(
    AttributeTargets.Property | AttributeTargets.Field,
    Inherited = true,
    AllowMultiple = false
)]
public class LookUpNonEditableAttribute : Attribute { }
