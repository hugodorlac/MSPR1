using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEBAPP_ASP.NET_.NET_FRAMEWORK_CS_MVC.Models;

namespace WEBAPP_ASP.NET_.NET_FRAMEWORK_CS_MVC.Controllers
{
    //[RoutePrefix("login")]
    public class AuthController : Controller
    {

        AuthModel model = new AuthModel();

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string codeabonne, string username, string password)
        {
            model = new AuthModel(codeabonne, username, password);
            string codeRetour = model.Authentification();
            string[] str = { "-1", "-2", "-3" };
            if (str.Contains(codeRetour))
            {
                model = new AuthModel();
                return View();
            }
            else
            {
                Response.Cookies.Add(model.CookieSession());
                TempData["sessionIDHeader"] = model.sessionID;
                return RedirectToAction("Index", "Client");
            }
        }
    }
}