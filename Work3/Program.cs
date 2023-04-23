//  Напишите программу, которая задаёт массив из 8 элементов (от -10 до 10) и выводит их на экран.

// 1, 2, 5, 7, 9 -> [1, 2, 5, 7, 9]

// 6, 1, 3 -> [6, 1, 3]

int[] array = new int[10]; // arraySize == 4 - размер (количество)

for (int i = 0; i < array.Length; i++) // заполнение массива
{
    int randomNumber = new Random().Next(-10, 11); // генерируем случайное число
    array[i] = randomNumber; // кладём в массив на место с индексом i
}

for (int i = 0; i < array.Length; i++) // вывод массива в консоль
{
    Console.Write(array[i] + "  ");
}
 Console.WriteLine();

Console.WriteLine("Массив: [" + string.Join(", ", array) + "]");

