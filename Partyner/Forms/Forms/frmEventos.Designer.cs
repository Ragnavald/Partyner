namespace Forms
{
    partial class frmEventos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEventos));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btnCadastrar = new MetroFramework.Controls.MetroButton();
            this.btnEditar = new MetroFramework.Controls.MetroButton();
            this.btnExcluir = new MetroFramework.Controls.MetroButton();
            this.dtpData = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cmbTipo = new MetroFramework.Controls.MetroComboBox();
            this.cmbAdicionais = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btnAdicionais = new MetroFramework.Controls.MetroButton();
            this.dgvConsultaEven = new MetroFramework.Controls.MetroGrid();
            this.dgvAdicionais = new MetroFramework.Controls.MetroGrid();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtPesquisa = new MetroFramework.Controls.MetroTextBox();
            this.btnPesquisar = new MetroFramework.Controls.MetroButton();
            this.cmbTipoPesquisa = new MetroFramework.Controls.MetroComboBox();
            this.txtDescricao = new MetroFramework.Controls.MetroTextBox();
            this.cmbCliente = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.btnCadTipo = new MetroFramework.Controls.MetroButton();
            this.btnCadProdutos = new MetroFramework.Controls.MetroButton();
            this.btnCadAd = new MetroFramework.Controls.MetroButton();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.tAlerta = new System.Windows.Forms.Timer(this.components);
            this.pnTopo = new System.Windows.Forms.Panel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtNMC = new MetroFramework.Controls.MetroTextBox();
            this.btnProdFunf = new MetroFramework.Controls.MetroButton();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.mpAlerta = new MetroFramework.Controls.MetroPanel();
            this.lblAlerta = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaEven)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdicionais)).BeginInit();
            this.mpAlerta.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel1.Location = new System.Drawing.Point(20, 310);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(36, 19);
            this.metroLabel1.TabIndex = 19;
            this.metroLabel1.Text = "Data";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel3.Location = new System.Drawing.Point(20, 148);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(65, 19);
            this.metroLabel3.TabIndex = 22;
            this.metroLabel3.Text = "Descrição";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCadastrar.Location = new System.Drawing.Point(23, 695);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(100, 36);
            this.btnCadastrar.TabIndex = 24;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseSelectable = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditar.Enabled = false;
            this.btnEditar.Location = new System.Drawing.Point(129, 695);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(94, 36);
            this.btnEditar.TabIndex = 25;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseSelectable = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Location = new System.Drawing.Point(229, 695);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 36);
            this.btnExcluir.TabIndex = 26;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseSelectable = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // dtpData
            // 
            this.dtpData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpData.Location = new System.Drawing.Point(20, 332);
            this.dtpData.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(306, 29);
            this.dtpData.Style = MetroFramework.MetroColorStyle.Red;
            this.dtpData.TabIndex = 3;
            this.dtpData.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel2.Location = new System.Drawing.Point(23, 364);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(35, 19);
            this.metroLabel2.TabIndex = 29;
            this.metroLabel2.Text = "Tipo";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // cmbTipo
            // 
            this.cmbTipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.ItemHeight = 23;
            this.cmbTipo.Location = new System.Drawing.Point(21, 386);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(305, 29);
            this.cmbTipo.Style = MetroFramework.MetroColorStyle.Red;
            this.cmbTipo.TabIndex = 4;
            this.cmbTipo.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cmbTipo.UseSelectable = true;
            // 
            // cmbAdicionais
            // 
            this.cmbAdicionais.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbAdicionais.Enabled = false;
            this.cmbAdicionais.FormattingEnabled = true;
            this.cmbAdicionais.ItemHeight = 23;
            this.cmbAdicionais.Location = new System.Drawing.Point(20, 494);
            this.cmbAdicionais.Name = "cmbAdicionais";
            this.cmbAdicionais.Size = new System.Drawing.Size(188, 29);
            this.cmbAdicionais.Style = MetroFramework.MetroColorStyle.Red;
            this.cmbAdicionais.TabIndex = 6;
            this.cmbAdicionais.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cmbAdicionais.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel4.Location = new System.Drawing.Point(20, 472);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(68, 19);
            this.metroLabel4.TabIndex = 31;
            this.metroLabel4.Text = "Adicionais";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // btnAdicionais
            // 
            this.btnAdicionais.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdicionais.Enabled = false;
            this.btnAdicionais.Location = new System.Drawing.Point(214, 494);
            this.btnAdicionais.Name = "btnAdicionais";
            this.btnAdicionais.Size = new System.Drawing.Size(112, 29);
            this.btnAdicionais.TabIndex = 7;
            this.btnAdicionais.Text = "Adicionar";
            this.btnAdicionais.UseSelectable = true;
            this.btnAdicionais.Click += new System.EventHandler(this.btnAdicionais_Click);
            // 
            // dgvConsultaEven
            // 
            this.dgvConsultaEven.AllowUserToAddRows = false;
            this.dgvConsultaEven.AllowUserToDeleteRows = false;
            this.dgvConsultaEven.AllowUserToResizeRows = false;
            this.dgvConsultaEven.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvConsultaEven.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvConsultaEven.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvConsultaEven.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvConsultaEven.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsultaEven.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConsultaEven.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvConsultaEven.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvConsultaEven.EnableHeadersVisualStyles = false;
            this.dgvConsultaEven.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvConsultaEven.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvConsultaEven.Location = new System.Drawing.Point(373, 170);
            this.dgvConsultaEven.Name = "dgvConsultaEven";
            this.dgvConsultaEven.ReadOnly = true;
            this.dgvConsultaEven.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsultaEven.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvConsultaEven.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvConsultaEven.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultaEven.Size = new System.Drawing.Size(973, 486);
            this.dgvConsultaEven.Style = MetroFramework.MetroColorStyle.Red;
            this.dgvConsultaEven.TabIndex = 35;
            this.dgvConsultaEven.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dgvConsultaEven.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultaEven_CellClick);
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAdicionais.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAdicionais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAdicionais.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAdicionais.Enabled = false;
            this.dgvAdicionais.EnableHeadersVisualStyles = false;
            this.dgvAdicionais.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvAdicionais.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvAdicionais.Location = new System.Drawing.Point(20, 529);
            this.dgvAdicionais.Name = "dgvAdicionais";
            this.dgvAdicionais.ReadOnly = true;
            this.dgvAdicionais.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAdicionais.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAdicionais.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAdicionais.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdicionais.Size = new System.Drawing.Size(306, 106);
            this.dgvAdicionais.Style = MetroFramework.MetroColorStyle.Red;
            this.dgvAdicionais.TabIndex = 36;
            this.dgvAdicionais.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dgvAdicionais.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdicionais_CellClick);
            // 
            // metroLabel5
            // 
            this.metroLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel5.Location = new System.Drawing.Point(368, 94);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(89, 19);
            this.metroLabel5.TabIndex = 37;
            this.metroLabel5.Text = "Pesquisar por";
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txtPesquisa.CustomButton.Image = null;
            this.txtPesquisa.CustomButton.Location = new System.Drawing.Point(685, 1);
            this.txtPesquisa.CustomButton.Name = "";
            this.txtPesquisa.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtPesquisa.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPesquisa.CustomButton.TabIndex = 1;
            this.txtPesquisa.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPesquisa.CustomButton.UseSelectable = true;
            this.txtPesquisa.CustomButton.Visible = false;
            this.txtPesquisa.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPesquisa.Lines = new string[0];
            this.txtPesquisa.Location = new System.Drawing.Point(527, 116);
            this.txtPesquisa.MaxLength = 32767;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.PasswordChar = '\0';
            this.txtPesquisa.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPesquisa.SelectedText = "";
            this.txtPesquisa.SelectionLength = 0;
            this.txtPesquisa.SelectionStart = 0;
            this.txtPesquisa.ShortcutsEnabled = true;
            this.txtPesquisa.Size = new System.Drawing.Size(713, 29);
            this.txtPesquisa.Style = MetroFramework.MetroColorStyle.Red;
            this.txtPesquisa.TabIndex = 38;
            this.txtPesquisa.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtPesquisa.UseSelectable = true;
            this.txtPesquisa.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPesquisa.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPesquisar.Location = new System.Drawing.Point(1246, 116);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(100, 29);
            this.btnPesquisar.TabIndex = 39;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseSelectable = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
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
            this.cmbTipoPesquisa.Location = new System.Drawing.Point(368, 116);
            this.cmbTipoPesquisa.Name = "cmbTipoPesquisa";
            this.cmbTipoPesquisa.Size = new System.Drawing.Size(153, 29);
            this.cmbTipoPesquisa.Style = MetroFramework.MetroColorStyle.Red;
            this.cmbTipoPesquisa.TabIndex = 40;
            this.cmbTipoPesquisa.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cmbTipoPesquisa.UseSelectable = true;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txtDescricao.CustomButton.Image = null;
            this.txtDescricao.CustomButton.Location = new System.Drawing.Point(170, 1);
            this.txtDescricao.CustomButton.Name = "";
            this.txtDescricao.CustomButton.Size = new System.Drawing.Size(135, 135);
            this.txtDescricao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescricao.CustomButton.TabIndex = 1;
            this.txtDescricao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescricao.CustomButton.UseSelectable = true;
            this.txtDescricao.CustomButton.Visible = false;
            this.txtDescricao.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtDescricao.Lines = new string[0];
            this.txtDescricao.Location = new System.Drawing.Point(20, 170);
            this.txtDescricao.MaxLength = 32767;
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.PasswordChar = '\0';
            this.txtDescricao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescricao.SelectedText = "";
            this.txtDescricao.SelectionLength = 0;
            this.txtDescricao.SelectionStart = 0;
            this.txtDescricao.ShortcutsEnabled = true;
            this.txtDescricao.Size = new System.Drawing.Size(306, 137);
            this.txtDescricao.Style = MetroFramework.MetroColorStyle.Red;
            this.txtDescricao.TabIndex = 2;
            this.txtDescricao.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtDescricao.UseSelectable = true;
            this.txtDescricao.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescricao.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cmbCliente
            // 
            this.cmbCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.ItemHeight = 23;
            this.cmbCliente.Location = new System.Drawing.Point(23, 116);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(303, 29);
            this.cmbCliente.Style = MetroFramework.MetroColorStyle.Red;
            this.cmbCliente.TabIndex = 1;
            this.cmbCliente.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cmbCliente.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel6.Location = new System.Drawing.Point(23, 94);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(49, 19);
            this.metroLabel6.TabIndex = 42;
            this.metroLabel6.Text = "Cliente";
            this.metroLabel6.UseCustomBackColor = true;
            this.metroLabel6.UseCustomForeColor = true;
            // 
            // btnCadTipo
            // 
            this.btnCadTipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadTipo.Location = new System.Drawing.Point(1253, 54);
            this.btnCadTipo.Name = "btnCadTipo";
            this.btnCadTipo.Size = new System.Drawing.Size(88, 36);
            this.btnCadTipo.TabIndex = 10;
            this.btnCadTipo.Text = "Tipo";
            this.btnCadTipo.UseSelectable = true;
            this.btnCadTipo.Click += new System.EventHandler(this.btnCadTipo_Click);
            // 
            // btnCadProdutos
            // 
            this.btnCadProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadProdutos.Location = new System.Drawing.Point(1165, 54);
            this.btnCadProdutos.Name = "btnCadProdutos";
            this.btnCadProdutos.Size = new System.Drawing.Size(82, 36);
            this.btnCadProdutos.TabIndex = 9;
            this.btnCadProdutos.Text = "Produtos";
            this.btnCadProdutos.UseSelectable = true;
            this.btnCadProdutos.Click += new System.EventHandler(this.btnCadProdutos_Click);
            // 
            // btnCadAd
            // 
            this.btnCadAd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadAd.Location = new System.Drawing.Point(1071, 54);
            this.btnCadAd.Name = "btnCadAd";
            this.btnCadAd.Size = new System.Drawing.Size(88, 36);
            this.btnCadAd.TabIndex = 8;
            this.btnCadAd.Text = "Adicionais";
            this.btnCadAd.UseSelectable = true;
            this.btnCadAd.Click += new System.EventHandler(this.btnCadAd_Click);
            // 
            // metroLabel8
            // 
            this.metroLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(1071, 32);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(69, 19);
            this.metroLabel8.TabIndex = 57;
            this.metroLabel8.Text = "Cadastrar:";
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tAlerta
            // 
            this.tAlerta.Interval = 1000;
            this.tAlerta.Tick += new System.EventHandler(this.tAlerta_Tick_1);
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
            // metroLabel7
            // 
            this.metroLabel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel7.Location = new System.Drawing.Point(20, 418);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(150, 19);
            this.metroLabel7.TabIndex = 65;
            this.metroLabel7.Text = "Numero de Convidados";
            this.metroLabel7.UseCustomBackColor = true;
            this.metroLabel7.UseCustomForeColor = true;
            // 
            // txtNMC
            // 
            this.txtNMC.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txtNMC.CustomButton.Image = null;
            this.txtNMC.CustomButton.Location = new System.Drawing.Point(278, 1);
            this.txtNMC.CustomButton.Name = "";
            this.txtNMC.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtNMC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNMC.CustomButton.TabIndex = 1;
            this.txtNMC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNMC.CustomButton.UseSelectable = true;
            this.txtNMC.CustomButton.Visible = false;
            this.txtNMC.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtNMC.Lines = new string[0];
            this.txtNMC.Location = new System.Drawing.Point(20, 440);
            this.txtNMC.MaxLength = 32767;
            this.txtNMC.Name = "txtNMC";
            this.txtNMC.PasswordChar = '\0';
            this.txtNMC.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNMC.SelectedText = "";
            this.txtNMC.SelectionLength = 0;
            this.txtNMC.SelectionStart = 0;
            this.txtNMC.ShortcutsEnabled = true;
            this.txtNMC.Size = new System.Drawing.Size(306, 29);
            this.txtNMC.Style = MetroFramework.MetroColorStyle.Red;
            this.txtNMC.TabIndex = 5;
            this.txtNMC.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtNMC.UseSelectable = true;
            this.txtNMC.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNMC.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnProdFunf
            // 
            this.btnProdFunf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProdFunf.Location = new System.Drawing.Point(912, 54);
            this.btnProdFunf.Name = "btnProdFunf";
            this.btnProdFunf.Size = new System.Drawing.Size(133, 36);
            this.btnProdFunf.TabIndex = 11;
            this.btnProdFunf.Text = "Gerenciar Gastos";
            this.btnProdFunf.UseSelectable = true;
            this.btnProdFunf.Click += new System.EventHandler(this.btnProdFunf_Click);
            // 
            // metroLabel9
            // 
            this.metroLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(912, 32);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(68, 19);
            this.metroLabel9.TabIndex = 68;
            this.metroLabel9.Text = "Gerenciar:";
            this.metroLabel9.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // mpAlerta
            // 
            this.mpAlerta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mpAlerta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(9)))), ((int)(((byte)(65)))));
            this.mpAlerta.Controls.Add(this.lblAlerta);
            this.mpAlerta.HorizontalScrollbarBarColor = true;
            this.mpAlerta.HorizontalScrollbarHighlightOnWheel = false;
            this.mpAlerta.HorizontalScrollbarSize = 10;
            this.mpAlerta.Location = new System.Drawing.Point(23, 611);
            this.mpAlerta.Name = "mpAlerta";
            this.mpAlerta.Size = new System.Drawing.Size(303, 24);
            this.mpAlerta.TabIndex = 69;
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
            this.lblAlerta.Location = new System.Drawing.Point(0, 2);
            this.lblAlerta.Name = "lblAlerta";
            this.lblAlerta.Size = new System.Drawing.Size(47, 19);
            this.lblAlerta.Style = MetroFramework.MetroColorStyle.Red;
            this.lblAlerta.TabIndex = 46;
            this.lblAlerta.Text = "Alerta:";
            this.lblAlerta.UseCustomBackColor = true;
            this.lblAlerta.UseCustomForeColor = true;
            this.lblAlerta.Visible = false;
            // 
            // frmEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.btnProdFunf);
            this.Controls.Add(this.txtNMC);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.pnTopo);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.btnCadTipo);
            this.Controls.Add(this.btnCadProdutos);
            this.Controls.Add(this.btnCadAd);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.cmbTipoPesquisa);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.dgvConsultaEven);
            this.Controls.Add(this.btnAdicionais);
            this.Controls.Add(this.cmbAdicionais);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dgvAdicionais);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.mpAlerta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEventos";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Gerenciar Eventos";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmEventos_FormClosed);
            this.Load += new System.EventHandler(this.frmEventos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaEven)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdicionais)).EndInit();
            this.mpAlerta.ResumeLayout(false);
            this.mpAlerta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton btnCadastrar;
        private MetroFramework.Controls.MetroButton btnEditar;
        private MetroFramework.Controls.MetroButton btnExcluir;
        private MetroFramework.Controls.MetroDateTime dtpData;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cmbTipo;
        private MetroFramework.Controls.MetroComboBox cmbAdicionais;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton btnAdicionais;
        private MetroFramework.Controls.MetroGrid dgvConsultaEven;
        private MetroFramework.Controls.MetroGrid dgvAdicionais;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtPesquisa;
        private MetroFramework.Controls.MetroButton btnPesquisar;
        private MetroFramework.Controls.MetroComboBox cmbTipoPesquisa;
        private MetroFramework.Controls.MetroTextBox txtDescricao;
        private MetroFramework.Controls.MetroComboBox cmbCliente;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroButton btnCadTipo;
        private MetroFramework.Controls.MetroButton btnCadProdutos;
        private MetroFramework.Controls.MetroButton btnCadAd;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.Timer tAlerta;
        private System.Windows.Forms.Panel pnTopo;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtNMC;
        private MetroFramework.Controls.MetroButton btnProdFunf;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroPanel mpAlerta;
        private MetroFramework.Controls.MetroLabel lblAlerta;

    }
}