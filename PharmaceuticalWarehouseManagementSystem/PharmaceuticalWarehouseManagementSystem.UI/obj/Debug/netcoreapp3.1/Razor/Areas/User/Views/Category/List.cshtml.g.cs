#pragma checksum "C:\Users\LornV\Documents\GitHub\Test-Version\PharmaceuticalWarehouseManagementSystem\PharmaceuticalWarehouseManagementSystem.UI\Areas\User\Views\Category\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f028207d3ed6085ee8d656bc0ef027a80a1ab6f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_User_Views_Category_List), @"mvc.1.0.view", @"/Areas/User/Views/Category/List.cshtml")]
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
#line 1 "C:\Users\LornV\Documents\GitHub\Test-Version\PharmaceuticalWarehouseManagementSystem\PharmaceuticalWarehouseManagementSystem.UI\Areas\User\Views\_ViewImports.cshtml"
using PharmaceuticalWarehouseManagementSystem.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LornV\Documents\GitHub\Test-Version\PharmaceuticalWarehouseManagementSystem\PharmaceuticalWarehouseManagementSystem.UI\Areas\User\Views\_ViewImports.cshtml"
using PharmaceuticalWarehouseManagementSystem.UI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f028207d3ed6085ee8d656bc0ef027a80a1ab6f", @"/Areas/User/Views/Category/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f63222cf90b101eed568e1d04ba3195a08b01dfc", @"/Areas/User/Views/_ViewImports.cshtml")]
    public class Areas_User_Views_Category_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PharmaceuticalWarehouseManagementSystem.ENTITY.Entity.Category>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\LornV\Documents\GitHub\Test-Version\PharmaceuticalWarehouseManagementSystem\PharmaceuticalWarehouseManagementSystem.UI\Areas\User\Views\Category\List.cshtml"
  
    ViewData["Title"] = "List";
    Layout = "~/Areas/User/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"card-header\">\r\n    <div class=\"card-title\">Category List</div>\r\n</div>\r\n\r\n<div class=\"card-body table-responsive\">\r\n<table class=\"table table-bordered\">\r\n    <thead>\r\n    <tr>\r\n        <th>\r\n            ");
#nullable restore
#line 18 "C:\Users\LornV\Documents\GitHub\Test-Version\PharmaceuticalWarehouseManagementSystem\PharmaceuticalWarehouseManagementSystem.UI\Areas\User\Views\Category\List.cshtml"
       Write(Html.DisplayNameFor(model => model.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 21 "C:\Users\LornV\Documents\GitHub\Test-Version\PharmaceuticalWarehouseManagementSystem\PharmaceuticalWarehouseManagementSystem.UI\Areas\User\Views\Category\List.cshtml"
       Write(Html.DisplayNameFor(model => model.CategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 24 "C:\Users\LornV\Documents\GitHub\Test-Version\PharmaceuticalWarehouseManagementSystem\PharmaceuticalWarehouseManagementSystem.UI\Areas\User\Views\Category\List.cshtml"
       Write(Html.DisplayNameFor(model => model.CategoryDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        \r\n        <th></th>\r\n    </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 31 "C:\Users\LornV\Documents\GitHub\Test-Version\PharmaceuticalWarehouseManagementSystem\PharmaceuticalWarehouseManagementSystem.UI\Areas\User\Views\Category\List.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 35 "C:\Users\LornV\Documents\GitHub\Test-Version\PharmaceuticalWarehouseManagementSystem\PharmaceuticalWarehouseManagementSystem.UI\Areas\User\Views\Category\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 38 "C:\Users\LornV\Documents\GitHub\Test-Version\PharmaceuticalWarehouseManagementSystem\PharmaceuticalWarehouseManagementSystem.UI\Areas\User\Views\Category\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.CategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 41 "C:\Users\LornV\Documents\GitHub\Test-Version\PharmaceuticalWarehouseManagementSystem\PharmaceuticalWarehouseManagementSystem.UI\Areas\User\Views\Category\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.CategoryDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f028207d3ed6085ee8d656bc0ef027a80a1ab6f8263", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 45 "C:\Users\LornV\Documents\GitHub\Test-Version\PharmaceuticalWarehouseManagementSystem\PharmaceuticalWarehouseManagementSystem.UI\Areas\User\Views\Category\List.cshtml"
                                       WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <br />\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f028207d3ed6085ee8d656bc0ef027a80a1ab6f10621", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 47 "C:\Users\LornV\Documents\GitHub\Test-Version\PharmaceuticalWarehouseManagementSystem\PharmaceuticalWarehouseManagementSystem.UI\Areas\User\Views\Category\List.cshtml"
                                         WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 50 "C:\Users\LornV\Documents\GitHub\Test-Version\PharmaceuticalWarehouseManagementSystem\PharmaceuticalWarehouseManagementSystem.UI\Areas\User\Views\Category\List.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PharmaceuticalWarehouseManagementSystem.ENTITY.Entity.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
