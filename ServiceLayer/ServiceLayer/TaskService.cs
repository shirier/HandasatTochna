using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace ServiceLayer
{
    class TaskService
    {
         
        private TaskFacade taskFacade;
        public string create(string title, string description, List<string> dueTime, List<int> label)
        {
            return JsonSerializer.Serialize(new Response("Not impleneted yet"));
        }
        public string delete(int id)
        {
            return JsonSerializer.Serialize(new Response("Not impleneted yet"));
        }


        public string changeTitle(int id, string newTitle)
        {
            return JsonSerializer.Serialize(new Response("Not impleneted yet"));
        }
        public string changeDescription(int id, string newDescription)
        {
            return JsonSerializer.Serialize(new Response("Not impleneted yet"));
        }
        public string changeDue(int id, List<string> newDueTime)
        {
            return JsonSerializer.Serialize(new Response("Not impleneted yet"));
        }
        public string changeId(int id, int newId)
        {
            return JsonSerializer.Serialize(new Response("Not impleneted yet"));
        }


        public string getTimeLeft(int id)
        {
            return JsonSerializer.Serialize(new Response("Not impleneted yet"));
        }
        public string changeLabel(int id, List<int> newLabel)
        {
            return JsonSerializer.Serialize(new Response("Not impleneted yet"));
        }

    }
}
