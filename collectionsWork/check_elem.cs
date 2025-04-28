using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collectionsWork
{
    internal class check_elem<T>
    {
        private readonly IEnumerable<T> _collection;

        public check_elem(IEnumerable<T> collection)
        {
            _collection = collection ?? throw new ArgumentNullException(nameof(collection));
        }

        public bool Contains(T item)
        {
            return _collection.Contains(item);
        }

        public T FindFirst(Predicate<T> predicate)
        {
            if (predicate == null)
                throw new ArgumentNullException(nameof(predicate));

            return _collection.FirstOrDefault(item => predicate(item));
        }

        public IEnumerable<T> FindAll(Predicate<T> predicate)
        {
            if (predicate == null)
                throw new ArgumentNullException(nameof(predicate));

            return _collection.Where(item => predicate(item));
        }

        public T GetByIndex(int index)
        {
            if (_collection is IList<T> list)
            {
                return list[index];
            }
            throw new NotSupportedException("Коллекция не поддерживает доступ по индексу.");
        }

        public int IndexOf(T item)
        {
            if (_collection is IList<T> list)
            {
                return list.IndexOf(item);
            }
            throw new NotSupportedException("Коллекция не поддерживает поиск по индексу.");
        }
    }
}
