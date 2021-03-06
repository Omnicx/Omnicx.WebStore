﻿using Omnicx.WebStore.Models.Common;
using Omnicx.WebStore.Models.Enums;
using Omnicx.WebStore.Models.Keys;
using System;
using System.Collections.Generic;


namespace Omnicx.WebStore.Models.Commerce
{
    public class ReturnModel 
    {
        public String Id { get; set; }
        public string OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public Amount GrandTotal { get; set; }
        public Amount SubTotal { get; set; }
        public Amount ShippingCharge { get; set; }
        public Amount Tax { get; set; }
        public OrderStatus Status { get; set; }
        public string ItemXml { get; set; }
        public string StatusLabel { get; set; }
        public string ReasonForReturnId { get; set; }
        public string RequiredActionId { get; set; }
        public string Comment { get; set; }
        public List<ReturnLineModel> LineItems { get; set; }
        public string CurrencyCode { get; set; }
        public string CurrencySymbol { get; set; }
        public byte RettunStatus { get; set; }
        public string Email { get; set; }
    }
}