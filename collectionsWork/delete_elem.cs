using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collectionsWork
{
    public class delete_elem<T>
    {
        private ICollection<T> _collection;

        public delete_elem(ICollection<T> collection)
        {
            _collection = collection ?? throw new ArgumentNullException(nameof(collection)); //
        }

        public bool RemoveFirst(Predicate<T> predicate)
        {
            if (predicate == null)
                throw new ArgumentNullException(nameof(predicate));

            var itemToRemove = _collection.FirstOrDefault(item => predicate(item));
            if (itemToRemove != null && !itemToRemove.Equals(default(T)))
            {
                return _collection.Remove(itemToRemove);
            }
            return false;
        }

        public int RemoveAll(Predicate<T> predicate)
        {
            if (predicate == null)
                throw new ArgumentNullException(nameof(predicate));

            var itemsToRemove = _collection.Where(item => predicate(item)).ToList();
            foreach (var item in itemsToRemove)
            {
                _collection.Remove(item);
            }
            return itemsToRemove.Count;
        }

        public void RemoveAt(int index)
        {
            if (_collection is IList<T> list)
            {
                list.RemoveAt(index);
            }
            else
            {
                throw new NotSupportedException("Коллекция не поддерживает удаление по индексу.");
            }
        }
    }
}
