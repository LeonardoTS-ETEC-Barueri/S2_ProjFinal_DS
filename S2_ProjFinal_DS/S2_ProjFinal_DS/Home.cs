using S2_ProjFinal_DS;
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
using System.Globalization;

namespace UI_ProjFinalDS
{
    public partial class Home : Form
    {

        public Home()
        {
            InitializeComponent();

            // Configurações da Mensagem de Saudação.
            TimeSpan tarde = new TimeSpan(12, 0, 0);
            TimeSpan noite = new TimeSpan(18, 0, 0);
            TimeSpan horarioAtual = DateTime.Now.TimeOfDay;

            if (horarioAtual < tarde) {
                lblSaudacao.Text = "Bom dia!";
            }
            else if (horarioAtual < noite) 
            {
                lblSaudacao.Text = "Boa tarde!";
            }
            else
            {
                lblSaudacao.Text = "Boa noite!";
            }
            
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

        private void btnCompromissoAdd_Click(object sender, EventArgs e)
        {
            // Exibe uma tela "Compromisso" vazia, para que o usuário registre um novo compromisso.
            this.Hide();

            Compromisso telaNewCompromisso = new Compromisso();

            telaNewCompromisso.Text = "Novo compromisso";   // Altera o título da tela para "Novo compromisso" 
            // Esse título não deve ser modificado, por meio dele, o evento "Click" na área de contatos/convidados ocorre,
            // exibindo a informação sobre a impossibilidade de manipular convidados no momento.

            telaNewCompromisso.dataGridViewContatosCompromisso.DataSource = null; // Desabilita a exibição dos contatos.

            telaNewCompromisso.btnSalvarNewCompromisso.Visible = true;    // Ativa o botão de salvar para a base de dados.
            telaNewCompromisso.btnSalvarNewCompromisso.Enabled = true;

            telaNewCompromisso.ShowDialog();
            atualizarCompromisso();
            this.Show();
            
        }

        private void btnContatoAdd_Click(object sender, EventArgs e)
        {
            // Exibe uma tela "Contato" vazia, para que o usuário registre um novo contato.
            this.Hide();
            Contato telaNewContato = new Contato();
            telaNewContato.Text = "Novo contato";
            telaNewContato.ShowDialog();
            atualizarContato();
            this.Show();

        }

        // Variáveis para verificação do estado de seleção das linhas do DataViewGrid.
        private bool isCompromissoSelected;
        private bool isContatoSelected;

        // Toggle botões COMPROMISSOS.
        private void dataGridViewCompromissos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // No DataGridView Compromissos, seleciona/Deixa de selecionar a linha ao clicar em qualquer célula da linha.
            
            if (isCompromissoSelected)
            {
                dataGridViewCompromissos.ClearSelection();
                this.btnCompromissoRmv.Enabled = false;
                this.btnCompromissoDetalhes.Enabled = false;


                isCompromissoSelected = false;
            } else
            {
                //dataGridViewCompromissos.CurrentRow.Selected = true;
                this.btnCompromissoRmv.Enabled = true;
                this.btnCompromissoDetalhes.Enabled = true;

                isCompromissoSelected = true;
                
            }
            
            
        }
        private void dataGridViewCompromissos_SelectionChanged(object sender, EventArgs e)
        {
            isCompromissoSelected = false;
        }

        // Toggle botões CONTATOS.
        private void dataGridViewContatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // No DataGridView Contatos, seleciona/Deixa de selecionar a linha ao clicar em qualquer célula da linha.

            if (isContatoSelected)
            {
                dataGridViewContatos.ClearSelection();
                this.btnContatoRmv.Enabled = false;

                isContatoSelected = false;
            }
            else
            {
                //dataGridViewContatos.CurrentRow.Selected = true;
                this.btnContatoRmv.Enabled = true;

                isContatoSelected = true;
            }
        }

        private void dataGridViewContatos_SelectionChanged(object sender, EventArgs e)
        {
            isContatoSelected = false;
        }

