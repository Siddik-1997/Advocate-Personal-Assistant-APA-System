#pragma checksum "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3200536b3a4bc58f7a82ecc1703b564e0d050b71"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CaseProfiles_Details), @"mvc.1.0.view", @"/Views/CaseProfiles/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CaseProfiles/Details.cshtml", typeof(AspNetCore.Views_CaseProfiles_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3200536b3a4bc58f7a82ecc1703b564e0d050b71", @"/Views/CaseProfiles/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3540a498f392ad9da72a35ae39cf7c01548420ef", @"/Views/_ViewImports.cshtml")]
    public class Views_CaseProfiles_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AdvocatePersonalAssistantSystem.Models.CaseProfile>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(59, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(104, 127, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>CaseProfile</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(232, 43, false);
#line 15 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Case_Id));

#line default
#line hidden
            EndContext();
            BeginContext(275, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(319, 39, false);
#line 18 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Details.cshtml"
       Write(Html.DisplayFor(model => model.Case_Id));

#line default
#line hidden
            EndContext();
            BeginContext(358, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(402, 46, false);
#line 21 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ClientName));

#line default
#line hidden
            EndContext();
            BeginContext(448, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(492, 42, false);
#line 24 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Details.cshtml"
       Write(Html.DisplayFor(model => model.ClientName));

#line default
#line hidden
            EndContext();
            BeginContext(534, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(578, 45, false);
#line 27 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Plaintiff));

#line default
#line hidden
            EndContext();
            BeginContext(623, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(667, 41, false);
#line 30 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Details.cshtml"
       Write(Html.DisplayFor(model => model.Plaintiff));

#line default
#line hidden
            EndContext();
            BeginContext(708, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(752, 45, false);
#line 33 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Defendant));

#line default
#line hidden
            EndContext();
            BeginContext(797, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(841, 41, false);
#line 36 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Details.cshtml"
       Write(Html.DisplayFor(model => model.Defendant));

#line default
#line hidden
            EndContext();
            BeginContext(882, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(926, 41, false);
#line 39 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(967, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1011, 37, false);
#line 42 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Details.cshtml"
       Write(Html.DisplayFor(model => model.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(1048, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1092, 43, false);
#line 45 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(1135, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1179, 39, false);
#line 48 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Details.cshtml"
       Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(1218, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1262, 39, false);
#line 51 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Fee));

#line default
#line hidden
            EndContext();
            BeginContext(1301, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1345, 35, false);
#line 54 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Details.cshtml"
       Write(Html.DisplayFor(model => model.Fee));

#line default
#line hidden
            EndContext();
            BeginContext(1380, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1424, 41, false);
#line 57 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Idate));

#line default
#line hidden
            EndContext();
            BeginContext(1465, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1509, 37, false);
#line 60 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Details.cshtml"
       Write(Html.DisplayFor(model => model.Idate));

#line default
#line hidden
            EndContext();
            BeginContext(1546, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1590, 41, false);
#line 63 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Hdate));

#line default
#line hidden
            EndContext();
            BeginContext(1631, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1675, 37, false);
#line 66 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Details.cshtml"
       Write(Html.DisplayFor(model => model.Hdate));

#line default
#line hidden
            EndContext();
            BeginContext(1712, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1759, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75667216c8304444b28ea3bc3e09efda", async() => {
                BeginContext(1810, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 71 "C:\Users\Dipu\source\repos\AdvocatePersonalAssistant(APA)System\AdvocatePersonalAssistant(APA)System\Views\CaseProfiles\Details.cshtml"
                           WriteLiteral(Model.Case_Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1818, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1826, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9247a1266d14b4fb49c97fa3992e09b", async() => {
                BeginContext(1848, 12, true);
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
            BeginContext(1864, 10, true);
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
