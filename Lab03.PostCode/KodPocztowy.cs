using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03.PostCode
{
    class KodPocztowy
    {
        private int okregPocztowy;
        private int sektorKodowy;

        public void setKodPoczowy(string kod)
        {
            if (kod[2]=='-')
            {
                string _okregPocztowy = kod.Substring(0, 2);
                string _sektorKodowy = kod.Substring(3, 3);

                try
                {
                    okregPocztowy = Int32.Parse(_okregPocztowy);
                    sektorKodowy = Int32.Parse(_sektorKodowy);
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Unable to parse.");
                } 
            }
            else Console.WriteLine("Wrong post code format.");

        }

        public override string ToString()
        {
            return okregPocztowy + "-" + sektorKodowy;
        }
    }
}
