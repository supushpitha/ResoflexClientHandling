using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResoflexClientHandlingSystem.Role
{
    class ClientRequest
    {
        private Client reqClient;
        private int reqId;
        private string request;
        private DateTime addedDate;
        private bool importance;
        
        public ClientRequest(Client reqClient, int reqId, string request, bool importance)
        {
            this.ReqClient = reqClient;
            this.ReqId = reqId;
            this.Request = request;
            this.AddedDate = DateTime.Now;
            this.Importance = importance;
        }

        public ClientRequest(Client reqClient, string request, bool importance)
        {
            this.ReqClient = reqClient;
            this.Request = request;
            this.AddedDate = DateTime.Now;
            this.Importance = importance;
        }

        public Client ReqClient { get => reqClient; set => reqClient = value; }
        public int ReqId { get => reqId; set => reqId = value; }
        public string Request { get => request; set => request = value; }
        public bool Importance { get => importance; set => importance = value; }
        public DateTime AddedDate { get => addedDate; set => addedDate = value; }
    }
}
