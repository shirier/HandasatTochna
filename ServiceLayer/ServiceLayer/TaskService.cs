using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    class TaskService
    {
        public string create(string title, string description, List<string> dueTime, List<int> label)
        {
            throw new NotImplementedException();
        }
        public string delete(int id)
        {
            throw new NotImplementedException();
        }


        public string changeTitle(int id, string newTitle)
        {
            throw new NotImplementedException();
        }
        public string changeDescription(int id, string newDescription)
        {
            throw new NotImplementedException();
        }
        public string changeDue(int id, List<string> newDueTime)
        {
            throw new NotImplementedException();
        }
        public string changeId(int id, int newId)
        {
            throw new NotImplementedException();
        }


        public string getTimeLeft(int id)
        {
            throw new NotImplementedException();
        }
        public string changeLabel(int id, List<int> newLabel)
        {
            throw new NotImplementedException();
        }

    }
}
