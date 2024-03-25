namespace ControloDePropinas
{
    partial class TelaArquivos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.comboxMeses = new System.Windows.Forms.ComboBox();
            this.lbmesf = new Guna.UI.WinForms.GunaLabel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panelsexo = new Guna.UI.WinForms.GunaPanel();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.labelMes = new Guna.UI.WinForms.GunaLabel();
            this.labelF_Npag = new Guna.UI.WinForms.GunaCheckBox();
            this.labelFiltroM_Pago = new Guna.UI.WinForms.GunaCheckBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaDataGridView1 = new Guna.UI.WinForms.GunaDataGridView();
            this.btn_ListaPag = new Guna.UI.WinForms.GunaButton();
            this.Btn_Visualizar = new Guna.UI.WinForms.GunaButton();
            this.btn_RefreshPag = new Guna.UI.WinForms.GunaButton();
            this.lbApagar = new System.Windows.Forms.Label();
            this.lbnum = new System.Windows.Forms.Label();
            this.lbsexo = new System.Windows.Forms.Label();
            this.lbnome = new System.Windows.Forms.Label();
            this.btactualizar = new Guna.UI.WinForms.GunaButton();
            this.btApagar = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel1.SuspendLayout();
            this.panelsexo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaPanel1.Controls.Add(this.comboxMeses);
            this.gunaPanel1.Controls.Add(this.lbmesf);
            this.gunaPanel1.Controls.Add(this.comboBox1);
            this.gunaPanel1.Controls.Add(this.panelsexo);
            this.gunaPanel1.Controls.Add(this.gunaLabel5);
            this.gunaPanel1.Controls.Add(this.gunaLabel6);
            this.gunaPanel1.Controls.Add(this.gunaLabel7);
            this.gunaPanel1.Controls.Add(this.gunaLabel4);
            this.gunaPanel1.Controls.Add(this.gunaLabel3);
            this.gunaPanel1.Controls.Add(this.gunaLabel2);
            this.gunaPanel1.Controls.Add(this.gunaLabel1);
            this.gunaPanel1.Location = new System.Drawing.Point(102, 111);
            this.gunaPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1190, 160);
            this.gunaPanel1.TabIndex = 0;
            // 
            // comboxMeses
            // 
            this.comboxMeses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxMeses.FormattingEnabled = true;
            this.comboxMeses.Items.AddRange(new object[] {
            "Todos",
            "Setembro",
            "Outubro",
            "Novembro",
            "Dezembro",
            "Janeiro",
            "Marco",
            "Abril",
            "Maio",
            "Junho"});
            this.comboxMeses.Location = new System.Drawing.Point(916, 104);
            this.comboxMeses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboxMeses.Name = "comboxMeses";
            this.comboxMeses.Size = new System.Drawing.Size(185, 24);
            this.comboxMeses.TabIndex = 11;
            this.comboxMeses.Visible = false;
            this.comboxMeses.TextChanged += new System.EventHandler(this.comboxMeses_TextChanged);
            // 
            // lbmesf
            // 
            this.lbmesf.AutoSize = true;
            this.lbmesf.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbmesf.Location = new System.Drawing.Point(921, 82);
            this.lbmesf.Name = "lbmesf";
            this.lbmesf.Size = new System.Drawing.Size(98, 20);
            this.lbmesf.TabIndex = 10;
            this.lbmesf.Text = "Mês de Filtro:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(916, 50);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 24);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // panelsexo
            // 
            this.panelsexo.Controls.Add(this.gunaButton1);
            this.panelsexo.Controls.Add(this.labelMes);
            this.panelsexo.Controls.Add(this.labelF_Npag);
            this.panelsexo.Controls.Add(this.labelFiltroM_Pago);
            this.panelsexo.Location = new System.Drawing.Point(404, 39);
            this.panelsexo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelsexo.Name = "panelsexo";
            this.panelsexo.Size = new System.Drawing.Size(358, 83);
            this.panelsexo.TabIndex = 8;
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.DimGray;
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(216, 26);
            this.gunaButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 2;
            this.gunaButton1.Size = new System.Drawing.Size(118, 28);
            this.gunaButton1.TabIndex = 2;
            this.gunaButton1.Text = "Filtrar";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // labelMes
            // 
            this.labelMes.AutoSize = true;
            this.labelMes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelMes.Location = new System.Drawing.Point(92, 14);
            this.labelMes.Name = "labelMes";
            this.labelMes.Size = new System.Drawing.Size(53, 20);
            this.labelMes.TabIndex = 10;
            this.labelMes.Text = "Meses:";
            this.labelMes.Visible = false;
            // 
            // labelF_Npag
            // 
            this.labelF_Npag.BaseColor = System.Drawing.Color.White;
            this.labelF_Npag.Checked = true;
            this.labelF_Npag.CheckedOffColor = System.Drawing.Color.Gray;
            this.labelF_Npag.CheckedOnColor = System.Drawing.Color.DimGray;
            this.labelF_Npag.FillColor = System.Drawing.Color.White;
            this.labelF_Npag.Location = new System.Drawing.Point(45, 49);
            this.labelF_Npag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelF_Npag.Name = "labelF_Npag";
            this.labelF_Npag.Size = new System.Drawing.Size(128, 20);
            this.labelF_Npag.TabIndex = 1;
            this.labelF_Npag.Text = "Filtrar Femenino";
            // 
            // labelFiltroM_Pago
            // 
            this.labelFiltroM_Pago.BaseColor = System.Drawing.Color.White;
            this.labelFiltroM_Pago.Checked = true;
            this.labelFiltroM_Pago.CheckedOffColor = System.Drawing.Color.Gray;
            this.labelFiltroM_Pago.CheckedOnColor = System.Drawing.Color.DimGray;
            this.labelFiltroM_Pago.FillColor = System.Drawing.Color.White;
            this.labelFiltroM_Pago.Location = new System.Drawing.Point(44, 16);
            this.labelFiltroM_Pago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelFiltroM_Pago.Name = "labelFiltroM_Pago";
            this.labelFiltroM_Pago.Size = new System.Drawing.Size(129, 20);
            this.labelFiltroM_Pago.TabIndex = 0;
            this.labelFiltroM_Pago.Text = "Filtrar Masculino";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel5.Location = new System.Drawing.Point(59, 38);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(0, 20);
            this.gunaLabel5.TabIndex = 7;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel6.Location = new System.Drawing.Point(96, 70);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(0, 20);
            this.gunaLabel6.TabIndex = 6;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel7.Location = new System.Drawing.Point(108, 102);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(0, 20);
            this.gunaLabel7.TabIndex = 5;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.Location = new System.Drawing.Point(70, 38);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(60, 20);
            this.gunaLabel4.TabIndex = 4;
            this.gunaLabel4.Text = "ª Classe";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(56, 70);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(40, 20);
            this.gunaLabel3.TabIndex = 3;
            this.gunaLabel3.Text = "Sala:";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(54, 102);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(50, 20);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "Turno:";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(913, 25);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(54, 20);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Turma:";
            // 
            // gunaDataGridView1
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.gunaDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gunaDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.gunaDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.gunaDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gunaDataGridView1.ColumnHeadersHeight = 25;
            this.gunaDataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.gunaDataGridView1.EnableHeadersVisualStyles = false;
            this.gunaDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.gunaDataGridView1.Location = new System.Drawing.Point(102, 305);
            this.gunaDataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaDataGridView1.Name = "gunaDataGridView1";
            this.gunaDataGridView1.RowHeadersVisible = false;
            this.gunaDataGridView1.RowHeadersWidth = 62;
            this.gunaDataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.gunaDataGridView1.RowTemplate.Height = 28;
            this.gunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDataGridView1.Size = new System.Drawing.Size(1190, 429);
            this.gunaDataGridView1.TabIndex = 1;
            this.gunaDataGridView1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.WetAsphalt;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Height = 25;
            this.gunaDataGridView1.ThemeStyle.ReadOnly = false;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Height = 28;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.gunaDataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gunaDataGridView1_CellClick);
            this.gunaDataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gunaDataGridView1_CellEnter);
            // 
            // btn_ListaPag
            // 
            this.btn_ListaPag.AnimationHoverSpeed = 0.07F;
            this.btn_ListaPag.AnimationSpeed = 0.03F;
            this.btn_ListaPag.BackColor = System.Drawing.Color.Transparent;
            this.btn_ListaPag.BaseColor = System.Drawing.Color.DimGray;
            this.btn_ListaPag.BorderColor = System.Drawing.Color.Black;
            this.btn_ListaPag.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_ListaPag.FocusedColor = System.Drawing.Color.Empty;
            this.btn_ListaPag.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_ListaPag.ForeColor = System.Drawing.Color.White;
            this.btn_ListaPag.Image = null;
            this.btn_ListaPag.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_ListaPag.Location = new System.Drawing.Point(528, 18);
            this.btn_ListaPag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ListaPag.Name = "btn_ListaPag";
            this.btn_ListaPag.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.btn_ListaPag.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_ListaPag.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_ListaPag.OnHoverImage = null;
            this.btn_ListaPag.OnPressedColor = System.Drawing.Color.Black;
            this.btn_ListaPag.Radius = 10;
            this.btn_ListaPag.Size = new System.Drawing.Size(324, 52);
            this.btn_ListaPag.TabIndex = 3;
            this.btn_ListaPag.Text = "LISTA DE PAGAMENTOS";
            this.btn_ListaPag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_ListaPag.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // Btn_Visualizar
            // 
            this.Btn_Visualizar.AnimationHoverSpeed = 0.07F;
            this.Btn_Visualizar.AnimationSpeed = 0.03F;
            this.Btn_Visualizar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Visualizar.BaseColor = System.Drawing.Color.DimGray;
            this.Btn_Visualizar.BorderColor = System.Drawing.Color.Black;
            this.Btn_Visualizar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Btn_Visualizar.FocusedColor = System.Drawing.Color.Empty;
            this.Btn_Visualizar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_Visualizar.ForeColor = System.Drawing.Color.White;
            this.Btn_Visualizar.Image = null;
            this.Btn_Visualizar.ImageSize = new System.Drawing.Size(20, 20);
            this.Btn_Visualizar.Location = new System.Drawing.Point(102, 18);
            this.Btn_Visualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Visualizar.Name = "Btn_Visualizar";
            this.Btn_Visualizar.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.Btn_Visualizar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Btn_Visualizar.OnHoverForeColor = System.Drawing.Color.White;
            this.Btn_Visualizar.OnHoverImage = null;
            this.Btn_Visualizar.OnPressedColor = System.Drawing.Color.Black;
            this.Btn_Visualizar.Radius = 10;
            this.Btn_Visualizar.Size = new System.Drawing.Size(324, 52);
            this.Btn_Visualizar.TabIndex = 4;
            this.Btn_Visualizar.Text = "VISUALIZAR TURMAS";
            this.Btn_Visualizar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Btn_Visualizar.Click += new System.EventHandler(this.gunaButton3_Click);
            // 
            // btn_RefreshPag
            // 
            this.btn_RefreshPag.AnimationHoverSpeed = 0.07F;
            this.btn_RefreshPag.AnimationSpeed = 0.03F;
            this.btn_RefreshPag.BackColor = System.Drawing.Color.Transparent;
            this.btn_RefreshPag.BaseColor = System.Drawing.Color.DimGray;
            this.btn_RefreshPag.BorderColor = System.Drawing.Color.Black;
            this.btn_RefreshPag.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_RefreshPag.FocusedColor = System.Drawing.Color.Empty;
            this.btn_RefreshPag.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_RefreshPag.ForeColor = System.Drawing.Color.White;
            this.btn_RefreshPag.Image = null;
            this.btn_RefreshPag.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_RefreshPag.Location = new System.Drawing.Point(968, 18);
            this.btn_RefreshPag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_RefreshPag.Name = "btn_RefreshPag";
            this.btn_RefreshPag.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.btn_RefreshPag.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_RefreshPag.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_RefreshPag.OnHoverImage = null;
            this.btn_RefreshPag.OnPressedColor = System.Drawing.Color.Black;
            this.btn_RefreshPag.Radius = 10;
            this.btn_RefreshPag.Size = new System.Drawing.Size(324, 52);
            this.btn_RefreshPag.TabIndex = 5;
            this.btn_RefreshPag.Text = "ACTUALIZAR PAGAMENTO";
            this.btn_RefreshPag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_RefreshPag.Click += new System.EventHandler(this.btn_RefreshPag_Click);
            // 
            // lbApagar
            // 
            this.lbApagar.AutoSize = true;
            this.lbApagar.Location = new System.Drawing.Point(1331, 318);
            this.lbApagar.Name = "lbApagar";
            this.lbApagar.Size = new System.Drawing.Size(12, 17);
            this.lbApagar.TabIndex = 8;
            this.lbApagar.Text = ".";
            this.lbApagar.Visible = false;
            // 
            // lbnum
            // 
            this.lbnum.AutoSize = true;
            this.lbnum.Location = new System.Drawing.Point(1331, 394);
            this.lbnum.Name = "lbnum";
            this.lbnum.Size = new System.Drawing.Size(12, 17);
            this.lbnum.TabIndex = 9;
            this.lbnum.Text = ".";
            this.lbnum.Visible = false;
            // 
            // lbsexo
            // 
            this.lbsexo.AutoSize = true;
            this.lbsexo.Location = new System.Drawing.Point(1331, 459);
            this.lbsexo.Name = "lbsexo";
            this.lbsexo.Size = new System.Drawing.Size(12, 17);
            this.lbsexo.TabIndex = 11;
            this.lbsexo.Text = ".";
            this.lbsexo.Visible = false;
            // 
            // lbnome
            // 
            this.lbnome.AutoSize = true;
            this.lbnome.Location = new System.Drawing.Point(1331, 429);
            this.lbnome.Name = "lbnome";
            this.lbnome.Size = new System.Drawing.Size(12, 17);
            this.lbnome.TabIndex = 10;
            this.lbnome.Text = ".";
            this.lbnome.Visible = false;
            // 
            // btactualizar
            // 
            this.btactualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btactualizar.AnimationHoverSpeed = 0.07F;
            this.btactualizar.AnimationSpeed = 0.03F;
            this.btactualizar.BackColor = System.Drawing.Color.Transparent;
            this.btactualizar.BaseColor = System.Drawing.Color.DimGray;
            this.btactualizar.BorderColor = System.Drawing.Color.Black;
            this.btactualizar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btactualizar.FocusedColor = System.Drawing.Color.Empty;
            this.btactualizar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btactualizar.ForeColor = System.Drawing.Color.White;
            this.btactualizar.Image = null;
            this.btactualizar.ImageSize = new System.Drawing.Size(20, 20);
            this.btactualizar.Location = new System.Drawing.Point(102, 756);
            this.btactualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btactualizar.Name = "btactualizar";
            this.btactualizar.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.btactualizar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btactualizar.OnHoverForeColor = System.Drawing.Color.White;
            this.btactualizar.OnHoverImage = null;
            this.btactualizar.OnPressedColor = System.Drawing.Color.Black;
            this.btactualizar.Radius = 2;
            this.btactualizar.Size = new System.Drawing.Size(158, 28);
            this.btactualizar.TabIndex = 12;
            this.btactualizar.Text = "ATUALIZAR CAMPO";
            this.btactualizar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btactualizar.Click += new System.EventHandler(this.btactualizar_Click_1);
            // 
            // btApagar
            // 
            this.btApagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btApagar.AnimationHoverSpeed = 0.07F;
            this.btApagar.AnimationSpeed = 0.03F;
            this.btApagar.BackColor = System.Drawing.Color.Transparent;
            this.btApagar.BaseColor = System.Drawing.Color.DimGray;
            this.btApagar.BorderColor = System.Drawing.Color.Black;
            this.btApagar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btApagar.FocusedColor = System.Drawing.Color.Empty;
            this.btApagar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btApagar.ForeColor = System.Drawing.Color.White;
            this.btApagar.Image = null;
            this.btApagar.ImageSize = new System.Drawing.Size(20, 20);
            this.btApagar.Location = new System.Drawing.Point(290, 756);
            this.btApagar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btApagar.Name = "btApagar";
            this.btApagar.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.btApagar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btApagar.OnHoverForeColor = System.Drawing.Color.White;
            this.btApagar.OnHoverImage = null;
            this.btApagar.OnPressedColor = System.Drawing.Color.Black;
            this.btApagar.Radius = 2;
            this.btApagar.Size = new System.Drawing.Size(156, 28);
            this.btApagar.TabIndex = 13;
            this.btApagar.Text = "ELIMINAR REGISTRO";
            this.btApagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btApagar.Click += new System.EventHandler(this.btApagar_Click_1);
            // 
            // TelaArquivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1402, 808);
            this.Controls.Add(this.btApagar);
            this.Controls.Add(this.btactualizar);
            this.Controls.Add(this.lbsexo);
            this.Controls.Add(this.lbnome);
            this.Controls.Add(this.lbnum);
            this.Controls.Add(this.lbApagar);
            this.Controls.Add(this.btn_RefreshPag);
            this.Controls.Add(this.Btn_Visualizar);
            this.Controls.Add(this.btn_ListaPag);
            this.Controls.Add(this.gunaDataGridView1);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TelaArquivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arquivos";
            this.Load += new System.EventHandler(this.TelaArquivos_Load);
            this.DoubleClick += new System.EventHandler(this.TelaArquivos_DoubleClick);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.panelsexo.ResumeLayout(false);
            this.panelsexo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaPanel panelsexo;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaCheckBox labelF_Npag;
        private Guna.UI.WinForms.GunaCheckBox labelFiltroM_Pago;
        private Guna.UI.WinForms.GunaDataGridView gunaDataGridView1;
        private Guna.UI.WinForms.GunaButton btn_ListaPag;
        private Guna.UI.WinForms.GunaButton Btn_Visualizar;
        private Guna.UI.WinForms.GunaButton btn_RefreshPag;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboxMeses;
        private System.Windows.Forms.Label lbApagar;
        private System.Windows.Forms.Label lbnum;
        private System.Windows.Forms.Label lbsexo;
        private System.Windows.Forms.Label lbnome;
        private Guna.UI.WinForms.GunaLabel lbmesf;
        private Guna.UI.WinForms.GunaLabel labelMes;
        private Guna.UI.WinForms.GunaButton btactualizar;
        private Guna.UI.WinForms.GunaButton btApagar;
    }
}