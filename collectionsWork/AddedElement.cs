using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collectionsWork
{
    // класс для добавления элементов и расположения в обратном порядке
    internal static class AddedElement
    {
        public static void Add<T>(this List<T> list, T item) // обощенный метод для 
        {
            if(list.Count < list.Capacity) // предпологаем, что внутри массив, проверяем есть ли метод
            {
                list.Insert(list.Count, item); // если есть добавляем
            }
            else
            {
                list.Add(item); // если нет, добавляем новый элемент
            }
        }
    }
}
