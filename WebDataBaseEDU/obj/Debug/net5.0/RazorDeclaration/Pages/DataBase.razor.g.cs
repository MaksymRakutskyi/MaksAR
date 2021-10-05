// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WebDataBaseEDU.Pages
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
#line 3 "C:\Users\User\source\repos\WebDataBaseEDU\WebDataBaseEDU\Pages\DataBase.razor"
using WebDataBaseEDU.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\source\repos\WebDataBaseEDU\WebDataBaseEDU\Pages\DataBase.razor"
using Microsoft.AspNetCore.Http.Features;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/database")]
    public partial class DataBase : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "C:\Users\User\source\repos\WebDataBaseEDU\WebDataBaseEDU\Pages\DataBase.razor"
       
    
    List<User> users { get; set; }
    
    protected override void OnInitialized()
    {
        using (var connection = new SqliteConnection("Data Source = baza.db;"))
        {
            connection.Open();

            SqliteCommand command = new SqliteCommand();
            command.Connection = connection;

            command.CommandText = "SELECT * FROM Users";

            using (SqliteDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    users = new List<User>();
                    while (reader.Read())
                    {               
                        users.Add(new User() 
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Surname = reader.GetString(2),
                            Age = reader.GetInt32(3),
                            Description = reader.GetString(4),
                            IsActive = reader.GetBoolean(5),
                            Role = reader.GetString(6)
                        });
                        
                    }
                    
                }
            }
        }
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591