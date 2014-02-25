using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//Librerias Agregadas 
using System.Data.OleDb;//Establece el tipo de conexion a la base de datos
using System.Configuration;//Establecemos comunicacion con la libreria de configuracion para poder hacer uso del App.Config
using Shajobe.Properties;//Nos permite tener acceso y control sobre las propiedades del proyecto en este caso la direccion del appconfig y entre otros
//Librerias de Animacion
using System.Runtime.InteropServices;
namespace Shajobe
{
    public partial class Abono : Form
    {
        public Abono()
        {
            InitializeComponent();
        }
        #region Diseño de la forma
        #region Creando controles de la forma
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercadeToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox_Logo;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button bttn_Abono;
        private System.Windows.Forms.GroupBox groupBox_listaAbonos;
        private System.Windows.Forms.DataGridView dataGridView_Abonos;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_ApellidoP;
        private System.Windows.Forms.Label lbl_ApellidoM;
        private System.Windows.Forms.Label lbl_Saldo;
        private System.Windows.Forms.Label lbl_LimiteCredito;
        private System.Windows.Forms.Label lbl_Dias;
        private System.Windows.Forms.Label lbl_Abono;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_ApellidoP;
        private System.Windows.Forms.TextBox txt_ApellidoM;
        private System.Windows.Forms.TextBox txt_Saldo;
        private System.Windows.Forms.TextBox txt_LimiteCredito;
        private System.Windows.Forms.TextBox txt_Dias;
        private System.Windows.Forms.TextBox txt_Abono;
        private System.Windows.Forms.GroupBox groupBoxLista_Clientes;
        private System.Windows.Forms.DataGridView dataGridView_Clientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido_P;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido_M;
        private System.Windows.Forms.DataGridViewTextBoxColumn Limite_Credito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dias_Credito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
        private System.Windows.Forms.Label lbl_Fecha;
        private System.Windows.Forms.DateTimePicker dateTimePicker_FechaAbono;
        private PictureBox pic_Logo;
        #endregion
        private void Diseño_Forma()
        {
            pic_Logo = new System.Windows.Forms.PictureBox();
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Abono));
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            acercadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            errorProvider1 = new System.Windows.Forms.ErrorProvider(components);
            groupBox = new System.Windows.Forms.GroupBox();
            bttn_Abono = new System.Windows.Forms.Button();
            groupBox_listaAbonos = new System.Windows.Forms.GroupBox();
            dataGridView_Abonos = new System.Windows.Forms.DataGridView();
            lbl_Nombre = new System.Windows.Forms.Label();
            lbl_ApellidoP = new System.Windows.Forms.Label();
            lbl_ApellidoM = new System.Windows.Forms.Label();
            lbl_Saldo = new System.Windows.Forms.Label();
            lbl_LimiteCredito = new System.Windows.Forms.Label();
            lbl_Dias = new System.Windows.Forms.Label();
            lbl_Abono = new System.Windows.Forms.Label();
            txt_Nombre = new System.Windows.Forms.TextBox();
            txt_ApellidoP = new System.Windows.Forms.TextBox();
            txt_ApellidoM = new System.Windows.Forms.TextBox();
            txt_Saldo = new System.Windows.Forms.TextBox();
            txt_LimiteCredito = new System.Windows.Forms.TextBox();
            txt_Dias = new System.Windows.Forms.TextBox();
            txt_Abono = new System.Windows.Forms.TextBox();
            groupBoxLista_Clientes = new System.Windows.Forms.GroupBox();
            dataGridView_Clientes = new System.Windows.Forms.DataGridView();
            Id_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Apellido_P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Apellido_M = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Limite_Credito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Dias_Credito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            pictureBox_Logo = new System.Windows.Forms.PictureBox();
            dateTimePicker_FechaAbono = new System.Windows.Forms.DateTimePicker();
            lbl_Fecha = new System.Windows.Forms.Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(errorProvider1)).BeginInit();
            groupBox.SuspendLayout();
            groupBox_listaAbonos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(dataGridView_Abonos)).BeginInit();
            groupBoxLista_Clientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(dataGridView_Clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox_Logo)).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(186)))), ((int)(((byte)(82)))));
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            archivoToolStripMenuItem,
            ayudaToolStripMenuItem});
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(867, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            nuevoToolStripMenuItem,
            abrirToolStripMenuItem,
            toolStripSeparator2,
            salirToolStripMenuItem});
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            nuevoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuevoToolStripMenuItem.Image")));
            nuevoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            nuevoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            nuevoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            nuevoToolStripMenuItem.Text = "&Nuevo";
            nuevoToolStripMenuItem.Click += new System.EventHandler(nuevoToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("abrirToolStripMenuItem.Image")));
            abrirToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            abrirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            abrirToolStripMenuItem.Text = "&Abrir";
            abrirToolStripMenuItem.Click += new System.EventHandler(abrirToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            salirToolStripMenuItem.Text = "&Salir";
            salirToolStripMenuItem.Click += new System.EventHandler(salirToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            acercadeToolStripMenuItem});
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            ayudaToolStripMenuItem.Text = "Ay&uda";
            // 
            // acercadeToolStripMenuItem
            // 
            acercadeToolStripMenuItem.Name = "acercadeToolStripMenuItem";
            acercadeToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            acercadeToolStripMenuItem.Text = "&Acerca de...";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // groupBox
            // 
            groupBox.Controls.Add(lbl_Fecha);
            groupBox.Controls.Add(dateTimePicker_FechaAbono);
            groupBox.Controls.Add(bttn_Abono);
            groupBox.Controls.Add(groupBox_listaAbonos);
            groupBox.Controls.Add(lbl_Nombre);
            groupBox.Controls.Add(lbl_ApellidoP);
            groupBox.Controls.Add(lbl_ApellidoM);
            groupBox.Controls.Add(lbl_Saldo);
            groupBox.Controls.Add(lbl_LimiteCredito);
            groupBox.Controls.Add(lbl_Dias);
            groupBox.Controls.Add(lbl_Abono);
            groupBox.Controls.Add(txt_Nombre);
            groupBox.Controls.Add(txt_ApellidoP);
            groupBox.Controls.Add(txt_ApellidoM);
            groupBox.Controls.Add(txt_Saldo);
            groupBox.Controls.Add(txt_LimiteCredito);
            groupBox.Controls.Add(txt_Dias);
            groupBox.Controls.Add(txt_Abono);
            groupBox.Controls.Add(groupBoxLista_Clientes);
            groupBox.Location = new System.Drawing.Point(1, 22);
            groupBox.Name = "groupBox";
            groupBox.Size = new System.Drawing.Size(867, 364);
            groupBox.TabIndex = 6;
            groupBox.TabStop = false;
            // 
            // bttn_Abono
            // 
            bttn_Abono.Location = new System.Drawing.Point(439, 326);
            bttn_Abono.Name = "bttn_Abono";
            bttn_Abono.Size = new System.Drawing.Size(75, 23);
            bttn_Abono.TabIndex = 39;
            bttn_Abono.Text = "Abonar";
            bttn_Abono.UseVisualStyleBackColor = true;
            bttn_Abono.Click += new System.EventHandler(bttn_Abono_Click);
            // 
            // groupBox_listaAbonos
            // 
            groupBox_listaAbonos.Controls.Add(dataGridView_Abonos);
            groupBox_listaAbonos.Location = new System.Drawing.Point(541, 27);
            groupBox_listaAbonos.Name = "groupBox_listaAbonos";
            groupBox_listaAbonos.Size = new System.Drawing.Size(257, 325);
            groupBox_listaAbonos.TabIndex = 26;
            groupBox_listaAbonos.TabStop = false;
            groupBox_listaAbonos.Text = "Lista de abonos anteriores";
            // 
            // dataGridView_Abonos
            // 
            dataGridView_Abonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Abonos.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView_Abonos.Location = new System.Drawing.Point(3, 16);
            dataGridView_Abonos.Name = "dataGridView_Abonos";
            dataGridView_Abonos.Size = new System.Drawing.Size(251, 306);
            dataGridView_Abonos.TabIndex = 6;
            // 
            // lbl_Nombre
            // 
            lbl_Nombre.AutoSize = true;
            lbl_Nombre.Location = new System.Drawing.Point(298, 43);
            lbl_Nombre.Name = "lbl_Nombre";
            lbl_Nombre.Size = new System.Drawing.Size(44, 13);
            lbl_Nombre.TabIndex = 22;
            lbl_Nombre.Text = "Nombre";
            // 
            // lbl_ApellidoP
            // 
            lbl_ApellidoP.AutoSize = true;
            lbl_ApellidoP.Location = new System.Drawing.Point(298, 77);
            lbl_ApellidoP.Name = "lbl_ApellidoP";
            lbl_ApellidoP.Size = new System.Drawing.Size(83, 13);
            lbl_ApellidoP.TabIndex = 25;
            lbl_ApellidoP.Text = "Apellido paterno";
            // 
            // lbl_ApellidoM
            // 
            lbl_ApellidoM.AutoSize = true;
            lbl_ApellidoM.Location = new System.Drawing.Point(298, 111);
            lbl_ApellidoM.Name = "lbl_ApellidoM";
            lbl_ApellidoM.Size = new System.Drawing.Size(85, 13);
            lbl_ApellidoM.TabIndex = 27;
            lbl_ApellidoM.Text = "Apellido materno";
            // 
            // lbl_Saldo
            // 
            lbl_Saldo.AutoSize = true;
            lbl_Saldo.Location = new System.Drawing.Point(298, 150);
            lbl_Saldo.Name = "lbl_Saldo";
            lbl_Saldo.Size = new System.Drawing.Size(34, 13);
            lbl_Saldo.TabIndex = 28;
            lbl_Saldo.Text = "Saldo";
            // 
            // lbl_LimiteCredito
            // 
            lbl_LimiteCredito.AutoSize = true;
            lbl_LimiteCredito.Location = new System.Drawing.Point(298, 187);
            lbl_LimiteCredito.Name = "lbl_LimiteCredito";
            lbl_LimiteCredito.Size = new System.Drawing.Size(84, 13);
            lbl_LimiteCredito.TabIndex = 29;
            lbl_LimiteCredito.Text = "Limite de credito";
            // 
            // lbl_Dias
            // 
            lbl_Dias.AutoSize = true;
            lbl_Dias.Location = new System.Drawing.Point(298, 224);
            lbl_Dias.Name = "lbl_Dias";
            lbl_Dias.Size = new System.Drawing.Size(78, 13);
            lbl_Dias.TabIndex = 30;
            lbl_Dias.Text = "Dias de credito";
            // 
            // lbl_Abono
            // 
            lbl_Abono.AutoSize = true;
            lbl_Abono.Location = new System.Drawing.Point(298, 261);
            lbl_Abono.Name = "lbl_Abono";
            lbl_Abono.Size = new System.Drawing.Size(47, 13);
            lbl_Abono.TabIndex = 31;
            lbl_Abono.Text = "Abono $";
            // 
            // txt_Nombre
            // 
            txt_Nombre.Enabled = false;
            txt_Nombre.Location = new System.Drawing.Point(414, 36);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new System.Drawing.Size(100, 20);
            txt_Nombre.TabIndex = 32;
            // 
            // txt_ApellidoP
            // 
            txt_ApellidoP.Enabled = false;
            txt_ApellidoP.Location = new System.Drawing.Point(414, 70);
            txt_ApellidoP.Name = "txt_ApellidoP";
            txt_ApellidoP.Size = new System.Drawing.Size(100, 20);
            txt_ApellidoP.TabIndex = 33;
            // 
            // txt_ApellidoM
            // 
            txt_ApellidoM.Enabled = false;
            txt_ApellidoM.Location = new System.Drawing.Point(414, 104);
            txt_ApellidoM.Name = "txt_ApellidoM";
            txt_ApellidoM.Size = new System.Drawing.Size(100, 20);
            txt_ApellidoM.TabIndex = 34;
            // 
            // txt_Saldo
            // 
            txt_Saldo.Enabled = false;
            txt_Saldo.Location = new System.Drawing.Point(414, 143);
            txt_Saldo.Name = "txt_Saldo";
            txt_Saldo.Size = new System.Drawing.Size(100, 20);
            txt_Saldo.TabIndex = 35;
            // 
            // txt_LimiteCredito
            // 
            txt_LimiteCredito.Enabled = false;
            txt_LimiteCredito.Location = new System.Drawing.Point(414, 180);
            txt_LimiteCredito.Name = "txt_LimiteCredito";
            txt_LimiteCredito.Size = new System.Drawing.Size(100, 20);
            txt_LimiteCredito.TabIndex = 36;
            // 
            // txt_Dias
            // 
            txt_Dias.Enabled = false;
            txt_Dias.Location = new System.Drawing.Point(414, 217);
            txt_Dias.Name = "txt_Dias";
            txt_Dias.Size = new System.Drawing.Size(100, 20);
            txt_Dias.TabIndex = 37;
            // 
            // txt_Abono
            // 
            txt_Abono.Location = new System.Drawing.Point(414, 254);
            txt_Abono.MaxLength = 9;
            txt_Abono.Name = "txt_Abono";
            txt_Abono.Size = new System.Drawing.Size(100, 20);
            txt_Abono.TabIndex = 38;
            // 
            // groupBoxLista_Clientes
            // 
            groupBoxLista_Clientes.Controls.Add(dataGridView_Clientes);
            groupBoxLista_Clientes.Location = new System.Drawing.Point(11, 27);
            groupBoxLista_Clientes.Name = "groupBoxLista_Clientes";
            groupBoxLista_Clientes.Size = new System.Drawing.Size(257, 325);
            groupBoxLista_Clientes.TabIndex = 24;
            groupBoxLista_Clientes.TabStop = false;
            groupBoxLista_Clientes.Text = "Lista de clientes";
            // 
            // dataGridView_Clientes
            // 
            dataGridView_Clientes.AllowUserToAddRows = false;
            dataGridView_Clientes.AllowUserToDeleteRows = false;
            dataGridView_Clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            Id_Cliente,
            Nombre,
            Apellido_P,
            Apellido_M,
            Limite_Credito,
            Dias_Credito,
            Saldo});
            dataGridView_Clientes.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView_Clientes.Location = new System.Drawing.Point(3, 16);
            dataGridView_Clientes.Name = "dataGridView_Clientes";
            dataGridView_Clientes.ReadOnly = true;
            dataGridView_Clientes.Size = new System.Drawing.Size(251, 306);
            dataGridView_Clientes.TabIndex = 6;
            dataGridView_Clientes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(dataGridView_Clientes_MouseDoubleClick);
            // 
            // Id_Cliente
            // 
            Id_Cliente.HeaderText = "Id_Cliente";
            Id_Cliente.Name = "Id_Cliente";
            Id_Cliente.ReadOnly = true;
            Id_Cliente.Visible = false;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Apellido_P
            // 
            Apellido_P.HeaderText = "Apellido_P";
            Apellido_P.Name = "Apellido_P";
            Apellido_P.ReadOnly = true;
            // 
            // Apellido_M
            // 
            Apellido_M.HeaderText = "Apellido_M";
            Apellido_M.Name = "Apellido_M";
            Apellido_M.ReadOnly = true;
            // 
            // Limite_Credito
            // 
            Limite_Credito.HeaderText = "Limite_Credito";
            Limite_Credito.Name = "Limite_Credito";
            Limite_Credito.ReadOnly = true;
            Limite_Credito.Visible = false;
            // 
            // Dias_Credito
            // 
            Dias_Credito.HeaderText = "Dias_Credito";
            Dias_Credito.Name = "Dias_Credito";
            Dias_Credito.ReadOnly = true;
            Dias_Credito.Visible = false;
            // 
            // Saldo
            // 
            Saldo.HeaderText = "Saldo";
            Saldo.Name = "Saldo";
            Saldo.ReadOnly = true;
            Saldo.Visible = false;
            // 
            // pictureBox_Logo
            // 
            pictureBox_Logo.BackgroundImage = global::Shajobe.Properties.Resources.Modificar;
            pictureBox_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox_Logo.Location = new System.Drawing.Point(799, 22);
            pictureBox_Logo.Name = "pictureBox_Logo";
            pictureBox_Logo.Size = new System.Drawing.Size(65, 44);
            pictureBox_Logo.TabIndex = 24;
            pictureBox_Logo.TabStop = false;
            // 
            // dateTimePicker_FechaAbono
            // 
            dateTimePicker_FechaAbono.Location = new System.Drawing.Point(314, 300);
            dateTimePicker_FechaAbono.Name = "dateTimePicker_FechaAbono";
            dateTimePicker_FechaAbono.Size = new System.Drawing.Size(200, 20);
            dateTimePicker_FechaAbono.TabIndex = 40;
            // 
            // lbl_Fecha
            // 
            lbl_Fecha.AutoSize = true;
            lbl_Fecha.Location = new System.Drawing.Point(376, 283);
            lbl_Fecha.Name = "lbl_Fecha";
            lbl_Fecha.Size = new System.Drawing.Size(85, 13);
            lbl_Fecha.TabIndex = 41;
            lbl_Fecha.Text = "Fecha de abono";
            // 
            // pic_Logo
            // 
            pic_Logo.BackgroundImage = global::Shajobe.Properties.Resources.Logo_Shajobe;
            pic_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pic_Logo.Location = new System.Drawing.Point(90, 250);
            pic_Logo.Name = "pic_Logo";
            pic_Logo.Size = new System.Drawing.Size(156, 74);
            pic_Logo.TabIndex = 13;
            pic_Logo.TabStop = false;
            // 
            // Abono
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(228)))), ((int)(((byte)(196)))));
            ClientSize = new System.Drawing.Size(867, 389);
            Controls.Add(pictureBox_Logo);
            Controls.Add(groupBox);
            Controls.Add(menuStrip1);
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(873, 413);
            MinimumSize = new System.Drawing.Size(873, 413);
            Icon = global::Shajobe.Properties.Resources.Caja_ICO;
            Name = "Abono";
            Text = "Abono";
            Load += new System.EventHandler(Abono_Load);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(errorProvider1)).EndInit();
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            groupBox_listaAbonos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(dataGridView_Abonos)).EndInit();
            groupBoxLista_Clientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(dataGridView_Clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox_Logo)).EndInit();
            AnimateWindow(Handle, 350, AnimateWindowFlags.AW_CENTER);
            AnimateWindow(Handle, 350, AnimateWindowFlags.AW_CENTER | AnimateWindowFlags.AW_SLIDE);
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        #region Eventos
        //-------------------------------------------------------------
        //-------------------------Variables---------------------------
        //-------------------------------------------------------------
        private int Idp = 0;
        private bool Espacios_Vacios = false;
        private void Abono_Load(object sender, EventArgs e)
        {
            Diseño_Forma();
            #region Carga de elementos
            Llenando_ListaClientes();
            #endregion

        }
        #region Carga de datos
        private void Llenando_ListaClientes()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand coman = new OleDbCommand();
            OleDbDataReader dr;
            con.ConnectionString = ObtenerString();
            coman.Connection = con;
            coman.CommandText = "SELECT Nombre, Apellido_P, Apellido_M, Limite_Credito, Dias_Credito, Saldo, Id_Cliente FROM Tb_Cliente where Saldo>0.00 AND Activo= 'S'";
            coman.CommandType = CommandType.Text;
            con.Open();
            dataGridView_Clientes.Rows.Clear();
            dr = coman.ExecuteReader();
            while (dr.Read())
            {
                //Creando y obteniendo el indice para un nuevo renglon
                int Indice = dataGridView_Clientes.Rows.Add();
                dataGridView_Clientes.Rows[Indice].Cells["Id_Cliente"].Value = dr.GetInt32(dr.GetOrdinal("Id_Cliente"));
                dataGridView_Clientes.Rows[Indice].Cells["Nombre"].Value = dr.GetString(dr.GetOrdinal("Nombre"));
                dataGridView_Clientes.Rows[Indice].Cells["Apellido_P"].Value = dr.GetString(dr.GetOrdinal("Apellido_P"));
                dataGridView_Clientes.Rows[Indice].Cells["Apellido_M"].Value = dr.GetString(dr.GetOrdinal("Apellido_M"));
                dataGridView_Clientes.Rows[Indice].Cells["Limite_Credito"].Value = dr.GetDecimal(dr.GetOrdinal("Limite_Credito"));
                dataGridView_Clientes.Rows[Indice].Cells["Dias_Credito"].Value = dr.GetInt32(dr.GetOrdinal("Dias_Credito"));
                dataGridView_Clientes.Rows[Indice].Cells["Saldo"].Value = dr.GetDecimal(dr.GetOrdinal("Saldo"));
            }
            con.Close();
        }
        #endregion
        //-------------------------------------------------------------
        //------Obtiene la cadena de conexion desde la app Config------
        //-------------------------------------------------------------
        public static string ObtenerString()
        {
            return Settings.Default.ShajobeConnectionString;
        }
        private void dataGridView_Clientes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txt_Nombre.Text = Convert.ToString(dataGridView_Clientes.CurrentRow.Cells["Nombre"].Value);
            txt_ApellidoP.Text = Convert.ToString(dataGridView_Clientes.CurrentRow.Cells["Apellido_P"].Value);
            txt_ApellidoM.Text = Convert.ToString(dataGridView_Clientes.CurrentRow.Cells["Apellido_M"].Value);
            txt_Dias.Text = Convert.ToString(dataGridView_Clientes.CurrentRow.Cells["Dias_Credito"].Value);
            txt_LimiteCredito.Text = Convert.ToString(dataGridView_Clientes.CurrentRow.Cells["Limite_Credito"].Value);
            txt_Saldo.Text = Convert.ToString(dataGridView_Clientes.CurrentRow.Cells["Saldo"].Value);
        }
        //-------------------------------------------------------------
        //----------------CONFIGURACION DE CONTROLES-------------------
        //-------------------------------------------------------------
        #region Abrir Panel de busqueda
        //Creando controles
        DataGridView data_resultado;
        TextBox txt_Busqueda;
        PictureBox pic_Lupa;
        Button bttn_Busqueda;
        Panel panel_Busqueda;
        Label lbl_Etiqueta;
        //Creando Columnas del DATAGRID
        DataGridViewTextBoxColumn RFC1;
        DataGridViewTextBoxColumn Nombre_Contacto1;
        DataGridViewTextBoxColumn Apellido_M1;
        DataGridViewTextBoxColumn Apellido_P1;
        DataGridViewTextBoxColumn Nombre1;
        DataGridViewTextBoxColumn Id;
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //INICIALIZANDO CONTROLES
            panel_Busqueda = new System.Windows.Forms.Panel();
            txt_Busqueda = new System.Windows.Forms.TextBox();
            data_resultado = new System.Windows.Forms.DataGridView();
            pic_Lupa = new System.Windows.Forms.PictureBox();
            bttn_Busqueda = new System.Windows.Forms.Button();
            lbl_Etiqueta = new System.Windows.Forms.Label();
            //groupBoxfoto.SuspendLayout();
            //INICIALIZANDO COLUMNAS
            RFC1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Nombre_Contacto1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Apellido_M1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Apellido_P1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Nombre1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            //DISEÑOS DE A LOS CONTROLES
            txt_Busqueda.Location = new System.Drawing.Point(130, 57);
            txt_Busqueda.Name = "txt_Busqueda";
            txt_Busqueda.Size = new System.Drawing.Size(124, 20);
            txt_Busqueda.TabIndex = 0;
            txt_Busqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txt_Busqueda_KeyPress);
            // 
            // pic_Lupa
            // 
            pic_Lupa.BackgroundImage = ((System.Drawing.Image)(global::Shajobe.Properties.Resources.lupa));
            pic_Lupa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pic_Lupa.Location = new System.Drawing.Point(21, 19);
            pic_Lupa.Name = "pic_Lupa";
            pic_Lupa.Size = new System.Drawing.Size(100, 101);
            pic_Lupa.TabIndex = 1;
            pic_Lupa.TabStop = false;
            // 
            // data_resultado
            // 
            data_resultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_resultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            Id,
            Nombre1,
            Apellido_P1,
            Apellido_M1,
            Nombre_Contacto1,
            RFC1});
            data_resultado.Location = new System.Drawing.Point(21, 136);
            data_resultado.Name = "data_resultado";
            data_resultado.RowHeadersWidth = 25;
            data_resultado.RowTemplate.Height = 50;
            data_resultado.Size = new System.Drawing.Size(526, 139);
            data_resultado.TabIndex = 2;
            data_resultado.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.data_resultado_MouseDoubleClick);
            // 
            // RFC
            // 
            RFC1.HeaderText = "RFC";
            RFC1.Name = "RFC";
            // 
            // Nombre_Contacto
            // 
            Nombre_Contacto1.HeaderText = "Nombre_Contacto";
            Nombre_Contacto1.Name = "Nombre_Contacto";
            // 
            // Apellido_M
            // 
            Apellido_M1.HeaderText = "Apellido_M";
            Apellido_M1.Name = "Apellido_M";
            // 
            // Apellido_P
            // 
            Apellido_P1.HeaderText = "Apellido_P";
            Apellido_P1.Name = "Apellido_P";
            // 
            // Nombre
            // 
            Nombre1.HeaderText = "Nombre";
            Nombre1.Name = "Nombre";
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.Visible = false;
            // 
            // lbl_Etiqueta
            // 
            lbl_Etiqueta.AutoSize = true;
            lbl_Etiqueta.Location = new System.Drawing.Point(127, 26);
            lbl_Etiqueta.Name = "lbl_Etiqueta";
            lbl_Etiqueta.Size = new System.Drawing.Size(419, 13);
            lbl_Etiqueta.TabIndex = 3;
            lbl_Etiqueta.Text = "Escriba el nombre, uno de los apellidos, nombre de contacto ó RFC del cliente" +
                "a buscar";
            // 
            // bttn_Busqueda
            // 
            bttn_Busqueda.BackgroundImage = ((System.Drawing.Image)(global::Shajobe.Properties.Resources.Siguiente));
            bttn_Busqueda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            bttn_Busqueda.Location = new System.Drawing.Point(274, 48);
            bttn_Busqueda.Name = "bttn_Busqueda";
            bttn_Busqueda.Size = new System.Drawing.Size(62, 54);
            bttn_Busqueda.TabIndex = 4;
            bttn_Busqueda.UseVisualStyleBackColor = true;
            bttn_Busqueda.Click += new System.EventHandler(bttn_Busqueda_Click);
            // 
            // panel_Busqueda
            // 
            panel_Busqueda.Controls.Add(bttn_Busqueda);
            panel_Busqueda.Controls.Add(lbl_Etiqueta);
            panel_Busqueda.Controls.Add(data_resultado);
            panel_Busqueda.Controls.Add(pic_Lupa);
            panel_Busqueda.Controls.Add(txt_Busqueda);
            panel_Busqueda.Enabled = false;
            panel_Busqueda.Location = new System.Drawing.Point(160, 38);
            panel_Busqueda.Name = "panel_Busqueda";
            panel_Busqueda.Size = new System.Drawing.Size(568, 496);
            panel_Busqueda.TabIndex = 35;
            panel_Busqueda.Visible = false;
            //CARACTERISTICA DE AUTOCOMPLETADO EN TXT_BUSQUEDA
            txt_Busqueda.AutoCompleteCustomSource = Autocomplete();
            txt_Busqueda.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_Busqueda.AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.Controls.Add(panel_Busqueda);
            groupBox.Visible = false;
            panel_Busqueda.Visible = true;
            panel_Busqueda.Enabled = true;
        }
        #endregion
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Limpiar()
        {
            txt_Saldo.Clear();
            txt_Nombre.Clear();
            txt_LimiteCredito.Clear();
            txt_Dias.Clear();
            txt_ApellidoP.Clear();
            txt_ApellidoM.Clear();
            txt_Abono.Clear();
            errorProvider1.Clear();
            //DATAGRIDBVIEW
            dataGridView_Abonos.Rows.Clear();
            Llenando_ListaClientes();
            try
            {
                //Quito el panel de busqueda
                this.Controls.Remove(panel_Busqueda);
            }
            catch (Exception)
            {
                //En caso de que no existe todavia el panel de busqueda
                //omite la instrucción de quitar dicho control
            }
            groupBox.Visible = true;
            errorProvider1.Clear();
        }
        private void bttn_Busqueda_Click(object sender, EventArgs e)
        {
            Busqueda();
        }
        private void bttn_Abono_Click(object sender, EventArgs e)
        {
            //Obtengo que ficha o que control esta activa para poder limpiar dicho control
            OleDbConnection conexion = null;
            OleDbTransaction transaccion = null;
            #region GENERAR ABONO
            bool i = Verificar_CamposVacios();
            if (i == true)
                MessageBox.Show("Inserta todos los datos marcados", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                try
                {
                    conexion = new OleDbConnection(ObtenerString());
                    conexion.Open();
                    transaccion = conexion.BeginTransaction(System.Data.IsolationLevel.Serializable);
                    OleDbCommand comando = new OleDbCommand("SP_Abono", conexion, transaccion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@Id_Cliente ", Idp);
                    comando.Parameters.AddWithValue("@Fecha_Pago ", dateTimePicker_FechaAbono.Value);
                    comando.Parameters.AddWithValue("@Monto_Pago", Convert.ToDecimal(txt_Abono.Text));
                    comando.ExecuteNonQuery();
                    transaccion.Commit();
                    conexion.Close();
                    MessageBox.Show("Datos guardados con éxito", "Solicitud procesada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Limpiar();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha ocurrido un error inesperado", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            #endregion
        }
        //-------------------------------------------------------------
        //------------------Busqueda del sistema-----------------------
        //-------------------------------------------------------------
        #region Busqueda en el sistema
        public void BusquedaDatos(int Idp)
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand coman = new OleDbCommand();
            OleDbDataReader dr;
            con.ConnectionString = ObtenerString();
            coman.Connection = con;
            coman.CommandText = "Select Id_Cliente,Nombre,Apellido_P,Apellido_M,Saldo,Limite_Credito,Dias_Credito from Tb_Cliente where Id_Cliente='" + Idp + "'";
            coman.CommandType = CommandType.Text;
            con.Open();
            data_resultado.Rows.Clear();
            dr = coman.ExecuteReader();
            while (dr.Read())
            {
                Idp = dr.GetInt32(dr.GetOrdinal("Id_Cliente"));
                txt_Nombre.Text = dr.GetString(dr.GetOrdinal("Nombre"));
                txt_ApellidoP.Text = dr.GetString(dr.GetOrdinal("Apellido_P"));
                txt_ApellidoM.Text = dr.GetString(dr.GetOrdinal("Apellido_M"));
                txt_Saldo.Text = dr.GetDecimal(dr.GetOrdinal("Saldo")).ToString("N");
                txt_LimiteCredito.Text = dr.GetDecimal(dr.GetOrdinal("Limite_Credito")).ToString("N");
                txt_Dias.Text = (dr.GetInt32(dr.GetOrdinal("Dias_Credito"))).ToString();
            }
            con.Close();
        }
        private void Busqueda()
        {
            if (txt_Busqueda.Text.Trim() == "")
            {
                errorProvider1.SetError(txt_Busqueda, "No puedes dejar el campo vacio");
                MessageBox.Show("Inserta todos los datos marcados", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                OleDbConnection con = new OleDbConnection();
                OleDbCommand coman = new OleDbCommand();
                OleDbDataReader dr;
                con.ConnectionString = ObtenerString();
                coman.Connection = con;
                string busqueda = txt_Busqueda.Text;
                txt_Busqueda.Text = busqueda.ToUpper();
                coman.CommandText = "Select Id_Cliente,Foto,Nombre,Apellido_P,Apellido_M,Nombre_Contacto,RFC from Tb_Cliente where (Nombre='" + busqueda.ToUpper() + "'OR Apellido_P='" + busqueda.ToUpper() + "'OR Apellido_M='" + busqueda.ToUpper() + "'OR Nombre_Contacto='" + busqueda.ToUpper() + "'OR RFC='" + busqueda.ToUpper() + "') AND Activo='S'";
                coman.CommandType = CommandType.Text;
                con.Open();
                data_resultado.Rows.Clear();
                dr = coman.ExecuteReader();
                while (dr.Read())
                {
                    int Renglon = data_resultado.Rows.Add();
                    Idp = dr.GetInt32(dr.GetOrdinal("Id_Cliente"));
                    data_resultado.Rows[Renglon].Cells["Id"].Value = dr.GetInt32(dr.GetOrdinal("Id_Cliente"));
                    data_resultado.Rows[Renglon].Cells["Nombre"].Value = dr.GetString(dr.GetOrdinal("Nombre"));
                    data_resultado.Rows[Renglon].Cells["Apellido_P"].Value = dr.GetString(dr.GetOrdinal("Apellido_P"));
                    data_resultado.Rows[Renglon].Cells["Apellido_M"].Value = dr.GetString(dr.GetOrdinal("Apellido_M"));
                    data_resultado.Rows[Renglon].Cells["Nombre_Contacto"].Value = dr.GetString(dr.GetOrdinal("Nombre_Contacto"));
                    data_resultado.Rows[Renglon].Cells["RFC"].Value = dr.GetString(dr.GetOrdinal("RFC"));
                }
                con.Close();
            }
        }
        #endregion
        //-------------------------------------------------------------
        //----------------------AUTO COMPLETAR-------------------------
        //-------------------------------------------------------------
        #region Autocompletar
        //metodo para cargar la coleccion de datos para el autocomplete
        public static DataTable Datos()
        {
            DataTable dt = new DataTable();

            OleDbConnection conexion = new OleDbConnection(ObtenerString());//cadena conexion
            string consulta = "SELECT * FROM Tb_Cliente where Activo='S'"; //consulta a la tabla paises
            OleDbCommand comando = new OleDbCommand(consulta, conexion);
            OleDbDataAdapter adap = new OleDbDataAdapter(comando);
            adap.Fill(dt);
            return dt;
        }
        //metodo para cargar la coleccion de datos para el autocomplete
        public static AutoCompleteStringCollection Autocomplete()
        {
            DataTable dt = Datos();

            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            //recorrer y cargar los items para el autocompletado
            foreach (DataRow row in dt.Rows)
            {
                coleccion.Add(Convert.ToString(row["Nombre"]));
                coleccion.Add(Convert.ToString(row["Apellido_P"]));
                coleccion.Add(Convert.ToString(row["Apellido_M"]));
                coleccion.Add(Convert.ToString(row["Nombre_Contacto"]));
                coleccion.Add(Convert.ToString(row["RFC"]));
            }

            return coleccion;
        }
        #endregion
        //-------------------------------------------------------------
        //------------------DATAGRIDVIEW BUSQUEDA----------------------
        //-------------------------------------------------------------
        //ACCION QUE REALIZA CUANDO SE DA DOBLE CLIC SOBRE EL DATAGRIDVIEW DE BUSQUEDA
        private void data_resultado_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Idp = Convert.ToInt32(data_resultado.CurrentRow.Cells["Id"].Value);
            Limpiar();
            BusquedaDatos(Idp);
            //Quito el panel de busqueda
            this.Controls.Remove(panel_Busqueda);
        }
        //-------------------------------------------------------------
        //-------------------Validacion de campos----------------------
        //-------------------------------------------------------------
        private TextBox[] Campos = new TextBox[7];
        #region VALIDAR CAMPOS
        private bool Verificar_CamposVacios()
        {
            //Se introduce los textbox en un arreglo con el fin de identificar espacios vacios
            Campos[0] = txt_Nombre;
            Campos[1] = txt_ApellidoP;
            Campos[2] = txt_ApellidoM;
            Campos[3] = txt_Abono;
            Campos[4] = txt_LimiteCredito;
            Campos[5] = txt_Dias;
            Campos[6] = txt_Saldo;
            //Reinicio el error provider para volver a reemarcar
            errorProvider1.Clear();
            Espacios_Vacios = false;
            for (int i = 0; i < Campos.Length; i++)
            {
                if (Campos[i].Text.Trim() == "")
                {
                    Indicador_CamposVacios(i);
                    Espacios_Vacios = true;
                }

            }
            return Espacios_Vacios;
        }
        private void Indicador_CamposVacios(int i)
        {
            switch (i)
            {
                case 0:
                    errorProvider1.SetError(txt_Nombre, "No puedes dejar el campo vacio");
                    break;
                case 1:
                    errorProvider1.SetError(txt_ApellidoP, "No puedes dejar el campo vacio");
                    break;
                case 2:
                    errorProvider1.SetError(txt_ApellidoM, "No puedes dejar el campo vacio");
                    break;
                case 3:
                    errorProvider1.SetError(txt_Abono, "No puedes dejar el campo vacio");
                    break;
                case 4:
                    errorProvider1.SetError(txt_LimiteCredito, "No puedes dejar el campo vacio");
                    break;
                case 5:
                    errorProvider1.SetError(txt_Dias, "No puedes dejar el campo vacio");
                    break;
                case 6:
                    errorProvider1.SetError(txt_Saldo, "No puedes dejar el campo vacio");
                    break;
                default:
                    break;
            }
        }
        private void txt_Abono_KeyPress(object sender, KeyPressEventArgs e)
        {
            //---------Apartado de numeros-------------Apartado de teclas especiales Retroceso y suprimir------------------------Uso del punto
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar < 7 || e.KeyChar > 9) && (e.KeyChar < 126 || e.KeyChar > 128) && (e.KeyChar < 45 || e.KeyChar > 47))
            {
                MessageBox.Show("Solo se aceptan numeros", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                e.Handled = true;
            }
        }
        private void txt_Busqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar < 65 || e.KeyChar > 90) && (e.KeyChar < 97 || e.KeyChar > 122) && (e.KeyChar < 7 || e.KeyChar > 9) && (e.KeyChar < 126 || e.KeyChar > 128) && (e.KeyChar < 45 || e.KeyChar > 47) && (e.KeyChar < 31 || e.KeyChar > 33))
            {
                MessageBox.Show("Solo se aceptan letras y numeros", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                e.Handled = true;
            }
        }
        #endregion
        #endregion
        #region Animación de la forma
        // 
        //EFECTOS VENTANA
        //
        [DllImport("user32.dll")]
        static extern bool AnimateWindow(IntPtr hWnd, int time, AnimateWindowFlags flags);
        [Flags]
        enum AnimateWindowFlags
        {
            AW_HOR_POSITIVE = 0x00000001,
            AW_HOR_NEGATIVE = 0x00000002,
            AW_VER_POSITIVE = 0x00000004,
            AW_VER_NEGATIVE = 0x00000008,
            AW_CENTER = 0x00000010,
            AW_HIDE = 0x00010000,
            AW_ACTIVATE = 0x00020000,
            AW_SLIDE = 0x00040000,
            AW_BLEND = 0x00080000
        }
        #endregion
    }
}
