using System.Collections.Generic;
using System.Text;

namespace Solution.BrowserHistory;

public class HistoryManager
{
    private readonly Stack<Halaman> _backStack = new();
    private readonly Stack<Halaman> _forwardStack = new();
    private Halaman? _currentPage;
    private readonly List<string> _visitedUrls = new(); // Tracks all visited URLs in order

    public void KunjungiHalaman(string url)
    {
        var halaman = new Halaman(url, url);
        KunjungiHalaman(halaman);
    }

    public void KunjungiHalaman(Halaman halaman)
    {
        if (_currentPage != null)
        {
            _backStack.Push(_currentPage);
        }
        _currentPage = halaman;
        _forwardStack.Clear();
        _visitedUrls.Add(halaman.Url); // Track visited URL
    }

    public string? Kembali()
    {
        if (_backStack.Count == 0) return "Tidak ada halaman sebelumnya.";

        _forwardStack.Push(_currentPage!);
        _currentPage = _backStack.Pop();
        return _currentPage?.Url;
    }

    public string? Maju()
    {
        if (_forwardStack.Count == 0) return "Tidak ada halaman berikutnya.";

        _backStack.Push(_currentPage!);
        _currentPage = _forwardStack.Pop();
        return _currentPage?.Url;
    }

    public string? LihatHalamanSaatIni()
    {
        return _currentPage?.Url;
    }
    public void TampilkanHistory()
    {
        var sb = new StringBuilder();

        foreach (var halaman in _backStack.Reverse()) // Reverse to maintain order
        {
            sb.AppendLine(halaman.Url);
        }

        if (_currentPage != null)
        {
            sb.AppendLine(_currentPage.Url);
        }

        Console.Write(sb.ToString()); // Print instead of returning a string
    }






}