// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.Write("Введи число A: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи число B: ");
int x = Convert.ToInt32(Console.ReadLine());
int y= GetSum(n,x);
Console.WriteLine(y);

int GetSum(int numbers,int number) 
{
    int step = n;
    for (int i = 1; i < number; i++)
    {
        step = step * numbers;
    }
    return step;
}
