using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ServiceLayer
{
    class UserService
    {

        private UserFacade userFacade;

        public string register(string email, string password)
        {
            return JsonSerializer.Serialize(new Response("Not impleneted yet"));
        }

        public string login(string email, string password)
        {
            return JsonSerializer.Serialize(new Response("Not impleneted yet"));
        }
        public string logout(string email)
        {
            return JsonSerializer.Serialize(new Response("Not impleneted yet"));
        }


        public string getBoards(string email)
        {
            return JsonSerializer.Serialize(new Response("Not impleneted yet"));
        }

        public string createBoard(string email, string boardname)
        {
            return JsonSerializer.Serialize(new Response("Not impleneted yet"));
        }

        public string deleteBoard(string email, string boardname)
        {
            return JsonSerializer.Serialize(new Response("Not impleneted yet"));
        }
    }
}
