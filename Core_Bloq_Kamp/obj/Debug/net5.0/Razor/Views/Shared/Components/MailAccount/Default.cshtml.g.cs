#pragma checksum "C:\Users\Murad\Downloads\Core_Bloq_Kamp\Core_Bloq_Kamp\Views\Shared\Components\MailAccount\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b25fdd59f325002e9a3ec7a7a4147cd137da3a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_MailAccount_Default), @"mvc.1.0.view", @"/Views/Shared/Components/MailAccount/Default.cshtml")]
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
#line 1 "C:\Users\Murad\Downloads\Core_Bloq_Kamp\Core_Bloq_Kamp\Views\_ViewImports.cshtml"
using Core_Bloq_Kamp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Murad\Downloads\Core_Bloq_Kamp\Core_Bloq_Kamp\Views\_ViewImports.cshtml"
using Core_Bloq_Kamp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Murad\Downloads\Core_Bloq_Kamp\Core_Bloq_Kamp\Views\Shared\Components\MailAccount\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b25fdd59f325002e9a3ec7a7a4147cd137da3a7", @"/Views/Shared/Components/MailAccount/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d8472834c0357c3cfd341c7331e112f5e09ad66", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_MailAccount_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Writer>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"account-top\">\r\n");
#nullable restore
#line 5 "C:\Users\Murad\Downloads\Core_Bloq_Kamp\Core_Bloq_Kamp\Views\Shared\Components\MailAccount\Default.cshtml"
     foreach (var x in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"account-top-left\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 173, "\"", 193, 1);
#nullable restore
#line 8 "C:\Users\Murad\Downloads\Core_Bloq_Kamp\Core_Bloq_Kamp\Views\Shared\Components\MailAccount\Default.cshtml"
WriteAttributeValue("", 179, x.WriterImage, 179, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 1.5cm; height: 1.5cm; border-radius: 100%\"");
            BeginWriteAttribute("alt", " alt=\"", 251, "\"", 257, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n        </div>\r\n        <div class=\"account-top-right\">\r\n            <h2>");
#nullable restore
#line 11 "C:\Users\Murad\Downloads\Core_Bloq_Kamp\Core_Bloq_Kamp\Views\Shared\Components\MailAccount\Default.cshtml"
           Write(x.WriterName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h2>\r\n            <p>");
#nullable restore
#line 12 "C:\Users\Murad\Downloads\Core_Bloq_Kamp\Core_Bloq_Kamp\Views\Shared\Components\MailAccount\Default.cshtml"
          Write(x.WriterMail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"clear\"> </div>\r\n");
#nullable restore
#line 15 "C:\Users\Murad\Downloads\Core_Bloq_Kamp\Core_Bloq_Kamp\Views\Shared\Components\MailAccount\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Writer>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
