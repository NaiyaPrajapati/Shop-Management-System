#pragma checksum "D:\Dhruval\github\Shop-Management-System\SDP\Views\Staff\DeleteStaff.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f484f7213f36521510f6059a602513e7c6afc318"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Staff_DeleteStaff), @"mvc.1.0.view", @"/Views/Staff/DeleteStaff.cshtml")]
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
#line 1 "D:\Dhruval\github\Shop-Management-System\SDP\Views\_ViewImports.cshtml"
using SDP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Dhruval\github\Shop-Management-System\SDP\Views\_ViewImports.cshtml"
using SDP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f484f7213f36521510f6059a602513e7c6afc318", @"/Views/Staff/DeleteStaff.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d05cba2b556eab87c229afa8de49a53b5eb5e26e", @"/Views/_ViewImports.cshtml")]
    public class Views_Staff_DeleteStaff : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SDP.Models.staff>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewStaff", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteStaff", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Dhruval\github\Shop-Management-System\SDP\Views\Staff\DeleteStaff.cshtml"
  
    ViewData["Title"] = "DeleteStaff";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<section class=""breadcumb-area bg-img bg-overlay"" style=""background-image: url(/img/bg-img/breadcumb3.jpg);"">
    <div class=""bradcumbContent"">
        <p>See what’s new</p>
        <h2>Delete Staff</h2>
    </div>
</section>
<!-- ##### Breadcumb Area End ##### -->
<!-- ##### Login Area Start ##### -->
<section class=""login-area section-padding-100"">
    <div class=""container"">
        <div class=""row justify-content-center"">
            <div class=""col-12 col-lg-8"">
                <div class=""login-content"">
                    <h3>Are you sure you want to delete this?</h3>
                    <div>
                        <h4>staff</h4>
                        <hr />
                        <dl class=""row"">
                            <dt class=""col-sm-2"">
                                ");
#nullable restore
#line 27 "D:\Dhruval\github\Shop-Management-System\SDP\Views\Staff\DeleteStaff.cshtml"
                           Write(Html.DisplayNameFor(model => model.email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dt>\r\n                            <dd class=\"col-sm-10\">\r\n                                ");
#nullable restore
#line 30 "D:\Dhruval\github\Shop-Management-System\SDP\Views\Staff\DeleteStaff.cshtml"
                           Write(Html.DisplayFor(model => model.email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dd>\r\n                            <dt class=\"col-sm-2\">\r\n                                ");
#nullable restore
#line 33 "D:\Dhruval\github\Shop-Management-System\SDP\Views\Staff\DeleteStaff.cshtml"
                           Write(Html.DisplayNameFor(model => model.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dt>\r\n                            <dd class=\"col-sm-10\">\r\n                                ");
#nullable restore
#line 36 "D:\Dhruval\github\Shop-Management-System\SDP\Views\Staff\DeleteStaff.cshtml"
                           Write(Html.DisplayFor(model => model.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dd>\r\n                            <dt class=\"col-sm-2\">\r\n                                ");
#nullable restore
#line 39 "D:\Dhruval\github\Shop-Management-System\SDP\Views\Staff\DeleteStaff.cshtml"
                           Write(Html.DisplayNameFor(model => model.contact));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dt>\r\n                            <dd class=\"col-sm-10\">\r\n                                ");
#nullable restore
#line 42 "D:\Dhruval\github\Shop-Management-System\SDP\Views\Staff\DeleteStaff.cshtml"
                           Write(Html.DisplayFor(model => model.contact));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dd>\r\n                            <dt class=\"col-sm-2\">\r\n                                ");
#nullable restore
#line 45 "D:\Dhruval\github\Shop-Management-System\SDP\Views\Staff\DeleteStaff.cshtml"
                           Write(Html.DisplayNameFor(model => model.salary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dt>\r\n                            <dd class=\"col-sm-10\">\r\n                                ");
#nullable restore
#line 48 "D:\Dhruval\github\Shop-Management-System\SDP\Views\Staff\DeleteStaff.cshtml"
                           Write(Html.DisplayFor(model => model.salary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dd>\r\n                            <dt class=\"col-sm-2\">\r\n                                ");
#nullable restore
#line 51 "D:\Dhruval\github\Shop-Management-System\SDP\Views\Staff\DeleteStaff.cshtml"
                           Write(Html.DisplayNameFor(model => model.address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dt>\r\n                            <dd class=\"col-sm-10\">\r\n                                ");
#nullable restore
#line 54 "D:\Dhruval\github\Shop-Management-System\SDP\Views\Staff\DeleteStaff.cshtml"
                           Write(Html.DisplayFor(model => model.address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dd>\r\n                            <dt class=\"col-sm-2\">\r\n                                ");
#nullable restore
#line 57 "D:\Dhruval\github\Shop-Management-System\SDP\Views\Staff\DeleteStaff.cshtml"
                           Write(Html.DisplayNameFor(model => model.role));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dt>\r\n                            <dd class=\"col-sm-10\">\r\n                                ");
#nullable restore
#line 60 "D:\Dhruval\github\Shop-Management-System\SDP\Views\Staff\DeleteStaff.cshtml"
                           Write(Html.DisplayFor(model => model.role));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dd>\r\n                        </dl>\r\n\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f484f7213f36521510f6059a602513e7c6afc31810148", async() => {
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f484f7213f36521510f6059a602513e7c6afc31810435", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 65 "D:\Dhruval\github\Shop-Management-System\SDP\Views\Staff\DeleteStaff.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.staffId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f484f7213f36521510f6059a602513e7c6afc31812263", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
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
            WriteLiteral("\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SDP.Models.staff> Html { get; private set; }
    }
}
#pragma warning restore 1591
