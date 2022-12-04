using FishingGame.Helper;
using FishingGame.TypesOfFish;


namespace FishingGame.Casting
{
    public static class CommonCastSequence
    {
        public static IFishModel Fish(List<IFishModel> listOfFishes, int fishingLvl )
        {
            //this won't return 0 because the users level gets checked before this gets run to ensure their will be at least one fish they can fish for
            List<IFishModel> tempList = GetFishUserCanCatch.GetList(listOfFishes, fishingLvl);

            IFishModel fish = PickRandomFishFromList.GetFish(tempList);

            PauseBeforeCatchingFish.Pause(fish.MinTimeToCatchInMilliseconds, fish.MaxTimeToCatchInMilliseconds);

            Console.WriteLine($"You caught a {fish.FishName}");

            return fish;

        }
    }
}
