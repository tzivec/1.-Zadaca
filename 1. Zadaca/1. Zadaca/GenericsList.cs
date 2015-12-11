using System;
using System.Collections;
using System.Collections.Generic;

namespace _1.Zadaca
{
    public class GenericsList<X> : IGenericList<X>
    {
        private int _count;
        private X[] _internalStorage;

        public GenericsList()
        {
            _count = 0;
            _internalStorage = new X[4];
        }

        ///<summary>
        ///Readonly property.Gets the number of items contained in the collection.
        ///</summary>
        public int Count
        {
            get { return _count; }
        }

        ///<summary>
        ///Adds an item to the collection.
        ///</summary>
        public void Add(X item)
        {
            if (_count >= _internalStorage.Length)
            {
                X[] t = new X[_internalStorage.Length * 2];
                for (int i = 0; i < _internalStorage.Length; i++)
                {
                    t[i] = _internalStorage[i];
                }
                _internalStorage = t;
            }
            _internalStorage[_count++] = item;
        }

        ///<summary>
        ///Removes all items from the collection.
        ///</summary>
        public void Clear()
        {
            _count = 0;
        }

        ///<summary>
        ///Determines whether the collection contains a specific value.
        ///</summary>
        public bool Contains(X item)
        {
            for (int i = 0; i < _count; i++)
            {
                if (_internalStorage[i].Equals(item))
                {
                    return true;
                }
            }
            return false;
        }

        ///<summary>
        ///Returns the item at the given index in the collection.
        ///</summary>
        public X GetElement(int index)
        {
            if (index < _count)
            {
                return _internalStorage[index];
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        ///<summary>
        ///Returns the index of the item in the collection.
        ///If item is not found in the collection, method returns -1.
        ///</summary>
        public int IndexOf(X item)
        {
            for (int i = 0; i < _count; i++)
            {
                if (_internalStorage[i].Equals(item))
                {
                    return i;
                }
            }
            throw new NullReferenceException();
        }

        ///<summary>
        ///Removes the first occurrence of an item from the collection.
        ///If the item was not found, method does nothing.
        ///</summary>
        public bool Remove(X item)
        {
            for (int i = 0; i < _count; i++)
            {
                if (_internalStorage[i].Equals(item))
                {
                    return RemoveAt(i);
                }
            }
            return false;
        }

        ///<summary>
        ///Removes the item at the given index in the collection.
        ///</summary>
        public bool RemoveAt(int index)
        {
            if (index >= _count)
            {
                return false;
            }
            else
            {
                for (int i = index; i < _count; i++)
                {
                    _internalStorage[i] = _internalStorage[i + 1];
                }
                _count--;
                return true;
            }
        }

        public IEnumerator<X> GetEnumerator()
        {
            return new GenericListEnumerator<X>(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}