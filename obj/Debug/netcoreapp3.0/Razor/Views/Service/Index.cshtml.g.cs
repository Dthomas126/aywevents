#pragma checksum "/home/devinthomas/Desktop/aywevents/Views/Service/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4af2bd1b3be0714ff19f6c3175c5c9997792f4bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Service_Index), @"mvc.1.0.view", @"/Views/Service/Index.cshtml")]
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
#line 1 "/home/devinthomas/Desktop/aywevents/Views/_ViewImports.cshtml"
using aywevents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/devinthomas/Desktop/aywevents/Views/_ViewImports.cshtml"
using aywevents.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4af2bd1b3be0714ff19f6c3175c5c9997792f4bb", @"/Views/Service/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"981192cf28a07dd9a35bc230538ae0eb07a73650", @"/Views/_ViewImports.cshtml")]
    public class Views_Service_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<aywevents.Models.Service>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "/home/devinthomas/Desktop/aywevents/Views/Service/Index.cshtml"
    
  ViewData["Title"] = "Index";
  

#line default
#line hidden
#nullable disable
            WriteLiteral("  <section>\r\n<section class=\"container pt-5\">\r\n\r\n  <div class=\"pt-5\">\r\n  <h1>Index</h1>\r\n\r\n  <p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4af2bd1b3be0714ff19f6c3175c5c9997792f4bb3621", async() => {
                WriteLiteral("Create New Service");
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
            WriteLiteral("\r\n  </p>\r\n  <div id=\"accordion\">\r\n    <div class=\"row\">\r\n      <div class=\"col-lg-4\">\r\n        <div class=\"nav flex-column nav-pills\" id=\"v-pills-tab\" role=\"tablist\" aria-orientation=\"vertical\">\r\n");
#nullable restore
#line 19 "/home/devinthomas/Desktop/aywevents/Views/Service/Index.cshtml"
           foreach (var item in Model)
          {

#line default
#line hidden
#nullable disable
            WriteLiteral("          <a class=\"nav-link \"");
            BeginWriteAttribute("id", " id=\"", 517, "\"", 532, 1);
#nullable restore
#line 21 "/home/devinthomas/Desktop/aywevents/Views/Service/Index.cshtml"
WriteAttributeValue("", 522, item.Name, 522, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"pill\"");
            BeginWriteAttribute("href", " href=\"", 552, "\"", 568, 2);
            WriteAttributeValue("", 559, "#", 559, 1, true);
#nullable restore
#line 21 "/home/devinthomas/Desktop/aywevents/Views/Service/Index.cshtml"
WriteAttributeValue("", 560, item.ID, 560, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"tab\"\r\n            aria-controls=\"v-pills-home\" aria-selected=\"true\">");
#nullable restore
#line 22 "/home/devinthomas/Desktop/aywevents/Views/Service/Index.cshtml"
                                                         Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 23 "/home/devinthomas/Desktop/aywevents/Views/Service/Index.cshtml"
          }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n      </div>\r\n      <div class=\"col-lg-4\">\r\n        <div class=\"tab-content\" id=\"v-pills-tabContent\">\r\n");
#nullable restore
#line 28 "/home/devinthomas/Desktop/aywevents/Views/Service/Index.cshtml"
           foreach (var item in Model)
          {

#line default
#line hidden
#nullable disable
            WriteLiteral("          <div class=\"tab-pane fade show \"");
            BeginWriteAttribute("id", " id=\"", 887, "\"", 900, 1);
#nullable restore
#line 30 "/home/devinthomas/Desktop/aywevents/Views/Service/Index.cshtml"
WriteAttributeValue("", 892, item.ID, 892, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"tabpanel\"");
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 917, "\"", 945, 1);
#nullable restore
#line 30 "/home/devinthomas/Desktop/aywevents/Views/Service/Index.cshtml"
WriteAttributeValue("", 935, item.Name, 935, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            ");
#nullable restore
#line 31 "/home/devinthomas/Desktop/aywevents/Views/Service/Index.cshtml"
       Write(item.Details);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n          </div>\r\n");
#nullable restore
#line 33 "/home/devinthomas/Desktop/aywevents/Views/Service/Index.cshtml"

          }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
      </div>
    </div>
    </div>

    
  </section>

  <section class=""m-0"">
      <div class=""container pt-5"">
        
    <div class=""row"">
      <div class=""col-lg-3"">
        <div class=""card p-4"">
          <div class=""card-body text-center"">
            <h1 class=""card-title"" > <i class=""fas fa-glass-cheers"" style=""font-size: 60px""></i> </h1>
            <h4 class=""card-text"">Weddings</h4>
            <button class=""btn btn-primary"">Learn more</button>
          </div>
        </div>
      </div>
      <div class=""col-lg-3"">
          <div class=""card p-4"">
              <div class=""card-body text-center"">
                <h1 class=""card-title"" > <i class=""fab fa-accusoft"" style=""font-size: 60px""></i> </h1>
                <h4 class=""card-text"">Private</h4>
                <button class=""btn btn-primary"">Learn more</button>
              </div>
            </div>
      </div>
      <div class=""col-lg-3"">
          <div class=""card p-4"">
              <di");
            WriteLiteral(@"v class=""card-body text-center"">
                <h1 class=""card-title"" > <i class=""fas fa-birthday-cake"" style=""font-size: 60px""></i> </h1>
                <h4 class=""card-text"">Birthday's</h4>
                <button class=""btn btn-primary"">Learn more</button>
              </div>
            </div>
      </div>
      <div class=""col-lg-3"">
          <div class=""card p-4"">
              <div class=""card-body text-center"">
                <h1 class=""card-title"" > <i class=""fas fa-gift"" style=""font-size: 60px""></i> </h1>
                <h4 class=""card-text"">Commercial</h4>
                <button class=""btn btn-primary"">Learn more</button>
              </div>
            </div>
      </div>
    </div>
    
    </div>
    </section>
  </section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<aywevents.Models.Service>> Html { get; private set; }
    }
}
#pragma warning restore 1591
