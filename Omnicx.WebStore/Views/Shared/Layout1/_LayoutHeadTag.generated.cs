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
    
    #line 16 "..\..\Views\Shared\Layout1\_LayoutHeadTag.cshtml"
    using Omnicx.API.SDK.Entities;
    
    #line default
    #line hidden
    
    #line 17 "..\..\Views\Shared\Layout1\_LayoutHeadTag.cshtml"
    using Omnicx.API.SDK.Helpers;
    
    #line default
    #line hidden
    using Omnicx.WebStore;
    using Omnicx.WebStore.Core;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/Layout1/_LayoutHeadTag.cshtml")]
    public partial class _Views_Shared_Layout1__LayoutHeadTag_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared_Layout1__LayoutHeadTag_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Shared\Layout1\_LayoutHeadTag.cshtml"
  
/*
    Name: Body Tags
    Purpose: Place all the css and head tags
    Structure: /Views/Shared/Layout1/_LayoutHeadTag.cshtml
    Contains (Partial Views Used):

    Contained In (Where we Use this View):
        a-/Views/Shared/Layout1/_Layout.cshtml
        b-/Views/Shared/Layout1/_LayoutAccount.cshtml
        c-/Views/Shared/Layout1/_LayoutBlog.cshtml
        d-/Views/Shared/Layout1/_LayoutCMS.cshtml
        e-/Views/Shared/Layout1/_OpcLayout.cshtml
    */

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 18 "..\..\Views\Shared\Layout1\_LayoutHeadTag.cshtml"
  
    var StoreTheme = ConfigKeys.StoreTheme;

            
            #line default
            #line hidden
WriteLiteral("\r\n<head>\r\n    <title>");

            
            #line 22 "..\..\Views\Shared\Layout1\_LayoutHeadTag.cshtml"
      Write(Html.Title(false));

            
            #line default
            #line hidden
WriteLiteral("</title>\r\n    <meta");

WriteLiteral(" name=\"description\"");

WriteAttribute("content", Tuple.Create(" content=\"", 675), Tuple.Create("\"", 710)
            
            #line 23 "..\..\Views\Shared\Layout1\_LayoutHeadTag.cshtml"
, Tuple.Create(Tuple.Create("", 685), Tuple.Create<System.Object, System.Int32>(Html.MetaDescription()
            
            #line default
            #line hidden
, 685), false)
);

WriteLiteral(" />\r\n    <meta");

WriteLiteral(" name=\"title\"");

WriteAttribute("content", Tuple.Create(" content=\"", 738), Tuple.Create("\"", 767)
            
            #line 24 "..\..\Views\Shared\Layout1\_LayoutHeadTag.cshtml"
, Tuple.Create(Tuple.Create("", 748), Tuple.Create<System.Object, System.Int32>(Html.MetaTitle()
            
            #line default
            #line hidden
, 748), false)
);

WriteLiteral(">\r\n    <meta");

WriteLiteral(" name=\"keywords\"");

WriteAttribute("content", Tuple.Create(" content=\"", 796), Tuple.Create("\"", 828)
            
            #line 25 "..\..\Views\Shared\Layout1\_LayoutHeadTag.cshtml"
, Tuple.Create(Tuple.Create("", 806), Tuple.Create<System.Object, System.Int32>(Html.MetaKeywords()
            
            #line default
            #line hidden
, 806), false)
);

WriteLiteral(">\r\n    <meta");

WriteLiteral(" charset=\"UTF-8\"");

WriteLiteral(">\r\n    <meta");

WriteLiteral(" http-equiv=\"x-ua-compatible\"");

WriteLiteral(" content=\"IE=edge\"");

WriteLiteral(">\r\n    <meta");

WriteLiteral(" name=\"viewport\"");

WriteLiteral(" content=\"width=device-width, initial-scale=1.0, maximum-scale=1, user-scalable=n" +
"o\"");

WriteLiteral(">\r\n    <link");

WriteLiteral(" rel=\"apple-touch-icon\"");

WriteLiteral(" sizes=\"57x57\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1076), Tuple.Create("\"", 1144)
, Tuple.Create(Tuple.Create("", 1083), Tuple.Create("/assets/theme/", 1083), true)
            
            #line 29 "..\..\Views\Shared\Layout1\_LayoutHeadTag.cshtml"
, Tuple.Create(Tuple.Create("", 1097), Tuple.Create<System.Object, System.Int32>(StoreTheme
            
            #line default
            #line hidden
, 1097), false)
, Tuple.Create(Tuple.Create("", 1108), Tuple.Create("/images/favicon/apple-icon-57x57.png", 1108), true)
);

WriteLiteral(">\r\n    <link");

WriteLiteral(" rel=\"apple-touch-icon\"");

