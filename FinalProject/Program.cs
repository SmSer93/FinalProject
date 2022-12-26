//Написать программу, которая из имеющегося массива строк сформирует новый массив.
//Условие нового массива - длина строки не больше 3 символов.

void PrintText(string text)
{
    Console.Write(text);
}

void NewLine ()
{
    Console.WriteLine();
}

dynamic UserEnter()
{
    string a = Console.ReadLine();
    if (a != "")
    {
        if (int.TryParse(a, out int n))
        {
            int b = Convert.ToInt32(a);
            return b;
        }
        else if (a == "y") return true;
        else if (a == "n") return false;
        else return a;
    }
    else
    {
        a = "exit";
        return a;
    }
}

void PrintArray (string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] != null)
        {
            Console.Write($"{array[i]}, ");
        }
    }
    Console.WriteLine();
}

string[] UserEnterStrings()
{
    PrintText("Введите до 30 строк. Если хотите завершить ввод - нажмите 'Enter'.");
    NewLine();
    string[] help = new string[30];
    int i = 0;
    for (; true; i++)
{
    string str = String.Empty;
    if (i < 30)
    {
        PrintText($"Введите {i + 1} строку: ");
        str = Convert.ToString(UserEnter());
    }
    if (str == "exit" || i == 30) break;
    else help[i] = str;
}
string[] strings = new string [i];
for (int j=0; j < strings.Length; j++)
{
    strings[j] = help[j];
}
return strings;
}

string[] enter = UserEnterStrings();
string[] exit = new string[enter.Length];
for (int i = 0; i < enter.Length; i++)
{
    if (enter[i].Length < 4) exit[i] = enter[i];
}

PrintArray(exit);