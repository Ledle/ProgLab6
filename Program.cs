using System;
using System.Collections.Generic;

namespace ProgLab6
{
    class Program
    {
        static void Main(string[] args)
        {
			User serg = new User(111, 22, "Sergey");
			Group PI = new Group("PI");
			Question q1 = new Question("2+2?", "4", 5);
			Question q2 = new Question("2+2*2?", "6", 10);
			Test math = new Test(new Question[] { q1, q2 }, "Math");
			Discipline progr = new Discipline("Programming");
			PI.adduser(serg);
			math.Quest[0].show();
			math.show();
			progr.addtest(math);
			PI.Students[0].show();
			PI.show();
			progr.show();
			User dima = new User(113, 454, "Dmitry");
			PI.deluser(111);
			PI.show();
			PI.adduser(dima);
			PI.show();
			PI.adduser(serg);
			PI.show();
			progr.delgroup(PI.Name);
		}
    }
}
