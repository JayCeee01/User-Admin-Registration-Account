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

            
        }

        public bool verifyLogin(string id, string pass)
        {
            bool verify;

            if (id.Equals("admin") && pass.Equals(user_password)){
                verify = true;
                Console.WriteLine("Login Successfully.");
                return verify;
            }
            else
            {
                verify = false;
                Console.WriteLine("Login Failed. Incorrect username or password.");
                Console.WriteLine();
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
                Console.WriteLine("Login Account...");
                Console.WriteLine("___________________________");
                Console.Write("Enter your username: ");
                string id = Console.ReadLine();

                Console.Write("Enter your password: ");
                string pass = Console.ReadLine();
                Console.WriteLine();

                if (!id.Equals("") && !pass.Equals(""))
                {
                    User user = new User(id, pass);
                    bool verifyUser = user.verifyLogin(id, pass);

                    if (verifyUser == true) 
                    {
                        Console.WriteLine("Registering Account... \n");
                        Console.WriteLine("___________________________");
                        Console.Write("Register your admin name: ");
                        string adminName = Console.ReadLine();
                        Console.Write("Register your password: ");
                        string newpass = Console.ReadLine();
                        Console.WriteLine();

                        Administrator admin1 = new Administrator(adminName, id, pass);
                        admin1.updateAdminName(adminName);
                        admin1.updatePassword(newpass);
                        Console.WriteLine("Admin login success: " + admin1.verifyLogin("admin", newpass));

                        Console.WriteLine();
                        Console.WriteLine("Press any key to exit...");
                        Console.ReadKey();
                    }
                    else
                    {
                        continue;
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
