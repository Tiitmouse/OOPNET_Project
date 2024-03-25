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
    
    public IEnumerable<Match> fetchMatches()
    {
        // try
        // {
        //     string json = File.ReadAllText($"{_path}matches.json");
        //     IEnumerable<Match> matches = JsonSerializer.Deserialize<List<Match>>(json);
        //     return matches;
        // }
        // catch (JsonException e)
        // {
        //     Console.WriteLine(e);
        // }
        // return new List<Match>();
        throw new NotImplementedException();
    }

    public IEnumerable<Match> fetchMatchesByCountry(string countryFifaCode)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Team> fetchTeams()
    {
        // try
        // {
        //     string json = File.ReadAllText($"{_path}teams.json");
        //     IEnumerable<Team> teams = JsonSerializer.Deserialize<List<Team>>(json);
        //     return teams;
        // }
        // catch (JsonException e)
        // {
        //     Console.WriteLine(e);
        // }
        // return new System.Collections.Generic.List<Team>();
        throw new NotImplementedException();
    }

    public IEnumerable<Result> fetchResults()
    {
        throw new NotImplementedException();
    }

    public IEnumerable<TeamDetails> fetchTeamDetails()
    {
        try
        {
            string json = File.ReadAllText($"{_path}teams.json");
            IEnumerable<TeamDetails> teamdetails = JsonSerializer.Deserialize<List<TeamDetails>>(json);
            return teamdetails;
        }
        catch (JsonException e)
        {
            Console.WriteLine(e);
        }
        return new System.Collections.Generic.List<TeamDetails>();
    }
}