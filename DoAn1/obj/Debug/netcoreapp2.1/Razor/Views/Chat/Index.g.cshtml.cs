#pragma checksum "C:\Users\GMT\Desktop\Stuff\DoAn1Final\DoAn1Final\DoAn1\DoAn1\Views\Chat\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9de337fa7dbca5d18c6581fe08ce6c3dad45ccba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Chat_Index), @"mvc.1.0.view", @"/Views/Chat/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Chat/Index.cshtml", typeof(AspNetCore.Views_Chat_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9de337fa7dbca5d18c6581fe08ce6c3dad45ccba", @"/Views/Chat/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43da5b8a0c05820e6044dacf6ceed3ec2f937a09", @"/Views/_ViewImports.cshtml")]
    public class Views_Chat_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/aspnet/signalr/dist/browser/signalr.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\GMT\Desktop\Stuff\DoAn1Final\DoAn1Final\DoAn1\DoAn1\Views\Chat\Index.cshtml"
  
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
            BeginContext(247, 420, true);
            WriteLiteral(@"

<style type=""text/css"">

    .container {
        background-color: #99CCFF;
        border: thick solid #808080;
        padding: 20px;
        margin: 20px;
    }
</style>

<div class=""container"">
    <input type=""text"" id=""message"" />
    <input type=""button"" id=""sendmessage"" value=""Send"" />
    <ul id=""discussion""></ul>
</div>
<!--Script references. -->
<!--Reference the SignalR library. -->
");
            EndContext();
            BeginContext(667, 95, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4d3d140d9b143e6bbf803e90dfc8585", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(762, 292, true);
            WriteLiteral(@"
<!--Add script to update the page and send messages.-->
<script type=""text/javascript"">
    document.addEventListener('DOMContentLoaded', function () {

        var messageInput = document.getElementById('message');

        // Get the user name and store it to prepend to messages.
");
            EndContext();
            BeginContext(1129, 20, true);
            WriteLiteral("        var name = \'");
            EndContext();
            BeginContext(1150, 18, false);
#line 40 "C:\Users\GMT\Desktop\Stuff\DoAn1Final\DoAn1Final\DoAn1\DoAn1\Views\Chat\Index.cshtml"
               Write(User.Identity.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1168, 1595, true);
            WriteLiteral(@"';
        // Set initial focus to message input box.
        messageInput.focus();

        // Start the connection.
        var connection = new signalR.HubConnectionBuilder()
            .withUrl('/chatSignalR')
            .build();

        // Create a function that the hub can call to broadcast messages.
        connection.on('broadcastMessage', function (name, message) {
            // Html encode display name and message.
            var encodedName = name;
            var encodedMsg = message;
            // Add the message to the page.
            var liElement = document.createElement('li');
            liElement.innerHTML = '<strong>' + encodedName + '</strong>:&nbsp;&nbsp;' + encodedMsg;
            document.getElementById('discussion').appendChild(liElement);
        });

        // Transport fallback functionality is now built into start.
        connection.start()
            .then(function () {
                console.log('connection started');
                document");
            WriteLiteral(@".getElementById('sendmessage').addEventListener('click', function (event) {
                    // Call the Send method on the hub.
                    connection.invoke('send', name, messageInput.value);

                    // Clear text box and reset focus for next comment.
                    messageInput.value = '';
                    messageInput.focus();
                    event.preventDefault();
                });
            })
            .catch(error => {
                console.error(error.message);
            });
    });</script>


");
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
