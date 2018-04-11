using Generics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using MyCusList;
namespace UnitTestList
{
    [TestClass]

    public class UnitTest1
    {
        //Add method tests
        [TestMethod]
        public void Add_MultiInts_ImprovedArray()
        {
            // Arrange
            ListProperties<int> list = new ListProperties<int>();
            ListProperties<int> expected = new ListProperties<int>() { 1, 2, 3 };
            // Act 

            list.Add(1);
            list.Add(2);
            list.Add(3);
            Assert.AreEqual(list[0], expected[0]);
        }
        [TestMethod]
        public void Add_MultiStrings_ImprovedArray()
        {
            // Arrange
            ListProperties<string> list = new ListProperties<string>();
            ListProperties<string> expected = new ListProperties<string>() { "One", "Two", "Three" };
            // Act 
            list.Add("One");
            list.Add("Two");
            list.Add("Three");

            // Assert
            Assert.AreEqual(expected[0], list[0]);
        }
        [TestMethod]
        public void Add_SingleInt_IncreaseCount()
        {
            // Arrange
            ListProperties<int> list = new ListProperties<int>();
            ListProperties<int> expected = new ListProperties<int>() { 1 };
            // Act 
            list.Add(1);
            // Assert
            Assert.AreEqual(expected.Count, list.Count);
        }
        [TestMethod]
        public void Add_SingleInt_ArrayLoads()
        {
            // Arrange
            ListProperties<int> list = new ListProperties<int>();

            // Act 
            list.Add(1);
            int expected = 1;
            // Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void Add_Objects_ImproveArray()
        {
            // Arrange
            ListProperties<object> list = new ListProperties<object>();
            ListProperties<object> expected = new ListProperties<object>() { 1 };
            // Act 
            list.Add(1);
            int[] result = new int[] { 1 };
            // Assert
            Assert.AreEqual(expected.Count, list.Count);
        }
        [TestMethod]
        public void Add_Ints_IncreaseCount()
        {
            // Arrange
            ListProperties<int> list = new ListProperties<int>();
            // Act 
            list.Add(1);
            list.Add(2);
            list.Add(3);
            int result = 3;
            // Assert
            Assert.AreEqual(result, list.Count);
        }
        [TestMethod]
        public void Add_MultiObjects_SizeExpands()
        {
            // Arrange
            ListProperties<object> list = new ListProperties<object>();
            // Act
            object obj = new object();
            list.Add(obj);
            list.Add(obj);
            list.Add(obj);
            list.Add(obj);
            list.Add(obj);
            list.Add(obj);
            list.Add(obj);
            list.Add(obj);
            list.Add(obj);
            list.Add(obj);
            list.Add(obj);
            list.Add(obj);
            list.Add(obj);
            list.Add(obj);
            list.Add(obj);
            list.Add(obj);
            list.Add(obj);
            list.Add(obj);
            list.Add(obj);
            int expected = 19;
            // Assert
            Assert.AreEqual(expected, list.Count);

        }

        [TestMethod]
        public void Count_StartAtZero_CountEqualZero()
        {
            // Arrange
            ListProperties<int> list = new ListProperties<int>();

            // Act
            int expected = 0;

            // Assert
            Assert.AreEqual(expected, list.Count);
        }
        //Remove method tests
        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void Remove_EveryInts_ThrowException()
        {
            // Arrange
            ListProperties<int> list = new ListProperties<int>();
            list.Add(1);
            int notExpected = 1;
            // Act
            list.Remove(1);
            // Assert
            Assert.AreNotEqual(notExpected, list[0]);
        }

        [TestMethod]
        public void Remove_SingleInt_CountGoesDown()
        {
            // Arrange
            ListProperties<int> list = new ListProperties<int>();
            list.Add(1);
            list.Add(1);
            list.Add(1);
            list.Add(1);
            // Act
            int notExpected = list.Count;
            list.Remove(1);
            // Assert
            Assert.AreNotEqual(notExpected, list.Count);
        }
        [TestMethod]
        public void Remove_SingleString_IndexChange()
        {
            // Arrange
            ListProperties<string> list = new ListProperties<string>() { "One", "Two", "Three" };
            string one = "One";
            // Act

            list.Remove(one);
            string expected = "Three";
            // Assert
            Assert.AreEqual(expected, list[1]);
        }
        [TestMethod]
        public void Remove_MultiInts_IndexChange()
        {
            // Arrange
            ListProperties<int> list = new ListProperties<int>() { 0, 1, 2, 3, 4, 5, 6, 7 };
            int expected = 7;
            // Act
            list.Remove(0);
            list.Remove(3);
            // Assert
            Assert.AreEqual(expected, list[5]);
        }
        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void Remove_Objects_ThrowException()
        {
            // Arrange
            ListProperties<object> list = new ListProperties<object>();
            object notExpected = list;
            // Act
            list.Add(list);
            list.Add(list);
            list.Add(list);
            list.Remove(list);
            list.Remove(list);
            list.Remove(list);
            // Assert
            Assert.AreNotEqual(notExpected, list[0]);
        }
        [TestMethod]
        public void Remove_SingleObject_CountGoesDown()
        {
            // Arrange
            ListProperties<object> list = new ListProperties<object>();
            list.Add(list);
            list.Add(list);
            // Act
            int expected = 1;
            list.Remove(list);
            // Assert
            Assert.AreEqual(expected, list.Count);
        }
        [TestMethod]
        public void Remove_Object_ResultEqualsTrue()
        {
            // Arrange
            ListProperties<object> list = new ListProperties<object>();
            list.Add(list);
            list.Add(list);
            // Act
            bool expected = true;
            bool remove = list.Remove(list);
            // Assert
            Assert.AreEqual(expected, remove);
        }
        [TestMethod]
        public void Remove_Nothing_ResultEqualsFalse()
        {
            // Arrange
            ListProperties<object> list = new ListProperties<object>();
            // Act
            bool expected = false;
            bool remove = list.Remove(list);
            // Assert
            Assert.AreEqual(expected, remove);
        }
        [TestMethod]
        public void ToString_ThreeStrings_ReturnOneString()
        {
            // Arrange
            ListProperties<string> list = new ListProperties<string>() { "One", "Two", "Three" };
            // Act
            string expected = "OneTwoThree";
            string result = list.ToString();
            // Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void ToString_MultiInts_ReturnOneString()
        {
            // Arrange
            ListProperties<int> list = new ListProperties<int>() { 1, 1, 4 };
            // Act
            string expected = "114";
            string result = list.ToString();
            // Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void ToString_EmptyList_ReturnEmptyString()
        {
            // Arrange
            ListProperties<string> list = new ListProperties<string>();
            // Act
            string expected = "";
            string result = list.ToString();
            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ToString_Bools_ReturnOneString()
        {
            // Arrange
            ListProperties<bool> list = new ListProperties<bool>() { true, false, true };
            // Act
            string expected = "TrueFalseTrue";
            string result = list.ToString();
            // Assert
            Assert.AreEqual(expected, result);
        }
        // Plus Operator Test Methods
        [TestMethod]
        public void Plus_Strings_ConcatLists()
        {
            // Arrange
            ListProperties<string> list = new ListProperties<string>() { "One", "Two" };
            // Act
            list = list + list;
            string expected = "Two";
            // Assert
            Assert.AreEqual(expected, list[3]);
        }
        [TestMethod]
        public void Plus_Ints_CountIncrease()
        {
            // Arrange
            ListProperties<int> list = new ListProperties<int>() { 1, 2, 3 };
            // Act
            list = list + list;
            int expected = 6;
            // Assert
            Assert.AreEqual(expected, list.Count);
        }
        [TestMethod]
        public void Plus_EmptyList_ConcatLists()
        {
            ListProperties<string> list = new ListProperties<string>() { "One", "Two" };
            ListProperties<string> empty = new ListProperties<string>();
            // Act
            empty = list + empty;
            string expected = "Two";
            // Assert
            Assert.AreEqual(expected, empty[1]);
        }
        [TestMethod]
        public void Plus_StringToEmpty_CountIdles()
        {
            ListProperties<string> list = new ListProperties<string>() { "One", "Two" };
            ListProperties<string> empty = new ListProperties<string>();
            // Act
            empty = list + empty;
            int expected = 2;
            // Assert
            Assert.AreEqual(expected, empty.Count);

        }
        [TestMethod]
        public void Plus_Bools_ListsConcat()
        {
            // Arrange
            ListProperties<bool> list = new ListProperties<bool>() { true, false };
            // Act
            list = list + list;
            bool expected = true;
            // Assert
            Assert.AreEqual(expected, list[2]);
        }
        // Minus Operator Test Methods
        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void Minus_Bools_ThrowException()
        {
            // Arrange
            ListProperties<bool> list = new ListProperties<bool>() { true, true, true };
            // Act
            bool notExpected = true;
            list = list - list;
            // Assert
            Assert.AreNotEqual(notExpected, list[0]);
        }
        [TestMethod]
        public void Minus_Strings_IndexShifts()
        {
            // Arrange
            ListProperties<string> list = new ListProperties<string>() { "true", "true", "false" };
            ListProperties<string> otherList = new ListProperties<string>() { "true" };
            // Act
            string expected = "false";
            list = list - otherList;
            // Assert
            Assert.AreEqual(expected, list[1]);
        }
        [TestMethod]
        public void Minus_Bools_CountDecrease()
        {
            // Arrange
            ListProperties<bool> list = new ListProperties<bool>() { true, true, true };
            // Act
            int expected = 0;
            list = list - list;
            // Assert
            Assert.AreEqual(expected, list.Count);
        }
        [TestMethod]
        public void Minus_AllInts_CountDecrease()
        {
            // Arrange
            ListProperties<int> list = new ListProperties<int>() { 1, 4, 9 };
            // Act
            int expected = 0;
            list = list - list;
            // Assert
            Assert.AreEqual(expected, list.Count);
        }
        [TestMethod]
        public void Minus_Objects_CountDecreases()
        {
            // Arrange
            ListProperties<object> list = new ListProperties<object>() { };
            list.Add(list);
            // Act
            int expected = 0;
            list = list - list;
            // Assert
            Assert.AreEqual(expected, list.Count);
        }
        // Zip TestMethods
        [TestMethod]
        public void ZipListProperties_ListPropertiesString_ListPropertiesZipped()
        {
            //Arrange
            ListProperties<string> expectedResult = new ListProperties<string>();
            expectedResult.Add("A");
            expectedResult.Add("B");
            expectedResult.Add("C");
            expectedResult.Add("D");
            ListProperties<string> stringsA = new ListProperties<string>();
            ListProperties<string> stringsB = new ListProperties<string>();
            ListProperties<string> actualResult = new ListProperties<string>();
            stringsA.Add("A");
            stringsA.Add("C");
            stringsB.Add("B");
            stringsB.Add("D");

            //Act
            actualResult = stringsA.Zip(stringsB);

            //Assert
            Assert.AreEqual(expectedResult.ToString(), actualResult.ToString());
        }

        [TestMethod]
        public void ZipListProperties_ListPropertiesint_ListPropertiesZipped()
        {
            //Arrange
            ListProperties<int> expectedResult = new ListProperties<int>() { 1, 2, 3, 4 };
            ListProperties<int> numbers = new ListProperties<int>();
            ListProperties<int> moreNumbers = new ListProperties<int>();
            ListProperties<int> actualResult = new ListProperties<int>();
            numbers.Add(1);
            numbers.Add(3);
            moreNumbers.Add(2);
            moreNumbers.Add(4);

            //Act
            actualResult = numbers.Zip(moreNumbers);

            //Assert
            Assert.AreEqual(expectedResult.ToString(), actualResult.ToString());
        }

        [TestMethod]
        public void ZipListProperties_ListPropertiesobject_ListPropertiesZipped()
        {
            //Arrange
            ListProperties<Objects> objectsA = new ListProperties<Objects>();
            ListProperties<Objects> objectsB = new ListProperties<Objects>();
            ListProperties<Objects> actualResult = new ListProperties<Objects>();
            Objects ObjectA = new Objects();
            Objects ObjectB = new Objects();
            objectsA.Add(ObjectA);
            objectsB.Add(ObjectB);
            ListProperties<Objects> expectedResult = new ListProperties<Objects>();
            expectedResult.Add(ObjectA);
            expectedResult.Add(ObjectB);

            //Act
            actualResult = objectsA.Zip(objectsB);

            //Assert
            Assert.AreEqual(expectedResult.ToString(), actualResult.ToString());
        }

        [TestMethod]
        public void Sort_Ints_IndexShifts()
        {
            // Arrange
            ListProperties<int> list = new ListProperties<int>() { 1, 4, 10, 2 };
            // Act
            list.Sort();
            int expected = 10;
            // Assert
            Assert.AreEqual(expected, list[3]);
        }
        [TestMethod]
        public void Sort_Strings_IndexShifts()
        {
            // Arrange
            ListProperties<string> list = new ListProperties<string>() { "The", "He", "A", "Hat" };
            // Act
            list.Sort();
            string expected = "A";
            // Assert
            Assert.AreEqual(expected, list[0]);
        }
        [TestMethod]
        public void Sort_Strings_ReturnOrderedList()
        {
            // Arrange
            ListProperties<string> list = new ListProperties<string>() { "The", "He", "A", "Hat" };
            // Act
            list.Sort();
            string expected = "AHatHeThe";
            // Assert
            Assert.AreEqual(expected, list.ToString());
        }
    }
}
