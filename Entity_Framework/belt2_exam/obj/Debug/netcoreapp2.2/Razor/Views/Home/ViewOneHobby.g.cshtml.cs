#pragma checksum "C:\Users\Micha\Desktop\C#_Stack\Entity_Framework\belt2_exam\Views\Home\ViewOneHobby.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f46615ab76ae368e7d1cead44a59e6997c07c35"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ViewOneHobby), @"mvc.1.0.view", @"/Views/Home/ViewOneHobby.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ViewOneHobby.cshtml", typeof(AspNetCore.Views_Home_ViewOneHobby))]
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
#line 1 "C:\Users\Micha\Desktop\C#_Stack\Entity_Framework\belt2_exam\Views\_ViewImports.cshtml"
using belt2_exam;

#line default
#line hidden
#line 2 "C:\Users\Micha\Desktop\C#_Stack\Entity_Framework\belt2_exam\Views\_ViewImports.cshtml"
using belt2_exam.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f46615ab76ae368e7d1cead44a59e6997c07c35", @"/Views/Home/ViewOneHobby.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"647f4578119dd0fcab12d61f88c2be9e4490f5b8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewOneHobby : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BeltWrapper>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Novice", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Intermediate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Expert", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "HPAssociation", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(20, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Micha\Desktop\C#_Stack\Entity_Framework\belt2_exam\Views\Home\ViewOneHobby.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(67, 101, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row pt-5\">\r\n        <div class=\"col-12\">\r\n            <h1>");
            EndContext();
            BeginContext(169, 16, false);
#line 10 "C:\Users\Micha\Desktop\C#_Stack\Entity_Framework\belt2_exam\Views\Home\ViewOneHobby.cshtml"
           Write(Model.Hobby.Name);

#line default
#line hidden
            EndContext();
            BeginContext(185, 91, true);
            WriteLiteral("</h1>\r\n        </div>\r\n    </div>\r\n    <div class=\"col-12 pt-5\">\r\n        <h4>Description: ");
            EndContext();
            BeginContext(277, 23, false);
#line 14 "C:\Users\Micha\Desktop\C#_Stack\Entity_Framework\belt2_exam\Views\Home\ViewOneHobby.cshtml"
                    Write(Model.Hobby.Description);

#line default
#line hidden
            EndContext();
            BeginContext(300, 104, true);
            WriteLiteral("</h4>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-6 pt-5 text-center\">\r\n            <h5>");
            EndContext();
            BeginContext(405, 16, false);
#line 18 "C:\Users\Micha\Desktop\C#_Stack\Entity_Framework\belt2_exam\Views\Home\ViewOneHobby.cshtml"
           Write(Model.Hobby.Name);

