using System;
using System.Collections.Generic;
using System.Text;

namespace Lab9Ex
{
   abstract class ContBancar
    {
       
        private Guid id = Guid.NewGuid();

        
        public string Nume { get; set; }
        public  double SoldCurent { get; protected set; }
        public Guid Id { get => id; }

        public ContBancar(string nume)
        {
            this.Nume = nume;
            
        }

        public virtual void DepuneBani(int DeDepus)
        {
            SoldCurent +=DeDepus;
        }
        public virtual void RetrageBani(int deRetras)
        {
           
            if (deRetras < this.SoldCurent)
            {
                this.SoldCurent -= deRetras;
            }
            else
            {
                Console.WriteLine("Fonduri Insuficiente");
            }


        }
        public override string ToString()
        {
            return $"Contul bancar:{Nume} cu Id=ul:{Id} are soldul:{SoldCurent}"; 
        }
    }
}
