namespace MyWebServer.Server.Routing
{
    using MyWebServer.Server.Http;

    public interface IRoutingTable
    {
        void Map(string url, HttpResponse response);

        void Map(string url, HttpMethod methodm, HttpResponse response);

        void MapGet(string url, HttpResponse response);
    }
}
