namespace Solution.BrowserHistory;

public class Halaman
{
    public string Url { get; }
    public string Judul { get; }

    public Halaman(string url, string judul)
    {
        Url = url;
        Judul = judul;
    }
}