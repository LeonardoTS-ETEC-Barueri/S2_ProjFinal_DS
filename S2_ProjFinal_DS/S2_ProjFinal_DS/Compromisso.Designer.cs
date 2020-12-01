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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nomecontatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblcontatoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_listacontatos_ds_fims2DataSet2 = new S2_ProjFinal_DS.db_listacontatos_ds_fims2DataSet2();
            this.tbl_contatoTableAdapter = new S2_ProjFinal_DS.db_listacontatos_ds_fims2DataSet2TableAdapters.tbl_contatoTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.nomecontatoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estaConfirmadoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tblconvidadocompromissoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_listacontatos_ds_fims2DataSet3 = new S2_ProjFinal_DS.db_listacontatos_ds_fims2DataSet3();
            this.tbl_convidado_compromissoTableAdapter = new S2_ProjFinal_DS.db_listacontatos_ds_fims2DataSet3TableAdapters.tbl_convidado_compromissoTableAdapter();
            this.btnContatoAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcontatoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_listacontatos_ds_fims2DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblconvidadocompromissoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_listacontatos_ds_fims2DataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(395, 42);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Liberation Sans", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(475, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "HORÁRIO";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(459, 235);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Liberation Sans", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(18, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "ASSUNTO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Liberation Sans", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(18, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "DESCRIÇÃO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Liberation Sans", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(398, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "CONVIDADOS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Liberation Sans", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(18, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "CONTATOS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Liberation Sans", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(433, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "SELECIONE UMA DATA";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomecontatoDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblcontatoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 294);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(348, 98);
            this.dataGridView1.TabIndex = 10;
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
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomecontatoDataGridViewTextBoxColumn1,
            this.estaConfirmadoDataGridViewCheckBoxColumn});
            this.dataGridView2.DataSource = this.tblconvidadocompromissoBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(395, 294);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(227, 98);
            this.dataGridView2.TabIndex = 11;
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
            // btnContatoAdd
            // 
            this.btnContatoAdd.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnContatoAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContatoAdd.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnContatoAdd.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnContatoAdd.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnContatoAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContatoAdd.Font = new System.Drawing.Font("Liberation Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContatoAdd.Location = new System.Drawing.Point(15, 398);
            this.btnContatoAdd.Name = "btnContatoAdd";
            this.btnContatoAdd.Size = new System.Drawing.Size(172, 23);
            this.btnContatoAdd.TabIndex = 12;
            this.btnContatoAdd.Text = "Convidar contato";
            this.btnContatoAdd.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Liberation Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(450, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Remover convidado";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Enabled = false;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Liberation Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(450, 458);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Editar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Liberation Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(539, 458);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(83, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "Voltar";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(15, 42);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(348, 20);
            this.textBox2.TabIndex = 17;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(15, 93);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(348, 162);
            this.textBox3.TabIndex = 18;
            // 
            // Compromisso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 493);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnContatoAdd);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "Compromisso";
            this.Text = "CompromissoNovoAlterar";
            this.Load += new System.EventHandler(this.CompromissoNovoAlterar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcontatoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_listacontatos_ds_fims2DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblconvidadocompromissoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_listacontatos_ds_fims2DataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private db_listacontatos_ds_fims2DataSet2 db_listacontatos_ds_fims2DataSet2;
        private System.Windows.Forms.BindingSource tblcontatoBindingSource;
        private db_listacontatos_ds_fims2DataSet2TableAdapters.tbl_contatoTableAdapter tbl_contatoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomecontatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private db_listacontatos_ds_fims2DataSet3 db_listacontatos_ds_fims2DataSet3;
        private System.Windows.Forms.BindingSource tblconvidadocompromissoBindingSource;
        private db_listacontatos_ds_fims2DataSet3TableAdapters.tbl_convidado_compromissoTableAdapter tbl_convidado_compromissoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomecontatoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estaConfirmadoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button btnContatoAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}