namespace S2_ProjFinal_DS
{
    public partial class Compromisso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.monthCalendarCompromisso = new System.Windows.Forms.MonthCalendar();
            this.lblHorarioCompromisso = new System.Windows.Forms.Label();
            this.lblAssuntoCompromisso = new System.Windows.Forms.Label();
            this.lblDescricaoCompromisso = new System.Windows.Forms.Label();
            this.lblConvidadosCompromisso = new System.Windows.Forms.Label();
            this.lblContatosCompromisso = new System.Windows.Forms.Label();
            this.lblDataCompromisso = new System.Windows.Forms.Label();
            this.dataGridViewContatosCompromisso = new System.Windows.Forms.DataGridView();
            this.nomecontatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblcontatoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_listacontatos_ds_fims2DataSet2 = new S2_ProjFinal_DS.db_listacontatos_ds_fims2DataSet2();
            this.tbl_contatoTableAdapter = new S2_ProjFinal_DS.db_listacontatos_ds_fims2DataSet2TableAdapters.tbl_contatoTableAdapter();
            this.dataGridViewConvidadosCompromisso = new System.Windows.Forms.DataGridView();
            this.tblconvidadocompromissoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_listacontatos_ds_fims2DataSet3 = new S2_ProjFinal_DS.db_listacontatos_ds_fims2DataSet3();
            this.tbl_convidado_compromissoTableAdapter = new S2_ProjFinal_DS.db_listacontatos_ds_fims2DataSet3TableAdapters.tbl_convidado_compromissoTableAdapter();
            this.btnConvidarContato = new System.Windows.Forms.Button();
            this.btnRmvConvidado = new System.Windows.Forms.Button();
            this.btnEditarCompromisso = new System.Windows.Forms.Button();
            this.btnVoltarCompromisso = new System.Windows.Forms.Button();
            this.txbAssuntoCompromisso = new System.Windows.Forms.TextBox();
            this.txbDescricaoCompromisso = new System.Windows.Forms.TextBox();
            this.chkBoxAtivo = new System.Windows.Forms.CheckBox();
            this.btnSalvarEdicao = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.mtxbHorarioCompromisso = new System.Windows.Forms.MaskedTextBox();
            this.btnCancelarEdicao = new System.Windows.Forms.Button();
            this.lblHiddenCodCompromisso = new System.Windows.Forms.Label();
            this.lblHiddenCod = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContatosCompromisso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcontatoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_listacontatos_ds_fims2DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConvidadosCompromisso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblconvidadocompromissoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_listacontatos_ds_fims2DataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendarCompromisso
            // 
            this.monthCalendarCompromisso.BackColor = System.Drawing.SystemColors.Control;
            this.monthCalendarCompromisso.Location = new System.Drawing.Point(395, 42);
            this.monthCalendarCompromisso.MaxSelectionCount = 1;
            this.monthCalendarCompromisso.Name = "monthCalendarCompromisso";
            this.monthCalendarCompromisso.ShowToday = false;
            this.monthCalendarCompromisso.ShowTodayCircle = false;
            this.monthCalendarCompromisso.TabIndex = 6;
            // 
            // lblHorarioCompromisso
            // 
            this.lblHorarioCompromisso.AutoSize = true;
            this.lblHorarioCompromisso.Font = new System.Drawing.Font("Liberation Sans", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblHorarioCompromisso.Location = new System.Drawing.Point(475, 212);
            this.lblHorarioCompromisso.Name = "lblHorarioCompromisso";
            this.lblHorarioCompromisso.Size = new System.Drawing.Size(67, 15);
            this.lblHorarioCompromisso.TabIndex = 7;
            this.lblHorarioCompromisso.Text = "HORÁRIO";
            // 
            // lblAssuntoCompromisso
            // 
            this.lblAssuntoCompromisso.AutoSize = true;
            this.lblAssuntoCompromisso.Font = new System.Drawing.Font("Liberation Sans", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblAssuntoCompromisso.Location = new System.Drawing.Point(18, 18);
            this.lblAssuntoCompromisso.Name = "lblAssuntoCompromisso";
            this.lblAssuntoCompromisso.Size = new System.Drawing.Size(70, 15);
            this.lblAssuntoCompromisso.TabIndex = 1;
            this.lblAssuntoCompromisso.Text = "ASSUNTO";
            // 
            // lblDescricaoCompromisso
            // 
            this.lblDescricaoCompromisso.AutoSize = true;
            this.lblDescricaoCompromisso.Font = new System.Drawing.Font("Liberation Sans", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDescricaoCompromisso.Location = new System.Drawing.Point(18, 70);
            this.lblDescricaoCompromisso.Name = "lblDescricaoCompromisso";
            this.lblDescricaoCompromisso.Size = new System.Drawing.Size(83, 15);
            this.lblDescricaoCompromisso.TabIndex = 3;
            this.lblDescricaoCompromisso.Text = "DESCRIÇÃO";
            // 
            // lblConvidadosCompromisso
            // 
            this.lblConvidadosCompromisso.AutoSize = true;
            this.lblConvidadosCompromisso.Font = new System.Drawing.Font("Liberation Sans", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblConvidadosCompromisso.Location = new System.Drawing.Point(398, 275);
            this.lblConvidadosCompromisso.Name = "lblConvidadosCompromisso";
            this.lblConvidadosCompromisso.Size = new System.Drawing.Size(94, 15);
            this.lblConvidadosCompromisso.TabIndex = 11;
            this.lblConvidadosCompromisso.Text = "CONVIDADOS";
            // 
            // lblContatosCompromisso
            // 
            this.lblContatosCompromisso.AutoSize = true;
            this.lblContatosCompromisso.Font = new System.Drawing.Font("Liberation Sans", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblContatosCompromisso.Location = new System.Drawing.Point(18, 275);
            this.lblContatosCompromisso.Name = "lblContatosCompromisso";
            this.lblContatosCompromisso.Size = new System.Drawing.Size(77, 15);
            this.lblContatosCompromisso.TabIndex = 9;
            this.lblContatosCompromisso.Text = "CONTATOS";
            // 
            // lblDataCompromisso
            // 
            this.lblDataCompromisso.AutoSize = true;
            this.lblDataCompromisso.Font = new System.Drawing.Font("Liberation Sans", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDataCompromisso.Location = new System.Drawing.Point(433, 18);
            this.lblDataCompromisso.Name = "lblDataCompromisso";
            this.lblDataCompromisso.Size = new System.Drawing.Size(150, 15);
            this.lblDataCompromisso.TabIndex = 5;
            this.lblDataCompromisso.Text = "SELECIONE UMA DATA";
            // 
            // dataGridViewContatosCompromisso
            // 
            this.dataGridViewContatosCompromisso.AllowUserToAddRows = false;
            this.dataGridViewContatosCompromisso.AllowUserToDeleteRows = false;
            this.dataGridViewContatosCompromisso.AutoGenerateColumns = false;
            this.dataGridViewContatosCompromisso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewContatosCompromisso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContatosCompromisso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomecontatoDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.empresaDataGridViewTextBoxColumn,
            this.cargoDataGridViewTextBoxColumn});
            this.dataGridViewContatosCompromisso.DataSource = this.tblcontatoBindingSource;
            this.dataGridViewContatosCompromisso.Location = new System.Drawing.Point(15, 294);
            this.dataGridViewContatosCompromisso.MultiSelect = false;
            this.dataGridViewContatosCompromisso.Name = "dataGridViewContatosCompromisso";
            this.dataGridViewContatosCompromisso.ReadOnly = true;
            this.dataGridViewContatosCompromisso.RowHeadersVisible = false;
            this.dataGridViewContatosCompromisso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewContatosCompromisso.Size = new System.Drawing.Size(348, 98);
            this.dataGridViewContatosCompromisso.TabIndex = 10;
            this.dataGridViewContatosCompromisso.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewContatosCompromisso_CellClick);
            this.dataGridViewContatosCompromisso.SelectionChanged += new System.EventHandler(this.dataGridViewContatosCompromisso_SelectionChanged);
            // 
            // nomecontatoDataGridViewTextBoxColumn
            // 
            this.nomecontatoDataGridViewTextBoxColumn.DataPropertyName = "nome_contato";
            this.nomecontatoDataGridViewTextBoxColumn.HeaderText = "nome_contato";
            this.nomecontatoDataGridViewTextBoxColumn.Name = "nomecontatoDataGridViewTextBoxColumn";
            this.nomecontatoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empresaDataGridViewTextBoxColumn
            // 
            this.empresaDataGridViewTextBoxColumn.DataPropertyName = "empresa";
            this.empresaDataGridViewTextBoxColumn.HeaderText = "empresa";
            this.empresaDataGridViewTextBoxColumn.Name = "empresaDataGridViewTextBoxColumn";
            this.empresaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cargoDataGridViewTextBoxColumn
            // 
            this.cargoDataGridViewTextBoxColumn.DataPropertyName = "cargo";
            this.cargoDataGridViewTextBoxColumn.HeaderText = "cargo";
            this.cargoDataGridViewTextBoxColumn.Name = "cargoDataGridViewTextBoxColumn";
            this.cargoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblcontatoBindingSource
            // 
            this.tblcontatoBindingSource.DataMember = "tbl_contato";
            this.tblcontatoBindingSource.DataSource = this.db_listacontatos_ds_fims2DataSet2;
            // 
            // db_listacontatos_ds_fims2DataSet2
            // 
            this.db_listacontatos_ds_fims2DataSet2.DataSetName = "db_listacontatos_ds_fims2DataSet2";
            this.db_listacontatos_ds_fims2DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_contatoTableAdapter
            // 
            this.tbl_contatoTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewConvidadosCompromisso
            // 
            this.dataGridViewConvidadosCompromisso.AllowUserToAddRows = false;
            this.dataGridViewConvidadosCompromisso.AllowUserToDeleteRows = false;
            this.dataGridViewConvidadosCompromisso.AllowUserToOrderColumns = true;
            this.dataGridViewConvidadosCompromisso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewConvidadosCompromisso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConvidadosCompromisso.Location = new System.Drawing.Point(395, 294);
            this.dataGridViewConvidadosCompromisso.MultiSelect = false;
            this.dataGridViewConvidadosCompromisso.Name = "dataGridViewConvidadosCompromisso";
            this.dataGridViewConvidadosCompromisso.ReadOnly = true;
            this.dataGridViewConvidadosCompromisso.RowHeadersVisible = false;
            this.dataGridViewConvidadosCompromisso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewConvidadosCompromisso.Size = new System.Drawing.Size(227, 98);
            this.dataGridViewConvidadosCompromisso.TabIndex = 12;
            this.dataGridViewConvidadosCompromisso.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewConvidadosCompromisso_CellClick);
            this.dataGridViewConvidadosCompromisso.SelectionChanged += new System.EventHandler(this.dataGridViewConvidadosCompromisso_SelectionChanged);
            // 
            // tblconvidadocompromissoBindingSource
            // 
            this.tblconvidadocompromissoBindingSource.DataMember = "tbl_convidado_compromisso";
            this.tblconvidadocompromissoBindingSource.DataSource = this.db_listacontatos_ds_fims2DataSet3;
            // 
            // db_listacontatos_ds_fims2DataSet3
            // 
            this.db_listacontatos_ds_fims2DataSet3.DataSetName = "db_listacontatos_ds_fims2DataSet3";
            this.db_listacontatos_ds_fims2DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_convidado_compromissoTableAdapter
            // 
            this.tbl_convidado_compromissoTableAdapter.ClearBeforeFill = true;
            // 
            // btnConvidarContato
            // 
            this.btnConvidarContato.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnConvidarContato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConvidarContato.Enabled = false;
            this.btnConvidarContato.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConvidarContato.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnConvidarContato.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnConvidarContato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvidarContato.Font = new System.Drawing.Font("Liberation Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvidarContato.Location = new System.Drawing.Point(15, 398);
            this.btnConvidarContato.Name = "btnConvidarContato";
            this.btnConvidarContato.Size = new System.Drawing.Size(172, 23);
            this.btnConvidarContato.TabIndex = 13;
            this.btnConvidarContato.Text = "Convidar contato";
            this.btnConvidarContato.UseVisualStyleBackColor = false;
            this.btnConvidarContato.Visible = false;
            this.btnConvidarContato.Click += new System.EventHandler(this.btnConvidarContato_Click);
            // 
            // btnRmvConvidado
            // 
            this.btnRmvConvidado.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnRmvConvidado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRmvConvidado.Enabled = false;
            this.btnRmvConvidado.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRmvConvidado.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnRmvConvidado.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnRmvConvidado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRmvConvidado.Font = new System.Drawing.Font("Liberation Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRmvConvidado.Location = new System.Drawing.Point(450, 398);
            this.btnRmvConvidado.Name = "btnRmvConvidado";
            this.btnRmvConvidado.Size = new System.Drawing.Size(172, 23);
            this.btnRmvConvidado.TabIndex = 14;
            this.btnRmvConvidado.Text = "Remover convidado";
            this.btnRmvConvidado.UseVisualStyleBackColor = false;
            this.btnRmvConvidado.Visible = false;
            this.btnRmvConvidado.Click += new System.EventHandler(this.btnRmvConvidado_Click);
            // 
            // btnEditarCompromisso
            // 
            this.btnEditarCompromisso.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEditarCompromisso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarCompromisso.Enabled = false;
            this.btnEditarCompromisso.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditarCompromisso.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnEditarCompromisso.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEditarCompromisso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarCompromisso.Font = new System.Drawing.Font("Liberation Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarCompromisso.Location = new System.Drawing.Point(450, 458);
            this.btnEditarCompromisso.Name = "btnEditarCompromisso";
            this.btnEditarCompromisso.Size = new System.Drawing.Size(83, 23);
            this.btnEditarCompromisso.TabIndex = 16;
            this.btnEditarCompromisso.Text = "Editar";
            this.btnEditarCompromisso.UseVisualStyleBackColor = false;
            this.btnEditarCompromisso.Visible = false;
            this.btnEditarCompromisso.Click += new System.EventHandler(this.btnEditarCompromisso_Click);
            // 
            // btnVoltarCompromisso
            // 
            this.btnVoltarCompromisso.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnVoltarCompromisso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltarCompromisso.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVoltarCompromisso.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnVoltarCompromisso.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnVoltarCompromisso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltarCompromisso.Font = new System.Drawing.Font("Liberation Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarCompromisso.Location = new System.Drawing.Point(539, 458);
            this.btnVoltarCompromisso.Name = "btnVoltarCompromisso";
            this.btnVoltarCompromisso.Size = new System.Drawing.Size(83, 23);
            this.btnVoltarCompromisso.TabIndex = 20;
            this.btnVoltarCompromisso.Text = "Voltar";
            this.btnVoltarCompromisso.UseVisualStyleBackColor = false;
            this.btnVoltarCompromisso.Click += new System.EventHandler(this.btnVoltarCompromisso_Click);
            // 
            // txbAssuntoCompromisso
            // 
            this.txbAssuntoCompromisso.Location = new System.Drawing.Point(15, 42);
            this.txbAssuntoCompromisso.Name = "txbAssuntoCompromisso";
            this.txbAssuntoCompromisso.Size = new System.Drawing.Size(348, 20);
            this.txbAssuntoCompromisso.TabIndex = 2;
            // 
            // txbDescricaoCompromisso
            // 
            this.txbDescricaoCompromisso.Location = new System.Drawing.Point(15, 93);
            this.txbDescricaoCompromisso.Multiline = true;
            this.txbDescricaoCompromisso.Name = "txbDescricaoCompromisso";
            this.txbDescricaoCompromisso.Size = new System.Drawing.Size(348, 162);
            this.txbDescricaoCompromisso.TabIndex = 4;
            // 
            // chkBoxAtivo
            // 
            this.chkBoxAtivo.AutoSize = true;
            this.chkBoxAtivo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkBoxAtivo.Checked = true;
            this.chkBoxAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxAtivo.Location = new System.Drawing.Point(15, 462);
            this.chkBoxAtivo.Name = "chkBoxAtivo";
            this.chkBoxAtivo.Size = new System.Drawing.Size(153, 17);
            this.chkBoxAtivo.TabIndex = 15;
            this.chkBoxAtivo.Text = "O compromisso está ativo?";
            this.chkBoxAtivo.UseVisualStyleBackColor = true;
            // 
            // btnSalvarEdicao
            // 
            this.btnSalvarEdicao.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSalvarEdicao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvarEdicao.Enabled = false;
            this.btnSalvarEdicao.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSalvarEdicao.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnSalvarEdicao.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSalvarEdicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarEdicao.Font = new System.Drawing.Font("Liberation Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarEdicao.Location = new System.Drawing.Point(450, 458);
            this.btnSalvarEdicao.Name = "btnSalvarEdicao";
            this.btnSalvarEdicao.Size = new System.Drawing.Size(83, 23);
            this.btnSalvarEdicao.TabIndex = 17;
            this.btnSalvarEdicao.Text = "Salvar";
            this.btnSalvarEdicao.UseVisualStyleBackColor = false;
            this.btnSalvarEdicao.Visible = false;
            this.btnSalvarEdicao.Click += new System.EventHandler(this.btnSalvarEdicao_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Enabled = false;
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Liberation Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(450, 458);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(83, 23);
            this.btnSalvar.TabIndex = 19;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Visible = false;
            // 
            // mtxbHorarioCompromisso
            // 
            this.mtxbHorarioCompromisso.AllowPromptAsInput = false;
            this.mtxbHorarioCompromisso.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtxbHorarioCompromisso.Location = new System.Drawing.Point(459, 235);
            this.mtxbHorarioCompromisso.Mask = "00:00:00";
            this.mtxbHorarioCompromisso.Name = "mtxbHorarioCompromisso";
            this.mtxbHorarioCompromisso.ResetOnPrompt = false;
            this.mtxbHorarioCompromisso.ResetOnSpace = false;
            this.mtxbHorarioCompromisso.Size = new System.Drawing.Size(100, 20);
            this.mtxbHorarioCompromisso.TabIndex = 8;
            this.mtxbHorarioCompromisso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCancelarEdicao
            // 
            this.btnCancelarEdicao.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCancelarEdicao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarEdicao.Enabled = false;
            this.btnCancelarEdicao.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelarEdicao.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnCancelarEdicao.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCancelarEdicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarEdicao.Font = new System.Drawing.Font("Liberation Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarEdicao.Location = new System.Drawing.Point(539, 458);
            this.btnCancelarEdicao.Name = "btnCancelarEdicao";
            this.btnCancelarEdicao.Size = new System.Drawing.Size(83, 23);
            this.btnCancelarEdicao.TabIndex = 18;
            this.btnCancelarEdicao.Text = "Cancelar";
            this.btnCancelarEdicao.UseVisualStyleBackColor = false;
            this.btnCancelarEdicao.Visible = false;
            this.btnCancelarEdicao.Click += new System.EventHandler(this.btnCancelarEdicao_Click);
            // 
            // lblHiddenCodCompromisso
            // 
            this.lblHiddenCodCompromisso.AutoSize = true;
            this.lblHiddenCodCompromisso.Font = new System.Drawing.Font("Liberation Sans", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblHiddenCodCompromisso.Location = new System.Drawing.Point(18, 444);
            this.lblHiddenCodCompromisso.Name = "lblHiddenCodCompromisso";
            this.lblHiddenCodCompromisso.Size = new System.Drawing.Size(130, 15);
            this.lblHiddenCodCompromisso.TabIndex = 21;
            this.lblHiddenCodCompromisso.Text = "Cod. Compromisso:";
            this.lblHiddenCodCompromisso.Visible = false;
            // 
            // lblHiddenCod
            // 
            this.lblHiddenCod.AutoSize = true;
            this.lblHiddenCod.Font = new System.Drawing.Font("Liberation Sans", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblHiddenCod.Location = new System.Drawing.Point(154, 444);
            this.lblHiddenCod.Name = "lblHiddenCod";
            this.lblHiddenCod.Size = new System.Drawing.Size(14, 15);
            this.lblHiddenCod.TabIndex = 22;
            this.lblHiddenCod.Text = "1";
            this.lblHiddenCod.Visible = false;
            // 
            // Compromisso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 493);
            this.Controls.Add(this.lblHiddenCod);
            this.Controls.Add(this.lblHiddenCodCompromisso);
            this.Controls.Add(this.mtxbHorarioCompromisso);
            this.Controls.Add(this.chkBoxAtivo);
            this.Controls.Add(this.txbDescricaoCompromisso);
            this.Controls.Add(this.txbAssuntoCompromisso);
            this.Controls.Add(this.btnRmvConvidado);
            this.Controls.Add(this.btnConvidarContato);
            this.Controls.Add(this.dataGridViewConvidadosCompromisso);
            this.Controls.Add(this.dataGridViewContatosCompromisso);
            this.Controls.Add(this.lblDataCompromisso);
            this.Controls.Add(this.lblContatosCompromisso);
            this.Controls.Add(this.lblConvidadosCompromisso);
            this.Controls.Add(this.lblDescricaoCompromisso);
            this.Controls.Add(this.lblAssuntoCompromisso);
            this.Controls.Add(this.lblHorarioCompromisso);
            this.Controls.Add(this.monthCalendarCompromisso);
            this.Controls.Add(this.btnVoltarCompromisso);
            this.Controls.Add(this.btnEditarCompromisso);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnSalvarEdicao);
            this.Controls.Add(this.btnCancelarEdicao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Compromisso";
            this.Text = "CompromissoNovoAlterar";
            this.Load += new System.EventHandler(this.CompromissoNovoAlterar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContatosCompromisso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcontatoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_listacontatos_ds_fims2DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConvidadosCompromisso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblconvidadocompromissoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_listacontatos_ds_fims2DataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MonthCalendar monthCalendarCompromisso;
        public System.Windows.Forms.Label lblHorarioCompromisso;
        public System.Windows.Forms.Label lblAssuntoCompromisso;
        public System.Windows.Forms.Label lblDescricaoCompromisso;
        public System.Windows.Forms.Label lblConvidadosCompromisso;
        public System.Windows.Forms.Label lblContatosCompromisso;
        public System.Windows.Forms.Label lblDataCompromisso;
        public System.Windows.Forms.DataGridView dataGridViewContatosCompromisso;
        public db_listacontatos_ds_fims2DataSet2 db_listacontatos_ds_fims2DataSet2;
        public System.Windows.Forms.BindingSource tblcontatoBindingSource;
        public db_listacontatos_ds_fims2DataSet2TableAdapters.tbl_contatoTableAdapter tbl_contatoTableAdapter;
        public System.Windows.Forms.DataGridView dataGridViewConvidadosCompromisso;
        public db_listacontatos_ds_fims2DataSet3 db_listacontatos_ds_fims2DataSet3;
        public System.Windows.Forms.BindingSource tblconvidadocompromissoBindingSource;
        public db_listacontatos_ds_fims2DataSet3TableAdapters.tbl_convidado_compromissoTableAdapter tbl_convidado_compromissoTableAdapter;
        public System.Windows.Forms.Button btnConvidarContato;
        public System.Windows.Forms.Button btnRmvConvidado;
        public System.Windows.Forms.Button btnEditarCompromisso;
        public System.Windows.Forms.Button btnVoltarCompromisso;
        public System.Windows.Forms.TextBox txbAssuntoCompromisso;
        public System.Windows.Forms.TextBox txbDescricaoCompromisso;
        public System.Windows.Forms.CheckBox chkBoxAtivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomecontatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoDataGridViewTextBoxColumn;
        public System.Windows.Forms.Button btnSalvarEdicao;
        public System.Windows.Forms.Button btnSalvar;
        public System.Windows.Forms.MaskedTextBox mtxbHorarioCompromisso;
        public System.Windows.Forms.Button btnCancelarEdicao;
        public System.Windows.Forms.Label lblHiddenCodCompromisso;
        public System.Windows.Forms.Label lblHiddenCod;
    }
}