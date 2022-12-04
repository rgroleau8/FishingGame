using FishingGame.FishingMethods;

namespace FishingGame.Prompts
{
    public class FishingPrompt : PromptBaseClass, IFishingPrompt
    {
        #region Variables

        private IInventoryPrompt _inventoryPrompt;

        private INetFishing _netFishing;
        private IRodFishing _rodFishing;
        private IHarpoonFishing _harpoonFishing;
        private ICageFishing _cageFishing;


        #endregion

        #region Constructor

        public FishingPrompt(IInventoryPrompt inventoryPrompt, INetFishing netFishing, IRodFishing rodFishing, IHarpoonFishing harpoonFishing, ICageFishing cageFishing)
        {
            _inventoryPrompt = inventoryPrompt;
            _netFishing = netFishing;
            _rodFishing = rodFishing;
            _harpoonFishing = harpoonFishing;
            _cageFishing = cageFishing;

            PromptsForUser = new List<string>();

            PromptsForUser.Add("1: Access Inventory");
            PromptsForUser.Add("2: Leave Fishing Docs");
            PromptsForUser.Add("3: Net Fishing");
            PromptsForUser.Add("4: Rod Fishing");
            PromptsForUser.Add("5: Harpoon Fishing");
            PromptsForUser.Add("6: Cage Fishing");

        }

        #endregion

        #region Methods

        public void PromptUser()
        {
            base.PromptUser(FishingOptions, "2");

        }

        private void FishingOptions(string input)
        {
            switch (input)
            {
                case "1":
                    _inventoryPrompt.PromptUser();
                    break;
                case "2":
                    return;
                case "3":
                    _netFishing.StartFishing();
                    break;
                case "4":
                    _rodFishing.StartFishing();
                    break;
                case "5":
                    _harpoonFishing.StartFishing();
                    break;
                case "6":
                    _cageFishing.StartFishing();
                    break;

            }
        }

        #endregion






    }
}
