namespace Solution.BracketValidation;

public class BracketValidator
{
    private readonly List<char> _stack = new();

    public bool ValidasiEkspresi(string ekspresi)
    {
        _stack.Clear();
        
        foreach (char c in ekspresi)
        {
            if (IsBracketOpen(c))
            {
                _stack.Add(c);
            }
            else if (IsBracketClose(c))
            {
                if (_stack.Count == 0 || !IsMatchingPair(_stack[^1], c))
                {
                    return false;
                }
                _stack.RemoveAt(_stack.Count - 1);
            }
        }
        
        return _stack.Count == 0;
    }

    private static bool IsBracketOpen(char c) => c is '(' or '{' or '[';
    
    private static bool IsBracketClose(char c) => c is ')' or '}' or ']';
    
    private static bool IsMatchingPair(char open, char close) =>
        (open == '(' && close == ')') ||
        (open == '{' && close == '}') ||
        (open == '[' && close == ']');
}