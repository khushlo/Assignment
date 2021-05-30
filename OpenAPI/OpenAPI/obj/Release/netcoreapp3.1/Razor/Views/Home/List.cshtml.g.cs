#pragma checksum "C:\Users\Khushlo\Desktop\Assignment\OpenAPI\OpenAPI\Views\Home\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "709dbd375611126d50e3421785cad0b98dca781d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_List), @"mvc.1.0.view", @"/Views/Home/List.cshtml")]
namespace AspNetCore
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
#line 1 "C:\Users\Khushlo\Desktop\Assignment\OpenAPI\OpenAPI\Views\_ViewImports.cshtml"
using OpenAPI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Khushlo\Desktop\Assignment\OpenAPI\OpenAPI\Views\_ViewImports.cshtml"
using OpenAPI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"709dbd375611126d50e3421785cad0b98dca781d", @"/Views/Home/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39dba4f7b8fa6391cdf97b043327657ff8f1556b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DatasetService.Cheese>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "FetchDataFromWeb", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Khushlo\Desktop\Assignment\OpenAPI\OpenAPI\Views\Home\List.cshtml"
  
    ViewData["Title"] = "Cheese List";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>List</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "709dbd375611126d50e3421785cad0b98dca781d3648", async() => {
                WriteLiteral("Refresh data");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <pre>\r\n        ");
#nullable restore
#line 12 "C:\Users\Khushlo\Desktop\Assignment\OpenAPI\OpenAPI\Views\Home\List.cshtml"
   Write(Html.ActionLink("Create", "Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n        ");
#nullable restore
#line 13 "C:\Users\Khushlo\Desktop\Assignment\OpenAPI\OpenAPI\Views\Home\List.cshtml"
   Write(Html.ActionLink("DeleteAll", "DeleteAll"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n    </pre>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\Khushlo\Desktop\Assignment\OpenAPI\OpenAPI\Views\Home\List.cshtml"
           Write(Html.DisplayNameFor(model => model.CheeseId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\Khushlo\Desktop\Assignment\OpenAPI\OpenAPI\Views\Home\List.cshtml"
           Write(Html.DisplayNameFor(model => model.CheeseNameEn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\Khushlo\Desktop\Assignment\OpenAPI\OpenAPI\Views\Home\List.cshtml"
           Write(Html.DisplayNameFor(model => model.CheeseNameFr));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "C:\Users\Khushlo\Desktop\Assignment\OpenAPI\OpenAPI\Views\Home\List.cshtml"
           Write(Html.DisplayNameFor(model => model.ManufacturerNameEn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "C:\Users\Khushlo\Desktop\Assignment\OpenAPI\OpenAPI\Views\Home\List.cshtml"
           Write(Html.DisplayNameFor(model => model.ManufacturerNameFr));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n");
            WriteLiteral("            <th>\r\n                ");
#nullable restore
#line 107 "C:\Users\Khushlo\Desktop\Assignment\OpenAPI\OpenAPI\Views\Home\List.cshtml"
           Write(Html.DisplayNameFor(model => model.LastUpdateDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 113 "C:\Users\Khushlo\Desktop\Assignment\OpenAPI\OpenAPI\Views\Home\List.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 116 "C:\Users\Khushlo\Desktop\Assignment\OpenAPI\OpenAPI\Views\Home\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.CheeseId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 119 "C:\Users\Khushlo\Desktop\Assignment\OpenAPI\OpenAPI\Views\Home\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.CheeseNameEn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 122 "C:\Users\Khushlo\Desktop\Assignment\OpenAPI\OpenAPI\Views\Home\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.CheeseNameFr));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 125 "C:\Users\Khushlo\Desktop\Assignment\OpenAPI\OpenAPI\Views\Home\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.ManufacturerNameEn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 128 "C:\Users\Khushlo\Desktop\Assignment\OpenAPI\OpenAPI\Views\Home\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.ManufacturerNameFr));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n");
            WriteLiteral("            <td>\r\n                ");
#nullable restore
#line 203 "C:\Users\Khushlo\Desktop\Assignment\OpenAPI\OpenAPI\Views\Home\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.LastUpdateDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 206 "C:\Users\Khushlo\Desktop\Assignment\OpenAPI\OpenAPI\Views\Home\List.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new {  id=item.CheeseId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 207 "C:\Users\Khushlo\Desktop\Assignment\OpenAPI\OpenAPI\Views\Home\List.cshtml"
           Write(Html.ActionLink("Details", "Details", new { id = item.CheeseId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 208 "C:\Users\Khushlo\Desktop\Assignment\OpenAPI\OpenAPI\Views\Home\List.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id = item.CheeseId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 211 "C:\Users\Khushlo\Desktop\Assignment\OpenAPI\OpenAPI\Views\Home\List.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DatasetService.Cheese>> Html { get; private set; }
    }
}
#pragma warning restore 1591