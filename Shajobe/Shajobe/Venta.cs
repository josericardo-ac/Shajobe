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
    public partial class Venta : Form
    {
        public Venta()
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
        private System.Windows.Forms.ToolStripMenuItem documentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notaDeRemisiónToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView_Productos;
        private System.Windows.Forms.ComboBox comboBox_Cliente;
        private System.Windows.Forms.ComboBox comboBoxTipoPago;
        private System.Windows.Forms.ComboBox comboBoxAdquisicion;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.DateTimePicker dateTimeVenta;
        private System.Windows.Forms.DataGridView dataGridView_Carrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_ProductoTerminado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lote;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.Label lbl_Cantidad;
        private System.Windows.Forms.Label lbl_SubTotal;
        private System.Windows.Forms.TextBox txt_IVA;
        private System.Windows.Forms.TextBox txt_Descuento;
        private System.Windows.Forms.TextBox txt_SubTotal;
        private System.Windows.Forms.Label lbl_Descuento;
        private System.Windows.Forms.Label lbl_IVA;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.TextBox txt_Total;
        private System.Windows.Forms.TextBox txt_Efectivo;
        private System.Windows.Forms.Label lbl_Efectivo;
        private System.Windows.Forms.TextBox txt_Cambio;
        private System.Windows.Forms.Label lbl_Cambio;
        private System.Windows.Forms.GroupBox groupBox_Productos;
        private System.Windows.Forms.Button bttn_Agregar;
        private System.Windows.Forms.Button bttn_Quitar;
        private System.Windows.Forms.Button btn_Pagar;
        private System.Windows.Forms.PictureBox pic_Venta;
        private System.Windows.Forms.GroupBox groupBox_Informacion;
        private System.Windows.Forms.Label lbl_TipoPago;
        private System.Windows.Forms.Label lbl_Adquisicion;
        private System.Windows.Forms.Label lbl_Fecha;
        private System.Windows.Forms.Label lbl_Cliente;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_ProductoTerminadoP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionP;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_VentaP;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoteP;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescuentoP;
        private PictureBox pic_Logo;
        #endregion
        private void Diseño_Forma()
        {
            pic_Logo = new System.Windows.Forms.PictureBox();
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Venta));
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            acercadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            documentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            notaDeRemisiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            dataGridView_Productos = new System.Windows.Forms.DataGridView();
            Id_ProductoTerminadoP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DescripcionP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            NombreP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Precio_VentaP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            LoteP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CantidadP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DescuentoP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            comboBox_Cliente = new System.Windows.Forms.ComboBox();
            comboBoxTipoPago = new System.Windows.Forms.ComboBox();
            comboBoxAdquisicion = new System.Windows.Forms.ComboBox();
            txt_Cantidad = new System.Windows.Forms.TextBox();
            dateTimeVenta = new System.Windows.Forms.DateTimePicker();
            dataGridView_Carrito = new System.Windows.Forms.DataGridView();
            Id_ProductoTerminado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Lote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            lbl_Cantidad = new System.Windows.Forms.Label();
            lbl_SubTotal = new System.Windows.Forms.Label();
            txt_IVA = new System.Windows.Forms.TextBox();
            txt_Descuento = new System.Windows.Forms.TextBox();
            txt_SubTotal = new System.Windows.Forms.TextBox();
            lbl_Descuento = new System.Windows.Forms.Label();
            lbl_IVA = new System.Windows.Forms.Label();
            lbl_Total = new System.Windows.Forms.Label();
            txt_Total = new System.Windows.Forms.TextBox();
            txt_Efectivo = new System.Windows.Forms.TextBox();
            lbl_Efectivo = new System.Windows.Forms.Label();
            txt_Cambio = new System.Windows.Forms.TextBox();
            lbl_Cambio = new System.Windows.Forms.Label();
            groupBox_Productos = new System.Windows.Forms.GroupBox();
            bttn_Agregar = new System.Windows.Forms.Button();
            bttn_Quitar = new System.Windows.Forms.Button();
            btn_Pagar = new System.Windows.Forms.Button();
            pic_Venta = new System.Windows.Forms.PictureBox();
            groupBox_Informacion = new System.Windows.Forms.GroupBox();
            lbl_Cliente = new System.Windows.Forms.Label();
            lbl_TipoPago = new System.Windows.Forms.Label();
            lbl_Adquisicion = new System.Windows.Forms.Label();
            lbl_Fecha = new System.Windows.Forms.Label();
            errorProvider1 = new System.Windows.Forms.ErrorProvider(components);
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(dataGridView_Productos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dataGridView_Carrito)).BeginInit();
            groupBox_Productos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(pic_Venta)).BeginInit();
            groupBox_Informacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(errorProvider1)).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(186)))), ((int)(((byte)(82)))));
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            archivoToolStripMenuItem,
            ayudaToolStripMenuItem,
            documentoToolStripMenuItem});
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(1019, 24);
            menuStrip1.TabIndex = 4;
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
            nuevoToolStripMenuItem.Image = global::Shajobe.Properties.Resources.Nuevo;
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
            abrirToolStripMenuItem.Image = global::Shajobe.Properties.Resources.Abrir;
            abrirToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            abrirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            abrirToolStripMenuItem.Text = "&Abrir";
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
            // documentoToolStripMenuItem
            // 
            documentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            notaDeRemisiónToolStripMenuItem});
            documentoToolStripMenuItem.Name = "documentoToolStripMenuItem";
            documentoToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            documentoToolStripMenuItem.Text = "Documento";
            // 
            // notaDeRemisiónToolStripMenuItem
            // 
            notaDeRemisiónToolStripMenuItem.Name = "notaDeRemisiónToolStripMenuItem";
            notaDeRemisiónToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            notaDeRemisiónToolStripMenuItem.Text = "Nota de remisión";
            // 
            // dataGridView_Productos
            // 
            dataGridView_Productos.AllowUserToDeleteRows = false;
            dataGridView_Productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Productos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            Id_ProductoTerminadoP,
            DescripcionP,
            NombreP,
            Precio_VentaP,
            LoteP,
            CantidadP,
            DescuentoP});
            dataGridView_Productos.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView_Productos.Location = new System.Drawing.Point(3, 16);
            dataGridView_Productos.Name = "dataGridView_Productos";
            dataGridView_Productos.Size = new System.Drawing.Size(429, 242);
            dataGridView_Productos.TabIndex = 5;
            // 
            // Id_ProductoTerminadoP
            // 
            Id_ProductoTerminadoP.HeaderText = "Id_ProductoTerminado";
            Id_ProductoTerminadoP.Name = "Id_ProductoTerminadoP";
            Id_ProductoTerminadoP.Visible = false;
            // 
            // DescripcionP
            // 
            DescripcionP.HeaderText = "Descripcion";
            DescripcionP.Name = "DescripcionP";
            DescripcionP.Visible = false;
            // 
            // NombreP
            // 
            NombreP.HeaderText = "Nombre";
            NombreP.Name = "NombreP";
            // 
            // Precio_VentaP
            // 
            Precio_VentaP.HeaderText = "Precio";
            Precio_VentaP.Name = "Precio_VentaP";
            // 
            // LoteP
            // 
            LoteP.HeaderText = "Lote";
            LoteP.Name = "LoteP";
            // 
            // CantidadP
            // 
            CantidadP.HeaderText = "Cantidad";
            CantidadP.Name = "CantidadP";
            // 
            // DescuentoP
            // 
            DescuentoP.HeaderText = "Descuento";
            DescuentoP.Name = "DescuentoP";
            // 
            // comboBox_Cliente
            // 
            comboBox_Cliente.FormattingEnabled = true;
            comboBox_Cliente.Location = new System.Drawing.Point(96, 29);
            comboBox_Cliente.Name = "comboBox_Cliente";
            comboBox_Cliente.Size = new System.Drawing.Size(200, 21);
            comboBox_Cliente.TabIndex = 6;
            // 
            // comboBoxTipoPago
            // 
            comboBoxTipoPago.FormattingEnabled = true;
            comboBoxTipoPago.Location = new System.Drawing.Point(96, 56);
            comboBoxTipoPago.Name = "comboBoxTipoPago";
            comboBoxTipoPago.Size = new System.Drawing.Size(121, 21);
            comboBoxTipoPago.TabIndex = 7;
            // 
            // comboBoxAdquisicion
            // 
            comboBoxAdquisicion.FormattingEnabled = true;
            comboBoxAdquisicion.Location = new System.Drawing.Point(96, 83);
            comboBoxAdquisicion.Name = "comboBoxAdquisicion";
            comboBoxAdquisicion.Size = new System.Drawing.Size(121, 21);
            comboBoxAdquisicion.TabIndex = 8;
            // 
            // txt_Cantidad
            // 
            txt_Cantidad.Location = new System.Drawing.Point(453, 85);
            txt_Cantidad.Name = "txt_Cantidad";
            txt_Cantidad.Size = new System.Drawing.Size(100, 20);
            txt_Cantidad.TabIndex = 9;
            txt_Cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txt_Cantidad_KeyPress);
            // 
            // dateTimeVenta
            // 
            dateTimeVenta.Location = new System.Drawing.Point(96, 110);
            dateTimeVenta.Name = "dateTimeVenta";
            dateTimeVenta.Size = new System.Drawing.Size(200, 20);
            dateTimeVenta.TabIndex = 12;
            // 
            // dataGridView_Carrito
            // 
            dataGridView_Carrito.AllowUserToAddRows = false;
            dataGridView_Carrito.AllowUserToDeleteRows = false;
            dataGridView_Carrito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Carrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Carrito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            Id_ProductoTerminado,
            Lote,
            Nombre,
            Descripcion,
            Cantidad,
            Precio});
            dataGridView_Carrito.Location = new System.Drawing.Point(12, 315);
            dataGridView_Carrito.Name = "dataGridView_Carrito";
            dataGridView_Carrito.ReadOnly = true;
            dataGridView_Carrito.Size = new System.Drawing.Size(675, 327);
            dataGridView_Carrito.TabIndex = 13;
            // 
            // Id_ProductoTerminado
            // 
            Id_ProductoTerminado.HeaderText = "Id_ProductoTerminado";
            Id_ProductoTerminado.Name = "Id_ProductoTerminado";
            Id_ProductoTerminado.ReadOnly = true;
            Id_ProductoTerminado.Visible = false;
            // 
            // Lote
            // 
            Lote.HeaderText = "Lote";
            Lote.Name = "Lote";
            Lote.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripción";
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // lbl_Cantidad
            // 
            lbl_Cantidad.AutoSize = true;
            lbl_Cantidad.Location = new System.Drawing.Point(450, 69);
            lbl_Cantidad.Name = "lbl_Cantidad";
            lbl_Cantidad.Size = new System.Drawing.Size(49, 13);
            lbl_Cantidad.TabIndex = 14;
            lbl_Cantidad.Text = "Cantidad";
            // 
            // lbl_SubTotal
            // 
            lbl_SubTotal.AutoSize = true;
            lbl_SubTotal.Location = new System.Drawing.Point(729, 343);
            lbl_SubTotal.Name = "lbl_SubTotal";
            lbl_SubTotal.Size = new System.Drawing.Size(46, 13);
            lbl_SubTotal.TabIndex = 18;
            lbl_SubTotal.Text = "Subtotal";
            // 
            // txt_IVA
            // 
            txt_IVA.Location = new System.Drawing.Point(790, 388);
            txt_IVA.Name = "txt_IVA";
            txt_IVA.Size = new System.Drawing.Size(100, 20);
            txt_IVA.TabIndex = 17;
            txt_IVA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txt_IVA_KeyPress);
            // 
            // txt_Descuento
            // 
            txt_Descuento.Location = new System.Drawing.Point(790, 362);
            txt_Descuento.Name = "txt_Descuento";
            txt_Descuento.Size = new System.Drawing.Size(100, 20);
            txt_Descuento.TabIndex = 16;
            txt_Descuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txt_Descuento_KeyPress);
            // 
            // txt_SubTotal
            // 
            txt_SubTotal.Enabled = false;
            txt_SubTotal.Location = new System.Drawing.Point(790, 336);
            txt_SubTotal.Name = "txt_SubTotal";
            txt_SubTotal.Size = new System.Drawing.Size(100, 20);
            txt_SubTotal.TabIndex = 15;
            txt_SubTotal.TextChanged += new System.EventHandler(txt_SubTotal_TextChanged);
            // 
            // lbl_Descuento
            // 
            lbl_Descuento.AutoSize = true;
            lbl_Descuento.Location = new System.Drawing.Point(729, 369);
            lbl_Descuento.Name = "lbl_Descuento";
            lbl_Descuento.Size = new System.Drawing.Size(59, 13);
            lbl_Descuento.TabIndex = 19;
            lbl_Descuento.Text = "Descuento";
            // 
            // lbl_IVA
            // 
            lbl_IVA.AutoSize = true;
            lbl_IVA.Location = new System.Drawing.Point(729, 395);
            lbl_IVA.Name = "lbl_IVA";
            lbl_IVA.Size = new System.Drawing.Size(24, 13);
            lbl_IVA.TabIndex = 20;
            lbl_IVA.Text = "IVA";
            // 
            // lbl_Total
            // 
            lbl_Total.AutoSize = true;
            lbl_Total.Location = new System.Drawing.Point(729, 423);
            lbl_Total.Name = "lbl_Total";
            lbl_Total.Size = new System.Drawing.Size(31, 13);
            lbl_Total.TabIndex = 21;
            lbl_Total.Text = "Total";
            // 
            // txt_Total
            // 
            txt_Total.Enabled = false;
            txt_Total.Location = new System.Drawing.Point(790, 416);
            txt_Total.Name = "txt_Total";
            txt_Total.Size = new System.Drawing.Size(100, 20);
            txt_Total.TabIndex = 22;
            // 
            // txt_Efectivo
            // 
            txt_Efectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txt_Efectivo.ForeColor = System.Drawing.Color.Red;
            txt_Efectivo.Location = new System.Drawing.Point(790, 512);
            txt_Efectivo.Name = "txt_Efectivo";
            txt_Efectivo.Size = new System.Drawing.Size(100, 22);
            txt_Efectivo.TabIndex = 24;
            // 
            // lbl_Efectivo
            // 
            lbl_Efectivo.AutoSize = true;
            lbl_Efectivo.Location = new System.Drawing.Point(729, 519);
            lbl_Efectivo.Name = "lbl_Efectivo";
            lbl_Efectivo.Size = new System.Drawing.Size(46, 13);
            lbl_Efectivo.TabIndex = 23;
            lbl_Efectivo.Text = "Efectivo";
            // 
            // txt_Cambio
            // 
            txt_Cambio.Enabled = false;
            txt_Cambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txt_Cambio.ForeColor = System.Drawing.Color.Red;
            txt_Cambio.Location = new System.Drawing.Point(790, 538);
            txt_Cambio.Name = "txt_Cambio";
            txt_Cambio.Size = new System.Drawing.Size(100, 22);
            txt_Cambio.TabIndex = 26;
            // 
            // lbl_Cambio
            // 
            lbl_Cambio.AutoSize = true;
            lbl_Cambio.Location = new System.Drawing.Point(729, 545);
            lbl_Cambio.Name = "lbl_Cambio";
            lbl_Cambio.Size = new System.Drawing.Size(42, 13);
            lbl_Cambio.TabIndex = 25;
            lbl_Cambio.Text = "Cambio";
            // 
            // groupBox_Productos
            // 
            groupBox_Productos.Controls.Add(dataGridView_Productos);
            groupBox_Productos.Location = new System.Drawing.Point(572, 41);
            groupBox_Productos.Name = "groupBox_Productos";
            groupBox_Productos.Size = new System.Drawing.Size(435, 261);
            groupBox_Productos.TabIndex = 27;
            groupBox_Productos.TabStop = false;
            groupBox_Productos.Text = "Productos";
            // 
            // bttn_Agregar
            // 
            bttn_Agregar.BackgroundImage = global::Shajobe.Properties.Resources.Agregar;
            bttn_Agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            bttn_Agregar.Location = new System.Drawing.Point(506, 170);
            bttn_Agregar.Name = "bttn_Agregar";
            bttn_Agregar.Size = new System.Drawing.Size(60, 60);
            bttn_Agregar.TabIndex = 28;
            bttn_Agregar.UseVisualStyleBackColor = true;
            bttn_Agregar.Click += new System.EventHandler(bttn_Agregar_Click);
            // 
            // bttn_Quitar
            // 
            bttn_Quitar.BackgroundImage = global::Shajobe.Properties.Resources.Quitar;
            bttn_Quitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            bttn_Quitar.Location = new System.Drawing.Point(506, 239);
            bttn_Quitar.Name = "bttn_Quitar";
            bttn_Quitar.Size = new System.Drawing.Size(60, 60);
            bttn_Quitar.TabIndex = 29;
            bttn_Quitar.UseVisualStyleBackColor = true;
            bttn_Quitar.Click += new System.EventHandler(bttn_Quitar_Click);
            // 
            // btn_Pagar
            // 
            btn_Pagar.Location = new System.Drawing.Point(889, 585);
            btn_Pagar.Name = "btn_Pagar";
            btn_Pagar.Size = new System.Drawing.Size(75, 23);
            btn_Pagar.TabIndex = 30;
            btn_Pagar.Text = "Pagar";
            btn_Pagar.UseVisualStyleBackColor = true;
            btn_Pagar.Click += new System.EventHandler(btn_Pagar_Click);
            // 
            // pic_Venta
            // 
            pic_Venta.BackgroundImage = global::Shajobe.Properties.Resources.Venta;
            pic_Venta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pic_Venta.Location = new System.Drawing.Point(337, 66);
            pic_Venta.Name = "pic_Venta";
            pic_Venta.Size = new System.Drawing.Size(100, 100);
            pic_Venta.TabIndex = 31;
            pic_Venta.TabStop = false;
            // 
            // groupBox_Informacion
            // 
            groupBox_Informacion.Controls.Add(lbl_Cliente);
            groupBox_Informacion.Controls.Add(lbl_TipoPago);
            groupBox_Informacion.Controls.Add(lbl_Adquisicion);
            groupBox_Informacion.Controls.Add(lbl_Fecha);
            groupBox_Informacion.Controls.Add(comboBox_Cliente);
            groupBox_Informacion.Controls.Add(comboBoxTipoPago);
            groupBox_Informacion.Controls.Add(comboBoxAdquisicion);
            groupBox_Informacion.Controls.Add(dateTimeVenta);
            groupBox_Informacion.Location = new System.Drawing.Point(24, 60);
            groupBox_Informacion.Name = "groupBox_Informacion";
            groupBox_Informacion.Size = new System.Drawing.Size(307, 199);
            groupBox_Informacion.TabIndex = 32;
            groupBox_Informacion.TabStop = false;
            groupBox_Informacion.Text = "Información";
            // 
            // lbl_Cliente
            // 
            lbl_Cliente.AutoSize = true;
            lbl_Cliente.Location = new System.Drawing.Point(16, 37);
            lbl_Cliente.Name = "lbl_Cliente";
            lbl_Cliente.Size = new System.Drawing.Size(39, 13);
            lbl_Cliente.TabIndex = 36;
            lbl_Cliente.Text = "Cliente";
            // 
            // lbl_TipoPago
            // 
            lbl_TipoPago.AutoSize = true;
            lbl_TipoPago.Location = new System.Drawing.Point(16, 64);
            lbl_TipoPago.Name = "lbl_TipoPago";
            lbl_TipoPago.Size = new System.Drawing.Size(78, 13);
            lbl_TipoPago.TabIndex = 33;
            lbl_TipoPago.Text = "Forma de pago";
            // 
            // lbl_Adquisicion
            // 
            lbl_Adquisicion.AutoSize = true;
            lbl_Adquisicion.Location = new System.Drawing.Point(16, 91);
            lbl_Adquisicion.Name = "lbl_Adquisicion";
            lbl_Adquisicion.Size = new System.Drawing.Size(81, 13);
            lbl_Adquisicion.TabIndex = 34;
            lbl_Adquisicion.Text = "Forma de venta";
            // 
            // lbl_Fecha
            // 
            lbl_Fecha.AutoSize = true;
            lbl_Fecha.Location = new System.Drawing.Point(16, 117);
            lbl_Fecha.Name = "lbl_Fecha";
            lbl_Fecha.Size = new System.Drawing.Size(37, 13);
            lbl_Fecha.TabIndex = 35;
            lbl_Fecha.Text = "Fecha";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
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
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(228)))), ((int)(((byte)(196)))));
            ClientSize = new System.Drawing.Size(1019, 668);
            Controls.Add(groupBox_Informacion);
            Controls.Add(pic_Venta);
            Controls.Add(btn_Pagar);
            Controls.Add(bttn_Quitar);
            Controls.Add(bttn_Agregar);
            Controls.Add(groupBox_Productos);
            Controls.Add(txt_Cambio);
            Controls.Add(lbl_Cambio);
            Controls.Add(txt_Efectivo);
            Controls.Add(lbl_Efectivo);
            Controls.Add(txt_Total);
            Controls.Add(lbl_Total);
            Controls.Add(lbl_IVA);
            Controls.Add(lbl_Descuento);
            Controls.Add(lbl_SubTotal);
            Controls.Add(txt_IVA);
            Controls.Add(txt_Descuento);
            Controls.Add(txt_SubTotal);
            Controls.Add(lbl_Cantidad);
            Controls.Add(dataGridView_Carrito);
            Controls.Add(txt_Cantidad);
            Controls.Add(menuStrip1);
            Icon = global::Shajobe.Properties.Resources.Venta_ICO;
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(1025, 692);
            MinimumSize = new System.Drawing.Size(1025, 692);
            Name = "Venta";
            Text = "Venta";
            Load += new System.EventHandler(Venta_Load);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(dataGridView_Productos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dataGridView_Carrito)).EndInit();
            groupBox_Productos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(pic_Venta)).EndInit();
            groupBox_Informacion.ResumeLayout(false);
            groupBox_Informacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(errorProvider1)).EndInit();
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
        private int Idp = 0, Tp = 0, Existencia;//LO USO PARA OBTENER EL ID COMO RESULTADO DE LA BUSQUEDA
        private decimal Subtotal = 0, Total = 0;
        //-------------------------------------------------------------
        //----------------Limpia y restablece controles----------------
        //-------------------------------------------------------------
        #region Limpiar
        private void Limpiar()
        {
            //Limpiando controles
            txt_Cantidad.Clear();
            dataGridView_Carrito.Rows.Clear();
            txt_Cambio.Clear();
            txt_Efectivo.Clear();
            txt_SubTotal.Clear();
            txt_Total.Clear();
            Tp = 0;
            Existencia = 0;
            Subtotal = 0;
            Total = 0;
            //Llenando controles y seleccionando opciones
            Llenando_ListaClientes();
            comboBox_Cliente.ResetText();
            Llenando_DataGridViewProductos();
            comboBoxTipoPago.SelectedIndex = 0;
            comboBoxAdquisicion.SelectedIndex = 0;
            //Agregando datos por defecto
            txt_IVA.Text = "0.00";
            txt_Descuento.Text = "0.00";
        }
        #endregion
        //-------------------------------------------------------------
        //----------------CONFIGURACION DE CONTROLES-------------------
        //-------------------------------------------------------------
        #region Configuracion_Controles
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void bttn_Agregar_Click(object sender, EventArgs e)
        {
            if (dataGridView_Productos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un producto para agregar al carrito", "Error de selección", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                if (txt_Cantidad.Text.Trim() == "")
                {
                    MessageBox.Show("Introduzca la cantidad de producto que va a comprar para agregar al carrito", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    errorProvider1.SetError(txt_Cantidad, "Introduce la cantidad solicitada");
                }
                else
                {
                    #region Obteniendo_Existencia
                    int SProducto = Convert.ToInt32(dataGridView_Productos.CurrentRow.Cells["Id_ProductoTerminadoP"].Value);
                    //Opteniendo Informacion de productos disponibles
                    OleDbConnection con = new OleDbConnection();
                    OleDbCommand coman = new OleDbCommand();
                    OleDbDataReader dr;
                    con.ConnectionString = ObtenerString();
                    coman.Connection = con;
                    coman.CommandText = "Select SUM(Existencia)AS Existencia from Tb_AlmacenProducto where Activo= 'S' and Id_ProductoTerminado='" + SProducto + "'";
                    coman.CommandType = CommandType.Text;
                    con.Open();
                    dr = coman.ExecuteReader();
                    while (dr.Read())
                    {
                        //Declarando Variables y obteniendo los valores correspondiente
                        Existencia = dr.GetInt32(dr.GetOrdinal("Existencia"));
                    }
                    con.Close();
                    #endregion
                    #region Agregar_Carrito
                    if (Convert.ToInt32(txt_Cantidad.Text) < Existencia)
                    {
                        int Lista = dataGridView_Carrito.Rows.Add();
                        dataGridView_Carrito.Rows[Lista].Cells["Id_ProductoTerminado"].Value = Convert.ToInt32(dataGridView_Productos.CurrentRow.Cells["Id_ProductoTerminadoP"].Value);
                        dataGridView_Carrito.Rows[Lista].Cells["Nombre"].Value = Convert.ToString(dataGridView_Productos.CurrentRow.Cells["NombreP"].Value);
                        dataGridView_Carrito.Rows[Lista].Cells["Lote"].Value = Convert.ToString(dataGridView_Productos.CurrentRow.Cells["LoteP"].Value);
                        dataGridView_Carrito.Rows[Lista].Cells["Descripcion"].Value = Convert.ToString(dataGridView_Productos.CurrentRow.Cells["DescripcionP"].Value);
                        dataGridView_Carrito.Rows[Lista].Cells["Precio"].Value = Convert.ToDecimal(dataGridView_Productos.CurrentRow.Cells["Precio_VentaP"].Value);
                        dataGridView_Carrito.Rows[Lista].Cells["Cantidad"].Value = Convert.ToInt32(txt_Cantidad.Text);
                        //Metodo para sumar el subtotal
                        Suma_Subtotal(Convert.ToInt32(txt_Cantidad.Text), Convert.ToDecimal(dataGridView_Productos.CurrentRow.Cells["Precio_VentaP"].Value));
                    }
                    else
                    {
                        MessageBox.Show("No se cuenta con la cantidad solicitada", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    #endregion
                    txt_Cantidad.Clear();
                }
            }
        }
        private void bttn_Quitar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseas realmente quitar este producto del carrito", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                Resta_Subtotal(Convert.ToInt32(dataGridView_Carrito.CurrentRow.Cells["Cantidad"].Value), Convert.ToDecimal(dataGridView_Carrito.CurrentRow.Cells["Precio"].Value));
                dataGridView_Carrito.Rows.RemoveAt(dataGridView_Carrito.CurrentRow.Index);
            }
        }
        #endregion
        private void Venta_Load(object sender, EventArgs e)
        {
            Diseño_Forma();
            #region Llenando_Datos
            Llenando_ListaClientes();
            Llenando_TipoPagos();
            Llenando_Adquisicion();
            Usuario();
            Llenando_DataGridViewProductos();
            #endregion

            //Seleccionando por defecto
            comboBoxTipoPago.SelectedIndex = 0;
            comboBoxAdquisicion.SelectedIndex = 0;
            //Llenando lista de productos

            //Agregando datos por defecto
            txt_IVA.Text = "0.00";
            txt_Descuento.Text = "0.00";
            //Usuario registrado

        }
        //Llenando comboBox de Clientes
        #region LlenandoComboBox
        private void Llenando_ListaClientes()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand coman = new OleDbCommand();
            OleDbDataReader dr;
            con.ConnectionString = ObtenerString();
            coman.Connection = con;
            coman.CommandText = "Select Nombre, Apellido_P from Tb_Cliente where Activo= 'S'";
            coman.CommandType = CommandType.Text;
            con.Open();
            comboBox_Cliente.Items.Clear();
            dr = coman.ExecuteReader();
            while (dr.Read())
            {
                //Declarando Variables y obteniendo los valores correspondiente
                string Nombre = dr.GetString(dr.GetOrdinal("Nombre"));
                string Apellido_P = dr.GetString(dr.GetOrdinal("Apellido_P"));
                comboBox_Cliente.Items.Add(Nombre + " " + Apellido_P);
            }
            con.Close();
        }
        //Llenando comboBox de Tipos de pago
        private void Llenando_TipoPagos()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand coman = new OleDbCommand();
            OleDbDataReader dr;
            con.ConnectionString = ObtenerString();
            coman.Connection = con;
            coman.CommandText = "Select Nombre from Tb_TipoPago where Activo= 'S'";
            coman.CommandType = CommandType.Text;
            con.Open();
            comboBoxTipoPago.Items.Clear();
            dr = coman.ExecuteReader();
            while (dr.Read())
            {
                //Declarando Variables y obteniendo los valores correspondiente
                string Nombre = dr.GetString(dr.GetOrdinal("Nombre"));
                comboBoxTipoPago.Items.Add(Nombre);
            }
            con.Close();
        }
        //Llenando comboBox de Adquisicion
        private void Llenando_Adquisicion()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand coman = new OleDbCommand();
            OleDbDataReader dr;
            con.ConnectionString = ObtenerString();
            coman.Connection = con;
            coman.CommandText = "Select Nombre from Tb_Adquisicion where Activo= 'S'";
            coman.CommandType = CommandType.Text;
            con.Open();
            comboBoxAdquisicion.Items.Clear();
            dr = coman.ExecuteReader();
            while (dr.Read())
            {
                //Declarando Variables y obteniendo los valores correspondiente
                string Nombre = dr.GetString(dr.GetOrdinal("Nombre"));
                comboBoxAdquisicion.Items.Add(Nombre);
            }
            con.Close();
        }
        #endregion
        #region Lista_Productos
        private void Llenando_DataGridViewProductos()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand coman = new OleDbCommand();
            OleDbDataReader dr;
            con.ConnectionString = ObtenerString();
            coman.Connection = con;
            coman.CommandText = "SELECT Tb_ProductoTerminado.Nombre, Tb_ProductoTerminado.Descripcion, Tb_ProductoTerminado.Cantidad, Tb_AlmacenProducto.Lote, Tb_AlmacenProducto.Precio_Venta, Tb_AlmacenProducto.Descuento, Tb_AlmacenProducto.Id_ProductoTerminado FROM Tb_ProductoTerminado INNER JOIN Tb_AlmacenProducto ON Tb_ProductoTerminado.Id_ProductoTerminado = Tb_AlmacenProducto.Id_ProductoTerminado where Tb_AlmacenProducto.Activo='S'";
            coman.CommandType = CommandType.Text;
            con.Open();
            dataGridView_Productos.Rows.Clear();
            dr = coman.ExecuteReader();
            while (dr.Read())
            {
                //Creando y obteniendo el indice para un nuevo renglon
                int Indice = dataGridView_Productos.Rows.Add();
                dataGridView_Productos.Rows[Indice].Cells["Id_ProductoTerminadoP"].Value = dr.GetInt32(dr.GetOrdinal("Id_ProductoTerminado"));
                dataGridView_Productos.Rows[Indice].Cells["NombreP"].Value = dr.GetString(dr.GetOrdinal("Nombre"));
                dataGridView_Productos.Rows[Indice].Cells["DescripcionP"].Value = dr.GetString(dr.GetOrdinal("Descripcion"));
                dataGridView_Productos.Rows[Indice].Cells["Precio_VentaP"].Value = dr.GetDecimal(dr.GetOrdinal("Precio_Venta"));
                dataGridView_Productos.Rows[Indice].Cells["DescuentoP"].Value = dr.GetDecimal(dr.GetOrdinal("Descuento"));
                dataGridView_Productos.Rows[Indice].Cells["CantidadP"].Value = dr.GetDecimal(dr.GetOrdinal("Cantidad"));
            }
            con.Close();
        }
        #endregion
        #region Usuario_Cajero
        private void Usuario()
        {

            OleDbConnection con = new OleDbConnection();
            OleDbCommand coman = new OleDbCommand();
            OleDbDataReader dr;
            con.ConnectionString = ObtenerString();
            coman.Connection = con;
            coman.CommandText = "SELECT Id_Usuario FROM Tb_Usuarios_Login where Id_Login=(select MAX(Id_Login) from Tb_Usuarios_Login where Estado='A')";
            coman.CommandType = CommandType.Text;
            con.Open();
            dataGridView_Productos.Rows.Clear();
            dr = coman.ExecuteReader();
            while (dr.Read())
            {
                //Me traego el id del usuario que se logeo
                Idp = dr.GetInt32(dr.GetOrdinal("Id_Usuario"));
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
        //-------------------------------------------------------------
        //-------------------Validacion de campos----------------------
        //-------------------------------------------------------------
        #region Validación_Escritura
        private void txt_Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            //---------Apartado de numeros-------------Apartado de teclas especiales Retroceso y suprimir------------------------Uso del punto
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar < 7 || e.KeyChar > 9) && (e.KeyChar < 126 || e.KeyChar > 128) && (e.KeyChar < 45 || e.KeyChar > 47))
            {
                MessageBox.Show("Solo se aceptan numeros", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                e.Handled = true;
            }
        }
        private void txt_IVA_KeyPress(object sender, KeyPressEventArgs e)
        {
            //---------Apartado de numeros-------------Apartado de teclas especiales Retroceso y suprimir------------------------Uso del punto
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar < 7 || e.KeyChar > 9) && (e.KeyChar < 126 || e.KeyChar > 128) && (e.KeyChar < 45 || e.KeyChar > 47))
            {
                MessageBox.Show("Solo se aceptan numeros", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                e.Handled = true;
            }
        }
        private void txt_Descuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            //---------Apartado de numeros-------------Apartado de teclas especiales Retroceso y suprimir------------------------Uso del punto
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar < 7 || e.KeyChar > 9) && (e.KeyChar < 126 || e.KeyChar > 128) && (e.KeyChar < 45 || e.KeyChar > 47))
            {
                MessageBox.Show("Solo se aceptan numeros", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                e.Handled = true;
            }
        }
        #endregion
        #region Calculo_Subtotal,Total
        private void Suma_Subtotal(int c, decimal p)
        {
            //Calculando el subtotal
            Subtotal = Subtotal + (c * p);
            txt_SubTotal.Text = Convert.ToString(Subtotal);
            //Calculando el numero de articulos
            Tp = Tp + c;
        }
        private void Resta_Subtotal(int c, decimal p)
        {
            //Calculando el subtotal
            Subtotal = Subtotal - (c * p);
            txt_SubTotal.Text = Convert.ToString(Subtotal);
            //Calculando el numero de articulos
            Tp = Tp - c;
        }
        private void Calcular_Total()
        {
            //Calculando el total
            if (txt_IVA.Text == "0.00" && txt_Descuento.Text == "0.00")
            {
                txt_Total.Text = Convert.ToString(Subtotal);
            }
            else
            {
                decimal d = Convert.ToDecimal(txt_Descuento.Text);
                decimal ATotal = d * Subtotal;
                decimal i = Convert.ToDecimal(txt_IVA.Text);
                decimal AIVA = i * Subtotal;
                Total = Subtotal - ATotal + AIVA;
                txt_Total.Text = Convert.ToString(Math.Round(Total, 2));
            }
        }
        #endregion
        private void btn_Pagar_Click(object sender, EventArgs e)
        {
            //Obtengo que ficha o que control esta activa para poder limpiar dicho control
            OleDbConnection conexion = null;
            OleDbTransaction transaccion = null;
            if (comboBoxTipoPago.SelectedIndex == 0)
            {
                #region Venta_CONTADO
                if (txt_Efectivo.Text.Trim() == "" && comboBox_Cliente.SelectedIndex == -1)
                {
                    MessageBox.Show("Verifique que haya seleccionado al cliente y haya introducido el efectivo", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    errorProvider1.SetError(txt_Efectivo, "Introduce el efectivo");
                }
                else
                {

                    try
                    {
                        conexion = new OleDbConnection(ObtenerString());
                        conexion.Open();
                        transaccion = conexion.BeginTransaction(System.Data.IsolationLevel.Serializable);
                        OleDbCommand comando = new OleDbCommand("SP_Venta", conexion, transaccion);
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.Clear();
                        int cli = comboBox_Cliente.SelectedIndex;
                        int pago = comboBoxTipoPago.SelectedIndex;
                        int adq = comboBoxAdquisicion.SelectedIndex;
                        cli++;
                        pago++;
                        adq++;
                        comando.Parameters.AddWithValue("@Id_Cliente ", cli);
                        comando.Parameters.AddWithValue("@Id_TipoPago ", pago);
                        comando.Parameters.AddWithValue("@Id_Adquisicion", adq);
                        comando.Parameters.AddWithValue("@Id_Usuario", Idp);
                        comando.Parameters.AddWithValue("@Total_Producto", Tp);
                        comando.Parameters.AddWithValue("@Subtotal", Convert.ToDecimal(txt_SubTotal.Text));
                        comando.Parameters.AddWithValue("@IVA", Convert.ToDecimal(txt_IVA.Text));
                        comando.Parameters.AddWithValue("@Total", Convert.ToDecimal(txt_Total.Text));
                        comando.Parameters.AddWithValue("@Fecha", dateTimeVenta.Value);
                        comando.ExecuteNonQuery();
                        transaccion.Commit();
                        conexion.Close();
                        MessageBox.Show("Datos guardados con éxito", "Solicitud procesada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ha ocurrido un error inesperado", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                #endregion
            }
            else if (comboBoxTipoPago.SelectedIndex == 1)
            {
                #region Venta_CREDITO
                if (comboBox_Cliente.SelectedIndex == -1)
                {
                    MessageBox.Show("Verifique que haya seleccionado al cliente", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    errorProvider1.SetError(comboBox_Cliente, "Introduce el efectivo");
                }
                else
                {
                    try
                    {
                        conexion = new OleDbConnection(ObtenerString());
                        conexion.Open();
                        transaccion = conexion.BeginTransaction(System.Data.IsolationLevel.Serializable);
                        OleDbCommand comando = new OleDbCommand("SP_Pedido", conexion, transaccion);
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.Clear();
                        int cli = comboBox_Cliente.SelectedIndex;
                        int pago = comboBoxTipoPago.SelectedIndex;
                        int adq = comboBoxAdquisicion.SelectedIndex;
                        cli++;
                        pago++;
                        adq++;
                        comando.Parameters.AddWithValue("@Id_Cliente ", cli);
                        comando.Parameters.AddWithValue("@Id_TipoPago ", pago);
                        comando.Parameters.AddWithValue("@Id_Adquisicion", adq);
                        comando.Parameters.AddWithValue("@Id_Usuario", Idp);
                        comando.Parameters.AddWithValue("@Total_Producto", Tp);
                        comando.Parameters.AddWithValue("@Subtotal", Convert.ToDecimal(txt_SubTotal.Text));
                        comando.Parameters.AddWithValue("@IVA", Convert.ToDecimal(txt_IVA.Text));
                        comando.Parameters.AddWithValue("@Total", Convert.ToDecimal(txt_Total.Text));
                        comando.Parameters.AddWithValue("@Fecha", dateTimeVenta.Value);
                        comando.ExecuteNonQuery();
                        transaccion.Commit();
                        conexion.Close();
                        MessageBox.Show("Datos guardados con éxito", "Solicitud procesada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ha ocurrido un error inesperado", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                #endregion
            }
        }
        private void txt_SubTotal_TextChanged(object sender, EventArgs e)
        {
            Calcular_Total();
        }
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
