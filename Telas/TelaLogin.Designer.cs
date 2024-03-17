namespace ControloDePropinas
{
    partial class TelaLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLogin));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtUsuario = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.txtSenha = new Guna.UI.WinForms.GunaTextBox();
            this.buttonEntrar = new Guna.UI.WinForms.GunaAdvenceButton();
            this.buttonCancelar = new Guna.UI.WinForms.GunaAdvenceButton();
            this.circleProgress = new Guna.UI.WinForms.GunaWinCircleProgressIndicator();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 15;
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.gunaElipsePanel1.Location = new System.Drawing.Point(621, 19);
            this.gunaElipsePanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Radius = 10;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(519, 620);
            this.gunaElipsePanel1.TabIndex = 0;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(217, 38);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(153, 46);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "ENTRAR";
            this.gunaLabel1.Click += new System.EventHandler(this.gunaLabel1_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.Transparent;
            this.txtUsuario.BaseColor = System.Drawing.Color.White;
            this.txtUsuario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(158)))), ((int)(((byte)(240)))));
            this.txtUsuario.BorderSize = 1;
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.FocusedBaseColor = System.Drawing.Color.White;
            this.txtUsuario.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(158)))), ((int)(((byte)(240)))));
            this.txtUsuario.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(94, 178);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.Radius = 10;
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.Size = new System.Drawing.Size(422, 58);
            this.txtUsuario.TabIndex = 3;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(102, 150);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(82, 25);
            this.gunaLabel2.TabIndex = 4;
            this.gunaLabel2.Text = "Usuário:";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(102, 275);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(69, 25);
            this.gunaLabel3.TabIndex = 6;
            this.gunaLabel3.Text = "Senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.Transparent;
            this.txtSenha.BaseColor = System.Drawing.Color.White;
            this.txtSenha.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(158)))), ((int)(((byte)(240)))));
            this.txtSenha.BorderSize = 1;
            this.txtSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSenha.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSenha.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(158)))), ((int)(((byte)(240)))));
            this.txtSenha.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSenha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(94, 302);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '\0';
            this.txtSenha.Radius = 10;
            this.txtSenha.SelectedText = "";
            this.txtSenha.Size = new System.Drawing.Size(422, 58);
            this.txtSenha.TabIndex = 5;
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
            this.buttonEntrar.Location = new System.Drawing.Point(94, 475);
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
            this.buttonEntrar.TabIndex = 7;
            this.buttonEntrar.Text = "ENTRAR";
            this.buttonEntrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.buttonEntrar.Click += new System.EventHandler(this.button_Click);
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
            this.buttonCancelar.Location = new System.Drawing.Point(331, 475);
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
            this.buttonCancelar.TabIndex = 8;
            this.buttonCancelar.Text = "CANCELAR";
            this.buttonCancelar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // circleProgress
            // 
            this.circleProgress.BackColor = System.Drawing.Color.Transparent;
            this.circleProgress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.circleProgress.Location = new System.Drawing.Point(150, 480);
            this.circleProgress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.circleProgress.Name = "circleProgress";
            this.circleProgress.ProgressColor = System.Drawing.Color.DodgerBlue;
            this.circleProgress.Size = new System.Drawing.Size(70, 48);
            this.circleProgress.TabIndex = 5;
            this.circleProgress.Visible = false;
            this.circleProgress.Load += new System.EventHandler(this.circleProgress_Load);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // TelaLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1159, 660);
            this.Controls.Add(this.circleProgress);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonEntrar);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaElipsePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TelaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Login";
            this.Load += new System.EventHandler(this.TelaLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox txtUsuario;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaTextBox txtSenha;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaAdvenceButton buttonEntrar;
        private Guna.UI.WinForms.GunaAdvenceButton buttonCancelar;
        private Guna.UI.WinForms.GunaWinCircleProgressIndicator circleProgress;
        private System.Windows.Forms.Timer timer1;
    }
}

