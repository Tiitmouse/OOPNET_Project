namespace WCup_Data.DataFetching;

public static class FetchFactory
{
    public static IDataFetcher FetchData(Settings.Settings settings)
    {
        switch (settings.DataFetchType)
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