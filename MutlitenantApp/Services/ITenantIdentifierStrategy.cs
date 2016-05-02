using System.Web.Routing;

namespace MutlitenantApp.Services
{
    public interface ITenantIdentifierStrategy
    {
        string GetCurrentTenant(RequestContext context);
    }
}
