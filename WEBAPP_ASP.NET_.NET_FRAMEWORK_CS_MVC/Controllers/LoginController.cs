using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEBAPP_ASP.NET_.NET_FRAMEWORK_CS_MVC.Models;

namespace WEBAPP_ASP.NET_.NET_FRAMEWORK_CS_MVC.Controllers
{
    public class LoginController : Controller
    {
        [Route("login1")]
        // GET: Login
        public ActionResult Index(AuthModel model)
        {
            if (Request.HttpMethod == "POST")
            {
                LoginModel loginModel = new LoginModel(model.codeabonne, model.username, model.password);
                if (loginModel.codeRetour == "2")
                {
                    return Redirect("~/client");
                } else
                {
                    return Redirect("~/login1");
                }
            }
            return View();
        }

        [Route("client1")]
        // GET: Client
        public ActionResult IndexClient()
        {
            return View();
        }
        [Route("client1/{id}")]
        public ActionResult FicheClient(int id)
        {
            ViewBag.Message = "Your connection page.";
            ViewBag.nRefClient = id;

            return View();
        }
    }
}