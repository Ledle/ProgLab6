using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgLab6
{
    class User
    {
        private int login, password;
        private String name;
        private Group grp;
        public int Login{
            get { return login; }
            set { login = value; }
        }
        public int Password
        {
            get { return password; }
            set { password = value; }
        }
        public String Name
        {
            get { return name; }
            set { name = value.Substring(0,1).ToUpper() + value.Substring(1); }//Делает первую букву имени заглавной
        }
        public Group Group {
            get { return grp; }
        }
        public User()
        {
            this.name = "";
            this.grp = null;
            this.login = 0;
            this.password = 0;
        }
        public User(String name) {
            this.name = name;
            this.grp = null;
            this.login = 0;
            this.password = 0;
        }
        public User(int login, int password, String name)
        {
            this.login = login;
            this.password = password;
            this.name = name;
            this.grp = null;
        }
        public void changegroup(Group gr)
        {
            if (grp != gr)
            {
                gr.adduser(this);
                if (this.grp != null)
                {
                    this.grp.deluser(this.login);
                }
                this.grp = gr;
            }
        }
        public void delgroup()
        {
            if (this.grp != null)
            {
                this.grp.deluser(this.login);
            }
            this.grp = null;
        }
        public void show()
        {
            Console.WriteLine("User: " + this.name);
            if (this.grp != null)
            {
                Console.WriteLine(" Group: " + this.grp.Name);
            }
            Console.WriteLine(" Login: " + this.login + " Password: " + this.password);
        }
        public void input()
        {
            Console.Write("Enter name of student: ");
            this.name = Console.ReadLine();
            Console.Write("Enter login: ");
            this.login = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter password: ");
            this.password = Convert.ToInt32(Console.ReadLine());
        }
    }
}