using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace BlazorJSDemo.Pages
{
    public class JSDemoModel : ComponentBase
    {
        protected static string Message { get; set; }

        [Inject]
        public IJSRuntime JSRuntime { get; set; }

        [JSInvokable]
        public static void CSCallBackMethod()
        {
            Message = "C# Method invoked";
        }

        protected async Task CallCSMethod()
        {
            await JSRuntime.InvokeAsync<object>("CSMethod");
        }

        protected void CallJSMethod()
        {
            JSRuntime.InvokeAsync<bool>("JSMethod");
        }
    }
}
