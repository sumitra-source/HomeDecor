#pragma checksum "C:\Users\shres\Desktop\HomeDecorations\HomeDecorations\HomeDecorations\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8870dafc8087d2ee1b2f1bb2aaef16df2a8402f"
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
#line 1 "C:\Users\shres\Desktop\HomeDecorations\HomeDecorations\HomeDecorations\Views\_ViewImports.cshtml"
using HomeDecorations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\shres\Desktop\HomeDecorations\HomeDecorations\HomeDecorations\Views\_ViewImports.cshtml"
using HomeDecorations.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8870dafc8087d2ee1b2f1bb2aaef16df2a8402f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"087cc9bc420b9addb45d866d80a62138b8ddc2a0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/home.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("200px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a8870dafc8087d2ee1b2f1bb2aaef16df2a8402f4870", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>HomeDecor</title>
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css"">
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a8870dafc8087d2ee1b2f1bb2aaef16df2a8402f5453", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a8870dafc8087d2ee1b2f1bb2aaef16df2a8402f7344", async() => {
                WriteLiteral("\r\n    <div class=\"header\">\r\n        <div class=\"container\">\r\n            <div class=\"navbar\">\r\n                <div class=\"logo\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a8870dafc8087d2ee1b2f1bb2aaef16df2a8402f7767", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                </div>
                
                <div class=""cart"">
                    <i class=""fa fa-shopping-cart""></i>
                </div>

            </div>

            <div class=""row"">
                <div class=""col-2"">
                    <h1>Design your home <br>as you desire</h1>
                    <p>
                        Lorem ipsum dolor sit, amet consectetur adipisicing elit.<br> Animi nostrum labore tenetur odit
                        aliquam <br>illo dicta qui error, accusantium, neque dolore voluptatum. <br>Laudantium nulla
                        perferendis rem soluta distinctio veritatis magni?
                    </p>
                    <a");
                BeginWriteAttribute("href", " href=\"", 1323, "\"", 1330, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""btn""> Explore now &#8594;</a>
                </div>
                <div class=""col-2"">
                    <img src=""./images/main4.jpg"">
                </div>
            </div>

        </div>
    </div>

    <!-- feature category section -->
    <div class=""categories"">
        <div class=""small-container"">
            <h2 class=""title"">Categories</h2>
            <div class=""row"">
                <div class=""col-3"">
                    <img src=""images/sofa 1.jpg"">
                </div>
                <div class=""col-3"">
                    <img src=""./images/sofa 2.jpg"">
                </div>
                <div class=""col-3"">
                    <img src=""./images/sofa 3.jfif"">
                </div>
            </div>
        </div>

    </div>

    <!-- FEARURED CONATAINER -->
    <div class=""small-container"">
        <h2 class=""title"">Premium Products</h2>
        <div class=""row"">
            <div class=""col-4"">
                <img src=""/images/dinin");
                WriteLiteral(@"g 5.jfif"">
                <h4>Description od the dining table</h4>
                <div class=""rating"">
                    <i class=""fa fa-star""></i>
                    <i class=""fa fa-star""></i>
                    <i class=""fa fa-star""></i>
                    <i class=""fa fa-star""></i>
                    <i class=""fa fa-star-half-o""></i>
                </div>
                <p>$499.99</p>
            </div>
            <div class=""col-4"">
                <img src=""/images/dining 2.jfif"">
                <h4>Description od the dining table</h4>
                <div class=""rating"">
                    <i class=""fa fa-star""></i>
                    <i class=""fa fa-star""></i>
                    <i class=""fa fa-star""></i>
                    <i class=""fa fa-star""></i>
                    <i class=""fa fa-star-half-o""></i>
                </div>
                <p>$599.99</p>
            </div>
            <div class=""col-4"">
                <img src=""/images/dining 3.jfif"">
      ");
                WriteLiteral(@"          <h4>Description od the dining table</h4>
                <div class=""rating"">
                    <i class=""fa fa-star""></i>
                    <i class=""fa fa-star""></i>
                    <i class=""fa fa-star""></i>
                    <i class=""fa fa-star""></i>
                    <i class=""fa fa-star-half""></i>
                </div>
                <p>$399.99</p>
            </div>
            <div class=""col-4"">
                <img src=""/images/dining 4.jfif"">
                <h4>Description of the dining table</h4>
                <div class=""rating"">
                    <i class=""fa fa-star""></i>
                    <i class=""fa fa-star""></i>
                    <i class=""fa fa-star""></i>
                    <i class=""fa fa-star-half-o""></i>
                    <i class=""fa fa-star-o""></i>

                </div>
                <p>$199.99</p>
            </div>
        </div>
        <h2 class=""title"">Recent Products</h2>
        <div class=""row"">
            <di");
                WriteLiteral(@"v class=""col-4"">
                <img src=""/images/chair 1.jfif"">
                <h4>Description od the dining table</h4>
                <div class=""rating"">
                    <i class=""fa fa-star""></i>
                    <i class=""fa fa-star""></i>
                    <i class=""fa fa-star""></i>
                    <i class=""fa fa-star""></i>
                    <i class=""fa fa-star-half-o""></i>
                </div>
                <p>$499.99</p>
            </div>
            <div class=""col-4"">
                <img src=""/images/chair 2.jfif"">
                <h4>Description od the dining table</h4>
                <div class=""rating"">
                    <i class=""fa fa-star""></i>
                    <i class=""fa fa-star""></i>
                    <i class=""fa fa-star""></i>
                    <i class=""fa fa-star""></i>
                    <i class=""fa fa-star-half-o""></i>
                </div>
                <p>$599.99</p>
            </div>
            <div class=""col-4"">
  ");
                WriteLiteral(@"              <img src=""/images/chair 5.jfif"">
                <h4>Description od the dining table</h4>
                <div class=""rating"">
                    <i class=""fa fa-star""></i>
                    <i class=""fa fa-star""></i>
                    <i class=""fa fa-star""></i>
                    <i class=""fa fa-star""></i>
                    <i class=""fa fa-star-half""></i>
                </div>
                <p>$399.99</p>
            </div>
            <div class=""col-4"">
                <img src=""/images/chair 4.jfif"">
                <h4>Description of the dining table</h4>
                <div class=""rating"">
                    <i class=""fa fa-star""></i>
                    <i class=""fa fa-star""></i>
                    <i class=""fa fa-star""></i>
                    <i class=""fa fa-star-half-o""></i>
                    <i class=""fa fa-star-o""></i>

                </div>
                <p>$199.99</p>
            </div>
        </div>
        <div class=""row"">
          ");
                WriteLiteral(@"  <div class=""col-4"">
                <img src=""/images/wall4.jfif"">
                <h4>Description od the dining table</h4>
                <div class=""rating"">
                    <i class=""fa fa-star""></i>
                    <i class=""fa fa-star""></i>
                    <i class=""fa fa-star""></i>
                    <i class=""fa fa-star""></i>
                    <i class=""fa fa-star-half-o""></i>
                </div>
                <p>$499.99</p>
            </div>
            <div class=""col-4"">
                <img src=""/images/wall.jfif"">
                <h4>Description od the dining table</h4>
                <div class=""rating"">
                    <i class=""fa fa-star""></i>
                    <i class=""fa fa-star""></i>
                    <i class=""fa fa-star""></i>
                    <i class=""fa fa-star""></i>
                    <i class=""fa fa-star-half-o""></i>
                </div>
                <p>$599.99</p>
            </div>
            <div class=""col-4"">
  ");
                WriteLiteral(@"              <img src=""/images/wall2.jfif"">
                <h4>Description od the dining table</h4>
                <div class=""rating"">
                    <i class=""fa fa-star""></i>
                    <i class=""fa fa-star""></i>
                    <i class=""fa fa-star""></i>
                    <i class=""fa fa-star""></i>
                    <i class=""fa fa-star-half""></i>
                </div>
                <p>$399.99</p>
            </div>
            <div class=""col-4"">
                <img src=""/images/wall3.jfif"">
                <h4>Description of the dining table</h4>
                <div class=""rating"">
                    <i class=""fa fa-star""></i>
                    <i class=""fa fa-star""></i>
                    <i class=""fa fa-star""></i>
                    <i class=""fa fa-star-half-o""></i>
                    <i class=""fa fa-star-o""></i>

                </div>
                <p>$199.99</p>
            </div>
        </div>
    </div>
    <!-- Offer -->
    <div ");
                WriteLiteral(@"class=""offer"">
        <div class=""small-container"">
            <div class=""row"">
                <div class=""col-2"">
                    <img src=""./images/wall.jfif"" class=""offer-img"">
                </div>
                <div class=""col-2"">
                    <p>This is the offer section</p>
                    <h1>Wall decor</h1>
                    <samall>For your personalized setup and one to one guide,  <br> description of the wall design and decoration</samall><br>
                    <br>
                    <a");
                BeginWriteAttribute("href", " href=\"", 9040, "\"", 9047, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""btn"">Buy Now &#8594;</a>
                </div>
            </div>
        </div>
    </div>

    <!-- Testomonial Section -->
    <div class=""testimonial"">
        <div class=""small-container"">
            <div class=""row"">
                <div class=""col-3"">
                    <i class=""fa fa-quote-left""></i>
                    <p>
                        Lorem ipsum, dolor sit amet consectetur adipisicing elit. Sit amet ipsam perspiciatis <br> Quasi
                        blanditiis reprehenderit perferendis harum quas et alias facilis culpa, earum dolor illum,<br>
                        corporis exercitationem accusantium cupiditate sapiente?
                    </p>
                    <i class=""fa fa-quote-right""></i>
                    <div class=""rating"">
                        <i class=""fa fa-star""></i>
                        <i class=""fa fa-star""></i>
                        <i class=""fa fa-star""></i>
                        <i class=""fa fa-star""></i>
          ");
                WriteLiteral(@"              <i class=""fa fa-star-half""></i>
                    </div>
                    <img src=""/images/sofa 1.jpg"">
                    <h3>Krishna Rijal</h3>
                </div>

                <div class=""col-3"">
                    <i class=""fa fa-quote-left""></i>
                    <p>
                        Lorem ipsum, dolor sit amet consectetur adipisicing elit. Sit amet ipsam perspiciatis <br>
                        Quasi blanditiis reprehenderit perferendis harum quas et alias facilis culpa, earum dolor
                        illum,<br> corporis exercitationem accusantium cupiditate sapiente?
                    </p>
                    <i class=""fa fa-quote-right""></i>
                    <div class=""rating"">
                        <i class=""fa fa-star""></i>
                        <i class=""fa fa-star""></i>
                        <i class=""fa fa-star""></i>
                        <i class=""fa fa-star""></i>
                        <i class=""fa fa-star-half""></i>");
                WriteLiteral(@"
                    </div>
                    <img src=""/images/sofa 1.jpg"">
                    <h3>Krishna Rijal</h3>
                </div>

                <div class=""col-3"">
                    <i class=""fa fa-quote-left""></i>
                    <p>
                        Lorem ipsum, dolor sit amet consectetur adipisicing elit. Sit amet ipsam perspiciatis
                        <br> Quasi blanditiis reprehenderit perferendis harum quas et alias facilis culpa, earum
                        dolor illum,<br> corporis exercitationem accusantium cupiditate sapiente?
                    </p>
                    <i class=""fa fa-quote-right""></i>
                    <div class=""rating"">
                        <i class=""fa fa-star""></i>
                        <i class=""fa fa-star""></i>
                        <i class=""fa fa-star""></i>
                        <i class=""fa fa-star""></i>
                        <i class=""fa fa-star-half""></i>
                    </div>
                 ");
                WriteLiteral(@"   <img src=""/images/sofa 1.jpg"">
                    <h3>Krishna Rijal</h3>
                </div>
            </div>
        </div>
    </div>
    <!-- Brands -->
    <div class=""brands"">
        <div class=""small-container"">
            <div class=""row"">
                <div class=""col-5"">
                    <img src=""./images/logo1.png"">
                </div>
                <div class=""col-5"">
                    <img src=""./images/logo2.png"">
                </div>
                <div class=""col-5"">
                    <img src=""./images/logo3.png"">
                </div>
                <div class=""col-5"">
                    <img src=""./images/logo4.png"">
                </div>
                <div class=""col-5"">
                    <img src=""./images/logo5.png"">
                </div>
            </div>
        </div>
    </div>
    <!-- footer -->
    <div class=""footer"">
        <div class=""container"">
            <div class=""row"">
                <div class=""foot");
                WriteLiteral(@"er-col-1"">
                    <h3>Download our apps</h3>
                    <p>Download our mobile and desktop app</p>
                </div>
                <div class=""footer-col-2"">
                    <h3>Download our apps</h3>
                    <p>Download our mobile and desktop app</p>
                </div>
                <div class=""footer-col-3"">
                    <h3>Download our apps</h3>
                    <p>Download our mobile and desktop app</p>
                </div>
                <div class=""footer-col-4"">
                    <h3>Download our apps</h3>
                    <p>Download our mobile and desktop app</p>
                </div>
                <div class=""footer-col-5"">
                    <h3>Download our apps</h3>
                    <p>Download our mobile and desktop app</p>
                </div>
            </div>
        </div>
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
            WriteLiteral("\r\n\r\n\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
