#pragma checksum "C:\Users\Murad\Downloads\Core_Bloq_Kamp\Core_Bloq_Kamp\Views\Shared\Components\MessageNav\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "270c1b791197e965b2ea012932d750488ae44df4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_MessageNav_Default), @"mvc.1.0.view", @"/Views/Shared/Components/MessageNav/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"270c1b791197e965b2ea012932d750488ae44df4", @"/Views/Shared/Components/MessageNav/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d8472834c0357c3cfd341c7331e112f5e09ad66", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_MessageNav_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<nav>\r\n    <a><span> </span>Gələnlər <i>");
#nullable restore
#line 3 "C:\Users\Murad\Downloads\Core_Bloq_Kamp\Core_Bloq_Kamp\Views\Shared\Components\MessageNav\Default.cshtml"
                            Write(ViewBag.gelen);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i></a>\r\n    <a><span class=\"icon3\"></span>Göndərilənlər <i>");
#nullable restore
#line 4 "C:\Users\Murad\Downloads\Core_Bloq_Kamp\Core_Bloq_Kamp\Views\Shared\Components\MessageNav\Default.cshtml"
                                              Write(ViewBag.gonderilen);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i></a>\r\n    <a><span class=\"icon4\"></span>Silinənlər</a>\r\n</nav>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
