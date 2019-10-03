using ClassLibrary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CarCollection cars = new CarCollection();

            // Используем перечислитель
            IEnumerator car = cars.GetEnumerator();
            while (car.MoveNext())
                Console.WriteLine(((Car)car.Current).id +" : "+ ((Car)car.Current).type + " : " + ((Car)car.Current).model + " : " + ((Car)car.Current).speed + " : " + ((Car)car.Current).Move(100));

            Console.ReadKey();
        }
    }
}
