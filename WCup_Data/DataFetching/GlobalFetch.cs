using QuickType;
using WCup_Data.Models;

namespace WCup_Data.DataFetching;

public class GlobalFetch : IDataFetcher
{
    public IEnumerable<Match> FetchMatches()
    {
        throw new NotImplementedException();
    }
    public IEnumerable<Result>? FetchResults()
    {
        throw new NotImplementedException();
    }
    public IEnumerable<TeamDetails>? FetchTeamDetails()
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Group> FetchGroups()
    {
        throw new NotImplementedException();
    }
}