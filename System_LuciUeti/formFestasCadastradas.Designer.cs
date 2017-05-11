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
            this.dgvContrato = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.N_Contrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_contrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf_contrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rg_contrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel_principal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel_recado_contrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cep_contrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nCasa_contrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email_contrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endereco_contrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_pessoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horario_inicio_evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horario_termino_evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obs_evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContrato)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvContrato
            // 
            this.dgvContrato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContrato.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.N_Contrato,
            this.dvgNome,
            this.data_contrato,
            this.cpf_contrato,
            this.rg_contrato,
            this.tel_principal,
            this.tel_recado_contrato,
            this.cep_contrato,
            this.nCasa_contrato,
            this.email_contrato,
            this.endereco_contrato,
            this.nome_evento,
            this.tipo_evento,
            this.valor_pessoa,
            this.valor_total,
            this.Data_Evento,
            this.horario_inicio_evento,
            this.horario_termino_evento,
            this.obs_evento});
            this.dgvContrato.Location = new System.Drawing.Point(4, 90);
            this.dgvContrato.Name = "dgvContrato";
            this.dgvContrato.Size = new System.Drawing.Size(1010, 385);
            this.dgvContrato.TabIndex = 0;
            this.dgvContrato.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContrato_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(366, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(410, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(125, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(580, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
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
            this.button2.Location = new System.Drawing.Point(580, 54);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Voltar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // N_Contrato
            // 
            this.N_Contrato.HeaderText = "Numero do Contrato";
            this.N_Contrato.Name = "N_Contrato";
            // 
            // dvgNome
            // 
            this.dvgNome.HeaderText = "Nome do Contratante";
            this.dvgNome.Name = "dvgNome";
            // 
            // data_contrato
            // 
            this.data_contrato.HeaderText = "Data do Contrato";
            this.data_contrato.Name = "data_contrato";
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
            // nome_evento
            // 
            this.nome_evento.HeaderText = "Nome do evento";
            this.nome_evento.Name = "nome_evento";
            // 
            // tipo_evento
            // 
            this.tipo_evento.HeaderText = "Tipo de evento";
            this.tipo_evento.Name = "tipo_evento";
            // 
            // valor_pessoa
            // 
            this.valor_pessoa.HeaderText = "Valor por Pessoa";
            this.valor_pessoa.Name = "valor_pessoa";
            // 
            // valor_total
            // 
            this.valor_total.HeaderText = "Valor total do evento";
            this.valor_total.Name = "valor_total";
            // 
            // Data_Evento
            // 
            this.Data_Evento.HeaderText = "Data do evento";
            this.Data_Evento.Name = "Data_Evento";
            // 
            // horario_inicio_evento
            // 
            this.horario_inicio_evento.HeaderText = "Horario de Inicio do evento";
            this.horario_inicio_evento.Name = "horario_inicio_evento";
            // 
            // horario_termino_evento
            // 
            this.horario_termino_evento.HeaderText = "Horario de termino do evento ";
            this.horario_termino_evento.Name = "horario_termino_evento";
            // 
            // obs_evento
            // 
            this.obs_evento.HeaderText = "Obs";
            this.obs_evento.Name = "obs_evento";
            // 
            // formFestasCadastradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 478);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgvContrato);
            this.Name = "formFestasCadastradas";
            this.Text = "formFestasCadastradas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvContrato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvContrato;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn N_Contrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_contrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf_contrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn rg_contrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel_principal;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel_recado_contrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn cep_contrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn nCasa_contrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn email_contrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn endereco_contrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_evento;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_evento;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor_pessoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Evento;
        private System.Windows.Forms.DataGridViewTextBoxColumn horario_inicio_evento;
        private System.Windows.Forms.DataGridViewTextBoxColumn horario_termino_evento;
        private System.Windows.Forms.DataGridViewTextBoxColumn obs_evento;
    }
}