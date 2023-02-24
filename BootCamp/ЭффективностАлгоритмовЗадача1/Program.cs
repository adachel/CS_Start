// Дано число N. Показать все числа от -N до N.

////////////////////////////////////////////////////////////////////////////////////////////
// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// for(int i = -n; i <= n; i++) // Решение плохо оформлено, нужен метод
// {
//     Console.Write($"{i}  ");
// }

///////////////////////////////////////////////////////////////////////////////////////////
// int GetValueByUser(string text) // Метод ввода числа с клавиатуры без проверки на валидность.
// {
//     Console.Write(text);
//     return int.Parse(Console.ReadLine()!); // Parse  - преобразует строку в число
// }

////////////////////////////////////////////////////////////////////////////////////////

// void PrintNumbers1(int n) // Не корректный метод. Сonsole не должно быть в методе
// {
//   for (int i = -n; i <= n; i++)
//   {
//     Console.Write(i + " "); // Дает пробел между цифрами
//   }
//   System.Console.WriteLine();
// }
// int n = GetValueByUser("Введите число N: "); // Ввод числа
// PrintNumbers2(n);

/////////////////////////////////////////////////////////////////////////////////////

// string PrintNumbers2(int n) // Корректный метод вывлда
// {
//   string output = String.Empty;
//   for (int i = -n; i <= n; i++) // Плохая эффективность, нужно сократить кол-во итераций
//   {
//     //output = output + (i + "");
//     output = output + $"{i} ";
//   }
//   return output;
// }

// int n = GetValueByUser("Введите число N: "); // Ввод числа
// string res = PrintNumbers2(n);
// Console.Write(res);
//File.WriteAllText("data.txt", res); // Печать в файл

//////////////////////////////////////////////////////////////////////////////////////////////

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

string PrintNumbers3(int n) // Корректный метод вывлда
{
  string output = "0";

  for (int i = 1; i <= n; i++) // По эффективности так лучше
  {
    output = $"{-i} " + output + $" {i}";
  }
  return output;
}

int n = GetValueByUser("Введите число N: "); // Ввод числа
string res = PrintNumbers3(n);
Console.Write(res);
