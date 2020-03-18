﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[System.Data.Linq.Mapping.DatabaseAttribute(Name="AdventureWorksLT")]
public partial class AdventureWorksLTDataClassesDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Extensibility Method Definitions
  partial void OnCreated();
  partial void InsertSalesOrderDetail(SalesOrderDetail instance);
  partial void UpdateSalesOrderDetail(SalesOrderDetail instance);
  partial void DeleteSalesOrderDetail(SalesOrderDetail instance);
  #endregion
	
	public AdventureWorksLTDataClassesDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["AdventureWorksLTConnectionString"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public AdventureWorksLTDataClassesDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public AdventureWorksLTDataClassesDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public AdventureWorksLTDataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public AdventureWorksLTDataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<SalesOrderDetail> SalesOrderDetails
	{
		get
		{
			return this.GetTable<SalesOrderDetail>();
		}
	}
}

[Table(Name="SalesLT.SalesOrderDetail")]
public partial class SalesOrderDetail : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _SalesOrderID;
	
	private int _SalesOrderDetailID;
	
	private short _OrderQty;
	
	private int _ProductID;
	
	private decimal _UnitPrice;
	
	private decimal _UnitPriceDiscount;
	
	private decimal _LineTotal;
	
	private System.Guid _rowguid;
	
	private System.DateTime _ModifiedDate;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSalesOrderIDChanging(int value);
    partial void OnSalesOrderIDChanged();
    partial void OnSalesOrderDetailIDChanging(int value);
    partial void OnSalesOrderDetailIDChanged();
    partial void OnOrderQtyChanging(short value);
    partial void OnOrderQtyChanged();
    partial void OnProductIDChanging(int value);
    partial void OnProductIDChanged();
    partial void OnUnitPriceChanging(decimal value);
    partial void OnUnitPriceChanged();
    partial void OnUnitPriceDiscountChanging(decimal value);
    partial void OnUnitPriceDiscountChanged();
    partial void OnLineTotalChanging(decimal value);
    partial void OnLineTotalChanged();
    partial void OnrowguidChanging(System.Guid value);
    partial void OnrowguidChanged();
    partial void OnModifiedDateChanging(System.DateTime value);
    partial void OnModifiedDateChanged();
    #endregion
	
	public SalesOrderDetail()
	{
		OnCreated();
	}
	
	[Column(Storage="_SalesOrderID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int SalesOrderID
	{
		get
		{
			return this._SalesOrderID;
		}
		set
		{
			if ((this._SalesOrderID != value))
			{
				this.OnSalesOrderIDChanging(value);
				this.SendPropertyChanging();
				this._SalesOrderID = value;
				this.SendPropertyChanged("SalesOrderID");
				this.OnSalesOrderIDChanged();
			}
		}
	}
	
	[Column(Storage="_SalesOrderDetailID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int SalesOrderDetailID
	{
		get
		{
			return this._SalesOrderDetailID;
		}
		set
		{
			if ((this._SalesOrderDetailID != value))
			{
				this.OnSalesOrderDetailIDChanging(value);
				this.SendPropertyChanging();
				this._SalesOrderDetailID = value;
				this.SendPropertyChanged("SalesOrderDetailID");
				this.OnSalesOrderDetailIDChanged();
			}
		}
	}
	
	[Column(Storage="_OrderQty", DbType="SmallInt NOT NULL")]
	public short OrderQty
	{
		get
		{
			return this._OrderQty;
		}
		set
		{
			if ((this._OrderQty != value))
			{
				this.OnOrderQtyChanging(value);
				this.SendPropertyChanging();
				this._OrderQty = value;
				this.SendPropertyChanged("OrderQty");
				this.OnOrderQtyChanged();
			}
		}
	}
	
	[Column(Storage="_ProductID", DbType="Int NOT NULL")]
	public int ProductID
	{
		get
		{
			return this._ProductID;
		}
		set
		{
			if ((this._ProductID != value))
			{
				this.OnProductIDChanging(value);
				this.SendPropertyChanging();
				this._ProductID = value;
				this.SendPropertyChanged("ProductID");
				this.OnProductIDChanged();
			}
		}
	}
	
	[Column(Storage="_UnitPrice", DbType="Money NOT NULL")]
	public decimal UnitPrice
	{
		get
		{
			return this._UnitPrice;
		}
		set
		{
			if ((this._UnitPrice != value))
			{
				this.OnUnitPriceChanging(value);
				this.SendPropertyChanging();
				this._UnitPrice = value;
				this.SendPropertyChanged("UnitPrice");
				this.OnUnitPriceChanged();
			}
		}
	}
	
	[Column(Storage="_UnitPriceDiscount", DbType="Money NOT NULL")]
	public decimal UnitPriceDiscount
	{
		get
		{
			return this._UnitPriceDiscount;
		}
		set
		{
			if ((this._UnitPriceDiscount != value))
			{
				this.OnUnitPriceDiscountChanging(value);
				this.SendPropertyChanging();
				this._UnitPriceDiscount = value;
				this.SendPropertyChanged("UnitPriceDiscount");
				this.OnUnitPriceDiscountChanged();
			}
		}
	}
	
	[Column(Storage="_LineTotal", AutoSync=AutoSync.Always, DbType="Decimal(38,6) NOT NULL", IsDbGenerated=true, UpdateCheck=UpdateCheck.Never)]
	public decimal LineTotal
	{
		get
		{
			return this._LineTotal;
		}
		set
		{
			if ((this._LineTotal != value))
			{
				this.OnLineTotalChanging(value);
				this.SendPropertyChanging();
				this._LineTotal = value;
				this.SendPropertyChanged("LineTotal");
				this.OnLineTotalChanged();
			}
		}
	}
	
	[Column(Storage="_rowguid", DbType="UniqueIdentifier NOT NULL")]
	public System.Guid rowguid
	{
		get
		{
			return this._rowguid;
		}
		set
		{
			if ((this._rowguid != value))
			{
				this.OnrowguidChanging(value);
				this.SendPropertyChanging();
				this._rowguid = value;
				this.SendPropertyChanged("rowguid");
				this.OnrowguidChanged();
			}
		}
	}
	
	[Column(Storage="_ModifiedDate", DbType="DateTime NOT NULL")]
	public System.DateTime ModifiedDate
	{
		get
		{
			return this._ModifiedDate;
		}
		set
		{
			if ((this._ModifiedDate != value))
			{
				this.OnModifiedDateChanging(value);
				this.SendPropertyChanging();
				this._ModifiedDate = value;
				this.SendPropertyChanged("ModifiedDate");
				this.OnModifiedDateChanged();
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
#pragma warning restore 1591
