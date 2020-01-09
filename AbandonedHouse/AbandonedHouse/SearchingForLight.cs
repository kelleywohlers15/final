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
    public partial class SearchingForLight : Form
    {
        public SearchingForLight()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new LocationInHouse().Show();
            this.Visible = false;
        }
    }
}
