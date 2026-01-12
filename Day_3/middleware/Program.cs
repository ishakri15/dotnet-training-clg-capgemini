var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/add", () => $"The sum is  {10+20}"); //one method
app.MapGet("/add/{a:int}/{b:int}", (int a, int b) =>  //second method with parameters
    {
        return $"The sum is {a + b}";
    });
app.Use(async(HttpContext context, RequestDelegate next) =>
    {
        await context.Response.WriteAsync("From middleware1\n");
        next(context);
    });
app.Use(async(HttpContext context, RequestDelegate next) =>
    {
        await context.Response.WriteAsync("From middleware2\n");
        next(context);
    });
app.Use(async(HttpContext context, RequestDelegate next) =>
    {
        await context.Response.WriteAsync("From middleware3");
        next(context);
    });

app.Run();
