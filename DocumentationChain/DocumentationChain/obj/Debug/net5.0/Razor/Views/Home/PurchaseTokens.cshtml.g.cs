#pragma checksum "C:\Users\Ollie\Desktop\Work\DocumentationChain\DocumentationChain\DocumentationChain\Views\Home\PurchaseTokens.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe9a9eb1c03f3960354220ed48b1911d2aee606c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_PurchaseTokens), @"mvc.1.0.view", @"/Views/Home/PurchaseTokens.cshtml")]
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
#line 1 "C:\Users\Ollie\Desktop\Work\DocumentationChain\DocumentationChain\DocumentationChain\Views\Home\PurchaseTokens.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe9a9eb1c03f3960354220ed48b1911d2aee606c", @"/Views/Home/PurchaseTokens.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"592d5f828d2d6b9947bc19256867f3d27a5bb0a0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_PurchaseTokens : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Ollie\Desktop\Work\DocumentationChain\DocumentationChain\DocumentationChain\Views\Home\PurchaseTokens.cshtml"
  
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe9a9eb1c03f3960354220ed48b1911d2aee606c4014", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 20 "C:\Users\Ollie\Desktop\Work\DocumentationChain\DocumentationChain\DocumentationChain\Views\Home\PurchaseTokens.cshtml"
      if (isLogged)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            <div class=""tile is-ancestor"" style=""margin-left: 15px; margin-right: 15px; margin-top: 10px;"">
                <div class=""tile is-vertical is-parent is-12"">
                    <div class=""tile"">
                        <article class=""tile is-child notification is-white"" style=""text-align: center;"">
                            <p class=""subtitle"" style=""font-family: 'IBM Plex Mono Light'""><strong>Purchase Tokens to store Documents!</strong> </p>
                            <p class=""subtitle"" style=""font-family: 'IBM Plex Mono Light'"">Please Enter an Amount Below</p>
                        </article>
                    </div>
                </div>
            </div>
");
                WriteLiteral(@"            <div class=""tile is-ancestor"">
                <!--First Column-->
                <div class=""tile is-parent is-4 is-vertical"">
                    <!--Introduction text-->
                </div>
                <div class=""tile is-parent is-4 is-vertical"">
                    <!--Introduction text-->
                    <article class=""tile is-child notification box is-success"" style=""box-shadow: #000000 0 5px 15px; box-shadow: rgba(0, 0, 0, 0.35) 0 5px 15px;"">
                        <h3> Please Enter a Choosen Amount</h3>
                        <input type=""text"" name=""AmountBox"" id=""TokenPurchase"" multiple />
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
                WriteLiteral("            <div style=\"text-align: center;\">\r\n                <div id=\"paypal-button-container\"></div>\r\n            </div>\r\n");
#nullable restore
#line 56 "C:\Users\Ollie\Desktop\Work\DocumentationChain\DocumentationChain\DocumentationChain\Views\Home\PurchaseTokens.cshtml"
        }
        else
        {


#line default
#line hidden
#nullable disable
                WriteLiteral(@"            <div class=""tile is-ancestor"" style=""margin-left: 15px; margin-right: 15px; margin-top: 10px;"">
                <div class=""tile is-vertical is-parent is-12"">
                    <div class=""tile"">
                        <article class=""tile is-child notification is-white"" style=""text-align: center;"">
                            <p class=""subtitle"" style=""font-family: 'IBM Plex Mono Light'""><strong>Purchase Log In To Purchase Tokens!</strong> </p>
                        </article>
                    </div>
                </div>
            </div>
");
#nullable restore
#line 69 "C:\Users\Ollie\Desktop\Work\DocumentationChain\DocumentationChain\DocumentationChain\Views\Home\PurchaseTokens.cshtml"
        }
    

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n");
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
            WriteLiteral(@"

<script src=""https://www.paypal.com/sdk/js?client-id=AYUMEewur6ChNqBT-8Rlq1c7PC2QX9rA8rVaUZ3Ntx6i8UQjQdMFgbNarkH9fY5IJ52CYps1pTNpIpyE&currency=GBP"" data-sdk-integration-source=""button-factory""></script>
<script>
    var TotalAmount;

    function GetAmount() {
        TotalAmount = document.getElementById(""TokenPurchase"").value;
        return TotalAmount;
    }

    function ClearInputBox() {
        document.getElementById(""TokenPurchase"").value = """";
    }
    function initPayPalButton() {
        paypal.Buttons({
            style: {
                shape: 'rect',
                color: 'gold',
                layout: 'vertical',
                label: 'paypal'

            },


            createOrder: function(data, actions) {
                return actions.order.create({
                    purchase_units: [
                        {

                            reference_id: ""documentationChain.ID"",
                            description: ""documentationchain ID"",

");
            WriteLiteral(@"
                            custom_id: ""documentationChainID"",
                            amount: {
                                currency_code: ""GBP"",
                                value: GetAmount(), //Get the Total Of Price From Box
                                breakdown: {
                                    item_total: {
                                        currency_code: ""GBP"",
                                        value: GetAmount() //Get the Total Of Price From Box
                                    }
                                }
                            },
                            items: [
                                {
                                name: ""Tokens"",
                                SKU: ""TokenID"",
                                unit_amount: {
                                    currency_code: ""GBP"",
                                    value: GetAmount()
                                    },
                                quantity: ""1");
            WriteLiteral(@""",
                        },
                           ]
                        }
                    ]
                });
            },

            onApprove: function(data, actions) {
                return actions.order.capture().then(function (details) {
                    /*
                    Used initially instead of the invoices to alert the customer
                    alert('Transaction completed by ' + details.payer.name.given_name + '!');

                    console.log(JSON.stringify(details)); (Used for testing to display all the information provided by paypal)
                    */
                    var name = details.payer.name.given_name;
                    var payPalOrderID = details.id;

                    ClearInputBox();
                    var amount = TotalAmount; //if you want to pass an Id parameter
                     $.ajax({
                type: 'POST',
                url: '");
#nullable restore
#line 150 "C:\Users\Ollie\Desktop\Work\DocumentationChain\DocumentationChain\DocumentationChain\Views\Home\PurchaseTokens.cshtml"
                 Write(Url.Action("AddTokenBalance", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                data: {
                    'amount': amount
                }
            });

                });
            },

            onCancel: function(data) {
                //return to cart
            },

            onError: function(err) {
                console.log(err);
            }
        }).render('#paypal-button-container');
    }


    initPayPalButton();
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
