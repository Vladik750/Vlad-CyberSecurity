using System;
using System.Collections.Generic;
using System.Text;

namespace API
{
    class Respond
    {
        public string text;
        public object respondObject;
        public Request request;

        public Respond(string text, object respondObject, Request request )
        {
            this.text = text;
            this.respondObject = respondObject;
            this.request = request;
        }
    }
}
