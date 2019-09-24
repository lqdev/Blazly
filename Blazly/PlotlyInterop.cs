using Microsoft.JSInterop;
using System.Threading.Tasks;
using Blazly.Base;

namespace Blazly
{
    public class PlotlyInterop
    {
        public static ValueTask<string> Prompt(IJSRuntime jsRuntime, string message)
        {
            // Implemented in exampleJsInterop.js
            return jsRuntime.InvokeAsync<string>(
                "exampleJsFunctions.showPrompt",
                message);
        }

        public static async Task NewPlot(IJSRuntime jsRuntime, string id, Trace[] data, Layout layout)
        {
            await jsRuntime.InvokeVoidAsync("plotlyFunctions.newPlot", id, data, layout);
        }
    }
}
