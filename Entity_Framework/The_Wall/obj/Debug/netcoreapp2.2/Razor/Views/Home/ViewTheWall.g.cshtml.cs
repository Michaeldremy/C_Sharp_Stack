#pragma checksum "C:\Users\Micha\Desktop\C#_Stack\Entity_Framework\The_Wall\Views\Home\ViewTheWall.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a35e604e0409f8de6252ca036623084c726b26f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ViewTheWall), @"mvc.1.0.view", @"/Views/Home/ViewTheWall.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ViewTheWall.cshtml", typeof(AspNetCore.Views_Home_ViewTheWall))]
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
#line 1 "C:\Users\Micha\Desktop\C#_Stack\Entity_Framework\The_Wall\Views\_ViewImports.cshtml"
using The_Wall;

#line default
#line hidden
#line 2 "C:\Users\Micha\Desktop\C#_Stack\Entity_Framework\The_Wall\Views\_ViewImports.cshtml"
using The_Wall.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a35e604e0409f8de6252ca036623084c726b26f0", @"/Views/Home/ViewTheWall.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b8e00ec31abe48a6b3f0895238757b3f39cb208", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewTheWall : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WallWrapper>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("cols", new global::Microsoft.AspNetCore.Html.HtmlString("134"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rows", new global::Microsoft.AspNetCore.Html.HtmlString("3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("createmessage"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "createcomment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(20, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Micha\Desktop\C#_Stack\Entity_Framework\The_Wall\Views\Home\ViewTheWall.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(67, 202, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row pt-3\">\r\n        <div class=\"col-7\">\r\n            <h1>The Coding Dojo Wall</h1>\r\n        </div>\r\n        <div class=\"col-3 pt-3\">\r\n            <h4>Welcome, ");
            EndContext();
            BeginContext(270, 20, false);
#line 13 "C:\Users\Micha\Desktop\C#_Stack\Entity_Framework\The_Wall\Views\Home\ViewTheWall.cshtml"
                    Write(Model.User.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(290, 608, true);
            WriteLiteral(@"!</h4>
        </div>
        <div class=""col-2 text-center pt-2"">
            <a href=""/""><button type=""submit"" class=""btn btn-primary"">Log Out</button></a>
        </div>
        <div class=""row"">
            <div class=""col-12"">
                ___________________________________________________________________________________________________________________________________________________________________
            </div>
        </div>
    </div>
    <div class=""row pt-5"">
        <div class=""col-12"">
            <h3 style=""color: blue;"">Post a message</h3>
        </div>
        ");
            EndContext();
            BeginContext(898, 465, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a35e604e0409f8de6252ca036623084c726b26f07079", async() => {
                BeginContext(941, 52, true);
                WriteLiteral("\r\n            <div class=\"col-12\">\r\n                ");
                EndContext();
                BeginContext(993, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a35e604e0409f8de6252ca036623084c726b26f07515", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 30 "C:\Users\Micha\Desktop\C#_Stack\Entity_Framework\The_Wall\Views\Home\ViewTheWall.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Message.Msg);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1039, 72, true);
                WriteLiteral("\r\n            </div>\r\n            <div class=\"col-12\">\r\n                ");
                EndContext();
                BeginContext(1111, 62, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a35e604e0409f8de6252ca036623084c726b26f09284", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
#line 33 "C:\Users\Micha\Desktop\C#_Stack\Entity_Framework\The_Wall\Views\Home\ViewTheWall.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Message.Msg);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1173, 183, true);
                WriteLiteral("\r\n            </div>\r\n            <div class=\"col-11\">\r\n                <button type=\"submit\" class=\"btn btn-primary float-right\">Post a Message</button>\r\n            </div>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
            BeginContext(1363, 72, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"row pt-5\">\r\n        <div class=\"col-12\">\r\n");
            EndContext();
#line 42 "C:\Users\Micha\Desktop\C#_Stack\Entity_Framework\The_Wall\Views\Home\ViewTheWall.cshtml"
             foreach (var u in @Model.AllMessages)
            {
                

#line default
#line hidden
#line 45 "C:\Users\Micha\Desktop\C#_Stack\Entity_Framework\The_Wall\Views\Home\ViewTheWall.cshtml"
                 if (@Model.User.UserId == @u.UserId)
                {

#line default
#line hidden
            BeginContext(1727, 142, true);
            WriteLiteral("                    <div class=\"row\">\r\n                        <div class=\"col-5 pt-2\">\r\n                            <h5 style=\"color: blue;\">");
            EndContext();
            BeginContext(1870, 16, false);
#line 49 "C:\Users\Micha\Desktop\C#_Stack\Entity_Framework\The_Wall\Views\Home\ViewTheWall.cshtml"
                                                Write(u.User.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1886, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1888, 15, false);
#line 49 "C:\Users\Micha\Desktop\C#_Stack\Entity_Framework\The_Wall\Views\Home\ViewTheWall.cshtml"
                                                                  Write(u.User.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(1903, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(1907, 35, false);
#line 49 "C:\Users\Micha\Desktop\C#_Stack\Entity_Framework\The_Wall\Views\Home\ViewTheWall.cshtml"
                                                                                     Write(u.User.CreatedAt.ToLongDateString());

#line default
#line hidden
            EndContext();
            BeginContext(1942, 114, true);
            WriteLiteral("</h5>\r\n                        </div>\r\n                        <div class=\"col-7\">\r\n                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2056, "\"", 2079, 2);
            WriteAttributeValue("", 2063, "delete/", 2063, 7, true);
#line 52 "C:\Users\Micha\Desktop\C#_Stack\Entity_Framework\The_Wall\Views\Home\ViewTheWall.cshtml"
WriteAttributeValue("", 2070, u.UserId, 2070, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2080, 133, true);
            WriteLiteral("><button type=\"submit\" class=\"btn btn-dark\">Delete Message</button></a>\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 55 "C:\Users\Micha\Desktop\C#_Stack\Entity_Framework\The_Wall\Views\Home\ViewTheWall.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(2273, 45, true);
            WriteLiteral("                    <h5 style=\"color: blue;\">");
            EndContext();
            BeginContext(2319, 16, false);
#line 58 "C:\Users\Micha\Desktop\C#_Stack\Entity_Framework\The_Wall\Views\Home\ViewTheWall.cshtml"
                                        Write(u.User.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(2335, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(2337, 15, false);
#line 58 "C:\Users\Micha\Desktop\C#_Stack\Entity_Framework\The_Wall\Views\Home\ViewTheWall.cshtml"
                                                          Write(u.User.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(2352, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(2356, 35, false);
#line 58 "C:\Users\Micha\Desktop\C#_Stack\Entity_Framework\The_Wall\Views\Home\ViewTheWall.cshtml"
                                                                             Write(u.User.CreatedAt.ToLongDateString());

#line default
#line hidden
            EndContext();
            BeginContext(2391, 7, true);
            WriteLiteral("</h5>\r\n");
            EndContext();
#line 59 "C:\Users\Micha\Desktop\C#_Stack\Entity_Framework\The_Wall\Views\Home\ViewTheWall.cshtml"
                }

#line default
#line hidden
#line 61 "C:\Users\Micha\Desktop\C#_Stack\Entity_Framework\The_Wall\Views\Home\ViewTheWall.cshtml"
                 foreach (var m in @u.User.CreatedMessages)
                {

#line default
#line hidden
            BeginContext(2666, 37, true);
            WriteLiteral("                    <h5 class=\"pl-2\">");
            EndContext();
            BeginContext(2704, 5, false);
#line 63 "C:\Users\Micha\Desktop\C#_Stack\Entity_Framework\The_Wall\Views\Home\ViewTheWall.cshtml"
                                Write(m.Msg);

#line default
#line hidden
            EndContext();
            BeginContext(2709, 7, true);
            WriteLiteral("</h5>\r\n");
            EndContext();
#line 64 "C:\Users\Micha\Desktop\C#_Stack\Entity_Framework\The_Wall\Views\Home\ViewTheWall.cshtml"
                 foreach (var c in @m.AllComments)
                {

#line default
#line hidden
            BeginContext(2787, 57, true);
            WriteLiteral("                    <h5 class=\"pl-4\" style=\"color: red;\">");
            EndContext();
            BeginContext(2845, 16, false);
#line 66 "C:\Users\Micha\Desktop\C#_Stack\Entity_Framework\The_Wall\Views\Home\ViewTheWall.cshtml"
                                                    Write(c.User.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(2861, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(2863, 15, false);
#line 66 "C:\Users\Micha\Desktop\C#_Stack\Entity_Framework\The_Wall\Views\Home\ViewTheWall.cshtml"
                                                                      Write(c.User.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(2878, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(2882, 35, false);
#line 66 "C:\Users\Micha\Desktop\C#_Stack\Entity_Framework\The_Wall\Views\Home\ViewTheWall.cshtml"
                                                                                         Write(c.User.CreatedAt.ToLongDateString());

#line default
#line hidden
            EndContext();
            BeginContext(2917, 44, true);
            WriteLiteral("</h5>\r\n                    <h5 class=\"pl-5\">");
            EndContext();
            BeginContext(2962, 5, false);
#line 67 "C:\Users\Micha\Desktop\C#_Stack\Entity_Framework\The_Wall\Views\Home\ViewTheWall.cshtml"
                                Write(c.Cmt);

#line default
#line hidden
            EndContext();
            BeginContext(2967, 7, true);
            WriteLiteral("</h5>\r\n");
            EndContext();
#line 68 "C:\Users\Micha\Desktop\C#_Stack\Entity_Framework\The_Wall\Views\Home\ViewTheWall.cshtml"
                }

#line default
#line hidden
            BeginContext(2993, 219, true);
            WriteLiteral("                    <div class=\"row pt-5\">\r\n                        <div class=\"col-12\">\r\n                            <h3 style=\"color: red;\">Post a Comment</h3>\r\n                        </div>\r\n                        ");
            EndContext();
            BeginContext(3212, 685, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a35e604e0409f8de6252ca036623084c726b26f020201", async() => {
                BeginContext(3316, 84, true);
                WriteLiteral("\r\n                            <div class=\"col-12\">\r\n                                ");
                EndContext();
                BeginContext(3400, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a35e604e0409f8de6252ca036623084c726b26f020672", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 75 "C:\Users\Micha\Desktop\C#_Stack\Entity_Framework\The_Wall\Views\Home\ViewTheWall.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Comment.Cmt);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3446, 120, true);
                WriteLiteral("\r\n                            </div>\r\n                            <div class=\"col-12\">\r\n                                ");
                EndContext();
                BeginContext(3566, 62, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a35e604e0409f8de6252ca036623084c726b26f022491", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
#line 78 "C:\Users\Micha\Desktop\C#_Stack\Entity_Framework\The_Wall\Views\Home\ViewTheWall.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Comment.Cmt);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3628, 262, true);
                WriteLiteral(@"
                            </div>
                            <div class=""col-11"">
                                <button type=""submit"" class=""btn btn-danger float-right"">Post a Comment</button>
                            </div>
                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-messageId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 73 "C:\Users\Micha\Desktop\C#_Stack\Entity_Framework\The_Wall\Views\Home\ViewTheWall.cshtml"
                                                                                                      WriteLiteral(m.MessageId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["messageId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-messageId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["messageId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3897, 30, true);
            WriteLiteral("\r\n                    </div>\r\n");
            EndContext();
#line 85 "C:\Users\Micha\Desktop\C#_Stack\Entity_Framework\The_Wall\Views\Home\ViewTheWall.cshtml"
                }

#line default
#line hidden
#line 85 "C:\Users\Micha\Desktop\C#_Stack\Entity_Framework\The_Wall\Views\Home\ViewTheWall.cshtml"
                 
            }

#line default
#line hidden
            BeginContext(3961, 34, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WallWrapper> Html { get; private set; }
    }
}
#pragma warning restore 1591