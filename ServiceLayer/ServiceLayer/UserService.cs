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
        public string register(string email, string password)
        {
            throw new NotImplementedException();
        }

        public string login(string email, string password)
        {
            throw new NotImplementedException();
        }
        public string logout(string email)
        {
            throw new NotImplementedException();
        }



        //Board related functions
        public List<BoardService> getBoards(string email)
        {
            throw new NotImplementedException();
        }

        public string createBoard(string email, string boardname)
        {
            throw new NotImplementedException();
        }

        public string deleteBoard(string email, string boardname)
        {
            throw new NotImplementedException();
        }
    }
}
