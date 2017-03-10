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
namespace CDS.Client.DataAccessLayer.XDB
{

    [Persistent(@"CDS_ORG.ORG_Contact")]
    public partial class CDS_ORG_ORG_Contact : XPLiteObject
    {
        long _Id;
        [Key(true)]
        public long Id
        {
            get { return _Id; }
            set { SetPropertyValue<long>("Id", ref _Id, value); }
        }
        CDS_SYS_SYS_Entity _CompanyId;
        [Association(@"CDS_ORG_ORG_ContactReferencesCDS_SYS_SYS_Entity")]
        public CDS_SYS_SYS_Entity CompanyId
        {
            get { return _CompanyId; }
            set { SetPropertyValue<CDS_SYS_SYS_Entity>("CompanyId", ref _CompanyId, value); }
        }
        CDS_SYS_SYS_Person _PersonId;
        [Association(@"CDS_ORG_ORG_ContactReferencesCDS_SYS_SYS_Person")]
        public CDS_SYS_SYS_Person PersonId
        {
            get { return _PersonId; }
            set { SetPropertyValue<CDS_SYS_SYS_Person>("PersonId", ref _PersonId, value); }
        }
        CDS_ORG_ORG_Department _DepartmentId;
        [Association(@"CDS_ORG_ORG_ContactReferencesCDS_ORG_ORG_Department")]
        public CDS_ORG_ORG_Department DepartmentId
        {
            get { return _DepartmentId; }
            set { SetPropertyValue<CDS_ORG_ORG_Department>("DepartmentId", ref _DepartmentId, value); }
        }
        string _Telephone1;
        [Size(50)]
        public string Telephone1
        {
            get { return _Telephone1; }
            set { SetPropertyValue<string>("Telephone1", ref _Telephone1, value); }
        }
        string _Telephone2;
        [Size(50)]
        public string Telephone2
        {
            get { return _Telephone2; }
            set { SetPropertyValue<string>("Telephone2", ref _Telephone2, value); }
        }
        string _Fax;
        [Size(50)]
        public string Fax
        {
            get { return _Fax; }
            set { SetPropertyValue<string>("Fax", ref _Fax, value); }
        }
        string _Email;
        [Size(50)]
        public string Email
        {
            get { return _Email; }
            set { SetPropertyValue<string>("Email", ref _Email, value); }
        }
        string _Note;
        [Size(1000)]
        public string Note
        {
            get { return _Note; }
            set { SetPropertyValue<string>("Note", ref _Note, value); }
        }
        DateTime _CreatedOn;
        public DateTime CreatedOn
        {
            get { return _CreatedOn; }
            set { SetPropertyValue<DateTime>("CreatedOn", ref _CreatedOn, value); }
        }
        CDS_SYS_SYS_Person _CreatedBy;
        [Association(@"CDS_ORG_ORG_ContactReferencesCDS_SYS_SYS_Person1")]
        public CDS_SYS_SYS_Person CreatedBy
        {
            get { return _CreatedBy; }
            set { SetPropertyValue<CDS_SYS_SYS_Person>("CreatedBy", ref _CreatedBy, value); }
        }
        bool _IsDefault;
        public bool IsDefault
        {
            get { return _IsDefault; }
            set { SetPropertyValue<bool>("IsDefault", ref _IsDefault, value); }
        }
    }

}