#pragma checksum "C:\Users\jfish\source\repos\CoffeeShop\Views\Home\Registration.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00c5c3837f43da26d5326d698bfecac62ab17eb9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Registration), @"mvc.1.0.view", @"/Views/Home/Registration.cshtml")]
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
#line 1 "C:\Users\jfish\source\repos\CoffeeShop\Views\_ViewImports.cshtml"
using CoffeeShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jfish\source\repos\CoffeeShop\Views\_ViewImports.cshtml"
using CoffeeShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00c5c3837f43da26d5326d698bfecac62ab17eb9", @"/Views/Home/Registration.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0280a23aa28fddc99a39f5869bf0f0a5a4076c2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Registration : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Registration", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return validateForm()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/registration.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\jfish\source\repos\CoffeeShop\Views\Home\Registration.cshtml"
  
    ViewData["Title"] = "Registration";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<style>\r\n    .red {\r\n        color: red;\r\n    }\r\n\r\n    .red-bg {\r\n        background-color: #FF9999;\r\n    }\r\n</style>\r\n\r\n<h1>Registration</h1>\r\n\r\n<h4>User</h4>\r\n<hr />\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00c5c3837f43da26d5326d698bfecac62ab17eb95174", async() => {
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n\r\n                <label class=\"control-label\" for=\"FirstName\" id=\"fNameLabel\">First Name</label>\r\n                <input class=\"form-control\" type=\"text\" id=\"fName\" name=\"fName\"");
                BeginWriteAttribute("value", " value=\"", 588, "\"", 596, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                <span class=""text-danger field-validation-valid"" id=""fNameFeedback""></span>
            </div>
            <div class=""form-group"">
                <label class=""control-label"" for=""LastName"" id=""lNameLabel"">Last Name</label>
                <input class=""form-control"" type=""text"" id=""lName"" name=""lName""");
                BeginWriteAttribute("value", " value=\"", 927, "\"", 935, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                <span class=""text-danger field-validation-valid"" id=""lNameFeedback""></span>
            </div>
            <div class=""form-group"">
                <label class=""control-label"" for=""Email"" id=""emailLabel"">Email</label>
                <input class=""form-control"" type=""text"" id=""Email"" name=""Email""");
                BeginWriteAttribute("value", " value=\"", 1259, "\"", 1267, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                <span class=""text-danger field-validation-valid"" id=""EmailFeedback""></span>
            </div>
            <div class=""form-group"">
                <label class=""control-label"" for=""DietaryNeed"" id=""dNeedLabel"">Dietary Needs</label>
                <input class=""form-control"" type=""text"" id=""dNeed"" name=""dNeed""");
                BeginWriteAttribute("value", " value=\"", 1605, "\"", 1613, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                <span class=""text-danger field-validation-valid"" id=""dietNeedFeedback""></span>
            </div>
            <div class=""form-group"">
                <label class=""control-label"" for=""Birthday"" id=""birthdayLabel"">Birthday</label>
                <input class=""form-control"" type=""date"" id=""birthday"" name=""birthday""");
                BeginWriteAttribute("value", " value=\"", 1955, "\"", 1963, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                <span class=""text-danger field-validation-valid"" id=""birthdayFeedBack""></span>
            </div>
            <div class=""form-group"">
                <label class=""control-label"" for=""Password"" id=""pWordLabel"">Password</label>
                <input class=""form-control"" type=""password"" id=""pWord"" name=""pWord""");
                BeginWriteAttribute("value", " value=\"", 2300, "\"", 2308, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                <span class=""text-danger field-validation-valid"" id=""passwordFeedback""></span>
            </div>
            <div class=""form-group"">
                <label class=""control-label"" for=""PassWordConfirm"" id=""pWordConfirmLabel"">Confirm Password</label>
                <input class=""form-control"" type=""password"" id=""pWordConfirm"" name=""pwordConfirm""");
                BeginWriteAttribute("value", " value=\"", 2681, "\"", 2689, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                <span class=""text-danger field-validation-valid"" id=""passwordConfFeedback""></span>
            </div>
            <div id=""formFeedback""></div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00c5c3837f43da26d5326d698bfecac62ab17eb910726", async() => {
                WriteLiteral("\r\n   \r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591
