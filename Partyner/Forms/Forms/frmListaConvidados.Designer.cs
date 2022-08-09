namespace Forms
{
    partial class frmListaConvidados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaConvidados));
            this.btnCarregarEvento = new MetroFramework.Controls.MetroButton();
            this.cmbEvento = new MetroFramework.Controls.MetroComboBox();
            this.btnPesquisarPresente = new MetroFramework.Controls.MetroButton();
            this.txtPesquisaPresente = new MetroFramework.Controls.MetroTextBox();
            this.dgvConvidadosPresentes = new MetroFramework.Controls.MetroGrid();
            this.btnPesquisar = new MetroFramework.Controls.MetroButton();
            this.txtPesquisa = new MetroFramework.Controls.MetroTextBox();
            this.dgvConvidados = new MetroFramework.Controls.MetroGrid();
            this.btnCarregarPresenca = new MetroFramework.Controls.MetroButton();
            this.btnDesfazerPresenca = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblAlerta = new MetroFramework.Controls.MetroLabel();
            this.pnTopo = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConvidadosPresentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConvidados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCarregarEvento
            // 
            this.btnCarregarEvento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCarregarEvento.Location = new System.Drawing.Point(1243, 73);
            this.btnCarregarEvento.Name = "btnCarregarEvento";
            this.btnCarregarEvento.Size = new System.Drawing.Size(100, 29);
            this.btnCarregarEvento.TabIndex = 57;
            this.btnCarregarEvento.Text = "Carregar Evento";
            this.btnCarregarEvento.UseSelectable = true;
            this.btnCarregarEvento.Click += new System.EventHandler(this.btnCarregarEvento_Click);
            // 
            // cmbEvento
            // 
            this.cmbEvento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbEvento.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbEvento.FormattingEnabled = true;
            this.cmbEvento.ItemHeight = 23;
            this.cmbEvento.Location = new System.Drawing.Point(23, 73);
            this.cmbEvento.Name = "cmbEvento";
            this.cmbEvento.Size = new System.Drawing.Size(1214, 29);
            this.cmbEvento.Style = MetroFramework.MetroColorStyle.Red;
            this.cmbEvento.TabIndex = 56;
            this.cmbEvento.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cmbEvento.UseSelectable = true;
            // 
            // btnPesquisarPresente
            // 
            this.btnPesquisarPresente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPesquisarPresente.Location = new System.Drawing.Point(1243, 162);
            this.btnPesquisarPresente.Name = "btnPesquisarPresente";
            this.btnPesquisarPresente.Size = new System.Drawing.Size(100, 29);
            this.btnPesquisarPresente.TabIndex = 55;
            this.btnPesquisarPresente.Text = "Pesquisar";
            this.btnPesquisarPresente.UseSelectable = true;
            this.btnPesquisarPresente.Click += new System.EventHandler(this.btnPesquisarPresente_Click);
            // 
            // txtPesquisaPresente
            // 
            this.txtPesquisaPresente.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txtPesquisaPresente.CustomButton.Image = null;
            this.txtPesquisaPresente.CustomButton.Location = new System.Drawing.Point(504, 1);
            this.txtPesquisaPresente.CustomButton.Name = "";
            this.txtPesquisaPresente.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtPesquisaPresente.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPesquisaPresente.CustomButton.TabIndex = 1;
            this.txtPesquisaPresente.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPesquisaPresente.CustomButton.UseSelectable = true;
            this.txtPesquisaPresente.CustomButton.Visible = false;
            this.txtPesquisaPresente.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtPesquisaPresente.Lines = new string[0];
            this.txtPesquisaPresente.Location = new System.Drawing.Point(705, 162);
            this.txtPesquisaPresente.MaxLength = 32767;
            this.txtPesquisaPresente.Name = "txtPesquisaPresente";
            this.txtPesquisaPresente.PasswordChar = '\0';
            this.txtPesquisaPresente.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPesquisaPresente.SelectedText = "";
            this.txtPesquisaPresente.SelectionLength = 0;
            this.txtPesquisaPresente.SelectionStart = 0;
            this.txtPesquisaPresente.ShortcutsEnabled = true;
            this.txtPesquisaPresente.Size = new System.Drawing.Size(532, 29);
            this.txtPesquisaPresente.Style = MetroFramework.MetroColorStyle.Red;
            this.txtPesquisaPresente.TabIndex = 54;
            this.txtPesquisaPresente.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtPesquisaPresente.UseSelectable = true;
            this.txtPesquisaPresente.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPesquisaPresente.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dgvConvidadosPresentes
            // 
            this.dgvConvidadosPresentes.AllowUserToAddRows = false;
            this.dgvConvidadosPresentes.AllowUserToDeleteRows = false;
            this.dgvConvidadosPresentes.AllowUserToResizeRows = false;
            this.dgvConvidadosPresentes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvConvidadosPresentes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvConvidadosPresentes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvConvidadosPresentes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvConvidadosPresentes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConvidadosPresentes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConvidadosPresentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvConvidadosPresentes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvConvidadosPresentes.EnableHeadersVisualStyles = false;
            this.dgvConvidadosPresentes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvConvidadosPresentes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvConvidadosPresentes.Location = new System.Drawing.Point(705, 211);
            this.dgvConvidadosPresentes.Name = "dgvConvidadosPresentes";
            this.dgvConvidadosPresentes.ReadOnly = true;
            this.dgvConvidadosPresentes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConvidadosPresentes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvConvidadosPresentes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvConvidadosPresentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConvidadosPresentes.Size = new System.Drawing.Size(638, 484);
            this.dgvConvidadosPresentes.Style = MetroFramework.MetroColorStyle.Red;
            this.dgvConvidadosPresentes.TabIndex = 53;
            this.dgvConvidadosPresentes.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dgvConvidadosPresentes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConvidadosPresentes_CellClick);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPesquisar.Location = new System.Drawing.Point(561, 162);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(100, 29);
            this.btnPesquisar.TabIndex = 52;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseSelectable = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txtPesquisa.CustomButton.Image = null;
            this.txtPesquisa.CustomButton.Location = new System.Drawing.Point(504, 1);
            this.txtPesquisa.CustomButton.Name = "";
            this.txtPesquisa.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtPesquisa.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPesquisa.CustomButton.TabIndex = 1;
            this.txtPesquisa.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPesquisa.CustomButton.UseSelectable = true;
            this.txtPesquisa.CustomButton.Visible = false;
            this.txtPesquisa.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtPesquisa.Lines = new string[0];
            this.txtPesquisa.Location = new System.Drawing.Point(23, 162);
            this.txtPesquisa.MaxLength = 32767;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.PasswordChar = '\0';
            this.txtPesquisa.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPesquisa.SelectedText = "";
            this.txtPesquisa.SelectionLength = 0;
            this.txtPesquisa.SelectionStart = 0;
            this.txtPesquisa.ShortcutsEnabled = true;
            this.txtPesquisa.Size = new System.Drawing.Size(532, 29);
            this.txtPesquisa.Style = MetroFramework.MetroColorStyle.Red;
            this.txtPesquisa.TabIndex = 51;
            this.txtPesquisa.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtPesquisa.UseSelectable = true;
            this.txtPesquisa.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPesquisa.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dgvConvidados
            // 
            this.dgvConvidados.AllowUserToAddRows = false;
            this.dgvConvidados.AllowUserToDeleteRows = false;
            this.dgvConvidados.AllowUserToResizeRows = false;
            this.dgvConvidados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvConvidados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvConvidados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvConvidados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvConvidados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConvidados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvConvidados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvConvidados.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvConvidados.EnableHeadersVisualStyles = false;
            this.dgvConvidados.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvConvidados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvConvidados.Location = new System.Drawing.Point(23, 211);
            this.dgvConvidados.Name = "dgvConvidados";
            this.dgvConvidados.ReadOnly = true;
            this.dgvConvidados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConvidados.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvConvidados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvConvidados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConvidados.Size = new System.Drawing.Size(638, 484);
            this.dgvConvidados.Style = MetroFramework.MetroColorStyle.Red;
            this.dgvConvidados.TabIndex = 50;
            this.dgvConvidados.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dgvConvidados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConvidados_CellClick);
            // 
            // btnCarregarPresenca
            // 
            this.btnCarregarPresenca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCarregarPresenca.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnCarregarPresenca.Location = new System.Drawing.Point(23, 701);
            this.btnCarregarPresenca.Name = "btnCarregarPresenca";
            this.btnCarregarPresenca.Size = new System.Drawing.Size(638, 44);
            this.btnCarregarPresenca.TabIndex = 58;
            this.btnCarregarPresenca.Text = "Marcar Presença";
            this.btnCarregarPresenca.UseSelectable = true;
            this.btnCarregarPresenca.Click += new System.EventHandler(this.btnCarregarPresenca_Click);
            // 
            // btnDesfazerPresenca
            // 
            this.btnDesfazerPresenca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDesfazerPresenca.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnDesfazerPresenca.Location = new System.Drawing.Point(705, 701);
            this.btnDesfazerPresenca.Name = "btnDesfazerPresenca";
            this.btnDesfazerPresenca.Size = new System.Drawing.Size(638, 44);
            this.btnDesfazerPresenca.TabIndex = 59;
            this.btnDesfazerPresenca.Text = "Desfazer Presença";
            this.btnDesfazerPresenca.UseSelectable = true;
            this.btnDesfazerPresenca.Click += new System.EventHandler(this.btnDesfazerPresenca_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(692, 37);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(0, 0);
            this.metroLabel1.TabIndex = 61;
            // 
            // lblAlerta
            // 
            this.lblAlerta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAlerta.AutoSize = true;
            this.lblAlerta.Location = new System.Drawing.Point(23, 105);
            this.lblAlerta.Name = "lblAlerta";
            this.lblAlerta.Size = new System.Drawing.Size(44, 19);
            this.lblAlerta.TabIndex = 62;
            this.lblAlerta.Text = "Alerta";
            this.lblAlerta.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblAlerta.Visible = false;
            // 
            // pnTopo
            // 
            this.pnTopo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnTopo.AutoSize = true;
            this.pnTopo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(9)))), ((int)(((byte)(65)))));
            this.pnTopo.Location = new System.Drawing.Point(-7, -5);
            this.pnTopo.Name = "pnTopo";
            this.pnTopo.Size = new System.Drawing.Size(1380, 10);
            this.pnTopo.TabIndex = 63;
            // 
            // frmListaConvidados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.pnTopo);
            this.Controls.Add(this.lblAlerta);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnDesfazerPresenca);
            this.Controls.Add(this.btnCarregarPresenca);
            this.Controls.Add(this.btnCarregarEvento);
            this.Controls.Add(this.cmbEvento);
            this.Controls.Add(this.btnPesquisarPresente);
            this.Controls.Add(this.txtPesquisaPresente);
            this.Controls.Add(this.dgvConvidadosPresentes);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.dgvConvidados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListaConvidados";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Lista Convidados";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmListaConvidados_FormClosed);
            this.Load += new System.EventHandler(this.frmListaConvidados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConvidadosPresentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConvidados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnCarregarEvento;
        private MetroFramework.Controls.MetroComboBox cmbEvento;
        private MetroFramework.Controls.MetroButton btnPesquisarPresente;
        private MetroFramework.Controls.MetroTextBox txtPesquisaPresente;
        private MetroFramework.Controls.MetroGrid dgvConvidadosPresentes;
        private MetroFramework.Controls.MetroButton btnPesquisar;
        private MetroFramework.Controls.MetroTextBox txtPesquisa;
        private MetroFramework.Controls.MetroGrid dgvConvidados;
        private MetroFramework.Controls.MetroButton btnCarregarPresenca;
        private MetroFramework.Controls.MetroButton btnDesfazerPresenca;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lblAlerta;
        private System.Windows.Forms.Panel pnTopo;
    }
}