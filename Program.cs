namespace DZ_5th_lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] CreateArray()
            {
                int array_size = new Random().Next(1, 11);
                int[] _array = new int[array_size];

                for (int i = 0; i < _array.Length; i++)
                {
                    _array[i] = new Random().Next(100, 1000);                    
                }
                return _array;
            }

            int[] dz_array = CreateArray();            

            int count = 0;

            foreach (int i in dz_array)
            {
                count += i % 2 == 0 ? 1 : 0;
            }
            Console.WriteLine($"[{String.Join(", ", dz_array)}]\n");
            Console.WriteLine(count);            
        }
    }
}