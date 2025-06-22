using Microsoft.EntityFrameworkCore;
using YourApp.DAL;
public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddDbContext<SystemDbContext>(opt =>
        {
            opt.UseNpgsql(builder.Configuration.GetConnectionString("defaultConnection"));
        });
        
        builder.Services.AddControllers();

        var app = builder.Build();

        app.MapControllers();

        app.Run();
    }
}