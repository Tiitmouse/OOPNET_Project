namespace WCup_Data.DataFetching;

public static class FetchFactory
{
    public static IDataFetcher FetchData(char dataFetchType)
    {
        switch (dataFetchType)
        {
            case 'L':
                return new LocalFetch();
            case 'G':
                return new GlobalFetch();
            default:
                throw new InvalidOperationException();
        }
    }
}