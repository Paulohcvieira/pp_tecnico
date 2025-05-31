namespace UC12_projetoPP
{
    partial class FormTELA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTELA));
            this.dataGridCLIENTE = new System.Windows.Forms.DataGridView();
            this.dataGridORCAMENTO = new System.Windows.Forms.DataGridView();
            this.buttonADICIONAR = new System.Windows.Forms.Button();
            this.buttonRETIRAR = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrarmenustrip = new System.Windows.Forms.ToolStripMenuItem();
            this.relatoriomenustrip = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.comboBoxCLIENTES = new System.Windows.Forms.ComboBox();
            this.labelSELECIONECLIENTE = new System.Windows.Forms.Label();
            this.buttonSTARTVENDA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCLIENTE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridORCAMENTO)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridCLIENTE
            // 
            this.dataGridCLIENTE.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dataGridCLIENTE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCLIENTE.Location = new System.Drawing.Point(24, 147);
            this.dataGridCLIENTE.Name = "dataGridCLIENTE";
            this.dataGridCLIENTE.Size = new System.Drawing.Size(240, 245);
            this.dataGridCLIENTE.TabIndex = 0;
            this.dataGridCLIENTE.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCLIENTE_CellContentClick);
            // 
            // dataGridORCAMENTO
            // 
            this.dataGridORCAMENTO.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dataGridORCAMENTO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridORCAMENTO.Location = new System.Drawing.Point(377, 143);
            this.dataGridORCAMENTO.Name = "dataGridORCAMENTO";
            this.dataGridORCAMENTO.Size = new System.Drawing.Size(240, 245);
            this.dataGridORCAMENTO.TabIndex = 1;
            // 
            // buttonADICIONAR
            // 
            this.buttonADICIONAR.Location = new System.Drawing.Point(283, 258);
            this.buttonADICIONAR.Name = "buttonADICIONAR";
            this.buttonADICIONAR.Size = new System.Drawing.Size(75, 31);
            this.buttonADICIONAR.TabIndex = 7;
            this.buttonADICIONAR.Text = "Adicionar >";
            this.buttonADICIONAR.UseVisualStyleBackColor = true;
            this.buttonADICIONAR.Click += new System.EventHandler(this.buttonADICIONAR_Click);
            // 
            // buttonRETIRAR
            // 
            this.buttonRETIRAR.Location = new System.Drawing.Point(283, 320);
            this.buttonRETIRAR.Name = "buttonRETIRAR";
            this.buttonRETIRAR.Size = new System.Drawing.Size(75, 32);
            this.buttonRETIRAR.TabIndex = 8;
            this.buttonRETIRAR.Text = "< Retirar";
            this.buttonRETIRAR.UseVisualStyleBackColor = true;
            this.buttonRETIRAR.Click += new System.EventHandler(this.buttonRETIRAR_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarmenustrip,
            this.relatoriomenustrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(637, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrarmenustrip
            // 
            this.cadastrarmenustrip.Name = "cadastrarmenustrip";
            this.cadastrarmenustrip.Size = new System.Drawing.Size(69, 20);
            this.cadastrarmenustrip.Text = "Cadastrar";
            this.cadastrarmenustrip.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
            // 
            // relatoriomenustrip
            // 
            this.relatoriomenustrip.Name = "relatoriomenustrip";
            this.relatoriomenustrip.Size = new System.Drawing.Size(66, 20);
            this.relatoriomenustrip.Text = "Relatório";
            this.relatoriomenustrip.Click += new System.EventHandler(this.relatoriomenustrip_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // comboBoxCLIENTES
            // 
            this.comboBoxCLIENTES.FormattingEnabled = true;
            this.comboBoxCLIENTES.Location = new System.Drawing.Point(24, 120);
            this.comboBoxCLIENTES.Name = "comboBoxCLIENTES";
            this.comboBoxCLIENTES.Size = new System.Drawing.Size(240, 21);
            this.comboBoxCLIENTES.TabIndex = 10;
            this.comboBoxCLIENTES.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelSELECIONECLIENTE
            // 
            this.labelSELECIONECLIENTE.AutoSize = true;
            this.labelSELECIONECLIENTE.Location = new System.Drawing.Point(21, 104);
            this.labelSELECIONECLIENTE.Name = "labelSELECIONECLIENTE";
            this.labelSELECIONECLIENTE.Size = new System.Drawing.Size(98, 13);
            this.labelSELECIONECLIENTE.TabIndex = 11;
            this.labelSELECIONECLIENTE.Text = "Selecione o Cliente";
            // 
            // buttonSTARTVENDA
            // 
            this.buttonSTARTVENDA.Location = new System.Drawing.Point(283, 120);
            this.buttonSTARTVENDA.Name = "buttonSTARTVENDA";
            this.buttonSTARTVENDA.Size = new System.Drawing.Size(75, 37);
            this.buttonSTARTVENDA.TabIndex = 12;
            this.buttonSTARTVENDA.Text = "Iniciar Venda";
            this.buttonSTARTVENDA.UseVisualStyleBackColor = true;
            this.buttonSTARTVENDA.Click += new System.EventHandler(this.buttonSTARTVENDA_Click);
            // 
            // FormTELA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::UC12_projetoPP.Properties.Resources.Sem_título;
            this.ClientSize = new System.Drawing.Size(637, 476);
            this.Controls.Add(this.buttonSTARTVENDA);
            this.Controls.Add(this.labelSELECIONECLIENTE);
            this.Controls.Add(this.comboBoxCLIENTES);
            this.Controls.Add(this.buttonRETIRAR);
            this.Controls.Add(this.buttonADICIONAR);
            this.Controls.Add(this.dataGridORCAMENTO);
            this.Controls.Add(this.dataGridCLIENTE);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTELA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de Venda";
            this.Load += new System.EventHandler(this.FormTELA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCLIENTE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridORCAMENTO)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridCLIENTE;
        private System.Windows.Forms.DataGridView dataGridORCAMENTO;
        private System.Windows.Forms.Button buttonADICIONAR;
        private System.Windows.Forms.Button buttonRETIRAR;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarmenustrip;
        private System.Windows.Forms.ToolStripMenuItem relatoriomenustrip;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox comboBoxCLIENTES;
        private System.Windows.Forms.Label labelSELECIONECLIENTE;
        private System.Windows.Forms.Button buttonSTARTVENDA;
    }
}