using MyLib;

// Урок 6. Одномерные массивы. Продолжение

void Task41()
{
    // Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

    int size = MyLibClass.Input("Укажите желаемое количество чисел: ");

    int[] numbers = new int[size];

    int j = 1;
    int k = 0;
    for (int i = 0; i < size; i++)
    {
        numbers[i] = MyLibClass.Input($"Введите число #{j}: ");
        if (numbers[i] > 0) k++;
        j++;
    }

    MyLibClass.PrintArray(numbers);
    Console.WriteLine($"Количество введенных положительных чисел: {k}");

}

void Task43()
{
    // Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
    // заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

    double b1 = MyLibClass.Input("Введите значение для b1: ");
    double b2 = MyLibClass.Input("Введите значение для b2: ");
    double k1 = MyLibClass.Input("Введите значение для k1: ");
    double k2 = MyLibClass.Input("Введите значение для k2: ");

    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;

    Console.WriteLine($"Точка пересечения двух прямых: A({Math.Round(x, 2)}; {Math.Round(y, 2)})");





}


Console.Clear();
Task43();





