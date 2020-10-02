using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlbumMeum;
using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Linq;

namespace AlbumMeum.Tests
{
	[TestClass()]
	public class AlbumTests
	{
		[TestMethod()]
		public void Add_FourPositiveValues_CountOfFour()
		{
			// Arrange
			Album<int> album1 = new Album<int>();
			int value1 = 1;
			int value2 = 2;
			int value3 = 3;
			int value4 = 4;
			int expected = 4;		// Should have 4 items in list at end of test
			int actual;					//	Result of test
			// Act
			album1.Add(value1);
			album1.Add(value2);
			album1.Add(value3);
			album1.Add(value4);
			actual = album1.count;    // Retrieves number of items in list and returns as int
			// Assert
			Assert.AreEqual(expected, actual);		// Tests if equal, throws exception if they are not
		}

		[TestMethod()]
		public void Add_FourPositiveValues_IncreaseCapacity()
		{
			// Arrange
			Album<int> album1 = new Album<int>();
			int value1 = 1;
			int value2 = 2;
			int value3 = 3;
			int value4 = 4;
			int expected = 8;   // Should have 8 array positions in list at end of test
			int actual;         //	Result of test
			// Act
			album1.Add(value1);
			album1.Add(value2);
			album1.Add(value3);
			album1.Add(value4);
			actual = album1.capacity;		// Retrieves number of available array positions and returns as int
			// Assert
			Assert.AreEqual(expected, actual);    // Tests if equal, throws exception if they are not
		}

		[TestMethod()]
		public void Add_ThreePositiveValues_OneAtZeroIndex()		// Using three list objects because a fourth generates a new array, erasing current array objects
		{
			// Arrange
			Album<int> album1 = new Album<int>();
			int value1 = 1;
			int value2 = 2;
			int value3 = 3;
			int expected = 1;
			int actual;         //	Result of test
			// Act
			album1.Add(value1);
			album1.Add(value2);
			album1.Add(value3);
			actual = album1[0];   // Retrieves value at initial array position and returns as int
			// Assert
			Assert.AreEqual(expected, actual);    // Tests if equal, throws exception if they are not
		}

	}
}