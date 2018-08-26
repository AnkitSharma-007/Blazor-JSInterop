using Microsoft.AspNetCore.Blazor.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorJSDemo.Pages
{
    public class JSDemoModel : BlazorComponent
    {
        protected static string message { get; set; }

        [JSInvokable]
        public static void CSCallBackMethod()
        {
            message = "C# Method invoked";
        }

        protected void CallCSMethod()
        {
            JSRuntime.Current.InvokeAsync<bool>("CSMethod");
        }

        protected void CallJSMethod()
        {
            JSRuntime.Current.InvokeAsync<bool>("JSMethod");
        }
    }
}