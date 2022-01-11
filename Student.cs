using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgLab6
{
    internal class Student:User,Interface
    {
        private Group grp;
        public Student() : base(){}
        public Student(string name) : base(name){}
        public Student(int login, int password, string name) : base(login,password,name){}
        Group Group
        {
            get { return grp; }
        }
        new public void show()
        {
            Console.WriteLine("User: " + this.name);
            if (grp != null)
            {
                Console.WriteLine("Group: " + grp);
            }
            Console.WriteLine(" Login: " + this.login + " Password: " + this.password);
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
        new public string toString()
        {
            string st;
            st = "Student: " + this.name;
            if (grp != null)
            {
                st += " Group: " + grp.Name;
            }
            st += " Login: " + this.login + " Password: " + this.password;
            return st;
        }
    }
}
