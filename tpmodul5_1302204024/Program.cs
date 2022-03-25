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
            //a.IncreasePlayCount(2); 
            //a.PrintVideoDetails();
            for (int i = 0; i < 65538; i++)
            {
                a.IncreasePlayCount(i);
            }
            a.PrintVideoDetails();
            
            //a.IncreasePlayCount(2147483647); //assert > 2147483647
            //a.PrintVideoDetails();

            //Boolean isstring = tescorect("ini string g sih");
            //tescorect("ini string g sih");
            //Console.WriteLine(isstring);
            //Boolean string2 = tescorect(null);
            //Console.WriteLine(string2);

            //new PreconditionDemo().DontPassInNull("hello");
            //new PreconditionDemo().DontPassInNull(null);


        }
        public static Boolean tescorect(String input)
        {
            Debug.Assert(input != null, "input should not null");
            return input is String;
        }
    }
    //public class PreconditionDemo
    //{
    //    public void DontPassInNull(string text)
    //    {
    //        Contract.Requires(text != null);
    //        Console.WriteLine("In DontPassInNull()");
    //    }
    //}
}

