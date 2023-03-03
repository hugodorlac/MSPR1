using System;
using System.Web.Mvc;
using WEBAPP_ASP.NET_.NET_FRAMEWORK_CS_MVC.com.dailybiz.exe;
using WEBAPP_ASP.NET_.NET_FRAMEWORK_CS_MVC.Models;

namespace WEBAPP_ASP.NET_.NET_FRAMEWORK_CS_MVC.Controllers
{
    public class ClientApiController : Controller
    {
        FicheClientModel model = new FicheClientModel();

        [Route("getClient/{codeClient}")]
        public string GetClient(string codeClient)
        {
            model = new FicheClientModel(codeClient);
            SessionIDHeader sessionIDHeader = TempData.Peek("sessionIDHeader") as SessionIDHeader;
            return model.GetClientJSON(sessionIDHeader, "FB_Clients", $"CODECLIENT='{model.codeClient}'", "DATECREATION ASC", "0");
        }

        [Route("addClient")]
        public string AddClient(ClientJSONModel model)
        {
            System.Xml.Serialization.XmlSerializer XmlString = new System.Xml.Serialization.XmlSerializer(model.GetType());
            SessionIDHeader sessionIDHeader = TempData.Peek("sessionIDHeader") as SessionIDHeader;
            XmlString.Serialize(Console.Out, model);
            Console.WriteLine();
            Console.ReadLine();
            return ""; // model.AddClient(sessionIDHeader, );
        }

        [Route("updateClient/{codeClient}")]
        public string UpdateClient(string codeClient)
        {
            model = new FicheClientModel(codeClient);
            SessionIDHeader sessionIDHeader = TempData.Peek("sessionIDHeader") as SessionIDHeader;
            return model.GetClientJSON(sessionIDHeader, "FB_Clients", $"CODECLIENT='{model.codeClient}'", "DATECREATION ASC", "0");
        }

        [Route("deleteClient/{codeClient}")]
        public string DeleteClient(string codeClient)
        {
            model = new FicheClientModel(codeClient);
            SessionIDHeader sessionIDHeader = TempData.Peek("sessionIDHeader") as SessionIDHeader;
            return model.DeleteClient(sessionIDHeader, "FB_Clients", $"{model.codeClient}");
        }

    }
}