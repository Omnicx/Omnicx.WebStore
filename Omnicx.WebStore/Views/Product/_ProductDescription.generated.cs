﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using DevTrends.MvcDonutCaching;
    using Omnicx.WebStore;
    using Omnicx.WebStore.Core;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Product/_ProductDescription.cshtml")]
    public partial class _Views_Product__ProductDescription_cshtml : Omnicx.WebStore.Core.Services.Infrastructure.CustomBaseViewPage<Omnicx.WebStore.Models.Catalog.ProductDetailModel>
    {
        public _Views_Product__ProductDescription_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"col-sm-2 col-xs-12\"");

WriteLiteral(">\r\n        <h4");

WriteLiteral(" class=\"detailHeading\"");

WriteLiteral(" ng-show=\"pm.model.shortDescription!=\'\' && pm.model.shortDescription!=null\"");

WriteLiteral(">");

            
            #line 4 "..\..\Views\Product\_ProductDescription.cshtml"
                                                                                                        Write(LT("ProductDetail.Links.PRODUCTDESCRIPTION", "Description"));

            
            #line default
            #line hidden
WriteLiteral("</h4>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"col-sm-10 col-xs-12\"");

WriteLiteral(">\r\n        <p");

WriteLiteral(" class=\"faq-ans\"");

WriteLiteral("><span");

WriteLiteral(" ng-bind=\"pm.model.shortDescription\"");

WriteLiteral("></span></p>\r\n    </div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"panel panel-default margin-top-sm\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"panel-heading panelHeading bg-white\"");

WriteLiteral(">");

            
            #line 11 "..\..\Views\Product\_ProductDescription.cshtml"
                                                Write(LT("ProductDetail.Links.Specifications", "Specifications"));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n    <div");

WriteLiteral(" class=\"panel-body no-border\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12\"");

WriteLiteral(">\r\n                <p");

WriteLiteral(" class=\"faq-ans\"");

WriteLiteral(" ng-show=\"pm.model.brand!=\'\' && pm.model.brand!=null\"");

WriteLiteral(">\r\n                    <strong>");

            
            #line 16 "..\..\Views\Product\_ProductDescription.cshtml"
                       Write(LT("ProductListing.FacetHeading.Brand", "Brand"));

            
            #line default
            #line hidden
WriteLiteral(" </strong>\r\n                    <span");

WriteLiteral(" ng-bind=\"pm.model.brand\"");

WriteLiteral("></span>\r\n                </p>\r\n                <p");

WriteLiteral(" class=\"faq-ans\"");

WriteLiteral(" ng-show=\"pm.model.subBrand!=\'\' && pm.model.subBrand!=null\"");

WriteLiteral(">\r\n                    <strong>");

            
            #line 20 "..\..\Views\Product\_ProductDescription.cshtml"
                       Write(LT("Product.Label.Subbrand", "Sub-brand"));

            
            #line default
            #line hidden
WriteLiteral(" </strong>\r\n                    <span");

WriteLiteral(" ng-bind=\"pm.model.subBrand\"");

WriteLiteral("></span>\r\n                </p>\r\n                <p");

WriteLiteral(" class=\"faq-ans\"");

WriteLiteral(" ng-show=\"pm.model.uomValue!=\'\' && pm.model.uomValue!=null && pm.model.uomValue>0" +
"\"");

WriteLiteral(">\r\n                    <strong> ");

            
            #line 24 "..\..\Views\Product\_ProductDescription.cshtml"
                        Write(LT("Product.Label.Volume", "Volume"));

            
            #line default
            #line hidden
WriteLiteral(" </strong>\r\n                    <span");

WriteLiteral(" ng-bind=\"pm.model.uomValue\"");

WriteLiteral("></span> <span");

WriteLiteral(" ng-bind=\"pm.model.uom\"");

WriteLiteral("></span>\r\n                </p>\r\n                <p");

WriteLiteral(" class=\"faq-ans\"");

WriteLiteral(" ng-show=\"pm.model.stockCode!=\'\' && pm.model.stockCode!=null\"");

WriteLiteral(">\r\n                    <strong> ");

            
            #line 28 "..\..\Views\Product\_ProductDescription.cshtml"
                        Write(LT("ProductDetail.Label.StockCode", "Stock Code"));

            
            #line default
            #line hidden
WriteLiteral(" </strong>\r\n                    <span");

WriteLiteral(" ng-bind=\"pm.model.stockCode\"");

WriteLiteral("></span>\r\n                </p>\r\n                <p");

WriteLiteral(" class=\"faq-ans\"");

WriteLiteral(" ng-show=\"pm.model.currentStock!=\'\' && pm.model.currentStock!=null\"");

WriteLiteral(">\r\n                    <strong> ");

            
            #line 32 "..\..\Views\Product\_ProductDescription.cshtml"
                        Write(LT("Product.Label.CurrentStock", "Current Stock"));

            
            #line default
            #line hidden
WriteLiteral(" </strong>\r\n                    <span");

WriteLiteral(" ng-bind=\"pm.model.currentStock\"");

WriteLiteral("></span>\r\n                </p>\r\n                ");

WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
