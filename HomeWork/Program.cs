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

Console.Clear();
Task41();





