using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_Polymorphism
{
    class Carnation:Flower
    {
        public Carnation():base(100,"Красный")
        {

        }
        public Carnation(int _cost,string _colorOfPetals):base( _cost, _colorOfPetals)
        {

        }
        public override string FlowerSmell()
        {
            return "Пахнет гвоздикой";
        }

        
    }
}
