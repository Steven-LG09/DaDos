using DaDos.Routes;
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
    public partial class User : Form
    {
        private Class9 class9;
        public User(Class9 data)
        {
            InitializeComponent();
            class9 = data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Route route = new Route(class9);
            route.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (class9 != null)
            {
                Button ruta1 = new Button();
                ruta1.Text = class9.Label3;
                ruta1.Location = new Point(17, 54);
                ruta1.Size = new Size(90, 90);
                ruta1.BackColor = Color.Green;
                ruta1.ForeColor = Color.Transparent;

                ruta1.Click += Ruta1_Click;

                this.Controls.Add(ruta1);
            }
            else
            {
                label2.Text = "No hay Rutas Activas";
            }
        }
        private void Ruta1_Click(object sender, EventArgs e)
        {
            Route1 route = new Route1(class9);
            route.ShowDialog();
            
        }
    }
}
