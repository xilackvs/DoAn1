#pragma checksum "C:\Users\GMT\Desktop\Stuff\DoAn1Final\DoAn1Final\DoAn1\DoAn1\Areas\Admin\Views\Management\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32aacf59cee2c710a2a4032b836cef02115984c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Management_Detail), @"mvc.1.0.view", @"/Areas/Admin/Views/Management/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Management/Detail.cshtml", typeof(AspNetCore.Areas_Admin_Views_Management_Detail))]
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
#line 1 "C:\Users\GMT\Desktop\Stuff\DoAn1Final\DoAn1Final\DoAn1\DoAn1\Areas\Admin\Views\_ViewImports.cshtml"
using DoAn1;

#line default
#line hidden
#line 2 "C:\Users\GMT\Desktop\Stuff\DoAn1Final\DoAn1Final\DoAn1\DoAn1\Areas\Admin\Views\_ViewImports.cshtml"
using DoAn1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32aacf59cee2c710a2a4032b836cef02115984c2", @"/Areas/Admin/Views/Management/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43da5b8a0c05820e6044dacf6ceed3ec2f937a09", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Management_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DoAn1.Data.Models.Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Management", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("your image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 66, true);
            WriteLiteral("\r\n<style>\r\n    img {\r\n        width: 15%;\r\n    }\r\n</style>\r\n\r\n<h1>");
            EndContext();
            BeginContext(101, 13, false);
#line 9 "C:\Users\GMT\Desktop\Stuff\DoAn1Final\DoAn1Final\DoAn1\DoAn1\Areas\Admin\Views\Management\Detail.cshtml"
Write(ViewBag.title);

#line default
#line hidden
            EndContext();
            BeginContext(114, 36, true);
            WriteLiteral("</h1>\r\n<h2>Product Details</h2>\r\n<p>");
            EndContext();
            BeginContext(150, 101, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8a81b5e54864a82b1b6d584464c2d79", async() => {
                BeginContext(241, 6, true);
                WriteLiteral("Return");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(251, 82, true);
            WriteLiteral("</p>\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>Product Name</th>\r\n        <td>");
            EndContext();
            BeginContext(334, 17, false);
#line 15 "C:\Users\GMT\Desktop\Stuff\DoAn1Final\DoAn1Final\DoAn1\DoAn1\Areas\Admin\Views\Management\Detail.cshtml"
       Write(Model.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(351, 71, true);
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th>Product Type</th>\r\n        <td>");
            EndContext();
            BeginContext(423, 22, false);
#line 19 "C:\Users\GMT\Desktop\Stuff\DoAn1Final\DoAn1Final\DoAn1\DoAn1\Areas\Admin\Views\Management\Detail.cshtml"
       Write(Model.ProductType.Name);

#line default
#line hidden
            EndContext();
            BeginContext(445, 65, true);
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th>Price</th>\r\n        <td>$");
            EndContext();
            BeginContext(511, 11, false);
#line 23 "C:\Users\GMT\Desktop\Stuff\DoAn1Final\DoAn1Final\DoAn1\DoAn1\Areas\Admin\Views\Management\Detail.cshtml"
        Write(Model.Price);

#line default
#line hidden
            EndContext();
            BeginContext(522, 78, true);
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th>Photo</th>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(600, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "78f3d92040414d4fb3abeee0d5adc4ea", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 610, "~/images/Products/", 610, 18, true);
#line 28 "C:\Users\GMT\Desktop\Stuff\DoAn1Final\DoAn1Final\DoAn1\DoAn1\Areas\Admin\Views\Management\Detail.cshtml"
AddHtmlAttributeValue("", 628, Model.Photo, 628, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(661, 88, true);
            WriteLiteral("\r\n        </td>\r\n\r\n    </tr>\r\n    <tr>\r\n        <th>Short Description</th>\r\n        <td>");
            EndContext();
            BeginContext(750, 22, false);
#line 34 "C:\Users\GMT\Desktop\Stuff\DoAn1Final\DoAn1Final\DoAn1\DoAn1\Areas\Admin\Views\Management\Detail.cshtml"
       Write(Model.ShortDescription);

#line default
#line hidden
            EndContext();
            BeginContext(772, 75, true);
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th>Long Description</th>\r\n        <td>");
            EndContext();
            BeginContext(848, 21, false);
#line 38 "C:\Users\GMT\Desktop\Stuff\DoAn1Final\DoAn1Final\DoAn1\DoAn1\Areas\Admin\Views\Management\Detail.cshtml"
       Write(Model.LongDescription);

#line default
#line hidden
            EndContext();
            BeginContext(869, 45, true);
            WriteLiteral("</td>\r\n    </tr>\r\n\r\n    <tr></tr>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DoAn1.Data.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
