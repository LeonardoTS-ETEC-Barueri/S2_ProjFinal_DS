using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_ProjFinalDS;
using DTOL_ProjFinalDS;

namespace S2_ProjFinal_DS
{
    public partial class Compromisso : Form
    {
        // Variáveis para coleta dos detalhes de um item selecionado a partir da Home.cs.
        string lastAssunto;
        string lastDescricao;
        string lastDataCompromisso;
        string lastHorario;
        bool lastAtivo;
        DTO_Compromisso lastConvidados = new DTO_Compromisso(); // Sera o DataSource que contém os dados iniciais do compromisso detalhado.

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

        private void btnVoltarCompromisso_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditarCompromisso_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(teste);

            // Reconfiguração da tela para o modo de edição.
            this.btnEditarCompromisso.Enabled = false;
            this.btnEditarCompromisso.Visible = false;

            this.btnVoltarCompromisso.Enabled = false;
            this.btnVoltarCompromisso.Visible = false;

            this.btnSalvarEdicao.Visible = true;
            this.btnSalvarEdicao.Enabled = true;

            this.btnCancelarEdicao.Visible = true;
            this.btnCancelarEdicao.Enabled = true;

            //this.btnConvidarContato.Visible = true;
            //this.btnRmvConvidado.Visible = true;

            this.txbAssuntoCompromisso.ReadOnly = false;
            this.txbDescricaoCompromisso.ReadOnly = false;
            this.monthCalendarCompromisso.Enabled = true;
            this.mtxbHorarioCompromisso.ReadOnly = false;
            this.chkBoxAtivo.AutoCheck = true;

            // Coleta os dados atuais do item descrito no momento que o botão de edição é clicado.
            // Isso garante que poderemos voltar essas informações caso o usuário cancele a edição.
            lastAssunto = txbAssuntoCompromisso.Text;
            lastDescricao = txbDescricaoCompromisso.Text;
            lastHorario = mtxbHorarioCompromisso.Text;
            lastAtivo = chkBoxAtivo.Checked;

            lastDataCompromisso = monthCalendarCompromisso.SelectionRange.Start.ToString();
            System.Globalization.CultureInfo myCulture = new System.Globalization.CultureInfo(System.Globalization.CultureInfo.CurrentCulture.Name.ToString());
            DateTime myLastDataCompromisso = DateTime.Parse(lastDataCompromisso, myCulture);

            DTO_Compromisso myCompromisso = new DTO_Compromisso();
            myCompromisso.codCompromisso = int.Parse(lblHiddenCod.Text);
            lastConvidados.Convidados = BLL_Compromisso.verificarListaCompromisso(myCompromisso);

            //MessageBox.Show("Atenção: A lista de contatos é salva automaticamente, diferentemente dos outros campos, ela não voltará atrás ao cancelar a edição.", "ATENÇÃO", MessageBoxButtons.OK ,MessageBoxIcon.Warning);

            //MessageBox.Show("Assunto: " + lastAssunto + "\nDescricao: " + lastDescricao + "\nHorario: " + lastHorario + "\nData: " + myLastDataCompromisso.ToString() + "\nConvidados: " + lastConvidados.GetType());

        }

        private void btnCancelarEdicao_Click(object sender, EventArgs e)
        {
            // Cancela a edição retornando para o modo de exibição.
            this.btnEditarCompromisso.Enabled = true;
            this.btnEditarCompromisso.Visible = true;

            this.btnVoltarCompromisso.Enabled = true;
            this.btnVoltarCompromisso.Visible = true;

            this.btnSalvarEdicao.Visible = false;
            this.btnSalvarEdicao.Enabled = false;

            this.btnCancelarEdicao.Visible = false;
            this.btnCancelarEdicao.Enabled = false;

            //this.btnConvidarContato.Visible = false;
            //this.btnRmvConvidado.Visible = false;

            this.txbAssuntoCompromisso.ReadOnly = true;
            this.txbDescricaoCompromisso.ReadOnly = true;
            this.monthCalendarCompromisso.Enabled = false;
            this.mtxbHorarioCompromisso.ReadOnly = true;
            this.chkBoxAtivo.AutoCheck = false;

            // Retorna os dados exibidos inicialmente.
            txbAssuntoCompromisso.Text = lastAssunto;
            txbDescricaoCompromisso.Text = lastDescricao;
            mtxbHorarioCompromisso.Text = lastHorario;
            chkBoxAtivo.Checked = lastAtivo;

            System.Globalization.CultureInfo myCulture = new System.Globalization.CultureInfo(System.Globalization.CultureInfo.CurrentCulture.Name.ToString());
            DateTime myLastDataCompromisso = DateTime.Parse(lastDataCompromisso, myCulture);
            monthCalendarCompromisso.SetDate(myLastDataCompromisso);

            
            //List<DTO_Convidado> myLastConvidados = lastConvidados.Convidados;
            //dataGridViewConvidadosCompromisso.DataSource = null;
            //dataGridViewConvidadosCompromisso.DataSource = myLastConvidados;
            //this.dataGridViewConvidadosCompromisso.Columns["codCompromisso"].Visible = false;
            
        }

