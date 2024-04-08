using QuickType;
using WCup_Data.Models;

namespace WCup_Data.DataFetching;

public interface IDataFetcher
{
    IEnumerable<Match>? FetchMatches();
    //should be done elsewhere
    // IEnumerable<Match> fetchMatchesByCountry(string countryFifaCode);
    //probably not needed
    // IEnumerable<Team> fetchTeams();
    IEnumerable<Result>? FetchResults();
    IEnumerable<TeamDetails>? FetchTeamDetails();
    
    IEnumerable<Group>? FetchGroups();
}