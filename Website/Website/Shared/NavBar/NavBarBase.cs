using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using BlazorStyled;

namespace Website.Shared.NavBar
{
    public class NavBarBase : ComponentBase
    {

        [Inject] 
        IStyled Styled {get;set;}

        protected NavData NavData {get; set;}

        [Parameter]
        public bool ToggleTheme { get; set; }
            

        [Parameter]
        public EventCallback<bool> OnToggleThemeChanged {get; set;}
    

        protected async void ToggleThemeChanged(MouseEventArgs mouseEventArgs)
        {
            await OnToggleThemeChanged.InvokeAsync(ToggleTheme);
        }


        [Inject]
        protected HttpClient Http { get; set; }

        protected override async Task OnInitializedAsync()
        {
            NavData = await Http.GetJsonAsync<NavData>("json/layout/navbar.json");
        }
    }
}