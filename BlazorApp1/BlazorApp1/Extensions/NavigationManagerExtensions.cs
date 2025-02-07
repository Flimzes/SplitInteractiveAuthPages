using System.Text;
using Microsoft.AspNetCore.Components;

namespace BlazorApp1.Extensions;
public static class NavigationManagerExtensions {
    public static void NavigateToWithStatus(this NavigationManager navigationManager, string uri, string error)
        => navigationManager.NavigateTo($"{uri}?error={Convert.ToBase64String(Encoding.UTF8.GetBytes(error))}");
}