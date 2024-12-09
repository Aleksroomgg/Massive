using Massive.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Massive
{
    internal class Program
    {
        static ClassSwitch classSwitch = new ClassSwitch();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. массив из 14 элементов\n2. замена пятого элемента среднеарифметическим\n3. Количество элементов больше среднего арифметического\n4. поменять местами максимальный и первый элементы\n5. поменять местами максимальный и минимальный элементы\n6. определить больше четных или нечетных\n7.количество элементов больше первого\n8. индексы максимального и минимального элементов\n9. новый массив как разность между элементами и средним арифметическим\n10. сумма элементов больше среднего арифметического модулей отрицательных\n11. количество и сумма четных положительных элементов\n12. элементы в порядке убывания и сумма макс/мин\n13.  сумма и разность максимального и минимального элементов\n14. замена элементов кратных 3 на сумму нечетных\n");
                int z = int.Parse(Console.ReadLine());
                classSwitch.GG(z);
                Console.ReadKey();
                Console.Clear();
            }
        }   
    }
}
