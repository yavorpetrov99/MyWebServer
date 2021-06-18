namespace MyWebServer
{
    using System.Threading.Tasks;
    using MyWebServer.Server;

    public class Startup
    {
        public static async Task Main()
            => await new HttpServer("127.0.0.1",9090).Start();
    }
}
