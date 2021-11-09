using System;
using System.Collections.Generic;
using System.Text;
using RestSharp;

namespace API
{
    class Client
    {
        public RestClient client;

        public Client()
        {
            client = new RestClient("https://jsonplaceholder.typicode.com/posts");
        }

        public void MakeRequest()
        {
            AskUser ask = new AskUser("Enter id: ");
            GetInput input = new GetInput();

            RestRequest request = new RestRequest();
            request.AddParameter("id", input.inputString);

            IRestResponse response = client.Get(request);

            Console.WriteLine(response.Content.ToString());
        }

        
    }
}
