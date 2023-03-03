using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WEBAPP_ASP.NET_.NET_FRAMEWORK_CS_MVC.com.dailybiz.exe;

namespace WEBAPP_ASP.NET_.NET_FRAMEWORK_CS_MVC.Models
{
    public class AuthModel
    {
        public string codeabonne { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public IdylisapiSoapClient idylisapi { get; set; }
        public SessionIDHeader sessionID { get; set; }
        public string codeRetour { get; set; }
        public string errorMessage { get; private set; }

        public AuthModel() {  }
        public AuthModel(string codeabonne, string username, string password)
        {
            this.codeabonne = codeabonne;
            this.username = username;
            this.password = password;
            this.idylisapi = new IdylisapiSoapClient();
            this.sessionID = new SessionIDHeader();

            sessionID.SessionID = Authentification();
        }
        public string Authentification()
        {
            codeRetour = idylisapi.authentification1(codeabonne, username, password);
            string[] str = { "-1", "-2", "-3" };
            if (str.Contains(codeRetour))
            {
                MessageError();
            }
            return codeRetour;
        }
        private void MessageError()
        {
            switch (codeRetour)
            {
                case "-1":
                    errorMessage = "Identifiant ou mot de passe invalide.";
                    break;
                case "-2":
                    errorMessage = "Le client n’existe pas.";
                    break;
                case "-3":
                    errorMessage = "Le client géré n'appartient pas à cet utilisateur";
                    break;
                default:
                    break;
            }
        }
        public HttpCookie CookieSession()
        {
            HttpCookie cookieToken = new HttpCookie("TOKEN", codeRetour);
            cookieToken.Expires = DateTime.Now.AddMinutes(30);
            
            return cookieToken;
        }
    }
}