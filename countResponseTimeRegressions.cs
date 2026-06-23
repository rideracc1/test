public static class CountResponseTimeRegressions
{
    public static int Run(List<int> responseTimes)
    {
        if (responseTimes.Count < 2)
        {
            return 0;
        }

        int result = 0;
        for (int i = 1; i < responseTimes.Count; i++)
        {
            if (responseTimes[i] > responseTimes.GetRange(0, i).Average())
            {
                result++;
            }
        }

        return result;

    }
}