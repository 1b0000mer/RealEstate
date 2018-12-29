using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RealEstateWebsite.Areas.Censor
{
    public class CensorAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Censor";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Censor_default",
                "Censor/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}