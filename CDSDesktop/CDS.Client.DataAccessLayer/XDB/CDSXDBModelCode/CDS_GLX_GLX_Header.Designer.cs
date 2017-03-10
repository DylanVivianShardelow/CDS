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

    [Persistent(@"CDS_GLX.GLX_Header")]
    public partial class CDS_GLX_GLX_Header : XPLiteObject
    {
        long _Id;
        [Key(true)]
        public long Id
        {
            get { return _Id; }
            set { SetPropertyValue<long>("Id", ref _Id, value); }
        }
        CDS_SYS_SYS_Period _PeriodId;
        [Association(@"CDS_GLX_GLX_HeaderReferencesCDS_SYS_SYS_Period")]
        public CDS_SYS_SYS_Period PeriodId
        {
            get { return _PeriodId; }
            set { SetPropertyValue<CDS_SYS_SYS_Period>("PeriodId", ref _PeriodId, value); }
        }
        CDS_SYS_SYS_Status _StatusId;
        [Association(@"CDS_GLX_GLX_HeaderReferencesCDS_SYS_SYS_Status")]
        public CDS_SYS_SYS_Status StatusId
        {
            get { return _StatusId; }
            set { SetPropertyValue<CDS_SYS_SYS_Status>("StatusId", ref _StatusId, value); }
        }
        CDS_SYS_SYS_Tracking _TrackId;
        [Association(@"CDS_GLX_GLX_HeaderReferencesCDS_SYS_SYS_Tracking")]
        public CDS_SYS_SYS_Tracking TrackId
        {
            get { return _TrackId; }
            set { SetPropertyValue<CDS_SYS_SYS_Tracking>("TrackId", ref _TrackId, value); }
        }
        CDS_GLX_GLX_JournalType _JournalTypeId;
        [Association(@"CDS_GLX_GLX_HeaderReferencesCDS_GLX_GLX_JournalType")]
        public CDS_GLX_GLX_JournalType JournalTypeId
        {
            get { return _JournalTypeId; }
            set { SetPropertyValue<CDS_GLX_GLX_JournalType>("JournalTypeId", ref _JournalTypeId, value); }
        }
        string _Reference;
        [Size(50)]
        public string Reference
        {
            get { return _Reference; }
            set { SetPropertyValue<string>("Reference", ref _Reference, value); }
        }
        string _Description;
        public string Description
        {
            get { return _Description; }
            set { SetPropertyValue<string>("Description", ref _Description, value); }
        }
        DateTime _Date;
        public DateTime Date
        {
            get { return _Date; }
            set { SetPropertyValue<DateTime>("Date", ref _Date, value); }
        }
        DateTime _PostedDate;
        public DateTime PostedDate
        {
            get { return _PostedDate; }
            set { SetPropertyValue<DateTime>("PostedDate", ref _PostedDate, value); }
        }
        string _Title;
        [Size(151)]
        public string Title
        {
            get { return _Title; }
            set { SetPropertyValue<string>("Title", ref _Title, value); }
        }
        DateTime _CreatedOn;
        public DateTime CreatedOn
        {
            get { return _CreatedOn; }
            set { SetPropertyValue<DateTime>("CreatedOn", ref _CreatedOn, value); }
        }
        CDS_SYS_SYS_Person _CreatedBy;
        [Association(@"CDS_GLX_GLX_HeaderReferencesCDS_SYS_SYS_Person")]
        public CDS_SYS_SYS_Person CreatedBy
        {
            get { return _CreatedBy; }
            set { SetPropertyValue<CDS_SYS_SYS_Person>("CreatedBy", ref _CreatedBy, value); }
        }
        long _ReferenceId;
        public long ReferenceId
        {
            get { return _ReferenceId; }
            set { SetPropertyValue<long>("ReferenceId", ref _ReferenceId, value); }
        }
        [Association(@"CDS_GLX_GLX_LineReferencesCDS_GLX_GLX_Header", typeof(CDS_GLX_GLX_Line))]
        public XPCollection<CDS_GLX_GLX_Line> CDS_GLX_GLX_Lines { get { return GetCollection<CDS_GLX_GLX_Line>("CDS_GLX_GLX_Lines"); } }
    }

}