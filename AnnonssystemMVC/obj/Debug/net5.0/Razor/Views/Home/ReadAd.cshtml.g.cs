#pragma checksum "C:\Users\amand\source\repos\SamverkandeAPI\AnnonssystemMVC\Views\Home\ReadAd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "574f1ff998a34b846cbf5ac2cc1117cd4c3f795a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ReadAd), @"mvc.1.0.view", @"/Views/Home/ReadAd.cshtml")]
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
#nullable restore
#line 1 "C:\Users\amand\source\repos\SamverkandeAPI\AnnonssystemMVC\Views\_ViewImports.cshtml"
using AnnonssystemMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\amand\source\repos\SamverkandeAPI\AnnonssystemMVC\Views\_ViewImports.cshtml"
using AnnonssystemMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"574f1ff998a34b846cbf5ac2cc1117cd4c3f795a", @"/Views/Home/ReadAd.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ee71e19257f99442fe5b8c4104937b4d87b66f9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ReadAd : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AnnonssystemMVC.Models.Ads>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ReadAllaAds", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\amand\source\repos\SamverkandeAPI\AnnonssystemMVC\Views\Home\ReadAd.cshtml"
  
    ViewData["Title"] = "Visa Annons";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Annons: ");
#nullable restore
#line 7 "C:\Users\amand\source\repos\SamverkandeAPI\AnnonssystemMVC\Views\Home\ReadAd.cshtml"
       Write(Html.DisplayFor(model => model.Ad_Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            Id\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 16 "C:\Users\amand\source\repos\SamverkandeAPI\AnnonssystemMVC\Views\Home\ReadAd.cshtml"
       Write(Html.DisplayFor(model => model.Ad_Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Annonsör\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 22 "C:\Users\amand\source\repos\SamverkandeAPI\AnnonssystemMVC\Views\Home\ReadAd.cshtml"
       Write(Html.DisplayFor(model => model.Ad_Annonsor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Rubrik\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 28 "C:\Users\amand\source\repos\SamverkandeAPI\AnnonssystemMVC\Views\Home\ReadAd.cshtml"
       Write(Html.DisplayFor(model => model.Ad_Rubrik));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Innehåll\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 34 "C:\Users\amand\source\repos\SamverkandeAPI\AnnonssystemMVC\Views\Home\ReadAd.cshtml"
       Write(Html.DisplayFor(model => model.Ad_Innehall));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Varans Pris\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 40 "C:\Users\amand\source\repos\SamverkandeAPI\AnnonssystemMVC\Views\Home\ReadAd.cshtml"
       Write(Html.DisplayFor(model => model.Ad_VaransPris));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Annonspris\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 46 "C:\Users\amand\source\repos\SamverkandeAPI\AnnonssystemMVC\Views\Home\ReadAd.cshtml"
       Write(Html.DisplayFor(model => model.Ad_AnnonsPris));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "574f1ff998a34b846cbf5ac2cc1117cd4c3f795a6549", async() => {
                WriteLiteral("Tillbaka");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AnnonssystemMVC.Models.Ads> Html { get; private set; }
    }
}
#pragma warning restore 1591
