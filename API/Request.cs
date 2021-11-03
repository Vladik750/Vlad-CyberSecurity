using System;
using System.Collections.Generic;
using System.Text;

namespace API
{
    class Request
    {
        public string name;
        public Server server;

        public Request(RequestBuilder requestBuilder)
        {
            this.name = requestBuilder.name;
            this.server = requestBuilder.server;
        }

    }

    class RequestBuilder
    {
        public string name;
        public Server server;

        public RequestBuilder()
        {
            this.name = "Request.";
            this.server = null;
        }
        public RequestBuilder ToServer(Server server)
        {
            if(server == null)
            {
                throw new ArgumentException("Server should be passed!");
            }
            this.server = server;
            return this;
        }

        public RequestBuilder RequestName(string name)
        {
            this.name = name;
            return this;
        }

        public Request Build()
        {
            return new Request(this);
        }

    }
}
