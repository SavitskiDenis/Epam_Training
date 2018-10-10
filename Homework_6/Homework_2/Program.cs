using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
    class BigType
    {
        private int[] typeArray;

        public int [] TypeValue
        {
            get
            {
                return typeArray;
            }
            set
            {
                typeArray = value;
            }
        }

        public BigType()
        {
            typeArray = new int [1]{1};
        }

        public BigType(int number)
        {
            SplitNumber(number.ToString());
        }

        public BigType(long number)
        {
            SplitNumber(number.ToString());
        }

        public BigType(string number)
        {
            SplitNumber(number);
        }

        private void SplitNumber(string number)
        {

            char[] numberchar = number.ToCharArray();

            typeArray = new int[numberchar.Length];
            int index = 0;
            string item;
            for (int i = 0; i < typeArray.Length; i++)
            {
                item = Convert.ToString(numberchar[index]);
                typeArray[i] = int.Parse(item);
                index++;
            }
            Array.Reverse(typeArray);
        }

        public static int[] SplitNumberToArray(string number)
        {

            char[] numberchar = number.ToCharArray();
            int [] resultArray;
            resultArray = new int[numberchar.Length];
            int index = 0;
            string item;
            for (int i = 0; i < resultArray.Length; i++)
            {
                item = Convert.ToString(numberchar[index]);
                resultArray[i] = int.Parse(item);
                index++;
            }
            Array.Reverse(resultArray);
            return resultArray;
        }

       //operators_________________________________________________________________
        public static BigType operator +(BigType firstValue,BigType secondValue)
        {
            return new BigType { TypeValue=SumTwoArrays(firstValue.TypeValue,secondValue.TypeValue)};
        }

        public static BigType operator +(BigType firstValue, int secondValue)
        {
            return new BigType { TypeValue = SumTwoArrays(firstValue.TypeValue, SplitNumberToArray(secondValue.ToString())) };
        }

        public static BigType operator +(int firstValue, BigType secondValue)
        {
            return new BigType { TypeValue = SumTwoArrays(SplitNumberToArray(firstValue.ToString()), secondValue.TypeValue) };
        }

        public static BigType operator +(BigType firstValue, long secondValue)
        {
            return new BigType { TypeValue = SumTwoArrays(firstValue.TypeValue, SplitNumberToArray(secondValue.ToString())) };
        }

        public static BigType operator +(long firstValue, BigType secondValue)
        {
            return new BigType { TypeValue = SumTwoArrays(SplitNumberToArray(firstValue.ToString()), secondValue.TypeValue) };
        }

        public static BigType operator +(BigType firstValue, string secondValue)
        {
            return new BigType { TypeValue = SumTwoArrays(firstValue.TypeValue, SplitNumberToArray(secondValue)) };
        }

        public static BigType operator +(string firstValue, BigType secondValue)
        {
            return new BigType { TypeValue = SumTwoArrays(SplitNumberToArray(firstValue), secondValue.TypeValue) };
        }

        public static BigType operator *(BigType firstValue, BigType secondValue)
        {
            return new BigType { TypeValue = MulticationArrays(firstValue.TypeValue, secondValue.TypeValue) };
        }

        public static BigType operator *(BigType firstValue, int secondValue)
        {
            return new BigType { TypeValue = MulticationArrays(firstValue.TypeValue, SplitNumberToArray(secondValue.ToString())) };
        }

        public static BigType operator *(int firstValue, BigType secondValue)
        {
            return new BigType { TypeValue = MulticationArrays(SplitNumberToArray(firstValue.ToString()), secondValue.TypeValue) };
        }

        public static BigType operator *(BigType firstValue, long secondValue)
        {
            return new BigType { TypeValue = MulticationArrays(firstValue.TypeValue, SplitNumberToArray(secondValue.ToString())) };
        }

        public static BigType operator *(long firstValue, BigType secondValue)
        {
            return new BigType { TypeValue = MulticationArrays(SplitNumberToArray(firstValue.ToString()), secondValue.TypeValue) };
        }

        public static BigType operator *(BigType firstValue, string secondValue)
        {
            return new BigType { TypeValue = MulticationArrays(firstValue.TypeValue, SplitNumberToArray(secondValue)) };
        }

        public static BigType operator *(string firstValue, BigType secondValue)
        {
            return new BigType { TypeValue = MulticationArrays(SplitNumberToArray(firstValue), secondValue.TypeValue) };
        }

        public static BigType operator -(BigType firstValue, BigType secondValue)
        {
            return new BigType { TypeValue = SubtractTwoArrays(firstValue.TypeValue, secondValue.TypeValue) };
        }

        public static BigType operator -(BigType firstValue, int secondValue)
        {
            return new BigType { TypeValue = SubtractTwoArrays(firstValue.TypeValue, SplitNumberToArray(secondValue.ToString())) };
        }

        public static BigType operator -(int firstValue, BigType secondValue)
        {
            return new BigType { TypeValue = SubtractTwoArrays(SplitNumberToArray(firstValue.ToString()), secondValue.TypeValue) };
        }

        public static BigType operator -(BigType firstValue, long secondValue)
        {
            return new BigType { TypeValue = SubtractTwoArrays(firstValue.TypeValue, SplitNumberToArray(secondValue.ToString())) };
        }

        public static BigType operator -(long firstValue, BigType secondValue)
        {
            return new BigType { TypeValue = SubtractTwoArrays(SplitNumberToArray(firstValue.ToString()), secondValue.TypeValue) };
        }

        public static BigType operator -(BigType firstValue, string secondValue)
        {
            return new BigType { TypeValue = SubtractTwoArrays(firstValue.TypeValue, SplitNumberToArray(secondValue)) };
        }

        public static BigType operator -(string firstValue, BigType secondValue)
        {
            return new BigType { TypeValue = SubtractTwoArrays(SplitNumberToArray(firstValue), secondValue.TypeValue) };
        }
        //_________________________________________________________________________

        public static int[] SumTwoArrays(int[] firstArray, int[] secondArray)
        {
            int[] sumArray = {0};
            string check = "";

            if(firstArray.Length > secondArray.Length)
            {
                sumArray = new int [firstArray.Length];
                check = "1";
            }
            else if (firstArray.Length < secondArray.Length)
            {
                sumArray = new int[secondArray.Length];
                check = "2";
            }
            else
            {
                check = "0";
                sumArray = new int[firstArray.Length];
            }

            int  firstIndex = 0, secondIndex = 0, addNumber = 0,arrayLength=sumArray.Length;
            for (int i = 0; i < arrayLength; i++)
            {
                if(check=="1")
                {
                    if(secondIndex < secondArray.Length)
                    {
                        if (firstArray[firstIndex] + secondArray[secondIndex] + addNumber <= 9)
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
                                Array.Resize(ref sumArray, sumArray.Length + 1);
                                sumArray[i] = firstArray[firstIndex] + secondArray[secondIndex] + addNumber - 10;
                                addNumber = (firstArray[firstIndex] + secondArray[secondIndex] + addNumber - sumArray[i]) / 10;
                            }

                        }
                    }
                    else
                    {
                        if (firstArray[firstIndex] + addNumber <= 9)
                        {
                            sumArray[i] = firstArray[firstIndex] + addNumber;
                            addNumber = 0;
                        }
                        else
                        {
                            if (i + 1 < sumArray.Length)
                            {
                                sumArray[i] = firstArray[firstIndex] + addNumber - 10;
                                addNumber = (firstArray[firstIndex] + addNumber - sumArray[i]) / 10;
                            }
                            else
                            {
                                Array.Resize(ref sumArray, sumArray.Length + 1);
                                sumArray[i] = firstArray[firstIndex] + addNumber - 10;
                                addNumber = (firstArray[firstIndex] + addNumber - sumArray[i]) / 10;
                            }
                            if (sumArray.Length > arrayLength && i == sumArray.Length - 2)
                            {
                                sumArray[i + 1] = addNumber;
                            }

                        }
                    }

                    firstIndex++;
                    secondIndex++;
                }
                else if(check == "2")
                {
                       if (firstIndex < firstArray.Length)
                        {
                            if (firstArray[firstIndex] + secondArray[secondIndex] + addNumber <= 9)
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
                                    Array.Resize(ref sumArray, sumArray.Length + 1);
                                    sumArray[i] = firstArray[firstIndex] + secondArray[secondIndex] + addNumber - 10;
                                    addNumber = (firstArray[firstIndex] + secondArray[secondIndex] + addNumber - sumArray[i]) / 10;
                                }
                                if (sumArray.Length > arrayLength && i == sumArray.Length - 2)
                                {
                                    sumArray[i + 1] = addNumber;
                                }

                            }
                        }
                        else
                        {
                            if (secondArray[secondIndex] + addNumber <= 9)
                            {
                                sumArray[i] = secondArray[secondIndex] + addNumber;
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
                                    Array.Resize(ref sumArray, sumArray.Length + 1);
                                    sumArray[i] = secondArray[secondIndex] + addNumber - 10;
                                    addNumber = (secondArray[secondIndex] + addNumber - sumArray[i]) / 10;
                                }
                                if (sumArray.Length > arrayLength && i == sumArray.Length - 2)
                                {
                                    sumArray[i + 1] = addNumber;
                                }

                            }
                        }

                        firstIndex++;
                        secondIndex++;
                }
                else if(check=="0")
                {
                    if (firstArray[firstIndex] + secondArray[secondIndex] + addNumber <= 9)
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
                            Array.Resize(ref sumArray, sumArray.Length + 1);
                            sumArray[i] = firstArray[firstIndex] + secondArray[secondIndex] + addNumber - 10;
                            addNumber = (firstArray[firstIndex] + secondArray[secondIndex] + addNumber - sumArray[i]) / 10;
                        }
                        if (sumArray.Length > arrayLength && i == sumArray.Length - 2)
                        {
                            sumArray[i + 1] = addNumber;
                        }

                    }
                    firstIndex++;
                    secondIndex++;
                }
                
                
            }
            return sumArray;
        }

        public static int[] MulticationArrays(int[] myArray, int[] number)
        {
            int index = 1, position = 1, addNumber = 0;
            int[] resultArray = new int[myArray.Length];
            int[] secondArray;


            for (int i = 0; i < myArray.Length; i++)
            {
                if ((myArray[i] * number[0]) + addNumber <= 9)
                {
                    resultArray[i] = (myArray[i] * number[0]) + addNumber;
                    addNumber = 0;
                }
                else
                {
                    if (i + 1 < myArray.Length)
                    {
                        resultArray[i] = ((myArray[i] * number[0]) + addNumber) % 10;
                        addNumber = (((myArray[i] * number[0]) + addNumber) - resultArray[i]) / 10;
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

            if (number.Length > 1)
            {
                while (index < number.Length)
                {
                    secondArray = new int[myArray.Length];
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
                    resultArray = SumTwoArrayWithPosition(resultArray, secondArray, position);
                    index++;
                    position++;
                }
            }

            return resultArray;

        }

        public static int[] SumTwoArrayWithPosition(int[] firstArray, int[] secondArray, int position)
        {
            int[] sumArray = new int[secondArray.Length + position];
            int firstIndex = 0, secondIndex = 0, addNumber = 0, arrayLength = sumArray.Length;
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
                else if (i >= firstArray.Length)
                {
                    if (secondArray[secondIndex] + addNumber <= 9)
                    {
                        sumArray[i] = secondArray[secondIndex] + addNumber;
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
                            Array.Resize(ref sumArray, sumArray.Length + 1);
                            sumArray[i] = secondArray[secondIndex] + addNumber - 10;
                            addNumber = (secondArray[secondIndex] + addNumber - sumArray[i]) / 10;
                        }


                    }
                    if (sumArray.Length > arrayLength && i == sumArray.Length - 2)
                    {
                        sumArray[i + 1] = addNumber;
                    }
                    secondIndex++;
                }
                else
                {
                    if (firstArray[firstIndex] + secondArray[secondIndex] + addNumber <= 9)
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
                            Array.Resize(ref sumArray, sumArray.Length + 1);
                            sumArray[i] = firstArray[firstIndex] + secondArray[secondIndex] + addNumber - 10;
                            addNumber = (firstArray[firstIndex] + secondArray[secondIndex] + addNumber - sumArray[i]) / 10;
                        }

                    }
                    if (sumArray.Length > arrayLength && i >= sumArray.Length - 2)
                    {
                        sumArray[i + 1] = addNumber;
                    }
                    firstIndex++;
                    secondIndex++;
                }

            }
            return sumArray;
        }

        public static int[] SubtractTwoArrays(int [] firstArray, int [] secondArray)
        {
            int[] subArray={0};
            string check = "";
            int item = 0, lengthFirstArray = firstArray.Length;
            bool negative = false;

            if (firstArray.Length > secondArray.Length)
            {
                subArray = new int[firstArray.Length];
                check = "1";
            }
            else if (firstArray.Length < secondArray.Length)
            {
                
                subArray = new int[secondArray.Length];
                Array.Resize(ref firstArray, secondArray.Length);
                for (int i = 0; i < firstArray.Length; i++)
                {
                    item = firstArray[i];
                    firstArray[i] = secondArray[i];
                    secondArray[i] = item;
                }
                Array.Resize(ref secondArray,lengthFirstArray);
                check = "1";
                negative = true;
            }
            else
            {
                check = "0";
                subArray = new int[firstArray.Length];
                if(!isBiggest(firstArray,secondArray))
                {
                    for (int i = 0; i < firstArray.Length; i++)
                    {
                        item = firstArray[i];
                        firstArray[i] = secondArray[i];
                        secondArray[i] = item;
                    }
                    negative = true;
                }
                
            }
            int firstIndex = 0, secondIndex = 0;
            for (int i = 0; i < subArray.Length; i++)
            {
                if(check=="1")
                {
                    if(secondIndex<secondArray.Length)
                    {
                        if(firstArray[firstIndex]-secondArray[secondIndex]>=0)
                        {
                            subArray[i] = firstArray[firstIndex] - secondArray[secondIndex];
                        }
                        else if(firstIndex+1<firstArray.Length)
                        {
                            if(firstArray[firstIndex+1]>0)
                            {
                                firstArray[firstIndex] += 10;
                                firstArray[firstIndex + 1]--;
                                subArray[i] = firstArray[firstIndex] - secondArray[secondIndex];
                            }
                            else
                            {
                                for (int j = firstIndex+1; j < firstArray.Length; j++)
                                {
                                    if(firstArray[j]>0)
                                    {
                                        firstArray[j] -= 1;
                                        for (int k = j-1; k > firstIndex ; k--)
                                        {
                                            firstArray[k] = 9;
                                        }
                                        firstArray[firstIndex] += 10;
                                        subArray[i] = firstArray[firstIndex] - secondArray[secondIndex];
                                        break;
                                    }
                                }
                            }
                        }
                        else
                        {
                            subArray[i] = firstArray[firstIndex] - secondArray[secondIndex];
                        }
                    }
                    else if(firstIndex<firstArray.Length)
                    {
                        subArray[i] = firstArray[firstIndex];
                    }
                    firstIndex++;
                    secondIndex++;
                }
                else if(check=="0")
                {
                        if (firstArray[firstIndex] - secondArray[secondIndex] >= 0)
                        {
                            subArray[i] = firstArray[firstIndex] - secondArray[secondIndex];
                        }
                        else if (firstIndex + 1 < firstArray.Length)
                        {
                            if (firstArray[firstIndex + 1] > 0)
                            {
                                firstArray[firstIndex] += 10;
                                firstArray[firstIndex + 1]--;
                                subArray[i] = firstArray[firstIndex] - secondArray[secondIndex];
                            }
                            else
                            {
                                for (int j = firstIndex + 1; j < firstArray.Length; j++)
                                {
                                    if (firstArray[j] > 0)
                                    {
                                        firstArray[j] -= 1;
                                        for (int k = j - 1; k > firstIndex; k--)
                                        {
                                            firstArray[k] = 9;
                                        }
                                        firstArray[firstIndex] += 10;
                                        subArray[i] = firstArray[firstIndex] - secondArray[secondIndex];
                                        break;
                                    }
                                }
                            }
                        }
                        else
                        {
                            subArray[i] = firstArray[firstIndex] - secondArray[secondIndex];
                        }
                    firstIndex++;
                    secondIndex++;
                }
            }
            for (int i = subArray.Length-1; i >=0 ; i--)
            {
                if (subArray[i] == 0)
                {
                    Array.Resize(ref subArray, subArray.Length - 1);
                }
                else
                {
                    break;
                }
            }
            if(negative)
            {
                subArray[subArray.Length - 1] *= -1;
            }
            return subArray;
        }

        public void OutputArray()
        {
            
            for (int i = typeArray.Length-1; i >=0; i--)
            {
                Console.Write(typeArray[i]);
            }

            Console.WriteLine();
        }
            
        public static bool isBiggest(int[] first,int[] second)
        {
            bool check = false;
            for (int i = first.Length-1; i >= 0; i--)
            {
                if(first[i]>second[i])
                {
                    check=true;
                    break;
                }
                else if(first[i]<second[i])
                {
                    check=false;
                    break;
                }

            }
            return check;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            BigType myVar = new BigType(a);
            
            long b = long.Parse(Console.ReadLine());
            BigType myVar1 = new BigType(b);

            BigType myVar2 = myVar + myVar1;
            myVar2.OutputArray();

            myVar2 = myVar * myVar1;
            myVar2.OutputArray();

            myVar2 = myVar2 - myVar;
            myVar2.OutputArray();
            
            Console.ReadKey();
        }
    }
}
