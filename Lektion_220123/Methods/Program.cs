/*//Method_1 Ничего не принимает, ничего не возвращает
void Method_1()
{
    Console.WriteLine("Автор ...");
}

Method_1();
*/

// Method_2 Что-то принимает, но ничего не возвращает
/*
void Method_2(string msg)
{
    Console.WriteLine(msg);
}
Method_2 (msg: "Текст сообщения");
*/

//Пример Method_2
/*
void Method_21(string msg, int count)
{
    int i = 0;
    while (i < count)
{
    Console.WriteLine(msg);
    i++;
}

}
Method_21 ("Текст", 4);
*/

//Method_3 Ничего не возвращает, но что-то принимает
/*
int Method_3()
{
    return DateTime.Now.Year;
}
int year = Method_3 ();
Console.WriteLine(year);
*/

//Method_4 Что-то принимают и что-то возвращают
string Method_4 (int count, string text)
{
    int i = 0;
    string result = string.Empty; // Изначально пустая строка
    while (i < count)
    {
        result = result + text;
        i++;
    }

    return result;

}

string res = Method_4 (10, "Десять раз ");
Console.WriteLine(res);





