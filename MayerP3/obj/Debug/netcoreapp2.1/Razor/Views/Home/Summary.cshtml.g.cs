#pragma checksum "C:\Users\rgarn\Source\Repos\MayerP3\MayerP3\Views\Home\Summary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72f84d86461d5d4525183ee199b43c5cfdd52304"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Summary), @"mvc.1.0.view", @"/Views/Home/Summary.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Summary.cshtml", typeof(AspNetCore.Views_Home_Summary))]
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
#line 1 "C:\Users\rgarn\Source\Repos\MayerP3\MayerP3\Views\_ViewImports.cshtml"
using MayerP3;

#line default
#line hidden
#line 2 "C:\Users\rgarn\Source\Repos\MayerP3\MayerP3\Views\_ViewImports.cshtml"
using MayerP3.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72f84d86461d5d4525183ee199b43c5cfdd52304", @"/Views/Home/Summary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c857de53306907ad8d9013f15dbdba9aa36d9d6f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Summary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<InvestmentCalc>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\rgarn\Source\Repos\MayerP3\MayerP3\Views\Home\Summary.cshtml"
  
    ViewData["Title"] = "Summary";

#line default
#line hidden
            BeginContext(66, 24, true);
            WriteLiteral("\r\n<h2>Summary</h2>\r\n\r\n\r\n");
            EndContext();
            BeginContext(91, 39, false);
#line 9 "C:\Users\rgarn\Source\Repos\MayerP3\MayerP3\Views\Home\Summary.cshtml"
Write(Html.DisplayNameFor(m => m.FutureValue));

#line default
#line hidden
            EndContext();
            BeginContext(130, 5, true);
            WriteLiteral("\r\n<p>");
            EndContext();
            BeginContext(136, 31, false);
#line 10 "C:\Users\rgarn\Source\Repos\MayerP3\MayerP3\Views\Home\Summary.cshtml"
Write(Model.FutureValue.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(167, 10, true);
            WriteLiteral("</p>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<InvestmentCalc> Html { get; private set; }
    }
}
#pragma warning restore 1591