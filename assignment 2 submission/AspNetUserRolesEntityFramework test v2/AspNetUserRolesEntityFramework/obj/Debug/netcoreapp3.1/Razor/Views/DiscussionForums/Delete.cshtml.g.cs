#pragma checksum "C:\Users\User\Documents\uc\WDP\assignment 2 submission\AspNetUserRolesEntityFramework test v2\AspNetUserRolesEntityFramework\Views\DiscussionForums\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a347e2c87b409a911d57e1b9ed74c7b3aa7c199"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DiscussionForums_Delete), @"mvc.1.0.view", @"/Views/DiscussionForums/Delete.cshtml")]
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
#line 1 "C:\Users\User\Documents\uc\WDP\assignment 2 submission\AspNetUserRolesEntityFramework test v2\AspNetUserRolesEntityFramework\Views\_ViewImports.cshtml"
using AspNetUserRolesEntityFramework;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Documents\uc\WDP\assignment 2 submission\AspNetUserRolesEntityFramework test v2\AspNetUserRolesEntityFramework\Views\_ViewImports.cshtml"
using AspNetUserRolesEntityFramework.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a347e2c87b409a911d57e1b9ed74c7b3aa7c199", @"/Views/DiscussionForums/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af4600266cff0b0bffc650705ac65220f1459377", @"/Views/_ViewImports.cshtml")]
    public class Views_DiscussionForums_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AspNetUserRolesEntityFramework.Models.DiscussionForum>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Review", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a347e2c87b409a911d57e1b9ed74c7b3aa7c1995177", async() => {
                WriteLiteral("\r\n    <div class=\"bgis\">\r\n        <div class=\"bgc bgs\">\r\n            <div id=\"introBox\">Canberra Restaurants</div>\r\n            <div id=\"quote\"><h1>Delete</h1></div>\r\n        </div>\r\n    </div>\r\n");
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
            WriteLiteral("\r\n\r\n<div style=\"margin-left:50px\">\r\n    <h3 style=\"margin-top:20px\">Are you sure you want to delete this?</h3>\r\n    <div>\r\n        <hr />\r\n        <dl class=\"row\">\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 18 "C:\Users\User\Documents\uc\WDP\assignment 2 submission\AspNetUserRolesEntityFramework test v2\AspNetUserRolesEntityFramework\Views\DiscussionForums\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Heading));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 21 "C:\Users\User\Documents\uc\WDP\assignment 2 submission\AspNetUserRolesEntityFramework test v2\AspNetUserRolesEntityFramework\Views\DiscussionForums\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Heading));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 24 "C:\Users\User\Documents\uc\WDP\assignment 2 submission\AspNetUserRolesEntityFramework test v2\AspNetUserRolesEntityFramework\Views\DiscussionForums\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Like));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 27 "C:\Users\User\Documents\uc\WDP\assignment 2 submission\AspNetUserRolesEntityFramework test v2\AspNetUserRolesEntityFramework\Views\DiscussionForums\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Like));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 30 "C:\Users\User\Documents\uc\WDP\assignment 2 submission\AspNetUserRolesEntityFramework test v2\AspNetUserRolesEntityFramework\Views\DiscussionForums\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.TopicTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 33 "C:\Users\User\Documents\uc\WDP\assignment 2 submission\AspNetUserRolesEntityFramework test v2\AspNetUserRolesEntityFramework\Views\DiscussionForums\Delete.cshtml"
           Write(Html.DisplayFor(model => model.TopicTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 36 "C:\Users\User\Documents\uc\WDP\assignment 2 submission\AspNetUserRolesEntityFramework test v2\AspNetUserRolesEntityFramework\Views\DiscussionForums\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.PostDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 39 "C:\Users\User\Documents\uc\WDP\assignment 2 submission\AspNetUserRolesEntityFramework test v2\AspNetUserRolesEntityFramework\Views\DiscussionForums\Delete.cshtml"
           Write(Html.DisplayFor(model => model.PostDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 42 "C:\Users\User\Documents\uc\WDP\assignment 2 submission\AspNetUserRolesEntityFramework test v2\AspNetUserRolesEntityFramework\Views\DiscussionForums\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 45 "C:\Users\User\Documents\uc\WDP\assignment 2 submission\AspNetUserRolesEntityFramework test v2\AspNetUserRolesEntityFramework\Views\DiscussionForums\Delete.cshtml"
           Write(Html.DisplayFor(model => model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 48 "C:\Users\User\Documents\uc\WDP\assignment 2 submission\AspNetUserRolesEntityFramework test v2\AspNetUserRolesEntityFramework\Views\DiscussionForums\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.MessageContent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 51 "C:\Users\User\Documents\uc\WDP\assignment 2 submission\AspNetUserRolesEntityFramework test v2\AspNetUserRolesEntityFramework\Views\DiscussionForums\Delete.cshtml"
           Write(Html.DisplayFor(model => model.MessageContent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 54 "C:\Users\User\Documents\uc\WDP\assignment 2 submission\AspNetUserRolesEntityFramework test v2\AspNetUserRolesEntityFramework\Views\DiscussionForums\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Disagree));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 57 "C:\Users\User\Documents\uc\WDP\assignment 2 submission\AspNetUserRolesEntityFramework test v2\AspNetUserRolesEntityFramework\Views\DiscussionForums\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Disagree));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 60 "C:\Users\User\Documents\uc\WDP\assignment 2 submission\AspNetUserRolesEntityFramework test v2\AspNetUserRolesEntityFramework\Views\DiscussionForums\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Agree));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 63 "C:\Users\User\Documents\uc\WDP\assignment 2 submission\AspNetUserRolesEntityFramework test v2\AspNetUserRolesEntityFramework\Views\DiscussionForums\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Agree));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a347e2c87b409a911d57e1b9ed74c7b3aa7c19913246", async() => {
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2a347e2c87b409a911d57e1b9ed74c7b3aa7c19913517", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 68 "C:\Users\User\Documents\uc\WDP\assignment 2 submission\AspNetUserRolesEntityFramework test v2\AspNetUserRolesEntityFramework\Views\DiscussionForums\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

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
                WriteLiteral("\r\n            <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a347e2c87b409a911d57e1b9ed74c7b3aa7c19915394", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AspNetUserRolesEntityFramework.Models.DiscussionForum> Html { get; private set; }
    }
}
#pragma warning restore 1591
