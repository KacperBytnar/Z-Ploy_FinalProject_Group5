#pragma checksum "C:\Users\Acer\Desktop\FINALProject\FinalProject_ZPloy\FinalProject_ZPloy\Pages\Tasks\GetAllTasks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45e90f14d29ea042fe2d0a78be9d74be2f482176"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FinalProject_ZPloy.Pages.Tasks.Pages_Tasks_GetAllTasks), @"mvc.1.0.razor-page", @"/Pages/Tasks/GetAllTasks.cshtml")]
namespace FinalProject_ZPloy.Pages.Tasks
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45e90f14d29ea042fe2d0a78be9d74be2f482176", @"/Pages/Tasks/GetAllTasks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7516b472ec1797540435514bb7a910b4ca309389", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Tasks_GetAllTasks : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Tasks/CreateTask", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<p>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45e90f14d29ea042fe2d0a78be9d74be2f4821763308", async() => {
                WriteLiteral(" Create Task");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</p>

<table class=""table"">
    <thead>
        <tr>
            <th>  Task ID   </th>
            <th>    Title  </th>
            <th>    Description  </th>
            <th>  Prize   </th>
            <th>    Location  </th>
            <th>    UserID  </th>

        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 22 "C:\Users\Acer\Desktop\FINALProject\FinalProject_ZPloy\FinalProject_ZPloy\Pages\Tasks\GetAllTasks.cshtml"
         foreach (var item in Model.tasks)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\n    <td> ");
#nullable restore
#line 25 "C:\Users\Acer\Desktop\FINALProject\FinalProject_ZPloy\FinalProject_ZPloy\Pages\Tasks\GetAllTasks.cshtml"
    Write(item.TaskID);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n    <td> ");
#nullable restore
#line 26 "C:\Users\Acer\Desktop\FINALProject\FinalProject_ZPloy\FinalProject_ZPloy\Pages\Tasks\GetAllTasks.cshtml"
    Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n    <td> ");
#nullable restore
#line 27 "C:\Users\Acer\Desktop\FINALProject\FinalProject_ZPloy\FinalProject_ZPloy\Pages\Tasks\GetAllTasks.cshtml"
    Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n    <td> ");
#nullable restore
#line 28 "C:\Users\Acer\Desktop\FINALProject\FinalProject_ZPloy\FinalProject_ZPloy\Pages\Tasks\GetAllTasks.cshtml"
    Write(item.Prize);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n    <td> ");
#nullable restore
#line 29 "C:\Users\Acer\Desktop\FINALProject\FinalProject_ZPloy\FinalProject_ZPloy\Pages\Tasks\GetAllTasks.cshtml"
    Write(item.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n\n\n\n</tr>");
#nullable restore
#line 33 "C:\Users\Acer\Desktop\FINALProject\FinalProject_ZPloy\FinalProject_ZPloy\Pages\Tasks\GetAllTasks.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FinalProject_ZPloy.Pages.Tasks.GetAllTasksModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FinalProject_ZPloy.Pages.Tasks.GetAllTasksModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FinalProject_ZPloy.Pages.Tasks.GetAllTasksModel>)PageContext?.ViewData;
        public FinalProject_ZPloy.Pages.Tasks.GetAllTasksModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
