#pragma checksum "C:\Users\leeri\Desktop\Coding_Dojo\C#Stack\AspDotNet\WeddingPlanner\Views\Home\OneWedding.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0c727338a899ee140a33fe2b5a778bea645ef58"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_OneWedding), @"mvc.1.0.view", @"/Views/Home/OneWedding.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/OneWedding.cshtml", typeof(AspNetCore.Views_Home_OneWedding))]
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
#line 1 "C:\Users\leeri\Desktop\Coding_Dojo\C#Stack\AspDotNet\WeddingPlanner\Views\_ViewImports.cshtml"
using WeddingPlanner;

#line default
#line hidden
#line 2 "C:\Users\leeri\Desktop\Coding_Dojo\C#Stack\AspDotNet\WeddingPlanner\Views\_ViewImports.cshtml"
using WeddingPlanner.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0c727338a899ee140a33fe2b5a778bea645ef58", @"/Views/Home/OneWedding.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e9e38482b8beecdb199b7be73dfa5c3d6a2f574", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_OneWedding : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ThisWrapper>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(20, 145, true);
            WriteLiteral("<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col\">\r\n            <div class=\"row\">\r\n                <div class=\"col-8\"><h1>");
            EndContext();
            BeginContext(166, 27, false);
#line 6 "C:\Users\leeri\Desktop\Coding_Dojo\C#Stack\AspDotNet\WeddingPlanner\Views\Home\OneWedding.cshtml"
                                  Write(Model.ThisWedding.WedderOne);

#line default
#line hidden
            EndContext();
            BeginContext(193, 5, true);
            WriteLiteral(" and ");
            EndContext();
            BeginContext(199, 27, false);
#line 6 "C:\Users\leeri\Desktop\Coding_Dojo\C#Stack\AspDotNet\WeddingPlanner\Views\Home\OneWedding.cshtml"
                                                                   Write(Model.ThisWedding.WedderTwo);

#line default
#line hidden
            EndContext();
            BeginContext(226, 220, true);
            WriteLiteral(" Wedding</h1></div>\r\n                <div class=\"col\"><a href=\"/dashboard\">Dashboard</a> | <a href=\"logout\">Logout</a></div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col\"><h3>Date: ");
            EndContext();
            BeginContext(447, 41, false);
#line 10 "C:\Users\leeri\Desktop\Coding_Dojo\C#Stack\AspDotNet\WeddingPlanner\Views\Home\OneWedding.cshtml"
                                      Write(Model.ThisWedding.Date.ToLongDateString());

#line default
#line hidden
            EndContext();
            BeginContext(488, 241, true);
            WriteLiteral("</h3></div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col\">Guests:</div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col-1\"></div>\r\n                <div class=\"col\">\r\n");
            EndContext();
#line 18 "C:\Users\leeri\Desktop\Coding_Dojo\C#Stack\AspDotNet\WeddingPlanner\Views\Home\OneWedding.cshtml"
                 foreach (var i in Model.ThisWedding.UsersfromWedding)
                {

#line default
#line hidden
            BeginContext(820, 23, true);
            WriteLiteral("                    <p>");
            EndContext();
            BeginContext(844, 16, false);
#line 20 "C:\Users\leeri\Desktop\Coding_Dojo\C#Stack\AspDotNet\WeddingPlanner\Views\Home\OneWedding.cshtml"
                  Write(i.User.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(860, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(862, 15, false);
#line 20 "C:\Users\leeri\Desktop\Coding_Dojo\C#Stack\AspDotNet\WeddingPlanner\Views\Home\OneWedding.cshtml"
                                    Write(i.User.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(877, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 21 "C:\Users\leeri\Desktop\Coding_Dojo\C#Stack\AspDotNet\WeddingPlanner\Views\Home\OneWedding.cshtml"
                }

#line default
#line hidden
            BeginContext(902, 78, true);
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ThisWrapper> Html { get; private set; }
    }
}
#pragma warning restore 1591
