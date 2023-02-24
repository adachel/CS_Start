// Ввод числа методом

// int GetValueByUser(string text) // Метод ввода числа с клавиатуры без проверки на валидность.
// {
//     Console.Write(text);
//     return int.Parse(Console.ReadLine()!); // Parse  - преобразует строку в число
// }

int GetValueByUser(string text) // Метод ввода числа с клавиатуры с проверки на валидность.
{
  int value = 0;
  bool flag = false;
  do
  {
    Console.Write(text);
    string s = Console.ReadLine()!;
    flag = int.TryParse(s, out value) && value > 0;
  } while (!flag);
  return value;
}


int n = GetValueByUser("Введите число N: "); // Ввод числа