        private void atualizarCompromisso()
        {
            this.tbl_compromissoTableAdapter.Fill(this.db_listacontatos_ds_fims2DataSet.tbl_compromisso); // Atualiza a dataGridView preenchendo-a com os dados da tbl_compromisso que estão configuradas como dataTable pro método Fill.

            if (dataGridViewCompromissos.SelectedRows.Count > 0) // Garante que os botões não vão ficar ativos depois de uma atualização.
            {
                this.dataGridViewCompromissos.ClearSelection();
                this.btnCompromissoRmv.Enabled = false;
                this.btnCompromissoDetalhes.Enabled = false;

                if (isCompromissoSelected)  // Garante que os Toggles da seleção de linha no dataGridView não entrem em conflito no primeiro clique caso a linha estivesse selecionada quando ocorrer a atualização.
                {
                    isCompromissoSelected = false;
                }

            }
        }

        private void atualizarContato()
        {
            this.tbl_contatoTableAdapter.Fill(this.db_listacontatos_ds_fims2DataSet1.tbl_contato); // Atualiza a dataGridView preenchendo-a com os dados da tbl_compromisso que estão configuradas como dataTable pro método Fill.

            if (dataGridViewContatos.SelectedRows.Count > 0) // Garante que os botões não vão ficar ativos depois de uma atualização.
            {
                this.dataGridViewContatos.ClearSelection();
                this.btnContatoRmv.Enabled = false;

                if (isCompromissoSelected)  // Garante que os Toggles da seleção de linha no dataGridView não entrem em conflito no primeiro clique caso a linha estivesse selecionada quando ocorrer a atualização.
                {
                    isCompromissoSelected = false;
                }

            }
        }

        private void btnCompromissoRmv_Click(object sender, EventArgs e)
        {
            // Remove o registro selecionado
            DataGridViewRow mySelectedRow = dataGridViewCompromissos.CurrentRow;

            if (mySelectedRow.Selected) // Se a linha estiver selecionada...
            {
                // Avise o usuário sobre a operação, permita-o escolher continuar ou não. Se continuar, delete o compromisso.
                DialogResult myAlert = MessageBox.Show("A exclusão é permanente, o compromisso será completamente removido.\nTem certeza que deseja continuar?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (myAlert == DialogResult.Yes) { 
                    
                    
                    DTO_Compromisso obj_dtoCompromisso = new DTO_Compromisso();
                    BLL_Compromisso obj_bllCompromisso = new BLL_Compromisso();

                    // Index da linha selecionada para realizar a exclusão "Cells[0]" deve ser o cod_compromisso no dataGridViewCompromissos.
                    obj_dtoCompromisso.codCompromisso = int.Parse(mySelectedRow.Cells[0].Value.ToString());

                    string retornoBLL = obj_bllCompromisso.validarRmvCompromisso(obj_dtoCompromisso);

                    MessageBox.Show(retornoBLL, "CONCLUSÃO", MessageBoxButtons.OK);
                    atualizarCompromisso();

                }
                //else
                //{
                    //MessageBox.Show("Sábia decisão...");
                //}

                //dataGridViewCompromissos.Rows.Remove(mySelectedRow);    // Ao clicar, remove a linha selecionada.

            }

        }

        private void btnCompromissoDetalhes_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Instânciamento das classes utilizadas.

            Compromisso telaDetCompromisso = new Compromisso();
            DTO_Compromisso obj_dtoCompromisso = new DTO_Compromisso();
            BLL_Compromisso obj_bllCompromisso = new BLL_Compromisso();
            DataGridViewRow mySelectedRow = dataGridViewCompromissos.CurrentRow;

            // Guarda os dados selecionados no DTO.

            CultureInfo myCulture = new CultureInfo(CultureInfo.CurrentCulture.Name.ToString());
            DateTime dataCompromisso = DateTime.Parse(mySelectedRow.Cells[2].Value.ToString(), myCulture); // Cells[2] = dataCompromisso (dd/mm/yyyy) - validation needed.
            //MessageBox.Show(dataCompromisso.ToString("yyyy-MM-dd"));

