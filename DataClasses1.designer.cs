#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SemesterProject
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="avigailsp")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertITEM(ITEM instance);
    partial void UpdateITEM(ITEM instance);
    partial void DeleteITEM(ITEM instance);
    partial void InsertORDER(ORDER instance);
    partial void UpdateORDER(ORDER instance);
    partial void DeleteORDER(ORDER instance);
    partial void InsertPERSON(PERSON instance);
    partial void UpdatePERSON(PERSON instance);
    partial void DeletePERSON(PERSON instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::SemesterProject.Properties.Settings.Default.avigailspConnectionString, mappingSource)
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
		
		public System.Data.Linq.Table<ITEM> ITEMs
		{
			get
			{
				return this.GetTable<ITEM>();
			}
		}
		
		public System.Data.Linq.Table<ORDER> ORDERs
		{
			get
			{
				return this.GetTable<ORDER>();
			}
		}
		
		public System.Data.Linq.Table<PERSON> PERSONs
		{
			get
			{
				return this.GetTable<PERSON>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ITEMS")]
	public partial class ITEM : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ITEM_ID;
		
		private string _NAME;
		
		private System.Nullable<decimal> _PRICE;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnITEM_IDChanging(int value);
    partial void OnITEM_IDChanged();
    partial void OnNAMEChanging(string value);
    partial void OnNAMEChanged();
    partial void OnPRICEChanging(System.Nullable<decimal> value);
    partial void OnPRICEChanged();
    #endregion
		
		public ITEM()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ITEM_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ITEM_ID
		{
			get
			{
				return this._ITEM_ID;
			}
			set
			{
				if ((this._ITEM_ID != value))
				{
					this.OnITEM_IDChanging(value);
					this.SendPropertyChanging();
					this._ITEM_ID = value;
					this.SendPropertyChanged("ITEM_ID");
					this.OnITEM_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NAME", DbType="VarChar(255)")]
		public string NAME
		{
			get
			{
				return this._NAME;
			}
			set
			{
				if ((this._NAME != value))
				{
					this.OnNAMEChanging(value);
					this.SendPropertyChanging();
					this._NAME = value;
					this.SendPropertyChanged("NAME");
					this.OnNAMEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PRICE", DbType="Decimal(10,2)")]
		public System.Nullable<decimal> PRICE
		{
			get
			{
				return this._PRICE;
			}
			set
			{
				if ((this._PRICE != value))
				{
					this.OnPRICEChanging(value);
					this.SendPropertyChanging();
					this._PRICE = value;
					this.SendPropertyChanged("PRICE");
					this.OnPRICEChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ORDERS")]
	public partial class ORDER : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ORDER_ID;
		
		private System.Nullable<int> _PERSON_ID;
		
		private System.Nullable<decimal> _TOTAL;
		
		private System.Nullable<System.DateTime> _DATE;
		
		private EntityRef<PERSON> _PERSON;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnORDER_IDChanging(int value);
    partial void OnORDER_IDChanged();
    partial void OnPERSON_IDChanging(System.Nullable<int> value);
    partial void OnPERSON_IDChanged();
    partial void OnTOTALChanging(System.Nullable<decimal> value);
    partial void OnTOTALChanged();
    partial void OnDATEChanging(System.Nullable<System.DateTime> value);
    partial void OnDATEChanged();
    #endregion
		
		public ORDER()
		{
			this._PERSON = default(EntityRef<PERSON>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ORDER_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ORDER_ID
		{
			get
			{
				return this._ORDER_ID;
			}
			set
			{
				if ((this._ORDER_ID != value))
				{
					this.OnORDER_IDChanging(value);
					this.SendPropertyChanging();
					this._ORDER_ID = value;
					this.SendPropertyChanged("ORDER_ID");
					this.OnORDER_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PERSON_ID", DbType="Int")]
		public System.Nullable<int> PERSON_ID
		{
			get
			{
				return this._PERSON_ID;
			}
			set
			{
				if ((this._PERSON_ID != value))
				{
					if (this._PERSON.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnPERSON_IDChanging(value);
					this.SendPropertyChanging();
					this._PERSON_ID = value;
					this.SendPropertyChanged("PERSON_ID");
					this.OnPERSON_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TOTAL", DbType="Decimal(10,2)")]
		public System.Nullable<decimal> TOTAL
		{
			get
			{
				return this._TOTAL;
			}
			set
			{
				if ((this._TOTAL != value))
				{
					this.OnTOTALChanging(value);
					this.SendPropertyChanging();
					this._TOTAL = value;
					this.SendPropertyChanged("TOTAL");
					this.OnTOTALChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DATE", DbType="Date")]
		public System.Nullable<System.DateTime> DATE
		{
			get
			{
				return this._DATE;
			}
			set
			{
				if ((this._DATE != value))
				{
					this.OnDATEChanging(value);
					this.SendPropertyChanging();
					this._DATE = value;
					this.SendPropertyChanged("DATE");
					this.OnDATEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PERSON_ORDER", Storage="_PERSON", ThisKey="PERSON_ID", OtherKey="PERSON_ID", IsForeignKey=true)]
		public PERSON PERSON
		{
			get
			{
				return this._PERSON.Entity;
			}
			set
			{
				PERSON previousValue = this._PERSON.Entity;
				if (((previousValue != value) 
							|| (this._PERSON.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._PERSON.Entity = null;
						previousValue.ORDERs.Remove(this);
					}
					this._PERSON.Entity = value;
					if ((value != null))
					{
						value.ORDERs.Add(this);
						this._PERSON_ID = value.PERSON_ID;
					}
					else
					{
						this._PERSON_ID = default(Nullable<int>);
					}
					this.SendPropertyChanged("PERSON");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PERSON")]
	public partial class PERSON : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _PERSON_ID;
		
		private string _USERNAME;
		
		private string _PASSWORD;
		
		private System.Nullable<decimal> _BALANCE;
		
		private EntitySet<ORDER> _ORDERs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPERSON_IDChanging(int value);
    partial void OnPERSON_IDChanged();
    partial void OnUSERNAMEChanging(string value);
    partial void OnUSERNAMEChanged();
    partial void OnPASSWORDChanging(string value);
    partial void OnPASSWORDChanged();
    partial void OnBALANCEChanging(System.Nullable<decimal> value);
    partial void OnBALANCEChanged();
    #endregion
		
		public PERSON()
		{
			this._ORDERs = new EntitySet<ORDER>(new Action<ORDER>(this.attach_ORDERs), new Action<ORDER>(this.detach_ORDERs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PERSON_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int PERSON_ID
		{
			get
			{
				return this._PERSON_ID;
			}
			set
			{
				if ((this._PERSON_ID != value))
				{
					this.OnPERSON_IDChanging(value);
					this.SendPropertyChanging();
					this._PERSON_ID = value;
					this.SendPropertyChanged("PERSON_ID");
					this.OnPERSON_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_USERNAME", DbType="VarChar(255)")]
		public string USERNAME
		{
			get
			{
				return this._USERNAME;
			}
			set
			{
				if ((this._USERNAME != value))
				{
					this.OnUSERNAMEChanging(value);
					this.SendPropertyChanging();
					this._USERNAME = value;
					this.SendPropertyChanged("USERNAME");
					this.OnUSERNAMEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PASSWORD", DbType="VarChar(255)")]
		public string PASSWORD
		{
			get
			{
				return this._PASSWORD;
			}
			set
			{
				if ((this._PASSWORD != value))
				{
					this.OnPASSWORDChanging(value);
					this.SendPropertyChanging();
					this._PASSWORD = value;
					this.SendPropertyChanged("PASSWORD");
					this.OnPASSWORDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BALANCE", DbType="Decimal(10,2)")]
		public System.Nullable<decimal> BALANCE
		{
			get
			{
				return this._BALANCE;
			}
			set
			{
				if ((this._BALANCE != value))
				{
					this.OnBALANCEChanging(value);
					this.SendPropertyChanging();
					this._BALANCE = value;
					this.SendPropertyChanged("BALANCE");
					this.OnBALANCEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PERSON_ORDER", Storage="_ORDERs", ThisKey="PERSON_ID", OtherKey="PERSON_ID")]
		public EntitySet<ORDER> ORDERs
		{
			get
			{
				return this._ORDERs;
			}
			set
			{
				this._ORDERs.Assign(value);
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
		
		private void attach_ORDERs(ORDER entity)
		{
			this.SendPropertyChanging();
			entity.PERSON = this;
		}
		
		private void detach_ORDERs(ORDER entity)
		{
			this.SendPropertyChanging();
			entity.PERSON = null;
		}
	}
}
#pragma warning restore 1591
