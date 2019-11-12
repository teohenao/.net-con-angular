using System;


namespace LabHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------Padre-----");
            Padre p = new Padre();
            p.nombre = "luis";
            p.primerApellido = "henao";
            p.segundoApellido = "garcia";
            Console.WriteLine($"{p.nombre} {p.primerApellido} {p.segundoApellido}");
            p.cantar();
            p.bailar();

            Console.WriteLine("---------hijo-----");
            Hijo h = new Hijo();
            h.nombre = "Mateo";
            h.segundoApellido = "Agudelo";
            Console.WriteLine(h.nombre + " " + h.primerApellido + " " + h.segundoApellido);
            h.cantar();
            h.estudiar();

            Console.WriteLine("---------Sobrino-----");
            Sobrino s = new Sobrino();
            s.nombre = "pablo";
            s.segundoApellido = "hernandez";
            Console.WriteLine(s.nombre + " " + s.primerApellido + " " + s.segundoApellido);
            s.cantar();
            s.esconderse();

            Console.WriteLine("---------Nieto-----");
            Nieto n = new Nieto();
            n.nombre = "santiago";
            n.segundoApellido = "mejia";
            Console.WriteLine($"{n.nombre} {n.primerApellido} {n.segundoApellido}");
            n.bailar();
            n.llorar();
            Console.WriteLine("\n PRESIONE UNA ENTER PARA SALIR");
            Console.ReadLine();

           
        }
    }
}
