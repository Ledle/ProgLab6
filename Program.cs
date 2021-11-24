using System;
using System.Collections.Generic;

namespace ProgLab6
{ 
    class Program
    {
        static void Change(Question q)
        {
            q.Value = 13;
        }
        static void Main(string[] args)
        {
            Question q = new Question("Text","Answer",12);
            q.Value = 12;
            Change(q);
            q.show();
		}
    }
}