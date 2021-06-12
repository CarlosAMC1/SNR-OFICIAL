
namespace Social_Network_Rental.Presentacion
{
    partial class FrmGestionarUsuario
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pcbminimizar = new System.Windows.Forms.PictureBox();
            this.pcbcerrar = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.tabgestionar = new System.Windows.Forms.TabControl();
            this.tblistar = new System.Windows.Forms.TabPage();
            this.dgvlistar = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btndesactivar = new System.Windows.Forms.Button();
            this.btnactivar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.chkseleccionar = new System.Windows.Forms.CheckBox();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbagregar = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.cboestado = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtnivel = new System.Windows.Forms.TextBox();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btngrabar = new System.Windows.Forms.Button();
            this.ErrorAlerta = new System.Windows.Forms.ErrorProvider(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbcerrar)).BeginInit();
            this.tabgestionar.SuspendLayout();
            this.tblistar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistar)).BeginInit();
            this.tbagregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorAlerta)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(843, 38);
            this.panel1.TabIndex = 0;
            // 
            // pcbminimizar
            // 
            this.pcbminimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pcbminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbminimizar.Image = global::Social_Network_Rental.Presentacion.Properties.Resources._111_minus;
            this.pcbminimizar.Location = new System.Drawing.Point(775, 7);
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
            this.pcbcerrar.Location = new System.Drawing.Point(806, 8);
            this.pcbcerrar.Name = "pcbcerrar";
            this.pcbcerrar.Size = new System.Drawing.Size(25, 22);
            this.pcbcerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbcerrar.TabIndex = 2;
            this.pcbcerrar.TabStop = false;
            this.pcbcerrar.Click += new System.EventHandler(this.pcbcerrar_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // tabgestionar
            // 
            this.tabgestionar.Controls.Add(this.tblistar);
            this.tabgestionar.Controls.Add(this.tbagregar);
            this.tabgestionar.Location = new System.Drawing.Point(32, 88);
            this.tabgestionar.Name = "tabgestionar";
            this.tabgestionar.SelectedIndex = 0;
            this.tabgestionar.Size = new System.Drawing.Size(748, 386);
            this.tabgestionar.TabIndex = 1;
            // 
            // tblistar
            // 
            this.tblistar.Controls.Add(this.dgvlistar);
            this.tblistar.Controls.Add(this.btndesactivar);
            this.tblistar.Controls.Add(this.btnactivar);
            this.tblistar.Controls.Add(this.btneliminar);
            this.tblistar.Controls.Add(this.chkseleccionar);
            this.tblistar.Controls.Add(this.txtbusqueda);
            this.tblistar.Controls.Add(this.btnbuscar);
            this.tblistar.Controls.Add(this.label2);
            this.tblistar.Location = new System.Drawing.Point(4, 22);
            this.tblistar.Name = "tblistar";
            this.tblistar.Padding = new System.Windows.Forms.Padding(3);
            this.tblistar.Size = new System.Drawing.Size(740, 360);
            this.tblistar.TabIndex = 0;
            this.tblistar.Text = "Listar";
            this.tblistar.UseVisualStyleBackColor = true;
            // 
            // dgvlistar
            // 
            this.dgvlistar.AllowUserToAddRows = false;
            this.dgvlistar.AllowUserToDeleteRows = false;
            this.dgvlistar.AllowUserToOrderColumns = true;
            this.dgvlistar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlistar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.dgvlistar.Location = new System.Drawing.Point(20, 51);
            this.dgvlistar.Margin = new System.Windows.Forms.Padding(2);
            this.dgvlistar.Name = "dgvlistar";
            this.dgvlistar.ReadOnly = true;
            this.dgvlistar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvlistar.Size = new System.Drawing.Size(625, 158);
            this.dgvlistar.TabIndex = 16;
            this.dgvlistar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvlistar_CellContentClick);
            this.dgvlistar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvlistar_CellDoubleClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            // 
            // btndesactivar
            // 
            this.btndesactivar.Image = global::Social_Network_Rental.Presentacion.Properties.Resources.process_remove;
            this.btndesactivar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndesactivar.Location = new System.Drawing.Point(387, 236);
            this.btndesactivar.Name = "btndesactivar";
            this.btndesactivar.Size = new System.Drawing.Size(116, 34);
            this.btndesactivar.TabIndex = 15;
            this.btndesactivar.Text = "Desactivar";
            this.btndesactivar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndesactivar.UseVisualStyleBackColor = true;
            this.btndesactivar.Click += new System.EventHandler(this.btndesactivar_Click);
            // 
            // btnactivar
            // 
            this.btnactivar.Image = global::Social_Network_Rental.Presentacion.Properties.Resources.accept;
            this.btnactivar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnactivar.Location = new System.Drawing.Point(273, 239);
            this.btnactivar.Name = "btnactivar";
            this.btnactivar.Size = new System.Drawing.Size(95, 33);
            this.btnactivar.TabIndex = 14;
            this.btnactivar.Text = "Activar";
            this.btnactivar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnactivar.UseVisualStyleBackColor = true;
            this.btnactivar.Click += new System.EventHandler(this.btnactivar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Image = global::Social_Network_Rental.Presentacion.Properties.Resources.remove;
            this.btneliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btneliminar.Location = new System.Drawing.Point(151, 238);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(101, 33);
            this.btneliminar.TabIndex = 13;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // chkseleccionar
            // 
            this.chkseleccionar.AutoSize = true;
            this.chkseleccionar.Location = new System.Drawing.Point(44, 239);
            this.chkseleccionar.Name = "chkseleccionar";
            this.chkseleccionar.Size = new System.Drawing.Size(82, 17);
            this.chkseleccionar.TabIndex = 12;
            this.chkseleccionar.Text = "Seleccionar";
            this.chkseleccionar.UseVisualStyleBackColor = true;
            this.chkseleccionar.CheckedChanged += new System.EventHandler(this.chkseleccionar_CheckedChanged);
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Location = new System.Drawing.Point(107, 19);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(248, 20);
            this.txtbusqueda.TabIndex = 8;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Image = global::Social_Network_Rental.Presentacion.Properties.Resources.search;
            this.btnbuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbuscar.Location = new System.Drawing.Point(394, 11);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(93, 35);
            this.btnbuscar.TabIndex = 7;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbuscar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Buscar: ";
            // 
            // tbagregar
            // 
            this.tbagregar.Controls.Add(this.button1);
            this.tbagregar.Controls.Add(this.cboestado);
            this.tbagregar.Controls.Add(this.label6);
            this.tbagregar.Controls.Add(this.txtnivel);
            this.tbagregar.Controls.Add(this.txtclave);
            this.tbagregar.Controls.Add(this.txtusuario);
            this.tbagregar.Controls.Add(this.txtid);
            this.tbagregar.Controls.Add(this.label5);
            this.tbagregar.Controls.Add(this.label4);
            this.tbagregar.Controls.Add(this.label3);
            this.tbagregar.Controls.Add(this.label1);
            this.tbagregar.Controls.Add(this.btncancelar);
            this.tbagregar.Controls.Add(this.btngrabar);
            this.tbagregar.Location = new System.Drawing.Point(4, 22);
            this.tbagregar.Name = "tbagregar";
            this.tbagregar.Padding = new System.Windows.Forms.Padding(3);
            this.tbagregar.Size = new System.Drawing.Size(740, 360);
            this.tbagregar.TabIndex = 1;
            this.tbagregar.Text = "Agregar";
            this.tbagregar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(469, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 34);
            this.button1.TabIndex = 25;
            this.button1.Text = "Ver Reportes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboestado
            // 
            this.cboestado.FormattingEnabled = true;
            this.cboestado.Location = new System.Drawing.Point(309, 194);
            this.cboestado.Name = "cboestado";
            this.cboestado.Size = new System.Drawing.Size(112, 21);
            this.cboestado.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(207, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Estado     : ";
            // 
            // txtnivel
            // 
            this.txtnivel.Enabled = false;
            this.txtnivel.Location = new System.Drawing.Point(308, 152);
            this.txtnivel.Name = "txtnivel";
            this.txtnivel.Size = new System.Drawing.Size(112, 20);
            this.txtnivel.TabIndex = 20;
            this.txtnivel.Text = "Usuario";
            // 
            // txtclave
            // 
            this.txtclave.Location = new System.Drawing.Point(308, 116);
            this.txtclave.Name = "txtclave";
            this.txtclave.Size = new System.Drawing.Size(112, 20);
            this.txtclave.TabIndex = 19;
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(308, 77);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(112, 20);
            this.txtusuario.TabIndex = 18;
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(309, 38);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(112, 20);
            this.txtid.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(208, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Nivel        :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(206, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Usuario      :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(206, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Clave       :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Id Persona : ";
            // 
            // btncancelar
            // 
            this.btncancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btncancelar.Image = global::Social_Network_Rental.Presentacion.Properties.Resources.remove1;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancelar.Location = new System.Drawing.Point(303, 257);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(102, 34);
            this.btncancelar.TabIndex = 23;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // btngrabar
            // 
            this.btngrabar.Image = global::Social_Network_Rental.Presentacion.Properties.Resources.Agregar_p1;
            this.btngrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngrabar.Location = new System.Drawing.Point(113, 257);
            this.btngrabar.Name = "btngrabar";
            this.btngrabar.Size = new System.Drawing.Size(100, 34);
            this.btngrabar.TabIndex = 22;
            this.btngrabar.Text = "Grabar";
            this.btngrabar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btngrabar.UseVisualStyleBackColor = true;
            this.btngrabar.Click += new System.EventHandler(this.btngrabar_Click_1);
            // 
            // ErrorAlerta
            // 
            this.ErrorAlerta.ContainerControl = this;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label7.Location = new System.Drawing.Point(214, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(250, 24);
            this.label7.TabIndex = 2;
            this.label7.Text = "Editar Datos Usuario";
            // 
            // FrmGestionarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(843, 505);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tabgestionar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGestionarUsuario";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGestionarUsuario";
            this.Load += new System.EventHandler(this.FrmGestionarUsuario_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbcerrar)).EndInit();
            this.tabgestionar.ResumeLayout(false);
            this.tblistar.ResumeLayout(false);
            this.tblistar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistar)).EndInit();
            this.tbagregar.ResumeLayout(false);
            this.tbagregar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorAlerta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pcbminimizar;
        private System.Windows.Forms.PictureBox pcbcerrar;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.TabControl tabgestionar;
        private System.Windows.Forms.TabPage tblistar;
        private System.Windows.Forms.TabPage tbagregar;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btndesactivar;
        private System.Windows.Forms.Button btnactivar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.CheckBox chkseleccionar;
        private System.Windows.Forms.DataGridView dgvlistar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.ErrorProvider ErrorAlerta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboestado;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btngrabar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtnivel;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}