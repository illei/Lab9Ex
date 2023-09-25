using System;
using System.Collections.Generic;
using System.Text;

namespace Lab9Ex
{
    class ContInvestitii:ContEconomii

    {
        private  int ziCurenta = 0;
        public int ZiExtragere { get; set; }
        public ContInvestitii(int ziExtragere,string nume) : base(nume)
        {
            this.ZiExtragere = ziExtragere;
            
        }

        public override void RetrageBani(int DeDepus)
        {
            ziCurenta= DateTime.Now.Day;
            if (ziCurenta>=ZiExtragere)
            {
                base.RetrageBani(DeDepus);
            }

            else
            {
                Console.WriteLine("inca nu sa atins termenul");
            }
            
        }

        public override string ToString()
        {
            return $"{base.ToString()} are ziua de retragere  : {ZiExtragere}";
        }

    }
}
