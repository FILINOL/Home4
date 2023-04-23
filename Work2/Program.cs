//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.Write("Введите число: ");
string str = Console.ReadLine();
int sum = 0;


for (int i = 0; i < str.Length; i++)
{
    int currentNumber = int.Parse(str[i].ToString());
    sum += currentNumber; // sum = sum + currentNumber
}
Console.WriteLine(sum);



