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

namespace Final_Proj
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="OOPProject")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCustomer(Customer instance);
    partial void UpdateCustomer(Customer instance);
    partial void DeleteCustomer(Customer instance);
    partial void InsertItem(Item instance);
    partial void UpdateItem(Item instance);
    partial void DeleteItem(Item instance);
    partial void InsertPurchase(Purchase instance);
    partial void UpdatePurchase(Purchase instance);
    partial void DeletePurchase(Purchase instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::Final_Proj.Properties.Settings.Default.OOPProjectConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Customer> Customers
		{
			get
			{
				return this.GetTable<Customer>();
			}
		}
		
		public System.Data.Linq.Table<Item> Items
		{
			get
			{
				return this.GetTable<Item>();
			}
		}
		
		public System.Data.Linq.Table<Purchase> Purchases
		{
			get
			{
				return this.GetTable<Purchase>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Customer")]
	public partial class Customer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CustID;
		
		private string _UserName;
		
		private string _Password;
		
		private System.Nullable<decimal> _Balance;
		
		private EntitySet<Purchase> _Purchases;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCustIDChanging(int value);
    partial void OnCustIDChanged();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnBalanceChanging(System.Nullable<decimal> value);
    partial void OnBalanceChanged();
    #endregion
		
		public Customer()
		{
			this._Purchases = new EntitySet<Purchase>(new Action<Purchase>(this.attach_Purchases), new Action<Purchase>(this.detach_Purchases));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int CustID
		{
			get
			{
				return this._CustID;
			}
			set
			{
				if ((this._CustID != value))
				{
					this.OnCustIDChanging(value);
					this.SendPropertyChanging();
					this._CustID = value;
					this.SendPropertyChanged("CustID");
					this.OnCustIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this.OnUserNameChanging(value);
					this.SendPropertyChanging();
					this._UserName = value;
					this.SendPropertyChanged("UserName");
					this.OnUserNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Balance", DbType="Decimal(8,2)")]
		public System.Nullable<decimal> Balance
		{
			get
			{
				return this._Balance;
			}
			set
			{
				if ((this._Balance != value))
				{
					this.OnBalanceChanging(value);
					this.SendPropertyChanging();
					this._Balance = value;
					this.SendPropertyChanged("Balance");
					this.OnBalanceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Customer_Purchase", Storage="_Purchases", ThisKey="CustID", OtherKey="CustID")]
		public EntitySet<Purchase> Purchases
		{
			get
			{
				return this._Purchases;
			}
			set
			{
				this._Purchases.Assign(value);
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
		
		private void attach_Purchases(Purchase entity)
		{
			this.SendPropertyChanging();
			entity.Customer = this;
		}
		
		private void detach_Purchases(Purchase entity)
		{
			this.SendPropertyChanging();
			entity.Customer = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Item")]
	public partial class Item : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ItemID;
		
		private string _Product;
		
		private decimal _Price;
		
		private EntitySet<Purchase> _Purchases;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnItemIDChanging(int value);
    partial void OnItemIDChanged();
    partial void OnProductChanging(string value);
    partial void OnProductChanged();
    partial void OnPriceChanging(decimal value);
    partial void OnPriceChanged();
    #endregion
		
		public Item()
		{
			this._Purchases = new EntitySet<Purchase>(new Action<Purchase>(this.attach_Purchases), new Action<Purchase>(this.detach_Purchases));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ItemID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ItemID
		{
			get
			{
				return this._ItemID;
			}
			set
			{
				if ((this._ItemID != value))
				{
					this.OnItemIDChanging(value);
					this.SendPropertyChanging();
					this._ItemID = value;
					this.SendPropertyChanged("ItemID");
					this.OnItemIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Product", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string Product
		{
			get
			{
				return this._Product;
			}
			set
			{
				if ((this._Product != value))
				{
					this.OnProductChanging(value);
					this.SendPropertyChanging();
					this._Product = value;
					this.SendPropertyChanged("Product");
					this.OnProductChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Decimal(8,2) NOT NULL")]
		public decimal Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Item_Purchase", Storage="_Purchases", ThisKey="ItemID", OtherKey="ItemID")]
		public EntitySet<Purchase> Purchases
		{
			get
			{
				return this._Purchases;
			}
			set
			{
				this._Purchases.Assign(value);
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
		
		private void attach_Purchases(Purchase entity)
		{
			this.SendPropertyChanging();
			entity.Item = this;
		}
		
		private void detach_Purchases(Purchase entity)
		{
			this.SendPropertyChanging();
			entity.Item = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Purchases")]
	public partial class Purchase : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _PurchaseID;
		
		private int _CustID;
		
		private int _ItemID;
		
		private System.DateTime _PurchaseDate;
		
		private EntityRef<Customer> _Customer;
		
		private EntityRef<Item> _Item;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPurchaseIDChanging(int value);
    partial void OnPurchaseIDChanged();
    partial void OnCustIDChanging(int value);
    partial void OnCustIDChanged();
    partial void OnItemIDChanging(int value);
    partial void OnItemIDChanged();
    partial void OnPurchaseDateChanging(System.DateTime value);
    partial void OnPurchaseDateChanged();
    #endregion
		
		public Purchase()
		{
			this._Customer = default(EntityRef<Customer>);
			this._Item = default(EntityRef<Item>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PurchaseID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int PurchaseID
		{
			get
			{
				return this._PurchaseID;
			}
			set
			{
				if ((this._PurchaseID != value))
				{
					this.OnPurchaseIDChanging(value);
					this.SendPropertyChanging();
					this._PurchaseID = value;
					this.SendPropertyChanged("PurchaseID");
					this.OnPurchaseIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustID", DbType="Int NOT NULL")]
		public int CustID
		{
			get
			{
				return this._CustID;
			}
			set
			{
				if ((this._CustID != value))
				{
					if (this._Customer.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCustIDChanging(value);
					this.SendPropertyChanging();
					this._CustID = value;
					this.SendPropertyChanged("CustID");
					this.OnCustIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ItemID", DbType="Int NOT NULL")]
		public int ItemID
		{
			get
			{
				return this._ItemID;
			}
			set
			{
				if ((this._ItemID != value))
				{
					if (this._Item.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnItemIDChanging(value);
					this.SendPropertyChanging();
					this._ItemID = value;
					this.SendPropertyChanged("ItemID");
					this.OnItemIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PurchaseDate", DbType="Date NOT NULL")]
		public System.DateTime PurchaseDate
		{
			get
			{
				return this._PurchaseDate;
			}
			set
			{
				if ((this._PurchaseDate != value))
				{
					this.OnPurchaseDateChanging(value);
					this.SendPropertyChanging();
					this._PurchaseDate = value;
					this.SendPropertyChanged("PurchaseDate");
					this.OnPurchaseDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Customer_Purchase", Storage="_Customer", ThisKey="CustID", OtherKey="CustID", IsForeignKey=true)]
		public Customer Customer
		{
			get
			{
				return this._Customer.Entity;
			}
			set
			{
				Customer previousValue = this._Customer.Entity;
				if (((previousValue != value) 
							|| (this._Customer.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Customer.Entity = null;
						previousValue.Purchases.Remove(this);
					}
					this._Customer.Entity = value;
					if ((value != null))
					{
						value.Purchases.Add(this);
						this._CustID = value.CustID;
					}
					else
					{
						this._CustID = default(int);
					}
					this.SendPropertyChanged("Customer");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Item_Purchase", Storage="_Item", ThisKey="ItemID", OtherKey="ItemID", IsForeignKey=true)]
		public Item Item
		{
			get
			{
				return this._Item.Entity;
			}
			set
			{
				Item previousValue = this._Item.Entity;
				if (((previousValue != value) 
							|| (this._Item.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Item.Entity = null;
						previousValue.Purchases.Remove(this);
					}
					this._Item.Entity = value;
					if ((value != null))
					{
						value.Purchases.Add(this);
						this._ItemID = value.ItemID;
					}
					else
					{
						this._ItemID = default(int);
					}
					this.SendPropertyChanged("Item");
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
}
#pragma warning restore 1591
