#pragma checksum "C:\Users\Acer\Desktop\FINALProject\FinalProject_ZPloy\FinalProject_ZPloy\Pages\UserAccount\DisplayUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52a079cc74ce370ebd40d3688f279bae1862ba58"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FinalProject_ZPloy.Pages.UserAccount.Pages_UserAccount_DisplayUser), @"mvc.1.0.razor-page", @"/Pages/UserAccount/DisplayUser.cshtml")]
namespace FinalProject_ZPloy.Pages.UserAccount
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Acer\Desktop\FINALProject\FinalProject_ZPloy\FinalProject_ZPloy\Pages\_ViewImports.cshtml"
using FinalProject_ZPloy;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52a079cc74ce370ebd40d3688f279bae1862ba58", @"/Pages/UserAccount/DisplayUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7516b472ec1797540435514bb7a910b4ca309389", @"/Pages/_ViewImports.cshtml")]
    public class Pages_UserAccount_DisplayUser : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 5 "C:\Users\Acer\Desktop\FINALProject\FinalProject_ZPloy\FinalProject_ZPloy\Pages\UserAccount\DisplayUser.cshtml"
 foreach (var user in Model.users)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Name: ");
#nullable restore
#line 7 "C:\Users\Acer\Desktop\FINALProject\FinalProject_ZPloy\FinalProject_ZPloy\Pages\UserAccount\DisplayUser.cshtml"
     Write(user.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n                <h1>Password: ");
#nullable restore
#line 8 "C:\Users\Acer\Desktop\FINALProject\FinalProject_ZPloy\FinalProject_ZPloy\Pages\UserAccount\DisplayUser.cshtml"
                         Write(user.PasswordHash);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n                                <h1>Description: <\\br>");
#nullable restore
#line 9 "C:\Users\Acer\Desktop\FINALProject\FinalProject_ZPloy\FinalProject_ZPloy\Pages\UserAccount\DisplayUser.cshtml"
                                                 Write(user.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>");
#nullable restore
#line 9 "C:\Users\Acer\Desktop\FINALProject\FinalProject_ZPloy\FinalProject_ZPloy\Pages\UserAccount\DisplayUser.cshtml"
                                                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>ID: <\\br>");
#nullable restore
#line 10 "C:\Users\Acer\Desktop\FINALProject\FinalProject_ZPloy\FinalProject_ZPloy\Pages\UserAccount\DisplayUser.cshtml"
        Write(Model.UserID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FinalProject_ZPloy.Pages.UserAccount.DisplayUserModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FinalProject_ZPloy.Pages.UserAccount.DisplayUserModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FinalProject_ZPloy.Pages.UserAccount.DisplayUserModel>)PageContext?.ViewData;
        public FinalProject_ZPloy.Pages.UserAccount.DisplayUserModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
