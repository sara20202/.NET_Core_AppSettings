#pragma checksum "C:\Users\User\source\repos\BasicDemoApp\BasicDemo\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7341ad809cce04da603713aa3cd693a6f5a975d6"
// <auto-generated/>
#pragma warning disable 1591
namespace BasicDemo.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\User\source\repos\BasicDemoApp\BasicDemo\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\repos\BasicDemoApp\BasicDemo\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\source\repos\BasicDemoApp\BasicDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\source\repos\BasicDemoApp\BasicDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\source\repos\BasicDemoApp\BasicDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\source\repos\BasicDemoApp\BasicDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\source\repos\BasicDemoApp\BasicDemo\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\source\repos\BasicDemoApp\BasicDemo\_Imports.razor"
using BasicDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\User\source\repos\BasicDemoApp\BasicDemo\_Imports.razor"
using BasicDemo.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\User\source\repos\BasicDemoApp\BasicDemo\_Imports.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\User\source\repos\BasicDemoApp\BasicDemo\_Imports.razor"
using BasicDemo.Options;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Hello, world!</h1>\r\n\r\nWelcome to your new app.\r\n\r\n");
            __builder.OpenComponent<BasicDemo.Shared.SurveyPrompt>(1);
            __builder.AddAttribute(2, "Title", "How is Blazor working for you?");
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n");
            __builder.OpenElement(4, "p");
            __builder.AddMarkupContent(5, "\r\n    MySetting value :");
            __builder.AddContent(6, 
#nullable restore
#line 11 "C:\Users\User\source\repos\BasicDemoApp\BasicDemo\Pages\Index.razor"
                      mySetting

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(7, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.OpenElement(9, "p");
            __builder.AddMarkupContent(10, "\r\n    MySubSetting value :");
            __builder.AddContent(11, 
#nullable restore
#line 14 "C:\Users\User\source\repos\BasicDemoApp\BasicDemo\Pages\Index.razor"
                         mySubSetting

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(12, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n");
            __builder.OpenElement(14, "p");
            __builder.AddMarkupContent(15, "\r\n    MySubSetting value :");
            __builder.AddContent(16, 
#nullable restore
#line 17 "C:\Users\User\source\repos\BasicDemoApp\BasicDemo\Pages\Index.razor"
                         mySubSubSetting

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(17, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n");
            __builder.OpenElement(19, "p");
            __builder.AddMarkupContent(20, "\r\n    MyConnectionString value :");
            __builder.AddContent(21, 
#nullable restore
#line 20 "C:\Users\User\source\repos\BasicDemoApp\BasicDemo\Pages\Index.razor"
                               ConnectionString

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(22, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n");
            __builder.OpenElement(24, "p");
            __builder.AddMarkupContent(25, "\r\n    Enable Email: ");
            __builder.AddContent(26, 
#nullable restore
#line 23 "C:\Users\User\source\repos\BasicDemoApp\BasicDemo\Pages\Index.razor"
                   emailSettings.EnableEmailSystem

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(27, " <br>\r\n    Email Timeout :");
            __builder.AddContent(28, 
#nullable restore
#line 24 "C:\Users\User\source\repos\BasicDemoApp\BasicDemo\Pages\Index.razor"
                    emailSettings.EmailTimeoutInSeconds

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(29, "<br>\r\n    Email Services:\r\n");
#nullable restore
#line 26 "C:\Users\User\source\repos\BasicDemoApp\BasicDemo\Pages\Index.razor"
     foreach(string server in emailSettings.EmailServices)
            {
                

#line default
#line hidden
#nullable disable
            __builder.AddContent(30, 
#nullable restore
#line 28 "C:\Users\User\source\repos\BasicDemoApp\BasicDemo\Pages\Index.razor"
                 server

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(31, " &nbsp;\r\n");
#nullable restore
#line 29 "C:\Users\User\source\repos\BasicDemoApp\BasicDemo\Pages\Index.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(32, "    <br>\r\n    Email Admin: ");
            __builder.AddContent(33, 
#nullable restore
#line 31 "C:\Users\User\source\repos\BasicDemoApp\BasicDemo\Pages\Index.razor"
                  emailSettings.EmailAdmin.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(34, " ");
            __builder.AddContent(35, 
#nullable restore
#line 31 "C:\Users\User\source\repos\BasicDemoApp\BasicDemo\Pages\Index.razor"
                                                      emailSettings.EmailAdmin.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(36, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Users\User\source\repos\BasicDemoApp\BasicDemo\Pages\Index.razor"
      
    string mySetting = "";
    string mySubSetting =  "";
    string mySubSubSetting = ""; 
    string ConnectionString = "";
    EmailSettingsOptions emailSettings = new EmailSettingsOptions();
    protected override void OnInitialized()
    {
        mySetting = _config.GetValue<string>("MySetting");
        mySubSetting = _config.GetValue<string>("MainSetting:SubSetting");
        mySubSubSetting = _config.GetValue<string>("MainSetting:SubSection:SubSubSetting");
        ConnectionString = _config.GetConnectionString("Default");
        emailSettings = _config.GetSection("EmailSettings").Get<EmailSettingsOptions>();

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration _config { get; set; }
    }
}
#pragma warning restore 1591
