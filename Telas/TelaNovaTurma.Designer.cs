namespace ControloDePropinas
{
    partial class TelaNovaTurma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaNovaTurma));
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.tSala = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.tNome = new Guna.UI.WinForms.GunaTextBox();
            this.tClasse = new System.Windows.Forms.ComboBox();
            this.tTurno = new System.Windows.Forms.ComboBox();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.button1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.button2 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.Location = new System.Drawing.Point(63, 198);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(52, 25);
            this.gunaLabel6.TabIndex = 27;
            this.gunaLabel6.Text = "Sala:";
            // 
            // tSala
            // 
            this.tSala.BackColor = System.Drawing.Color.Transparent;
            this.tSala.BaseColor = System.Drawing.Color.White;
            this.tSala.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(158)))), ((int)(((byte)(240)))));
            this.tSala.BorderSize = 1;
            this.tSala.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tSala.FocusedBaseColor = System.Drawing.Color.White;
            this.tSala.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(158)))), ((int)(((byte)(240)))));
            this.tSala.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tSala.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSala.Location = new System.Drawing.Point(63, 228);
            this.tSala.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tSala.Name = "tSala";
            this.tSala.PasswordChar = '\0';
            this.tSala.Radius = 10;
            this.tSala.SelectedText = "";
            this.tSala.Size = new System.Drawing.Size(425, 46);
            this.tSala.TabIndex = 25;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.Location = new System.Drawing.Point(63, 103);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(155, 25);
            this.gunaLabel5.TabIndex = 26;
            this.gunaLabel5.Text = "Nome da Turma:";
            // 
            // tNome
            // 
            this.tNome.BackColor = System.Drawing.Color.Transparent;
            this.tNome.BaseColor = System.Drawing.Color.White;
            this.tNome.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(158)))), ((int)(((byte)(240)))));
            this.tNome.BorderSize = 1;
            this.tNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tNome.FocusedBaseColor = System.Drawing.Color.White;
            this.tNome.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(158)))), ((int)(((byte)(240)))));
            this.tNome.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tNome.Location = new System.Drawing.Point(63, 134);
            this.tNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tNome.Name = "tNome";
            this.tNome.PasswordChar = '\0';
            this.tNome.Radius = 10;
            this.tNome.SelectedText = "";
            this.tNome.Size = new System.Drawing.Size(425, 46);
            this.tNome.TabIndex = 24;
            // 
            // tClasse
            // 
            this.tClasse.BackColor = System.Drawing.SystemColors.Window;
            this.tClasse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tClasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tClasse.FormattingEnabled = true;
            this.tClasse.Items.AddRange(new object[] {
            "7",
            "8",
            "9"});
            this.tClasse.Location = new System.Drawing.Point(66, 415);
            this.tClasse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tClasse.Name = "tClasse";
            this.tClasse.Size = new System.Drawing.Size(425, 33);
            this.tClasse.TabIndex = 29;
            // 
            // tTurno
            // 
            this.tTurno.BackColor = System.Drawing.SystemColors.Window;
            this.tTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tTurno.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.tTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tTurno.FormattingEnabled = true;
            this.tTurno.Items.AddRange(new object[] {
            "MANHÃ",
            "TARDE"});
            this.tTurno.Location = new System.Drawing.Point(67, 326);
            this.tTurno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tTurno.Name = "tTurno";
            this.tTurno.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tTurno.Size = new System.Drawing.Size(425, 33);
            this.tTurno.TabIndex = 28;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.Location = new System.Drawing.Point(63, 296);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(66, 25);
            this.gunaLabel7.TabIndex = 33;
            this.gunaLabel7.Text = "Turno:";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.AnimationHoverSpeed = 0.07F;
            this.button1.AnimationSpeed = 0.03F;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BaseColor = System.Drawing.Color.White;
            this.button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(158)))), ((int)(((byte)(240)))));
            this.button1.BorderSize = 1;
            this.button1.CheckedBaseColor = System.Drawing.Color.Gray;
            this.button1.CheckedBorderColor = System.Drawing.Color.Black;
            this.button1.CheckedForeColor = System.Drawing.Color.White;
            this.button1.CheckedImage = ((System.Drawing.Image)(resources.GetObject("button1.CheckedImage")));
            this.button1.CheckedLineColor = System.Drawing.Color.DimGray;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.button1.FocusedColor = System.Drawing.Color.Empty;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = null;
            this.button1.ImageSize = new System.Drawing.Size(20, 20);
            this.button1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.button1.Location = new System.Drawing.Point(323, 573);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.OnHoverBaseColor = System.Drawing.Color.DarkGray;
            this.button1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.button1.OnHoverForeColor = System.Drawing.Color.White;
            this.button1.OnHoverImage = null;
            this.button1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(158)))), ((int)(((byte)(240)))));
            this.button1.OnPressedColor = System.Drawing.Color.Black;
            this.button1.Radius = 10;
            this.button1.Size = new System.Drawing.Size(165, 46);
            this.button1.TabIndex = 32;
            this.button1.Text = "CANCELAR";
            this.button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.AnimationHoverSpeed = 0.07F;
            this.button2.AnimationSpeed = 0.03F;
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BaseColor = System.Drawing.Color.White;
            this.button2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(158)))), ((int)(((byte)(240)))));
            this.button2.BorderSize = 1;
            this.button2.CheckedBaseColor = System.Drawing.Color.Gray;
            this.button2.CheckedBorderColor = System.Drawing.Color.Black;
            this.button2.CheckedForeColor = System.Drawing.Color.White;
            this.button2.CheckedImage = ((System.Drawing.Image)(resources.GetObject("button2.CheckedImage")));
            this.button2.CheckedLineColor = System.Drawing.Color.DimGray;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.button2.FocusedColor = System.Drawing.Color.Empty;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = null;
            this.button2.ImageSize = new System.Drawing.Size(20, 20);
            this.button2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.button2.Location = new System.Drawing.Point(63, 573);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.OnHoverBaseColor = System.Drawing.Color.DarkGray;
            this.button2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.button2.OnHoverForeColor = System.Drawing.Color.White;
            this.button2.OnHoverImage = null;
            this.button2.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(158)))), ((int)(((byte)(240)))));
            this.button2.OnPressedColor = System.Drawing.Color.Black;
            this.button2.Radius = 10;
            this.button2.Size = new System.Drawing.Size(165, 46);
            this.button2.TabIndex = 31;
            this.button2.Text = "ADICIONAR";
            this.button2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel8.Location = new System.Drawing.Point(62, 386);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(121, 25);
            this.gunaLabel8.TabIndex = 30;
            this.gunaLabel8.Text = "Nova Classe:";
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.gunaElipsePanel1.Location = new System.Drawing.Point(567, 27);
            this.gunaElipsePanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Radius = 10;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(577, 601);
            this.gunaElipsePanel1.TabIndex = 34;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 15;
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(104, 27);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(353, 46);
            this.gunaLabel1.TabIndex = 35;
            this.gunaLabel1.Text = "CADASTRAR TURMA";
            // 
            // TelaNovaTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1170, 659);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaElipsePanel1);
            this.Controls.Add(this.tClasse);
            this.Controls.Add(this.tTurno);
            this.Controls.Add(this.gunaLabel7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.gunaLabel8);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.tSala);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.tNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TelaNovaTurma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaNovaTurma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaTextBox tSala;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaTextBox tNome;
        private System.Windows.Forms.ComboBox tClasse;
        private System.Windows.Forms.ComboBox tTurno;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaAdvenceButton button1;
        private Guna.UI.WinForms.GunaAdvenceButton button2;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
    }
}