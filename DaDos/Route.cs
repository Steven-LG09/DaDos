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
    public partial class Route : Form
    {
        private Class9 class9;
        public Route(Class9 data)
        {
            InitializeComponent();
            class9 = data;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RouteCh routeCh = new RouteCh();
            routeCh.Show();
            this.Close();
        }
        private void label3_Click(object sender, EventArgs e)
        {
            if(class9 != null)
            {
                routes.Text = class9.Label1;
                work.Text = class9.Label2;
                Refer.Text = class9.Label3;
                button3.Visible = true;
            }
            else
            {
                routes.Text = "Informacion incompleta";
                work.Text = "Informacion incompleta";
                Refer.Text = "Informacion incompleta";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User(class9);
            user.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            User user = new User(class9);
            user.Show();
            this.Close();
        }
    }
}
