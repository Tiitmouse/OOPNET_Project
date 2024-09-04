using QuickType;
using WCup_Data.Models;
using WCup_Data.Settings;
using System.Text.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using System;

namespace WCup_Data.DataFetching;

public class GlobalFetch : IDataFetcher
{
    private readonly string _link = 
     $"https://worldcup-vua.nullbit.hr/" +
     $"{SettingsController.GetSettings().CType.ToString()}/";
    HttpClient client = new HttpClient();

    public async Task<List<Match>?> FetchMatches()
    {
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
        HttpResponseMessage response = await client.GetAsync(_link + "teams/results");

        if (response.IsSuccessStatusCode)
        {
            string json = await response.Content.ReadAsStringAsync();
            List<Result> results = JsonSerializer.Deserialize<List<Result>>(json);
            return results;
        }
        {
            throw new Exception("Failed to fetch results");
        }    }
    public async Task<List<TeamDetails>>? FetchTeamDetails()
    {
        HttpResponseMessage response = await client.GetAsync(_link + "teams");

        if (response.IsSuccessStatusCode)
        {
            string json = await response.Content.ReadAsStringAsync();
            List<TeamDetails> teams = JsonSerializer.Deserialize<List<TeamDetails>>(json);
            return teams;
        }
        {
            throw new Exception("Failed to fetch team details");
        }    
    }

    public async Task<List<Group>>? FetchGroups()
    {
        HttpResponseMessage response = await client.GetAsync(_link + "teams/group_results");

        if (response.IsSuccessStatusCode)
        {
            string json = await response.Content.ReadAsStringAsync();
            List<Group> groups = JsonSerializer.Deserialize<List<Group>>(json);
            return groups;
        }
        {
            throw new Exception("Failed to fetch groups");
        }      
    }

    public async Task<List<Match>> fetchMatchesByCountry(string countryFifaCode)
    {
        HttpResponseMessage response = await client.GetAsync(_link + $"matches/country?fifa_code={countryFifaCode}");

        if (response.IsSuccessStatusCode)
        {
            string json = await response.Content.ReadAsStringAsync();
            List<Match> matches = JsonSerializer.Deserialize<List<Match>>(json);
            return matches;
        }
        {
            throw new Exception("Failed to fetch groups");
        }
    }
}