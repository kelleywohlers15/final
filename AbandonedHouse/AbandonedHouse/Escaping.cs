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
    public partial class Escaping : Form
    {
        public Escaping()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Hiding().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
