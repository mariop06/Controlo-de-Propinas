namespace ControloDePropinas
{
    partial class TelaDePagamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaDePagamentos));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.comboTurmas = new System.Windows.Forms.ComboBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.buttonCancelar = new Guna.UI.WinForms.GunaAdvenceButton();
            this.buttonEntrar = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.TituloTela = new Guna.UI.WinForms.GunaLabel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.comboAlunos = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
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
            this.comboTurmas.Location = new System.Drawing.Point(86, 208);
            this.comboTurmas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboTurmas.Name = "comboTurmas";
            this.comboTurmas.Size = new System.Drawing.Size(478, 37);
            this.comboTurmas.TabIndex = 28;
            this.comboTurmas.TextChanged += new System.EventHandler(this.comboTurmas_TextChanged);
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.Location = new System.Drawing.Point(85, 318);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(177, 30);
            this.gunaLabel6.TabIndex = 37;
            this.gunaLabel6.Text = "Nome do Aluno:";
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.gunaElipsePanel1.Location = new System.Drawing.Point(687, 29);
            this.gunaElipsePanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Radius = 10;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(649, 751);
            this.gunaElipsePanel1.TabIndex = 34;
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
            this.buttonCancelar.Location = new System.Drawing.Point(382, 644);
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
            this.buttonCancelar.TabIndex = 33;
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
            this.buttonEntrar.Location = new System.Drawing.Point(90, 644);
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
            this.buttonEntrar.TabIndex = 32;
            this.buttonEntrar.Text = "CONFIRMAR";
            this.buttonEntrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.buttonEntrar.Click += new System.EventHandler(this.buttonEntrar_Click);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(81, 175);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(177, 30);
            this.gunaLabel3.TabIndex = 31;
            this.gunaLabel3.Text = "Turma do Aluno:";
            // 
            // TituloTela
            // 
            this.TituloTela.AutoSize = true;
            this.TituloTela.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloTela.Location = new System.Drawing.Point(63, 43);
            this.TituloTela.Name = "TituloTela";
            this.TituloTela.Size = new System.Drawing.Size(523, 54);
            this.TituloTela.TabIndex = 29;
            this.TituloTela.Text = "CONFIRMAR PAGAMENTO\r\n";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Setembro",
            "Outubro",
            "Novembro",
            "Dezembro",
            "Janeiro",
            "Fevereiro",
            "Marco",
            "Abril",
            "Maio",
            "Junho"});
            this.comboBox1.Location = new System.Drawing.Point(90, 506);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(478, 37);
            this.comboBox1.TabIndex = 38;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(85, 473);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(138, 30);
            this.gunaLabel1.TabIndex = 39;
            this.gunaLabel1.Text = "Mês a Pagar:";
            // 
            // comboAlunos
            // 
            this.comboAlunos.BackColor = System.Drawing.SystemColors.Window;
            this.comboAlunos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAlunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboAlunos.FormattingEnabled = true;
            this.comboAlunos.Location = new System.Drawing.Point(90, 350);
            this.comboAlunos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboAlunos.Name = "comboAlunos";
            this.comboAlunos.Size = new System.Drawing.Size(478, 37);
            this.comboAlunos.TabIndex = 40;
            // 
            // TelaDePagamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 808);
            this.Controls.Add(this.comboAlunos);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.comboTurmas);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.gunaElipsePanel1);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonEntrar);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.TituloTela);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaDePagamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaDePagamentos";
            this.Load += new System.EventHandler(this.TelaDePagamentos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.ComboBox comboBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.ComboBox comboTurmas;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaAdvenceButton buttonCancelar;
        private Guna.UI.WinForms.GunaAdvenceButton buttonEntrar;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel TituloTela;
        private System.Windows.Forms.ComboBox comboAlunos;
    }
}