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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tSala = new Guna.UI.WinForms.GunaTextBox();
            this.tNome = new Guna.UI.WinForms.GunaTextBox();
            this.tClasse = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tTurno = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(532, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "CANCELAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(532, 133);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 57);
            this.button2.TabIndex = 1;
            this.button2.Text = "ADD";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tSala
            // 
            this.tSala.BaseColor = System.Drawing.Color.White;
            this.tSala.BorderColor = System.Drawing.Color.Silver;
            this.tSala.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tSala.FocusedBaseColor = System.Drawing.Color.White;
            this.tSala.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tSala.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tSala.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tSala.Location = new System.Drawing.Point(96, 223);
            this.tSala.Name = "tSala";
            this.tSala.PasswordChar = '\0';
            this.tSala.SelectedText = "";
            this.tSala.Size = new System.Drawing.Size(216, 36);
            this.tSala.TabIndex = 3;
            // 
            // tNome
            // 
            this.tNome.BaseColor = System.Drawing.Color.White;
            this.tNome.BorderColor = System.Drawing.Color.Silver;
            this.tNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tNome.FocusedBaseColor = System.Drawing.Color.White;
            this.tNome.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tNome.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tNome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tNome.Location = new System.Drawing.Point(96, 145);
            this.tNome.Name = "tNome";
            this.tNome.PasswordChar = '\0';
            this.tNome.SelectedText = "";
            this.tNome.Size = new System.Drawing.Size(216, 36);
            this.tNome.TabIndex = 4;
            // 
            // tClasse
            // 
            this.tClasse.BackColor = System.Drawing.Color.Transparent;
            this.tClasse.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.tClasse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tClasse.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tClasse.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tClasse.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tClasse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.tClasse.ItemHeight = 30;
            this.tClasse.Items.AddRange(new object[] {
            "7",
            "8",
            "9"});
            this.tClasse.Location = new System.Drawing.Point(96, 65);
            this.tClasse.Name = "tClasse";
            this.tClasse.Size = new System.Drawing.Size(216, 36);
            this.tClasse.TabIndex = 5;
            // 
            // tTurno
            // 
            this.tTurno.BackColor = System.Drawing.Color.Transparent;
            this.tTurno.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.tTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tTurno.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tTurno.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tTurno.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tTurno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.tTurno.ItemHeight = 30;
            this.tTurno.Items.AddRange(new object[] {
            "MANHÃ",
            "TARDE"});
            this.tTurno.Location = new System.Drawing.Point(96, 309);
            this.tTurno.Name = "tTurno";
            this.tTurno.Size = new System.Drawing.Size(216, 36);
            this.tTurno.TabIndex = 6;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(96, 34);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(112, 25);
            this.gunaLabel1.TabIndex = 7;
            this.gunaLabel1.Text = "Nova Classe:";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(96, 117);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(145, 25);
            this.gunaLabel2.TabIndex = 8;
            this.gunaLabel2.Text = "Nome da Turma:";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(96, 195);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(48, 25);
            this.gunaLabel3.TabIndex = 9;
            this.gunaLabel3.Text = "Sala:";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.Location = new System.Drawing.Point(96, 281);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(62, 25);
            this.gunaLabel4.TabIndex = 10;
            this.gunaLabel4.Text = "Turno:";
            // 
            // TelaNovaTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.tTurno);
            this.Controls.Add(this.tClasse);
            this.Controls.Add(this.tNome);
            this.Controls.Add(this.tSala);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaNovaTurma";
            this.Text = "TelaNovaTurma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Guna.UI.WinForms.GunaTextBox tSala;
        private Guna.UI.WinForms.GunaTextBox tNome;
        private Guna.UI2.WinForms.Guna2ComboBox tClasse;
        private Guna.UI2.WinForms.Guna2ComboBox tTurno;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
    }
}