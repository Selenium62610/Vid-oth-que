#pragma checksum "C:\Users\Edouard\Documents\M2_Progr_Avance\.Net\Vidéothèque\Vid-oth-que\VidéoThèque\Pages\Movies\DetailsForClient.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c261d421c216944119202df8fd86e92f0b4beff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(VidéoThèque.Pages.Movies.Pages_Movies_DetailsForClient), @"mvc.1.0.razor-page", @"/Pages/Movies/DetailsForClient.cshtml")]
namespace VidéoThèque.Pages.Movies
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
#line 1 "C:\Users\Edouard\Documents\M2_Progr_Avance\.Net\Vidéothèque\Vid-oth-que\VidéoThèque\Pages\_ViewImports.cshtml"
using VidéoThèque;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c261d421c216944119202df8fd86e92f0b4beff", @"/Pages/Movies/DetailsForClient.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8556d82e979ebc4a42cd373cc1ad643f877199c2", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Movies_DetailsForClient : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "../MovieDisplay", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Commande", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\Edouard\Documents\M2_Progr_Avance\.Net\Vidéothèque\Vid-oth-que\VidéoThèque\Pages\Movies\DetailsForClient.cshtml"
  
    ViewData["Title"] = "Détails du film";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Détails</h1>\r\n\r\n<div>\r\n    <h4>Du film</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 16 "C:\Users\Edouard\Documents\M2_Progr_Avance\.Net\Vidéothèque\Vid-oth-que\VidéoThèque\Pages\Movies\DetailsForClient.cshtml"
       Write(Html.DisplayNameFor(model => model.Movie.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 394, "\"", 447, 1);
#nullable restore
#line 19 "C:\Users\Edouard\Documents\M2_Progr_Avance\.Net\Vidéothèque\Vid-oth-que\VidéoThèque\Pages\Movies\DetailsForClient.cshtml"
WriteAttributeValue("", 400, Url.Content("~/img/"+Model.Movie.Image+".PNG"), 400, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"250px\" width=\"200px\"\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 22 "C:\Users\Edouard\Documents\M2_Progr_Avance\.Net\Vidéothèque\Vid-oth-que\VidéoThèque\Pages\Movies\DetailsForClient.cshtml"
       Write(Html.DisplayNameFor(model => model.Movie.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 25 "C:\Users\Edouard\Documents\M2_Progr_Avance\.Net\Vidéothèque\Vid-oth-que\VidéoThèque\Pages\Movies\DetailsForClient.cshtml"
       Write(Html.DisplayFor(model => model.Movie.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 28 "C:\Users\Edouard\Documents\M2_Progr_Avance\.Net\Vidéothèque\Vid-oth-que\VidéoThèque\Pages\Movies\DetailsForClient.cshtml"
       Write(Html.DisplayNameFor(model => model.Movie.ReleaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 31 "C:\Users\Edouard\Documents\M2_Progr_Avance\.Net\Vidéothèque\Vid-oth-que\VidéoThèque\Pages\Movies\DetailsForClient.cshtml"
       Write(Html.DisplayFor(model => model.Movie.ReleaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 34 "C:\Users\Edouard\Documents\M2_Progr_Avance\.Net\Vidéothèque\Vid-oth-que\VidéoThèque\Pages\Movies\DetailsForClient.cshtml"
       Write(Html.DisplayNameFor(model => model.Movie.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 37 "C:\Users\Edouard\Documents\M2_Progr_Avance\.Net\Vidéothèque\Vid-oth-que\VidéoThèque\Pages\Movies\DetailsForClient.cshtml"
       Write(Html.DisplayFor(model => model.Movie.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 40 "C:\Users\Edouard\Documents\M2_Progr_Avance\.Net\Vidéothèque\Vid-oth-que\VidéoThèque\Pages\Movies\DetailsForClient.cshtml"
       Write(Html.DisplayNameFor(model => model.Movie.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 43 "C:\Users\Edouard\Documents\M2_Progr_Avance\.Net\Vidéothèque\Vid-oth-que\VidéoThèque\Pages\Movies\DetailsForClient.cshtml"
       Write(Html.DisplayFor(model => model.Movie.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 46 "C:\Users\Edouard\Documents\M2_Progr_Avance\.Net\Vidéothèque\Vid-oth-que\VidéoThèque\Pages\Movies\DetailsForClient.cshtml"
       Write(Html.DisplayNameFor(model => model.Movie.Realisateur));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 49 "C:\Users\Edouard\Documents\M2_Progr_Avance\.Net\Vidéothèque\Vid-oth-que\VidéoThèque\Pages\Movies\DetailsForClient.cshtml"
       Write(Html.DisplayFor(model => model.Movie.Realisateur));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 52 "C:\Users\Edouard\Documents\M2_Progr_Avance\.Net\Vidéothèque\Vid-oth-que\VidéoThèque\Pages\Movies\DetailsForClient.cshtml"
       Write(Html.DisplayNameFor(model => model.Movie.Acteurs));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 55 "C:\Users\Edouard\Documents\M2_Progr_Avance\.Net\Vidéothèque\Vid-oth-que\VidéoThèque\Pages\Movies\DetailsForClient.cshtml"
       Write(Html.DisplayFor(model => model.Movie.Acteurs));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 58 "C:\Users\Edouard\Documents\M2_Progr_Avance\.Net\Vidéothèque\Vid-oth-que\VidéoThèque\Pages\Movies\DetailsForClient.cshtml"
       Write(Html.DisplayNameFor(model => model.Movie.Synopsis));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 61 "C:\Users\Edouard\Documents\M2_Progr_Avance\.Net\Vidéothèque\Vid-oth-que\VidéoThèque\Pages\Movies\DetailsForClient.cshtml"
       Write(Html.DisplayFor(model => model.Movie.Synopsis));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c261d421c216944119202df8fd86e92f0b4beff10132", async() => {
                WriteLiteral("Retourner au choix des films");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 67 "C:\Users\Edouard\Documents\M2_Progr_Avance\.Net\Vidéothèque\Vid-oth-que\VidéoThèque\Pages\Movies\DetailsForClient.cshtml"
                                    WriteLiteral(Model.Movie.ID);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c261d421c216944119202df8fd86e92f0b4beff12351", async() => {
                WriteLiteral(" Louer ce film ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 68 "C:\Users\Edouard\Documents\M2_Progr_Avance\.Net\Vidéothèque\Vid-oth-que\VidéoThèque\Pages\Movies\DetailsForClient.cshtml"
                               WriteLiteral(Model.Movie.ID);

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VidéoThèque.Pages.Movies.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<VidéoThèque.Pages.Movies.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<VidéoThèque.Pages.Movies.DetailsModel>)PageContext?.ViewData;
        public VidéoThèque.Pages.Movies.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
