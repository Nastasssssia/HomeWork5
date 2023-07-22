using MyLib;
namespace Task;
class Program
{
    static void Main(string[] args)
    {
        void Task34()
        {
            //Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
            int size = MyLibClass.Input("Введите размер массива:");
            int []array = new int[size];
            MyLibClass.FillArray(array,100, 999);
            MyLibClass.PrintArray(array);
            int count = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] % 2 == 0) count++;
            }
            Console.WriteLine($"Количество четных чисел: {count}");
        }


        void Task36()
        {
            // Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов с нечётными индексами.
            int size = MyLibClass.Input("Введите размер массива:");
            int []array = new int[size];
            MyLibClass.FillArray(array,1, 15);
            MyLibClass.PrintArray(array);
            int sum = 0;
            for(int i = 1; i < array.Length; i+=2)
            {
                sum += array[i];    
            }
            Console.WriteLine( $"Сумма элементов с нечетными индексами = {sum}");
        }

        void Task38()
        {
            //Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
            int size = MyLibClass.Input("Введите размер массива:");
            double []array = new double[size];
            MyLibClass.FillArray(array);
            MyLibClass.PrintArray(array);
            double max = array[0];
            double min = array[0];
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] > max) max = array[i];
                else if(array [i] < min) min = array [i];
            }
            Console.WriteLine($"Разница между максимальным элементом массива {max} и минимальным элементом массива {min} = {max - min}");
           

        }
        
    }
}
