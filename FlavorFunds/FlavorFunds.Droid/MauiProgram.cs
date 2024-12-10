using System.IO;
namespace FlavorFunds.Droid
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();

            builder.UseMauiApp<App>();
            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "FlavorFundsApp.db");

            // Register DatabaseHelper as a singleton
            builder.Services.AddSingleton(s => new DatabaseHelper(dbPath));
            return builder.Build();
        }
    }
}
