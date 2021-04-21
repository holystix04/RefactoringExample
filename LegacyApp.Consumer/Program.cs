using System;

namespace LegacyApp.Consumer
{
    public class Program
    {
        public static void Main(string[] args) { ProveAddUser(args); }

        private static void ProveAddUser(string[] args)
        {
            /*
             * DO NOT CHANGE THIS FILE AT ALL!
             */

            var userService = new UserService();
            var addResult   = userService.AddUser("Joshua", "Clark", "jclark@rrs360.com", new DateTime(1989, 1, 6), 4);
            Console.WriteLine("Adding Joshua Clark was " + (addResult ? "successful" : "unsuccessful"));
        }
    }
}