WriteLiteral(" sizes=\"60x60\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1194), Tuple.Create("\"", 1262)
, Tuple.Create(Tuple.Create("", 1201), Tuple.Create("/assets/theme/", 1201), true)
            
            #line 30 "..\..\Views\Shared\Layout1\_LayoutHeadTag.cshtml"
, Tuple.Create(Tuple.Create("", 1215), Tuple.Create<System.Object, System.Int32>(StoreTheme
            
            #line default
            #line hidden
, 1215), false)
, Tuple.Create(Tuple.Create("", 1226), Tuple.Create("/images/favicon/apple-icon-60x60.png", 1226), true)
);

WriteLiteral(">\r\n    <link");

WriteLiteral(" rel=\"apple-touch-icon\"");

WriteLiteral(" sizes=\"72x72\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1312), Tuple.Create("\"", 1380)
, Tuple.Create(Tuple.Create("", 1319), Tuple.Create("/assets/theme/", 1319), true)
            
            #line 31 "..\..\Views\Shared\Layout1\_LayoutHeadTag.cshtml"
, Tuple.Create(Tuple.Create("", 1333), Tuple.Create<System.Object, System.Int32>(StoreTheme
            
            #line default
            #line hidden
, 1333), false)
, Tuple.Create(Tuple.Create("", 1344), Tuple.Create("/images/favicon/apple-icon-72x72.png", 1344), true)
);

WriteLiteral(">\r\n    <link");

WriteLiteral(" rel=\"apple-touch-icon\"");

WriteLiteral(" sizes=\"76x76\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1430), Tuple.Create("\"", 1498)
, Tuple.Create(Tuple.Create("", 1437), Tuple.Create("/assets/theme/", 1437), true)
            
            #line 32 "..\..\Views\Shared\Layout1\_LayoutHeadTag.cshtml"
, Tuple.Create(Tuple.Create("", 1451), Tuple.Create<System.Object, System.Int32>(StoreTheme
            
            #line default
            #line hidden
, 1451), false)
, Tuple.Create(Tuple.Create("", 1462), Tuple.Create("/images/favicon/apple-icon-76x76.png", 1462), true)
);

WriteLiteral(">\r\n    <link");

WriteLiteral(" rel=\"apple-touch-icon\"");

WriteLiteral(" sizes=\"114x114\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1550), Tuple.Create("\"", 1620)
, Tuple.Create(Tuple.Create("", 1557), Tuple.Create("/assets/theme/", 1557), true)
            
            #line 33 "..\..\Views\Shared\Layout1\_LayoutHeadTag.cshtml"
, Tuple.Create(Tuple.Create("", 1571), Tuple.Create<System.Object, System.Int32>(StoreTheme
            
            #line default
            #line hidden
, 1571), false)
, Tuple.Create(Tuple.Create("", 1582), Tuple.Create("/images/favicon/apple-icon-114x114.png", 1582), true)
);

WriteLiteral(">\r\n    <link");

WriteLiteral(" rel=\"apple-touch-icon\"");

WriteLiteral(" sizes=\"120x120\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1672), Tuple.Create("\"", 1742)
, Tuple.Create(Tuple.Create("", 1679), Tuple.Create("/assets/theme/", 1679), true)
            
            #line 34 "..\..\Views\Shared\Layout1\_LayoutHeadTag.cshtml"
, Tuple.Create(Tuple.Create("", 1693), Tuple.Create<System.Object, System.Int32>(StoreTheme
            
            #line default
            #line hidden
, 1693), false)
, Tuple.Create(Tuple.Create("", 1704), Tuple.Create("/images/favicon/apple-icon-120x120.png", 1704), true)
);

WriteLiteral(">\r\n    <link");

WriteLiteral(" rel=\"apple-touch-icon\"");

WriteLiteral(" sizes=\"144x144\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1794), Tuple.Create("\"", 1864)
, Tuple.Create(Tuple.Create("", 1801), Tuple.Create("/assets/theme/", 1801), true)
            
            #line 35 "..\..\Views\Shared\Layout1\_LayoutHeadTag.cshtml"
, Tuple.Create(Tuple.Create("", 1815), Tuple.Create<System.Object, System.Int32>(StoreTheme
            
            #line default
            #line hidden
, 1815), false)
, Tuple.Create(Tuple.Create("", 1826), Tuple.Create("/images/favicon/apple-icon-144x144.png", 1826), true)
);

WriteLiteral(">\r\n    <link");

WriteLiteral(" rel=\"apple-touch-icon\"");

WriteLiteral(" sizes=\"152x152\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1916), Tuple.Create("\"", 1986)
, Tuple.Create(Tuple.Create("", 1923), Tuple.Create("/assets/theme/", 1923), true)
            
            #line 36 "..\..\Views\Shared\Layout1\_LayoutHeadTag.cshtml"
