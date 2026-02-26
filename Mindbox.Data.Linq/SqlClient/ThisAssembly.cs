using System.Reflection;

namespace System.Data.Linq.SqlClient
{
    public static class ThisAssembly
    {
        public static string InformationalVersion
        {
            get { return Assembly.GetCallingAssembly().GetName().Version.ToString(); }
        }
    }
}
