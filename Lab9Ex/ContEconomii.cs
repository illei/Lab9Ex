using System;
using System.Collections.Generic;
using System.Text;

namespace Lab9Ex
{
    class ContEconomii : ContBancar
    {
        const double rataDobanda = 0.3;
        public ContEconomii(string nume) : base(nume)
        {

        }

        public override void DepuneBani(int DeDepus)
        {
            base.DepuneBani(DeDepus);
            Console.WriteLine("Noul dumneavoastra sold: \n");
            SoldCurent *= (1+rataDobanda);
        }

        public override string ToString()
        {
            return $"{base.ToString()} are dobanda de  : {rataDobanda}";
        }

    }
}
