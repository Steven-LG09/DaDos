using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DaDos.Parts
{
    public partial class InfoO : Form
    {
        private Class9 class9;
        private string[] images;
        public InfoO(Class9 data)
        {
            InitializeComponent();
            class9 = data;

            images = new string[] { };

            switch (class9.Label2)
            {
                case "Joaquin Medina":
                    Nombre.Text = class9.Label2;
                    Edad.Text = "34 años";
                    Licencia.Text = "C2";
                    Telefono.Text = "3158254678";
                    Cedula.Text = "1034035537";
                    Fecha.Text = "04/02/1990";
                    ECivil.Text = "Casado";
                    Nacionalidad.Text = "Colombiano";
                    Photo.Image = Properties.Resources.Joaquin;
                    break;

                case "Manuel Franco":
                    Nombre.Text = class9.Label2;
                    Edad.Text = "28 años";
                    Licencia.Text = "C2";
                    Telefono.Text = "3026784547";
                    Cedula.Text = "105378956";
                    Fecha.Text = "17/08/1995";
                    ECivil.Text = "Soltero";
                    Nacionalidad.Text = "Colombiano";
                    Photo.Image = Properties.Resources.Manuel;
                    break;

                case "Pedro Valles":
                    Nombre.Text = class9.Label2;
                    Edad.Text = "40 años";
                    Licencia.Text = "C2";
                    Telefono.Text = "3147455643";
                    Cedula.Text = "1078398765";
                    Fecha.Text = "09/12/1983";
                    ECivil.Text = "Casado";
                    Nacionalidad.Text = "Colombiano";
                    Photo.Image = Properties.Resources.Pedro;
                    break;
            }
        }
    }
}
