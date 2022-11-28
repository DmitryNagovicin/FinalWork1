// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3.

int Prompt(string message)                                 //Ввод числа с клавиатуры
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

string[] CreateArray(int length)                            // Создание массива
{
    string[] massiv = new string[length];
    for (int i = 0; i < length; i++)
    {
        System.Console.WriteLine($"Введите {i+1}й элемент: ");
        string line = Convert.ToString(Console.ReadLine());
        massiv[i] = line;
    }
    return massiv;
}

void PrintArray(string[] array)                              //Вывод массива
{
    for ( int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
    System.Console.WriteLine();
}

string[] CheckLength(string[] array)                          // Формирование нового массива с элементами короче 3х символов
{
    int lenElement = 4;
    int position = 0;
    int len = array.Length;
    string[] massiv = new string[len];
    for (int i = 0; i < len; i++)
    {
        if(array[i].Length < lenElement)
        {
            massiv[position] = array[i];
            position++;
        }
    }
    return massiv;
}


