using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

using System.Configuration;
using PHMS;
using PHMS.UserControls;

namespace PHMS
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        //method to set the position of the main panel that holds the controls to center of the form.

        private void frmMain_Load(object sender, EventArgs e)
        {
            tabMain.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(new UcMainManu());
            pnlGhraph.Controls.Add(new UcCharts());
        }
    }
}
