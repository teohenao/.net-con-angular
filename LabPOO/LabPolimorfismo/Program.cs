using System;
using System.Collections.Generic;

namespace LabPolimorfismo
{
    class Program
    {
       

        static void Main(string[] args)
        {
            List<Animales> listAnimales = new List<Animales>();

            Carnivoro c1 = new Carnivoro();
            c1.nombre = "leon";
            c1.color = "amarillo";
            c1.tamanio = "pequenio";
            listAnimales.Add(c1);

            Carnivoro c2 = new Carnivoro();
            c2.nombre = "cocodrilo";
            c2.color = "verde";
            c2.tamanio = "mediano";
            listAnimales.Add(c2);
                
            Hebivoro h1 = new Hebivoro();
            h1.nombre = "jirafa";
            h1.color = "amarilla";
            h1.tamanio = "gigante";
            listAnimales.Add(h1);

            Hebivoro h2 = new Hebivoro();
            h2.nombre = "tortuga";
            h2.color = "verde";
            h2.tamanio = "pequeña";
            listAnimales.Add(h2);

            Console.WriteLine("-----------------La lista de animales esta conformada por----------------");
            foreach (var animal in listAnimales)
            {
                Console.WriteLine(animal.nombre);
            }

        }
    }
}
