#pragma checksum "D:\iti\.netcore\lec1 .core\lab6mvccore\lab6mvccore\Views\StudentController1\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83a927daffe3b1ac3732f07893dc3c9286feaeb0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_StudentController1_Index), @"mvc.1.0.view", @"/Views/StudentController1/Index.cshtml")]
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
#line 1 "D:\iti\.netcore\lec1 .core\lab6mvccore\lab6mvccore\Views\_ViewImports.cshtml"
using lab6mvccore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\iti\.netcore\lec1 .core\lab6mvccore\lab6mvccore\Views\_ViewImports.cshtml"
using lab6mvccore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\iti\.netcore\lec1 .core\lab6mvccore\lab6mvccore\Views\_ViewImports.cshtml"
using lab6mvccore.services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83a927daffe3b1ac3732f07893dc3c9286feaeb0", @"/Views/StudentController1/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1f04b06fc93d550e36ed0e0f4401fe7e25885a3", @"/Views/_ViewImports.cshtml")]
    public class Views_StudentController1_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Student>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\iti\.netcore\lec1 .core\lab6mvccore\lab6mvccore\Views\StudentController1\Index.cshtml"
  
    ViewBag.Title = "Student list";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>\r\n            ID\r\n        </th>\r\n        <th>\r\n            Name\r\n        </th>\r\n        <th>\r\n            Age\r\n        </th>\r\n\r\n        <th></th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 21 "D:\iti\.netcore\lec1 .core\lab6mvccore\lab6mvccore\Views\StudentController1\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 25 "D:\iti\.netcore\lec1 .core\lab6mvccore\lab6mvccore\Views\StudentController1\Index.cshtml"
           Write(item.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 28 "D:\iti\.netcore\lec1 .core\lab6mvccore\lab6mvccore\Views\StudentController1\Index.cshtml"
           Write(item.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 31 "D:\iti\.netcore\lec1 .core\lab6mvccore\lab6mvccore\Views\StudentController1\Index.cshtml"
           Write(item.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n            <td></td>\r\n        </tr>\r\n");
#nullable restore
#line 36 "D:\iti\.netcore\lec1 .core\lab6mvccore\lab6mvccore\Views\StudentController1\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591
