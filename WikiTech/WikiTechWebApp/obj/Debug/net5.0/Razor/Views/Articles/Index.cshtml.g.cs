#pragma checksum "C:\GitKraken\WikiTech-Proto\WikiTech\WikiTechWebApp\Views\Articles\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "533cb64759e2872e0df26925a7f81e2b78c15346"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"533cb64759e2872e0df26925a7f81e2b78c15346", @"/Views/Articles/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d1102c9b6673538f36e809ead68f4d91b7c784d", @"/Views/_ViewImports.cshtml")]
    public class Views_Articles_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WikiTechAPI.Models.Article>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ValidationScriptsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 15 "C:\GitKraken\WikiTech-Proto\WikiTech\WikiTechWebApp\Views\Articles\Index.cshtml"
  ViewData["Title"] = "View";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<h1>Articles</h1>\n\n<p>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "533cb64759e2872e0df26925a7f81e2b78c153465095", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</p>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "533cb64759e2872e0df26925a7f81e2b78c153466258", async() => {
                WriteLiteral("\n    <div class=\"container\">\n        <div class=\"row\">\n            <div class=\"col-md-3\">\n                <h4");
                BeginWriteAttribute("class", " class=\"", 732, "\"", 740, 0);
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
                BeginWriteAttribute("class", " class=\"", 1319, "\"", 1327, 0);
                EndWriteAttribute();
                WriteLiteral(" id=\"sections\">Catégorie</h4>\n                        <!--<a href=\"#\" class=\"list-group-item\"><span class=\"badge\">14</span> Upcoming Sessions</a>-->\n\n                        <hr");
                BeginWriteAttribute("class", " class=\"", 1505, "\"", 1513, 0);
                EndWriteAttribute();
                WriteLiteral(">\n                        <h4");
                BeginWriteAttribute("class", " class=\"", 1543, "\"", 1551, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""tags"">Tags (all) à devenir TOP 10</h4>
                        <!--<a href=""#"" class=""list-group-item""><span class=""badge"">3</span> Second item</a>-->

                    </div>
                </div>

                <div class=""hidden-sm hidden-xs"">
                    <hr>
                    <div class=""well"">

                        <h4>Premium Membership</h4>
                        <p>Gain unlimited access to our entire course library.</p>
                        <button class=""btn btn-sm btn-warning"">Learn more</button>
                        <hr>
                        <p class=""text-center "">Already a member? <a href=""Identity/Account/Login"">Connexion</a></p>
                    </div>
                </div>

            </div>
            <div class=""col-md-9"">

                <div class=""well hidden-xs"">

                    <div class=""row"">

                        <div class=""col-xs-4"">

                            <select class=""form-control"">
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "533cb64759e2872e0df26925a7f81e2b78c153469109", async() => {
                    WriteLiteral("Featured");
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "533cb64759e2872e0df26925a7f81e2b78c1534610155", async() => {
                    WriteLiteral("Recently Added");
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "533cb64759e2872e0df26925a7f81e2b78c1534611208", async() => {
                    WriteLiteral("Next Upcoming Session");
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "533cb64759e2872e0df26925a7f81e2b78c1534612268", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "533cb64759e2872e0df26925a7f81e2b78c1534613310", async() => {
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
#line 85 "C:\GitKraken\WikiTech-Proto\WikiTech\WikiTechWebApp\Views\Articles\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    <div class=""row"">
                        <!-- <div class=""col-sm-4"">
                                <a href=""#"" class=""""><img src=""http://placehold.it/1280X720"" class=""img-responsive""></a>
                            </div>-->
                        <div class=""col-sm-8"">
                            <h3 class=""title"">");
#nullable restore
#line 92 "C:\GitKraken\WikiTech-Proto\WikiTech\WikiTechWebApp\Views\Articles\Index.cshtml"
                                         Write(Html.DisplayFor(modelItem => item.TitreArticle));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\n");
#nullable restore
#line 93 "C:\GitKraken\WikiTech-Proto\WikiTech\WikiTechWebApp\Views\Articles\Index.cshtml"
                             if (SignInManager.IsSignedIn(User))
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <p class=\"text-muted\"><span class=\"glyphicon glyphicon-calendar\"></span>Le : ");
#nullable restore
#line 95 "C:\GitKraken\WikiTech-Proto\WikiTech\WikiTechWebApp\Views\Articles\Index.cshtml"
                                                                                                        Write(Html.DisplayFor(modelItem => item.DatepublicationArticle));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n");
#nullable restore
#line 96 "C:\GitKraken\WikiTech-Proto\WikiTech\WikiTechWebApp\Views\Articles\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <p class=\"text-muted\"><span class=\"glyphicon glyphicon-lock\"></span>Contenu réservé au premium</p>\n");
#nullable restore
#line 100 "C:\GitKraken\WikiTech-Proto\WikiTech\WikiTechWebApp\Views\Articles\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                            <p>");
#nullable restore
#line 102 "C:\GitKraken\WikiTech-Proto\WikiTech\WikiTechWebApp\Views\Articles\Index.cshtml"
                          Write(Html.DisplayFor(modelItem => item.DescriptionArticle));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n                            <p class=\"text-muted\">Rédigé par <a");
                BeginWriteAttribute("href", " href=\"", 4110, "\"", 4167, 2);
                WriteAttributeValue("", 4117, "AspNetUsers/", 4117, 12, true);
#nullable restore
#line 103 "C:\GitKraken\WikiTech-Proto\WikiTech\WikiTechWebApp\Views\Articles\Index.cshtml"
WriteAttributeValue("", 4129, Html.DisplayFor(modelItem => item.Id), 4129, 38, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 103 "C:\GitKraken\WikiTech-Proto\WikiTech\WikiTechWebApp\Views\Articles\Index.cshtml"
                                                                                                                     Write(Html.DisplayFor(modelItem => item.IdNavigation.PrenomAspnetuser));

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></p>\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "533cb64759e2872e0df26925a7f81e2b78c1534618114", async() => {
                    WriteLiteral("->Consulter");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 104 "C:\GitKraken\WikiTech-Proto\WikiTech\WikiTechWebApp\Views\Articles\Index.cshtml"
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
                WriteLiteral("\n                        </div>\n                    </div>\n                    <hr>\n");
#nullable restore
#line 108 "C:\GitKraken\WikiTech-Proto\WikiTech\WikiTechWebApp\Views\Articles\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                <ul class=""pagination pagination-lg pull-right"">
                    <li><a href=""#"">«</a></li>
                    <li class=""active""><a href=""#"">1</a></li>
                    <li><a href=""#"">2</a></li>
                    <li><a href=""#"">3</a></li>
                    <li><a href=""#"">4</a></li>
                    <li><a href=""#"">5</a></li>
                    <li><a href=""#"">»</a></li>
                </ul>
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "533cb64759e2872e0df26925a7f81e2b78c1534622005", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
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
                url: ""http://localhost:59601/Api/Tags"",
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
            WriteLiteral(@"             contentType: ""application/json"",
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
