using System;
using System.Collections.Generic;

namespace ProgLab6
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Question q = new Question();
            q.Value = 12;
            q.show();
            (q++).show();
            q.show();
            (++q).show();
		}
    }
}