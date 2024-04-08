using QuickType;
using WCup_Data.Models;
using WCup_Data.Settings;
using System.Text.Json;

namespace WCup_Data.DataFetching;

public class GlobalFetch : IDataFetcher
{
    private readonly string _link = 
     $"https://worldcup-vua.nullbit.hr/" +
     $"{SettingsController.GetSettings().CType.ToString()}/";

    public async Task<List<Match>?> FetchMatches()
    {
        HttpClient client = new HttpClient();
        HttpResponseMessage response = await client.GetAsync(_link + "matches");

        if (response.IsSuccessStatusCode)
        {
            string json = await response.Content.ReadAsStringAsync();
            List<Match> matches = JsonSerializer.Deserialize<List<Match>>(json);
            return matches;
        }
        {
            throw new Exception("Failed to fetch matches");
        }
    }
    // public IEnumerable<Match> FetchMatches()
    // {
    //     throw new NotImplementedException();
    // }
    public async Task<List<Result>?> FetchResults()
    {
        throw new NotImplementedException();
    }
    public Task<List<TeamDetails>>? FetchTeamDetails()
    {
        throw new NotImplementedException();
    }

    public Task<List<Group>>? FetchGroups()
    {
        throw new NotImplementedException();
    }
}