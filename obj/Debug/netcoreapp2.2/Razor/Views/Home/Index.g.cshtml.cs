#pragma checksum "C:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\asp_dot_net\CRUDelicious\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0bebe3ea72a876f77b0b2d6e74416f3985ca9c3"
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
#line 1 "C:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\asp_dot_net\CRUDelicious\Views\_ViewImports.cshtml"
using CRUDelicious;

#line default
#line hidden
#line 2 "C:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\asp_dot_net\CRUDelicious\Views\_ViewImports.cshtml"
using CRUDelicious.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0bebe3ea72a876f77b0b2d6e74416f3985ca9c3", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"815eae4269ab1eac71e8261ccfa9294c33285639", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Dish>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\asp_dot_net\CRUDelicious\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 182, true);
            WriteLiteral("\r\n<div>\r\n    <h1>Welcome to CRUDelicious</h1>\r\n    <div>\r\n        <h3>Checkout some recent dishes!</h3>\r\n        <a href=\"/new\">Add a Dish!</a>\r\n        <hr>\r\n    </div>\r\n    <div>\r\n");
            EndContext();
            BeginContext(254, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 14 "C:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\asp_dot_net\CRUDelicious\Views\Home\Index.cshtml"
         foreach(var dish in Model)
        {

#line default
#line hidden
            BeginContext(302, 18, true);
            WriteLiteral("            <h3><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 320, "\"", 340, 2);
            WriteAttributeValue("", 327, "/", 327, 1, true);
#line 16 "C:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\asp_dot_net\CRUDelicious\Views\Home\Index.cshtml"
WriteAttributeValue("", 328, dish.DishId, 328, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(341, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(343, 9, false);
#line 16 "C:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\asp_dot_net\CRUDelicious\Views\Home\Index.cshtml"
                                   Write(dish.Name);

#line default
#line hidden
            EndContext();
            BeginContext(352, 9, true);
            WriteLiteral("</a>  by ");
            EndContext();
            BeginContext(362, 9, false);
#line 16 "C:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\asp_dot_net\CRUDelicious\Views\Home\Index.cshtml"
                                                      Write(dish.Chef);

#line default
#line hidden
            EndContext();
            BeginContext(371, 8, true);
            WriteLiteral(" </h3>\r\n");
            EndContext();
#line 17 "C:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\asp_dot_net\CRUDelicious\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(390, 18, true);
            WriteLiteral("    </div>\r\n</div>");
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
