#pragma checksum "C:\Users\BERK\source\repos\ECommerceApp\ECommerceApp.WebUI\Views\Shared\_slider.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b6bb0fcd5ebfe3ab8db3e5ed7a72fadfa28ba6d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__slider), @"mvc.1.0.view", @"/Views/Shared/_slider.cshtml")]
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
#line 1 "C:\Users\BERK\source\repos\ECommerceApp\ECommerceApp.WebUI\Views\_ViewImports.cshtml"
using ECommerceApp.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\BERK\source\repos\ECommerceApp\ECommerceApp.WebUI\Views\_ViewImports.cshtml"
using ECommerceApp.WebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b6bb0fcd5ebfe3ab8db3e5ed7a72fadfa28ba6d", @"/Views/Shared/_slider.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1f263cd437206bf9eb5238581e7c04d14acf753", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__slider : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div id=""mySlider"" class=""carousel slide"" data-ride=""carousel"">
    <ol class=""carousel-indicators"">
        <li data-target=""#mySlider"" data-slide-to=""0"" class=""active""></li>
        <li data-target=""#mySlider"" data-slide-to=""1""></li>
        <li data-target=""#mySlider"" data-slide-to=""2""></li>
    </ol>
    <div class=""carousel-inner"">
        <div class=""carousel-item active"">
            <img src=""/img/1.png"" class=""d-block img-fluid"" />
        </div>
        <div class=""carousel-item"">
            <img src=""/img/2.png"" class=""d-block img-fluid"" />
        </div>
        <div class=""carousel-item"">
            <img src=""/img/3.png"" class=""d-block img-fluid"" />
        </div>
    </div>
    <a href=""#mySlider"" data-slide=""prev"" class=""carousel-control-prev"">
        <span class=""carousel-control-prev-icon""></span>
    </a>
    <a href=""#mySlider"" data-slide=""next"" class=""carousel-control-next"">
        <span class=""carousel-control-next-icon""></span>
    </a>
</div>");
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
