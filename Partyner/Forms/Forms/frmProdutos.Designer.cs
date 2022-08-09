namespace Forms
{
    partial class frmProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProdutos));
            this.pnTopo = new System.Windows.Forms.Panel();
            this.btnPesquisar = new MetroFramework.Controls.MetroButton();
            this.dgvProdutos = new MetroFramework.Controls.MetroGrid();
            this.btnExcluir = new MetroFramework.Controls.MetroButton();
            this.btnEditar = new MetroFramework.Controls.MetroButton();
            this.btnCadastrar = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtPesquisa = new MetroFramework.Controls.MetroTextBox();
            this.cmbTipoPesquisa = new MetroFramework.Controls.MetroComboBox();
            this.txtPrecoProd = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtNomeProd = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtCategoria = new MetroFramework.Controls.MetroTextBox();
            this.tAlerta = new System.Windows.Forms.Timer(this.components);
            this.mpAlerta = new MetroFramework.Controls.MetroPanel();
            this.lblAlerta = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
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
            this.pnTopo.TabIndex = 49;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPesquisar.Location = new System.Drawing.Point(1243, 102);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(100, 29);
            this.btnPesquisar.Style = MetroFramework.MetroColorStyle.Red;
            this.btnPesquisar.TabIndex = 75;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseSelectable = true;
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AllowUserToResizeRows = false;
            this.dgvProdutos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvProdutos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvProdutos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProdutos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvProdutos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProdutos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProdutos.EnableHeadersVisualStyles = false;
            this.dgvProdutos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvProdutos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvProdutos.Location = new System.Drawing.Point(362, 156);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProdutos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProdutos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(981, 494);
            this.dgvProdutos.Style = MetroFramework.MetroColorStyle.Red;
            this.dgvProdutos.TabIndex = 74;
            this.dgvProdutos.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dgvProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellClick);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Location = new System.Drawing.Point(233, 615);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 35);
            this.btnExcluir.Style = MetroFramework.MetroColorStyle.Red;
            this.btnExcluir.TabIndex = 73;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseSelectable = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditar.Enabled = false;
            this.btnEditar.Location = new System.Drawing.Point(133, 615);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(94, 35);
            this.btnEditar.Style = MetroFramework.MetroColorStyle.Red;
            this.btnEditar.TabIndex = 72;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseSelectable = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCadastrar.Location = new System.Drawing.Point(27, 615);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(100, 35);
            this.btnCadastrar.Style = MetroFramework.MetroColorStyle.Red;
            this.btnCadastrar.TabIndex = 71;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseSelectable = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel5.Location = new System.Drawing.Point(362, 80);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(89, 19);
            this.metroLabel5.TabIndex = 69;
            this.metroLabel5.Text = "Pesquisar por";
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel2.Location = new System.Drawing.Point(23, 134);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(43, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel2.TabIndex = 68;
            this.metroLabel2.Text = "Preço";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
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
            this.txtPesquisa.Location = new System.Drawing.Point(521, 102);
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
            this.txtPesquisa.TabIndex = 67;
            this.txtPesquisa.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtPesquisa.UseSelectable = true;
            this.txtPesquisa.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPesquisa.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cmbTipoPesquisa
            // 
            this.cmbTipoPesquisa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbTipoPesquisa.FormattingEnabled = true;
            this.cmbTipoPesquisa.ItemHeight = 23;
            this.cmbTipoPesquisa.Items.AddRange(new object[] {
            "nome",
            "cpf"});
            this.cmbTipoPesquisa.Location = new System.Drawing.Point(362, 102);
            this.cmbTipoPesquisa.Name = "cmbTipoPesquisa";
            this.cmbTipoPesquisa.Size = new System.Drawing.Size(153, 29);
            this.cmbTipoPesquisa.Style = MetroFramework.MetroColorStyle.Red;
            this.cmbTipoPesquisa.TabIndex = 66;
            this.cmbTipoPesquisa.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cmbTipoPesquisa.UseSelectable = true;
            // 
            // txtPrecoProd
            // 
            this.txtPrecoProd.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txtPrecoProd.CustomButton.Image = null;
            this.txtPrecoProd.CustomButton.Location = new System.Drawing.Point(278, 1);
            this.txtPrecoProd.CustomButton.Name = "";
            this.txtPrecoProd.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtPrecoProd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrecoProd.CustomButton.TabIndex = 1;
            this.txtPrecoProd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrecoProd.CustomButton.UseSelectable = true;
            this.txtPrecoProd.CustomButton.Visible = false;
            this.txtPrecoProd.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtPrecoProd.Lines = new string[0];
            this.txtPrecoProd.Location = new System.Drawing.Point(23, 156);
            this.txtPrecoProd.MaxLength = 32767;
            this.txtPrecoProd.Name = "txtPrecoProd";
            this.txtPrecoProd.PasswordChar = '\0';
            this.txtPrecoProd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrecoProd.SelectedText = "";
            this.txtPrecoProd.SelectionLength = 0;
            this.txtPrecoProd.SelectionStart = 0;
            this.txtPrecoProd.ShortcutsEnabled = true;
            this.txtPrecoProd.Size = new System.Drawing.Size(306, 29);
            this.txtPrecoProd.Style = MetroFramework.MetroColorStyle.Red;
            this.txtPrecoProd.TabIndex = 65;
            this.txtPrecoProd.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtPrecoProd.UseSelectable = true;
            this.txtPrecoProd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrecoProd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel1.Location = new System.Drawing.Point(23, 80);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(46, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel1.TabIndex = 64;
            this.metroLabel1.Text = "Nome";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // txtNomeProd
            // 
            this.txtNomeProd.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txtNomeProd.CustomButton.Image = null;
            this.txtNomeProd.CustomButton.Location = new System.Drawing.Point(278, 1);
            this.txtNomeProd.CustomButton.Name = "";
            this.txtNomeProd.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtNomeProd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNomeProd.CustomButton.TabIndex = 1;
            this.txtNomeProd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNomeProd.CustomButton.UseSelectable = true;
            this.txtNomeProd.CustomButton.Visible = false;
            this.txtNomeProd.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtNomeProd.Lines = new string[0];
            this.txtNomeProd.Location = new System.Drawing.Point(23, 102);
            this.txtNomeProd.MaxLength = 32767;
            this.txtNomeProd.Name = "txtNomeProd";
            this.txtNomeProd.PasswordChar = '\0';
            this.txtNomeProd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNomeProd.SelectedText = "";
            this.txtNomeProd.SelectionLength = 0;
            this.txtNomeProd.SelectionStart = 0;
            this.txtNomeProd.ShortcutsEnabled = true;
            this.txtNomeProd.Size = new System.Drawing.Size(306, 29);
            this.txtNomeProd.Style = MetroFramework.MetroColorStyle.Red;
            this.txtNomeProd.TabIndex = 63;
            this.txtNomeProd.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtNomeProd.UseSelectable = true;
            this.txtNomeProd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNomeProd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel3.Location = new System.Drawing.Point(23, 188);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(67, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel3.TabIndex = 77;
            this.metroLabel3.Text = "Categoria";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txtCategoria.CustomButton.Image = null;
            this.txtCategoria.CustomButton.Location = new System.Drawing.Point(278, 1);
            this.txtCategoria.CustomButton.Name = "";
            this.txtCategoria.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtCategoria.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCategoria.CustomButton.TabIndex = 1;
            this.txtCategoria.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCategoria.CustomButton.UseSelectable = true;
            this.txtCategoria.CustomButton.Visible = false;
            this.txtCategoria.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtCategoria.Lines = new string[0];
            this.txtCategoria.Location = new System.Drawing.Point(23, 210);
            this.txtCategoria.MaxLength = 32767;
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.PasswordChar = '\0';
            this.txtCategoria.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCategoria.SelectedText = "";
            this.txtCategoria.SelectionLength = 0;
            this.txtCategoria.SelectionStart = 0;
            this.txtCategoria.ShortcutsEnabled = true;
            this.txtCategoria.Size = new System.Drawing.Size(306, 29);
            this.txtCategoria.Style = MetroFramework.MetroColorStyle.Red;
            this.txtCategoria.TabIndex = 76;
            this.txtCategoria.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtCategoria.UseSelectable = true;
            this.txtCategoria.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCategoria.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.mpAlerta.Location = new System.Drawing.Point(23, 215);
            this.mpAlerta.Name = "mpAlerta";
            this.mpAlerta.Size = new System.Drawing.Size(306, 24);
            this.mpAlerta.TabIndex = 78;
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
            // frmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 730);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.cmbTipoPesquisa);
            this.Controls.Add(this.txtPrecoProd);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtNomeProd);
            this.Controls.Add(this.pnTopo);
            this.Controls.Add(this.mpAlerta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProdutos";
            this.Text = "Gerenciar Produtos";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmProdutos_FormClosed);
            this.Load += new System.EventHandler(this.frmProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.mpAlerta.ResumeLayout(false);
            this.mpAlerta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnTopo;
        private MetroFramework.Controls.MetroButton btnPesquisar;
        private MetroFramework.Controls.MetroGrid dgvProdutos;
        private MetroFramework.Controls.MetroButton btnExcluir;
        private MetroFramework.Controls.MetroButton btnEditar;
        private MetroFramework.Controls.MetroButton btnCadastrar;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtPesquisa;
        private MetroFramework.Controls.MetroComboBox cmbTipoPesquisa;
        private MetroFramework.Controls.MetroTextBox txtPrecoProd;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtNomeProd;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtCategoria;
        private System.Windows.Forms.Timer tAlerta;
        private MetroFramework.Controls.MetroPanel mpAlerta;
        private MetroFramework.Controls.MetroLabel lblAlerta;
    }
}