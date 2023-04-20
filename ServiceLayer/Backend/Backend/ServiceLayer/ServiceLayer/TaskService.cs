using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ServiceLayer
{
    /// <summary>
    /// the interface of the tasks
    /// </summary>
    class TaskService
    {
         
        private TskFacade taskFacade;
        /// <summary>
        /// input:string of title and description list of int to set color and datetime for due date
        /// output:json string of the respons
        /// 
        /// create tasks
        /// </summary>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="dueTime"></param>
        /// <param name="label"></param>
        /// <returns></returns>
        public string create(string title, string description, DateTime dueTime, List<int> label)
        {
            return JsonSerializer.Serialize(new Response("Not impleneted yet"));
        }
        /// <summary>
        /// input:int tasks id
        /// output:json string of the respons
        /// 
        /// deleting tasks
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string delete(int id)
        {
            return JsonSerializer.Serialize(new Response("Not impleneted yet"));
        }

        /// <summary>
        /// input:int tasks id and string of new title
        /// output:json string of the respons
        /// 
        /// changing the title
        /// </summary>
        /// <param name="id"></param>
        /// <param name="newTitle"></param>
        /// <returns></returns>
        public string changeTitle(int id, string newTitle)
        {
            return JsonSerializer.Serialize(new Response("Not impleneted yet"));
        }
        /// <summary>
        /// input:int tasks id and string of new description
        /// output:json string of the respons
        /// 
        /// changing the description
        /// </summary>
        /// <param name="id"></param>
        /// <param name="newDescription"></param>
        /// <returns></returns>
        public string changeDescription(int id, string newDescription)
        {
            return JsonSerializer.Serialize(new Response("Not impleneted yet"));
        }
        /// <summary>
        /// input:int tasks id and string of new title
        /// output:json string of the respons
        /// 
        /// changing the title
        /// </summary>
        /// <param name="id"></param>
        /// <param name="newDueTime"></param>
        /// <returns></returns>
        public string changeDue(int id, DateTime newDueTime)
        {
            return JsonSerializer.Serialize(new Response("Not impleneted yet"));
        }
        /// <summary>
        /// input:int tasks id and new id
        /// output:json string of the respons
        /// 
        /// changing the id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="newId"></param>
        /// <returns></returns>
        public string changeId(int id, int newId)
        {
            return JsonSerializer.Serialize(new Response("Not impleneted yet"));
        }

        /// <summary>
        /// input:int tasks id 
        /// output:json string of the respons
        /// 
        /// gets the time left for the task
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string getTimeLeft(int id)
        {
            return JsonSerializer.Serialize(new Response("Not impleneted yet"));
        }
        /// <summary>
        /// input:int tasks id and list of ints of new lable
        /// output:json string of the respons
        /// 
        /// changing the lable
        /// </summary>
        /// <param name="id"></param>
        /// <param name="newLabel"></param>
        /// <returns></returns>
        public string changeLabel(int id, List<int> newLabel)
        {
            return JsonSerializer.Serialize(new Response("Not impleneted yet"));
        }

    }
}
