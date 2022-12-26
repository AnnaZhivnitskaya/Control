// Задан массив. Сформировать из имеющегося массива новый массив со строками, где кол-во символов <=3

Console.WriteLine("Введите строковые значения элементов массива");

string[] words = Console.ReadLine()!.Split(' ');

string[] CorrectMass(string[] arr)
{
    string[] arr2 = new string[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        arr2 = arr2.Append(arr[i]).ToArray();
    }
    return arr2;
}

void Print(string[] arrey)
{
    int begin = arrey.Length;
    for (int i = 0; i < begin; i++)
    {
        Console.Write($"{arrey[i]} ");
    }
    Console.WriteLine();
}

string[] arr_1_new = CorrectMass(words);
Print(arr_1_new);
