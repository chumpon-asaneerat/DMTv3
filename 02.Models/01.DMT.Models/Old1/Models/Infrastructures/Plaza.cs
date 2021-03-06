﻿#region Using

using System;
using System.Collections.Generic;
using System.Linq;

using SQLite;
using SQLiteNetExtensions.Attributes;
using SQLiteNetExtensions.Extensions;

// required for JsonIgnore.
using Newtonsoft.Json;
using NLib;
using NLib.Reflection;
using System.ComponentModel;

#endregion

namespace DMT.Models
{
    #region Plaza

    /// <summary>
    /// The Plaza Data Model class.
    /// </summary>
    //[Table("Plaza")]
    public class Plaza : NTable<Plaza>
    {
        #region Intenral Variables

        private string _PlazaId = string.Empty;
        private string _PlazaNameEN = string.Empty;
        private string _PlazaNameTH = string.Empty;

        private string _TSBId = string.Empty;
        private string _TSBNameEN = string.Empty;
        private string _TSBNameTH = string.Empty;

        private string _PlazaGroupId = string.Empty;
        private string _PlazaGroupNameEN = string.Empty;
        private string _PlazaGroupNameTH = string.Empty;
        private string _Direction = string.Empty;

        private int _Status = 0;
        private DateTime _LastUpdate = DateTime.MinValue;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor.
        /// </summary>
        public Plaza() : base() { }

        #endregion

        #region Public Proprties

        #region Common

        /// <summary>
        /// Gets or sets PlazaId.
        /// </summary>
        [Category("Plaza")]
        [Description("Gets or sets PlazaId.")]
        [PrimaryKey, MaxLength(10)]
        [PeropertyMapName("PlazaId")]
        public string PlazaId
        {
            get
            {
                return _PlazaId;
            }
            set
            {
                if (_PlazaId != value)
                {
                    _PlazaId = value;
                    this.RaiseChanged("PlazaId");
                }
            }
        }
        /// <summary>
        /// Gets or sets PlazaNameEN
        /// </summary>
        [Category("Plaza")]
        [Description("Gets or sets PlazaNameEN")]
        [MaxLength(100)]
        [PeropertyMapName("PlazaNameEN")]
        public string PlazaNameEN
        {
            get
            {
                return _PlazaNameEN;
            }
            set
            {
                if (_PlazaNameEN != value)
                {
                    _PlazaNameEN = value;
                    this.RaiseChanged("PlazaNameEN");
                }
            }
        }
        /// <summary>
        /// Gets or sets PlazaNameTH
        /// </summary>
        [Category("Plaza")]
        [Description("Gets or sets PlazaNameTH")]
        [MaxLength(100)]
        [PeropertyMapName("PlazaNameTH")]
        public string PlazaNameTH
        {
            get
            {
                return _PlazaNameTH;
            }
            set
            {
                if (_PlazaNameTH != value)
                {
                    _PlazaNameTH = value;
                    this.RaiseChanged("PlazaNameTH");
                }
            }
        }

        #endregion

        #region TSB

        /// <summary>
        /// Gets or sets TSBId.
        /// </summary>
        [Category("TSB")]
        [Description("Gets or sets TSBId.")]
        [ReadOnly(true)]
        [MaxLength(10)]
        [PeropertyMapName("TSBId")]
        public string TSBId
        {
            get
            {
                return _TSBId;
            }
            set
            {
                if (_TSBId != value)
                {
                    _TSBId = value;
                    this.RaiseChanged("TSBId");
                }
            }
        }
        /// <summary>
        /// Gets or sets TSBNameEN.
        /// </summary>
        [Category("TSB")]
        [Description("Gets or sets TSBNameEN.")]
        [ReadOnly(true)]
        [Ignore]
        [PeropertyMapName("TSBNameEN")]
        public virtual string TSBNameEN
        {
            get
            {
                return _TSBNameEN;
            }
            set
            {
                if (_TSBNameEN != value)
                {
                    _TSBNameEN = value;
                    this.RaiseChanged("TSBNameEN");
                }
            }
        }
        /// <summary>
        /// Gets or sets TSBNameTH.
        /// </summary>
        [Category("TSB")]
        [Description("Gets or sets TSBNameTH.")]
        [ReadOnly(true)]
        [Ignore]
        [PeropertyMapName("TSBNameTH")]
        public virtual string TSBNameTH
        {
            get
            {
                return _TSBNameTH;
            }
            set
            {
                if (_TSBNameTH != value)
                {
                    _TSBNameTH = value;
                    this.RaiseChanged("TSBNameTH");
                }
            }
        }

        #endregion

        #region PlazaGroup

