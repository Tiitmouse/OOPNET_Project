using QuickType;
using WCup_Data.Models;

namespace WCup_Data.DataFetching;

public class GlobalFetch : IDataFetcher
{
    public IEnumerable<Match> fetchMatches()
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Match> fetchMatchesByCountry(string countryFifaCode)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Team> fetchTeams()
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Result> fetchResults()
    {
        throw new NotImplementedException();
    }
}