using Autofac;
using FishingGame.FishingMethods;
using FishingGame.Input;
using FishingGame.Inventory;
using FishingGame.TypesOfFish;
using FishingGame.EXP_Calc;
using FishingGame.Character;
using FishingGame.Casting;
using FishingGame.FishingSpots;
using FishingGame.Prompts;
using FishingGame.Store;

namespace FishingGame
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<UserKillSwitch>().As<IUserKillSwitch>();
            builder.RegisterType<Inventory.Inventory>().As<IInventory>().SingleInstance();
            
            
            builder.RegisterType<Character.Character>().As<ICharacter>().SingleInstance();
            builder.RegisterType<ExperienceUtil>().As<IExperienceUtil>().SingleInstance();
            builder.RegisterType<Store.Store>().As<IStore>();


            builder.RegisterType<NetFishing>().As<INetFishing>();
            builder.RegisterType<NetFishingSpot>().As<INetFishingSpot>().SingleInstance();
            builder.RegisterType<NetFishes>().As<INetFishes>().SingleInstance();

            builder.RegisterType<RodFishing>().As<IRodFishing>();
            builder.RegisterType<RodFishingSpot>().As<IRodFishingSpot>().SingleInstance();
            builder.RegisterType<RodFishes>().As<IRodFishes>().SingleInstance();

            builder.RegisterType<HarpoonFishing>().As<IHarpoonFishing>();
            builder.RegisterType<HarpoonFishingSpot>().As<IHarpoonFishingSpot>().SingleInstance();
            builder.RegisterType<HarpoonFishes>().As<IHarpoonFishes>().SingleInstance();

            builder.RegisterType<CageFishing>().As<ICageFishing>();
            builder.RegisterType<CageFishingSpot>().As<ICageFishingSpot>().SingleInstance();
            builder.RegisterType<CageFishes>().As<ICageFishes>().SingleInstance();


            builder.RegisterType<FishSpotTimer>().As<IFishSpotTimer>();

          

            builder.RegisterType<MainMenuPrompt>().As<IMainMenuPrompt>();
            builder.RegisterType<FishingPrompt>().As<IFishingPrompt>();
            builder.RegisterType<InventoryPrompt>().As<IInventoryPrompt>();
            builder.RegisterType<StorePrompt>().As<IStorePrompt>();
            builder.RegisterType<CharacterInfoPrompt>().As<ICharacterInfoPrompt>();
            builder.RegisterType<StoreBuyToolsPrompt>().As<IStoreBuyToolsPrompt>();


            builder.RegisterType<GameLogic>().As<IGameLogic>();
            builder.RegisterType<CastTypeRegular>().As<ICastTypeRegular>();

            builder.RegisterType<Shrimp>().As<IShrimp>();
            builder.RegisterType<Anchovie>().As<IAnchovie>();
            builder.RegisterType<Pike>().As<IPike>();
            builder.RegisterType<Herring>().As<IHerring>();
            builder.RegisterType<Trout>().As<ITrout>();
            builder.RegisterType<Tuna>().As<ITuna>();
            builder.RegisterType<Swordfish>().As<ISwordfish>();
            builder.RegisterType<Shark>().As<IShark>();
            builder.RegisterType<Lobster>().As<ILobster>();

            return builder.Build();
        }
    }
}
