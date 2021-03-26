
namespace Social_Network_Rental.Presentacion
{
    partial class FrmInmueble
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInmueble));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pcbrestaurar = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pcbmaximizar = new System.Windows.Forms.PictureBox();
            this.pcbminimizar = new System.Windows.Forms.PictureBox();
            this.pcbcerrar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse5 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse6 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse7 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvlistar = new System.Windows.Forms.DataGridView();
            this.bunifuElipse8 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuWebClient1 = new Bunifu.Framework.UI.BunifuWebClient(this.components);
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbrestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbmaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbcerrar)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 40;
            this.bunifuElipse2.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pcbrestaurar);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pcbmaximizar);
            this.panel1.Controls.Add(this.pcbminimizar);
            this.panel1.Controls.Add(this.pcbcerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(969, 37);
            this.panel1.TabIndex = 14;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Social_Network_Rental.Presentacion.Properties.Resources._111_minus;
            this.pictureBox2.Location = new System.Drawing.Point(887, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pcbrestaurar
            // 
            this.pcbrestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pcbrestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbrestaurar.Image = global::Social_Network_Rental.Presentacion.Properties.Resources._120_minimize;
            this.pcbrestaurar.Location = new System.Drawing.Point(1945, 7);
            this.pcbrestaurar.Name = "pcbrestaurar";
            this.pcbrestaurar.Size = new System.Drawing.Size(25, 23);
            this.pcbrestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbrestaurar.TabIndex = 3;
            this.pcbrestaurar.TabStop = false;
            this.pcbrestaurar.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::Social_Network_Rental.Presentacion.Properties.Resources._103_delete;
            this.pictureBox3.Location = new System.Drawing.Point(928, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 22);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pcbmaximizar
            // 
            this.pcbmaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pcbmaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbmaximizar.Image = global::Social_Network_Rental.Presentacion.Properties.Resources._115_expand;
            this.pcbmaximizar.Location = new System.Drawing.Point(1945, 7);
            this.pcbmaximizar.Name = "pcbmaximizar";
            this.pcbmaximizar.Size = new System.Drawing.Size(25, 23);
            this.pcbmaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbmaximizar.TabIndex = 2;
            this.pcbmaximizar.TabStop = false;
            // 
            // pcbminimizar
            // 
            this.pcbminimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pcbminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbminimizar.Image = global::Social_Network_Rental.Presentacion.Properties.Resources._111_minus;
            this.pcbminimizar.Location = new System.Drawing.Point(1904, 7);
            this.pcbminimizar.Name = "pcbminimizar";
            this.pcbminimizar.Size = new System.Drawing.Size(25, 23);
            this.pcbminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbminimizar.TabIndex = 1;
            this.pcbminimizar.TabStop = false;
            // 
            // pcbcerrar
            // 
            this.pcbcerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pcbcerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbcerrar.Image = global::Social_Network_Rental.Presentacion.Properties.Resources._103_delete;
            this.pcbcerrar.Location = new System.Drawing.Point(1987, 8);
            this.pcbcerrar.Name = "pcbcerrar";
            this.pcbcerrar.Size = new System.Drawing.Size(25, 22);
            this.pcbcerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbcerrar.TabIndex = 0;
            this.pcbcerrar.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(207, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(609, 38);
            this.label1.TabIndex = 15;
            this.label1.Text = "Alojamientos en el area Seleccionada";
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 20;
            this.bunifuElipse3.TargetControl = this;
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 20;
            this.bunifuElipse4.TargetControl = this;
            // 
            // bunifuElipse5
            // 
            this.bunifuElipse5.ElipseRadius = 20;
            this.bunifuElipse5.TargetControl = this;
            // 
            // bunifuElipse6
            // 
            this.bunifuElipse6.ElipseRadius = 20;
            this.bunifuElipse6.TargetControl = this;
            // 
            // bunifuElipse7
            // 
            this.bunifuElipse7.ElipseRadius = 30;
            this.bunifuElipse7.TargetControl = this;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.dgvlistar);
            this.panel2.Location = new System.Drawing.Point(12, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(941, 350);
            this.panel2.TabIndex = 63;
            // 
            // dgvlistar
            // 
            this.dgvlistar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlistar.Location = new System.Drawing.Point(133, 56);
            this.dgvlistar.Name = "dgvlistar";
            this.dgvlistar.Size = new System.Drawing.Size(746, 218);
            this.dgvlistar.TabIndex = 0;
            // 
            // bunifuElipse8
            // 
            this.bunifuElipse8.ElipseRadius = 30;
            this.bunifuElipse8.TargetControl = this.panel2;
            // 
            // bunifuWebClient1
            // 
            this.bunifuWebClient1.AllowReadStreamBuffering = false;
            this.bunifuWebClient1.AllowWriteStreamBuffering = false;
            this.bunifuWebClient1.BaseAddress = "";
            this.bunifuWebClient1.CachePolicy = null;
            this.bunifuWebClient1.Credentials = null;
            this.bunifuWebClient1.Encoding = ((System.Text.Encoding)(resources.GetObject("bunifuWebClient1.Encoding")));
            this.bunifuWebClient1.Headers = ((System.Net.WebHeaderCollection)(resources.GetObject("bunifuWebClient1.Headers")));
            this.bunifuWebClient1.QueryString = ((System.Collections.Specialized.NameValueCollection)(resources.GetObject("bunifuWebClient1.QueryString")));
            this.bunifuWebClient1.UseDefaultCredentials = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::Social_Network_Rental.Presentacion.Properties.Resources.Logo1;
            this.pictureBox5.Location = new System.Drawing.Point(26, 52);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 61);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 54;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // FrmInmueble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(969, 504);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInmueble";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInmueble";
            this.Load += new System.EventHandler(this.FrmInmueble_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbrestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbmaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbcerrar)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pcbrestaurar;
        private System.Windows.Forms.PictureBox pcbmaximizar;
        private System.Windows.Forms.PictureBox pcbminimizar;
        private System.Windows.Forms.PictureBox pcbcerrar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse5;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse6;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse7;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse8;
        private Bunifu.Framework.UI.BunifuWebClient bunifuWebClient1;
        private System.Windows.Forms.DataGridView dgvlistar;
    }
}