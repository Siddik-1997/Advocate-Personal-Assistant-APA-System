#pragma checksum "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57111ba6d94038c597ea4bebee437720b5afae44"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CaseProfiles_Delete), @"mvc.1.0.view", @"/Views/CaseProfiles/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CaseProfiles/Delete.cshtml", typeof(AspNetCore.Views_CaseProfiles_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57111ba6d94038c597ea4bebee437720b5afae44", @"/Views/CaseProfiles/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3540a498f392ad9da72a35ae39cf7c01548420ef", @"/Views/_ViewImports.cshtml")]
    public class Views_CaseProfiles_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AdvocatePersonalAssistantSystem.Models.CaseProfile>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(59, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(103, 172, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>CaseProfile</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(276, 43, false);
#line 15 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Case_Id));

#line default
#line hidden
            EndContext();
            BeginContext(319, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(363, 39, false);
#line 18 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Case_Id));

#line default
#line hidden
            EndContext();
            BeginContext(402, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(446, 44, false);
#line 21 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CaseName));

#line default
#line hidden
            EndContext();
            BeginContext(490, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(534, 40, false);
#line 24 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CaseName));

#line default
#line hidden
            EndContext();
            BeginContext(574, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(618, 46, false);
#line 27 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ClientName));

#line default
#line hidden
            EndContext();
            BeginContext(664, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(708, 42, false);
#line 30 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ClientName));

#line default
#line hidden
            EndContext();
            BeginContext(750, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(794, 45, false);
#line 33 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Plaintiff));

#line default
#line hidden
            EndContext();
            BeginContext(839, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(883, 41, false);
#line 36 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Plaintiff));

#line default
#line hidden
            EndContext();
            BeginContext(924, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(968, 45, false);
#line 39 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Defendant));

#line default
#line hidden
            EndContext();
            BeginContext(1013, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1057, 41, false);
#line 42 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Defendant));

#line default
#line hidden
            EndContext();
            BeginContext(1098, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1142, 41, false);
#line 45 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(1183, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1227, 37, false);
#line 48 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(1264, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1308, 43, false);
#line 51 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(1351, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1395, 39, false);
#line 54 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(1434, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1478, 39, false);
#line 57 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Fee));

#line default
#line hidden
            EndContext();
            BeginContext(1517, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1561, 35, false);
#line 60 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Fee));

#line default
#line hidden
            EndContext();
            BeginContext(1596, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1640, 41, false);
#line 63 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Idate));

#line default
#line hidden
            EndContext();
            BeginContext(1681, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1725, 37, false);
#line 66 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Idate));

#line default
#line hidden
            EndContext();
            BeginContext(1762, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1806, 41, false);
#line 69 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Hdate));

#line default
#line hidden
            EndContext();
            BeginContext(1847, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1891, 37, false);
#line 72 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Hdate));

#line default
#line hidden
            EndContext();
            BeginContext(1928, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1966, 263, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5899eb815904460e89d23909e2f9eaf0", async() => {
                BeginContext(1992, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2002, 41, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3cf6ca0cb791402480247b4f243843e1", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 77 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Case_Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2043, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2053, 41, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2247457295354ca7965f647ad0b8e6e8", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 78 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Case_Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2094, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(2178, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2529719b261a4d7084fe78ab409ea9a0", async() => {
                    BeginContext(2200, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2216, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2229, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AdvocatePersonalAssistantSystem.Models.CaseProfile> Html { get; private set; }
    }
}
#pragma warning restore 1591
