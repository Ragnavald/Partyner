namespace Forms
{
    partial class frmGerenciarEventos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerenciarEventos));
            this.pnTopo = new System.Windows.Forms.Panel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.btnProdutos = new MetroFramework.Controls.MetroButton();
            this.cmbProdutos = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.dgvProdutos = new MetroFramework.Controls.MetroGrid();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.btnFuncionarios = new MetroFramework.Controls.MetroButton();
            this.cmbFuncionarios = new MetroFramework.Controls.MetroComboBox();
            this.metrolabel = new MetroFramework.Controls.MetroLabel();
            this.dgvFuncionarios = new MetroFramework.Controls.MetroGrid();
            this.cmbTipoPesquisa = new MetroFramework.Controls.MetroComboBox();
            this.btnPesquisar = new MetroFramework.Controls.MetroButton();
            this.txtPesquisa = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.dgvEventos = new MetroFramework.Controls.MetroGrid();
            this.txtQTD = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.mpProd = new MetroFramework.Controls.MetroPanel();
            this.lblProd = new MetroFramework.Controls.MetroLabel();
            this.tAlerta = new System.Windows.Forms.Timer(this.components);
            this.mpFunc = new MetroFramework.Controls.MetroPanel();
            this.lblFunc = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtPagamento = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).BeginInit();
            this.mpProd.SuspendLayout();
            this.mpFunc.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTopo
            // 
            this.pnTopo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnTopo.AutoSize = true;
            this.pnTopo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(9)))), ((int)(((byte)(65)))));
            this.pnTopo.Location = new System.Drawing.Point(-2, -5);
            this.pnTopo.Name = "pnTopo";
            this.pnTopo.Size = new System.Drawing.Size(1387, 10);
            this.pnTopo.TabIndex = 50;
            // 
            // metroLabel8
            // 
            this.metroLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(1090, -140);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(70, 19);
            this.metroLabel8.TabIndex = 69;
            this.metroLabel8.Text = "Cadastros:";
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btnProdutos
            // 
            this.btnProdutos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnProdutos.Enabled = false;
            this.btnProdutos.Location = new System.Drawing.Point(313, 288);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(100, 29);
            this.btnProdutos.TabIndex = 67;
            this.btnProdutos.Text = "Adicionar";
            this.btnProdutos.UseSelectable = true;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // cmbProdutos
            // 
            this.cmbProdutos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbProdutos.Enabled = false;
            this.cmbProdutos.FormattingEnabled = true;
            this.cmbProdutos.ItemHeight = 23;
            this.cmbProdutos.Location = new System.Drawing.Point(25, 288);
            this.cmbProdutos.Name = "cmbProdutos";
            this.cmbProdutos.Size = new System.Drawing.Size(197, 29);
            this.cmbProdutos.Style = MetroFramework.MetroColorStyle.Red;
            this.cmbProdutos.TabIndex = 66;
            this.cmbProdutos.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cmbProdutos.UseSelectable = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel7.Location = new System.Drawing.Point(23, 266);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(114, 19);
            this.metroLabel7.TabIndex = 65;
            this.metroLabel7.Text = "Produtos/Serviços";
            this.metroLabel7.UseCustomBackColor = true;
            this.metroLabel7.UseCustomForeColor = true;
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
            this.dgvProdutos.Location = new System.Drawing.Point(25, 323);
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
            this.dgvProdutos.Size = new System.Drawing.Size(388, 152);
            this.dgvProdutos.Style = MetroFramework.MetroColorStyle.Red;
            this.dgvProdutos.TabIndex = 68;
            this.dgvProdutos.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dgvProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellClick);
            // 
            // metroButton1
            // 
            this.metroButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton1.Enabled = false;
            this.metroButton1.Location = new System.Drawing.Point(1272, -118);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(88, 36);
            this.metroButton1.TabIndex = 64;
            this.metroButton1.Text = "Tipo";
            this.metroButton1.UseSelectable = true;
            // 
            // metroButton2
            // 
            this.metroButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton2.Enabled = false;
            this.metroButton2.Location = new System.Drawing.Point(1184, -118);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(82, 36);
            this.metroButton2.TabIndex = 63;
            this.metroButton2.Text = "Produtos";
            this.metroButton2.UseSelectable = true;
            // 
            // metroButton3
            // 
            this.metroButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton3.Location = new System.Drawing.Point(1090, -118);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(88, 36);
            this.metroButton3.TabIndex = 62;
            this.metroButton3.Text = "Adicionais";
            this.metroButton3.UseSelectable = true;
            // 
            // btnFuncionarios
            // 
            this.btnFuncionarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFuncionarios.Enabled = false;
            this.btnFuncionarios.Location = new System.Drawing.Point(313, 97);
            this.btnFuncionarios.Name = "btnFuncionarios";
            this.btnFuncionarios.Size = new System.Drawing.Size(100, 29);
            this.btnFuncionarios.TabIndex = 60;
            this.btnFuncionarios.Text = "Adicionar";
            this.btnFuncionarios.UseSelectable = true;
            this.btnFuncionarios.Click += new System.EventHandler(this.btnFuncionarios_Click);
            // 
            // cmbFuncionarios
            // 
            this.cmbFuncionarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbFuncionarios.Enabled = false;
            this.cmbFuncionarios.FormattingEnabled = true;
            this.cmbFuncionarios.ItemHeight = 23;
            this.cmbFuncionarios.Location = new System.Drawing.Point(25, 97);
            this.cmbFuncionarios.Name = "cmbFuncionarios";
            this.cmbFuncionarios.Size = new System.Drawing.Size(197, 29);
            this.cmbFuncionarios.Style = MetroFramework.MetroColorStyle.Red;
            this.cmbFuncionarios.TabIndex = 59;
            this.cmbFuncionarios.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cmbFuncionarios.UseSelectable = true;
            // 
            // metrolabel
            // 
            this.metrolabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metrolabel.AutoSize = true;
            this.metrolabel.BackColor = System.Drawing.Color.Transparent;
            this.metrolabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metrolabel.Location = new System.Drawing.Point(23, 75);
            this.metrolabel.Name = "metrolabel";
            this.metrolabel.Size = new System.Drawing.Size(82, 19);
            this.metrolabel.TabIndex = 58;
            this.metrolabel.Text = "Funcionários";
            this.metrolabel.UseCustomBackColor = true;
            this.metrolabel.UseCustomForeColor = true;
            // 
            // dgvFuncionarios
            // 
            this.dgvFuncionarios.AllowUserToAddRows = false;
            this.dgvFuncionarios.AllowUserToDeleteRows = false;
            this.dgvFuncionarios.AllowUserToResizeRows = false;
            this.dgvFuncionarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvFuncionarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvFuncionarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFuncionarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvFuncionarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFuncionarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFuncionarios.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvFuncionarios.EnableHeadersVisualStyles = false;
            this.dgvFuncionarios.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvFuncionarios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvFuncionarios.Location = new System.Drawing.Point(23, 132);
            this.dgvFuncionarios.Name = "dgvFuncionarios";
            this.dgvFuncionarios.ReadOnly = true;
            this.dgvFuncionarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFuncionarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvFuncionarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvFuncionarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFuncionarios.Size = new System.Drawing.Size(390, 106);
            this.dgvFuncionarios.Style = MetroFramework.MetroColorStyle.Red;
            this.dgvFuncionarios.TabIndex = 61;
            this.dgvFuncionarios.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dgvFuncionarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFuncionarios_CellClick);
            // 
            // cmbTipoPesquisa
            // 
            this.cmbTipoPesquisa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbTipoPesquisa.FormattingEnabled = true;
            this.cmbTipoPesquisa.ItemHeight = 23;
            this.cmbTipoPesquisa.Items.AddRange(new object[] {
            "Descrição",
            "Valor total",
            "Cliente"});
            this.cmbTipoPesquisa.Location = new System.Drawing.Point(489, 97);
            this.cmbTipoPesquisa.Name = "cmbTipoPesquisa";
            this.cmbTipoPesquisa.Size = new System.Drawing.Size(112, 29);
            this.cmbTipoPesquisa.Style = MetroFramework.MetroColorStyle.Red;
            this.cmbTipoPesquisa.TabIndex = 77;
            this.cmbTipoPesquisa.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cmbTipoPesquisa.UseSelectable = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPesquisar.Location = new System.Drawing.Point(1243, 97);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(100, 29);
            this.btnPesquisar.Style = MetroFramework.MetroColorStyle.Red;
            this.btnPesquisar.TabIndex = 76;
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
            this.txtPesquisa.CustomButton.Location = new System.Drawing.Point(602, 1);
            this.txtPesquisa.CustomButton.Name = "";
            this.txtPesquisa.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtPesquisa.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPesquisa.CustomButton.TabIndex = 1;
            this.txtPesquisa.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPesquisa.CustomButton.UseSelectable = true;
            this.txtPesquisa.CustomButton.Visible = false;
            this.txtPesquisa.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtPesquisa.Lines = new string[0];
            this.txtPesquisa.Location = new System.Drawing.Point(607, 97);
            this.txtPesquisa.MaxLength = 32767;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.PasswordChar = '\0';
            this.txtPesquisa.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPesquisa.SelectedText = "";
            this.txtPesquisa.SelectionLength = 0;
            this.txtPesquisa.SelectionStart = 0;
            this.txtPesquisa.ShortcutsEnabled = true;
            this.txtPesquisa.Size = new System.Drawing.Size(630, 29);
            this.txtPesquisa.Style = MetroFramework.MetroColorStyle.Red;
            this.txtPesquisa.TabIndex = 75;
            this.txtPesquisa.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtPesquisa.UseSelectable = true;
            this.txtPesquisa.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPesquisa.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel5.Location = new System.Drawing.Point(489, 75);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(89, 19);
            this.metroLabel5.TabIndex = 74;
            this.metroLabel5.Text = "Pesquisar por";
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // dgvEventos
            // 
            this.dgvEventos.AllowUserToAddRows = false;
            this.dgvEventos.AllowUserToDeleteRows = false;
            this.dgvEventos.AllowUserToResizeRows = false;
            this.dgvEventos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvEventos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvEventos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEventos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvEventos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEventos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEventos.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvEventos.EnableHeadersVisualStyles = false;
            this.dgvEventos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvEventos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvEventos.Location = new System.Drawing.Point(489, 151);
            this.dgvEventos.Name = "dgvEventos";
            this.dgvEventos.ReadOnly = true;
            this.dgvEventos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEventos.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvEventos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvEventos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEventos.Size = new System.Drawing.Size(854, 556);
            this.dgvEventos.Style = MetroFramework.MetroColorStyle.Red;
            this.dgvEventos.TabIndex = 73;
            this.dgvEventos.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dgvEventos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEventos_CellClick);
            // 
            // txtQTD
            // 
            this.txtQTD.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txtQTD.CustomButton.Image = null;
            this.txtQTD.CustomButton.Location = new System.Drawing.Point(48, 1);
            this.txtQTD.CustomButton.Name = "";
            this.txtQTD.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtQTD.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQTD.CustomButton.TabIndex = 1;
            this.txtQTD.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQTD.CustomButton.UseSelectable = true;
            this.txtQTD.CustomButton.Visible = false;
            this.txtQTD.Enabled = false;
            this.txtQTD.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtQTD.Lines = new string[0];
            this.txtQTD.Location = new System.Drawing.Point(231, 288);
            this.txtQTD.MaxLength = 32767;
            this.txtQTD.Name = "txtQTD";
            this.txtQTD.PasswordChar = '\0';
            this.txtQTD.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQTD.SelectedText = "";
            this.txtQTD.SelectionLength = 0;
            this.txtQTD.SelectionStart = 0;
            this.txtQTD.ShortcutsEnabled = true;
            this.txtQTD.Size = new System.Drawing.Size(76, 29);
            this.txtQTD.Style = MetroFramework.MetroColorStyle.Red;
            this.txtQTD.TabIndex = 9;
            this.txtQTD.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtQTD.UseSelectable = true;
            this.txtQTD.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtQTD.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel1.Location = new System.Drawing.Point(231, 266);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(78, 19);
            this.metroLabel1.TabIndex = 79;
            this.metroLabel1.Text = "Quantidade";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.Location = new System.Drawing.Point(25, 678);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 29);
            this.btnCancelar.TabIndex = 80;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseSelectable = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // mpProd
            // 
            this.mpProd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mpProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(9)))), ((int)(((byte)(65)))));
            this.mpProd.Controls.Add(this.lblProd);
            this.mpProd.HorizontalScrollbarBarColor = true;
            this.mpProd.HorizontalScrollbarHighlightOnWheel = false;
            this.mpProd.HorizontalScrollbarSize = 10;
            this.mpProd.Location = new System.Drawing.Point(25, 451);
            this.mpProd.Name = "mpProd";
            this.mpProd.Size = new System.Drawing.Size(388, 24);
            this.mpProd.TabIndex = 81;
            this.mpProd.UseCustomBackColor = true;
            this.mpProd.VerticalScrollbarBarColor = true;
            this.mpProd.VerticalScrollbarHighlightOnWheel = false;
            this.mpProd.VerticalScrollbarSize = 10;
            // 
            // lblProd
            // 
            this.lblProd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProd.AutoSize = true;
            this.lblProd.BackColor = System.Drawing.Color.Transparent;
            this.lblProd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblProd.Location = new System.Drawing.Point(3, 2);
            this.lblProd.Name = "lblProd";
            this.lblProd.Size = new System.Drawing.Size(47, 19);
            this.lblProd.Style = MetroFramework.MetroColorStyle.Red;
            this.lblProd.TabIndex = 46;
            this.lblProd.Text = "Alerta:";
            this.lblProd.UseCustomBackColor = true;
            this.lblProd.UseCustomForeColor = true;
            this.lblProd.Visible = false;
            // 
            // tAlerta
            // 
            this.tAlerta.Interval = 1000;
            this.tAlerta.Tick += new System.EventHandler(this.tAlerta_Tick);
            // 
            // mpFunc
            // 
            this.mpFunc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mpFunc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(9)))), ((int)(((byte)(65)))));
            this.mpFunc.Controls.Add(this.lblFunc);
            this.mpFunc.HorizontalScrollbarBarColor = true;
            this.mpFunc.HorizontalScrollbarHighlightOnWheel = false;
            this.mpFunc.HorizontalScrollbarSize = 10;
            this.mpFunc.Location = new System.Drawing.Point(23, 214);
            this.mpFunc.Name = "mpFunc";
            this.mpFunc.Size = new System.Drawing.Size(388, 24);
            this.mpFunc.TabIndex = 82;
            this.mpFunc.UseCustomBackColor = true;
            this.mpFunc.VerticalScrollbarBarColor = true;
            this.mpFunc.VerticalScrollbarHighlightOnWheel = false;
            this.mpFunc.VerticalScrollbarSize = 10;
            // 
            // lblFunc
            // 
            this.lblFunc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFunc.AutoSize = true;
            this.lblFunc.BackColor = System.Drawing.Color.Transparent;
            this.lblFunc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFunc.Location = new System.Drawing.Point(3, 2);
            this.lblFunc.Name = "lblFunc";
            this.lblFunc.Size = new System.Drawing.Size(47, 19);
            this.lblFunc.Style = MetroFramework.MetroColorStyle.Red;
            this.lblFunc.TabIndex = 46;
            this.lblFunc.Text = "Alerta:";
            this.lblFunc.UseCustomBackColor = true;
            this.lblFunc.UseCustomForeColor = true;
            this.lblFunc.Visible = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel2.Location = new System.Drawing.Point(231, 75);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(77, 19);
            this.metroLabel2.TabIndex = 84;
            this.metroLabel2.Text = "Pagamento";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // txtPagamento
            // 
            this.txtPagamento.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txtPagamento.CustomButton.Image = null;
            this.txtPagamento.CustomButton.Location = new System.Drawing.Point(48, 1);
            this.txtPagamento.CustomButton.Name = "";
            this.txtPagamento.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtPagamento.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPagamento.CustomButton.TabIndex = 1;
            this.txtPagamento.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPagamento.CustomButton.UseSelectable = true;
            this.txtPagamento.CustomButton.Visible = false;
            this.txtPagamento.Enabled = false;
            this.txtPagamento.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtPagamento.Lines = new string[0];
            this.txtPagamento.Location = new System.Drawing.Point(231, 97);
            this.txtPagamento.MaxLength = 32767;
            this.txtPagamento.Name = "txtPagamento";
            this.txtPagamento.PasswordChar = '\0';
            this.txtPagamento.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPagamento.SelectedText = "";
            this.txtPagamento.SelectionLength = 0;
            this.txtPagamento.SelectionStart = 0;
            this.txtPagamento.ShortcutsEnabled = true;
            this.txtPagamento.Size = new System.Drawing.Size(76, 29);
            this.txtPagamento.Style = MetroFramework.MetroColorStyle.Red;
            this.txtPagamento.TabIndex = 83;
            this.txtPagamento.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtPagamento.UseSelectable = true;
            this.txtPagamento.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPagamento.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // frmGerenciarEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 730);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtPagamento);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtQTD);
            this.Controls.Add(this.cmbTipoPesquisa);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.dgvEventos);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.btnProdutos);
            this.Controls.Add(this.cmbProdutos);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.btnFuncionarios);
            this.Controls.Add(this.cmbFuncionarios);
            this.Controls.Add(this.metrolabel);
            this.Controls.Add(this.pnTopo);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.mpProd);
            this.Controls.Add(this.dgvFuncionarios);
            this.Controls.Add(this.mpFunc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGerenciarEventos";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Gerenciar Gastos";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmGerenciarEventos_FormClosed);
            this.Load += new System.EventHandler(this.frmGerenciarEventos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).EndInit();
            this.mpProd.ResumeLayout(false);
            this.mpProd.PerformLayout();
            this.mpFunc.ResumeLayout(false);
            this.mpFunc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnTopo;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroButton btnProdutos;
        private MetroFramework.Controls.MetroComboBox cmbProdutos;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroGrid dgvProdutos;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton btnFuncionarios;
        private MetroFramework.Controls.MetroComboBox cmbFuncionarios;
        private MetroFramework.Controls.MetroLabel metrolabel;
        private MetroFramework.Controls.MetroGrid dgvFuncionarios;
        private MetroFramework.Controls.MetroComboBox cmbTipoPesquisa;
        private MetroFramework.Controls.MetroButton btnPesquisar;
        private MetroFramework.Controls.MetroTextBox txtPesquisa;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroGrid dgvEventos;
        private MetroFramework.Controls.MetroTextBox txtQTD;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private MetroFramework.Controls.MetroPanel mpProd;
        private MetroFramework.Controls.MetroLabel lblProd;
        private System.Windows.Forms.Timer tAlerta;
        private MetroFramework.Controls.MetroPanel mpFunc;
        private MetroFramework.Controls.MetroLabel lblFunc;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtPagamento;
    }
}