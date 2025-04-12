using DaDos.Parts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DaDos.Routes
{
    public partial class Route1 : Form
    {
        private Class9 class9;
        public Route1(Class9 data)
        {
            InitializeComponent();
            class9 = data;
            Rte.Text = class9.Label1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InfoO infoO = new InfoO(class9);
            infoO.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InfoR infoR = new InfoR(class9);
            infoR.ShowDialog();
        }
    }
}
