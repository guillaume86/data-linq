using System.Collections;
using System.Linq.Expressions;

namespace System.Data.Linq.Provider
{
    using System.Data.Linq.Mapping;

    public interface IDataServices
    {
        DataContext Context { get; }
        MetaModel Model { get; }
        IDeferredSourceFactory GetDeferredSourceFactory(MetaDataMember member);
        object GetCachedObject(Expression query);
        bool IsCachedObject(MetaType type, object instance);
        object InsertLookupCachedObject(MetaType type, object instance);
        void OnEntityMaterialized(MetaType type, object instance);
    }

    public interface IDeferredSourceFactory
    {
        IEnumerable CreateDeferredSource(object instance);
        IEnumerable CreateDeferredSource(object[] keyValues);
    }
}
