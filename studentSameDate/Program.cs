namespace studentSameDate;

internal class Program
{
    public static void Main(string[] args)
    {
        int eventCount = 0;
        int iteration = 50376;
        int numberOfStudent = 50;
        string randomSeed = "this is random seed";

        Random rnd = new Random();

        for (int i=0; i < iteration; i++)
        {
            IDictionary<int, int> birthdateDict = new Dictionary<int, int>();

            for (int y=0; y < numberOfStudent; y++)
            {
                int randomBirthdate = Convert.ToInt32(rnd.NextInt64(1, 365));

                if (birthdateDict.ContainsKey(randomBirthdate))
                {
                    birthdateDict[randomBirthdate]++;
                }
                else
                {
                    birthdateDict.Add(randomBirthdate, 1);
                }
            }

            foreach (var birthDateEl in birthdateDict)
            {
                if (birthDateEl.Value >= 2)
                {
                    eventCount++;
                    break;
                }
            }
        }

        double probability = Convert.ToDouble(eventCount) / Convert.ToDouble(iteration) * 100.0;
        Console.WriteLine(probability.ToString());
    }
}