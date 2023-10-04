namespace AlgorithmsAnalysis
{
    public class Summ : IResercheable
    {
        // Запуск и суммирование
        public override void Run(int[] array, int value)
        {
            int sum = 0;
            foreach (int elem in array)
            {
                sum += elem;
            }
        }
        public Summ(int size,string name) : base(size,name)
        {
        }
    }
}