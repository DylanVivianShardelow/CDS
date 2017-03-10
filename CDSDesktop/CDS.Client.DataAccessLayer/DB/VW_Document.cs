//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CDS.Client.DataAccessLayer.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class VW_Document
    {
        public long Id { get; set; }
        public long TransactionId { get; set; }
        public long HeaderId { get; set; }
        public Nullable<byte> TypeId { get; set; }
        public byte ShippingTypeId { get; set; }
        public long CompanyId { get; set; }
        public long TrackId { get; set; }
        public string TransactionType { get; set; }
        public Nullable<long> DocumentNumber { get; set; }
        public string CompanyName { get; set; }
        public string ShippingTypeName { get; set; }
        public Nullable<System.DateTime> DatePosted { get; set; }
        public Nullable<System.DateTime> DayPosted { get; set; }
        public Nullable<System.DateTime> DateFirstPrinted { get; set; }
        public Nullable<System.DateTime> DateLastPrinted { get; set; }
        public Nullable<System.DateTime> DateValid { get; set; }
        public string ReferenceShort1 { get; set; }
        public string ReferenceShort2 { get; set; }
        public string ReferenceShort3 { get; set; }
        public string ReferenceShort4 { get; set; }
        public string ReferenceShort5 { get; set; }
        public string ReferenceLong1 { get; set; }
        public string ReferenceLong2 { get; set; }
        public string ReferenceLong3 { get; set; }
        public string ReferenceLong4 { get; set; }
        public string ReferenceLong5 { get; set; }
        public Nullable<decimal> Rounding { get; set; }
        public string ContactPerson { get; set; }
        public string ContactTelephone { get; set; }
        public string Telephone { get; set; }
        public string VatNumber { get; set; }
        public string ShippingAddressLine1 { get; set; }
        public string ShippingAddressLine2 { get; set; }
        public string ShippingAddressLine3 { get; set; }
        public string ShippingAddressLine4 { get; set; }
        public string ShippingAddressCode { get; set; }
        public string BillingAddressLine1 { get; set; }
        public string BillingAddressLine2 { get; set; }
        public string BillingAddressLine3 { get; set; }
        public string BillingAddressLine4 { get; set; }
        public string BillingAddressCode { get; set; }
        public Nullable<decimal> TotalCash { get; set; }
        public Nullable<decimal> TotalCredit { get; set; }
        public Nullable<decimal> TotalAccount { get; set; }
        public string Comment { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<decimal> TotalExcl { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<decimal> TotalTax { get; set; }
    }
}