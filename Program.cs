using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2
{
  //  Napišite program u kojem ćete deklarirati varijable a i b tipa int, te im dodijelite vrijednosti 100 (a) i 3 (b). Ispišite njihove vrijednosti u sljedećem obliku://
//“a dijeljeno s b je x i ostatak y”.//

    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            int b = 3;
            Console.WriteLine(a + " dijeljeno s " + b + " je " + (a / b) + " i ostatak " + (a % b)+" .");
       
            Console.ReadLine();
        }
    }
}
