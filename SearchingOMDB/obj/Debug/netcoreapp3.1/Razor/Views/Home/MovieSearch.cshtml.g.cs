#pragma checksum "C:\Users\ybeea\OneDrive\Desktop\GrandCircus\Week6\SearchingOMDB\SearchingOMDB\Views\Home\MovieSearch.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2216cb5718c4809f3a48e388133ec8f95fd30215"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_MovieSearch), @"mvc.1.0.view", @"/Views/Home/MovieSearch.cshtml")]
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
#line 1 "C:\Users\ybeea\OneDrive\Desktop\GrandCircus\Week6\SearchingOMDB\SearchingOMDB\Views\_ViewImports.cshtml"
using SearchingOMDB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ybeea\OneDrive\Desktop\GrandCircus\Week6\SearchingOMDB\SearchingOMDB\Views\_ViewImports.cshtml"
using SearchingOMDB.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2216cb5718c4809f3a48e388133ec8f95fd30215", @"/Views/Home/MovieSearch.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19e8d75778c91d0e4e98daf886f5d11c4c483e63", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_MovieSearch : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MovieModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MovieSearch", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div style=\"text-align:center\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2216cb5718c4809f3a48e388133ec8f95fd302153960", async() => {
                WriteLiteral("\r\n        <label for=\"title\">Enter Movie Title:</label>\r\n        <input type=\"text\" name=\"title\" id=\"title\" /><br />\r\n        <input type=\"submit\" />\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
#nullable restore
#line 15 "C:\Users\ybeea\OneDrive\Desktop\GrandCircus\Week6\SearchingOMDB\SearchingOMDB\Views\Home\MovieSearch.cshtml"
 if (Model != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div style=\"text-align:center\">\r\n    <h3>Movie:</h3>\r\n    <h4>");
#nullable restore
#line 19 "C:\Users\ybeea\OneDrive\Desktop\GrandCircus\Week6\SearchingOMDB\SearchingOMDB\Views\Home\MovieSearch.cshtml"
   Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    <h4>");
#nullable restore
#line 20 "C:\Users\ybeea\OneDrive\Desktop\GrandCircus\Week6\SearchingOMDB\SearchingOMDB\Views\Home\MovieSearch.cshtml"
   Write(Model.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    <h5>");
#nullable restore
#line 21 "C:\Users\ybeea\OneDrive\Desktop\GrandCircus\Week6\SearchingOMDB\SearchingOMDB\Views\Home\MovieSearch.cshtml"
   Write(Model.Rated);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n    <img");
            BeginWriteAttribute("src", " src=\"", 572, "\"", 591, 1);
#nullable restore
#line 22 "C:\Users\ybeea\OneDrive\Desktop\GrandCircus\Week6\SearchingOMDB\SearchingOMDB\Views\Home\MovieSearch.cshtml"
WriteAttributeValue("", 578, Model.Poster, 578, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n</div>\r\n");
#nullable restore
#line 24 "C:\Users\ybeea\OneDrive\Desktop\GrandCircus\Week6\SearchingOMDB\SearchingOMDB\Views\Home\MovieSearch.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MovieModel> Html { get; private set; }
    }
}
#pragma warning restore 1591