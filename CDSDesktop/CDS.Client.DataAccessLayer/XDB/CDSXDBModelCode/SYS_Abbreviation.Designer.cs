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

    public partial class SYS_Abbreviation : XPLiteObject
    {
        short _Id;
        [Key]
        public short Id
        {
            get { return _Id; }
            set { SetPropertyValue<short>("Id", ref _Id, value); }
        }
        string _Abbreviation;
        [Size(50)]
        public string Abbreviation
        {
            get { return _Abbreviation; }
            set { SetPropertyValue<string>("Abbreviation", ref _Abbreviation, value); }
        }
        string _Description;
        [Size(300)]
        public string Description
        {
            get { return _Description; }
            set { SetPropertyValue<string>("Description", ref _Description, value); }
        }
        DateTime _CreatedOn;
        public DateTime CreatedOn
        {
            get { return _CreatedOn; }
            set { SetPropertyValue<DateTime>("CreatedOn", ref _CreatedOn, value); }
        }
        SYS_Person _CreatedBy;
        [Association(@"SYS_AbbreviationReferencesSYS_Person")]
        public SYS_Person CreatedBy
        {
            get { return _CreatedBy; }
            set { SetPropertyValue<SYS_Person>("CreatedBy", ref _CreatedBy, value); }
        }
    }

}