void Exit()
{
    Console.Write("Нажмите любою клавишу... ");
    Console.ReadKey();
}
void Zadach41()
{
    //Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
    Console.Clear();
    Console.Write("Введите размер массива чисел М: ");
    double[] array = FillArray();
    PrintArray(array);
    PrintCount(array);
}

double[] FillArray()
{
    Random random = new Random();
    int input = Convert.ToInt32(Console.ReadLine());
    double[] array = new double[input];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите число № {i+1}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());

    }
    return array;
}
void PrintArray(double[] array)
{
    Console.WriteLine("[" + String.Join("; ", array) + "]");
}
void PrintCount(double[] array)
{
     int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    Console.WriteLine("C колько чисел больше 0: " + count);
}

Zadach41();
Exit();