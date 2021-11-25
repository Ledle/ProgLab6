using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgLab6
{
    class Group
    {
        private static List<Group> groups = new List<Group>();//список всех групп
        private List<User> students;
        private List<Discipline> disciplines;
        private String name;
        public String Name {
            get { return name; }
            set { name = value; }
        }
        public static List<Group> list()
        {
            return new List<Group>(groups);
        }
        public List<User> Students 
        {
            get { return new List<User>(students); }
        }
        public List<Discipline> Disciplines
        {
            get { return new List<Discipline>(disciplines); }
        }
        public Group()
        {
            this.name = "";
            this.students = new List<User>();
            this.disciplines = new List<Discipline>();
            groups.Add(this);
        }
        public Group(String name)
        {
            this.name = name;
            this.students = new List<User>();
            this.disciplines = new List<Discipline>();
            groups.Add(this);
        }
        public int adddisc(Discipline disc)
        {
            if (this.disciplines.IndexOf(disc) == -1)
            {
                disciplines.Add(disc);
                disc.addgroup(this);
            }
            return disciplines.Count() - 1;
        }
        public int adduser(User student)
        {
            if (students.IndexOf(student) == -1)
            {
                students.Add(student);
                student.changegroup(this);
            }
            return students.IndexOf(student);
        }
        public void deldisc(String name)
        {
            for (int i = 0; i < disciplines.Count(); i++)
            {
                if (disciplines[i].Name == name)
                {
                    Discipline d = disciplines[i];
                    disciplines.Remove(disciplines[i]);
                    d.delgroup(this.name);
                    break;
                }
            }
        }
        public void show()
        {
            Console.WriteLine("Group " + this.name);
            if (this.students.Count() > 0)
            {
                for (int i = 0; i < this.students.Count(); i++)
                {
                    Console.WriteLine(" " + i + ") Name: " + this.students[i].Name + " Login: " + this.students[i].Login);
                }
            }
            if (this.disciplines.Count() > 0)
            {
                Console.WriteLine(" Disciplines:");
                for (int i = 0; i < this.disciplines.Count(); i++)
                {
                    Console.WriteLine("  " + i + ") Discipline: " + this.disciplines[i].Name);
                }
            }
        }
        public void input()
        {
            Console.Write("Enter name of groups: ");
            this.name = Console.ReadLine();
            Console.Write("Enter number of students: ");
            int n = Convert.ToInt32(Console.ReadLine());
            this.students = new List<User>(n);
            for (int i = 0; i < n; i++)
            {
                this.students.Add(new User());
                this.students[i].input();
            }
        }
        public void deluser(int login)
        {
            for (int i = 0; i < students.Count(); i++)
            {
                if (students[i].Login == login)
                {
                    User s = students[i];
                    students.Remove(students[i]);
                    s.delgroup();
                    break;
                }
            }
        }
    }
}
