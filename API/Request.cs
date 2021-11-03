using System;
using System.Collections.Generic;
using System.Text;

namespace API
{
    class Request
    {
        public string name;
        public Server server;
        public User user;

        public Request(RequestBuilder requestBuilder)
        {
            this.name = requestBuilder.name;
            this.server = requestBuilder.server;
            this.user = requestBuilder.user;
        }

       
    }

    class RequestBuilder
    {
        public string name;
        public Server server;
        public User user;

        public RequestBuilder()
        {
            this.name = "";
            this.server = null;
            this.user = null;
        }

        public RequestBuilder FromUser(User user)
        {
            this.user = user;
            return this;
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
