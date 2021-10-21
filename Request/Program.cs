using System;

namespace Request
{
    class User
    {
        private string username;
        private string password;
        private string firstName;
        private string lastName;
        private string email;

        public User(string username, string password, string firstName, string lastName, string email)
        {
            this.username = username;
            this.password = password;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
        }

        public void MakeRequest(string data)
        {
            Request req = new RequestBuilder(this, data).CheckUserName().CheckPassword().Build();
            Console.WriteLine("Request");
            Console.WriteLine($"Check username: {req.usernameChecked}");
            Console.WriteLine($"Check password: {req.passwordChecked}");
            if ((req.usernameChecked) && (req.passwordChecked))
            {
                Console.WriteLine(data);
                Console.WriteLine($"First Name: {firstName}");
                Console.WriteLine($"Last Name: {lastName}");
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }

    }

    class Request
    {
        protected User user;
        protected string data;
        public bool usernameChecked;
        public bool passwordChecked;

        public Request(RequestBuilder requestBuilder)
        {
            this.user = requestBuilder.user;
            this.data = requestBuilder.data;
            this.usernameChecked = requestBuilder.usernameChecked;
            this.passwordChecked = requestBuilder.passwordChecked;
        }

    }

    class RequestBuilder
    {
        public User user;
        public string data;
        public bool usernameChecked;
        public bool passwordChecked;

        public RequestBuilder(User user, string data)
        {
            this.user = user;
            this.data = data;
            this.usernameChecked = false;
            this.passwordChecked = false;
        }

        public RequestBuilder CheckUserName()
        {
            usernameChecked = true;
            return this;
        }

        public RequestBuilder CheckPassword()
        {
            passwordChecked = true;
            return this;
        }

        public Request Build()
        {
            return new Request(this);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Bogrov570", "pass1234", "Ivan", "Bogrov", "email@email");
            string data = "Request Sent.";
            user.MakeRequest(data);
        }
    }
}
