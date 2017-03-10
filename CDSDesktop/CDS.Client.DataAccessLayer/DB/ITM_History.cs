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
    using System.ComponentModel;
    
    
    public partial class ITM_History : INotifyPropertyChanged, IBaseEntity
    { 
    	bool hasChanges = false;
        public bool HasChanges
        {
        	get
        	{
                return hasChanges;
        	}
        	set
        	{
                if (hasChanges != value)
                    hasChanges = value;
        	}
        } 
    	
    	bool ignoreChanges = false;
        public bool IgnoreChanges
        {
            get
            {
                
                
                return ignoreChanges;
            }
            set
            {
                if (ignoreChanges != value)
                {
                    ignoreChanges = value;
                }
            }
        }
    
    	List<string> changeList = new List<string>();
    	[Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public List<string> ChangeList
        {
            get
            { 
                return changeList;
            }
            set
            {
                if (changeList != value)
                {
                    changeList = value;
                }
            }
        } 
    
    	public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged; 
    	private void SetProperty<T>(ref T field, T value, [System.Runtime.CompilerServices.CallerMemberName] string name = "")
    	{
    		if (!EqualityComparer<T>.Default.Equals(field, value))
    		{
    			field = value;
    			//ChangeSet.Add(LogEntry.New<T>(field.ToString(),this.ToString(), this.Id,  field,  value ));
    			var handler = PropertyChanged;
    			if (handler != null)
    			{
    				if(!name.StartsWith("Id") && name != "Title" && name != "CreatedOn" && !IgnoreChanges)  
    				{
    					HasChanges = true;
    					ChangeList.Add(name);
    				}
    
    				handler(this, new System.ComponentModel.PropertyChangedEventArgs(name));
    			}
    		}
    	} 
     
        private long id;
        private long inventoryId;
        private long periodId;
        private decimal amount;
        private decimal movement;
        private decimal onHand;
        private decimal onHold;
        private decimal onReserve;
        private decimal onOrder;
        private decimal unitPrice;
        private decimal unitCost;
        private decimal unitAverage;
        private Nullable<System.DateTime> firstSold;
        private Nullable<System.DateTime> firstPurchased;
        private Nullable<System.DateTime> lastSold;
        private Nullable<System.DateTime> lastPurchased;
        private Nullable<System.DateTime> lastMovement;
        private long siteId;
        private Nullable<decimal> sales12;
        private Nullable<decimal> sales6;
        private Nullable<decimal> sales3;
    
        public long Id 
    	{ 
    		get { return id; }
    		set { SetProperty(ref id, value); }
    	 }
        public long InventoryId 
    	{ 
    		get { return inventoryId; }
    		set { SetProperty(ref inventoryId, value); }
    	 }
        public long PeriodId 
    	{ 
    		get { return periodId; }
    		set { SetProperty(ref periodId, value); }
    	 }
        public decimal Amount 
    	{ 
    		get { return amount; }
    		set { SetProperty(ref amount, value); }
    	 }
        public decimal Movement 
    	{ 
    		get { return movement; }
    		set { SetProperty(ref movement, value); }
    	 }
        public decimal OnHand 
    	{ 
    		get { return onHand; }
    		set { SetProperty(ref onHand, value); }
    	 }
        public decimal OnHold 
    	{ 
    		get { return onHold; }
    		set { SetProperty(ref onHold, value); }
    	 }
        public decimal OnReserve 
    	{ 
    		get { return onReserve; }
    		set { SetProperty(ref onReserve, value); }
    	 }
        public decimal OnOrder 
    	{ 
    		get { return onOrder; }
    		set { SetProperty(ref onOrder, value); }
    	 }
        public decimal UnitPrice 
    	{ 
    		get { return unitPrice; }
    		set { SetProperty(ref unitPrice, value); }
    	 }
        public decimal UnitCost 
    	{ 
    		get { return unitCost; }
    		set { SetProperty(ref unitCost, value); }
    	 }
        public decimal UnitAverage 
    	{ 
    		get { return unitAverage; }
    		set { SetProperty(ref unitAverage, value); }
    	 }
        public Nullable<System.DateTime> FirstSold 
    	{ 
    		get { return firstSold; }
    		set { SetProperty(ref firstSold, value); }
    	 }
        public Nullable<System.DateTime> FirstPurchased 
    	{ 
    		get { return firstPurchased; }
    		set { SetProperty(ref firstPurchased, value); }
    	 }
        public Nullable<System.DateTime> LastSold 
    	{ 
    		get { return lastSold; }
    		set { SetProperty(ref lastSold, value); }
    	 }
        public Nullable<System.DateTime> LastPurchased 
    	{ 
    		get { return lastPurchased; }
    		set { SetProperty(ref lastPurchased, value); }
    	 }
        public Nullable<System.DateTime> LastMovement 
    	{ 
    		get { return lastMovement; }
    		set { SetProperty(ref lastMovement, value); }
    	 }
        public long SiteId 
    	{ 
    		get { return siteId; }
    		set { SetProperty(ref siteId, value); }
    	 }
        public Nullable<decimal> Sales12 
    	{ 
    		get { return sales12; }
    		set { SetProperty(ref sales12, value); }
    	 }
        public Nullable<decimal> Sales6 
    	{ 
    		get { return sales6; }
    		set { SetProperty(ref sales6, value); }
    	 }
        public Nullable<decimal> Sales3 
    	{ 
    		get { return sales3; }
    		set { SetProperty(ref sales3, value); }
    	 }
    }
}