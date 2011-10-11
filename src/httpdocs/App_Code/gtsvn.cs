#region Auto-generated classes for gtsdb database on 2011-10-11 11:19:15Z

//
//  ____  _     __  __      _        _
// |  _ \| |__ |  \/  | ___| |_ __ _| |
// | | | | '_ \| |\/| |/ _ \ __/ _` | |
// | |_| | |_) | |  | |  __/ || (_| | |
// |____/|_.__/|_|  |_|\___|\__\__,_|_|
//
// Auto-generated from gtsdb on 2011-10-11 11:19:15Z
// Please visit http://linq.to/db for more information

#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq.Mapping;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using DbLinq.Data.Linq;
using DbLinq.Data.Linq.Mapping;

namespace gtsvn
{
	public partial class GTSdB : DbLinq.Data.Linq.DataContext
	{
		public GTSdB(System.Data.IDbConnection connection)
		: base(connection, new DbLinq.MySql.MySqlVendor())
		{
		}

		public GTSdB(System.Data.IDbConnection connection, DbLinq.Vendor.IVendor vendor)
		: base(connection, vendor)
		{
		}

		public Table<BaseInfo> BaseInfo { get { return GetTable<BaseInfo>(); } }
		public Table<Contact> Contact { get { return GetTable<Contact>(); } }
		public Table<Country> Country { get { return GetTable<Country>(); } }
		public Table<Event> Event { get { return GetTable<Event>(); } }
		public Table<Hotel> Hotel { get { return GetTable<Hotel>(); } }
		public Table<Location> Location { get { return GetTable<Location>(); } }
		public Table<Pictures> Pictures { get { return GetTable<Pictures>(); } }
		public Table<Role> Role { get { return GetTable<Role>(); } }
		public Table<Scenery> Scenery { get { return GetTable<Scenery>(); } }
		public Table<Tour> Tour { get { return GetTable<Tour>(); } }
		public Table<TourGroup> TourGroup { get { return GetTable<TourGroup>(); } }
		public Table<TourHotel> TourHotel { get { return GetTable<TourHotel>(); } }
		public Table<TourKind> TourKind { get { return GetTable<TourKind>(); } }
		public Table<TourReG> TourReG { get { return GetTable<TourReG>(); } }
		public Table<TourTourKind> TourTourKind { get { return GetTable<TourTourKind>(); } }
		public Table<UserRole> UserRole { get { return GetTable<UserRole>(); } }
		public Table<Users> Users { get { return GetTable<Users>(); } }

	}

	[Table(Name = "baseinfo")]
	public partial class BaseInfo : INotifyPropertyChanged
	{
		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region string Description

		private string _description;
		[DebuggerNonUserCode]
		[Column(Storage = "_description", Name = "Description", DbType = "longtext")]
		public string Description
		{
			get
			{
				return _description;
			}
			set
			{
				if (value != _description)
				{
					_description = value;
					OnPropertyChanged("Description");
				}
			}
		}

		#endregion

		#region uint InfoID

