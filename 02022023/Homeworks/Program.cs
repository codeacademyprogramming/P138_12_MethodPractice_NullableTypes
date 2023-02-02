using System;

namespace Homeworks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 34, 54, 23 };

            Resize(ref numbers, 1);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine(numbers.Length);

            Add(ref numbers, 10);
            Add(ref numbers, -43);
            Add(ref numbers, 174);


            Console.WriteLine(numbers[numbers.Length-1]);

            string text = "fdfd fdf";

            Console.WriteLine(HasDigit(text));

            string sentence = "salam    Abbas necesen   yaxsisanmi?";

            var newSentence = MakeSentence(sentence);
            //salam Abbas necesen yaxsisanmi?

            Console.WriteLine(newSentence);
            Console.WriteLine(CountWords(sentence));

            int[] arr = { 45, 20, 43 };

            //Resize(ref arr, 2);
            //Array.Resize(ref arr, 2);

            //Array.Clear(arr, 1, 2);

            //Array.Reverse(arr);

            Array.Sort(arr);
            Array.Reverse(arr);


            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.WriteLine(Array.IndexOf(arr, 20));
        }

        //Verilmiş int array-ə verilmiş int dəyəri əlavə edən metod

        static void Add(ref int[] arr, int value)
        {
            int[] newArr = new int[arr.Length + 1];

            for(int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }

            newArr[newArr.Length - 1] = value;

            arr = newArr;
        }

        //Verilmis arrayin olcusunu deyisen metod.
        //5 uzunluqlu bir arrayi ve 10 deyeri gondersek, arrayimizin uzunlugu 10 olmalidir

        static void Resize(ref int[] arr, int size)
        {
            int[] newArr = new int[size];

            int count = size > arr.Length ? arr.Length:size;

            //if (size > arr.Length)
            //{
            //    count = arr.Length;
            //}
            //else
            //{
            //    count = size;
            //}

            for (int i = 0; i < count; i++)
            {
                newArr[i] = arr[i];
            }

            arr = newArr;
        }

        static bool HasDigit(string str)
        {
            for(int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                    return true;
            }

            return false;
        }

        static int CountWords(string str)
        {
            string[] arr = str.Split(' ');

            return arr.Length;
        }

        static string MakeSentence(string str)
        {
            var arr = str.Split(' ');

            string newStr = "";

            for(int i = 0;i < arr.Length; i++)
            {
                if (arr[i] != "")
                    newStr += arr[i] + " ";
            }

            return newStr.TrimEnd();
        }

    }
}
