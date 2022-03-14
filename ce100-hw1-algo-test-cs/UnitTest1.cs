using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ce100_hw1_algo_lib_cs;
using System.Collections;

namespace ce100_hw1_algo_test_cs
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InsertionShort_TestMethod1()
        {
            int[] arr = { 14, 7, 25, 67, 16, 48, 4 };
            int[] keynum = { 4, 7, 14, 16, 25, 48, 67 };

            CollectionAssert.AreEqual(Class1.InsSort(arr), keynum);
        }

        [TestMethod]
        public void InsertionShort_TestMethod2()
        {
            int[] arr = { 31, 44, 15, 77, 68, 83, 43 };
            int[] keynum = { 15, 31, 43, 44, 68, 77, 83 };

            CollectionAssert.AreEqual(Class1.InsSort(arr), keynum);
        }

        [TestMethod]
        public void InsertionShort_TestMethod3()
        {
            int[] arr = { 3, 13, 43, 93, 73, 83, 23 };
            int[] keynum = { 3, 13, 23, 43, 73, 83, 93 };

            CollectionAssert.AreEqual(Class1.InsSort(arr), keynum);
        }


        [TestMethod]
        public void SelectionShort_TestMethod1()
        {
            int[] arr = { 13, 6, 25, 66, 15, 47, 3 };
            int[] keynum = { 3, 6, 13, 15, 25, 47, 66 };

            CollectionAssert.AreEqual(Class1.SelectionSortArray(arr), keynum);
        }

        [TestMethod]
        public void SelectionShort_TestMethod2()
        {
            int[] arr = { 17, 97, 88, 67, 19, 54, 9 };
            int[] keynum = { 9, 17, 19, 54, 67, 88, 97 };

            CollectionAssert.AreEqual(Class1.SelectionSortArray(arr), keynum);
        }

        [TestMethod]
        public void SelectionShort_TestMethod3()
        {
            int[] arr = { 12, 24, 6, 95, 73, 9, 89 };
            int[] keynum = { 6, 9, 12, 24, 73, 89, 95 };

            CollectionAssert.AreEqual(Class1.SelectionSortArray(arr), keynum);
        }

        [TestMethod]
        public void NaivePower_TestMethod1()
        {
            int a = 5;
            uint b = 2;
            int result = 25;
            long c = Class1.Naivepower(a, b);
            Assert.AreEqual(c, result);
        }

        [TestMethod]
        public void NaivePower_TestMethod2()
        {
            int a = 3;
            uint b = 3;
            int result = 27;
            long c = Class1.Naivepower(a, b);
            Assert.AreEqual(c, result);
        }

        [TestMethod]
        public void NaivePower_TestMethod3()
        {
            int a = 7;
            uint b = 4;
            int result = 2401;
            long c = Class1.Naivepower(a, b);
            Assert.AreEqual(c, result);
        }

        [TestMethod]
        public void IterativebinarySearch_TestMethod3()
        {
            int[] array = { 6, 9, 11, 23, 72, 89, 91 };
            int index = 11;
            int result = 2;
            int c = Class1.IterativebinarySearch(array, index);
            Assert.AreEqual(c, result);
        }


        [TestMethod]
        public void IterativebinarySearch_TestMethod2()
        {
            int[] array = { 9, 12, 14, 26, 75, 92, 94 };
            int index = 75;
            int result = 4;
            int c = Class1.IterativebinarySearch(array, index);
            Assert.AreEqual(c, result);
        }

        [TestMethod]
        public void IterativebinarySearch_TestMethod1()
        {
            int[] array = { 10, 13, 15, 27, 76, 93, 95 };
            int index = 95;
            int result = 6;
            int c = Class1.IterativebinarySearch(array, index);
            Assert.AreEqual(c, result);
        }


        [TestMethod]
        public void RecursivebinarySearch_TestMethod1()
        {
            int[] array = { 10, 11, 12, 13, 14, 15, 16 };
            int index = 16;
            int result = 6;

            int c = Class1.BinarySearchRecursive(array, 0, 6, index);
            Assert.AreEqual(c, result);

        }


        [TestMethod]
        public void RecursivebinarySearch_TestMethod2()
        {
            int[] array = { 11, 12, 13, 14, 15, 16, 17 };
            int index = 14;
            int result = 3;

            int c = Class1.BinarySearchRecursive(array, 0, 6, index);
            Assert.AreEqual(c, result);

        }


        [TestMethod]
        public void RecursivebinarySearch_TestMethod3()
        {
            int[] array = { 12, 13, 14, 15, 16, 17, 18 };
            int index = 14;
            int result = 2;

            int c = Class1.BinarySearchRecursive(array, 0, 6, index);
            Assert.AreEqual(c, result);

        }

        [TestMethod]
        public void RecursivePower_TestMethod1()
        {
            int a = 5;
            int b = 3;
            int result = 125;
            double c = Class1.RecursivePower(a, b);
            Assert.AreEqual(c, result);
        }

        [TestMethod]
        public void RecursivePower_TestMethod2()
        {
            int a = 7;
            int b = 2;
            int result = 49;
            double c = Class1.RecursivePower(a, b);
            Assert.AreEqual(c, result);
        }

        [TestMethod]
        public void RecursivePower_TestMethod3()
        {
            int a = 2;
            int b = 2;
            int result = 4;
            double c = Class1.RecursivePower(a, b);
            Assert.AreEqual(c, result);
        }

        [TestMethod]
        public void MergeSort_TestSimple_1()
        {

            int[] Arr1 = new int[6] { 5, 8, 3, 7, 10, 50, };

            int[] Exp = new int[6] { 3, 5, 7, 8, 10, 50, };
            CollectionAssert.AreEqual(Class1.mergeSort(Arr1), Exp);
        }

        [TestMethod]
        public void MergeSort_TestSimple_2()
        {

            int[] Arr1 = new int[6] { 7, 12, 4, 9, 16, 19, };

            int[] Exp = new int[6] { 4, 7, 9, 12, 16, 19, };
            CollectionAssert.AreEqual(Class1.mergeSort(Arr1), Exp);
        }

        [TestMethod]
        public void MergeSort_TestSimple_3()
        {

            int[] Arr1 = new int[6] { 10, 17, 4, 13, 22, 28, };

            int[] Exp = new int[6] { 4, 10, 13, 17, 22, 28, };
            CollectionAssert.AreEqual(Class1.mergeSort(Arr1), Exp);
        }
    }






}