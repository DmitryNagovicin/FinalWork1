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

