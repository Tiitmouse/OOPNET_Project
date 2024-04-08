using System.Text.Json;
using QuickType;
using WCup_Data.Models;
using WCup_Data.Settings;

namespace WCup_Data.DataFetching;

public class LocalFetch : IDataFetcher
{
    private readonly string _path = 
        $"/Users/lorena/Documents/projekti/OOPNET_Projekt/worldcup.sfg.io/" +
        $"{SettingsController.GetSettings().CType.ToString()}/";
    
    public async Task<List<Match>> FetchMatches()
    {
        try
        {
            string json = File.ReadAllText($"{_path}matches.json");
            List<Match>? matches = JsonSerializer.Deserialize<List<Match>>(json);
            return matches ?? throw new InvalidOperationException();
        }
        catch (JsonException e)
        {
            Console.WriteLine(e);
        }
        return new List<Match>();
    }
    public async Task<List<Result>>? FetchResults()
    {
        try
        {
            string json = File.ReadAllText($"{_path}results.json");
            List<Result>? results = JsonSerializer.Deserialize<List<Result>>(json);
            return results ?? throw new InvalidOperationException();
        }
        catch (JsonException e)
        {
            Console.WriteLine(e);
        }
        return new List<Result>();
    }

    public async Task<List<TeamDetails>>? FetchTeamDetails()
    {
        try
        {
            string json = File.ReadAllText($"{_path}teams.json");
            List<TeamDetails>? teamDetails = JsonSerializer.Deserialize<List<TeamDetails>>(json);
            return teamDetails ?? throw new InvalidOperationException();
        }
        catch (JsonException e)
        {
            Console.WriteLine(e);
        }
        return new List<TeamDetails>();
    }

    public async Task<List<Group>>? FetchGroups()
    {
        try
        {
            string json = File.ReadAllText($"{_path}group_results.json");
            List<Group>? groups = JsonSerializer.Deserialize<List<Group>>(json);
            return groups ?? throw new InvalidOperationException();
        }
        catch (JsonException e)
        {
            Console.WriteLine(e);
        }
        return new List<Group>();
    }
}