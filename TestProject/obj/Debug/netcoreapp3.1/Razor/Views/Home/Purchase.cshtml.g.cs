#pragma checksum "/Users/hannah/Documents/Wuxiaworld/TestProject/Views/Home/Purchase.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f10e3e52f75d19922fad55fa9b97f9d5788dfa9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Purchase), @"mvc.1.0.view", @"/Views/Home/Purchase.cshtml")]
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
#line 1 "/Users/hannah/Documents/Wuxiaworld/TestProject/Views/_ViewImports.cshtml"
using TestProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/hannah/Documents/Wuxiaworld/TestProject/Views/_ViewImports.cshtml"
using TestProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f10e3e52f75d19922fad55fa9b97f9d5788dfa9", @"/Views/Home/Purchase.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5793b3861753add5f6e734f58173abd93064819", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Purchase : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TestPurchase>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/hannah/Documents/Wuxiaworld/TestProject/Views/Home/Purchase.cshtml"
  
    ViewData["Title"] = "Purchase";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n \r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f10e3e52f75d19922fad55fa9b97f9d5788dfa93375", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\"/>\r\n    <title>Purchase:</title>\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f10e3e52f75d19922fad55fa9b97f9d5788dfa94423", async() => {
                WriteLiteral("\r\n\r\n    <h1>");
#nullable restore
#line 15 "/Users/hannah/Documents/Wuxiaworld/TestProject/Views/Home/Purchase.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n\r\n    <p>To create admin side to add Items for user view.</p>\r\n\r\n");
#nullable restore
#line 19 "/Users/hannah/Documents/Wuxiaworld/TestProject/Views/Home/Purchase.cshtml"
     using (Html.BeginForm("Purchase","HomeController", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        <table>
            <tr>
                <th>Enter Item Details:</th>
            </tr>
            <tr>
                <td>Item: </td>
                <td>
                    <input type=""text"" id=""PurchaseItem"" name=""PurchaseItem"" placeholder=""Enter Item"">
                </td>
            </tr>
            <tr>
                <td>Amount: </td>
                <td>
                    <input type=""number"" id=""PurchaseValue"" name=""PurchaseValue"" placeholder=""Enter Item Amount"">
                </td>
            </tr>
            <tr>
                <td>Date: </td>
                <td>
                    <input type=""date"" id=""PurchaseDate"" name=""PurchaseDate"" placeholder=""MM/DD/YYYY"">
                </td>
            </tr>
            <tr>
                <td></td>
                <td><input type=""submit"" value=""Submit""/></td>
            </tr>
        </table>
");
#nullable restore
#line 48 "/Users/hannah/Documents/Wuxiaworld/TestProject/Views/Home/Purchase.cshtml"
    }

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TestPurchase> Html { get; private set; }
    }
}
#pragma warning restore 1591
