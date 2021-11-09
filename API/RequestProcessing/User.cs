using System;
using System.Collections.Generic;
using System.Text;

namespace API
{
    class User
    {
        private Response response;

        public void SetResponse(Response response)
        {
            this.response = response;
        }
            
        public void SendRequest(Server server)
        {
            Console.WriteLine("Enter request name:");
            string requestName = Console.ReadLine();
            Request request = new RequestBuilder().FromUser(this).ToServer(server).RequestName(requestName).Build();
            Console.WriteLine("Request Sent.\n");

            server.ManageRequest(request);
            server.SendResponse(this);
            ShowData();
        }

        public void ShowData()
        {
            response.ShowResponse();
        }
    }
}
