using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_ProjFinalDS;
using DTOL_ProjFinalDS;

namespace S2_ProjFinal_DS
{
    public partial class Contato : Form
    {
        public Contato()
        {
            InitializeComponent();
        }

        private void btnVoltarContato_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdicionarContato_Click(object sender, EventArgs e)
        {
            DTO_Contato newContato = new DTO_Contato();
            BLL_Contato obj_bllContato = new BLL_Contato();

            newContato.nomeContato = this.txbNomeContato.Text;
            newContato.telefone = this.mtxbTelefoneContato.Text.Replace(" ", "");
            newContato.email = this.txbEmailContato.Text;
            newContato.cargo = this.txbCargoContato.Text;
            newContato.empresa = this.txbEmpresaContato.Text;

            //MessageBox.Show(newContato.telefone);
            string retornoBLL = obj_bllContato.validarAddNewContato(newContato);
            MessageBox.Show(retornoBLL);

            this.Close();

        }
    }
}
