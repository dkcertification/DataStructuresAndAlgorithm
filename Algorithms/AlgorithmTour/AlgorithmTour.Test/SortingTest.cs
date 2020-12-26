﻿using AlgorithmConcepts.Concepts;
using NUnit.Framework;
using System;

namespace AlgorithmTour.Test
{
    [TestFixture]
    public class SortingTest
    {
        private int[][] Samples()
        {
            int[][] samples = new int[9][];
            samples[0] = new int[] { 1 };
            samples[1] = new int[] { 2, 1 };
            samples[2] = new int[] { 2, 1, 3 };
            samples[3] = new int[] { 1, 1, 1 };
            samples[4] = new int[] { 2, -1, 3, 3 };
            samples[5] = new int[] { 4, -5, 3, 3 };
            samples[6] = new int[] { 0, -5, 3, 3 };
            samples[7] = new int[] { 0, -5, 3, 0 };
            samples[8] = new int[] { 3, 2, 5, 5, 1, 0, 7, 8 };
            return samples;
        }
        
        private void RunTestsForSortAlgorithm(Action<int[]> sort)
        {
            foreach (var sample in Samples())
            {
                sort(sample);
                CollectionAssert.IsOrdered(sample);
                PrintOut(sample);
            }
        }

        private void PrintOut(int[] array)
        {
            TestContext.WriteLine("-------------TRACE-------------------\n");
            foreach (var item in array)
            {
                TestContext.Write(item + " ");
            }
            TestContext.WriteLine("\n------------------------------------\n");
        }

        [Test]
        public void BubbleSort_ValidInput_SortedInput()
        {

            RunTestsForSortAlgorithm(BubbleSort.Sort);
        }

        [Test]
        public void SelectionSort_ValidInput_SortedOutput()
        {
            RunTestsForSortAlgorithm(SelectionSort.Sort);
        }

        [Test]
        public void InsertionSort_ValidInput_SortedOutput()
        {
            RunTestsForSortAlgorithm(InsertionSort.Sort);
        }

        [Test]
        public void ShellSort_ValidInput_SortedOutput()
        {
            RunTestsForSortAlgorithm(ShellSort.Sort);
        }

        [Test]
        public void MergeSort_ValidInput_SortedOutput()
        {
            RunTestsForSortAlgorithm(MergeSort.Sort);
        }

        [Test]
        public void QuickSort_ValidateInput_SortedOutput()
        {
            RunTestsForSortAlgorithm(QuickSort.Sort);
        }
    }
}
