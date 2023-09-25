using System;

namespace Lab9Ex
{
    class Program
    {
        static void Main(string[] args)
        {
          
            ContCurent  cont = new ContCurent("COnt");

            cont.DepuneBani(4999);
           
            cont.RetrageBani(5000);
            cont.RetrageBani(5000);
            Console.WriteLine(cont.ToString());



        }
    }
}
