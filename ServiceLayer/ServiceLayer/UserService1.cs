using System;

namespace IntroSE.ForumSystem.Backend.ServiceLayer
{
    public class UserService
    {

        public UserService()
        {
        }

        /// <summary>
        /// 
        /// Load the data. Must be invoked explicitly by the user when the system starts
        /// 
        /// </summary>
        /// <returns>A response instance</returns>
        public Response LoadData()
        {
            return new Response("Not impleneted yet");
        }

        /// <summary>
        /// Registers a user in the system
        /// </summary>
        /// <param name="email">User's email. Assumed not to be registered yet</param>
        /// <param name="password">User's password</param>
        /// <returns></returns>
        public Response Register(string email, string password)
        {
            return new Response("Not impleneted yet");
        }

    }
}
