using System.Web.Mvc;

namespace Mh.Housing.ManageSite.Areas.b
{
    public class bAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "b";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "b_default",
                "b/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}