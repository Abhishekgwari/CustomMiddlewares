var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

// middleware using run method
// app .Run(async (context) =>    // context is a parameter
// {
//    await context.Response.WriteAsync("Welcome  to Asp.net core 6");
//});

// run method never executes our next method
// middleware using run method

// use method give facility to call next method
// use method have multiple parameter
app.Use(async (context, next) =>    // context , use  is a parameter
{
    await context.Response.WriteAsync("Welcome  to Abhishek Middleware \n");
    await next(context);  // it will help us to run next middleware
});

// run have only one  parameter
app .Run(async (context) =>    // context is a parameter
 {
    await context.Response.WriteAsync("Welcome  to .net");
});


app.Run(); // its start on server
