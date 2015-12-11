using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Zadaca
{
    class GenericListEnumerator<T> : IEnumerator<T>
    {
        private IGenericList<T> _collection;
        private int _position ;
        private T _current;

        public GenericListEnumerator(IGenericList<T> collection)
        {
            _collection = collection;
            _position = 0;
        }

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            if (_collection.Count > _position)
            {
                _current = _collection.GetElement(_position);
                _position++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
        }

        public T Current
        {
            get { return _current; }
        }

        object IEnumerator.Current
        {
            get { return Current; }
        }
    }
}
