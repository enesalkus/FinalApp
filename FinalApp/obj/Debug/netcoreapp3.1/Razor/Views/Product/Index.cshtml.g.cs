#pragma checksum "C:\Users\NS\GitHub\FinalApp\FinalApp\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84d02c86e6f31436e8075b93e30ac85983ddc7e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84d02c86e6f31436e8075b93e30ac85983ddc7e5", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe8fbe6848d88ffe95ac8bac2a00039f73880daa", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FinalApp.Models.Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\NS\GitHub\FinalApp\FinalApp\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Product Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"urun\">\r\n    <div class=\"urun-resim\">\r\n        <img style=\"width: 100%;\"");
            BeginWriteAttribute("src", " src=\"", 167, "\"", 185, 1);
#nullable restore
#line 9 "C:\Users\NS\GitHub\FinalApp\FinalApp\Views\Product\Index.cshtml"
WriteAttributeValue("", 173, Model.Resim, 173, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div>\r\n    <div class=\"urun-icerik\">\r\n        <div class=\"urun-baslik\">\r\n            <div class=\"icerik-yazi\"><b>");
#nullable restore
#line 13 "C:\Users\NS\GitHub\FinalApp\FinalApp\Views\Product\Index.cshtml"
                                   Write(Model.Kategori);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></div>\r\n            <div class=\"icerik-yazi\">");
#nullable restore
#line 14 "C:\Users\NS\GitHub\FinalApp\FinalApp\Views\Product\Index.cshtml"
                                Write(Model.Urun);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        </div>\r\n        <div class=\"urun-fiyat\"><b>");
#nullable restore
#line 16 "C:\Users\NS\GitHub\FinalApp\FinalApp\Views\Product\Index.cshtml"
                              Write(Model.Fiyat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></div>\r\n    </div>\r\n</div>\r\n<br style=\"clear:both;\" />");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FinalApp.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
