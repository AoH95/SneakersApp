#pragma checksum "\\Mac\Home\Documents\DOTNET\SneakersApp\SneakersApp\SneakersApp\Views\Shared\_MessagePartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16cd9b768bbfc1791dee9150b910ef860255fd21"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__MessagePartial), @"mvc.1.0.view", @"/Views/Shared/_MessagePartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_MessagePartial.cshtml", typeof(AspNetCore.Views_Shared__MessagePartial))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16cd9b768bbfc1791dee9150b910ef860255fd21", @"/Views/Shared/_MessagePartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80e028f1b317ead31de115899abd80155ad1cc7f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__MessagePartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "\\Mac\Home\Documents\DOTNET\SneakersApp\SneakersApp\SneakersApp\Views\Shared\_MessagePartial.cshtml"
 if (!string.IsNullOrWhiteSpace(TempData["Message"]?.ToString()))
{
    var message = Newtonsoft.Json.JsonConvert.DeserializeObject<SneakersApp.Class.FlashMessage>(TempData["Message"].ToString());



#line default
#line hidden
            BeginContext(199, 8, true);
            WriteLiteral("    <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 207, "\"", 268, 3);
            WriteAttributeValue("", 215, "alert", 215, 5, true);
            WriteAttributeValue(" ", 220, "alert-", 221, 7, true);
#line 6 "\\Mac\Home\Documents\DOTNET\SneakersApp\SneakersApp\SneakersApp\Views\Shared\_MessagePartial.cshtml"
WriteAttributeValue("", 227, message.TypeMessage.ToString().ToLower(), 227, 41, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(269, 10, true);
            WriteLiteral(">\n        ");
            EndContext();
            BeginContext(280, 15, false);
#line 7 "\\Mac\Home\Documents\DOTNET\SneakersApp\SneakersApp\SneakersApp\Views\Shared\_MessagePartial.cshtml"
   Write(message.Message);

#line default
#line hidden
            EndContext();
            BeginContext(295, 12, true);
            WriteLiteral("\n    </div>\n");
            EndContext();
#line 9 "\\Mac\Home\Documents\DOTNET\SneakersApp\SneakersApp\SneakersApp\Views\Shared\_MessagePartial.cshtml"


}

#line default
#line hidden
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