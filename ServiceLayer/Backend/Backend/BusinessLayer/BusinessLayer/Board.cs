using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    /// <summary>
    /// board object
    /// </summary>
    class Board
    {
        private string name;
        private Column backlog;
        private Column inProgress;
        private Column done;
        private int id;
    }
}