		private uint _infoID;
		[DebuggerNonUserCode]
		[Column(Storage = "_infoID", Name = "InfoId", DbType = "int unsigned", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
		public uint InfoID
		{
			get
			{
				return _infoID;
			}
			set
			{
				if (value != _infoID)
				{
					_infoID = value;
					OnPropertyChanged("InfoID");
				}
			}
		}

		#endregion

		#region string InfoKind

		private string _infoKind;
		[DebuggerNonUserCode]
		[Column(Storage = "_infoKind", Name = "InfoKind", DbType = "varchar(500)")]
		public string InfoKind
		{
			get
			{
				return _infoKind;
			}
			set
			{
				if (value != _infoKind)
				{
					_infoKind = value;
					OnPropertyChanged("InfoKind");
				}
			}
		}

		#endregion

		#region bool? IsActived

		private bool? _isActived;
		[DebuggerNonUserCode]
		[Column(Storage = "_isActived", Name = "IsActived", DbType = "bit(1)")]
		public bool? IsActived
		{
			get
			{
				return _isActived;
			}
			set
			{
				if (value != _isActived)
				{
					_isActived = value;
					OnPropertyChanged("IsActived");
				}
			}
		}

		#endregion

		#region System.DateTime? LastUpdt

		private System.DateTime? _lastUpdt;
		[DebuggerNonUserCode]
		[Column(Storage = "_lastUpdt", Name = "LastUpdt", DbType = "datetime")]
		public System.DateTime? LastUpdt
		{
			get
			{
				return _lastUpdt;
			}
			set
			{
				if (value != _lastUpdt)
				{
					_lastUpdt = value;
					OnPropertyChanged("LastUpdt");
				}
			}
		}

		#endregion

	}

	[Table(Name = "contact")]
	public partial class Contact : INotifyPropertyChanged
	{
		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region string Address

		private string _address;
		[DebuggerNonUserCode]
		[Column(Storage = "_address", Name = "Address", DbType = "varchar(500)")]
		public string Address
		{
			get
			{
				return _address;
			}
			set
			{
				if (value != _address)
				{
					_address = value;
					OnPropertyChanged("Address");
				}
			}
		}

		#endregion

		#region System.DateTime? ContactDate

		private System.DateTime? _contactDate;
		[DebuggerNonUserCode]
		[Column(Storage = "_contactDate", Name = "ContactDate", DbType = "datetime")]
		public System.DateTime? ContactDate
		{
			get
			{
				return _contactDate;
			}
			set
			{
				if (value != _contactDate)
				{
					_contactDate = value;
					OnPropertyChanged("ContactDate");
				}
			}
		}

		#endregion

		#region uint ContactID

		private uint _contactID;
		[DebuggerNonUserCode]
		[Column(Storage = "_contactID", Name = "ContactId", DbType = "int unsigned", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
		public uint ContactID
		{
			get
			{
				return _contactID;
			}
			set
			{
				if (value != _contactID)
				{
					_contactID = value;
					OnPropertyChanged("ContactID");
				}
			}
		}

		#endregion

		#region string Contents

		private string _contents;
		[DebuggerNonUserCode]
		[Column(Storage = "_contents", Name = "Contents", DbType = "longtext")]
		public string Contents
		{
			get
			{
				return _contents;
			}
			set
			{
				if (value != _contents)
				{
					_contents = value;
					OnPropertyChanged("Contents");
				}
			}
		}

		#endregion

		#region string Email

		private string _email;
		[DebuggerNonUserCode]
		[Column(Storage = "_email", Name = "Email", DbType = "varchar(100)")]
		public string Email
		{
			get
			{
				return _email;
			}
			set
			{
				if (value != _email)
				{
					_email = value;
					OnPropertyChanged("Email");
				}
			}
		}

		#endregion

		#region bool? IsSolved

		private bool? _isSolved;
		[DebuggerNonUserCode]
		[Column(Storage = "_isSolved", Name = "IsSolved", DbType = "bit(1)")]
		public bool? IsSolved
		{
			get
			{
				return _isSolved;
			}
			set
			{
				if (value != _isSolved)
				{
					_isSolved = value;
					OnPropertyChanged("IsSolved");
				}
			}
		}

		#endregion

		#region System.DateTime? LastUpdt

		private System.DateTime? _lastUpdt;
		[DebuggerNonUserCode]
		[Column(Storage = "_lastUpdt", Name = "LastUpdt", DbType = "datetime")]
		public System.DateTime? LastUpdt
		{
			get
			{
				return _lastUpdt;
			}
			set
			{
				if (value != _lastUpdt)
				{
					_lastUpdt = value;
					OnPropertyChanged("LastUpdt");
				}
			}
		}

		#endregion

		#region string Name

		private string _name;
		[DebuggerNonUserCode]
		[Column(Storage = "_name", Name = "Name", DbType = "varchar(500)")]
		public string Name
		{
			get
			{
				return _name;
			}
			set
			{
				if (value != _name)
				{
					_name = value;
					OnPropertyChanged("Name");
				}
			}
		}

		#endregion

		#region string Phone

		private string _phone;
		[DebuggerNonUserCode]
		[Column(Storage = "_phone", Name = "Phone", DbType = "varchar(100)")]
		public string Phone
		{
			get
			{
				return _phone;
			}
			set
			{
				if (value != _phone)
				{
					_phone = value;
					OnPropertyChanged("Phone");
				}
			}
		}

		#endregion

		#region string ReplyComment

		private string _replyComment;
		[DebuggerNonUserCode]
		[Column(Storage = "_replyComment", Name = "ReplyComment", DbType = "varchar(5000)")]
		public string ReplyComment
		{
			get
			{
				return _replyComment;
			}
			set
			{
				if (value != _replyComment)
				{
					_replyComment = value;
					OnPropertyChanged("ReplyComment");
				}
			}
		}

		#endregion

		#region System.DateTime? ReplyDate

		private System.DateTime? _replyDate;
		[DebuggerNonUserCode]
		[Column(Storage = "_replyDate", Name = "ReplyDate", DbType = "datetime")]
		public System.DateTime? ReplyDate
		{
			get
			{
				return _replyDate;
			}
			set
			{
				if (value != _replyDate)
				{
					_replyDate = value;
					OnPropertyChanged("ReplyDate");
				}
			}
		}

		#endregion

		#region int? UserID

		private int? _userID;
		[DebuggerNonUserCode]
		[Column(Storage = "_userID", Name = "UserId", DbType = "int")]
		public int? UserID
		{
			get
			{
				return _userID;
			}
			set
			{
				if (value != _userID)
				{
					_userID = value;
					OnPropertyChanged("UserID");
				}
			}
		}

		#endregion

	}

	[Table(Name = "country")]
	public partial class Country : INotifyPropertyChanged
	{
		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region uint CountryID

		private uint _countryID;
		[DebuggerNonUserCode]
		[Column(Storage = "_countryID", Name = "CountryId", DbType = "int unsigned", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
		public uint CountryID
		{
			get
			{
				return _countryID;
			}
			set
			{
				if (value != _countryID)
				{
					_countryID = value;
					OnPropertyChanged("CountryID");
				}
			}
		}

		#endregion

		#region string CountryNm

		private string _countryNm;
		[DebuggerNonUserCode]
		[Column(Storage = "_countryNm", Name = "CountryNm", DbType = "varchar(500)")]
		public string CountryNm
		{
			get
			{
				return _countryNm;
			}
			set
			{
				if (value != _countryNm)
				{
					_countryNm = value;
					OnPropertyChanged("CountryNm");
				}
			}
		}

		#endregion

		#region string Description

		private string _description;
		[DebuggerNonUserCode]
		[Column(Storage = "_description", Name = "Description", DbType = "longtext")]
		public string Description
		{
			get
			{
				return _description;
			}
			set
			{
				if (value != _description)
				{
					_description = value;
					OnPropertyChanged("Description");
				}
			}
		}

		#endregion

	}

	[Table(Name = "event")]
	public partial class Event : INotifyPropertyChanged
	{
		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region string Description

		private string _description;
		[DebuggerNonUserCode]
		[Column(Storage = "_description", Name = "Description", DbType = "longtext")]
		public string Description
		{
			get
			{
				return _description;
			}
			set
			{
				if (value != _description)
				{
					_description = value;
					OnPropertyChanged("Description");
				}
			}
		}

		#endregion

		#region uint EventID

		private uint _eventID;
		[DebuggerNonUserCode]
		[Column(Storage = "_eventID", Name = "EventId", DbType = "int unsigned", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
		public uint EventID
		{
			get
			{
				return _eventID;
			}
			set
			{
				if (value != _eventID)
				{
					_eventID = value;
					OnPropertyChanged("EventID");
				}
			}
		}

		#endregion

		#region string EventNm

		private string _eventNm;
		[DebuggerNonUserCode]
		[Column(Storage = "_eventNm", Name = "EventNm", DbType = "varchar(500)")]
		public string EventNm
		{
			get
			{
				return _eventNm;
			}
			set
			{
				if (value != _eventNm)
				{
					_eventNm = value;
					OnPropertyChanged("EventNm");
				}
			}
		}

		#endregion

		#region System.DateTime? FromDate

		private System.DateTime? _fromDate;
		[DebuggerNonUserCode]
		[Column(Storage = "_fromDate", Name = "FromDate", DbType = "datetime")]
		public System.DateTime? FromDate
		{
			get
			{
				return _fromDate;
			}
			set
			{
				if (value != _fromDate)
				{
					_fromDate = value;
					OnPropertyChanged("FromDate");
				}
			}
		}

		#endregion

		#region bool? IsActived

		private bool? _isActived;
		[DebuggerNonUserCode]
		[Column(Storage = "_isActived", Name = "IsActived", DbType = "bit(1)")]
		public bool? IsActived
		{
			get
			{
				return _isActived;
			}
			set
			{
				if (value != _isActived)
				{
					_isActived = value;
					OnPropertyChanged("IsActived");
				}
			}
		}

		#endregion

		#region int? LocaID

		private int? _locaID;
		[DebuggerNonUserCode]
		[Column(Storage = "_locaID", Name = "LocaId", DbType = "int")]
		public int? LocaID
		{
			get
			{
				return _locaID;
			}
			set
			{
				if (value != _locaID)
				{
					_locaID = value;
					OnPropertyChanged("LocaID");
				}
			}
		}

		#endregion

		#region string PicPath1

		private string _picPath1;
		[DebuggerNonUserCode]
		[Column(Storage = "_picPath1", Name = "PicPath1", DbType = "varchar(500)")]
		public string PicPath1
		{
			get
			{
				return _picPath1;
			}
			set
			{
				if (value != _picPath1)
				{
					_picPath1 = value;
					OnPropertyChanged("PicPath1");
				}
			}
		}

		#endregion

		#region string PicPath2

		private string _picPath2;
		[DebuggerNonUserCode]
		[Column(Storage = "_picPath2", Name = "PicPath2", DbType = "varchar(500)")]
		public string PicPath2
		{
			get
			{
				return _picPath2;
			}
			set
			{
				if (value != _picPath2)
				{
					_picPath2 = value;
					OnPropertyChanged("PicPath2");
				}
			}
		}

		#endregion

		#region System.DateTime? ToDate

		private System.DateTime? _toDate;
		[DebuggerNonUserCode]
		[Column(Storage = "_toDate", Name = "ToDate", DbType = "datetime")]
		public System.DateTime? ToDate
		{
			get
			{
				return _toDate;
			}
			set
			{
				if (value != _toDate)
				{
					_toDate = value;
					OnPropertyChanged("ToDate");
				}
			}
		}

		#endregion

	}

	[Table(Name = "hotel")]
	public partial class Hotel : INotifyPropertyChanged
	{
		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region string DescReview

		private string _descReview;
		[DebuggerNonUserCode]
		[Column(Storage = "_descReview", Name = "DescReview", DbType = "varchar(5000)")]
		public string DescReview
		{
			get
			{
				return _descReview;
			}
			set
			{
				if (value != _descReview)
				{
					_descReview = value;
					OnPropertyChanged("DescReview");
				}
			}
		}

		#endregion

		#region string Description

		private string _description;
		[DebuggerNonUserCode]
		[Column(Storage = "_description", Name = "Description", DbType = "longtext")]
		public string Description
		{
			get
			{
				return _description;
			}
			set
			{
				if (value != _description)
				{
					_description = value;
					OnPropertyChanged("Description");
				}
			}
		}

		#endregion

		#region uint HotelID

		private uint _hotelID;
		[DebuggerNonUserCode]
		[Column(Storage = "_hotelID", Name = "HotelId", DbType = "int unsigned", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
		public uint HotelID
		{
			get
			{
				return _hotelID;
			}
			set
			{
				if (value != _hotelID)
				{
					_hotelID = value;
					OnPropertyChanged("HotelID");
				}
			}
		}

		#endregion

		#region string HotelNm

		private string _hotelNm;
		[DebuggerNonUserCode]
		[Column(Storage = "_hotelNm", Name = "HotelNm", DbType = "varchar(500)")]
		public string HotelNm
		{
			get
			{
				return _hotelNm;
			}
			set
			{
				if (value != _hotelNm)
				{
					_hotelNm = value;
					OnPropertyChanged("HotelNm");
				}
			}
		}

		#endregion

		#region bool? IsActived

		private bool? _isActived;
		[DebuggerNonUserCode]
		[Column(Storage = "_isActived", Name = "IsActived", DbType = "bit(1)")]
		public bool? IsActived
		{
			get
			{
				return _isActived;
			}
			set
			{
				if (value != _isActived)
				{
					_isActived = value;
					OnPropertyChanged("IsActived");
				}
			}
		}

		#endregion

		#region int? LocaID

		private int? _locaID;
		[DebuggerNonUserCode]
		[Column(Storage = "_locaID", Name = "LocaId", DbType = "int")]
		public int? LocaID
		{
			get
			{
				return _locaID;
			}
			set
			{
				if (value != _locaID)
				{
					_locaID = value;
					OnPropertyChanged("LocaID");
				}
			}
		}

		#endregion

		#region string PicPath1

		private string _picPath1;
		[DebuggerNonUserCode]
		[Column(Storage = "_picPath1", Name = "PicPath1", DbType = "varchar(500)")]
		public string PicPath1
		{
			get
			{
				return _picPath1;
			}
			set
			{
				if (value != _picPath1)
				{
					_picPath1 = value;
					OnPropertyChanged("PicPath1");
				}
			}
		}

		#endregion

		#region string PicPath2

		private string _picPath2;
		[DebuggerNonUserCode]
		[Column(Storage = "_picPath2", Name = "PicPath2", DbType = "varchar(500)")]
		public string PicPath2
		{
			get
			{
				return _picPath2;
			}
			set
			{
				if (value != _picPath2)
				{
					_picPath2 = value;
					OnPropertyChanged("PicPath2");
				}
			}
		}

		#endregion

		#region string Price

		private string _price;
		[DebuggerNonUserCode]
		[Column(Storage = "_price", Name = "Price", DbType = "varchar(100)")]
		public string Price
		{
			get
			{
				return _price;
			}
			set
			{
				if (value != _price)
				{
					_price = value;
					OnPropertyChanged("Price");
				}
			}
		}

		#endregion

		#region int? Star

		private int? _star;
		[DebuggerNonUserCode]
		[Column(Storage = "_star", Name = "Star", DbType = "int")]
		public int? Star
		{
			get
			{
				return _star;
			}
			set
			{
				if (value != _star)
				{
					_star = value;
					OnPropertyChanged("Star");
				}
			}
		}

		#endregion

	}

	[Table(Name = "location")]
	public partial class Location : INotifyPropertyChanged
	{
		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region int? CountryID

		private int? _countryID;
		[DebuggerNonUserCode]
		[Column(Storage = "_countryID", Name = "CountryId", DbType = "int")]
		public int? CountryID
		{
			get
			{
				return _countryID;
			}
			set
			{
				if (value != _countryID)
				{
					_countryID = value;
					OnPropertyChanged("CountryID");
				}
			}
		}

		#endregion

		#region string Description

		private string _description;
		[DebuggerNonUserCode]
		[Column(Storage = "_description", Name = "Description", DbType = "longtext")]
		public string Description
		{
			get
			{
				return _description;
			}
			set
			{
				if (value != _description)
				{
					_description = value;
					OnPropertyChanged("Description");
				}
			}
		}

		#endregion

		#region double? Idx

		private double? _idx;
		[DebuggerNonUserCode]
		[Column(Storage = "_idx", Name = "Idx", DbType = "double")]
		public double? Idx
		{
			get
			{
				return _idx;
			}
			set
			{
				if (value != _idx)
				{
					_idx = value;
					OnPropertyChanged("Idx");
				}
			}
		}

		#endregion

		#region bool? IsActived

		private bool? _isActived;
		[DebuggerNonUserCode]
		[Column(Storage = "_isActived", Name = "IsActived", DbType = "bit(1)")]
		public bool? IsActived
		{
			get
			{
				return _isActived;
			}
			set
			{
				if (value != _isActived)
				{
					_isActived = value;
					OnPropertyChanged("IsActived");
				}
			}
		}

		#endregion

		#region uint LocaID

		private uint _locaID;
		[DebuggerNonUserCode]
		[Column(Storage = "_locaID", Name = "LocaId", DbType = "int unsigned", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
		public uint LocaID
		{
			get
			{
				return _locaID;
			}
			set
			{
				if (value != _locaID)
				{
					_locaID = value;
					OnPropertyChanged("LocaID");
				}
			}
		}

		#endregion

		#region string LocaNm

		private string _locaNm;
		[DebuggerNonUserCode]
		[Column(Storage = "_locaNm", Name = "LocaNm", DbType = "varchar(500)")]
		public string LocaNm
		{
			get
			{
				return _locaNm;
			}
			set
			{
				if (value != _locaNm)
				{
					_locaNm = value;
					OnPropertyChanged("LocaNm");
				}
			}
		}

		#endregion

	}

	[Table(Name = "pictures")]
	public partial class Pictures : INotifyPropertyChanged
	{
		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region string FullPath

		private string _fullPath;
		[DebuggerNonUserCode]
		[Column(Storage = "_fullPath", Name = "FullPath", DbType = "varchar(5000)")]
		public string FullPath
		{
			get
			{
				return _fullPath;
			}
			set
			{
				if (value != _fullPath)
				{
					_fullPath = value;
					OnPropertyChanged("FullPath");
				}
			}
		}

		#endregion

		#region bool? IsDefault

		private bool? _isDefault;
		[DebuggerNonUserCode]
		[Column(Storage = "_isDefault", Name = "IsDefault", DbType = "bit(1)")]
		public bool? IsDefault
		{
			get
			{
				return _isDefault;
			}
			set
			{
				if (value != _isDefault)
				{
					_isDefault = value;
					OnPropertyChanged("IsDefault");
				}
			}
		}

		#endregion

		#region int? ItemsID

		private int? _itemsID;
		[DebuggerNonUserCode]
		[Column(Storage = "_itemsID", Name = "ItemsId", DbType = "int")]
		public int? ItemsID
		{
			get
			{
				return _itemsID;
			}
			set
			{
				if (value != _itemsID)
				{
					_itemsID = value;
					OnPropertyChanged("ItemsID");
				}
			}
		}

		#endregion

		#region string PicDesc

		private string _picDesc;
		[DebuggerNonUserCode]
		[Column(Storage = "_picDesc", Name = "PicDesc", DbType = "varchar(5000)")]
		public string PicDesc
		{
			get
			{
				return _picDesc;
			}
			set
			{
				if (value != _picDesc)
				{
					_picDesc = value;
					OnPropertyChanged("PicDesc");
				}
			}
		}

		#endregion

		#region uint PicID

		private uint _picID;
		[DebuggerNonUserCode]
		[Column(Storage = "_picID", Name = "PicId", DbType = "int unsigned", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
		public uint PicID
		{
			get
			{
				return _picID;
			}
			set
			{
				if (value != _picID)
				{
					_picID = value;
					OnPropertyChanged("PicID");
				}
			}
		}

		#endregion

		#region string PicKind

		private string _picKind;
		[DebuggerNonUserCode]
		[Column(Storage = "_picKind", Name = "PicKind", DbType = "varchar(500)")]
		public string PicKind
		{
			get
			{
				return _picKind;
			}
			set
			{
				if (value != _picKind)
				{
					_picKind = value;
					OnPropertyChanged("PicKind");
				}
			}
		}

		#endregion

		#region string PicNm

		private string _picNm;
		[DebuggerNonUserCode]
		[Column(Storage = "_picNm", Name = "PicNm", DbType = "varchar(1000)")]
		public string PicNm
		{
			get
			{
				return _picNm;
			}
			set
			{
				if (value != _picNm)
				{
					_picNm = value;
					OnPropertyChanged("PicNm");
				}
			}
		}

		#endregion

		#region string PicPath

		private string _picPath;
		[DebuggerNonUserCode]
		[Column(Storage = "_picPath", Name = "PicPath", DbType = "varchar(1000)")]
		public string PicPath
		{
			get
			{
				return _picPath;
			}
			set
			{
				if (value != _picPath)
				{
					_picPath = value;
					OnPropertyChanged("PicPath");
				}
			}
		}

		#endregion

		#region System.DateTime? UpdtDate

		private System.DateTime? _updtDate;
		[DebuggerNonUserCode]
		[Column(Storage = "_updtDate", Name = "UpdtDate", DbType = "datetime")]
		public System.DateTime? UpdtDate
		{
			get
			{
				return _updtDate;
			}
			set
			{
				if (value != _updtDate)
				{
					_updtDate = value;
					OnPropertyChanged("UpdtDate");
				}
			}
		}

		#endregion

	}

	[Table(Name = "role")]
	public partial class Role : INotifyPropertyChanged
	{
		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region string Description

		private string _description;
		[DebuggerNonUserCode]
		[Column(Storage = "_description", Name = "Description", DbType = "longtext")]
		public string Description
		{
			get
			{
				return _description;
			}
			set
			{
				if (value != _description)
				{
					_description = value;
					OnPropertyChanged("Description");
				}
			}
		}

		#endregion

		#region bool? IsActived

		private bool? _isActived;
		[DebuggerNonUserCode]
		[Column(Storage = "_isActived", Name = "IsActived", DbType = "bit(1)")]
		public bool? IsActived
		{
			get
			{
				return _isActived;
			}
			set
			{
				if (value != _isActived)
				{
					_isActived = value;
					OnPropertyChanged("IsActived");
				}
			}
		}

		#endregion

		#region uint RoleID

		private uint _roleID;
		[DebuggerNonUserCode]
		[Column(Storage = "_roleID", Name = "RoleId", DbType = "int unsigned", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
		public uint RoleID
		{
			get
			{
				return _roleID;
			}
			set
			{
				if (value != _roleID)
				{
					_roleID = value;
					OnPropertyChanged("RoleID");
				}
			}
		}

		#endregion

		#region string RoleNm

		private string _roleNm;
		[DebuggerNonUserCode]
		[Column(Storage = "_roleNm", Name = "RoleNm", DbType = "varchar(500)")]
		public string RoleNm
		{
			get
			{
				return _roleNm;
			}
			set
			{
				if (value != _roleNm)
				{
					_roleNm = value;
					OnPropertyChanged("RoleNm");
				}
			}
		}

		#endregion

	}

	[Table(Name = "scenery")]
	public partial class Scenery : INotifyPropertyChanged
	{
		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region string DescReview

		private string _descReview;
		[DebuggerNonUserCode]
		[Column(Storage = "_descReview", Name = "DescReview", DbType = "varchar(5000)")]
		public string DescReview
		{
			get
			{
				return _descReview;
			}
			set
			{
				if (value != _descReview)
				{
					_descReview = value;
					OnPropertyChanged("DescReview");
				}
			}
		}

		#endregion

		#region string Description

		private string _description;
		[DebuggerNonUserCode]
		[Column(Storage = "_description", Name = "Description", DbType = "longtext")]
		public string Description
		{
			get
			{
				return _description;
			}
			set
			{
				if (value != _description)
				{
					_description = value;
					OnPropertyChanged("Description");
				}
			}
		}

		#endregion

		#region bool? IsActived

		private bool? _isActived;
		[DebuggerNonUserCode]
		[Column(Storage = "_isActived", Name = "IsActived", DbType = "bit(1)")]
		public bool? IsActived
		{
			get
			{
				return _isActived;
			}
			set
			{
				if (value != _isActived)
				{
					_isActived = value;
					OnPropertyChanged("IsActived");
				}
			}
		}

		#endregion

		#region int? LocaID

		private int? _locaID;
		[DebuggerNonUserCode]
		[Column(Storage = "_locaID", Name = "LocaId", DbType = "int")]
		public int? LocaID
		{
			get
			{
				return _locaID;
			}
			set
			{
				if (value != _locaID)
				{
					_locaID = value;
					OnPropertyChanged("LocaID");
				}
			}
		}

		#endregion

		#region string PicPath1

		private string _picPath1;
		[DebuggerNonUserCode]
		[Column(Storage = "_picPath1", Name = "PicPath1", DbType = "varchar(500)")]
		public string PicPath1
		{
			get
			{
				return _picPath1;
			}
			set
			{
				if (value != _picPath1)
				{
					_picPath1 = value;
					OnPropertyChanged("PicPath1");
				}
			}
		}

		#endregion

		#region string PicPath2

		private string _picPath2;
		[DebuggerNonUserCode]
		[Column(Storage = "_picPath2", Name = "PicPath2", DbType = "varchar(500)")]
		public string PicPath2
		{
			get
			{
				return _picPath2;
			}
			set
			{
				if (value != _picPath2)
				{
					_picPath2 = value;
					OnPropertyChanged("PicPath2");
				}
			}
		}

		#endregion

		#region uint ScenID

		private uint _scenID;
		[DebuggerNonUserCode]
		[Column(Storage = "_scenID", Name = "ScenId", DbType = "int unsigned", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
		public uint ScenID
		{
			get
			{
				return _scenID;
			}
			set
			{
				if (value != _scenID)
				{
					_scenID = value;
					OnPropertyChanged("ScenID");
				}
			}
		}

		#endregion

		#region string ScenNm

		private string _scenNm;
		[DebuggerNonUserCode]
		[Column(Storage = "_scenNm", Name = "ScenNm", DbType = "varchar(500)")]
		public string ScenNm
		{
			get
			{
				return _scenNm;
			}
			set
			{
				if (value != _scenNm)
				{
					_scenNm = value;
					OnPropertyChanged("ScenNm");
				}
			}
		}

		#endregion

	}

	[Table(Name = "tour")]
	public partial class Tour : INotifyPropertyChanged
	{
		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region string DescReview

		private string _descReview;
		[DebuggerNonUserCode]
		[Column(Storage = "_descReview", Name = "DescReview", DbType = "varchar(5000)")]
		public string DescReview
		{
			get
			{
				return _descReview;
			}
			set
			{
				if (value != _descReview)
				{
					_descReview = value;
					OnPropertyChanged("DescReview");
				}
			}
		}

		#endregion

		#region string Description

		private string _description;
		[DebuggerNonUserCode]
		[Column(Storage = "_description", Name = "Description", DbType = "longtext")]
		public string Description
		{
			get
			{
				return _description;
			}
			set
			{
				if (value != _description)
				{
					_description = value;
					OnPropertyChanged("Description");
				}
			}
		}

		#endregion

		#region int? HotelID

		private int? _hotelID;
		[DebuggerNonUserCode]
		[Column(Storage = "_hotelID", Name = "HotelId", DbType = "int")]
		public int? HotelID
		{
			get
			{
				return _hotelID;
			}
			set
			{
				if (value != _hotelID)
				{
					_hotelID = value;
					OnPropertyChanged("HotelID");
				}
			}
		}

		#endregion

		#region System.DateTime? InsDate

		private System.DateTime? _insDate;
		[DebuggerNonUserCode]
		[Column(Storage = "_insDate", Name = "InsDate", DbType = "datetime")]
		public System.DateTime? InsDate
		{
			get
			{
				return _insDate;
			}
			set
			{
				if (value != _insDate)
				{
					_insDate = value;
					OnPropertyChanged("InsDate");
				}
			}
		}

		#endregion

		#region bool? IsActived

		private bool? _isActived;
		[DebuggerNonUserCode]
		[Column(Storage = "_isActived", Name = "IsActived", DbType = "bit(1)")]
		public bool? IsActived
		{
			get
			{
				return _isActived;
			}
			set
			{
				if (value != _isActived)
				{
					_isActived = value;
					OnPropertyChanged("IsActived");
				}
			}
		}

		#endregion

		#region bool? IsNew

		private bool? _isNew;
		[DebuggerNonUserCode]
		[Column(Storage = "_isNew", Name = "IsNew", DbType = "bit(1)")]
		public bool? IsNew
		{
			get
			{
				return _isNew;
			}
			set
			{
				if (value != _isNew)
				{
					_isNew = value;
					OnPropertyChanged("IsNew");
				}
			}
		}

		#endregion

		#region bool? IsProminent

		private bool? _isProminent;
		[DebuggerNonUserCode]
		[Column(Storage = "_isProminent", Name = "IsProminent", DbType = "bit(1)")]
		public bool? IsProminent
		{
			get
			{
				return _isProminent;
			}
			set
			{
				if (value != _isProminent)
				{
					_isProminent = value;
					OnPropertyChanged("IsProminent");
				}
			}
		}

		#endregion

		#region bool? IsPromotion

		private bool? _isPromotion;
		[DebuggerNonUserCode]
		[Column(Storage = "_isPromotion", Name = "IsPromotion", DbType = "bit(1)")]
		public bool? IsPromotion
		{
			get
			{
				return _isPromotion;
			}
			set
			{
				if (value != _isPromotion)
				{
					_isPromotion = value;
					OnPropertyChanged("IsPromotion");
				}
			}
		}

		#endregion

		#region int? LocaID

		private int? _locaID;
		[DebuggerNonUserCode]
		[Column(Storage = "_locaID", Name = "LocaId", DbType = "int")]
		public int? LocaID
		{
			get
			{
				return _locaID;
			}
			set
			{
				if (value != _locaID)
				{
					_locaID = value;
					OnPropertyChanged("LocaID");
				}
			}
		}

		#endregion

		#region string PicPath1

		private string _picPath1;
		[DebuggerNonUserCode]
		[Column(Storage = "_picPath1", Name = "PicPath1", DbType = "varchar(500)")]
		public string PicPath1
		{
			get
			{
				return _picPath1;
			}
			set
			{
				if (value != _picPath1)
				{
					_picPath1 = value;
					OnPropertyChanged("PicPath1");
				}
			}
		}

		#endregion

		#region string PicPath2

		private string _picPath2;
		[DebuggerNonUserCode]
		[Column(Storage = "_picPath2", Name = "PicPath2", DbType = "varchar(500)")]
		public string PicPath2
		{
			get
			{
				return _picPath2;
			}
			set
			{
				if (value != _picPath2)
				{
					_picPath2 = value;
					OnPropertyChanged("PicPath2");
				}
			}
		}

		#endregion

		#region int? TourGroup

		private int? _tourGroup;
		[DebuggerNonUserCode]
		[Column(Storage = "_tourGroup", Name = "TourGroup", DbType = "int")]
		public int? TourGroup
		{
			get
			{
				return _tourGroup;
			}
			set
			{
				if (value != _tourGroup)
				{
					_tourGroup = value;
					OnPropertyChanged("TourGroup");
				}
			}
		}

		#endregion

		#region uint TourID

		private uint _tourID;
		[DebuggerNonUserCode]
		[Column(Storage = "_tourID", Name = "TourId", DbType = "int unsigned", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
		public uint TourID
		{
			get
			{
				return _tourID;
			}
			set
			{
				if (value != _tourID)
				{
					_tourID = value;
					OnPropertyChanged("TourID");
				}
			}
		}

		#endregion

		#region string TourNm

		private string _tourNm;
		[DebuggerNonUserCode]
		[Column(Storage = "_tourNm", Name = "TourNm", DbType = "varchar(500)")]
		public string TourNm
		{
			get
			{
				return _tourNm;
			}
			set
			{
				if (value != _tourNm)
				{
					_tourNm = value;
					OnPropertyChanged("TourNm");
				}
			}
		}

		#endregion

		#region string TourReview

		private string _tourReview;
		[DebuggerNonUserCode]
		[Column(Storage = "_tourReview", Name = "TourReview", DbType = "longtext")]
		public string TourReview
		{
			get
			{
				return _tourReview;
			}
			set
			{
				if (value != _tourReview)
				{
					_tourReview = value;
					OnPropertyChanged("TourReview");
				}
			}
		}

		#endregion

	}

	[Table(Name = "tourgroup")]
	public partial class TourGroup : INotifyPropertyChanged
	{
		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region string Description

		private string _description;
		[DebuggerNonUserCode]
		[Column(Storage = "_description", Name = "Description", DbType = "longtext")]
		public string Description
		{
			get
			{
				return _description;
			}
			set
			{
				if (value != _description)
				{
					_description = value;
					OnPropertyChanged("Description");
				}
			}
		}

		#endregion

		#region bool? IsActived

		private bool? _isActived;
		[DebuggerNonUserCode]
		[Column(Storage = "_isActived", Name = "IsActived", DbType = "bit(1)")]
		public bool? IsActived
		{
			get
			{
				return _isActived;
			}
			set
			{
				if (value != _isActived)
				{
					_isActived = value;
					OnPropertyChanged("IsActived");
				}
			}
		}

		#endregion

		#region uint TourGroupID

		private uint _tourGroupID;
		[DebuggerNonUserCode]
		[Column(Storage = "_tourGroupID", Name = "TourGroupId", DbType = "int unsigned", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
		public uint TourGroupID
		{
			get
			{
				return _tourGroupID;
			}
			set
			{
				if (value != _tourGroupID)
				{
					_tourGroupID = value;
					OnPropertyChanged("TourGroupID");
				}
			}
		}

		#endregion

		#region string TourGroupNm

		private string _tourGroupNm;
		[DebuggerNonUserCode]
		[Column(Storage = "_tourGroupNm", Name = "TourGroupNm", DbType = "varchar(500)")]
		public string TourGroupNm
		{
			get
			{
				return _tourGroupNm;
			}
			set
			{
				if (value != _tourGroupNm)
				{
					_tourGroupNm = value;
					OnPropertyChanged("TourGroupNm");
				}
			}
		}

		#endregion

	}

	[Table(Name = "tourhotel")]
	public partial class TourHotel : INotifyPropertyChanged
	{
		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region int HotelID

		private int _hotelID;
		[DebuggerNonUserCode]
		[Column(Storage = "_hotelID", Name = "HotelId", DbType = "int", IsPrimaryKey = true, CanBeNull = false)]
		public int HotelID
		{
			get
			{
				return _hotelID;
			}
			set
			{
				if (value != _hotelID)
				{
					_hotelID = value;
					OnPropertyChanged("HotelID");
				}
			}
		}

		#endregion

		#region int TourID

		private int _tourID;
		[DebuggerNonUserCode]
		[Column(Storage = "_tourID", Name = "TourId", DbType = "int", IsPrimaryKey = true, CanBeNull = false)]
		public int TourID
		{
			get
			{
				return _tourID;
			}
			set
			{
				if (value != _tourID)
				{
					_tourID = value;
					OnPropertyChanged("TourID");
				}
			}
		}

		#endregion

	}

	[Table(Name = "tourkind")]
	public partial class TourKind : INotifyPropertyChanged
	{
		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region string Description

		private string _description;
		[DebuggerNonUserCode]
		[Column(Storage = "_description", Name = "Description", DbType = "longtext")]
		public string Description
		{
			get
			{
				return _description;
			}
			set
			{
				if (value != _description)
				{
					_description = value;
					OnPropertyChanged("Description");
				}
			}
		}

		#endregion

		#region bool? IsActived

		private bool? _isActived;
		[DebuggerNonUserCode]
		[Column(Storage = "_isActived", Name = "IsActived", DbType = "bit(1)")]
		public bool? IsActived
		{
			get
			{
				return _isActived;
			}
			set
			{
				if (value != _isActived)
				{
					_isActived = value;
					OnPropertyChanged("IsActived");
				}
			}
		}

		#endregion

		#region int? TourGroupID

		private int? _tourGroupID;
		[DebuggerNonUserCode]
		[Column(Storage = "_tourGroupID", Name = "TourGroupId", DbType = "int")]
		public int? TourGroupID
		{
			get
			{
				return _tourGroupID;
			}
			set
			{
				if (value != _tourGroupID)
				{
					_tourGroupID = value;
					OnPropertyChanged("TourGroupID");
				}
			}
		}

		#endregion

		#region uint TourKindID

		private uint _tourKindID;
		[DebuggerNonUserCode]
		[Column(Storage = "_tourKindID", Name = "TourKindId", DbType = "int unsigned", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
		public uint TourKindID
		{
			get
			{
				return _tourKindID;
			}
			set
			{
				if (value != _tourKindID)
				{
					_tourKindID = value;
					OnPropertyChanged("TourKindID");
				}
			}
		}

		#endregion

		#region string TourKindNm

		private string _tourKindNm;
		[DebuggerNonUserCode]
		[Column(Storage = "_tourKindNm", Name = "TourKindNm", DbType = "varchar(500)")]
		public string TourKindNm
		{
			get
			{
				return _tourKindNm;
			}
			set
			{
				if (value != _tourKindNm)
				{
					_tourKindNm = value;
					OnPropertyChanged("TourKindNm");
				}
			}
		}

		#endregion

	}

	[Table(Name = "tourreg")]
	public partial class TourReG : INotifyPropertyChanged
	{
		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region string Address

		private string _address;
		[DebuggerNonUserCode]
		[Column(Storage = "_address", Name = "Address", DbType = "varchar(500)")]
		public string Address
		{
			get
			{
				return _address;
			}
			set
			{
				if (value != _address)
				{
					_address = value;
					OnPropertyChanged("Address");
				}
			}
		}

		#endregion

		#region int? Adult

		private int? _adult;
		[DebuggerNonUserCode]
		[Column(Storage = "_adult", Name = "Adult", DbType = "int")]
		public int? Adult
		{
			get
			{
				return _adult;
			}
			set
			{
				if (value != _adult)
				{
					_adult = value;
					OnPropertyChanged("Adult");
				}
			}
		}

		#endregion

		#region int? Child

		private int? _child;
		[DebuggerNonUserCode]
		[Column(Storage = "_child", Name = "Child", DbType = "int")]
		public int? Child
		{
			get
			{
				return _child;
			}
			set
			{
				if (value != _child)
				{
					_child = value;
					OnPropertyChanged("Child");
				}
			}
		}

		#endregion

		#region string Comment

		private string _comment;
		[DebuggerNonUserCode]
		[Column(Storage = "_comment", Name = "Comment", DbType = "varchar(5000)")]
		public string Comment
		{
			get
			{
				return _comment;
			}
			set
			{
				if (value != _comment)
				{
					_comment = value;
					OnPropertyChanged("Comment");
				}
			}
		}

		#endregion

		#region string Description

		private string _description;
		[DebuggerNonUserCode]
		[Column(Storage = "_description", Name = "Description", DbType = "longtext")]
		public string Description
		{
			get
			{
				return _description;
			}
			set
			{
				if (value != _description)
				{
					_description = value;
					OnPropertyChanged("Description");
				}
			}
		}

		#endregion

		#region System.DateTime? FromDate

		private System.DateTime? _fromDate;
		[DebuggerNonUserCode]
		[Column(Storage = "_fromDate", Name = "FromDate", DbType = "datetime")]
		public System.DateTime? FromDate
		{
			get
			{
				return _fromDate;
			}
			set
			{
				if (value != _fromDate)
				{
					_fromDate = value;
					OnPropertyChanged("FromDate");
				}
			}
		}

		#endregion

		#region string Hotel

		private string _hotel;
		[DebuggerNonUserCode]
		[Column(Storage = "_hotel", Name = "Hotel", DbType = "varchar(5000)")]
		public string Hotel
		{
			get
			{
				return _hotel;
			}
			set
			{
				if (value != _hotel)
				{
					_hotel = value;
					OnPropertyChanged("Hotel");
				}
			}
		}

		#endregion

		#region bool? IsCancel

		private bool? _isCancel;
		[DebuggerNonUserCode]
		[Column(Storage = "_isCancel", Name = "IsCancel", DbType = "bit(1)")]
		public bool? IsCancel
		{
			get
			{
				return _isCancel;
			}
			set
			{
				if (value != _isCancel)
				{
					_isCancel = value;
					OnPropertyChanged("IsCancel");
				}
			}
		}

		#endregion

		#region bool? IsSolved

		private bool? _isSolved;
		[DebuggerNonUserCode]
		[Column(Storage = "_isSolved", Name = "IsSolved", DbType = "bit(1)")]
		public bool? IsSolved
		{
			get
			{
				return _isSolved;
			}
			set
			{
				if (value != _isSolved)
				{
					_isSolved = value;
					OnPropertyChanged("IsSolved");
				}
			}
		}

		#endregion

		#region System.DateTime? LastUpdt

		private System.DateTime? _lastUpdt;
		[DebuggerNonUserCode]
		[Column(Storage = "_lastUpdt", Name = "LastUpdt", DbType = "date")]
		public System.DateTime? LastUpdt
		{
			get
			{
				return _lastUpdt;
			}
			set
			{
				if (value != _lastUpdt)
				{
					_lastUpdt = value;
					OnPropertyChanged("LastUpdt");
				}
			}
		}

		#endregion

		#region string Phone

		private string _phone;
		[DebuggerNonUserCode]
		[Column(Storage = "_phone", Name = "Phone", DbType = "varchar(100)")]
		public string Phone
		{
			get
			{
				return _phone;
			}
			set
			{
				if (value != _phone)
				{
					_phone = value;
					OnPropertyChanged("Phone");
				}
			}
		}

		#endregion

		#region string PlaceNm

		private string _placeNm;
		[DebuggerNonUserCode]
		[Column(Storage = "_placeNm", Name = "PlaceNm", DbType = "varchar(5000)")]
		public string PlaceNm
		{
			get
			{
				return _placeNm;
			}
			set
			{
				if (value != _placeNm)
				{
					_placeNm = value;
					OnPropertyChanged("PlaceNm");
				}
			}
		}

		#endregion

		#region System.DateTime? ToDate

		private System.DateTime? _toDate;
		[DebuggerNonUserCode]
		[Column(Storage = "_toDate", Name = "ToDate", DbType = "datetime")]
		public System.DateTime? ToDate
		{
			get
			{
				return _toDate;
			}
			set
			{
				if (value != _toDate)
				{
					_toDate = value;
					OnPropertyChanged("ToDate");
				}
			}
		}

		#endregion

		#region string TourGuide

		private string _tourGuide;
		[DebuggerNonUserCode]
		[Column(Storage = "_tourGuide", Name = "TourGuide", DbType = "varchar(100)")]
		public string TourGuide
		{
			get
			{
				return _tourGuide;
			}
			set
			{
				if (value != _tourGuide)
				{
					_tourGuide = value;
					OnPropertyChanged("TourGuide");
				}
			}
		}

		#endregion

		#region uint TourRegID

		private uint _tourRegID;
		[DebuggerNonUserCode]
		[Column(Storage = "_tourRegID", Name = "TourRegId", DbType = "int unsigned zerofill", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
		public uint TourRegID
		{
			get
			{
				return _tourRegID;
			}
			set
			{
				if (value != _tourRegID)
				{
					_tourRegID = value;
					OnPropertyChanged("TourRegID");
				}
			}
		}

		#endregion

		#region int? Trans

		private int? _trans;
		[DebuggerNonUserCode]
		[Column(Storage = "_trans", Name = "Trans", DbType = "int")]
		public int? Trans
		{
			get
			{
				return _trans;
			}
			set
			{
				if (value != _trans)
				{
					_trans = value;
					OnPropertyChanged("Trans");
				}
			}
		}

		#endregion

	}

	[Table(Name = "tourtourkind")]
	public partial class TourTourKind : INotifyPropertyChanged
	{
		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region int TourID

		private int _tourID;
		[DebuggerNonUserCode]
		[Column(Storage = "_tourID", Name = "TourId", DbType = "int", IsPrimaryKey = true, CanBeNull = false)]
		public int TourID
		{
			get
			{
				return _tourID;
			}
			set
			{
				if (value != _tourID)
				{
					_tourID = value;
					OnPropertyChanged("TourID");
				}
			}
		}

		#endregion

		#region int TourKindID

		private int _tourKindID;
		[DebuggerNonUserCode]
		[Column(Storage = "_tourKindID", Name = "TourKindId", DbType = "int", IsPrimaryKey = true, CanBeNull = false)]
		public int TourKindID
		{
			get
			{
				return _tourKindID;
			}
			set
			{
				if (value != _tourKindID)
				{
					_tourKindID = value;
					OnPropertyChanged("TourKindID");
				}
			}
		}

		#endregion

	}

	[Table(Name = "userrole")]
	public partial class UserRole : INotifyPropertyChanged
	{
		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region bool? IsActived

		private bool? _isActived;
		[DebuggerNonUserCode]
		[Column(Storage = "_isActived", Name = "IsActived", DbType = "bit(1)")]
		public bool? IsActived
		{
			get
			{
				return _isActived;
			}
			set
			{
				if (value != _isActived)
				{
					_isActived = value;
					OnPropertyChanged("IsActived");
				}
			}
		}

		#endregion

		#region int RoleID

		private int _roleID;
		[DebuggerNonUserCode]
		[Column(Storage = "_roleID", Name = "RoleId", DbType = "int", IsPrimaryKey = true, CanBeNull = false)]
		public int RoleID
		{
			get
			{
				return _roleID;
			}
			set
			{
				if (value != _roleID)
				{
					_roleID = value;
					OnPropertyChanged("RoleID");
				}
			}
		}

		#endregion

		#region int UserID

		private int _userID;
		[DebuggerNonUserCode]
		[Column(Storage = "_userID", Name = "UserId", DbType = "int", IsPrimaryKey = true, CanBeNull = false)]
		public int UserID
		{
			get
			{
				return _userID;
			}
			set
			{
				if (value != _userID)
				{
					_userID = value;
					OnPropertyChanged("UserID");
				}
			}
		}

		#endregion

	}

	[Table(Name = "users")]
	public partial class Users : INotifyPropertyChanged
	{
		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region string Address1

		private string _address1;
		[DebuggerNonUserCode]
		[Column(Storage = "_address1", Name = "Address1", DbType = "varchar(500)")]
		public string Address1
		{
			get
			{
				return _address1;
			}
			set
			{
				if (value != _address1)
				{
					_address1 = value;
					OnPropertyChanged("Address1");
				}
			}
		}

		#endregion

		#region string Address2

		private string _address2;
		[DebuggerNonUserCode]
		[Column(Storage = "_address2", Name = "Address2", DbType = "varchar(500)")]
		public string Address2
		{
			get
			{
				return _address2;
			}
			set
			{
				if (value != _address2)
				{
					_address2 = value;
					OnPropertyChanged("Address2");
				}
			}
		}

		#endregion

		#region int? Age

		private int? _age;
		[DebuggerNonUserCode]
		[Column(Storage = "_age", Name = "Age", DbType = "int")]
		public int? Age
		{
			get
			{
				return _age;
			}
			set
			{
				if (value != _age)
				{
					_age = value;
					OnPropertyChanged("Age");
				}
			}
		}

		#endregion

		#region string Email

		private string _email;
		[DebuggerNonUserCode]
		[Column(Storage = "_email", Name = "Email", DbType = "varchar(100)")]
		public string Email
		{
			get
			{
				return _email;
			}
			set
			{
				if (value != _email)
				{
					_email = value;
					OnPropertyChanged("Email");
				}
			}
		}

		#endregion

		#region string FullNm

		private string _fullNm;
		[DebuggerNonUserCode]
		[Column(Storage = "_fullNm", Name = "FullNm", DbType = "varchar(500)")]
		public string FullNm
		{
			get
			{
				return _fullNm;
			}
			set
			{
				if (value != _fullNm)
				{
					_fullNm = value;
					OnPropertyChanged("FullNm");
				}
			}
		}

		#endregion

		#region string HomePhone

		private string _homePhone;
		[DebuggerNonUserCode]
		[Column(Storage = "_homePhone", Name = "HomePhone", DbType = "varchar(100)")]
		public string HomePhone
		{
			get
			{
				return _homePhone;
			}
			set
			{
				if (value != _homePhone)
				{
					_homePhone = value;
					OnPropertyChanged("HomePhone");
				}
			}
		}

		#endregion

		#region bool? IsActived

		private bool? _isActived;
		[DebuggerNonUserCode]
		[Column(Storage = "_isActived", Name = "IsActived", DbType = "bit(1)")]
		public bool? IsActived
		{
			get
			{
				return _isActived;
			}
			set
			{
				if (value != _isActived)
				{
					_isActived = value;
					OnPropertyChanged("IsActived");
				}
			}
		}

		#endregion

		#region System.DateTime? LastUpdt

		private System.DateTime? _lastUpdt;
		[DebuggerNonUserCode]
		[Column(Storage = "_lastUpdt", Name = "LastUpdt", DbType = "datetime")]
		public System.DateTime? LastUpdt
		{
			get
			{
				return _lastUpdt;
			}
			set
			{
				if (value != _lastUpdt)
				{
					_lastUpdt = value;
					OnPropertyChanged("LastUpdt");
				}
			}
		}

		#endregion

		#region string Phone

		private string _phone;
		[DebuggerNonUserCode]
		[Column(Storage = "_phone", Name = "Phone", DbType = "varchar(100)")]
		public string Phone
		{
			get
			{
				return _phone;
			}
			set
			{
				if (value != _phone)
				{
					_phone = value;
					OnPropertyChanged("Phone");
				}
			}
		}

		#endregion

		#region string PicPath

		private string _picPath;
		[DebuggerNonUserCode]
		[Column(Storage = "_picPath", Name = "PicPath", DbType = "varchar(500)")]
		public string PicPath
		{
			get
			{
				return _picPath;
			}
			set
			{
				if (value != _picPath)
				{
					_picPath = value;
					OnPropertyChanged("PicPath");
				}
			}
		}

		#endregion

		#region string Pwd

		private string _pwd;
		[DebuggerNonUserCode]
		[Column(Storage = "_pwd", Name = "Pwd", DbType = "varchar(100)")]
		public string Pwd
		{
			get
			{
				return _pwd;
			}
			set
			{
				if (value != _pwd)
				{
					_pwd = value;
					OnPropertyChanged("Pwd");
				}
			}
		}

		#endregion

		#region string PwdEncrypt

		private string _pwdEncrypt;
		[DebuggerNonUserCode]
		[Column(Storage = "_pwdEncrypt", Name = "PwdEncrypt", DbType = "varchar(500)")]
		public string PwdEncrypt
		{
			get
			{
				return _pwdEncrypt;
			}
			set
			{
				if (value != _pwdEncrypt)
				{
					_pwdEncrypt = value;
					OnPropertyChanged("PwdEncrypt");
				}
			}
		}

		#endregion

		#region int? Sex

		private int? _sex;
		[DebuggerNonUserCode]
		[Column(Storage = "_sex", Name = "Sex", DbType = "int")]
		public int? Sex
		{
			get
			{
				return _sex;
			}
			set
			{
				if (value != _sex)
				{
					_sex = value;
					OnPropertyChanged("Sex");
				}
			}
		}

		#endregion

		#region uint UserID

		private uint _userID;
		[DebuggerNonUserCode]
		[Column(Storage = "_userID", Name = "UserId", DbType = "int unsigned", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
		public uint UserID
		{
			get
			{
				return _userID;
			}
			set
			{
				if (value != _userID)
				{
					_userID = value;
					OnPropertyChanged("UserID");
				}
			}
		}

		#endregion

		#region string UserNm

		private string _userNm;
		[DebuggerNonUserCode]
		[Column(Storage = "_userNm", Name = "UserNm", DbType = "varchar(500)")]
		public string UserNm
		{
			get
			{
				return _userNm;
			}
			set
			{
				if (value != _userNm)
				{
					_userNm = value;
					OnPropertyChanged("UserNm");
				}
			}
		}

		#endregion

	}
}
