#pragma checksum "C:\Users\Murad\Downloads\Core_Bloq_Kamp\Core_Bloq_Kamp\Views\Shared\Components\CommentList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38594b3165f3a3cbc8b5be232fe5f3da8194a01c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CommentList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CommentList/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38594b3165f3a3cbc8b5be232fe5f3da8194a01c", @"/Views/Shared/Components/CommentList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d8472834c0357c3cfd341c7331e112f5e09ad66", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_CommentList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concrete.Comment>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"comment-top\">\r\n\t<h4>Şərhlər</h4>\r\n");
#nullable restore
#line 5 "C:\Users\Murad\Downloads\Core_Bloq_Kamp\Core_Bloq_Kamp\Views\Shared\Components\CommentList\Default.cshtml"
     foreach(var x in Model)
	{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<div class=\"media\">\r\n\t\t\t<img src=\"http://cdn.onlinewebfonts.com/svg/img_24787.png\" style=\"height: 40px; width: 40px;\"");
            BeginWriteAttribute("alt", " alt=\"", 248, "\"", 254, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\" />\r\n\t\t\t<div class=\"media-body\">\r\n\t\t\t\t<h5 class=\"mt-0\">");
#nullable restore
#line 10 "C:\Users\Murad\Downloads\Core_Bloq_Kamp\Core_Bloq_Kamp\Views\Shared\Components\CommentList\Default.cshtml"
                            Write(x.CommentUserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\t\t\t\t<p>\r\n\t\t\t\t\t");
#nullable restore
#line 12 "C:\Users\Murad\Downloads\Core_Bloq_Kamp\Core_Bloq_Kamp\Views\Shared\Components\CommentList\Default.cshtml"
               Write(x.CommenContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</p>\r\n\t\t\t</div>\r\n\t\t</div>\r\n");
#nullable restore
#line 16 "C:\Users\Murad\Downloads\Core_Bloq_Kamp\Core_Bloq_Kamp\Views\Shared\Components\CommentList\Default.cshtml"

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntityLayer.Concrete.Comment>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
