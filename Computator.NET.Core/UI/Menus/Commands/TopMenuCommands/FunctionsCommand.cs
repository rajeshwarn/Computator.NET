using System.Collections.Generic;
using Computator.NET.Core.UI.Menus;
using Computator.NET.Data;
using Computator.NET.UI.Controls.AutocompleteMenu;
using Computator.NET.UI.Controls.CodeEditors;
using Computator.NET.UI.Menus.Commands;
using Computator.NET.UI.Models;

namespace Computator.NET.UI.Menus
{
    public class FunctionsCommand : FunctionDetailsBasedCommand
    {
        public FunctionsCommand(ITextProvider expressionTextProvider, IScriptProvider scriptingTextProvider, IScriptProvider customFunctionsTextProvider, ISharedViewState sharedViewState, IFunctionsDetails functionsDetails, IClickedMouseButtonsProvider clickedMouseButtonsProvider, IShowFuncrionDetails showFuncrionDetails) : base(MenuStrings.functionsToolStripMenuItem_Text,
            new Dictionary<string, string>()
            {
                {"ElementaryFunctions",MenuStrings.elementaryFunctionsToolStripMenuItem_Text },
                {"SpecialFunctions", MenuStrings.specialFunctionsToolStripMenuItem_Text}
            },
            expressionTextProvider, scriptingTextProvider, customFunctionsTextProvider, sharedViewState, functionsDetails, clickedMouseButtonsProvider, showFuncrionDetails)
        {
        }
    }
}