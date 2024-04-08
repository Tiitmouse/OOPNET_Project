using QuickType;
using WCup_Data.DataFetching;
using WCup_Data.Models;
using WCup_Data.Settings;

namespace Test
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            Settings settings = SettingsController.GetSettings();
            Console.WriteLine("loaded settings");
            IDataFetcher fetcher = FetchFactory.FetchData(settings.DataFetchType);
            List<Match> matches = await fetcher.FetchMatches();
            List<Group> groups = await fetcher.FetchGroups();
            List<Result> results = await fetcher.FetchResults();
            List<TeamDetails> teams = await fetcher.FetchTeamDetails();
            SettingsController.SaveSettings();
            Console.WriteLine("saved settings");
        }
    }  
}