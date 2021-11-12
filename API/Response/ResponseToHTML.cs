using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace API
{
    class ResponseToHTML : IShowResponse
    {
        private string path = @"C:\Users\USER\source\repos\API\index.html";
        void IShowResponse.ShowResponse(IRestResponse response)
        {
            /// Create a file and write a response to it.
            FileStream fs = File.Create(path);
            fs.Close();
            StreamWriter streamWriter = new StreamWriter(path);
            streamWriter.WriteLine("<html>");
            streamWriter.WriteLine("<head>");
            streamWriter.WriteLine("  <title>HTML-Document</title>");
            streamWriter.WriteLine("  <meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\" />");
            streamWriter.WriteLine("</head>");
            streamWriter.WriteLine("<body>");
            streamWriter.WriteLine(response.Content.ToString());
            streamWriter.WriteLine("</body>");
            streamWriter.WriteLine("</html>");
            streamWriter.Close();
            StreamReader sr = File.OpenText(path);
        }
    }
}
