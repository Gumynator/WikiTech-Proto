#pragma checksum "C:\GitKraken\WikiTech-Proto\WikiTech\WikiTechWebApp\Views\Articles\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3105a0adf72f722438a85fe3492381a5aa3a5c98"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Articles_Index), @"mvc.1.0.view", @"/Views/Articles/Index.cshtml")]
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
#line 1 "C:\GitKraken\WikiTech-Proto\WikiTech\WikiTechWebApp\Views\_ViewImports.cshtml"
using WikiTechWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\GitKraken\WikiTech-Proto\WikiTech\WikiTechWebApp\Views\_ViewImports.cshtml"
using WikiTechWebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\GitKraken\WikiTech-Proto\WikiTech\WikiTechWebApp\Views\Articles\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\GitKraken\WikiTech-Proto\WikiTech\WikiTechWebApp\Views\Articles\Index.cshtml"
using WikiTechWebApp.Areas.Identity.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\GitKraken\WikiTech-Proto\WikiTech\WikiTechWebApp\Views\Articles\Index.cshtml"
using WikiTechWebApp.Views.Articles;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3105a0adf72f722438a85fe3492381a5aa3a5c98", @"/Views/Articles/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d1102c9b6673538f36e809ead68f4d91b7c784d", @"/Views/_ViewImports.cshtml")]
    public class Views_Articles_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WikiTechAPI.Models.Article>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ValidationScriptsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n");
#nullable restore
#line 17 "C:\GitKraken\WikiTech-Proto\WikiTech\WikiTechWebApp\Views\Articles\Index.cshtml"
  ViewData["Title"] = "View";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<!--\n <h1>Articles</h1>\n\n <a asp-action=\"Create\">Create New</a>\n</p>\n-->\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3105a0adf72f722438a85fe3492381a5aa3a5c985046", async() => {
                WriteLiteral("\n    <div class=\"container\">\n        <div class=\"row\">\n            <div class=\"col-md-3\">\n                <h4");
                BeginWriteAttribute("class", " class=\"", 821, "\"", 829, 0);
                EndWriteAttribute();
                WriteLiteral(@">Search</h4>
                <div class=""input-group"">
                    <input type=""text"" class=""form-control"" placeholder=""Search"" name=""srch-term"" id=""srch-term"">
                    <div class=""input-group-btn"">
                        <button class=""btn btn-default"" type=""submit"">
                            <i class=""glyphicon glyphicon-search""></i>
                        </button>
                    </div>
                </div>

                <div>
                    <hr>
                    <div class=""list-group list-group"">

                        <h4");
                BeginWriteAttribute("class", " class=\"", 1407, "\"", 1415, 0);
                EndWriteAttribute();
                WriteLiteral(" id=\"sections\">Catégorie</h4>\n                        <!--<a href=\"#\" class=\"list-group-item\"><span class=\"badge\">14</span> Upcoming Sessions</a>-->\n\n                        <hr");
                BeginWriteAttribute("class", " class=\"", 1593, "\"", 1601, 0);
                EndWriteAttribute();
                WriteLiteral(">\n                        <h4");
                BeginWriteAttribute("class", " class=\"", 1631, "\"", 1639, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""tags"">Tags (all) à devenir TOP 10</h4>
                        <!--<a href=""#"" class=""list-group-item""><span class=""badge"">3</span> Second item</a>-->

                    </div>
                </div>
                <div class=""hidden-sm hidden-xs"">
                    <hr>
                    <div class=""well"">

                        <h4>Membre Premium</h4>
                        <p>Accès explusif à un maximum d'article</p>
                        <button class=""btn btn-sm btn-warning"">Abonnement</button>
                        <hr>
");
#nullable restore
#line 61 "C:\GitKraken\WikiTech-Proto\WikiTech\WikiTechWebApp\Views\Articles\Index.cshtml"
                         if (!SignInManager.IsSignedIn(User))
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <p class=\"text-center \">Déjà Membre ? <a href=\"Identity/Account/Login\">Connexion</a></p>");
#nullable restore
#line 63 "C:\GitKraken\WikiTech-Proto\WikiTech\WikiTechWebApp\Views\Articles\Index.cshtml"
                                                                                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </div>
                </div>

            </div>
            <div class=""col-md-9"">

                <div class=""well hidden-xs"">

                    <div class=""row"">

                        <div class=""col-xs-4"">

                            <select class=""form-control"">
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3105a0adf72f722438a85fe3492381a5aa3a5c988443", async() => {
                    WriteLiteral("Ajouté récement");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3105a0adf72f722438a85fe3492381a5aa3a5c989496", async() => {
                    WriteLiteral("A-Z");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3105a0adf72f722438a85fe3492381a5aa3a5c9810537", async() => {
                    WriteLiteral("Z-A");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                            </select>\n                        </div>\n                    </div>\n                </div>\n                <hr>\n\n");
#nullable restore
#line 86 "C:\GitKraken\WikiTech-Proto\WikiTech\WikiTechWebApp\Views\Articles\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            <div class=""row"">
                <!-- <div class=""col-sm-4"">
        <a href=""#"" class=""""><img src=""http://placehold.it/1280X720"" class=""img-responsive""></a>
    </div>-->
                <div class=""col-sm-8"">
                    <h3 class=""title"">");
#nullable restore
#line 93 "C:\GitKraken\WikiTech-Proto\WikiTech\WikiTechWebApp\Views\Articles\Index.cshtml"
                                 Write(Html.DisplayFor(modelItem => item.TitreArticle));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\n");
#nullable restore
#line 94 "C:\GitKraken\WikiTech-Proto\WikiTech\WikiTechWebApp\Views\Articles\Index.cshtml"
                     if (item.IsqualityArticle == false)
                    {    // la fonction d'affichage de date sera gérée avec la validation d'article puisque c'est une date de publication

#line default
#line hidden
#nullable disable
                WriteLiteral("            <p class=\"text-muted\"><span class=\"glyphicon glyphicon-calendar\"></span> ");
#nullable restore
#line 96 "C:\GitKraken\WikiTech-Proto\WikiTech\WikiTechWebApp\Views\Articles\Index.cshtml"
                                                                                Write(Html.DisplayFor(modelItem => item.DatepublicationArticle));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p> ");
#nullable restore
#line 96 "C:\GitKraken\WikiTech-Proto\WikiTech\WikiTechWebApp\Views\Articles\Index.cshtml"
                                                                                                                                                    }
        else
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <p class=\"text-muted\"><span class=\"glyphicon glyphicon-lock\"></span>Contenu réservé au premium</p>");
#nullable restore
#line 99 "C:\GitKraken\WikiTech-Proto\WikiTech\WikiTechWebApp\Views\Articles\Index.cshtml"
                                                                                                              }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    <p>");
