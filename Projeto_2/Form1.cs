using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_2
{
    public partial class Kcal : Form
    {
        public Kcal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbxAtFisica.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Insira uma opção válida de atividade física!", "Atividade inválida!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                resKcal.Clear();
                cbxAtFisica.Focus();
            }
            else if (txtPeso.Text == "")
            {
                MessageBox.Show("Insira uma opção válida para seu peso", "Peso indefinido!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                resKcal.Clear();
                txtPeso.Focus();
            }
            else if (Convert.ToInt32(txtPeso.Text) < 1 || Convert.ToInt32(txtPeso.Text) > 200)
            {
                MessageBox.Show("Peso deve estar entre 1Kg e 200Kg", "Peso inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPeso.Clear();
                resKcal.Clear();
                txtPeso.Focus();
            }
            /*
            Caminhar
            Musculação
            Futebol
            Tênis
            Dança
            Alongamento
            */
            else
            {
                switch (cbxAtFisica.SelectedItem)
                {
                    case "Caminhar":
                        resKcal.Text = (Convert.ToDecimal(txtPeso.Text) * tempoEx.Value * 1).ToString();
                    break;

                    case "Musculação":
                        resKcal.Text = (Convert.ToDecimal(txtPeso.Text) * tempoEx.Value * 2).ToString(); 
                    break;

                    case "Futebol":
                        resKcal.Text = (Convert.ToDecimal(txtPeso.Text) * tempoEx.Value * 3).ToString();
                    break;

                    case "Tênis":
                        resKcal.Text = (Convert.ToDecimal(txtPeso.Text) * tempoEx.Value * 2).ToString();
                    break;

                    case "Dança":
                        resKcal.Text = (Convert.ToDecimal(txtPeso.Text) * tempoEx.Value * 1).ToString();
                    break;

                    case "Alongamento":
                        resKcal.Text = (Convert.ToDecimal(txtPeso.Text) * tempoEx.Value * 5).ToString();
                    break;

                    default:
                        MessageBox.Show("Escolha uma opção válida!");
                    break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtPeso.Clear();
            resKcal.Clear();
            tempoEx.Value = 1;
            cbxAtFisica.SelectedItem = null;
            cbxAtFisica.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxAtFisica_SelectedIndexChanged(object sender, EventArgs e)
        {
            resKcal.Clear();
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
