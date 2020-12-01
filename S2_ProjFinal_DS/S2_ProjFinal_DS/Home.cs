using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_ProjFinalDS
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'db_listacontatos_ds_fims2DataSet1.tbl_contato'. Você pode movê-la ou removê-la conforme necessário.
            this.tbl_contatoTableAdapter.Fill(this.db_listacontatos_ds_fims2DataSet1.tbl_contato);
            // TODO: esta linha de código carrega dados na tabela 'db_listacontatos_ds_fims2DataSet.tbl_compromisso'. Você pode movê-la ou removê-la conforme necessário.
            this.tbl_compromissoTableAdapter.Fill(this.db_listacontatos_ds_fims2DataSet.tbl_compromisso);

            // Essas linhas desabilitam a seleção inicial da primeira linha dos dataGridView da tela Home.
            this.dataGridViewCompromissos.ClearSelection(); 
            this.dataGridViewContatos.ClearSelection();

        }
    }
}
