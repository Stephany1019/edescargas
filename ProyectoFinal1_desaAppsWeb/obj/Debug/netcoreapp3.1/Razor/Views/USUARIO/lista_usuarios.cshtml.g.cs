#pragma checksum "D:\VisualStudio projects\ProyectoDesarrolloWeb\ProyectoFinal1_desaAppsWeb\Views\USUARIO\lista_usuarios.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e05929dc656184016816dc5d849cf0b0e981ab3f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_USUARIO_lista_usuarios), @"mvc.1.0.view", @"/Views/USUARIO/lista_usuarios.cshtml")]
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
#line 1 "D:\VisualStudio projects\ProyectoDesarrolloWeb\ProyectoFinal1_desaAppsWeb\Views\_ViewImports.cshtml"
using ProyectoFinal1_desaAppsWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\VisualStudio projects\ProyectoDesarrolloWeb\ProyectoFinal1_desaAppsWeb\Views\_ViewImports.cshtml"
using ProyectoFinal1_desaAppsWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e05929dc656184016816dc5d849cf0b0e981ab3f", @"/Views/USUARIO/lista_usuarios.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45bfad75ec5a7e3916d78c056e2e966b3ccf16c2", @"/Views/_ViewImports.cshtml")]
    public class Views_USUARIO_lista_usuarios : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProyectoFinal1_desaAppsWeb.Models.USUARIO>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\VisualStudio projects\ProyectoDesarrolloWeb\ProyectoFinal1_desaAppsWeb\Views\USUARIO\lista_usuarios.cshtml"
  
    ViewData["Title"] = "lista_usuarios";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e05929dc656184016816dc5d849cf0b0e981ab3f4772", async() => {
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
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "D:\VisualStudio projects\ProyectoDesarrolloWeb\ProyectoFinal1_desaAppsWeb\Views\USUARIO\lista_usuarios.cshtml"
           Write(Html.DisplayNameFor(model => model.Usuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "D:\VisualStudio projects\ProyectoDesarrolloWeb\ProyectoFinal1_desaAppsWeb\Views\USUARIO\lista_usuarios.cshtml"
           Write(Html.DisplayNameFor(model => model.Contrasena));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            ");
#nullable restore
#line 22 "D:\VisualStudio projects\ProyectoDesarrolloWeb\ProyectoFinal1_desaAppsWeb\Views\USUARIO\lista_usuarios.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "D:\VisualStudio projects\ProyectoDesarrolloWeb\ProyectoFinal1_desaAppsWeb\Views\USUARIO\lista_usuarios.cshtml"
           Write(Html.DisplayNameFor(model => model.Pregunta_seguridad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "D:\VisualStudio projects\ProyectoDesarrolloWeb\ProyectoFinal1_desaAppsWeb\Views\USUARIO\lista_usuarios.cshtml"
           Write(Html.DisplayNameFor(model => model.Respuesta_seguridad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 35 "D:\VisualStudio projects\ProyectoDesarrolloWeb\ProyectoFinal1_desaAppsWeb\Views\USUARIO\lista_usuarios.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 39 "D:\VisualStudio projects\ProyectoDesarrolloWeb\ProyectoFinal1_desaAppsWeb\Views\USUARIO\lista_usuarios.cshtml"
               Write(Html.DisplayFor(modelItem => item.Usuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 42 "D:\VisualStudio projects\ProyectoDesarrolloWeb\ProyectoFinal1_desaAppsWeb\Views\USUARIO\lista_usuarios.cshtml"
               Write(Html.DisplayFor(modelItem => item.Contrasena));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 45 "D:\VisualStudio projects\ProyectoDesarrolloWeb\ProyectoFinal1_desaAppsWeb\Views\USUARIO\lista_usuarios.cshtml"
               Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 48 "D:\VisualStudio projects\ProyectoDesarrolloWeb\ProyectoFinal1_desaAppsWeb\Views\USUARIO\lista_usuarios.cshtml"
               Write(Html.DisplayFor(modelItem => item.Pregunta_seguridad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 51 "D:\VisualStudio projects\ProyectoDesarrolloWeb\ProyectoFinal1_desaAppsWeb\Views\USUARIO\lista_usuarios.cshtml"
               Write(Html.DisplayFor(modelItem => item.Respuesta_seguridad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e05929dc656184016816dc5d849cf0b0e981ab3f9990", async() => {
                WriteLiteral("Edit");
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
#line 54 "D:\VisualStudio projects\ProyectoDesarrolloWeb\ProyectoFinal1_desaAppsWeb\Views\USUARIO\lista_usuarios.cshtml"
                                           WriteLiteral(item.Id_usuario);

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
            WriteLiteral(" |\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e05929dc656184016816dc5d849cf0b0e981ab3f12201", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 55 "D:\VisualStudio projects\ProyectoDesarrolloWeb\ProyectoFinal1_desaAppsWeb\Views\USUARIO\lista_usuarios.cshtml"
                                              WriteLiteral(item.Id_usuario);

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
            WriteLiteral(" |\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e05929dc656184016816dc5d849cf0b0e981ab3f14419", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 56 "D:\VisualStudio projects\ProyectoDesarrolloWeb\ProyectoFinal1_desaAppsWeb\Views\USUARIO\lista_usuarios.cshtml"
                                             WriteLiteral(item.Id_usuario);

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
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 59 "D:\VisualStudio projects\ProyectoDesarrolloWeb\ProyectoFinal1_desaAppsWeb\Views\USUARIO\lista_usuarios.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>


<!--<head>

    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">
    <meta name=""description"" content="""">
    <meta name=""author"" content="""">
    <link href=""https://fonts.googleapis.com/css?family=Raleway:100,300,400,500,700,900"" rel=""stylesheet"">

    <title>E-Descargas</title>-->
<!--
SOFTY PINKO
https://templatemo.com/tm-535-softy-pinko
-->
<!-- Additional CSS Files -->
<!--<link rel=""stylesheet"" type=""text/css"" href=""assets/css/bootstrap.min.css"">

    <link rel=""stylesheet"" type=""text/css"" href=""assets/css/font-awesome.css"">

    <link rel=""stylesheet"" href=""assets/css/templatemo-softy-pinko.css"">

    <link rel=""stylesheet"" type=""text/css"" href=""assets/css/design.css"">

</head>

<body>-->
<!-- ***** Preloader Start ***** -->
<!--<div id=""preloader"">
    <div class=""jumper"">
        <div></div>
        <div></div>
        <div></div>
    </div>
</div>-->
<!-- ***** Preloader End ");
            WriteLiteral(@"***** -->
<!-- ***** Header Area Start ***** -->
<!--<header class=""header-area header-sticky"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <nav class=""main-nav"">-->
<!-- ***** Logo Start ***** -->
<!--<a href=""lista_usuarios.html"" class=""logo"">
    <img src=""https://i.imgur.com/ugCorAW.png"" alt=""E-Descargas"" />
</a>-->
<!-- ***** Logo End ***** -->
<!-- ***** Menu Start ***** -->
<!--<ul class=""nav"">
    <li><a href=""index.html"">Inicio</a></li>
    <li><a href=""busqueda.html"">Búsqueda</a></li>
    <li><a href=""descargas.html"">Descargas</a></li>
    <li><a href=""compras.html"">Compras</a></li>
    <li><a href=""admin.html"" class=""active"">Admin</a></li>
    <li><a href=""signIn.html"">Salir</a></li>
</ul>
<a class='menu-trigger'>
    <span>Menu</span>
</a>-->
<!-- ***** Menu End ***** -->
<!--</nav>
            </div>
        </div>
    </div>
</header>-->
<!-- ***** Header Area End ***** -->
<!-- ***** Blog Start ***** -->
");
            WriteLiteral(@"<!--<section class=""section"" id=""blog"">
    <div class=""container"">-->
<!-- ***** Section Title Start ***** -->
<!--<div class=""row"">
    <div class=""col-lg-12"">
        <div class=""center-heading"">
            <h2 class=""section-title""><br>Lista de usuarios</h2>
        </div>
    </div>
    <div class=""offset-lg-3 col-lg-6"">
        <div class=""center-text"">
            <p>Mirá la lista de tus usuarios</p>
        </div>
    </div>
</div>-->
<!-- ***** Section Title End ***** -->
<!--<div>
            <table class=""default"">

                <table border=""1"" "">

                    <col span=""2"" class=""fondo"">
                    <col>
                    <tbody>
                        <tr>
                            <th>Usuario</th>
                            <th>Rol</th>
                        </tr>
                        <tr>
                            <td>Stephany</td>
                            <td>Administrador</td>
                        </tr>
                ");
            WriteLiteral(@"        <tr>
                            <td>Israel</td>
                            <td>Administrador</td>
                        </tr>
                        <tr>
                            <td>Rafael</td>
                            <td>Administrador</td>
                        </tr>




                    </tbody>
                </table>


        </div>


    </div>
    </div>

    </div>
    </div>
</section>-->
<!-- ***** Blog End ***** -->
<!-- ***** Footer Start ***** -->
<!--<footer>
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12 col-md-12 col-sm-12"">
                <ul class=""social"">
                    <li><a href=""#""><i class=""fa fa-linkedin""></i></a></li>
                </ul>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-12"">
                <p class=""copyright"">Copyright &copy; 2021 E-Descargas</p>
            </div>
        </div>
    </div>
</footer>-->
<!-");
            WriteLiteral(@"- jQuery -->
<!--<script src=""assets/js/jquery-2.1.0.min.js""></script>-->
<!-- Bootstrap -->
<!--<script src=""assets/js/popper.js""></script>
<script src=""assets/js/bootstrap.min.js""></script>-->
<!-- Plugins -->
<!--<script src=""assets/js/scrollreveal.min.js""></script>
<script src=""assets/js/waypoints.min.js""></script>
<script src=""assets/js/jquery.counterup.min.js""></script>
<script src=""assets/js/imgfix.min.js""></script>-->
<!-- Global Init -->
<!--<script src=""assets/js/custom.js""></script>

</body>-->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProyectoFinal1_desaAppsWeb.Models.USUARIO>> Html { get; private set; }
    }
}
#pragma warning restore 1591
