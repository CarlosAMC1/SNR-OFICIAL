
namespace Social_Network_Rental.Presentacion
{
    partial class FrmReservaInmueble
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvlistar = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pcbminimizar = new System.Windows.Forms.PictureBox();
            this.pcbcerrar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbcerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panel1.Controls.Add(this.pcbminimizar);
            this.panel1.Controls.Add(this.pcbcerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 38);
            this.panel1.TabIndex = 1;
            // 
            // dgvlistar
            // 
            this.dgvlistar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlistar.Location = new System.Drawing.Point(91, 127);
            this.dgvlistar.Name = "dgvlistar";
            this.dgvlistar.Size = new System.Drawing.Size(642, 176);
            this.dgvlistar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(219, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Visualizar Sitios Publicados";
            // 
            // pcbminimizar
            // 
            this.pcbminimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pcbminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbminimizar.Image = global::Social_Network_Rental.Presentacion.Properties.Resources._111_minus;
            this.pcbminimizar.Location = new System.Drawing.Point(764, 7);
            this.pcbminimizar.Name = "pcbminimizar";
            this.pcbminimizar.Size = new System.Drawing.Size(25, 23);
            this.pcbminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbminimizar.TabIndex = 3;
            this.pcbminimizar.TabStop = false;
            this.pcbminimizar.Click += new System.EventHandler(this.pcbminimizar_Click);
            // 
            // pcbcerrar
            // 
            this.pcbcerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pcbcerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbcerrar.Image = global::Social_Network_Rental.Presentacion.Properties.Resources._103_delete;
            this.pcbcerrar.Location = new System.Drawing.Point(795, 8);
            this.pcbcerrar.Name = "pcbcerrar";
            this.pcbcerrar.Size = new System.Drawing.Size(25, 22);
            this.pcbcerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbcerrar.TabIndex = 2;
            this.pcbcerrar.TabStop = false;
            this.pcbcerrar.Click += new System.EventHandler(this.pcbcerrar_Click);
            // 
            // FrmReservaInmueble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(832, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvlistar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReservaInmueble";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmReservaInmueble";
            this.Load += new System.EventHandler(this.FrmReservaInmueble_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbcerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbminimizar;
        private System.Windows.Forms.PictureBox pcbcerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvlistar;
        private System.Windows.Forms.Label label1;
    }
}