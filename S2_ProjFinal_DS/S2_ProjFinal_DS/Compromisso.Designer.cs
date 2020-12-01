namespace S2_ProjFinal_DS
{
    partial class Compromisso
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
            this.txbHorarioCompromisso = new System.Windows.Forms.TextBox();
            this.lblAssuntoCompromisso = new System.Windows.Forms.Label();
            this.lblDescricaoCompromisso = new System.Windows.Forms.Label();
            this.lblConvidadosCompromisso = new System.Windows.Forms.Label();
            this.lblContatosCompromisso = new System.Windows.Forms.Label();
            this.lblDataCompromisso = new System.Windows.Forms.Label();
            this.dataGridViewContatosCompromisso = new System.Windows.Forms.DataGridView();
            this.nomecontatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblcontatoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_listacontatos_ds_fims2DataSet2 = new S2_ProjFinal_DS.db_listacontatos_ds_fims2DataSet2();
            this.tbl_contatoTableAdapter = new S2_ProjFinal_DS.db_listacontatos_ds_fims2DataSet2TableAdapters.tbl_contatoTableAdapter();
            this.dataGridViewConvidadosCompromisso = new System.Windows.Forms.DataGridView();
            this.nomecontatoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estaConfirmadoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tblconvidadocompromissoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_listacontatos_ds_fims2DataSet3 = new S2_ProjFinal_DS.db_listacontatos_ds_fims2DataSet3();
            this.tbl_convidado_compromissoTableAdapter = new S2_ProjFinal_DS.db_listacontatos_ds_fims2DataSet3TableAdapters.tbl_convidado_compromissoTableAdapter();
            this.btnConvidarContato = new System.Windows.Forms.Button();
            this.btnRmvConvidado = new System.Windows.Forms.Button();
            this.btnEditarCompromisso = new System.Windows.Forms.Button();
            this.btnVoltarCompromisso = new System.Windows.Forms.Button();
            this.txbAssuntoCompromisso = new System.Windows.Forms.TextBox();
            this.txbDescricaoCompromisso = new System.Windows.Forms.TextBox();
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
            this.monthCalendarCompromisso.Location = new System.Drawing.Point(395, 42);
            this.monthCalendarCompromisso.MaxSelectionCount = 1;
            this.monthCalendarCompromisso.Name = "monthCalendarCompromisso";
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
            // txbHorarioCompromisso
            // 
            this.txbHorarioCompromisso.Location = new System.Drawing.Point(459, 235);
            this.txbHorarioCompromisso.Name = "txbHorarioCompromisso";
            this.txbHorarioCompromisso.Size = new System.Drawing.Size(100, 20);
            this.txbHorarioCompromisso.TabIndex = 8;
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
            this.emailDataGridViewTextBoxColumn});
            this.dataGridViewContatosCompromisso.DataSource = this.tblcontatoBindingSource;
            this.dataGridViewContatosCompromisso.Location = new System.Drawing.Point(15, 294);
            this.dataGridViewContatosCompromisso.Name = "dataGridViewContatosCompromisso";
            this.dataGridViewContatosCompromisso.ReadOnly = true;
            this.dataGridViewContatosCompromisso.RowHeadersVisible = false;
            this.dataGridViewContatosCompromisso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewContatosCompromisso.Size = new System.Drawing.Size(348, 98);
            this.dataGridViewContatosCompromisso.TabIndex = 10;
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
            this.dataGridViewConvidadosCompromisso.AutoGenerateColumns = false;
            this.dataGridViewConvidadosCompromisso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewConvidadosCompromisso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConvidadosCompromisso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomecontatoDataGridViewTextBoxColumn1,
            this.estaConfirmadoDataGridViewCheckBoxColumn});
            this.dataGridViewConvidadosCompromisso.DataSource = this.tblconvidadocompromissoBindingSource;
            this.dataGridViewConvidadosCompromisso.Location = new System.Drawing.Point(395, 294);
            this.dataGridViewConvidadosCompromisso.Name = "dataGridViewConvidadosCompromisso";
            this.dataGridViewConvidadosCompromisso.ReadOnly = true;
            this.dataGridViewConvidadosCompromisso.RowHeadersVisible = false;
            this.dataGridViewConvidadosCompromisso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewConvidadosCompromisso.Size = new System.Drawing.Size(227, 98);
            this.dataGridViewConvidadosCompromisso.TabIndex = 12;
            // 
            // nomecontatoDataGridViewTextBoxColumn1
            // 
            this.nomecontatoDataGridViewTextBoxColumn1.DataPropertyName = "nome_contato";
            this.nomecontatoDataGridViewTextBoxColumn1.HeaderText = "nome_contato";
            this.nomecontatoDataGridViewTextBoxColumn1.Name = "nomecontatoDataGridViewTextBoxColumn1";
            this.nomecontatoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // estaConfirmadoDataGridViewCheckBoxColumn
            // 
            this.estaConfirmadoDataGridViewCheckBoxColumn.DataPropertyName = "estaConfirmado";
            this.estaConfirmadoDataGridViewCheckBoxColumn.HeaderText = "estaConfirmado";
            this.estaConfirmadoDataGridViewCheckBoxColumn.Name = "estaConfirmadoDataGridViewCheckBoxColumn";
            this.estaConfirmadoDataGridViewCheckBoxColumn.ReadOnly = true;
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
            // 
            // btnRmvConvidado
            // 
            this.btnRmvConvidado.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnRmvConvidado.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.btnEditarCompromisso.TabIndex = 15;
            this.btnEditarCompromisso.Text = "Editar";
            this.btnEditarCompromisso.UseVisualStyleBackColor = false;
            this.btnEditarCompromisso.Visible = false;
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
            this.btnVoltarCompromisso.TabIndex = 16;
            this.btnVoltarCompromisso.Text = "Voltar";
            this.btnVoltarCompromisso.UseVisualStyleBackColor = false;
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
            // Compromisso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 493);
            this.Controls.Add(this.txbDescricaoCompromisso);
            this.Controls.Add(this.txbAssuntoCompromisso);
            this.Controls.Add(this.btnVoltarCompromisso);
            this.Controls.Add(this.btnEditarCompromisso);
            this.Controls.Add(this.btnRmvConvidado);
            this.Controls.Add(this.btnConvidarContato);
            this.Controls.Add(this.dataGridViewConvidadosCompromisso);
            this.Controls.Add(this.dataGridViewContatosCompromisso);
            this.Controls.Add(this.lblDataCompromisso);
            this.Controls.Add(this.lblContatosCompromisso);
            this.Controls.Add(this.lblConvidadosCompromisso);
            this.Controls.Add(this.lblDescricaoCompromisso);
            this.Controls.Add(this.lblAssuntoCompromisso);
            this.Controls.Add(this.txbHorarioCompromisso);
            this.Controls.Add(this.lblHorarioCompromisso);
            this.Controls.Add(this.monthCalendarCompromisso);
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

        private System.Windows.Forms.MonthCalendar monthCalendarCompromisso;
        private System.Windows.Forms.Label lblHorarioCompromisso;
        private System.Windows.Forms.TextBox txbHorarioCompromisso;
        private System.Windows.Forms.Label lblAssuntoCompromisso;
        private System.Windows.Forms.Label lblDescricaoCompromisso;
        private System.Windows.Forms.Label lblConvidadosCompromisso;
        private System.Windows.Forms.Label lblContatosCompromisso;
        private System.Windows.Forms.Label lblDataCompromisso;
        private System.Windows.Forms.DataGridView dataGridViewContatosCompromisso;
        private db_listacontatos_ds_fims2DataSet2 db_listacontatos_ds_fims2DataSet2;
        private System.Windows.Forms.BindingSource tblcontatoBindingSource;
        private db_listacontatos_ds_fims2DataSet2TableAdapters.tbl_contatoTableAdapter tbl_contatoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomecontatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridViewConvidadosCompromisso;
        private db_listacontatos_ds_fims2DataSet3 db_listacontatos_ds_fims2DataSet3;
        private System.Windows.Forms.BindingSource tblconvidadocompromissoBindingSource;
        private db_listacontatos_ds_fims2DataSet3TableAdapters.tbl_convidado_compromissoTableAdapter tbl_convidado_compromissoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomecontatoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estaConfirmadoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button btnConvidarContato;
        private System.Windows.Forms.Button btnRmvConvidado;
        private System.Windows.Forms.Button btnEditarCompromisso;
        private System.Windows.Forms.Button btnVoltarCompromisso;
        private System.Windows.Forms.TextBox txbAssuntoCompromisso;
        private System.Windows.Forms.TextBox txbDescricaoCompromisso;
    }
}