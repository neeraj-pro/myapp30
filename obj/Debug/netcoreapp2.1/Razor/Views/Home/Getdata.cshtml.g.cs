#pragma checksum "C:\Users\amngupta\source\repos\WebApplication5\WebApplication5\Views\Home\Getdata.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7293e761a1a435feec65f961aa4982b857ffe9b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Getdata), @"mvc.1.0.view", @"/Views/Home/Getdata.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Getdata.cshtml", typeof(AspNetCore.Views_Home_Getdata))]
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
#line 1 "C:\Users\amngupta\source\repos\WebApplication5\WebApplication5\Views\_ViewImports.cshtml"
using WebApplication5;

#line default
#line hidden
#line 2 "C:\Users\amngupta\source\repos\WebApplication5\WebApplication5\Views\_ViewImports.cshtml"
using WebApplication5.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7293e761a1a435feec65f961aa4982b857ffe9b5", @"/Views/Home/Getdata.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ac7a6a20369a094c1643b76f0e92e19ec3cef6a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Getdata : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\amngupta\source\repos\WebApplication5\WebApplication5\Views\Home\Getdata.cshtml"
  

    var rand_str = (int)ViewBag.Message1;

#line default
#line hidden
            BeginContext(52, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "C:\Users\amngupta\source\repos\WebApplication5\WebApplication5\Views\Home\Getdata.cshtml"
  

    var data = ViewBag.Message2;

#line default
#line hidden
            BeginContext(97, 9, true);
            WriteLiteral("<h3> Hi  ");
            EndContext();
            BeginContext(107, 10, false);
#line 10 "C:\Users\amngupta\source\repos\WebApplication5\WebApplication5\Views\Home\Getdata.cshtml"
    Write(data.fname);

#line default
#line hidden
            EndContext();
            BeginContext(117, 68, true);
            WriteLiteral(" , Your account created successfully and your application ID is  :  ");
            EndContext();
            BeginContext(186, 8, false);
#line 10 "C:\Users\amngupta\source\repos\WebApplication5\WebApplication5\Views\Home\Getdata.cshtml"
                                                                                   Write(rand_str);

#line default
#line hidden
            EndContext();
            BeginContext(194, 111, true);
            WriteLiteral(" \r\n    \r\n    <br /><br />\r\n    NOTE : Please keep application id for further references.\r\n    \r\n    </h3>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
