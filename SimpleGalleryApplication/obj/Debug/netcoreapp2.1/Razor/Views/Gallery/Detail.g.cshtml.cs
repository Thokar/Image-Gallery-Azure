#pragma checksum "D:\FilesToGo\Angular\FullStackApp\Image-Gallery-Azure\SimpleGalleryApplication\Views\Gallery\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bfe4067bcf836dd37342d1389822cd0e92e9a926"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Gallery_Detail), @"mvc.1.0.view", @"/Views/Gallery/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Gallery/Detail.cshtml", typeof(AspNetCore.Views_Gallery_Detail))]
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
#line 1 "D:\FilesToGo\Angular\FullStackApp\Image-Gallery-Azure\SimpleGalleryApplication\Views\_ViewImports.cshtml"
using SimpleGalleryApplication;

#line default
#line hidden
#line 2 "D:\FilesToGo\Angular\FullStackApp\Image-Gallery-Azure\SimpleGalleryApplication\Views\_ViewImports.cshtml"
using SimpleGalleryApplication.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bfe4067bcf836dd37342d1389822cd0e92e9a926", @"/Views/Gallery/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68857e3f4e5426f019581eb7b4bd166aeac2797a", @"/Views/_ViewImports.cshtml")]
    public class Views_Gallery_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SimpleGalleryApplication.Models.GalleryDetailModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Gallery", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(59, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\FilesToGo\Angular\FullStackApp\Image-Gallery-Azure\SimpleGalleryApplication\Views\Gallery\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
            BeginContext(103, 134, true);
            WriteLiteral("\r\n<div class=\"container body-content\">\r\n  <div class=\"row gallery-image-container-detail\">\r\n    <div class=\"image-detail\">\r\n      <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 237, "\"", 253, 1);
#line 10 "D:\FilesToGo\Angular\FullStackApp\Image-Gallery-Azure\SimpleGalleryApplication\Views\Gallery\Detail.cshtml"
WriteAttributeValue("", 243, Model.Url, 243, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 254, "\"", 272, 1);
#line 10 "D:\FilesToGo\Angular\FullStackApp\Image-Gallery-Azure\SimpleGalleryApplication\Views\Gallery\Detail.cshtml"
WriteAttributeValue("", 260, Model.Title, 260, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(273, 84, true);
            WriteLiteral(" />\r\n    </div>\r\n  </div>\r\n  <div class=\"row image-detail-meta\">\r\n    <span> Title: ");
            EndContext();
            BeginContext(358, 11, false);
#line 14 "D:\FilesToGo\Angular\FullStackApp\Image-Gallery-Azure\SimpleGalleryApplication\Views\Gallery\Detail.cshtml"
             Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(369, 30, true);
            WriteLiteral("</span>\r\n    <span> Uploaded: ");
            EndContext();
            BeginContext(400, 13, false);
#line 15 "D:\FilesToGo\Angular\FullStackApp\Image-Gallery-Azure\SimpleGalleryApplication\Views\Gallery\Detail.cshtml"
                Write(Model.Created);

#line default
#line hidden
            EndContext();
            BeginContext(413, 54, true);
            WriteLiteral("</span>\r\n  </div>\r\n  <div classe=\"row controls\">\r\n    ");
            EndContext();
            BeginContext(467, 104, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aff88c67c84949aabbea17ea03f89e48", async() => {
                BeginContext(538, 29, true);
                WriteLiteral("\r\n      Back to Gallery\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
            BeginContext(571, 20, true);
            WriteLiteral("\r\n  </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SimpleGalleryApplication.Models.GalleryDetailModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
