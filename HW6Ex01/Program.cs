// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();
Console.WriteLine("Задача 41.");

int[] CreateArray()
{
    Console.WriteLine("Введите числа: ");
    string? array = Console.ReadLine();
    array = array.Replace(",", "");
    array = array.Replace(".", "");

    string[] ar = array.Split(" ");
    int[] arr = new int[ar.Length];
    for (int i = 0; i < ar.Length; i++)
    {
        arr[i] = Convert.ToInt32(ar[i]);
    }
    return arr;
}

int[] Numbers = CreateArray();

void More(int[] M)
{
    int result = 0;
    for (int i = 0; i < M.Length; i++)
    {
        if (M[i] > 0)
        {
            result = result + 1;
        }
        else
        {
            result = result + 0;
        }
    }
    if(result == 1)
    {
    System.Console.WriteLine($"Вы ввели {result} число больше 0");
    }
    else if(result == 2 || result == 3 || result == 4)
    {
    System.Console.WriteLine($"Вы ввели {result} числа больше 0");
    }
    else
    {
    System.Console.WriteLine($"Вы ввели {result} чисел больше 0");
    }
}

More(Numbers);
