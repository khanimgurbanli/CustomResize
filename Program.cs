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

                CountSize(ref array,i+1);
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

        static void CountSize(ref int[] arr, int size)
        {
            int[] newArray = new int[size];

            for (int i = 0; i < arr.Length; i++)
            {
                newArray[i] = arr[i];
            }
            arr = newArray;
        }
    }
    /*
    
int[] returnArr = GetValue();
Console.WriteLine($"Sum is : {Sum(returnArr)}");


static int[] GetValue()
{
    int[] numbers = new int[0];

    int count = 0;
    for (int i = 0; i < 2; i++)
    {
        int intNumber = 0;
        bool checkLoop = true;
        do
        {

            if (i == count) Console.WriteLine($"Enter please {count+1}. number must be different from 0");
            string numb = Console.ReadLine();

            bool returnResult = CheckNumber(numb,out intNumber);


            if (returnResult) checkLoop = false;

        } while (checkLoop);

        Resize(ref numbers, i + 1);
        numbers[i] = intNumber;

        count++;
    }

    return numbers;
}

static bool CheckNumber( string data,out int number)
{
    bool checkNumber = int.TryParse(data, out number);
    if (checkNumber && number > 0) return checkNumber;
    else return false;
}

static double Sum(int[] arr)
{
    double sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        sum += arr[i];
    }
    return sum;
}

static void Resize(ref int[] arr, int size)
{
    int[] myNewArr = new int[size];
    if (arr.Length > size)
    {
        for (int i = 0; i < size; i++)
        {
            myNewArr[i] = arr[i];
        }
        arr = myNewArr;
    }
    else if(arr.Length < size)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            myNewArr[i] = arr[i];
        }
        arr = myNewArr;
    }
}
    */
}
