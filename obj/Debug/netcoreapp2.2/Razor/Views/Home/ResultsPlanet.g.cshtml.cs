#pragma checksum "C:\Users\achia\OneDrive\Desktop\LabsWeekSeven\SWAPI\SWAPI\Views\Home\ResultsPlanet.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15f6643c519db9721cc8161b98f52a7d606e2a49"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ResultsPlanet), @"mvc.1.0.view", @"/Views/Home/ResultsPlanet.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ResultsPlanet.cshtml", typeof(AspNetCore.Views_Home_ResultsPlanet))]
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
#line 1 "C:\Users\achia\OneDrive\Desktop\LabsWeekSeven\SWAPI\SWAPI\Views\_ViewImports.cshtml"
using SWAPI;

#line default
#line hidden
#line 2 "C:\Users\achia\OneDrive\Desktop\LabsWeekSeven\SWAPI\SWAPI\Views\_ViewImports.cshtml"
using SWAPI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15f6643c519db9721cc8161b98f52a7d606e2a49", @"/Views/Home/ResultsPlanet.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67a2a7524a3e15c6deb36b004187595012c6cbad", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ResultsPlanet : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SWAPI.Models.Planet>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\achia\OneDrive\Desktop\LabsWeekSeven\SWAPI\SWAPI\Views\Home\ResultsPlanet.cshtml"
  
    ViewData["Title"] = "ResultsPlanet";

#line default
#line hidden
            BeginContext(77, 28, true);
            WriteLiteral("\r\n<h1>ResultsPlanet</h1>\r\n\r\n");
            EndContext();
            BeginContext(106, 10, false);
#line 8 "C:\Users\achia\OneDrive\Desktop\LabsWeekSeven\SWAPI\SWAPI\Views\Home\ResultsPlanet.cshtml"
Write(Model.name);

#line default
#line hidden
            EndContext();
            BeginContext(116, 4, true);
            WriteLiteral(" ,\r\n");
            EndContext();
            BeginContext(121, 13, false);
#line 9 "C:\Users\achia\OneDrive\Desktop\LabsWeekSeven\SWAPI\SWAPI\Views\Home\ResultsPlanet.cshtml"
Write(Model.gravity);

#line default
#line hidden
            EndContext();
            BeginContext(134, 9, true);
            WriteLiteral(" N/kg ,\r\n");
            EndContext();
            BeginContext(144, 20, false);
#line 10 "C:\Users\achia\OneDrive\Desktop\LabsWeekSeven\SWAPI\SWAPI\Views\Home\ResultsPlanet.cshtml"
Write(Model.orbital_period);

#line default
#line hidden
            EndContext();
            BeginContext(164, 4, true);
            WriteLiteral(" AU.");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SWAPI.Models.Planet> Html { get; private set; }
    }
}
#pragma warning restore 1591
