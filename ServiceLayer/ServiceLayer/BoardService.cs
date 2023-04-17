using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    interface BoardService
    {
        public string create(string username, string boardname);

        public string delete(string username, string boardname);

        public string createTask(string username, Task task);

        public string deleteTask(string username, string boardname, Task task);

        public string ChangeName(string username, string boardname);


    }
}
