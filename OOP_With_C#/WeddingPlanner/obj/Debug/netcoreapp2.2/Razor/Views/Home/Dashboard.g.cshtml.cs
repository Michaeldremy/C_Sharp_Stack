#pragma checksum "C:\Users\leeri\Desktop\Coding_Dojo\C#Stack\AspDotNet\WeddingPlanner\Views\Home\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2cad2c8094fe78380613775cb03074eefc7c6133"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dashboard), @"mvc.1.0.view", @"/Views/Home/Dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Dashboard.cshtml", typeof(AspNetCore.Views_Home_Dashboard))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2cad2c8094fe78380613775cb03074eefc7c6133", @"/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e9e38482b8beecdb199b7be73dfa5c3d6a2f574", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ThisWrapper>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RSVP", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UnRSVP", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(20, 647, true);
            WriteLiteral(@"<div class=""container"">
    <div class=""row"">
        <div class=""col"">
            <div class=""row"">
                <div class=""col-8""><h1>Welcome to the Wedding Planner</h1></div>
                <div class=""col""><h3><a href=""logout"">Logout</a></h3></div>
            </div>
            <div class=""row"">
                <div class=""col"">
                    <table class=""table table-striped"">
                        <tr>
                            <th>Wedding</th>
                            <th>Date</th>
                            <th>Guest</th>
                            <th>Action</th>
                        </tr>
");
            EndContext();
#line 18 "C:\Users\leeri\Desktop\Coding_Dojo\C#Stack\AspDotNet\WeddingPlanner\Views\Home\Dashboard.cshtml"
                         foreach(var l in Model.AllWeddings)
                        {

#line default
#line hidden
            BeginContext(756, 72, true);
            WriteLiteral("                            <tr>\r\n                                <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 828, "\"", 856, 2);
            WriteAttributeValue("", 835, "/wedding/", 835, 9, true);
#line 21 "C:\Users\leeri\Desktop\Coding_Dojo\C#Stack\AspDotNet\WeddingPlanner\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 844, l.WeddingId, 844, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(857, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(859, 11, false);
#line 21 "C:\Users\leeri\Desktop\Coding_Dojo\C#Stack\AspDotNet\WeddingPlanner\Views\Home\Dashboard.cshtml"
                                                               Write(l.WedderOne);

#line default
#line hidden
            EndContext();
            BeginContext(870, 3, true);
            WriteLiteral(" & ");
            EndContext();
            BeginContext(874, 11, false);
#line 21 "C:\Users\leeri\Desktop\Coding_Dojo\C#Stack\AspDotNet\WeddingPlanner\Views\Home\Dashboard.cshtml"
                                                                              Write(l.WedderTwo);

#line default
#line hidden
            EndContext();
            BeginContext(885, 47, true);
            WriteLiteral("</a></td>\r\n                                <td>");
            EndContext();
            BeginContext(933, 6, false);
#line 22 "C:\Users\leeri\Desktop\Coding_Dojo\C#Stack\AspDotNet\WeddingPlanner\Views\Home\Dashboard.cshtml"
                               Write(l.Date);

#line default
#line hidden
            EndContext();
            BeginContext(939, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(983, 26, false);
#line 23 "C:\Users\leeri\Desktop\Coding_Dojo\C#Stack\AspDotNet\WeddingPlanner\Views\Home\Dashboard.cshtml"
                               Write(l.UsersfromWedding.Count());

#line default
#line hidden
            EndContext();
            BeginContext(1009, 45, true);
            WriteLiteral("</td>\r\n                                <td>\r\n");
            EndContext();
#line 25 "C:\Users\leeri\Desktop\Coding_Dojo\C#Stack\AspDotNet\WeddingPlanner\Views\Home\Dashboard.cshtml"
                                     if(@l.Creator == @Model.ThisUser)
                                    {

#line default
#line hidden
            BeginContext(1165, 42, true);
            WriteLiteral("                                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1207, "\"", 1233, 2);
            WriteAttributeValue("", 1214, "delete/", 1214, 7, true);
#line 27 "C:\Users\leeri\Desktop\Coding_Dojo\C#Stack\AspDotNet\WeddingPlanner\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 1221, l.WeddingId, 1221, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1234, 13, true);
            WriteLiteral(">Delete</a>\r\n");
            EndContext();
#line 28 "C:\Users\leeri\Desktop\Coding_Dojo\C#Stack\AspDotNet\WeddingPlanner\Views\Home\Dashboard.cshtml"
                                    }
                                    else
                                    {
                                        

#line default
#line hidden
#line 31 "C:\Users\leeri\Desktop\Coding_Dojo\C#Stack\AspDotNet\WeddingPlanner\Views\Home\Dashboard.cshtml"
                                         if(l.UsersfromWedding.FirstOrDefault(u => u.UserId == Model.ThisUser.UserId) ==null)
                                        {

#line default
#line hidden
            BeginContext(1537, 44, true);
            WriteLiteral("                                            ");
            EndContext();
            BeginContext(1581, 358, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2cad2c8094fe78380613775cb03074eefc7c61339890", async() => {
                BeginContext(1672, 50, true);
                WriteLiteral("\r\n                                                ");
                EndContext();
                BeginContext(1722, 80, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2cad2c8094fe78380613775cb03074eefc7c613310322", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 34 "C:\Users\leeri\Desktop\Coding_Dojo\C#Stack\AspDotNet\WeddingPlanner\Views\Home\Dashboard.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Association.UserId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#line 34 "C:\Users\leeri\Desktop\Coding_Dojo\C#Stack\AspDotNet\WeddingPlanner\Views\Home\Dashboard.cshtml"
                                                                                            WriteLiteral(Model.ThisUser.UserId);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1802, 130, true);
                WriteLiteral("\r\n                                                <input type=\"submit\" value=\"RSVP\">\r\n                                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-wedid", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 33 "C:\Users\leeri\Desktop\Coding_Dojo\C#Stack\AspDotNet\WeddingPlanner\Views\Home\Dashboard.cshtml"
                                                                                               WriteLiteral(l.WeddingId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["wedid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-wedid", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["wedid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1939, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 37 "C:\Users\leeri\Desktop\Coding_Dojo\C#Stack\AspDotNet\WeddingPlanner\Views\Home\Dashboard.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
            BeginContext(2073, 44, true);
            WriteLiteral("                                            ");
            EndContext();
            BeginContext(2117, 363, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2cad2c8094fe78380613775cb03074eefc7c613316154", async() => {
                BeginContext(2210, 50, true);
                WriteLiteral("\r\n                                                ");
                EndContext();
                BeginContext(2260, 80, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2cad2c8094fe78380613775cb03074eefc7c613316587", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 41 "C:\Users\leeri\Desktop\Coding_Dojo\C#Stack\AspDotNet\WeddingPlanner\Views\Home\Dashboard.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Association.UserId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#line 41 "C:\Users\leeri\Desktop\Coding_Dojo\C#Stack\AspDotNet\WeddingPlanner\Views\Home\Dashboard.cshtml"
                                                                                            WriteLiteral(Model.ThisUser.UserId);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2340, 133, true);
                WriteLiteral("\r\n                                                <input type=\"submit\" value=\"UN-RSVP\">\r\n                                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-wedid", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 40 "C:\Users\leeri\Desktop\Coding_Dojo\C#Stack\AspDotNet\WeddingPlanner\Views\Home\Dashboard.cshtml"
                                                                                                 WriteLiteral(l.WeddingId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["wedid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-wedid", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["wedid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2480, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 44 "C:\Users\leeri\Desktop\Coding_Dojo\C#Stack\AspDotNet\WeddingPlanner\Views\Home\Dashboard.cshtml"
                                        }

#line default
#line hidden
#line 44 "C:\Users\leeri\Desktop\Coding_Dojo\C#Stack\AspDotNet\WeddingPlanner\Views\Home\Dashboard.cshtml"
                                         
                                    }

#line default
#line hidden
            BeginContext(2564, 114, true);
            WriteLiteral("                                    \r\n\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 50 "C:\Users\leeri\Desktop\Coding_Dojo\C#Stack\AspDotNet\WeddingPlanner\Views\Home\Dashboard.cshtml"
                        }

#line default
#line hidden
            BeginContext(2705, 274, true);
            WriteLiteral(@"                    </table>
                </div>
            </div>
            <div class=""row"">
                <div class=""col"">
                    <a href=""/wedding"">New Wedding</a>
                </div>
            </div>
        </div>
    </div>
</div>");
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
