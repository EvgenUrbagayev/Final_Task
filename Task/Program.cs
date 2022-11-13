// Напишите программу, которая из имеющегося массива строк формирует массив строк,
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с
// клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется
// пользоваться коллекциями, лучше обойтись исключительно массивами

// Примеры:
// ["hello", "2", "world", ":-)"]->["2", ":-)"]
// ["1234", "1567", "-2", "computer science"]->["-2"]
// ["Russia", "Denmark", "Kazan"]->[]


using static System.Console;
Clear();

WriteLine("Введите элементы массива через пробел: ");
string[] array = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
string[] array2 = new string[array.Length];
WriteLine($"[{String.Join(",",array)}]");
GetArray(array2);
PrintArray(array2);




void GetArray(string[] array2)
{
     int count = 0;
     for (int i = 0; i < array.Length; i++)
     {
     if(array[i].Length <= 3)
         {
         array2[count] = array[i];
         count++;
         }
     }
 }


 void PrintArray(string[] array)
 {
     for (int i = 0; i < array.Length; i++)
     {
         Write($"{array[i]} ");
     }
     WriteLine();
 }
