using System;
using System.IO;
using System.Web.Mvc;
using System.Xml.Serialization;
using WEBAPP_ASP.NET_.NET_FRAMEWORK_CS_MVC.com.dailybiz.exe;
using WEBAPP_ASP.NET_.NET_FRAMEWORK_CS_MVC.Models;

namespace WEBAPP_ASP.NET_.NET_FRAMEWORK_CS_MVC.Controllers
{
    public class ClientController : Controller
    {
        FicheClientModel ficheClientModel = new FicheClientModel();
        ClientJSONModel clientJSONModel = new ClientJSONModel();

        //[Route("client")]
        public ActionResult Index()
        {
            if (Request.Cookies.Get("TOKEN") != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Auth");
            }
        }

        [HttpPost]
        [MultipleButton(Argument = "Recherche", Name = "action")]
        public ActionResult Recherche(string codeClient)
        {
            if (Request.Cookies.Get("TOKEN") != null)
            {
                ClientModel clientModel = new ClientModel(codeClient);
                SessionIDHeader sessionIDHeader = TempData.Peek("sessionIDHeader") as SessionIDHeader;
                string critere = $"CODECLIENT='{clientModel.CODECLIENT}'";
                ViewBag.JsonString = clientModel.GetClient(sessionIDHeader, "FB_Clients", critere, "DATECREATION ASC", "0");
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Auth");
            }
        }

        [HttpPost]
        [MultipleButton(Argument = "Search", Name = "action")]
        public ActionResult Search(string codeClient)
        {
            if (Request.Cookies.Get("TOKEN") != null)
            {
                ficheClientModel = new FicheClientModel(codeClient);
                SessionIDHeader sessionIDHeader = TempData.Peek("sessionIDHeader") as SessionIDHeader;
                string critere = $"CODECLIENT='{ficheClientModel.codeClient}'";
                ViewBag.JsonString = (ficheClientModel.GetClientJSON(sessionIDHeader, "FB_Clients", critere, "DATECREATION ASC", "0"));

                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Auth");
            }
        }

        [Route("addClient")]
        public string AddClient(ClientJSONModel clientJSONModel)
        {
            System.Xml.Serialization.XmlSerializer XmlString = new System.Xml.Serialization.XmlSerializer(clientJSONModel.GetType());
            SessionIDHeader sessionIDHeader = TempData.Peek("sessionIDHeader") as SessionIDHeader;
            XmlString.Serialize(Console.Out, clientJSONModel);
            Console.WriteLine();
            Console.ReadLine();
            return ""; // model.AddClient(sessionIDHeader, );
        }

        [Route("updateClient/{codeClient}")]
        public string UpdateClient(string codeClient)
        {
            ficheClientModel = new FicheClientModel(codeClient);
            SessionIDHeader sessionIDHeader = TempData.Peek("sessionIDHeader") as SessionIDHeader;

            return ficheClientModel.GetClientJSON(sessionIDHeader, "FB_Clients", $"CODECLIENT='{ficheClientModel.codeClient}'", "DATECREATION ASC", "0");
        }
        [HttpPost]
        [MultipleButton(Argument = "Delete", Name = "action")]
        public string DeleteClient(string codeClient)
        {
            ClientModel clientModel = new ClientModel(codeClient);
            SessionIDHeader sessionIDHeader = TempData.Peek("sessionIDHeader") as SessionIDHeader;
            return clientModel.DeleteClient(sessionIDHeader, "FB_Clients", $"{codeClient}");
        }

        //[HttpPost]
        //[MultipleButton(Argument = "DeleteTest", Name = "action")]
        //public string DeleteClientTest(string codeClient)
        //{
        //    return codeClient;
        //}

    }
}