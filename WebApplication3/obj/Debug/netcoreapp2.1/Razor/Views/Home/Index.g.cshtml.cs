#pragma checksum "D:\MY WORK\PRIGEEGE!!!!!\VSZANALYTICS\WebApplication3\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2d7acea487b1f1b08205bbd8ca013a501a9a373"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "D:\MY WORK\PRIGEEGE!!!!!\VSZANALYTICS\WebApplication3\Views\_ViewImports.cshtml"
using WebApplication3;

#line default
#line hidden
#line 2 "D:\MY WORK\PRIGEEGE!!!!!\VSZANALYTICS\WebApplication3\Views\_ViewImports.cshtml"
using WebApplication3.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2d7acea487b1f1b08205bbd8ca013a501a9a373", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"463d1c12e8fc14b2589daa67feec3183fea97611", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplication3.Models.UserFile>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddFile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(25, 1829, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e544b692de374f199672e4d1d8b342d2", async() => {
                BeginContext(31, 60, true);
                WriteLiteral("\r\n    <title>Main Page</title>\r\n    <meta charset=\"utf-8\">\r\n");
                EndContext();
                BeginContext(312, 1535, true);
                WriteLiteral(@"    <style>
        .container {
            width: 100%;
            max-width: 1024px;
            padding: 15px;
            margin: 0 auto;
        }

            .container:after, .row:after {
                content: """";
                display: table;
                clear: both;
            }

        .logo {
            float: left;
        }

        .row {
            margin-bottom: 15px;
            margin-top:15px;
        }

        .col-1-2 {
            width: 50%;
            float: left;
            border: 1px solid black;
        }

        .col-3-4 {
            width: 75%;
            float: left;
            border: 1px solid black;

        }

        .col-1-4 {
            width: 25%;
            float: left;
            border: 1px solid black
        }

        .col-2-5 {
            width: 40%;
            float: left;
            border: 1px solid black
        }

        .col-3-5 {
            width: 60%;
            float: left;");
                WriteLiteral(@"
            border: 1px solid black
        }

            .col-3-5 img {
                width: 100%;
                height: 100%;
            }

        .btn {
            border: 1px solid grey;
            background-color: whitesmoke;
            float: right;
            margin-right: 45%;
        }

        .slct {
            border: 1px solid greenyellow;
            background-color: whitesmoke;
            float: left;
            width: 20vw;   
        }
    </style>

");
                EndContext();
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
            EndContext();
            BeginContext(1854, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1856, 2253, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6e1538589064adeac5f2b3dd17ce036", async() => {
                BeginContext(1862, 252, true);
                WriteLiteral("\r\n    <div class=\"main\">\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n                <div class=\"col-3-4\">\r\n                    <p>Выберите Фильтр, по которому хотите провести анализ</p>\r\n                    <select class=\"slct\">\r\n");
                EndContext();
#line 89 "D:\MY WORK\PRIGEEGE!!!!!\VSZANALYTICS\WebApplication3\Views\Home\Index.cshtml"
                         for (int i = 0; i < 5; i++)
                        {

#line default
#line hidden
                BeginContext(2195, 28, true);
                WriteLiteral("                            ");
                EndContext();
                BeginContext(2223, 19, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28ef1db4312d47f4a5d6f9144153073e", async() => {
                    BeginContext(2232, 1, false);
#line 91 "D:\MY WORK\PRIGEEGE!!!!!\VSZANALYTICS\WebApplication3\Views\Home\Index.cshtml"
                               Write(i);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2242, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 92 "D:\MY WORK\PRIGEEGE!!!!!\VSZANALYTICS\WebApplication3\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
                BeginContext(2271, 991, true);
                WriteLiteral(@"                    </select>
                </div>
                <div class=""col-1-4"">
                    <a href=""/Home/ProfilePage/""><img src=""https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQOiBuMr3d1NpGEMNR0dLnaao8P78-7paC61qSxcBfGKGgRNOSE"" alt=""profPic"" /></a>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-3-5"">
                    <img src=""https://news-hunter.pro/wp-content/uploads/2017/08/binarnye-optsiony-po-trendu.jpg"" alt=""аналит График"" />
                </div>
                <div class=""col-2-5"">
                    <img src=""http://berg.com.ua/wp-content/forex-currency-trading-pairs.png"" alt=""Валютные пары"" />
                </div>
            </div>
            <div class=""row"">
                <div class=""col-1-2"">
                    <a class=""btn"" href=""#"">SAVE</a>
                </div>
                <div class=""col-1-2"">
                    <a class=""btn"" href=""#"">
");
                EndContext();
                BeginContext(3339, 24, true);
                WriteLiteral("                        ");
                EndContext();
#line 114 "D:\MY WORK\PRIGEEGE!!!!!\VSZANALYTICS\WebApplication3\Views\Home\Index.cshtml"
                          
                            ViewBag.Title = "Upload";
                        

#line default
#line hidden
                BeginContext(3449, 85, true);
                WriteLiteral("                        <h3>Выберите файл для загрузки</h3>\r\n                        ");
                EndContext();
                BeginContext(3534, 267, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9fb845955f234da996560bcd6394f901", async() => {
                    BeginContext(3627, 167, true);
                    WriteLiteral("\r\n                            <input type=\"file\" name=\"uploads\" /><br>\r\n                            <input type=\"submit\" value=\"Загрузить\" />\r\n                        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3801, 301, true);
                WriteLiteral(@"
                    </a>
                </div>
            </div>
        </div>
    </div>
    <footer>
        <div class=""container"">
            <div class=""col-1-3""></div>
            <div class=""col-1-3""></div>
            <div class=""col-1-3""></div>
        </div>
    </footer>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4109, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApplication3.Models.UserFile>> Html { get; private set; }
    }
}
#pragma warning restore 1591
