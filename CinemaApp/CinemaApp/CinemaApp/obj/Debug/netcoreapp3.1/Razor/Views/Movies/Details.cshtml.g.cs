#pragma checksum "C:\Users\Cristian-Gabriel\Desktop\PREZENTARE\CinemaApp\CinemaApp\CinemaApp\Views\Movies\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1475a21b3e80cc85a22e969a0eac8b23f681341"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Details), @"mvc.1.0.view", @"/Views/Movies/Details.cshtml")]
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
#line 1 "C:\Users\Cristian-Gabriel\Desktop\PREZENTARE\CinemaApp\CinemaApp\CinemaApp\Views\_ViewImports.cshtml"
using CinemaApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Cristian-Gabriel\Desktop\PREZENTARE\CinemaApp\CinemaApp\CinemaApp\Views\_ViewImports.cshtml"
using CinemaApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1475a21b3e80cc85a22e969a0eac8b23f681341", @"/Views/Movies/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8084176d599023adc56a4b10a115bd11b8f0b29", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CinemaApp.ViewModels.MovieGenreViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("max-height: 150px;min-height: 150px; max-width:190px; min-width:50px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("movie image-cap"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\Cristian-Gabriel\Desktop\PREZENTARE\CinemaApp\CinemaApp\CinemaApp\Views\Movies\Details.cshtml"
 foreach (var movie in Model)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            WriteLiteral(" ");
#nullable restore
#line 7 "C:\Users\Cristian-Gabriel\Desktop\PREZENTARE\CinemaApp\CinemaApp\CinemaApp\Views\Movies\Details.cshtml"
         
        var photoPath = "~/Photo/" + (movie.Movie.PhotoPath ?? "noimage.jpg");
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <h2>");
            WriteLiteral("Movie </h2>\r\n    <p>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1475a21b3e80cc85a22e969a0eac8b23f6813415410", async() => {
                WriteLiteral("Inapoi la filme");
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
            WriteLiteral("\r\n    </p>\r\n    <div class=\"block\">\r\n        <div class=\"left movie-content-left\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b1475a21b3e80cc85a22e969a0eac8b23f6813416678", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 16 "C:\Users\Cristian-Gabriel\Desktop\PREZENTARE\CinemaApp\CinemaApp\CinemaApp\Views\Movies\Details.cshtml"
                               WriteLiteral(photoPath);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 16 "C:\Users\Cristian-Gabriel\Desktop\PREZENTARE\CinemaApp\CinemaApp\CinemaApp\Views\Movies\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n            <div class=\"movie-name info\">\r\n                <h4>\r\n                    ");
#nullable restore
#line 20 "C:\Users\Cristian-Gabriel\Desktop\PREZENTARE\CinemaApp\CinemaApp\CinemaApp\Views\Movies\Details.cshtml"
               Write(movie.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </h4>\r\n                <span>\r\n                    ");
#nullable restore
#line 23 "C:\Users\Cristian-Gabriel\Desktop\PREZENTARE\CinemaApp\CinemaApp\CinemaApp\Views\Movies\Details.cshtml"
               Write(movie.DateAdded);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </span>\r\n\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"right movie-content-right\">\r\n            <div class=\"movie-landing-content\">\r\n                <h1 class=\"ml-2\">");
#nullable restore
#line 31 "C:\Users\Cristian-Gabriel\Desktop\PREZENTARE\CinemaApp\CinemaApp\CinemaApp\Views\Movies\Details.cshtml"
                            Write(movie.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                <p class=\"ml-2\">");
#nullable restore
#line 32 "C:\Users\Cristian-Gabriel\Desktop\PREZENTARE\CinemaApp\CinemaApp\CinemaApp\Views\Movies\Details.cshtml"
                           Write(movie.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <div class=\"summary\">\r\n                    <div class=\"leftSide\">\r\n                        Gen\r\n                    </div><div class=\"rightSide\">\r\n                        ");
#nullable restore
#line 37 "C:\Users\Cristian-Gabriel\Desktop\PREZENTARE\CinemaApp\CinemaApp\CinemaApp\Views\Movies\Details.cshtml"
                   Write(movie.GenreName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div><div class=\"clear\">\r\n\r\n                    </div><div class=\"leftSide\">\r\n                        Data publicarii\r\n                    </div><div class=\"rightSide\">\r\n                        ");
#nullable restore
#line 43 "C:\Users\Cristian-Gabriel\Desktop\PREZENTARE\CinemaApp\CinemaApp\CinemaApp\Views\Movies\Details.cshtml"
                   Write(movie.ReleaseDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div><div class=""clear"">
                    </div>


                </div>
            </div>

            <div class=""video"" id=""trailer"">
                <script>
                    setTimeout(function () {
                        searchMovie('");
#nullable restore
#line 54 "C:\Users\Cristian-Gabriel\Desktop\PREZENTARE\CinemaApp\CinemaApp\CinemaApp\Views\Movies\Details.cshtml"
                                Write(movie.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\')\r\n                        debugger;\r\n                    }, 500);\r\n                </script>\r\n\r\n\r\n            </div>\r\n        </div>\r\n        <div class=\"clear\"></div>\r\n    </div>\r\n");
#nullable restore
#line 64 "C:\Users\Cristian-Gabriel\Desktop\PREZENTARE\CinemaApp\CinemaApp\CinemaApp\Views\Movies\Details.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CinemaApp.ViewModels.MovieGenreViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
