using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DaDos
{
    public partial class RouteCh : Form
    {
        private Class9 class9;
        public RouteCh()
        {
            InitializeComponent();
            class9 = new Class9();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selected.Text = Routes.Text;
            class9.Label1 = selected.Text;
        }

        private void continuar_Click(object sender, EventArgs e)
        {
            Route route = new Route(class9);
            route.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            worker.Text = WorkerList.Text;
            class9.Label2 = worker.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            refer.Text = RefList.Text;
            class9.Label3 =refer.Text;
            continuar.Visible = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Route route1 = new Route(class9);
            route1.Show();
            this.Close();
        }
    }
}
