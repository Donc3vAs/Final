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

namespace Baigiamasis_dabras
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Data")]
	public partial class DataLDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertVartotojai(Vartotojai instance);
    partial void UpdateVartotojai(Vartotojai instance);
    partial void DeleteVartotojai(Vartotojai instance);
    partial void InsertKlientai(Klientai instance);
    partial void UpdateKlientai(Klientai instance);
    partial void DeleteKlientai(Klientai instance);
    partial void InsertKlientaitikrint(Klientaitikrint instance);
    partial void UpdateKlientaitikrint(Klientaitikrint instance);
    partial void DeleteKlientaitikrint(Klientaitikrint instance);
    partial void InsertIvykiai(Ivykiai instance);
    partial void UpdateIvykiai(Ivykiai instance);
    partial void DeleteIvykiai(Ivykiai instance);
    #endregion
		
		public DataLDataContext() : 
				base(global::Baigiamasis_dabras.Properties.Settings.Default.DataConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataLDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataLDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataLDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataLDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Vartotojai> Vartotojais
		{
			get
			{
				return this.GetTable<Vartotojai>();
			}
		}
		
		public System.Data.Linq.Table<Klientai> Klientais
		{
			get
			{
				return this.GetTable<Klientai>();
			}
		}
		
		public System.Data.Linq.Table<Klientaitikrint> Klientaitikrints
		{
			get
			{
				return this.GetTable<Klientaitikrint>();
			}
		}
		
		public System.Data.Linq.Table<Ivykiai> Ivykiais
		{
			get
			{
				return this.GetTable<Ivykiai>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Vartotojai")]
	public partial class Vartotojai : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Vartotojas;
		
		private string _Slaptazodis;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnVartotojasChanging(string value);
    partial void OnVartotojasChanged();
    partial void OnSlaptazodisChanging(string value);
    partial void OnSlaptazodisChanged();
    #endregion
		
		public Vartotojai()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Vartotojas", DbType="NVarChar(50)")]
		public string Vartotojas
		{
			get
			{
				return this._Vartotojas;
			}
			set
			{
				if ((this._Vartotojas != value))
				{
					this.OnVartotojasChanging(value);
					this.SendPropertyChanging();
					this._Vartotojas = value;
					this.SendPropertyChanged("Vartotojas");
					this.OnVartotojasChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Slaptazodis", DbType="NVarChar(50)")]
		public string Slaptazodis
		{
			get
			{
				return this._Slaptazodis;
			}
			set
			{
				if ((this._Slaptazodis != value))
				{
					this.OnSlaptazodisChanging(value);
					this.SendPropertyChanging();
					this._Slaptazodis = value;
					this.SendPropertyChanged("Slaptazodis");
					this.OnSlaptazodisChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Klientai")]
	public partial class Klientai : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Vardas;
		
		private string _Numeris;
		
		private string _Elpastas;
		
		private string _Vip;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnVardasChanging(string value);
    partial void OnVardasChanged();
    partial void OnNumerisChanging(string value);
    partial void OnNumerisChanged();
    partial void OnElpastasChanging(string value);
    partial void OnElpastasChanged();
    partial void OnVipChanging(string value);
    partial void OnVipChanged();
    #endregion
		
		public Klientai()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Vardas", DbType="NVarChar(50)")]
		public string Vardas
		{
			get
			{
				return this._Vardas;
			}
			set
			{
				if ((this._Vardas != value))
				{
					this.OnVardasChanging(value);
					this.SendPropertyChanging();
					this._Vardas = value;
					this.SendPropertyChanged("Vardas");
					this.OnVardasChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Numeris", DbType="NVarChar(50)")]
		public string Numeris
		{
			get
			{
				return this._Numeris;
			}
			set
			{
				if ((this._Numeris != value))
				{
					this.OnNumerisChanging(value);
					this.SendPropertyChanging();
					this._Numeris = value;
					this.SendPropertyChanged("Numeris");
					this.OnNumerisChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Elpastas", DbType="NVarChar(100)")]
		public string Elpastas
		{
			get
			{
				return this._Elpastas;
			}
			set
			{
				if ((this._Elpastas != value))
				{
					this.OnElpastasChanging(value);
					this.SendPropertyChanging();
					this._Elpastas = value;
					this.SendPropertyChanged("Elpastas");
					this.OnElpastasChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Vip", DbType="NVarChar(4)")]
		public string Vip
		{
			get
			{
				return this._Vip;
			}
			set
			{
				if ((this._Vip != value))
				{
					this.OnVipChanging(value);
					this.SendPropertyChanging();
					this._Vip = value;
					this.SendPropertyChanged("Vip");
					this.OnVipChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Klientaitikrint")]
	public partial class Klientaitikrint : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Vardas;
		
		private string _Numeris;
		
		private string _Elpastas;
		
		private string _Vip;
		
		private string _Vartotojas;
		
		private System.Nullable<int> _Session;
		
		private string _Veiksmas;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnVardasChanging(string value);
    partial void OnVardasChanged();
    partial void OnNumerisChanging(string value);
    partial void OnNumerisChanged();
    partial void OnElpastasChanging(string value);
    partial void OnElpastasChanged();
    partial void OnVipChanging(string value);
    partial void OnVipChanged();
    partial void OnVartotojasChanging(string value);
    partial void OnVartotojasChanged();
    partial void OnSessionChanging(System.Nullable<int> value);
    partial void OnSessionChanged();
    partial void OnVeiksmasChanging(string value);
    partial void OnVeiksmasChanged();
    #endregion
		
		public Klientaitikrint()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Vardas", DbType="NVarChar(50)")]
		public string Vardas
		{
			get
			{
				return this._Vardas;
			}
			set
			{
				if ((this._Vardas != value))
				{
					this.OnVardasChanging(value);
					this.SendPropertyChanging();
					this._Vardas = value;
					this.SendPropertyChanged("Vardas");
					this.OnVardasChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Numeris", DbType="NVarChar(50)")]
		public string Numeris
		{
			get
			{
				return this._Numeris;
			}
			set
			{
				if ((this._Numeris != value))
				{
					this.OnNumerisChanging(value);
					this.SendPropertyChanging();
					this._Numeris = value;
					this.SendPropertyChanged("Numeris");
					this.OnNumerisChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Elpastas", DbType="NVarChar(100)")]
		public string Elpastas
		{
			get
			{
				return this._Elpastas;
			}
			set
			{
				if ((this._Elpastas != value))
				{
					this.OnElpastasChanging(value);
					this.SendPropertyChanging();
					this._Elpastas = value;
					this.SendPropertyChanged("Elpastas");
					this.OnElpastasChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Vip", DbType="NVarChar(4)")]
		public string Vip
		{
			get
			{
				return this._Vip;
			}
			set
			{
				if ((this._Vip != value))
				{
					this.OnVipChanging(value);
					this.SendPropertyChanging();
					this._Vip = value;
					this.SendPropertyChanged("Vip");
					this.OnVipChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Vartotojas", DbType="NVarChar(50)")]
		public string Vartotojas
		{
			get
			{
				return this._Vartotojas;
			}
			set
			{
				if ((this._Vartotojas != value))
				{
					this.OnVartotojasChanging(value);
					this.SendPropertyChanging();
					this._Vartotojas = value;
					this.SendPropertyChanged("Vartotojas");
					this.OnVartotojasChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Session", DbType="Int")]
		public System.Nullable<int> Session
		{
			get
			{
				return this._Session;
			}
			set
			{
				if ((this._Session != value))
				{
					this.OnSessionChanging(value);
					this.SendPropertyChanging();
					this._Session = value;
					this.SendPropertyChanged("Session");
					this.OnSessionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Veiksmas", DbType="NVarChar(50)")]
		public string Veiksmas
		{
			get
			{
				return this._Veiksmas;
			}
			set
			{
				if ((this._Veiksmas != value))
				{
					this.OnVeiksmasChanging(value);
					this.SendPropertyChanging();
					this._Veiksmas = value;
					this.SendPropertyChanged("Veiksmas");
					this.OnVeiksmasChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Ivykiai")]
	public partial class Ivykiai : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Vartotojas;
		
		private System.Nullable<int> _Session;
		
		private string _Eventas;
		
		private string _Tekstas;
		
		private System.Nullable<System.DateTime> _TikslusLaikas;
		
		private System.Nullable<int> _Tarpas;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnVartotojasChanging(string value);
    partial void OnVartotojasChanged();
    partial void OnSessionChanging(System.Nullable<int> value);
    partial void OnSessionChanged();
    partial void OnEventasChanging(string value);
    partial void OnEventasChanged();
    partial void OnTekstasChanging(string value);
    partial void OnTekstasChanged();
    partial void OnTikslusLaikasChanging(System.Nullable<System.DateTime> value);
    partial void OnTikslusLaikasChanged();
    partial void OnTarpasChanging(System.Nullable<int> value);
    partial void OnTarpasChanged();
    #endregion
		
		public Ivykiai()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Vartotojas", DbType="NVarChar(50)")]
		public string Vartotojas
		{
			get
			{
				return this._Vartotojas;
			}
			set
			{
				if ((this._Vartotojas != value))
				{
					this.OnVartotojasChanging(value);
					this.SendPropertyChanging();
					this._Vartotojas = value;
					this.SendPropertyChanged("Vartotojas");
					this.OnVartotojasChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Session", DbType="Int")]
		public System.Nullable<int> Session
		{
			get
			{
				return this._Session;
			}
			set
			{
				if ((this._Session != value))
				{
					this.OnSessionChanging(value);
					this.SendPropertyChanging();
					this._Session = value;
					this.SendPropertyChanged("Session");
					this.OnSessionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Eventas", DbType="NVarChar(50)")]
		public string Eventas
		{
			get
			{
				return this._Eventas;
			}
			set
			{
				if ((this._Eventas != value))
				{
					this.OnEventasChanging(value);
					this.SendPropertyChanging();
					this._Eventas = value;
					this.SendPropertyChanged("Eventas");
					this.OnEventasChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tekstas", DbType="NVarChar(100)")]
		public string Tekstas
		{
			get
			{
				return this._Tekstas;
			}
			set
			{
				if ((this._Tekstas != value))
				{
					this.OnTekstasChanging(value);
					this.SendPropertyChanging();
					this._Tekstas = value;
					this.SendPropertyChanged("Tekstas");
					this.OnTekstasChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TikslusLaikas", DbType="DateTime")]
		public System.Nullable<System.DateTime> TikslusLaikas
		{
			get
			{
				return this._TikslusLaikas;
			}
			set
			{
				if ((this._TikslusLaikas != value))
				{
					this.OnTikslusLaikasChanging(value);
					this.SendPropertyChanging();
					this._TikslusLaikas = value;
					this.SendPropertyChanged("TikslusLaikas");
					this.OnTikslusLaikasChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tarpas", DbType="Int")]
		public System.Nullable<int> Tarpas
		{
			get
			{
				return this._Tarpas;
			}
			set
			{
				if ((this._Tarpas != value))
				{
					this.OnTarpasChanging(value);
					this.SendPropertyChanging();
					this._Tarpas = value;
					this.SendPropertyChanged("Tarpas");
					this.OnTarpasChanged();
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
