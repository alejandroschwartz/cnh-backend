#pragma checksum "C:\Users\Augusto D.j\Desktop\CNH\ApiCNH\ApiCNH\Views\Mediciones\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fba6da207fa7a1c876fa461f946f8e600bd18276"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Mediciones_Edit), @"mvc.1.0.view", @"/Views/Mediciones/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fba6da207fa7a1c876fa461f946f8e600bd18276", @"/Views/Mediciones/Edit.cshtml")]
    public class Views_Mediciones_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ApiCNH.Models.Mediciones>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Augusto D.j\Desktop\CNH\ApiCNH\ApiCNH\Views\Mediciones\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Edit</h1>

<h4>Mediciones</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""Id"" />
            <div class=""form-group"">
                <label asp-for=""Maquina"" class=""control-label""></label>
                <input asp-for=""Maquina"" class=""form-control"" />
                <span asp-validation-for=""Maquina"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Medicion"" class=""control-label""></label>
                <input asp-for=""Medicion"" class=""form-control"" />
                <span asp-validation-for=""Medicion"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Descripcion"" class=""control-label""></label>
                <input asp-for=""Descripcion"" class=""form-control"" />
                <span a");
            WriteLiteral(@"sp-validation-for=""Descripcion"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Save"" class=""btn btn-primary"" />
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
#line 43 "C:\Users\Augusto D.j\Desktop\CNH\ApiCNH\ApiCNH\Views\Mediciones\Edit.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ApiCNH.Models.Mediciones> Html { get; private set; }
    }
}
#pragma warning restore 1591
