namespace UC12_projetoPP
{
    partial class FormLOGIN
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLOGIN));
            this.textBoxLOGIN = new System.Windows.Forms.TextBox();
            this.textBoxSENHA = new System.Windows.Forms.TextBox();
            this.buttonCONFIRMAR = new System.Windows.Forms.Button();
            this.labelLOGIN = new System.Windows.Forms.Label();
            this.labelSENHA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxLOGIN
            // 
            this.textBoxLOGIN.Location = new System.Drawing.Point(249, 122);
            this.textBoxLOGIN.Name = "textBoxLOGIN";
            this.textBoxLOGIN.Size = new System.Drawing.Size(100, 20);
            this.textBoxLOGIN.TabIndex = 0;
            this.textBoxLOGIN.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxSENHA
            // 
            this.textBoxSENHA.Location = new System.Drawing.Point(249, 196);
            this.textBoxSENHA.Name = "textBoxSENHA";
            this.textBoxSENHA.Size = new System.Drawing.Size(100, 20);
            this.textBoxSENHA.TabIndex = 1;
            // 
            // buttonCONFIRMAR
            // 
            this.buttonCONFIRMAR.BackColor = System.Drawing.Color.White;
            this.buttonCONFIRMAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonCONFIRMAR.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.buttonCONFIRMAR.FlatAppearance.BorderSize = 10;
            this.buttonCONFIRMAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.buttonCONFIRMAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonCONFIRMAR.Location = new System.Drawing.Point(249, 253);
            this.buttonCONFIRMAR.Name = "buttonCONFIRMAR";
            this.buttonCONFIRMAR.Size = new System.Drawing.Size(100, 40);
            this.buttonCONFIRMAR.TabIndex = 2;
            this.buttonCONFIRMAR.Text = "Confirmar";
            this.buttonCONFIRMAR.UseVisualStyleBackColor = false;
            this.buttonCONFIRMAR.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelLOGIN
            // 
            this.labelLOGIN.AutoSize = true;
            this.labelLOGIN.BackColor = System.Drawing.Color.Transparent;
            this.labelLOGIN.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.labelLOGIN.ForeColor = System.Drawing.Color.White;
            this.labelLOGIN.Location = new System.Drawing.Point(249, 103);
            this.labelLOGIN.Name = "labelLOGIN";
            this.labelLOGIN.Size = new System.Drawing.Size(45, 19);
            this.labelLOGIN.TabIndex = 3;
            this.labelLOGIN.Text = "Login";
            // 
            // labelSENHA
            // 
            this.labelSENHA.AutoSize = true;
            this.labelSENHA.BackColor = System.Drawing.Color.Transparent;
            this.labelSENHA.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSENHA.ForeColor = System.Drawing.Color.White;
            this.labelSENHA.Location = new System.Drawing.Point(248, 174);
            this.labelSENHA.Name = "labelSENHA";
            this.labelSENHA.Size = new System.Drawing.Size(53, 19);
            this.labelSENHA.TabIndex = 4;
            this.labelSENHA.Text = "Senha";
            // 
            // FormLOGIN
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.BackgroundImage = global::UC12_projetoPP.Properties.Resources.bg_login;
            this.ClientSize = new System.Drawing.Size(614, 431);
            this.Controls.Add(this.labelSENHA);
            this.Controls.Add(this.labelLOGIN);
            this.Controls.Add(this.buttonCONFIRMAR);
            this.Controls.Add(this.textBoxSENHA);
            this.Controls.Add(this.textBoxLOGIN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLOGIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLOGIN;
        private System.Windows.Forms.TextBox textBoxSENHA;
        private System.Windows.Forms.Button buttonCONFIRMAR;
        private System.Windows.Forms.Label labelLOGIN;
        private System.Windows.Forms.Label labelSENHA;
    }
}

