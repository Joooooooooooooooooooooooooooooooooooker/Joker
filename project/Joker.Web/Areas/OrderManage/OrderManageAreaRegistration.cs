using System.Web.Mvc;

namespace Joker.Web.Areas.OrderManage
{
    public class OrderManageAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "OrderManage";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                this.AreaName + "_Default",
                this.AreaName + "/{controller}/{action}/{id}",
                new { area = this.AreaName, controller = "Home", action = "Index", id = UrlParameter.Optional },
                new string[] { "Joker.Web.Areas." + this.AreaName + ".Controllers" }
            );
        }
    }
}