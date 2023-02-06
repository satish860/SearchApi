global using FastEndpoints;
using Typesense.Setup;

namespace Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddFastEndpoints();
            builder.Services
                   .AddTypesenseClient(config =>
                   {
                       config.ApiKey = "Hu52dwsas2AdxdE";
                       config.Nodes = new List<Node>
                       {
                           new Node(host: "localhost",port:"8108",protocol:"http")
                       };            
                   });
            var app = builder.Build();

            app.UseAuthorization();
            app.UseFastEndpoints();
            app.Run();
        }
    }
}