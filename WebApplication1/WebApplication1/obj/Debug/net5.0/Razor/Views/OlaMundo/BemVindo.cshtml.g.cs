#pragma checksum "C:\Users\gabri\Desktop\projects\ASP\WebApplication1\WebApplication1\Views\OlaMundo\BemVindo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6020b862115af0c372a5cad0f62b33da65e8ad32"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OlaMundo_BemVindo), @"mvc.1.0.view", @"/Views/OlaMundo/BemVindo.cshtml")]
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
#line 1 "C:\Users\gabri\Desktop\projects\ASP\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gabri\Desktop\projects\ASP\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6020b862115af0c372a5cad0f62b33da65e8ad32", @"/Views/OlaMundo/BemVindo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_OlaMundo_BemVindo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\gabri\Desktop\projects\ASP\WebApplication1\WebApplication1\Views\OlaMundo\BemVindo.cshtml"
  
    ViewData["Title"] = "BemVindo";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>BemVindo</h1>\r\n\r\n<h2>Vamos mostrar ");
#nullable restore
#line 8 "C:\Users\gabri\Desktop\projects\ASP\WebApplication1\WebApplication1\Views\OlaMundo\BemVindo.cshtml"
             Write(ViewData["NumVezes"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" vezes a mensagem:</h2>\r\n\r\n<ul>\r\n");
#nullable restore
#line 11 "C:\Users\gabri\Desktop\projects\ASP\WebApplication1\WebApplication1\Views\OlaMundo\BemVindo.cshtml"
     for(int i = 0; i < (int)ViewData["NumVezes"]; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>");
#nullable restore
#line 13 "C:\Users\gabri\Desktop\projects\ASP\WebApplication1\WebApplication1\Views\OlaMundo\BemVindo.cshtml"
       Write(ViewData["Mensagem"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 14 "C:\Users\gabri\Desktop\projects\ASP\WebApplication1\WebApplication1\Views\OlaMundo\BemVindo.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n");
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
