//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace CDS.DataAccessLayer.XPO.Datamodel
{

    [Persistent(@"CDS_JOB.JOB_Header")]
    public partial class JOB_Header : XPLiteObject
    {
        long fId;
        [Key(true)]
        public long Id
        {
            get { return fId; }
            set { SetPropertyValue<long>("Id", ref fId, value); }
        }
        SYS_DOC_Header fHeaderId;
        [Association(@"CDS_JOB_JOB_HeaderReferencesSYS_DOC_Header")]
        public SYS_DOC_Header HeaderId
        {
            get { return fHeaderId; }
            set { SetPropertyValue<SYS_DOC_Header>("HeaderId", ref fHeaderId, value); }
        }
        ORG_Company fCompanyId;
        [Association(@"CDS_JOB_JOB_HeaderReferencesORG_Company")]
        public ORG_Company CompanyId
        {
            get { return fCompanyId; }
            set { SetPropertyValue<ORG_Company>("CompanyId", ref fCompanyId, value); }
        }
        string fTelephone;
        [Size(50)]
        public string Telephone
        {
            get { return fTelephone; }
            set { SetPropertyValue<string>("Telephone", ref fTelephone, value); }
        }
        string fContactPerson;
        [Size(50)]
        public string ContactPerson
        {
            get { return fContactPerson; }
            set { SetPropertyValue<string>("ContactPerson", ref fContactPerson, value); }
        }
        string fContactTelephone;
        [Size(50)]
        public string ContactTelephone
        {
            get { return fContactTelephone; }
            set { SetPropertyValue<string>("ContactTelephone", ref fContactTelephone, value); }
        }
        DateTime fDateFirstPrinted;
        public DateTime DateFirstPrinted
        {
            get { return fDateFirstPrinted; }
            set { SetPropertyValue<DateTime>("DateFirstPrinted", ref fDateFirstPrinted, value); }
        }
        DateTime fDateLastPrinted;
        public DateTime DateLastPrinted
        {
            get { return fDateLastPrinted; }
            set { SetPropertyValue<DateTime>("DateLastPrinted", ref fDateLastPrinted, value); }
        }
        DateTime fDate1;
        public DateTime Date1
        {
            get { return fDate1; }
            set { SetPropertyValue<DateTime>("Date1", ref fDate1, value); }
        }
        DateTime fDate2;
        public DateTime Date2
        {
            get { return fDate2; }
            set { SetPropertyValue<DateTime>("Date2", ref fDate2, value); }
        }
        DateTime fDate3;
        public DateTime Date3
        {
            get { return fDate3; }
            set { SetPropertyValue<DateTime>("Date3", ref fDate3, value); }
        }
        string fReferenceShort1;
        [Size(20)]
        public string ReferenceShort1
        {
            get { return fReferenceShort1; }
            set { SetPropertyValue<string>("ReferenceShort1", ref fReferenceShort1, value); }
        }
        string fReferenceShort2;
        [Size(20)]
        public string ReferenceShort2
        {
            get { return fReferenceShort2; }
            set { SetPropertyValue<string>("ReferenceShort2", ref fReferenceShort2, value); }
        }
        string fReferenceShort3;
        [Size(20)]
        public string ReferenceShort3
        {
            get { return fReferenceShort3; }
            set { SetPropertyValue<string>("ReferenceShort3", ref fReferenceShort3, value); }
        }
        string fReferenceShort4;
        [Size(20)]
        public string ReferenceShort4
        {
            get { return fReferenceShort4; }
            set { SetPropertyValue<string>("ReferenceShort4", ref fReferenceShort4, value); }
        }
        string fReferenceShort5;
        [Size(20)]
        public string ReferenceShort5
        {
            get { return fReferenceShort5; }
            set { SetPropertyValue<string>("ReferenceShort5", ref fReferenceShort5, value); }
        }
        string fReferenceShort6;
        [Size(20)]
        public string ReferenceShort6
        {
            get { return fReferenceShort6; }
            set { SetPropertyValue<string>("ReferenceShort6", ref fReferenceShort6, value); }
        }
        string fReferenceShort7;
        [Size(20)]
        public string ReferenceShort7
        {
            get { return fReferenceShort7; }
            set { SetPropertyValue<string>("ReferenceShort7", ref fReferenceShort7, value); }
        }
        string fReferenceShort8;
        [Size(20)]
        public string ReferenceShort8
        {
            get { return fReferenceShort8; }
            set { SetPropertyValue<string>("ReferenceShort8", ref fReferenceShort8, value); }
        }
        string fReferenceShort9;
        [Size(20)]
        public string ReferenceShort9
        {
            get { return fReferenceShort9; }
            set { SetPropertyValue<string>("ReferenceShort9", ref fReferenceShort9, value); }
        }
        string fReferenceShort10;
        [Size(20)]
        public string ReferenceShort10
        {
            get { return fReferenceShort10; }
            set { SetPropertyValue<string>("ReferenceShort10", ref fReferenceShort10, value); }
        }
        string fReferenceLong1;
        public string ReferenceLong1
        {
            get { return fReferenceLong1; }
            set { SetPropertyValue<string>("ReferenceLong1", ref fReferenceLong1, value); }
        }
        string fReferenceLong2;
        public string ReferenceLong2
        {
            get { return fReferenceLong2; }
            set { SetPropertyValue<string>("ReferenceLong2", ref fReferenceLong2, value); }
        }
        string fReferenceLong3;
        public string ReferenceLong3
        {
            get { return fReferenceLong3; }
            set { SetPropertyValue<string>("ReferenceLong3", ref fReferenceLong3, value); }
        }
        string fReferenceLong4;
        public string ReferenceLong4
        {
            get { return fReferenceLong4; }
            set { SetPropertyValue<string>("ReferenceLong4", ref fReferenceLong4, value); }
        }
        string fReferenceLong5;
        public string ReferenceLong5
        {
            get { return fReferenceLong5; }
            set { SetPropertyValue<string>("ReferenceLong5", ref fReferenceLong5, value); }
        }
        string fShippingAddressLine1;
        [Size(50)]
        public string ShippingAddressLine1
        {
            get { return fShippingAddressLine1; }
            set { SetPropertyValue<string>("ShippingAddressLine1", ref fShippingAddressLine1, value); }
        }
        string fShippingAddressLine2;
        [Size(50)]
        public string ShippingAddressLine2
        {
            get { return fShippingAddressLine2; }
            set { SetPropertyValue<string>("ShippingAddressLine2", ref fShippingAddressLine2, value); }
        }
        string fShippingAddressLine3;
        [Size(50)]
        public string ShippingAddressLine3
        {
            get { return fShippingAddressLine3; }
            set { SetPropertyValue<string>("ShippingAddressLine3", ref fShippingAddressLine3, value); }
        }
        string fShippingAddressLine4;
        [Size(50)]
        public string ShippingAddressLine4
        {
            get { return fShippingAddressLine4; }
            set { SetPropertyValue<string>("ShippingAddressLine4", ref fShippingAddressLine4, value); }
        }
        string fShippingAddressCode;
        [Size(10)]
        public string ShippingAddressCode
        {
            get { return fShippingAddressCode; }
            set { SetPropertyValue<string>("ShippingAddressCode", ref fShippingAddressCode, value); }
        }
        string fBillingAddressLine1;
        [Size(50)]
        public string BillingAddressLine1
        {
            get { return fBillingAddressLine1; }
            set { SetPropertyValue<string>("BillingAddressLine1", ref fBillingAddressLine1, value); }
        }
        string fBillingAddressLine2;
        [Size(50)]
        public string BillingAddressLine2
        {
            get { return fBillingAddressLine2; }
            set { SetPropertyValue<string>("BillingAddressLine2", ref fBillingAddressLine2, value); }
        }
        string fBillingAddressLine3;
        [Size(50)]
        public string BillingAddressLine3
        {
            get { return fBillingAddressLine3; }
            set { SetPropertyValue<string>("BillingAddressLine3", ref fBillingAddressLine3, value); }
        }
        string fBillingAddressLine4;
        [Size(50)]
        public string BillingAddressLine4
        {
            get { return fBillingAddressLine4; }
            set { SetPropertyValue<string>("BillingAddressLine4", ref fBillingAddressLine4, value); }
        }
        string fBillingAddressCode;
        [Size(50)]
        public string BillingAddressCode
        {
            get { return fBillingAddressCode; }
            set { SetPropertyValue<string>("BillingAddressCode", ref fBillingAddressCode, value); }
        }
        DateTime fCreatedOn;
        public DateTime CreatedOn
        {
            get { return fCreatedOn; }
            set { SetPropertyValue<DateTime>("CreatedOn", ref fCreatedOn, value); }
        }
        SYS_Person fCreatedBy;
        [Association(@"CDS_JOB_JOB_HeaderReferencesSYS_Person")]
        public SYS_Person CreatedBy
        {
            get { return fCreatedBy; }
            set { SetPropertyValue<SYS_Person>("CreatedBy", ref fCreatedBy, value); }
        }
    }

}