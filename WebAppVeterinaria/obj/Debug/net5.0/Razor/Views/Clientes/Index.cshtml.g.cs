#pragma checksum "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Clientes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37d9c26c602be669f8179391b49b00e37270302f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clientes_Index), @"mvc.1.0.view", @"/Views/Clientes/Index.cshtml")]
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
#line 1 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\_ViewImports.cshtml"
using WebAppVeterinaria;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\_ViewImports.cshtml"
using WebAppVeterinaria.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Clientes\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37d9c26c602be669f8179391b49b00e37270302f", @"/Views/Clientes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8696af2e76fcfe31055f781a5a8bebe552b26035", @"/Views/_ViewImports.cshtml")]
    public class Views_Clientes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.PagedList<WebAppVeterinaria.Entity.Cliente>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("align-self-center mt-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary text-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mt-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "clientes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Clientes\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"top-padding background-content vh-100\">\r\n    <div class=\"container\">\r\n        <h3 class=\"text-color-primary mt-1\">Lista de Clientes</h3>\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37d9c26c602be669f8179391b49b00e37270302f6653", async() => {
                WriteLiteral("\r\n            <div class=\"row\">\r\n                <div class=\"col-md-8\">\r\n                    <p class=\"form-inline\">\r\n                        <input type=\"search\" name=\"search\"");
                BeginWriteAttribute("value", " value=\"", 555, "\"", 578, 1);
#nullable restore
#line 16 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Clientes\Index.cshtml"
WriteAttributeValue("", 563, ViewBag.Search, 563, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Pesquise por Nome...\" style=\"width:80%\" class=\"form-control\" />\r\n                        <button type=\"submit\" name=\"name\"");
                BeginWriteAttribute("value", " value=\"", 715, "\"", 723, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-success\"><i class=\"fas fa-search\"></i></button>\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37d9c26c602be669f8179391b49b00e37270302f7884", async() => {
                    WriteLiteral("Limpar pesquisa");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </p>\r\n                    \r\n                </div>\r\n                <div class=\"col-md-4\">\r\n                    <div class=\"text-right\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37d9c26c602be669f8179391b49b00e37270302f9395", async() => {
                    WriteLiteral("<i class=\"fas fa-user-plus\"></i> Novo Cliente");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n        <table class=\"table shadow p-3 rounded\">\r\n            <thead class=\"table-light bg-light rounded text-color-secondary\">\r\n                <tr>\r\n                    <th>\r\n                        ");
#nullable restore
#line 34 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Clientes\Index.cshtml"
                   Write(Html.DisplayName("Nome Completo"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 37 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Clientes\Index.cshtml"
                   Write(Html.DisplayName("CPF"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 40 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Clientes\Index.cshtml"
                   Write(Html.DisplayName("Celular"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 43 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Clientes\Index.cshtml"
                   Write(Html.DisplayName("Status"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 46 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Clientes\Index.cshtml"
                   Write(Html.DisplayName("Cidade"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 49 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Clientes\Index.cshtml"
                   Write(Html.DisplayName("Estado"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody class=\"bg-light text-color-primary\">\r\n");
#nullable restore
#line 55 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Clientes\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n\r\n                        <td>\r\n                            ");
#nullable restore
#line 60 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Clientes\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.NomeCompleto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 63 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Clientes\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Cpf));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 66 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Clientes\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Celular));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n");
#nullable restore
#line 69 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Clientes\Index.cshtml"
                             if (item.Ativo == true)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"shadow-sm\" style=\"background-color:#4f794e; text-align:center; border-radius:25px; color:aliceblue\">\r\n                                    <small>ATIVO</small>\r\n                                </div>\r\n");
#nullable restore
#line 74 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Clientes\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"shadow-sm\" style=\"background-color:#b25454; text-align:center; border-radius:25px; color:aliceblue\">\r\n                                    <small>INATIVO</small>\r\n                                </div>\r\n");
#nullable restore
#line 80 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Clientes\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 83 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Clientes\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Cidade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 86 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Clientes\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 89 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Clientes\Index.cshtml"
                       Write(Html.ActionLink("", "Edit", new { item.Id }, new { @class = "btn btn-light bg-white fas fa-pen p-2 shadow-sm text-warning" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 90 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Clientes\Index.cshtml"
                       Write(Html.ActionLink("", "Details", new { item.Id }, new { @class = "btn btn-light bg-white fas fa-search p-2 shadow-sm text-info" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 91 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Clientes\Index.cshtml"
                       Write(Html.ActionLink("", "Delete", new { item.Id }, new { @class = "btn btn-light bg-white fas fa-trash-alt p-2 shadow-sm text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 94 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Clientes\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n        <div class=\"col-md-6\">\r\n            Listando registros de ");
#nullable restore
#line 98 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Clientes\Index.cshtml"
                             Write(Model.FirstItemOnPage);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            a ");
#nullable restore
#line 99 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Clientes\Index.cshtml"
         Write(Model.LastItemOnPage);

#line default
#line hidden
#nullable disable
            WriteLiteral(" de um total de ");
#nullable restore
#line 99 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Clientes\Index.cshtml"
                                              Write(Model.TotalItemCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-6\">\r\n            ");
#nullable restore
#line 102 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Clientes\Index.cshtml"
       Write(Html.PagedListPager(Model,
                             page => Url.Action("Index", new { page })));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.PagedList<WebAppVeterinaria.Entity.Cliente>> Html { get; private set; }
    }
}
#pragma warning restore 1591