        /// <summary>
        /// Gets or sets PlazaGroupId.
        /// </summary>
        [Category("Plaza Group")]
        [Description("Gets or sets PlazaGroupId.")]
        [ReadOnly(true)]
        [MaxLength(10)]
        [PeropertyMapName("PlazaGroupId")]
        public string PlazaGroupId
        {
            get
            {
                return _PlazaGroupId;
            }
            set
            {
                if (_PlazaGroupId != value)
                {
                    _PlazaGroupId = value;
                    this.RaiseChanged("PlazaGroupId");
                }
            }
        }
        /// <summary>
        /// Gets or sets PlazaGroupNameEN.
        /// </summary>
        [Category("Plaza Group")]
        [Description("Gets or sets PlazaGroupNameEN.")]
        [ReadOnly(true)]
        [Ignore]
        [PeropertyMapName("PlazaGroupNameEN")]
        public virtual string PlazaGroupNameEN
        {
            get
            {
                return _PlazaGroupNameEN;
            }
            set
            {
                if (_PlazaGroupNameEN != value)
                {
                    _PlazaGroupNameEN = value;
                    this.RaiseChanged("PlazaGroupNameEN");
                }
            }
        }
        /// <summary>
        /// Gets or sets PlazaGroupNameTH.
        /// </summary>
        [Category("Plaza Group")]
        [Description("Gets or sets PlazaGroupNameTH.")]
        [ReadOnly(true)]
        [Ignore]
        [PeropertyMapName("PlazaGroupNameTH")]
        public virtual string PlazaGroupNameTH
        {
            get
            {
                return _PlazaGroupNameTH;
            }
            set
            {
                if (_PlazaGroupNameTH != value)
                {
                    _PlazaGroupNameTH = value;
                    this.RaiseChanged("PlazaGroupNameTH");
                }
            }
        }
        /// <summary>
        /// Gets or sets Direction.
        /// </summary>
        [Category("Plaza Group")]
        [Description("Gets or sets Direction.")]
        [ReadOnly(true)]
        [Ignore]
        [PeropertyMapName("Direction")]
        public virtual string Direction
        {
            get
            {
                return _Direction;
            }
            set
            {
                if (_Direction != value)
                {
                    _Direction = value;
                    this.RaiseChanged("Direction");
                }
            }
        }

        #endregion

        #region Status (DC)

        /// <summary>
        /// Gets or sets Status (1 = Sync, 0 = Unsync, etc..)
        /// </summary>
        [Category("DataCenter")]
        [Description("Gets or sets Status (1 = Sync, 0 = Unsync, etc..)")]
        [ReadOnly(true)]
        [PeropertyMapName("Status")]
        public int Status
        {
            get
            {
                return _Status;
            }
            set
            {
                if (_Status != value)
                {
                    _Status = value;
                    this.RaiseChanged("Status");
                }
            }
        }
        /// <summary>
        /// Gets or sets LastUpdated (Sync to DC).
        /// </summary>
        [Category("DataCenter")]
        [Description("Gets or sets LastUpdated (Sync to DC).")]
        [ReadOnly(true)]
        [PeropertyMapName("LastUpdate")]
        public DateTime LastUpdate
        {
            get { return _LastUpdate; }
            set
            {
                if (_LastUpdate != value)
                {
                    _LastUpdate = value;
                    this.RaiseChanged("LastUpdate");
                }
            }
        }

        #endregion

        #endregion

        #region Internal Class

        public class FKs : Plaza
        {
            #region TSB

            /// <summary>
            /// Gets or sets TSBNameEN.
            /// </summary>
            [MaxLength(100)]
            [PeropertyMapName("TSBNameEN")]
            public override string TSBNameEN
            {
                get { return base.TSBNameEN; }
                set { base.TSBNameEN = value; }
            }
            /// <summary>
            /// Gets or sets TSBNameTH.
            /// </summary>
            [MaxLength(100)]
            [PeropertyMapName("TSBNameTH")]
            public override string TSBNameTH
            {
                get { return base.TSBNameTH; }
                set { base.TSBNameTH = value; }
            }

            #endregion

            #region PlazaGroup

            /// <summary>
            /// Gets or sets PlazaGroupNameEN.
            /// </summary>
            [MaxLength(100)]
            [PeropertyMapName("PlazaGroupNameEN")]
            public override string PlazaGroupNameEN
            {
                get { return base.PlazaGroupNameEN; }
                set { base.PlazaGroupNameEN = value; }
            }
            /// <summary>
            /// Gets or sets PlazaGroupNameTH.
            /// </summary>
            [MaxLength(100)]
            [PeropertyMapName("PlazaGroupNameTH")]
            public override string PlazaGroupNameTH
            {
                get { return base.PlazaGroupNameTH; }
                set { base.PlazaGroupNameTH = value; }
            }
            /// <summary>
            /// Gets or sets Direction.
            /// </summary>
            [MaxLength(10)]
            [PeropertyMapName("Direction")]
            public override string Direction
            {
                get { return base.Direction; }
                set { base.Direction = value; }
            }

