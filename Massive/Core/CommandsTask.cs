using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Massive.Core
{
    internal class CommandsTask
    {
        public void Task1()
        {
            int[] array = new int[14];
            int A = 0;

            Console.WriteLine("Введите 14 целых чисел:");
            for (int i = 0; i < 14; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                if (array[i] % 2 == 0)
                {
                    A++;
                }
            }

            Console.WriteLine("Количество четных элементов: " + A);

        }
        public void Task2()
        {
            int[] array = new int[12];
            Console.WriteLine("Введите 12 целых чисел:");
            for (int i = 0; i < 12; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            double B = 0;
            for (int i = 0; i < 12; i++)
            {
                B += array[i];
            }
            B /= 12;

            array[4] = (int)B; 
            Console.WriteLine("Массив после замены пятого элемента: " + string.Join(", ", array));
        }
        public void Task3()
        {
            int[] array = new int[11];
            Console.WriteLine("Введите 11 целых чисел:");
            for (int i = 0; i < 11; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            double A = 0;
            for (int i = 0; i < 11; i++)
            {
                A += array[i];
            }
            A /= 11;

            int count = 0;
            for (int i = 0; i < 11; i++)
            {
                if (Math.Abs(array[i]) > A)
                {
                    count++;
                }
            }

            Console.WriteLine("Количество элементов больше среднего арифметического: " + count);
        }
        public void Task4()
        {
            int[] array = new int[10];
            Console.WriteLine("Введите 10 целых чисел:");
            for (int i = 0; i < 10; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int maxIndex = 0;
            for (int i = 1; i < 10; i++)
            {
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
            }
            int A = array[0];
            array[0] = array[maxIndex];
            array[maxIndex] = A;

            Console.WriteLine("Массив после замены: " + string.Join(", ", array));

        }
        public void Task5()
        {
            int[] array = new int[9];
            Console.WriteLine("Введите 9 целых чисел:");
            for (int i = 0; i < 9; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int maxIndex = 0;
            int minIndex = 0;

            for (int i = 1; i < 9; i++)
            {
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
                if (array[i] < array[minIndex])
                {
                    minIndex = i;
                }
            }
            int A = array[maxIndex];
            array[maxIndex] = array[minIndex];
            array[minIndex] = A;

            Console.WriteLine("Массив после замены: " + string.Join(", ", array));
        }
        public void Task6()
        {
            int[] array = new int[20];
            int evenCount = 0;
            int oddCount = 0;
            Console.WriteLine("Введите 20 целых чисел:");
            for (int i = 0; i < 20; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                if (array[i] % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }

            if (evenCount > oddCount)
            {
                Console.WriteLine("Больше четных чисел.");
            }
            else if (oddCount > evenCount)
            {
                Console.WriteLine("Больше нечетных чисел.");
            }
            else
            {
                Console.WriteLine("Четных и нечетных чисел поровну.");
            }
        }
        public void Task7()
        {
            double[] array = new double[15];
            Console.WriteLine("Введите 15 вещественных чисел:");
            for (int i = 0; i < 15; i++)
            {
                array[i] = double.Parse(Console.ReadLine());
            }

            double firstElement = array[0];
            int count = 0;

            for (int i = 1; i < 15; i++)
            {
                if (array[i] > firstElement)
                {
                    count++;
                }
            }

            Console.WriteLine("Количество элементов, больших первого: " + count);
        }
        public void Task8()
        {
            double[] array = new double[16];
            Console.WriteLine("Введите 16 вещественных чисел:");
            for (int i = 0; i < 16; i++)
            {
                array[i] = double.Parse(Console.ReadLine());
            }

            int maxIndex = 0;
            int minIndex = 0;

            for (int i = 1; i < 16; i++)
            {
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
                if (array[i] < array[minIndex])
                {
                    minIndex = i;
                }
            }

            Console.WriteLine("Индекс максимального элемента: " + maxIndex);
            Console.WriteLine("Индекс минимального элемента: " + minIndex);
        }
        public void Task9()
        {
            int[] array = new int[15];
            Console.WriteLine("Введите 15 целых чисел:");
            for (int i = 0; i < 15; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            double average = 0;
            for (int i = 0; i < 15; i++)
            {
                average += array[i];
            }
            average /= 15;

            int[] newArray = new int[15];
            for (int i = 0; i < 15; i++)
            {
                newArray[i] = array[i] - (int)average;
            }

            Console.WriteLine("Новый массив: " + string.Join(", ", newArray));
        }
        public void Task10()
        {
            int[] array = new int[17];
            Console.WriteLine("Введите 17 целых чисел:");
            for (int i = 0; i < 17; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            double negativeAverage = 0;
            int negativeCount = 0;

            for (int i = 0; i < 17; i++)
            {
                if (array[i] < 0)
                {
                    negativeAverage += Math.Abs(array[i]);
                    negativeCount++;
                }
            }
            if (negativeCount > 0)
            {
                negativeAverage /= negativeCount;
            }

            int sum = 0;
            for (int i = 0; i < 17; i++)
            {
                if (Math.Abs(array[i]) > negativeAverage)
                {
                    sum += array[i];
                }
            }

            Console.WriteLine("Сумма элементов: " + sum);
        }
        public void Task11()
        {
            int[] array = new int[14];
            Console.WriteLine("Введите 14 целых чисел:");
            for (int i = 0; i < 14; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int evenCount = 0;
            int evenSum = 0;

            for (int i = 0; i < 14; i++)
            {
                if (array[i] > 0 && array[i] % 2 == 0)
                {
                    evenCount++;
                    evenSum += array[i];
                }
            }

            Console.WriteLine("Количество: " + evenCount);
            Console.WriteLine("Сумма: " + evenSum);
        }
        public void Task12()
        {
            double[] array = new double[12];
            Console.WriteLine("Введите 12 вещественных чисел:");
            for (int i = 0; i < 12; i++)
            {
                array[i] = double.Parse(Console.ReadLine());
            }

            Array.Sort(array);
            Array.Reverse(array);

            double max = array[0];
            double min = array[array.Length - 1];
            double sum = max + min;

            Console.WriteLine("Элементы в порядке убывания: " + string.Join(", ", array));
            Console.WriteLine("Сумма: " + sum);
        }
        public void Task13()
        {
            int[] array = new int[15];
            Console.WriteLine("Введите 15 целых чисел:");
            for (int i = 0; i < 15; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int max = array[0];
            int min = array[0];

            for (int i = 1; i < 15; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            Console.WriteLine("Сумма: " + (max + min));
            Console.WriteLine("Разность: " + (max - min));
        }
        public void Task14()
        {
            int[] array = new int[17];
            Console.WriteLine("Введите 17 целых чисел:");
            for (int i = 0; i < 17; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int oddSum = 0;
            for (int i = 0; i < 17; i++)
            {
                if (array[i] % 2 != 0)
                {
                    oddSum += array[i];
                }
            }

            for (int i = 0; i < 17; i++)
            {
                if (array[i] % 3 == 0)
                {
                    array[i] = oddSum;
                }
            }

            Console.WriteLine("Массив после замены: " + string.Join(", ", array));
        }

    } 
}
