#pragma checksum "C:\Users\Randel\Epicodus\c#_projects\CretaceousPark.Solution\CretaceousClient\Views\Animals\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ceb1d7b9d7159ce9a9698851715d7fb03afbfe02"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Animals_Index), @"mvc.1.0.view", @"/Views/Animals/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Animals/Index.cshtml", typeof(AspNetCore.Views_Animals_Index))]
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
#line 1 "C:\Users\Randel\Epicodus\c#_projects\CretaceousPark.Solution\CretaceousClient\Views\_ViewImports.cshtml"
using CretaceousClient;

#line default
#line hidden
#line 2 "C:\Users\Randel\Epicodus\c#_projects\CretaceousPark.Solution\CretaceousClient\Views\_ViewImports.cshtml"
using CretaceousClient.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ceb1d7b9d7159ce9a9698851715d7fb03afbfe02", @"/Views/Animals/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f39fe7863f0515623de0efe633db44e57c6c85f", @"/Views/_ViewImports.cshtml")]
    public class Views_Animals_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 31, true);
            WriteLiteral("<h1>All Animals:</h1>\r\n\r\n<ol>\r\n");
            EndContext();
#line 4 "C:\Users\Randel\Epicodus\c#_projects\CretaceousPark.Solution\CretaceousClient\Views\Animals\Index.cshtml"
 foreach (Animal animal in Model)
{

#line default
#line hidden
            BeginContext(69, 26, true);
            WriteLiteral("    <ul>\r\n        <li>ID: ");
            EndContext();
            BeginContext(96, 15, false);
#line 7 "C:\Users\Randel\Epicodus\c#_projects\CretaceousPark.Solution\CretaceousClient\Views\Animals\Index.cshtml"
           Write(animal.AnimalId);

#line default
#line hidden
            EndContext();
            BeginContext(111, 25, true);
            WriteLiteral("</li>\r\n        <li>Name: ");
            EndContext();
            BeginContext(137, 11, false);
#line 8 "C:\Users\Randel\Epicodus\c#_projects\CretaceousPark.Solution\CretaceousClient\Views\Animals\Index.cshtml"
             Write(animal.Name);

#line default
#line hidden
            EndContext();
            BeginContext(148, 28, true);
            WriteLiteral("</li>\r\n        <li>Species: ");
            EndContext();
            BeginContext(177, 14, false);
#line 9 "C:\Users\Randel\Epicodus\c#_projects\CretaceousPark.Solution\CretaceousClient\Views\Animals\Index.cshtml"
                Write(animal.Species);

#line default
#line hidden
            EndContext();
            BeginContext(191, 24, true);
            WriteLiteral("</li>\r\n        <li>Age: ");
            EndContext();
            BeginContext(216, 10, false);
#line 10 "C:\Users\Randel\Epicodus\c#_projects\CretaceousPark.Solution\CretaceousClient\Views\Animals\Index.cshtml"
            Write(animal.Age);

#line default
#line hidden
            EndContext();
            BeginContext(226, 27, true);
            WriteLiteral("</li>\r\n        <li>Gender: ");
            EndContext();
            BeginContext(254, 13, false);
#line 11 "C:\Users\Randel\Epicodus\c#_projects\CretaceousPark.Solution\CretaceousClient\Views\Animals\Index.cshtml"
               Write(animal.Gender);

#line default
#line hidden
            EndContext();
            BeginContext(267, 24, true);
            WriteLiteral("</li>\r\n    </ul>\r\n    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 291, "\"", 333, 2);
            WriteAttributeValue("", 298, "/Animals/Details/", 298, 17, true);
#line 13 "C:\Users\Randel\Epicodus\c#_projects\CretaceousPark.Solution\CretaceousClient\Views\Animals\Index.cshtml"
WriteAttributeValue("", 315, animal.AnimalId, 315, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(334, 26, true);
            WriteLiteral("><p>View Details</p></a>\r\n");
            EndContext();
            BeginContext(460, 10, true);
            WriteLiteral("    <br>\r\n");
            EndContext();
#line 18 "C:\Users\Randel\Epicodus\c#_projects\CretaceousPark.Solution\CretaceousClient\Views\Animals\Index.cshtml"
}

#line default
#line hidden
            BeginContext(473, 11, true);
            WriteLiteral("</ol>\r\n\r\n\r\n");
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
