using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserNamespace
{
    internal class User
    {
        private string user_id;
        protected string user_password;


        public User(string id, string pass)
        {
            this.user_id = id;
            this.user_password = pass; 

            //verifyLogin(id, pass);
        }

        public bool verifyLogin(string id, string pass)
        {
            bool verify;

            if (id.Equals("admin") && pass.Equals("pass")){
                verify = true;
                Console.WriteLine("Login Successfully.");
                return verify;
            }
            else
            {
                verify = false;
                Console.WriteLine("Login Failed. Incorrect username or password.");
                return verify;
            }
        }

        public virtual void updatePassword(string newPassword)
        {

        }

        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Enter your username: ");
                string id = Console.ReadLine();
                string pass = Console.ReadLine();

                if (id.Equals("") && pass.Equals(""))
                {
                    User user = new User(id, pass);
                    bool verifyUser = user.verifyLogin(id, pass);

                    if (verifyUser == true) 
                    {
                        Console.WriteLine("Registering Account... ");

                    }

                    break;

                }
                else
                {
                    Console.WriteLine("Please fill out the username and password");
                    continue;
                }

            }
            
        }
    }
}
