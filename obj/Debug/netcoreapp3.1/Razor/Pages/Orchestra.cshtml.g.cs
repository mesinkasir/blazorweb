#pragma checksum "C:\Users\creativebydre\BlazorApp\New folder\razorsite\Pages\Orchestra.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8bdac4d1556033965eec1027a89a7f0ce82a95b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(razorsite.Pages.Pages_Orchestra), @"mvc.1.0.razor-page", @"/Pages/Orchestra.cshtml")]
namespace razorsite.Pages
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
#line 1 "C:\Users\creativebydre\BlazorApp\New folder\razorsite\Pages\_ViewImports.cshtml"
using razorsite;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bdac4d1556033965eec1027a89a7f0ce82a95b4", @"/Pages/Orchestra.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4834be2349bc436b322032a0194f01edf30da986", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Orchestra : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\creativebydre\BlazorApp\New folder\razorsite\Pages\Orchestra.cshtml"
  
    ViewData["Title"] = "Blazor Web App";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"text-center\">\r\n     <h1><strong>Orchestra Art</strong></h1>\r\n    <div class=\"ratio ratio-16x9\">\r\n  <iframe src=\"https://www.youtube.com/embed/N-sVtvY1Lhk\" class=\"shadow rounded\" allowfullscreen></iframe>\r\n</div>  \r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrchestraModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OrchestraModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OrchestraModel>)PageContext?.ViewData;
        public OrchestraModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
