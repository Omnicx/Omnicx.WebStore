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
    
    #line 14 "..\..\Views\Category\Layout1\CategoryProducts.cshtml"
    using Microsoft.Web.Mvc;
    
    #line default
    #line hidden
    
    #line 18 "..\..\Views\Category\Layout1\CategoryProducts.cshtml"
    using Omnicx.API.SDK.Entities;
    
    #line default
    #line hidden
    
    #line 19 "..\..\Views\Category\Layout1\CategoryProducts.cshtml"
    using Omnicx.API.SDK.Helpers;
    
    #line default
    #line hidden
    
    #line 20 "..\..\Views\Category\Layout1\CategoryProducts.cshtml"
    using Omnicx.API.SDK.Models.Catalog;
    
    #line default
    #line hidden
    using Omnicx.WebStore;
    using Omnicx.WebStore.Core;
    
    #line 16 "..\..\Views\Category\Layout1\CategoryProducts.cshtml"
    using Omnicx.WebStore.Core.Controllers;
    
    #line default
    #line hidden
    
    #line 15 "..\..\Views\Category\Layout1\CategoryProducts.cshtml"
    using Omnicx.WebStore.Core.Helpers;
    
    #line default
    #line hidden
    
    #line 17 "..\..\Views\Category\Layout1\CategoryProducts.cshtml"
    using Omnicx.WebStore.Framework.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Category/Layout1/CategoryProducts.cshtml")]
    public partial class _Views_Category_Layout1_CategoryProducts_cshtml : Omnicx.WebStore.Core.Services.Infrastructure.CustomBaseViewPage<Omnicx.API.SDK.Models.Catalog.CategoryModel>
    {
        public _Views_Category_Layout1_CategoryProducts_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Category\Layout1\CategoryProducts.cshtml"
  
/*
    Name: Category listing
    Purpose: Category List View
    Structure: /Views/Category/Layout1/CategoryProducts.cshtml
    Contains (Partial Views Used):
        a-/Views/Shared/Layout1/_Layout.cshtml.cshtml           (For base Structure)
        b-/Views/Shared/_BreadCrumb.cshtml                      (Dynamic Breadcrumb view)
        c-/Views/search/Layout1/_SearchResultProducts.cshtml    (Product listing of selected category)

    Contained In (Where we Use this View):
    */

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 22 "..\..\Views\Category\Layout1\CategoryProducts.cshtml"
  
    ViewBag.Title = @LT("ProductDetail.Label.Search" , "Search");
    Layout = "~/Views/Shared/Layout1/_Layout.cshtml";
    CategoryModel metaInfo = (CategoryModel)ViewBag.MetaInfo;
    Html.AddDataLayer(DataLayerObjectType.CategoryDetail, Model);

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 28 "..\..\Views\Category\Layout1\CategoryProducts.cshtml"
 if (metaInfo != null)
{

    Html.AddTitleParts(metaInfo.Name);
    Html.AddMetaTitle(metaInfo.MetaTitle);
    Html.AddMetaDescriptionParts(metaInfo.MetaDescription);
    Html.AddMetaKeywordsParts(metaInfo.MetaKeywords);
    Html.AddCanonicalUrl(metaInfo.CanonicalTags);
}

            
            #line default
            #line hidden
WriteLiteral("<div");

WriteLiteral(" class=\"col-md-12 col-xs-12 no-padding\"");

WriteLiteral(">\r\n    <ul");

WriteLiteral(" class=\"breadcrumb\"");

WriteLiteral(">\r\n        <li><a");

WriteLiteral(" href=\"/\"");

WriteLiteral(">");

            
            #line 39 "..\..\Views\Category\Layout1\CategoryProducts.cshtml"
                   Write(LT("ProductListing.Breadcrumb.Home", "Home"));

            
            #line default
            #line hidden
WriteLiteral("</a></li>       \r\n");

            
            #line 40 "..\..\Views\Category\Layout1\CategoryProducts.cshtml"
        
            
            #line default
            #line hidden
            
            #line 40 "..\..\Views\Category\Layout1\CategoryProducts.cshtml"
         if (Model.BreadCrumbs != null)
        {
            var catBreadCrumb = Model.BreadCrumbs.FirstOrDefault(x => x.SlugType == EntitySlugTypes.Category.ToString());
            if (catBreadCrumb != null && catBreadCrumb.Slug != null)
            {
                
            
            #line default
            #line hidden
            
            #line 45 "..\..\Views\Category\Layout1\CategoryProducts.cshtml"
           Write(Html.Partial("~/Views/Shared/_BreadCrumb.cshtml", catBreadCrumb.Slug));

            
            #line default
            #line hidden
            
            #line 45 "..\..\Views\Category\Layout1\CategoryProducts.cshtml"
                                                                                      ;
            }
        }

            
            #line default
            #line hidden
WriteLiteral("        <li><a");

WriteLiteral(" href=\"#\"");

WriteLiteral("></a>");

            
            #line 48 "..\..\Views\Category\Layout1\CategoryProducts.cshtml"
                       Write(Model.Name);

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n    </ul>\r\n</div>\r\n\r\n");

            
            #line 52 "..\..\Views\Category\Layout1\CategoryProducts.cshtml"
Write(Html.Partial("~/Views/search/Layout1/_SearchResultProducts.cshtml" , Model.ProductList));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

DefineSection("scripts", () => {

WriteLiteral("\r\n    <script>\r\n        var searchProductUrl = \'");

            
            #line 56 "..\..\Views\Category\Layout1\CategoryProducts.cshtml"
                            Write(Html.BuildUrlFromExpression<SearchController>(c => c.SearchProducts(null)));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var productUrl = \'");

            
            #line 57 "..\..\Views\Category\Layout1\CategoryProducts.cshtml"
                      Write(Html.BuildUrlFromExpression<ProductController>(c => c.ProductDetails("")));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var addToWishlistUrl = \'");

            
            #line 58 "..\..\Views\Category\Layout1\CategoryProducts.cshtml"
                            Write(Html.BuildUrlFromExpression<AccountController>(c => c.AddProductToWishlist(null)));

            
            #line default
            #line hidden
WriteLiteral("\';     \r\n        var getWishlist = \'");

            
            #line 59 "..\..\Views\Category\Layout1\CategoryProducts.cshtml"
                       Write(Html.BuildUrlFromExpression<AccountController>(c => c.GetWishlist()));

            
            #line default
            #line hidden
WriteLiteral(@"'; 
        window.app.constant('productConfig',{
            searchProductUrl:searchProductUrl,
            productUrl : productUrl,
            addToWishlistUrl : addToWishlistUrl,           
            getWishlist:getWishlist
        });
        window.app.constant('model', ");

            
            #line 66 "..\..\Views\Category\Layout1\CategoryProducts.cshtml"
                                Write(Html.JsonFor(Model));

            
            #line default
            #line hidden
WriteLiteral(");\r\n    </script>\r\n");

});

        }
    }
}
#pragma warning restore 1591