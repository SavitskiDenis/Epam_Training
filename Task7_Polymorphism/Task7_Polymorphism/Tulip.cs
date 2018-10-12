using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_Polymorphism
{
    class Tulip : Flower
    {
        public Tulip() : base(150,"Красный")
        {

        }

        public Tulip(int _cost, string _colorOfPetals)
            : base(_cost, _colorOfPetals)
        {

        }

        public override string FlowerSmell()
        {
            return "Пахнет тюльпаном";
        }


    }
}
