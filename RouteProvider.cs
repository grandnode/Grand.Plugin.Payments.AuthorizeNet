using System.Web.Mvc;
using System.Web.Routing;
using Grand.Web.Framework.Mvc.Routes;

namespace Grand.Plugin.Payments.AuthorizeNet {
    public partial class RouteProvider : IRouteProvider {
        public void RegisterRoutes(RouteCollection routes) {
            //IPN
            routes.MapRoute("Plugin.Payments.AuthorizeNet.IPNHandler",
                 "Plugins/PaymentAuthorizeNet/IPNHandler",
                 new { controller = "PaymentAuthorizeNet", action = "IPNHandler" },
                 new[] { "Grand.Plugin.Payments.AuthorizeNet.Controllers" }
            );
        }
        public int Priority {
            get {
                return 0;
            }
        }
    }
}
