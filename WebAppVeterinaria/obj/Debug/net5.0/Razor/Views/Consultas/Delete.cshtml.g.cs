#pragma checksum "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Consultas\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4eedb06a7ebe14de141bc365a6494decd148046e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Consultas_Delete), @"mvc.1.0.view", @"/Views/Consultas/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4eedb06a7ebe14de141bc365a6494decd148046e", @"/Views/Consultas/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8696af2e76fcfe31055f781a5a8bebe552b26035", @"/Views/_ViewImports.cshtml")]
    public class Views_Consultas_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebAppVeterinaria.Entity.Consulta>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Consultas\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""top-padding background-content vh-100"">
    <div class=""container"">

        <div style=""background-color:white; width:100%; display:flex; padding:40px; flex-wrap:wrap;"" class=""shadow-sm"">
            <h1>Excluir</h1>

            <div class=""col-md-12"">
                <h3 class=""alert-danger"">Você tem certeza que deseja excluir esta consulta?</h3>
            </div>

            <div>
                <hr />
                <dl class=""row"">
                    <dt class=""col-sm-2"">
                        ");
#nullable restore
#line 21 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Consultas\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.DataCadastro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 24 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Consultas\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.DataCadastro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 27 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Consultas\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.DataConsulta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 30 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Consultas\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.DataConsulta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 33 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Consultas\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.DataRetorno));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 36 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Consultas\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.DataRetorno));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 39 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Consultas\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.Descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 42 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Consultas\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.Descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 45 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Consultas\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.Retorno));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 48 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Consultas\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.Retorno));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 51 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Consultas\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.Observacao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 54 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Consultas\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.Observacao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 57 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Consultas\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.NomeAnimal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 60 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Consultas\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.NomeAnimal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 63 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Consultas\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.RacaAnimal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 66 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Consultas\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.RacaAnimal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 69 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Consultas\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.TipoSexo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n");
#nullable restore
#line 72 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Consultas\Delete.cshtml"
                         if (Model.TipoSexo.ToString() == "1")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div>\r\n                                <h6>Macho</h6>\r\n                            </div>\r\n");
#nullable restore
#line 77 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Consultas\Delete.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div>\r\n                                <h6>Fêmea</h6>\r\n                            </div>\r\n");
#nullable restore
#line 83 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Consultas\Delete.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 86 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Consultas\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.TipoEspecie));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n");
#nullable restore
#line 89 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Consultas\Delete.cshtml"
                         if (Model.TipoEspecie.ToString() == "1")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div>\r\n                                <h6>Canina</h6>\r\n                            </div>\r\n");
#nullable restore
#line 94 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Consultas\Delete.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div>\r\n                                <h6>Felino</h6>\r\n                            </div>\r\n");
#nullable restore
#line 100 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Consultas\Delete.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 103 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Consultas\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.Idade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 106 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Consultas\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.Idade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 109 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Consultas\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.Peso));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 112 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Consultas\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.Peso));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 115 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Consultas\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.HistoricoClinicoAnimal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 118 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Consultas\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.HistoricoClinicoAnimal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 121 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Consultas\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.ClienteId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 124 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Consultas\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.ClienteId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 127 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Consultas\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.VeterinarioId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 130 "C:\Users\aalve\source\repos\WebAppVeterinaria\WebAppVeterinaria\Views\Consultas\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.VeterinarioId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                </dl>\r\n\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4eedb06a7ebe14de141bc365a6494decd148046e18234", async() => {
                WriteLiteral("\r\n                    <input type=\"submit\" value=\"Excluir\" class=\"btn btn-danger\" />\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4eedb06a7ebe14de141bc365a6494decd148046e18605", async() => {
                    WriteLiteral("Voltar");
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
                WriteLiteral("\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebAppVeterinaria.Entity.Consulta> Html { get; private set; }
    }
}
#pragma warning restore 1591
