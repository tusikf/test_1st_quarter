//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

//Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.Write("Введите размер исходного массива: ");
int size = int.Parse(Console.ReadLine()!);

string[] array = GetArray(size);
Console.WriteLine($"Исходный массив: [{String.Join(", ", array)}]");

int j = 0;
int schet = 0;
int z = 0;
string x = " ";


string[] otvet = new string[size];
for (int k = 0; k < size; k++)
{
    x = array[k];
    int summ = 0;
    foreach(int el in x)
    {
        summ++;
    }

    //Console.WriteLine($"элемент  массива: [{x}]");
    if ( summ < 4)
    {
        otvet[j] = array[k];
        j++;

    }
    else 
    {
        otvet[j] = "=";
        j++;
        schet++;

    }
}
string[] otvet2 = new string[size-schet];
for (int k = 0; k < size; k++)
{
    if (otvet[k]!="=")
    {
        otvet2[z]=otvet[k];
        z++;
    }
}

Console.WriteLine($"Итоговый массив где элементы короче или = 3 : [{String.Join(", ", otvet2)}]");

// Функция заполнения массива
string[] GetArray(int size)
{
    string[] result = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write("Введите элемент исходного массива: ");
        result[i] = Console.ReadLine()!;
    }
    return result;
}