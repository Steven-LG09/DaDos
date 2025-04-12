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
    public partial class Form1 : Form
    {
        private Class9 class9;
        public Form1()
        {
            InitializeComponent();

            contraseña.PasswordChar = '*';
        }

        private void ingresar_Click(object sender, EventArgs e)
        {
            if (usuario.Text == "user1234" & contraseña.Text == "1234")
            {
                User user = new User(class9);
                user.Show();
                this.Hide();
            }
            else
            {
                label3.Text = "Datos Incorrectos";
            }
        }
    }
}
