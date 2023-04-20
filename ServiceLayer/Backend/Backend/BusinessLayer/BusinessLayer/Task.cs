using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    /// <summary>
    /// task object
    /// </summary>
    class Task
    {
        private int id;
        private DateTime creationTime;
        private DateTime dueTime;
        private string title;
        private string description;
        private List<int> color;
    }
}
