#pragma checksum "\\Mac\Home\Documents\DOTNET\lastClone\SneakersApp\SneakersApp\SneakersApp\Views\Shoe\Usershoe.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36ec1d780aac76f987fc25f7df43258579ee1817"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shoe_Usershoe), @"mvc.1.0.view", @"/Views/Shoe/Usershoe.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shoe/Usershoe.cshtml", typeof(AspNetCore.Views_Shoe_Usershoe))]
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
#line 1 "\\Mac\Home\Documents\DOTNET\lastClone\SneakersApp\SneakersApp\SneakersApp\Views\_ViewImports.cshtml"
using SneakersApp;

#line default
#line hidden
#line 2 "\\Mac\Home\Documents\DOTNET\lastClone\SneakersApp\SneakersApp\SneakersApp\Views\_ViewImports.cshtml"
using SneakersApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36ec1d780aac76f987fc25f7df43258579ee1817", @"/Views/Shoe/Usershoe.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80e028f1b317ead31de115899abd80155ad1cc7f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shoe_Usershoe : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SneakersApp.Models.ShoeIndexModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Shoe", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(42, 81, true);
            WriteLiteral("\r\n    <div class=\"container body-content\">\r\n        <div class=\"shoes-content\">\r\n");
            EndContext();
#line 5 "\\Mac\Home\Documents\DOTNET\lastClone\SneakersApp\SneakersApp\SneakersApp\Views\Shoe\Usershoe.cshtml"
             if(Model.Shoes.Any()){
                

#line default
#line hidden
#line 6 "\\Mac\Home\Documents\DOTNET\lastClone\SneakersApp\SneakersApp\SneakersApp\Views\Shoe\Usershoe.cshtml"
                 foreach(var shoes in Model.Shoes)
                {

#line default
#line hidden
            BeginContext(231, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(247, 233, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36ec1d780aac76f987fc25f7df43258579ee18174798", async() => {
                BeginContext(317, 46, true);
                WriteLiteral("\r\n                    <div class=\"shoes-image\"");
                EndContext();
                BeginWriteAttribute("style", " style=\"", 363, "\"", 403, 3);
                WriteAttributeValue("", 371, "background-image:url(", 371, 21, true);
#line 9 "\\Mac\Home\Documents\DOTNET\lastClone\SneakersApp\SneakersApp\SneakersApp\Views\Shoe\Usershoe.cshtml"
WriteAttributeValue("", 392, shoes.Url, 392, 10, false);

#line default
#line hidden
                WriteAttributeValue("", 402, ")", 402, 1, true);
                EndWriteAttribute();
                BeginContext(404, 35, true);
                WriteLiteral("></div>\r\n                    <span>");
                EndContext();
                BeginContext(440, 11, false);
#line 10 "\\Mac\Home\Documents\DOTNET\lastClone\SneakersApp\SneakersApp\SneakersApp\Views\Shoe\Usershoe.cshtml"
                     Write(shoes.Title);

#line default
#line hidden
                EndContext();
                BeginContext(451, 25, true);
                WriteLiteral("</span>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 8 "\\Mac\Home\Documents\DOTNET\lastClone\SneakersApp\SneakersApp\SneakersApp\Views\Shoe\Usershoe.cshtml"
                                                               WriteLiteral(shoes.Id);

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
            BeginContext(480, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 12 "\\Mac\Home\Documents\DOTNET\lastClone\SneakersApp\SneakersApp\SneakersApp\Views\Shoe\Usershoe.cshtml"
                }

#line default
#line hidden
#line 12 "\\Mac\Home\Documents\DOTNET\lastClone\SneakersApp\SneakersApp\SneakersApp\Views\Shoe\Usershoe.cshtml"
                 
            }else{

#line default
#line hidden
            BeginContext(521, 66, true);
            WriteLiteral("                <p>You have 0 created shoes.</p>\r\n                ");
            EndContext();
            BeginContext(587, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36ec1d780aac76f987fc25f7df43258579ee18178956", async() => {
                BeginContext(632, 24, true);
                WriteLiteral("Create your first shoe !");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(660, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 16 "\\Mac\Home\Documents\DOTNET\lastClone\SneakersApp\SneakersApp\SneakersApp\Views\Shoe\Usershoe.cshtml"
            }

#line default
#line hidden
            BeginContext(677, 28, true);
            WriteLiteral("        </div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SneakersApp.Models.ShoeIndexModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
