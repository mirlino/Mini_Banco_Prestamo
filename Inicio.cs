using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void ControlBotones()
        {
            if (txtNombre.Text.Trim() != string.Empty && txtNombre.Text.All(Char.IsLetter))
            {
                btnAcceder.Enabled = true;
                errorProvider1.SetError(txtNombre, "");
            }
            else
            {
                if (!(txtNombre.Text.All(Char.IsLetter)))
                {
                    errorProvider1.SetError(txtNombre, "El Nombre solo debe contener letras");
                }
                else
                {
                    errorProvider1.SetError(txtNombre, "Debe Introducir su nombre");
                }
                btnAcceder.Enabled = false;
                txtNombre.Focus();
            }
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
            ControlBotones();
        }

        private void BtnAcceder_Click(object sender, EventArgs e)
        {
            using (Prestamo ventanaPrestamos = new Prestamo(txtNombre.Text))
                ventanaPrestamos.ShowDialog();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            btnAcceder.Enabled = false;
        }
    }
}
