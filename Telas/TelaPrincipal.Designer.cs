namespace ControloDePropinas.Telas
{
    partial class TelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            this.sideBarP = new Guna.UI.WinForms.GunaPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.gunaPictureBox7 = new Guna.UI.WinForms.GunaPictureBox();
            this.btn_info = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_atividade = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_more = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_dash = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaPictureBox6 = new Guna.UI.WinForms.GunaPictureBox();
            this.btn_Inicio = new Guna.UI.WinForms.GunaAdvenceButton();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.sideBarP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // sideBarP
            // 
            this.sideBarP.AllowDrop = true;
            this.sideBarP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(187)))), ((int)(((byte)(201)))));
            this.sideBarP.Controls.Add(this.btn_info);
            this.sideBarP.Controls.Add(this.gunaPictureBox6);
            this.sideBarP.Controls.Add(this.label1);
            this.sideBarP.Controls.Add(this.btn_atividade);
            this.sideBarP.Controls.Add(this.btn_Inicio);
            this.sideBarP.Controls.Add(this.label4);
            this.sideBarP.Controls.Add(this.btn_more);
            this.sideBarP.Controls.Add(this.btn_dash);
            this.sideBarP.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBarP.Location = new System.Drawing.Point(0, 0);
            this.sideBarP.Margin = new System.Windows.Forms.Padding(0);
            this.sideBarP.MaximumSize = new System.Drawing.Size(275, 929);
            this.sideBarP.MinimumSize = new System.Drawing.Size(100, 929);
            this.sideBarP.Name = "sideBarP";
            this.sideBarP.Size = new System.Drawing.Size(100, 929);
            this.sideBarP.TabIndex = 0;
            this.sideBarP.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPrincipal_Paint);
            this.sideBarP.MouseHover += new System.EventHandler(this.sideBarP_MouseHover);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(6, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "__________";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(138, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1320, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________________" +
    "___";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.BackColor = System.Drawing.Color.Transparent;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(1152, 53);
            this.labelNome.MaximumSize = new System.Drawing.Size(300, 30);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(127, 25);
            this.labelNome.TabIndex = 4;
            this.labelNome.Text = "Mario Paulo";
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 20;
            this.gunaElipse1.TargetControl = this;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(7, 729);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "__________";
            // 
            // gunaPictureBox7
            // 
            this.gunaPictureBox7.BackgroundImage = global::ControloDePropinas.Properties.Resources.Frame_13;
            this.gunaPictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaPictureBox7.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox7.Location = new System.Drawing.Point(1370, 14);
            this.gunaPictureBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaPictureBox7.Name = "gunaPictureBox7";
            this.gunaPictureBox7.Size = new System.Drawing.Size(71, 64);
            this.gunaPictureBox7.TabIndex = 2;
            this.gunaPictureBox7.TabStop = false;
            // 
            // btn_info
            // 
            this.btn_info.AnimationHoverSpeed = 0.07F;
            this.btn_info.AnimationSpeed = 0.03F;
            this.btn_info.BackColor = System.Drawing.Color.Transparent;
            this.btn_info.BaseColor = System.Drawing.Color.Transparent;
            this.btn_info.BorderColor = System.Drawing.Color.Black;
            this.btn_info.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_info.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_info.CheckedForeColor = System.Drawing.Color.White;
            this.btn_info.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_info.CheckedImage")));
            this.btn_info.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_info.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_info.FocusedColor = System.Drawing.Color.Empty;
            this.btn_info.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_info.ForeColor = System.Drawing.Color.White;
            this.btn_info.Image = global::ControloDePropinas.Properties.Resources.info_2;
            this.btn_info.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_info.LineColor = System.Drawing.Color.Transparent;
            this.btn_info.Location = new System.Drawing.Point(29, 761);
            this.btn_info.Name = "btn_info";
            this.btn_info.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_info.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_info.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_info.OnHoverImage = null;
            this.btn_info.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_info.OnPressedColor = System.Drawing.Color.Black;
            this.btn_info.Radius = 5;
            this.btn_info.Size = new System.Drawing.Size(62, 60);
            this.btn_info.TabIndex = 6;
            this.btn_info.Text = "INFORMAÇÃO";
            // 
            // btn_atividade
            // 
            this.btn_atividade.AnimationHoverSpeed = 0.07F;
            this.btn_atividade.AnimationSpeed = 0.03F;
            this.btn_atividade.BackColor = System.Drawing.Color.Transparent;
            this.btn_atividade.BaseColor = System.Drawing.Color.Transparent;
            this.btn_atividade.BorderColor = System.Drawing.Color.Black;
            this.btn_atividade.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_atividade.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_atividade.CheckedForeColor = System.Drawing.Color.White;
            this.btn_atividade.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_atividade.CheckedImage")));
            this.btn_atividade.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_atividade.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_atividade.FocusedColor = System.Drawing.Color.Empty;
            this.btn_atividade.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atividade.ForeColor = System.Drawing.Color.White;
            this.btn_atividade.Image = global::ControloDePropinas.Properties.Resources.relatorio_2;
            this.btn_atividade.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_atividade.LineColor = System.Drawing.Color.Transparent;
            this.btn_atividade.Location = new System.Drawing.Point(23, 363);
            this.btn_atividade.Name = "btn_atividade";
            this.btn_atividade.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_atividade.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_atividade.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_atividade.OnHoverImage = null;
            this.btn_atividade.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_atividade.OnPressedColor = System.Drawing.Color.Black;
            this.btn_atividade.Radius = 5;
            this.btn_atividade.Size = new System.Drawing.Size(50, 60);
            this.btn_atividade.TabIndex = 6;
            this.btn_atividade.Text = "ATIVIDADES";
            // 
            // btn_more
            // 
            this.btn_more.AnimationHoverSpeed = 0.07F;
            this.btn_more.AnimationSpeed = 0.03F;
            this.btn_more.BackColor = System.Drawing.Color.Transparent;
            this.btn_more.BaseColor = System.Drawing.Color.Transparent;
            this.btn_more.BorderColor = System.Drawing.Color.Black;
            this.btn_more.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_more.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_more.CheckedForeColor = System.Drawing.Color.White;
            this.btn_more.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_more.CheckedImage")));
            this.btn_more.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_more.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_more.FocusedColor = System.Drawing.Color.Empty;
            this.btn_more.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_more.ForeColor = System.Drawing.Color.White;
            this.btn_more.Image = global::ControloDePropinas.Properties.Resources.adicionar_um_sinal_de_interface_de_contorno_de_pessoa_2;
            this.btn_more.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_more.LineColor = System.Drawing.Color.Transparent;
            this.btn_more.Location = new System.Drawing.Point(23, 296);
            this.btn_more.Name = "btn_more";
            this.btn_more.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_more.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_more.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_more.OnHoverImage = null;
            this.btn_more.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_more.OnPressedColor = System.Drawing.Color.Black;
            this.btn_more.Radius = 5;
            this.btn_more.Size = new System.Drawing.Size(50, 60);
            this.btn_more.TabIndex = 8;
            this.btn_more.Text = "MORE";
            // 
            // btn_dash
            // 
            this.btn_dash.AnimationHoverSpeed = 0.07F;
            this.btn_dash.AnimationSpeed = 0.03F;
            this.btn_dash.BackColor = System.Drawing.Color.Transparent;
            this.btn_dash.BaseColor = System.Drawing.Color.Transparent;
            this.btn_dash.BorderColor = System.Drawing.Color.Black;
            this.btn_dash.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_dash.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_dash.CheckedForeColor = System.Drawing.Color.White;
            this.btn_dash.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_dash.CheckedImage")));
            this.btn_dash.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_dash.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_dash.FocusedColor = System.Drawing.Color.Empty;
            this.btn_dash.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dash.ForeColor = System.Drawing.Color.White;
            this.btn_dash.Image = global::ControloDePropinas.Properties.Resources.painel_de_controle_2;
            this.btn_dash.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_dash.LineColor = System.Drawing.Color.Transparent;
            this.btn_dash.Location = new System.Drawing.Point(23, 225);
            this.btn_dash.Name = "btn_dash";
            this.btn_dash.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_dash.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_dash.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_dash.OnHoverImage = null;
            this.btn_dash.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_dash.OnPressedColor = System.Drawing.Color.Black;
            this.btn_dash.Radius = 5;
            this.btn_dash.Size = new System.Drawing.Size(50, 60);
            this.btn_dash.TabIndex = 7;
            this.btn_dash.Text = "DASHBOARD";
            // 
            // gunaPictureBox6
            // 
            this.gunaPictureBox6.BackgroundImage = global::ControloDePropinas.Properties.Resources.Frame_13;
            this.gunaPictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaPictureBox6.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox6.Location = new System.Drawing.Point(16, 14);
            this.gunaPictureBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaPictureBox6.Name = "gunaPictureBox6";
            this.gunaPictureBox6.Size = new System.Drawing.Size(71, 64);
            this.gunaPictureBox6.TabIndex = 1;
            this.gunaPictureBox6.TabStop = false;
            // 
            // btn_Inicio
            // 
            this.btn_Inicio.AnimationHoverSpeed = 0.07F;
            this.btn_Inicio.AnimationSpeed = 0.03F;
            this.btn_Inicio.BackColor = System.Drawing.Color.Transparent;
            this.btn_Inicio.BaseColor = System.Drawing.Color.Transparent;
            this.btn_Inicio.BorderColor = System.Drawing.Color.Black;
            this.btn_Inicio.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_Inicio.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_Inicio.CheckedForeColor = System.Drawing.Color.White;
            this.btn_Inicio.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_Inicio.CheckedImage")));
            this.btn_Inicio.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_Inicio.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Inicio.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Inicio.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Inicio.ForeColor = System.Drawing.Color.White;
            this.btn_Inicio.Image = global::ControloDePropinas.Properties.Resources.botao_de_inicio_2;
            this.btn_Inicio.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Inicio.LineColor = System.Drawing.Color.Transparent;
            this.btn_Inicio.Location = new System.Drawing.Point(23, 153);
            this.btn_Inicio.Name = "btn_Inicio";
            this.btn_Inicio.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Inicio.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Inicio.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Inicio.OnHoverImage = null;
            this.btn_Inicio.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Inicio.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Inicio.Radius = 5;
            this.btn_Inicio.Size = new System.Drawing.Size(50, 60);
            this.btn_Inicio.TabIndex = 5;
            this.btn_Inicio.Text = "ÍNICIO";
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 80;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 910);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.gunaPictureBox7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sideBarP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimizeBox = false;
            this.Name = "TelaPrincipal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teste";
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            this.sideBarP.ResumeLayout(false);
            this.sideBarP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel sideBarP;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox6;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox7;
        private System.Windows.Forms.Label labelNome;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaAdvenceButton btn_info;
        private Guna.UI.WinForms.GunaAdvenceButton btn_atividade;
        private Guna.UI.WinForms.GunaAdvenceButton btn_more;
        private Guna.UI.WinForms.GunaAdvenceButton btn_dash;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaAdvenceButton btn_Inicio;
        private System.Windows.Forms.Timer sidebarTimer;
    }
}