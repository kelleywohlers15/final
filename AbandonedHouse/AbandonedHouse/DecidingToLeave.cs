using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbandonedHouse
{
    public partial class DecidingToLeave : Form
    {
        public DecidingToLeave()
        {
            InitializeComponent();
        }

        private void btn_Talk_Click(object sender, EventArgs e)
        {
            new theEnding().Show();
            this.Visible = false;
        }
    }
}
