using QuickType;
using WCup_Data.Models;

namespace WCup_Data.DataFetching;

public interface IDataFetcher
{
    Task<List<Match>> FetchMatches();
    // IEnumerable<Match> fetchMatchesByCountry(string countryFifaCode);
    //probably not needed
    // IEnumerable<Team> fetchTeams();
    Task<List<Result>> FetchResults();
    Task<List<TeamDetails>> FetchTeamDetails();
    
    Task<List<Group>> FetchGroups();
}