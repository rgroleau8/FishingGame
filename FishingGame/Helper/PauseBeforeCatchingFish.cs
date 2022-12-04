using System.Threading;

namespace FishingGame.Helper
{
    public static class PauseBeforeCatchingFish
    {
        public static void Pause(int minTime, int maxTime)
        {
            Random timeToFishRandom = new Random();
            int timeInMillisec = timeToFishRandom.Next(minTime, maxTime);

            Thread.Sleep(timeInMillisec);
        }
    }
}
