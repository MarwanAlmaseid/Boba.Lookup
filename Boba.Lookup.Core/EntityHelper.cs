using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Boba.Lookup;

public static class EntityHelper
{
    public static List<Type> GetAllSubEntities<T>()
    {
        var appDomain = new AppDomainTypeFinder();
        var alllookupEntities = appDomain.FindClassesOfType(typeof(T), true).ToList();

        return alllookupEntities;
    }

    public static Type GetEntityByName<T>(string name)
    {
        var domainAssemblies = GetAllSubEntities<T>();
        var assembly = domainAssemblies.FirstOrDefault(x => x.Name == name);

        return assembly;
    }

    public static string GetPropertyType(Type type)
    {
        if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>))
        {
            return Nullable.GetUnderlyingType(type).Name;
        }

        return type.Name;
    }

    public static bool IsNullable(PropertyInfo propertyInfo)
    {
        if (
            propertyInfo.PropertyType.IsGenericType
            && propertyInfo.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>)
        )
        {
            return true;
        }

        return false;
    }

    public static bool HasDefaultValue(PropertyInfo propertyInfo)
    {
        var requiredAttribute = Attribute.IsDefined(propertyInfo, typeof(RequiredAttribute));

        return requiredAttribute;
    }
}
