using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    /// <summary>
    /// this class is incharge of the responses that each function send
    /// </summary>
    public class Response
    {
        public readonly string ErrorMessage;
        public bool ErrorOccured { get => ErrorMessage != null; }
        /// <summary>
        /// constructor
        /// </summary>
        public Response() { }
        /// <summary>
        /// constructor
        /// input: a massage from the functions
        /// </summary>
        /// <param name="msg"></param>
        public Response(string msg)
        {
            this.ErrorMessage = msg;
        }
    }
}
