#pragma checksum "C:\Users\User\source\repos\WebDataBaseEDU\WebDataBaseEDU\Shared\UserDelete.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa92d40e08b2bd142eed3659b68e3a16007a2403"
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
#line 1 "C:\Users\User\source\repos\WebDataBaseEDU\WebDataBaseEDU\Shared\UserDelete.razor"
using WebDataBaseEDU.Data;

#line default
#line hidden
#nullable disable
    public partial class UserDelete : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "style", "padding-bottom: 1rem");
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table");
            __builder.AddMarkupContent(4, "<thead><tr><th>Name</th>\r\n            <th>Surname</th>\r\n            <th>Age</th>\r\n            <th>Descriprion</th>\r\n            <th>IsActive</th>\r\n            <th>Role</th></tr></thead>\r\n        ");
            __builder.OpenElement(5, "tr");
            __builder.OpenElement(6, "td");
            __builder.AddContent(7, 
#nullable restore
#line 16 "C:\Users\User\source\repos\WebDataBaseEDU\WebDataBaseEDU\Shared\UserDelete.razor"
                 SomeUserToDelete.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "td");
            __builder.AddContent(10, 
#nullable restore
#line 17 "C:\Users\User\source\repos\WebDataBaseEDU\WebDataBaseEDU\Shared\UserDelete.razor"
                 SomeUserToDelete.Surname

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.OpenElement(12, "td");
            __builder.AddContent(13, 
#nullable restore
#line 18 "C:\Users\User\source\repos\WebDataBaseEDU\WebDataBaseEDU\Shared\UserDelete.razor"
                 SomeUserToDelete.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenElement(15, "td");
            __builder.AddContent(16, 
#nullable restore
#line 19 "C:\Users\User\source\repos\WebDataBaseEDU\WebDataBaseEDU\Shared\UserDelete.razor"
                 SomeUserToDelete.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 20 "C:\Users\User\source\repos\WebDataBaseEDU\WebDataBaseEDU\Shared\UserDelete.razor"
                 SomeUserToDelete.IsActive

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n            ");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 21 "C:\Users\User\source\repos\WebDataBaseEDU\WebDataBaseEDU\Shared\UserDelete.razor"
                 SomeUserToDelete.Role

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n\r\n");
            __builder.OpenElement(24, "div");
            __builder.OpenElement(25, "button");
            __builder.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "C:\Users\User\source\repos\WebDataBaseEDU\WebDataBaseEDU\Shared\UserDelete.razor"
                      Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "class", "btn btn-danger");
            __builder.AddAttribute(28, "style", "float: right");
            __builder.AddContent(29, "Cancel");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n    ");
            __builder.OpenElement(31, "button");
            __builder.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\User\source\repos\WebDataBaseEDU\WebDataBaseEDU\Shared\UserDelete.razor"
                      Submit

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "class", "btn btn-success");
            __builder.AddAttribute(34, "style", "float: right; margin-right: 0.4em;");
            __builder.AddContent(35, "Submit");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "C:\Users\User\source\repos\WebDataBaseEDU\WebDataBaseEDU\Shared\UserDelete.razor"
       

    [CascadingParameter] BlazoredModalInstance BlazoredModal { get; set; }
    
    [Parameter] public User SomeUserToDelete { get; set; }
 
    async Task Cancel() => await BlazoredModal.CancelAsync();
    async Task Submit() => await BlazoredModal.CloseAsync(ModalResult.Ok(true));

    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
