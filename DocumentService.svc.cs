using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WebStar
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class DocumentService : IDocumentService
    {
        private deathstarEntities DeathStar; 

        public DocumentService()
        {
            Init();
        }

        private void Init()
        {
           DeathStar = new deathstarEntities();
        }

        public string GetFullDocumentList()
        {
            return "Documents";
        }

        public List<Document> GetDocumentsByType(string docType)
        {
            List<Document> docsList = new List<Document>();
            deathstarEntities DeathStar = new deathstarEntities();

            List<string> docs = from d in DeathStar.DocumentTypes select d;

            return docsList;
        }

        public List<string> GetDocumentTypes()
        {
            List<string> doctypes = new List<string>();

            return doctypes;

        }

        public string SaveNewDocument(string name, string type)
        {
            string doc = string.Empty;

            return doc;
        }

        public string ModifyDocument(string name)
        {
            string doc = string.Empty;

            return doc;
        }

        public string DeleteDocument(string name)
        {
            string doc = string.Empty;

            return doc;
        }
    }
}
