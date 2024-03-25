using QuickType;
using WCup_Data.Models;

namespace WCup_Data.DataFetching;

public interface IDataFetcher
{
    IEnumerable<Match> fetchMatches();
    IEnumerable<Match> fetchMatchesByCountry(string countryFifaCode);
    IEnumerable<Team> fetchTeams();
    IEnumerable<Result> fetchResults();
    IEnumerable<TeamDetails> fetchTeamDetails();
    
    // IEnumerable<> fetchGroupResults();
}