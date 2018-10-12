using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_Polymorphism
{
    class Cornflower : Flower
    {
        public Cornflower () : base(80,"Синий")
        {

        }

        public Cornflower(int _cost, string _colorOfPetals): base(_cost, _colorOfPetals)
        {

        }

        public override string FlowerSmell()
        {
            return "Пахнет васильком";
        }
    }
}
