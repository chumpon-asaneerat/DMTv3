﻿#region Usings

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

using RestSharp;

using DMT.Models;

#endregion


namespace DMT.Services
{
    partial class PlazaOperations
    {
        #region Internal Variables

        private RevenueOperations _Revenue_Ops = null;

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets Revenue Operations.
        /// </summary>
        public RevenueOperations Revenue
        {
            get
            {
                if (null == _Revenue_Ops)
                {
                    lock (this)
                    {
                        _Revenue_Ops = new RevenueOperations();
                    }
                }
                return _Revenue_Ops;
            }
        }

        #endregion

        #region Revenue class

        /// <summary>
        /// The Revenue Operations class.
        /// Used for Manage Revenue Entry's operation(s).
        /// </summary>
        public class RevenueOperations
        {
            #region Constructor

            /// <summary>
            /// Constructor.
            /// </summary>
            internal RevenueOperations() { }

            #endregion

            #region Public Methods

            public UserShiftRevenue CreateRevenueShift(Search.Revenues.PlazaShift value)
            {
                return NRestClient.Create(port: 9000).Execute<UserShiftRevenue>(
                    RouteConsts.Revenue.CreatePlazaRevenue.Url, value);
            }
            public UserShiftRevenue GetRevenueShift(Search.Revenues.PlazaShift value)
            {
                return NRestClient.Create(port: 9000).Execute<UserShiftRevenue>(
                    RouteConsts.Revenue.GetPlazaRevenue.Url, value);
            }
            public void SaveRevenueShift(Search.Revenues.SaveRevenueShift value)
            {
                NRestClient.Create(port: 9000).Execute(
                    RouteConsts.Revenue.SavePlazaRevenue.Url, value);
            }
            public string SaveRevenue(RevenueEntry value)
            {
                return NRestClient.Create(port: 9000).Execute<string>(
                    RouteConsts.Revenue.SaveRevenue.Url, value);
            }

            #endregion
        }

        #endregion
    }
}
