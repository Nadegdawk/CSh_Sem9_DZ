Main();

void Main()
{
	bool isWorking = true;
	while (isWorking)
	{
		Console.Write("Input command: ");
		switch (Console.ReadLine())
		{
			case "Task64": Task64(); break;
			case "Task66": Task66(); break;
			case "Task68": Task68(); break;
			case "exit": isWorking = false; break;
		}
		Console.WriteLine();
	}
}

void Task64()
// Задача 64: Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

{
	Console.WriteLine("Output of numbers from N to 1");
	int n = ReadInt("N");
	PrintFromUntil(n);
}

void Task66()
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт
//  сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

{
    Console.WriteLine("The sum of the numbers from M to N");
	int m = ReadInt("M");
	int n = ReadInt("N");
	int sum = 0;
	if (m <= n) sum = SumDigital(m, n);
	else sum = SumDigital(n, m);
	Console.WriteLine($"Sum: {sum}");
}

void Task68()
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

{
	Console.WriteLine("Ackermann Function A(m,n)");
	int m = ReadInt("m");
	int n = ReadInt("n");
	int a = FunctionAckermann(m, n);
	Console.WriteLine($"A({m},{n}) = {a}");
}

int ReadInt(string argumentName)            //ввод данных пользователем
{
	Console.Write($"Input {argumentName}: ");
	return int.Parse(Console.ReadLine());
}

void PrintFromUntil(int n)
{
    if (n == 1)
    {
        Console.WriteLine(n);
        return;
    }
    Console.Write($"{n}, ");
    PrintFromUntil(n - 1);
}

int SumDigital(int m, int n)
{
    if (m == n)
    {
        return (m);
    }
    return m + SumDigital(m+1, n);
}

int FunctionAckermann(int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return FunctionAckermann(m - 1, 1);
    if (m > 0 && n > 0) return FunctionAckermann(m - 1, FunctionAckermann(m, n - 1));
    return FunctionAckermann(m, n);
}
