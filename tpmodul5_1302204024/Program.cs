using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul5_1302204024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayaTubeVideo b = new SayaTubeVideo("1234567891"); // test case 1 assert < 10
            b.PrintVideoDetails();

            SayaTubeVideo c = new SayaTubeVideo(null);  // test case 2 assert == null
            c.PrintVideoDetails();
            c.IncreasePlayCount(10000000);

            SayaTubeVideo a = new SayaTubeVideo("Tutorial Design By Contract – [MUHAMMAD RIZQI ANSHARI]");
            a.PrintVideoDetails();

            for (int i = 0; i < 65538; i++)
            {
                a.IncreasePlayCount(i);
            }
            a.PrintVideoDetails();
        }
    }
}

