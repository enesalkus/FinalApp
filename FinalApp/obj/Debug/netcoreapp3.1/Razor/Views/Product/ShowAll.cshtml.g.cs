#pragma checksum "C:\Users\NS\GitHub\FinalApp\FinalApp\Views\Product\ShowAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d0bb2889be0febc38ebe7462e28445d39999b0c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ShowAll), @"mvc.1.0.view", @"/Views/Product/ShowAll.cshtml")]
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
#line 1 "C:\Users\NS\GitHub\FinalApp\FinalApp\Views\_ViewImports.cshtml"
using FinalApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\NS\GitHub\FinalApp\FinalApp\Views\_ViewImports.cshtml"
using FinalApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\NS\GitHub\FinalApp\FinalApp\Views\Product\ShowAll.cshtml"
using FinalApp.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d0bb2889be0febc38ebe7462e28445d39999b0c", @"/Views/Product/ShowAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe8fbe6848d88ffe95ac8bac2a00039f73880daa", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_ShowAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<FinalApp.Models.Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\NS\GitHub\FinalApp\FinalApp\Views\Product\ShowAll.cshtml"
  
    ViewData["Title"] = "Product Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 7 "C:\Users\NS\GitHub\FinalApp\FinalApp\Views\Product\ShowAll.cshtml"
Write(ViewData["Heading"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<table align=\"center\" border=\"1\" width=\"50%\">\r\n    <tr>\r\n        <td>Resim</td>\r\n        <td>Kategori</td>\r\n        <td>Ürün</td>\r\n        <td>Fiyat</td>\r\n    </tr>\r\n");
#nullable restore
#line 15 "C:\Users\NS\GitHub\FinalApp\FinalApp\Views\Product\ShowAll.cshtml"
     foreach (var p in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td><img width=\"100\" height=\"100\"");
            BeginWriteAttribute("src", " src=\"", 413, "\"", 427, 1);
#nullable restore
#line 18 "C:\Users\NS\GitHub\FinalApp\FinalApp\Views\Product\ShowAll.cshtml"
WriteAttributeValue("", 419, p.Resim, 419, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n            <td>");
#nullable restore
#line 19 "C:\Users\NS\GitHub\FinalApp\FinalApp\Views\Product\ShowAll.cshtml"
           Write(p.Kategori);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 20 "C:\Users\NS\GitHub\FinalApp\FinalApp\Views\Product\ShowAll.cshtml"
           Write(p.Urun);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\NS\GitHub\FinalApp\FinalApp\Views\Product\ShowAll.cshtml"
           Write(p.Fiyat);

#line default
#line hidden
#nullable disable
            WriteLiteral("₺</td>\r\n        </tr>\r\n");
#nullable restore
#line 23 "C:\Users\NS\GitHub\FinalApp\FinalApp\Views\Product\ShowAll.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<FinalApp.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
