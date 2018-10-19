using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> _myList = new MyList<int>(20,10);
            _myList.Add(20);
            _myList.Add(30);

            Console.WriteLine("Список элементов после добавления:" + MyList<int>.Output(_myList));
            Console.WriteLine(_myList.Length);
            bool check=_myList.Remove(20);
            Console.WriteLine("Удаление:" +check);
            Console.WriteLine("Список элементов:"+MyList<int>.Output(_myList));
            
            _myList.Insert(1,5);
            Console.WriteLine("Список элементов после замены:" + MyList<int>.Output(_myList));
            _myList.RemoveAt(0);
            Console.WriteLine("Список элементов после удаления первого элемента:" + MyList<int>.Output(_myList));
            Console.WriteLine("Индекс элемента с значением 5:"+_myList.IndexOf(5));
            _myList = new MyList<int>(2,5);
            try
            {
                _myList.Add(10);
                _myList.Add(20);
                
            }
            catch( ListException ex)
            {
                Console.WriteLine(ex);
            }
            Console.WriteLine("Список элементов после замены:" + MyList<int>.Output(_myList));

            



            Console.ReadKey();


        }
    }
}
