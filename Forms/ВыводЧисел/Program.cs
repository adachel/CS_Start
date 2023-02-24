// Корректный метод выводы (без Console).

string PrintNumbers2(int n) // Корректный метод вывлда
{
  string output = String.Empty;

  for (int i = -n; i <= n; i++)
  {
    //output = output + (i + "");
    output = output + $"{i} ";
  }
  return output;
}

int n = GetValueByUser("Введите число N: "); // Ввод числа
string res = PrintNumbers2(n);
Console.Write(res);
//File.WriteAllText("data.txt", res); // Печать в файл
