#pragma checksum "C:\Users\GMT\Desktop\Stuff\DoAn1Final\DoAn1Final\DoAn1\DoAn1\Views\Order\AllOrders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3a4c9cf6077049e16e411a3e36858b35b220517"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_AllOrders), @"mvc.1.0.view", @"/Views/Order/AllOrders.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/AllOrders.cshtml", typeof(AspNetCore.Views_Order_AllOrders))]
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
#line 1 "C:\Users\GMT\Desktop\Stuff\DoAn1Final\DoAn1Final\DoAn1\DoAn1\Views\_ViewImports.cshtml"
using DoAn1;

#line default
#line hidden
#line 2 "C:\Users\GMT\Desktop\Stuff\DoAn1Final\DoAn1Final\DoAn1\DoAn1\Views\_ViewImports.cshtml"
using DoAn1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3a4c9cf6077049e16e411a3e36858b35b220517", @"/Views/Order/AllOrders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43da5b8a0c05820e6044dacf6ceed3ec2f937a09", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_AllOrders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DoAn1.ViewModels.ListOrdersWithId>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\GMT\Desktop\Stuff\DoAn1Final\DoAn1Final\DoAn1\DoAn1\Views\Order\AllOrders.cshtml"
  
    if (User.IsInRole("Admin") == true)
    {
        Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";
    }
    if (User.IsInRole("Seller") == true)
    {
        Layout = "~/Areas/Seller/Views/Shared/_Layout.cshtml";
    }

#line default
#line hidden
            BeginContext(245, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(289, 23, true);
            WriteLiteral("<h2>All Orders</h2>\r\n\r\n");
            EndContext();
            BeginContext(313, 43, false);
#line 15 "C:\Users\GMT\Desktop\Stuff\DoAn1Final\DoAn1Final\DoAn1\DoAn1\Views\Order\AllOrders.cshtml"
Write(await Html.PartialAsync("OrderList", Model));

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DoAn1.ViewModels.ListOrdersWithId> Html { get; private set; }
    }
}
#pragma warning restore 1591
