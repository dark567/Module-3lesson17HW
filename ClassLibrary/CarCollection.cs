using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class CarCollection : IEnumerable, IEnumerator
    {
        private Car[] car = {
            new Car(type:"Bus", model:"BMW", speed: 100),
            new Car(type:"sedan", model:"bens", speed:180),
            new Car(type:"bicycle", model:"---", speed:25),
            new Car(type:"buke", model:"Harley", speed:80),
            new Car(type:"Djip", model:"Opel", speed:120)
        };

        int index = -1;

        public object Current => car[index];

        public IEnumerator GetEnumerator()
        {
            // return this;
            for (int i = 0; i < car.Length; i++)
            {
                yield return car[i];
            }
        }

        public bool MoveNext()
        {
            if (index == car.Length - 1)
            {
                Reset();
                return false;
            }

            index++;
            return true;
        }

        public void Reset()
        {
            index = -1;
        }
    }
}
