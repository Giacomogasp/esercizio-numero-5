using System;

namespace esercizio_numero_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci la temperatura della serra");
            double temperatura = double.Parse(Console.ReadLine());
            if (temperatura >= 18)
            {
                double t = (temperatura + 18);
                double temperaturainiziale = temperatura + 18;
                double temperaturafinale = temperatura - 5;
                double temperaturamedia = temperatura - 5 + 18;

            }
            Console.ReadLine();
        }
    }
}
