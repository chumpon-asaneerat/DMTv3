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
    #region Config

    /// <summary>
    /// The Config Data Model Class.
    /// </summary>
    [Table("Config")]
    public class Config : NTable<Config>
    {
        #region Intenral Variables

        private string _Key = string.Empty;
        private string _Value = string.Empty;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor.
        /// </summary>
        public Config() : base() { }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets Key
        /// </summary>
        [Category("Common")]
        [Description("Gets or sets Key")]
        [PrimaryKey, MaxLength(30)]
        [PeropertyMapName("Key")]
        public string Key
        {
            get
            {
                return _Key;
            }
            set
            {
                if (_Key != value)
                {
                    _Key = value;
                    this.RaiseChanged("Key");
                }
            }
        }
        /// <summary>
        /// Gets or sets Value
        /// </summary>
        [Category("Common")]
        [Description("Gets or sets Value")]
        [MaxLength(100)]
        [PeropertyMapName("Value")]
        public string Value
        {
            get
            {
                return _Value;
            }
            set
            {
                if (_Value != value)
                {
                    _Value = value;
                    this.RaiseChanged("Value");
                }
            }
        }

        #endregion

        #region Static Methods

        #endregion
    }

    #endregion
}
