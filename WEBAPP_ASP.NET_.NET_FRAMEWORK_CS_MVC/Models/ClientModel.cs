using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;
using System.Xml.Serialization;
using WEBAPP_ASP.NET_.NET_FRAMEWORK_CS_MVC.com.dailybiz.exe;

namespace WEBAPP_ASP.NET_.NET_FRAMEWORK_CS_MVC.Models
{
    // using System.Xml.Serialization;
    // XmlSerializer serializer = new XmlSerializer(typeof(FICHE));
    // using (StringReader reader = new StringReader(xml))
    // {
    //    var test = (FICHE)serializer.Deserialize(reader);
    // }

    [XmlRoot(ElementName = "FICHE")]
    public class ClientModel
    {
        public IdylisapiSoapClient apiclient;

        [XmlElement(ElementName = "CODECLIENT")]
        public string CODECLIENT { get; set; }

        [XmlElement(ElementName = "NOM")]
        public string NOM { get; set; }
        // ---------------------------------------------------------

        [XmlElement(ElementName = "ADRESSE1")]
        public string ADRESSE1 { get; set; }

        [XmlElement(ElementName = "ADRESSE2")]
        public string ADRESSE2 { get; set; }

        [XmlElement(ElementName = "ADRESSE3")]
        public string ADRESSE3 { get; set; }

        [XmlElement(ElementName = "CP")]
        public string CP { get; set; }


        [XmlElement(ElementName = "VILLE")]
        public string VILLE { get; set; }

        [XmlElement(ElementName = "PAYS")]
        public string PAYS { get; set; }

        [XmlElement(ElementName = "TEL")]
        public string TEL { get; set; }

        [XmlElement(ElementName = "FAX")]
        public string FAX { get; set; }

        [XmlElement(ElementName = "EMAIL")]
        public string EMAIL { get; set; }
        // ---------------------------------------------------------

        [XmlElement(ElementName = "EXP_TYPE_NONSOUMISTVA")]
        public string EXPTYPENONSOUMISTVA { get; set; }

        [XmlElement(ElementName = "TVA_INTRA")]
        public int TVAINTRA { get; set; }
        // ---------------------------------------------------------

        [XmlElement(ElementName = "COMP_COMPTABLE")]
        public string COMPCOMPTABLE { get; set; }
        // ---------------------------------------------------------

        [XmlElement(ElementName = "STATUT")]
        public string STATUT { get; set; }

        [XmlElement(ElementName = "TYPESOCIETE")]
        public string TYPESOCIETE { get; set; }

        [XmlElement(ElementName = "CODEAPE")]
        public string CODEAPE { get; set; }

        [XmlElement(ElementName = "NUMEROSIRET")]
        public string NUMEROSIRET { get; set; }

        [XmlElement(ElementName = "WEB")]
        public string WEB { get; set; }
        // ---------------------------------------------------------

        [XmlElement(ElementName = "DATECREATION")]
        public DateTime DATECREATION { get; set; }

        [XmlElement(ElementName = "DATEMAJ")]
        public DateTime DATEMAJ { get; set; }



        [XmlElement(ElementName = "REFCLIENT")]
        public int REFCLIENT { get; set; }

        public ClientModel()
        {
            
        }
        public ClientModel(string codeClient)
        {
            this.CODECLIENT = codeClient;
            this.apiclient = new IdylisapiSoapClient();
        }
        public string GetClient(SessionIDHeader sessionIDHeader, string nomtable, string critere, string ordre, string soustables) {
            return apiclient.LireTableJSON(sessionIDHeader, nomtable, critere, ordre, soustables);
        }
        public string DeleteClient(SessionIDHeader sessionIDHeader, string nomtable, string codeClient)
        {
            return apiclient.SuppresionTable(sessionIDHeader, nomtable, codeClient);
        }
    }


}