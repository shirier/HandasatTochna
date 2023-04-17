using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    class UserService
    {

        private UserFacade userFacade;

        //User related functions
        public string register(string username, string password, string mail)
        {
            throw new NotImplementedException();
        }

        public string login(string username, string password, string mail)
        {
            throw new NotImplementedException();
        }
        public string logout(string username)
        {
            throw new NotImplementedException();
        }




        //Task related functions
        public List<TaskService> GetINProgressTasks(string username)
        {
            throw new NotImplementedException();
        }



        //Board related functions
        public List<BoardService> GetBoards(string username)
        {
            throw new NotImplementedException();
        }

        public string createBoard(string username, string boardname)
        {
            throw new NotImplementedException();
        }

        public string deleteBoard(string username, string boardname)
        {
            throw new NotImplementedException();
        }
    }
}
