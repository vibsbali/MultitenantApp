using System.Web.Routing;

namespace MutlitenantApp.Services
{
    class TenantIdentifierStrategy : ITenantIdentifierStrategy
    {
        public string GetCurrentTenant(RequestContext context)
        {
            if (context.HttpContext.Request.Url != null) return context.HttpContext.Request.Url.Host.ToLower();
        }
    }
}