using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Task7_Polymorphism
{
    abstract class Flower
    {
        protected int _cost;
        protected string _colorOfPetals;
        public Flower(int _cost,string _colorOfPetals)
        {
            this._cost = _cost;
            this._colorOfPetals = _colorOfPetals;
        }
        public virtual string FlowerSmell ()
        {
            return "Ничем не пахнет";
        }
        public int GetCost ()
        {
            return _cost;
        }
        public string GetColorOfPetals ()
        {
            return _colorOfPetals;
        }
    }
}
