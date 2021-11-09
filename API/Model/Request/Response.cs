using System;
using System.Collections.Generic;
using System.Text;

namespace API
{
    class Response
    {
        public IData data;
        public User user;
        public string message;

        public Response(ResponseBuilder respondBuilder)
        {
            data = respondBuilder.data;
            user = respondBuilder.user;
            message = respondBuilder.message;
        }

        //Writes the data of an object 
        public void ShowResponse()
        {
            if(data != null)
            {
                Console.WriteLine(message);
                data.ShowData();   
            }
            else
            {
                Console.WriteLine(message);
            }
            
        }
    }

    class ResponseBuilder
    {
        public IData data;
        public User user;
        public string message;

        public ResponseBuilder()
        {
            message = "";
        }

        public ResponseBuilder ToUser(User user)
        {
            this.user = user;
            return this;
        }

        public ResponseBuilder WithData(IData data)
        {
            this.data = data;
            return this;
        }

        public ResponseBuilder WithMessage(string message)
        {
            this.message = message;
            return this;
        }

        public Response Build()
        {
            return new Response(this);
        }
    }

}
