
namespace Social_Network_Rental.Presentacion
{
    partial class FrmHistorialReserva
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
            this.pcbminimizar = new System.Windows.Forms.PictureBox();
            this.pcbcerrar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbcerrar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcbminimizar
            // 
            this.pcbminimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pcbminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbminimizar.Image = global::Social_Network_Rental.Presentacion.Properties.Resources._111_minus;
            this.pcbminimizar.Location = new System.Drawing.Point(643, 7);
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
            this.pcbcerrar.Location = new System.Drawing.Point(674, 8);
            this.pcbcerrar.Name = "pcbcerrar";
            this.pcbcerrar.Size = new System.Drawing.Size(25, 22);
            this.pcbcerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbcerrar.TabIndex = 0;
            this.pcbcerrar.TabStop = false;
            this.pcbcerrar.Click += new System.EventHandler(this.pcbcerrar_Click);
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
            this.panel1.Size = new System.Drawing.Size(711, 37);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 24);
            this.label1.TabIndex = 43;
            this.label1.Text = "Solicitudes de Reserva";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(150, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 44;
            this.label2.Text = "Numero : ";
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(233, 105);
            this.txtnumero.Multiline = true;
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(295, 79);
            this.txtnumero.TabIndex = 45;
            // 
            // FrmHistorialReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(711, 265);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHistorialReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmHistorialReserva";
            this.Load += new System.EventHandler(this.FrmHistorialReserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbcerrar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbminimizar;
        private System.Windows.Forms.PictureBox pcbcerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnumero;
    }
}