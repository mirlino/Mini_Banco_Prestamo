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
    public partial class Prestamo : Form
    {
        string NombreCliente;
        string[] RazasDisponibles = { "Balrog", "Drúedain", "Enano", "Elfo", "Ent", "Goblin", "Hobbit", "Hombre", "Istari (Mago)", "Orco", "Troll", "Uruk -hai"};
        int[] CuotasDisponibles = {12, 24, 36, 60, 120, 180, 240 };
        string[] LugaresDisponibles;
        Dictionary<int, double> interesesBase;

        public Prestamo(string nombre)
        {
            InitializeComponent();
            NombreCliente = nombre;

            string listadoCiudades = Properties.Resources.lugares.ToString();
            LugaresDisponibles = listadoCiudades.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            interesesBase = new Dictionary<int, double>();
            int i;
            double intereses;
            for(i = 0, intereses = 3.0; i < CuotasDisponibles.Length; i++, intereses += 0.5)
            {
                interesesBase[CuotasDisponibles[i]] = intereses;
            }
        }

        private void Prestamo_Load(object sender, EventArgs e)
        {
            lblWelcome.Text += NombreCliente;
            popularCuotas();
            popularRazas();
            popularCiudades();
        }

        void popularCuotas()
        {
            for (int i = 0; i < CuotasDisponibles.Length; i++)
            {
                cbCuotas.Items.Add(CuotasDisponibles[i]);
            }
        }

        void popularRazas()
        {
            for (int i = 0; i < RazasDisponibles.Length; i++)
            {
                cbRaza.Items.Add(RazasDisponibles[i]);
            }
        }

        void popularCiudades()
        {
            for (int i = 0; i < LugaresDisponibles.Length; i++)
            {
                cbOrigen.Items.Add(LugaresDisponibles[i]);
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        double CalcularInteres()
        {
            int cuotasPerdidas = (int)cbCuotas.SelectedItem;
            string razaSeleccionada = cbRaza.SelectedItem.ToString().ToLower();
            string lugarSeleccionado = cbOrigen.SelectedItem.ToString().ToLower();
            double interes = interesesBase[cuotasPerdidas];
            if (new[] { "orco", "uruk -hai", "goblin", "troll", "balrog" }.Contains(razaSeleccionada))
            {
                interes += 0.3;
            }
            if (new[] { "rivendell", "tirion", "valinor", "hobbiton", "bree", "fondor" }.Contains(lugarSeleccionado))
            {
                interes -= 0.3;
            }

            return interes;
        }

        private void BtnConfirmS_Click(object sender, EventArgs e)
        {
            switch (validaciones())
            {
                case 0:
                    {
                        errorProvider1.SetError(pDatosPersonales, "");
                        errorProvider1.SetError(pDetallesPrestamo, "");
                        double interesMensual = CalcularInteres();
                        double montoPerdido = double.Parse(txtPrestamo.Text);
                        int cuotasPerdidas = (int)cbCuotas.SelectedItem;
                        double interesTotal = montoPerdido * (interesMensual / 100) * cuotasPerdidas;
                        double montoAPagar = montoPerdido + interesTotal;
                        string mensaje = $"Su préstamo por {montoPerdido} en {cuotasPerdidas} cuotas se concederá con un interes del {interesMensual}% mensual \nEl monto final asciende a {montoAPagar}";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show(mensaje, "Cálculo de interes", buttons);
                        break;
                    }
                case 1:
                    {
                        errorProvider1.SetError(pDatosPersonales, "Debe completar todos los datos personales");
                        errorProvider1.SetError(pDetallesPrestamo, "");
                        break;
                    }
                case 2:
                    {
                        errorProvider1.SetError(pDatosPersonales, "");
                        errorProvider1.SetError(pDetallesPrestamo, "Debe ingresar un monto numérico y una cantidad");
                        break;
                    }

            }
        }

        int validaciones()
        {
            if ((cbRaza.SelectedIndex <= -1) || (cbOrigen.SelectedIndex <= -1))
            {
                return 1;
            }
            else
            {
                if (!(txtPrestamo.Text.All(Char.IsDigit)) || (txtPrestamo.Text == "") || (cbCuotas.SelectedIndex <= -1))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