            #endregion

            #region Public Methods

            public Plaza ToPlaza()
            {
                Plaza inst = new Plaza();
                this.AssignTo(inst); // set all properties to new instance.
                return inst;
            }

            #endregion
        }

        #endregion

        #region Static Methods

        public static List<Plaza> Gets(SQLiteConnection db)
        {
            if (null == db) return new List<Plaza>();
            lock (sync)
            {
                string cmd = string.Empty;
                cmd += "SELECT Plaza.* ";
                cmd += "     , TSB.TSBNameEN, TSB.TSBNameTH ";
                cmd += "     , PlazaGroup.PlazaGroupNameEN, PlazaGroup.PlazaGroupNameTH, Plaza.Direction ";
                cmd += "  FROM Plaza, PlazaGroup, TSB ";
                cmd += " WHERE Plaza.TSBId = TSB.TSBId ";
                cmd += "   AND PlazaGroup.TSBId = TSB.TSBId ";
                cmd += "   AND Plaza.TSBId = TSB.TSBId ";
                cmd += "   AND Plaza.PlazaGroupId = PlazaGroup.PlazaGroupId ";

                var rets = NQuery.Query<FKs>(cmd).ToList();
                var results = new List<Plaza>();
                if (null != rets)
                {
                    rets.ForEach(ret =>
                    {
                        results.Add(ret.ToPlaza());
                    });
                }

                return results;
            }
        }
        public static List<Plaza> Gets()
        {
            lock (sync)
            {
                SQLiteConnection db = Default;
                return Gets(db);
            }
        }
        public static Plaza Get(SQLiteConnection db, string plazaId)
        {
            if (null == db) return null;
            lock (sync)
            {
                string cmd = string.Empty;
                cmd += "SELECT Plaza.* ";
                cmd += "     , TSB.TSBNameEN, TSB.TSBNameTH ";
                cmd += "     , PlazaGroup.PlazaGroupNameEN, PlazaGroup.PlazaGroupNameTH, Plaza.Direction ";
                cmd += "  FROM Plaza, PlazaGroup, TSB ";
                cmd += " WHERE Plaza.TSBId = TSB.TSBId ";
                cmd += "   AND PlazaGroup.TSBId = TSB.TSBId ";
                cmd += "   AND Plaza.TSBId = TSB.TSBId ";
                cmd += "   AND Plaza.PlazaGroupId = PlazaGroup.PlazaGroupId ";
                cmd += "   AND Plaza.PlazaId = ? ";
                var ret = NQuery.Query<FKs>(cmd, plazaId).FirstOrDefault();
                return (null != ret) ? ret.ToPlaza() : null;
            }
        }
        public static Plaza Get(string plazaId)
        {
            lock (sync)
            {
                SQLiteConnection db = Default;
                return Get(db, plazaId);
            }
        }
        public static List<Plaza> GetTSBPlazas(TSB value)
        {
            lock (sync)
            {
                if (null == value) return new List<Plaza>();
                return GetTSBPlazas(value.TSBId);
            }
        }
        public static List<Plaza> GetTSBPlazas(string tsbId)
        {
            lock (sync)
            {
                string cmd = string.Empty;
                cmd += "SELECT Plaza.* ";
                cmd += "     , TSB.TSBNameEN, TSB.TSBNameTH ";
                cmd += "     , PlazaGroup.PlazaGroupNameEN, PlazaGroup.PlazaGroupNameTH, PlazaGroup.Direction ";
                cmd += "  FROM Plaza, PlazaGroup, TSB ";
                cmd += " WHERE Plaza.TSBId = TSB.TSBId ";
                cmd += "   AND PlazaGroup.TSBId = TSB.TSBId ";
                cmd += "   AND Plaza.TSBId = TSB.TSBId ";
                cmd += "   AND Plaza.PlazaGroupId = PlazaGroup.PlazaGroupId ";
                cmd += "   AND Plaza.TSBId = ? ";

                var rets = NQuery.Query<FKs>(cmd, tsbId).ToList();
                var results = new List<Plaza>();
                if (null != rets)
                {
                    rets.ForEach(ret =>
                    {
                        results.Add(ret.ToPlaza());
                    });
                }
                return results;
            }
        }

        #endregion
    }

    #endregion
}