, Tuple.Create(Tuple.Create("", 1937), Tuple.Create<System.Object, System.Int32>(StoreTheme
            
            #line default
            #line hidden
, 1937), false)
, Tuple.Create(Tuple.Create("", 1948), Tuple.Create("/images/favicon/apple-icon-152x152.png", 1948), true)
);

WriteLiteral(">\r\n    <link");

WriteLiteral(" rel=\"apple-touch-icon\"");

WriteLiteral(" sizes=\"180x180\"");

WriteAttribute("href", Tuple.Create(" href=\"", 2038), Tuple.Create("\"", 2108)
, Tuple.Create(Tuple.Create("", 2045), Tuple.Create("/assets/theme/", 2045), true)
            
            #line 37 "..\..\Views\Shared\Layout1\_LayoutHeadTag.cshtml"
, Tuple.Create(Tuple.Create("", 2059), Tuple.Create<System.Object, System.Int32>(StoreTheme
            
            #line default
            #line hidden
, 2059), false)
, Tuple.Create(Tuple.Create("", 2070), Tuple.Create("/images/favicon/apple-icon-180x180.png", 2070), true)
);

WriteLiteral(">\r\n    <link");

WriteLiteral(" rel=\"icon\"");

WriteLiteral(" type=\"image/png\"");

WriteLiteral(" sizes=\"192x192\"");

WriteAttribute("href", Tuple.Create(" href=\"", 2165), Tuple.Create("\"", 2237)
, Tuple.Create(Tuple.Create("", 2172), Tuple.Create("/assets/theme/", 2172), true)
            
            #line 38 "..\..\Views\Shared\Layout1\_LayoutHeadTag.cshtml"
, Tuple.Create(Tuple.Create("", 2186), Tuple.Create<System.Object, System.Int32>(StoreTheme
            
            #line default
            #line hidden
, 2186), false)
, Tuple.Create(Tuple.Create("", 2197), Tuple.Create("/images/favicon/android-icon-192x192.png", 2197), true)
);

WriteLiteral(">\r\n    <link");

WriteLiteral(" rel=\"icon\"");

WriteLiteral(" type=\"image/png\"");

WriteLiteral(" sizes=\"32x32\"");

WriteAttribute("href", Tuple.Create(" href=\"", 2292), Tuple.Create("\"", 2357)
, Tuple.Create(Tuple.Create("", 2299), Tuple.Create("/assets/theme/", 2299), true)
            
            #line 39 "..\..\Views\Shared\Layout1\_LayoutHeadTag.cshtml"
, Tuple.Create(Tuple.Create("", 2313), Tuple.Create<System.Object, System.Int32>(StoreTheme
            
            #line default
            #line hidden
, 2313), false)
, Tuple.Create(Tuple.Create("", 2324), Tuple.Create("/images/favicon/favicon-32x32.png", 2324), true)
);

WriteLiteral(">\r\n    <link");

WriteLiteral(" rel=\"icon\"");

WriteLiteral(" type=\"image/png\"");

WriteLiteral(" sizes=\"96x96\"");

WriteAttribute("href", Tuple.Create(" href=\"", 2412), Tuple.Create("\"", 2477)
, Tuple.Create(Tuple.Create("", 2419), Tuple.Create("/assets/theme/", 2419), true)
            
            #line 40 "..\..\Views\Shared\Layout1\_LayoutHeadTag.cshtml"
, Tuple.Create(Tuple.Create("", 2433), Tuple.Create<System.Object, System.Int32>(StoreTheme
            
            #line default
            #line hidden
, 2433), false)
, Tuple.Create(Tuple.Create("", 2444), Tuple.Create("/images/favicon/favicon-96x96.png", 2444), true)
);

WriteLiteral(">\r\n    <link");

WriteLiteral(" rel=\"icon\"");

WriteLiteral(" type=\"image/png\"");

WriteLiteral(" sizes=\"16x16\"");

WriteAttribute("href", Tuple.Create(" href=\"", 2532), Tuple.Create("\"", 2597)
, Tuple.Create(Tuple.Create("", 2539), Tuple.Create("/assets/theme/", 2539), true)
            
            #line 41 "..\..\Views\Shared\Layout1\_LayoutHeadTag.cshtml"
, Tuple.Create(Tuple.Create("", 2553), Tuple.Create<System.Object, System.Int32>(StoreTheme
            
            #line default
            #line hidden
, 2553), false)
, Tuple.Create(Tuple.Create("", 2564), Tuple.Create("/images/favicon/favicon-16x16.png", 2564), true)
);

WriteLiteral(">\r\n\r\n    <link");

WriteLiteral(" rel=\"shortcut icon\"");

