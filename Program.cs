using System;
using System.Collections.Generic;

namespace ProgLab6
{ 
    class Program {
        static void Main(string[] args)
        {
            Discipline[,] discips = new Discipline[2, 2]; 
            discips[0,0] = new Discipline("Math"); 
            discips[0,1] = new Discipline("Physics");
            discips[1,0] = new Discipline("English");
            discips[1,1] = new Discipline("Philosophy");
            Group[] groups = new Group[2];
            groups[0] = new Group("PS");
            groups[1] = new Group("PI");
            User[,] users = new User[2,3];
            users[0,0] = new User("Andrey");
            users[0,1] = new User("Sergey");
            users[0,2] = new User("Ivan");
            users[1,0] = new User("John");
            users[1,1] = new User("Marty");
            users[1,2] = new User("Kyle");
            Question[] questions = new Question[16];
            String quest,answer;
            for (int i = 0; i < questions.Length; i++)
            {
                quest = Convert.ToString(i) + "+" + Convert.ToString(i*2);
                answer = Convert.ToString(i + i * 2);
                questions[i] = new Question(quest,answer,i+5);
            }
            Test[] tests = new Test[2];
            Question[] quests= new Question[8];
            for (int i = 0;i < tests.Length; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    quests[j] = questions[j + 8 * i];
                }
                tests[i] = new Test(quests, "Test #" + Convert.ToString(i + 1));
            }
            for (int i = 0; i < groups.Length; i++)
            {
                for (int j = 0; j < users.GetLength(1); j++)
                {
                    groups[i].adduser(users[i, j]);
                }
                for (int j = 0; j < discips.GetLength(1); j++)
                {
                    groups[i].adddisc(discips[i, j]);
                }
            }
            foreach (Group g in groups)
            {
                g.show();
            }
        }
    }
}