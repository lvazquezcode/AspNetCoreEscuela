#pragma checksum "D:\Desarrollo\Cursos\DotNetCore\Ejemplos\AspNetCore\MvcWebTest\Views\Curso\ListaCursos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6139c92903cf22347c957e13472d38a7e8c287b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Curso_ListaCursos), @"mvc.1.0.view", @"/Views/Curso/ListaCursos.cshtml")]
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
#line 1 "D:\Desarrollo\Cursos\DotNetCore\Ejemplos\AspNetCore\MvcWebTest\Views\_ViewImports.cshtml"
using MvcWebTest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Desarrollo\Cursos\DotNetCore\Ejemplos\AspNetCore\MvcWebTest\Views\_ViewImports.cshtml"
using MvcWebTest.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6139c92903cf22347c957e13472d38a7e8c287b1", @"/Views/Curso/ListaCursos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7d06a9e417ccc9d9ff4dfa4cb1e3b11a4d2ca71", @"/Views/_ViewImports.cshtml")]
    public class Views_Curso_ListaCursos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Curso>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Desarrollo\Cursos\DotNetCore\Ejemplos\AspNetCore\MvcWebTest\Views\Curso\ListaCursos.cshtml"
  
    ViewData["Titulo"] = "Información Curso";
    Layout = "Template_Simple";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 8 "D:\Desarrollo\Cursos\DotNetCore\Ejemplos\AspNetCore\MvcWebTest\Views\Curso\ListaCursos.cshtml"
Write(ViewData["Titulo"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<strong>Desde la la vista parcial</strong>\r\n<br>\r\n<a class=\"btn btn-primary\" href=\"/Curso/Create\">Nuevo</a>\r\n<br>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6139c92903cf22347c957e13472d38a7e8c287b14249", async() => {
                WriteLiteral(@"
    <table class=""table table-hover"">
        <thead>
            <tr>
                <th scope=""col"">#</th>
                <th scope=""col"">Nombre</th>
                <th scope=""col"">Id</th>
                <th scope=""col"">Editar</th>
                <th scope=""col"">Eliminar</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 26 "D:\Desarrollo\Cursos\DotNetCore\Ejemplos\AspNetCore\MvcWebTest\Views\Curso\ListaCursos.cshtml"
              
                int cont = 1;
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "D:\Desarrollo\Cursos\DotNetCore\Ejemplos\AspNetCore\MvcWebTest\Views\Curso\ListaCursos.cshtml"
             foreach (var curso in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 32 "D:\Desarrollo\Cursos\DotNetCore\Ejemplos\AspNetCore\MvcWebTest\Views\Curso\ListaCursos.cshtml"
                   Write(cont);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 33 "D:\Desarrollo\Cursos\DotNetCore\Ejemplos\AspNetCore\MvcWebTest\Views\Curso\ListaCursos.cshtml"
                   Write(curso.Nombre);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 34 "D:\Desarrollo\Cursos\DotNetCore\Ejemplos\AspNetCore\MvcWebTest\Views\Curso\ListaCursos.cshtml"
                   Write(curso.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td><a class=\"btn btn-primary\"");
                BeginWriteAttribute("href", " href=\"", 945, "\"", 975, 2);
                WriteAttributeValue("", 952, "/Curso/Update/", 952, 14, true);
#nullable restore
#line 35 "D:\Desarrollo\Cursos\DotNetCore\Ejemplos\AspNetCore\MvcWebTest\Views\Curso\ListaCursos.cshtml"
WriteAttributeValue("", 966, curso.Id, 966, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Update</a></td>\r\n                    <td><input class=\"btn btn-danger\" type=\"submit\" value=\"Delete\"></td>\r\n                </tr>\r\n");
#nullable restore
#line 38 "D:\Desarrollo\Cursos\DotNetCore\Ejemplos\AspNetCore\MvcWebTest\Views\Curso\ListaCursos.cshtml"
                cont++;
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n    <p><i>");
#nullable restore
#line 43 "D:\Desarrollo\Cursos\DotNetCore\Ejemplos\AspNetCore\MvcWebTest\Views\Curso\ListaCursos.cshtml"
     Write(ViewBag.Fecha);

#line default
#line hidden
#nullable disable
                WriteLiteral("</i></p>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Curso>> Html { get; private set; }
    }
}
#pragma warning restore 1591
