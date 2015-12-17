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

namespace Domain
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="CardBinder")]
	public partial class LinqToSQLDatacontext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertcard(card instance);
    partial void Updatecard(card instance);
    partial void Deletecard(card instance);
    partial void Insertuser(user instance);
    partial void Updateuser(user instance);
    partial void Deleteuser(user instance);
    #endregion
		
		public LinqToSQLDatacontext() : 
				base(global::Domain.Properties.Settings.Default.CardBinderConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public LinqToSQLDatacontext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinqToSQLDatacontext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinqToSQLDatacontext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinqToSQLDatacontext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<card> cards
		{
			get
			{
				return this.GetTable<card>();
			}
		}
		
		public System.Data.Linq.Table<cardbinder> cardbinders
		{
			get
			{
				return this.GetTable<cardbinder>();
			}
		}
		
		public System.Data.Linq.Table<user> users
		{
			get
			{
				return this.GetTable<user>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.card")]
	public partial class card : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _name;
		
		private int _serialnumber;
		
		private string _imagepath;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnserialnumberChanging(int value);
    partial void OnserialnumberChanged();
    partial void OnimagepathChanging(string value);
    partial void OnimagepathChanged();
    #endregion
		
		public card()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NChar(30) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_serialnumber", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int serialnumber
		{
			get
			{
				return this._serialnumber;
			}
			set
			{
				if ((this._serialnumber != value))
				{
					this.OnserialnumberChanging(value);
					this.SendPropertyChanging();
					this._serialnumber = value;
					this.SendPropertyChanged("serialnumber");
					this.OnserialnumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_imagepath", DbType="NChar(100)")]
		public string imagepath
		{
			get
			{
				return this._imagepath;
			}
			set
			{
				if ((this._imagepath != value))
				{
					this.OnimagepathChanging(value);
					this.SendPropertyChanging();
					this._imagepath = value;
					this.SendPropertyChanged("imagepath");
					this.OnimagepathChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.cardbinder")]
	public partial class cardbinder
	{
		
		private string _id;
		
		private string _userid;
		
		private int _cardid;
		
		public cardbinder()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="NChar(40) NOT NULL", CanBeNull=false)]
		public string id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this._id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userid", DbType="NChar(30) NOT NULL", CanBeNull=false)]
		public string userid
		{
			get
			{
				return this._userid;
			}
			set
			{
				if ((this._userid != value))
				{
					this._userid = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cardid", DbType="Int NOT NULL")]
		public int cardid
		{
			get
			{
				return this._cardid;
			}
			set
			{
				if ((this._cardid != value))
				{
					this._cardid = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[user]")]
	public partial class user : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _name;
		
		private string _password;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnpasswordChanging(string value);
    partial void OnpasswordChanged();
    #endregion
		
		public user()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NChar(30) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="NChar(30)")]
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this.OnpasswordChanging(value);
					this.SendPropertyChanging();
					this._password = value;
					this.SendPropertyChanged("password");
					this.OnpasswordChanged();
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
