// Задание 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

using System;
					
public class Program
{
	public static void Main()
	{
		

		Console.Write("Введите неотрицательное число m: "); 
        int m = Convert.ToInt32(Console.ReadLine()); 
 
        Console.Write("Введите неотрицательное число n: "); 
        int n = Convert.ToInt32(Console.ReadLine());
		
		int AkkermanFunc(int m, int n)
		{
			if(m == 0)
			{
				return n + 1;
			}
			if(m > 0 && n == 0)
			{
				return AkkermanFunc(m - 1, 1);
			}
			return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
		}
		
		int result = AkkermanFunc(m, n); 
        Console.WriteLine($"Значение функции Аккермана для ({m}, {n}) равно: {result}");
	}
}