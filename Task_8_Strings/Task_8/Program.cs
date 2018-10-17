using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            WordsRedaction first = new WordsRedaction("Я сразу смазал карту будня,плеснувши краску из стакана,я показал на блюде студня косые скулы океана.На чешуе жестяной рыбы прочёл я зовы новых губ.А вы ноктюрн сыграть могли бы на флейте водосточных труб?");
            string[] _myArray = first.stringArray;
            for (int i = 0; i < _myArray.Length; i++)
            {
                Console.WriteLine(_myArray[i]);
            }

            Console.ReadKey();
        }
    }
}
