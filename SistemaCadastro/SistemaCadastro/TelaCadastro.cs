using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCadastro
{
    public partial class TelaCadastro : Form
    {
        List<Pessoa> pessoas;
        public TelaCadastro()
        {
            InitializeComponent();
            pessoas = new List<Pessoa>();

            comboEstadoCivil.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void botaoOK_Click(object sender, EventArgs e)
        {
            if (nameBox.Text == "")
            {
                MessageBox.Show("Informe o campo nome");
                nameBox.Focus();
                return;
            }
            if (numberBox.Text == "")
            {
                MessageBox.Show("Informe o campo Telefone");
                numberBox.Focus();
                return;
            }
            char sexo;
            if (radioM.Checked)
            {
                sexo = 'M';
            }
            else if (radioF.Checked)
            {
                sexo = 'F';
            }
            else
            {
                sexo = 'O';
            }

            Pessoa p = new Pessoa();
            p.Nome = nameBox.Text;
            p.Telefone = numberBox.Text;
            p.EstadoCivil = comboEstadoCivil.SelectedItem.ToString();
            p.Data = dataBox.Text;
            p.Sexo = sexo;
            p.VeiculosProprio = checkCarroProprio.Checked;
            p.VeiculosProprio = checkCasaPropria.Checked;
            pessoas.Add(p);
            MessageBox.Show("Usuário cadastrado com sucesso!!\n" + p.Nome);
        }//BOTAO OK

        private void botaoCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }//BOTAO CANCEL

        private void botaoClean_Click(object sender, EventArgs e)
        {
            nameBox.Clear();
            numberBox.Clear();
            checkCarroProprio.Checked = false;
            checkCasaPropria.Checked = false;
        }//BOTAO CLEAN

        public void Listar()
        {
            lista.Items.Clear();
            foreach(Pessoa p in pessoas)
            {
                lista.Items.Add(p.Nome);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            removeButton.Visible = true;
            lista.Items.Clear();
            foreach (Pessoa p in pessoas)
            {
                lista.Items.Add(p.Nome);
            }
        }

        private void cleanListButton_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            int index = lista.SelectedIndex;
            pessoas.RemoveAt(index);
            lista.Items.Clear();
        }

        private void expand_Click(object sender, EventArgs e)
        {
            removeButton.Visible = false;
            int index = lista.SelectedIndex;
            lista.Items.Clear();
            lista.Items.Add(pessoas[index].Nome);
            lista.Items.Add(pessoas[index].Telefone);
            lista.Items.Add(pessoas[index].Data);
            lista.Items.Add(pessoas[index].EstadoCivil);
            lista.Items.Add(pessoas[index].Sexo);
        }
    }
}
