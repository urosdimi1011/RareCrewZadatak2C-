#pragma checksum "C:\Users\Lenovo\Desktop\posao_zadaci\Zadatak 2- C#\Zadatak\Zadatak\Views\Employ\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "431f97ccfbdb6617170e954decdba14988f5308e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employ_Index), @"mvc.1.0.view", @"/Views/Employ/Index.cshtml")]
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
#line 1 "C:\Users\Lenovo\Desktop\posao_zadaci\Zadatak 2- C#\Zadatak\Zadatak\Views\_ViewImports.cshtml"
using Zadatak;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo\Desktop\posao_zadaci\Zadatak 2- C#\Zadatak\Zadatak\Views\_ViewImports.cshtml"
using Zadatak.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"431f97ccfbdb6617170e954decdba14988f5308e", @"/Views/Employ/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f0a1fc9bfc9f6da3ef27ad06a685f103cc67679", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Employ_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EmployeeTimeEntry>>
    #nullable disable
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
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "431f97ccfbdb6617170e954decdba14988f5308e3343", async() => {
                WriteLiteral(@"
    <title>Employee Time Tracker</title>
    <style>
        .low-work {
            background-color: red;
        }
        thead{
            background-color:silver;
        }
        th,td{
            padding-left:7px;
            padding-top:10px;
            padding-bottom:10px;
            width:200px;
        }

    </style>
");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "431f97ccfbdb6617170e954decdba14988f5308e4661", async() => {
                WriteLiteral(@"
    <h1>Employees Ordered by Total Time Worked</h1>
    <table border=""1"">
        <thead>
            <tr>
                <th>Name</th>
                <th>Total time in Month</th>
                <th>Edit</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 34 "C:\Users\Lenovo\Desktop\posao_zadaci\Zadatak 2- C#\Zadatak\Zadatak\Views\Employ\Index.cshtml"
             foreach (var entry in Model)
            {
                var rowClass = entry.TotalTimeWorked < 100 ? "low-work" : "";

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr");
                BeginWriteAttribute("class", " class=\"", 867, "\"", 884, 1);
#nullable restore
#line 37 "C:\Users\Lenovo\Desktop\posao_zadaci\Zadatak 2- C#\Zadatak\Zadatak\Views\Employ\Index.cshtml"
WriteAttributeValue("", 875, rowClass, 875, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <td>");
#nullable restore
#line 38 "C:\Users\Lenovo\Desktop\posao_zadaci\Zadatak 2- C#\Zadatak\Zadatak\Views\Employ\Index.cshtml"
                   Write(entry.EmployeeName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 39 "C:\Users\Lenovo\Desktop\posao_zadaci\Zadatak 2- C#\Zadatak\Zadatak\Views\Employ\Index.cshtml"
                   Write(entry.TotalTimeWorked.ToString("0.##"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" hrs</td>\r\n                    <td><a href=\"#\">Edit</a></td>\r\n                </tr>\r\n");
#nullable restore
#line 42 "C:\Users\Lenovo\Desktop\posao_zadaci\Zadatak 2- C#\Zadatak\Zadatak\Views\Employ\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\r\n    </table>\r\n");
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
            WriteLiteral("\r\n</html>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EmployeeTimeEntry>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
