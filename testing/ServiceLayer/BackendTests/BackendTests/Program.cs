using System.Text.Json;
using System.Text.Json.Serialization;
namespace BackendTests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RegisterLoginChecker();
            RegisterPasswordChecker();
            uniqueyemailchecker();
            taskcreaterequirements();
            boardCreatingChecker();
            startingBoardsChecker();
            tasksInBoardChecker();
            taskChecker();
            inProgChecker();
        }

        /// <summary>
        /// checking requirment 1 & 7 & 8
        /// </summary>
        public static void RegisterLoginChecker() {
            string email = "abc@gmail.com";
            string password = "Aa1234";
            Console.WriteLine("should register, logout and then login");
            Console.WriteLine(JsonSerializer.Deserialize<string>(UserService.register(email, password)));
            Console.WriteLine(JsonSerializer.Deserialize<string>(UserService.logout(email)));
            Console.WriteLine(JsonSerializer.Deserialize<string>(UserService.login(email, password)));
        }
        /// <summary>
        /// checking requirement 2
        /// </summary>
        public static void RegisterPasswordChecker()
        {
            string email = "abc2@gmail.com";
            string password1 = "Aa123";
            string password2 = "aa1234";
            string password3 = "AA1234";
            string password4 = "Aaaaaa";
            string password5 = "123456";
            string password6 = "Aa12345678901234567890";
            Console.WriteLine("should try and register with passwords that not legal");
            Console.WriteLine(JsonSerializer.Deserialize<string>(UserService.register(email, password1)));
            Console.WriteLine(JsonSerializer.Deserialize<string>(UserService.register(email, password2)));
            Console.WriteLine(JsonSerializer.Deserialize<string>(UserService.register(email, password3)));
            Console.WriteLine(JsonSerializer.Deserialize<string>(UserService.register(email, password4)));
            Console.WriteLine(JsonSerializer.Deserialize<string>(UserService.register(email, password5)));
            Console.WriteLine(JsonSerializer.Deserialize<string>(UserService.register(email, password6)));
        }

        /// <summary>
        /// check req 3
        /// </summary>
        public static void uniqueyemailchecker()
        {
            string email = "abc3@gmail.com";
            string password = "Aa1234";
            Console.WriteLine("should show that you cant use an email that is allready being used");
            Console.WriteLine(JsonSerializer.Deserialize<string>(UserService.register(email, password)));
            Console.WriteLine(JsonSerializer.Deserialize<string>(UserService.register(email, password)));

        }

        /// <summary>
        /// check req 4
        /// </summary>
        public static void taskcreaterequirements()
        {
            string title = "title";
            string title2 = "123456789012345678901234567890123456789012345678901";
            string desc = "";
            for (int i = 0; i < 301; i++)
            {
                desc += "1";
            }
            List<string> due = new List<string>();
            due.Add("01");
            due.Add("01");
            due.Add("2024");
            List<int> lable = new List<int>();
            lable.Add(100);
            lable.Add(100);
            lable.Add(100);
            Console.WriteLine("shold create a task and try to create two more with too long title and description");
            Console.WriteLine(JsonSerializer.Deserialize<string>(TaskService.create(title, "",due,lable)));
            Console.WriteLine(JsonSerializer.Deserialize<string>(TaskService.create(title2, "", due, lable)));
            Console.WriteLine(JsonSerializer.Deserialize<string>(TaskService.create(title, desc, due, lable)));
        }

        /// <summary>
        /// check req 6 & 9
        /// </summary>
        public static void boardCreatingChecker()
        {
            string email = "abc4@gmail.com";
            string password = "Aa1234";
            Console.WriteLine("checking you can create and delete boards and also that no two boardds with the same name can be under one user");
            Console.WriteLine(JsonSerializer.Deserialize<string>(UserService.register(email, password)));
            string name = "abc";
            Console.WriteLine(JsonSerializer.Deserialize<string>(BoardService.create(email, name)));
            Console.WriteLine(JsonSerializer.Deserialize<string>(BoardService.create(email, name)));
            Console.WriteLine(JsonSerializer.Deserialize<string>(BoardService.Delete(email, name)));
        }

        /// <summary>
        /// check req 5 & 10 & 11 & 12
        /// </summary>
        public static void startingBoardsChecker()
        {
            string email = "abc5@gmail.com";
            string password = "Aa1234";
            Console.WriteLine("showing that by deafult a user have 0 boards and the atributes of boards and limiting the columns");
            Console.WriteLine(JsonSerializer.Deserialize<string>(UserService.register(email, password)));
            Console.WriteLine(JsonSerializer.Deserialize<string>(UserService.getBoards(email)));
            string name = "abc";
            Console.WriteLine(JsonSerializer.Deserialize<string>(BoardService.create(email, name)));
            int Id = int.Parse(JsonSerializer.Deserialize<string>(UserService.getBoards(email)).Split(',')[0]);
            Console.WriteLine(JsonSerializer.Deserialize<string>(BoardService.getBoardAtributes(Id)));
            Console.WriteLine(JsonSerializer.Deserialize<string>(BoardService.setDoneLimits(50)));
            Console.WriteLine(JsonSerializer.Deserialize<string>(BoardService.setBacklogLimits(50)));
            Console.WriteLine(JsonSerializer.Deserialize<string>(BoardService.setInProgressLimits(50)));
        }

        /// <summary>
        /// check req 13 & 14
        /// </summary>
        public static void tasksInBoardChecker()
        {
            Console.WriteLine("showing that you can crete taks and move them forward");
            string email = "abc6@gmail.com";
            string password = "Aa1234";
            Console.WriteLine(JsonSerializer.Deserialize<string>(UserService.register(email, password)));
            string name = "abc";
            Console.WriteLine(JsonSerializer.Deserialize<string>(BoardService.create(email, name)));
            Console.WriteLine(JsonSerializer.Deserialize<string>(BoardService.createTask(email, name, "title", "")));
            Console.WriteLine(JsonSerializer.Deserialize<string>(BoardService.moveTask(email, name, 1)));
        }

        /// <summary>
        /// check req 15 & 16
        /// </summary>
        public static void taskChecker() {
            Console.WriteLine("showing you can change each atribute of the task");
            string title = "title";
            List<string> due = new List<string>();
            due.Add("01");
            due.Add("01");
            due.Add("2024");
            List<int> lable = new List<int>();
            lable.Add(100);
            lable.Add(100);
            lable.Add(100);
            Console.WriteLine(JsonSerializer.Deserialize<string>(TaskService.create(title, "", due, lable)));
            Console.WriteLine(JsonSerializer.Deserialize<string>(TaskService.changeTitle(1,"abc")));
            Console.WriteLine(JsonSerializer.Deserialize<string>(TaskService.changeDescription(1, "abc")));
            Console.WriteLine(JsonSerializer.Deserialize<string>(TaskService.changeDue(1, due)));
            Console.WriteLine(JsonSerializer.Deserialize<string>(TaskService.changeLable(1, lable)));
            Console.WriteLine(JsonSerializer.Deserialize<string>(TaskService.changeId(1, 2)));

        }

        /// <summary>
        /// check req 17
        /// </summary>
        public static void inProgChecker()
        {
            string email = "abc7@gmail.com";
            string password = "Aa1234";
            Console.WriteLine("shows that a user can access hes in progress tasks");
            Console.WriteLine(JsonSerializer.Deserialize<string>(UserService.register(email, password)));
            Console.WriteLine(JsonSerializer.Deserialize<string>(UserService.getInProgressTasks(email)));
            
        }
    }
}