#pragma checksum "C:\Users\James\Source\Repos\BBForm\BBForm\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a40a4cd9897b74aff0b1ebff88234923315724df"
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
#line 1 "C:\Users\James\Source\Repos\BBForm\BBForm\Views\_ViewImports.cshtml"
using BBForm;

#line default
#line hidden
#line 2 "C:\Users\James\Source\Repos\BBForm\BBForm\Views\_ViewImports.cshtml"
using BBForm.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a40a4cd9897b74aff0b1ebff88234923315724df", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"381f8d7f0da8ff4db1baed04e268f8c893f7bc41", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\James\Source\Repos\BBForm\BBForm\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 38, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h5> ");
            EndContext();
            BeginContext(105, 829, true);
            WriteLiteral(@"Basketball Player Entry Form</h5>
    <p>This is the Basketball Player Entry Form developed for Seikosoft as an interview project.</p>
    <ul>
        <li>
            Each of the above links provides a respective list along with the ablility to create, update, and delete fields.
        </li>
        <li>
            The Players link provides a list of all players currently in the database.
        </li>
        <li>
            The Teams link provides a list of all basketball teams currently in the database.
        </li>
        <li>
            The Player's Teams link provides a list of all players as well as their previous and current teams on which they played. There
                is also a seach parameter allowing you to refine a search based on a given team.
        </li>
    </ul>
</div>
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
