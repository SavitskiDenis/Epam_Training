using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Flower[] bouquet = {
                                    new Rose(),
                                    new Rose(450,"Белый"),
                                    new Rose (500,"Зеленый"),
                                    new Carnation(),
                                    new Carnation(200,"Розовый"),
                                    new Tulip(),
                                    new Tulip(170,"Желтый"),
                                    new Chamomile(),
                                    new Chamomile(),
                                    new Cornflower(),
                                    new Cornflower()
                                };

            OutputBouquetInformation(bouquet);

            Console.ReadKey();
        }

        static void OutputBouquetInformation(Flower [] myBouquet)
        {
            int resultCost = 0;
            for (int i = 0; i < myBouquet.Length; i++)
            {
                resultCost += myBouquet[i].GetCost();
                Console.WriteLine("Цвет лепестков:" + myBouquet[i].GetColorOfPetals() + "\n" + myBouquet[i].FlowerSmell());
            }
            Console.WriteLine("Стоимость букета:"+resultCost);
        }
    }
}
