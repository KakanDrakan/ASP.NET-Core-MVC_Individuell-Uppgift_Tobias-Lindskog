using GamesListApp.Web.Services;

namespace GamesListApp.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddSingleton<GamesListService>(); //This is to make the service available for DI in the UniqueNameAttribute.
                                                               //I'm aware this means the service is shared across all requests, but for this simple app, it's fine.
                                                               //Also, why is the intellisense autocompleting my comments?
            var app = builder.Build();

            app.MapControllers();

            app.Run();
        }
    }
}
