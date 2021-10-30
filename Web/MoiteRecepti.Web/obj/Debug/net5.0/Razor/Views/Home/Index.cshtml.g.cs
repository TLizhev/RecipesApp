#pragma checksum "C:\Users\fostata\Source\Repos\RecipeApp\Web\MoiteRecepti.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9b3092ce2f270f4f90b0b3a113bab2af016b570"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\fostata\Source\Repos\RecipeApp\Web\MoiteRecepti.Web\Views\_ViewImports.cshtml"
using MoiteRecepti.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\fostata\Source\Repos\RecipeApp\Web\MoiteRecepti.Web\Views\_ViewImports.cshtml"
using MoiteRecepti.Web.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\fostata\Source\Repos\RecipeApp\Web\MoiteRecepti.Web\Views\Home\Index.cshtml"
using MoiteRecepti.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9b3092ce2f270f4f90b0b3a113bab2af016b570", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8dcad4bea33db1a082fdf2a6517a3aea2eb20ca4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MoiteRecepti.Web.ViewModels.Home.IndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Recipes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ById", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "C:\Users\fostata\Source\Repos\RecipeApp\Web\MoiteRecepti.Web\Views\Home\Index.cshtml"
  
    this.ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"text-center row\">\n    <h1 class=\"display-4\">Welcome to ");
#nullable restore
#line 8 "C:\Users\fostata\Source\Repos\RecipeApp\Web\MoiteRecepti.Web\Views\Home\Index.cshtml"
                                Write(GlobalConstants.SystemName);

#line default
#line hidden
#nullable disable
            WriteLiteral("!</h1>\n    <div class=\"col-md-8\">\n        <div class=\"row\">\n");
#nullable restore
#line 11 "C:\Users\fostata\Source\Repos\RecipeApp\Web\MoiteRecepti.Web\Views\Home\Index.cshtml"
             foreach (var recipe in this.Model.RandomRecipes)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"card col-md-6\">\n                    <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 449, "\"", 471, 1);
#nullable restore
#line 14 "C:\Users\fostata\Source\Repos\RecipeApp\Web\MoiteRecepti.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 455, recipe.ImageUrl, 455, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 472, "\"", 490, 1);
#nullable restore
#line 14 "C:\Users\fostata\Source\Repos\RecipeApp\Web\MoiteRecepti.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 478, recipe.Name, 478, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                    <div class=\"card-body\">\n                        <h5 class=\"card-title\">");
#nullable restore
#line 16 "C:\Users\fostata\Source\Repos\RecipeApp\Web\MoiteRecepti.Web\Views\Home\Index.cshtml"
                                          Write(recipe.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                        <p class=\"card-text\">");
#nullable restore
#line 17 "C:\Users\fostata\Source\Repos\RecipeApp\Web\MoiteRecepti.Web\Views\Home\Index.cshtml"
                                        Write(recipe.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e9b3092ce2f270f4f90b0b3a113bab2af016b5706675", async() => {
                WriteLiteral("Go to recipe");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 18 "C:\Users\fostata\Source\Repos\RecipeApp\Web\MoiteRecepti.Web\Views\Home\Index.cshtml"
                                                                        WriteLiteral(recipe.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    </div>\n                </div>\n");
#nullable restore
#line 21 "C:\Users\fostata\Source\Repos\RecipeApp\Web\MoiteRecepti.Web\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n    </div>\n    <div class=\"col-md-4\">\n        <p>We have:</p>\n        <ul class=\"list-group\">\n            <li class=\"list-group-item bg-info\">Recipes: ");
#nullable restore
#line 27 "C:\Users\fostata\Source\Repos\RecipeApp\Web\MoiteRecepti.Web\Views\Home\Index.cshtml"
                                                    Write(Model.RecipesCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n            <li class=\"list-group-item bg-light\">Categories: ");
#nullable restore
#line 28 "C:\Users\fostata\Source\Repos\RecipeApp\Web\MoiteRecepti.Web\Views\Home\Index.cshtml"
                                                        Write(Model.CategoriesCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n            <li class=\"list-group-item bg-info\">Images: ");
#nullable restore
#line 29 "C:\Users\fostata\Source\Repos\RecipeApp\Web\MoiteRecepti.Web\Views\Home\Index.cshtml"
                                                   Write(Model.ImagesCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n            <li class=\"list-group-item bg-light\">Ingredients: ");
#nullable restore
#line 30 "C:\Users\fostata\Source\Repos\RecipeApp\Web\MoiteRecepti.Web\Views\Home\Index.cshtml"
                                                         Write(Model.IngredientsCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n        </ul>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MoiteRecepti.Web.ViewModels.Home.IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
