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

    [Persistent(@"CDS_GLX.GLX_Budget")]
    public partial class GLX_Budget : XPLiteObject
    {
        long fId;
        [Key(true)]
        public long Id
        {
            get { return fId; }
            set { SetPropertyValue<long>("Id", ref fId, value); }
        }
        SYS_Entity fEntityId;
        [Association(@"GLX_BudgetReferencesSYS_Entity")]
        public SYS_Entity EntityId
        {
            get { return fEntityId; }
            set { SetPropertyValue<SYS_Entity>("EntityId", ref fEntityId, value); }
        }
        SYS_Period fPeriodId;
        [Association(@"GLX_BudgetReferencesSYS_Period")]
        public SYS_Period PeriodId
        {
            get { return fPeriodId; }
            set { SetPropertyValue<SYS_Period>("PeriodId", ref fPeriodId, value); }
        }
        decimal fAmount;
        public decimal Amount
        {
            get { return fAmount; }
            set { SetPropertyValue<decimal>("Amount", ref fAmount, value); }
        }
        DateTime fCreatedOn;
        public DateTime CreatedOn
        {
            get { return fCreatedOn; }
            set { SetPropertyValue<DateTime>("CreatedOn", ref fCreatedOn, value); }
        }
        SYS_Person fCreatedBy;
        [Association(@"GLX_BudgetReferencesSYS_Person")]
        public SYS_Person CreatedBy
        {
            get { return fCreatedBy; }
            set { SetPropertyValue<SYS_Person>("CreatedBy", ref fCreatedBy, value); }
        }
    }

}