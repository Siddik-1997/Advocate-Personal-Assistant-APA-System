#pragma checksum "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CyberLaws\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "454040faee28277d33415a84062830c9fca7eee4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CyberLaws_Index), @"mvc.1.0.view", @"/Views/CyberLaws/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CyberLaws/Index.cshtml", typeof(AspNetCore.Views_CyberLaws_Index))]
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
#line 1 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\_ViewImports.cshtml"
using AdvocatePersonalAssistant_APA_System;

#line default
#line hidden
#line 2 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\_ViewImports.cshtml"
using AdvocatePersonalAssistant_APA_System.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"454040faee28277d33415a84062830c9fca7eee4", @"/Views/CyberLaws/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3540a498f392ad9da72a35ae39cf7c01548420ef", @"/Views/_ViewImports.cshtml")]
    public class Views_CyberLaws_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AdvocatePersonalAssistantSystem.Models.CyberLaw>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(69, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CyberLaws\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(112, 621, true);
            WriteLiteral(@"
<style>
    body{

        font-family:'raleway';
    }
    table{
        width:100%;
        border-collapse:collapse;
        font-size:18px;
        color:#04311d;
        text-align:justify;
        padding:20px;
        font-family:raleway;
    }
    th{
        background-color:#76D7C4;
        color:#fff;
        padding:10px;
        border:1px solid #d8dada;
    }
    td{
        background-color:#d1f5e8;
        padding:10px;
        border:1px solid #d8dada;



    }

</style>
    <div style=""font-family:Arial"">

        <h2>Cyber Laws</h2>

        <p>
            ");
            EndContext();
            BeginContext(733, 27, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74aeb45b6fc6434bbd32dd2d257140ad", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(760, 29, true);
            WriteLiteral("\r\n        </p>\r\n        <p>\r\n");
            EndContext();
#line 45 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CyberLaws\Index.cshtml"
             using (Html.BeginForm("Index", "CyberLaws", FormMethod.Get))
            {

#line default
#line hidden
            BeginContext(879, 34, true);
            WriteLiteral("                <b>Search By:</b> ");
            EndContext();
            BeginContext(914, 44, false);
#line 47 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CyberLaws\Index.cshtml"
                             Write(Html.RadioButton("searchBy", "Law_no", true));

#line default
#line hidden
            EndContext();
            BeginContext(964, 8, true);
            WriteLiteral("Law No  ");
            EndContext();
            BeginContext(998, 39, false);
#line 48 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CyberLaws\Index.cshtml"
           Write(Html.RadioButton("searchBy", "LawName"));

#line default
#line hidden
            EndContext();
            BeginContext(1043, 8, true);
            WriteLiteral("Law Name");
            EndContext();
            BeginContext(1058, 6, true);
            WriteLiteral("<br>\r\n");
            EndContext();
            BeginContext(1081, 22, false);
#line 49 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CyberLaws\Index.cshtml"
           Write(Html.TextBox("search"));

#line default
#line hidden
            EndContext();
            BeginContext(1103, 41, true);
            WriteLiteral("<input type=\"submit\" value=\" Search\" />\r\n");
            EndContext();
#line 50 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CyberLaws\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1159, 159, true);
            WriteLiteral("        </p>\r\n        \r\n        <table border=\"1\" class=\"table\">\r\n            <thead>\r\n                <tr>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1319, 42, false);
#line 57 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CyberLaws\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Law_no));

#line default
#line hidden
            EndContext();
            BeginContext(1361, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1441, 43, false);
#line 60 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CyberLaws\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.LawName));

#line default
#line hidden
            EndContext();
            BeginContext(1484, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1564, 46, false);
#line 63 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CyberLaws\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Punishment));

#line default
#line hidden
            EndContext();
            BeginContext(1610, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1690, 43, false);
#line 66 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CyberLaws\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.LDeails));

#line default
#line hidden
            EndContext();
            BeginContext(1733, 97, true);
            WriteLiteral("\r\n                    </th>\r\n\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 72 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CyberLaws\Index.cshtml"
                 if (Model.Count() == 0)
                {

#line default
#line hidden
            BeginContext(1891, 128, true);
            WriteLiteral("                    <tr>\r\n                        <td colspan=\"4\">No row match search criteria</td>\r\n                    </tr>\r\n");
            EndContext();
#line 77 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CyberLaws\Index.cshtml"
                }
                else
                {
                    foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(2151, 96, true);
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2248, 41, false);
#line 84 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CyberLaws\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Law_no));

#line default
#line hidden
            EndContext();
            BeginContext(2289, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2393, 42, false);
#line 87 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CyberLaws\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.LawName));

#line default
#line hidden
            EndContext();
            BeginContext(2435, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2539, 45, false);
#line 90 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CyberLaws\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Punishment));

#line default
#line hidden
            EndContext();
            BeginContext(2584, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2688, 42, false);
#line 93 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CyberLaws\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.LDeails));

#line default
#line hidden
            EndContext();
            BeginContext(2730, 100, true);
            WriteLiteral("\r\n                            </td>\r\n                            \r\n\r\n                        </tr>\r\n");
            EndContext();
#line 98 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CyberLaws\Index.cshtml"
                    }
                }

#line default
#line hidden
            BeginContext(2872, 52, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AdvocatePersonalAssistantSystem.Models.CyberLaw>> Html { get; private set; }
    }
}
#pragma warning restore 1591
