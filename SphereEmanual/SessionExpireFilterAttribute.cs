using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace SphereEmanual
{
    public class SessionExpire: ActionFilterAttribute 
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.RouteData.GetRequiredString("controller").Equals("UserAccount", StringComparison.CurrentCultureIgnoreCase)
                && filterContext.RouteData.GetRequiredString("action").Equals("Login", StringComparison.CurrentCultureIgnoreCase))
            {
                return;
            }

            var ctx = HttpContext.Current;

            // check if session is supported
            if (ctx.Session != null)
            {
                // check if a new session id was generated
                //if (ctx.Session.IsNewSession)
                //{
                    // If it says it is a new session, but an existing cookie exists, then it must
                    // have timed out
                    //var sessionCookie = ctx.Request.Headers["Cookie"];
                    //if ((userGroup == null) && (sessionCookie.IndexOf("ASP.NET_SessionId", StringComparison.Ordinal) >= 0))  
                    var userGroup = ctx.Session["UserGroup"];
                    if (((userGroup == null) && (!ctx.Session.IsNewSession)) || (ctx.Session.IsNewSession))
                    {
                        FormsAuthentication.SignOut();
                        ctx.Session.RemoveAll();
                        ctx.Session.Clear();
                        ctx.Session.Abandon();
                        ctx.Response.Redirect("~/UserAccount/Login");
                    }
                //}
            }
            base.OnActionExecuting(filterContext);
        }
    }
}