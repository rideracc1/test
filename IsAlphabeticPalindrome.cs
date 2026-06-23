public static class IsAlphabeticPalindrome
{
    public static bool Run(string code)
    {
        var letters = new List<char>();
        foreach (char c in code)
        {
            if (char.IsLetter(c))
            {
                letters.Add(char.ToLower(c));
            }
        }

        var i = letters.Count / 2 - 1;
        var j = letters.Count % 2 == 0 ? i + 1 : i + 2;
        while (i >= 0 && j < letters.Count)
        {
            if (letters[i] != letters[j])
            {
                return false;
            }
            i--;
            j++;
        }
        return true;
    }
}