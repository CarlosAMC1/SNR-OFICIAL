
namespace Social_Network_Rental.Presentacion
{
    partial class FrmPublicarInmueble
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
            this.dgbpublicar = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pcbminimizar = new System.Windows.Forms.PictureBox();
            this.pcbcerrar = new System.Windows.Forms.PictureBox();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtciudad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtestado = new System.Windows.Forms.TextBox();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnpublicar = new System.Windows.Forms.Button();
            this.pcbimagen = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgbpublicar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbcerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbimagen)).BeginInit();
            this.SuspendLayout();
            // 
            // dgbpublicar
            // 
            this.dgbpublicar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbpublicar.Location = new System.Drawing.Point(36, 104);
            this.dgbpublicar.Name = "dgbpublicar";
            this.dgbpublicar.Size = new System.Drawing.Size(814, 152);
            this.dgbpublicar.TabIndex = 0;
            this.dgbpublicar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgbpublicar_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Controls.Add(this.pcbminimizar);
            this.panel1.Controls.Add(this.pcbcerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(893, 37);
            this.panel1.TabIndex = 42;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblUsuario.Location = new System.Drawing.Point(33, 9);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(0, 13);
            this.lblUsuario.TabIndex = 3;
            // 
            // pcbminimizar
            // 
            this.pcbminimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pcbminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbminimizar.Image = global::Social_Network_Rental.Presentacion.Properties.Resources._111_minus;
            this.pcbminimizar.Location = new System.Drawing.Point(825, 7);
            this.pcbminimizar.Name = "pcbminimizar";
            this.pcbminimizar.Size = new System.Drawing.Size(25, 23);
            this.pcbminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbminimizar.TabIndex = 1;
            this.pcbminimizar.TabStop = false;
            this.pcbminimizar.Click += new System.EventHandler(this.pcbminimizar_Click);
            // 
            // pcbcerrar
            // 
            this.pcbcerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pcbcerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbcerrar.Image = global::Social_Network_Rental.Presentacion.Properties.Resources._103_delete;
            this.pcbcerrar.Location = new System.Drawing.Point(856, 8);
            this.pcbcerrar.Name = "pcbcerrar";
            this.pcbcerrar.Size = new System.Drawing.Size(25, 22);
            this.pcbcerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbcerrar.TabIndex = 0;
            this.pcbcerrar.TabStop = false;
            this.pcbcerrar.Click += new System.EventHandler(this.pcbcerrar_Click);
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Enabled = false;
            this.txtdescripcion.Location = new System.Drawing.Point(218, 429);
            this.txtdescripcion.Multiline = true;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(245, 68);
            this.txtdescripcion.TabIndex = 71;
            // 
            // txtprecio
            // 
            this.txtprecio.Enabled = false;
            this.txtprecio.Location = new System.Drawing.Point(219, 403);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(112, 20);
            this.txtprecio.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 429);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 69;
            this.label1.Text = "Descripcion  : ";
            // 
            // txtciudad
            // 
            this.txtciudad.Enabled = false;
            this.txtciudad.Location = new System.Drawing.Point(220, 351);
            this.txtciudad.Name = "txtciudad";
            this.txtciudad.Size = new System.Drawing.Size(112, 20);
            this.txtciudad.TabIndex = 68;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(107, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 67;
            this.label3.Text = "Ciudad       :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(107, 406);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 66;
            this.label4.Text = "Precio          : ";
            // 
            // txtestado
            // 
            this.txtestado.Enabled = false;
            this.txtestado.Location = new System.Drawing.Point(219, 377);
            this.txtestado.Name = "txtestado";
            this.txtestado.Size = new System.Drawing.Size(112, 20);
            this.txtestado.TabIndex = 65;
            // 
            // txtnumero
            // 
            this.txtnumero.Enabled = false;
            this.txtnumero.Location = new System.Drawing.Point(220, 325);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(112, 20);
            this.txtnumero.TabIndex = 64;
            // 
            // txtdireccion
            // 
            this.txtdireccion.Enabled = false;
            this.txtdireccion.Location = new System.Drawing.Point(221, 299);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(242, 20);
            this.txtdireccion.TabIndex = 63;
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(221, 273);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(112, 20);
            this.txtid.TabIndex = 62;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(108, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 61;
            this.label5.Text = "Estado         :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(106, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 60;
            this.label6.Text = "Direccion     :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(106, 325);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 17);
            this.label15.TabIndex = 59;
            this.label15.Text = "Numero       :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(107, 273);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(96, 17);
            this.label16.TabIndex = 58;
            this.label16.Text = "Id Inmueble : ";
            // 
            // btnpublicar
            // 
            this.btnpublicar.Image = global::Social_Network_Rental.Presentacion.Properties.Resources.Agregar_p1;
            this.btnpublicar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnpublicar.Location = new System.Drawing.Point(390, 519);
            this.btnpublicar.Name = "btnpublicar";
            this.btnpublicar.Size = new System.Drawing.Size(126, 34);
            this.btnpublicar.TabIndex = 74;
            this.btnpublicar.Text = "Publicar Inmueble";
            this.btnpublicar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnpublicar.UseVisualStyleBackColor = true;
            this.btnpublicar.Click += new System.EventHandler(this.btnpublicar_Click);
            // 
            // pcbimagen
            // 
            this.pcbimagen.Location = new System.Drawing.Point(568, 300);
            this.pcbimagen.Name = "pcbimagen";
            this.pcbimagen.Size = new System.Drawing.Size(185, 157);
            this.pcbimagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbimagen.TabIndex = 73;
            this.pcbimagen.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(322, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 28);
            this.label2.TabIndex = 75;
            this.label2.Text = "Publicar Inmueble";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(704, 529);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 33);
            this.button1.TabIndex = 76;
            this.button1.Text = "Reporte Publicaciones";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmPublicarInmueble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(893, 585);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnpublicar);
            this.Controls.Add(this.pcbimagen);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtciudad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtestado);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgbpublicar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPublicarInmueble";
            this.Text = "FrmPublicarInmueble";
            this.Load += new System.EventHandler(this.FrmPublicarInmueble_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgbpublicar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbcerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbimagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgbpublicar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.PictureBox pcbminimizar;
        private System.Windows.Forms.PictureBox pcbcerrar;
        private System.Windows.Forms.PictureBox pcbimagen;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtciudad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtestado;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnpublicar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}