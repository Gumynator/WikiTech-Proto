#pragma checksum "D:\ES\2eme\GlobalWiki\Conception\WikiTech-Proto\APIPrototype\APIPrototype\Views\Villes\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63b7f3f55365925136e07197cd0c06d957963257"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Villes_Create), @"mvc.1.0.view", @"/Views/Villes/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63b7f3f55365925136e07197cd0c06d957963257", @"/Views/Villes/Create.cshtml")]
    public class Views_Villes_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<APIPrototype.Models.Ville>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\ES\2eme\GlobalWiki\Conception\WikiTech-Proto\APIPrototype\APIPrototype\Views\Villes\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>Ville</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""NomVille"" class=""control-label""></label>
                <input asp-for=""NomVille"" class=""form-control"" />
                <span asp-validation-for=""NomVille"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""CodeVille"" class=""control-label""></label>
                <input asp-for=""CodeVille"" class=""form-control"" />
                <span asp-validation-for=""CodeVille"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 37 "D:\ES\2eme\GlobalWiki\Conception\WikiTech-Proto\APIPrototype\APIPrototype\Views\Villes\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<APIPrototype.Models.Ville> Html { get; private set; }
    }
}
#pragma warning restore 1591
