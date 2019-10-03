using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Car : Vehicle
    {
        public Guid Id;

        public Car(string type, string model, int speed) : base( type,  model,  speed)
        {
            Id = Guid.NewGuid();
        }

        public override int Move(int _timeMove)
        {
            return base.Move(_timeMove) * 2;
        }
    }
}
