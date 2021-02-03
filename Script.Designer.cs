namespace NPC
{
    partial class Script
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Script));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbBotaoSalvar = new System.Windows.Forms.Label();
            this.pnBotaoBorda = new System.Windows.Forms.Panel();
            this.lbBotaoFundoTexto = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtScript = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnBotaoBorda.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 538);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.pnBotaoBorda);
            this.panel2.Controls.Add(this.lbTitulo);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(863, 41);
            this.panel2.TabIndex = 0;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveJ);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel4.Controls.Add(this.lbBotaoSalvar);
            this.panel4.Location = new System.Drawing.Point(692, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(80, 31);
            this.panel4.TabIndex = 2;
            // 
            // lbBotaoSalvar
            // 
            this.lbBotaoSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBotaoSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbBotaoSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbBotaoSalvar.ForeColor = System.Drawing.Color.White;
            this.lbBotaoSalvar.Location = new System.Drawing.Point(1, 1);
            this.lbBotaoSalvar.Name = "lbBotaoSalvar";
            this.lbBotaoSalvar.Size = new System.Drawing.Size(78, 29);
            this.lbBotaoSalvar.TabIndex = 0;
            this.lbBotaoSalvar.Text = "SALVAR";
            this.lbBotaoSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbBotaoSalvar.Click += new System.EventHandler(this.lbBotaoSalvar_Click);
            // 
            // pnBotaoBorda
            // 
            this.pnBotaoBorda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnBotaoBorda.Controls.Add(this.lbBotaoFundoTexto);
            this.pnBotaoBorda.Location = new System.Drawing.Point(778, 5);
            this.pnBotaoBorda.Name = "pnBotaoBorda";
            this.pnBotaoBorda.Size = new System.Drawing.Size(80, 31);
            this.pnBotaoBorda.TabIndex = 1;
            // 
            // lbBotaoFundoTexto
            // 
            this.lbBotaoFundoTexto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBotaoFundoTexto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbBotaoFundoTexto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbBotaoFundoTexto.ForeColor = System.Drawing.Color.White;
            this.lbBotaoFundoTexto.Location = new System.Drawing.Point(1, 1);
            this.lbBotaoFundoTexto.Name = "lbBotaoFundoTexto";
            this.lbBotaoFundoTexto.Size = new System.Drawing.Size(78, 29);
            this.lbBotaoFundoTexto.TabIndex = 0;
            this.lbBotaoFundoTexto.Text = "Fechar";
            this.lbBotaoFundoTexto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbBotaoFundoTexto.Click += new System.EventHandler(this.lbBotaoFundoTexto_Click);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.ForeColor = System.Drawing.Color.Silver;
            this.lbTitulo.Location = new System.Drawing.Point(12, 12);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(35, 13);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "label1";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.txtScript);
            this.panel3.Location = new System.Drawing.Point(1, 41);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(863, 496);
            this.panel3.TabIndex = 1;
            // 
            // txtScript
            // 
            this.txtScript.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtScript.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtScript.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScript.ForeColor = System.Drawing.SystemColors.Window;
            this.txtScript.Location = new System.Drawing.Point(6, 6);
            this.txtScript.Multiline = true;
            this.txtScript.Name = "txtScript";
            this.txtScript.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtScript.Size = new System.Drawing.Size(852, 484);
            this.txtScript.TabIndex = 0;
            this.txtScript.TabStop = false;
            this.txtScript.WordWrap = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel5.Controls.Add(this.label1);
            this.panel5.Enabled = false;
            this.panel5.Location = new System.Drawing.Point(551, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(135, 31);
            this.panel5.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Checar Janela do Jogo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Script
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 538);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Script";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Script";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.pnBotaoBorda.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnBotaoBorda;
        private System.Windows.Forms.Label lbBotaoFundoTexto;
        private System.Windows.Forms.TextBox txtScript;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbBotaoSalvar;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
    }
}