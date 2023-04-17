using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    class TaskService
    {
        public string Create(BoardService board, List<string> time, string title, string description, int id)
        {
            throw new NotImplementedException();
        }
        public string ChangeStat(int id, string stat)
        {
            throw new NotImplementedException();
        }
        public string ChangeDue(int id, List<string> time)
        {
            throw new NotImplementedException();
        }
        public string ChangeTitle(string title, List<string> time)
        {
            throw new NotImplementedException();
        }
        public string ChangeDescription(string description, List<string> time)
        {
            throw new NotImplementedException();
        }
        public string Remove(int id)
        {
            throw new NotImplementedException();
        }
        public TaskService GetTask(int id)
        {
            throw new NotImplementedException();
        }
        public string GetTimeLeft(int id)
        {
            throw new NotImplementedException();
        }
        public string GetStat(int id)
        {
            throw new NotImplementedException();
        }
    }
