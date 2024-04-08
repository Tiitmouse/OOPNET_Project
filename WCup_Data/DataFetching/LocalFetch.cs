using System.Collections;
using System.Text.Json;
using QuickType;
using WCup_Data.Models;
using WCup_Data.Settings;
using Exception = System.Exception;

namespace WCup_Data.DataFetching;

public class LocalFetch : IDataFetcher
{
    private readonly string _path = 
        $"/Users/lorena/Documents/projekti/OOPNET_Projekt/worldcup.sfg.io/" +
        $"{SettingsController.GetSettings().CType.ToString()}/";
    
    public IEnumerable<Match> FetchMatches()
    {
        try
        {
            string json = File.ReadAllText($"{_path}matches.json");
            IEnumerable<Match>? matches = JsonSerializer.Deserialize<List<Match>>(json);
            return matches;
        }
        catch (JsonException e)
        {
            Console.WriteLine(e);
        }
        return new System.Collections.Generic.List<Match>();
    }
    public IEnumerable<Result>? FetchResults()
    {
        try
        {
            string json = File.ReadAllText($"{_path}results.json");
            IEnumerable<Result>? results = JsonSerializer.Deserialize<List<Result>>(json);
            return results;
        }
        catch (JsonException e)
        {
            Console.WriteLine(e);
        }
        return new System.Collections.Generic.List<Result>();
    }

    public IEnumerable<TeamDetails>? FetchTeamDetails()
    {
        try
        {
            string json = File.ReadAllText($"{_path}teams.json");
            IEnumerable<TeamDetails>? teamDetails = JsonSerializer.Deserialize<List<TeamDetails>>(json);
            return teamDetails;
        }
        catch (JsonException e)
        {
            Console.WriteLine(e);
        }
        return new System.Collections.Generic.List<TeamDetails>();
    }

    public IEnumerable<Group> FetchGroups()
    {
        try
        {
            string json = File.ReadAllText($"{_path}group_results.json");
            IEnumerable<Group>? groups = JsonSerializer.Deserialize<List<Group>>(json);
            return groups;
        }
        catch (JsonException e)
        {
            Console.WriteLine(e);
        }
        return new System.Collections.Generic.List<Group>();
    }
}