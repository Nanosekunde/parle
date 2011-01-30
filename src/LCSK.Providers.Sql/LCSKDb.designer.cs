﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LCSK.Providers.Sql
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="hlsim")]
	public partial class LCSKDbDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertLiveChat_ChatMessage(LiveChat_ChatMessage instance);
    partial void UpdateLiveChat_ChatMessage(LiveChat_ChatMessage instance);
    partial void DeleteLiveChat_ChatMessage(LiveChat_ChatMessage instance);
    partial void InsertLiveChat_ChatRequest(LiveChat_ChatRequest instance);
    partial void UpdateLiveChat_ChatRequest(LiveChat_ChatRequest instance);
    partial void DeleteLiveChat_ChatRequest(LiveChat_ChatRequest instance);
    partial void InsertLiveChat_LogAccess(LiveChat_LogAccess instance);
    partial void UpdateLiveChat_LogAccess(LiveChat_LogAccess instance);
    partial void DeleteLiveChat_LogAccess(LiveChat_LogAccess instance);
    partial void InsertLiveChat_Operator(LiveChat_Operator instance);
    partial void UpdateLiveChat_Operator(LiveChat_Operator instance);
    partial void DeleteLiveChat_Operator(LiveChat_Operator instance);
    #endregion
		
		public LCSKDbDataContext() : 
				base(global::LCSK.Providers.Sql.Properties.Settings.Default.hlsimConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public LCSKDbDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LCSKDbDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LCSKDbDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LCSKDbDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<LiveChat_ChatMessage> LiveChat_ChatMessages
		{
			get
			{
				return this.GetTable<LiveChat_ChatMessage>();
			}
		}
		
		public System.Data.Linq.Table<LiveChat_ChatRequest> LiveChat_ChatRequests
		{
			get
			{
				return this.GetTable<LiveChat_ChatRequest>();
			}
		}
		
		public System.Data.Linq.Table<LiveChat_LogAccess> LiveChat_LogAccesses
		{
			get
			{
				return this.GetTable<LiveChat_LogAccess>();
			}
		}
		
		public System.Data.Linq.Table<LiveChat_Operator> LiveChat_Operators
		{
			get
			{
				return this.GetTable<LiveChat_Operator>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.LiveChat_ChatMessages")]
	public partial class LiveChat_ChatMessage : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _MessageID;
		
		private System.Guid _ChatID;
		
		private string _FromName;
		
		private string _Message;
		
		private long _SentDate;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMessageIDChanging(long value);
    partial void OnMessageIDChanged();
    partial void OnChatIDChanging(System.Guid value);
    partial void OnChatIDChanged();
    partial void OnFromNameChanging(string value);
    partial void OnFromNameChanged();
    partial void OnMessageChanging(string value);
    partial void OnMessageChanged();
    partial void OnSentDateChanging(long value);
    partial void OnSentDateChanged();
    #endregion
		
		public LiveChat_ChatMessage()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MessageID", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long MessageID
		{
			get
			{
				return this._MessageID;
			}
			set
			{
				if ((this._MessageID != value))
				{
					this.OnMessageIDChanging(value);
					this.SendPropertyChanging();
					this._MessageID = value;
					this.SendPropertyChanged("MessageID");
					this.OnMessageIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ChatID", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid ChatID
		{
			get
			{
				return this._ChatID;
			}
			set
			{
				if ((this._ChatID != value))
				{
					this.OnChatIDChanging(value);
					this.SendPropertyChanging();
					this._ChatID = value;
					this.SendPropertyChanged("ChatID");
					this.OnChatIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FromName", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string FromName
		{
			get
			{
				return this._FromName;
			}
			set
			{
				if ((this._FromName != value))
				{
					this.OnFromNameChanging(value);
					this.SendPropertyChanging();
					this._FromName = value;
					this.SendPropertyChanged("FromName");
					this.OnFromNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Message", DbType="VarChar(3000) NOT NULL", CanBeNull=false)]
		public string Message
		{
			get
			{
				return this._Message;
			}
			set
			{
				if ((this._Message != value))
				{
					this.OnMessageChanging(value);
					this.SendPropertyChanging();
					this._Message = value;
					this.SendPropertyChanged("Message");
					this.OnMessageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SentDate", DbType="BigInt NOT NULL")]
		public long SentDate
		{
			get
			{
				return this._SentDate;
			}
			set
			{
				if ((this._SentDate != value))
				{
					this.OnSentDateChanging(value);
					this.SendPropertyChanging();
					this._SentDate = value;
					this.SendPropertyChanged("SentDate");
					this.OnSentDateChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.LiveChat_ChatRequests")]
	public partial class LiveChat_ChatRequest : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _ChatID;
		
		private string _VisitorIP;
		
		private string _VisitorName;
		
		private string _VisitorEmail;
		
		private string _VisitorUserAgent;
		
		private int _OperatorID;
		
		private System.DateTime _RequestDate;
		
		private System.Nullable<System.DateTime> _AcceptDate;
		
		private System.Nullable<System.DateTime> _ClosedDate;
		
		private string _Department;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnChatIDChanging(System.Guid value);
    partial void OnChatIDChanged();
    partial void OnVisitorIPChanging(string value);
    partial void OnVisitorIPChanged();
    partial void OnVisitorNameChanging(string value);
    partial void OnVisitorNameChanged();
    partial void OnVisitorEmailChanging(string value);
    partial void OnVisitorEmailChanged();
    partial void OnVisitorUserAgentChanging(string value);
    partial void OnVisitorUserAgentChanged();
    partial void OnOperatorIDChanging(int value);
    partial void OnOperatorIDChanged();
    partial void OnRequestDateChanging(System.DateTime value);
    partial void OnRequestDateChanged();
    partial void OnAcceptDateChanging(System.Nullable<System.DateTime> value);
    partial void OnAcceptDateChanged();
    partial void OnClosedDateChanging(System.Nullable<System.DateTime> value);
    partial void OnClosedDateChanged();
    partial void OnDepartmentChanging(string value);
    partial void OnDepartmentChanged();
    #endregion
		
		public LiveChat_ChatRequest()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ChatID", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid ChatID
		{
			get
			{
				return this._ChatID;
			}
			set
			{
				if ((this._ChatID != value))
				{
					this.OnChatIDChanging(value);
					this.SendPropertyChanging();
					this._ChatID = value;
					this.SendPropertyChanged("ChatID");
					this.OnChatIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VisitorIP", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string VisitorIP
		{
			get
			{
				return this._VisitorIP;
			}
			set
			{
				if ((this._VisitorIP != value))
				{
					this.OnVisitorIPChanging(value);
					this.SendPropertyChanging();
					this._VisitorIP = value;
					this.SendPropertyChanged("VisitorIP");
					this.OnVisitorIPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VisitorName", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string VisitorName
		{
			get
			{
				return this._VisitorName;
			}
			set
			{
				if ((this._VisitorName != value))
				{
					this.OnVisitorNameChanging(value);
					this.SendPropertyChanging();
					this._VisitorName = value;
					this.SendPropertyChanged("VisitorName");
					this.OnVisitorNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VisitorEmail", DbType="VarChar(225) NOT NULL", CanBeNull=false)]
		public string VisitorEmail
		{
			get
			{
				return this._VisitorEmail;
			}
			set
			{
				if ((this._VisitorEmail != value))
				{
					this.OnVisitorEmailChanging(value);
					this.SendPropertyChanging();
					this._VisitorEmail = value;
					this.SendPropertyChanged("VisitorEmail");
					this.OnVisitorEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VisitorUserAgent", DbType="VarChar(125) NOT NULL", CanBeNull=false)]
		public string VisitorUserAgent
		{
			get
			{
				return this._VisitorUserAgent;
			}
			set
			{
				if ((this._VisitorUserAgent != value))
				{
					this.OnVisitorUserAgentChanging(value);
					this.SendPropertyChanging();
					this._VisitorUserAgent = value;
					this.SendPropertyChanged("VisitorUserAgent");
					this.OnVisitorUserAgentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OperatorID", DbType="Int NOT NULL")]
		public int OperatorID
		{
			get
			{
				return this._OperatorID;
			}
			set
			{
				if ((this._OperatorID != value))
				{
					this.OnOperatorIDChanging(value);
					this.SendPropertyChanging();
					this._OperatorID = value;
					this.SendPropertyChanged("OperatorID");
					this.OnOperatorIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RequestDate", DbType="SmallDateTime NOT NULL")]
		public System.DateTime RequestDate
		{
			get
			{
				return this._RequestDate;
			}
			set
			{
				if ((this._RequestDate != value))
				{
					this.OnRequestDateChanging(value);
					this.SendPropertyChanging();
					this._RequestDate = value;
					this.SendPropertyChanged("RequestDate");
					this.OnRequestDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AcceptDate", DbType="SmallDateTime")]
		public System.Nullable<System.DateTime> AcceptDate
		{
			get
			{
				return this._AcceptDate;
			}
			set
			{
				if ((this._AcceptDate != value))
				{
					this.OnAcceptDateChanging(value);
					this.SendPropertyChanging();
					this._AcceptDate = value;
					this.SendPropertyChanged("AcceptDate");
					this.OnAcceptDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ClosedDate", DbType="SmallDateTime")]
		public System.Nullable<System.DateTime> ClosedDate
		{
			get
			{
				return this._ClosedDate;
			}
			set
			{
				if ((this._ClosedDate != value))
				{
					this.OnClosedDateChanging(value);
					this.SendPropertyChanging();
					this._ClosedDate = value;
					this.SendPropertyChanged("ClosedDate");
					this.OnClosedDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Department", DbType="VarChar(100)")]
		public string Department
		{
			get
			{
				return this._Department;
			}
			set
			{
				if ((this._Department != value))
				{
					this.OnDepartmentChanging(value);
					this.SendPropertyChanging();
					this._Department = value;
					this.SendPropertyChanged("Department");
					this.OnDepartmentChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.LiveChat_LogAccess")]
	public partial class LiveChat_LogAccess : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _LogAccessID;
		
		private string _PageRequested;
		
		private string _DomainRequested;
		
		private System.DateTime _RequestedTime;
		
		private string _Referrer;
		
		private string _VisitorUserAgent;
		
		private string _VisitorIP;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnLogAccessIDChanging(int value);
    partial void OnLogAccessIDChanged();
    partial void OnPageRequestedChanging(string value);
    partial void OnPageRequestedChanged();
    partial void OnDomainRequestedChanging(string value);
    partial void OnDomainRequestedChanged();
    partial void OnRequestedTimeChanging(System.DateTime value);
    partial void OnRequestedTimeChanged();
    partial void OnReferrerChanging(string value);
    partial void OnReferrerChanged();
    partial void OnVisitorUserAgentChanging(string value);
    partial void OnVisitorUserAgentChanged();
    partial void OnVisitorIPChanging(string value);
    partial void OnVisitorIPChanged();
    #endregion
		
		public LiveChat_LogAccess()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LogAccessID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int LogAccessID
		{
			get
			{
				return this._LogAccessID;
			}
			set
			{
				if ((this._LogAccessID != value))
				{
					this.OnLogAccessIDChanging(value);
					this.SendPropertyChanging();
					this._LogAccessID = value;
					this.SendPropertyChanged("LogAccessID");
					this.OnLogAccessIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PageRequested", DbType="VarChar(500) NOT NULL", CanBeNull=false)]
		public string PageRequested
		{
			get
			{
				return this._PageRequested;
			}
			set
			{
				if ((this._PageRequested != value))
				{
					this.OnPageRequestedChanging(value);
					this.SendPropertyChanging();
					this._PageRequested = value;
					this.SendPropertyChanged("PageRequested");
					this.OnPageRequestedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DomainRequested", DbType="VarChar(250) NOT NULL", CanBeNull=false)]
		public string DomainRequested
		{
			get
			{
				return this._DomainRequested;
			}
			set
			{
				if ((this._DomainRequested != value))
				{
					this.OnDomainRequestedChanging(value);
					this.SendPropertyChanging();
					this._DomainRequested = value;
					this.SendPropertyChanged("DomainRequested");
					this.OnDomainRequestedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RequestedTime", DbType="SmallDateTime NOT NULL")]
		public System.DateTime RequestedTime
		{
			get
			{
				return this._RequestedTime;
			}
			set
			{
				if ((this._RequestedTime != value))
				{
					this.OnRequestedTimeChanging(value);
					this.SendPropertyChanging();
					this._RequestedTime = value;
					this.SendPropertyChanged("RequestedTime");
					this.OnRequestedTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Referrer", DbType="VarChar(500) NOT NULL", CanBeNull=false)]
		public string Referrer
		{
			get
			{
				return this._Referrer;
			}
			set
			{
				if ((this._Referrer != value))
				{
					this.OnReferrerChanging(value);
					this.SendPropertyChanging();
					this._Referrer = value;
					this.SendPropertyChanged("Referrer");
					this.OnReferrerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VisitorUserAgent", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string VisitorUserAgent
		{
			get
			{
				return this._VisitorUserAgent;
			}
			set
			{
				if ((this._VisitorUserAgent != value))
				{
					this.OnVisitorUserAgentChanging(value);
					this.SendPropertyChanging();
					this._VisitorUserAgent = value;
					this.SendPropertyChanged("VisitorUserAgent");
					this.OnVisitorUserAgentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VisitorIP", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string VisitorIP
		{
			get
			{
				return this._VisitorIP;
			}
			set
			{
				if ((this._VisitorIP != value))
				{
					this.OnVisitorIPChanging(value);
					this.SendPropertyChanging();
					this._VisitorIP = value;
					this.SendPropertyChanged("VisitorIP");
					this.OnVisitorIPChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.LiveChat_Operators")]
	public partial class LiveChat_Operator : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _OperatorID;
		
		private string _OperatorName;
		
		private string _OperatorPassword;
		
		private string _OperatorEmail;
		
		private bool _IsOnline;
		
		private string _Department;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnOperatorIDChanging(int value);
    partial void OnOperatorIDChanged();
    partial void OnOperatorNameChanging(string value);
    partial void OnOperatorNameChanged();
    partial void OnOperatorPasswordChanging(string value);
    partial void OnOperatorPasswordChanged();
    partial void OnOperatorEmailChanging(string value);
    partial void OnOperatorEmailChanged();
    partial void OnIsOnlineChanging(bool value);
    partial void OnIsOnlineChanged();
    partial void OnDepartmentChanging(string value);
    partial void OnDepartmentChanged();
    #endregion
		
		public LiveChat_Operator()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OperatorID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int OperatorID
		{
			get
			{
				return this._OperatorID;
			}
			set
			{
				if ((this._OperatorID != value))
				{
					this.OnOperatorIDChanging(value);
					this.SendPropertyChanging();
					this._OperatorID = value;
					this.SendPropertyChanged("OperatorID");
					this.OnOperatorIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OperatorName", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string OperatorName
		{
			get
			{
				return this._OperatorName;
			}
			set
			{
				if ((this._OperatorName != value))
				{
					this.OnOperatorNameChanging(value);
					this.SendPropertyChanging();
					this._OperatorName = value;
					this.SendPropertyChanged("OperatorName");
					this.OnOperatorNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OperatorPassword", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string OperatorPassword
		{
			get
			{
				return this._OperatorPassword;
			}
			set
			{
				if ((this._OperatorPassword != value))
				{
					this.OnOperatorPasswordChanging(value);
					this.SendPropertyChanging();
					this._OperatorPassword = value;
					this.SendPropertyChanged("OperatorPassword");
					this.OnOperatorPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OperatorEmail", DbType="VarChar(250) NOT NULL", CanBeNull=false)]
		public string OperatorEmail
		{
			get
			{
				return this._OperatorEmail;
			}
			set
			{
				if ((this._OperatorEmail != value))
				{
					this.OnOperatorEmailChanging(value);
					this.SendPropertyChanging();
					this._OperatorEmail = value;
					this.SendPropertyChanged("OperatorEmail");
					this.OnOperatorEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsOnline", DbType="Bit NOT NULL")]
		public bool IsOnline
		{
			get
			{
				return this._IsOnline;
			}
			set
			{
				if ((this._IsOnline != value))
				{
					this.OnIsOnlineChanging(value);
					this.SendPropertyChanging();
					this._IsOnline = value;
					this.SendPropertyChanged("IsOnline");
					this.OnIsOnlineChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Department", DbType="VarChar(500) NOT NULL", CanBeNull=false)]
		public string Department
		{
			get
			{
				return this._Department;
			}
			set
			{
				if ((this._Department != value))
				{
					this.OnDepartmentChanging(value);
					this.SendPropertyChanging();
					this._Department = value;
					this.SendPropertyChanged("Department");
					this.OnDepartmentChanged();
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