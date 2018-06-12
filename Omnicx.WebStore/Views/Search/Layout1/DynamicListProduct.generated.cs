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
    
    #line 12 "..\..\Views\Search\Layout1\DynamicListProduct.cshtml"
    using Omnicx.API.SDK.Entities;
    
    #line default
    #line hidden
    
    #line 13 "..\..\Views\Search\Layout1\DynamicListProduct.cshtml"
    using Omnicx.API.SDK.Helpers;
    
    #line default
    #line hidden
    
    #line 14 "..\..\Views\Search\Layout1\DynamicListProduct.cshtml"
    using Omnicx.API.SDK.Models.Helpers;
    
    #line default
    #line hidden
    using Omnicx.WebStore;
    using Omnicx.WebStore.Core;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Search/Layout1/DynamicListProduct.cshtml")]
    public partial class _Views_Search_Layout1_DynamicListProduct_cshtml : Omnicx.WebStore.Core.Services.Infrastructure.CustomBaseViewPage<Omnicx.API.SDK.Models.Catalog.DynamicListModel>
    {
        public _Views_Search_Layout1_DynamicListProduct_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Search\Layout1\DynamicListProduct.cshtml"
  
/*
    Name: Dynamic Search List
    Purpose: Show Product list after search items
    Structure: /Views/Search/Layout1/DynamicListProduct.cshtml
    Contains (Partial Views Used):
        a-/Views/Search/Layout1/Search.cshtml

    Contained In (Where we Use this View):
    */

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 16 "..\..\Views\Search\Layout1\DynamicListProduct.cshtml"
  
    ViewBag.Title = Model != null ? Model.Name : "";
    Layout = "";
    Html.AddTitleParts(Model.Name);
    Html.AddMetaTitle(Model.MetaTitle);
    Html.AddMetaDescriptionParts(Model.MetaDescription);
    Html.AddMetaKeywordsParts(Model.MetaKeywords);
    Html.AddCanonicalUrl(Model.CanonicalTags);
    Html.AddDataLayer(DataLayerObjectType.CollectionDetail, Model);

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 27 "..\..\Views\Search\Layout1\DynamicListProduct.cshtml"
 if (Model != null)
{
    if (Model.ListType == ListDatasetSource.Product && Model.Products != null)
    {
        
            
            #line default
            #line hidden
            
            #line 31 "..\..\Views\Search\Layout1\DynamicListProduct.cshtml"
   Write(Html.Partial("~/Views/Search/Layout1/Search.cshtml", Model.Products));

            
            #line default
            #line hidden
            
            #line 31 "..\..\Views\Search\Layout1\DynamicListProduct.cshtml"
                                                                             
    }
}

            
            #line default
            #line hidden
WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591