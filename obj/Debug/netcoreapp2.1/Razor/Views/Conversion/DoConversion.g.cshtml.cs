#pragma checksum "C:\CIDM3312\Assignment\Assignment7\Views\Conversion\DoConversion.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13c642a80f17d0990ff48c0b54875d2d0a24631d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Conversion_DoConversion), @"mvc.1.0.view", @"/Views/Conversion/DoConversion.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Conversion/DoConversion.cshtml", typeof(AspNetCore.Views_Conversion_DoConversion))]
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
#line 1 "C:\CIDM3312\Assignment\Assignment7\Views\_ViewImports.cshtml"
using Assignment7;

#line default
#line hidden
#line 2 "C:\CIDM3312\Assignment\Assignment7\Views\_ViewImports.cshtml"
using Assignment7.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13c642a80f17d0990ff48c0b54875d2d0a24631d", @"/Views/Conversion/DoConversion.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20166ba8124ef534adc515f8de4b4d236a903b29", @"/Views/_ViewImports.cshtml")]
    public class Views_Conversion_DoConversion : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ConverterViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(27, 28, true);
            WriteLiteral("\r\n<h1>Result</h1>\r\n<p>\r\n    ");
            EndContext();
            BeginContext(56, 20, false);
#line 5 "C:\CIDM3312\Assignment\Assignment7\Views\Conversion\DoConversion.cshtml"
Write(Model.ValueToConvert);

#line default
#line hidden
            EndContext();
            BeginContext(76, 12, true);
            WriteLiteral(" <br/>\r\n    ");
            EndContext();
            BeginContext(89, 20, false);
#line 6 "C:\CIDM3312\Assignment\Assignment7\Views\Conversion\DoConversion.cshtml"
Write(Model.ConversionType);

#line default
#line hidden
            EndContext();
            BeginContext(109, 12, true);
            WriteLiteral(" <br/>\r\n    ");
            EndContext();
            BeginContext(122, 20, false);
#line 7 "C:\CIDM3312\Assignment\Assignment7\Views\Conversion\DoConversion.cshtml"
Write(Model.ConvertedValue);

#line default
#line hidden
            EndContext();
            BeginContext(142, 12, true);
            WriteLiteral(" <br/>\r\n</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ConverterViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
