namespace ControloDePropinas.Telas
{
    partial class TelaCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastro));
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.TxtNum = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.buttonCancelar = new Guna.UI.WinForms.GunaAdvenceButton();
            this.buttonEntrar = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.TxtProc = new Guna.UI.WinForms.GunaTextBox();
            this.comboSexo = new System.Windows.Forms.ComboBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.TxtNome = new Guna.UI.WinForms.GunaTextBox();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.comboTurmas = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(110, 499);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(79, 30);
            this.gunaLabel3.TabIndex = 14;
            this.gunaLabel3.Text = "Turma:";
            this.gunaLabel3.Click += new System.EventHandler(this.gunaLabel3_Click);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(110, 323);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(197, 30);
            this.gunaLabel2.TabIndex = 11;
            this.gunaLabel2.Text = "Número na Turma:";
            // 
            // TxtNum
            // 
            this.TxtNum.BackColor = System.Drawing.Color.Transparent;
            this.TxtNum.BaseColor = System.Drawing.Color.White;
            this.TxtNum.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(158)))), ((int)(((byte)(240)))));
            this.TxtNum.BorderSize = 1;
            this.TxtNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNum.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtNum.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(158)))), ((int)(((byte)(240)))));
            this.TxtNum.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtNum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNum.Location = new System.Drawing.Point(115, 355);
            this.TxtNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtNum.Name = "TxtNum";
            this.TxtNum.PasswordChar = '\0';
            this.TxtNum.Radius = 10;
            this.TxtNum.SelectedText = "";
            this.TxtNum.Size = new System.Drawing.Size(478, 58);
            this.TxtNum.TabIndex = 2;
            this.TxtNum.TextChanged += new System.EventHandler(this.TxtNum_TextChanged);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(162, 21);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(407, 54);
            this.gunaLabel1.TabIndex = 9;
            this.gunaLabel1.Text = "CADASTRAR ALUNO";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.AnimationHoverSpeed = 0.07F;
            this.buttonCancelar.AnimationSpeed = 0.03F;
            this.buttonCancelar.BackColor = System.Drawing.Color.Transparent;
            this.buttonCancelar.BaseColor = System.Drawing.Color.White;
            this.buttonCancelar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(158)))), ((int)(((byte)(240)))));
            this.buttonCancelar.BorderSize = 1;
            this.buttonCancelar.CheckedBaseColor = System.Drawing.Color.Gray;
            this.buttonCancelar.CheckedBorderColor = System.Drawing.Color.Black;
            this.buttonCancelar.CheckedForeColor = System.Drawing.Color.White;
            this.buttonCancelar.CheckedImage = ((System.Drawing.Image)(resources.GetObject("buttonCancelar.CheckedImage")));
            this.buttonCancelar.CheckedLineColor = System.Drawing.Color.DimGray;
            this.buttonCancelar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonCancelar.FocusedColor = System.Drawing.Color.Empty;
            this.buttonCancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.ForeColor = System.Drawing.Color.Black;
            this.buttonCancelar.Image = null;
            this.buttonCancelar.ImageSize = new System.Drawing.Size(20, 20);
            this.buttonCancelar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.buttonCancelar.Location = new System.Drawing.Point(407, 693);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.buttonCancelar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.buttonCancelar.OnHoverForeColor = System.Drawing.Color.White;
            this.buttonCancelar.OnHoverImage = null;
            this.buttonCancelar.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(158)))), ((int)(((byte)(240)))));
            this.buttonCancelar.OnPressedColor = System.Drawing.Color.Black;
            this.buttonCancelar.Radius = 10;
            this.buttonCancelar.Size = new System.Drawing.Size(186, 58);
            this.buttonCancelar.TabIndex = 16;
            this.buttonCancelar.Text = "SAIR";
            this.buttonCancelar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonEntrar
            // 
            this.buttonEntrar.AnimationHoverSpeed = 0.07F;
            this.buttonEntrar.AnimationSpeed = 0.03F;
            this.buttonEntrar.BackColor = System.Drawing.Color.Transparent;
            this.buttonEntrar.BaseColor = System.Drawing.Color.White;
            this.buttonEntrar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(158)))), ((int)(((byte)(240)))));
            this.buttonEntrar.BorderSize = 1;
            this.buttonEntrar.CheckedBaseColor = System.Drawing.Color.Gray;
            this.buttonEntrar.CheckedBorderColor = System.Drawing.Color.Black;
            this.buttonEntrar.CheckedForeColor = System.Drawing.Color.White;
            this.buttonEntrar.CheckedImage = ((System.Drawing.Image)(resources.GetObject("buttonEntrar.CheckedImage")));
            this.buttonEntrar.CheckedLineColor = System.Drawing.Color.DimGray;
            this.buttonEntrar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonEntrar.FocusedColor = System.Drawing.Color.Empty;
            this.buttonEntrar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEntrar.ForeColor = System.Drawing.Color.Black;
            this.buttonEntrar.Image = null;
            this.buttonEntrar.ImageSize = new System.Drawing.Size(20, 20);
            this.buttonEntrar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.buttonEntrar.Location = new System.Drawing.Point(115, 693);
            this.buttonEntrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEntrar.Name = "buttonEntrar";
            this.buttonEntrar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.buttonEntrar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.buttonEntrar.OnHoverForeColor = System.Drawing.Color.White;
            this.buttonEntrar.OnHoverImage = null;
            this.buttonEntrar.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(158)))), ((int)(((byte)(240)))));
            this.buttonEntrar.OnPressedColor = System.Drawing.Color.Black;
            this.buttonEntrar.Radius = 10;
            this.buttonEntrar.Size = new System.Drawing.Size(186, 58);
            this.buttonEntrar.TabIndex = 15;
            this.buttonEntrar.Text = "CADASTRAR";
            this.buttonEntrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.buttonEntrar.Click += new System.EventHandler(this.buttonEntrar_Click);
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.gunaElipsePanel1.Location = new System.Drawing.Point(731, 21);
            this.gunaElipsePanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Radius = 10;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(649, 751);
            this.gunaElipsePanel1.TabIndex = 17;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(110, 422);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(66, 30);
            this.gunaLabel4.TabIndex = 18;
            this.gunaLabel4.Text = "Sexo:";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.Location = new System.Drawing.Point(114, 111);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(170, 30);
            this.gunaLabel5.TabIndex = 20;
            this.gunaLabel5.Text = "Nº do Processo:";
            // 
            // TxtProc
            // 
            this.TxtProc.BackColor = System.Drawing.Color.Transparent;
            this.TxtProc.BaseColor = System.Drawing.Color.White;
            this.TxtProc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(158)))), ((int)(((byte)(240)))));
            this.TxtProc.BorderSize = 1;
            this.TxtProc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtProc.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtProc.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(158)))), ((int)(((byte)(240)))));
            this.TxtProc.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtProc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtProc.Location = new System.Drawing.Point(115, 143);
            this.TxtProc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtProc.Name = "TxtProc";
            this.TxtProc.PasswordChar = '\0';
            this.TxtProc.Radius = 10;
            this.TxtProc.SelectedText = "";
            this.TxtProc.Size = new System.Drawing.Size(478, 58);
            this.TxtProc.TabIndex = 0;
            // 
            // comboSexo
            // 
            this.comboSexo.BackColor = System.Drawing.SystemColors.Window;
            this.comboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSexo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSexo.FormattingEnabled = true;
            this.comboSexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.comboSexo.Location = new System.Drawing.Point(115, 455);
            this.comboSexo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboSexo.Name = "comboSexo";
            this.comboSexo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboSexo.Size = new System.Drawing.Size(478, 37);
            this.comboSexo.TabIndex = 3;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.Location = new System.Drawing.Point(110, 216);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(79, 30);
            this.gunaLabel6.TabIndex = 23;
            this.gunaLabel6.Text = "Nome:";
            // 
            // TxtNome
            // 
            this.TxtNome.BackColor = System.Drawing.Color.Transparent;
            this.TxtNome.BaseColor = System.Drawing.Color.White;
            this.TxtNome.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(158)))), ((int)(((byte)(240)))));
            this.TxtNome.BorderSize = 1;
            this.TxtNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNome.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtNome.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(158)))), ((int)(((byte)(240)))));
            this.TxtNome.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNome.Location = new System.Drawing.Point(115, 248);
            this.TxtNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.PasswordChar = '\0';
            this.TxtNome.Radius = 10;
            this.TxtNome.SelectedText = "";
            this.TxtNome.Size = new System.Drawing.Size(478, 58);
            this.TxtNome.TabIndex = 1;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // comboTurmas
            // 
            this.comboTurmas.BackColor = System.Drawing.SystemColors.Window;
            this.comboTurmas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTurmas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTurmas.FormattingEnabled = true;
            this.comboTurmas.Location = new System.Drawing.Point(115, 532);
            this.comboTurmas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboTurmas.Name = "comboTurmas";
            this.comboTurmas.Size = new System.Drawing.Size(478, 37);
            this.comboTurmas.TabIndex = 4;
            // 
            // TelaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1402, 808);
            this.Controls.Add(this.comboTurmas);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.comboSexo);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.TxtProc);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaElipsePanel1);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonEntrar);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.TxtNum);
            this.Controls.Add(this.gunaLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TelaCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaCadastro";
            this.Load += new System.EventHandler(this.TelaCadastro_Load);
            this.DoubleClick += new System.EventHandler(this.TelaCadastro_DoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaAdvenceButton buttonCancelar;
        private Guna.UI.WinForms.GunaAdvenceButton buttonEntrar;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTextBox TxtNum;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaTextBox TxtProc;
        private System.Windows.Forms.ComboBox comboSexo;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaTextBox TxtNome;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.ComboBox comboTurmas;
    }
}