#line default
#line hidden
            EndContext();
            BeginContext(421, 308, true);
            WriteLiteral(@" Enthusiasts:</h5>
            <table class=""table table-bordered"">
                <thead>
                    <tr>
                        <th scope=""col"">Name</th>
                        <th scope=""col"">Proficiency</th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 27 "C:\Users\Micha\Desktop\C#_Stack\Entity_Framework\belt2_exam\Views\Home\ViewOneHobby.cshtml"
                     foreach (var p in @Model.Hobby.AllAssociations)
                    {

#line default
#line hidden
            BeginContext(822, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(877, 16, false);
#line 30 "C:\Users\Micha\Desktop\C#_Stack\Entity_Framework\belt2_exam\Views\Home\ViewOneHobby.cshtml"
                       Write(p.User.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(893, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(895, 15, false);
#line 30 "C:\Users\Micha\Desktop\C#_Stack\Entity_Framework\belt2_exam\Views\Home\ViewOneHobby.cshtml"
                                         Write(p.User.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(910, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 31 "C:\Users\Micha\Desktop\C#_Stack\Entity_Framework\belt2_exam\Views\Home\ViewOneHobby.cshtml"
                         foreach (var h in @Model.Proficiencies)
                        {

#line default
#line hidden
            BeginContext(1010, 28, true);
            WriteLiteral("                        <td>");
            EndContext();
            BeginContext(1039, 18, false);
#line 33 "C:\Users\Micha\Desktop\C#_Stack\Entity_Framework\belt2_exam\Views\Home\ViewOneHobby.cshtml"
                       Write(h.ProficiencyLevel);

#line default
#line hidden
            EndContext();
            BeginContext(1057, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 34 "C:\Users\Micha\Desktop\C#_Stack\Entity_Framework\belt2_exam\Views\Home\ViewOneHobby.cshtml"
                        }

#line default
#line hidden
            BeginContext(1091, 27, true);
            WriteLiteral("                    </tr>\r\n");
            EndContext();
#line 36 "C:\Users\Micha\Desktop\C#_Stack\Entity_Framework\belt2_exam\Views\Home\ViewOneHobby.cshtml"
                    }

#line default
#line hidden
            BeginContext(1141, 153, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n        <div class=\"col-6 text-center pt-5\">\r\n            <h5>Become an Enthusiast</h5>\r\n");
            EndContext();
#line 42 "C:\Users\Micha\Desktop\C#_Stack\Entity_Framework\belt2_exam\Views\Home\ViewOneHobby.cshtml"
             if (Model.User.UserId == @Model.Hobby.UserId)
            {

#line default
#line hidden
            BeginContext(1369, 60, true);
            WriteLiteral("                <p>You are already apart of the group!</p>\r\n");
            EndContext();
#line 45 "C:\Users\Micha\Desktop\C#_Stack\Entity_Framework\belt2_exam\Views\Home\ViewOneHobby.cshtml"
            }
            else
            {
                bool JoinHobby = false;
                

#line default
#line hidden
#line 49 "C:\Users\Micha\Desktop\C#_Stack\Entity_Framework\belt2_exam\Views\Home\ViewOneHobby.cshtml"
                 foreach (var association in @Model.User.CreatedAssociations)
                {
                    if (Model.Hobby.AllAssociations.Contains(association))
                    {
                        JoinHobby = true;

#line default
#line hidden
            BeginContext(1758, 78, true);
            WriteLiteral("                        <p>You are already apart of the group, have fun!</p>\r\n");
            EndContext();
#line 55 "C:\Users\Micha\Desktop\C#_Stack\Entity_Framework\belt2_exam\Views\Home\ViewOneHobby.cshtml"
                    }
                }

#line default
#line hidden
#line 57 "C:\Users\Micha\Desktop\C#_Stack\Entity_Framework\belt2_exam\Views\Home\ViewOneHobby.cshtml"
                 if (!JoinHobby)
                {

#line default
#line hidden
            BeginContext(1931, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(1951, 893, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f46615ab76ae368e7d1cead44a59e6997c07c3511316", async() => {
                BeginContext(2057, 78, true);
                WriteLiteral("\r\n                        <div class=\"col pt-3\">\r\n                            ");
                EndContext();
                BeginContext(2135, 314, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f46615ab76ae368e7d1cead44a59e6997c07c3511782", async() => {
                    BeginContext(2182, 34, true);
                    WriteLiteral("\r\n                                ");
                    EndContext();
                    BeginContext(2216, 38, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f46615ab76ae368e7d1cead44a59e6997c07c3512221", async() => {
                        BeginContext(2239, 6, true);
                        WriteLiteral("Novice");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(2254, 34, true);
                    WriteLiteral("\r\n                                ");
                    EndContext();
                    BeginContext(2288, 50, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f46615ab76ae368e7d1cead44a59e6997c07c3513807", async() => {
                        BeginContext(2317, 12, true);
                        WriteLiteral("Intermediate");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(2338, 34, true);
                    WriteLiteral("\r\n                                ");
                    EndContext();
                    BeginContext(2372, 38, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f46615ab76ae368e7d1cead44a59e6997c07c3515400", async() => {
                        BeginContext(2395, 6, true);
                        WriteLiteral("Expert");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(2410, 30, true);
                    WriteLiteral("\r\n                            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#line 61 "C:\Users\Micha\Desktop\C#_Stack\Entity_Framework\belt2_exam\Views\Home\ViewOneHobby.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Proficiency.ProficiencyLevel);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2449, 34, true);
                WriteLiteral("\r\n                        </div>\r\n");
                EndContext();
                BeginContext(2633, 70, true);
                WriteLiteral("                    <div class=\"col pt-3\">\r\n                        <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2703, "\"", 2736, 2);
                WriteAttributeValue("", 2710, "/join/", 2710, 6, true);
#line 71 "C:\Users\Micha\Desktop\C#_Stack\Entity_Framework\belt2_exam\Views\Home\ViewOneHobby.cshtml"
WriteAttributeValue("", 2716, Model.Hobby.HobbyId, 2716, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2737, 100, true);
                WriteLiteral("><button type=\"submit\">Add to Hobbies</button></a>\r\n                    </div>\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-proficiencyId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 59 "C:\Users\Micha\Desktop\C#_Stack\Entity_Framework\belt2_exam\Views\Home\ViewOneHobby.cshtml"
                                                                                WriteLiteral(Model.Proficiency.ProficiencyId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["proficiencyId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-proficiencyId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["proficiencyId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2844, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 74 "C:\Users\Micha\Desktop\C#_Stack\Entity_Framework\belt2_exam\Views\Home\ViewOneHobby.cshtml"
                }

#line default
#line hidden
#line 74 "C:\Users\Micha\Desktop\C#_Stack\Entity_Framework\belt2_exam\Views\Home\ViewOneHobby.cshtml"
                 
            }

#line default
#line hidden
            BeginContext(2880, 34, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BeltWrapper> Html { get; private set; }
    }
}
#pragma warning restore 1591
