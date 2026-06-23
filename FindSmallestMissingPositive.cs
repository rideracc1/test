public static class FindSmallestMissingPositive
{
    public static int Run(List<int> orderNumbers)
    {
        for (int i = 0; i < orderNumbers.Count; i++)
        {
            while (orderNumbers[i] > 0 && orderNumbers[i] <= orderNumbers.Count && orderNumbers[orderNumbers[i] - 1] != orderNumbers[i])
            {
                var val = orderNumbers[i];
                orderNumbers[i] = orderNumbers[val - 1];
                orderNumbers[val - 1] = val;
            }
        }

        for (int i = 0; i < orderNumbers.Count; i++)
        {
            if (orderNumbers[i] != i + 1)
            {
                return i + 1;
            }
        }
        return orderNumbers.Count + 1;
    }
}