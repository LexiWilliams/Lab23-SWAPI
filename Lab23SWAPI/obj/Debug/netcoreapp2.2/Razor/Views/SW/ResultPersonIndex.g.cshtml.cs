#pragma checksum "C:\Users\lexas\Desktop\C#\Week 7\Lab23-SWAPI\Lab23SWAPI\Views\SW\ResultPersonIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "367d0ccd3bc15d0e4f24a2cd6f8d3bf866b01313"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SW_ResultPersonIndex), @"mvc.1.0.view", @"/Views/SW/ResultPersonIndex.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SW/ResultPersonIndex.cshtml", typeof(AspNetCore.Views_SW_ResultPersonIndex))]
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
#line 1 "C:\Users\lexas\Desktop\C#\Week 7\Lab23-SWAPI\Lab23SWAPI\Views\_ViewImports.cshtml"
using Lab23SWAPI;

#line default
#line hidden
#line 2 "C:\Users\lexas\Desktop\C#\Week 7\Lab23-SWAPI\Lab23SWAPI\Views\_ViewImports.cshtml"
using Lab23SWAPI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"367d0ccd3bc15d0e4f24a2cd6f8d3bf866b01313", @"/Views/SW/ResultPersonIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e208850e95dd75cd2335bfc81e3987516016e1b", @"/Views/_ViewImports.cshtml")]
    public class Views_SW_ResultPersonIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lab23SWAPI.Models.Person>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\lexas\Desktop\C#\Week 7\Lab23-SWAPI\Lab23SWAPI\Views\SW\ResultPersonIndex.cshtml"
  
    ViewData["Title"] = "ResultPersonIndex";

#line default
#line hidden
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(90, 28, true);
            WriteLiteral("\r\n<h1>Result Person</h1>\r\n\r\n");
            EndContext();
            BeginContext(119, 10, false);
#line 10 "C:\Users\lexas\Desktop\C#\Week 7\Lab23-SWAPI\Lab23SWAPI\Views\SW\ResultPersonIndex.cshtml"
Write(Model.name);

#line default
#line hidden
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lab23SWAPI.Models.Person> Html { get; private set; }
    }
}
#pragma warning restore 1591
