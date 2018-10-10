using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Factorial
    {
        public static int [] FindFactorial(int number)
        {
            int[] myFactorialArray = { 1 };
            for (int i = 2; i <=number; i++)
            {
                myFactorialArray = MulticationArrayByNumber(myFactorialArray,SplitNumber(i));
            }
            Array.Reverse(myFactorialArray);
            return myFactorialArray;
        }
        public static int [] MulticationArrayByNumber(int [] myArray ,int [] number)
         {
             int index = 1,position=1,addNumber=0;
             int[] resultArray=new int [myArray.Length];
             int[] secondArray;
             

                 for (int i = 0; i < myArray.Length; i++)
                 {
                     if ((myArray[i] * number[0])+addNumber <= 9)
                     {
                        resultArray[i]= (myArray[i] * number[0])+addNumber;
                        addNumber = 0;
                     }
                     else
                     {
                         if (i + 1 < myArray.Length)
                         {
                             resultArray[i] = ((myArray[i] * number[0])+addNumber) % 10;
                             addNumber=(((myArray[i] * number[0])+addNumber)-resultArray[i])/10;
                         }
                         else
                         {
                             Array.Resize(ref resultArray, resultArray.Length + 1);
                             resultArray[i] = ((myArray[i] * number[0]) + addNumber) % 10;
                             addNumber = (((myArray[i] * number[0]) + addNumber) - resultArray[i]) / 10;
                             
                         }
                         if (i == myArray.Length - 1)
                         {
                             resultArray[resultArray.Length - 1] = addNumber;
                         }
                     }
                     
                 }
                 
             if (number.Length >1)
             {
                 while(index<number.Length)
                 {
                     secondArray=new int[myArray.Length];
                     addNumber = 0;
                     for (int i = 0; i < myArray.Length; i++)
                     {
                         if ((myArray[i] * number[index]) + addNumber <= 9)
                         {
                             secondArray[i] = (myArray[i] * number[index]) + addNumber;
                             addNumber = 0;
                         }
                         else
                         {
                             if (i + 1 < myArray.Length)
                             {
                                 secondArray[i] = ((myArray[i] * number[index]) + addNumber) % 10;
                                 addNumber = (((myArray[i] * number[index]) + addNumber) - secondArray[i]) / 10;
                             }
                             else
                             {
                                 Array.Resize(ref secondArray, secondArray.Length + 1);
                                 secondArray[i] = ((myArray[i] * number[index]) + addNumber) % 10;
                                 addNumber = (((myArray[i] * number[index]) + addNumber) - secondArray[i]) / 10;

                             }
                             if (i == myArray.Length - 1)
                             {
                                 secondArray[secondArray.Length - 1] = addNumber;
                             }
                         }
                     }
                     resultArray = SumTwoArray(resultArray,secondArray,position);
                     index++;
                     position++;
                 }
             }
             
             return resultArray;
             
         }
        public static int [] SplitNumber (int number)
         {
             int [] numberArray;
             
             char[] numberchar = Convert.ToString(number).ToCharArray();
             
             numberArray = new int[numberchar.Length];
             int index = 0;
             string item;
             for (int i = 0; i < numberArray.Length; i++)
             {
                 item = Convert.ToString(numberchar[index]);
                 numberArray[i] = Convert.ToInt32(item);
                 index++;
             }
             Array.Reverse(numberArray);
             return numberArray;
         }
        public static int [] SumTwoArray (int [] firstArray, int [] secondArray,int position)
        {
            int [] sumArray = new int [secondArray.Length+position];
            int firstIndex = 0, secondIndex = 0,addNumber = 0,arrayLength=sumArray.Length;
            for (int i = 0; i < arrayLength; i++)
            {
                if (i < position)
                {
                    if (firstArray[firstIndex] + addNumber <= 9)
                    {
                        sumArray[i] = firstArray[firstIndex] + addNumber;
                        addNumber = 0;
                    }
                    else
                    {
                        sumArray[i] = firstArray[firstIndex] + addNumber - 10;
                        addNumber = (firstArray[firstIndex] + addNumber - sumArray[i]) / 10;
                    }
                    firstIndex++;
                }
                else if(i>=firstArray.Length)
                {
                    if (secondArray[secondIndex] + addNumber<=9)
                    {
                        sumArray[i] = secondArray[secondIndex]+addNumber;
                        addNumber = 0;
                    }
                    else
                    {
                        if (i + 1 < sumArray.Length)
                        {
                            sumArray[i] = secondArray[secondIndex] + addNumber - 10;
                            addNumber = (secondArray[secondIndex] + addNumber - sumArray[i]) / 10;
                        }
                        else
                        {
                            Array.Resize(ref sumArray,sumArray.Length+1);
                            sumArray[i] = secondArray[secondIndex] + addNumber - 10;
                            addNumber = (secondArray[secondIndex] + addNumber - sumArray[i]) / 10;
                        }
                        
                        
                    }
                    if(sumArray.Length>arrayLength && i==sumArray.Length-2 )
                    {
                        sumArray[i+1] = addNumber;
                    }
                    secondIndex++;
                }
                else
                {
                    if(firstArray[firstIndex] + secondArray[secondIndex]+addNumber<=9)
                    {
                        sumArray[i] = firstArray[firstIndex] + secondArray[secondIndex] + addNumber;
                        addNumber = 0;
                    }
                    else
                    {
                        if (i + 1 < sumArray.Length)
                        {
                            sumArray[i] = firstArray[firstIndex] + secondArray[secondIndex] + addNumber - 10;
                            addNumber = (firstArray[firstIndex] + secondArray[secondIndex] + addNumber - sumArray[i]) / 10;
                        }
                        else
                        {
                            Array.Resize(ref sumArray,sumArray.Length+1);
                            sumArray[i] = firstArray[firstIndex] + secondArray[secondIndex] + addNumber - 10;
                            addNumber = (firstArray[firstIndex] + secondArray[secondIndex] + addNumber - sumArray[i]) / 10;
                        }
                       
                    }
                    if (sumArray.Length > arrayLength && i >= sumArray.Length-2 )
                    {
                        sumArray[i+1] = addNumber;
                    }
                    firstIndex++;
                    secondIndex++;
                }
               
            }
            return sumArray;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int n;
            int[] result;
            while(true)
            {
                if (int.TryParse(Console.ReadLine(), out n) && n >= 1)
                {
                    result = Factorial.FindFactorial(n);
                    break;
                }
                else Console.WriteLine("Проверьте вводимое число!");
            }
            Console.WriteLine("Факториал числа");
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i]);
            }
            Console.ReadKey();
        }
    }
}
