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
    /// the interface for the user
    /// </summary>
    class UserService
    {

        private UserFacade userFacade;
        /// <summary>
        /// input:string of email and password
        /// output:json string of the respons
        /// 
        /// creating the user in the system
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public string register(string email, string password)
        {
            return JsonSerializer.Serialize(new Response("Not impleneted yet"));
        }
        /// <summary>
        ///  input:string of email and password
        /// output:json string of the respons
        /// 
        /// entering the system for the user
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public string login(string email, string password)
        {
            return JsonSerializer.Serialize(new Response("Not impleneted yet"));
        }
        /// <summary>
        ///  input:string of email
        /// output:json string of the respons
        /// 
        /// loging out of the user
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public string logout(string email)
        {
            return JsonSerializer.Serialize(new Response("Not impleneted yet"));
        }
        /// <summary>
        ///  input:string of email
        /// output:json string of the respons
        /// 
        /// geting the list of all inprog tasks
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public string getInProgressTasks(string email)
        {
            return JsonSerializer.Serialize(new Response("Not impleneted yet"));
        }
        /// <summary>
        /// input:string of email
        /// output:json string of the respons
        /// 
        /// geting the list of all boards
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public string getBoards(string email)
        {
            return JsonSerializer.Serialize(new Response("Not impleneted yet"));
        }
        /// <summary>
        /// input:string of email and boardname
        /// output:json string of the respons
        /// 
        /// creating boards for the user
        /// </summary>
        /// <param name="email"></param>
        /// <param name="boardname"></param>
        /// <returns></returns>
        public string createBoard(string email, string boardname)
        {
            return JsonSerializer.Serialize(new Response("Not impleneted yet"));
        }
        /// <summary>
        /// input:string of email and boardname
        /// output:json string of the respons
        /// 
        /// delete boards for the user
        /// </summary>
        /// <param name="email"></param>
        /// <param name="boardname"></param>
        /// <returns></returns>
        public string deleteBoard(string email, string boardname)
        {
            return JsonSerializer.Serialize(new Response("Not impleneted yet"));
        }
    }
}
