#pragma checksum "C:\Users\Micha\Desktop\C#_Stack\Entity_Framework\CRUDelicious\Views\Home\DisplayDish.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8a0126f071dbb0ac5de775da9b794af15c308b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_DisplayDish), @"mvc.1.0.view", @"/Views/Home/DisplayDish.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/DisplayDish.cshtml", typeof(AspNetCore.Views_Home_DisplayDish))]
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
#line 1 "C:\Users\Micha\Desktop\C#_Stack\Entity_Framework\CRUDelicious\Views\_ViewImports.cshtml"
using CRUDelicious;

#line default
#line hidden
#line 2 "C:\Users\Micha\Desktop\C#_Stack\Entity_Framework\CRUDelicious\Views\_ViewImports.cshtml"
using CRUDelicious.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8a0126f071dbb0ac5de775da9b794af15c308b0", @"/Views/Home/DisplayDish.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"815eae4269ab1eac71e8261ccfa9294c33285639", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_DisplayDish : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Micha\Desktop\C#_Stack\Entity_Framework\CRUDelicious\Views\Home\DisplayDish.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 294, true);
            WriteLiteral(@"
<div class=""contain"">
    <div class=""row pt-3"">
        <div class=""col-12"">
            <a href=""/""><button type=""submit"" class=""btn btn-primary""> Home</button></a>
        </div>
    </div>
        <div class=""row text-center"">
            <div class=""col-12"">
                <h3>");
            EndContext();
            BeginContext(340, 10, false);
#line 13 "C:\Users\Micha\Desktop\C#_Stack\Entity_Framework\CRUDelicious\Views\Home\DisplayDish.cshtml"
               Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(350, 144, true);
            WriteLiteral("</h3>\r\n            </div>\r\n        </div>\r\n            <div class=\"row text-center\">\r\n                <div class=\"col-12\">\r\n                <h5>");
            EndContext();
            BeginContext(495, 10, false);
#line 18 "C:\Users\Micha\Desktop\C#_Stack\Entity_Framework\CRUDelicious\Views\Home\DisplayDish.cshtml"
               Write(Model.Chef);

#line default
#line hidden
            EndContext();
            BeginContext(505, 352, true);
            WriteLiteral(@"</h5>
                </div>
            </div>  
        <div class=""row text-center"">
            <div class=""col-12"">
                __________________________________________________________________________
            </div>
        </div>
        <div class=""row pt-5 text-center"">
            <div class=""col-12"">
                <h5>");
            EndContext();
            BeginContext(858, 17, false);
#line 28 "C:\Users\Micha\Desktop\C#_Stack\Entity_Framework\CRUDelicious\Views\Home\DisplayDish.cshtml"
               Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(875, 148, true);
            WriteLiteral("</h5>\r\n            </div>\r\n        </div>\r\n        <div class=\"row pt-5 text-center\">\r\n            <div class=\"col\">\r\n                <h5>Calories: ");
            EndContext();
            BeginContext(1024, 14, false);
#line 33 "C:\Users\Micha\Desktop\C#_Stack\Entity_Framework\CRUDelicious\Views\Home\DisplayDish.cshtml"
                         Write(Model.Calories);

#line default
#line hidden
            EndContext();
            BeginContext(1038, 149, true);
            WriteLiteral("</h5>\r\n            </div>\r\n        </div>\r\n        <div class=\"row pt-5 text-center\">\r\n            <div class=\"col\">\r\n                <h5>Tastiness: ");
            EndContext();
            BeginContext(1188, 15, false);
#line 38 "C:\Users\Micha\Desktop\C#_Stack\Entity_Framework\CRUDelicious\Views\Home\DisplayDish.cshtml"
                          Write(Model.Tastiness);

#line default
#line hidden
            EndContext();
            BeginContext(1203, 138, true);
            WriteLiteral("</h5>\r\n            </div>\r\n        </div>\r\n        <div class=\"row text-center pt-5\">\r\n            <div class=\"col-6\">\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1341, "\"", 1368, 2);
            WriteAttributeValue("", 1348, "delete/", 1348, 7, true);
#line 43 "C:\Users\Micha\Desktop\C#_Stack\Entity_Framework\CRUDelicious\Views\Home\DisplayDish.cshtml"
WriteAttributeValue("", 1355, Model.DishId, 1355, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1369, 138, true);
            WriteLiteral("><button type=\"submit\" class=\"btn btn-danger\">Delete</button></a>\r\n            </div>\r\n            <div class=\"col-6\">\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1507, "\"", 1532, 2);
            WriteAttributeValue("", 1514, "edit/", 1514, 5, true);
#line 46 "C:\Users\Micha\Desktop\C#_Stack\Entity_Framework\CRUDelicious\Views\Home\DisplayDish.cshtml"
WriteAttributeValue("", 1519, Model.DishId, 1519, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1533, 108, true);
            WriteLiteral("><button type=\"submit\" class=\"btn btn-primary\">Edit</button></a>\r\n            </div>\r\n        </div>\r\n</div>");
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
