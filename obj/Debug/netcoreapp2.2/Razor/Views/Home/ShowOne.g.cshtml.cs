#pragma checksum "C:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\asp_dot_net\CRUDelicious\Views\Home\ShowOne.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd7992a70ed08313bf5ea140f61c07adfea2ea1b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ShowOne), @"mvc.1.0.view", @"/Views/Home/ShowOne.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ShowOne.cshtml", typeof(AspNetCore.Views_Home_ShowOne))]
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
#line 1 "C:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\asp_dot_net\CRUDelicious\Views\_ViewImports.cshtml"
using CRUDelicious;

#line default
#line hidden
#line 2 "C:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\asp_dot_net\CRUDelicious\Views\_ViewImports.cshtml"
using CRUDelicious.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd7992a70ed08313bf5ea140f61c07adfea2ea1b", @"/Views/Home/ShowOne.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"815eae4269ab1eac71e8261ccfa9294c33285639", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ShowOne : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Dish>>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 35, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(35, 207, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd7992a70ed08313bf5ea140f61c07adfea2ea1b3439", async() => {
                BeginContext(41, 194, true);
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"ie=edge\">\r\n    <title>Document</title>\r\n");
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
            BeginContext(242, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(244, 656, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd7992a70ed08313bf5ea140f61c07adfea2ea1b4831", async() => {
                BeginContext(250, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(279, 14, true);
                WriteLiteral("            \r\n");
                EndContext();
#line 12 "C:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\asp_dot_net\CRUDelicious\Views\Home\ShowOne.cshtml"
             foreach(var item in Model)
            {


#line default
#line hidden
                BeginContext(351, 58, true);
                WriteLiteral("                <a href=\"/\">Home</a>\r\n                <h1>");
                EndContext();
                BeginContext(410, 9, false);
#line 16 "C:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\asp_dot_net\CRUDelicious\Views\Home\ShowOne.cshtml"
               Write(item.Name);

#line default
#line hidden
                EndContext();
                BeginContext(419, 27, true);
                WriteLiteral("</h1>\r\n                <h3>");
                EndContext();
                BeginContext(447, 9, false);
#line 17 "C:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\asp_dot_net\CRUDelicious\Views\Home\ShowOne.cshtml"
               Write(item.Chef);

#line default
#line hidden
                EndContext();
                BeginContext(456, 29, true);
                WriteLiteral("</h3>\r\n                <hr>\r\n");
                EndContext();
                BeginContext(487, 20, true);
                WriteLiteral("                <h5>");
                EndContext();
                BeginContext(508, 16, false);
#line 20 "C:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\asp_dot_net\CRUDelicious\Views\Home\ShowOne.cshtml"
               Write(item.Description);

#line default
#line hidden
                EndContext();
                BeginContext(524, 37, true);
                WriteLiteral("</h5>\r\n                <h5>calories: ");
                EndContext();
                BeginContext(562, 13, false);
#line 21 "C:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\asp_dot_net\CRUDelicious\Views\Home\ShowOne.cshtml"
                         Write(item.Calories);

#line default
#line hidden
                EndContext();
                BeginContext(575, 38, true);
                WriteLiteral("</h5>\r\n                <h5>Tastiness: ");
                EndContext();
                BeginContext(614, 14, false);
#line 22 "C:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\asp_dot_net\CRUDelicious\Views\Home\ShowOne.cshtml"
                          Write(item.Tastiness);

#line default
#line hidden
                EndContext();
                BeginContext(628, 49, true);
                WriteLiteral("</h5>\r\n            <div>\r\n                <button");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 677, "\"", 732, 5);
                WriteAttributeValue("", 687, "window.location.href", 687, 20, true);
                WriteAttributeValue(" ", 707, "=", 708, 2, true);
                WriteAttributeValue(" ", 709, "\'/delete/", 710, 10, true);
#line 24 "C:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\asp_dot_net\CRUDelicious\Views\Home\ShowOne.cshtml"
WriteAttributeValue("", 719, item.DishId, 719, 12, false);

#line default
#line hidden
                WriteAttributeValue("", 731, "\'", 731, 1, true);
                EndWriteAttribute();
                BeginContext(733, 41, true);
                WriteLiteral(">Delete</button>\r\n                <button");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 774, "\"", 827, 5);
                WriteAttributeValue("", 784, "window.location.href", 784, 20, true);
                WriteAttributeValue(" ", 804, "=", 805, 2, true);
                WriteAttributeValue(" ", 806, "\'/edit/", 807, 8, true);
#line 25 "C:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\asp_dot_net\CRUDelicious\Views\Home\ShowOne.cshtml"
WriteAttributeValue("", 814, item.DishId, 814, 12, false);

#line default
#line hidden
                WriteAttributeValue("", 826, "\'", 826, 1, true);
                EndWriteAttribute();
                BeginContext(828, 36, true);
                WriteLiteral(">Edit</button>\r\n            </div>\r\n");
                EndContext();
#line 27 "C:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\asp_dot_net\CRUDelicious\Views\Home\ShowOne.cshtml"
            }

#line default
#line hidden
                BeginContext(879, 14, true);
                WriteLiteral("            \r\n");
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
            BeginContext(900, 9, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Dish>> Html { get; private set; }
    }
}
#pragma warning restore 1591
