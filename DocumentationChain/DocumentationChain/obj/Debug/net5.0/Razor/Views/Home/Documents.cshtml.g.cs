#pragma checksum "C:\Users\Ollie\Desktop\Work\DocumentationChain\DocumentationChain\DocumentationChain\Views\Home\Documents.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20cd9234bb612b48a3e4b54c8f87989a904d2e56"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Documents), @"mvc.1.0.view", @"/Views/Home/Documents.cshtml")]
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
#line 1 "C:\Users\Ollie\Desktop\Work\DocumentationChain\DocumentationChain\DocumentationChain\Views\_ViewImports.cshtml"
using DocumentationChain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ollie\Desktop\Work\DocumentationChain\DocumentationChain\DocumentationChain\Views\_ViewImports.cshtml"
using DocumentationChain.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Ollie\Desktop\Work\DocumentationChain\DocumentationChain\DocumentationChain\Views\Home\Documents.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20cd9234bb612b48a3e4b54c8f87989a904d2e56", @"/Views/Home/Documents.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"592d5f828d2d6b9947bc19256867f3d27a5bb0a0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Documents : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<File>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SettingUploadData", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Ollie\Desktop\Work\DocumentationChain\DocumentationChain\DocumentationChain\Views\Home\Documents.cshtml"
  
    ViewData["Title"] = "Documents";


#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Ollie\Desktop\Work\DocumentationChain\DocumentationChain\DocumentationChain\Views\Home\Documents.cshtml"
  
    //Without Try Catch Error Is Thrown Because User Is Not Logged in when you try to load the page not logged in
    var cUser = await userManager.GetUserAsync(User);
    bool isLogged = false;
    if (cUser == null)
    {
        isLogged = false;
    }
    else
    {
        isLogged = true;
        var Balance = cUser.Balance;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20cd9234bb612b48a3e4b54c8f87989a904d2e565772", async() => {
                WriteLiteral(@"
    <div class=""tile is-ancestor"" style=""margin-left: 15px; margin-right: 15px; margin-top: 10px;"">
        <div class=""tile is-vertical is-parent is-12"">
            <div class=""tile"">
                <article class=""tile is-child notification is-white"" style=""text-align: center;"">
                    <p class=""subtitle"" style=""font-family: 'IBM Plex Mono Light'""><strong>Store Documents!</strong> </p>
                    <p class=""subtitle"" style=""font-family: 'IBM Plex Mono Light'"">Please Click an Option Below</p>
                </article>
            </div>
        </div>
    </div>

    <div class=""tile is-ancestor"">
        <!--First Column-->
        <div class=""tile is-parent is-4 is-vertical"">
            <!--Introduction text-->
         
        </div>
        <div class=""tile is-parent is-4 is-vertical"">
            <!--Introduction text-->
            <article class=""tile is-child notification box is-success"" style=""box-shadow: #000000 0 5px 15px; box-shadow: rgba(0, 0, 0, 0.");
                WriteLiteral("35) 0 5px 15px;\">\r\n                <input type=\"file\" name=\"elementName\" style=\"display:none; \" id=\"pdfFile\" />\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20cd9234bb612b48a3e4b54c8f87989a904d2e567257", async() => {
                    WriteLiteral(@"
                    <div class=""form-group"">
                        <div class=""col-md-10"">
                            <p>Upload one or more files using this form:</p>
                            <input type=""file"" name=""files"" multiple />
                            <h3> Please Enter a Secret Phase</h3>
                            <input type=""text"" name=""SecPhase"" multiple />
                        </div>
                    </div>
                    <div class=""form-group"">
                        <div class=""col-md-10"">
");
#nullable restore
#line 58 "C:\Users\Ollie\Desktop\Work\DocumentationChain\DocumentationChain\DocumentationChain\Views\Home\Documents.cshtml"
                             if (isLogged)
                            {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                <input type=\"submit\" value=\"Upload\" onClick=\'return confirmSubmit()\' />\r\n");
#nullable restore
#line 61 "C:\Users\Ollie\Desktop\Work\DocumentationChain\DocumentationChain\DocumentationChain\Views\Home\Documents.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                <input type=\"submit\" value=\"Upload\" disabled />\r\n");
#nullable restore
#line 65 "C:\Users\Ollie\Desktop\Work\DocumentationChain\DocumentationChain\DocumentationChain\Views\Home\Documents.cshtml"
                            }

#line default
#line hidden
#nullable disable
                    WriteLiteral("                        </div>\r\n                    </div>\r\n                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            </article>
        </div>
        <div class=""tile is-parent is-4 is-vertical"">
            <!--Introduction text-->
            <article class=""tile is-child"">
            </article>
        </div>
        <!--Second Column-->

    </div>


");
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
            WriteLiteral("\r\n    <script>\r\n\r\n\r\n    function Onclick() {\r\n        var textbox = document.getElementById(\"SecText\").value;\r\n\r\n            $.ajax({\r\n                type: \'POST\',\r\n                url: \'");
#nullable restore
#line 90 "C:\Users\Ollie\Desktop\Work\DocumentationChain\DocumentationChain\DocumentationChain\Views\Home\Documents.cshtml"
                 Write(Url.Action("DownloadFile","Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                data: {
                    'secPhase': textbox
                }
            });

        }

        function confirmSubmit() {
            var agree = confirm(""Are you sure you wish to continue?"");
            if (agree)
                return true;
            else
                return false;
        }



    function storeDocuments() {
        var x = document.getElementById(""pdfFile"").style.display;

        if (x == 'none') {
            document.getElementById(""pdfFile"").style.display = 'block';
            document.getElementById(""uploadDoc"").style.display = 'block';
        }
        else {
            document.getElementById(""pdfFile"").style.display = 'none';
            document.getElementById(""uploadDoc"").style.display = 'none';
        }
    }


    </script>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> userManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<File> Html { get; private set; }
    }
}
#pragma warning restore 1591
