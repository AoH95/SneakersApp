#pragma checksum "\\Mac\Home\Documents\DOTNET\SneakersApp\SneakersApp\SneakersApp\Views\Shared\_LayoutForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4a2f69444df36879e0b65d692a56c25ebbf2d35"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LayoutForm), @"mvc.1.0.view", @"/Views/Shared/_LayoutForm.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_LayoutForm.cshtml", typeof(AspNetCore.Views_Shared__LayoutForm))]
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
#line 1 "\\Mac\Home\Documents\DOTNET\SneakersApp\SneakersApp\SneakersApp\Views\_ViewImports.cshtml"
using SneakersApp;

#line default
#line hidden
#line 2 "\\Mac\Home\Documents\DOTNET\SneakersApp\SneakersApp\SneakersApp\Views\_ViewImports.cshtml"
using SneakersApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4a2f69444df36879e0b65d692a56c25ebbf2d35", @"/Views/Shared/_LayoutForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80e028f1b317ead31de115899abd80155ad1cc7f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__LayoutForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery.validate.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery.validate.unobtrusive.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 2 "\\Mac\Home\Documents\DOTNET\SneakersApp\SneakersApp\SneakersApp\Views\Shared\_LayoutForm.cshtml"
  
    Layout = "_Layout";
    ViewData["Title"] = "_LayoutForm";

#line default
#line hidden
            BeginContext(69, 80, true);
            WriteLiteral("\n\n<div class=\"card\">\n    <div class=\"card-body\">\n        <h1 class=\"card-title\">");
            EndContext();
            BeginContext(150, 35, false);
#line 10 "\\Mac\Home\Documents\DOTNET\SneakersApp\SneakersApp\SneakersApp\Views\Shared\_LayoutForm.cshtml"
                          Write(RenderSection("SectionTitle", true));

#line default
#line hidden
            EndContext();
            BeginContext(185, 14, true);
            WriteLiteral("</h1>\n        ");
            EndContext();
            BeginContext(200, 12, false);
#line 11 "\\Mac\Home\Documents\DOTNET\SneakersApp\SneakersApp\SneakersApp\Views\Shared\_LayoutForm.cshtml"
   Write(RenderBody());

#line default
#line hidden
            EndContext();
            BeginContext(212, 20, true);
            WriteLiteral("\n    </div>\n</div>\n\n");
            EndContext();
            DefineSection("SectionScripts", async() => {
                BeginContext(256, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(261, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4a2f69444df36879e0b65d692a56c25ebbf2d355349", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(312, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(317, 63, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4a2f69444df36879e0b65d692a56c25ebbf2d356600", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(380, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(386, 38, false);
#line 18 "\\Mac\Home\Documents\DOTNET\SneakersApp\SneakersApp\SneakersApp\Views\Shared\_LayoutForm.cshtml"
Write(RenderSection("SectionScripts", false));

#line default
#line hidden
                EndContext();
                BeginContext(424, 2, true);
                WriteLiteral("\n\n");
                EndContext();
            }
            );
            BeginContext(428, 1, true);
            WriteLiteral("\n");
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
