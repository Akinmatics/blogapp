#pragma checksum "C:\Users\User\desktop\dev\mywebsite\Views\AboutMe\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "244f595e8b50d11e11a144e3bb2d640a99faf0b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AboutMe_Index), @"mvc.1.0.view", @"/Views/AboutMe/Index.cshtml")]
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
#line 1 "C:\Users\User\desktop\dev\mywebsite\Views\_ViewImports.cshtml"
using mywebsite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\desktop\dev\mywebsite\Views\_ViewImports.cshtml"
using mywebsite.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"244f595e8b50d11e11a144e3bb2d640a99faf0b0", @"/Views/AboutMe/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"988a296778a7ae6773ec03b617ffa6973abc01a9", @"/Views/_ViewImports.cshtml")]
    public class Views_AboutMe_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Page>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\desktop\dev\mywebsite\Views\AboutMe\Index.cshtml"
  
    ViewData["Title"] = "About me";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\User\desktop\dev\mywebsite\Views\AboutMe\Index.cshtml"
Write(Html.Raw(Model?.Content));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Page> Html { get; private set; }
    }
}
#pragma warning restore 1591
