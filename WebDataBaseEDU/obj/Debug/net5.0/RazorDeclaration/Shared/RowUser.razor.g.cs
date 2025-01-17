// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WebDataBaseEDU.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\User\source\repos\WebDataBaseEDU\WebDataBaseEDU\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\repos\WebDataBaseEDU\WebDataBaseEDU\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\source\repos\WebDataBaseEDU\WebDataBaseEDU\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\source\repos\WebDataBaseEDU\WebDataBaseEDU\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\source\repos\WebDataBaseEDU\WebDataBaseEDU\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\source\repos\WebDataBaseEDU\WebDataBaseEDU\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\source\repos\WebDataBaseEDU\WebDataBaseEDU\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\source\repos\WebDataBaseEDU\WebDataBaseEDU\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\User\source\repos\WebDataBaseEDU\WebDataBaseEDU\_Imports.razor"
using Microsoft.Data.Sqlite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\User\source\repos\WebDataBaseEDU\WebDataBaseEDU\_Imports.razor"
using WebDataBaseEDU;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\User\source\repos\WebDataBaseEDU\WebDataBaseEDU\_Imports.razor"
using WebDataBaseEDU.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\User\source\repos\WebDataBaseEDU\WebDataBaseEDU\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\User\source\repos\WebDataBaseEDU\WebDataBaseEDU\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\User\source\repos\WebDataBaseEDU\WebDataBaseEDU\Shared\RowUser.razor"
using WebDataBaseEDU.Data;

#line default
#line hidden
#nullable disable
    public partial class RowUser : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "C:\Users\User\source\repos\WebDataBaseEDU\WebDataBaseEDU\Shared\RowUser.razor"
       

    [Parameter] public bool IsShowOrHide { get; set; }

    [Parameter] public User CurrentUser { get; set; }
    
    [Parameter] public EventCallback<User> OnClickDeleteUser { get; set; }
    
    [Parameter] public EventCallback<User> OnClickEditUser { get; set; }

    [CascadingParameter] public IModalService Modal { get; set; }

    async Task ShowUserEdit()
    {
        var parameters = new ModalParameters();
        parameters.Add(nameof(UserEdit.SomeUserToEdit), CurrentUser);

        var messageForm = Modal.Show<UserEdit>($"Edit User №{CurrentUser.Id}", parameters);
        var result = await messageForm.Result;
        
        if (!result.Cancelled)
        {
            await OnClickEditUser.InvokeAsync(CurrentUser);
        }
        
    }
    
    async Task ShowUserDelete()
    {
        var parameters = new ModalParameters();
        parameters.Add(nameof(UserDelete.SomeUserToDelete), CurrentUser);

        var messageForm = Modal.Show<UserDelete>($"Delete User №{CurrentUser.Id} ?", parameters);
        var result = await messageForm.Result;

        if (!result.Cancelled)
        {
            await OnClickDeleteUser.InvokeAsync(CurrentUser);
        }
        
    }




#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
