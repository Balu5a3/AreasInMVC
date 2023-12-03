using System.Web.Mvc;

namespace Areas.Areas.Balu
{
    public class BaluAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Balu";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Balu_default",
                "Balu/{controller}/{action}/{id}",
                new { controller = "Hello", action = "Index", id = UrlParameter.Optional },
                namespaces : new[] { "Areas.Areas.Balu.Controllers"}
            );
        }
    }
}