using System.Net.Sockets; // Встроенные библиотеки для работы с ТСР
using System.Text;

namespace Client
{
    class OurClient
    {
        private TcpClient client; // Переменная, кот. позволит нам работать с TCP
        private StreamWriter sWriter; // Поток, при помощи кот. отпр данные на сервер

        public OurClient()
        {
            client = new TcpClient("127.0.0.1", 5555);
            sWriter = new StreamWriter(client.GetStream(), Encoding.UTF8);

            HandleCommunication();
        }

        void HandleCommunication()
        {
            while (true)
            {
                Console.Write("> ");
                string message = Console.ReadLine();
                sWriter.WriteLine(message);
                sWriter.Flush();
            }
        }


    }
}