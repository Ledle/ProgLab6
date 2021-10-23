using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgLab6
{
    class Test
    {
        private String name;
        private List<Question> quest;
        private List<Int32> result;
        public String Name 
        {
            get { return name; }
            set { name = value; }
        }
        public List<Question> Quest {
            get { return new List<Question>(quest); }
        }
        public Test()
        {
            this.name = "";
            this.quest = new List<Question>();
            this.result = new List<Int32>();
        }
        public Test(Question[] questions, String name)
        {
            this.name = name;
            this.quest = new List<Question>(questions.ToList());
            this.result = new List<Int32>();
        }
        public void addresult(int login, int res)
        {
            result.Add(login);
            result.Add(res);
        }
        public int getresult(int login) {
            int n = result.IndexOf(login);
            if (n == -1)
            {
                return 0;
            }
            return result[n + 1];
        }
        public void show()
        {
            Console.WriteLine("Test " + name + ":");
            for (int i = 0; i < quest.Count(); i++)
            {
                Console.WriteLine("Question " + i + ")" + quest[i].Text);
                Console.WriteLine("Answer: " + quest[i].Answer);
            }
        }
        public void input()
        {
            Console.Write("Enter name of test: ");
            this.name = Console.ReadLine();
            Console.WriteLine("Enter number of questions: ");
            int n;
            do{
                n = Convert.ToInt32(Console.ReadLine());
                if (n < 0)
                {
                    Console.WriteLine("Wrond number, need n>0");
                }
            }while(n < 0);
            quest = new List<Question>(n);
            for (int i = 0; i < n; i++)
            {
                quest.Add(new Question());
                quest[i].input();
            }
        }
    }
}   