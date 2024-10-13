using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserNamespace
{
    internal class Administrator : User
    {
        private string admin_name;

        public Administrator(string name, string id, string pass) : base(id, pass)
        {
            this.admin_name = name;
        }

        public override void updatePassword(string newPassword)
        {
            Console.WriteLine($"Update succesful. Your new password is: {newPassword}");
            this.user_password = newPassword;
        }

        public void updateAdminName(string name)
        {
            Console.WriteLine($"Update succesful. Your new password is: {name}");
            this.admin_name = name;
        }
    }
}
