#pragma checksum "E:\3.2\SD Lab\Key_Castle\Key Castle\Views\Cart\CartCon.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd692ba54365145bfc139b8e6616be9f03771417"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_CartCon), @"mvc.1.0.view", @"/Views/Cart/CartCon.cshtml")]
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
#line 1 "E:\3.2\SD Lab\Key_Castle\Key Castle\Views\_ViewImports.cshtml"
using Key_Castle;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\3.2\SD Lab\Key_Castle\Key Castle\Views\_ViewImports.cshtml"
using Key_Castle_Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\3.2\SD Lab\Key_Castle\Key Castle\Views\Cart\CartCon.cshtml"
using Key_Castle_Utility;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd692ba54365145bfc139b8e6616be9f03771417", @"/Views/Cart/CartCon.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6838a7015289068391c312b1a985fe5b0e51cd58", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_CartCon : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Remove", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 4 "E:\3.2\SD Lab\Key_Castle\Key Castle\Views\Cart\CartCon.cshtml"
 if (Model.Count() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd692ba54365145bfc139b8e6616be9f037714175913", async() => {
                WriteLiteral(@"
        <br />
        <div class=""backgroundWhiteBorder"">
            <div class=""container row"">
                <div class=""col -8"">
                    <div class=""card mt-4"">
                        <div class=""card-header bg-dark text-light ml-0 row container"">
                            <div class=""col-6"">
                                <i class=""fa fa-shopping-cart""></i> &nbsp;
                                Shopping Cart
                            </div>
                            <div class=""col-6 text-right"">
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd692ba54365145bfc139b8e6616be9f037714176748", async() => {
                    WriteLiteral("Continue Shopping");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""card-body"">
                            <div class="" d-none d-lg-block"">
                                <div class=""row"" style=""color:#821f3d"">
                                    <div class=""col-lg-2"">
                                    </div>
                                    <div class=""col-12 col-lg-7"">
                                        Product Details
                                    </div>
                                    <div class=""col-12 col-lg-2"">
                                        Price per unit
                                    </div>
                                    <div class=""col-6 col-sm-4 col-lg-1"">
                                    </div>
                                </div>
                            </div>

                            <hr />
");
#nullable restore
#line 38 "E:\3.2\SD Lab\Key_Castle\Key Castle\Views\Cart\CartCon.cshtml"
                               var orderTotal = 0.0; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "E:\3.2\SD Lab\Key_Castle\Key Castle\Views\Cart\CartCon.cshtml"
                             foreach (var obj in Model)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"row h-100\">\n                            <div class=\"col-4 col-md-2 text-center py-2\">\n                                <img");
                BeginWriteAttribute("src", " src=\"", 1975, "\"", 2012, 2);
#nullable restore
#line 43 "E:\3.2\SD Lab\Key_Castle\Key Castle\Views\Cart\CartCon.cshtml"
WriteAttributeValue("", 1981, WC.ImagePath, 1981, 13, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "E:\3.2\SD Lab\Key_Castle\Key Castle\Views\Cart\CartCon.cshtml"
WriteAttributeValue("", 1994, obj.Product_photo, 1994, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"rounded\" width=\"100\" />\n                            </div>\n                            <div class=\"col-8 col-lg-7\">\n                                <h5>");
#nullable restore
#line 46 "E:\3.2\SD Lab\Key_Castle\Key Castle\Views\Cart\CartCon.cshtml"
                               Write(obj.Product_name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\n                                <div style=\"font-size:11px;\">");
#nullable restore
#line 47 "E:\3.2\SD Lab\Key_Castle\Key Castle\Views\Cart\CartCon.cshtml"
                                                        Write(obj.Short_Desc);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\n                            </div>\n                            <div class=\"col-3 col-lg-2 pt-lg-4\" style=\"font-size:11px;\">\n                                <span style=\"font-size:17px;\"> $");
#nullable restore
#line 50 "E:\3.2\SD Lab\Key_Castle\Key Castle\Views\Cart\CartCon.cshtml"
                                                           Write(obj.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span> BDT\n                            </div>\n\n                            <div class=\"col-2 col-lg-1 p-0 pt-lg-4 text-center\">\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd692ba54365145bfc139b8e6616be9f0377141711750", async() => {
                    WriteLiteral("\n                                    <i class=\"fas fa-trash\"></i>\n                                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 54 "E:\3.2\SD Lab\Key_Castle\Key Castle\Views\Cart\CartCon.cshtml"
                                                                               WriteLiteral(obj.Product_id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                            </div>\n                        </div> \n");
#nullable restore
#line 59 "E:\3.2\SD Lab\Key_Castle\Key Castle\Views\Cart\CartCon.cshtml"
                        orderTotal += obj.Price;

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <hr/>\n");
#nullable restore
#line 61 "E:\3.2\SD Lab\Key_Castle\Key Castle\Views\Cart\CartCon.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"row\">\n                                <div class=\"col-12 text-right pr-5\" style=\"color:#821f3d\">\n                                    Order Total : &nbsp; &nbsp; <span style=\"font-size:17px;\"> ");
#nullable restore
#line 64 "E:\3.2\SD Lab\Key_Castle\Key Castle\Views\Cart\CartCon.cshtml"
                                                                                          Write(orderTotal);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span> BDT
                                </div>
                            </div>
                        </div>
                        <div class=""card-footer"">
                            <div class=""row"">
                                <div class=""col-6 col-md-3 offset-md-9"">
                                    <button type=""submit"" class=""btn btn-success form-control "">
                                        <span>Checkout</span>
                                    </button>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 82 "E:\3.2\SD Lab\Key_Castle\Key Castle\Views\Cart\CartCon.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p class=\"text-center\">Please add items to cart.</p>\n");
#nullable restore
#line 86 "E:\3.2\SD Lab\Key_Castle\Key Castle\Views\Cart\CartCon.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
