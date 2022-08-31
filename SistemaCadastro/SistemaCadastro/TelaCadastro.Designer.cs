namespace SistemaCadastro
{
    partial class TelaCadastro
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboEstadoCivil = new System.Windows.Forms.ComboBox();
            this.numberBox = new System.Windows.Forms.MaskedTextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.dataBox = new System.Windows.Forms.DateTimePicker();
            this.botaoOK = new System.Windows.Forms.Button();
            this.botaoCancel = new System.Windows.Forms.Button();
            this.botaoClean = new System.Windows.Forms.Button();
            this.checkCasaPropria = new System.Windows.Forms.CheckBox();
            this.checkCarroProprio = new System.Windows.Forms.CheckBox();
            this.grupoSexo = new System.Windows.Forms.GroupBox();
            this.radioO = new System.Windows.Forms.RadioButton();
            this.radioF = new System.Windows.Forms.RadioButton();
            this.radioM = new System.Windows.Forms.RadioButton();
            this.lista = new System.Windows.Forms.ListBox();
            this.listButton = new System.Windows.Forms.Button();
            this.cleanListButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.expand = new System.Windows.Forms.Button();
            this.grupoSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estado Civil";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefone";
            // 
            // comboEstadoCivil
            // 
            this.comboEstadoCivil.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.comboEstadoCivil.DisplayMember = "Solteiro";
            this.comboEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEstadoCivil.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboEstadoCivil.FormattingEnabled = true;
            this.comboEstadoCivil.Items.AddRange(new object[] {
            "Solteiro",
            "Casado",
            "Divorciado",
            "Viúvo"});
            this.comboEstadoCivil.Location = new System.Drawing.Point(163, 142);
            this.comboEstadoCivil.Name = "comboEstadoCivil";
            this.comboEstadoCivil.Size = new System.Drawing.Size(258, 21);
            this.comboEstadoCivil.TabIndex = 4;
            // 
            // numberBox
            // 
            this.numberBox.Location = new System.Drawing.Point(163, 186);
            this.numberBox.Mask = "(99) 00000-0000";
            this.numberBox.Name = "numberBox";
            this.numberBox.Size = new System.Drawing.Size(258, 20);
            this.numberBox.TabIndex = 5;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(163, 28);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(258, 20);
            this.nameBox.TabIndex = 6;
            // 
            // dataBox
            // 
            this.dataBox.CustomFormat = "";
            this.dataBox.Location = new System.Drawing.Point(163, 86);
            this.dataBox.Name = "dataBox";
            this.dataBox.Size = new System.Drawing.Size(258, 20);
            this.dataBox.TabIndex = 7;
            // 
            // botaoOK
            // 
            this.botaoOK.Location = new System.Drawing.Point(52, 331);
            this.botaoOK.Name = "botaoOK";
            this.botaoOK.Size = new System.Drawing.Size(111, 43);
            this.botaoOK.TabIndex = 8;
            this.botaoOK.Text = "Confirmar";
            this.botaoOK.UseVisualStyleBackColor = true;
            this.botaoOK.Click += new System.EventHandler(this.botaoOK_Click);
            // 
            // botaoCancel
            // 
            this.botaoCancel.Location = new System.Drawing.Point(181, 331);
            this.botaoCancel.Name = "botaoCancel";
            this.botaoCancel.Size = new System.Drawing.Size(111, 43);
            this.botaoCancel.TabIndex = 9;
            this.botaoCancel.Text = "Cancelar";
            this.botaoCancel.UseVisualStyleBackColor = true;
            this.botaoCancel.Click += new System.EventHandler(this.botaoCancel_Click);
            // 
            // botaoClean
            // 
            this.botaoClean.Location = new System.Drawing.Point(310, 331);
            this.botaoClean.Name = "botaoClean";
            this.botaoClean.Size = new System.Drawing.Size(111, 43);
            this.botaoClean.TabIndex = 10;
            this.botaoClean.Text = "Limpar";
            this.botaoClean.UseVisualStyleBackColor = true;
            this.botaoClean.Click += new System.EventHandler(this.botaoClean_Click);
            // 
            // checkCasaPropria
            // 
            this.checkCasaPropria.AutoSize = true;
            this.checkCasaPropria.Location = new System.Drawing.Point(163, 227);
            this.checkCasaPropria.Name = "checkCasaPropria";
            this.checkCasaPropria.Size = new System.Drawing.Size(86, 17);
            this.checkCasaPropria.TabIndex = 11;
            this.checkCasaPropria.Text = "Casa Própria";
            this.checkCasaPropria.UseVisualStyleBackColor = true;
            // 
            // checkCarroProprio
            // 
            this.checkCarroProprio.AutoSize = true;
            this.checkCarroProprio.Location = new System.Drawing.Point(163, 251);
            this.checkCarroProprio.Name = "checkCarroProprio";
            this.checkCarroProprio.Size = new System.Drawing.Size(87, 17);
            this.checkCarroProprio.TabIndex = 12;
            this.checkCarroProprio.Text = "Carro Próprio";
            this.checkCarroProprio.UseVisualStyleBackColor = true;
            // 
            // grupoSexo
            // 
            this.grupoSexo.Controls.Add(this.radioO);
            this.grupoSexo.Controls.Add(this.radioF);
            this.grupoSexo.Controls.Add(this.radioM);
            this.grupoSexo.Location = new System.Drawing.Point(467, 28);
            this.grupoSexo.Name = "grupoSexo";
            this.grupoSexo.Size = new System.Drawing.Size(321, 100);
            this.grupoSexo.TabIndex = 13;
            this.grupoSexo.TabStop = false;
            this.grupoSexo.Text = "Sexo";
            // 
            // radioO
            // 
            this.radioO.AutoSize = true;
            this.radioO.Location = new System.Drawing.Point(7, 67);
            this.radioO.Name = "radioO";
            this.radioO.Size = new System.Drawing.Size(56, 17);
            this.radioO.TabIndex = 14;
            this.radioO.TabStop = true;
            this.radioO.Text = "Outros";
            this.radioO.UseVisualStyleBackColor = true;
            // 
            // radioF
            // 
            this.radioF.AutoSize = true;
            this.radioF.Location = new System.Drawing.Point(7, 44);
            this.radioF.Name = "radioF";
            this.radioF.Size = new System.Drawing.Size(67, 17);
            this.radioF.TabIndex = 1;
            this.radioF.TabStop = true;
            this.radioF.Text = "Feminino";
            this.radioF.UseVisualStyleBackColor = true;
            // 
            // radioM
            // 
            this.radioM.AutoSize = true;
            this.radioM.Checked = true;
            this.radioM.Location = new System.Drawing.Point(7, 20);
            this.radioM.Name = "radioM";
            this.radioM.Size = new System.Drawing.Size(73, 17);
            this.radioM.TabIndex = 0;
            this.radioM.TabStop = true;
            this.radioM.Text = "Masculino";
            this.radioM.UseVisualStyleBackColor = true;
            // 
            // lista
            // 
            this.lista.FormattingEnabled = true;
            this.lista.Location = new System.Drawing.Point(467, 149);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(321, 225);
            this.lista.TabIndex = 15;
            // 
            // listButton
            // 
            this.listButton.Location = new System.Drawing.Point(677, 213);
            this.listButton.Name = "listButton";
            this.listButton.Size = new System.Drawing.Size(111, 43);
            this.listButton.TabIndex = 16;
            this.listButton.Text = "Listar";
            this.listButton.UseVisualStyleBackColor = true;
            this.listButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // cleanListButton
            // 
            this.cleanListButton.Location = new System.Drawing.Point(677, 262);
            this.cleanListButton.Name = "cleanListButton";
            this.cleanListButton.Size = new System.Drawing.Size(111, 43);
            this.cleanListButton.TabIndex = 17;
            this.cleanListButton.Text = "Limpar Lista";
            this.cleanListButton.UseVisualStyleBackColor = true;
            this.cleanListButton.Click += new System.EventHandler(this.cleanListButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(677, 311);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(111, 43);
            this.removeButton.TabIndex = 18;
            this.removeButton.Text = "Remover";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // expand
            // 
            this.expand.Location = new System.Drawing.Point(677, 164);
            this.expand.Name = "expand";
            this.expand.Size = new System.Drawing.Size(111, 43);
            this.expand.TabIndex = 19;
            this.expand.Text = "Expandir";
            this.expand.UseVisualStyleBackColor = true;
            this.expand.Click += new System.EventHandler(this.expand_Click);
            // 
            // TelaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.expand);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.cleanListButton);
            this.Controls.Add(this.listButton);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.grupoSexo);
            this.Controls.Add(this.checkCarroProprio);
            this.Controls.Add(this.checkCasaPropria);
            this.Controls.Add(this.botaoClean);
            this.Controls.Add(this.botaoCancel);
            this.Controls.Add(this.botaoOK);
            this.Controls.Add(this.dataBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.numberBox);
            this.Controls.Add(this.comboEstadoCivil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "TelaCadastro";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grupoSexo.ResumeLayout(false);
            this.grupoSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox numberBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.DateTimePicker dataBox;
        private System.Windows.Forms.Button botaoOK;
        private System.Windows.Forms.Button botaoCancel;
        private System.Windows.Forms.Button botaoClean;
        public System.Windows.Forms.ComboBox comboEstadoCivil;
        private System.Windows.Forms.CheckBox checkCasaPropria;
        private System.Windows.Forms.CheckBox checkCarroProprio;
        private System.Windows.Forms.GroupBox grupoSexo;
        private System.Windows.Forms.RadioButton radioO;
        private System.Windows.Forms.RadioButton radioF;
        private System.Windows.Forms.RadioButton radioM;
        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.Button listButton;
        private System.Windows.Forms.Button cleanListButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button expand;
    }
}

