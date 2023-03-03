using WEBAPP_ASP.NET_.NET_FRAMEWORK_CS_MVC.com.dailybiz.exe;

namespace WEBAPP_ASP.NET_.NET_FRAMEWORK_CS_MVC.Models
{
    public class FicheClientModel
    {
        public string codeClient;
        public string codeRetour;
        IdylisapiSoapClient idylisapi;

        public FicheClientModel(string codeClient) 
        { 
            this.codeClient = codeClient;
            this.idylisapi = new IdylisapiSoapClient();
        }

        public FicheClientModel() { }
        public string GetClient(SessionIDHeader sessionIDHeader, string nomtable, string critere, string ordre, string soustables, string pieceattache, string aveccompression)
        {
            codeRetour = idylisapi.LireTableSansCData(sessionIDHeader, nomtable, critere, ordre, soustables, pieceattache, aveccompression);
            return codeRetour;
        }
        public string GetClientJSON(SessionIDHeader sessionIDHeader, string nomtable, string critere, string ordre, string soustables)
        {
            return idylisapi.LireTableJSON(sessionIDHeader, nomtable, critere, ordre, soustables);
        }


        public string AddClient(SessionIDHeader sessionIDHeader, string XmlString)
        {
            codeRetour = idylisapi.InsererTableSession(sessionIDHeader.SessionID, XmlString);
            return codeRetour;
        }

        public string DeleteClient(SessionIDHeader sessionIDHeader, string nomtable, string codeClient)
        {
            codeRetour = idylisapi.SuppresionTableSession(sessionIDHeader.SessionID, nomtable, codeClient);
            return codeRetour;
        }
    }
}