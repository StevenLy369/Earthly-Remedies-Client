#pragma checksum "C:\Users\cronk\desktop\EarthlyRemediesClient\Views\Remedies\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04621b1d381bebe25c88e4c84c87e7c70a49cc3d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Remedies_Edit), @"mvc.1.0.view", @"/Views/Remedies/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Remedies/Edit.cshtml", typeof(AspNetCore.Views_Remedies_Edit))]
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
#line 1 "C:\Users\cronk\desktop\EarthlyRemediesClient\Views\_ViewImports.cshtml"
using EarthlyRemediesClient;

#line default
#line hidden
#line 2 "C:\Users\cronk\desktop\EarthlyRemediesClient\Views\_ViewImports.cshtml"
using EarthlyRemediesClient.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04621b1d381bebe25c88e4c84c87e7c70a49cc3d", @"/Views/Remedies/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33c70f17bebfd452a2e66cc73fac3efb349a4e8c", @"/Views/_ViewImports.cshtml")]
    public class Views_Remedies_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\cronk\desktop\EarthlyRemediesClient\Views\Remedies\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
            BeginContext(40, 29, true);
            WriteLiteral("\r\n\r\n<h1> Edit Remedy</h1>\r\n\r\n");
            EndContext();
            BeginContext(69, 650, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "04621b1d381bebe25c88e4c84c87e7c70a49cc3d3813", async() => {
                BeginContext(134, 90, true);
                WriteLiteral("\r\n    <label for=\"name\"> Remedy Name</label>\r\n    <input id=\"name\" name=\"name\" type=\"text\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 224, "\"", 245, 1);
#line 10 "C:\Users\cronk\desktop\EarthlyRemediesClient\Views\Remedies\Edit.cshtml"
WriteAttributeValue("", 232, Model.Name, 232, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(246, 103, true);
                WriteLiteral(">\r\n    <label for=\"details\"> Remedy Details</label>\r\n    <input id=\"details\" name=\"details\" type=\"text\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 349, "\"", 373, 1);
#line 12 "C:\Users\cronk\desktop\EarthlyRemediesClient\Views\Remedies\Edit.cshtml"
WriteAttributeValue("", 357, Model.Details, 357, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(374, 103, true);
                WriteLiteral(">\r\n    <label for =\"ailment\"> Ailment Name</label>\r\n    <input id=\"ailment\" name=\"ailment\" type =\"text\"");
                EndContext();
                BeginWriteAttribute("value", " value =\"", 477, "\"", 502, 1);
#line 14 "C:\Users\cronk\desktop\EarthlyRemediesClient\Views\Remedies\Edit.cshtml"
WriteAttributeValue("", 486, Model.Ailment, 486, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(503, 119, true);
                WriteLiteral(">\r\n    <label for=\"ingredients\"> Remedy Ingredients</label>\r\n    <input id=\"ingredients\" name=\"ingredients\" type=\"text\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 622, "\"", 650, 1);
#line 16 "C:\Users\cronk\desktop\EarthlyRemediesClient\Views\Remedies\Edit.cshtml"
WriteAttributeValue("", 630, Model.Ingredients, 630, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(651, 61, true);
                WriteLiteral("/>\r\n\r\n    <button type=\"submit\">Update this Remedy</button>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 83, "/remedies/Details/", 83, 18, true);
#line 8 "C:\Users\cronk\desktop\EarthlyRemediesClient\Views\Remedies\Edit.cshtml"
AddHtmlAttributeValue("", 101, Model.RemedyId, 101, 17, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(719, 12, true);
            WriteLiteral("\r\n\r\n\r\n    \r\n");
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
