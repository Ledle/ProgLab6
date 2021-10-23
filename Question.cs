using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgLab6
{
    class Question
    {
        private String text, answer;
        private int score;
        public String Text
        {
            get { return text; }
            set { text = value; }
        }
        public String Answer
        {
            get { return answer; }
            set { answer = value; }
        }
        public int Value
        {
            get { return score; }
            set { score = Math.Abs(value); }
        }
        public Question() {
            this.text = "";
            this.answer = "";
            this.score = 0;
        }
        public Question(String text, String answer, int value)
        {
            this.text = text;
            this.answer = answer;
            this.score = value;
        }
        public void show() {
            Console.WriteLine("Question: " + this.text);
            Console.Write("Answer: " + this.answer);
            Console.WriteLine("(" + this.score + ")");
        }
        public void input() {
            Console.Write("Enter text: ");
            this.text = Console.ReadLine();
            Console.Write("Enter answer: ");
            this.answer = Console.ReadLine();
            Console.Write("Enter scores: ");
            this.score = Convert.ToInt32(Console.ReadLine());
        }
    }
}
