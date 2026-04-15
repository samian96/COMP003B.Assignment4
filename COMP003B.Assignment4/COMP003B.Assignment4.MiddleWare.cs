namespace COMP003B.Assignment4.Middleware
{
    public class LoggingMiddleWare
    {
        private readonly RequestDelegate _next;

        public LoggingMiddleWare(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            // displays in the console app when user input happens shows the request and response 
            Console.WriteLine($"[Request] {context.Request.Method} {context.Request.Path}");
                await _next(context);
            Console.WriteLine($"[Respond] {context.Response.StatusCode}");
        }
    }
}
