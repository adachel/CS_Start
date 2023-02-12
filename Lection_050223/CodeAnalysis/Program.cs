
string text = "(1,2) (2,3) (4,5) (6,7)"
               .Replace("(", " ") // Убираем скобки
               .Replace(")", " ");
Console.WriteLine(text);

var data = text.Split(" ") // Разделяе на элементы по пробелу
               .Select (item => item.Split(',')) // Разделяет по запятой
               .Select (e => (x: int.Parse(e[0]), y: int.Parse(e[1]))) // Выборка из текущего массива, 
                // чтобы первой координатой был первый элемент массива, сразу конвертированный в число. То же — со второй
               .Where (e => e.x % 2 == 0) // пары, для которых первая координата — чётная
               .Select (point => (point.x * 10, point.y)) // набор, который мы получили и увелили первую координату
               .ToArray(); // Превращаем в массив
for (int i = 0; i < data.Length; i++)
{
    Console.WriteLine(data[i]);
    Console.WriteLine();
}
