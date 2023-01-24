Console.WriteLine("Введите имя");
string? username = Console.ReadLine();

if (username?.ToLower() == "дмитрий")
{
    Console.WriteLine("Приветствую Вас дорогой Дмитрий");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
