using System;
using System.Collections.Generic;
using System.Text;

namespace API
{
    class User
    {
        private Respond respond;

        public void SetRespond(Respond respond)
        {
            this.respond = respond;
        }
            
        public void SendRequest(Server server)
        {
            Console.WriteLine("Enter request name:");
            string requestName = Console.ReadLine();
            Request request = new RequestBuilder().FromUser(this).ToServer(server).RequestName(requestName).Build();
            Console.WriteLine("Request Sent.\n");

            server.ManageRequest(request);
            server.SendRespond(this);
            ShowData();
        }

        public void ShowData()
        {
            respond.ShowRespond();
        }
    }
}
