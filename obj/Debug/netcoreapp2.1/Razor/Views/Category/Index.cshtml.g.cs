#pragma checksum "C:\Users\monster\source\repos\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "685e2d16a72c20a81a995cf3d904b97436ed9eb9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Index), @"mvc.1.0.view", @"/Views/Category/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Category/Index.cshtml", typeof(AspNetCore.Views_Category_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"685e2d16a72c20a81a995cf3d904b97436ed9eb9", @"/Views/Category/Index.cshtml")]
    public class Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CoreAndFood.Data.Models.Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\monster\source\repos\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(135, 34, true);
            WriteLiteral("\r\n<h2>Category List</h2>\r\n<br />\r\n");
            EndContext();
#line 9 "C:\Users\monster\source\repos\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(199, 27, true);
            WriteLiteral("    <p>\r\n        Food Name:");
            EndContext();
            BeginContext(227, 17, false);
#line 12 "C:\Users\monster\source\repos\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
             Write(Html.TextBox("p"));

#line default
#line hidden
            EndContext();
            BeginContext(244, 58, true);
            WriteLiteral("\r\n        <input type=\"submit\" value=\"Find\" />\r\n    </p>\r\n");
            EndContext();
#line 15 "C:\Users\monster\source\repos\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
               
}

#line default
#line hidden
            BeginContext(322, 187, true);
            WriteLiteral("<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>ID</th>\r\n        <th>Category Name</th>\r\n        <th>Status</th>\r\n        <th>Delete</th>\r\n        <th>Update</th>\r\n    </tr>\r\n");
            EndContext();
#line 25 "C:\Users\monster\source\repos\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
     foreach (var x in Model)
    {

#line default
#line hidden
            BeginContext(547, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(594, 12, false);
#line 28 "C:\Users\monster\source\repos\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
                   Write(x.CategoryID);

#line default
#line hidden
            EndContext();
            BeginContext(606, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(638, 14, false);
#line 29 "C:\Users\monster\source\repos\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
                   Write(x.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(652, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(684, 8, false);
#line 30 "C:\Users\monster\source\repos\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
                   Write(x.Status);

#line default
#line hidden
            EndContext();
            BeginContext(692, 35, true);
            WriteLiteral("</td>\r\n\r\n                    <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 727, "\"", 772, 2);
            WriteAttributeValue("", 734, "/Category/CategoryDelete/", 734, 25, true);
#line 32 "C:\Users\monster\source\repos\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
WriteAttributeValue("", 759, x.CategoryID, 759, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(773, 67, true);
            WriteLiteral(" class=\"btn btn-danger\">Delete</a></td>\r\n                    <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 840, "\"", 882, 2);
            WriteAttributeValue("", 847, "/Category/CategoryGet/", 847, 22, true);
#line 33 "C:\Users\monster\source\repos\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
WriteAttributeValue("", 869, x.CategoryID, 869, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(883, 89, true);
            WriteLiteral(" class=\"btn btn-success\">Update</a></td>\r\n\r\n                    \r\n                </tr>\r\n");
            EndContext();
#line 37 "C:\Users\monster\source\repos\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(983, 85, true);
            WriteLiteral("</table>\r\n<a href=\"/Category/CategoryAdd/\" class=\"btn btn-primary\">New Category</a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CoreAndFood.Data.Models.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
