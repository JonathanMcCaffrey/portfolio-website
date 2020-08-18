using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using BlazorStyled;

namespace DPW.Shared.NavBar
{
    public partial class NavBar : ComponentBase
    {
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