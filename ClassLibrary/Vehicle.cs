using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public abstract class Vehicle
    {
        public Guid id;
        public string type;
        public string model;
        public int speed;
        public Vehicle(string _type, string _model, int _speed )
        {
            this.id = Guid.NewGuid();
            this.type = _type;
            this.model = _model;
            this.speed = _speed;
        }


        public virtual int Move(int _timeMove)
        {
            return _timeMove * speed;
        }
    }
}
