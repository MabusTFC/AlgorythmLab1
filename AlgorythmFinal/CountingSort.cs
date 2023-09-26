namespace AlgorithmsAnalysis
{
    public class CountingSort : IResercheable
    {
        public override void Run(int[] array, int value = 0)
        {
            CountingSortAlgorithm(array);
        }

        static void CountingSortAlgorithm(int[] arr)
        {
            int max = FindMaxValue(arr);

            int[] count = new int[max + 1];
            int[] output = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
                count[arr[i]]++;

            for (int i = 1; i <= max; i++)
                count[i] += count[i - 1];

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                output[count[arr[i]] - 1] = arr[i];
                count[arr[i]]--;
            }

            for (int i = 0; i < arr.Length; i++)
                arr[i] = output[i];
        }

        static int FindMaxValue(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }
            return max;
        }

        public CountingSort(int size, string name) : base(size, name)
        {
        }
    }
}