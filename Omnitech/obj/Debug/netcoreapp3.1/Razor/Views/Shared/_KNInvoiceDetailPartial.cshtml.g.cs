#pragma checksum "D:\Project\Omnitech\Omnitech\Views\Shared\_KNInvoiceDetailPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83faa8a915fe238f9adf8c6431ab49ab619f7191"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Omnitech.Models.Shared.Views_Shared__KNInvoiceDetailPartial), @"mvc.1.0.view", @"/Views/Shared/_KNInvoiceDetailPartial.cshtml")]
namespace Omnitech.Models.Shared
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
#line 1 "D:\Project\Omnitech\Omnitech\Views\_ViewImports.cshtml"
using Omnitech;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Project\Omnitech\Omnitech\Views\_ViewImports.cshtml"
using DevExtreme.AspNet.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Project\Omnitech\Omnitech\Views\Shared\_KNInvoiceDetailPartial.cshtml"
using Omnitech.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Project\Omnitech\Omnitech\Views\Shared\_KNInvoiceDetailPartial.cshtml"
using Omnitech.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83faa8a915fe238f9adf8c6431ab49ab619f7191", @"/Views/Shared/_KNInvoiceDetailPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a176c098ad34cf0c9d5df9c28d487640da3cad4f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__KNInvoiceDetailPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<KNInvoiceDto>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "D:\Project\Omnitech\Omnitech\Views\Shared\_KNInvoiceDetailPartial.cshtml"
Write(
Html.DevExtreme().DataGrid<KNInvoiceDetail>()
    .ShowBorders(true)
    .ID("knInvoiceDetailDataContainer")
    .DataSource(Model.KNInvoiceDetails, new[] { "ID" })
    .DataSource(Model.KNInvoiceDetails)
    .HoverStateEnabled(true)
    .ShowBorders(true)
    .Columns(columns =>
        {
            columns.AddFor(m => m.LOGICALREF).HeaderCellTemplate("LOGICALREF");
            columns.AddFor(m => m.SKU).HeaderCellTemplate("Sku");
            columns.AddFor(m => m.TARIX).HeaderCellTemplate("TARIX");
            columns.AddFor(m => m.MIQDAR).HeaderCellTemplate("MIQDAR");
            columns.AddFor(m => m.MEBLEG).HeaderCellTemplate("MEBLEG");
            columns.AddFor(m => m.CLIENT).HeaderCellTemplate("CLIENT");
            columns.AddFor(m => m.MEHSULUN_KODU).HeaderCellTemplate("MEHSULUN_KODU");
            columns.AddFor(m => m.MEHSULUN_ADI).HeaderCellTemplate("MEHSULUN_ADI");
            columns.AddFor(m => m.ISTEHSALCHI).HeaderCellTemplate("ISTEHSALCHI");
            columns.AddFor(m => m.BARCODE).HeaderCellTemplate("BARCODE");
            columns.AddFor(m => m.VAHID).HeaderCellTemplate("VAHID");
            columns.AddFor(m => m.EDEDSAYI).HeaderCellTemplate("EDEDSAYI");
            columns.AddFor(m => m.FIRMA).HeaderCellTemplate("FIRMA");
            //columns.AddFor(m => m.DELETED).AllowHiding(true);
        })
    .Selection(s => s.Mode(SelectionMode.Single))
    .AllowColumnResizing(true)
    .Paging(p => p.PageSize(1000))
    .Pager(x=>x.Option("foo", x))
    .FilterRow(f => f.Visible(true))
    .HeaderFilter(f => f.Visible(true))
    .GroupPanel(p => p.Visible(true))
    .Grouping(g => g.AutoExpandAll(false))
   .Summary(s => s
         .TotalItems(totalItems =>
         {
             totalItems.AddFor(m => m.MEBLEG).SummaryType(SummaryType.Sum).DisplayFormat("Cəm: {0}");
             totalItems.AddFor(m => m.LOGICALREF).SummaryType(SummaryType.Count).DisplayFormat("Cəm: {0}");
             
         })
     )
);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n<input id=\"printed_amount_from_db\" type=\"hidden\" disabled");
            BeginWriteAttribute("value", " value=\"", 2135, "\"", 2165, 1);
#nullable restore
#line 50 "D:\Project\Omnitech\Omnitech\Views\Shared\_KNInvoiceDetailPartial.cshtml"
WriteAttributeValue("", 2143, ViewBag.PrintedAmount, 2143, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n<input id=\"difference_from_db\" type=\"hidden\" disabled");
            BeginWriteAttribute("value", " value=\"", 2224, "\"", 2251, 1);
#nullable restore
#line 51 "D:\Project\Omnitech\Omnitech\Views\Shared\_KNInvoiceDetailPartial.cshtml"
WriteAttributeValue("", 2232, ViewBag.Difference, 2232, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KNInvoiceDto> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591