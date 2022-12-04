using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingGame.Prompts
{
    public interface IPrompt
    {
        List<string> PromptsForUser { get; set; }

        delegate void ChooseOption(string input);

        void PromptUser();

    }
}
