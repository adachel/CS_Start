// Дан текст. В нём нужно все пробелы заменить чёрточками, маленькие буквы «к»
//заменить большими «К», а большие «С» заменить на маленькие «с».

string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

string Replace(string text, char oldValue, char newValue) // Создаем метод Replace.
{
    string result = string.Empty; // Пустая строка.
    int length = text.Length; // Присваиваем Length длину текста.
    for (int i = 0; i < length; i++)
        {
            if (text[i] == oldValue) //Сравниваем элемент текста со значением oldValue.
                    result = result + $"{newValue}"; // Присваиваем result новое значение.

            else
                    result = result + $"{text[i]}"; // Иначе result старый.
        }

    return result;
}


string newText = Replace(text, ' ', '|'); // Метод Replace создан, меняем "пробел" на "_".
Console.WriteLine(newText);

Console.WriteLine();

newText = Replace(text, 'к', 'К');
Console.WriteLine(newText);

Console.WriteLine();

newText = Replace(text, 'С', 'с');
Console.WriteLine(newText);
