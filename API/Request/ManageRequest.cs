using System;
using System.Collections.Generic;
using System.Text;
using RestSharp;

namespace API
{
    class ManageRequest : IMakeRequest, IBuildRequest
    {
        IRestRequest IBuildRequest.BuildRequest(IGetUserInput input, IRestRequest request /*,string parameter*/)
        {
            string attribute = input.GetUserInput();
            return request.AddParameter(/*parameter*/"search", attribute);            
        }

        IRestResponse IMakeRequest.MakeRequest(Client client, IRestRequest request)
        {
            return client.client.Get(request);
        }
    }
}
