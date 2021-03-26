
namespace Social_Network_Rental.Presentacion
{
    partial class FrmIniciarSesion
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
            this.btningresar = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnlimpiar = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.lkncontraseña = new System.Windows.Forms.LinkLabel();
            this.lblerror = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btningresar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnlimpiar)).BeginInit();
            this.SuspendLayout();
            // 
            // btningresar
            // 
            this.btningresar.BorderStyle.EdgeRadius = 7;
            this.btningresar.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias;
            this.btningresar.DropDownArrowColor = System.Drawing.Color.Black;
            this.btningresar.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btningresar.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.btningresar.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btningresar.Location = new System.Drawing.Point(320, 182);
            this.btningresar.Name = "btningresar";
            this.btningresar.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ModernBlack;
            this.btningresar.Size = new System.Drawing.Size(127, 37);
            this.btningresar.StateStyles.DisabledStyle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btningresar.StateStyles.FocusStyle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btningresar.StateStyles.HoverStyle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btningresar.StateStyles.PressedStyle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btningresar.TabIndex = 14;
            this.btningresar.TextStyle.ForeColor = System.Drawing.Color.LightGray;
            this.btningresar.TextStyle.Text = "Ingresar";
            this.btningresar.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btningresar.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.ToolBar;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(418, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 36);
            this.label1.TabIndex = 15;
            this.label1.Text = "Iniciar Sesion";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 292);
            this.panel1.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Social_Network_Rental.Presentacion.Properties.Resources.Logo1;
            this.pictureBox1.Location = new System.Drawing.Point(22, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(295, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Usuario :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(295, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "Contraseña :";
            // 
            // txtusuario
            // 
            this.txtusuario.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtusuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtusuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtusuario.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtusuario.Location = new System.Drawing.Point(368, 89);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(276, 21);
            this.txtusuario.TabIndex = 22;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(368, 107);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(276, 10);
            this.bunifuSeparator1.TabIndex = 21;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtcontraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcontraseña.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtcontraseña.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontraseña.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtcontraseña.Location = new System.Drawing.Point(398, 134);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.PasswordChar = '*';
            this.txtcontraseña.Size = new System.Drawing.Size(246, 21);
            this.txtcontraseña.TabIndex = 24;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(398, 152);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(246, 10);
            this.bunifuSeparator2.TabIndex = 23;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(279, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(497, 33);
            this.panel2.TabIndex = 25;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Social_Network_Rental.Presentacion.Properties.Resources._103_delete;
            this.pictureBox2.Location = new System.Drawing.Point(456, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BorderStyle.EdgeRadius = 7;
            this.btnlimpiar.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias;
            this.btnlimpiar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnlimpiar.DropDownArrowColor = System.Drawing.Color.Black;
            this.btnlimpiar.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btnlimpiar.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.btnlimpiar.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnlimpiar.Location = new System.Drawing.Point(586, 182);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ModernBlack;
            this.btnlimpiar.Size = new System.Drawing.Size(127, 37);
            this.btnlimpiar.StateStyles.DisabledStyle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnlimpiar.StateStyles.FocusStyle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnlimpiar.StateStyles.HoverStyle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnlimpiar.StateStyles.PressedStyle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnlimpiar.TabIndex = 27;
            this.btnlimpiar.TextStyle.ForeColor = System.Drawing.Color.LightGray;
            this.btnlimpiar.TextStyle.Text = "Limpiar";
            this.btnlimpiar.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnlimpiar.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.ToolBar;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // lkncontraseña
            // 
            this.lkncontraseña.ActiveLinkColor = System.Drawing.Color.Blue;
            this.lkncontraseña.AutoSize = true;
            this.lkncontraseña.LinkColor = System.Drawing.Color.Gray;
            this.lkncontraseña.Location = new System.Drawing.Point(421, 245);
            this.lkncontraseña.Name = "lkncontraseña";
            this.lkncontraseña.Size = new System.Drawing.Size(131, 13);
            this.lkncontraseña.TabIndex = 31;
            this.lkncontraseña.TabStop = true;
            this.lkncontraseña.Text = "¿Olvidaste tu contraseña?";
            this.lkncontraseña.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerror.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblerror.Image = global::Social_Network_Rental.Presentacion.Properties.Resources.remove;
            this.lblerror.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblerror.Location = new System.Drawing.Point(332, 165);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(150, 16);
            this.lblerror.TabIndex = 30;
            this.lblerror.Text = "No deje campos vacios";
            this.lblerror.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblerror.Visible = false;
            // 
            // FrmIniciarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(776, 292);
            this.Controls.Add(this.lkncontraseña);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtcontraseña);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btningresar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmIniciarSesion";
            this.Opacity = 0.99D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmIniciarSesion";
            this.Load += new System.EventHandler(this.FrmIniciarSesion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btningresar)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnlimpiar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Klik.Windows.Forms.v1.EntryLib.ELButton btningresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtusuario;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.TextBox txtcontraseña;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Klik.Windows.Forms.v1.EntryLib.ELButton btnlimpiar;
        private System.Windows.Forms.Label lblerror;
        private System.Windows.Forms.LinkLabel lkncontraseña;
    }
}