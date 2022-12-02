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
int count = StringsLessThreeElements(array);
GetNewArray(array);

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

int StringsLessThreeElements(string[] array)     // функция считает количество элементов в каждой строке из массива
{
    int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
    count++;
    }
}
return count;
}

string[] GetNewArray(string[] array)                // функция заполнения нового массива
{
string[] newarray = new string [count];
    int temp = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if (array[i].Length <= 3)
    {
        newarray[temp] = array[i];
        temp++;
    }
    }
    return newarray;
}

