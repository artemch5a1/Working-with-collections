using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collectionsWork
{
    internal static class ReverseElements
    {
        public static void ReverseList<T>(this List<T> list) // создаем обобщенный метод
        {
            list.Reverse(); // оборачиваем лист
        }
    }
}