        // Variáveis para verificação do estado de seleção das linhas do DataViewGrid.
        private bool isContatoSelected;
        private bool isConvidadoSelected;

        // Toggle dos Botões de CONTATOS do COMPROMISSO.
        private void dataGridViewContatosCompromisso_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (isContatoSelected)
            {
                this.dataGridViewContatosCompromisso.ClearSelection();
                this.btnConvidarContato.Enabled = false;

                isContatoSelected = false;
            }
            else
            {
                this.btnConvidarContato.Enabled = true;

                isContatoSelected = true;

            }
        }

        private void dataGridViewContatosCompromisso_SelectionChanged(object sender, EventArgs e)
        {
            isContatoSelected = false;
        }

        // Toggle dos Botões de CONVIDADOS do COMPROMISSO.
        private void dataGridViewConvidadosCompromisso_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (isConvidadoSelected)
            {
                this.dataGridViewConvidadosCompromisso.ClearSelection();
                this.btnRmvConvidado.Enabled = false;

                isConvidadoSelected = false;
            }
            else
            {
                this.btnRmvConvidado.Enabled = true;

                isConvidadoSelected = true;

            }
        }

        private void dataGridViewConvidadosCompromisso_SelectionChanged(object sender, EventArgs e)
        {
            isConvidadoSelected = false;
        }

        // Ao clicar em "btnSalvarEdicao" o usuário realizará a alteração dos dados do compromisso atual de acordo com as alterações realizadas na tela.
        private void btnSalvarEdicao_Click(object sender, EventArgs e)
        {
            // Avisa o usuário sobre a operação, permita-o escolher continuar ou não. Se continuar, altere o compromisso.
            DialogResult myAlert = MessageBox.Show("O compromisso será alterado.\nTem certeza que deseja continuar?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (myAlert == DialogResult.Yes)
            {
                DTO_Compromisso obj_dtoCompromisso = new DTO_Compromisso();
                BLL_Compromisso obj_bllCompromisso = new BLL_Compromisso();

                // Armazena os dados atuais no objeto, isso é necessário para realizar a atualização.
                obj_dtoCompromisso.codCompromisso = int.Parse(lblHiddenCod.Text);
                obj_dtoCompromisso.assunto = txbAssuntoCompromisso.Text;
                obj_dtoCompromisso.descricao = txbDescricaoCompromisso.Text;

                string selectedDataCompromisso = monthCalendarCompromisso.SelectionRange.Start.ToString();
                System.Globalization.CultureInfo myCulture = new System.Globalization.CultureInfo(System.Globalization.CultureInfo.CurrentCulture.Name.ToString());
                DateTime dataCompromisso = DateTime.Parse(selectedDataCompromisso, myCulture);

                obj_dtoCompromisso.dataCompromisso = dataCompromisso.ToString("yyyy-MM-dd"); // Data validada.
                obj_dtoCompromisso.horario = mtxbHorarioCompromisso.Text;
                obj_dtoCompromisso.estaAtivo = chkBoxAtivo.Checked;
                obj_dtoCompromisso.Convidados = (List<DTO_Convidado>)this.dataGridViewConvidadosCompromisso.DataSource; // É opcional passar a lista atual de convidados.

                // Inicia as validações dos dados do objeto por meio da BLL_Compromisso e salva os dados na base de dados.
                string retornoBLL = obj_bllCompromisso.validarAltCompromisso(obj_dtoCompromisso);

                MessageBox.Show(retornoBLL);

                // Volta os botões ao estado anterior à edição.
                this.btnEditarCompromisso.Enabled = true;
                this.btnEditarCompromisso.Visible = true;

                this.btnVoltarCompromisso.Enabled = true;
                this.btnVoltarCompromisso.Visible = true;

                this.btnSalvarEdicao.Visible = false;
                this.btnSalvarEdicao.Enabled = false;

                this.btnCancelarEdicao.Visible = false;
                this.btnCancelarEdicao.Enabled = false;

                this.txbAssuntoCompromisso.ReadOnly = true;
                this.txbDescricaoCompromisso.ReadOnly = true;
                this.monthCalendarCompromisso.Enabled = false;
                this.mtxbHorarioCompromisso.ReadOnly = true;
                this.chkBoxAtivo.AutoCheck = false;
            }

        }

        // Configuração da adição de novos convidados.
        private void btnConvidarContato_Click(object sender, EventArgs e)
        {
            DataGridView dgvContatos = this.dataGridViewContatosCompromisso;
            DataGridView dgvConvidados = this.dataGridViewConvidadosCompromisso;
            DTO_Convidado newConvidado = new DTO_Convidado();

            var convidadosDataSource = (List<DTO_Convidado>)dataGridViewConvidadosCompromisso.DataSource;

            newConvidado.codCompromisso = int.Parse(this.lblHiddenCod.Text);
            newConvidado.nomeContato = dgvContatos.SelectedRows[0].Cells[0].Value.ToString();
            newConvidado.estaConfirmado = true;

            bool isConvidado = false;   // Flag de nome já identificado na lista de convidados.

            foreach (DataGridViewRow row in dgvConvidados.Rows) // Verificamos a coluna do nome em cada linha do dataGridView.
            {
                object nome = row.Cells[0].Value;
                if (nome != null && nome.ToString() == newConvidado.nomeContato)
                {
                    MessageBox.Show("Contato já convidado");
                    isConvidado = true;
                    break;
                }
            }

            if (!isConvidado)
            {
                convidadosDataSource.Add(newConvidado);
                string retornoBLL = BLL_Compromisso.validarNewConvidado(newConvidado);  // Adição à lista na Base de Dados.
                MessageBox.Show(retornoBLL);
            }

            //MessageBox.Show("cod: " + lblHiddenCod.Text + "\nnome: " + dgvContatos.SelectedRows[0].Cells[0].Value.ToString() + "\nconfirmado: " + true.ToString());

            dataGridViewConvidadosCompromisso.DataSource = null;
            dataGridViewConvidadosCompromisso.DataSource = convidadosDataSource;
            dataGridViewConvidadosCompromisso.Columns[1].Visible = false;   // Oculta a coluna "cod_compromisso".
            //dataGridViewConvidadosCompromisso.Refresh();

        }

        // Configuração da remoção de convidados.
        private void btnRmvConvidado_Click(object sender, EventArgs e)
        {
            DataGridView dgvConvidados = this.dataGridViewConvidadosCompromisso;
            DTO_Convidado convidadoRemovido = new DTO_Convidado();

            var convidadosDataSource = (List<DTO_Convidado>)dataGridViewConvidadosCompromisso.DataSource;

            convidadoRemovido.nomeContato = dgvConvidados.SelectedRows[0].Cells[0].Value.ToString();
            convidadoRemovido.codCompromisso = int.Parse(dgvConvidados.SelectedRows[0].Cells[1].Value.ToString());  // cod_compromisso: a coluna esta oculta na dataGridView.
            convidadoRemovido.estaConfirmado = bool.Parse(dgvConvidados.SelectedRows[0].Cells[2].Value.ToString());

            //MessageBox.Show(dgvConvidados.SelectedRows[0].Index.ToString());
            //MessageBox.Show(convidadoRemovido.codCompromisso.ToString());

            convidadosDataSource.RemoveAt(int.Parse(dgvConvidados.SelectedRows[0].Index.ToString()));
            //dgvConvidados.Rows.Remove(dgvConvidados.SelectedRows[0]);

            string retornoBLL = BLL_Compromisso.validarRmvConvidado(convidadoRemovido); // Remoção da lista na Base de Dados.
            MessageBox.Show(retornoBLL);

            dgvConvidados.DataSource = null;
            dgvConvidados.DataSource = convidadosDataSource;
            dgvConvidados.Columns[1].Visible = false;

            this.dataGridViewConvidadosCompromisso.ClearSelection();
            this.btnRmvConvidado.Enabled = false;

        }

        private void dataGridViewContatosCompromisso_Click(object sender, EventArgs e)
        {
            if (this.Text == "Novo compromisso")
            {
                MessageBox.Show("Você só poderá adicionar novos convidados depois de criar o compromisso.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridViewConvidadosCompromisso_Click(object sender, EventArgs e)
        {
            if (this.Text == "Novo compromisso")
            {
                MessageBox.Show("Você só poderá manipular os convidados depois de criar o compromisso.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSalvarNewCompromisso_Click(object sender, EventArgs e)
        {
            // Avisa o usuário sobre a operação, permita-o escolher continuar ou não. Se continuar, salve o compromisso.
            DialogResult myAlert = MessageBox.Show("Deseja realmente salvar o compromisso?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (myAlert == DialogResult.Yes)
            {
                DTO_Compromisso obj_dtoCompromisso = new DTO_Compromisso();
                BLL_Compromisso obj_bllCompromisso = new BLL_Compromisso();

                // Armazena os dados atuais no objeto, isso é necessário para realizar a atualização.
                obj_dtoCompromisso.codCompromisso = int.Parse(lblHiddenCod.Text);
                obj_dtoCompromisso.assunto = txbAssuntoCompromisso.Text;
                obj_dtoCompromisso.descricao = txbDescricaoCompromisso.Text;

                string selectedDataCompromisso = monthCalendarCompromisso.SelectionRange.Start.ToString();
                System.Globalization.CultureInfo myCulture = new System.Globalization.CultureInfo(System.Globalization.CultureInfo.CurrentCulture.Name.ToString());
                DateTime dataCompromisso = DateTime.Parse(selectedDataCompromisso, myCulture);

                obj_dtoCompromisso.dataCompromisso = dataCompromisso.ToString("yyyy-MM-dd"); // Data validada.
                obj_dtoCompromisso.horario = mtxbHorarioCompromisso.Text;
                obj_dtoCompromisso.estaAtivo = chkBoxAtivo.Checked;

                // Inicia as validações dos dados do objeto por meio da BLL_Compromisso e salva os dados na base de dados.
                string retornoBLL = obj_bllCompromisso.validarNewCompromisso(obj_dtoCompromisso);

                MessageBox.Show(retornoBLL);

                this.Close();
                
            }
        }
    }
}
