#pragma checksum "C:\Users\azooz\LastProjSDA3\LastProjSDA3\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ee79df98c74475125e39ebd98a11d3a628f2f67"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\azooz\LastProjSDA3\LastProjSDA3\Views\_ViewImports.cshtml"
using ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ee79df98c74475125e39ebd98a11d3a628f2f67", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c86d4dedc560c3ae2ac2a1386df8378c2c18acf", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("sentMessage"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("contactForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("novalidate", new global::Microsoft.AspNetCore.Html.HtmlString("novalidate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid rounded mb-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\azooz\LastProjSDA3\LastProjSDA3\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- Masthead -->

<div style=""border:40px; margin:40px"">

</div>
<!-- Product Section -->
<section class=""page-section portfolio"" id=""portfolio"">
    <div class=""container"">

        <!-- Portfolio Section Heading -->
        <h2 class=""page-section-heading text-center text-uppercase text-secondary mb-0"">Product</h2>

        <!-- Icon Divider -->
        <div class=""divider-custom"">
            <div class=""divider-custom-line""></div>
            <div class=""divider-custom-icon"">
                <i class=""fas fa-star""></i>
            </div>
            <div class=""divider-custom-line""></div>
        </div>

        <!-- Portfolio Grid Items -->
        <div class=""row"">

            <!-- Portfolio Item 1 -->
");
#nullable restore
#line 30 "C:\Users\azooz\LastProjSDA3\LastProjSDA3\Views\Home\Index.cshtml"
             foreach (var portfolioItem in Model.PortfolioItem)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-6 col-lg-4\">\r\n                    <div class=\"portfolio-item mx-auto\" data-toggle=\"modal\" data-target=\"#item-");
#nullable restore
#line 33 "C:\Users\azooz\LastProjSDA3\LastProjSDA3\Views\Home\Index.cshtml"
                                                                                          Write(portfolioItem.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
                        <div class=""portfolio-item-caption d-flex align-items-center justify-content-center h-100 w-100"">
                            <div class=""portfolio-item-caption-content text-center text-white"">
                                <i class=""fas fa-plus fa-3x""></i>
                            </div>
                        </div>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0ee79df98c74475125e39ebd98a11d3a628f2f677305", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1460, "~/img/portfolio/", 1460, 16, true);
#nullable restore
#line 39 "C:\Users\azooz\LastProjSDA3\LastProjSDA3\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 1476, portfolioItem.ImageUrl, 1476, 23, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 42 "C:\Users\azooz\LastProjSDA3\LastProjSDA3\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
        <!-- /.row -->

    </div>
</section>

<!-- About Section -->
<section class=""page-section bg-primary text-white mb-0"" id=""about"">
    <div class=""container"">

        <!-- About Section Heading -->
        <h2 class=""page-section-heading text-center text-uppercase text-white"">About</h2>

        <!-- Icon Divider -->
        <div class=""divider-custom divider-light"">
            <div class=""divider-custom-line""></div>
            <div class=""divider-custom-icon"">
                <i class=""fas fa-star""></i>
            </div>
            <div class=""divider-custom-line""></div>
        </div>

        <!-- About Section Content -->
        <div class=""row"">
            <div class=""col-lg-4 ml-auto"">
                <p class=""lead"">We are company that offers high quallity computers on pre-order</p>
            </div>
            <div class=""col-lg-4 mr-auto"">
                <p class=""lead"">You can go to Contact and send the message , and you will be contacte");
            WriteLiteral(@"d if the computers is in warehouse </p>
            </div>
        </div>

        

    </div>
</section>

<!-- Contact Section -->
<section class=""page-section"" id=""contact"">
    <div class=""container"">

        <!-- Contact Section Heading -->
        <h2 class=""page-section-heading text-center text-uppercase text-secondary mb-0"">Contact Me</h2>

        <!-- Icon Divider -->
        <div class=""divider-custom"">
            <div class=""divider-custom-line""></div>
            <div class=""divider-custom-icon"">
                <i class=""fas fa-star""></i>
            </div>
            <div class=""divider-custom-line""></div>
        </div>

        <!-- Contact Section Form -->
        <div class=""row"">
            <div class=""col-lg-8 mx-auto"">
                <!-- To configure the contact form email address, go to mail/contact_me.php and update the email address in the PHP file on line 19. -->
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ee79df98c74475125e39ebd98a11d3a628f2f6711264", async() => {
                WriteLiteral(@"
                    <div class=""control-group"">
                        <div class=""form-group floating-label-form-group controls mb-0 pb-2"">
                            <label>Name</label>
                            <input class=""form-control"" id=""name"" type=""text"" placeholder=""Name"" required=""required"" data-validation-required-message=""Please enter your name."">
                            <p class=""help-block text-danger""></p>
                        </div>
                    </div>
                    <div class=""control-group"">
                        <div class=""form-group floating-label-form-group controls mb-0 pb-2"">
                            <label>Email Address</label>
                            <input class=""form-control"" id=""email"" type=""email"" placeholder=""Email Address"" required=""required"" data-validation-required-message=""Please enter your email address."">
                            <p class=""help-block text-danger""></p>
                        </div>
                    </d");
                WriteLiteral(@"iv>
                    <div class=""control-group"">
                        <div class=""form-group floating-label-form-group controls mb-0 pb-2"">
                            <label>Phone Number</label>
                            <input class=""form-control"" id=""phone"" type=""tel"" placeholder=""Phone Number"" required=""required"" data-validation-required-message=""Please enter your phone number."">
                            <p class=""help-block text-danger""></p>
                        </div>
                    </div>
                    <div class=""control-group"">
                        <div class=""form-group floating-label-form-group controls mb-0 pb-2"">
                            <label>Message</label>
                            <textarea class=""form-control"" id=""message"" rows=""5"" placeholder=""Message"" required=""required"" data-validation-required-message=""Please enter a message.""></textarea>
                            <p class=""help-block text-danger""></p>
                        </div>
     ");
                WriteLiteral(@"               </div>
                    <br>
                    <div id=""success""></div>
                    <div class=""form-group"">
                        <button type=""submit"" class=""btn btn-primary btn-xl"" id=""sendMessageButton"">Send</button>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n</section>\r\n\r\n\r\n<!-- Portfolio Modals -->\r\n<!-- Portfolio Modal 1 -->\r\n");
#nullable restore
#line 145 "C:\Users\azooz\LastProjSDA3\LastProjSDA3\Views\Home\Index.cshtml"
 foreach (var item in Model.PortfolioItem)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"portfolio-modal modal fade\"");
            BeginWriteAttribute("id", " id=\"", 6188, "\"", 6206, 2);
            WriteAttributeValue("", 6193, "item-", 6193, 5, true);
#nullable restore
#line 147 "C:\Users\azooz\LastProjSDA3\LastProjSDA3\Views\Home\Index.cshtml"
WriteAttributeValue("", 6198, item.Id, 6198, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" tabindex=""-1"" role=""dialog"" aria-labelledby=""portfolioModal1Label"" aria-hidden=""true"">
        <div class=""modal-dialog modal-xl"" role=""document"">
            <div class=""modal-content"">
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">
                        <i class=""fas fa-times""></i>
                    </span>
                </button>
                <div class=""modal-body text-center"">
                    <div class=""container"">
                        <div class=""row justify-content-center"">
                            <div class=""col-lg-8"">
                                <!-- Portfolio Modal - Title -->
                                <h2 class=""portfolio-modal-title text-secondary text-uppercase mb-0"">");
#nullable restore
#line 160 "C:\Users\azooz\LastProjSDA3\LastProjSDA3\Views\Home\Index.cshtml"
                                                                                                Write(item.ProjectName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                                <!-- Icon Divider -->
                                <div class=""divider-custom"">
                                    <div class=""divider-custom-line""></div>
                                    <div class=""divider-custom-icon"">
                                        <i class=""fas fa-star""></i>
                                    </div>
                                    <div class=""divider-custom-line""></div>
                                </div>
                                <!-- Portfolio Modal - Image -->
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0ee79df98c74475125e39ebd98a11d3a628f2f6717835", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 7691, "~/img/portfolio/", 7691, 16, true);
#nullable restore
#line 170 "C:\Users\azooz\LastProjSDA3\LastProjSDA3\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 7707, item.ImageUrl, 7707, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                <!-- Portfolio Modal - Text -->\r\n                                <p class=\"mb-5\">");
#nullable restore
#line 172 "C:\Users\azooz\LastProjSDA3\LastProjSDA3\Views\Home\Index.cshtml"
                                           Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                <p>Contact to us for book / Pre-booking</p>
                                <p>in CONTACT</p>
                                <button class=""btn btn-primary"" href=""#"" data-dismiss=""modal"">
                                    <i class=""fas fa-times fa-fw""></i>
                                    Close Window
                                </button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
");
#nullable restore
#line 186 "C:\Users\azooz\LastProjSDA3\LastProjSDA3\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
