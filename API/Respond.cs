using System;
using System.Collections.Generic;
using System.Text;

namespace API
{
    class Respond
    {
        public IData data;
        public User user;
        public string message;

        public Respond(RespondBuilder respondBuilder)
        {
            data = respondBuilder.data;
            user = respondBuilder.user;
            message = respondBuilder.message;
        }

        public void ShowRespond()
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

    class RespondBuilder
    {
        public IData data;
        public User user;
        public string message;

        public RespondBuilder()
        {
            message = "";
        }

        public RespondBuilder ToUser(User user)
        {
            this.user = user;
            return this;
        }

        public RespondBuilder WithData(IData data)
        {
            this.data = data;
            return this;
        }

        public RespondBuilder WithMessage(string message)
        {
            this.message = message;
            return this;
        }

        public Respond Build()
        {
            return new Respond(this);
        }
    }

}
