using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgLab6
{
    internal class Teacher:User,Interface
    {
        private List<Discipline> discips = new List<Discipline>();
        Teacher() : base() {}
        Teacher(String name) : base(name) {}
        Teacher(int login, int password, String name) : base(login, password, name) {}
        Teacher(int login, int password, String name, Discipline disc) : base(login, password, name) {
            if (!discips.Contains(disc))
            {
                if (Discipline.list().Contains(disc))
                {

                }
            }
        }
        List<Discipline> Disciplines
        {
            get { return new List<Discipline>(discips); }
        }
        new public void show()
        {
            Console.WriteLine("Teacher: " + this.name);
            if (discips.Count != 0) { Console.WriteLine("Disciplines:"); }
            foreach (Discipline d in discips)
            {
                Console.WriteLine(d.Name);
            }
            Console.WriteLine(" Login: " + this.login + " Password: " + this.password);
        }
        public void adddisc(Discipline disc)
        {
            if (!discips.Contains(disc))
            {
                discips.Add(disc);
            }
        }
        public void deldisc(Discipline disc)
        {
            discips.Remove(disc);
        }
        new public void input()
        {
            Console.Write("Enter name of teacher: ");
            this.name = Console.ReadLine();
            Console.Write("Enter login: ");
            this.login = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter password: ");
            this.password = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter discipline: ");
            String name = Console.ReadLine();
            bool f=true;
            for (int i = 0; i < Discipline.list().Count; i++)
            {
                if (Discipline.list()[i].Name == name)
                {
                    adddisc(Discipline.list()[i]);
                    f = false;
                    break;
                }
            }
            if (f)
            {
                adddisc(new Discipline(name));
            }
        }
        new public String toString()
        {
            string st;
            st = "Teacher: " + this.name;
            if (discips.Count != 0) { st += "Disciplines:"; }
            foreach (Discipline d in discips)
            {
                st+= d.Name;
            }
            st += " Login: " + this.login + " Password: " + this.password;
            return st;
        }
    }
}
