namespace Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mensagem));
            this.btn2 = new MetroFramework.Controls.MetroButton();
            this.btn1 = new MetroFramework.Controls.MetroButton();
            this.lblTexto = new MetroFramework.Controls.MetroLabel();
            this.lblTitulo = new MetroFramework.Controls.MetroLabel();
            this.pnTopo = new System.Windows.Forms.Panel();
            this.pnTopo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(256, 159);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(67, 23);
            this.btn2.TabIndex = 49;
            this.btn2.Text = "Não";
            this.btn2.UseSelectable = true;
            this.btn2.Click += new System.EventHandler(this.txtNão_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(183, 159);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(67, 23);
            this.btn1.TabIndex = 49;
            this.btn1.Text = "Sim";
            this.btn1.UseSelectable = true;
            this.btn1.Click += new System.EventHandler(this.btnSim_Click);
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.BackColor = System.Drawing.Color.Transparent;
            this.lblTexto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTexto.Location = new System.Drawing.Point(28, 65);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(38, 19);
            this.lblTexto.TabIndex = 1;
            this.lblTexto.Text = "texto";
            this.lblTexto.UseCustomBackColor = true;
            this.lblTexto.UseCustomForeColor = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTitulo.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitulo.Location = new System.Drawing.Point(28, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(62, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Título";
            this.lblTitulo.UseCustomBackColor = true;
            this.lblTitulo.UseCustomForeColor = true;
            // 
            // pnTopo
            // 
            this.pnTopo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnTopo.AutoSize = true;
            this.pnTopo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(9)))), ((int)(((byte)(65)))));
            this.pnTopo.Controls.Add(this.btn2);
            this.pnTopo.Controls.Add(this.btn1);
            this.pnTopo.Controls.Add(this.lblTexto);
            this.pnTopo.Controls.Add(this.lblTitulo);
            this.pnTopo.Location = new System.Drawing.Point(-5, -5);
            this.pnTopo.Name = "pnTopo";
            this.pnTopo.Size = new System.Drawing.Size(350, 210);
            this.pnTopo.TabIndex = 48;
            // 
            // Mensagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 200);
            this.Controls.Add(this.pnTopo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mensagem";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Mensagem_Load);
            this.pnTopo.ResumeLayout(false);
            this.pnTopo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btn2;
        private MetroFramework.Controls.MetroButton btn1;
        private MetroFramework.Controls.MetroLabel lblTexto;
        private MetroFramework.Controls.MetroLabel lblTitulo;
        private System.Windows.Forms.Panel pnTopo;

    }
}