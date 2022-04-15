#pragma checksum "G:\asp net project\NearbySoft\NerbySoft\asp_net_mvc\asp_net_mvc\Views\Shared\PartialDelete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58e8e72f0f2087118e9c76dcd1841cf354ae1f09"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_PartialDelete), @"mvc.1.0.view", @"/Views/Shared/PartialDelete.cshtml")]
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
#line 1 "G:\asp net project\NearbySoft\NerbySoft\asp_net_mvc\asp_net_mvc\Views\_ViewImports.cshtml"
using asp_net_mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\asp net project\NearbySoft\NerbySoft\asp_net_mvc\asp_net_mvc\Views\_ViewImports.cshtml"
using asp_net_mvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58e8e72f0f2087118e9c76dcd1841cf354ae1f09", @"/Views/Shared/PartialDelete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"925ac3579c879115ad33834b0ad0d20314b86d4f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_PartialDelete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""modal fade"" tabindex=""-1"" id=""dialogDelete"" role=""dialog"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <p style=""margin-bottom: 0;"">Are you sure you want to delete ");
#nullable restore
#line 7 "G:\asp net project\NearbySoft\NerbySoft\asp_net_mvc\asp_net_mvc\Views\Shared\PartialDelete.cshtml"
                                                                        Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"?</p>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"" style=""display:none"">
                <input hidden id=""deleteId"">                
            </div>
            <div class=""card-body"">
                <div class=""datatable"">
                    <div class=""row"">
                        <div class=""col-lg-12"">
                            <div style=""display:flex"" class=""form-group"">
                                <p>To confirm deletion, please enter <strong id=""deletedName""></strong></p>
                                <a data-toggle=""modal"" class=""tool mg-l-8"" title=""Copy"" href=""#"" onclick=""copyToByfer()""><img src=""https://img.icons8.com/material-outlined/24/000000/copy.png"" /></a>
                               
                            </div>
                            <div class=""form-group"">
 ");
            WriteLiteral(@"                               <input class=""form-control"" placeholder=""Enter name""  id=""deleteName"" style="" display: block; width: 100%;"" type=""text"" oninput=""clearValid(this)"" />

                                <div class=""valid-feedback""></div>
                                <div class=""invalid-feedback"" style=""display:block""></div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""modal-footer"">
                <button id=""buttonDelete"" type=""button"" class=""myBtn"" onclick=""deleteModel(this)"">Delete</button>
                <button id=""buttonCancel"" type=""button"" class=""myBtn"" data-toggle=""modal"" data-target=""#dialogDelete"">Cancel</button>
            </div>
        </div>

    </div>
</div>
<script>
    function copyToByfer() {
        var name = document.getElementById(""deletedName"").innerText;
        navigator.clipboard.writeText(name);
    }
           
</script>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; }
    }
}
#pragma warning restore 1591