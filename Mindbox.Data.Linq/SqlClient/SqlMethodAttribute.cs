using System.Reflection;

namespace System.Data.Linq.SqlClient
{
    [AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
    public sealed class SqlMethodAttribute : Attribute
    {
        readonly string _functionName;

        public SqlMethodAttribute(string functionName)
        {
            this._functionName = functionName;
        }

        public string FunctionName
        {
            get { return _functionName; }
        }

        /// <summary>
        /// Call this with MethodInfo.GetCurrentMethod() in
        /// methods that are only supported in SQL.
        /// </summary>
        /// <param name="methodBase"></param>
        public static void ThrowOnlyForSql(MethodBase methodBase)
        {
            throw Error.SqlMethodOnlyForSql(methodBase);
        }
    }
}
