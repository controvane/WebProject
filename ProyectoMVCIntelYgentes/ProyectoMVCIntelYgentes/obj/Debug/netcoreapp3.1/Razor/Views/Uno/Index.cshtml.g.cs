#pragma checksum "F:\PRW3_2021\ProyectoMVCIntelYgentes\ProyectoMVCIntelYgentes\Views\Uno\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "061f3e688519b1d9044240d88835ebef28c7b48f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Uno_Index), @"mvc.1.0.view", @"/Views/Uno/Index.cshtml")]
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
#line 1 "F:\PRW3_2021\ProyectoMVCIntelYgentes\ProyectoMVCIntelYgentes\Views\_ViewImports.cshtml"
using ProyectoMVCIntelYgentes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\PRW3_2021\ProyectoMVCIntelYgentes\ProyectoMVCIntelYgentes\Views\_ViewImports.cshtml"
using ProyectoMVCIntelYgentes.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"061f3e688519b1d9044240d88835ebef28c7b48f", @"/Views/Uno/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb278eee8095328452db33a2573be6a61d597554", @"/Views/_ViewImports.cshtml")]
    public class Views_Uno_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "F:\PRW3_2021\ProyectoMVCIntelYgentes\ProyectoMVCIntelYgentes\Views\Uno\Index.cshtml"
  
    ViewData["Title"] = "Controlador Uno";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index - Uno </h1>\r\n<p>Vista con datos debilmente tipados</p>\r\n<p>");
#nullable restore
#line 8 "F:\PRW3_2021\ProyectoMVCIntelYgentes\ProyectoMVCIntelYgentes\Views\Uno\Index.cshtml"
Write(ViewData["mensaje"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 9 "F:\PRW3_2021\ProyectoMVCIntelYgentes\ProyectoMVCIntelYgentes\Views\Uno\Index.cshtml"
Write(ViewBag.mensaje1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
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