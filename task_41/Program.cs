// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//                                     0, 7, 8, -2, -2 -> 2
//                                     1, -7, 567, 89, 223-> 3

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

Console.Clear();

int[] PositiveNumbers(int[] inArray)
{
    int[] result = new int[inArray.Length];

    for (int i = 0; i < inArray.Length; i++)
    {
        if (inArray[i] > 0)
        {
            result[i] = inArray[i];
        }
    }
    return result;
}

int SummaNumbers(int[] result)
{
    int summ = 0;
    for (int i = 0; i < result.Length; i++)
    {
        if (result[i] > 0)
           { 
            summ++;
           }
    }
    return summ;
}


int[] array = GetArray(5, -10, 10);
Console.WriteLine(String.Join(", ", array));

SummaNumbers(array);
int summ = SummaNumbers(array);
Console.WriteLine($"Количество чисел > 0 = {summ}");

int[] numbers = PositiveNumbers(array);
Console.WriteLine(String.Join(", ", numbers));