            obj_dtoCompromisso.codCompromisso = int.Parse(mySelectedRow.Cells[0].Value.ToString()); // Cells[0] = codCompromisso.
            obj_dtoCompromisso.assunto = mySelectedRow.Cells[1].Value.ToString(); // Cells[1] = assunto.
            obj_dtoCompromisso.dataCompromisso =  dataCompromisso.ToString("yyyy-MM-dd"); // Data validada.
            obj_dtoCompromisso.horario = mySelectedRow.Cells[3].Value.ToString(); // Cells[3] = horario (hh:mm:ss).
            obj_dtoCompromisso.descricao = mySelectedRow.Cells[4].Value.ToString(); // Cells[4] = descricao.
            obj_dtoCompromisso.estaAtivo = bool.Parse(mySelectedRow.Cells[5].Value.ToString()); // Cells[5] = estaAtivo default 1 (true).

            // Define a exibição dos dados na UI Compromisso.

            telaDetCompromisso.Text = "Assunto do Compromisso: " + obj_dtoCompromisso.assunto;
            telaDetCompromisso.txbAssuntoCompromisso.Text = obj_dtoCompromisso.assunto;
            telaDetCompromisso.txbDescricaoCompromisso.Text = obj_dtoCompromisso.descricao;
            telaDetCompromisso.monthCalendarCompromisso.SetDate(dataCompromisso);
            telaDetCompromisso.mtxbHorarioCompromisso.Text = obj_dtoCompromisso.horario;
            telaDetCompromisso.chkBoxAtivo.Checked = obj_dtoCompromisso.estaAtivo;
            telaDetCompromisso.lblHiddenCod.Text = obj_dtoCompromisso.codCompromisso.ToString();

            // Verifica se existem convidados nesse compromisso e atualiza a GridView da tela Compromisso de acordo...
            obj_dtoCompromisso.Convidados = BLL_Compromisso.verificarListaCompromisso(obj_dtoCompromisso);    // Deve retornar uma lista de convidados.

            List<DTO_Convidado> myConvidados = obj_dtoCompromisso.Convidados;   // Atribui a lista de convidados do nosso obj_dtoCompromisso a uma variável.
            
            telaDetCompromisso.dataGridViewConvidadosCompromisso.DataSource = myConvidados; // Passa a lista para a DataTable da dataGridView.

            telaDetCompromisso.dataGridViewConvidadosCompromisso.Columns["codCompromisso"].Visible = false; // Oculta um campo indesejado.


            // Desabilita inicialmente a edição dos detalhes.

            //telaDetCompromisso.btnConvidarContato.Enabled = false;
            //telaDetCompromisso.btnRmvConvidado.Enabled = false;
            telaDetCompromisso.txbAssuntoCompromisso.ReadOnly = true;
            telaDetCompromisso.txbDescricaoCompromisso.ReadOnly = true;
            telaDetCompromisso.monthCalendarCompromisso.Enabled = false;
            telaDetCompromisso.mtxbHorarioCompromisso.ReadOnly = true;
            telaDetCompromisso.chkBoxAtivo.AutoCheck = false;
            telaDetCompromisso.btnEditarCompromisso.Enabled = true;
            telaDetCompromisso.btnEditarCompromisso.Visible = true;

            // Exibe a tela com os detalhes.

            telaDetCompromisso.ShowDialog();
            atualizarCompromisso();
            this.Show();

        }

        private void btnContatoRmv_Click(object sender, EventArgs e)
        {

            DataGridViewRow mySelectedRow = dataGridViewContatos.CurrentRow;

            if (mySelectedRow.Selected) // Se a linha estiver selecionada...
            {
                // Avise o usuário sobre a operação, permita-o escolher continuar ou não. Se continuar, delete o compromisso.
                DialogResult myAlert = MessageBox.Show("A exclusão é permanente, o contato será completamente removido.\nTem certeza que deseja continuar?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (myAlert == DialogResult.Yes)
                {

                    DTO_Contato obj_dtoContato = new DTO_Contato();
                    BLL_Contato obj_bllContato = new BLL_Contato();

                    // Index da linha selecionada para realizar a exclusão "Cells[0]" deve ser o cod_compromisso no dataGridViewCompromissos.
                    obj_dtoContato.nomeContato = mySelectedRow.Cells[0].Value.ToString();

                    string retornoBLL = obj_bllContato.validarRmvContato(obj_dtoContato);

                    MessageBox.Show(retornoBLL, "CONCLUSÃO", MessageBoxButtons.OK);
                    atualizarContato();
                }

            }
        }
    }   // Fim da classe Home do Form.
}
