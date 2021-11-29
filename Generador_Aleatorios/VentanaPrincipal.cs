using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generador_Aleatorios
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
            lb_mensaje_entrada.Text = "Utilize solo números entre 0 y 1, y solo espacios y/o comas para separarlos.";
            lb_mensaje_entrada.Font = new Font("Segoe UI", 8);
            btn_exect.Enabled = false;
            tab_control_entrada.TabPages.Remove(tb_entrada_automatica);
            tab_control_entrada.TabPages.Remove(tb_entrada_transf_inv);
        }

        private void btn_link_Click(object sender, EventArgs e)
        {
            var psi = new ProcessStartInfo
            {
                FileName = "https://pinetools.com/es/generador-numeros-aleatorios",
                UseShellExecute = true
            };

            Process.Start(psi);
        }

        public bool inputcorrecto_manual = false;
        public bool inputcorrecto_metodo = false;

        private void btn_clean_Click(object sender, EventArgs e)
        {
            txt_entrada_manual.Text = "";
            dgv_output.Rows.Clear();
        }

        private void Output(decimal[] aleatorio)
        {
            foreach (decimal aleat in aleatorio)
            {
                int index = dgv_output.Rows.Add();
                dgv_output.Rows[index].Cells[0].Value = index + 1;
                dgv_output.Rows[index].Cells[1].Value = aleat;
            }
        }

        private void rb_entrada_manual_CheckedChanged(object sender, EventArgs e)
        {
            switch (rb_entrada_manual.Checked)
            {
                case true:
                    tab_control_entrada.TabPages.Remove(tb_entrada_automatica);
                    tab_control_entrada.TabPages.Add(tb_entrada_manual);
                    break;
                case false:
                    tab_control_entrada.TabPages.Remove(tb_entrada_manual);
                    tab_control_entrada.TabPages.Add(tb_entrada_automatica);
                    break;
            }
        }

        private void cb_methodlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cb_methodlist.SelectedIndex) {
                case 0:
                    tab_control_entrada.TabPages.Add(tb_entrada_transf_inv);
                    tab_control_entrada.SelectedTab = tb_entrada_transf_inv;
                    break;
                default:
                    break;
            }
        }

        private void txt_entrada_manual_TextChanged(object sender, EventArgs e)
        {
            if (!txt_entrada_manual.Text.Equals(""))
            {
                if (Input.PRHGCheck(txt_entrada_manual.Text))
                {
                    lb_mensaje_entrada.Text = "Conjunto de números aceptado.";
                    lb_mensaje_entrada.Font = new Font("Segoe UI", 8);
                    lb_mensaje_entrada.ForeColor = Color.Green;
                    inputcorrecto_manual = true;
                }
                else {
                    lb_mensaje_entrada.Text = "Utilize solo números entre 0 y 1, y solo espacios y/o comas para separarlos.";
                    lb_mensaje_entrada.Font = new Font("Segoe UI", 8);
                    lb_mensaje_entrada.ForeColor = Color.Red;
                    inputcorrecto_manual = false;
                }
            }
            else {
                lb_mensaje_entrada.Text = "Utilize solo números entre 0 y 1, y solo espacios y/o comas para separarlos.";
                lb_mensaje_entrada.Font = new Font("Segoe UI", 8);
                lb_mensaje_entrada.ForeColor = Color.Black;
                inputcorrecto_manual = false;
            }
            btn_exect.Enabled = (inputcorrecto_manual && inputcorrecto_metodo);
        }

        private void txt_rango_inferior_TextChanged(object sender, EventArgs e)
        {
            inputcorrecto_metodo = !txt_rango_inferior.Text.Equals("") && !txt_rango_superior.Text.Equals("");
            if (!txt_rango_inferior.Text.Equals("") && !txt_rango_superior.Text.Equals("")) {
                inputcorrecto_metodo = Convert.ToInt32(txt_rango_inferior.Text) < Convert.ToInt32(txt_rango_superior.Text);
            }
            btn_exect.Enabled = inputcorrecto_manual && inputcorrecto_metodo;
        }

        private void txt_rango_superior_TextChanged(object sender, EventArgs e)
        {
            inputcorrecto_metodo = !txt_rango_inferior.Text.Equals("") && !txt_rango_superior.Text.Equals("");
            if (!txt_rango_inferior.Text.Equals("") && !txt_rango_superior.Text.Equals(""))
            {
                inputcorrecto_metodo = Convert.ToInt32(txt_rango_inferior.Text) < Convert.ToInt32(txt_rango_superior.Text);
            }
            btn_exect.Enabled = inputcorrecto_manual && inputcorrecto_metodo;
        }

        private void txt_rango_inferior_KeyPress(object sender, KeyPressEventArgs e)
        {
            Input.OnlyNumbers(e);
        }

        private void txt_rango_superior_KeyPress(object sender, KeyPressEventArgs e)
        {
            Input.OnlyNumbers(e);
        }

        private void btn_exect_Click(object sender, EventArgs e)
        {
            Output(GeneradorAleatorios.calcularAleatorioTransfInv(
                Input.ReciveInput(txt_entrada_manual.Text), 
                Convert.ToInt32(txt_rango_inferior.Text), 
                Convert.ToInt32(txt_rango_superior.Text)));
        }
    }
}