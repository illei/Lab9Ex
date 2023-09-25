using System;
using System.Collections.Generic;
using System.Text;

namespace Lab9Ex
{
    class ContCurent : ContBancar
    {
        private const double PafonDescoperire =-5000;
        public ContCurent (string nume): base(nume)
        {

        }

        public override void RetrageBani(int deRetras)
        {
            base.RetrageBani(deRetras);
            if (deRetras > SoldCurent)
            {
                Console.WriteLine("Se verifica posibilitatea de descoperire");
                if ((SoldCurent - deRetras)>=(PafonDescoperire))
                {
                    SoldCurent -= deRetras;
                    Console.WriteLine($"Noul Sold:{SoldCurent}");
                }
                else
                {
                    Console.WriteLine("Nu se poate face descoperie");
                }
            }
        }
        public override string ToString()
        {
            return $"{base.ToString()}"; 
        }
    }
}
