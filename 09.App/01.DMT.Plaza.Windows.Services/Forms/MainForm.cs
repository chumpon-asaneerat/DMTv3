﻿#region Using

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#endregion

namespace DMT.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //private Services.LocalDatabaseWebServer server = null;

        private void MainForm_Load(object sender, EventArgs e)
        {
            /*
            if (null == server)
            {
                server = new Services.LocalDatabaseWebServer();
                server.Start();
            }
            */
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*
            if (null != server)
            {
                server.Shutdown();
            }
            server = null;
            */
        }
    }
}
