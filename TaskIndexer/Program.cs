using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskIndexer.Models;

namespace TaskIndexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person[0] = "Aysel, Mirze, 19";
            person[1] = "Nigar, Aliyeva 22";
            person[2] = " Ali, Aliyev, 18";
            person[3] = "Isa, Rzayev, 21";
            person[4] = "Sema, Mahmudova 15";
            person[5] = "Leyla, Memmedova 25";


            for (int i = 0; i < 6; i++)
                Console.WriteLine(person[i]);
        }
    }
}
