public static class IsNonTrivialRotation
{
    public static bool Run(string s1, string s2)
    {
        if (s1 == s2 || s1.Length != s2.Length)
        {
            return false;
        }

        var remaining = s2;
        foreach (var c in s1)
        {
            var index = remaining.IndexOf(c);
            if (index == -1)
            {
                return false;
            }
            remaining = remaining.Remove(index, 1);
        }
        if (remaining.Length > 0)
        {
            return false;
        }

        return true;
    }
}