using System.Web.Routing;

namespace MutlitenantApp.Services
{
    interface ITenantIdentifierStrategy
    {
        string GetCurrentTenant(RequestContext context);
    }
}
