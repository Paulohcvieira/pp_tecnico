namespace UC12_projetoPP
{
    partial class FormCADASTRAR
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
            this.menustripPRINCIPAL = new System.Windows.Forms.MenuStrip();
            this.principalmenustrip = new System.Windows.Forms.ToolStripMenuItem();
            this.relatoriomenustrip = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridPESSOAS = new System.Windows.Forms.DataGridView();
            this.labelPCADASTRADAS = new System.Windows.Forms.Label();
            this.textBoxPESQUISACADASTRO = new System.Windows.Forms.TextBox();
            this.buttonPESQUISACLIENTE = new System.Windows.Forms.Button();
            this.panelCLIENTE = new System.Windows.Forms.Panel();
            this.textBoxCONTATO = new System.Windows.Forms.TextBox();
            this.labelCONTATO = new System.Windows.Forms.Label();
            this.checkBoxADM = new System.Windows.Forms.CheckBox();
            this.textBoxCADASTROLOGIN = new System.Windows.Forms.TextBox();
            this.textBoxCADASTROSENHA = new System.Windows.Forms.TextBox();
            this.labelSENHACADASTRO = new System.Windows.Forms.Label();
            this.labelLOGINCADASTRO = new System.Windows.Forms.Label();
            this.labelNOMECADASTRO = new System.Windows.Forms.Label();
            this.labelCadastro = new System.Windows.Forms.Label();
            this.checkBoxTECNICO = new System.Windows.Forms.CheckBox();
            this.checkBoxUSUARIO = new System.Windows.Forms.CheckBox();
            this.textBoxCADASTRONOME = new System.Windows.Forms.TextBox();
            this.buttonCONFIRMCLIENTE = new System.Windows.Forms.Button();
            this.panelSERVICO = new System.Windows.Forms.Panel();
            this.checkboxPERMITIRCADASTROSERVICO = new System.Windows.Forms.CheckBox();
            this.textBoxVALORCADASTRO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCadastroserviço = new System.Windows.Forms.Label();
            this.textBoxSERVICOCADASTRO = new System.Windows.Forms.TextBox();
            this.buttonCADASTROSERVICO = new System.Windows.Forms.Button();
            this.checkBoxPESQUISATECNICO = new System.Windows.Forms.CheckBox();
            this.checkBoxPESQUISACLIENTES = new System.Windows.Forms.CheckBox();
            this.menustripPRINCIPAL.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPESSOAS)).BeginInit();
            this.panelCLIENTE.SuspendLayout();
            this.panelSERVICO.SuspendLayout();
            this.SuspendLayout();
            // 
            // menustripPRINCIPAL
            // 
            this.menustripPRINCIPAL.BackColor = System.Drawing.Color.White;
            this.menustripPRINCIPAL.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.principalmenustrip,
            this.relatoriomenustrip});
            this.menustripPRINCIPAL.Location = new System.Drawing.Point(0, 0);
            this.menustripPRINCIPAL.Name = "menustripPRINCIPAL";
            this.menustripPRINCIPAL.Size = new System.Drawing.Size(611, 24);
            this.menustripPRINCIPAL.TabIndex = 0;
            this.menustripPRINCIPAL.Text = "menuStrip1";
            // 
            // principalmenustrip
            // 
            this.principalmenustrip.Name = "principalmenustrip";
            this.principalmenustrip.Size = new System.Drawing.Size(65, 20);
            this.principalmenustrip.Text = "Principal";
            this.principalmenustrip.Click += new System.EventHandler(this.principalToolStripMenuItem_Click);
            // 
            // relatoriomenustrip
            // 
            this.relatoriomenustrip.Name = "relatoriomenustrip";
            this.relatoriomenustrip.Size = new System.Drawing.Size(66, 20);
            this.relatoriomenustrip.Text = "Relatório";
            this.relatoriomenustrip.Click += new System.EventHandler(this.relatoriomenustrip_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.panel2.Controls.Add(this.checkBoxPESQUISACLIENTES);
            this.panel2.Controls.Add(this.checkBoxPESQUISATECNICO);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dataGridPESSOAS);
            this.panel2.Controls.Add(this.labelPCADASTRADAS);
            this.panel2.Controls.Add(this.textBoxPESQUISACADASTRO);
            this.panel2.Controls.Add(this.buttonPESQUISACLIENTE);
            this.panel2.Location = new System.Drawing.Point(280, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(324, 395);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Clique em Pesquisar";
            // 
            // dataGridPESSOAS
            // 
            this.dataGridPESSOAS.BackgroundColor = System.Drawing.Color.LightGoldenrodYellow;
            this.dataGridPESSOAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPESSOAS.Location = new System.Drawing.Point(0, 60);
            this.dataGridPESSOAS.Name = "dataGridPESSOAS";
            this.dataGridPESSOAS.Size = new System.Drawing.Size(324, 335);
            this.dataGridPESSOAS.TabIndex = 2;
            // 
            // labelPCADASTRADAS
            // 
            this.labelPCADASTRADAS.AutoSize = true;
            this.labelPCADASTRADAS.Location = new System.Drawing.Point(43, 6);
            this.labelPCADASTRADAS.Name = "labelPCADASTRADAS";
            this.labelPCADASTRADAS.Size = new System.Drawing.Size(54, 13);
            this.labelPCADASTRADAS.TabIndex = 1;
            this.labelPCADASTRADAS.Text = "Cadastros";
            // 
            // textBoxPESQUISACADASTRO
            // 
            this.textBoxPESQUISACADASTRO.Location = new System.Drawing.Point(3, 40);
            this.textBoxPESQUISACADASTRO.Name = "textBoxPESQUISACADASTRO";
            this.textBoxPESQUISACADASTRO.Size = new System.Drawing.Size(150, 20);
            this.textBoxPESQUISACADASTRO.TabIndex = 4;
            // 
            // buttonPESQUISACLIENTE
            // 
            this.buttonPESQUISACLIENTE.Location = new System.Drawing.Point(203, 37);
            this.buttonPESQUISACLIENTE.Name = "buttonPESQUISACLIENTE";
            this.buttonPESQUISACLIENTE.Size = new System.Drawing.Size(75, 23);
            this.buttonPESQUISACLIENTE.TabIndex = 5;
            this.buttonPESQUISACLIENTE.Text = "Pesquisar";
            this.buttonPESQUISACLIENTE.UseVisualStyleBackColor = true;
            this.buttonPESQUISACLIENTE.Click += new System.EventHandler(this.buttonPESQUISACLIENTE_Click);
            // 
            // panelCLIENTE
            // 
            this.panelCLIENTE.BackColor = System.Drawing.Color.Honeydew;
            this.panelCLIENTE.Controls.Add(this.textBoxCONTATO);
            this.panelCLIENTE.Controls.Add(this.labelCONTATO);
            this.panelCLIENTE.Controls.Add(this.checkBoxADM);
            this.panelCLIENTE.Controls.Add(this.textBoxCADASTROLOGIN);
            this.panelCLIENTE.Controls.Add(this.textBoxCADASTROSENHA);
            this.panelCLIENTE.Controls.Add(this.labelSENHACADASTRO);
            this.panelCLIENTE.Controls.Add(this.labelLOGINCADASTRO);
            this.panelCLIENTE.Controls.Add(this.labelNOMECADASTRO);
            this.panelCLIENTE.Controls.Add(this.labelCadastro);
            this.panelCLIENTE.Controls.Add(this.checkBoxTECNICO);
            this.panelCLIENTE.Controls.Add(this.checkBoxUSUARIO);
            this.panelCLIENTE.Controls.Add(this.textBoxCADASTRONOME);
            this.panelCLIENTE.Controls.Add(this.buttonCONFIRMCLIENTE);
            this.panelCLIENTE.Location = new System.Drawing.Point(3, 27);
            this.panelCLIENTE.Name = "panelCLIENTE";
            this.panelCLIENTE.Size = new System.Drawing.Size(211, 234);
            this.panelCLIENTE.TabIndex = 5;
            // 
            // textBoxCONTATO
            // 
            this.textBoxCONTATO.Location = new System.Drawing.Point(50, 147);
            this.textBoxCONTATO.MaxLength = 14;
            this.textBoxCONTATO.Name = "textBoxCONTATO";
            this.textBoxCONTATO.Size = new System.Drawing.Size(136, 20);
            this.textBoxCONTATO.TabIndex = 16;
            // 
            // labelCONTATO
            // 
            this.labelCONTATO.AutoSize = true;
            this.labelCONTATO.Location = new System.Drawing.Point(0, 147);
            this.labelCONTATO.Name = "labelCONTATO";
            this.labelCONTATO.Size = new System.Drawing.Size(47, 13);
            this.labelCONTATO.TabIndex = 15;
            this.labelCONTATO.Text = "Contato:";
            // 
            // checkBoxADM
            // 
            this.checkBoxADM.AutoSize = true;
            this.checkBoxADM.Location = new System.Drawing.Point(153, 32);
            this.checkBoxADM.Name = "checkBoxADM";
            this.checkBoxADM.Size = new System.Drawing.Size(50, 17);
            this.checkBoxADM.TabIndex = 14;
            this.checkBoxADM.Text = "ADM";
            this.checkBoxADM.UseVisualStyleBackColor = true;
            this.checkBoxADM.CheckedChanged += new System.EventHandler(this.checkBoxADM_CheckedChanged);
            // 
            // textBoxCADASTROLOGIN
            // 
            this.textBoxCADASTROLOGIN.Location = new System.Drawing.Point(50, 102);
            this.textBoxCADASTROLOGIN.Name = "textBoxCADASTROLOGIN";
            this.textBoxCADASTROLOGIN.Size = new System.Drawing.Size(136, 20);
            this.textBoxCADASTROLOGIN.TabIndex = 13;
            // 
            // textBoxCADASTROSENHA
            // 
            this.textBoxCADASTROSENHA.Location = new System.Drawing.Point(50, 121);
            this.textBoxCADASTROSENHA.Name = "textBoxCADASTROSENHA";
            this.textBoxCADASTROSENHA.Size = new System.Drawing.Size(136, 20);
            this.textBoxCADASTROSENHA.TabIndex = 12;
            // 
            // labelSENHACADASTRO
            // 
            this.labelSENHACADASTRO.AutoSize = true;
            this.labelSENHACADASTRO.Location = new System.Drawing.Point(0, 121);
            this.labelSENHACADASTRO.Name = "labelSENHACADASTRO";
            this.labelSENHACADASTRO.Size = new System.Drawing.Size(41, 13);
            this.labelSENHACADASTRO.TabIndex = 11;
            this.labelSENHACADASTRO.Text = "Senha:";
            // 
            // labelLOGINCADASTRO
            // 
            this.labelLOGINCADASTRO.AutoSize = true;
            this.labelLOGINCADASTRO.Location = new System.Drawing.Point(3, 102);
            this.labelLOGINCADASTRO.Name = "labelLOGINCADASTRO";
            this.labelLOGINCADASTRO.Size = new System.Drawing.Size(36, 13);
            this.labelLOGINCADASTRO.TabIndex = 10;
            this.labelLOGINCADASTRO.Text = "Login:";
            // 
            // labelNOMECADASTRO
            // 
            this.labelNOMECADASTRO.AutoSize = true;
            this.labelNOMECADASTRO.Location = new System.Drawing.Point(3, 74);
            this.labelNOMECADASTRO.Name = "labelNOMECADASTRO";
            this.labelNOMECADASTRO.Size = new System.Drawing.Size(41, 13);
            this.labelNOMECADASTRO.TabIndex = 9;
            this.labelNOMECADASTRO.Text = "Nome :";
            // 
            // labelCadastro
            // 
            this.labelCadastro.AutoSize = true;
            this.labelCadastro.Location = new System.Drawing.Point(54, 8);
            this.labelCadastro.Name = "labelCadastro";
            this.labelCadastro.Size = new System.Drawing.Size(78, 13);
            this.labelCadastro.TabIndex = 8;
            this.labelCadastro.Text = "Cadastramento";
            // 
            // checkBoxTECNICO
            // 
            this.checkBoxTECNICO.AutoSize = true;
            this.checkBoxTECNICO.Location = new System.Drawing.Point(82, 32);
            this.checkBoxTECNICO.Name = "checkBoxTECNICO";
            this.checkBoxTECNICO.Size = new System.Drawing.Size(65, 17);
            this.checkBoxTECNICO.TabIndex = 7;
            this.checkBoxTECNICO.Text = "Técnico";
            this.checkBoxTECNICO.UseVisualStyleBackColor = true;
            this.checkBoxTECNICO.CheckedChanged += new System.EventHandler(this.checkBoxTECNICO_CheckedChanged);
            // 
            // checkBoxUSUARIO
            // 
            this.checkBoxUSUARIO.AutoSize = true;
            this.checkBoxUSUARIO.Location = new System.Drawing.Point(14, 32);
            this.checkBoxUSUARIO.Name = "checkBoxUSUARIO";
            this.checkBoxUSUARIO.Size = new System.Drawing.Size(58, 17);
            this.checkBoxUSUARIO.TabIndex = 6;
            this.checkBoxUSUARIO.Text = "Cliente";
            this.checkBoxUSUARIO.UseVisualStyleBackColor = true;
            this.checkBoxUSUARIO.CheckedChanged += new System.EventHandler(this.checkBoxUSUARIO_CheckedChanged);
            // 
            // textBoxCADASTRONOME
            // 
            this.textBoxCADASTRONOME.Location = new System.Drawing.Point(50, 76);
            this.textBoxCADASTRONOME.Name = "textBoxCADASTRONOME";
            this.textBoxCADASTRONOME.Size = new System.Drawing.Size(136, 20);
            this.textBoxCADASTRONOME.TabIndex = 2;
            // 
            // buttonCONFIRMCLIENTE
            // 
            this.buttonCONFIRMCLIENTE.Location = new System.Drawing.Point(76, 190);
            this.buttonCONFIRMCLIENTE.Name = "buttonCONFIRMCLIENTE";
            this.buttonCONFIRMCLIENTE.Size = new System.Drawing.Size(85, 35);
            this.buttonCONFIRMCLIENTE.TabIndex = 3;
            this.buttonCONFIRMCLIENTE.Text = "Cadastrar";
            this.buttonCONFIRMCLIENTE.UseVisualStyleBackColor = true;
            this.buttonCONFIRMCLIENTE.Click += new System.EventHandler(this.buttonCONFIRMCLIENTE_Click);
            // 
            // panelSERVICO
            // 
            this.panelSERVICO.BackColor = System.Drawing.Color.Honeydew;
            this.panelSERVICO.Controls.Add(this.checkboxPERMITIRCADASTROSERVICO);
            this.panelSERVICO.Controls.Add(this.textBoxVALORCADASTRO);
            this.panelSERVICO.Controls.Add(this.label2);
            this.panelSERVICO.Controls.Add(this.label3);
            this.panelSERVICO.Controls.Add(this.labelCadastroserviço);
            this.panelSERVICO.Controls.Add(this.textBoxSERVICOCADASTRO);
            this.panelSERVICO.Controls.Add(this.buttonCADASTROSERVICO);
            this.panelSERVICO.Location = new System.Drawing.Point(3, 258);
            this.panelSERVICO.Name = "panelSERVICO";
            this.panelSERVICO.Size = new System.Drawing.Size(211, 186);
            this.panelSERVICO.TabIndex = 15;
            // 
            // checkboxPERMITIRCADASTROSERVICO
            // 
            this.checkboxPERMITIRCADASTROSERVICO.AutoSize = true;
            this.checkboxPERMITIRCADASTROSERVICO.Location = new System.Drawing.Point(152, 8);
            this.checkboxPERMITIRCADASTROSERVICO.Name = "checkboxPERMITIRCADASTROSERVICO";
            this.checkboxPERMITIRCADASTROSERVICO.Size = new System.Drawing.Size(15, 14);
            this.checkboxPERMITIRCADASTROSERVICO.TabIndex = 14;
            this.checkboxPERMITIRCADASTROSERVICO.UseVisualStyleBackColor = true;
            this.checkboxPERMITIRCADASTROSERVICO.CheckedChanged += new System.EventHandler(this.checkboxPERMITIRCADASTROSERVICO_CheckedChanged);
            // 
            // textBoxVALORCADASTRO
            // 
            this.textBoxVALORCADASTRO.Location = new System.Drawing.Point(50, 85);
            this.textBoxVALORCADASTRO.MaxLength = 6;
            this.textBoxVALORCADASTRO.Name = "textBoxVALORCADASTRO";
            this.textBoxVALORCADASTRO.Size = new System.Drawing.Size(136, 20);
            this.textBoxVALORCADASTRO.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Valor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Serviço:";
            // 
            // labelCadastroserviço
            // 
            this.labelCadastroserviço.AutoSize = true;
            this.labelCadastroserviço.Location = new System.Drawing.Point(54, 8);
            this.labelCadastroserviço.Name = "labelCadastroserviço";
            this.labelCadastroserviço.Size = new System.Drawing.Size(91, 13);
            this.labelCadastroserviço.TabIndex = 8;
            this.labelCadastroserviço.Text = "Cadastrar Serviço";
            // 
            // textBoxSERVICOCADASTRO
            // 
            this.textBoxSERVICOCADASTRO.Location = new System.Drawing.Point(50, 57);
            this.textBoxSERVICOCADASTRO.Name = "textBoxSERVICOCADASTRO";
            this.textBoxSERVICOCADASTRO.Size = new System.Drawing.Size(136, 20);
            this.textBoxSERVICOCADASTRO.TabIndex = 2;
            // 
            // buttonCADASTROSERVICO
            // 
            this.buttonCADASTROSERVICO.Location = new System.Drawing.Point(76, 125);
            this.buttonCADASTROSERVICO.Name = "buttonCADASTROSERVICO";
            this.buttonCADASTROSERVICO.Size = new System.Drawing.Size(85, 35);
            this.buttonCADASTROSERVICO.TabIndex = 3;
            this.buttonCADASTROSERVICO.Text = "Cadastrar";
            this.buttonCADASTROSERVICO.UseVisualStyleBackColor = true;
            this.buttonCADASTROSERVICO.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBoxPESQUISATECNICO
            // 
            this.checkBoxPESQUISATECNICO.AutoSize = true;
            this.checkBoxPESQUISATECNICO.Location = new System.Drawing.Point(3, 22);
            this.checkBoxPESQUISATECNICO.Name = "checkBoxPESQUISATECNICO";
            this.checkBoxPESQUISATECNICO.Size = new System.Drawing.Size(70, 17);
            this.checkBoxPESQUISATECNICO.TabIndex = 7;
            this.checkBoxPESQUISATECNICO.Text = "Técnicos";
            this.checkBoxPESQUISATECNICO.UseVisualStyleBackColor = true;
            this.checkBoxPESQUISATECNICO.CheckedChanged += new System.EventHandler(this.checkBoxPESQUISATECNICO_CheckedChanged);
            // 
            // checkBoxPESQUISACLIENTES
            // 
            this.checkBoxPESQUISACLIENTES.AutoSize = true;
            this.checkBoxPESQUISACLIENTES.Location = new System.Drawing.Point(89, 22);
            this.checkBoxPESQUISACLIENTES.Name = "checkBoxPESQUISACLIENTES";
            this.checkBoxPESQUISACLIENTES.Size = new System.Drawing.Size(63, 17);
            this.checkBoxPESQUISACLIENTES.TabIndex = 8;
            this.checkBoxPESQUISACLIENTES.Text = "Clientes";
            this.checkBoxPESQUISACLIENTES.UseVisualStyleBackColor = true;
            this.checkBoxPESQUISACLIENTES.CheckedChanged += new System.EventHandler(this.checkBoxPESQUISACLIENTES_CheckedChanged);
            // 
            // FormCADASTRAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(611, 450);
            this.Controls.Add(this.panelSERVICO);
            this.Controls.Add(this.panelCLIENTE);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menustripPRINCIPAL);
            this.MainMenuStrip = this.menustripPRINCIPAL;
            this.Name = "FormCADASTRAR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCADASTRAR";
            this.Load += new System.EventHandler(this.FormCADASTRAR_Load);
            this.menustripPRINCIPAL.ResumeLayout(false);
            this.menustripPRINCIPAL.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPESSOAS)).EndInit();
            this.panelCLIENTE.ResumeLayout(false);
            this.panelCLIENTE.PerformLayout();
            this.panelSERVICO.ResumeLayout(false);
            this.panelSERVICO.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menustripPRINCIPAL;
        private System.Windows.Forms.ToolStripMenuItem principalmenustrip;
        private System.Windows.Forms.ToolStripMenuItem relatoriomenustrip;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelPCADASTRADAS;
        private System.Windows.Forms.DataGridView dataGridPESSOAS;
        private System.Windows.Forms.Panel panelCLIENTE;
        private System.Windows.Forms.TextBox textBoxCADASTROLOGIN;
        private System.Windows.Forms.TextBox textBoxCADASTROSENHA;
        private System.Windows.Forms.Label labelSENHACADASTRO;
        private System.Windows.Forms.Label labelLOGINCADASTRO;
        private System.Windows.Forms.Label labelNOMECADASTRO;
        private System.Windows.Forms.Label labelCadastro;
        private System.Windows.Forms.CheckBox checkBoxTECNICO;
        private System.Windows.Forms.CheckBox checkBoxUSUARIO;
        private System.Windows.Forms.Button buttonPESQUISACLIENTE;
        private System.Windows.Forms.TextBox textBoxPESQUISACADASTRO;
        private System.Windows.Forms.TextBox textBoxCADASTRONOME;
        private System.Windows.Forms.Button buttonCONFIRMCLIENTE;
        private System.Windows.Forms.CheckBox checkBoxADM;
        private System.Windows.Forms.Panel panelSERVICO;
        private System.Windows.Forms.TextBox textBoxVALORCADASTRO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelCadastroserviço;
        private System.Windows.Forms.TextBox textBoxSERVICOCADASTRO;
        private System.Windows.Forms.Button buttonCADASTROSERVICO;
        private System.Windows.Forms.TextBox textBoxCONTATO;
        private System.Windows.Forms.Label labelCONTATO;
        private System.Windows.Forms.CheckBox checkboxPERMITIRCADASTROSERVICO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxPESQUISACLIENTES;
        private System.Windows.Forms.CheckBox checkBoxPESQUISATECNICO;
    }
}