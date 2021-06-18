namespace MyWebServer.Server.Responses
{
    using MyWebServer.Server.Common;
    using MyWebServer.Server.Http;
    using System.Text;

    public class TextResponse : HttpResponse
    {
        public TextResponse(string text) 
            : base(HttpStatusCode.Ok)
        {
            Guard.AgainstNull(text);

            this.Headers.Add("Content-Type", "text/plain; charset=UTF-8");
            this.Headers.Add("Content-Length", Encoding.UTF8.GetByteCount(text).ToString());
        }
    }
}
