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

namespace Shajobe
{
    public partial class Menu_Principal : Form
    {
        public Menu_Principal()
        {
            InitializeComponent();
        }

        #region Diseño de la forma
        #region Creando controles
        private System.Windows.Forms.Label lbl_Proveedoresporpagar;
        private System.Windows.Forms.Label lbl_Clientesporpagar;
        private System.Windows.Forms.PictureBox picCliente;
        private System.Windows.Forms.DataGridView dataGridViewClientes;
        private System.Windows.Forms.DataGridView dataGridViewProveedores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_PedidosPendientes;
        private System.Windows.Forms.PictureBox pic_Proveedor;
        private System.Windows.Forms.PictureBox pic_Recordatorio;
        private System.Windows.Forms.PictureBox pic_Pendiente;
        private System.Windows.Forms.DataGridView dataPendiente;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem catalogosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materiaPrimaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materiaPrimaSinRebabaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosTerminadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosIndirectosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosElaboradosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem almacenToolStripMenuItem;
        private System.Windows.Forms.PictureBox pic_Logo;
        private System.Windows.Forms.ToolStripMenuItem inventariosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem elaborarProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem financieroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ventaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuentasDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingredientesEmpaquesToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridProductosTerminados;
        private System.Windows.Forms.DataGridView dataGridProductosElaborados;
        private System.Windows.Forms.DataGridView dataSinRebaba;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_AlertaMateriaPrimaP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_MateriaPrimaP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MateriaPrimaP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Almacens;
        private System.Windows.Forms.DataGridViewTextBoxColumn Existencias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fechas;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Activos;
        private System.Windows.Forms.DataGridView dataConrebaba;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_AlertaMateriaPrima;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Almacenc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_MateriaPrima;
        private System.Windows.Forms.DataGridViewTextBoxColumn MateriaPrima;
        private System.Windows.Forms.DataGridViewTextBoxColumn Existenciac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fechac;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Activoc;
        private System.Windows.Forms.DataGridView dataIndirecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_AlertaIndirecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_ProductoIndirecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductoIndirecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Almacen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Existencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Activo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombrec;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido_Pc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dias_Creditoc;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Activocl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido_P;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dias_Credito;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Activop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_AlertaProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_ProductoTerminado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Almacent;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductoTerminado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Existenciat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fechat;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Activot;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_AlertaProductoElaborado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_ProductoElaborado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Almacene;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductoElaborado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Existenciae;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fechae;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Activoe;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem abonoToolStripMenuItem;
        #endregion
        private void Diseño_Forma()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Principal));
            lbl_Proveedoresporpagar = new System.Windows.Forms.Label();
            lbl_Clientesporpagar = new System.Windows.Forms.Label();
            picCliente = new System.Windows.Forms.PictureBox();
            dataGridViewClientes = new System.Windows.Forms.DataGridView();
            Id_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Nombrec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Apellido_Pc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Saldoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Dias_Creditoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Activocl = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            dataGridViewProveedores = new System.Windows.Forms.DataGridView();
            Id_Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Apellido_P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Dias_Credito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Activop = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            label2 = new System.Windows.Forms.Label();
            lbl_PedidosPendientes = new System.Windows.Forms.Label();
            pic_Proveedor = new System.Windows.Forms.PictureBox();
            pic_Recordatorio = new System.Windows.Forms.PictureBox();
            pic_Pendiente = new System.Windows.Forms.PictureBox();
            dataPendiente = new System.Windows.Forms.DataGridView();
            menu = new System.Windows.Forms.MenuStrip();
            catalogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            materiaPrimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            materiaPrimaSinRebabaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            productosTerminadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            productosIndirectosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            productosElaboradosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            inventariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            almacenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            inventariosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            elaborarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ingredientesEmpaquesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            financieroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            cajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            ventaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            abonoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            cuentasDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            pic_Logo = new System.Windows.Forms.PictureBox();
            panel3 = new System.Windows.Forms.Panel();
            dataGridProductosTerminados = new System.Windows.Forms.DataGridView();
            Id_AlertaProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Id_ProductoTerminado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Id_Almacent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ProductoTerminado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Existenciat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Fechat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Activot = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            dataGridProductosElaborados = new System.Windows.Forms.DataGridView();
            Id_AlertaProductoElaborado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Id_ProductoElaborado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Id_Almacene = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ProductoElaborado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Existenciae = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Fechae = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Activoe = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            dataSinRebaba = new System.Windows.Forms.DataGridView();
            Id_AlertaMateriaPrimaP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Id_MateriaPrimaP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            MateriaPrimaP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Id_Almacens = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Existencias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Fechas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Activos = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            dataConrebaba = new System.Windows.Forms.DataGridView();
            Id_AlertaMateriaPrima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Id_Almacenc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Id_MateriaPrima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            MateriaPrima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Existenciac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Fechac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Activoc = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            dataIndirecto = new System.Windows.Forms.DataGridView();
            Id_AlertaIndirecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Id_ProductoIndirecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ProductoIndirecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Id_Almacen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Existencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Activo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(picCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dataGridViewClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dataGridViewProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pic_Proveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pic_Recordatorio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pic_Pendiente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dataPendiente)).BeginInit();
            menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(pic_Logo)).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(dataGridProductosTerminados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dataGridProductosElaborados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dataSinRebaba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dataConrebaba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dataIndirecto)).BeginInit();
            SuspendLayout();
            // 
            // lbl_Proveedoresporpagar
            // 
            lbl_Proveedoresporpagar.AutoSize = true;
            lbl_Proveedoresporpagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_Proveedoresporpagar.Location = new System.Drawing.Point(887, 94);
            lbl_Proveedoresporpagar.Name = "lbl_Proveedoresporpagar";
            lbl_Proveedoresporpagar.Size = new System.Drawing.Size(170, 20);
            lbl_Proveedoresporpagar.TabIndex = 29;
            lbl_Proveedoresporpagar.Text = "Proveedores por pagar";
            // 
            // lbl_Clientesporpagar
            // 
            lbl_Clientesporpagar.AutoSize = true;
            lbl_Clientesporpagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_Clientesporpagar.Location = new System.Drawing.Point(887, 457);
            lbl_Clientesporpagar.Name = "lbl_Clientesporpagar";
            lbl_Clientesporpagar.Size = new System.Drawing.Size(138, 20);
            lbl_Clientesporpagar.TabIndex = 28;
            lbl_Clientesporpagar.Text = "Clientes por pagar";
            // 
            // picCliente
            // 
            picCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picCliente.BackgroundImage")));
            picCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            picCliente.Location = new System.Drawing.Point(781, 423);
            picCliente.Name = "picCliente";
            picCliente.Size = new System.Drawing.Size(100, 84);
            picCliente.TabIndex = 27;
            picCliente.TabStop = false;
            // 
            // dataGridViewClientes
            // 
            dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            Id_Cliente,
            Nombrec,
            Apellido_Pc,
            Saldoc,
            Dias_Creditoc,
            Activocl});
            dataGridViewClientes.Location = new System.Drawing.Point(781, 514);
            dataGridViewClientes.Name = "dataGridViewClientes";
            dataGridViewClientes.Size = new System.Drawing.Size(379, 223);
            dataGridViewClientes.TabIndex = 26;
            // 
            // Id_Cliente
            // 
            Id_Cliente.HeaderText = "Id_Cliente";
            Id_Cliente.Name = "Id_Cliente";
            Id_Cliente.Visible = false;
            // 
            // Nombrec
            // 
            Nombrec.HeaderText = "Nombre";
            Nombrec.Name = "Nombrec";
            // 
            // Apellido_Pc
            // 
            Apellido_Pc.HeaderText = "Apellido Paterno";
            Apellido_Pc.Name = "Apellido_Pc";
            // 
            // Saldoc
            // 
            Saldoc.HeaderText = "Saldo";
            Saldoc.Name = "Saldoc";
            // 
            // Dias_Creditoc
            // 
            Dias_Creditoc.HeaderText = "Dias_Credito";
            Dias_Creditoc.Name = "Dias_Creditoc";
            // 
            // Activocl
            // 
            Activocl.HeaderText = "Activo";
            Activocl.Name = "Activocl";
            // 
            // dataGridViewProveedores
            // 
            dataGridViewProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            Id_Proveedor,
            Nombre,
            Apellido_P,
            Saldo,
            Dias_Credito,
            Activop});
            dataGridViewProveedores.Location = new System.Drawing.Point(781, 171);
            dataGridViewProveedores.Name = "dataGridViewProveedores";
            dataGridViewProveedores.Size = new System.Drawing.Size(379, 223);
            dataGridViewProveedores.TabIndex = 25;
            // 
            // Id_Proveedor
            // 
            Id_Proveedor.HeaderText = "Id_Proveedor";
            Id_Proveedor.Name = "Id_Proveedor";
            Id_Proveedor.Visible = false;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Apellido_P
            // 
            Apellido_P.HeaderText = "Apellido_P";
            Apellido_P.Name = "Apellido_P";
            // 
            // Saldo
            // 
            Saldo.HeaderText = "Saldo";
            Saldo.Name = "Saldo";
            // 
            // Dias_Credito
            // 
            Dias_Credito.HeaderText = "Dias credito";
            Dias_Credito.Name = "Dias_Credito";
            // 
            // Activop
            // 
            Activop.HeaderText = "Activo";
            Activop.Name = "Activop";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(402, 94);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(216, 20);
            label2.TabIndex = 24;
            label2.Text = "Cosas por comprar y elaborar";
            // 
            // lbl_PedidosPendientes
            // 
            lbl_PedidosPendientes.AutoSize = true;
            lbl_PedidosPendientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_PedidosPendientes.Location = new System.Drawing.Point(108, 94);
            lbl_PedidosPendientes.Name = "lbl_PedidosPendientes";
            lbl_PedidosPendientes.Size = new System.Drawing.Size(149, 20);
            lbl_PedidosPendientes.TabIndex = 23;
            lbl_PedidosPendientes.Text = "Pedidos pendientes";
            // 
            // pic_Proveedor
            // 
            pic_Proveedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_Proveedor.BackgroundImage")));
            pic_Proveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pic_Proveedor.Location = new System.Drawing.Point(781, 64);
            pic_Proveedor.Name = "pic_Proveedor";
            pic_Proveedor.Size = new System.Drawing.Size(100, 84);
            pic_Proveedor.TabIndex = 22;
            pic_Proveedor.TabStop = false;
            // 
            // pic_Recordatorio
            // 
            pic_Recordatorio.BackgroundImage = global::Shajobe.Properties.Resources.Cosas_Comprar;
            pic_Recordatorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pic_Recordatorio.Location = new System.Drawing.Point(321, 64);
            pic_Recordatorio.Name = "pic_Recordatorio";
            pic_Recordatorio.Size = new System.Drawing.Size(75, 75);
            pic_Recordatorio.TabIndex = 21;
            pic_Recordatorio.TabStop = false;
            // 
            // pic_Pendiente
            // 
            pic_Pendiente.BackgroundImage = global::Shajobe.Properties.Resources.Pendientes;
            pic_Pendiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pic_Pendiente.Location = new System.Drawing.Point(17, 60);
            pic_Pendiente.Name = "pic_Pendiente";
            pic_Pendiente.Size = new System.Drawing.Size(85, 79);
            pic_Pendiente.TabIndex = 20;
            pic_Pendiente.TabStop = false;
            // 
            // dataPendiente
            // 
            dataPendiente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataPendiente.Location = new System.Drawing.Point(17, 145);
            dataPendiente.Name = "dataPendiente";
            dataPendiente.Size = new System.Drawing.Size(284, 592);
            dataPendiente.TabIndex = 18;
            // 
            // menu
            // 
            menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(186)))), ((int)(((byte)(82)))));
            menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            catalogosToolStripMenuItem,
            inventariosToolStripMenuItem,
            elaborarProductosToolStripMenuItem,
            financieroToolStripMenuItem,
            reportesToolStripMenuItem,
            configuraciónToolStripMenuItem});
            menu.Location = new System.Drawing.Point(0, 0);
            menu.Name = "menu";
            menu.Size = new System.Drawing.Size(1177, 24);
            menu.TabIndex = 32;
            menu.Text = "menuStrip1";
            // 
            // catalogosToolStripMenuItem
            // 
            catalogosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            clientesToolStripMenuItem,
            proveedoresToolStripMenuItem,
            materiaPrimaToolStripMenuItem,
            materiaPrimaSinRebabaToolStripMenuItem,
            productosTerminadosToolStripMenuItem,
            productosIndirectosToolStripMenuItem,
            productosElaboradosToolStripMenuItem});
            catalogosToolStripMenuItem.Name = "catalogosToolStripMenuItem";
            catalogosToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            catalogosToolStripMenuItem.Text = "Catalogos";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Image = global::Shajobe.Properties.Resources.Clientes;
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            clientesToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            clientesToolStripMenuItem.Text = "&Clientes";
            clientesToolStripMenuItem.Click += new System.EventHandler(clientesToolStripMenuItem_Click_1);
            // 
            // proveedoresToolStripMenuItem
            // 
            proveedoresToolStripMenuItem.Image = global::Shajobe.Properties.Resources.Proveedores;
            proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            proveedoresToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            proveedoresToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            proveedoresToolStripMenuItem.Text = "&Proveedores";
            proveedoresToolStripMenuItem.Click += new System.EventHandler(proveedoresToolStripMenuItem_Click_1);
            // 
            // materiaPrimaToolStripMenuItem
            // 
            materiaPrimaToolStripMenuItem.Image = global::Shajobe.Properties.Resources.Materia_prima;
            materiaPrimaToolStripMenuItem.Name = "materiaPrimaToolStripMenuItem";
            materiaPrimaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            materiaPrimaToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            materiaPrimaToolStripMenuItem.Text = "&Materia prima con rebaba";
            materiaPrimaToolStripMenuItem.Click += new System.EventHandler(materiaPrimaToolStripMenuItem_Click);
            // 
            // materiaPrimaSinRebabaToolStripMenuItem
            // 
            materiaPrimaSinRebabaToolStripMenuItem.Image = global::Shajobe.Properties.Resources.Materia_prima;
            materiaPrimaSinRebabaToolStripMenuItem.Name = "materiaPrimaSinRebabaToolStripMenuItem";
            materiaPrimaSinRebabaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            materiaPrimaSinRebabaToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            materiaPrimaSinRebabaToolStripMenuItem.Text = "&Materia prima sin rebaba";
            materiaPrimaSinRebabaToolStripMenuItem.Click += new System.EventHandler(materiaPrimaSinRebabaToolStripMenuItem_Click);
            // 
            // productosTerminadosToolStripMenuItem
            // 
            productosTerminadosToolStripMenuItem.Image = global::Shajobe.Properties.Resources.Producto;
            productosTerminadosToolStripMenuItem.Name = "productosTerminadosToolStripMenuItem";
            productosTerminadosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            productosTerminadosToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            productosTerminadosToolStripMenuItem.Text = "&Productos terminados";
            productosTerminadosToolStripMenuItem.Click += new System.EventHandler(productosTerminadosToolStripMenuItem_Click_1);
            // 
            // productosIndirectosToolStripMenuItem
            // 
            productosIndirectosToolStripMenuItem.Image = global::Shajobe.Properties.Resources.Indirecto;
            productosIndirectosToolStripMenuItem.Name = "productosIndirectosToolStripMenuItem";
            productosIndirectosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            productosIndirectosToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            productosIndirectosToolStripMenuItem.Text = "&Productos Indirectos";
            productosIndirectosToolStripMenuItem.Click += new System.EventHandler(productosIndirectosToolStripMenuItem_Click);
            // 
            // productosElaboradosToolStripMenuItem
            // 
            productosElaboradosToolStripMenuItem.Image = global::Shajobe.Properties.Resources.Producto_Elaborado;
            productosElaboradosToolStripMenuItem.Name = "productosElaboradosToolStripMenuItem";
            productosElaboradosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            productosElaboradosToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            productosElaboradosToolStripMenuItem.Text = "&Productos elaborados";
            productosElaboradosToolStripMenuItem.Click += new System.EventHandler(productosElaboradosToolStripMenuItem_Click);
            // 
            // inventariosToolStripMenuItem
            // 
            inventariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            almacenToolStripMenuItem,
            inventariosToolStripMenuItem1});
            inventariosToolStripMenuItem.Name = "inventariosToolStripMenuItem";
            inventariosToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            inventariosToolStripMenuItem.Text = "Inventarios";
            // 
            // almacenToolStripMenuItem
            // 
            almacenToolStripMenuItem.Image = global::Shajobe.Properties.Resources.Almacen;
            almacenToolStripMenuItem.Name = "almacenToolStripMenuItem";
            almacenToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            almacenToolStripMenuItem.Text = "Almacén";
            almacenToolStripMenuItem.Click += new System.EventHandler(almacenToolStripMenuItem_Click);
            // 
            // inventariosToolStripMenuItem1
            // 
            inventariosToolStripMenuItem1.Image = global::Shajobe.Properties.Resources.Inventario;
            inventariosToolStripMenuItem1.Name = "inventariosToolStripMenuItem1";
            inventariosToolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            inventariosToolStripMenuItem1.Text = "Inventarios";
            inventariosToolStripMenuItem1.Click += new System.EventHandler(inventariosToolStripMenuItem1_Click);
            // 
            // elaborarProductosToolStripMenuItem
            // 
            elaborarProductosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            ingredientesEmpaquesToolStripMenuItem});
            elaborarProductosToolStripMenuItem.Name = "elaborarProductosToolStripMenuItem";
            elaborarProductosToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            elaborarProductosToolStripMenuItem.Text = "Elaborar productos";
            // 
            // ingredientesEmpaquesToolStripMenuItem
            // 
            ingredientesEmpaquesToolStripMenuItem.Name = "ingredientesEmpaquesToolStripMenuItem";
            ingredientesEmpaquesToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            ingredientesEmpaquesToolStripMenuItem.Text = "Ingredientes - Empaques";
            ingredientesEmpaquesToolStripMenuItem.Click += new System.EventHandler(ingredientesEmpaquesToolStripMenuItem_Click);
            // 
            // financieroToolStripMenuItem
            // 
            financieroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            cajaToolStripMenuItem,
            toolStripSeparator1,
            ventaToolStripMenuItem,
            toolStripSeparator3,
            abonoToolStripMenuItem});
            financieroToolStripMenuItem.Name = "financieroToolStripMenuItem";
            financieroToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            financieroToolStripMenuItem.Text = "Financiero";
            // 
            // cajaToolStripMenuItem
            // 
            cajaToolStripMenuItem.Image = global::Shajobe.Properties.Resources.caja_eleventa;
            cajaToolStripMenuItem.Name = "cajaToolStripMenuItem";
            cajaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            cajaToolStripMenuItem.Text = "Caja";
            cajaToolStripMenuItem.Click += new System.EventHandler(cajaToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // ventaToolStripMenuItem
            // 
            ventaToolStripMenuItem.Image = global::Shajobe.Properties.Resources.Venta;
            ventaToolStripMenuItem.Name = "ventaToolStripMenuItem";
            ventaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            ventaToolStripMenuItem.Text = "Venta - Pedido";
            ventaToolStripMenuItem.Click += new System.EventHandler(ventaToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // abonoToolStripMenuItem
            // 
            abonoToolStripMenuItem.Image = global::Shajobe.Properties.Resources.Modificar;
            abonoToolStripMenuItem.Name = "abonoToolStripMenuItem";
            abonoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            abonoToolStripMenuItem.Text = "Abono";
            abonoToolStripMenuItem.Click += new System.EventHandler(abonoToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            reportesToolStripMenuItem.Text = "Reportes";
            // 
            // configuraciónToolStripMenuItem
            // 
            configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            cuentasDeUsuarioToolStripMenuItem,
            toolStripSeparator2});
            configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            configuraciónToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            configuraciónToolStripMenuItem.Text = "Configuración";
            // 
            // cuentasDeUsuarioToolStripMenuItem
            // 
            cuentasDeUsuarioToolStripMenuItem.Image = global::Shajobe.Properties.Resources.Usuario;
            cuentasDeUsuarioToolStripMenuItem.Name = "cuentasDeUsuarioToolStripMenuItem";
            cuentasDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            cuentasDeUsuarioToolStripMenuItem.Text = "Cuentas de usuario";
            cuentasDeUsuarioToolStripMenuItem.Click += new System.EventHandler(cuentasDeUsuarioToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(172, 6);
            // 
            // pic_Logo
            // 
            pic_Logo.BackgroundImage = global::Shajobe.Properties.Resources.Logo_Shajobe;
            pic_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pic_Logo.Location = new System.Drawing.Point(985, 25);
            pic_Logo.Name = "pic_Logo";
            pic_Logo.Size = new System.Drawing.Size(175, 75);
            pic_Logo.TabIndex = 33;
            pic_Logo.TabStop = false;
            // 
            // panel3
            // 
            panel3.AutoScroll = true;
            panel3.Controls.Add(dataGridProductosTerminados);
            panel3.Controls.Add(dataGridProductosElaborados);
            panel3.Controls.Add(dataSinRebaba);
            panel3.Controls.Add(dataConrebaba);
            panel3.Controls.Add(dataIndirecto);
            panel3.Location = new System.Drawing.Point(303, 136);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(473, 600);
            panel3.TabIndex = 34;
            // 
            // dataGridProductosTerminados
            // 
            dataGridProductosTerminados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridProductosTerminados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            Id_AlertaProducto,
            Id_ProductoTerminado,
            Id_Almacent,
            ProductoTerminado,
            Existenciat,
            Fechat,
            Activot});
            dataGridProductosTerminados.Location = new System.Drawing.Point(12, 790);
            dataGridProductosTerminados.Name = "dataGridProductosTerminados";
            dataGridProductosTerminados.Size = new System.Drawing.Size(442, 199);
            dataGridProductosTerminados.TabIndex = 36;
            // 
            // Id_AlertaProducto
            // 
            Id_AlertaProducto.HeaderText = "Id_AlertaProducto";
            Id_AlertaProducto.Name = "Id_AlertaProducto";
            Id_AlertaProducto.Visible = false;
            // 
            // Id_ProductoTerminado
            // 
            Id_ProductoTerminado.HeaderText = "Id_ProductoTerminado";
            Id_ProductoTerminado.Name = "Id_ProductoTerminado";
            Id_ProductoTerminado.Visible = false;
            // 
            // Id_Almacent
            // 
            Id_Almacent.HeaderText = "Id_Almacent";
            Id_Almacent.Name = "Id_Almacent";
            Id_Almacent.Visible = false;
            // 
            // ProductoTerminado
            // 
            ProductoTerminado.HeaderText = "Producto terminado";
            ProductoTerminado.Name = "ProductoTerminado";
            // 
            // Existenciat
            // 
            Existenciat.HeaderText = "Existencia";
            Existenciat.Name = "Existenciat";
            // 
            // Fechat
            // 
            Fechat.HeaderText = "Fecha";
            Fechat.Name = "Fechat";
            // 
            // Activot
            // 
            Activot.HeaderText = "Activo";
            Activot.Name = "Activot";
            Activot.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            Activot.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridProductosElaborados
            // 
            dataGridProductosElaborados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridProductosElaborados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            Id_AlertaProductoElaborado,
            Id_ProductoElaborado,
            Id_Almacene,
            ProductoElaborado,
            Existenciae,
            Fechae,
            Activoe});
            dataGridProductosElaborados.Location = new System.Drawing.Point(12, 606);
            dataGridProductosElaborados.Name = "dataGridProductosElaborados";
            dataGridProductosElaborados.Size = new System.Drawing.Size(442, 178);
            dataGridProductosElaborados.TabIndex = 35;
            // 
            // Id_AlertaProductoElaborado
            // 
            Id_AlertaProductoElaborado.HeaderText = "Id_AlertaProductoElaborado";
            Id_AlertaProductoElaborado.Name = "Id_AlertaProductoElaborado";
            Id_AlertaProductoElaborado.Visible = false;
            // 
            // Id_ProductoElaborado
            // 
            Id_ProductoElaborado.HeaderText = "Id_ProductoElaborado";
            Id_ProductoElaborado.Name = "Id_ProductoElaborado";
            Id_ProductoElaborado.Visible = false;
            // 
            // Id_Almacene
            // 
            Id_Almacene.HeaderText = "Id_Almacene";
            Id_Almacene.Name = "Id_Almacene";
            Id_Almacene.Visible = false;
            // 
            // ProductoElaborado
            // 
            ProductoElaborado.HeaderText = "Producto elaborado";
            ProductoElaborado.Name = "ProductoElaborado";
            // 
            // Existenciae
            // 
            Existenciae.HeaderText = "Existencia";
            Existenciae.Name = "Existenciae";
            // 
            // Fechae
            // 
            Fechae.HeaderText = "Fecha";
            Fechae.Name = "Fechae";
            // 
            // Activoe
            // 
            Activoe.HeaderText = "Activo";
            Activoe.Name = "Activoe";
            // 
            // dataSinRebaba
            // 
            dataSinRebaba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataSinRebaba.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            Id_AlertaMateriaPrimaP,
            Id_MateriaPrimaP,
            MateriaPrimaP,
            Id_Almacens,
            Existencias,
            Fechas,
            Activos});
            dataSinRebaba.Location = new System.Drawing.Point(12, 401);
            dataSinRebaba.Name = "dataSinRebaba";
            dataSinRebaba.Size = new System.Drawing.Size(442, 199);
            dataSinRebaba.TabIndex = 34;
            // 
            // Id_AlertaMateriaPrimaP
            // 
            Id_AlertaMateriaPrimaP.HeaderText = "Id_AlertaMateriaPrimaP";
            Id_AlertaMateriaPrimaP.Name = "Id_AlertaMateriaPrimaP";
            Id_AlertaMateriaPrimaP.Visible = false;
            // 
            // Id_MateriaPrimaP
            // 
            Id_MateriaPrimaP.HeaderText = "Id_MateriaPrimaP";
            Id_MateriaPrimaP.Name = "Id_MateriaPrimaP";
            Id_MateriaPrimaP.Visible = false;
            // 
            // MateriaPrimaP
            // 
            MateriaPrimaP.HeaderText = "Materia prima";
            MateriaPrimaP.Name = "MateriaPrimaP";
            // 
            // Id_Almacens
            // 
            Id_Almacens.HeaderText = "Id_Almacen";
            Id_Almacens.Name = "Id_Almacens";
            Id_Almacens.Visible = false;
            // 
            // Existencias
            // 
            Existencias.HeaderText = "Existencia";
            Existencias.Name = "Existencias";
            // 
            // Fechas
            // 
            Fechas.HeaderText = "Fecha";
            Fechas.Name = "Fechas";
            // 
            // Activos
            // 
            Activos.HeaderText = "Activo";
            Activos.Name = "Activos";
            // 
            // dataConrebaba
            // 
            dataConrebaba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataConrebaba.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            Id_AlertaMateriaPrima,
            Id_Almacenc,
            Id_MateriaPrima,
            MateriaPrima,
            Existenciac,
            Fechac,
            Activoc});
            dataConrebaba.Location = new System.Drawing.Point(12, 195);
            dataConrebaba.Name = "dataConrebaba";
            dataConrebaba.Size = new System.Drawing.Size(442, 199);
            dataConrebaba.TabIndex = 33;
            // 
            // Id_AlertaMateriaPrima
            // 
            Id_AlertaMateriaPrima.HeaderText = "Id_AlertaMateriaPrima";
            Id_AlertaMateriaPrima.Name = "Id_AlertaMateriaPrima";
            Id_AlertaMateriaPrima.Visible = false;
            // 
            // Id_Almacenc
            // 
            Id_Almacenc.HeaderText = "Id_Almacen";
            Id_Almacenc.Name = "Id_Almacenc";
            Id_Almacenc.Visible = false;
            // 
            // Id_MateriaPrima
            // 
            Id_MateriaPrima.HeaderText = "Id_MateriaPrima";
            Id_MateriaPrima.Name = "Id_MateriaPrima";
            Id_MateriaPrima.Visible = false;
            // 
            // MateriaPrima
            // 
            MateriaPrima.HeaderText = "MateriaPrima";
            MateriaPrima.Name = "MateriaPrima";
            // 
            // Existenciac
            // 
            Existenciac.HeaderText = "Existencia";
            Existenciac.Name = "Existenciac";
            // 
            // Fechac
            // 
            Fechac.HeaderText = "Fecha";
            Fechac.Name = "Fechac";
            // 
            // Activoc
            // 
            Activoc.HeaderText = "Activo";
            Activoc.Name = "Activoc";
            // 
            // dataIndirecto
            // 
            dataIndirecto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataIndirecto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            Id_AlertaIndirecto,
            Id_ProductoIndirecto,
            ProductoIndirecto,
            Id_Almacen,
            Existencia,
            Fecha,
            Activo});
            dataIndirecto.Location = new System.Drawing.Point(12, 10);
            dataIndirecto.Name = "dataIndirecto";
            dataIndirecto.Size = new System.Drawing.Size(442, 178);
            dataIndirecto.TabIndex = 32;
            // 
            // Id_AlertaIndirecto
            // 
            Id_AlertaIndirecto.HeaderText = "Id_AlertaIndirecto";
            Id_AlertaIndirecto.Name = "Id_AlertaIndirecto";
            Id_AlertaIndirecto.Visible = false;
            // 
            // Id_ProductoIndirecto
            // 
            Id_ProductoIndirecto.HeaderText = "Id_ProductoIndirecto";
            Id_ProductoIndirecto.Name = "Id_ProductoIndirecto";
            Id_ProductoIndirecto.Visible = false;
            // 
            // ProductoIndirecto
            // 
            ProductoIndirecto.HeaderText = "ProductoIndirecto";
            ProductoIndirecto.Name = "ProductoIndirecto";
            // 
            // Id_Almacen
            // 
            Id_Almacen.HeaderText = "Id_Almacen";
            Id_Almacen.Name = "Id_Almacen";
            Id_Almacen.Visible = false;
            // 
            // Existencia
            // 
            Existencia.HeaderText = "Existencia";
            Existencia.Name = "Existencia";
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            // 
            // Activo
            // 
            Activo.HeaderText = "Activo";
            Activo.Name = "Activo";
            // 
            // Menu_Principal
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1177, 791);
            Controls.Add(panel3);
            Controls.Add(pic_Logo);
            Controls.Add(lbl_Proveedoresporpagar);
            Controls.Add(lbl_Clientesporpagar);
            Controls.Add(picCliente);
            Controls.Add(dataGridViewClientes);
            Controls.Add(dataGridViewProveedores);
            Controls.Add(label2);
            Controls.Add(lbl_PedidosPendientes);
            Controls.Add(pic_Proveedor);
            Controls.Add(pic_Recordatorio);
            Controls.Add(pic_Pendiente);
            Controls.Add(dataPendiente);
            Controls.Add(menu);
            BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(228)))), ((int)(((byte)(196)))));
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Icon = global::Shajobe.Properties.Resources.Icono_Shajobe;
            MainMenuStrip = menu;
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(1183, 820);
            MinimumSize = new System.Drawing.Size(1183, 820);
            Name = "Menu_Principal";
            Text = "Menu principal";
            FormClosing += new System.Windows.Forms.FormClosingEventHandler(Menu_Principal_FormClosing);
            Load += new System.EventHandler(Menu_Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(picCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dataGridViewClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dataGridViewProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pic_Proveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pic_Recordatorio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pic_Pendiente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dataPendiente)).EndInit();
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(pic_Logo)).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(dataGridProductosTerminados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dataGridProductosElaborados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dataSinRebaba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dataConrebaba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dataIndirecto)).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        #region Eventos
        //-------------------------------------------------------------
        //------Abre la ventana y valida si la ventana esta abierta----
        //-------------------------------------------------------------
        #region Ventas y pestañas
        private void clientesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //VALIDACION DE VENTANAS
            if (Application.OpenForms["Cliente"] != null)// EN CASO DE TENER UNA VENTANA YA ABIERTA SOLO SE ACTIVA LA ABIERTA
            {
                Application.OpenForms["Cliente"].Activate();
            }
            else                                      // EN CASO DE NO TENER UNA VENTANA ABIERTA ABRE LA VENTANA
            {
                Cliente c = new Cliente();
                c.Show();
            }
        }
        private void proveedoresToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //VALIDACION DE VENTANAS
            if (Application.OpenForms["Proveedor"] != null)// EN CASO DE TENER UNA VENTANA YA ABIERTA SOLO SE ACTIVA LA ABIERTA
            {
                Application.OpenForms["Proveedor"].Activate();
            }
            else                                      // EN CASO DE NO TENER UNA VENTANA ABIERTA ABRE LA VENTANA
            {
                Proveedor p = new Proveedor();
                p.Show();
            }
        }
        private void productosIndirectosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //VALIDACION DE VENTANAS
            if (Application.OpenForms["Indirecto"] != null)// EN CASO DE TENER UNA VENTANA YA ABIERTA SOLO SE ACTIVA LA ABIERTA
            {
                Application.OpenForms["Indirecto"].Activate();
            }
            else                                      // EN CASO DE NO TENER UNA VENTANA ABIERTA ABRE LA VENTANA
            {
                Indirecto i = new Indirecto();
                i.Show();
            }
        }
        private void productosTerminadosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //VALIDACION DE VENTANAS
            if (Application.OpenForms["Producto_Terminado"] != null)// EN CASO DE TENER UNA VENTANA YA ABIERTA SOLO SE ACTIVA LA ABIERTA
            {
                Application.OpenForms["Producto_Terminado"].Activate();
            }
            else                                      // EN CASO DE NO TENER UNA VENTANA ABIERTA ABRE LA VENTANA
            {
                Producto_Terminado pt = new Producto_Terminado();
                pt.Show();
            }
        }
        private void materiaPrimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //VALIDACION DE VENTANAS
            if (Application.OpenForms["Materia_Prima"] != null)// EN CASO DE TENER UNA VENTANA YA ABIERTA SOLO SE ACTIVA LA ABIERTA
            {
                Application.OpenForms["Materia_Prima"].Activate();
            }
            else                                      // EN CASO DE NO TENER UNA VENTANA ABIERTA ABRE LA VENTANA
            {
                Materia_Prima mp = new Materia_Prima();
                mp.Show();
            }
        }
        private void materiaPrimaSinRebabaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //VALIDACION DE VENTANAS
            if (Application.OpenForms["Materia_PrimaP"] != null)// EN CASO DE TENER UNA VENTANA YA ABIERTA SOLO SE ACTIVA LA ABIERTA
            {
                Application.OpenForms["Materia_PrimaP"].Activate();
            }
            else                                      // EN CASO DE NO TENER UNA VENTANA ABIERTA ABRE LA VENTANA
            {
                Materia_PrimaP mp = new Materia_PrimaP();
                mp.Show();
            }
        }
        private void productosElaboradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //VALIDACION DE VENTANAS
            if (Application.OpenForms["Producto_Elaborado"] != null)// EN CASO DE TENER UNA VENTANA YA ABIERTA SOLO SE ACTIVA LA ABIERTA
            {
                Application.OpenForms["Producto_Elaborado"].Activate();
            }
            else                                      // EN CASO DE NO TENER UNA VENTANA ABIERTA ABRE LA VENTANA
            {
                Producto_Elaborado pe = new Producto_Elaborado();
                pe.Show();
            }

        }
        private void almacenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //VALIDACION DE VENTANAS
            if (Application.OpenForms["Almacen"] != null)// EN CASO DE TENER UNA VENTANA YA ABIERTA SOLO SE ACTIVA LA ABIERTA
            {
                Application.OpenForms["Almacen"].Activate();
            }
            else                                      // EN CASO DE NO TENER UNA VENTANA ABIERTA ABRE LA VENTANA
            {
                Almacen a = new Almacen();
                a.Show();
            }
        }
        private void inventariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //VALIDACION DE VENTANAS
            if (Application.OpenForms["Inventario"] != null)// EN CASO DE TENER UNA VENTANA YA ABIERTA SOLO SE ACTIVA LA ABIERTA
            {
                Application.OpenForms["Inventario"].Activate();
            }
            else                                      // EN CASO DE NO TENER UNA VENTANA ABIERTA ABRE LA VENTANA
            {
                Inventario i = new Inventario();
                i.Show();
            }
        }
        private void cuentasDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //VALIDACION DE VENTANAS
            if (Application.OpenForms["Usuario"] != null)// EN CASO DE TENER UNA VENTANA YA ABIERTA SOLO SE ACTIVA LA ABIERTA
            {
                Application.OpenForms["Usuario"].Activate();
            }
            else                                      // EN CASO DE NO TENER UNA VENTANA ABIERTA ABRE LA VENTANA
            {
                Usuario u = new Usuario();
                u.Show();
            }
        }
        private void ingredientesEmpaquesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //VALIDACION DE VENTANAS
            if (Application.OpenForms["Ingredientes_Empaques"] != null)// EN CASO DE TENER UNA VENTANA YA ABIERTA SOLO SE ACTIVA LA ABIERTA
            {
                Application.OpenForms["Ingredientes_Empaques"].Activate();
            }
            else                                      // EN CASO DE NO TENER UNA VENTANA ABIERTA ABRE LA VENTANA
            {
                Ingredientes_Empaques ine = new Ingredientes_Empaques();
                ine.Show();
            }
        }
        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //VALIDACION DE VENTANAS
            if (Application.OpenForms["Venta"] != null)// EN CASO DE TENER UNA VENTANA YA ABIERTA SOLO SE ACTIVA LA ABIERTA
            {
                Application.OpenForms["Venta"].Activate();
            }
            else                                      // EN CASO DE NO TENER UNA VENTANA ABIERTA ABRE LA VENTANA
            {
                Venta v = new Venta();
                v.Show();
            }
        }
        private void cajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //VALIDACION DE VENTANAS
            if (Application.OpenForms["Caja"] != null)// EN CASO DE TENER UNA VENTANA YA ABIERTA SOLO SE ACTIVA LA ABIERTA
            {
                Application.OpenForms["Caja"].Activate();
            }
            else                                      // EN CASO DE NO TENER UNA VENTANA ABIERTA ABRE LA VENTANA
            {
                Caja c = new Caja();
                c.Show();
            }
        }
        private void abonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //VALIDACION DE VENTANAS
            if (Application.OpenForms["Abono"] != null)// EN CASO DE TENER UNA VENTANA YA ABIERTA SOLO SE ACTIVA LA ABIERTA
            {
                Application.OpenForms["Abono"].Activate();
            }
            else                                      // EN CASO DE NO TENER UNA VENTANA ABIERTA ABRE LA VENTANA
            {
                Abono c = new Abono();
                c.Show();
            }
        }
        #endregion
        //-------------------------------------------------------------
        //------         Menu Pricipal carga de elementos        ------
        //-------------------------------------------------------------
        private int Idp;
        //Cargando Alertas del sistema
        #region Alertas de inventario
        private void Alerta_Indirecto()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand coman = new OleDbCommand();
            OleDbDataReader dr;
            con.ConnectionString = ObtenerString();
            coman.Connection = con;
            coman.CommandText = "Select Id_AlertaIndirecto,Id_AlmacenIndirecto,Id_ProductoIndirecto,Existencia,Fecha_Alerta,Activo from Tb_AlertaIndirecto";
            coman.CommandType = CommandType.Text;
            con.Open();
            dataIndirecto.Rows.Clear();
            dr = coman.ExecuteReader();
            while (dr.Read())
            {
                int Renglon = dataIndirecto.Rows.Add();
                Idp = dr.GetInt32(dr.GetOrdinal("Id_AlertaIndirecto"));
                dataIndirecto.Rows[Renglon].Cells["Id_AlertaIndirecto"].Value = dr.GetInt32(dr.GetOrdinal("Id_AlertaIndirecto"));
                dataIndirecto.Rows[Renglon].Cells["Id_ProductoIndirecto"].Value = dr.GetInt32(dr.GetOrdinal("Id_ProductoIndirecto"));
                dataIndirecto.Rows[Renglon].Cells["Id_AlmacenIndirecto"].Value = dr.GetInt32(dr.GetOrdinal("Id_AlmacenIndirecto"));
                dataIndirecto.Rows[Renglon].Cells["Existencia"].Value = dr.GetInt32(dr.GetOrdinal("Existencia"));
                dataIndirecto.Rows[Renglon].Cells["Fecha_Alerta"].Value = dr.GetString(dr.GetOrdinal("Fecha_Alerta"));
                //dataIndirecto.Rows[Renglon].Cells["Activo"].Value = dr.GetString(dr.GetOrdinal("Activo"));
            }
            con.Close();
        }
        #endregion
        #region Aviso de compra de materia
        // LLenado del datagridView para notificar las cosas por comprar
        private void Indirecto()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand coman = new OleDbCommand();
            OleDbDataReader dr;
            con.ConnectionString = ObtenerString();
            coman.Connection = con;
            coman.CommandText = "Select * from Tb_Concepto";
            coman.CommandType = CommandType.Text;
            con.Open();
            dataIndirecto.Rows.Clear();
            dr = coman.ExecuteReader();
            while (dr.Read())
            {
                int Renglon = dataIndirecto.Rows.Add();
                dataIndirecto.Rows[Renglon].Cells["Id_ProductoIndirecto "].Value = dr.GetInt32(dr.GetOrdinal("Id_ProductoIndirecto "));
                dataIndirecto.Rows[Renglon].Cells["ProductoIndirecto "].Value = dr.GetString(dr.GetOrdinal("ProductoIndirecto"));
                dataIndirecto.Rows[Renglon].Cells["Nombre"].Value = dr.GetString(dr.GetOrdinal("Nombre"));
                dataIndirecto.Rows[Renglon].Cells["Descripcion"].Value = dr.GetString(dr.GetOrdinal("Descripcion"));
            }
            con.Close();
        }
        private void Sinrebaba()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand coman = new OleDbCommand();
            OleDbDataReader dr;
            con.ConnectionString = ObtenerString();
            coman.Connection = con;
            coman.CommandText = "Select* from Tb_Concepto";
            coman.CommandType = CommandType.Text;
            con.Open();
            dataSinRebaba.Rows.Clear();
            dr = coman.ExecuteReader();
            while (dr.Read())
            {

            }
            con.Close();
        }
        private void Conrebaba()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand coman = new OleDbCommand();
            OleDbDataReader dr;
            con.ConnectionString = ObtenerString();
            coman.Connection = con;
            coman.CommandText = "Select * from Tb_Concepto";
            coman.CommandType = CommandType.Text;
            con.Open();
            dataConrebaba.Rows.Clear();
            dr = coman.ExecuteReader();
            while (dr.Read())
            {

            }
            con.Close();
        }
        #endregion
        //-------------------------------------------------------------
        //------  Cierra la sesión antes de cerrar la apliación  ------
        //-------------------------------------------------------------
        private void Menu_Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Quieres cerrar la aplicación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //OBTENIENDO EL ID DE LA CUENTA ACTIVA
                int Ultimo_Id = 0;
                OleDbConnection con = new OleDbConnection();
                OleDbCommand coman = new OleDbCommand();
                OleDbDataReader dr;
                con.ConnectionString = ObtenerString();
                coman.Connection = con;
                coman.CommandText = "select Id_Usuario from Tb_Usuarios_Login where Estado='A'";
                coman.CommandType = CommandType.Text;
                con.Open();
                dr = coman.ExecuteReader();
                while (dr.Read())
                {
                    Ultimo_Id = dr.GetInt32(dr.GetOrdinal("Id_Usuario"));
                }
                con.Close();
                //CREANDO REGISTRO DE DESLOGUEO
                OleDbConnection conexion = null;
                OleDbTransaction transaccion = null;
                conexion = new OleDbConnection(ObtenerString());
                conexion.Open();
                transaccion = conexion.BeginTransaction(System.Data.IsolationLevel.Serializable);
                OleDbCommand comando = new OleDbCommand("SP_Login_Desconectar", conexion, transaccion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@VId_Usuario", Ultimo_Id);
                comando.ExecuteNonQuery();
                transaccion.Commit();

                Application.Exit();
            }

        }
        //-------------------------------------------------------------
        //------Obtiene la cadena de conexion desde la app Config------
        //-------------------------------------------------------------
        public static string ObtenerString()
        {
            //return Settings.Default.ShajobeConnectionString;
            return "";
        }
        //-------------------------------------------------------------
        //------Obtiene los permisos y menus que tiene derecho ver-----
        //-------------------------------------------------------------
        public void Carga_Permisos(int I)
        {
            //SqlConnection con = new SqlConnection();
            //SqlDataReader dr;
            //SqlCommand com = new SqlCommand();
            //con.ConnectionString = direccionBD;
            //com.Connection = con;
            ////com.CommandText = "Select Id_Menu From Permisos where Id_Tipo_Usuario=Select Id_Tipo_Usuario From Usuario Where Id_Usuario='" + Convert.ToString(I) + "'";
            //com.CommandText = "Select Id_Menu From Permisos where Id_Tipo_Usuario=(Select Id_Tipo_Usuario From Usuario Where Id_Usuario='" + I + "')";
            //com.CommandType = CommandType.Text;
            //con.Open();
            //dr = com.ExecuteReader();
            //while (dr.Read())
            //{
            //    int Id_Menu = dr.GetInt32(dr.GetOrdinal("Id_Menu"));
            //    if (Id_Menu == 1) toolStripSplitButton1.Enabled = true;
            //    if (Id_Menu == 2) medicamentosToolStripMenuItem.Enabled = true;
            //    if (Id_Menu == 3) proveedoresToolStripMenuItem.Enabled = true;
            //    if (Id_Menu == 4) ClientesToolStripMenuItem.Enabled = true;
            //    //if (Id_Menu == 5) salidaDelInventarioToolStripMenuItem.Enabled = true;
            //    if (Id_Menu == 6) toolStripSplitButton2.Enabled = true;
            //    if (Id_Menu == 7) realizarPedidoToolStripMenuItem.Enabled = true;
            //    if (Id_Menu == 8) salidaDeInventarioToolStripMenuItem.Enabled = true;
            //    if (Id_Menu == 9) toolStripSplitButton3.Enabled = true;
            //    if (Id_Menu == 10) toolStripButton1.Enabled = true;
            //}
            //con.Close();
        }
        private void Menu_Principal_Load(object sender, EventArgs e)
        {
            Diseño_Forma();
        }
        #endregion
    }
}
