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
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }
        #region Diseño de la forma
        #region Creando controles de la forma
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_MateriaPrima;
        private System.Windows.Forms.TabPage tab_MateriaPrimaP;
        private System.Windows.Forms.TabPage tab_ProductoElaborado;
        private System.Windows.Forms.TabPage tab_ProductoIndirecto;
        private System.Windows.Forms.TabPage tab_ProductoTerminado;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercadeToolStripMenuItem;
        private System.Windows.Forms.PictureBox pic_Proveedor;
        private System.Windows.Forms.ToolStripMenuItem controlDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nivelMaxMinToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox_ListaMateriaPrimam;
        private System.Windows.Forms.DataGridView data_MateriaPrima;
        private System.Windows.Forms.GroupBox groupBox_MateriaPrimam;
        private System.Windows.Forms.Label lbl_Almacenm;
        private System.Windows.Forms.Label lbl_Fecham;
        private System.Windows.Forms.ComboBox combo_Almacenm;
        private System.Windows.Forms.Label lbl_PrecioVentam;
        private System.Windows.Forms.ComboBox comboBox_MateriaPrimam;
        private System.Windows.Forms.Label lbl_PrecioCompram;
        private System.Windows.Forms.TextBox txt_Lotem;
        private System.Windows.Forms.Label lbl_Existenciam;
        private System.Windows.Forms.TextBox txt_Existenciam;
        private System.Windows.Forms.Label lbl_Lotem;
        private System.Windows.Forms.TextBox txt_PrecioCompram;
        private System.Windows.Forms.Label lbl_MateriaPrima;
        private System.Windows.Forms.TextBox txt_PrecioVentam;
        private System.Windows.Forms.DateTimePicker dateTime_MateriaPrimam;
        private System.Windows.Forms.GroupBox groupBox_ListaMateriaPrimap;
        private System.Windows.Forms.DataGridView data_MateriaPrimaP;
        private System.Windows.Forms.GroupBox groupBox_MateriaPrimap;
        private System.Windows.Forms.Label lbl_Almacenp;
        private System.Windows.Forms.Label lbl_Fechap;
        private System.Windows.Forms.ComboBox combo_Almacenp;
        private System.Windows.Forms.Label lbl_PrecioVentaP;
        private System.Windows.Forms.ComboBox comboBox_MateriaPrimap;
        private System.Windows.Forms.Label lbl_PrecioComprap;
        private System.Windows.Forms.TextBox txt_Lotep;
        private System.Windows.Forms.Label lbl_Existenciap;
        private System.Windows.Forms.TextBox txt_Exisnteciap;
        private System.Windows.Forms.Label lbl_Lotep;
        private System.Windows.Forms.TextBox txt_PrecioComprap;
        private System.Windows.Forms.Label lbl_MateriaPrimaP;
        private System.Windows.Forms.TextBox txt_PrecioVentap;
        private System.Windows.Forms.DateTimePicker dateTime_MateriaPrimap;
        private System.Windows.Forms.GroupBox groupBox_ListaProductoElaborado;
        private System.Windows.Forms.DataGridView data_ProductoElaborado;
        private System.Windows.Forms.GroupBox groupBox_ProductoElaborado;
        private System.Windows.Forms.Label lbl_Almacene;
        private System.Windows.Forms.Label lbl_Fechae;
        private System.Windows.Forms.ComboBox combo_Almacene;
        private System.Windows.Forms.Label lbl_PrecioVentae;
        private System.Windows.Forms.ComboBox comboBox_ProductoElaborado;
        private System.Windows.Forms.Label lbl_PrecioComprae;
        private System.Windows.Forms.TextBox txt_Lotee;
        private System.Windows.Forms.Label lbl_Existenciae;
        private System.Windows.Forms.TextBox txt_Existenciae;
        private System.Windows.Forms.Label lbl_Lotee;
        private System.Windows.Forms.TextBox txt_PrecioComprae;
        private System.Windows.Forms.Label lbl_ProductoElaborado;
        private System.Windows.Forms.TextBox txt_PrecioVentae;
        private System.Windows.Forms.DateTimePicker dateTime_ProductoElaborado;
        private System.Windows.Forms.GroupBox groupBox_ListaProductoIndirecto;
        private System.Windows.Forms.DataGridView data_ProductoIndirecto;
        private System.Windows.Forms.GroupBox groupBox_ProductoIndirecto;
        private System.Windows.Forms.Label lbl_Almaceni;
        private System.Windows.Forms.Label lbl_FechaI;
        private System.Windows.Forms.ComboBox combo_Almaceni;
        private System.Windows.Forms.Label lbl_PrecioVentaI;
        private System.Windows.Forms.ComboBox comboBox_ProductoIndirecto;
        private System.Windows.Forms.Label lbl_PrecioCompraI;
        private System.Windows.Forms.Label lbl_Existenciai;
        private System.Windows.Forms.TextBox txt_Existenciai;
        private System.Windows.Forms.TextBox txt_PrecioComprai;
        private System.Windows.Forms.Label lbl_ProductoIndirecto;
        private System.Windows.Forms.TextBox txt_PrecioVentai;
        private System.Windows.Forms.DateTimePicker dateTime_ProductoIndirecto;
        private System.Windows.Forms.GroupBox groupBox_ListaProductoTerminado;
        private System.Windows.Forms.DataGridView data_ProductoTerminado;
        private System.Windows.Forms.GroupBox groupBox_ProductoTerminado;
        private System.Windows.Forms.Label lbl_Almacent;
        private System.Windows.Forms.Label lbl_Fechat;
        private System.Windows.Forms.ComboBox combo_Almacent;
        private System.Windows.Forms.Label lbl_PrecioVentat;
        private System.Windows.Forms.ComboBox comboBox_ProductoTerminado;
        private System.Windows.Forms.Label lbl_PrecioComprat;
        private System.Windows.Forms.TextBox txt_Lotet;
        private System.Windows.Forms.Label lbl_Existenciat;
        private System.Windows.Forms.TextBox txt_Existenciat;
        private System.Windows.Forms.Label lbl_Lotet;
        private System.Windows.Forms.TextBox txt_PrecioComprat;
        private System.Windows.Forms.Label lbl_Producto;
        private System.Windows.Forms.TextBox txt_PrecioVentat;
        private System.Windows.Forms.DateTimePicker dateTime_ProductoTerminado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_AlmacenMateriaPrimam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Almacenm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_MateriaPrimam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materia_Primam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lotem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Existenciam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Compram;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Ventam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecham;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_AlmacenMateriaPrimaP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_MateriaPrimaP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Almacenp;
        private System.Windows.Forms.DataGridViewTextBoxColumn MateriaPrimaP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lotep;
        private System.Windows.Forms.DataGridViewTextBoxColumn Existenciap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Comprap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Ventap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fechap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_AlmacenProductoElaborado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Almacene;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_ProductoElaborado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lotee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Existenciae;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Comprae;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Ventae;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fechae;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_AlmacenProductoIndirecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Almaceni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_ProductoIndirecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Productoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Existenciai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_CompraI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Ventai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fechai;
        private System.Windows.Forms.Label lbl_Descuentot;
        private System.Windows.Forms.TextBox txt_Descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_AlmacenProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Almacent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_ProductoTerminado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Productot;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lotet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Existenciat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Comprat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Ventat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fechat;
        private System.Windows.Forms.ToolStripMenuItem ordenDePeladoToolStripMenuItem;
        #endregion
        private void Diseño_Forma()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventario));
            tabControl1 = new System.Windows.Forms.TabControl();
            tab_MateriaPrima = new System.Windows.Forms.TabPage();
            groupBox_ListaMateriaPrimam = new System.Windows.Forms.GroupBox();
            data_MateriaPrima = new System.Windows.Forms.DataGridView();
            Id_AlmacenMateriaPrimam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Id_Almacenm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Id_MateriaPrimam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Materia_Primam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Lotem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Existenciam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Precio_Compram = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Precio_Ventam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Fecham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            groupBox_MateriaPrimam = new System.Windows.Forms.GroupBox();
            lbl_Almacenm = new System.Windows.Forms.Label();
            lbl_Fecham = new System.Windows.Forms.Label();
            combo_Almacenm = new System.Windows.Forms.ComboBox();
            lbl_PrecioVentam = new System.Windows.Forms.Label();
            comboBox_MateriaPrimam = new System.Windows.Forms.ComboBox();
            lbl_PrecioCompram = new System.Windows.Forms.Label();
            txt_Lotem = new System.Windows.Forms.TextBox();
            lbl_Existenciam = new System.Windows.Forms.Label();
            txt_Existenciam = new System.Windows.Forms.TextBox();
            lbl_Lotem = new System.Windows.Forms.Label();
            txt_PrecioCompram = new System.Windows.Forms.TextBox();
            lbl_MateriaPrima = new System.Windows.Forms.Label();
            txt_PrecioVentam = new System.Windows.Forms.TextBox();
            dateTime_MateriaPrimam = new System.Windows.Forms.DateTimePicker();
            tab_MateriaPrimaP = new System.Windows.Forms.TabPage();
            groupBox_ListaMateriaPrimap = new System.Windows.Forms.GroupBox();
            data_MateriaPrimaP = new System.Windows.Forms.DataGridView();
            Id_AlmacenMateriaPrimaP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Id_MateriaPrimaP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Id_Almacenp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            MateriaPrimaP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Lotep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Existenciap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Precio_Comprap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Precio_Ventap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Fechap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            groupBox_MateriaPrimap = new System.Windows.Forms.GroupBox();
            lbl_Almacenp = new System.Windows.Forms.Label();
            lbl_Fechap = new System.Windows.Forms.Label();
            combo_Almacenp = new System.Windows.Forms.ComboBox();
            lbl_PrecioVentaP = new System.Windows.Forms.Label();
            comboBox_MateriaPrimap = new System.Windows.Forms.ComboBox();
            lbl_PrecioComprap = new System.Windows.Forms.Label();
            txt_Lotep = new System.Windows.Forms.TextBox();
            lbl_Existenciap = new System.Windows.Forms.Label();
            txt_Exisnteciap = new System.Windows.Forms.TextBox();
            lbl_Lotep = new System.Windows.Forms.Label();
            txt_PrecioComprap = new System.Windows.Forms.TextBox();
            lbl_MateriaPrimaP = new System.Windows.Forms.Label();
            txt_PrecioVentap = new System.Windows.Forms.TextBox();
            dateTime_MateriaPrimap = new System.Windows.Forms.DateTimePicker();
            tab_ProductoElaborado = new System.Windows.Forms.TabPage();
            groupBox_ListaProductoElaborado = new System.Windows.Forms.GroupBox();
            data_ProductoElaborado = new System.Windows.Forms.DataGridView();
            Id_AlmacenProductoElaborado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Id_Almacene = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Id_ProductoElaborado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Lotee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Existenciae = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Precio_Comprae = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Precio_Ventae = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Fechae = new System.Windows.Forms.DataGridViewTextBoxColumn();
            groupBox_ProductoElaborado = new System.Windows.Forms.GroupBox();
            lbl_Almacene = new System.Windows.Forms.Label();
            lbl_Fechae = new System.Windows.Forms.Label();
            combo_Almacene = new System.Windows.Forms.ComboBox();
            lbl_PrecioVentae = new System.Windows.Forms.Label();
            comboBox_ProductoElaborado = new System.Windows.Forms.ComboBox();
            lbl_PrecioComprae = new System.Windows.Forms.Label();
            txt_Lotee = new System.Windows.Forms.TextBox();
            lbl_Existenciae = new System.Windows.Forms.Label();
            txt_Existenciae = new System.Windows.Forms.TextBox();
            lbl_Lotee = new System.Windows.Forms.Label();
            txt_PrecioComprae = new System.Windows.Forms.TextBox();
            lbl_ProductoElaborado = new System.Windows.Forms.Label();
            txt_PrecioVentae = new System.Windows.Forms.TextBox();
            dateTime_ProductoElaborado = new System.Windows.Forms.DateTimePicker();
            tab_ProductoIndirecto = new System.Windows.Forms.TabPage();
            groupBox_ListaProductoIndirecto = new System.Windows.Forms.GroupBox();
            data_ProductoIndirecto = new System.Windows.Forms.DataGridView();
            Id_AlmacenProductoIndirecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Id_Almaceni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Id_ProductoIndirecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Productoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Existenciai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Precio_CompraI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Precio_Ventai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Fechai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            groupBox_ProductoIndirecto = new System.Windows.Forms.GroupBox();
            lbl_Almaceni = new System.Windows.Forms.Label();
            lbl_FechaI = new System.Windows.Forms.Label();
            combo_Almaceni = new System.Windows.Forms.ComboBox();
            lbl_PrecioVentaI = new System.Windows.Forms.Label();
            comboBox_ProductoIndirecto = new System.Windows.Forms.ComboBox();
            lbl_PrecioCompraI = new System.Windows.Forms.Label();
            lbl_Existenciai = new System.Windows.Forms.Label();
            txt_Existenciai = new System.Windows.Forms.TextBox();
            txt_PrecioComprai = new System.Windows.Forms.TextBox();
            lbl_ProductoIndirecto = new System.Windows.Forms.Label();
            txt_PrecioVentai = new System.Windows.Forms.TextBox();
            dateTime_ProductoIndirecto = new System.Windows.Forms.DateTimePicker();
            tab_ProductoTerminado = new System.Windows.Forms.TabPage();
            groupBox_ListaProductoTerminado = new System.Windows.Forms.GroupBox();
            data_ProductoTerminado = new System.Windows.Forms.DataGridView();
            Id_AlmacenProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Id_Almacent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Id_ProductoTerminado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Productot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Lotet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Existenciat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Precio_Comprat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Precio_Ventat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Fechat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            groupBox_ProductoTerminado = new System.Windows.Forms.GroupBox();
            lbl_Descuentot = new System.Windows.Forms.Label();
            txt_Descuento = new System.Windows.Forms.TextBox();
            lbl_Almacent = new System.Windows.Forms.Label();
            lbl_Fechat = new System.Windows.Forms.Label();
            combo_Almacent = new System.Windows.Forms.ComboBox();
            lbl_PrecioVentat = new System.Windows.Forms.Label();
            comboBox_ProductoTerminado = new System.Windows.Forms.ComboBox();
            lbl_PrecioComprat = new System.Windows.Forms.Label();
            txt_Lotet = new System.Windows.Forms.TextBox();
            lbl_Existenciat = new System.Windows.Forms.Label();
            txt_Existenciat = new System.Windows.Forms.TextBox();
            lbl_Lotet = new System.Windows.Forms.Label();
            txt_PrecioComprat = new System.Windows.Forms.TextBox();
            lbl_Producto = new System.Windows.Forms.Label();
            txt_PrecioVentat = new System.Windows.Forms.TextBox();
            dateTime_ProductoTerminado = new System.Windows.Forms.DateTimePicker();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            controlDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            nivelMaxMinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ordenDePeladoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            acercadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            pic_Proveedor = new System.Windows.Forms.PictureBox();
            errorProvider1 = new System.Windows.Forms.ErrorProvider(components);
            tabControl1.SuspendLayout();
            tab_MateriaPrima.SuspendLayout();
            groupBox_ListaMateriaPrimam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(data_MateriaPrima)).BeginInit();
            groupBox_MateriaPrimam.SuspendLayout();
            tab_MateriaPrimaP.SuspendLayout();
            groupBox_ListaMateriaPrimap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(data_MateriaPrimaP)).BeginInit();
            groupBox_MateriaPrimap.SuspendLayout();
            tab_ProductoElaborado.SuspendLayout();
            groupBox_ListaProductoElaborado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(data_ProductoElaborado)).BeginInit();
            groupBox_ProductoElaborado.SuspendLayout();
            tab_ProductoIndirecto.SuspendLayout();
            groupBox_ListaProductoIndirecto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(data_ProductoIndirecto)).BeginInit();
            groupBox_ProductoIndirecto.SuspendLayout();
            tab_ProductoTerminado.SuspendLayout();
            groupBox_ListaProductoTerminado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(data_ProductoTerminado)).BeginInit();
            groupBox_ProductoTerminado.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(pic_Proveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(errorProvider1)).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tab_MateriaPrima);
            tabControl1.Controls.Add(tab_MateriaPrimaP);
            tabControl1.Controls.Add(tab_ProductoElaborado);
            tabControl1.Controls.Add(tab_ProductoIndirecto);
            tabControl1.Controls.Add(tab_ProductoTerminado);
            tabControl1.Location = new System.Drawing.Point(10, 73);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(807, 420);
            tabControl1.TabIndex = 0;
            // 
            // tab_MateriaPrima
            // 
            tab_MateriaPrima.BackColor = System.Drawing.SystemColors.Control;
            tab_MateriaPrima.Controls.Add(groupBox_ListaMateriaPrimam);
            tab_MateriaPrima.Controls.Add(groupBox_MateriaPrimam);
            tab_MateriaPrima.Location = new System.Drawing.Point(4, 22);
            tab_MateriaPrima.Name = "tab_MateriaPrima";
            tab_MateriaPrima.Padding = new System.Windows.Forms.Padding(3);
            tab_MateriaPrima.Size = new System.Drawing.Size(799, 394);
            tab_MateriaPrima.TabIndex = 0;
            tab_MateriaPrima.Text = "Materia prima";
            // 
            // groupBox_ListaMateriaPrimam
            // 
            groupBox_ListaMateriaPrimam.Controls.Add(data_MateriaPrima);
            groupBox_ListaMateriaPrimam.Location = new System.Drawing.Point(277, 34);
            groupBox_ListaMateriaPrimam.Name = "groupBox_ListaMateriaPrimam";
            groupBox_ListaMateriaPrimam.Size = new System.Drawing.Size(483, 327);
            groupBox_ListaMateriaPrimam.TabIndex = 82;
            groupBox_ListaMateriaPrimam.TabStop = false;
            groupBox_ListaMateriaPrimam.Text = "Lista de materia prima";
            // 
            // data_MateriaPrima
            // 
            data_MateriaPrima.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_MateriaPrima.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            Id_AlmacenMateriaPrimam,
            Id_Almacenm,
            Id_MateriaPrimam,
            Materia_Primam,
            Lotem,
            Existenciam,
            Precio_Compram,
            Precio_Ventam,
            Fecham});
            data_MateriaPrima.Location = new System.Drawing.Point(4, 16);
            data_MateriaPrima.Name = "data_MateriaPrima";
            data_MateriaPrima.Size = new System.Drawing.Size(474, 305);
            data_MateriaPrima.TabIndex = 0;
            data_MateriaPrima.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(data_MateriaPrima_MouseDoubleClick);
            // 
            // Id_AlmacenMateriaPrimam
            // 
            Id_AlmacenMateriaPrimam.HeaderText = "Id_AlmacenMateriaPrimam";
            Id_AlmacenMateriaPrimam.Name = "Id_AlmacenMateriaPrimam";
            Id_AlmacenMateriaPrimam.Visible = false;
            // 
            // Id_Almacenm
            // 
            Id_Almacenm.HeaderText = "Id_Almacen";
            Id_Almacenm.Name = "Id_Almacenm";
            Id_Almacenm.Visible = false;
            // 
            // Id_MateriaPrimam
            // 
            Id_MateriaPrimam.HeaderText = "Id_MateriaPrima";
            Id_MateriaPrimam.Name = "Id_MateriaPrimam";
            Id_MateriaPrimam.Visible = false;
            // 
            // Materia_Primam
            // 
            Materia_Primam.HeaderText = "Materia prima";
            Materia_Primam.Name = "Materia_Primam";
            // 
            // Lotem
            // 
            Lotem.HeaderText = "Lote";
            Lotem.Name = "Lotem";
            // 
            // Existenciam
            // 
            Existenciam.HeaderText = "Existencia";
            Existenciam.Name = "Existenciam";
            // 
            // Precio_Compram
            // 
            Precio_Compram.HeaderText = "Precio compra";
            Precio_Compram.Name = "Precio_Compram";
            // 
            // Precio_Ventam
            // 
            Precio_Ventam.HeaderText = "Precio venta";
            Precio_Ventam.Name = "Precio_Ventam";
            // 
            // Fecham
            // 
            Fecham.HeaderText = "Fecha";
            Fecham.Name = "Fecham";
            // 
            // groupBox_MateriaPrimam
            // 
            groupBox_MateriaPrimam.Controls.Add(lbl_Almacenm);
            groupBox_MateriaPrimam.Controls.Add(lbl_Fecham);
            groupBox_MateriaPrimam.Controls.Add(combo_Almacenm);
            groupBox_MateriaPrimam.Controls.Add(lbl_PrecioVentam);
            groupBox_MateriaPrimam.Controls.Add(comboBox_MateriaPrimam);
            groupBox_MateriaPrimam.Controls.Add(lbl_PrecioCompram);
            groupBox_MateriaPrimam.Controls.Add(txt_Lotem);
            groupBox_MateriaPrimam.Controls.Add(lbl_Existenciam);
            groupBox_MateriaPrimam.Controls.Add(txt_Existenciam);
            groupBox_MateriaPrimam.Controls.Add(lbl_Lotem);
            groupBox_MateriaPrimam.Controls.Add(txt_PrecioCompram);
            groupBox_MateriaPrimam.Controls.Add(lbl_MateriaPrima);
            groupBox_MateriaPrimam.Controls.Add(txt_PrecioVentam);
            groupBox_MateriaPrimam.Controls.Add(dateTime_MateriaPrimam);
            groupBox_MateriaPrimam.Location = new System.Drawing.Point(39, 34);
            groupBox_MateriaPrimam.Name = "groupBox_MateriaPrimam";
            groupBox_MateriaPrimam.Size = new System.Drawing.Size(232, 327);
            groupBox_MateriaPrimam.TabIndex = 83;
            groupBox_MateriaPrimam.TabStop = false;
            groupBox_MateriaPrimam.Text = "Inventario de materia prima";
            // 
            // lbl_Almacenm
            // 
            lbl_Almacenm.AutoSize = true;
            lbl_Almacenm.Location = new System.Drawing.Point(16, 31);
            lbl_Almacenm.Name = "lbl_Almacenm";
            lbl_Almacenm.Size = new System.Drawing.Size(48, 13);
            lbl_Almacenm.TabIndex = 7;
            lbl_Almacenm.Text = "Almacén";
            // 
            // lbl_Fecham
            // 
            lbl_Fecham.AutoSize = true;
            lbl_Fecham.Location = new System.Drawing.Point(16, 270);
            lbl_Fecham.Name = "lbl_Fecham";
            lbl_Fecham.Size = new System.Drawing.Size(37, 13);
            lbl_Fecham.TabIndex = 13;
            lbl_Fecham.Text = "Fecha";
            // 
            // combo_Almacenm
            // 
            combo_Almacenm.FormattingEnabled = true;
            combo_Almacenm.Location = new System.Drawing.Point(19, 47);
            combo_Almacenm.Name = "combo_Almacenm";
            combo_Almacenm.Size = new System.Drawing.Size(121, 21);
            combo_Almacenm.TabIndex = 0;
            // 
            // lbl_PrecioVentam
            // 
            lbl_PrecioVentam.AutoSize = true;
            lbl_PrecioVentam.Location = new System.Drawing.Point(16, 228);
            lbl_PrecioVentam.Name = "lbl_PrecioVentam";
            lbl_PrecioVentam.Size = new System.Drawing.Size(67, 13);
            lbl_PrecioVentam.TabIndex = 12;
            lbl_PrecioVentam.Text = "Precio venta";
            // 
            // comboBox_MateriaPrimam
            // 
            comboBox_MateriaPrimam.FormattingEnabled = true;
            comboBox_MateriaPrimam.Location = new System.Drawing.Point(19, 87);
            comboBox_MateriaPrimam.Name = "comboBox_MateriaPrimam";
            comboBox_MateriaPrimam.Size = new System.Drawing.Size(121, 21);
            comboBox_MateriaPrimam.TabIndex = 1;
            // 
            // lbl_PrecioCompram
            // 
            lbl_PrecioCompram.AutoSize = true;
            lbl_PrecioCompram.Location = new System.Drawing.Point(16, 189);
            lbl_PrecioCompram.Name = "lbl_PrecioCompram";
            lbl_PrecioCompram.Size = new System.Drawing.Size(75, 13);
            lbl_PrecioCompram.TabIndex = 11;
            lbl_PrecioCompram.Text = "Precio compra";
            // 
            // txt_Lotem
            // 
            txt_Lotem.Location = new System.Drawing.Point(19, 127);
            txt_Lotem.Name = "txt_Lotem";
            txt_Lotem.Size = new System.Drawing.Size(100, 20);
            txt_Lotem.TabIndex = 2;
            // 
            // lbl_Existenciam
            // 
            lbl_Existenciam.AutoSize = true;
            lbl_Existenciam.Location = new System.Drawing.Point(16, 150);
            lbl_Existenciam.Name = "lbl_Existenciam";
            lbl_Existenciam.Size = new System.Drawing.Size(55, 13);
            lbl_Existenciam.TabIndex = 10;
            lbl_Existenciam.Text = "Existencia";
            // 
            // txt_Existenciam
            // 
            txt_Existenciam.Location = new System.Drawing.Point(19, 166);
            txt_Existenciam.Name = "txt_Existenciam";
            txt_Existenciam.Size = new System.Drawing.Size(100, 20);
            txt_Existenciam.TabIndex = 3;
            // 
            // lbl_Lotem
            // 
            lbl_Lotem.AutoSize = true;
            lbl_Lotem.Location = new System.Drawing.Point(16, 111);
            lbl_Lotem.Name = "lbl_Lotem";
            lbl_Lotem.Size = new System.Drawing.Size(28, 13);
            lbl_Lotem.TabIndex = 9;
            lbl_Lotem.Text = "Lote";
            // 
            // txt_PrecioCompram
            // 
            txt_PrecioCompram.Location = new System.Drawing.Point(19, 205);
            txt_PrecioCompram.Name = "txt_PrecioCompram";
            txt_PrecioCompram.Size = new System.Drawing.Size(100, 20);
            txt_PrecioCompram.TabIndex = 4;
            txt_PrecioCompram.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txt_PrecioCompram_KeyPress);
            // 
            // lbl_MateriaPrima
            // 
            lbl_MateriaPrima.AutoSize = true;
            lbl_MateriaPrima.Location = new System.Drawing.Point(16, 71);
            lbl_MateriaPrima.Name = "lbl_MateriaPrima";
            lbl_MateriaPrima.Size = new System.Drawing.Size(70, 13);
            lbl_MateriaPrima.TabIndex = 8;
            lbl_MateriaPrima.Text = "Materia prima";
            // 
            // txt_PrecioVentam
            // 
            txt_PrecioVentam.Location = new System.Drawing.Point(19, 247);
            txt_PrecioVentam.Name = "txt_PrecioVentam";
            txt_PrecioVentam.Size = new System.Drawing.Size(100, 20);
            txt_PrecioVentam.TabIndex = 5;
            txt_PrecioVentam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txt_PrecioVentam_KeyPress);
            // 
            // dateTime_MateriaPrimam
            // 
            dateTime_MateriaPrimam.Location = new System.Drawing.Point(19, 286);
            dateTime_MateriaPrimam.Name = "dateTime_MateriaPrimam";
            dateTime_MateriaPrimam.Size = new System.Drawing.Size(200, 20);
            dateTime_MateriaPrimam.TabIndex = 6;
            // 
            // tab_MateriaPrimaP
            // 
            tab_MateriaPrimaP.BackColor = System.Drawing.SystemColors.Control;
            tab_MateriaPrimaP.Controls.Add(groupBox_ListaMateriaPrimap);
            tab_MateriaPrimaP.Controls.Add(groupBox_MateriaPrimap);
            tab_MateriaPrimaP.Location = new System.Drawing.Point(4, 22);
            tab_MateriaPrimaP.Name = "tab_MateriaPrimaP";
            tab_MateriaPrimaP.Padding = new System.Windows.Forms.Padding(3);
            tab_MateriaPrimaP.Size = new System.Drawing.Size(799, 394);
            tab_MateriaPrimaP.TabIndex = 1;
            tab_MateriaPrimaP.Text = "Materia prima sin rebaba";
            // 
            // groupBox_ListaMateriaPrimap
            // 
            groupBox_ListaMateriaPrimap.Controls.Add(data_MateriaPrimaP);
            groupBox_ListaMateriaPrimap.Location = new System.Drawing.Point(277, 34);
            groupBox_ListaMateriaPrimap.Name = "groupBox_ListaMateriaPrimap";
            groupBox_ListaMateriaPrimap.Size = new System.Drawing.Size(483, 327);
            groupBox_ListaMateriaPrimap.TabIndex = 82;
            groupBox_ListaMateriaPrimap.TabStop = false;
            groupBox_ListaMateriaPrimap.Text = "Lista de materia prima";
            // 
            // data_MateriaPrimaP
            // 
            data_MateriaPrimaP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_MateriaPrimaP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            Id_AlmacenMateriaPrimaP,
            Id_MateriaPrimaP,
            Id_Almacenp,
            MateriaPrimaP,
            Lotep,
            Existenciap,
            Precio_Comprap,
            Precio_Ventap,
            Fechap});
            data_MateriaPrimaP.Location = new System.Drawing.Point(4, 16);
            data_MateriaPrimaP.Name = "data_MateriaPrimaP";
            data_MateriaPrimaP.Size = new System.Drawing.Size(474, 305);
            data_MateriaPrimaP.TabIndex = 0;
            data_MateriaPrimaP.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(data_MateriaPrimaP_MouseDoubleClick);
            // 
            // Id_AlmacenMateriaPrimaP
            // 
            Id_AlmacenMateriaPrimaP.HeaderText = "Id_AlmacenMateriaPrimaP";
            Id_AlmacenMateriaPrimaP.Name = "Id_AlmacenMateriaPrimaP";
            Id_AlmacenMateriaPrimaP.Visible = false;
            // 
            // Id_MateriaPrimaP
            // 
            Id_MateriaPrimaP.HeaderText = "Id_MateriaPrimaP";
            Id_MateriaPrimaP.Name = "Id_MateriaPrimaP";
            Id_MateriaPrimaP.Visible = false;
            // 
            // Id_Almacenp
            // 
            Id_Almacenp.HeaderText = "Id_Almacenp";
            Id_Almacenp.Name = "Id_Almacenp";
            Id_Almacenp.Visible = false;
            // 
            // MateriaPrimaP
            // 
            MateriaPrimaP.HeaderText = "Materia prima";
            MateriaPrimaP.Name = "MateriaPrimaP";
            // 
            // Lotep
            // 
            Lotep.HeaderText = "Lote";
            Lotep.Name = "Lotep";
            // 
            // Existenciap
            // 
            Existenciap.HeaderText = "Existencia";
            Existenciap.Name = "Existenciap";
            // 
            // Precio_Comprap
            // 
            Precio_Comprap.HeaderText = "Precio compra";
            Precio_Comprap.Name = "Precio_Comprap";
            // 
            // Precio_Ventap
            // 
            Precio_Ventap.HeaderText = "Precio venta";
            Precio_Ventap.Name = "Precio_Ventap";
            // 
            // Fechap
            // 
            Fechap.HeaderText = "Fecha";
            Fechap.Name = "Fechap";
            // 
            // groupBox_MateriaPrimap
            // 
            groupBox_MateriaPrimap.Controls.Add(lbl_Almacenp);
            groupBox_MateriaPrimap.Controls.Add(lbl_Fechap);
            groupBox_MateriaPrimap.Controls.Add(combo_Almacenp);
            groupBox_MateriaPrimap.Controls.Add(lbl_PrecioVentaP);
            groupBox_MateriaPrimap.Controls.Add(comboBox_MateriaPrimap);
            groupBox_MateriaPrimap.Controls.Add(lbl_PrecioComprap);
            groupBox_MateriaPrimap.Controls.Add(txt_Lotep);
            groupBox_MateriaPrimap.Controls.Add(lbl_Existenciap);
            groupBox_MateriaPrimap.Controls.Add(txt_Exisnteciap);
            groupBox_MateriaPrimap.Controls.Add(lbl_Lotep);
            groupBox_MateriaPrimap.Controls.Add(txt_PrecioComprap);
            groupBox_MateriaPrimap.Controls.Add(lbl_MateriaPrimaP);
            groupBox_MateriaPrimap.Controls.Add(txt_PrecioVentap);
            groupBox_MateriaPrimap.Controls.Add(dateTime_MateriaPrimap);
            groupBox_MateriaPrimap.Location = new System.Drawing.Point(39, 34);
            groupBox_MateriaPrimap.Name = "groupBox_MateriaPrimap";
            groupBox_MateriaPrimap.Size = new System.Drawing.Size(232, 327);
            groupBox_MateriaPrimap.TabIndex = 83;
            groupBox_MateriaPrimap.TabStop = false;
            groupBox_MateriaPrimap.Text = "Inventario de materia prima";
            // 
            // lbl_Almacenp
            // 
            lbl_Almacenp.AutoSize = true;
            lbl_Almacenp.Location = new System.Drawing.Point(16, 31);
            lbl_Almacenp.Name = "lbl_Almacenp";
            lbl_Almacenp.Size = new System.Drawing.Size(48, 13);
            lbl_Almacenp.TabIndex = 7;
            lbl_Almacenp.Text = "Almacén";
            // 
            // lbl_Fechap
            // 
            lbl_Fechap.AutoSize = true;
            lbl_Fechap.Location = new System.Drawing.Point(16, 270);
            lbl_Fechap.Name = "lbl_Fechap";
            lbl_Fechap.Size = new System.Drawing.Size(37, 13);
            lbl_Fechap.TabIndex = 13;
            lbl_Fechap.Text = "Fecha";
            // 
            // combo_Almacenp
            // 
            combo_Almacenp.FormattingEnabled = true;
            combo_Almacenp.Location = new System.Drawing.Point(19, 47);
            combo_Almacenp.Name = "combo_Almacenp";
            combo_Almacenp.Size = new System.Drawing.Size(121, 21);
            combo_Almacenp.TabIndex = 0;
            // 
            // lbl_PrecioVentaP
            // 
            lbl_PrecioVentaP.AutoSize = true;
            lbl_PrecioVentaP.Location = new System.Drawing.Point(16, 228);
            lbl_PrecioVentaP.Name = "lbl_PrecioVentaP";
            lbl_PrecioVentaP.Size = new System.Drawing.Size(67, 13);
            lbl_PrecioVentaP.TabIndex = 12;
            lbl_PrecioVentaP.Text = "Precio venta";
            // 
            // comboBox_MateriaPrimap
            // 
            comboBox_MateriaPrimap.FormattingEnabled = true;
            comboBox_MateriaPrimap.Location = new System.Drawing.Point(19, 87);
            comboBox_MateriaPrimap.Name = "comboBox_MateriaPrimap";
            comboBox_MateriaPrimap.Size = new System.Drawing.Size(121, 21);
            comboBox_MateriaPrimap.TabIndex = 1;
            // 
            // lbl_PrecioComprap
            // 
            lbl_PrecioComprap.AutoSize = true;
            lbl_PrecioComprap.Location = new System.Drawing.Point(16, 189);
            lbl_PrecioComprap.Name = "lbl_PrecioComprap";
            lbl_PrecioComprap.Size = new System.Drawing.Size(75, 13);
            lbl_PrecioComprap.TabIndex = 11;
            lbl_PrecioComprap.Text = "Precio compra";
            // 
            // txt_Lotep
            // 
            txt_Lotep.Location = new System.Drawing.Point(19, 127);
            txt_Lotep.Name = "txt_Lotep";
            txt_Lotep.Size = new System.Drawing.Size(100, 20);
            txt_Lotep.TabIndex = 2;
            // 
            // lbl_Existenciap
            // 
            lbl_Existenciap.AutoSize = true;
            lbl_Existenciap.Location = new System.Drawing.Point(16, 150);
            lbl_Existenciap.Name = "lbl_Existenciap";
            lbl_Existenciap.Size = new System.Drawing.Size(55, 13);
            lbl_Existenciap.TabIndex = 10;
            lbl_Existenciap.Text = "Existencia";
            // 
            // txt_Exisnteciap
            // 
            txt_Exisnteciap.Location = new System.Drawing.Point(19, 166);
            txt_Exisnteciap.Name = "txt_Exisnteciap";
            txt_Exisnteciap.Size = new System.Drawing.Size(100, 20);
            txt_Exisnteciap.TabIndex = 3;
            // 
            // lbl_Lotep
            // 
            lbl_Lotep.AutoSize = true;
            lbl_Lotep.Location = new System.Drawing.Point(16, 111);
            lbl_Lotep.Name = "lbl_Lotep";
            lbl_Lotep.Size = new System.Drawing.Size(28, 13);
            lbl_Lotep.TabIndex = 9;
            lbl_Lotep.Text = "Lote";
            // 
            // txt_PrecioComprap
            // 
            txt_PrecioComprap.Location = new System.Drawing.Point(19, 205);
            txt_PrecioComprap.Name = "txt_PrecioComprap";
            txt_PrecioComprap.Size = new System.Drawing.Size(100, 20);
            txt_PrecioComprap.TabIndex = 4;
            txt_PrecioComprap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txt_PrecioComprap_KeyPress);
            // 
            // lbl_MateriaPrimaP
            // 
            lbl_MateriaPrimaP.AutoSize = true;
            lbl_MateriaPrimaP.Location = new System.Drawing.Point(16, 71);
            lbl_MateriaPrimaP.Name = "lbl_MateriaPrimaP";
            lbl_MateriaPrimaP.Size = new System.Drawing.Size(70, 13);
            lbl_MateriaPrimaP.TabIndex = 8;
            lbl_MateriaPrimaP.Text = "Materia prima";
            // 
            // txt_PrecioVentap
            // 
            txt_PrecioVentap.Location = new System.Drawing.Point(19, 247);
            txt_PrecioVentap.Name = "txt_PrecioVentap";
            txt_PrecioVentap.Size = new System.Drawing.Size(100, 20);
            txt_PrecioVentap.TabIndex = 5;
            txt_PrecioVentap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txt_PrecioVentap_KeyPress);
            // 
            // dateTime_MateriaPrimap
            // 
            dateTime_MateriaPrimap.Location = new System.Drawing.Point(19, 286);
            dateTime_MateriaPrimap.Name = "dateTime_MateriaPrimap";
            dateTime_MateriaPrimap.Size = new System.Drawing.Size(200, 20);
            dateTime_MateriaPrimap.TabIndex = 6;
            // 
            // tab_ProductoElaborado
            // 
            tab_ProductoElaborado.BackColor = System.Drawing.SystemColors.Control;
            tab_ProductoElaborado.Controls.Add(groupBox_ListaProductoElaborado);
            tab_ProductoElaborado.Controls.Add(groupBox_ProductoElaborado);
            tab_ProductoElaborado.Location = new System.Drawing.Point(4, 22);
            tab_ProductoElaborado.Name = "tab_ProductoElaborado";
            tab_ProductoElaborado.Padding = new System.Windows.Forms.Padding(3);
            tab_ProductoElaborado.Size = new System.Drawing.Size(799, 394);
            tab_ProductoElaborado.TabIndex = 2;
            tab_ProductoElaborado.Text = "Producto elaborado";
            // 
            // groupBox_ListaProductoElaborado
            // 
            groupBox_ListaProductoElaborado.Controls.Add(data_ProductoElaborado);
            groupBox_ListaProductoElaborado.Location = new System.Drawing.Point(277, 34);
            groupBox_ListaProductoElaborado.Name = "groupBox_ListaProductoElaborado";
            groupBox_ListaProductoElaborado.Size = new System.Drawing.Size(483, 327);
            groupBox_ListaProductoElaborado.TabIndex = 82;
            groupBox_ListaProductoElaborado.TabStop = false;
            groupBox_ListaProductoElaborado.Text = "Lista de producto elaborado";
            // 
            // data_ProductoElaborado
            // 
            data_ProductoElaborado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_ProductoElaborado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            Id_AlmacenProductoElaborado,
            Id_Almacene,
            Id_ProductoElaborado,
            Producto,
            Lotee,
            Existenciae,
            Precio_Comprae,
            Precio_Ventae,
            Fechae});
            data_ProductoElaborado.Location = new System.Drawing.Point(4, 16);
            data_ProductoElaborado.Name = "data_ProductoElaborado";
            data_ProductoElaborado.Size = new System.Drawing.Size(474, 305);
            data_ProductoElaborado.TabIndex = 0;
            data_ProductoElaborado.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(data_ProductoElaborado_MouseDoubleClick);
            // 
            // Id_AlmacenProductoElaborado
            // 
            Id_AlmacenProductoElaborado.HeaderText = "Id_AlmacenProductoElaborado";
            Id_AlmacenProductoElaborado.Name = "Id_AlmacenProductoElaborado";
            Id_AlmacenProductoElaborado.Visible = false;
            // 
            // Id_Almacene
            // 
            Id_Almacene.HeaderText = "Id_Almacene";
            Id_Almacene.Name = "Id_Almacene";
            Id_Almacene.Visible = false;
            // 
            // Id_ProductoElaborado
            // 
            Id_ProductoElaborado.HeaderText = "Id_ProductoElaborado";
            Id_ProductoElaborado.Name = "Id_ProductoElaborado";
            Id_ProductoElaborado.Visible = false;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.Name = "Producto";
            // 
            // Lotee
            // 
            Lotee.HeaderText = "Lote";
            Lotee.Name = "Lotee";
            // 
            // Existenciae
            // 
            Existenciae.HeaderText = "Existencia";
            Existenciae.Name = "Existenciae";
            // 
            // Precio_Comprae
            // 
            Precio_Comprae.HeaderText = "Precio compra";
            Precio_Comprae.Name = "Precio_Comprae";
            // 
            // Precio_Ventae
            // 
            Precio_Ventae.HeaderText = "Precio venta";
            Precio_Ventae.Name = "Precio_Ventae";
            // 
            // Fechae
            // 
            Fechae.HeaderText = "Fecha";
            Fechae.Name = "Fechae";
            // 
            // groupBox_ProductoElaborado
            // 
            groupBox_ProductoElaborado.Controls.Add(lbl_Almacene);
            groupBox_ProductoElaborado.Controls.Add(lbl_Fechae);
            groupBox_ProductoElaborado.Controls.Add(combo_Almacene);
            groupBox_ProductoElaborado.Controls.Add(lbl_PrecioVentae);
            groupBox_ProductoElaborado.Controls.Add(comboBox_ProductoElaborado);
            groupBox_ProductoElaborado.Controls.Add(lbl_PrecioComprae);
            groupBox_ProductoElaborado.Controls.Add(txt_Lotee);
            groupBox_ProductoElaborado.Controls.Add(lbl_Existenciae);
            groupBox_ProductoElaborado.Controls.Add(txt_Existenciae);
            groupBox_ProductoElaborado.Controls.Add(lbl_Lotee);
            groupBox_ProductoElaborado.Controls.Add(txt_PrecioComprae);
            groupBox_ProductoElaborado.Controls.Add(lbl_ProductoElaborado);
            groupBox_ProductoElaborado.Controls.Add(txt_PrecioVentae);
            groupBox_ProductoElaborado.Controls.Add(dateTime_ProductoElaborado);
            groupBox_ProductoElaborado.Location = new System.Drawing.Point(39, 34);
            groupBox_ProductoElaborado.Name = "groupBox_ProductoElaborado";
            groupBox_ProductoElaborado.Size = new System.Drawing.Size(232, 327);
            groupBox_ProductoElaborado.TabIndex = 83;
            groupBox_ProductoElaborado.TabStop = false;
            groupBox_ProductoElaborado.Text = "Inventario de producto elaborado";
            // 
            // lbl_Almacene
            // 
            lbl_Almacene.AutoSize = true;
            lbl_Almacene.Location = new System.Drawing.Point(16, 31);
            lbl_Almacene.Name = "lbl_Almacene";
            lbl_Almacene.Size = new System.Drawing.Size(48, 13);
            lbl_Almacene.TabIndex = 7;
            lbl_Almacene.Text = "Almacén";
            // 
            // lbl_Fechae
            // 
            lbl_Fechae.AutoSize = true;
            lbl_Fechae.Location = new System.Drawing.Point(16, 270);
            lbl_Fechae.Name = "lbl_Fechae";
            lbl_Fechae.Size = new System.Drawing.Size(37, 13);
            lbl_Fechae.TabIndex = 13;
            lbl_Fechae.Text = "Fecha";
            // 
            // combo_Almacene
            // 
            combo_Almacene.FormattingEnabled = true;
            combo_Almacene.Location = new System.Drawing.Point(19, 47);
            combo_Almacene.Name = "combo_Almacene";
            combo_Almacene.Size = new System.Drawing.Size(121, 21);
            combo_Almacene.TabIndex = 0;
            // 
            // lbl_PrecioVentae
            // 
            lbl_PrecioVentae.AutoSize = true;
            lbl_PrecioVentae.Location = new System.Drawing.Point(16, 228);
            lbl_PrecioVentae.Name = "lbl_PrecioVentae";
            lbl_PrecioVentae.Size = new System.Drawing.Size(67, 13);
            lbl_PrecioVentae.TabIndex = 12;
            lbl_PrecioVentae.Text = "Precio venta";
            // 
            // comboBox_ProductoElaborado
            // 
            comboBox_ProductoElaborado.FormattingEnabled = true;
            comboBox_ProductoElaborado.Location = new System.Drawing.Point(19, 87);
            comboBox_ProductoElaborado.Name = "comboBox_ProductoElaborado";
            comboBox_ProductoElaborado.Size = new System.Drawing.Size(121, 21);
            comboBox_ProductoElaborado.TabIndex = 1;
            // 
            // lbl_PrecioComprae
            // 
            lbl_PrecioComprae.AutoSize = true;
            lbl_PrecioComprae.Location = new System.Drawing.Point(16, 189);
            lbl_PrecioComprae.Name = "lbl_PrecioComprae";
            lbl_PrecioComprae.Size = new System.Drawing.Size(75, 13);
            lbl_PrecioComprae.TabIndex = 11;
            lbl_PrecioComprae.Text = "Precio compra";
            // 
            // txt_Lotee
            // 
            txt_Lotee.Location = new System.Drawing.Point(19, 127);
            txt_Lotee.Name = "txt_Lotee";
            txt_Lotee.Size = new System.Drawing.Size(100, 20);
            txt_Lotee.TabIndex = 2;
            // 
            // lbl_Existenciae
            // 
            lbl_Existenciae.AutoSize = true;
            lbl_Existenciae.Location = new System.Drawing.Point(16, 150);
            lbl_Existenciae.Name = "lbl_Existenciae";
            lbl_Existenciae.Size = new System.Drawing.Size(55, 13);
            lbl_Existenciae.TabIndex = 10;
            lbl_Existenciae.Text = "Existencia";
            // 
            // txt_Existenciae
            // 
            txt_Existenciae.Location = new System.Drawing.Point(19, 166);
            txt_Existenciae.Name = "txt_Existenciae";
            txt_Existenciae.Size = new System.Drawing.Size(100, 20);
            txt_Existenciae.TabIndex = 3;
            // 
            // lbl_Lotee
            // 
            lbl_Lotee.AutoSize = true;
            lbl_Lotee.Location = new System.Drawing.Point(16, 111);
            lbl_Lotee.Name = "lbl_Lotee";
            lbl_Lotee.Size = new System.Drawing.Size(28, 13);
            lbl_Lotee.TabIndex = 9;
            lbl_Lotee.Text = "Lote";
            // 
            // txt_PrecioComprae
            // 
            txt_PrecioComprae.Location = new System.Drawing.Point(19, 205);
            txt_PrecioComprae.Name = "txt_PrecioComprae";
            txt_PrecioComprae.Size = new System.Drawing.Size(100, 20);
            txt_PrecioComprae.TabIndex = 4;
            txt_PrecioComprae.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txt_PrecioComprae_KeyPress);
            // 
            // lbl_ProductoElaborado
            // 
            lbl_ProductoElaborado.AutoSize = true;
            lbl_ProductoElaborado.Location = new System.Drawing.Point(16, 71);
            lbl_ProductoElaborado.Name = "lbl_ProductoElaborado";
            lbl_ProductoElaborado.Size = new System.Drawing.Size(110, 13);
            lbl_ProductoElaborado.TabIndex = 8;
            lbl_ProductoElaborado.Text = "Productos elaborados";
            // 
            // txt_PrecioVentae
            // 
            txt_PrecioVentae.Location = new System.Drawing.Point(19, 247);
            txt_PrecioVentae.Name = "txt_PrecioVentae";
            txt_PrecioVentae.Size = new System.Drawing.Size(100, 20);
            txt_PrecioVentae.TabIndex = 5;
            txt_PrecioVentae.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txt_PrecioVentae_KeyPress);
            // 
            // dateTime_ProductoElaborado
            // 
            dateTime_ProductoElaborado.Location = new System.Drawing.Point(19, 286);
            dateTime_ProductoElaborado.Name = "dateTime_ProductoElaborado";
            dateTime_ProductoElaborado.Size = new System.Drawing.Size(200, 20);
            dateTime_ProductoElaborado.TabIndex = 6;
            // 
            // tab_ProductoIndirecto
            // 
            tab_ProductoIndirecto.BackColor = System.Drawing.SystemColors.Control;
            tab_ProductoIndirecto.Controls.Add(groupBox_ListaProductoIndirecto);
            tab_ProductoIndirecto.Controls.Add(groupBox_ProductoIndirecto);
            tab_ProductoIndirecto.Location = new System.Drawing.Point(4, 22);
            tab_ProductoIndirecto.Name = "tab_ProductoIndirecto";
            tab_ProductoIndirecto.Padding = new System.Windows.Forms.Padding(3);
            tab_ProductoIndirecto.Size = new System.Drawing.Size(799, 394);
            tab_ProductoIndirecto.TabIndex = 3;
            tab_ProductoIndirecto.Text = "Producto indirecto";
            // 
            // groupBox_ListaProductoIndirecto
            // 
            groupBox_ListaProductoIndirecto.Controls.Add(data_ProductoIndirecto);
            groupBox_ListaProductoIndirecto.Location = new System.Drawing.Point(277, 34);
            groupBox_ListaProductoIndirecto.Name = "groupBox_ListaProductoIndirecto";
            groupBox_ListaProductoIndirecto.Size = new System.Drawing.Size(483, 327);
            groupBox_ListaProductoIndirecto.TabIndex = 82;
            groupBox_ListaProductoIndirecto.TabStop = false;
            groupBox_ListaProductoIndirecto.Text = "Lista de producto indirecto";
            // 
            // data_ProductoIndirecto
            // 
            data_ProductoIndirecto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_ProductoIndirecto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            Id_AlmacenProductoIndirecto,
            Id_Almaceni,
            Id_ProductoIndirecto,
            Productoi,
            Existenciai,
            Precio_CompraI,
            Precio_Ventai,
            Fechai});
            data_ProductoIndirecto.Location = new System.Drawing.Point(4, 16);
            data_ProductoIndirecto.Name = "data_ProductoIndirecto";
            data_ProductoIndirecto.Size = new System.Drawing.Size(474, 305);
            data_ProductoIndirecto.TabIndex = 0;
            data_ProductoIndirecto.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(data_ProductoIndirecto_MouseDoubleClick);
            // 
            // Id_AlmacenProductoIndirecto
            // 
            Id_AlmacenProductoIndirecto.HeaderText = "Id_AlmacenProductoIndirecto";
            Id_AlmacenProductoIndirecto.Name = "Id_AlmacenProductoIndirecto";
            Id_AlmacenProductoIndirecto.Visible = false;
            // 
            // Id_Almaceni
            // 
            Id_Almaceni.HeaderText = "Id_Almacen";
            Id_Almaceni.Name = "Id_Almaceni";
            Id_Almaceni.Visible = false;
            // 
            // Id_ProductoIndirecto
            // 
            Id_ProductoIndirecto.HeaderText = "Id_ProductoIndirecto";
            Id_ProductoIndirecto.Name = "Id_ProductoIndirecto";
            Id_ProductoIndirecto.Visible = false;
            // 
            // Productoi
            // 
            Productoi.HeaderText = "Producto";
            Productoi.Name = "Productoi";
            // 
            // Existenciai
            // 
            Existenciai.HeaderText = "Existencia";
            Existenciai.Name = "Existenciai";
            // 
            // Precio_CompraI
            // 
            Precio_CompraI.HeaderText = "Precio compra";
            Precio_CompraI.Name = "Precio_CompraI";
            // 
            // Precio_Ventai
            // 
            Precio_Ventai.HeaderText = "Precio venta";
            Precio_Ventai.Name = "Precio_Ventai";
            // 
            // Fechai
            // 
            Fechai.HeaderText = "Fecha";
            Fechai.Name = "Fechai";
            // 
            // groupBox_ProductoIndirecto
            // 
            groupBox_ProductoIndirecto.Controls.Add(lbl_Almaceni);
            groupBox_ProductoIndirecto.Controls.Add(lbl_FechaI);
            groupBox_ProductoIndirecto.Controls.Add(combo_Almaceni);
            groupBox_ProductoIndirecto.Controls.Add(lbl_PrecioVentaI);
            groupBox_ProductoIndirecto.Controls.Add(comboBox_ProductoIndirecto);
            groupBox_ProductoIndirecto.Controls.Add(lbl_PrecioCompraI);
            groupBox_ProductoIndirecto.Controls.Add(lbl_Existenciai);
            groupBox_ProductoIndirecto.Controls.Add(txt_Existenciai);
            groupBox_ProductoIndirecto.Controls.Add(txt_PrecioComprai);
            groupBox_ProductoIndirecto.Controls.Add(lbl_ProductoIndirecto);
            groupBox_ProductoIndirecto.Controls.Add(txt_PrecioVentai);
            groupBox_ProductoIndirecto.Controls.Add(dateTime_ProductoIndirecto);
            groupBox_ProductoIndirecto.Location = new System.Drawing.Point(39, 34);
            groupBox_ProductoIndirecto.Name = "groupBox_ProductoIndirecto";
            groupBox_ProductoIndirecto.Size = new System.Drawing.Size(232, 327);
            groupBox_ProductoIndirecto.TabIndex = 83;
            groupBox_ProductoIndirecto.TabStop = false;
            groupBox_ProductoIndirecto.Text = "Inventario de producto indirecto";
            // 
            // lbl_Almaceni
            // 
            lbl_Almaceni.AutoSize = true;
            lbl_Almaceni.Location = new System.Drawing.Point(16, 31);
            lbl_Almaceni.Name = "lbl_Almaceni";
            lbl_Almaceni.Size = new System.Drawing.Size(48, 13);
            lbl_Almaceni.TabIndex = 7;
            lbl_Almaceni.Text = "Almacén";
            // 
            // lbl_FechaI
            // 
            lbl_FechaI.AutoSize = true;
            lbl_FechaI.Location = new System.Drawing.Point(16, 233);
            lbl_FechaI.Name = "lbl_FechaI";
            lbl_FechaI.Size = new System.Drawing.Size(37, 13);
            lbl_FechaI.TabIndex = 13;
            lbl_FechaI.Text = "Fecha";
            // 
            // combo_Almaceni
            // 
            combo_Almaceni.FormattingEnabled = true;
            combo_Almaceni.Location = new System.Drawing.Point(19, 47);
            combo_Almaceni.Name = "combo_Almaceni";
            combo_Almaceni.Size = new System.Drawing.Size(121, 21);
            combo_Almaceni.TabIndex = 0;
            // 
            // lbl_PrecioVentaI
            // 
            lbl_PrecioVentaI.AutoSize = true;
            lbl_PrecioVentaI.Location = new System.Drawing.Point(16, 191);
            lbl_PrecioVentaI.Name = "lbl_PrecioVentaI";
            lbl_PrecioVentaI.Size = new System.Drawing.Size(67, 13);
            lbl_PrecioVentaI.TabIndex = 12;
            lbl_PrecioVentaI.Text = "Precio venta";
            // 
            // comboBox_ProductoIndirecto
            // 
            comboBox_ProductoIndirecto.FormattingEnabled = true;
            comboBox_ProductoIndirecto.Location = new System.Drawing.Point(19, 87);
            comboBox_ProductoIndirecto.Name = "comboBox_ProductoIndirecto";
            comboBox_ProductoIndirecto.Size = new System.Drawing.Size(121, 21);
            comboBox_ProductoIndirecto.TabIndex = 1;
            // 
            // lbl_PrecioCompraI
            // 
            lbl_PrecioCompraI.AutoSize = true;
            lbl_PrecioCompraI.Location = new System.Drawing.Point(16, 152);
            lbl_PrecioCompraI.Name = "lbl_PrecioCompraI";
            lbl_PrecioCompraI.Size = new System.Drawing.Size(75, 13);
            lbl_PrecioCompraI.TabIndex = 11;
            lbl_PrecioCompraI.Text = "Precio compra";
            // 
            // lbl_Existenciai
            // 
            lbl_Existenciai.AutoSize = true;
            lbl_Existenciai.Location = new System.Drawing.Point(16, 113);
            lbl_Existenciai.Name = "lbl_Existenciai";
            lbl_Existenciai.Size = new System.Drawing.Size(55, 13);
            lbl_Existenciai.TabIndex = 10;
            lbl_Existenciai.Text = "Existencia";
            // 
            // txt_Existenciai
            // 
            txt_Existenciai.Location = new System.Drawing.Point(19, 129);
            txt_Existenciai.Name = "txt_Existenciai";
            txt_Existenciai.Size = new System.Drawing.Size(100, 20);
            txt_Existenciai.TabIndex = 3;
            // 
            // txt_PrecioComprai
            // 
            txt_PrecioComprai.Location = new System.Drawing.Point(19, 168);
            txt_PrecioComprai.Name = "txt_PrecioComprai";
            txt_PrecioComprai.Size = new System.Drawing.Size(100, 20);
            txt_PrecioComprai.TabIndex = 4;
            txt_PrecioComprai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txt_PrecioComprai_KeyPress);
            // 
            // lbl_ProductoIndirecto
            // 
            lbl_ProductoIndirecto.AutoSize = true;
            lbl_ProductoIndirecto.Location = new System.Drawing.Point(16, 71);
            lbl_ProductoIndirecto.Name = "lbl_ProductoIndirecto";
            lbl_ProductoIndirecto.Size = new System.Drawing.Size(93, 13);
            lbl_ProductoIndirecto.TabIndex = 8;
            lbl_ProductoIndirecto.Text = "Producto indirecto";
            // 
            // txt_PrecioVentai
            // 
            txt_PrecioVentai.Location = new System.Drawing.Point(19, 210);
            txt_PrecioVentai.Name = "txt_PrecioVentai";
            txt_PrecioVentai.Size = new System.Drawing.Size(100, 20);
            txt_PrecioVentai.TabIndex = 5;
            txt_PrecioVentai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txt_PrecioVentai_KeyPress);
            // 
            // dateTime_ProductoIndirecto
            // 
            dateTime_ProductoIndirecto.Location = new System.Drawing.Point(19, 249);
            dateTime_ProductoIndirecto.Name = "dateTime_ProductoIndirecto";
            dateTime_ProductoIndirecto.Size = new System.Drawing.Size(200, 20);
            dateTime_ProductoIndirecto.TabIndex = 6;
            // 
            // tab_ProductoTerminado
            // 
            tab_ProductoTerminado.BackColor = System.Drawing.SystemColors.Control;
            tab_ProductoTerminado.Controls.Add(groupBox_ListaProductoTerminado);
            tab_ProductoTerminado.Controls.Add(groupBox_ProductoTerminado);
            tab_ProductoTerminado.Location = new System.Drawing.Point(4, 22);
            tab_ProductoTerminado.Name = "tab_ProductoTerminado";
            tab_ProductoTerminado.Padding = new System.Windows.Forms.Padding(3);
            tab_ProductoTerminado.Size = new System.Drawing.Size(799, 394);
            tab_ProductoTerminado.TabIndex = 4;
            tab_ProductoTerminado.Text = "Producto terminado";
            // 
            // groupBox_ListaProductoTerminado
            // 
            groupBox_ListaProductoTerminado.Controls.Add(data_ProductoTerminado);
            groupBox_ListaProductoTerminado.Location = new System.Drawing.Point(277, 34);
            groupBox_ListaProductoTerminado.Name = "groupBox_ListaProductoTerminado";
            groupBox_ListaProductoTerminado.Size = new System.Drawing.Size(483, 327);
            groupBox_ListaProductoTerminado.TabIndex = 82;
            groupBox_ListaProductoTerminado.TabStop = false;
            groupBox_ListaProductoTerminado.Text = "Lista de producto terminado";
            // 
            // data_ProductoTerminado
            // 
            data_ProductoTerminado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_ProductoTerminado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            Id_AlmacenProducto,
            Id_Almacent,
            Id_ProductoTerminado,
            Productot,
            Lotet,
            Existenciat,
            Precio_Comprat,
            Precio_Ventat,
            Descuento,
            Fechat});
            data_ProductoTerminado.Location = new System.Drawing.Point(4, 16);
            data_ProductoTerminado.Name = "data_ProductoTerminado";
            data_ProductoTerminado.Size = new System.Drawing.Size(474, 305);
            data_ProductoTerminado.TabIndex = 0;
            data_ProductoTerminado.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(data_ProductoTerminado_MouseDoubleClick);
            // 
            // Id_AlmacenProducto
            // 
            Id_AlmacenProducto.HeaderText = "Id_AlmacenProducto";
            Id_AlmacenProducto.Name = "Id_AlmacenProducto";
            Id_AlmacenProducto.Visible = false;
            // 
            // Id_Almacent
            // 
            Id_Almacent.HeaderText = "Id_Almacen";
            Id_Almacent.Name = "Id_Almacent";
            Id_Almacent.Visible = false;
            // 
            // Id_ProductoTerminado
            // 
            Id_ProductoTerminado.HeaderText = "Id_ProductoTerminado";
            Id_ProductoTerminado.Name = "Id_ProductoTerminado";
            Id_ProductoTerminado.Visible = false;
            // 
            // Productot
            // 
            Productot.HeaderText = "Producto";
            Productot.Name = "Productot";
            // 
            // Lotet
            // 
            Lotet.HeaderText = "Lote";
            Lotet.Name = "Lotet";
            // 
            // Existenciat
            // 
            Existenciat.HeaderText = "Existencia";
            Existenciat.Name = "Existenciat";
            // 
            // Precio_Comprat
            // 
            Precio_Comprat.HeaderText = "Precio compra";
            Precio_Comprat.Name = "Precio_Comprat";
            // 
            // Precio_Ventat
            // 
            Precio_Ventat.HeaderText = "Precio venta";
            Precio_Ventat.Name = "Precio_Ventat";
            // 
            // Descuento
            // 
            Descuento.HeaderText = "Descuento";
            Descuento.Name = "Descuento";
            // 
            // Fechat
            // 
            Fechat.HeaderText = "Fecha";
            Fechat.Name = "Fechat";
            // 
            // groupBox_ProductoTerminado
            // 
            groupBox_ProductoTerminado.Controls.Add(lbl_Descuentot);
            groupBox_ProductoTerminado.Controls.Add(txt_Descuento);
            groupBox_ProductoTerminado.Controls.Add(lbl_Almacent);
            groupBox_ProductoTerminado.Controls.Add(lbl_Fechat);
            groupBox_ProductoTerminado.Controls.Add(combo_Almacent);
            groupBox_ProductoTerminado.Controls.Add(lbl_PrecioVentat);
            groupBox_ProductoTerminado.Controls.Add(comboBox_ProductoTerminado);
            groupBox_ProductoTerminado.Controls.Add(lbl_PrecioComprat);
            groupBox_ProductoTerminado.Controls.Add(txt_Lotet);
            groupBox_ProductoTerminado.Controls.Add(lbl_Existenciat);
            groupBox_ProductoTerminado.Controls.Add(txt_Existenciat);
            groupBox_ProductoTerminado.Controls.Add(lbl_Lotet);
            groupBox_ProductoTerminado.Controls.Add(txt_PrecioComprat);
            groupBox_ProductoTerminado.Controls.Add(lbl_Producto);
            groupBox_ProductoTerminado.Controls.Add(txt_PrecioVentat);
            groupBox_ProductoTerminado.Controls.Add(dateTime_ProductoTerminado);
            groupBox_ProductoTerminado.Location = new System.Drawing.Point(39, 34);
            groupBox_ProductoTerminado.Name = "groupBox_ProductoTerminado";
            groupBox_ProductoTerminado.Size = new System.Drawing.Size(232, 341);
            groupBox_ProductoTerminado.TabIndex = 83;
            groupBox_ProductoTerminado.TabStop = false;
            groupBox_ProductoTerminado.Text = "Inventario de producto terminado";
            // 
            // lbl_Descuentot
            // 
            lbl_Descuentot.AutoSize = true;
            lbl_Descuentot.Location = new System.Drawing.Point(16, 254);
            lbl_Descuentot.Name = "lbl_Descuentot";
            lbl_Descuentot.Size = new System.Drawing.Size(59, 13);
            lbl_Descuentot.TabIndex = 15;
            lbl_Descuentot.Text = "Descuento";
            // 
            // txt_Descuento
            // 
            txt_Descuento.Location = new System.Drawing.Point(19, 272);
            txt_Descuento.Name = "txt_Descuento";
            txt_Descuento.Size = new System.Drawing.Size(100, 20);
            txt_Descuento.TabIndex = 14;
            txt_Descuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txt_Descuento_KeyPress);
            // 
            // lbl_Almacent
            // 
            lbl_Almacent.AutoSize = true;
            lbl_Almacent.Location = new System.Drawing.Point(16, 17);
            lbl_Almacent.Name = "lbl_Almacent";
            lbl_Almacent.Size = new System.Drawing.Size(48, 13);
            lbl_Almacent.TabIndex = 7;
            lbl_Almacent.Text = "Almacén";
            // 
            // lbl_Fechat
            // 
            lbl_Fechat.AutoSize = true;
            lbl_Fechat.Location = new System.Drawing.Point(16, 293);
            lbl_Fechat.Name = "lbl_Fechat";
            lbl_Fechat.Size = new System.Drawing.Size(37, 13);
            lbl_Fechat.TabIndex = 13;
            lbl_Fechat.Text = "Fecha";
            // 
            // combo_Almacent
            // 
            combo_Almacent.FormattingEnabled = true;
            combo_Almacent.Location = new System.Drawing.Point(19, 33);
            combo_Almacent.Name = "combo_Almacent";
            combo_Almacent.Size = new System.Drawing.Size(121, 21);
            combo_Almacent.TabIndex = 0;
            // 
            // lbl_PrecioVentat
            // 
            lbl_PrecioVentat.AutoSize = true;
            lbl_PrecioVentat.Location = new System.Drawing.Point(16, 214);
            lbl_PrecioVentat.Name = "lbl_PrecioVentat";
            lbl_PrecioVentat.Size = new System.Drawing.Size(67, 13);
            lbl_PrecioVentat.TabIndex = 12;
            lbl_PrecioVentat.Text = "Precio venta";
            // 
            // comboBox_ProductoTerminado
            // 
            comboBox_ProductoTerminado.FormattingEnabled = true;
            comboBox_ProductoTerminado.Location = new System.Drawing.Point(19, 73);
            comboBox_ProductoTerminado.Name = "comboBox_ProductoTerminado";
            comboBox_ProductoTerminado.Size = new System.Drawing.Size(121, 21);
            comboBox_ProductoTerminado.TabIndex = 1;
            // 
            // lbl_PrecioComprat
            // 
            lbl_PrecioComprat.AutoSize = true;
            lbl_PrecioComprat.Location = new System.Drawing.Point(16, 175);
            lbl_PrecioComprat.Name = "lbl_PrecioComprat";
            lbl_PrecioComprat.Size = new System.Drawing.Size(75, 13);
            lbl_PrecioComprat.TabIndex = 11;
            lbl_PrecioComprat.Text = "Precio compra";
            // 
            // txt_Lotet
            // 
            txt_Lotet.Location = new System.Drawing.Point(19, 113);
            txt_Lotet.Name = "txt_Lotet";
            txt_Lotet.Size = new System.Drawing.Size(100, 20);
            txt_Lotet.TabIndex = 2;
            // 
            // lbl_Existenciat
            // 
            lbl_Existenciat.AutoSize = true;
            lbl_Existenciat.Location = new System.Drawing.Point(16, 136);
            lbl_Existenciat.Name = "lbl_Existenciat";
            lbl_Existenciat.Size = new System.Drawing.Size(55, 13);
            lbl_Existenciat.TabIndex = 10;
            lbl_Existenciat.Text = "Existencia";
            // 
            // txt_Existenciat
            // 
            txt_Existenciat.Location = new System.Drawing.Point(19, 152);
            txt_Existenciat.Name = "txt_Existenciat";
            txt_Existenciat.Size = new System.Drawing.Size(100, 20);
            txt_Existenciat.TabIndex = 3;
            // 
            // lbl_Lotet
            // 
            lbl_Lotet.AutoSize = true;
            lbl_Lotet.Location = new System.Drawing.Point(16, 97);
            lbl_Lotet.Name = "lbl_Lotet";
            lbl_Lotet.Size = new System.Drawing.Size(28, 13);
            lbl_Lotet.TabIndex = 9;
            lbl_Lotet.Text = "Lote";
            // 
            // txt_PrecioComprat
            // 
            txt_PrecioComprat.Location = new System.Drawing.Point(19, 191);
            txt_PrecioComprat.Name = "txt_PrecioComprat";
            txt_PrecioComprat.Size = new System.Drawing.Size(100, 20);
            txt_PrecioComprat.TabIndex = 4;
            txt_PrecioComprat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txt_PrecioComprat_KeyPress);
            // 
            // lbl_Producto
            // 
            lbl_Producto.AutoSize = true;
            lbl_Producto.Location = new System.Drawing.Point(16, 57);
            lbl_Producto.Name = "lbl_Producto";
            lbl_Producto.Size = new System.Drawing.Size(50, 13);
            lbl_Producto.TabIndex = 8;
            lbl_Producto.Text = "Producto";
            // 
            // txt_PrecioVentat
            // 
            txt_PrecioVentat.Location = new System.Drawing.Point(19, 233);
            txt_PrecioVentat.Name = "txt_PrecioVentat";
            txt_PrecioVentat.Size = new System.Drawing.Size(100, 20);
            txt_PrecioVentat.TabIndex = 5;
            txt_PrecioVentat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txt_PrecioVentat_KeyPress);
            // 
            // dateTime_ProductoTerminado
            // 
            dateTime_ProductoTerminado.Location = new System.Drawing.Point(19, 309);
            dateTime_ProductoTerminado.Name = "dateTime_ProductoTerminado";
            dateTime_ProductoTerminado.Size = new System.Drawing.Size(200, 20);
            dateTime_ProductoTerminado.TabIndex = 6;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(186)))), ((int)(((byte)(82)))));
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            archivoToolStripMenuItem,
            editarToolStripMenuItem,
            controlDeProductosToolStripMenuItem,
            ayudaToolStripMenuItem});
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(834, 24);
            menuStrip1.TabIndex = 78;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            nuevoToolStripMenuItem,
            abrirToolStripMenuItem,
            toolStripSeparator,
            guardarToolStripMenuItem,
            toolStripSeparator1,
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
            nuevoToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
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
            abrirToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            abrirToolStripMenuItem.Text = "&Abrir";
            abrirToolStripMenuItem.Click += new System.EventHandler(abrirToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new System.Drawing.Size(153, 6);
            // 
            // guardarToolStripMenuItem
            // 
            guardarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("guardarToolStripMenuItem.Image")));
            guardarToolStripMenuItem.Image = global::Shajobe.Properties.Resources.Guardar;
            guardarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            guardarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            guardarToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            guardarToolStripMenuItem.Text = "&Guardar";
            guardarToolStripMenuItem.Click += new System.EventHandler(guardarToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(153, 6);
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(153, 6);
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            salirToolStripMenuItem.Text = "&Salir";
            salirToolStripMenuItem.Click += new System.EventHandler(salirToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            toolStripSeparator3,
            modificarToolStripMenuItem,
            eliminarToolStripMenuItem});
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            editarToolStripMenuItem.Text = "&Editar";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new System.Drawing.Size(122, 6);
            // 
            // modificarToolStripMenuItem
            // 
            modificarToolStripMenuItem.Enabled = false;
            modificarToolStripMenuItem.Image = global::Shajobe.Properties.Resources.Modificar;
            modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            modificarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            modificarToolStripMenuItem.Text = "Modificar";
            modificarToolStripMenuItem.Click += new System.EventHandler(modificarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Enabled = false;
            eliminarToolStripMenuItem.Image = global::Shajobe.Properties.Resources.Borrar;
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            eliminarToolStripMenuItem.Text = "Eliminar";
            eliminarToolStripMenuItem.Click += new System.EventHandler(eliminarToolStripMenuItem_Click);
            // 
            // controlDeProductosToolStripMenuItem
            // 
            controlDeProductosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            nivelMaxMinToolStripMenuItem,
            ordenDePeladoToolStripMenuItem});
            controlDeProductosToolStripMenuItem.Name = "controlDeProductosToolStripMenuItem";
            controlDeProductosToolStripMenuItem.Size = new System.Drawing.Size(132, 20);
            controlDeProductosToolStripMenuItem.Text = "Control de productos";
            // 
            // nivelMaxMinToolStripMenuItem
            // 
            nivelMaxMinToolStripMenuItem.Image = global::Shajobe.Properties.Resources.Control_Inventario;
            nivelMaxMinToolStripMenuItem.Name = "nivelMaxMinToolStripMenuItem";
            nivelMaxMinToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            nivelMaxMinToolStripMenuItem.Text = "Nivel Max/Min";
            nivelMaxMinToolStripMenuItem.Click += new System.EventHandler(nivelMaxMinToolStripMenuItem_Click);
            // 
            // ordenDePeladoToolStripMenuItem
            // 
            ordenDePeladoToolStripMenuItem.Image = global::Shajobe.Properties.Resources.Caja;
            ordenDePeladoToolStripMenuItem.Name = "ordenDePeladoToolStripMenuItem";
            ordenDePeladoToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            ordenDePeladoToolStripMenuItem.Text = "Orden de pelado";
            ordenDePeladoToolStripMenuItem.Click += new System.EventHandler(ordenDePeladoToolStripMenuItem_Click);
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
            // pic_Proveedor
            // 
            pic_Proveedor.BackgroundImage = global::Shajobe.Properties.Resources.Inventario;
            pic_Proveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pic_Proveedor.Location = new System.Drawing.Point(732, 24);
            pic_Proveedor.Name = "pic_Proveedor";
            pic_Proveedor.Size = new System.Drawing.Size(85, 68);
            pic_Proveedor.TabIndex = 79;
            pic_Proveedor.TabStop = false;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Inventario
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(228)))), ((int)(((byte)(196)))));
            Icon = global::Shajobe.Properties.Resources.Inventario_ICO;
            ClientSize = new System.Drawing.Size(834, 511);
            Controls.Add(pic_Proveedor);
            Controls.Add(menuStrip1);
            Controls.Add(tabControl1);
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(840, 535);
            MinimumSize = new System.Drawing.Size(840, 535);
            Name = "Inventario";
            Text = "Inventario";
            Load += new System.EventHandler(Inventario_Load);
            tabControl1.ResumeLayout(false);
            tab_MateriaPrima.ResumeLayout(false);
            groupBox_ListaMateriaPrimam.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(data_MateriaPrima)).EndInit();
            groupBox_MateriaPrimam.ResumeLayout(false);
            groupBox_MateriaPrimam.PerformLayout();
            tab_MateriaPrimaP.ResumeLayout(false);
            groupBox_ListaMateriaPrimap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(data_MateriaPrimaP)).EndInit();
            groupBox_MateriaPrimap.ResumeLayout(false);
            groupBox_MateriaPrimap.PerformLayout();
            tab_ProductoElaborado.ResumeLayout(false);
            groupBox_ListaProductoElaborado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(data_ProductoElaborado)).EndInit();
            groupBox_ProductoElaborado.ResumeLayout(false);
            groupBox_ProductoElaborado.PerformLayout();
            tab_ProductoIndirecto.ResumeLayout(false);
            groupBox_ListaProductoIndirecto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(data_ProductoIndirecto)).EndInit();
            groupBox_ProductoIndirecto.ResumeLayout(false);
            groupBox_ProductoIndirecto.PerformLayout();
            tab_ProductoTerminado.ResumeLayout(false);
            groupBox_ListaProductoTerminado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(data_ProductoTerminado)).EndInit();
            groupBox_ProductoTerminado.ResumeLayout(false);
            groupBox_ProductoTerminado.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(pic_Proveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(errorProvider1)).EndInit();
            AnimateWindow(Handle, 350, AnimateWindowFlags.AW_CENTER);
            AnimateWindow(Handle, 350, AnimateWindowFlags.AW_CENTER | AnimateWindowFlags.AW_SLIDE);
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        #region Eventos
        //-------------------------------------------------------------
        //------------------Variables y Arreglos-----------------------
        //-------------------------------------------------------------
        private bool Espacios_Vacios = false;
        private TextBox[] Campos = new TextBox[4];
        private int Idp;//LO USO PARA OBTENER EL ID COMO RESULTADO DE LA BUSQUEDA
        //-------------------------------------------------------------
        //----------------Limpia y restablece controles----------------
        //-------------------------------------------------------------
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Limpiar()
        {
            //Obtengo que ficha o que control esta activa para poder limpiar dicho control
            string ficha = tabControl1.SelectedIndex.ToString();
            if (ficha == "0")
            {
                //LIMPIANDO CONTROLES
                comboBox_MateriaPrimam.ResetText();
                combo_Almacenm.ResetText();
                txt_Lotem.Clear();
                txt_Existenciam.Clear();
                txt_PrecioCompram.Clear();
                txt_PrecioVentam.Clear();
                errorProvider1.Clear();
                dateTime_MateriaPrimam.ResetText();
                data_MateriaPrima.Rows.Clear();
                Llenando_MateriaPrima();
                Llenando_AlmacenMateriaPrima();
                Llenando_DataGridViewMateriaPrima();
            }
            else if (ficha == "1")
            {
                //data_MateriaPrimaP.Rows.Clear();
                txt_Exisnteciap.Clear();
                txt_Lotep.Clear();
                txt_PrecioComprap.Clear();
                txt_PrecioVentap.Clear();
                errorProvider1.Clear();
                comboBox_MateriaPrimap.ResetText();
                combo_Almacenp.ResetText();
                dateTime_MateriaPrimap.ResetText();
                Llenando_MateriaPrimaP();
                Llenando_AlmacenMateriaPrimaP();
                Llenando_DataGridViewMateriaPrimaP();
            }
            else if (ficha == "2")
            {
                txt_Existenciae.Clear();
                txt_Lotee.Clear();
                txt_PrecioComprae.Clear();
                txt_PrecioVentae.Clear();
                errorProvider1.Clear();
                comboBox_ProductoElaborado.ResetText();
                combo_Almacene.ResetText();
                dateTime_ProductoElaborado.ResetText();
                Llenando_ProductoElaborado();
                Llenando_AlmacenMateriaPrimaE();
                Llenando_DataGridViewProductoElaborado();
            }
            else if (ficha == "3")
            {
                //data_ProductoIndirecto.Rows.Clear();
                txt_Existenciai.Clear();
                txt_PrecioComprai.Clear();
                txt_PrecioVentai.Clear();
                errorProvider1.Clear();
                comboBox_ProductoIndirecto.ResetText();
                combo_Almaceni.ResetText();
                dateTime_ProductoIndirecto.ResetText();
                Llenando_ProductoIndirecto();
                Llenando_AlmacenProductoIndirecto();
                Llenando_DataGridViewProductoIndirecto();
            }
            else if (ficha == "4")
            {
                txt_Existenciat.Clear();
                txt_PrecioComprat.Clear();
                txt_PrecioVentat.Clear();
                txt_Lotet.Clear();
                errorProvider1.Clear();
                combo_Almacent.ResetText();
                comboBox_ProductoTerminado.ResetText();
                dateTime_ProductoTerminado.ResetText();
                Llenando_AlmacenProductoTerminado();
                Llenando_DataGridViewProductoTerminado();
                Llenando_ProductoTerminado();
                txt_Descuento.Clear();

            }
            try
            {
                //Quito el panel de busqueda
                Controls.Remove(panel_Busqueda);
            }
            catch (Exception)
            {
                //En caso de que no existe todavia el panel de busqueda
                //omite la instrucción de quitar dicho control
            }
            try
            {
                //Quito el panel de busqueda
                Controls.Remove(panel_Niveles);
            }
            catch (Exception)
            {
                //En caso de que no existe todavia el panel de niveles
                //omite la instrucción de quitar dicho control
            }
            tabControl1.Visible = true;
            modificarToolStripMenuItem.Enabled = false;
            eliminarToolStripMenuItem.Enabled = false;
        }
        //-------------------------------------------------------------
        //----------------CONFIGURACION DE CONTROLES-------------------
        //-------------------------------------------------------------
        private void Inventario_Load(object sender, EventArgs e)
        {
            //Diseño de la forma
            Diseño_Forma();
            //Tab de Materia Prima
            Llenando_MateriaPrima();
            Llenando_AlmacenMateriaPrima();
            Llenando_DataGridViewMateriaPrima();
            //Tab de Materia PrimaP
            Llenando_MateriaPrimaP();
            Llenando_AlmacenMateriaPrimaP();
            Llenando_DataGridViewMateriaPrimaP();
            //Tab de Producto Elaborado
            Llenando_ProductoElaborado();
            Llenando_AlmacenMateriaPrimaE();
            Llenando_DataGridViewProductoElaborado();
            //Tab de Producto Indirecto
            Llenando_ProductoIndirecto();
            Llenando_AlmacenProductoIndirecto();
            Llenando_DataGridViewProductoIndirecto();
            //Tab de Producto Terminado
            Llenando_AlmacenProductoTerminado();
            Llenando_DataGridViewProductoTerminado();
            Llenando_ProductoTerminado();
            tabControl1.SendToBack();
        }
        #region Controles_Busqueda
        //Creando controles
        DataGridView data_resultado;
        TextBox txt_Busqueda;
        PictureBox pic_Lupa;
        Button bttn_Busqueda;
        Panel panel_Busqueda;
        Label lbl_Etiqueta;
        //Creando Columnas del DATAGRID
        DataGridViewTextBoxColumn Loteb;
        DataGridViewTextBoxColumn Nombreb;
        DataGridViewTextBoxColumn Idb;
        #endregion
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region Controles_Abrir
            //INICIALIZANDO CONTROLES
            panel_Busqueda = new System.Windows.Forms.Panel();
            txt_Busqueda = new System.Windows.Forms.TextBox();
            data_resultado = new System.Windows.Forms.DataGridView();
            pic_Lupa = new System.Windows.Forms.PictureBox();
            bttn_Busqueda = new System.Windows.Forms.Button();
            lbl_Etiqueta = new System.Windows.Forms.Label();
            //groupBoxfoto.SuspendLayout();
            //INICIALIZANDO COLUMNAS
            Loteb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Nombreb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Idb = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            Idb,
            Nombreb,
            Loteb});
            data_resultado.Location = new System.Drawing.Point(21, 136);
            data_resultado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            data_resultado.Name = "data_resultado";
            data_resultado.RowHeadersWidth = 25;
            data_resultado.RowTemplate.Height = 25;
            data_resultado.Size = new System.Drawing.Size(470, 150);
            data_resultado.TabIndex = 2;
            data_resultado.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(data_resultado_MouseDoubleClick);
            //
            // Descripcion
            // 
            Loteb.HeaderText = "Lote";
            Loteb.Name = "Loteb";
            // 
            // Nombre
            // 
            Nombreb.HeaderText = "Nombre";
            Nombreb.Name = "Nombreb";
            // 
            // Id
            // 
            Idb.HeaderText = "Id";
            Idb.Name = "Idb";
            Idb.Visible = false;
            // 
            // lbl_Etiqueta
            // 
            lbl_Etiqueta.AutoSize = true;
            lbl_Etiqueta.Location = new System.Drawing.Point(127, 26);
            lbl_Etiqueta.Name = "lbl_Etiqueta";
            lbl_Etiqueta.Size = new System.Drawing.Size(419, 13);
            lbl_Etiqueta.TabIndex = 3;
            lbl_Etiqueta.Text = "Escriba el nombre o lote del producto a buscar";
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
            panel_Busqueda.Location = new System.Drawing.Point(200, 127);
            panel_Busqueda.Name = "panel_Busqueda";
            panel_Busqueda.Size = new System.Drawing.Size(370, 321);
            panel_Busqueda.TabIndex = 35;
            panel_Busqueda.BringToFront();
            txt_Busqueda.Clear();
            data_resultado.Rows.Clear();
            Controls.Add(panel_Busqueda);
            panel_Busqueda.Visible = true;
            panel_Busqueda.Enabled = true;
            tabControl1.Visible = false;
            #endregion
            string ficha = tabControl1.SelectedIndex.ToString();
            #region Ficha0_Abrir
            if (ficha == "0")
            {
                //CARACTERISTICA DE AUTOCOMPLETADO EN TXT_BUSQUEDA
                txt_Busqueda.AutoCompleteCustomSource = Autocomplete1();
                txt_Busqueda.AutoCompleteMode = AutoCompleteMode.Suggest;
                txt_Busqueda.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            #endregion
            #region Ficha1_Abrir
            else if (ficha == "1")
            {
                //CARACTERISTICA DE AUTOCOMPLETADO EN TXT_BUSQUEDA
                txt_Busqueda.AutoCompleteCustomSource = Autocomplete2();
                txt_Busqueda.AutoCompleteMode = AutoCompleteMode.Suggest;
                txt_Busqueda.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            #endregion
            #region Ficha2_Abrir
            else if (ficha == "2")
            {
                //CARACTERISTICA DE AUTOCOMPLETADO EN TXT_BUSQUEDA
                txt_Busqueda.AutoCompleteCustomSource = Autocomplete3();
                txt_Busqueda.AutoCompleteMode = AutoCompleteMode.Suggest;
                txt_Busqueda.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            #endregion
            #region Ficha3_Abrir
            else if (ficha == "3")
            {
                //CARACTERISTICA DE AUTOCOMPLETADO EN TXT_BUSQUEDA
                txt_Busqueda.AutoCompleteCustomSource = Autocomplete4();
                txt_Busqueda.AutoCompleteMode = AutoCompleteMode.Suggest;
                txt_Busqueda.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            #endregion
            #region Ficha4_Abrir
            else if (ficha == "4")
            {
                //CARACTERISTICA DE AUTOCOMPLETADO EN TXT_BUSQUEDA
                txt_Busqueda.AutoCompleteCustomSource = Autocomplete5();
                txt_Busqueda.AutoCompleteMode = AutoCompleteMode.Suggest;
                txt_Busqueda.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            #endregion   
        }
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Obtengo que ficha o que control esta activa para poder limpiar dicho control
            OleDbConnection conexion = null;
            OleDbTransaction transaccion = null;
            string ficha = tabControl1.SelectedIndex.ToString();
            #region Ficha0_Guardar
            if (ficha == "0")
            {
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
                        OleDbCommand comando = new OleDbCommand("SP_AlmacenMateriaPrima_Alta", conexion, transaccion);
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.Clear();
                        comando.Parameters.AddWithValue("@Id_Almacen ", combo_Almacenm.SelectedIndex + 1);
                        comando.Parameters.AddWithValue("@Id_MateriaPrima ", comboBox_MateriaPrimam.SelectedIndex + 1);
                        comando.Parameters.AddWithValue("@Lote", txt_Lotem.Text);
                        comando.Parameters.AddWithValue("@Existencia", Convert.ToDecimal(txt_Existenciam.Text));
                        comando.Parameters.AddWithValue("@Precio_Compra", Convert.ToDecimal(txt_PrecioCompram.Text));
                        comando.Parameters.AddWithValue("@Precio_Venta", Convert.ToDecimal(txt_PrecioVentam.Text));
                        comando.Parameters.AddWithValue("@Fecha", dateTime_MateriaPrimam.Value);
                        comando.ExecuteNonQuery();
                        transaccion.Commit();
                        MessageBox.Show("Datos guardados con éxito", "Solicitud procesada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ha ocurrido un error inesperado", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        transaccion.Rollback();
                    }
                    finally
                    {
                        conexion.Close();
                    }
                }
            }
            #endregion
            #region Ficha1_Guardar
            else if (ficha == "1")
            {
                bool i = Verificar_CamposVaciosP();
                if (i == true)
                    MessageBox.Show("Inserta todos los datos marcados", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    try
                    {
                        conexion = new OleDbConnection(ObtenerString());
                        conexion.Open();
                        transaccion = conexion.BeginTransaction(System.Data.IsolationLevel.Serializable);
                        OleDbCommand comando = new OleDbCommand("SP_AlmacenMateriaPrimaP_Alta", conexion, transaccion);
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.Clear();
                        comando.Parameters.AddWithValue("@Id_Almacen ", combo_Almacenp.SelectedIndex + 1);
                        comando.Parameters.AddWithValue("@Id_MateriaPrima ", comboBox_MateriaPrimap.SelectedIndex + 1);
                        comando.Parameters.AddWithValue("@Lote", txt_Lotep.Text);
                        comando.Parameters.AddWithValue("@Existencia", txt_Exisnteciap.Text);
                        comando.Parameters.AddWithValue("@Precio_Compra", Convert.ToDecimal(txt_PrecioComprap.Text));
                        comando.Parameters.AddWithValue("@Precio_Venta", Convert.ToDecimal(txt_PrecioVentap.Text));
                        comando.Parameters.AddWithValue("@Fecha", dateTime_MateriaPrimap.Value);
                        comando.ExecuteNonQuery();
                        transaccion.Commit();
                        MessageBox.Show("Datos guardados con éxito", "Solicitud procesada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ha ocurrido un error inesperado", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        transaccion.Rollback();
                    }
                    finally
                    {
                        conexion.Close();
                    }
                }
            }
            #endregion
            #region Ficha2_Guardar
            else if (ficha == "2")
            {
                bool i = Verificar_CamposVaciosE();
                if (i == true)
                    MessageBox.Show("Inserta todos los datos marcados", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {

                    try
                    {
                        conexion = new OleDbConnection(ObtenerString());
                        conexion.Open();
                        transaccion = conexion.BeginTransaction(System.Data.IsolationLevel.Serializable);
                        OleDbCommand comando = new OleDbCommand("SP_AlmacenProductoElaborado_Alta", conexion, transaccion);
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.Clear();
                        comando.Parameters.AddWithValue("@Id_Almacen ", combo_Almacene.SelectedIndex + 1);
                        comando.Parameters.AddWithValue("@Id_ProductoElaborado ", comboBox_ProductoElaborado.SelectedIndex + 1);
                        comando.Parameters.AddWithValue("@Lote", txt_Lotee.Text);
                        comando.Parameters.AddWithValue("@Existencia", txt_Existenciae.Text);
                        comando.Parameters.AddWithValue("@Precio_Compra", txt_PrecioComprae.Text);
                        comando.Parameters.AddWithValue("@Precio_Venta", txt_PrecioVentae.Text);
                        comando.Parameters.AddWithValue("@Fecha", dateTime_ProductoElaborado.Value.Date);
                        comando.ExecuteNonQuery();
                        transaccion.Commit();
                        MessageBox.Show("Datos guardados con éxito", "Solicitud procesada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ha ocurrido un error inesperado", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        transaccion.Rollback();
                    }
                    finally
                    {
                        conexion.Close();
                    }
                }
            }
            #endregion
            #region Ficha3_Guardar
            else if (ficha == "3")
            {
                bool i = Verificar_CamposVaciosI();
                if (i == true)
                    MessageBox.Show("Inserta todos los datos marcados", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    try
                    {
                        conexion = new OleDbConnection(ObtenerString());
                        conexion.Open();
                        transaccion = conexion.BeginTransaction(System.Data.IsolationLevel.Serializable);
                        OleDbCommand comando = new OleDbCommand("SP_AlmacenIndirecto_Alta", conexion, transaccion);
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.Clear();
                        comando.Parameters.AddWithValue("@Id_Almacen ", combo_Almaceni.SelectedIndex + 1);
                        comando.Parameters.AddWithValue("@Id_ProductoIndirecto ", comboBox_ProductoIndirecto.SelectedIndex + 1);
                        comando.Parameters.AddWithValue("@Existencia", txt_Existenciai.Text);
                        comando.Parameters.AddWithValue("@Precio_Compra", txt_PrecioComprai.Text);
                        comando.Parameters.AddWithValue("@Precio_Venta", txt_PrecioVentai.Text);
                        comando.Parameters.AddWithValue("@Fecha", dateTime_ProductoIndirecto.Value.Date);
                        comando.ExecuteNonQuery();
                        transaccion.Commit();
                        MessageBox.Show("Datos guardados con éxito", "Solicitud procesada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ha ocurrido un error inesperado", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        transaccion.Rollback();
                    }
                    finally
                    {
                        conexion.Close();
                    }
                }
            }
            #endregion
            #region Ficha4_Guardar
            else if (ficha == "4")
            {
                bool i = Verificar_CamposVaciosT();
                if (i == true)
                    MessageBox.Show("Inserta todos los datos marcados", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    if (txt_Descuento.Text.Trim() == "")
                    {
                        txt_Descuento.Text = "0.00";
                    }
                    try
                    {
                        conexion = new OleDbConnection(ObtenerString());
                        conexion.Open();
                        transaccion = conexion.BeginTransaction(System.Data.IsolationLevel.Serializable);
                        OleDbCommand comando = new OleDbCommand("SP_AlmacenProductoTerminado_Alta", conexion, transaccion);
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.Clear();
                        comando.Parameters.AddWithValue("@Id_Almacen ", combo_Almacent.SelectedIndex + 1);
                        comando.Parameters.AddWithValue("@Id_ProductoTerminado ", comboBox_ProductoTerminado.SelectedIndex + 1);
                        comando.Parameters.AddWithValue("@Lote ", txt_Lotet.Text);
                        comando.Parameters.AddWithValue("@Existencia", txt_Existenciat.Text);
                        comando.Parameters.AddWithValue("@Precio_Compra", Convert.ToDecimal(txt_PrecioComprat.Text));
                        comando.Parameters.AddWithValue("@Precio_Venta", Convert.ToDecimal(txt_PrecioVentat.Text));
                        comando.Parameters.AddWithValue("@Descuento", Convert.ToDecimal(txt_Descuento.Text));
                        comando.Parameters.AddWithValue("@Fecha", dateTime_ProductoTerminado.Value);
                        comando.ExecuteNonQuery();
                        transaccion.Commit();
                        MessageBox.Show("Datos guardados con éxito", "Solicitud procesada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ha ocurrido un error inesperado", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        transaccion.Rollback();
                    }
                    finally
                    {
                        conexion.Close();
                    }
                }
            }
            #endregion
        }
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OleDbConnection conexion = null;
            OleDbTransaction transaccion = null;
            string ficha = tabControl1.SelectedIndex.ToString();
            if (ficha == "0")
            {
                try
                {
                    conexion = new OleDbConnection(ObtenerString());
                    conexion.Open();
                    transaccion = conexion.BeginTransaction(System.Data.IsolationLevel.Serializable);
                    OleDbCommand comando = new OleDbCommand("SP_AlmacenMateriaPrima_Bajas", conexion, transaccion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@Id_AlmacenMateriaPrima", Idp);
                    comando.ExecuteNonQuery();
                    transaccion.Commit();
                    conexion.Close();
                    MessageBox.Show("Datos Modificados con éxito", "Solicitud procesada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha ocurrido un error inesperado", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (ficha == "1")
            {
                try
                {
                    conexion = new OleDbConnection(ObtenerString());
                    conexion.Open();
                    transaccion = conexion.BeginTransaction(System.Data.IsolationLevel.Serializable);
                    OleDbCommand comando = new OleDbCommand("SP_AlmacenMateriaPrimaP_Bajas", conexion, transaccion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@Id_AlmacenMateriaPrimaP", Idp);
                    comando.ExecuteNonQuery();
                    transaccion.Commit();
                    conexion.Close();
                    MessageBox.Show("Datos Modificados con éxito", "Solicitud procesada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha ocurrido un error inesperado", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (ficha == "2")
            {
                try
                {
                    conexion = new OleDbConnection(ObtenerString());
                    conexion.Open();
                    transaccion = conexion.BeginTransaction(System.Data.IsolationLevel.Serializable);
                    OleDbCommand comando = new OleDbCommand("SP_AlmacenProductoElaborado_Bajas", conexion, transaccion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@Id_AlmacenProductoElaborado", Idp);
                    comando.ExecuteNonQuery();
                    transaccion.Commit();
                    conexion.Close();
                    MessageBox.Show("Datos Modificados con éxito", "Solicitud procesada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha ocurrido un error inesperado", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (ficha == "3")
            {
                try
                {
                    conexion = new OleDbConnection(ObtenerString());
                    conexion.Open();
                    transaccion = conexion.BeginTransaction(System.Data.IsolationLevel.Serializable);
                    OleDbCommand comando = new OleDbCommand("SP_AlmacenIndirecto_Baja", conexion, transaccion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@Id_AlmacenIndirecto", Idp);
                    comando.ExecuteNonQuery();
                    transaccion.Commit();
                    conexion.Close();
                    MessageBox.Show("Datos Modificados con éxito", "Solicitud procesada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha ocurrido un error inesperado", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (ficha == "4")
            {
                try
                {
                    conexion = new OleDbConnection(ObtenerString());
                    conexion.Open();
                    transaccion = conexion.BeginTransaction(System.Data.IsolationLevel.Serializable);
                    OleDbCommand comando = new OleDbCommand("SP_AlmacenProductoTerminado_Bajas", conexion, transaccion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@Id_ProductoTerminado", Idp);
                    comando.ExecuteNonQuery();
                    transaccion.Commit();
                    conexion.Close();
                    MessageBox.Show("Datos Modificados con éxito", "Solicitud procesada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha ocurrido un error inesperado", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OleDbConnection con = null;
            OleDbTransaction tran = null;
            string ficha = tabControl1.SelectedIndex.ToString();
            if (ficha == "0")
            {
                bool i = Verificar_CamposVacios();
                if (i == true)
                    MessageBox.Show("Inserta todos los datos marcados", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    try
                    {
                        con = new OleDbConnection(ObtenerString());
                        con.Open();
                        tran = con.BeginTransaction(System.Data.IsolationLevel.Serializable);
                        OleDbCommand comando = new OleDbCommand("SP_AlmacenMateriaPrima_Cambios", con, tran);
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.Clear();
                        comando.Parameters.AddWithValue("@Id_AlmacenMateriaPrima", Idp);
                        comando.Parameters.AddWithValue("@Id_Almacen", combo_Almacenm.SelectedIndex + 1);
                        comando.Parameters.AddWithValue("@Id_MateriaPrima", comboBox_MateriaPrimam.SelectedIndex + 1);
                        comando.Parameters.AddWithValue("@Lote", txt_Lotem.Text);
                        comando.Parameters.AddWithValue("@Existencia", txt_Existenciam.Text);
                        comando.Parameters.AddWithValue("@Precio_Compra", txt_PrecioCompram.Text);
                        comando.Parameters.AddWithValue("@Precio_Venta", txt_PrecioVentam.Text);
                        comando.Parameters.AddWithValue("@Fecha", dateTime_MateriaPrimam.Value.Date);
                        comando.ExecuteNonQuery();
                        tran.Commit();
                        con.Close();
                        MessageBox.Show("Datos Modificados con éxito", "Solicitud procesada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ha ocurrido un error inesperado", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (ficha == "1")
            {
                bool i = Verificar_CamposVaciosP();
                if (i == true)
                    MessageBox.Show("Inserta todos los datos marcados", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    try
                    {
                        con = new OleDbConnection(ObtenerString());
                        con.Open();
                        tran = con.BeginTransaction(System.Data.IsolationLevel.Serializable);
                        OleDbCommand comando = new OleDbCommand("SP_AlmacenMateriaPrimaP_Cambios", con, tran);
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.Clear();
                        comando.Parameters.AddWithValue("@Id_AlmacenMateriaPrimaP", Idp);
                        comando.Parameters.AddWithValue("@Id_Almacen", combo_Almacenp.SelectedIndex + 1);
                        comando.Parameters.AddWithValue("@Id_MateriaPrima", comboBox_MateriaPrimap.SelectedIndex + 1);
                        comando.Parameters.AddWithValue("@Lote", txt_Lotep.Text);
                        comando.Parameters.AddWithValue("@Existencia", txt_Exisnteciap.Text);
                        comando.Parameters.AddWithValue("@Precio_Compra", txt_PrecioComprap.Text);
                        comando.Parameters.AddWithValue("@Precio_Venta", txt_PrecioVentap.Text);
                        comando.Parameters.AddWithValue("@Fecha", dateTime_MateriaPrimap.Value.Date);
                        comando.ExecuteNonQuery();
                        tran.Commit();
                        con.Close();
                        MessageBox.Show("Datos Modificados con éxito", "Solicitud procesada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ha ocurrido un error inesperado", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            //FALTA CORREGIR
            else if (ficha == "2")
            {
                bool i = Verificar_CamposVaciosE();
                if (i == true)
                    MessageBox.Show("Inserta todos los datos marcados", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    try
                    {
                        con = new OleDbConnection(ObtenerString());
                        con.Open();
                        tran = con.BeginTransaction(System.Data.IsolationLevel.Serializable);
                        OleDbCommand comando = new OleDbCommand("SP_AlmacenProductoElaborado_Cambios", con, tran);
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.Clear();
                        comando.Parameters.AddWithValue("@Id_AlmacenProductoElaborado", Idp);
                        comando.Parameters.AddWithValue("@Id_Almacen", combo_Almacene.SelectedIndex + 1);
                        comando.Parameters.AddWithValue("@Id_ProductoElaborado", comboBox_ProductoElaborado.SelectedIndex + 1);
                        comando.Parameters.AddWithValue("@Lote", txt_Lotee.Text);
                        comando.Parameters.AddWithValue("@Existencia", txt_Existenciae.Text);
                        comando.Parameters.AddWithValue("@Precio_Compra", txt_PrecioComprae.Text);
                        comando.Parameters.AddWithValue("@Precio_Venta", txt_PrecioVentae.Text);
                        comando.Parameters.AddWithValue("@Fecha", dateTime_ProductoElaborado.Value.Date);
                        comando.ExecuteNonQuery();
                        tran.Commit();
                        con.Close();
                        MessageBox.Show("Datos Modificados con éxito", "Solicitud procesada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ha ocurrido un error inesperado", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (ficha == "3")
            {
                bool i = Verificar_CamposVaciosI();
                if (i == true)
                    MessageBox.Show("Inserta todos los datos marcados", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    try
                    {
                        con = new OleDbConnection(ObtenerString());
                        con.Open();
                        tran = con.BeginTransaction(System.Data.IsolationLevel.Serializable);
                        OleDbCommand comando = new OleDbCommand("SP_AlmacenIndirecto_Cambios", con, tran);
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.Clear();
                        comando.Parameters.AddWithValue("@Id_AlmacenIndirecto", Idp);
                        comando.Parameters.AddWithValue("@Id_Almacen", combo_Almaceni.SelectedIndex + 1);
                        comando.Parameters.AddWithValue("@Id_ProductoIndirecto", comboBox_ProductoIndirecto.SelectedIndex + 1);
                        comando.Parameters.AddWithValue("@Existencia", txt_Existenciai.Text);
                        comando.Parameters.AddWithValue("@Precio_Compra", txt_PrecioComprai.Text);
                        comando.Parameters.AddWithValue("@Precio_Venta", txt_PrecioVentai.Text);
                        comando.Parameters.AddWithValue("@Fecha", dateTime_ProductoIndirecto.Value.Date);
                        comando.ExecuteNonQuery();
                        tran.Commit();
                        con.Close();
                        MessageBox.Show("Datos Modificados con éxito", "Solicitud procesada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ha ocurrido un error inesperado", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (ficha == "4")
            {
                bool i = Verificar_CamposVaciosT();
                if (i == true)
                    MessageBox.Show("Inserta todos los datos marcados", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    try
                    {
                        con = new OleDbConnection(ObtenerString());
                        con.Open();
                        tran = con.BeginTransaction(System.Data.IsolationLevel.Serializable);
                        OleDbCommand comando = new OleDbCommand("SP_AlmacenProductoTerminado_Cambios", con, tran);
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.Clear();
                        comando.Parameters.AddWithValue("@Id_AlmacenProducto", Idp);
                        comando.Parameters.AddWithValue("@Id_Almacen", combo_Almacent.SelectedIndex + 1);
                        comando.Parameters.AddWithValue("@Id_ProductoTerminado", comboBox_ProductoTerminado.SelectedIndex + 1);
                        comando.Parameters.AddWithValue("@Lote", txt_Lotet.Text);
                        comando.Parameters.AddWithValue("@Existencia", txt_Existenciat.Text);
                        comando.Parameters.AddWithValue("@Precio_Compra", txt_PrecioComprat.Text);
                        comando.Parameters.AddWithValue("@Precio_Venta", txt_PrecioVentat.Text);
                        comando.Parameters.AddWithValue("@Descuento", txt_Descuento.Text);
                        comando.Parameters.AddWithValue("@Fecha", dateTime_ProductoTerminado.Value.Date);
                        comando.ExecuteNonQuery();
                        tran.Commit();
                        con.Close();
                        MessageBox.Show("Datos Modificados con éxito", "Solicitud procesada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ha ocurrido un error inesperado", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        //-------------------------------------------------------------
        //------------------Busqueda del sistema-----------------------
        //-------------------------------------------------------------
        #region Busqueda del sistema
        public void BusquedaDatos(int Idp)
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand coman = new OleDbCommand();
            OleDbDataReader dr;
            //Obtengo que ficha o que control esta activa para poder limpiar dicho control
            string ficha = tabControl1.SelectedIndex.ToString();
            #region Ficha0_Busqueda
            if (ficha == "0")
            {
                con.ConnectionString = ObtenerString();
                coman.Connection = con;
                coman.CommandText = "SELECT Tb_AlmacenMateriaPrima.* FROM Tb_AlmacenMateriaPrima where Tb_AlmacenMateriaPrima.Id_AlmacenMateriaPrima='" + Idp + "' And Tb_AlmacenMateriaPrima.Activo='S'";
                coman.CommandType = CommandType.Text;
                con.Open();
                dr = coman.ExecuteReader();
                while (dr.Read())
                {
                    Idp = dr.GetInt32(dr.GetOrdinal("Id_AlmacenMateriaPrima"));
                    int indice_MateriaPrima = dr.GetInt32(dr.GetOrdinal("Id_MateriaPrima"));
                    indice_MateriaPrima = indice_MateriaPrima - 1;
                    comboBox_MateriaPrimam.SelectedIndex = indice_MateriaPrima;
                    int indice_almacen = dr.GetInt32(dr.GetOrdinal("Id_Almacen"));
                    indice_almacen = indice_almacen - 1;
                    combo_Almacenm.SelectedIndex = indice_almacen;
                    txt_Existenciam.Text = dr.GetDecimal(dr.GetOrdinal("Existencia")).ToString("N");
                    txt_Lotem.Text = dr.GetString(dr.GetOrdinal("Lote"));
                    txt_PrecioCompram.Text = dr.GetDecimal(dr.GetOrdinal("Precio_Compra")).ToString("N");
                    txt_PrecioVentam.Text = dr.GetDecimal(dr.GetOrdinal("Precio_Venta")).ToString("N");
                    dateTime_MateriaPrimam.Value = dr.GetDateTime(dr.GetOrdinal("Fecha"));
                }
                con.Close();
            }
            #endregion
            #region Ficha1_Busqueda
            else if (ficha == "1")
            {
                con.ConnectionString = ObtenerString();
                coman.Connection = con;
                coman.CommandText = "SELECT Tb_AlmacenMateriaPrimaP.* FROM Tb_AlmacenMateriaPrimaP where Tb_AlmacenMateriaPrimaP.Id_AlmacenMateriaPrimaP='" + Idp + "'And Tb_AlmacenMateriaPrimaP.Activo='S'";
                coman.CommandType = CommandType.Text;
                con.Open();
                dr = coman.ExecuteReader();
                while (dr.Read())
                {
                    Idp = dr.GetInt32(dr.GetOrdinal("Id_AlmacenMateriaPrimaP"));
                    int indice_MateriaPrimap = dr.GetInt32(dr.GetOrdinal("Id_MateriaPrimaP"));
                    indice_MateriaPrimap = indice_MateriaPrimap - 1;
                    comboBox_MateriaPrimap.SelectedIndex = indice_MateriaPrimap;
                    int indice_almacen = dr.GetInt32(dr.GetOrdinal("Id_Almacen"));
                    indice_almacen = indice_almacen - 1;
                    combo_Almacenp.SelectedIndex = indice_almacen;
                    txt_Exisnteciap.Text = Convert.ToString(dr.GetInt32(dr.GetOrdinal("Existencia")));
                    txt_Lotep.Text = dr.GetString(dr.GetOrdinal("Lote"));
                    txt_PrecioComprap.Text = dr.GetDecimal(dr.GetOrdinal("Precio_Compra")).ToString("N");
                    txt_PrecioVentap.Text = dr.GetDecimal(dr.GetOrdinal("Precio_Venta")).ToString("N");
                    dateTime_MateriaPrimap.Value = dr.GetDateTime(dr.GetOrdinal("Fecha"));
                }
                con.Close();
            }
            #endregion
            #region Ficha2_Busqueda
            else if (ficha == "2")
            {
                con.ConnectionString = ObtenerString();
                coman.Connection = con;
                coman.CommandText = "SELECT Tb_AlmacenProductoElaborado.* FROM Tb_AlmacenProductoElaborado where Tb_AlmacenProductoElaborado.Id_AlmacenProductoElaborado='" + Idp + "'And Tb_AlmacenProductoElaborado.Activo='S'";
                coman.CommandType = CommandType.Text;
                con.Open();
                dr = coman.ExecuteReader();
                while (dr.Read())
                {
                    Idp = dr.GetInt32(dr.GetOrdinal("Id_AlmacenProductoElaborado"));
                    int indice_Pelaborado = dr.GetInt32(dr.GetOrdinal("Id_ProductoElaborado"));
                    indice_Pelaborado = indice_Pelaborado - 1;
                    comboBox_ProductoElaborado.SelectedIndex = indice_Pelaborado;
                    int indice_almacen = dr.GetInt32(dr.GetOrdinal("Id_Almacen"));
                    indice_almacen = indice_almacen - 1;
                    combo_Almacene.SelectedIndex = indice_almacen;
                    txt_Existenciae.Text = dr.GetDecimal(dr.GetOrdinal("Existencia")).ToString("N");
                    txt_Lotee.Text = dr.GetString(dr.GetOrdinal("Lote"));
                    txt_PrecioComprae.Text = dr.GetDecimal(dr.GetOrdinal("Precio_Compra")).ToString("N");
                    txt_PrecioVentae.Text = dr.GetDecimal(dr.GetOrdinal("Precio_Venta")).ToString("N");
                    dateTime_ProductoElaborado.Value = dr.GetDateTime(dr.GetOrdinal("Fecha"));
                }
                con.Close();
            }
            #endregion
            #region Ficha3_Busqueda
            else if (ficha == "3")
            {
                con.ConnectionString = ObtenerString();
                coman.Connection = con;
                coman.CommandText = "SELECT Tb_AlmacenIndirecto.* FROM Tb_AlmacenIndirecto where Tb_AlmacenIndirecto.Id_AlmacenIndirecto='" + Idp + "' and Tb_AlmacenIndirecto.Activo='S'";
                coman.CommandType = CommandType.Text;
                con.Open();
                dr = coman.ExecuteReader();
                while (dr.Read())
                {
                    Idp = dr.GetInt32(dr.GetOrdinal("Id_AlmacenIndirecto"));
                    int indice_Indirecto = dr.GetInt32(dr.GetOrdinal("Id_ProductoIndirecto"));
                    indice_Indirecto = indice_Indirecto - 1;
                    comboBox_ProductoIndirecto.SelectedIndex = indice_Indirecto;
                    int indice_almacei = dr.GetInt32(dr.GetOrdinal("Id_Almacen"));
                    indice_almacei = indice_almacei - 1;
                    combo_Almaceni.SelectedIndex = indice_almacei;
                    txt_Existenciai.Text = Convert.ToString(dr.GetInt32(dr.GetOrdinal("Existencia")));
                    txt_PrecioComprai.Text = dr.GetDecimal(dr.GetOrdinal("Precio_Compra")).ToString("N");
                    txt_PrecioVentai.Text = dr.GetDecimal(dr.GetOrdinal("Precio_Venta")).ToString("N");
                    dateTime_ProductoIndirecto.Value = dr.GetDateTime(dr.GetOrdinal("Fecha"));
                }
                con.Close();
            }
            #endregion
            #region Ficha4_Busqueda
            else if (ficha == "4")
            {
                con.ConnectionString = ObtenerString();
                coman.Connection = con;
                coman.CommandText = "SELECT Tb_AlmacenProducto.* FROM Tb_AlmacenProducto where Tb_AlmacenProducto.Id_AlmacenProducto='" + Idp + "'And Tb_AlmacenProducto.Activo='S'";
                coman.CommandType = CommandType.Text;
                con.Open();
                dr = coman.ExecuteReader();
                while (dr.Read())
                {
                    Idp = dr.GetInt32(dr.GetOrdinal("Id_AlmacenProducto"));
                    int indice_Terminado = dr.GetInt32(dr.GetOrdinal("Id_ProductoTerminado"));
                    indice_Terminado = indice_Terminado - 1;
                    comboBox_ProductoTerminado.SelectedIndex = indice_Terminado;
                    int indice_almacet = dr.GetInt32(dr.GetOrdinal("Id_Almacen"));
                    indice_almacet = indice_almacet - 1;
                    combo_Almacent.SelectedIndex = indice_almacet;
                    txt_Existenciat.Text = Convert.ToString(dr.GetInt32(dr.GetOrdinal("Existencia")));
                    txt_Lotet.Text = dr.GetString(dr.GetOrdinal("Lote"));
                    txt_PrecioComprat.Text = dr.GetDecimal(dr.GetOrdinal("Precio_Compra")).ToString("N");
                    txt_PrecioVentat.Text = dr.GetDecimal(dr.GetOrdinal("Precio_Venta")).ToString("N");
                    txt_Descuento.Text = dr.GetDecimal(dr.GetOrdinal("Descuento")).ToString("N");
                    dateTime_ProductoTerminado.Value = dr.GetDateTime(dr.GetOrdinal("Fecha"));
                }
                con.Close();
            }
            #endregion
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
                //Obtengo que ficha o que control esta activa para poder limpiar dicho control
                string ficha = tabControl1.SelectedIndex.ToString();
                #region Ficha0_BusquedaDatos
                if (ficha == "0")
                {
                    string busqueda = txt_Busqueda.Text;
                    txt_Busqueda.Text = busqueda.ToUpper();
                    coman.CommandText = "SELECT Tb_AlmacenMateriaPrima.*, Tb_MateriaPrima.Nombre AS Nombre_MateriaPrima, Tb_TipoPieza.Nombre AS Nombre_TipoPieza FROM Tb_AlmacenMateriaPrima INNER JOIN Tb_MateriaPrima ON Tb_AlmacenMateriaPrima.Id_MateriaPrima = Tb_MateriaPrima.Id_MateriaPrima INNER JOIN Tb_TipoPieza ON Tb_MateriaPrima.Id_TipoPieza = Tb_TipoPieza.Id_TipoPieza where Tb_MateriaPrima.Nombre='" + busqueda.ToUpper() + "' AND Tb_AlmacenMateriaPrima.Activo='S'";
                    coman.CommandType = CommandType.Text;
                    con.Open();
                    data_resultado.Rows.Clear();
                    dr = coman.ExecuteReader();
                    while (dr.Read())
                    {
                        int Renglon = data_resultado.Rows.Add();
                        Idp = dr.GetInt32(dr.GetOrdinal("Id_AlmacenMateriaPrima"));
                        data_resultado.Rows[Renglon].Cells["Idb"].Value = dr.GetInt32(dr.GetOrdinal("Id_AlmacenMateriaPrima"));
                        string NombreMateria = dr.GetString(dr.GetOrdinal("Nombre_MateriaPrima"));
                        string NombrePieza = dr.GetString(dr.GetOrdinal("Nombre_TipoPieza"));
                        string Nomb = NombreMateria + " " + NombrePieza;
                        data_resultado.Rows[Renglon].Cells["Nombreb"].Value = Nomb;
                        data_resultado.Rows[Renglon].Cells["Loteb"].Value = dr.GetString(dr.GetOrdinal("Lote"));
                    }
                    con.Close();
                }
                #endregion
                #region Ficha1_BusquedaDatos
                else if (ficha == "1")
                {
                    string busqueda = txt_Busqueda.Text;
                    txt_Busqueda.Text = busqueda.ToUpper();
                    coman.CommandText = "SELECT Tb_AlmacenMateriaPrimaP.*, Tb_MateriaPrimaP.Nombre FROM Tb_AlmacenMateriaPrimaP INNER JOIN Tb_MateriaPrimaP ON Tb_AlmacenMateriaPrimaP.Id_MateriaPrimaP = Tb_MateriaPrimaP.Id_MateriaPrimaP where Tb_MateriaPrimaP.Nombre='" + busqueda.ToUpper() + "' AND Tb_AlmacenMateriaPrimaP.Activo='S'";
                    coman.CommandType = CommandType.Text;
                    con.Open();
                    data_resultado.Rows.Clear();
                    dr = coman.ExecuteReader();
                    while (dr.Read())
                    {
                        int Renglon = data_resultado.Rows.Add();
                        Idp = dr.GetInt32(dr.GetOrdinal("Id_AlmacenMateriaPrimaP"));
                        data_resultado.Rows[Renglon].Cells["Idb"].Value = dr.GetInt32(dr.GetOrdinal("Id_AlmacenMateriaPrimaP"));
                        data_resultado.Rows[Renglon].Cells["Nombreb"].Value = dr.GetString(dr.GetOrdinal("Nombre"));
                        data_resultado.Rows[Renglon].Cells["Loteb"].Value = dr.GetString(dr.GetOrdinal("Lote"));

                    }
                    con.Close();
                }
                #endregion
                #region Ficha2_BusquedaDatos
                else if (ficha == "2")
                {
                    string busqueda = txt_Busqueda.Text;
                    txt_Busqueda.Text = busqueda.ToUpper();
                    coman.CommandText = "SELECT Tb_AlmacenProductoElaborado.*, Tb_ProductoElaborado.Nombre FROM Tb_AlmacenProductoElaborado INNER JOIN Tb_ProductoElaborado ON Tb_AlmacenProductoElaborado.Id_ProductoElaborado = Tb_ProductoElaborado.Id_ProductoElaborado where Tb_ProductoElaborado.Nombre='" + busqueda.ToUpper() + "' AND Tb_AlmacenProductoElaborado.Activo='S'";
                    coman.CommandType = CommandType.Text;
                    con.Open();
                    data_resultado.Rows.Clear();
                    dr = coman.ExecuteReader();
                    while (dr.Read())
                    {
                        int Renglon = data_resultado.Rows.Add();
                        Idp = dr.GetInt32(dr.GetOrdinal("Id_AlmacenProductoElaborado"));
                        data_resultado.Rows[Renglon].Cells["Idb"].Value = dr.GetInt32(dr.GetOrdinal("Id_AlmacenProductoElaborado"));
                        data_resultado.Rows[Renglon].Cells["Nombreb"].Value = dr.GetString(dr.GetOrdinal("Nombre"));
                        data_resultado.Rows[Renglon].Cells["Loteb"].Value = dr.GetString(dr.GetOrdinal("Lote"));

                    }
                    con.Close();
                }
                #endregion
                #region Ficha3_BusquedaDatos
                else if (ficha == "3")
                {
                    string busqueda = txt_Busqueda.Text;
                    txt_Busqueda.Text = busqueda.ToUpper();
                    coman.CommandText = "SELECT Tb_AlmacenIndirecto.*, Tb_ProductoIndirecto.Nombre, Tb_ProductoIndirecto.Clave FROM Tb_AlmacenIndirecto INNER JOIN Tb_ProductoIndirecto ON Tb_AlmacenIndirecto.Id_ProductoIndirecto = Tb_ProductoIndirecto.Id_ProductoIndirecto where Tb_ProductoIndirecto.Nombre='" + busqueda.ToUpper() + "' AND Tb_AlmacenIndirecto.Activo='S'";
                    coman.CommandType = CommandType.Text;
                    con.Open();
                    data_resultado.Rows.Clear();
                    dr = coman.ExecuteReader();
                    while (dr.Read())
                    {
                        int Renglon = data_resultado.Rows.Add();
                        Idp = dr.GetInt32(dr.GetOrdinal("Id_AlmacenIndirecto"));
                        data_resultado.Rows[Renglon].Cells["Idb"].Value = dr.GetInt32(dr.GetOrdinal("Id_AlmacenIndirecto"));
                        data_resultado.Rows[Renglon].Cells["Nombreb"].Value = dr.GetString(dr.GetOrdinal("Nombre"));
                        data_resultado.Rows[Renglon].Cells["Loteb"].Value = dr.GetString(dr.GetOrdinal("Clave"));

                    }
                    con.Close();
                }
                #endregion
                #region Ficha4_BusquedaDatos
                else if (ficha == "4")
                {
                    string busqueda = txt_Busqueda.Text;
                    txt_Busqueda.Text = busqueda.ToUpper();
                    coman.CommandText = "SELECT Tb_AlmacenProducto.*, Tb_ProductoTerminado.Nombre FROM Tb_AlmacenProducto INNER JOIN Tb_ProductoTerminado ON Tb_AlmacenProducto.Id_ProductoTerminado = Tb_ProductoTerminado.Id_ProductoTerminado where Tb_ProductoTerminado.Nombre='" + busqueda.ToUpper() + "' AND Tb_AlmacenProducto.Activo='S'";
                    coman.CommandType = CommandType.Text;
                    con.Open();
                    data_resultado.Rows.Clear();
                    dr = coman.ExecuteReader();
                    while (dr.Read())
                    {
                        int Renglon = data_resultado.Rows.Add();
                        Idp = dr.GetInt32(dr.GetOrdinal("Id_AlmacenProducto"));
                        data_resultado.Rows[Renglon].Cells["Idb"].Value = dr.GetInt32(dr.GetOrdinal("Id_AlmacenProducto"));
                        data_resultado.Rows[Renglon].Cells["Nombreb"].Value = dr.GetString(dr.GetOrdinal("Nombre"));
                        data_resultado.Rows[Renglon].Cells["Loteb"].Value = dr.GetString(dr.GetOrdinal("Lote"));

                    }
                    con.Close();
                }
                #endregion
            }
        }
        private void bttn_Busqueda_Click(object sender, EventArgs e)
        {
            Busqueda();
        }
        #endregion
        
        //-------------------------------------------------------------
        //----------------------AUTO COMPLETAR-------------------------
        //-------------------------------------------------------------
        //Metodo para autocompletar la busqueda
        #region AutoCompletar_MateriaPrima
        public static DataTable Datos1()
        {
            DataTable dt = new DataTable();
            OleDbConnection conexion = new OleDbConnection(ObtenerString());//cadena conexion
            string consulta = "SELECT Tb_MateriaPrima.Nombre, Tb_TipoPieza.Lote, Tb_TipoPieza.Nombre AS TipoPieza FROM Tb_MateriaPrima INNER JOIN Tb_TipoPieza ON Tb_MateriaPrima.Id_TipoPieza = Tb_TipoPieza.Id_TipoPieza  where Tb_MateriaPrima.Activo='S'";
            OleDbCommand comando = new OleDbCommand(consulta, conexion);
            OleDbDataAdapter adap = new OleDbDataAdapter(comando);
            adap.Fill(dt);
            return dt;
        }
        //metodo para cargar la coleccion de datos para el autocomplete
        public static AutoCompleteStringCollection Autocomplete1()
        {
            DataTable dt = Datos1();

            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            //recorrer y cargar los items para el autocompletado
            foreach (DataRow row in dt.Rows)
            {
                coleccion.Add(Convert.ToString(row["Nombre"]));
                coleccion.Add(Convert.ToString(row["Lote"]));
            }
            return coleccion;
        }
        #endregion
        #region AutoCompletar_MateriaPrimaP
        public static DataTable Datos2()
        {
            DataTable dt = new DataTable();
            OleDbConnection conexion = new OleDbConnection(ObtenerString());//cadena conexion
            string consulta = "SELECT Tb_MateriaPrimaP.Nombre As Nombre, Tb_MateriaPrimaP.Clave AS Clave, Tb_AlmacenMateriaPrimaP.Lote As Lote FROM Tb_MateriaPrimaP INNER JOIN Tb_AlmacenMateriaPrimaP ON Tb_MateriaPrimaP.Id_MateriaPrimaP = Tb_AlmacenMateriaPrimaP.Id_MateriaPrimaP where Tb_MateriaPrimaP.Activo='S'";
            OleDbCommand comando = new OleDbCommand(consulta, conexion);
            OleDbDataAdapter adap = new OleDbDataAdapter(comando);
            adap.Fill(dt);
            return dt;
        }
        //metodo para cargar la coleccion de datos para el autocomplete
        public static AutoCompleteStringCollection Autocomplete2()
        {
            DataTable dt = Datos2();

            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            //recorrer y cargar los items para el autocompletado
            foreach (DataRow row in dt.Rows)
            {
                coleccion.Add(Convert.ToString(row["Nombre"]));
                coleccion.Add(Convert.ToString(row["Clave"]));
                coleccion.Add(Convert.ToString(row["Lote"]));
            }
            return coleccion;
        }
        #endregion
        #region AutoCompletar_ProductoElaborado
        public static DataTable Datos3()
        {
            DataTable dt = new DataTable();
            OleDbConnection conexion = new OleDbConnection(ObtenerString());//cadena conexion
            string consulta = "SELECT Tb_ProductoElaborado.Nombre AS Nombre, Tb_AlmacenProductoElaborado.Lote AS Lote FROM Tb_AlmacenProductoElaborado INNER JOIN Tb_ProductoElaborado ON Tb_AlmacenProductoElaborado.Id_ProductoElaborado = Tb_ProductoElaborado.Id_ProductoElaborado where Tb_ProductoElaborado.Activo='S' And Tb_AlmacenProductoElaborado.Activo='S'"; //consulta a la tabla paises
            OleDbCommand comando = new OleDbCommand(consulta, conexion);
            OleDbDataAdapter adap = new OleDbDataAdapter(comando);
            adap.Fill(dt);
            return dt;
        }
        //metodo para cargar la coleccion de datos para el autocomplete
        public static AutoCompleteStringCollection Autocomplete3()
        {
            DataTable dt = Datos3();

            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            //recorrer y cargar los items para el autocompletado
            foreach (DataRow row in dt.Rows)
            {
                coleccion.Add(Convert.ToString(row["Nombre"]));
                coleccion.Add(Convert.ToString(row["Lote"]));
            }
            return coleccion;
        }
        #endregion
        #region AutoCompletar_ProductoIndirecto
        public static DataTable Datos4()
        {
            DataTable dt = new DataTable();
            OleDbConnection conexion = new OleDbConnection(ObtenerString());//cadena conexion
            string consulta = "SELECT Tb_ProductoIndirecto.Nombre AS Nombre , Tb_ProductoIndirecto.Clave AS Clave FROM Tb_AlmacenIndirecto INNER JOIN Tb_ProductoIndirecto ON Tb_AlmacenIndirecto.Id_ProductoIndirecto = Tb_ProductoIndirecto.Id_ProductoIndirecto where Tb_ProductoIndirecto.Activo='S'"; //consulta a la tabla paises
            OleDbCommand comando = new OleDbCommand(consulta, conexion);
            OleDbDataAdapter adap = new OleDbDataAdapter(comando);
            adap.Fill(dt);
            return dt;
        }
        //metodo para cargar la coleccion de datos para el autocomplete
        public static AutoCompleteStringCollection Autocomplete4()
        {
            DataTable dt = Datos4();

            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            //recorrer y cargar los items para el autocompletado
            foreach (DataRow row in dt.Rows)
            {
                coleccion.Add(Convert.ToString(row["Nombre"]));
                coleccion.Add(Convert.ToString(row["Clave"]));
            }
            return coleccion;
        }
        #endregion
        #region AutoCompletar_ProductoTerminado
        public static DataTable Datos5()
        {
            DataTable dt = new DataTable();
            OleDbConnection conexion = new OleDbConnection(ObtenerString());//cadena conexion
            string consulta = "SELECT Tb_ProductoTerminado.Clave, Tb_ProductoTerminado.Nombre, Tb_AlmacenProducto.Lote FROM Tb_AlmacenProducto INNER JOIN Tb_ProductoTerminado ON Tb_AlmacenProducto.Id_ProductoTerminado = Tb_ProductoTerminado.Id_ProductoTerminado where Tb_AlmacenProducto.Activo='S'"; //consulta a la tabla paises
            OleDbCommand comando = new OleDbCommand(consulta, conexion);
            OleDbDataAdapter adap = new OleDbDataAdapter(comando);
            adap.Fill(dt);
            return dt;
        }
        //metodo para cargar la coleccion de datos para el autocomplete
        public static AutoCompleteStringCollection Autocomplete5()
        {
            DataTable dt = Datos5();

            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            //recorrer y cargar los items para el autocompletado
            foreach (DataRow row in dt.Rows)
            {
                coleccion.Add(Convert.ToString(row["Nombre"]));
                coleccion.Add(Convert.ToString(row["Lote"]));
            }
            return coleccion;
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
        #region Validacion_CamposFormaPrincipal
        private void txt_Busqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar < 65 || e.KeyChar > 90) && (e.KeyChar < 97 || e.KeyChar > 122) && (e.KeyChar < 7 || e.KeyChar > 9) && (e.KeyChar < 126 || e.KeyChar > 128) && (e.KeyChar < 45 || e.KeyChar > 47) && (e.KeyChar < 31 || e.KeyChar > 33))
            {
                MessageBox.Show("Solo se aceptan letras y numeros", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                e.Handled = true;
            }
        }
        private void txt_PrecioCompram_KeyPress(object sender, KeyPressEventArgs e)
        {
            //---------Apartado de numeros-------------Apartado de teclas especiales Retroceso y suprimir------------------------Uso del punto
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar < 7 || e.KeyChar > 9) && (e.KeyChar < 126 || e.KeyChar > 128) && (e.KeyChar < 45 || e.KeyChar > 47))
            {
                MessageBox.Show("Solo se aceptan numeros", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                e.Handled = true;
            }
        }
        private void txt_PrecioVentam_KeyPress(object sender, KeyPressEventArgs e)
        {
            //---------Apartado de numeros-------------Apartado de teclas especiales Retroceso y suprimir------------------------Uso del punto
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar < 7 || e.KeyChar > 9) && (e.KeyChar < 126 || e.KeyChar > 128) && (e.KeyChar < 45 || e.KeyChar > 47))
            {
                MessageBox.Show("Solo se aceptan numeros", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                e.Handled = true;
            }
        }
        private void txt_PrecioComprap_KeyPress(object sender, KeyPressEventArgs e)
        {
            //---------Apartado de numeros-------------Apartado de teclas especiales Retroceso y suprimir------------------------Uso del punto
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar < 7 || e.KeyChar > 9) && (e.KeyChar < 126 || e.KeyChar > 128) && (e.KeyChar < 45 || e.KeyChar > 47))
            {
                MessageBox.Show("Solo se aceptan numeros", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                e.Handled = true;
            }
        }
        private void txt_PrecioVentap_KeyPress(object sender, KeyPressEventArgs e)
        {
            //---------Apartado de numeros-------------Apartado de teclas especiales Retroceso y suprimir------------------------Uso del punto
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar < 7 || e.KeyChar > 9) && (e.KeyChar < 126 || e.KeyChar > 128) && (e.KeyChar < 45 || e.KeyChar > 47))
            {
                MessageBox.Show("Solo se aceptan numeros", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                e.Handled = true;
            }
        }
        private void txt_PrecioComprae_KeyPress(object sender, KeyPressEventArgs e)
        {
            //---------Apartado de numeros-------------Apartado de teclas especiales Retroceso y suprimir------------------------Uso del punto
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar < 7 || e.KeyChar > 9) && (e.KeyChar < 126 || e.KeyChar > 128) && (e.KeyChar < 45 || e.KeyChar > 47))
            {
                MessageBox.Show("Solo se aceptan numeros", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                e.Handled = true;
            }
        }
        private void txt_PrecioVentae_KeyPress(object sender, KeyPressEventArgs e)
        {
            //---------Apartado de numeros-------------Apartado de teclas especiales Retroceso y suprimir------------------------Uso del punto
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar < 7 || e.KeyChar > 9) && (e.KeyChar < 126 || e.KeyChar > 128) && (e.KeyChar < 45 || e.KeyChar > 47))
            {
                MessageBox.Show("Solo se aceptan numeros", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                e.Handled = true;
            }
        }
        private void txt_PrecioComprai_KeyPress(object sender, KeyPressEventArgs e)
        {
            //---------Apartado de numeros-------------Apartado de teclas especiales Retroceso y suprimir------------------------Uso del punto
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar < 7 || e.KeyChar > 9) && (e.KeyChar < 126 || e.KeyChar > 128) && (e.KeyChar < 45 || e.KeyChar > 47))
            {
                MessageBox.Show("Solo se aceptan numeros", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                e.Handled = true;
            }
        }
        private void txt_PrecioVentai_KeyPress(object sender, KeyPressEventArgs e)
        {
            //---------Apartado de numeros-------------Apartado de teclas especiales Retroceso y suprimir------------------------Uso del punto
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar < 7 || e.KeyChar > 9) && (e.KeyChar < 126 || e.KeyChar > 128) && (e.KeyChar < 45 || e.KeyChar > 47))
            {
                MessageBox.Show("Solo se aceptan numeros", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                e.Handled = true;
            }
        }
        private void txt_PrecioComprat_KeyPress(object sender, KeyPressEventArgs e)
        {
            //---------Apartado de numeros-------------Apartado de teclas especiales Retroceso y suprimir------------------------Uso del punto
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar < 7 || e.KeyChar > 9) && (e.KeyChar < 126 || e.KeyChar > 128) && (e.KeyChar < 45 || e.KeyChar > 47))
            {
                MessageBox.Show("Solo se aceptan numeros", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                e.Handled = true;
            }
        }
        private void txt_PrecioVentat_KeyPress(object sender, KeyPressEventArgs e)
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
        //----------------------------------------------
        //---  Primera pestaña carga de elementos  -----
        //----------------------------------------------
        #region Elementos_PrimeraPestaña
        #region Carga de elementos
        //Llenando comboBox de Almacen
        private void Llenando_AlmacenMateriaPrima()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand coman = new OleDbCommand();
            OleDbDataReader dr;
            con.ConnectionString = ObtenerString();
            coman.Connection = con;
            coman.CommandText = "Select Nombre from Tb_Almacen where Activo= 'S'";
            coman.CommandType = CommandType.Text;
            con.Open();
            combo_Almacenm.Items.Clear();
            dr = coman.ExecuteReader();
            while (dr.Read())
            {
                //Declarando Variables y obteniendo los valores correspondiente
                string Nombre = dr.GetString(dr.GetOrdinal("Nombre"));
                combo_Almacenm.Items.Add(Nombre);
            }
            con.Close();
        }
        //Llenando comboBox de MateriaPrima
        private void Llenando_MateriaPrima()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand coman = new OleDbCommand();
            OleDbDataReader dr;
            con.ConnectionString = ObtenerString();
            coman.Connection = con;
            coman.CommandText = "SELECT Tb_MateriaPrima.Nombre AS Nombre_MateriaPrima, Tb_TipoPieza.Nombre AS Nombre_TipoPieza FROM Tb_MateriaPrima INNER JOIN Tb_TipoPieza ON Tb_MateriaPrima.Id_TipoPieza = Tb_TipoPieza.Id_TipoPieza where Tb_MateriaPrima.Activo= 'S'";
            coman.CommandType = CommandType.Text;
            con.Open();
            comboBox_MateriaPrimam.Items.Clear();
            dr = coman.ExecuteReader();
            while (dr.Read())
            {
                //Declarando Variables y obteniendo los valores correspondiente
                string Nombre_MateriaPrima = dr.GetString(dr.GetOrdinal("Nombre_MateriaPrima"));
                //Declarando Variables y obteniendo los valores correspondiente
                string Nombre_TipoPieza = dr.GetString(dr.GetOrdinal("Nombre_TipoPieza"));
                //Agregando el nombre del producto con su tipo concatenando en el combobox
                comboBox_MateriaPrimam.Items.Add(Nombre_MateriaPrima + " " + Nombre_TipoPieza);
            }
            con.Close();
        }
        private void Llenando_DataGridViewMateriaPrima()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand coman = new OleDbCommand();
            OleDbDataReader dr;
            con.ConnectionString = ObtenerString();
            coman.Connection = con;
            coman.CommandText = "SELECT Tb_AlmacenMateriaPrima.*, Tb_MateriaPrima.Nombre AS Nombre_MateriaPrima, Tb_TipoPieza.Nombre AS Nombre_TipoPieza FROM Tb_AlmacenMateriaPrima INNER JOIN Tb_MateriaPrima ON Tb_AlmacenMateriaPrima.Id_MateriaPrima = Tb_MateriaPrima.Id_MateriaPrima INNER JOIN Tb_TipoPieza ON Tb_MateriaPrima.Id_TipoPieza = Tb_TipoPieza.Id_TipoPieza where Tb_AlmacenMateriaPrima.Activo= 'S' AND Tb_MateriaPrima.Activo= 'S'";
            coman.CommandType = CommandType.Text;
            con.Open();
            data_MateriaPrima.Rows.Clear();
            dr = coman.ExecuteReader();
            while (dr.Read())
            {
                //Creando y obteniendo el indice para un nuevo renglon
                int Indice = data_MateriaPrima.Rows.Add();
                data_MateriaPrima.Rows[Indice].Cells["Id_AlmacenMateriaPrimam"].Value = dr.GetInt32(dr.GetOrdinal("Id_AlmacenMateriaPrima"));
                data_MateriaPrima.Rows[Indice].Cells["Id_Almacenm"].Value = dr.GetInt32(dr.GetOrdinal("Id_Almacen"));
                data_MateriaPrima.Rows[Indice].Cells["Id_MateriaPrimam"].Value = dr.GetInt32(dr.GetOrdinal("Id_MateriaPrima"));
                //Declarando Variables y obteniendo los valores correspondiente
                string Nombre_MateriaPrima = dr.GetString(dr.GetOrdinal("Nombre_MateriaPrima"));
                //Declarando Variables y obteniendo los valores correspondiente
                string Nombre_TipoPieza = dr.GetString(dr.GetOrdinal("Nombre_TipoPieza"));
                string MatPrima = Nombre_MateriaPrima + " " + Nombre_TipoPieza;
                //Agregando el nombre del producto con su tipo concatenando la columna del datagridview
                data_MateriaPrima.Rows[Indice].Cells["Materia_Primam"].Value = MatPrima;
                data_MateriaPrima.Rows[Indice].Cells["Lotem"].Value = dr.GetString(dr.GetOrdinal("Lote"));
                data_MateriaPrima.Rows[Indice].Cells["Existenciam"].Value = dr.GetDecimal(dr.GetOrdinal("Existencia")).ToString("N");
                data_MateriaPrima.Rows[Indice].Cells["Precio_Compram"].Value = dr.GetDecimal(dr.GetOrdinal("Precio_Compra")).ToString("N");
                data_MateriaPrima.Rows[Indice].Cells["Precio_Ventam"].Value = dr.GetDecimal(dr.GetOrdinal("Precio_Venta")).ToString("N");
                data_MateriaPrima.Rows[Indice].Cells["Fecham"].Value = dr.GetDateTime(dr.GetOrdinal("Fecha")).ToString("yyyy-MM-dd");
            }
            con.Close();
        }
            #endregion
        #region Verificar_CamposVacios1
        //Verificar espacios vacios
        private bool Verificar_CamposVacios()
        {
            //Se introduce los textbox en un arreglo con el fin de identificar espacios vacios
            Campos[0] = txt_Lotem;
            Campos[1] = txt_Existenciam;
            Campos[2] = txt_PrecioCompram;
            Campos[3] = txt_PrecioVentam;
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
                    errorProvider1.SetError(txt_Lotem, "No puedes dejar el campo vacio");
                    break;
                case 1:
                    errorProvider1.SetError(txt_Existenciam, "No puedes dejar el campo vacio");
                    break;
                case 2:
                    errorProvider1.SetError(txt_PrecioCompram, "No puedes dejar el campo vacio");
                    break;
                case 3:
                    errorProvider1.SetError(txt_PrecioVentam, "No puedes dejar el campo vacio");
                    break;
                default:
                    break;
            }
        }
        #endregion
        #endregion
        //----------------------------------------------
        //---  Segunda pestaña carga de elementos  -----
        //----------------------------------------------
        //Llenando comboBox de Almacen
        private void Llenando_AlmacenMateriaPrimaP()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand coman = new OleDbCommand();
            OleDbDataReader dr;
            con.ConnectionString = ObtenerString();
            coman.Connection = con;
            coman.CommandText = "Select Nombre from Tb_Almacen where Activo= 'S'";
            coman.CommandType = CommandType.Text;
            con.Open();
            combo_Almacenp.Items.Clear();
            dr = coman.ExecuteReader();
            while (dr.Read())
            {
                //Declarando Variables y obteniendo los valores correspondiente
                string Nombre = dr.GetString(dr.GetOrdinal("Nombre"));
                combo_Almacenp.Items.Add(Nombre);
            }
            con.Close();
        }
        //Llenando comboBox de MateriaPrima
        private void Llenando_MateriaPrimaP()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand coman = new OleDbCommand();
            OleDbDataReader dr;
            con.ConnectionString = ObtenerString();
            coman.Connection = con;
            coman.CommandText = "SELECT Nombre FROM Tb_MateriaPrimaP where Activo= 'S'";
            coman.CommandType = CommandType.Text;
            con.Open();
            comboBox_MateriaPrimap.Items.Clear();
            dr = coman.ExecuteReader();
            while (dr.Read())
            {
                comboBox_MateriaPrimap.Items.Add(dr.GetString(dr.GetOrdinal("Nombre")));
            }
            con.Close();
        }
        private void Llenando_DataGridViewMateriaPrimaP()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand coman = new OleDbCommand();
            OleDbDataReader dr;
            con.ConnectionString = ObtenerString();
            coman.Connection = con;
            coman.CommandText = "SELECT Tb_AlmacenMateriaPrimaP.*, Tb_MateriaPrimaP.Nombre FROM Tb_AlmacenMateriaPrimaP INNER JOIN Tb_MateriaPrimaP ON Tb_AlmacenMateriaPrimaP.Id_MateriaPrimaP = Tb_MateriaPrimaP.Id_MateriaPrimaP where Tb_AlmacenMateriaPrimaP.Activo= 'S'";
            coman.CommandType = CommandType.Text;
            con.Open();
            data_MateriaPrimaP.Rows.Clear();
            dr = coman.ExecuteReader();
            while (dr.Read())
            {
                //Creando y obteniendo el indice para un nuevo renglon
                int Indice = data_MateriaPrimaP.Rows.Add();
                data_MateriaPrimaP.Rows[Indice].Cells["Id_AlmacenMateriaPrimaP"].Value = dr.GetInt32(dr.GetOrdinal("Id_AlmacenMateriaPrimaP"));
                data_MateriaPrimaP.Rows[Indice].Cells["Id_Almacenp"].Value = dr.GetInt32(dr.GetOrdinal("Id_Almacen"));
                data_MateriaPrimaP.Rows[Indice].Cells["Id_MateriaPrimaP"].Value = dr.GetInt32(dr.GetOrdinal("Id_MateriaPrimaP"));
                data_MateriaPrimaP.Rows[Indice].Cells["MateriaPrimap"].Value = dr.GetString(dr.GetOrdinal("Nombre"));
                data_MateriaPrimaP.Rows[Indice].Cells["Lotep"].Value = dr.GetString(dr.GetOrdinal("Lote"));
                data_MateriaPrimaP.Rows[Indice].Cells["Existenciap"].Value = dr.GetInt32(dr.GetOrdinal("Existencia"));
                data_MateriaPrimaP.Rows[Indice].Cells["Precio_Comprap"].Value = dr.GetDecimal(dr.GetOrdinal("Precio_Compra")).ToString("N");
                data_MateriaPrimaP.Rows[Indice].Cells["Precio_Ventap"].Value = dr.GetDecimal(dr.GetOrdinal("Precio_Venta")).ToString("N");
                data_MateriaPrimaP.Rows[Indice].Cells["Fechap"].Value = dr.GetString(dr.GetOrdinal("Fecha"));
            }
            con.Close();
        }
        //Verificar espacios vacios
        private bool Verificar_CamposVaciosP()
        {
            //Se introduce los textbox en un arreglo con el fin de identificar espacios vacios
            Campos[0] = txt_Lotep;
            Campos[1] = txt_Exisnteciap;
            Campos[2] = txt_PrecioComprap;
            Campos[3] = txt_PrecioVentap;
            //Reinicio el error provider para volver a reemarcar
            errorProvider1.Clear();
            Espacios_Vacios = false;
            for (int i = 0; i < Campos.Length; i++)
            {
                if (Campos[i].Text.Trim() == "")
                {
                    Indicador_CamposVaciosP(i);
                    Espacios_Vacios = true;
                }
            }
            return Espacios_Vacios;
        }
        private void Indicador_CamposVaciosP(int i)
        {
            switch (i)
            {
                case 0:
                    errorProvider1.SetError(txt_Lotep, "No puedes dejar el campo vacio");
                    break;
                case 1:
                    errorProvider1.SetError(txt_Exisnteciap, "No puedes dejar el campo vacio");
                    break;
                case 2:
                    errorProvider1.SetError(txt_PrecioComprap, "No puedes dejar el campo vacio");
                    break;
                case 3:
                    errorProvider1.SetError(txt_PrecioVentap, "No puedes dejar el campo vacio");
                    break;
                default:
                    break;
            }
        }
        //----------------------------------------------
        //---  Tercera pestaña carga de elementos  -----
        //----------------------------------------------
        //Llenando comboBox de Almacen
        private void Llenando_AlmacenMateriaPrimaE()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand coman = new OleDbCommand();
            OleDbDataReader dr;
            con.ConnectionString = ObtenerString();
            coman.Connection = con;
            coman.CommandText = "Select Nombre from Tb_Almacen where Activo= 'S'";
            coman.CommandType = CommandType.Text;
            con.Open();
            combo_Almacene.Items.Clear();
            dr = coman.ExecuteReader();
            while (dr.Read())
            {
                //Declarando Variables y obteniendo los valores correspondiente
                string Nombre = dr.GetString(dr.GetOrdinal("Nombre"));
                combo_Almacene.Items.Add(Nombre);
            }
            con.Close();
        }
        //Llenando comboBox de MateriaPrima
        private void Llenando_ProductoElaborado()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand coman = new OleDbCommand();
            OleDbDataReader dr;
            con.ConnectionString = ObtenerString();
            coman.Connection = con;
            coman.CommandText = "SELECT Nombre FROM Tb_ProductoElaborado where Activo= 'S'";
            coman.CommandType = CommandType.Text;
            con.Open();
            comboBox_ProductoElaborado.Items.Clear();
            dr = coman.ExecuteReader();
            while (dr.Read())
            {
                comboBox_ProductoElaborado.Items.Add(dr.GetString(dr.GetOrdinal("Nombre")));
            }
            con.Close();
        }
        private void Llenando_DataGridViewProductoElaborado()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand coman = new OleDbCommand();
            OleDbDataReader dr;
            con.ConnectionString = ObtenerString();
            coman.Connection = con;
            coman.CommandText = "SELECT Tb_AlmacenProductoElaborado.*, Tb_ProductoElaborado.Nombre FROM Tb_AlmacenProductoElaborado INNER JOIN Tb_ProductoElaborado ON Tb_AlmacenProductoElaborado.Id_ProductoElaborado = Tb_ProductoElaborado.Id_ProductoElaborado where Tb_AlmacenProductoElaborado.Activo= 'S'";
            coman.CommandType = CommandType.Text;
            con.Open();
            data_ProductoElaborado.Rows.Clear();
            dr = coman.ExecuteReader();
            while (dr.Read())
            {
                //Creando y obteniendo el indice para un nuevo renglon
                int Indice = data_ProductoElaborado.Rows.Add();
                data_ProductoElaborado.Rows[Indice].Cells["Id_AlmacenProductoElaborado"].Value = dr.GetInt32(dr.GetOrdinal("Id_AlmacenProductoElaborado"));
                data_ProductoElaborado.Rows[Indice].Cells["Id_Almacene"].Value = dr.GetInt32(dr.GetOrdinal("Id_Almacen"));
                data_ProductoElaborado.Rows[Indice].Cells["Id_ProductoElaborado"].Value = dr.GetInt32(dr.GetOrdinal("Id_ProductoElaborado"));
                data_ProductoElaborado.Rows[Indice].Cells["Producto"].Value = dr.GetString(dr.GetOrdinal("Nombre"));
                data_ProductoElaborado.Rows[Indice].Cells["Lotee"].Value = dr.GetString(dr.GetOrdinal("Lote"));
                data_ProductoElaborado.Rows[Indice].Cells["Existenciae"].Value = dr.GetDecimal(dr.GetOrdinal("Existencia"));
                data_ProductoElaborado.Rows[Indice].Cells["Precio_Comprae"].Value = dr.GetDecimal(dr.GetOrdinal("Precio_Compra")).ToString("N");
                data_ProductoElaborado.Rows[Indice].Cells["Precio_Ventae"].Value = dr.GetDecimal(dr.GetOrdinal("Precio_Venta")).ToString("N");
                data_ProductoElaborado.Rows[Indice].Cells["Fechae"].Value = dr.GetString(dr.GetOrdinal("Fecha"));
            }
            con.Close();
        }
        //Verificar espacios vacios
        private bool Verificar_CamposVaciosE()
        {
            //Se introduce los textbox en un arreglo con el fin de identificar espacios vacios
            Campos[0] = txt_Lotee;
            Campos[1] = txt_Existenciae;
            Campos[2] = txt_PrecioComprae;
            Campos[3] = txt_PrecioVentae;
            //Reinicio el error provider para volver a reemarcar
            errorProvider1.Clear();
            Espacios_Vacios = false;
            for (int i = 0; i < Campos.Length; i++)
            {
                if (Campos[i].Text.Trim() == "")
                {
                    Indicador_CamposVaciosE(i);
                    Espacios_Vacios = true;
                }
            }
            return Espacios_Vacios;
        }
        private void Indicador_CamposVaciosE(int i)
        {
            switch (i)
            {
                case 0:
                    errorProvider1.SetError(txt_Lotee, "No puedes dejar el campo vacio");
                    break;
                case 1:
                    errorProvider1.SetError(txt_Existenciae, "No puedes dejar el campo vacio");
                    break;
                case 2:
                    errorProvider1.SetError(txt_PrecioComprae, "No puedes dejar el campo vacio");
                    break;
                case 3:
                    errorProvider1.SetError(txt_PrecioVentae, "No puedes dejar el campo vacio");
                    break;
                default:
                    break;
            }
        }
        //----------------------------------------------
        //---  Cuarta pestaña carga de elementos  -----
        //----------------------------------------------
        //Llenando comboBox de Almacen
        private void Llenando_AlmacenProductoIndirecto()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand coman = new OleDbCommand();
            OleDbDataReader dr;
            con.ConnectionString = ObtenerString();
            coman.Connection = con;
            coman.CommandText = "Select Nombre from Tb_Almacen where Activo= 'S'";
            coman.CommandType = CommandType.Text;
            con.Open();
            combo_Almaceni.Items.Clear();
            dr = coman.ExecuteReader();
            while (dr.Read())
            {
                //Declarando Variables y obteniendo los valores correspondiente
                string Nombre = dr.GetString(dr.GetOrdinal("Nombre"));
                combo_Almaceni.Items.Add(Nombre);
            }
            con.Close();
        }
        //Llenando comboBox de MateriaPrima
        private void Llenando_ProductoIndirecto()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand coman = new OleDbCommand();
            OleDbDataReader dr;
            con.ConnectionString = ObtenerString();
            coman.Connection = con;
            coman.CommandText = "SELECT Nombre FROM Tb_ProductoIndirecto where Activo= 'S'";
            coman.CommandType = CommandType.Text;
            con.Open();
            comboBox_ProductoIndirecto.Items.Clear();
            dr = coman.ExecuteReader();
            while (dr.Read())
            {
                comboBox_ProductoIndirecto.Items.Add(dr.GetString(dr.GetOrdinal("Nombre")));
            }
            con.Close();
        }
        private void Llenando_DataGridViewProductoIndirecto()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand coman = new OleDbCommand();
            OleDbDataReader dr;
            con.ConnectionString = ObtenerString();
            coman.Connection = con;
            coman.CommandText = "SELECT Tb_AlmacenIndirecto.*, Tb_ProductoIndirecto.Nombre FROM Tb_AlmacenIndirecto INNER JOIN Tb_ProductoIndirecto ON Tb_AlmacenIndirecto.Id_ProductoIndirecto = Tb_ProductoIndirecto.Id_ProductoIndirecto where Tb_AlmacenIndirecto.Activo= 'S'";
            coman.CommandType = CommandType.Text;
            con.Open();
            data_ProductoIndirecto.Rows.Clear();
            dr = coman.ExecuteReader();
            while (dr.Read())
            {
                //Creando y obteniendo el indice para un nuevo renglon
                int Indice = data_ProductoIndirecto.Rows.Add();
                data_ProductoIndirecto.Rows[Indice].Cells["Id_AlmacenProductoIndirecto"].Value = dr.GetInt32(dr.GetOrdinal("Id_AlmacenIndirecto"));
                data_ProductoIndirecto.Rows[Indice].Cells["Id_Almaceni"].Value = dr.GetInt32(dr.GetOrdinal("Id_Almacen"));
                data_ProductoIndirecto.Rows[Indice].Cells["Id_ProductoIndirecto"].Value = dr.GetInt32(dr.GetOrdinal("Id_ProductoIndirecto"));
                data_ProductoIndirecto.Rows[Indice].Cells["Productoi"].Value = dr.GetString(dr.GetOrdinal("Nombre"));
                data_ProductoIndirecto.Rows[Indice].Cells["Existenciai"].Value = dr.GetInt32(dr.GetOrdinal("Existencia"));
                data_ProductoIndirecto.Rows[Indice].Cells["Precio_CompraI"].Value = dr.GetDecimal(dr.GetOrdinal("Precio_Compra")).ToString("N");
                data_ProductoIndirecto.Rows[Indice].Cells["Precio_Ventai"].Value = dr.GetDecimal(dr.GetOrdinal("Precio_Venta")).ToString("N");
                data_ProductoIndirecto.Rows[Indice].Cells["Fechai"].Value = dr.GetString(dr.GetOrdinal("Fecha"));
            }
            con.Close();
        }
        //Verificar espacios vacios
        private bool Verificar_CamposVaciosI()
        {
            //Se introduce los textbox en un arreglo con el fin de identificar espacios vacios
            Campos[0] = txt_Existenciai;
            Campos[1] = txt_PrecioComprai;
            Campos[2] = txt_PrecioVentai;
            Campos[3] = txt_PrecioVentai;
            //Reinicio el error provider para volver a reemarcar
            errorProvider1.Clear();
            Espacios_Vacios = false;
            for (int i = 0; i < Campos.Length; i++)
            {
                if (Campos[i].Text.Trim() == "")
                {
                    Indicador_CamposVaciosI(i);
                    Espacios_Vacios = true;
                }
            }
            return Espacios_Vacios;
        }
        private void Indicador_CamposVaciosI(int i)
        {
            switch (i)
            {
                case 0:
                    errorProvider1.SetError(txt_Existenciai, "No puedes dejar el campo vacio");
                    break;
                case 1:
                    errorProvider1.SetError(txt_PrecioComprai, "No puedes dejar el campo vacio");
                    break;
                case 2:
                    errorProvider1.SetError(txt_PrecioVentai, "No puedes dejar el campo vacio");
                    break;
                default:
                    break;
            }
        }
        //----------------------------------------------
        //---   Quinta pestaña carga de elementos  -----
        //----------------------------------------------
        //Llenando comboBox de Almacen
        private void Llenando_AlmacenProductoTerminado()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand coman = new OleDbCommand();
            OleDbDataReader dr;
            con.ConnectionString = ObtenerString();
            coman.Connection = con;
            coman.CommandText = "Select Nombre from Tb_Almacen where Activo= 'S'";
            coman.CommandType = CommandType.Text;
            con.Open();
            combo_Almacent.Items.Clear();
            dr = coman.ExecuteReader();
            while (dr.Read())
            {
                //Declarando Variables y obteniendo los valores correspondiente
                string Nombre = dr.GetString(dr.GetOrdinal("Nombre"));
                combo_Almacent.Items.Add(Nombre);
            }
            con.Close();
        }
        //Llenando comboBox de MateriaPrima
        private void Llenando_ProductoTerminado()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand coman = new OleDbCommand();
            OleDbDataReader dr;
            con.ConnectionString = ObtenerString();
            coman.Connection = con;
            coman.CommandText = "SELECT Nombre FROM Tb_ProductoTerminado where Activo= 'S'";
            coman.CommandType = CommandType.Text;
            con.Open();
            comboBox_ProductoTerminado.Items.Clear();
            dr = coman.ExecuteReader();
            while (dr.Read())
            {
                comboBox_ProductoTerminado.Items.Add(dr.GetString(dr.GetOrdinal("Nombre")));
            }
            con.Close();
        }
        private void Llenando_DataGridViewProductoTerminado()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand coman = new OleDbCommand();
            OleDbDataReader dr;
            con.ConnectionString = ObtenerString();
            coman.Connection = con;
            coman.CommandText = "SELECT Tb_AlmacenProducto.*, Tb_ProductoTerminado.Nombre FROM Tb_AlmacenProducto INNER JOIN Tb_ProductoTerminado ON Tb_AlmacenProducto.Id_ProductoTerminado = Tb_ProductoTerminado.Id_ProductoTerminado where Tb_AlmacenProducto.Activo= 'S'";
            coman.CommandType = CommandType.Text;
            con.Open();
            data_ProductoTerminado.Rows.Clear();
            dr = coman.ExecuteReader();
            while (dr.Read())
            {
                //Creando y obteniendo el indice para un nuevo renglon
                int Indice = data_ProductoTerminado.Rows.Add();
                data_ProductoTerminado.Rows[Indice].Cells["Id_AlmacenProducto"].Value = dr.GetInt32(dr.GetOrdinal("Id_AlmacenProducto"));
                data_ProductoTerminado.Rows[Indice].Cells["Id_Almacent"].Value = dr.GetInt32(dr.GetOrdinal("Id_Almacen"));
                data_ProductoTerminado.Rows[Indice].Cells["Id_ProductoTerminado"].Value = dr.GetInt32(dr.GetOrdinal("Id_ProductoTerminado"));
                data_ProductoTerminado.Rows[Indice].Cells["Productot"].Value = dr.GetString(dr.GetOrdinal("Nombre"));
                data_ProductoTerminado.Rows[Indice].Cells["Lotet"].Value = dr.GetString(dr.GetOrdinal("Lote"));
                data_ProductoTerminado.Rows[Indice].Cells["Existenciat"].Value = dr.GetInt32(dr.GetOrdinal("Existencia"));
                data_ProductoTerminado.Rows[Indice].Cells["Precio_Comprat"].Value = dr.GetDecimal(dr.GetOrdinal("Precio_Compra")).ToString("N");
                data_ProductoTerminado.Rows[Indice].Cells["Precio_Ventat"].Value = dr.GetDecimal(dr.GetOrdinal("Precio_Venta")).ToString("N");
                data_ProductoTerminado.Rows[Indice].Cells["Descuento"].Value = dr.GetDecimal(dr.GetOrdinal("Descuento")).ToString("N");
                data_ProductoTerminado.Rows[Indice].Cells["Fechat"].Value = dr.GetString(dr.GetOrdinal("Fecha"));
            }
            con.Close();
        }
        //Verificar espacios vacios
        private bool Verificar_CamposVaciosT()
        {
            //Se introduce los textbox en un arreglo con el fin de identificar espacios vacios
            Campos[0] = txt_Lotet;
            Campos[1] = txt_Existenciat;
            Campos[2] = txt_PrecioComprat;
            Campos[3] = txt_PrecioVentat;
            //Reinicio el error provider para volver a reemarcar
            errorProvider1.Clear();
            Espacios_Vacios = false;
            for (int i = 0; i < Campos.Length; i++)
            {
                if (Campos[i].Text.Trim() == "")
                {
                    Indicador_CamposVaciosT(i);
                    Espacios_Vacios = true;
                }
            }
            return Espacios_Vacios;
        }
        private void Indicador_CamposVaciosT(int i)
        {
            switch (i)
            {
                case 0:
                    errorProvider1.SetError(txt_Lotet, "No puedes dejar el campo vacio");
                    break;
                case 1:
                    errorProvider1.SetError(txt_Existenciat, "No puedes dejar el campo vacio");
                    break;
                case 2:
                    errorProvider1.SetError(txt_PrecioComprat, "No puedes dejar el campo vacio");
                    break;
                case 3:
                    errorProvider1.SetError(txt_PrecioVentat, "No puedes dejar el campo vacio");
                    break;
                default:
                    break;
            }
        }
        //-------------------------------------------------------------
        //------------------DATAGRIDVIEW BUSQUEDA----------------------
        //-------------------------------------------------------------
        //ACCION QUE REALIZA CUANDO SE DA DOBLE CLIC SOBRE EL DATAGRIDVIEW
        private void data_MateriaPrima_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Idp = Convert.ToInt32(data_MateriaPrima.CurrentRow.Cells["Id_AlmacenMateriaPrimam"].Value);
            Limpiar();
            BusquedaDatos(Idp);
            modificarToolStripMenuItem.Enabled = true;
            eliminarToolStripMenuItem.Enabled = true;
        }
        private void data_MateriaPrimaP_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Idp = Convert.ToInt32(data_MateriaPrimaP.CurrentRow.Cells["Id_AlmacenMateriaPrimaP"].Value);
            Limpiar();
            BusquedaDatos(Idp);
            modificarToolStripMenuItem.Enabled = true;
            eliminarToolStripMenuItem.Enabled = true;
        }
        private void data_ProductoElaborado_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Idp = Convert.ToInt32(data_ProductoElaborado.CurrentRow.Cells["Id_AlmacenProductoElaborado"].Value);
            Limpiar();
            BusquedaDatos(Idp);
            modificarToolStripMenuItem.Enabled = true;
            eliminarToolStripMenuItem.Enabled = true;
        }
        private void data_ProductoIndirecto_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Idp = Convert.ToInt32(data_ProductoIndirecto.CurrentRow.Cells["Id_AlmacenProductoIndirecto"].Value);
            Limpiar();
            BusquedaDatos(Idp);
            modificarToolStripMenuItem.Enabled = true;
            eliminarToolStripMenuItem.Enabled = true;
        }
        private void data_ProductoTerminado_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Idp = Convert.ToInt32(data_ProductoTerminado.CurrentRow.Cells["Id_AlmacenProducto"].Value);
            Limpiar();
            BusquedaDatos(Idp);
            modificarToolStripMenuItem.Enabled = true;
            eliminarToolStripMenuItem.Enabled = true;
        }
        private void data_resultado_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Limpiar();
            string ficha = tabControl1.SelectedIndex.ToString();
            if (ficha == "0")
            {
                Idp = Convert.ToInt32(data_resultado.CurrentRow.Cells["Idb"].Value);
                BusquedaDatos(Idp);
            }
            else if (ficha == "1")
            {
                Idp = Convert.ToInt32(data_resultado.CurrentRow.Cells["Idb"].Value);
                BusquedaDatos(Idp);
            }
            else if (ficha == "2")
            {
                Idp = Convert.ToInt32(data_resultado.CurrentRow.Cells["Idb"].Value);
                BusquedaDatos(Idp);
            }
            else if (ficha == "3")
            {
                Idp = Convert.ToInt32(data_resultado.CurrentRow.Cells["Idb"].Value);
                BusquedaDatos(Idp);
            }
            else if (ficha == "4")
            {
                Idp = Convert.ToInt32(data_resultado.CurrentRow.Cells["Idb"].Value);
                BusquedaDatos(Idp);
            }
            tabControl1.Visible = true;
            modificarToolStripMenuItem.Enabled = true;
            eliminarToolStripMenuItem.Enabled = true;
            //Quito el panel de busqueda
            Controls.Remove(panel_Busqueda);
        }
        //-------------------------------------------------------------
        //---------------PANEL DE NIVELES DE PRODUCTOS-----------------
        //-------------------------------------------------------------
        #region PanelControles_NivelProductos
        //Creando controles
        Panel panel_Niveles;
        DataGridView dataGridView_Niveles;
        GroupBox groupBox_Niveles;
        DataGridViewTextBoxColumn NId_Nivel;
        DataGridViewTextBoxColumn NId_Producto;
        DataGridViewTextBoxColumn NId_Almacen;
        DataGridViewTextBoxColumn NAlmacen;
        DataGridViewTextBoxColumn NProducto;
        DataGridViewTextBoxColumn NMin;
        DataGridViewTextBoxColumn NMax;
        GroupBox groupBox_DatosNivel;
        Label lbl_NProducto;
        Label lbl_NAlmacen;
        Label lbl_NMin;
        Label lbl_NMax;
        TextBox txt_NProducto;
        TextBox txt_NAlmacen;
        TextBox txt_NMin;
        TextBox txt_NMax;
        Button bttn_NGuardar;
        Button bttn_NCerrar;
        #endregion

        private void nivelMaxMinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CREANDO CONTROLES
            panel_Niveles = new System.Windows.Forms.Panel();
            dataGridView_Niveles = new System.Windows.Forms.DataGridView();
            groupBox_Niveles = new System.Windows.Forms.GroupBox();
            groupBox_DatosNivel = new System.Windows.Forms.GroupBox();
            lbl_NProducto = new System.Windows.Forms.Label();
            lbl_NAlmacen = new System.Windows.Forms.Label();
            lbl_NMin = new System.Windows.Forms.Label();
            lbl_NMax = new System.Windows.Forms.Label();
            txt_NProducto = new System.Windows.Forms.TextBox();
            txt_NAlmacen = new System.Windows.Forms.TextBox();
            txt_NMin = new System.Windows.Forms.TextBox();
            txt_NMax = new System.Windows.Forms.TextBox();
            NId_Nivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            NId_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            NId_Almacen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            NAlmacen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            NProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            NMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            NMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            bttn_NGuardar = new System.Windows.Forms.Button();
            bttn_NCerrar = new System.Windows.Forms.Button();
            //CREANDO DISEÑO DE LOS CONTROLES
            // 
            // panel_Niveles
            // 
            panel_Niveles.Controls.Add(groupBox_DatosNivel);
            panel_Niveles.Controls.Add(groupBox_Niveles);
            panel_Niveles.Location = new System.Drawing.Point(16, 83);
            panel_Niveles.Name = "panel_Niveles";
            panel_Niveles.Size = new System.Drawing.Size(798, 403);
            panel_Niveles.TabIndex = 0;
            // 
            // groupBox_DatosNivel
            // 
            groupBox_DatosNivel.Controls.Add(bttn_NGuardar);
            groupBox_DatosNivel.Controls.Add(bttn_NCerrar);
            groupBox_DatosNivel.Controls.Add(txt_NMax);
            groupBox_DatosNivel.Controls.Add(txt_NMin);
            groupBox_DatosNivel.Controls.Add(txt_NAlmacen);
            groupBox_DatosNivel.Controls.Add(txt_NProducto);
            groupBox_DatosNivel.Controls.Add(lbl_NMax);
            groupBox_DatosNivel.Controls.Add(lbl_NMin);
            groupBox_DatosNivel.Controls.Add(lbl_NAlmacen);
            groupBox_DatosNivel.Controls.Add(lbl_NProducto);
            groupBox_DatosNivel.Location = new System.Drawing.Point(10, 8);
            groupBox_DatosNivel.Name = "groupBox_DatosNivel";
            groupBox_DatosNivel.Size = new System.Drawing.Size(315, 386);
            groupBox_DatosNivel.TabIndex = 1;
            groupBox_DatosNivel.TabStop = false;
            groupBox_DatosNivel.Text = "Datos";
            // 
            // txt_NMax
            // 
            txt_NMax.Location = new System.Drawing.Point(121, 137);
            txt_NMax.Name = "txt_NMax";
            txt_NMax.Size = new System.Drawing.Size(100, 20);
            txt_NMax.KeyPress += new KeyPressEventHandler(txt_MinMax_KeyPress);
            txt_NMax.TabIndex = 7;
            // 
            // txt_NMin
            // 
            txt_NMin.Location = new System.Drawing.Point(121, 104);
            txt_NMin.Name = "txt_NMin";
            txt_NMin.Size = new System.Drawing.Size(100, 20);
            txt_NMin.KeyPress += new KeyPressEventHandler(txt_MinMax_KeyPress);
            txt_NMin.TabIndex = 6;
            // 
            // txt_NAlmacen
            // 
            txt_NAlmacen.Location = new System.Drawing.Point(121, 70);
            txt_NAlmacen.Name = "txt_NAlmacen";
            txt_NAlmacen.Size = new System.Drawing.Size(121, 21);
            txt_NAlmacen.Enabled = false;
            txt_NAlmacen.TabIndex = 5;
            // 
            // txt_NProducto
            // 
            txt_NProducto.Location = new System.Drawing.Point(121, 36);
            txt_NProducto.Name = "txt_NProducto";
            txt_NProducto.Size = new System.Drawing.Size(121, 21);
            txt_NProducto.Enabled = false;
            txt_NProducto.TabIndex = 4;
            // 
            // lbl_NMax
            // 
            lbl_NMax.AutoSize = true;
            lbl_NMax.Location = new System.Drawing.Point(20, 144);
            lbl_NMax.Name = "lbl_NMax";
            lbl_NMax.Size = new System.Drawing.Size(87, 13);
            lbl_NMax.TabIndex = 3;
            lbl_NMax.Text = "Cantidad máxima";
            // 
            // lbl_NMin
            // 
            lbl_NMin.AutoSize = true;
            lbl_NMin.Location = new System.Drawing.Point(20, 111);
            lbl_NMin.Name = "lbl_NMin";
            lbl_NMin.Size = new System.Drawing.Size(86, 13);
            lbl_NMin.TabIndex = 2;
            lbl_NMin.Text = "Cantidad mínima";
            // 
            // lbl_NAlmacen
            // 
            lbl_NAlmacen.AutoSize = true;
            lbl_NAlmacen.Location = new System.Drawing.Point(22, 78);
            lbl_NAlmacen.Name = "lbl_NAlmacen";
            lbl_NAlmacen.Size = new System.Drawing.Size(48, 13);
            lbl_NAlmacen.TabIndex = 1;
            lbl_NAlmacen.Text = "Almacén";
            // 
            // lbl_NProducto
            // 
            lbl_NProducto.AutoSize = true;
            lbl_NProducto.Location = new System.Drawing.Point(20, 44);
            lbl_NProducto.Name = "lbl_NProducto";
            lbl_NProducto.Size = new System.Drawing.Size(50, 13);
            lbl_NProducto.TabIndex = 0;
            lbl_NProducto.Text = "Producto";
            // 
            // groupBox_Niveles
            // 
            groupBox_Niveles.Controls.Add(dataGridView_Niveles);
            groupBox_Niveles.Location = new System.Drawing.Point(339, 8);
            groupBox_Niveles.Name = "groupBox_Niveles";
            groupBox_Niveles.Size = new System.Drawing.Size(449, 386);
            groupBox_Niveles.TabIndex = 1;
            groupBox_Niveles.TabStop = false;
            groupBox_Niveles.Text = "Nivel de productos";
            // 
            // dataGridView_Niveles
            // 
            dataGridView_Niveles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Niveles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Niveles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            NId_Nivel,
            NId_Producto,
            NId_Almacen,
            NAlmacen,
            NProducto,
            NMin,
            NMax});
            dataGridView_Niveles.Location = new System.Drawing.Point(6, 19);
            dataGridView_Niveles.Name = "dataGridView_Niveles";
            dataGridView_Niveles.Size = new System.Drawing.Size(437, 361);
            dataGridView_Niveles.TabIndex = 0;
            dataGridView_Niveles.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(dataGridView_Niveles_MouseDoubleClick);
            // 
            // NId_Nivel
            // 
            NId_Nivel.HeaderText = "Id_Nivel";
            NId_Nivel.Name = "NId_Nivel";
            NId_Nivel.Visible = false;
            // 
            // NId_Producto
            // 
            NId_Producto.HeaderText = "Id_Producto";
            NId_Producto.Name = "NId_Producto";
            NId_Producto.Visible = false;
            // 
            // NId_Almacen
            // 
            NId_Almacen.HeaderText = "Id_Almacen";
            NId_Almacen.Name = "NId_Almacen";
            NId_Almacen.Visible = false;
            // 
            // NAlmacen
            // 
            NAlmacen.HeaderText = "Almacen";
            NAlmacen.Name = "NAlmacen";
            // 
            // NProducto
            // 
            NProducto.HeaderText = "Producto";
            NProducto.Name = "NProducto";
            // 
            // NMin
            // 
            NMin.HeaderText = "Cantidad mínima";
            NMin.Name = "NMin";
            // 
            // NMax
            // 
            NMax.HeaderText = "Cantidad máxima";
            NMax.Name = "NMax";
            // 
            // bttn_NGuardar
            // 
            bttn_NGuardar.BackgroundImage = global::Shajobe.Properties.Resources.Guardar;
            bttn_NGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            bttn_NGuardar.Location = new System.Drawing.Point(254, 96);
            bttn_NGuardar.Name = "bttn_NGuardar";
            bttn_NGuardar.Size = new System.Drawing.Size(55, 61);
            bttn_NGuardar.Click += new EventHandler(bttn_NGuardar_Click);
            bttn_NGuardar.TabIndex = 1;
            bttn_NGuardar.UseVisualStyleBackColor = true;
            // 
            // bttn_NCerrar
            // 
            bttn_NCerrar.BackgroundImage = global::Shajobe.Properties.Resources.cerrar;
            bttn_NCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            bttn_NCerrar.Location = new System.Drawing.Point(188, 338);
            bttn_NCerrar.Name = "bttn_NCerrar";
            bttn_NCerrar.Size = new System.Drawing.Size(121, 42);
            bttn_NCerrar.Click += new EventHandler(bttn_NCerrar_Click);
            bttn_NCerrar.TabIndex = 2;
            bttn_NCerrar.UseVisualStyleBackColor = true;
            //AGREGANDO EL CONTROL AL FORMULARIO
            Controls.Add(panel_Niveles);
            tabControl1.Visible = false;
            //Llenando los datagridView dependiendo de la opción
            Sub_LlenadoNiveles_DatagridView();
        }
        //-------------------------------------------------------------
        //----------------Limpia y restablece controles----------------
        //-------------------------------------------------------------
        private void Sub_Limpiar()
        {
            txt_NAlmacen.Clear();
            txt_NMax.Clear();
            txt_NMin.Clear();
            txt_NProducto.Clear();
            Sub_LlenadoNiveles_DatagridView();
        }
        private void Sub_LlenadoNiveles_DatagridView()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand coman = new OleDbCommand();
            OleDbDataReader dr;
            //Llenando el comboBox segun el tab que se encuentre activo y el datagridView
            string ficha = tabControl1.SelectedIndex.ToString();
            if (ficha == "0")
            {
                //Llenando el dataGridView
                con.ConnectionString = ObtenerString();
                coman.Connection = con;
                coman.CommandText = "SELECT Tb_Nivel_MateriaPrima.*, Tb_MateriaPrima.Nombre AS Nombre_MateriaPrima, Tb_TipoPieza.Nombre AS Nombre_TipoPieza, Tb_Almacen.Nombre AS Nombre_Almacen FROM Tb_Nivel_MateriaPrima INNER JOIN Tb_MateriaPrima ON Tb_Nivel_MateriaPrima.Id_MateriaPrima = Tb_MateriaPrima.Id_MateriaPrima INNER JOIN Tb_TipoPieza ON Tb_MateriaPrima.Id_TipoPieza = Tb_TipoPieza.Id_TipoPieza INNER JOIN Tb_AlmacenMateriaPrima ON Tb_Nivel_MateriaPrima.Id_AlmacenMateriaPrima = Tb_AlmacenMateriaPrima.Id_AlmacenMateriaPrima AND Tb_MateriaPrima.Id_MateriaPrima = Tb_AlmacenMateriaPrima.Id_MateriaPrima INNER JOIN Tb_Almacen ON Tb_AlmacenMateriaPrima.Id_Almacen = Tb_Almacen.Id_Almacen where Tb_Nivel_MateriaPrima.Activo='S'";
                coman.CommandType = CommandType.Text;
                con.Open();
                dataGridView_Niveles.Rows.Clear();
                dr = coman.ExecuteReader();
                while (dr.Read())
                {
                    //Creando y obteniendo el indice para un nuevo renglon
                    int Indice = dataGridView_Niveles.Rows.Add();
                    dataGridView_Niveles.Rows[Indice].Cells["NId_Nivel"].Value = dr.GetInt32(dr.GetOrdinal("Id_NivelMateriaPrima"));
                    dataGridView_Niveles.Rows[Indice].Cells["NId_Producto"].Value = dr.GetInt32(dr.GetOrdinal("Id_MateriaPrima"));
                    dataGridView_Niveles.Rows[Indice].Cells["NId_Almacen"].Value = dr.GetInt32(dr.GetOrdinal("Id_AlmacenMateriaPrima"));
                    dataGridView_Niveles.Rows[Indice].Cells["NAlmacen"].Value = dr.GetString(dr.GetOrdinal("Nombre_Almacen"));
                    //Declarando Variables y obteniendo los valores correspondiente
                    string Nombre_MateriaPrima = dr.GetString(dr.GetOrdinal("Nombre_MateriaPrima"));
                    //Declarando Variables y obteniendo los valores correspondiente
                    string Nombre_TipoPieza = dr.GetString(dr.GetOrdinal("Nombre_TipoPieza"));
                    string Nombre_Completo = Nombre_MateriaPrima + " " + Nombre_TipoPieza;
                    dataGridView_Niveles.Rows[Indice].Cells["NProducto"].Value = Nombre_Completo;
                    dataGridView_Niveles.Rows[Indice].Cells["NMin"].Value = dr.GetDecimal(dr.GetOrdinal("Min"));
                    dataGridView_Niveles.Rows[Indice].Cells["NMax"].Value = dr.GetDecimal(dr.GetOrdinal("Max"));
                }
                con.Close();
            }
            else if (ficha == "1")
            {
                //Llenando el dataGridView
                con.ConnectionString = ObtenerString();
                coman.Connection = con;
                coman.CommandText = "SELECT Tb_Nivel_MateriaPrimaP.*, Tb_MateriaPrimaP.Nombre AS Nombre_MateriaPrima, Tb_Almacen.Nombre AS Nombre_Almacen FROM Tb_Nivel_MateriaPrimaP INNER JOIN Tb_MateriaPrimaP ON Tb_Nivel_MateriaPrimaP.Id_MateriaPrimaP = Tb_MateriaPrimaP.Id_MateriaPrimaP INNER JOIN Tb_AlmacenMateriaPrimaP ON Tb_Nivel_MateriaPrimaP.Id_AlmacenMateriaPrimaP = Tb_AlmacenMateriaPrimaP.Id_AlmacenMateriaPrimaP AND  Tb_MateriaPrimaP.Id_MateriaPrimaP = Tb_AlmacenMateriaPrimaP.Id_MateriaPrimaP INNER JOIN Tb_Almacen ON Tb_AlmacenMateriaPrimaP.Id_Almacen = Tb_Almacen.Id_Almacen where Tb_Nivel_MateriaPrimaP.Activo='S'";
                coman.CommandType = CommandType.Text;
                con.Open();
                dataGridView_Niveles.Rows.Clear();
                dr = coman.ExecuteReader();
                while (dr.Read())
                {
                    //Creando y obteniendo el indice para un nuevo renglon
                    int Indice = dataGridView_Niveles.Rows.Add();
                    dataGridView_Niveles.Rows[Indice].Cells["NId_Nivel"].Value = dr.GetInt32(dr.GetOrdinal("Id_NivelMateriaPrimaP"));
                    dataGridView_Niveles.Rows[Indice].Cells["NId_Producto"].Value = dr.GetInt32(dr.GetOrdinal("Id_MateriaPrimaP"));
                    dataGridView_Niveles.Rows[Indice].Cells["NId_Almacen"].Value = dr.GetInt32(dr.GetOrdinal("Id_AlmacenMateriaPrimaP"));
                    dataGridView_Niveles.Rows[Indice].Cells["NAlmacen"].Value = dr.GetString(dr.GetOrdinal("Nombre_Almacen"));
                    dataGridView_Niveles.Rows[Indice].Cells["NProducto"].Value = dr.GetString(dr.GetOrdinal("Nombre_MateriaPrima")); ;
                    dataGridView_Niveles.Rows[Indice].Cells["NMin"].Value = dr.GetInt32(dr.GetOrdinal("Min"));
                    dataGridView_Niveles.Rows[Indice].Cells["NMax"].Value = dr.GetInt32(dr.GetOrdinal("Max"));
                }
                con.Close();
            }
            else if (ficha == "2")
            {
                //Llenando el dataGridView
                con.ConnectionString = ObtenerString();
                coman.Connection = con;
                coman.CommandText = "SELECT Tb_Almacen.Nombre AS Nombre_Almacen, Tb_ProductoElaborado.Nombre AS Nombre_Producto, Tb_Nivel_Elaborado.* FROM Tb_Nivel_Elaborado INNER JOIN Tb_ProductoElaborado ON Tb_Nivel_Elaborado.Id_ProductoElaborado = Tb_ProductoElaborado.Id_ProductoElaborado INNER JOIN Tb_AlmacenProductoElaborado ON Tb_Nivel_Elaborado.Id_AlmacenProductoElaborado = Tb_AlmacenProductoElaborado.Id_AlmacenProductoElaborado AND Tb_ProductoElaborado.Id_ProductoElaborado = Tb_AlmacenProductoElaborado.Id_ProductoElaborado INNER JOIN Tb_Almacen ON Tb_AlmacenProductoElaborado.Id_Almacen = Tb_Almacen.Id_Almacen where Tb_Nivel_Elaborado.Activo='S'";
                coman.CommandType = CommandType.Text;
                con.Open();
                dataGridView_Niveles.Rows.Clear();
                dr = coman.ExecuteReader();
                while (dr.Read())
                {
                    //Creando y obteniendo el indice para un nuevo renglon
                    int Indice = dataGridView_Niveles.Rows.Add();
                    dataGridView_Niveles.Rows[Indice].Cells["NId_Nivel"].Value = dr.GetInt32(dr.GetOrdinal("Id_NivelElaborado"));
                    dataGridView_Niveles.Rows[Indice].Cells["NId_Producto"].Value = dr.GetInt32(dr.GetOrdinal("Id_ProductoElaborado"));
                    dataGridView_Niveles.Rows[Indice].Cells["NId_Almacen"].Value = dr.GetInt32(dr.GetOrdinal("Id_AlmacenProductoElaborado"));
                    dataGridView_Niveles.Rows[Indice].Cells["NAlmacen"].Value = dr.GetString(dr.GetOrdinal("Nombre_Almacen"));
                    dataGridView_Niveles.Rows[Indice].Cells["NProducto"].Value = dr.GetString(dr.GetOrdinal("Nombre_Producto")); ;
                    dataGridView_Niveles.Rows[Indice].Cells["NMin"].Value = dr.GetDecimal(dr.GetOrdinal("Min"));
                    dataGridView_Niveles.Rows[Indice].Cells["NMax"].Value = dr.GetDecimal(dr.GetOrdinal("Max"));
                }
                con.Close();
            }
            else if (ficha == "3")
            {
                //Llenando el dataGridView
                con.ConnectionString = ObtenerString();
                coman.Connection = con;
                coman.CommandText = "SELECT Tb_Nivel_Indirecto.*, Tb_ProductoIndirecto.Nombre AS Nombre_Producto, Tb_Almacen.Nombre AS Nombre_Almacen FROM Tb_Nivel_Indirecto INNER JOIN Tb_ProductoIndirecto ON Tb_Nivel_Indirecto.Id_ProductoIndirecto = Tb_ProductoIndirecto.Id_ProductoIndirecto INNER JOIN Tb_AlmacenIndirecto ON Tb_Nivel_Indirecto.Id_AlmacenIndirecto = Tb_AlmacenIndirecto.Id_AlmacenIndirecto AND Tb_ProductoIndirecto.Id_ProductoIndirecto = Tb_AlmacenIndirecto.Id_ProductoIndirecto INNER JOIN Tb_Almacen ON Tb_AlmacenIndirecto.Id_Almacen = Tb_Almacen.Id_Almacen where Tb_Nivel_Indirecto.Activo='S'";
                coman.CommandType = CommandType.Text;
                con.Open();
                dataGridView_Niveles.Rows.Clear();
                dr = coman.ExecuteReader();
                while (dr.Read())
                {
                    //Creando y obteniendo el indice para un nuevo renglon
                    int Indice = dataGridView_Niveles.Rows.Add();
                    dataGridView_Niveles.Rows[Indice].Cells["NId_Nivel"].Value = dr.GetInt32(dr.GetOrdinal("Id_NivelIndirecto"));
                    dataGridView_Niveles.Rows[Indice].Cells["NId_Producto"].Value = dr.GetInt32(dr.GetOrdinal("Id_ProductoIndirecto"));
                    dataGridView_Niveles.Rows[Indice].Cells["NId_Almacen"].Value = dr.GetInt32(dr.GetOrdinal("Id_AlmacenIndirecto"));
                    dataGridView_Niveles.Rows[Indice].Cells["NAlmacen"].Value = dr.GetString(dr.GetOrdinal("Nombre_Almacen"));
                    dataGridView_Niveles.Rows[Indice].Cells["NProducto"].Value = dr.GetString(dr.GetOrdinal("Nombre_Producto")); ;
                    dataGridView_Niveles.Rows[Indice].Cells["NMin"].Value = dr.GetInt32(dr.GetOrdinal("Min"));
                    dataGridView_Niveles.Rows[Indice].Cells["NMax"].Value = dr.GetInt32(dr.GetOrdinal("Max"));
                }
                con.Close();
            }
            else if (ficha == "4")
            {
                //Llenando el dataGridView
                con.ConnectionString = ObtenerString();
                coman.Connection = con;
                coman.CommandText = "SELECT Tb_Nivel_ProductoTerminado.*, Tb_ProductoTerminado.Nombre AS Nombre_Producto, Tb_Almacen.Nombre AS Nombre_Almacen FROM Tb_Nivel_ProductoTerminado INNER JOIN Tb_ProductoTerminado ON Tb_Nivel_ProductoTerminado.Id_ProductoTerminado = Tb_ProductoTerminado.Id_ProductoTerminado INNER JOIN Tb_AlmacenProducto ON Tb_Nivel_ProductoTerminado.Id_AlmacenProducto = Tb_AlmacenProducto.Id_AlmacenProducto AND Tb_ProductoTerminado.Id_ProductoTerminado = Tb_AlmacenProducto.Id_ProductoTerminado INNER JOIN Tb_Almacen ON Tb_AlmacenProducto.Id_Almacen = Tb_Almacen.Id_Almacen where Tb_Nivel_ProductoTerminado.Activo='S'";
                coman.CommandType = CommandType.Text;
                con.Open();
                dataGridView_Niveles.Rows.Clear();
                dr = coman.ExecuteReader();
                while (dr.Read())
                {
                    //Creando y obteniendo el indice para un nuevo renglon
                    int Indice = dataGridView_Niveles.Rows.Add();
                    dataGridView_Niveles.Rows[Indice].Cells["NId_Nivel"].Value = dr.GetInt32(dr.GetOrdinal("Id_NivelProducto"));
                    dataGridView_Niveles.Rows[Indice].Cells["NId_Producto"].Value = dr.GetInt32(dr.GetOrdinal("Id_ProductoTerminado"));
                    dataGridView_Niveles.Rows[Indice].Cells["NId_Almacen"].Value = dr.GetInt32(dr.GetOrdinal("Id_AlmacenProducto"));
                    dataGridView_Niveles.Rows[Indice].Cells["NAlmacen"].Value = dr.GetString(dr.GetOrdinal("Nombre_Almacen"));
                    dataGridView_Niveles.Rows[Indice].Cells["NProducto"].Value = dr.GetString(dr.GetOrdinal("Nombre_Producto")); ;
                    dataGridView_Niveles.Rows[Indice].Cells["NMin"].Value = dr.GetInt32(dr.GetOrdinal("Min"));
                    dataGridView_Niveles.Rows[Indice].Cells["NMax"].Value = dr.GetInt32(dr.GetOrdinal("Max"));
                }
                con.Close();
            }
        }
        //-------------------------------------------------------------
        //------------------DATAGRIDVIEW BUSQUEDA----------------------
        //-------------------------------------------------------------
        private void dataGridView_Niveles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //Sub_Limpiar();
            string ficha = tabControl1.SelectedIndex.ToString();
            if (ficha == "0")
            {
                Idp = Convert.ToInt32(dataGridView_Niveles.CurrentRow.Cells["NId_Nivel"].Value);
                //Lleno los textbox con los datos cargados previamente en el datagridview
                txt_NProducto.Text = Convert.ToString(dataGridView_Niveles.CurrentRow.Cells["NProducto"].Value); ;
                txt_NAlmacen.Text = Convert.ToString(dataGridView_Niveles.CurrentRow.Cells["NAlmacen"].Value);
                txt_NMax.Text = Convert.ToString(dataGridView_Niveles.CurrentRow.Cells["NMax"].Value);
                txt_NMin.Text = Convert.ToString(dataGridView_Niveles.CurrentRow.Cells["NMin"].Value);
                //BusquedaDatos_Nivel(Idp);
            }
            else if (ficha == "1")
            {
                Idp = Convert.ToInt32(dataGridView_Niveles.CurrentRow.Cells["NId_Nivel"].Value);
                //Lleno los textbox con los datos cargados previamente en el datagridview
                txt_NProducto.Text = Convert.ToString(dataGridView_Niveles.CurrentRow.Cells["NProducto"].Value); ;
                txt_NAlmacen.Text = Convert.ToString(dataGridView_Niveles.CurrentRow.Cells["NAlmacen"].Value);
                txt_NMax.Text = Convert.ToString(dataGridView_Niveles.CurrentRow.Cells["NMax"].Value);
                txt_NMin.Text = Convert.ToString(dataGridView_Niveles.CurrentRow.Cells["NMin"].Value);
            }
            else if (ficha == "2")
            {
                Idp = Convert.ToInt32(dataGridView_Niveles.CurrentRow.Cells["NId_Nivel"].Value);
                //Lleno los textbox con los datos cargados previamente en el datagridview
                txt_NProducto.Text = Convert.ToString(dataGridView_Niveles.CurrentRow.Cells["NProducto"].Value); ;
                txt_NAlmacen.Text = Convert.ToString(dataGridView_Niveles.CurrentRow.Cells["NAlmacen"].Value);
                txt_NMax.Text = Convert.ToString(dataGridView_Niveles.CurrentRow.Cells["NMax"].Value);
                txt_NMin.Text = Convert.ToString(dataGridView_Niveles.CurrentRow.Cells["NMin"].Value);
            }
            else if (ficha == "3")
            {
                Idp = Convert.ToInt32(dataGridView_Niveles.CurrentRow.Cells["NId_Nivel"].Value);
                //Lleno los textbox con los datos cargados previamente en el datagridview
                txt_NProducto.Text = Convert.ToString(dataGridView_Niveles.CurrentRow.Cells["NProducto"].Value); ;
                txt_NAlmacen.Text = Convert.ToString(dataGridView_Niveles.CurrentRow.Cells["NAlmacen"].Value);
                txt_NMax.Text = Convert.ToString(dataGridView_Niveles.CurrentRow.Cells["NMax"].Value);
                txt_NMin.Text = Convert.ToString(dataGridView_Niveles.CurrentRow.Cells["NMin"].Value);
            }
            else if (ficha == "4")
            {
                Idp = Convert.ToInt32(dataGridView_Niveles.CurrentRow.Cells["NId_Nivel"].Value);
                //Lleno los textbox con los datos cargados previamente en el datagridview
                txt_NProducto.Text = Convert.ToString(dataGridView_Niveles.CurrentRow.Cells["NProducto"].Value); ;
                txt_NAlmacen.Text = Convert.ToString(dataGridView_Niveles.CurrentRow.Cells["NAlmacen"].Value);
                txt_NMax.Text = Convert.ToString(dataGridView_Niveles.CurrentRow.Cells["NMax"].Value);
                txt_NMin.Text = Convert.ToString(dataGridView_Niveles.CurrentRow.Cells["NMin"].Value);
            }
            //tabControl1.Visible = true;
            //modificarToolStripMenuItem.Enabled = true;
            //eliminarToolStripMenuItem.Enabled = true;
            //guardarToolStripMenuItem.Enabled = false;
        }
        //-------------------------------------------------------------
        //-------------------Validacion de campos----------------------
        //-------------------------------------------------------------
        private void txt_MinMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            //---------Apartado de numeros-------------Apartado de teclas especiales Retroceso y suprimir------------------------Uso del punto
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar < 7 || e.KeyChar > 9) && (e.KeyChar < 126 || e.KeyChar > 128) && (e.KeyChar < 45 || e.KeyChar > 47))
            {
                MessageBox.Show("Solo se aceptan numeros", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                e.Handled = true;
            }
        }
        //-------------------------------------------------------------
        //----------------CONFIGURACION DE CONTROLES-------------------
        //-------------------------------------------------------------
        private void bttn_NGuardar_Click(object sender, EventArgs e)
        {
            //Obtengo que ficha o que control esta activa para poder limpiar dicho control
            OleDbConnection conexion = null;
            OleDbTransaction transaccion = null;
            string ficha = tabControl1.SelectedIndex.ToString();
            if (ficha == "0")
            {
                try
                {
                    conexion = new OleDbConnection(ObtenerString());
                    conexion.Open();
                    transaccion = conexion.BeginTransaction(System.Data.IsolationLevel.Serializable);
                    OleDbCommand comando = new OleDbCommand("SP_NivelMateriaPrima_Cambios", conexion, transaccion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@Id_NivelMateriaPrima", Idp);
                    comando.Parameters.AddWithValue("@Min", Convert.ToDecimal(txt_NMin.Text));
                    comando.Parameters.AddWithValue("@Max", Convert.ToDecimal(txt_NMax.Text));
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
            else if (ficha == "1")
            {
                try
                {
                    conexion = new OleDbConnection(ObtenerString());
                    conexion.Open();
                    transaccion = conexion.BeginTransaction(System.Data.IsolationLevel.Serializable);
                    OleDbCommand comando = new OleDbCommand("SP_NivelMateriaPrimaP_Cambios", conexion, transaccion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@Id_NivelMateriaPrimaP", Idp);
                    comando.Parameters.AddWithValue("@Min", Convert.ToInt32(txt_NMin.Text));
                    comando.Parameters.AddWithValue("@Max", Convert.ToInt32(txt_NMax.Text));
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
            else if (ficha == "2")
            {
                try
                {
                    conexion = new OleDbConnection(ObtenerString());
                    conexion.Open();
                    transaccion = conexion.BeginTransaction(System.Data.IsolationLevel.Serializable);
                    OleDbCommand comando = new OleDbCommand("SP_NivelProductoElaborado_Cambios", conexion, transaccion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@Id_NivelElaborado", Idp);
                    comando.Parameters.AddWithValue("@Min", Convert.ToDecimal(txt_NMin.Text));
                    comando.Parameters.AddWithValue("@Max", Convert.ToDecimal(txt_NMax.Text));
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
            else if (ficha == "3")
            {
                try
                {
                    conexion = new OleDbConnection(ObtenerString());
                    conexion.Open();
                    transaccion = conexion.BeginTransaction(System.Data.IsolationLevel.Serializable);
                    OleDbCommand comando = new OleDbCommand("SP_NivelIndirecto_Cambios", conexion, transaccion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@Id_NivelIndirecto", Idp);
                    comando.Parameters.AddWithValue("@Min", Convert.ToInt32(txt_NMin.Text));
                    comando.Parameters.AddWithValue("@Max", Convert.ToInt32(txt_NMax.Text));
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
            else if (ficha == "4")
            {
                try
                {
                    conexion = new OleDbConnection(ObtenerString());
                    conexion.Open();
                    transaccion = conexion.BeginTransaction(System.Data.IsolationLevel.Serializable);
                    OleDbCommand comando = new OleDbCommand("SP_NivelProductoTerminado_Cambios", conexion, transaccion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@Id_NivelProducto", Idp);
                    comando.Parameters.AddWithValue("@Min", Convert.ToInt32(txt_NMin.Text));
                    comando.Parameters.AddWithValue("@Max", Convert.ToInt32(txt_NMax.Text));
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
            Sub_Limpiar();
        }
        private void bttn_NCerrar_Click(object sender, EventArgs e)
        {
            try
            {
                //Quito el panel de busqueda
                Controls.Remove(panel_Niveles);
            }
            catch (Exception)
            {
                //En caso de que no existe todavia el panel de niveles
                //omite la instrucción de quitar dicho control
            }
            tabControl1.Visible = true;
            modificarToolStripMenuItem.Enabled = false;
            eliminarToolStripMenuItem.Enabled = false;
        }

        private void ordenDePeladoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Obtengo que ficha o que control esta activa para poder limpiar dicho control
            string ficha = tabControl1.SelectedIndex.ToString();
            if (ficha == "0")
            {
                Diseño_Menu();
            }
        }
        //-------------------------------------------------------------
        //--------------------PANEL ORDEN DE PELADO--------------------
        //-------------------------------------------------------------
        //Creando controles
        Panel panel_OrdenPelado;
        GroupBox groupBox_Pelado;
        Button bttn_OGuardar;
        Button bttn_OCerrar;
        DateTimePicker dateTimePicker_OFecha;
        TextBox txt_OPrecioPelado;
        TextBox txt_ORenacida;
        TextBox txt_OPedaceria;
        TextBox txt_OCorazon;
        TextBox txt_OPesoSalida;
        TextBox txt_OPesoEntrada;
        ComboBox comboBox_OProducto;
        Label lbl_OFecha;
        Label lbl_OPrecioPelado;
        Label lbl_ORenacida;
        Label lbl_OPedaceria;
        Label lbl_OCorazon;
        Label lbl_OPesoSalida;
        Label lbl_OPesoEntrada;
        Label lbl_OProducto;
        // PRIMER DISEÑO DE PELADO
        private void DiseñoPelado()
        {
            panel_OrdenPelado = new System.Windows.Forms.Panel();
            groupBox_Pelado = new System.Windows.Forms.GroupBox();
            bttn_OGuardar = new System.Windows.Forms.Button();
            bttn_OCerrar = new System.Windows.Forms.Button();
            lbl_OProducto = new System.Windows.Forms.Label();
            lbl_OPesoEntrada = new System.Windows.Forms.Label();
            lbl_OPesoSalida = new System.Windows.Forms.Label();
            lbl_OCorazon = new System.Windows.Forms.Label();
            lbl_OPedaceria = new System.Windows.Forms.Label();
            lbl_ORenacida = new System.Windows.Forms.Label();
            lbl_OPrecioPelado = new System.Windows.Forms.Label();
            lbl_OFecha = new System.Windows.Forms.Label();
            comboBox_OProducto = new System.Windows.Forms.ComboBox();
            txt_OPesoEntrada = new System.Windows.Forms.TextBox();
            txt_OPesoSalida = new System.Windows.Forms.TextBox();
            txt_OCorazon = new System.Windows.Forms.TextBox();
            txt_OPedaceria = new System.Windows.Forms.TextBox();
            txt_ORenacida = new System.Windows.Forms.TextBox();
            txt_OPrecioPelado = new System.Windows.Forms.TextBox();
            dateTimePicker_OFecha = new System.Windows.Forms.DateTimePicker();
            // 
            // panel_OrdenPelado
            // 
            panel_OrdenPelado.Controls.Add(groupBox_Pelado);
            panel_OrdenPelado.Location = new System.Drawing.Point(192, 83);
            panel_OrdenPelado.Name = "panel_OrdenPelado";
            panel_OrdenPelado.Size = new System.Drawing.Size(448, 403);
            panel_OrdenPelado.TabIndex = 1;
            // 
            // groupBox_Pelado
            // 
            groupBox_Pelado.Controls.Add(dateTimePicker_OFecha);
            groupBox_Pelado.Controls.Add(txt_OPrecioPelado);
            groupBox_Pelado.Controls.Add(txt_ORenacida);
            groupBox_Pelado.Controls.Add(txt_OPedaceria);
            groupBox_Pelado.Controls.Add(txt_OCorazon);
            groupBox_Pelado.Controls.Add(txt_OPesoSalida);
            groupBox_Pelado.Controls.Add(txt_OPesoEntrada);
            groupBox_Pelado.Controls.Add(comboBox_OProducto);
            groupBox_Pelado.Controls.Add(lbl_OFecha);
            groupBox_Pelado.Controls.Add(lbl_OPrecioPelado);
            groupBox_Pelado.Controls.Add(lbl_ORenacida);
            groupBox_Pelado.Controls.Add(lbl_OPedaceria);
            groupBox_Pelado.Controls.Add(lbl_OCorazon);
            groupBox_Pelado.Controls.Add(lbl_OPesoSalida);
            groupBox_Pelado.Controls.Add(lbl_OPesoEntrada);
            groupBox_Pelado.Controls.Add(lbl_OProducto);
            groupBox_Pelado.Controls.Add(bttn_OGuardar);
            groupBox_Pelado.Controls.Add(bttn_OCerrar);
            groupBox_Pelado.Location = new System.Drawing.Point(10, 8);
            groupBox_Pelado.Name = "groupBox_Pelado";
            groupBox_Pelado.Size = new System.Drawing.Size(428, 386);
            groupBox_Pelado.TabIndex = 1;
            groupBox_Pelado.TabStop = false;
            groupBox_Pelado.Text = "Orden de pelado";
            // 
            // bttn_OGuardar
            // 
            bttn_OGuardar.BackgroundImage = ((System.Drawing.Image)(global::Shajobe.Properties.Resources.Guardar));
            bttn_OGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            bttn_OGuardar.Location = new System.Drawing.Point(354, 46);
            bttn_OGuardar.Name = "bttn_OGuardar";
            bttn_OGuardar.Size = new System.Drawing.Size(55, 61);
            bttn_OGuardar.Click += new EventHandler(bttn_OGuardar_Click);
            bttn_OGuardar.TabIndex = 1;
            bttn_OGuardar.UseVisualStyleBackColor = true;
            // 
            // bttn_OCerrar
            // 
            bttn_OCerrar.BackgroundImage = ((System.Drawing.Image)(global::Shajobe.Properties.Resources.cerrar));
            bttn_OCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            bttn_OCerrar.Location = new System.Drawing.Point(301, 338);
            bttn_OCerrar.Name = "bttn_OCerrar";
            bttn_OCerrar.Click += new EventHandler(bttn_OCerrar_Click);
            bttn_OCerrar.Size = new System.Drawing.Size(121, 42);
            bttn_OCerrar.TabIndex = 2;
            bttn_OCerrar.UseVisualStyleBackColor = true;
            // 
            // lbl_OProducto
            // 
            lbl_OProducto.AutoSize = true;
            lbl_OProducto.Location = new System.Drawing.Point(43, 54);
            lbl_OProducto.Name = "lbl_OProducto";
            lbl_OProducto.Size = new System.Drawing.Size(50, 13);
            lbl_OProducto.TabIndex = 3;
            lbl_OProducto.Text = "Producto";
            // 
            // lbl_OPesoEntrada
            // 
            lbl_OPesoEntrada.AutoSize = true;
            lbl_OPesoEntrada.Location = new System.Drawing.Point(43, 81);
            lbl_OPesoEntrada.Name = "lbl_OPesoEntrada";
            lbl_OPesoEntrada.Size = new System.Drawing.Size(70, 13);
            lbl_OPesoEntrada.TabIndex = 4;
            lbl_OPesoEntrada.Text = "Peso entrada";
            // 
            // lbl_OPesoSalida
            // 
            lbl_OPesoSalida.AutoSize = true;
            lbl_OPesoSalida.Location = new System.Drawing.Point(43, 108);
            lbl_OPesoSalida.Name = "lbl_OPesoSalida";
            lbl_OPesoSalida.Size = new System.Drawing.Size(61, 13);
            lbl_OPesoSalida.TabIndex = 5;
            lbl_OPesoSalida.Text = "Peso salida";
            // 
            // lbl_OCorazon
            // 
            lbl_OCorazon.AutoSize = true;
            lbl_OCorazon.Location = new System.Drawing.Point(43, 135);
            lbl_OCorazon.Name = "lbl_OCorazon";
            lbl_OCorazon.Size = new System.Drawing.Size(46, 13);
            lbl_OCorazon.TabIndex = 6;
            lbl_OCorazon.Text = "Corazón";
            // 
            // lbl_OPedaceria
            // 
            lbl_OPedaceria.AutoSize = true;
            lbl_OPedaceria.Location = new System.Drawing.Point(43, 162);
            lbl_OPedaceria.Name = "lbl_OPedaceria";
            lbl_OPedaceria.Size = new System.Drawing.Size(55, 13);
            lbl_OPedaceria.TabIndex = 7;
            lbl_OPedaceria.Text = "Pedaceria";
            // 
            // lbl_ORenacida
            // 
            lbl_ORenacida.AutoSize = true;
            lbl_ORenacida.Location = new System.Drawing.Point(43, 189);
            lbl_ORenacida.Name = "lbl_ORenacida";
            lbl_ORenacida.Size = new System.Drawing.Size(53, 13);
            lbl_ORenacida.TabIndex = 8;
            lbl_ORenacida.Text = "Renacida";
            // 
            // lbl_OPrecioPelado
            // 
            lbl_OPrecioPelado.AutoSize = true;
            lbl_OPrecioPelado.Location = new System.Drawing.Point(43, 216);
            lbl_OPrecioPelado.Name = "lbl_OPrecioPelado";
            lbl_OPrecioPelado.Size = new System.Drawing.Size(87, 13);
            lbl_OPrecioPelado.TabIndex = 9;
            lbl_OPrecioPelado.Text = "Precio de pelado";
            // 
            // lbl_OFecha
            // 
            lbl_OFecha.AutoSize = true;
            lbl_OFecha.Location = new System.Drawing.Point(43, 243);
            lbl_OFecha.Name = "lbl_OFecha";
            lbl_OFecha.Size = new System.Drawing.Size(37, 13);
            lbl_OFecha.TabIndex = 10;
            lbl_OFecha.Text = "Fecha";
            // 
            // comboBox_OProducto
            // 
            comboBox_OProducto.FormattingEnabled = true;
            comboBox_OProducto.Location = new System.Drawing.Point(135, 46);
            comboBox_OProducto.Name = "comboBox_OProducto";
            comboBox_OProducto.Size = new System.Drawing.Size(121, 21);
            comboBox_OProducto.TabIndex = 11;
            // 
            // txt_OPesoEntrada
            // 
            txt_OPesoEntrada.Location = new System.Drawing.Point(135, 74);
            txt_OPesoEntrada.Name = "txt_OPesoEntrada";
            txt_OPesoEntrada.Size = new System.Drawing.Size(100, 20);
            txt_OPesoEntrada.TabIndex = 12;
            // 
            // txt_OPesoSalida
            // 
            txt_OPesoSalida.Location = new System.Drawing.Point(135, 101);
            txt_OPesoSalida.Name = "txt_OPesoSalida";
            txt_OPesoSalida.Size = new System.Drawing.Size(100, 20);
            txt_OPesoSalida.TabIndex = 13;
            // 
            // txt_OCorazon
            // 
            txt_OCorazon.Location = new System.Drawing.Point(135, 128);
            txt_OCorazon.Name = "txt_OCorazon";
            txt_OCorazon.Size = new System.Drawing.Size(100, 20);
            txt_OCorazon.TabIndex = 14;
            // 
            // txt_OPedaceria
            // 
            txt_OPedaceria.Location = new System.Drawing.Point(135, 155);
            txt_OPedaceria.Name = "txt_OPedaceria";
            txt_OPedaceria.Size = new System.Drawing.Size(100, 20);
            txt_OPedaceria.TabIndex = 15;
            // 
            // txt_ORenacida
            // 
            txt_ORenacida.Location = new System.Drawing.Point(135, 182);
            txt_ORenacida.Name = "txt_ORenacida";
            txt_ORenacida.Size = new System.Drawing.Size(100, 20);
            txt_ORenacida.TabIndex = 16;
            // 
            // txt_OPrecioPelado
            // 
            txt_OPrecioPelado.Location = new System.Drawing.Point(135, 209);
            txt_OPrecioPelado.Name = "txt_OPrecioPelado";
            txt_OPrecioPelado.Size = new System.Drawing.Size(100, 20);
            txt_OPrecioPelado.TabIndex = 17;
            // 
            // dateTimePicker_OFecha
            // 
            dateTimePicker_OFecha.Location = new System.Drawing.Point(135, 236);
            dateTimePicker_OFecha.Name = "dateTimePicker_OFecha";
            dateTimePicker_OFecha.Size = new System.Drawing.Size(200, 20);
            dateTimePicker_OFecha.TabIndex = 18;
            //AGREGANDO EL CONTROL AL FORMULARIO
            Tipo_Diseño = true;// Sirve para indicarle al boton guardar en que seccion de diseño le toca entrar
            comboBox_OProducto.Items.Add("NUEZ");
            Controls.Add(panel_OrdenPelado);
            tabControl1.Visible = false;
        }
        //Creando controles
        TextBox txt_OPieza;
        Label lbl_OPieza;
        // SEGUNDO DISEÑO DE PELADO
        private void DiseñoPelado1()
        {
            panel_OrdenPelado = new System.Windows.Forms.Panel();
            groupBox_Pelado = new System.Windows.Forms.GroupBox();
            bttn_OGuardar = new System.Windows.Forms.Button();
            bttn_OCerrar = new System.Windows.Forms.Button();
            lbl_OProducto = new System.Windows.Forms.Label();
            lbl_OPesoEntrada = new System.Windows.Forms.Label();
            lbl_OPesoSalida = new System.Windows.Forms.Label();
            lbl_OPrecioPelado = new System.Windows.Forms.Label();
            lbl_OPieza = new System.Windows.Forms.Label();
            lbl_OFecha = new System.Windows.Forms.Label();
            comboBox_OProducto = new System.Windows.Forms.ComboBox();
            txt_OPesoEntrada = new System.Windows.Forms.TextBox();
            txt_OPesoSalida = new System.Windows.Forms.TextBox();
            txt_OPrecioPelado = new System.Windows.Forms.TextBox();
            dateTimePicker_OFecha = new System.Windows.Forms.DateTimePicker();
            txt_OPieza = new System.Windows.Forms.TextBox();
            // 
            // panel_OrdenPelado
            // 
            panel_OrdenPelado.Controls.Add(groupBox_Pelado);
            panel_OrdenPelado.Location = new System.Drawing.Point(192, 83);
            panel_OrdenPelado.Name = "panel_OrdenPelado";
            panel_OrdenPelado.Size = new System.Drawing.Size(448, 403);
            panel_OrdenPelado.TabIndex = 1;
            // 
            // groupBox_Pelado
            // 
            groupBox_Pelado.Controls.Add(dateTimePicker_OFecha);
            groupBox_Pelado.Controls.Add(txt_OPrecioPelado);
            groupBox_Pelado.Controls.Add(txt_OPieza);
            groupBox_Pelado.Controls.Add(txt_OPesoSalida);
            groupBox_Pelado.Controls.Add(txt_OPesoEntrada);
            groupBox_Pelado.Controls.Add(comboBox_OProducto);
            groupBox_Pelado.Controls.Add(lbl_OFecha);
            groupBox_Pelado.Controls.Add(lbl_OPrecioPelado);
            groupBox_Pelado.Controls.Add(lbl_OPieza);
            groupBox_Pelado.Controls.Add(lbl_OPesoSalida);
            groupBox_Pelado.Controls.Add(lbl_OPesoEntrada);
            groupBox_Pelado.Controls.Add(lbl_OProducto);
            groupBox_Pelado.Controls.Add(bttn_OGuardar);
            groupBox_Pelado.Controls.Add(bttn_OCerrar);
            groupBox_Pelado.Location = new System.Drawing.Point(10, 8);
            groupBox_Pelado.Name = "groupBox_Pelado";
            groupBox_Pelado.Size = new System.Drawing.Size(428, 386);
            groupBox_Pelado.TabIndex = 1;
            groupBox_Pelado.TabStop = false;
            groupBox_Pelado.Text = "Orden de pelado";
            // 
            // bttn_OGuardar
            // 
            bttn_OGuardar.BackgroundImage = ((System.Drawing.Image)(global::Shajobe.Properties.Resources.Guardar));
            bttn_OGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            bttn_OGuardar.Location = new System.Drawing.Point(354, 46);
            bttn_OGuardar.Name = "bttn_OGuardar";
            bttn_OGuardar.Size = new System.Drawing.Size(55, 61);
            bttn_OGuardar.Click += new EventHandler(bttn_OGuardar_Click);
            bttn_OGuardar.TabIndex = 1;
            bttn_OGuardar.UseVisualStyleBackColor = true;
            // 
            // bttn_OCerrar
            // 
            bttn_OCerrar.BackgroundImage = ((System.Drawing.Image)(global::Shajobe.Properties.Resources.cerrar));
            bttn_OCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            bttn_OCerrar.Location = new System.Drawing.Point(301, 338);
            bttn_OCerrar.Name = "bttn_OCerrar";
            bttn_OCerrar.Size = new System.Drawing.Size(121, 42);
            bttn_OCerrar.Click += new EventHandler(bttn_OCerrar_Click);
            bttn_OCerrar.TabIndex = 2;
            bttn_OCerrar.UseVisualStyleBackColor = true;
            // 
            // lbl_OProducto
            // 
            lbl_OProducto.AutoSize = true;
            lbl_OProducto.Location = new System.Drawing.Point(43, 54);
            lbl_OProducto.Name = "lbl_OProducto";
            lbl_OProducto.Size = new System.Drawing.Size(50, 13);
            lbl_OProducto.TabIndex = 3;
            lbl_OProducto.Text = "Producto";
            // 
            // lbl_OPesoEntrada
            // 
            lbl_OPesoEntrada.AutoSize = true;
            lbl_OPesoEntrada.Location = new System.Drawing.Point(43, 81);
            lbl_OPesoEntrada.Name = "lbl_OPesoEntrada";
            lbl_OPesoEntrada.Size = new System.Drawing.Size(70, 13);
            lbl_OPesoEntrada.TabIndex = 4;
            lbl_OPesoEntrada.Text = "Peso entrada";
            // 
            // lbl_OPesoSalida
            // 
            lbl_OPesoSalida.AutoSize = true;
            lbl_OPesoSalida.Location = new System.Drawing.Point(43, 108);
            lbl_OPesoSalida.Name = "lbl_OPesoSalida";
            lbl_OPesoSalida.Size = new System.Drawing.Size(61, 13);
            lbl_OPesoSalida.TabIndex = 5;
            lbl_OPesoSalida.Text = "Peso salida";
            // 
            // lbl_OCorazon
            // 
            lbl_OPieza.AutoSize = true;
            lbl_OPieza.Location = new System.Drawing.Point(43, 135);
            lbl_OPieza.Name = "lbl_OCorazon";
            lbl_OPieza.Size = new System.Drawing.Size(38, 13);
            lbl_OPieza.TabIndex = 6;
            lbl_OPieza.Text = "Piezas";
            // 
            // lbl_OPrecioPelado
            // 
            lbl_OPrecioPelado.AutoSize = true;
            lbl_OPrecioPelado.Location = new System.Drawing.Point(43, 161);
            lbl_OPrecioPelado.Name = "lbl_OPrecioPelado";
            lbl_OPrecioPelado.Size = new System.Drawing.Size(87, 13);
            lbl_OPrecioPelado.TabIndex = 9;
            lbl_OPrecioPelado.Text = "Precio de pelado";
            // 
            // lbl_OFecha
            // 
            lbl_OFecha.AutoSize = true;
            lbl_OFecha.Location = new System.Drawing.Point(43, 188);
            lbl_OFecha.Name = "lbl_OFecha";
            lbl_OFecha.Size = new System.Drawing.Size(37, 13);
            lbl_OFecha.TabIndex = 10;
            lbl_OFecha.Text = "Fecha";
            // 
            // comboBox_OProducto
            // 
            comboBox_OProducto.FormattingEnabled = true;
            comboBox_OProducto.Location = new System.Drawing.Point(135, 46);
            comboBox_OProducto.Name = "comboBox_OProducto";
            comboBox_OProducto.Size = new System.Drawing.Size(121, 21);
            comboBox_OProducto.TabIndex = 11;
            // 
            // txt_OPesoEntrada
            // 
            txt_OPesoEntrada.Location = new System.Drawing.Point(135, 74);
            txt_OPesoEntrada.Name = "txt_OPesoEntrada";
            txt_OPesoEntrada.Size = new System.Drawing.Size(100, 20);
            txt_OPesoEntrada.TabIndex = 12;
            // 
            // txt_OPesoSalida
            // 
            txt_OPesoSalida.Location = new System.Drawing.Point(135, 101);
            txt_OPesoSalida.Name = "txt_OPesoSalida";
            txt_OPesoSalida.Size = new System.Drawing.Size(100, 20);
            txt_OPesoSalida.TabIndex = 13;
            // 
            // txt_OPieza
            // 
            txt_OPieza.Location = new System.Drawing.Point(135, 128);
            txt_OPieza.Name = "txt_OPieza";
            txt_OPieza.Size = new System.Drawing.Size(100, 20);
            txt_OPieza.TabIndex = 14;
            // 
            // txt_OPrecioPelado
            // 
            txt_OPrecioPelado.Location = new System.Drawing.Point(135, 154);
            txt_OPrecioPelado.Name = "txt_OPrecioPelado";
            txt_OPrecioPelado.Size = new System.Drawing.Size(100, 20);
            txt_OPrecioPelado.TabIndex = 17;
            // 
            // dateTimePicker_OFecha
            // 
            dateTimePicker_OFecha.Location = new System.Drawing.Point(135, 181);
            dateTimePicker_OFecha.Name = "dateTimePicker_OFecha";
            dateTimePicker_OFecha.Size = new System.Drawing.Size(200, 20);
            dateTimePicker_OFecha.TabIndex = 18;
            //AGREGANDO EL CONTROL AL FORMULARIO
            Llenando_OMateriaPrima();
            Tipo_Diseño = false;// Sirve para indicarle al boton guardar en que seccion de diseño le toca entrar
            comboBox_OProducto.Items.Remove("NUEZ");
            Controls.Add(panel_OrdenPelado);
            tabControl1.Visible = false;
        }
        // DISEÑO DEL MENU DE SELECCIÓN DE PRODUCTO
        Label lbl_OOpcion;
        //Creando controles
        private void Diseño_Menu()
        {
            panel_OrdenPelado = new System.Windows.Forms.Panel();
            groupBox_Pelado = new System.Windows.Forms.GroupBox();
            comboBox_OProducto = new System.Windows.Forms.ComboBox();
            lbl_OOpcion = new System.Windows.Forms.Label();
            lbl_OProducto = new System.Windows.Forms.Label();
            // 
            // panel_OrdenPelado
            // 
            panel_OrdenPelado.Controls.Add(groupBox_Pelado);
            panel_OrdenPelado.Location = new System.Drawing.Point(192, 192);
            panel_OrdenPelado.Name = "panel_OrdenPelado";
            panel_OrdenPelado.Size = new System.Drawing.Size(448, 124);
            panel_OrdenPelado.TabIndex = 2;
            // 
            // groupBox_Pelado
            // 
            groupBox_Pelado.Controls.Add(comboBox_OProducto);
            groupBox_Pelado.Controls.Add(lbl_OOpcion);
            groupBox_Pelado.Controls.Add(lbl_OProducto);
            groupBox_Pelado.Location = new System.Drawing.Point(10, 8);
            groupBox_Pelado.Name = "groupBox_Pelado";
            groupBox_Pelado.Size = new System.Drawing.Size(428, 104);
            groupBox_Pelado.TabIndex = 1;
            groupBox_Pelado.TabStop = false;
            groupBox_Pelado.Text = "Orden de pelado";
            // 
            // comboBox_OProducto
            // 
            comboBox_OProducto.FormattingEnabled = true;
            comboBox_OProducto.Location = new System.Drawing.Point(200, 46);
            comboBox_OProducto.Name = "comboBox_OProducto";
            comboBox_OProducto.Size = new System.Drawing.Size(121, 21);
            comboBox_OProducto.TabIndex = 11;
            comboBox_OProducto.SelectionChangeCommitted += new EventHandler(comboBox_OProducto_SelectionChangeCommitted);
            // 
            // lbl_OOpcion
            // 
            lbl_OOpcion.AutoSize = true;
            lbl_OOpcion.Location = new System.Drawing.Point(156, 24);
            lbl_OOpcion.Name = "lbl_OOpcion";
            lbl_OOpcion.Size = new System.Drawing.Size(116, 13);
            lbl_OOpcion.TabIndex = 4;
            lbl_OOpcion.Text = "Selecciona una opción";
            // 
            // lbl_OProducto
            // 
            lbl_OProducto.AutoSize = true;
            lbl_OProducto.Location = new System.Drawing.Point(108, 54);
            lbl_OProducto.Name = "lbl_OProducto";
            lbl_OProducto.Size = new System.Drawing.Size(50, 13);
            lbl_OProducto.TabIndex = 3;
            lbl_OProducto.Text = "Producto";
            //Llenando el Combobox
            Llenando_OMateriaPrima();
            //AGREGANDO EL CONTROL AL FORMULARIO
            Controls.Add(panel_OrdenPelado);
            tabControl1.Visible = false;
        }

        //-------------------------------------------------------------
        //----------------CONFIGURACION DE CONTROLES-------------------
        //-------------------------------------------------------------
        private void comboBox_OProducto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                //Quito el panel de busqueda
                Controls.Remove(panel_OrdenPelado);
            }
            catch (Exception)
            {
                //En caso de que no existe todavia el panel de niveles
                //omite la instrucción de quitar dicho control
            }
            string opcion = Convert.ToString(comboBox_OProducto.SelectedItem);
            if (opcion == "NUEZ")
            {
                DiseñoPelado();
            }
            else
            {
                DiseñoPelado1();
            }
        }
        //Llenando comboBox de MateriaPrima
        private void Llenando_OMateriaPrima()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand coman = new OleDbCommand();
            OleDbDataReader dr;
            con.ConnectionString = ObtenerString();
            coman.Connection = con;
            coman.CommandText = "SELECT Nombre FROM Tb_MateriaPrima  where Activo= 'S' group by Nombre";
            coman.CommandType = CommandType.Text;
            con.Open();
            comboBox_OProducto.Items.Clear();
            dr = coman.ExecuteReader();
            while (dr.Read())
            {
                //Declarando Variables y obteniendo los valores correspondiente
                string Nombre_MateriaPrima = dr.GetString(dr.GetOrdinal("Nombre"));
                comboBox_OProducto.Items.Add(Nombre_MateriaPrima);
            }
            con.Close();
        }
        private bool Tipo_Diseño = true;
        private void bttn_OGuardar_Click(object sender, EventArgs e)
        {
            //Obtengo que ficha o que control esta activa para poder limpiar dicho control
            OleDbConnection conexion = null;
            OleDbTransaction transaccion = null;
            if (Tipo_Diseño == true)
            {
                //Diseño 
                bool i = Verificar_CamposVaciosN();
                if (i == true)
                    MessageBox.Show("Inserta todos los datos marcados", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {

                    try
                    {
                        conexion = new OleDbConnection(ObtenerString());
                        conexion.Open();
                        transaccion = conexion.BeginTransaction(System.Data.IsolationLevel.Serializable);
                        OleDbCommand comando = new OleDbCommand("SP_AlmacenMateriaPrima_Alta", conexion, transaccion);
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.Clear();
                        comando.Parameters.AddWithValue("@Id_MateriaPrima ", Idp);
                        comando.Parameters.AddWithValue("@Peso_Entrada ", Convert.ToDecimal(txt_OPesoEntrada.Text));
                        comando.Parameters.AddWithValue("@Peso_Salida ", Convert.ToDecimal(txt_OPesoSalida.Text));
                        comando.Parameters.AddWithValue("@Corazon ", Convert.ToDecimal(txt_OCorazon.Text));
                        comando.Parameters.AddWithValue("@Pedaceria ", Convert.ToDecimal(txt_OPedaceria.Text));
                        comando.Parameters.AddWithValue("@Renacida ", Convert.ToDecimal(txt_ORenacida.Text));
                        comando.Parameters.AddWithValue("@Runer ", 0.00);
                        comando.Parameters.AddWithValue("@Precio_Pelado ", Convert.ToDecimal(txt_OPrecioPelado.Text));
                        comando.Parameters.AddWithValue("@Fecha_Pelado ", dateTimePicker_OFecha.Value.Date);
                        //comando.Parameters.AddWithValue("@NMin", txt_NMin.Text);
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
            }
            else
            {
                //Diseño1
                //Diseño 
                bool i = Verificar_CamposVaciosN();
                if (i == true)
                    MessageBox.Show("Inserta todos los datos marcados", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {

                    try
                    {
                        conexion = new OleDbConnection(ObtenerString());
                        conexion.Open();
                        transaccion = conexion.BeginTransaction(System.Data.IsolationLevel.Serializable);
                        OleDbCommand comando = new OleDbCommand("SP_AlmacenMateriaPrima_Alta", conexion, transaccion);
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.Clear();
                        comando.Parameters.AddWithValue("@Id_MateriaPrima ", Idp);
                        comando.Parameters.AddWithValue("@Peso_Entrada ", txt_OPesoEntrada.Text);
                        comando.Parameters.AddWithValue("@Peso_Salida ", txt_OPesoSalida.Text);
                        comando.Parameters.AddWithValue("@Corazon ", 0.00);
                        comando.Parameters.AddWithValue("@Pedaceria ", 0.00);
                        comando.Parameters.AddWithValue("@Renacida ", 0.00);
                        comando.Parameters.AddWithValue("@Runer ", Convert.ToDecimal(txt_OPieza.Text));
                        comando.Parameters.AddWithValue("@Precio_Pelado ", txt_OPrecioPelado.Text);
                        comando.Parameters.AddWithValue("@Fecha_Pelado ", dateTimePicker_OFecha.Value.Date);
                        //comando.Parameters.AddWithValue("@NMin", txt_NMin.Text);
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
            }
        }
        private void bttn_OCerrar_Click(object sender, EventArgs e)
        {
            try
            {
                //Quito el panel de busqueda
                Controls.Remove(panel_OrdenPelado);
            }
            catch (Exception)
            {
                //En caso de que no existe todavia el panel de niveles
                //omite la instrucción de quitar dicho control
            }
            tabControl1.Visible = true;
        }
        //Verificar espacios vacios
        private TextBox[] Campos_Nivel;
        private bool Verificar_CamposVaciosN()
        {
            Campos_Nivel = new TextBox[1];
            //Se introduce los textbox en un arreglo con el fin de identificar espacios vacios
            Campos_Nivel[0] = txt_NMax;
            Campos_Nivel[1] = txt_NMin;
            //Reinicio el error provider para volver a reemarcar
            errorProvider1.Clear();
            Espacios_Vacios = false;
            for (int i = 0; i < Campos.Length; i++)
            {
                if (Campos_Nivel[i].Text.Trim() == "")
                {
                    Indicador_CamposVaciosN(i);
                    Espacios_Vacios = true;
                }
            }
            return Espacios_Vacios;
        }
        private void Indicador_CamposVaciosN(int i)
        {
            switch (i)
            {
                case 0:
                    errorProvider1.SetError(txt_NMax, "No puedes dejar el campo vacio");
                    break;
                case 1:
                    errorProvider1.SetError(txt_NMin, "No puedes dejar el campo vacio");
                    break;
                default:
                    break;
            }
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
