namespace Forms
{
    partial class frmAdicionais
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdicionais));
            this.pnTopo = new System.Windows.Forms.Panel();
            this.txtNomeAdic = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtPrecoAdic = new MetroFramework.Controls.MetroTextBox();
            this.cmbTipoPesquisa = new MetroFramework.Controls.MetroComboBox();
            this.txtPesquisa = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.btnExcluir = new MetroFramework.Controls.MetroButton();
            this.btnEditar = new MetroFramework.Controls.MetroButton();
            this.btnCadastrar = new MetroFramework.Controls.MetroButton();
            this.dgvAdicionais = new MetroFramework.Controls.MetroGrid();
            this.btnPesquisar = new MetroFramework.Controls.MetroButton();
            this.tAlerta = new System.Windows.Forms.Timer(this.components);
            this.mpAlerta = new MetroFramework.Controls.MetroPanel();
            this.lblAlerta = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdicionais)).BeginInit();
            this.mpAlerta.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTopo
            // 
            this.pnTopo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnTopo.AutoSize = true;
            this.pnTopo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(9)))), ((int)(((byte)(65)))));
            this.pnTopo.Location = new System.Drawing.Point(-1, -5);
            this.pnTopo.Name = "pnTopo";
            this.pnTopo.Size = new System.Drawing.Size(1387, 10);
            this.pnTopo.TabIndex = 48;
            // 
            // txtNomeAdic
            // 
            this.txtNomeAdic.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txtNomeAdic.CustomButton.Image = null;
            this.txtNomeAdic.CustomButton.Location = new System.Drawing.Point(278, 1);
            this.txtNomeAdic.CustomButton.Name = "";
            this.txtNomeAdic.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtNomeAdic.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNomeAdic.CustomButton.TabIndex = 1;
            this.txtNomeAdic.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNomeAdic.CustomButton.UseSelectable = true;
            this.txtNomeAdic.CustomButton.Visible = false;
            this.txtNomeAdic.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtNomeAdic.Lines = new string[0];
            this.txtNomeAdic.Location = new System.Drawing.Point(23, 116);
            this.txtNomeAdic.MaxLength = 32767;
            this.txtNomeAdic.Name = "txtNomeAdic";
            this.txtNomeAdic.PasswordChar = '\0';
            this.txtNomeAdic.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNomeAdic.SelectedText = "";
            this.txtNomeAdic.SelectionLength = 0;
            this.txtNomeAdic.SelectionStart = 0;
            this.txtNomeAdic.ShortcutsEnabled = true;
            this.txtNomeAdic.Size = new System.Drawing.Size(306, 29);
            this.txtNomeAdic.Style = MetroFramework.MetroColorStyle.Red;
            this.txtNomeAdic.TabIndex = 49;
            this.txtNomeAdic.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtNomeAdic.UseSelectable = true;
            this.txtNomeAdic.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNomeAdic.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel1.Location = new System.Drawing.Point(23, 94);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(46, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel1.TabIndex = 50;
            this.metroLabel1.Text = "Nome";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // txtPrecoAdic
            // 
            this.txtPrecoAdic.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txtPrecoAdic.CustomButton.Image = null;
            this.txtPrecoAdic.CustomButton.Location = new System.Drawing.Point(278, 1);
            this.txtPrecoAdic.CustomButton.Name = "";
            this.txtPrecoAdic.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtPrecoAdic.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrecoAdic.CustomButton.TabIndex = 1;
            this.txtPrecoAdic.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrecoAdic.CustomButton.UseSelectable = true;
            this.txtPrecoAdic.CustomButton.Visible = false;
            this.txtPrecoAdic.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtPrecoAdic.Lines = new string[0];
            this.txtPrecoAdic.Location = new System.Drawing.Point(23, 170);
            this.txtPrecoAdic.MaxLength = 32767;
            this.txtPrecoAdic.Name = "txtPrecoAdic";
            this.txtPrecoAdic.PasswordChar = '\0';
            this.txtPrecoAdic.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrecoAdic.SelectedText = "";
            this.txtPrecoAdic.SelectionLength = 0;
            this.txtPrecoAdic.SelectionStart = 0;
            this.txtPrecoAdic.ShortcutsEnabled = true;
            this.txtPrecoAdic.Size = new System.Drawing.Size(306, 29);
            this.txtPrecoAdic.Style = MetroFramework.MetroColorStyle.Red;
            this.txtPrecoAdic.TabIndex = 51;
            this.txtPrecoAdic.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtPrecoAdic.UseSelectable = true;
            this.txtPrecoAdic.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrecoAdic.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cmbTipoPesquisa
            // 
            this.cmbTipoPesquisa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbTipoPesquisa.FormattingEnabled = true;
            this.cmbTipoPesquisa.ItemHeight = 23;
            this.cmbTipoPesquisa.Items.AddRange(new object[] {
            "nome",
            "preço"});
            this.cmbTipoPesquisa.Location = new System.Drawing.Point(362, 116);
            this.cmbTipoPesquisa.Name = "cmbTipoPesquisa";
            this.cmbTipoPesquisa.Size = new System.Drawing.Size(153, 29);
            this.cmbTipoPesquisa.Style = MetroFramework.MetroColorStyle.Red;
            this.cmbTipoPesquisa.TabIndex = 53;
            this.cmbTipoPesquisa.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cmbTipoPesquisa.UseSelectable = true;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txtPesquisa.CustomButton.Image = null;
            this.txtPesquisa.CustomButton.Location = new System.Drawing.Point(688, 1);
            this.txtPesquisa.CustomButton.Name = "";
            this.txtPesquisa.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtPesquisa.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPesquisa.CustomButton.TabIndex = 1;
            this.txtPesquisa.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPesquisa.CustomButton.UseSelectable = true;
            this.txtPesquisa.CustomButton.Visible = false;
            this.txtPesquisa.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtPesquisa.Lines = new string[0];
            this.txtPesquisa.Location = new System.Drawing.Point(521, 116);
            this.txtPesquisa.MaxLength = 32767;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.PasswordChar = '\0';
            this.txtPesquisa.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPesquisa.SelectedText = "";
            this.txtPesquisa.SelectionLength = 0;
            this.txtPesquisa.SelectionStart = 0;
            this.txtPesquisa.ShortcutsEnabled = true;
            this.txtPesquisa.Size = new System.Drawing.Size(716, 29);
            this.txtPesquisa.Style = MetroFramework.MetroColorStyle.Red;
            this.txtPesquisa.TabIndex = 54;
            this.txtPesquisa.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtPesquisa.UseSelectable = true;
            this.txtPesquisa.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPesquisa.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel2.Location = new System.Drawing.Point(23, 148);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(43, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel2.TabIndex = 55;
            this.metroLabel2.Text = "Preço";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel5.Location = new System.Drawing.Point(362, 94);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(89, 19);
            this.metroLabel5.TabIndex = 56;
            this.metroLabel5.Text = "Pesquisar por";
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Location = new System.Drawing.Point(233, 629);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 35);
            this.btnExcluir.Style = MetroFramework.MetroColorStyle.Red;
            this.btnExcluir.TabIndex = 60;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseSelectable = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditar.Enabled = false;
            this.btnEditar.Location = new System.Drawing.Point(133, 629);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(94, 35);
            this.btnEditar.Style = MetroFramework.MetroColorStyle.Red;
            this.btnEditar.TabIndex = 59;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseSelectable = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCadastrar.Location = new System.Drawing.Point(27, 629);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(100, 35);
            this.btnCadastrar.Style = MetroFramework.MetroColorStyle.Red;
            this.btnCadastrar.TabIndex = 58;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseSelectable = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // dgvAdicionais
            // 
            this.dgvAdicionais.AllowUserToAddRows = false;
            this.dgvAdicionais.AllowUserToDeleteRows = false;
            this.dgvAdicionais.AllowUserToResizeRows = false;
            this.dgvAdicionais.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvAdicionais.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvAdicionais.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAdicionais.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvAdicionais.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAdicionais.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAdicionais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAdicionais.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAdicionais.EnableHeadersVisualStyles = false;
            this.dgvAdicionais.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvAdicionais.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvAdicionais.Location = new System.Drawing.Point(362, 170);
            this.dgvAdicionais.Name = "dgvAdicionais";
            this.dgvAdicionais.ReadOnly = true;
            this.dgvAdicionais.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAdicionais.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAdicionais.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAdicionais.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdicionais.Size = new System.Drawing.Size(981, 494);
            this.dgvAdicionais.Style = MetroFramework.MetroColorStyle.Red;
            this.dgvAdicionais.TabIndex = 61;
            this.dgvAdicionais.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dgvAdicionais.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdicionais_CellClick);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPesquisar.Location = new System.Drawing.Point(1243, 116);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(100, 29);
            this.btnPesquisar.Style = MetroFramework.MetroColorStyle.Red;
            this.btnPesquisar.TabIndex = 62;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseSelectable = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // tAlerta
            // 
            this.tAlerta.Interval = 1000;
            this.tAlerta.Tick += new System.EventHandler(this.tAlerta_Tick);
            // 
            // mpAlerta
            // 
            this.mpAlerta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mpAlerta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(9)))), ((int)(((byte)(65)))));
            this.mpAlerta.Controls.Add(this.lblAlerta);
            this.mpAlerta.HorizontalScrollbarBarColor = true;
            this.mpAlerta.HorizontalScrollbarHighlightOnWheel = false;
            this.mpAlerta.HorizontalScrollbarSize = 10;
            this.mpAlerta.Location = new System.Drawing.Point(23, 174);
            this.mpAlerta.Name = "mpAlerta";
            this.mpAlerta.Size = new System.Drawing.Size(306, 24);
            this.mpAlerta.TabIndex = 63;
            this.mpAlerta.UseCustomBackColor = true;
            this.mpAlerta.VerticalScrollbarBarColor = true;
            this.mpAlerta.VerticalScrollbarHighlightOnWheel = false;
            this.mpAlerta.VerticalScrollbarSize = 10;
            // 
            // lblAlerta
            // 
            this.lblAlerta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAlerta.AutoSize = true;
            this.lblAlerta.BackColor = System.Drawing.Color.Transparent;
            this.lblAlerta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAlerta.Location = new System.Drawing.Point(2, 2);
            this.lblAlerta.Name = "lblAlerta";
            this.lblAlerta.Size = new System.Drawing.Size(47, 19);
            this.lblAlerta.Style = MetroFramework.MetroColorStyle.Red;
            this.lblAlerta.TabIndex = 46;
            this.lblAlerta.Text = "Alerta:";
            this.lblAlerta.UseCustomBackColor = true;
            this.lblAlerta.UseCustomForeColor = true;
            this.lblAlerta.Visible = false;
            // 
            // frmAdicionais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 730);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.dgvAdicionais);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.cmbTipoPesquisa);
            this.Controls.Add(this.txtPrecoAdic);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtNomeAdic);
            this.Controls.Add(this.pnTopo);
            this.Controls.Add(this.mpAlerta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdicionais";
            this.Text = "Gerenciar Adicionais";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAdicionais_FormClosed);
            this.Load += new System.EventHandler(this.frmAdicionais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdicionais)).EndInit();
            this.mpAlerta.ResumeLayout(false);
            this.mpAlerta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnTopo;
        private MetroFramework.Controls.MetroTextBox txtNomeAdic;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtPrecoAdic;
        private MetroFramework.Controls.MetroComboBox cmbTipoPesquisa;
        private MetroFramework.Controls.MetroTextBox txtPesquisa;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton btnExcluir;
        private MetroFramework.Controls.MetroButton btnEditar;
        private MetroFramework.Controls.MetroButton btnCadastrar;
        private MetroFramework.Controls.MetroGrid dgvAdicionais;
        private MetroFramework.Controls.MetroButton btnPesquisar;
        private System.Windows.Forms.Timer tAlerta;
        private MetroFramework.Controls.MetroPanel mpAlerta;
        private MetroFramework.Controls.MetroLabel lblAlerta;
    }
}