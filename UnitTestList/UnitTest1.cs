using System;
using MyCusList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestList
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddInt()
        {
            ListProperties<int> list = new ListProperties<int>();
            int anticipatedOutcome =;
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(5);

            Assert.AreEqual(anticipatedOutcome, list[5]);
        }
        [TestMethod]
        public void TestNegNumbers()
        {
            ListProperties<int> list = new ListProperties<int>();

            int anticipatedOutcome = -17;
            list.Add(-5);
            list.Add(-3);
            list.Add(-1);
            Assert.AreEqual(anticipatedOutcome, UnitTestList[1]);
        }
        [TestMethod]
        public void StringAdded()
        {
            ListProperties<string> list = new ListProperties<string>();
            string anticipatedOutcome = "";

            list.Add("");
            list.Add("");

            Assert.AreNotSame(anticipatedOutcome, list[1]);
        }
        [TestMethod]
        public void TestForDouble()
        {
            ListProperties<double> list = new ListProperties<double>();
            double anticipatedOutcome = 20.18;
            list.Add(.25);
            list.Add(19.91);

            Assert.AreNotSame(anticipatedOutcome, list[0]);
        }
        [TestMethod]
        public void TestSubstractString()
        {
            ListProperties<string> list = new ListProperties<string>();
            string[] testArray = new string[5] {"1"}
            list.Remove("");
            Assert.IsFalse(false, "");
        } 
        [TestMethod]
        public void TestIntCount()
        {
            ListProperties<int> list = new ListProperties<int>() { 1, 2, 3, 4, 5 };
            int anticipatedOutcome = 3;
            int realOutcome = list.Count;
            Assert.AreEqual(anticipatedOutcome, realOutcome);
        }
        [TestMethod]
        public void TestStringCount()
        {
            ListProperties<string> list = new ListProperties<string>() { "" };
            int anticipatedOutcome = 2;
            int realOutcome = list.Count;
            Assert.AreEqual(anticipatedOutcome, realOutcome);

        }
        [TestMethod]
        public void TestUncertainCount()
        {
            ListProperties<double> list = new ListProperties<double> { 198.01, 199.10, 201.06, 202.15, 363.75 };
            int anticipatedOutcome = 4;
            int realOutcome = list.Count;
            Assert.AreNotEqual(anticipatedOutcome, realOutcome);
        }
        public void TestRemoveNumber()
        {
            ListProperties<int> list = new ListProperties<int>;
            int[] testNumberArray = new int[5] { 1, 2, 3, 4, 5 };
            list.Remove(1);
            Assert.IsFalse(false);
        }
        [TestMethod]
        public void TestToString()
        {
            ListProperties<string> list = new ListProperties<string>() { "" };

        }

    }
}
