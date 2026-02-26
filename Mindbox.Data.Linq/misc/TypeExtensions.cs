namespace System.Data.Linq
{
    internal static class TypeExtensions
    {
        internal static bool IsNullable(this Type type)
        {
            if (type == null)
                throw new ArgumentNullException("type");

            if (type.IsGenericType && typeof(Nullable<>) == type.GetGenericTypeDefinition())
                return true;

            return !type.IsValueType;
        }
    }
}
