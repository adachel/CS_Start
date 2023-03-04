namespace Client // Пространство имен. Для того, чтобы одни и те же переменные использовать в разных файлах
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Это наш клиент");
            OurClient ourClient = new OurClient();
        }
    }
}
