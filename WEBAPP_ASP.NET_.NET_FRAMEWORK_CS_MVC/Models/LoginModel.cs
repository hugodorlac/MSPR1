namespace WEBAPP_ASP.NET_.NET_FRAMEWORK_CS_MVC.Models
{
    using com.dailybiz.exe;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;

    public class LoginModel
    {
        public string refUtilisateur { get; private set; }
        public string _codeabonne { get; set; }
        public string _username { get; set; }
        public string _password { get; set; }
        public IdylisapiSoapClient idylisapi { get; set; }
        public SessionIDHeader sessionID { get; set; }
        public string codeRetour { get; set; }
        public string errorMessage { get; private set; }

        public LoginModel()
        {

        }
        public LoginModel(string codeabonne, string username, string password)
        {
            this._codeabonne = codeabonne;
            this._username = username;
            this._password = password;
            this.idylisapi = new IdylisapiSoapClient();
            this.sessionID = new SessionIDHeader();

            Authentification();
        }

        public string Authentification()
        {
            string result = idylisapi.authentification1(_codeabonne, _username, _password);
            string[] str = { "-1", "-2", "-3" };
            if (str.Contains(result))
            {
                codeRetour = result;
            }
            else
            {
                codeRetour = "2";
                refUtilisateur = idylisapi.RefUtilisateur(sessionID);

            }
            MessageError();
            return result;
        }

        public void AddInSession(string authString)
        {
            sessionID.SessionID = authString;
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
    }
}