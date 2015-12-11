using System;

namespace _1.Zadaca
{
    /// <summary>
    /// 
    /// </summary>
    public class IntegerList : IIntegerList
    {
        private int[] _internalStorage;
        private int _count;

        /// <summary>
        /// 
        /// </summary>
        public IntegerList()
        {
            _internalStorage = new int[4];
            _count = 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="initialSize"></param>
        public IntegerList(int initialSize)
        {
            _internalStorage = new int[initialSize];
            _count = 0;
        }


        ///<summary>
        ///Readonly property.Gets the number of items contained in the collection.
        ///</summary>
        public int Count
        {
            get
            {
                return _count;
            }
        }

        ///<summary>
        ///Adds an item to the collection.
        ///</summary>
        public void Add(int item)
        {
            if (_count >= _internalStorage.Length)
            {
                int[] t = new int[_internalStorage.Length * 2];
                for(int i=0; i<_internalStorage.Length; i++)
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
            for(int i = 0; i < _count; i++)
            {
                _internalStorage[i] = 0;
            }
            _count = 0;
        }

        ///<summary>
        ///Determines whether the collection contains a specific value.
        ///</summary>
        public bool Contains(int item)
        {
            for (int i = 0; i < _count; i++)
            {
                if(_internalStorage[i] == item)
                {
                    return true;
                }
            }
            return false;
        }

        ///<summary>
        ///Returns the item at the given index in the collection.
        ///</summary>
        public int GetElement(int index)
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
        public int IndexOf(int item)
        {
            for (int i = 0; i < _count; i++)
            {
                if (_internalStorage[i] == item)
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
        public bool Remove(int item)
        {
            for(int i = 0; i < _count; i++)
            {
                if (_internalStorage[i] == item)
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
                for(int i = index; i < _count; i++)
                {
                    _internalStorage[i] = _internalStorage[i + 1];
                }
                _count--;
                return true;
            }
        }
    }
}