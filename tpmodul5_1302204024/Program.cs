using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul5_1302204024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayaTubeVideo a = new SayaTubeVideo("Tutorial Design By Contract – [MUHAMMAD RIZQI ANSHARI]");
            a.PrintVideoDetails();
            a.IncreasePlayCount(2);
            a.PrintVideoDetails();
        }
    }
}

