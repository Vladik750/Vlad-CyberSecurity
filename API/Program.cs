using System;
using RestSharp;

namespace API
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Client myClient = new Client();
            string parameter = "name";
            AskUser askId = new AskUser("Enter " + parameter + ": ");
            IGetUserInput consoleInput = new GetConsoleInput();

            IRestRequest myRequest = new RestRequest();
            IBuildRequest build = new ManageRequest();
            myRequest = build.BuildRequest(consoleInput, myRequest);
            IMakeRequest makeRequest = new ManageRequest();
            IRestResponse resp = makeRequest.MakeRequest(myClient, myRequest);

            IShowResponse consoleResponse = new ResponseToConsole();
            consoleResponse.ShowResponse(resp);

            /*string url = "https://swapi.dev/api/people";
            RestClient client = new RestClient(url);
            var request = new RestRequest();
            request.AddParameter("search", "C-3PO");
            var response = client.Get(request);

            Console.WriteLine(response.Content.ToString());*/

        }
    }
}
