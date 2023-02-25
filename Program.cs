namespace DZ_5th_lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] CreateArray()
            {
                int array_size = new Random().Next(3, 11);
                int[] _array = new int[array_size];

                for (int i = 0; i < _array.Length; i++)
                {
                    _array[i] = new Random().Next(100, 1000);                    
                }                
                return _array;
            }                       

            int sum_of_odd_elements(int[] _array)
            {
                int sum =0;

                for (int i = 1; i < _array.Length; i += 2)
                {
                    sum += _array[i];
                }

                return sum;
            }

            int[] dz_array = CreateArray();

            int sum = sum_of_odd_elements(dz_array);

            Console.WriteLine(sum);            
        }
    }
}