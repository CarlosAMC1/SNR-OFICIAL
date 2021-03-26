
namespace Social_Network_Rental.Presentacion
{
    partial class FrmEditarInmueble
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
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabgestionar = new System.Windows.Forms.TabControl();
            this.tblistar = new System.Windows.Forms.TabPage();
            this.lblregistros = new System.Windows.Forms.Label();
            this.dgvlistar = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.chkseleccionar = new System.Windows.Forms.CheckBox();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbagregar = new System.Windows.Forms.TabPage();
            this.CboEstado = new System.Windows.Forms.ComboBox();
            this.btnseleccionar = new System.Windows.Forms.Button();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtciudad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ErrorAlerta = new System.Windows.Forms.ErrorProvider(this.components);
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.pcbimagen = new System.Windows.Forms.PictureBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.pcbminimizar = new System.Windows.Forms.PictureBox();
            this.pcbcerrar = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabgestionar.SuspendLayout();
            this.tblistar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistar)).BeginInit();
            this.tbagregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorAlerta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbimagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbcerrar)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(943, 37);
            this.panel1.TabIndex = 41;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(284, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(274, 24);
            this.label7.TabIndex = 43;
            this.label7.Text = "Editar Datos Inmuebles";
            // 
            // tabgestionar
            // 
            this.tabgestionar.Controls.Add(this.tblistar);
            this.tabgestionar.Controls.Add(this.tbagregar);
            this.tabgestionar.Location = new System.Drawing.Point(70, 83);
            this.tabgestionar.Name = "tabgestionar";
            this.tabgestionar.SelectedIndex = 0;
            this.tabgestionar.Size = new System.Drawing.Size(742, 369);
            this.tabgestionar.TabIndex = 42;
            // 
            // tblistar
            // 
            this.tblistar.Controls.Add(this.button1);
            this.tblistar.Controls.Add(this.lblregistros);
            this.tblistar.Controls.Add(this.dgvlistar);
            this.tblistar.Controls.Add(this.btneliminar);
            this.tblistar.Controls.Add(this.chkseleccionar);
            this.tblistar.Controls.Add(this.txtbusqueda);
            this.tblistar.Controls.Add(this.btnbuscar);
            this.tblistar.Controls.Add(this.label2);
            this.tblistar.Location = new System.Drawing.Point(4, 22);
            this.tblistar.Name = "tblistar";
            this.tblistar.Padding = new System.Windows.Forms.Padding(3);
            this.tblistar.Size = new System.Drawing.Size(734, 343);
            this.tblistar.TabIndex = 0;
            this.tblistar.Text = "Listar";
            this.tblistar.UseVisualStyleBackColor = true;
            this.tblistar.Click += new System.EventHandler(this.tblistar_Click);
            // 
            // lblregistros
            // 
            this.lblregistros.AutoSize = true;
            this.lblregistros.Location = new System.Drawing.Point(527, 239);
            this.lblregistros.Name = "lblregistros";
            this.lblregistros.Size = new System.Drawing.Size(34, 13);
            this.lblregistros.TabIndex = 15;
            this.lblregistros.Text = "Total:";
            // 
            // dgvlistar
            // 
            this.dgvlistar.AllowUserToAddRows = false;
            this.dgvlistar.AllowUserToDeleteRows = false;
            this.dgvlistar.AllowUserToOrderColumns = true;
            this.dgvlistar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlistar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.dgvlistar.Location = new System.Drawing.Point(37, 51);
            this.dgvlistar.Margin = new System.Windows.Forms.Padding(2);
            this.dgvlistar.Name = "dgvlistar";
            this.dgvlistar.ReadOnly = true;
            this.dgvlistar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvlistar.Size = new System.Drawing.Size(647, 158);
            this.dgvlistar.TabIndex = 14;
            this.dgvlistar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvlistar_CellContentClick_1);
            this.dgvlistar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvlistar_CellDoubleClick_1);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
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
            this.tbagregar.Controls.Add(this.CboEstado);
            this.tbagregar.Controls.Add(this.btnseleccionar);
            this.tbagregar.Controls.Add(this.txtdescripcion);
            this.tbagregar.Controls.Add(this.txtprecio);
            this.tbagregar.Controls.Add(this.label1);
            this.tbagregar.Controls.Add(this.txtciudad);
            this.tbagregar.Controls.Add(this.label3);
            this.tbagregar.Controls.Add(this.label4);
            this.tbagregar.Controls.Add(this.txtnumero);
            this.tbagregar.Controls.Add(this.txtdireccion);
            this.tbagregar.Controls.Add(this.txtid);
            this.tbagregar.Controls.Add(this.label5);
            this.tbagregar.Controls.Add(this.label6);
            this.tbagregar.Controls.Add(this.label15);
            this.tbagregar.Controls.Add(this.label16);
            this.tbagregar.Controls.Add(this.pcbimagen);
            this.tbagregar.Controls.Add(this.btncancelar);
            this.tbagregar.Controls.Add(this.btnactualizar);
            this.tbagregar.Location = new System.Drawing.Point(4, 22);
            this.tbagregar.Name = "tbagregar";
            this.tbagregar.Padding = new System.Windows.Forms.Padding(3);
            this.tbagregar.Size = new System.Drawing.Size(734, 343);
            this.tbagregar.TabIndex = 1;
            this.tbagregar.Text = "Editar";
            this.tbagregar.UseVisualStyleBackColor = true;
            // 
            // CboEstado
            // 
            this.CboEstado.FormattingEnabled = true;
            this.CboEstado.Items.AddRange(new object[] {
            "Departamento",
            "Casa"});
            this.CboEstado.Location = new System.Drawing.Point(156, 117);
            this.CboEstado.Name = "CboEstado";
            this.CboEstado.Size = new System.Drawing.Size(113, 21);
            this.CboEstado.TabIndex = 58;
            // 
            // btnseleccionar
            // 
            this.btnseleccionar.Location = new System.Drawing.Point(525, 204);
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.Size = new System.Drawing.Size(151, 34);
            this.btnseleccionar.TabIndex = 56;
            this.btnseleccionar.Text = "Seleccionar Imagen";
            this.btnseleccionar.UseVisualStyleBackColor = true;
            this.btnseleccionar.Click += new System.EventHandler(this.btnseleccionar_Click);
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(156, 170);
            this.txtdescripcion.Multiline = true;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(245, 68);
            this.txtdescripcion.TabIndex = 55;
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(157, 144);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(112, 20);
            this.txtprecio.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 53;
            this.label1.Text = "Descripcion  : ";
            // 
            // txtciudad
            // 
            this.txtciudad.Location = new System.Drawing.Point(158, 92);
            this.txtciudad.Name = "txtciudad";
            this.txtciudad.Size = new System.Drawing.Size(112, 20);
            this.txtciudad.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 51;
            this.label3.Text = "Ciudad       :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 48;
            this.label4.Text = "Precio          : ";
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(158, 66);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(112, 20);
            this.txtnumero.TabIndex = 46;
            // 
            // txtdireccion
            // 
            this.txtdireccion.Enabled = false;
            this.txtdireccion.Location = new System.Drawing.Point(159, 40);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(242, 20);
            this.txtdireccion.TabIndex = 45;
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(159, 14);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(112, 20);
            this.txtid.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 43;
            this.label5.Text = "Categoria   :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 42;
            this.label6.Text = "Direccion     :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(44, 66);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 17);
            this.label15.TabIndex = 41;
            this.label15.Text = "Numero       :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(45, 14);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(96, 17);
            this.label16.TabIndex = 40;
            this.label16.Text = "Id Inmueble : ";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // ErrorAlerta
            // 
            this.ErrorAlerta.ContainerControl = this;
            // 
            // btneliminar
            // 
            this.btneliminar.Image = global::Social_Network_Rental.Presentacion.Properties.Resources.remove;
            this.btneliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btneliminar.Location = new System.Drawing.Point(154, 239);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(101, 33);
            this.btneliminar.TabIndex = 13;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
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
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // pcbimagen
            // 
            this.pcbimagen.Location = new System.Drawing.Point(506, 41);
            this.pcbimagen.Name = "pcbimagen";
            this.pcbimagen.Size = new System.Drawing.Size(185, 157);
            this.pcbimagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbimagen.TabIndex = 57;
            this.pcbimagen.TabStop = false;
            // 
            // btncancelar
            // 
            this.btncancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btncancelar.Image = global::Social_Network_Rental.Presentacion.Properties.Resources.remove1;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancelar.Location = new System.Drawing.Point(327, 282);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(102, 34);
            this.btncancelar.TabIndex = 50;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnactualizar
            // 
            this.btnactualizar.Image = global::Social_Network_Rental.Presentacion.Properties.Resources.Agregar_p1;
            this.btnactualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnactualizar.Location = new System.Drawing.Point(122, 282);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(100, 34);
            this.btnactualizar.TabIndex = 49;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // pcbminimizar
            // 
            this.pcbminimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pcbminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbminimizar.Image = global::Social_Network_Rental.Presentacion.Properties.Resources._111_minus;
            this.pcbminimizar.Location = new System.Drawing.Point(875, 7);
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
            this.pcbcerrar.Location = new System.Drawing.Point(906, 8);
            this.pcbcerrar.Name = "pcbcerrar";
            this.pcbcerrar.Size = new System.Drawing.Size(25, 22);
            this.pcbcerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbcerrar.TabIndex = 0;
            this.pcbcerrar.TabStop = false;
            this.pcbcerrar.Click += new System.EventHandler(this.pcbcerrar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(574, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Reporte Categorias";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FrmEditarInmueble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(943, 476);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tabgestionar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEditarInmueble";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEditarInmueble";
            this.Load += new System.EventHandler(this.FrmEditarInmueble_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabgestionar.ResumeLayout(false);
            this.tblistar.ResumeLayout(false);
            this.tblistar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistar)).EndInit();
            this.tbagregar.ResumeLayout(false);
            this.tbagregar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorAlerta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbimagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbcerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbminimizar;
        private System.Windows.Forms.PictureBox pcbcerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabControl tabgestionar;
        private System.Windows.Forms.TabPage tblistar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.CheckBox chkseleccionar;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tbagregar;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pcbimagen;
        private System.Windows.Forms.Button btnseleccionar;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtciudad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ErrorProvider ErrorAlerta;
        private System.Windows.Forms.DataGridView dgvlistar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.Label lblregistros;
        private System.Windows.Forms.ComboBox CboEstado;
        private System.Windows.Forms.Button button1;
    }
}