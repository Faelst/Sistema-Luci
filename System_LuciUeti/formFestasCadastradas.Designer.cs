namespace System_LuciUeti
{
    partial class formFestasCadastradas
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
            this.dgvContratante = new System.Windows.Forms.DataGridView();
            this.N_Contratante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf_contrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rg_contrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel_principal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel_recado_contrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cep_contrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nCasa_contrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email_contrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endereco_contrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dvg_dadosEvento = new System.Windows.Forms.DataGridView();
            this.Numero_contrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome_evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_contrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_Evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horario_inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horario_termino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero_convidados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_pessoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obs_evemto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContratante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_dadosEvento)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvContratante
            // 
            this.dgvContratante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContratante.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.N_Contratante,
            this.dvgNome,
            this.cpf_contrato,
            this.rg_contrato,
            this.tel_principal,
            this.tel_recado_contrato,
            this.cep_contrato,
            this.nCasa_contrato,
            this.email_contrato,
            this.endereco_contrato});
            this.dgvContratante.Location = new System.Drawing.Point(12, 110);
            this.dgvContratante.Name = "dgvContratante";
            this.dgvContratante.Size = new System.Drawing.Size(444, 356);
            this.dgvContratante.TabIndex = 0;
            this.dgvContratante.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContrato_CellContentClick);
            this.dgvContratante.SelectionChanged += new System.EventHandler(this.dgvContratante_SelectionChanged);
            // 
            // N_Contratante
            // 
            this.N_Contratante.HeaderText = "Numero do Contrato";
            this.N_Contratante.Name = "N_Contratante";
            // 
            // dvgNome
            // 
            this.dvgNome.HeaderText = "Nome do Contratante";
            this.dvgNome.Name = "dvgNome";
            // 
            // cpf_contrato
            // 
            this.cpf_contrato.HeaderText = "CPF do contratante";
            this.cpf_contrato.Name = "cpf_contrato";
            // 
            // rg_contrato
            // 
            this.rg_contrato.HeaderText = "RG do contratante";
            this.rg_contrato.Name = "rg_contrato";
            // 
            // tel_principal
            // 
            this.tel_principal.HeaderText = "Tel.Principal";
            this.tel_principal.Name = "tel_principal";
            // 
            // tel_recado_contrato
            // 
            this.tel_recado_contrato.HeaderText = "tel.Recado";
            this.tel_recado_contrato.Name = "tel_recado_contrato";
            // 
            // cep_contrato
            // 
            this.cep_contrato.HeaderText = "CEP";
            this.cep_contrato.Name = "cep_contrato";
            // 
            // nCasa_contrato
            // 
            this.nCasa_contrato.HeaderText = "Numero da Casa";
            this.nCasa_contrato.Name = "nCasa_contrato";
            // 
            // email_contrato
            // 
            this.email_contrato.HeaderText = "E-mail";
            this.email_contrato.Name = "email_contrato";
            // 
            // endereco_contrato
            // 
            this.endereco_contrato.HeaderText = "Endereço";
            this.endereco_contrato.Name = "endereco_contrato";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(12, 49);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(366, 20);
            this.txtPesquisar.TabIndex = 1;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Infantil",
            "Casamento",
            "15 anos",
            "Almoço/Jantar",
            "Outros"});
            this.comboBox1.Location = new System.Drawing.Point(410, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(125, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(561, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pesquisar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(407, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tipo:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(561, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Voltar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dvg_dadosEvento
            // 
            this.dvg_dadosEvento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_dadosEvento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero_contrato,
            this.Nome_evento,
            this.Date_contrato,
            this.Tipo_Evento,
            this.Horario_inicio,
            this.Horario_termino,
            this.Numero_convidados,
            this.Valor_pessoa,
            this.valor_total,
            this.obs_evemto});
            this.dvg_dadosEvento.Location = new System.Drawing.Point(525, 110);
            this.dvg_dadosEvento.Name = "dvg_dadosEvento";
            this.dvg_dadosEvento.Size = new System.Drawing.Size(444, 356);
            this.dvg_dadosEvento.TabIndex = 7;
            this.dvg_dadosEvento.SelectionChanged += new System.EventHandler(this.dvg_dadosEvento_SelectionChanged);
            // 
            // Numero_contrato
            // 
            this.Numero_contrato.HeaderText = "Numero do Contrato:";
            this.Numero_contrato.Name = "Numero_contrato";
            // 
            // Nome_evento
            // 
            this.Nome_evento.HeaderText = "Nome do evento:";
            this.Nome_evento.Name = "Nome_evento";
            // 
            // Date_contrato
            // 
            this.Date_contrato.HeaderText = "Data do contrato";
            this.Date_contrato.Name = "Date_contrato";
            // 
            // Tipo_Evento
            // 
            this.Tipo_Evento.HeaderText = "Tipo de Evento";
            this.Tipo_Evento.Name = "Tipo_Evento";
            // 
            // Horario_inicio
            // 
            this.Horario_inicio.HeaderText = "Horario de Inicio";
            this.Horario_inicio.Name = "Horario_inicio";
            // 
            // Horario_termino
            // 
            this.Horario_termino.HeaderText = "Horario de termino";
            this.Horario_termino.Name = "Horario_termino";
            // 
            // Numero_convidados
            // 
            this.Numero_convidados.HeaderText = "Qtde de convidados";
            this.Numero_convidados.Name = "Numero_convidados";
            // 
            // Valor_pessoa
            // 
            this.Valor_pessoa.HeaderText = "Valor por pessoa";
            this.Valor_pessoa.Name = "Valor_pessoa";
            // 
            // valor_total
            // 
            this.valor_total.HeaderText = "Valor Toral";
            this.valor_total.Name = "valor_total";
            // 
            // obs_evemto
            // 
            this.obs_evemto.HeaderText = "Observaçoes";
            this.obs_evemto.Name = "obs_evemto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "DADOS DO CONTRATANTE:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(522, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "DADOS DO EVENTO:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(744, 49);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Voltar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(744, 20);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(141, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Voltar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // formFestasCadastradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 478);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dvg_dadosEvento);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.dgvContratante);
            this.Name = "formFestasCadastradas";
            this.Text = "formFestasCadastradas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvContratante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_dadosEvento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvContratante;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dvg_dadosEvento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_contrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome_evento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_contrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Evento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horario_inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horario_termino;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_convidados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_pessoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn obs_evemto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn N_Contratante;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf_contrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn rg_contrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel_principal;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel_recado_contrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn cep_contrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn nCasa_contrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn email_contrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn endereco_contrato;
    }
}