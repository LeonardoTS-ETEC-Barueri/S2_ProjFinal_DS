namespace UI_ProjFinalDS
{
    partial class Home
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnContatoAdd = new System.Windows.Forms.Button();
            this.tabctrlContatos = new System.Windows.Forms.TabControl();
            this.tabpgContatos = new System.Windows.Forms.TabPage();
            this.tabctrlCompromissos = new System.Windows.Forms.TabControl();
            this.tabpgCompromissos = new System.Windows.Forms.TabPage();
            this.lblSaudacao = new System.Windows.Forms.Label();
            this.btnContatoRmv = new System.Windows.Forms.Button();
            this.btnContatoDetalhes = new System.Windows.Forms.Button();
            this.btnCompromissoAdd = new System.Windows.Forms.Button();
            this.btnCompromissoRmv = new System.Windows.Forms.Button();
            this.btnCompromissoDetalhes = new System.Windows.Forms.Button();
            this.dataGridViewCompromissos = new System.Windows.Forms.DataGridView();
            this.db_listacontatos_ds_fims2DataSet = new S2_ProjFinal_DS.db_listacontatos_ds_fims2DataSet();
            this.tblcompromissoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_compromissoTableAdapter = new S2_ProjFinal_DS.db_listacontatos_ds_fims2DataSetTableAdapters.tbl_compromissoTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.db_listacontatos_ds_fims2DataSet1 = new S2_ProjFinal_DS.db_listacontatos_ds_fims2DataSet1();
            this.tblcontatoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_contatoTableAdapter = new S2_ProjFinal_DS.db_listacontatos_ds_fims2DataSet1TableAdapters.tbl_contatoTableAdapter();
            this.nomecontatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estaAtivoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datacompromissoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assuntoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codcompromissoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabctrlContatos.SuspendLayout();
            this.tabpgContatos.SuspendLayout();
            this.tabctrlCompromissos.SuspendLayout();
            this.tabpgCompromissos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompromissos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_listacontatos_ds_fims2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcompromissoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_listacontatos_ds_fims2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcontatoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnContatoAdd
            // 
            this.btnContatoAdd.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnContatoAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContatoAdd.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnContatoAdd.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnContatoAdd.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnContatoAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContatoAdd.Font = new System.Drawing.Font("Liberation Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContatoAdd.Location = new System.Drawing.Point(6, 158);
            this.btnContatoAdd.Name = "btnContatoAdd";
            this.btnContatoAdd.Size = new System.Drawing.Size(138, 23);
            this.btnContatoAdd.TabIndex = 0;
            this.btnContatoAdd.Text = "Novo contato";
            this.btnContatoAdd.UseVisualStyleBackColor = false;
            // 
            // tabctrlContatos
            // 
            this.tabctrlContatos.Controls.Add(this.tabpgContatos);
            this.tabctrlContatos.Font = new System.Drawing.Font("Liberation Sans", 9.75F, System.Drawing.FontStyle.Bold);
            this.tabctrlContatos.Location = new System.Drawing.Point(12, 266);
            this.tabctrlContatos.Name = "tabctrlContatos";
            this.tabctrlContatos.SelectedIndex = 0;
            this.tabctrlContatos.Size = new System.Drawing.Size(616, 215);
            this.tabctrlContatos.TabIndex = 1;
            // 
            // tabpgContatos
            // 
            this.tabpgContatos.Controls.Add(this.dataGridView1);
            this.tabpgContatos.Controls.Add(this.btnContatoDetalhes);
            this.tabpgContatos.Controls.Add(this.btnContatoRmv);
            this.tabpgContatos.Controls.Add(this.btnContatoAdd);
            this.tabpgContatos.Location = new System.Drawing.Point(4, 24);
            this.tabpgContatos.Name = "tabpgContatos";
            this.tabpgContatos.Padding = new System.Windows.Forms.Padding(3);
            this.tabpgContatos.Size = new System.Drawing.Size(608, 187);
            this.tabpgContatos.TabIndex = 0;
            this.tabpgContatos.Text = "CONTATOS";
            this.tabpgContatos.UseVisualStyleBackColor = true;
            // 
            // tabctrlCompromissos
            // 
            this.tabctrlCompromissos.Controls.Add(this.tabpgCompromissos);
            this.tabctrlCompromissos.Font = new System.Drawing.Font("Liberation Sans", 9.75F, System.Drawing.FontStyle.Bold);
            this.tabctrlCompromissos.Location = new System.Drawing.Point(12, 45);
            this.tabctrlCompromissos.Name = "tabctrlCompromissos";
            this.tabctrlCompromissos.SelectedIndex = 0;
            this.tabctrlCompromissos.Size = new System.Drawing.Size(616, 215);
            this.tabctrlCompromissos.TabIndex = 2;
            // 
            // tabpgCompromissos
            // 
            this.tabpgCompromissos.Controls.Add(this.dataGridViewCompromissos);
            this.tabpgCompromissos.Controls.Add(this.btnCompromissoDetalhes);
            this.tabpgCompromissos.Controls.Add(this.btnCompromissoRmv);
            this.tabpgCompromissos.Controls.Add(this.btnCompromissoAdd);
            this.tabpgCompromissos.Location = new System.Drawing.Point(4, 24);
            this.tabpgCompromissos.Name = "tabpgCompromissos";
            this.tabpgCompromissos.Padding = new System.Windows.Forms.Padding(3);
            this.tabpgCompromissos.Size = new System.Drawing.Size(608, 187);
            this.tabpgCompromissos.TabIndex = 0;
            this.tabpgCompromissos.Text = "COMPROMISSOS";
            this.tabpgCompromissos.UseVisualStyleBackColor = true;
            // 
            // lblSaudacao
            // 
            this.lblSaudacao.AutoSize = true;
            this.lblSaudacao.Font = new System.Drawing.Font("Liberation Sans", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblSaudacao.Location = new System.Drawing.Point(280, 9);
            this.lblSaudacao.Name = "lblSaudacao";
            this.lblSaudacao.Size = new System.Drawing.Size(80, 15);
            this.lblSaudacao.TabIndex = 3;
            this.lblSaudacao.Text = "SAUDAÇÃO";
            // 
            // btnContatoRmv
            // 
            this.btnContatoRmv.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnContatoRmv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContatoRmv.Enabled = false;
            this.btnContatoRmv.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnContatoRmv.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnContatoRmv.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnContatoRmv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContatoRmv.Font = new System.Drawing.Font("Liberation Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContatoRmv.Location = new System.Drawing.Point(441, 158);
            this.btnContatoRmv.Name = "btnContatoRmv";
            this.btnContatoRmv.Size = new System.Drawing.Size(83, 23);
            this.btnContatoRmv.TabIndex = 1;
            this.btnContatoRmv.Text = "Remover";
            this.btnContatoRmv.UseVisualStyleBackColor = false;
            // 
            // btnContatoDetalhes
            // 
            this.btnContatoDetalhes.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnContatoDetalhes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContatoDetalhes.Enabled = false;
            this.btnContatoDetalhes.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnContatoDetalhes.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnContatoDetalhes.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnContatoDetalhes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContatoDetalhes.Font = new System.Drawing.Font("Liberation Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContatoDetalhes.Location = new System.Drawing.Point(530, 158);
            this.btnContatoDetalhes.Name = "btnContatoDetalhes";
            this.btnContatoDetalhes.Size = new System.Drawing.Size(72, 23);
            this.btnContatoDetalhes.TabIndex = 2;
            this.btnContatoDetalhes.Text = "Detalhes";
            this.btnContatoDetalhes.UseVisualStyleBackColor = false;
            // 
            // btnCompromissoAdd
            // 
            this.btnCompromissoAdd.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCompromissoAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompromissoAdd.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCompromissoAdd.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnCompromissoAdd.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCompromissoAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompromissoAdd.Font = new System.Drawing.Font("Liberation Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompromissoAdd.Location = new System.Drawing.Point(6, 158);
            this.btnCompromissoAdd.Name = "btnCompromissoAdd";
            this.btnCompromissoAdd.Size = new System.Drawing.Size(138, 23);
            this.btnCompromissoAdd.TabIndex = 1;
            this.btnCompromissoAdd.Text = "Novo compromisso";
            this.btnCompromissoAdd.UseVisualStyleBackColor = false;
            // 
            // btnCompromissoRmv
            // 
            this.btnCompromissoRmv.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCompromissoRmv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompromissoRmv.Enabled = false;
            this.btnCompromissoRmv.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCompromissoRmv.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnCompromissoRmv.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCompromissoRmv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompromissoRmv.Font = new System.Drawing.Font("Liberation Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompromissoRmv.Location = new System.Drawing.Point(441, 158);
            this.btnCompromissoRmv.Name = "btnCompromissoRmv";
            this.btnCompromissoRmv.Size = new System.Drawing.Size(83, 23);
            this.btnCompromissoRmv.TabIndex = 2;
            this.btnCompromissoRmv.Text = "Remover";
            this.btnCompromissoRmv.UseVisualStyleBackColor = false;
            // 
            // btnCompromissoDetalhes
            // 
            this.btnCompromissoDetalhes.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCompromissoDetalhes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompromissoDetalhes.Enabled = false;
            this.btnCompromissoDetalhes.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCompromissoDetalhes.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnCompromissoDetalhes.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCompromissoDetalhes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompromissoDetalhes.Font = new System.Drawing.Font("Liberation Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompromissoDetalhes.Location = new System.Drawing.Point(530, 158);
            this.btnCompromissoDetalhes.Name = "btnCompromissoDetalhes";
            this.btnCompromissoDetalhes.Size = new System.Drawing.Size(72, 23);
            this.btnCompromissoDetalhes.TabIndex = 3;
            this.btnCompromissoDetalhes.Text = "Detalhes";
            this.btnCompromissoDetalhes.UseVisualStyleBackColor = false;
            // 
            // dataGridViewCompromissos
            // 
            this.dataGridViewCompromissos.AllowUserToAddRows = false;
            this.dataGridViewCompromissos.AllowUserToDeleteRows = false;
            this.dataGridViewCompromissos.AllowUserToOrderColumns = true;
            this.dataGridViewCompromissos.AutoGenerateColumns = false;
            this.dataGridViewCompromissos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCompromissos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCompromissos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codcompromissoDataGridViewTextBoxColumn,
            this.assuntoDataGridViewTextBoxColumn,
            this.datacompromissoDataGridViewTextBoxColumn,
            this.horarioDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.estaAtivoDataGridViewCheckBoxColumn});
            this.dataGridViewCompromissos.DataSource = this.tblcompromissoBindingSource;
            this.dataGridViewCompromissos.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewCompromissos.Name = "dataGridViewCompromissos";
            this.dataGridViewCompromissos.ReadOnly = true;
            this.dataGridViewCompromissos.RowHeadersVisible = false;
            this.dataGridViewCompromissos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCompromissos.Size = new System.Drawing.Size(596, 150);
            this.dataGridViewCompromissos.TabIndex = 4;
            // 
            // db_listacontatos_ds_fims2DataSet
            // 
            this.db_listacontatos_ds_fims2DataSet.DataSetName = "db_listacontatos_ds_fims2DataSet";
            this.db_listacontatos_ds_fims2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblcompromissoBindingSource
            // 
            this.tblcompromissoBindingSource.DataMember = "tbl_compromisso";
            this.tblcompromissoBindingSource.DataSource = this.db_listacontatos_ds_fims2DataSet;
            // 
            // tbl_compromissoTableAdapter
            // 
            this.tbl_compromissoTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomecontatoDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.empresaDataGridViewTextBoxColumn,
            this.cargoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblcontatoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(596, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // db_listacontatos_ds_fims2DataSet1
            // 
            this.db_listacontatos_ds_fims2DataSet1.DataSetName = "db_listacontatos_ds_fims2DataSet1";
            this.db_listacontatos_ds_fims2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblcontatoBindingSource
            // 
            this.tblcontatoBindingSource.DataMember = "tbl_contato";
            this.tblcontatoBindingSource.DataSource = this.db_listacontatos_ds_fims2DataSet1;
            // 
            // tbl_contatoTableAdapter
            // 
            this.tbl_contatoTableAdapter.ClearBeforeFill = true;
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
            // estaAtivoDataGridViewCheckBoxColumn
            // 
            this.estaAtivoDataGridViewCheckBoxColumn.DataPropertyName = "estaAtivo";
            this.estaAtivoDataGridViewCheckBoxColumn.HeaderText = "estaAtivo";
            this.estaAtivoDataGridViewCheckBoxColumn.Name = "estaAtivoDataGridViewCheckBoxColumn";
            this.estaAtivoDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horarioDataGridViewTextBoxColumn
            // 
            this.horarioDataGridViewTextBoxColumn.DataPropertyName = "horario";
            this.horarioDataGridViewTextBoxColumn.HeaderText = "horario";
            this.horarioDataGridViewTextBoxColumn.Name = "horarioDataGridViewTextBoxColumn";
            this.horarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datacompromissoDataGridViewTextBoxColumn
            // 
            this.datacompromissoDataGridViewTextBoxColumn.DataPropertyName = "data_compromisso";
            this.datacompromissoDataGridViewTextBoxColumn.HeaderText = "data_compromisso";
            this.datacompromissoDataGridViewTextBoxColumn.Name = "datacompromissoDataGridViewTextBoxColumn";
            this.datacompromissoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // assuntoDataGridViewTextBoxColumn
            // 
            this.assuntoDataGridViewTextBoxColumn.DataPropertyName = "assunto";
            this.assuntoDataGridViewTextBoxColumn.HeaderText = "assunto";
            this.assuntoDataGridViewTextBoxColumn.Name = "assuntoDataGridViewTextBoxColumn";
            this.assuntoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codcompromissoDataGridViewTextBoxColumn
            // 
            this.codcompromissoDataGridViewTextBoxColumn.DataPropertyName = "cod_compromisso";
            this.codcompromissoDataGridViewTextBoxColumn.HeaderText = "cod_compromisso";
            this.codcompromissoDataGridViewTextBoxColumn.Name = "codcompromissoDataGridViewTextBoxColumn";
            this.codcompromissoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 493);
            this.Controls.Add(this.lblSaudacao);
            this.Controls.Add(this.tabctrlCompromissos);
            this.Controls.Add(this.tabctrlContatos);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.tabctrlContatos.ResumeLayout(false);
            this.tabpgContatos.ResumeLayout(false);
            this.tabctrlCompromissos.ResumeLayout(false);
            this.tabpgCompromissos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompromissos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_listacontatos_ds_fims2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcompromissoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_listacontatos_ds_fims2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcontatoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnContatoAdd;
        private System.Windows.Forms.TabControl tabctrlContatos;
        private System.Windows.Forms.TabPage tabpgContatos;
        private System.Windows.Forms.TabControl tabctrlCompromissos;
        private System.Windows.Forms.TabPage tabpgCompromissos;
        private System.Windows.Forms.Label lblSaudacao;
        private System.Windows.Forms.Button btnContatoDetalhes;
        private System.Windows.Forms.Button btnContatoRmv;
        private System.Windows.Forms.Button btnCompromissoDetalhes;
        private System.Windows.Forms.Button btnCompromissoRmv;
        private System.Windows.Forms.Button btnCompromissoAdd;
        private System.Windows.Forms.DataGridView dataGridViewCompromissos;
        private S2_ProjFinal_DS.db_listacontatos_ds_fims2DataSet db_listacontatos_ds_fims2DataSet;
        private System.Windows.Forms.BindingSource tblcompromissoBindingSource;
        private S2_ProjFinal_DS.db_listacontatos_ds_fims2DataSetTableAdapters.tbl_compromissoTableAdapter tbl_compromissoTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private S2_ProjFinal_DS.db_listacontatos_ds_fims2DataSet1 db_listacontatos_ds_fims2DataSet1;
        private System.Windows.Forms.BindingSource tblcontatoBindingSource;
        private S2_ProjFinal_DS.db_listacontatos_ds_fims2DataSet1TableAdapters.tbl_contatoTableAdapter tbl_contatoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomecontatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codcompromissoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assuntoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datacompromissoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estaAtivoDataGridViewCheckBoxColumn;
    }
}

