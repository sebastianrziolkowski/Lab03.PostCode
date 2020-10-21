using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03.PostCode
{
    class Adres
    {
        private string kraj,
            miasto,
            ulica;
        private int numerDomu,
            numerMieszkania;
        private KodPocztowy kodPocztowy;

        public Adres()
        {
            kodPocztowy = new KodPocztowy();
        }

        public void setAdres()
        {
            try
            {
                Console.Write("Kraj:");
                kraj = Console.ReadLine();
                Console.Write("Miasto:");
                miasto = Console.ReadLine();
                Console.Write("Ulica:");
                ulica = Console.ReadLine();
                Console.Write("Numer domu:");
                numerDomu = Convert.ToInt32(Console.ReadLine());
                Console.Write("Numer mieszkania:");
                numerMieszkania = Convert.ToInt32(Console.ReadLine());
                Console.Write("Kod pocztowy:");
                kodPocztowy.setKodPoczowy(Console.ReadLine());

                Console.WriteLine(this.ToString());
            }
            catch (Exception)
            {

                Console.Write("Blad wprowadzanych danych.");
            }
        }

        public override string ToString()
        {
            return "Kraj " + kraj + "\n" +
                "misto: " + miasto + "\n" +
                "ulica: " + ulica + "\n" +
                "numer domu: " + numerDomu + "\n" +
                "numer mieszkania: " + numerMieszkania + "\n" +
                "kod pocztowy: " + kodPocztowy.ToString();
        }


    }
}
