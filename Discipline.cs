using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgLab6
{
    class Discipline
    {
        private static List<Discipline> disciplines = new List<Discipline>();//список всех дисциплин
        private String name;
        private List<Test> tests;
        private List<Group> groups;//массив объектов Group
        public String Name {
            get { return name; }
            set { name = value; }
        }
        public static List<Discipline> list() {//статический метод для полученияя копии списка
            return disciplines.GetRange(0,disciplines.Count);
        }
        public List<Test> Tests {
            get { return new List<Test>(tests); }
        }
        public List<Group> Groups
        {
            get { return new List<Group>(groups); }
        }
        public Discipline()
        {
            this.name = "";
            this.tests = new List<Test>();
            this.groups = new List<Group>();
            disciplines.Add(this);//добавление новой дисциплины в общий список
        }
        public Discipline(String name)
        {
            this.name = name;
            this.tests = new List<Test>();
            this.groups = new List<Group>();
            disciplines.Add(this);//добавление новой дисциплины в общий список
        }
        public Discipline(String name, Test[] tests, Group[] groups) {
            this.name = name;
            this.tests = new List<Test>(tests);
            this.groups = new List<Group>(groups);
        }
        public int addgroup(Group gr)
        {
            if (this.groups.IndexOf(gr) == -1)
            {
                this.groups.Add(gr);
                gr.adddisc(this);//добавление этой дисциплины в группу с помощью this
            }
            return groups.Count() - 1;
        }
        public int addtest(Test tst)
        {
            if (this.tests.IndexOf(tst) == -1)
            {
                this.tests.Add(tst);
            }
            return tests.Count() - 1;
        }
        public void deltest(String name)
        {
            for (int i = 0; i < tests.Count(); i++)
            {
                if (tests[i].Name == name)
                {
                    tests.Remove(tests[i]);
                    break;
                }
            }
        }
        public void delgroup(String name)
        {
            for (int i = 0; i < groups.Count(); i++)
            {
                if (groups[i].Name == name)
                {
                    Group g = groups[i];
                    groups.Remove(groups[i]);
                    g.deldisc(this.name);
                    break;
                }
            }
        }
        public void show()
        {
            Console.WriteLine("Discipline " + this.name + ":");
            if (this.groups.Count() > 0)
            {
                Console.WriteLine(" Groups:");
                for (int i = 0; i < this.groups.Count(); i++)
                {
                    Console.WriteLine("  " + i + ") " + this.groups[i].Name);
                }
            }
            if (this.tests.Count() >= 0)
            {
                Console.WriteLine(" Tests: " + this.tests.Count());
            }
        }
        public void input()
        {
            Console.WriteLine("Enter name of discipline: ");
            this.name = Console.ReadLine();
        }
    }
}
