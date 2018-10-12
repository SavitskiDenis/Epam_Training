using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_Polymorphism
{
    class Chamomile : Flower
    {
        public Chamomile () : base(150,"Белый")
        {

        }

        public Chamomile(int _cost,string _colorOfPetals) : base( _cost, _colorOfPetals)
        {

        }

        public override string FlowerSmell()
        {
            return "Пахнет ромашкой";
        }


    }
}
