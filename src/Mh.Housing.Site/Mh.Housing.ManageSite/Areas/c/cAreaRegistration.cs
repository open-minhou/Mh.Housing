using System.Web.Mvc;

namespace Mh.Housing.ManageSite.Areas.c
{
    public class cAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "c";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "c_default",
                "c/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}