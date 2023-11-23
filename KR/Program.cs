/*//
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []

//*/

void ArrayFULL(string [] Array)
{
    System.Console.WriteLine("Ввведите нобор цифр, слова и тд.: ");
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i]= Console.ReadLine();
    }
}

int ArrayNewLength(string [] ArrayOld)
{
    int count = 0;
    for (int i = 0; i < ArrayOld.Length; i++)
    {
        if (ArrayOld[i].Length<=3)
        {
            count++;
        }
    }
    return count;
}

string [] ArrayCheck(string [] ArrayOld , string [] ArrayNew)
{
   
    int res = 0;
    for (int i = 0; i < ArrayOld.Length; i++)
    {
        if (ArrayOld[i].Length<=3)
        {
            ArrayNew[res]=ArrayOld[i];
            res++;
        }
    }
    return ArrayNew;
}


System.Console.WriteLine("Введите какое количество слов будет в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
string [] ArrayOld = new string[m];

ArrayFULL(ArrayOld);
Console.Write("["+string.Join(", ",ArrayOld)+"]");

int count = ArrayNewLength(ArrayOld);
string [] ArrayNew = new string[count];
ArrayNew = ArrayCheck(ArrayOld,ArrayNew);

System.Console.WriteLine();
Console.Write("["+string.Join(", ",ArrayNew)+"]");
