#pragma checksum "C:\Users\Khushlo\Desktop\Assignment\OpenAPI\OpenAPI\Views\Home\FetchData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10b771ab9de9e05b881d02cc8ec3a08ff2ba78e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_FetchData), @"mvc.1.0.view", @"/Views/Home/FetchData.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10b771ab9de9e05b881d02cc8ec3a08ff2ba78e9", @"/Views/Home/FetchData.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39dba4f7b8fa6391cdf97b043327657ff8f1556b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_FetchData : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\Khushlo\Desktop\Assignment\OpenAPI\OpenAPI\Views\Home\FetchData.cshtml"
  
    ViewData["Title"] = "Fetch Data From Web";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\Khushlo\Desktop\Assignment\OpenAPI\OpenAPI\Views\Home\FetchData.cshtml"
  
    var res = ViewData.Model;
    if (res == 1)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Data Fetched Successfully !!</p>\r\n");
#nullable restore
#line 14 "C:\Users\Khushlo\Desktop\Assignment\OpenAPI\OpenAPI\Views\Home\FetchData.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Error Fetching data</p>\r\n");
#nullable restore
#line 18 "C:\Users\Khushlo\Desktop\Assignment\OpenAPI\OpenAPI\Views\Home\FetchData.cshtml"
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591