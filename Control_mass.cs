// Задан массив. Сформировать из имеющегося массива новый массив со строками, где кол-во символов <=3

Console.WriteLine("Введите строковые значения элементов массива");

string[] words = Console.ReadLine()!.Split(' ');

void CorrectMass(string[] arr)
{ 
    for(int i = 0; i <arr.Length; i++)
       {
    if(arr[i].Length <= 3)
    Console.Write($"{arr[i]} ");
    }
}
Console.WriteLine();
CorrectMass(words);
Console.WriteLine();


