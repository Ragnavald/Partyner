namespace Forms
{
    partial class frmConvidado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConvidado));
            this.txtNomeConv = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cmbEvento = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btnCadastrar = new MetroFramework.Controls.MetroButton();
            this.btnEditar = new MetroFramework.Controls.MetroButton();
            this.btnExcluir = new MetroFramework.Controls.MetroButton();
            this.dgvConvidados = new MetroFramework.Controls.MetroGrid();
            this.btnPesquisar = new MetroFramework.Controls.MetroButton();
            this.txtPesquisa = new MetroFramework.Controls.MetroTextBox();
            this.tAlerta = new System.Windows.Forms.Timer(this.components);
            this.pnTopo = new System.Windows.Forms.Panel();
            this.cmbTipoPesquisa = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mpAlerta = new MetroFramework.Controls.MetroPanel();
            this.lblAlerta = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConvidados)).BeginInit();
            this.mpAlerta.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNomeConv
            // 
            this.txtNomeConv.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txtNomeConv.CustomButton.Image = null;
            this.txtNomeConv.CustomButton.Location = new System.Drawing.Point(278, 1);
            this.txtNomeConv.CustomButton.Name = "";
            this.txtNomeConv.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtNomeConv.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNomeConv.CustomButton.TabIndex = 1;
            this.txtNomeConv.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNomeConv.CustomButton.UseSelectable = true;
            this.txtNomeConv.CustomButton.Visible = false;
            this.txtNomeConv.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtNomeConv.Lines = new string[0];
            this.txtNomeConv.Location = new System.Drawing.Point(23, 170);
            this.txtNomeConv.MaxLength = 32767;
            this.txtNomeConv.Name = "txtNomeConv";
            this.txtNomeConv.PasswordChar = '\0';
            this.txtNomeConv.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNomeConv.SelectedText = "";
            this.txtNomeConv.SelectionLength = 0;
            this.txtNomeConv.SelectionStart = 0;
            this.txtNomeConv.ShortcutsEnabled = true;
            this.txtNomeConv.Size = new System.Drawing.Size(306, 29);
            this.txtNomeConv.Style = MetroFramework.MetroColorStyle.Red;
            this.txtNomeConv.TabIndex = 8;
            this.txtNomeConv.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtNomeConv.UseSelectable = true;
            this.txtNomeConv.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNomeConv.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel1.Location = new System.Drawing.Point(23, 148);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(46, 19);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Nome";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // cmbEvento
            // 
            this.cmbEvento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbEvento.FormattingEnabled = true;
            this.cmbEvento.ItemHeight = 23;
            this.cmbEvento.Location = new System.Drawing.Point(23, 116);
            this.cmbEvento.Name = "cmbEvento";
            this.cmbEvento.Size = new System.Drawing.Size(306, 29);
            this.cmbEvento.Style = MetroFramework.MetroColorStyle.Red;
            this.cmbEvento.TabIndex = 10;
            this.cmbEvento.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cmbEvento.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel3.Location = new System.Drawing.Point(23, 94);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(48, 19);
            this.metroLabel3.TabIndex = 12;
            this.metroLabel3.Text = "Evento";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCadastrar.Location = new System.Drawing.Point(28, 648);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(100, 35);
            this.btnCadastrar.TabIndex = 14;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseSelectable = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditar.Enabled = false;
            this.btnEditar.Location = new System.Drawing.Point(134, 648);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(94, 35);
            this.btnEditar.TabIndex = 15;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseSelectable = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Location = new System.Drawing.Point(234, 648);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 35);
            this.btnExcluir.TabIndex = 16;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseSelectable = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // dgvConvidados
            // 
            this.dgvConvidados.AllowUserToAddRows = false;
            this.dgvConvidados.AllowUserToDeleteRows = false;
            this.dgvConvidados.AllowUserToResizeRows = false;
            this.dgvConvidados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvConvidados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvConvidados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvConvidados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConvidados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConvidados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvConvidados.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvConvidados.EnableHeadersVisualStyles = false;
            this.dgvConvidados.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvConvidados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvConvidados.Location = new System.Drawing.Point(362, 170);
            this.dgvConvidados.Name = "dgvConvidados";
            this.dgvConvidados.ReadOnly = true;
            this.dgvConvidados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConvidados.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvConvidados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvConvidados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConvidados.Size = new System.Drawing.Size(981, 513);
            this.dgvConvidados.Style = MetroFramework.MetroColorStyle.Red;
            this.dgvConvidados.TabIndex = 18;
            this.dgvConvidados.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dgvConvidados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConvidados_CellClick);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPesquisar.Location = new System.Drawing.Point(1243, 116);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(100, 29);
            this.btnPesquisar.TabIndex = 43;
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
            this.txtPesquisa.TabIndex = 42;
            this.txtPesquisa.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtPesquisa.UseSelectable = true;
            this.txtPesquisa.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPesquisa.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tAlerta
            // 
            this.tAlerta.Interval = 1000;
            this.tAlerta.Tick += new System.EventHandler(this.tAlerta_Tick);
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
            this.pnTopo.TabIndex = 64;
            // 
            // cmbTipoPesquisa
            // 
            this.cmbTipoPesquisa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbTipoPesquisa.FormattingEnabled = true;
            this.cmbTipoPesquisa.ItemHeight = 23;
            this.cmbTipoPesquisa.Items.AddRange(new object[] {
            "nome",
            "cpf"});
            this.cmbTipoPesquisa.Location = new System.Drawing.Point(362, 116);
            this.cmbTipoPesquisa.Name = "cmbTipoPesquisa";
            this.cmbTipoPesquisa.Size = new System.Drawing.Size(153, 29);
            this.cmbTipoPesquisa.Style = MetroFramework.MetroColorStyle.Red;
            this.cmbTipoPesquisa.TabIndex = 66;
            this.cmbTipoPesquisa.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cmbTipoPesquisa.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel2.Location = new System.Drawing.Point(362, 94);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(89, 19);
            this.metroLabel2.TabIndex = 65;
            this.metroLabel2.Text = "Pesquisar por";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // mpAlerta
            // 
            this.mpAlerta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mpAlerta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(9)))), ((int)(((byte)(65)))));
            this.mpAlerta.Controls.Add(this.lblAlerta);
            this.mpAlerta.HorizontalScrollbarBarColor = true;
            this.mpAlerta.HorizontalScrollbarHighlightOnWheel = false;
            this.mpAlerta.HorizontalScrollbarSize = 10;
            this.mpAlerta.Location = new System.Drawing.Point(23, 175);
            this.mpAlerta.Name = "mpAlerta";
            this.mpAlerta.Size = new System.Drawing.Size(306, 24);
            this.mpAlerta.TabIndex = 67;
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
            // frmConvidado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 714);
            this.Controls.Add(this.cmbTipoPesquisa);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.pnTopo);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.dgvConvidados);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.cmbEvento);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtNomeConv);
            this.Controls.Add(this.mpAlerta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConvidado";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Gerenciar Convidados";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmConvidado_FormClosed);
            this.Load += new System.EventHandler(this.frmConvidado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConvidados)).EndInit();
            this.mpAlerta.ResumeLayout(false);
            this.mpAlerta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtNomeConv;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cmbEvento;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton btnCadastrar;
        private MetroFramework.Controls.MetroButton btnEditar;
        private MetroFramework.Controls.MetroButton btnExcluir;
        private MetroFramework.Controls.MetroGrid dgvConvidados;
        private MetroFramework.Controls.MetroButton btnPesquisar;
        private MetroFramework.Controls.MetroTextBox txtPesquisa;
        private System.Windows.Forms.Timer tAlerta;
        private System.Windows.Forms.Panel pnTopo;
        private MetroFramework.Controls.MetroComboBox cmbTipoPesquisa;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroPanel mpAlerta;
        private MetroFramework.Controls.MetroLabel lblAlerta;
    }
}