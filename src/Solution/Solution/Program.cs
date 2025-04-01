using Solution.BracketValidation;
using Solution.BrowserHistory;
using Solution.Palindrome;

namespace Solution;

internal class Program
{
    static void Main(string[] args)
    {
        // Browser History Demo
        Console.WriteLine("=== Browser History ===");
        var history = new HistoryManager();

        // Test basic navigation
        history.KunjungiHalaman("https://google.com");
        history.KunjungiHalaman("https://github.com");
        history.KunjungiHalaman("https://stackoverflow.com");

        Console.WriteLine("\nCurrent page: " + history.LihatHalamanSaatIni());
        Console.WriteLine("\nFull history:");
        history.TampilkanHistory(); // No need for Console.WriteLine(history.TampilkanHistory());


        Console.WriteLine("\nGoing back...");
        Console.WriteLine("Back to: " + history.Kembali());
        Console.WriteLine("Back to: " + history.Kembali());
        Console.WriteLine("Forward to: " + history.Maju());

        // Test empty case
        Console.WriteLine("\nTrying to go back too far:");
        Console.WriteLine(history.Kembali());
        Console.WriteLine(history.Kembali());

        // Bracket validator
        Console.WriteLine("\n=== Bracket Validation ===");
        var validator = new BracketValidator();
        string[] ekspresiContoh = {
            "[{}](){}",
            "([]{[]})[]{{}()}",
            "(]",
            "([)]",
            "{[}"
        };

        foreach (var ekspresi in ekspresiContoh)
        {
            Console.WriteLine($"'{ekspresi}' valid? {validator.ValidasiEkspresi(ekspresi)}");
        }

        // Palindrome Checker
        Console.WriteLine("\n=== Palindrome Checker ===");
        string[] palindromeContoh = {
            "",
            "Kasur ini rusak",
            "Ibu Ratna antar ubi",
            "Hello World",
            "A man, a plan, a canal: Panama",
            "Was it a car or a cat I saw?"
        };

        foreach (var teks in palindromeContoh)
        {
            Console.WriteLine($"'{teks}' palindrom? {PalindromeChecker.CekPalindrom(teks)}");
        }
    }
}