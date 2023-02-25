namespace DZ_5th_lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] CreateArray()
            {
                int array_size = new Random().Next(1, 11);
                double[] _array = new double[array_size];

                for (int i = 0; i < _array.Length; i++)
                {
                    _array[i] = new Random().Next(100, 1000);                    
                }
                return _array;
            }                       

            double The_difference_between_max_min(double[] _dz)
            {
                double defference;

                double max = _dz[1], min = _dz[0];

                if (_dz[1] < _dz[0])
                {
                    min = _dz[1];
                    max = _dz[0];
                }

                for (int i = 2; i < _dz.Length; i++)
                {                    
                    if (_dz[i] < min)
                    {
                        min = _dz[i];
                    }
                    if (_dz[i] > max)
                    {
                        max = _dz[i];
                    }
                }
                defference = max - min;
                return defference;
            }

            double[] dz_array = CreateArray();            

            Console.WriteLine($"[{String.Join(", ", dz_array)}] -> {The_difference_between_max_min(dz_array)}");                       
        }
    }
}