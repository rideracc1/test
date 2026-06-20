Console.WriteLine(countResponseTimeRegressions([100, 200, 150,300]));

static int countResponseTimeRegressions(List<int> responseTimes)
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