#pragma checksum "C:\Users\Acer\Desktop\FINALProject\FinalProject_ZPloy\FinalProject_ZPloy\Pages\UserAccount\DisplayUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f99aff0277b802dea33be56c5b10a970096544aa"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f99aff0277b802dea33be56c5b10a970096544aa", @"/Pages/UserAccount/DisplayUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7516b472ec1797540435514bb7a910b4ca309389", @"/Pages/_ViewImports.cshtml")]
    public class Pages_UserAccount_DisplayUser : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/UserAccount/EditUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn1 btn-dark float-xl-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString(" font-size: x-large"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<style>

    .profile {
        margin: auto;
        width: 60%;
        padding-top: 20px;
    }
    label{
        font-weight:600;
        margin-right:10px;
    }
</style>


<section class=""section about-section gray-bg"" id=""about"">
    <div class=""profile"">
        <div class=""row align-items-center flex-row-reverse"">
            <div class=""col-lg-6"">
                <div class=""about-text go-to"">
                    <h3 class=""dark-color"">About Me</h3>

                    <p>");
#nullable restore
#line 26 "C:\Users\Acer\Desktop\FINALProject\FinalProject_ZPloy\FinalProject_ZPloy\Pages\UserAccount\DisplayUser.cshtml"
                  Write(Model.LoggedUser.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\n                    <div class=\"row about-list\">\n                        <div class=\"col-md-6\">\n                            <div class=\"media\">\n                                <label>   Name: </label>\n                                <p>");
#nullable restore
#line 31 "C:\Users\Acer\Desktop\FINALProject\FinalProject_ZPloy\FinalProject_ZPloy\Pages\UserAccount\DisplayUser.cshtml"
                              Write(Model.LoggedUser.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            </div>\n                            <div class=\"media\">\n                                <label>   Full Name: </label>\n                                <p>");
#nullable restore
#line 35 "C:\Users\Acer\Desktop\FINALProject\FinalProject_ZPloy\FinalProject_ZPloy\Pages\UserAccount\DisplayUser.cshtml"
                              Write(Model.LoggedUser.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 35 "C:\Users\Acer\Desktop\FINALProject\FinalProject_ZPloy\FinalProject_ZPloy\Pages\UserAccount\DisplayUser.cshtml"
                                                          Write(Model.LoggedUser.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            </div>\n                            <div class=\"media\">\n                                <label>   Age: </label>\n                                <p>");
#nullable restore
#line 39 "C:\Users\Acer\Desktop\FINALProject\FinalProject_ZPloy\FinalProject_ZPloy\Pages\UserAccount\DisplayUser.cshtml"
                              Write(Model.LoggedUser.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                            </div>
                        </div>
                        <div class=""col-md-6"">
                            <div class=""media"">
                                <label> Address: </label>
                                <p>   ");
#nullable restore
#line 45 "C:\Users\Acer\Desktop\FINALProject\FinalProject_ZPloy\FinalProject_ZPloy\Pages\UserAccount\DisplayUser.cshtml"
                                 Write(Model.LoggedUser.StreetAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 45 "C:\Users\Acer\Desktop\FINALProject\FinalProject_ZPloy\FinalProject_ZPloy\Pages\UserAccount\DisplayUser.cshtml"
                                                                  Write(Model.LoggedUser.ZipCode);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 45 "C:\Users\Acer\Desktop\FINALProject\FinalProject_ZPloy\FinalProject_ZPloy\Pages\UserAccount\DisplayUser.cshtml"
                                                                                            Write(Model.LoggedUser.City);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\n                            </div>\n                            <div class=\"media\">\n                                <label> Email:</label>\n                                <p>");
#nullable restore
#line 49 "C:\Users\Acer\Desktop\FINALProject\FinalProject_ZPloy\FinalProject_ZPloy\Pages\UserAccount\DisplayUser.cshtml"
                              Write(Model.LoggedUser.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            </div>\n                            <div class=\"media\">\n                                <label> Phone: </label>\n                                <p>   ");
#nullable restore
#line 53 "C:\Users\Acer\Desktop\FINALProject\FinalProject_ZPloy\FinalProject_ZPloy\Pages\UserAccount\DisplayUser.cshtml"
                                 Write(Model.LoggedUser.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            </div>\n                        </div>\n                    </div>\n                </div>\n            </div>\n            <div class=\"col-lg-6\">\n                <div class=\"about-avatar\">\n                    <img");
            BeginWriteAttribute("src", " src=\"", 2296, "\"", 2327, 1);
#nullable restore
#line 61 "C:\Users\Acer\Desktop\FINALProject\FinalProject_ZPloy\FinalProject_ZPloy\Pages\UserAccount\DisplayUser.cshtml"
WriteAttributeValue("", 2302, Model.LoggedUser.Picture, 2302, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid img-thumbnail\"");
            BeginWriteAttribute("title", " title=\"", 2360, "\"", 2368, 0);
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2369, "\"", 2375, 0);
            EndWriteAttribute();
            WriteLiteral("> \n                </div>\n            </div>\n        </div>\n\n        <div class=\" d-flex mt-2\" style=\"float: right; margin-bottom:150px; margin-left:100px;\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f99aff0277b802dea33be56c5b10a970096544aa9959", async() => {
                WriteLiteral("Edit Profile");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </div>\n\n    </div>\n</section>");
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
