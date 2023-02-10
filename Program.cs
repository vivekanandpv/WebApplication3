using WebApplication3.Services;

namespace WebApplication3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //  dependency injection container configuration
            builder.Services.AddControllers();
            builder.Services.AddScoped<IBookService, BookService>();

            var app = builder.Build();

            //  middleware configuration (pipeline setup)
            app.MapControllers();

            app.Run();
        }
    }
}