WriteAttribute("href", Tuple.Create(" href=\"", 2632), Tuple.Create("\"", 2691)
, Tuple.Create(Tuple.Create("", 2639), Tuple.Create("/assets/theme/", 2639), true)
            
            #line 43 "..\..\Views\Shared\Layout1\_LayoutHeadTag.cshtml"
, Tuple.Create(Tuple.Create("", 2653), Tuple.Create<System.Object, System.Int32>(StoreTheme
            
            #line default
            #line hidden
, 2653), false)
, Tuple.Create(Tuple.Create("", 2664), Tuple.Create("/images/favicon/favicon.ico", 2664), true)
);

WriteLiteral(">\r\n    <meta");

WriteLiteral(" name=\"msapplication-TileColor\"");

WriteLiteral(" content=\"#ffffff\"");

WriteLiteral(">\r\n    <meta");

WriteLiteral(" name=\"msapplication-TileImage\"");

WriteAttribute("content", Tuple.Create(" content=\"", 2796), Tuple.Create("\"", 2866)
, Tuple.Create(Tuple.Create("", 2806), Tuple.Create("/assets/theme/", 2806), true)
            
            #line 45 "..\..\Views\Shared\Layout1\_LayoutHeadTag.cshtml"
, Tuple.Create(Tuple.Create("", 2820), Tuple.Create<System.Object, System.Int32>(StoreTheme
            
            #line default
            #line hidden
, 2820), false)
, Tuple.Create(Tuple.Create("", 2831), Tuple.Create("/images/favicon/ms-icon-144x144.png", 2831), true)
);

WriteLiteral(">\r\n    <meta");

WriteLiteral(" name=\"theme-color\"");

WriteLiteral(" content=\"#ffffff\"");

WriteLiteral(">\r\n\r\n");

WriteLiteral("    ");

            
            #line 48 "..\..\Views\Shared\Layout1\_LayoutHeadTag.cshtml"
Write(Html.CanonicalUrl());

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n    <link");

WriteLiteral(" href=\'//fonts.googleapis.com/css?family=Montserrat:400,700|Merriweather:400,400i" +
"talic\'");

WriteLiteral(" rel=\'stylesheet\'");

WriteLiteral(" type=\'text/css\'");

WriteLiteral(">\r\n    <link");

WriteLiteral(" href=\"//fonts.googleapis.com/css?family=Open+Sans:400,600,700\"");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(">\r\n    <link");

WriteLiteral(" href=\"https://fonts.googleapis.com/css?family=Poppins\"");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(">\r\n    <link");

WriteLiteral(" href=\"//maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css\"");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" type=\"text/css\"");

WriteLiteral(" />\r\n");

WriteLiteral("    ");

            
            #line 54 "..\..\Views\Shared\Layout1\_LayoutHeadTag.cshtml"
Write(Styles.Render("~/bundles/style-css"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n    <!-- Responsivity for older IE -->\r\n    <!--[if lt IE 9]>\r\n        <scrip" +
"t src=\"~/assets/js/js-lib/respond.min.js\"></script>\r\n    <![endif]-->\r\n    ");

WriteLiteral("\r\n    <script>\r\n            dataLayer = ");

            
            #line 62 "..\..\Views\Shared\Layout1\_LayoutHeadTag.cshtml"
                   Write(Html.DataLayer());

            
            #line default
            #line hidden
WriteLiteral(";\r\n    </script>\r\n\r\n");

            
            #line 65 "..\..\Views\Shared\Layout1\_LayoutHeadTag.cshtml"
    
            
            #line default
            #line hidden
            
            #line 65 "..\..\Views\Shared\Layout1\_LayoutHeadTag.cshtml"
     if (@Html.GetOmnilyticId().ToString() != "")
    {

            
            #line default
            #line hidden
WriteLiteral("        <script");

WriteAttribute("src", Tuple.Create(" src=\"", 3904), Tuple.Create("\"", 3933)
            
            #line 67 "..\..\Views\Shared\Layout1\_LayoutHeadTag.cshtml"
, Tuple.Create(Tuple.Create("", 3910), Tuple.Create<System.Object, System.Int32>(Html.GetOmnilyticUrl()
            
            #line default
            #line hidden
, 3910), false)
);

WriteLiteral("></script>\r\n");

WriteLiteral("        <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">omnilytics.init(\'");

            
            #line 68 "..\..\Views\Shared\Layout1\_LayoutHeadTag.cshtml"
                                                   Write(Html.GetOmnilyticId());

            
            #line default
            #line hidden
WriteLiteral("\', \'dataLayer\')</script>\r\n");

            
            #line 69 "..\..\Views\Shared\Layout1\_LayoutHeadTag.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</head>\r\n");

        }
    }
}
#pragma warning restore 1591