/*
Задача: Написать программу, которая из имеющегося массива строк
формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
*/

string[] FilterArray(string[] array)
{
    int newSize = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newSize++;
        }
    }

    string[] filteredArray = new string[newSize];
    int currentIndex = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            filteredArray[currentIndex] = array[i];
            currentIndex++;
        }
    }
    return filteredArray;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"[{i}] : {array[i]}");
    }
}

string[] array = {"Hello", ";-D", "123", "Very good", "5"};
string[] newArray = FilterArray(array);
Console.WriteLine("Initial array:");
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Elements with 3 symbols or less:");
PrintArray(newArray);