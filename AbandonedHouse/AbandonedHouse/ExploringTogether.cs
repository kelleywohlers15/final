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
    public partial class ExploringTogether : Form
    {
        public ExploringTogether()
        {
            InitializeComponent();
        }

        private void btn_Stay_Click(object sender, EventArgs e)
        {
            new LocationInHouse().Show();
            this.Visible = false;
        }

        private void btn_Split_Click(object sender, EventArgs e)
        {
            new theEnding().Show();
            this.Visible = false;
        }
    }
}
