

using System;

namespace Name
{
        class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hola, javi");

            string saludo= "Hola, super javi";

            saludo= "KLK";

            int myInt= 5;
            double num2= 5.4;
            float num3= 3.5f;
            dynamic nose= 5;
            Console.WriteLine(saludo);
            Console.WriteLine(myInt+num2+num3);
            Console.WriteLine(nose);
            nose= "hola";
            var casa="Casa azul";
            Console.WriteLine(casa);

            var carros = new string[] {"Toyota", "Nissan", "Honda", "Ford"};
            carros[3]="5";
           foreach (var auto in carros)
        {
            Console.WriteLine(auto);
        }
        }

        
    }
    
}
