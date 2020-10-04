using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumMeum
{
 public class Album<T>
	{
		public int count;
		public int capacity;
		private T[] _items;

		// Store Values in Array
		public Album()		// Initializes a new instance of the AlbumMeum class that is empty (0) and has the default initial capacity (4).

		{
			count = 0;		// Number of objects in new array
			capacity = 4;		// Open array positions
			_items = new T[capacity];		// _items is a new array containing 4 of Generic Type T
		}
		// Read-Only Count Property

		// Public Capacity Property

		// Indexer
		public T this[int index]		// Gets or Sets element at specified index
		{
			get
			{
				if (index >= 0 && index < count)
				{
					return _items[index];
				}

				throw new ArgumentOutOfRangeException($"{index} is out of Album Range.");
			}

			set
			{
				if (index >= 0 && index < count)
				{
					_items[index] = value;
				}
				else
				{
					throw new ArgumentOutOfRangeException($"{index} is out of Album Range.");
				}
			}
		}

		// -->Add Method
		public void Add(T item)   // Adds an object (item) to the end of the AlbumMeum
		{
			_items[count] = item;		// item is added to _items array at index position of current count
			count++;		// Increase count by one to fill in empty array positions in sequence
			if(count >= capacity)
			{

				T[] _itemsNew =  new T[capacity *= 2];    // Ensures empty array positions by doubling available size of array when adding multiple (item)
				_items = _items.Concat(_itemsNew).ToArray();		// Appends empty array positions to end current array
			}
		}
		// -->Remove Method

		// ToString Override

		// + Operator Overloader

		// - Operator Overloader

		// Zipper

		// Iterability
		//public IEnumerator<T> GetEnumerator()   // Returns an enumerator that iterates through the AlbumMeum
		//{
		//	for (int i = 0; i < count; i++)
		//	{
		//		yield return _items	[i];
		//	}
		//}
		//IEnumerator IEnumerable.GetEnumerator()
		//{
		//	return GetEnumerator();
		//}

		// ** Sort Instance **

		// Documentation
	}
}
