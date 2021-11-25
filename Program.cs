using System;
using System.Collections.Generic;

namespace ProgLab6
{ 
    class Program {
        static void Main(string[] args)
        {
            Discipline d1 = new Discipline("Math");
            Discipline d2 = new Discipline("Physic");
            Discipline d3 = new Discipline("Programming");
            Discipline d4 = new Discipline("Economics");
            Group g1 = new Group("PI01");
            Group g2 = new Group("PI02");
            Group g3 = new Group("PI03");
            Group g4 = new Group("PI04");
            Console.WriteLine("Groups:");
            foreach (Group g in Group.list())
            {
                g.show();
            }
            Console.WriteLine("Disciplines: ");
            foreach (Discipline d in Discipline.list())
            {
                d.show();
            }
        }
    }
}