using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEBAPP_ASP.NET_.NET_FRAMEWORK_CS_MVC.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class ClientJSONModel
    {
        public DateTime _Horodatage { get; set; }
        public string Admin { get; set; }
        public string Adresse1 { get; set; }
        public string Adresse2 { get; set; }
        public string Adresse3 { get; set; }
        public bool CalculAutoCoordBancaires { get; set; }
        public string CleHachageEDI { get; set; }
        public string CleRIB { get; set; }
        public string CodeApe { get; set; }
        public string CodeBanque { get; set; }
        public string CodeBicswift { get; set; }
        public string CodeCatalogue { get; set; }
        public string CodeClient { get; set; }
        public string CodeDevise { get; set; }
        public string CodeGuichet { get; set; }
        public string Comp_Comptable { get; set; }
        public string CP { get; set; }
        public DateTime DateCreation { get; set; }
        public DateTime DateMAJ { get; set; }
        public string Domiciliation { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public string FTPDossierAParserEDI { get; set; }
        public string FTPMotDePasseEDI { get; set; }
        public string FTPUriEDI { get; set; }
        public string FTPUtilisateurEDI { get; set; }
        public string GLN { get; set; }
        public string iban { get; set; }
        public string Nom { get; set; }
        public bool NonSoumisTVA { get; set; }
        public string NumeroCompte { get; set; }
        public string NumeroSiret { get; set; }
        public string Pays { get; set; }
        public int RefClient { get; set; }
        public string Reglement { get; set; }
        public bool RelanceFacture { get; set; }
        public bool SoumisTVADOM { get; set; }
        public string Statut { get; set; }
        public bool TarifParQte { get; set; }
        public double TauxRemise { get; set; }
        public string Tel { get; set; }
        public string TitulaireCompte { get; set; }
        public string TVA_Intra { get; set; }
        public string TypePaiement { get; set; }
        public string Ville { get; set; }
        public string Web { get; set; }
        public int EXP_Compteur { get; set; }
        public string EXP_CpVille { get; set; }
        public string EXP_Crpar { get; set; }
        public DateTime EXP_DateDernierAvoir { get; set; }
        public DateTime EXP_DateDernierBL { get; set; }
        public DateTime EXP_DateDernierDevis { get; set; }
        public DateTime EXP_DateDerniereCommande { get; set; }
        public DateTime EXP_DateDerniereFacture { get; set; }
        public string EXP_IBAN_FORMAT { get; set; }
        public int EXP_IdylisCompteurLigne { get; set; }
        public double EXP_MontantDuClient { get; set; }
        public double EXP_MontantRestantDU1Mois { get; set; }
        public double EXP_MontantRestantDU2Mois { get; set; }
        public double EXP_MontantRestantDU3Mois { get; set; }
        public double EXP_MontantRestantDU4Mois { get; set; }
        public double EXP_MontantRestantDU5Mois { get; set; }
        public double EXP_MontantRestantDUPlus5Mois { get; set; }
        public double EXP_MontantRestantDUTotalMois { get; set; }
        public double EXP_MontantRestantDUTotalSansAvoirsMois { get; set; }
        public string EXP_Statut { get; set; }
        public string EXP_StatutCRM { get; set; }
        public double EXP_TotalMontantRestant { get; set; }
        public double EXP_TotalMontantRestantRelance { get; set; }
        public string EXP_TYPE_NONSOUMISTVA { get; set; }
    }

    public class Root
    {
        public List<ClientJSONModel> FB_Clients { get; set; }
    }

}