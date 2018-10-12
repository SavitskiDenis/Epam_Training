using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_Polymorphism
{
    class Rose : Flower
    {
        public Rose():base(400,"Красный")
        {

        }
        public Rose (int _cost,string _colorOfPetals):base(_cost,_colorOfPetals)
        {

        }
        public override string FlowerSmell()
        {
            return "Пахнет розой";
        }
    }
}
