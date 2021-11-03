using System;
using System.Collections.Generic;
using System.Text;

namespace API
{
    class Server
    {
        public Response response;
        public List<IData> dataList;

        public Server()
        {
            response = null;
            dataList = null;
        }
        public Server(IData dataItem)
        {
            this.dataList.Add(dataItem);
        }

        public Server(List<IData> dataList)
        {
            this.dataList = dataList;
        }

        public void ManageRequest(Request request)
        {
            if (request.name == "Get person")
            {
                if (dataList == null)
                {
                    response = new ResponseBuilder().WithMessage("Server is empty!").Build();
                }
                else
                {
                    for (int i = 0; i < dataList.Count; i++)
                    {
                        if (dataList[i] is Person)
                        {
                            response = new ResponseBuilder().WithData(dataList[i]).ToUser(request.user).WithMessage("Successful!").Build();
                            break;
                        }
                        response = new ResponseBuilder().WithMessage("Server didn`t find such item!").Build();
                    }
                }

            }
            else if (request.name == "Get pet")
            {
                if (dataList == null)
                {
                    response = new ResponseBuilder().WithMessage("Server is empty!").Build();
                }
                else
                {
                    for (int i = 0; i < dataList.Count; i++)
                    {
                        if (dataList[i] is Pet)
                        {
                            response = new ResponseBuilder().WithData(dataList[i]).ToUser(request.user).WithMessage("Successful!").Build();
                            break;
                        }
                        response = new ResponseBuilder().WithMessage("Server didn`t find such item!").Build();
                    }
                }

            }
            else
            {
                response = new ResponseBuilder().WithMessage("Unknown request!").Build();
            }

        }

        public void SendResponse(User user)
        {
            user.SetResponse(response);
        }

    }
}
