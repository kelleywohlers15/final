﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbondonedHouse_SearchingForm4
{
    public partial class FindingLight : Form
    {
        public FindingLight()
        {
            InitializeComponent();
        }

        private void FindingLight_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_Light1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Light2_Click(object sender, EventArgs e)
        {
            new LocationInHouse().Show();
            this.Visible = false;
        }
    }
}