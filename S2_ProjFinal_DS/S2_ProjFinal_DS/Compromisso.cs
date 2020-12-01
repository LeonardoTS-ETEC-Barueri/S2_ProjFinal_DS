using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S2_ProjFinal_DS
{
    public partial class Compromisso : Form
    {
        public Compromisso()
        {
            InitializeComponent();
        }

        private void CompromissoNovoAlterar_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'db_listacontatos_ds_fims2DataSet3.tbl_convidado_compromisso'. Você pode movê-la ou removê-la conforme necessário.
            this.tbl_convidado_compromissoTableAdapter.Fill(this.db_listacontatos_ds_fims2DataSet3.tbl_convidado_compromisso);
            // TODO: esta linha de código carrega dados na tabela 'db_listacontatos_ds_fims2DataSet2.tbl_contato'. Você pode movê-la ou removê-la conforme necessário.
            this.tbl_contatoTableAdapter.Fill(this.db_listacontatos_ds_fims2DataSet2.tbl_contato);

            // Essas linhas desabilitam a seleção inicial da primeira linha dos dataGridView da tela Compromisso.
            this.dataGridViewContatosCompromisso.ClearSelection();
            this.dataGridViewConvidadosCompromisso.ClearSelection();

        }
    }
}
