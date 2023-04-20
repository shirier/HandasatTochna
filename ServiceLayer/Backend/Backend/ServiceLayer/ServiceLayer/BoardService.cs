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
    /// interface for the boards
    /// </summary>
    class BoardService
    {
        private BoardFacade boardFacade;
        /// <summary>
        /// input:string of email and boardname
        /// output:json string of the respons
        /// 
        /// creating boards
        /// </summary>
        /// <param name="email"></param>
        /// <param name="boardname"></param>
        /// <returns></returns>
        public string create(string email, string boardname)
        {
            return JsonSerializer.Serialize(new Response("Not impleneted yet"));
        }
        /// <summary>
        /// input:string of email and boardname
        /// output:json string of the respons
        /// 
        /// delete boards
        /// </summary>
        /// <param name="email"></param>
        /// <param name="boardname"></param>
        /// <returns></returns>
        public string delete(string email, string boardname)
        {
            return JsonSerializer.Serialize(new Response("Not impleneted yet"));
        }
        /// <summary>
        /// input:string of email, boardname, title and description
        /// output:json string of the respons
        /// 
        /// creating tasks
        /// </summary>
        /// <param name="email"></param>
        /// <param name="boardname"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <returns></returns>
        public string createTask(string email, string boardname, string title, string description)
        {
            return JsonSerializer.Serialize(new Response("Not impleneted yet"));
        }
        /// <summary>
        /// input:string of email and boardname and int of task id
        /// output:json string of the respons
        /// 
        /// deleting tasks
        /// </summary>
        /// <param name="email"></param>
        /// <param name="boardname"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public string deleteTask(string email, string boardname, int id)
        {
            return JsonSerializer.Serialize(new Response("Not impleneted yet"));
        }
        /// <summary>
        /// input:int of the limit of this column
        /// output:json string of the respons
        /// 
        /// limiting this column
        /// </summary>
        /// <param name="limit"></param>
        /// <returns></returns>
        public string setBacklogLimit(int limit)
        {
            return JsonSerializer.Serialize(new Response("Not impleneted yet"));
        }
        /// <summary>
        /// input:int of the limit of this column
        /// output:json string of the respons
        /// 
        /// limiting this column
        /// </summary>
        /// <param name="limit"></param>
        /// <returns></returns>
        public string setInProgressLimit(int limit)
        {
            return JsonSerializer.Serialize(new Response("Not impleneted yet"));
        }
        /// <summary>
        /// input:int of the limit of this column
        /// output:json string of the respons
        /// 
        /// limiting this column
        /// </summary>
        /// <param name="limit"></param>
        /// <returns></returns>
        public string setDoneLimit(int limit)
        {
            return JsonSerializer.Serialize(new Response("Not impleneted yet"));
        }
        /// <summary>
        /// input:string of email and boardname and int tasks id
        /// output:json string of the respons
        /// 
        /// moving tsks forward
        /// </summary>
        /// <param name="email"></param>
        /// <param name="boardname"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public string moveTask(string email, string boardname, int id)
        {
            return JsonSerializer.Serialize(new Response("Not impleneted yet"));
        }
        /// <summary>
        /// input:int of board id
        /// output:json string of the respons
        /// 
        /// getting the structure of the board
        /// </summary>
        /// <param name="boardId"></param>
        /// <returns></returns>
        public string getBoardAtributes(int boardId)
        {
            return JsonSerializer.Serialize(new Response("Not impleneted yet"));
        }
    }
}
