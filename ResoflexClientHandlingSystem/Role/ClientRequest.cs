using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResoflexClientHandlingSystem.Role
{
    class ClientRequest
    {
        private int clientId;
        private int reqId;
        private string request;
        private string note;
        private bool importance;
        
        public ClientRequest(int clientId, int reqId, string request, string note, bool importance)
        {
            this.ClientId = clientId;
            this.ReqId = reqId;
            this.Request = request;
            this.Note = note;
            this.Importance = importance;
        }

        public ClientRequest(int clientId, string request, string note, bool importance)
        {
            this.ClientId = clientId;
            this.Request = request;
            this.Note = note;
            this.Importance = importance;
        }

        public int ClientId { get => clientId; set => clientId = value; }
        public int ReqId { get => reqId; set => reqId = value; }
        public string Request { get => request; set => request = value; }
        public string Note { get => note; set => note = value; }
        public bool Importance { get => importance; set => importance = value; }
    }
}
