using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ServiceLayer
{
    class BoardService
    {
        private BoardFacade boardFacade;
        public string create(string email, string boardname)
        {
            return JsonSerializer.Serialize(new Response("Not impleneted yet"));
        }
        public string delete(string email, string boardname)
        {
            return JsonSerializer.Serialize(new Response("Not impleneted yet"));
        }
        public string createTask(string email, string boardname, string title, string description)
        {
            return JsonSerializer.Serialize(new Response("Not impleneted yet"));
        }
        public string deleteTask(string email, string boardname, int id)
        {
            return JsonSerializer.Serialize(new Response("Not impleneted yet"));
        }

        public string moveTask(string email, string boardname, int id)
        {
            return JsonSerializer.Serialize(new Response("Not impleneted yet"));
        }

        public string getBoardAtributes(int boardId)
        {
            return JsonSerializer.Serialize(new Response("Not impleneted yet"));
        }
    }
}
