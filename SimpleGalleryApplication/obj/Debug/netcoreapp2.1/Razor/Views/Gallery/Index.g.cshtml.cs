#pragma checksum "D:\Angular\FullStackApp\Image-Gallery-Azure\SimpleGalleryApplication\Views\Gallery\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "abfafc8bb1704ae41fbb4434f8aa7f9ce87a28f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Gallery_Index), @"mvc.1.0.view", @"/Views/Gallery/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Gallery/Index.cshtml", typeof(AspNetCore.Views_Gallery_Index))]
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
#line 1 "D:\Angular\FullStackApp\Image-Gallery-Azure\SimpleGalleryApplication\Views\_ViewImports.cshtml"
using SimpleGalleryApplication;

#line default
#line hidden
#line 2 "D:\Angular\FullStackApp\Image-Gallery-Azure\SimpleGalleryApplication\Views\_ViewImports.cshtml"
using SimpleGalleryApplication.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abfafc8bb1704ae41fbb4434f8aa7f9ce87a28f9", @"/Views/Gallery/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68857e3f4e5426f019581eb7b4bd166aeac2797a", @"/Views/_ViewImports.cshtml")]
    public class Views_Gallery_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SimpleGalleryApplication.Models.GalleryIndexModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Gallery", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(60, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "D:\Angular\FullStackApp\Image-Gallery-Azure\SimpleGalleryApplication\Views\Gallery\Index.cshtml"
  
  ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(101, 77, true);
            WriteLiteral("\r\n<div class=\"container body-content\">\r\n  <div class=\"row gallery-content\">\r\n");
            EndContext();
#line 10 "D:\Angular\FullStackApp\Image-Gallery-Azure\SimpleGalleryApplication\Views\Gallery\Index.cshtml"
     foreach (var image in Model.Images)
    {

#line default
#line hidden
            BeginContext(227, 65, true);
            WriteLiteral("      <div class=\"gallery-image-container drop-shadow\">\r\n        ");
            EndContext();
            BeginContext(292, 173, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "748ca0077a844c63926d73d176e1ed06", async() => {
                BeginContext(365, 38, true);
                WriteLiteral("\r\n          <div class=\"gallery-image\"");
                EndContext();
                BeginWriteAttribute("style", " style=\"", 403, "\"", 443, 3);
                WriteAttributeValue("", 411, "background-image:url(", 411, 21, true);
#line 14 "D:\Angular\FullStackApp\Image-Gallery-Azure\SimpleGalleryApplication\Views\Gallery\Index.cshtml"
WriteAttributeValue("", 432, image.Url, 432, 10, false);

#line default
#line hidden
                WriteAttributeValue("", 442, ")", 442, 1, true);
                EndWriteAttribute();
                BeginContext(444, 17, true);
                WriteLiteral("></div>\r\n        ");
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
#line 13 "D:\Angular\FullStackApp\Image-Gallery-Azure\SimpleGalleryApplication\Views\Gallery\Index.cshtml"
                                                          WriteLiteral(image.ID);

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
            BeginContext(465, 28, true);
            WriteLiteral("\r\n      </div>\r\n      <span>");
            EndContext();
            BeginContext(494, 11, false);
#line 17 "D:\Angular\FullStackApp\Image-Gallery-Azure\SimpleGalleryApplication\Views\Gallery\Index.cshtml"
       Write(image.Title);

#line default
#line hidden
            EndContext();
            BeginContext(505, 21, true);
            WriteLiteral("</span>\r\n      <ul>\r\n");
            EndContext();
#line 19 "D:\Angular\FullStackApp\Image-Gallery-Azure\SimpleGalleryApplication\Views\Gallery\Index.cshtml"
         foreach (var tag in image.ImageTags)
        {

#line default
#line hidden
            BeginContext(584, 14, true);
            WriteLiteral("          <li>");
            EndContext();
            BeginContext(599, 15, false);
#line 21 "D:\Angular\FullStackApp\Image-Gallery-Azure\SimpleGalleryApplication\Views\Gallery\Index.cshtml"
         Write(tag.Description);

#line default
#line hidden
            EndContext();
            BeginContext(614, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 22 "D:\Angular\FullStackApp\Image-Gallery-Azure\SimpleGalleryApplication\Views\Gallery\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(632, 13, true);
            WriteLiteral("      </ul>\r\n");
            EndContext();
#line 24 "D:\Angular\FullStackApp\Image-Gallery-Azure\SimpleGalleryApplication\Views\Gallery\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(652, 20, true);
            WriteLiteral("  </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SimpleGalleryApplication.Models.GalleryIndexModel> Html { get; private set; }
    }
}
#pragma warning restore 1591