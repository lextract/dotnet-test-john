using System.Configuration;

namespace MasglobalTest.JohnAntonio.App.DAL
{
    internal static class UrisApi
    {
        public static string MasGlobalApi { get; } = ConfigurationManager.AppSettings["ServerApi.MasGlobalTestApi"];
    }
}
