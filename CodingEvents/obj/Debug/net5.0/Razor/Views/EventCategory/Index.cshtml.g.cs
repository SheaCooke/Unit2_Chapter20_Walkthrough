#pragma checksum "C:\Users\Shea Cooke\Desktop\LaunchCode\C#_Web_Development\Unit2_Chapter20_Walkthrough\Unit2_Chapter20_Walkthrough\CodingEvents\Views\EventCategory\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39186fa02bd215d22f82cedfe39502b47fd0b752"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EventCategory_Index), @"mvc.1.0.view", @"/Views/EventCategory/Index.cshtml")]
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
#line 1 "C:\Users\Shea Cooke\Desktop\LaunchCode\C#_Web_Development\Unit2_Chapter20_Walkthrough\Unit2_Chapter20_Walkthrough\CodingEvents\Views\_ViewImports.cshtml"
using CodingEvents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Shea Cooke\Desktop\LaunchCode\C#_Web_Development\Unit2_Chapter20_Walkthrough\Unit2_Chapter20_Walkthrough\CodingEvents\Views\_ViewImports.cshtml"
using CodingEvents.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39186fa02bd215d22f82cedfe39502b47fd0b752", @"/Views/EventCategory/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc2964dd59c32e4df324b99d9423fb70affcb2b3", @"/Views/_ViewImports.cshtml")]
    public class Views_EventCategory_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EventCategory>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Event Category</h1>\r\n\r\n\r\n\r\n            \r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th scope=\"col\">#</th>\r\n            <th scope=\"col\">Name</th>\r\n\r\n\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 23 "C:\Users\Shea Cooke\Desktop\LaunchCode\C#_Web_Development\Unit2_Chapter20_Walkthrough\Unit2_Chapter20_Walkthrough\CodingEvents\Views\EventCategory\Index.cshtml"
         foreach (var meeting in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n\r\n\r\n\r\n                <td>");
#nullable restore
#line 29 "C:\Users\Shea Cooke\Desktop\LaunchCode\C#_Web_Development\Unit2_Chapter20_Walkthrough\Unit2_Chapter20_Walkthrough\CodingEvents\Views\EventCategory\Index.cshtml"
               Write(meeting.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 30 "C:\Users\Shea Cooke\Desktop\LaunchCode\C#_Web_Development\Unit2_Chapter20_Walkthrough\Unit2_Chapter20_Walkthrough\CodingEvents\Views\EventCategory\Index.cshtml"
               Write(meeting.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n\r\n\r\n\r\n\r\n            </tr>\r\n");
#nullable restore
#line 38 "C:\Users\Shea Cooke\Desktop\LaunchCode\C#_Web_Development\Unit2_Chapter20_Walkthrough\Unit2_Chapter20_Walkthrough\CodingEvents\Views\EventCategory\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EventCategory>> Html { get; private set; }
    }
}
#pragma warning restore 1591
