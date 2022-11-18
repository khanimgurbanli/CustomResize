namespace Exercises
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = GetValue();
            double numSum= Sum(numbers);

            Console.WriteLine($"Numbers sum is : {numSum}");
        }

        static int[] GetValue()
        {
            int[] array = new int[0];
            bool check = true;
            int intNumber;

            for (int i = 0; i < 2; i++)
            {
                do
                {
                    Console.WriteLine("Enter the any number");
                    string data = Console.ReadLine();
                    bool returnResult = Check(data, out intNumber);

                    if (returnResult) check = false;

                } while (check);

                Array.Resize(ref array,i+1);
                array[i] = intNumber;
            }
            return array;
        }

        static bool Check(string data, out int intNumber)
        {
            bool isNumber = int.TryParse(data, out intNumber);

            return isNumber;
        }

        static double Sum(int[] arr)
        {
            double sum=0;   

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
    }
}
