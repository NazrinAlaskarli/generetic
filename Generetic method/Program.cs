namespace Generetic_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Number<int>(3));
            ChangeValue<int>(5, 6);
        }
        static T Number<T>(T value1)
        {
            return value1;
        }

        static void ChangeValue<T>(T value1, T value2)
        {
            T value3;
            value3 = value1;
            value1 = value2;
            value2= value3;

            Console.WriteLine($" {value1}, {value2}");
        }


    }

}
