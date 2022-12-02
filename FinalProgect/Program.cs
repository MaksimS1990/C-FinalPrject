// Написать программу, которая из имеющегося массива строк, формирует массив из строк, длина которых меньше либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами. 

Console.WriteLine("Программа формирует массив строк из введённых Вами строк. Далее формирует новый массив, который содержит строки равные 3 или меньше символам!");

int M = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Ваш размер массива {M}");
string[] array = new string [M];

GetArray(array);
Console.WriteLine("Ваш массив:");
PrintArray(array);

string[] GetArray(string[] array)                // Функция заполнения массива с консоли
{
 for (int i = 0; i < array.Length; i++) 
 { 
 array[i] = Console.ReadLine()!;
 }

 return array;
}

void PrintArray(string [] array)                 // функция вывода результата
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}