using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_Inheritance
{
    class Man
    {
        protected string _name,_gendre;
        protected byte _age, _weight;

        public void InputName(string _name)
        {
            this._name = _name;
        }
        public void InputGendre(string _gendre)
        {
            this._gendre = _gendre;
        }
        public void InputAge(byte _age)
        {
            this._age = _age;
        }
        public void InputWeight(byte _weight)
        {
            this._weight = _weight;
        }

        public string GetName()
        {
            return _name;
        }
        public string GetGendre()
        {
            return _gendre;
        }
        public byte GetAge()
        {
            return _age;
        }
        public byte GetWeight()
        {
            return _weight;
        }

    }
}
