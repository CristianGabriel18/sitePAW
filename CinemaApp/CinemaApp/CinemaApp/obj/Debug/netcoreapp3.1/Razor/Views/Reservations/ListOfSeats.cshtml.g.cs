#pragma checksum "C:\Users\Cristian-Gabriel\Desktop\PREZENTARE\CinemaApp\CinemaApp\CinemaApp\Views\Reservations\ListOfSeats.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b50922fc35227f68c543b769965e05fbfc4bd92"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reservations_ListOfSeats), @"mvc.1.0.view", @"/Views/Reservations/ListOfSeats.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b50922fc35227f68c543b769965e05fbfc4bd92", @"/Views/Reservations/ListOfSeats.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8084176d599023adc56a4b10a115bd11b8f0b29", @"/Views/_ViewImports.cshtml")]
    public class Views_Reservations_ListOfSeats : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b50922fc35227f68c543b769965e05fbfc4bd923165", async() => {
                WriteLiteral("\r\n\r\n    <script src=\"https://ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js\"></script>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<div class=""theatre"">

    <div class=""cinema-seats left"">
        <div class=""cinema-row row-1"">
            <div class=""seat""></div>
            <div class=""seat""></div>
            <div class=""seat""></div>
            <div class=""seat""></div>
            <div class=""seat""></div>
            <div class=""seat""></div>
            <div class=""seat""></div>
        </div>

        <div class=""cinema-row row-2"">
            <div class=""seat""></div>
            <div class=""seat""></div>
            <div class=""seat""></div>
            <div class=""seat""></div>
            <div class=""seat""></div>
            <div class=""seat""></div>
            <div class=""seat""></div>
        </div>

        <div class=""cinema-row row-3"">
            <div class=""seat""></div>
            <div class=""seat""></div>
            <div class=""seat""></div>
            <div class=""seat""></div>
            <div class=""seat""></div>
            <div class=""seat""></div>
            <div class=""seat""></div>
    ");
            WriteLiteral(@"    </div>

        <div class=""cinema-row row-4"">
            <div class=""seat""></div>
            <div class=""seat""></div>
            <div class=""seat""></div>
            <div class=""seat""></div>
            <div class=""seat""></div>
            <div class=""seat""></div>
            <div class=""seat""></div>
        </div>

        <div class=""cinema-row row-5"">
            <div class=""seat""></div>
            <div class=""seat""></div>
            <div class=""seat""></div>
            <div class=""seat""></div>
            <div class=""seat""></div>
            <div class=""seat""></div>
            <div class=""seat""></div>
        </div>

        <div class=""cinema-row row-6"">
            <div class=""seat""></div>
            <div class=""seat""></div>
            <div class=""seat""></div>
            <div class=""seat""></div>
            <div class=""seat""></div>
            <div class=""seat""></div>
            <div class=""seat""></div>
        </div>

        <div class=""cinema-row row-7"">");
            WriteLiteral(@"
            <div class=""seat""></div>
            <div class=""seat""></div>
            <div class=""seat""></div>
            <div class=""seat""></div>
            <div class=""seat""></div>
            <div class=""seat""></div>
            <div class=""seat""></div>
        </div>
    </div>


    <div class=""cinema-seats right"">
        <div class=""cinema-row row-1"">
            <div class=""seat""></div>
            <div class=""seat""></div>
            <div class=""seat""></div>
            <div class=""seat""></div>
            <div class=""seat""></div>
            <div class=""seat""></div>
            <div class=""seat""></div>
        </div>

        <div class=""cinema-row row-2"">
            <div class=""seat""></div>
            <div class=""seat""></div>
            <div class=""seat""></div>
            <div class=""seat""></div>
            <div class=""seat""></div>
            <div class=""seat""></div>
            <div class=""seat""></div>
        </div>

        <div class=""cinema-row row-3"">");
            WriteLiteral(@"
            <div class=""seat""></div>
            <div class=""seat""></div>
            <div class=""seat""></div>
            <div class=""seat""></div>
            <div class=""seat""></div>
            <div class=""seat""></div>
            <div class=""seat""></div>
        </div>

        <div class=""cinema-row row-4"">
            <div class=""seat""></div>
            <div class=""seat""></div>
            <div class=""seat""></div>
            <div class=""seat""></div>
            <div class=""seat""></div>
            <div class=""seat""></div>
            <div class=""seat""></div>
        </div>

        <div class=""cinema-row row-5"">
            <div class=""seat""></div>
            <div class=""seat""></div>
            <div class=""seat""></div>
            <div class=""seat""></div>
            <div class=""seat""></div>
            <div class=""seat""></div>
            <div class=""seat""></div>
        </div>

        <div class=""cinema-row row-6"">
            <div class=""seat""></div>
            ");
            WriteLiteral(@"<div class=""seat""></div>
            <div class=""seat""></div>
            <div class=""seat""></div>
            <div class=""seat""></div>
            <div class=""seat""></div>
            <div class=""seat""></div>
        </div>

        <div class=""cinema-row row-7"">
            <div class=""seat""></div>
            <div class=""seat""></div>
            <div class=""seat""></div>
            <div class=""seat""></div>
            <div class=""seat""></div>
            <div class=""seat""></div>
            <div class=""seat""></div>
        </div>
    </div>

</div>


<script>
    $(document).ready(function () {
        $('.cinema-seats .seat').on('click', function () {
            debugger;
            $(this).toggleClass('active');
        });
    });

</script>




<style>
    body {
        margin: 60px;
        background: #6c757d;
    }

    .theatre {
        display: flex;
        position: absolute;
        top: 70%;
        left: 50%;
        transform: translate(-50%,");
            WriteLiteral(@" -50%);
    }

    .cinema-seats {
        display: flex;
    }

        .cinema-seats .seat {
            cursor: pointer;
        }

            .cinema-seats .seat:hover:before {
                content: '';
                position: absolute;
                top: 0;
                width: 100%;
                height: 100%;
                background: rgba(0, 0, 0, 0.5);
                border-radius: 7px;
            }

            .cinema-seats .seat.active:before {
                content: '';
                position: absolute;
                top: 0;
                width: 100%;
                height: 100%;
                background: rgba(255, 255, 255, 0.6);
                border-radius: 7px;
            }

    .left .cinema-row {
        transform: skew(-15deg);
        margin: 0 6px;
    }

    .left .seat {
        width: 35px;
        height: 50px;
        border-radius: 7px;
        background: linear-gradient(to top, #761818, #761818, #761818, #761818");
            WriteLiteral(@", #761818, #B54041, #F3686A);
        margin-bottom: 10px;
        transform: skew(20deg);
        margin-top: -32px;
        box-shadow: 0 0 5px rgba(0, 0, 0, 0.5);
    }

    .left .row-2 {
        transform: skew(-13deg);
    }

        .left .row-2 .seat {
            transform: skew(18deg);
        }

    .left .row-3 {
        transform: skew(-12deg);
    }

        .left .row-3 .seat {
            transform: skew(16deg);
        }

    .left .row-4 {
        transform: skew(-11deg);
    }

        .left .row-4 .seat {
            transform: skew(15deg);
        }

    .left .row-5 {
        transform: skew(-10deg);
    }

        .left .row-5 .seat {
            transform: skew(12deg);
        }

    .left .row-6 {
        transform: skew(-9deg);
    }

        .left .row-6 .seat {
            transform: skew(10deg);
        }

    .left .row-7 {
        transform: skew(-7deg);
    }

        .left .row-7 .seat {
            transform: skew(8deg);
  ");
            WriteLiteral(@"      }

    .right {
        margin-left: 70px;
    }

        .right .cinema-row {
            transform: skew(7deg);
            margin: 0 6px;
        }

        .right .seat {
            width: 35px;
            height: 50px;
            border-radius: 7px;
            background: linear-gradient(to top, #761818, #761818, #761818, #761818, #761818, #B54041, #F3686A);
            margin-bottom: 10px;
            transform: skew(-8deg);
            margin-top: -32px;
            box-shadow: 0 0 5px rgba(0, 0, 0, 0.5);
        }

        .right .row-2 {
            transform: skew(9deg);
        }

            .right .row-2 .seat {
                transform: skew(-10deg);
            }

        .right .row-3 {
            transform: skew(10deg);
        }

            .right .row-3 .seat {
                transform: skew(-12deg);
            }

        .right .row-4 {
            transform: skew(11deg);
        }

            .right .row-4 .seat {
                ");
            WriteLiteral(@"transform: skew(-15deg);
            }

        .right .row-5 {
            transform: skew(12deg);
        }

            .right .row-5 .seat {
                transform: skew(-16deg);
            }

        .right .row-6 {
            transform: skew(13deg);
        }

            .right .row-6 .seat {
                transform: skew(-18deg);
            }

        .right .row-7 {
            transform: skew(15deg);
        }

            .right .row-7 .seat {
                transform: skew(-20deg);
            }
</style>");
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
