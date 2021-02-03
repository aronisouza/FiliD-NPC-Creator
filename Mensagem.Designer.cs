namespace NPC
{
    partial class Mensagem
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnBotaoBorda = new System.Windows.Forms.Panel();
            this.lbBotaoFundoTexto = new System.Windows.Forms.Label();
            this.lbCarinha = new System.Windows.Forms.Label();
            this.lbMensagem = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnBotaoBorda.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 216);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Controls.Add(this.lbTitulo);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(464, 41);
            this.panel2.TabIndex = 0;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveJ);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.ForeColor = System.Drawing.Color.Silver;
            this.lbTitulo.Location = new System.Drawing.Point(12, 12);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(42, 16);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "label1";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.pnBotaoBorda);
            this.panel3.Controls.Add(this.lbCarinha);
            this.panel3.Controls.Add(this.lbMensagem);
            this.panel3.Location = new System.Drawing.Point(1, 41);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(464, 174);
            this.panel3.TabIndex = 1;
            // 
            // pnBotaoBorda
            // 
            this.pnBotaoBorda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnBotaoBorda.Controls.Add(this.lbBotaoFundoTexto);
            this.pnBotaoBorda.Location = new System.Drawing.Point(379, 138);
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
            this.lbBotaoFundoTexto.Text = "ok";
            this.lbBotaoFundoTexto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbBotaoFundoTexto.Click += new System.EventHandler(this.btFechar_Click);
            this.lbBotaoFundoTexto.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbBotaoFundoTexto_MouseDown);
            this.lbBotaoFundoTexto.MouseLeave += new System.EventHandler(this.lbBotaoFundoTexto_MouseLeave);
            this.lbBotaoFundoTexto.MouseHover += new System.EventHandler(this.lbBotaoFundoTexto_MouseHover);
            this.lbBotaoFundoTexto.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lbBotaoFundoTexto_MouseUp);
            // 
            // lbCarinha
            // 
            this.lbCarinha.AutoSize = true;
            this.lbCarinha.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCarinha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbCarinha.Location = new System.Drawing.Point(11, 41);
            this.lbCarinha.Name = "lbCarinha";
            this.lbCarinha.Size = new System.Drawing.Size(48, 58);
            this.lbCarinha.TabIndex = 0;
            this.lbCarinha.Text = "?";
            this.lbCarinha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbMensagem
            // 
            this.lbMensagem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbMensagem.Location = new System.Drawing.Point(51, 20);
            this.lbMensagem.Name = "lbMensagem";
            this.lbMensagem.Size = new System.Drawing.Size(407, 115);
            this.lbMensagem.TabIndex = 0;
            this.lbMensagem.Text = "label1";
            this.lbMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Mensagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 216);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Mensagem";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mensagem";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnBotaoBorda.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lbCarinha;
        private System.Windows.Forms.Label lbMensagem;
        private System.Windows.Forms.Panel pnBotaoBorda;
        private System.Windows.Forms.Label lbBotaoFundoTexto;
    }
}