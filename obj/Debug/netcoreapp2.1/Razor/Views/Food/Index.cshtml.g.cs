#pragma checksum "C:\Users\monster\source\repos\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ceb01af9f5d48d8a0ec9ce0822a05dda7907ea76"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Food_Index), @"mvc.1.0.view", @"/Views/Food/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Food/Index.cshtml", typeof(AspNetCore.Views_Food_Index))]
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
#line 1 "C:\Users\monster\source\repos\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#line 2 "C:\Users\monster\source\repos\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ceb01af9f5d48d8a0ec9ce0822a05dda7907ea76", @"/Views/Food/Index.cshtml")]
    public class Views_Food_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<CoreAndFood.Data.Models.Food>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(99, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\monster\source\repos\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(189, 296, true);
            WriteLiteral(@"
<h2>Food List</h2>
<br />
<table class=""table table-bordered"">
    <tr>
        <th>ID</th>
        <th>Food Name</th>
        <th>Price</th>
        <th>Stock</th>
        <th>Category Name</th>
        <th>Delete</th>
        <th>Update</th>
        <th>Details</th>

    </tr>
");
            EndContext();
#line 24 "C:\Users\monster\source\repos\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
     foreach (var x in Model)
    {

#line default
#line hidden
            BeginContext(523, 18, true);
            WriteLiteral("    <tr>\r\n    <th>");
            EndContext();
            BeginContext(542, 8, false);
#line 27 "C:\Users\monster\source\repos\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
   Write(x.FoodID);

#line default
#line hidden
            EndContext();
            BeginContext(550, 15, true);
            WriteLiteral("</th>\r\n    <td>");
            EndContext();
            BeginContext(566, 6, false);
#line 28 "C:\Users\monster\source\repos\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
   Write(x.Name);

#line default
#line hidden
            EndContext();
            BeginContext(572, 15, true);
            WriteLiteral("</td>\r\n    <td>");
            EndContext();
            BeginContext(588, 7, false);
#line 29 "C:\Users\monster\source\repos\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
   Write(x.Price);

#line default
#line hidden
            EndContext();
            BeginContext(595, 15, true);
            WriteLiteral("</td>\r\n    <td>");
            EndContext();
            BeginContext(611, 7, false);
#line 30 "C:\Users\monster\source\repos\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
   Write(x.Stock);

#line default
#line hidden
            EndContext();
            BeginContext(618, 15, true);
            WriteLiteral("</td>\r\n    <td>");
            EndContext();
            BeginContext(634, 23, false);
#line 31 "C:\Users\monster\source\repos\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
   Write(x.Category.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(657, 19, true);
            WriteLiteral("</td>  \r\n    <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 676, "\"", 709, 2);
            WriteAttributeValue("", 683, "/Food/DeleteFood/", 683, 17, true);
#line 32 "C:\Users\monster\source\repos\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
WriteAttributeValue("", 700, x.FoodID, 700, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(710, 51, true);
            WriteLiteral(" class=\"btn btn-danger\">Delete</a></td>\r\n    <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 761, "\"", 791, 2);
            WriteAttributeValue("", 768, "/Food/FoodGet/", 768, 14, true);
#line 33 "C:\Users\monster\source\repos\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
WriteAttributeValue("", 782, x.FoodID, 782, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(792, 124, true);
            WriteLiteral(" class=\"btn btn-success\">Update</a></td>\r\n    <td><a href=\"#\" class=\"btn btn-info\">Details</a></td>\r\n        \r\n\r\n    </tr>\r\n");
            EndContext();
#line 38 "C:\Users\monster\source\repos\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(923, 10, true);
            WriteLiteral("</table>\r\n");
            EndContext();
            BeginContext(934, 80, false);
#line 40 "C:\Users\monster\source\repos\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
Write(Html.PagedListPager((IPagedList)Model, page => Url.Action("Index", new { page})));

#line default
#line hidden
            EndContext();
            BeginContext(1014, 63, true);
            WriteLiteral("\r\n<a href=\"/Food/AddFood/\" class=\"btn btn-primary\">New Food</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<CoreAndFood.Data.Models.Food>> Html { get; private set; }
    }
}
#pragma warning restore 1591