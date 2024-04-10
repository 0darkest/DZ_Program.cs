// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1

using System; 
 
class Program 
{ 
    static void Main() 
    { 
        int[] myArray = { 1, 2, 5, 0, 10, 34 }; 
 
        Console.WriteLine("Элементы массива, начиная с конца:"); 
        PrintArrayReverse(myArray, myArray.Length - 1); 
    } 
 
    static void PrintArrayReverse(int[] arr, int index) 
    { 
        if (index >= 0) 
        { 
            Console.Write(arr[index] + " "); 
            PrintArrayReverse(arr, index - 1); 
        } 
    } 
}