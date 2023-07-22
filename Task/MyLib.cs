
namespace MyLib;
public static class MyLibClass
{
    public static int Input(string text)
    {
        Console.Write(text);
        return Convert.ToInt32(Console.ReadLine());
    }

    public static void FillArray(int[]array, int minValue =-9, int maxValue = 9)
    {
        maxValue++;
        for(int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(minValue, maxValue); 
        }

    }

    public static void FillArray(double[]array)
    {
        for(int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().NextDouble() * 10; 
            array[i] = Math.Round(array [i],2);
        }


    }


    public static void PrintArray(int[]array)
    {
        for(int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]}, ");
        }
        Console.WriteLine();
    }

    public static void PrintArray(double[]array)
    {
        for(int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]}, ");
        }
        Console.WriteLine();
    }

        
    


    }
