﻿namespace AlgorithmsAnalysis
{
    public class MergeSort : IResercheable
    {
        public override void Run(int[] array, int value = 0)
        {
            MergeSortAlgorithm(array, 0, array.Length - 1);
        }
        // рекурсивную реализацию алгоритма сортировки слиянием (Merge sort) для массива целых чисел.
        static void MergeSortAlgorithm(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;

                MergeSortAlgorithm(arr, left, mid); // сортировка левой части массива
                MergeSortAlgorithm(arr, mid + 1, right);// сортировка правой части массива 

                Merge(arr, left, mid, right); 
            }
        }
        // метод слияние отсортированных массивов
        static void Merge(int[] arr, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            int[] leftArr = new int[n1];
            int[] rightArr = new int[n2];

            for (int i = 0; i < n1; ++i)
                leftArr[i] = arr[left + i];

            for (int j = 0; j < n2; ++j)
                rightArr[j] = arr[mid + 1 + j];

            int k = left;
            int leftIndex = 0;
            int rightIndex = 0;

            while (leftIndex < n1 && rightIndex < n2)
            {
                if (leftArr[leftIndex] <= rightArr[rightIndex])
                {
                    arr[k] = leftArr[leftIndex];
                    leftIndex++;
                }
                else
                {
                    arr[k] = rightArr[rightIndex];
                    rightIndex++;
                }
                k++;
            }

            while (leftIndex < n1)
            {
                arr[k] = leftArr[leftIndex];
                leftIndex++;
                k++;
            }

            while (rightIndex < n2)
            {
                arr[k] = rightArr[rightIndex];
                rightIndex++;
                k++;
            }
        }
        // инцилизация 
        public MergeSort(int size, string name) : base(size, name)
        {
        }
    }
}