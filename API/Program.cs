using System;
using RestSharp;


namespace API
{
    class Program
    {
        static void Main(string[] args)
        {
            //string url = "https://jsonplaceholder.typicode.com/posts";
            //var client = new RestClient(url);

            Client myClient = new Client();
            //var request = new RestRequest();
            myClient.MakeRequest();
            //request.AddParameter("id", "4");

            //var response = client.Get(request);

            //Console.WriteLine(response.Content.ToString());
        }
    }
}
