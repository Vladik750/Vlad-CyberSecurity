using System;
using System.Collections.Generic;
using System.Text;

namespace API
{
    class Server
    {
        public Respond respond;
        public List<IData> dataList;

        public Server()
        {
            respond = null;
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
                    respond = new RespondBuilder().WithMessage("Server is empty!").Build();
                }
                else
                {
                    for (int i = 0; i < dataList.Count; i++)
                    {
                        if (dataList[i] is Person)
                        {
                            respond = new RespondBuilder().WithData(dataList[i]).ToUser(request.user).WithMessage("Successful!").Build();
                            break;
                        }
                        respond = new RespondBuilder().WithMessage("Server didn`t find such item!").Build();
                    }
                }

            }
            if (request.name == "Get pet")
            {
                if (dataList == null)
                {
                    respond = new RespondBuilder().WithMessage("Server is empty!").Build();
                }
                else
                {
                    for (int i = 0; i < dataList.Count; i++)
                    {
                        if (dataList[i] is Pet)
                        {
                            respond = new RespondBuilder().WithData(dataList[i]).ToUser(request.user).WithMessage("Successful!").Build();
                            break;
                        }
                        respond = new RespondBuilder().WithMessage("Server didn`t find such item!").Build();
                    }
                }

            }
            /* else
             {
                 respond = new RespondBuilder().WithMessage("Unknown request!").Build();
             }*/
        }

        public void SendRespond(User user)
        {
            user.SetRespond(respond);
        }

    }
}
