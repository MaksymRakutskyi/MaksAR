#pragma checksum "C:\Users\User\source\repos\WebDataBaseEDU\WebDataBaseEDU\Shared\RowUser.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60a061cd41bf0be7175a9336723a8ed1bdcba909"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.OpenElement(0, "tr");
            __builder.OpenElement(1, "td");
            __builder.AddContent(2, 
#nullable restore
#line 4 "C:\Users\User\source\repos\WebDataBaseEDU\WebDataBaseEDU\Shared\RowUser.razor"
         CurrentUser.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "td");
            __builder.AddContent(5, 
#nullable restore
#line 5 "C:\Users\User\source\repos\WebDataBaseEDU\WebDataBaseEDU\Shared\RowUser.razor"
         CurrentUser.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenElement(7, "td");
            __builder.AddContent(8, 
#nullable restore
#line 6 "C:\Users\User\source\repos\WebDataBaseEDU\WebDataBaseEDU\Shared\RowUser.razor"
         CurrentUser.Surname

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 7 "C:\Users\User\source\repos\WebDataBaseEDU\WebDataBaseEDU\Shared\RowUser.razor"
         CurrentUser.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 8 "C:\Users\User\source\repos\WebDataBaseEDU\WebDataBaseEDU\Shared\RowUser.razor"
         CurrentUser.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n    ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 9 "C:\Users\User\source\repos\WebDataBaseEDU\WebDataBaseEDU\Shared\RowUser.razor"
         CurrentUser.IsActive

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n    ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 10 "C:\Users\User\source\repos\WebDataBaseEDU\WebDataBaseEDU\Shared\RowUser.razor"
         CurrentUser.Role

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 11 "C:\Users\User\source\repos\WebDataBaseEDU\WebDataBaseEDU\Shared\RowUser.razor"
     if (IsShowOrHide)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(21, "td");
            __builder.OpenElement(22, "button");
            __builder.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\User\source\repos\WebDataBaseEDU\WebDataBaseEDU\Shared\RowUser.razor"
                              ShowUserEdit

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "class", "btn btn-success btn-sm");
            __builder.AddAttribute(25, "style", "margin-right: 0.2em");
            __builder.AddContent(26, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n            ");
            __builder.OpenElement(28, "button");
            __builder.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\User\source\repos\WebDataBaseEDU\WebDataBaseEDU\Shared\RowUser.razor"
                              ShowUserDelete

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "class", "btn btn-danger btn-sm");
            __builder.AddMarkupContent(31, "<span class=\"oi oi-trash\"></span>");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 17 "C:\Users\User\source\repos\WebDataBaseEDU\WebDataBaseEDU\Shared\RowUser.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
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
