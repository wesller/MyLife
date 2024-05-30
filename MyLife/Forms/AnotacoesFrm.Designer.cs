namespace MyLife
{
    partial class AnotacoesFrm
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
            groupBox1 = new GroupBox();
            BtnNovo = new Button();
            lbAnotacoes = new ListBox();
            lblAnotacoes = new Label();
            groupBox2 = new GroupBox();
            txtDescricao = new TextBox();
            rtbTexto = new RichTextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox1.Controls.Add(BtnNovo);
            groupBox1.Controls.Add(lbAnotacoes);
            groupBox1.Controls.Add(lblAnotacoes);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(800, 182);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // BtnNovo
            // 
            BtnNovo.Location = new Point(399, 30);
            BtnNovo.Name = "BtnNovo";
            BtnNovo.Size = new Size(117, 38);
            BtnNovo.TabIndex = 2;
            BtnNovo.Text = "Novo";
            BtnNovo.UseVisualStyleBackColor = true;
            BtnNovo.Click += btnNovo_Click;
            // 
            // lbAnotacoes
            // 
            lbAnotacoes.FormattingEnabled = true;
            lbAnotacoes.ItemHeight = 15;
            lbAnotacoes.Location = new Point(64, 28);
            lbAnotacoes.Name = "lbAnotacoes";
            lbAnotacoes.Size = new Size(327, 139);
            lbAnotacoes.TabIndex = 1;
            // 
            // lblAnotacoes
            // 
            lblAnotacoes.AutoSize = true;
            lblAnotacoes.Location = new Point(9, 28);
            lblAnotacoes.Name = "lblAnotacoes";
            lblAnotacoes.Size = new Size(38, 15);
            lblAnotacoes.TabIndex = 0;
            lblAnotacoes.Text = "label1";
            // 
            // groupBox2
            // 
            groupBox2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox2.Controls.Add(txtDescricao);
            groupBox2.Controls.Add(rtbTexto);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 182);
            groupBox2.Margin = new Padding(0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(800, 268);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            // 
            // txtDescricao
            // 
            txtDescricao.Dock = DockStyle.Top;
            txtDescricao.Location = new Point(3, 19);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(794, 23);
            txtDescricao.TabIndex = 1;
            txtDescricao.TextChanged += txtDescricao_TextChanged;
            // 
            // rtbTexto
            // 
            rtbTexto.Dock = DockStyle.Fill;
            rtbTexto.Location = new Point(3, 19);
            rtbTexto.Name = "rtbTexto";
            rtbTexto.Size = new Size(794, 246);
            rtbTexto.TabIndex = 0;
            rtbTexto.Text = "";
            rtbTexto.TextChanged += rtbTexto_TextChanged;
            // 
            // Anotacoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Anotacoes";
            Text = "Anotacoes";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button BtnNovo;
        private ListBox lbAnotacoes;
        private Label lblAnotacoes;
        private RichTextBox rtbTexto;
        private TextBox txtDescricao;
    }
}