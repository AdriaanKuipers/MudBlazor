using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web.Virtualization;

namespace MudBlazor;

public partial class ZondVirtualTable<T> : MudTable<T>
{
    [Parameter] public ItemsProviderDelegate<T> ItemsProvider { get; set; }
}