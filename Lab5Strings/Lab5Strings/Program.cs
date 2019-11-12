using System;

namespace Lab5Strings
{
    /// <summary>
    /// Mateo Henao Rodriguez
    /// laboratorio numero 5
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * Primer Punto
             */
            String frase1 = "Microsoft: tu potencial, nuestra pasión";
            String[] palabra = frase1.Split();

            foreach (string i in palabra)
            {
                if (i.Length > 7)
                    Console.ForegroundColor = ConsoleColor.Red;
                else if (i.Length == 7)
                    Console.ForegroundColor = ConsoleColor.Yellow;
                else
                    Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(i);
                Console.ResetColor();
            }


            /**
             * Punto 2
             */
            string frase2 = string.Concat(frase1," ojala entre a heinson :(");
            int p = frase2.IndexOf(' ');
            frase2 = frase2.Substring(p+1);
            int p2 = frase2.IndexOf(' ');
            frase2 = frase2.Substring(p2+1);
            Console.WriteLine($"la nueva frase es: {frase2}");

            /**
             * Punto 3
             */
            DateTime fechaActual = DateTime.Now;

            /**
             * Punto 4
             */
            DateTime fecha2 = new DateTime(fechaActual.Year, fechaActual.Month, 1).AddMonths(1);

            /**
             * Punto 5
             */
            DateTime fecha3 = fecha2.AddMonths(1).AddDays(-1);
            if (fecha3.DayOfWeek == DayOfWeek.Sunday)
                fecha3 = fecha3.AddDays(-2);
            else if (fecha3.DayOfWeek == DayOfWeek.Saturday)
                fecha3 = fecha3.AddDays(-1);

            Console.WriteLine($"la fecha actual es: {fechaActual}");
            Console.WriteLine($"fecha2 es: {fecha2}");
            Console.WriteLine($"fecha3 es: {fecha3}");


        }
    }
}
