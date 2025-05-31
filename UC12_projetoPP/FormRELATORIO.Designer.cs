namespace UC12_projetoPP
{
    partial class FormRELATORIO
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
            this.panelRELATORIO = new System.Windows.Forms.Panel();
            this.buttonPESQUISA = new System.Windows.Forms.Button();
            this.textBoxRELATORIO = new System.Windows.Forms.TextBox();
            this.dataGridRELATORIO = new System.Windows.Forms.DataGridView();
            this.menuStripMAIN = new System.Windows.Forms.MenuStrip();
            this.PrincipalMENUSTRIP = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarMENUSTRIP = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBoxPESQUISACLIENTES = new System.Windows.Forms.CheckBox();
            this.checkBoxPESQUISATECNICO = new System.Windows.Forms.CheckBox();
            this.checkBoxSERVICOS = new System.Windows.Forms.CheckBox();
            this.panelRELATORIO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRELATORIO)).BeginInit();
            this.menuStripMAIN.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRELATORIO
            // 
            this.panelRELATORIO.BackColor = System.Drawing.Color.Honeydew;
            this.panelRELATORIO.Controls.Add(this.checkBoxSERVICOS);
            this.panelRELATORIO.Controls.Add(this.checkBoxPESQUISACLIENTES);
            this.panelRELATORIO.Controls.Add(this.checkBoxPESQUISATECNICO);
            this.panelRELATORIO.Controls.Add(this.buttonPESQUISA);
            this.panelRELATORIO.Controls.Add(this.textBoxRELATORIO);
            this.panelRELATORIO.Controls.Add(this.dataGridRELATORIO);
            this.panelRELATORIO.Location = new System.Drawing.Point(0, 27);
            this.panelRELATORIO.Name = "panelRELATORIO";
            this.panelRELATORIO.Size = new System.Drawing.Size(611, 405);
            this.panelRELATORIO.TabIndex = 7;
            // 
            // buttonPESQUISA
            // 
            this.buttonPESQUISA.Location = new System.Drawing.Point(224, 4);
            this.buttonPESQUISA.Name = "buttonPESQUISA";
            this.buttonPESQUISA.Size = new System.Drawing.Size(75, 23);
            this.buttonPESQUISA.TabIndex = 8;
            this.buttonPESQUISA.Text = "Pesquisar";
            this.buttonPESQUISA.UseVisualStyleBackColor = true;
            this.buttonPESQUISA.Click += new System.EventHandler(this.buttonPESQUISA_Click);
            // 
            // textBoxRELATORIO
            // 
            this.textBoxRELATORIO.Location = new System.Drawing.Point(3, 6);
            this.textBoxRELATORIO.Name = "textBoxRELATORIO";
            this.textBoxRELATORIO.Size = new System.Drawing.Size(213, 20);
            this.textBoxRELATORIO.TabIndex = 7;
            // 
            // dataGridRELATORIO
            // 
            this.dataGridRELATORIO.BackgroundColor = System.Drawing.Color.MintCream;
            this.dataGridRELATORIO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRELATORIO.Location = new System.Drawing.Point(3, 32);
            this.dataGridRELATORIO.Name = "dataGridRELATORIO";
            this.dataGridRELATORIO.Size = new System.Drawing.Size(438, 372);
            this.dataGridRELATORIO.TabIndex = 6;
            // 
            // menuStripMAIN
            // 
            this.menuStripMAIN.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PrincipalMENUSTRIP,
            this.cadastrarMENUSTRIP});
            this.menuStripMAIN.Location = new System.Drawing.Point(0, 0);
            this.menuStripMAIN.Name = "menuStripMAIN";
            this.menuStripMAIN.Size = new System.Drawing.Size(614, 24);
            this.menuStripMAIN.TabIndex = 8;
            this.menuStripMAIN.Text = "menuStrip1";
            // 
            // PrincipalMENUSTRIP
            // 
            this.PrincipalMENUSTRIP.Name = "PrincipalMENUSTRIP";
            this.PrincipalMENUSTRIP.Size = new System.Drawing.Size(65, 20);
            this.PrincipalMENUSTRIP.Text = "Principal";
            this.PrincipalMENUSTRIP.Click += new System.EventHandler(this.PrincipalMENUSTRIP_Click);
            // 
            // cadastrarMENUSTRIP
            // 
            this.cadastrarMENUSTRIP.Name = "cadastrarMENUSTRIP";
            this.cadastrarMENUSTRIP.Size = new System.Drawing.Size(69, 20);
            this.cadastrarMENUSTRIP.Text = "Cadastrar";
            this.cadastrarMENUSTRIP.Click += new System.EventHandler(this.cadastrarMENUSTRIP_Click);
            // 
            // checkBoxPESQUISACLIENTES
            // 
            this.checkBoxPESQUISACLIENTES.AutoSize = true;
            this.checkBoxPESQUISACLIENTES.Location = new System.Drawing.Point(447, 55);
            this.checkBoxPESQUISACLIENTES.Name = "checkBoxPESQUISACLIENTES";
            this.checkBoxPESQUISACLIENTES.Size = new System.Drawing.Size(63, 17);
            this.checkBoxPESQUISACLIENTES.TabIndex = 12;
            this.checkBoxPESQUISACLIENTES.Text = "Clientes";
            this.checkBoxPESQUISACLIENTES.UseVisualStyleBackColor = true;
            this.checkBoxPESQUISACLIENTES.CheckedChanged += new System.EventHandler(this.checkBoxPESQUISACLIENTES_CheckedChanged);
            // 
            // checkBoxPESQUISATECNICO
            // 
            this.checkBoxPESQUISATECNICO.AutoSize = true;
            this.checkBoxPESQUISATECNICO.Location = new System.Drawing.Point(447, 32);
            this.checkBoxPESQUISATECNICO.Name = "checkBoxPESQUISATECNICO";
            this.checkBoxPESQUISATECNICO.Size = new System.Drawing.Size(70, 17);
            this.checkBoxPESQUISATECNICO.TabIndex = 11;
            this.checkBoxPESQUISATECNICO.Text = "Técnicos";
            this.checkBoxPESQUISATECNICO.UseVisualStyleBackColor = true;
            this.checkBoxPESQUISATECNICO.CheckedChanged += new System.EventHandler(this.checkBoxPESQUISATECNICO_CheckedChanged);
            // 
            // checkBoxSERVICOS
            // 
            this.checkBoxSERVICOS.AutoSize = true;
            this.checkBoxSERVICOS.Location = new System.Drawing.Point(448, 79);
            this.checkBoxSERVICOS.Name = "checkBoxSERVICOS";
            this.checkBoxSERVICOS.Size = new System.Drawing.Size(62, 17);
            this.checkBoxSERVICOS.TabIndex = 13;
            this.checkBoxSERVICOS.Text = "Serviço";
            this.checkBoxSERVICOS.UseVisualStyleBackColor = true;
            this.checkBoxSERVICOS.CheckedChanged += new System.EventHandler(this.checkBoxSERVICOS_CheckedChanged);
            // 
            // FormRELATORIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(614, 431);
            this.Controls.Add(this.panelRELATORIO);
            this.Controls.Add(this.menuStripMAIN);
            this.MainMenuStrip = this.menuStripMAIN;
            this.Name = "FormRELATORIO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRELATORIO";
            this.Load += new System.EventHandler(this.FormRELATORIO_Load);
            this.panelRELATORIO.ResumeLayout(false);
            this.panelRELATORIO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRELATORIO)).EndInit();
            this.menuStripMAIN.ResumeLayout(false);
            this.menuStripMAIN.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelRELATORIO;
        private System.Windows.Forms.Button buttonPESQUISA;
        private System.Windows.Forms.TextBox textBoxRELATORIO;
        private System.Windows.Forms.DataGridView dataGridRELATORIO;
        private System.Windows.Forms.MenuStrip menuStripMAIN;
        private System.Windows.Forms.ToolStripMenuItem PrincipalMENUSTRIP;
        private System.Windows.Forms.ToolStripMenuItem cadastrarMENUSTRIP;
        private System.Windows.Forms.CheckBox checkBoxPESQUISACLIENTES;
        private System.Windows.Forms.CheckBox checkBoxPESQUISATECNICO;
        private System.Windows.Forms.CheckBox checkBoxSERVICOS;
    }
}