#nullable restore
#line 101 "C:\GitKraken\WikiTech-Proto\WikiTech\WikiTechWebApp\Views\Articles\Index.cshtml"
                  Write(Html.DisplayFor(modelItem => item.DescriptionArticle));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n                    <p class=\"text-muted\">Rédigé par <a");
                BeginWriteAttribute("href", " href=\"", 3987, "\"", 4044, 2);
                WriteAttributeValue("", 3994, "AspNetUsers/", 3994, 12, true);
#nullable restore
#line 102 "C:\GitKraken\WikiTech-Proto\WikiTech\WikiTechWebApp\Views\Articles\Index.cshtml"
WriteAttributeValue("", 4006, Html.DisplayFor(modelItem => item.Id), 4006, 38, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 102 "C:\GitKraken\WikiTech-Proto\WikiTech\WikiTechWebApp\Views\Articles\Index.cshtml"
                                                                                                             Write(Html.DisplayFor(modelItem => item.IdNavigation.PrenomAspnetuser));

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></p>\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3105a0adf72f722438a85fe3492381a5aa3a5c9815403", async() => {
                    WriteLiteral("->Consulter");
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
#line 103 "C:\GitKraken\WikiTech-Proto\WikiTech\WikiTechWebApp\Views\Articles\Index.cshtml"
                                              WriteLiteral(item.IdArticle);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                </div>\n            </div>\n");
                WriteLiteral("                            <hr>");
#nullable restore
#line 107 "C:\GitKraken\WikiTech-Proto\WikiTech\WikiTechWebApp\Views\Articles\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                <nav aria-label=""Page navigation example"">
        <ul class=""pagination"">
            <li class=""page-item"">
                <a class=""page-link"" href=""#"" aria-label=""Previous"">
                    <span aria-hidden=""true"">&laquo;</span>
                    <span class=""sr-only"">Previous</span>
                </a>
            </li>
            <li class=""page-item""><a class=""page-link"" href=""#"">1</a></li>
            <li class=""page-item""><a class=""page-link"" href=""#"">2</a></li>
            <li class=""page-item""><a class=""page-link"" href=""#"">3</a></li>
            <li class=""page-item"">
                <a class=""page-link"" href=""#"" aria-label=""Next"">
                    <span aria-hidden=""true"">&raquo;</span>
                    <span class=""sr-only"">Next</span>
                </a>
            </li>
        </ul>
    </nav>
            </div>
        </div>
    </div>

    <br>
    <br>
");
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
            WriteLiteral("\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3105a0adf72f722438a85fe3492381a5aa3a5c9819778", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
            }
            );
            WriteLiteral(@"
<script>

    $(document).ready(function () {
        getTags();
        getSection();

    }
    )
    function getTags() {
        $.ajax(
            {
                url: ""http://localhost:59601/Api/Tags/"",
                type: ""GET"",
                dataType: ""JSON"",
                contentType: ""application/json"",
                success: function (data) {
                    console.log(data);
                    createTagSelect(data);
                }
            });
    }

    function createTagSelect(data) {
        var select = $(""#tags"");

        $.each(data, function (key, value) {
            console.log(value);
            var element = ""<a href=\""tags/"" + value.idTag + ""\"" class=\""list-group-item\""><span class=\""badge\"">nb</span>"" + value.nomTag + ""</a>"";
            select.append(element);
        })
    }

    function getSection() {
        $.ajax(
            {
                url: ""http://localhost:59601/Api/Sections"",
                type: ""GET"",
                dataType: ""JSON"",
  ");
            WriteLiteral(@"              contentType: ""application/json"",
                success: function (data) {
                    console.log(data);
                    createSectionSelect(data);
                }
            });
    }

    function createSectionSelect(data) {
        var select = $(""#sections"");

        $.each(data, function (key, value) {
            console.log(value);
            var element = ""<a href=\""sections/"" + value.idSection + ""\"" class=\""list-group-item\""><span class=\""badge\"">nb</span>"" + value.nomSection + ""</a>"";
            select.append(element);
        })
    }
</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WikiTechAPI.Models.Article>> Html { get; private set; }
    }
}
#pragma warning restore 1591
