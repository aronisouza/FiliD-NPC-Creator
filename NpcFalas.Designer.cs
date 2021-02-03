namespace NPC
{
    partial class NpcFalas
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
            this.lbBotaoInfo = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbBotaoFechar = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbBotaoInfo
            // 
            this.lbBotaoInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBotaoInfo.BackColor = System.Drawing.SystemColors.MenuText;
            this.lbBotaoInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbBotaoInfo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBotaoInfo.ForeColor = System.Drawing.Color.White;
            this.lbBotaoInfo.Location = new System.Drawing.Point(691, 3);
            this.lbBotaoInfo.Name = "lbBotaoInfo";
            this.lbBotaoInfo.Size = new System.Drawing.Size(44, 41);
            this.lbBotaoInfo.TabIndex = 8;
            this.lbBotaoInfo.Text = "?";
            this.lbBotaoInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbBotaoInfo.Click += new System.EventHandler(this.lbBotaoInfo_Click);
            this.lbBotaoInfo.MouseLeave += new System.EventHandler(this.lbBotaoInfo_MouseLeave);
            this.lbBotaoInfo.MouseHover += new System.EventHandler(this.lbBotaoInfo_MouseHover);
            // 
            // lbTitulo
            // 
            this.lbTitulo.BackColor = System.Drawing.SystemColors.MenuText;
            this.lbTitulo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbTitulo.Location = new System.Drawing.Point(1, 1);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lbTitulo.Size = new System.Drawing.Size(786, 43);
            this.lbTitulo.TabIndex = 7;
            this.lbTitulo.Text = "FiliÐ NPC Creator: Quest Pré programada";
            this.lbTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveJ);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel6.Controls.Add(this.lbBotaoInfo);
            this.panel6.Controls.Add(this.lbBotaoFechar);
            this.panel6.Controls.Add(this.lbTitulo);
            this.panel6.Controls.Add(this.panel2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(788, 446);
            this.panel6.TabIndex = 13;
            // 
            // lbBotaoFechar
            // 
            this.lbBotaoFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBotaoFechar.BackColor = System.Drawing.SystemColors.MenuText;
            this.lbBotaoFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbBotaoFechar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBotaoFechar.ForeColor = System.Drawing.Color.White;
            this.lbBotaoFechar.Location = new System.Drawing.Point(741, 3);
            this.lbBotaoFechar.Name = "lbBotaoFechar";
            this.lbBotaoFechar.Size = new System.Drawing.Size(44, 41);
            this.lbBotaoFechar.TabIndex = 0;
            this.lbBotaoFechar.Text = "X";
            this.lbBotaoFechar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbBotaoFechar.Click += new System.EventHandler(this.lbBotaoFechar_Click);
            this.lbBotaoFechar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbBotaoFechar_MouseDown);
            this.lbBotaoFechar.MouseLeave += new System.EventHandler(this.lbBotaoFechar_MouseLeave);
            this.lbBotaoFechar.MouseHover += new System.EventHandler(this.lbBotaoFechar_MouseHover);
            this.lbBotaoFechar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lbBotaoFechar_MouseUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Location = new System.Drawing.Point(1, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(786, 341);
            this.panel2.TabIndex = 6;
            // 
            // NpcFalas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 446);
            this.Controls.Add(this.panel6);
            this.Name = "NpcFalas";
            this.Text = "NpcFalas";
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbBotaoInfo;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbBotaoFechar;
        private System.Windows.Forms.Panel panel2;
    }
}