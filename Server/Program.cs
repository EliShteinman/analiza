using System.Net;
using System.Text;
class program
{
    public static void Main(string[] args)
    {
        HttpListener listener = new HttpListener();
        listener.Prefixes.Add("http://localhost:5000/");
        listener.Start();
        // Console.WriteLine("server run to port 5000");

        while (true)
        {
            HttpListenerContext context = listener.GetContext();
            // Console.WriteLine("****************");
            // HttpListenerRequest request = context.Request;
            //
            // Console.WriteLine("Method: " + request.HttpMethod);
            // Console.WriteLine("URL: " + request.Url);
            // Console.WriteLine("RawUrl: " + request.RawUrl);
            // Console.WriteLine("Protocol Version: " + request.ProtocolVersion);
            // Console.WriteLine("Content Type: " + request.ContentType);
            // Console.WriteLine("Content Length: " + request.ContentLength64);
            // Console.WriteLine("UserAgent: " + request.UserAgent);
            // Console.WriteLine("Remote endpoint: " + request.RemoteEndPoint);
            //
            // // הדפסת כל ההדרים
            // Console.WriteLine("Headers:");
            // foreach (string headerName in request.Headers)
            // {
            //     Console.WriteLine($"{headerName}: {request.Headers[headerName]}");
            // }
            //
            // // הדפסת פרמטרים מה-URL (אם יש)
            // Console.WriteLine("Query String:");
            // foreach (string key in request.QueryString.AllKeys)
            // {
            //     Console.WriteLine($"{key} = {request.QueryString[key]}");
            // }
            //
            // // הדפסת קבצי Cookie (אם יש)
            // Console.WriteLine("Cookies:");
            // foreach (Cookie cookie in request.Cookies)
            // {
            //     Console.WriteLine($"{cookie.Name} = {cookie.Value}");
            // }
            //
            // // קריאת גוף הבקשה (Body) אם יש תוכן
            // if (request.HasEntityBody)
            // {
            //     using (var bodyStream = request.InputStream)
            //     using (var reader = new StreamReader(bodyStream, request.ContentEncoding))
            //     {
            //         string body = reader.ReadToEnd();
            //         Console.WriteLine("Body:");
            //         Console.WriteLine(body);
            //     }
            //     
            // }
            string path = context.Request.Url.AbsolutePath;
            string responseText;
            if (path == "/hello" || path == "/")
            {
                responseText = "hello";
            }
            else if (path == "/time")
            {
                responseText = DateTime.Now.ToString();

            }
            else
            {
                context.Response.StatusCode = 404;
                responseText = "404 this page not found";
            }
            byte[] buffer = Encoding.UTF8.GetBytes(responseText);
            context.Response.ContentLength64 = buffer.Length;
            context.Response.OutputStream.Write(buffer, 0, buffer.Length);
            context.Response.Close();
        }
    }
}
    