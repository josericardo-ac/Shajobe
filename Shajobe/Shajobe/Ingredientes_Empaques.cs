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
    public partial class Ingredientes_Empaques : Form
    {
        public Ingredientes_Empaques()
        {
            InitializeComponent();
        }
        #region Diseño de la forma
        #region Creando controles de la forma
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
        private System.Windows.Forms.ToolStripMenuItem presentaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empaqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercadeToolStripMenuItem;
        private System.Windows.Forms.Panel panel_Ingredientes;
        private System.Windows.Forms.Label lbl_Cantidad_Mpp;
        private System.Windows.Forms.Label lbl_Cantidad_Mp;
        private System.Windows.Forms.Label lbl_Cantidad_PElaborado;
        private System.Windows.Forms.TextBox txt_SinRebaba;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button bttn_AgregarSinRebaba;
        private System.Windows.Forms.TextBox txt_ConRebaba;
        private System.Windows.Forms.Button bttn_QuitarConRebaba;
        private System.Windows.Forms.Button bttn_AgregarConRebaba;
        private System.Windows.Forms.TextBox txt_ProdElabCant;
        private System.Windows.Forms.Button bttn_QuitarProdElab;
        private System.Windows.Forms.Button bttn_AgregarProdElab;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView data_ListaSinRebaba;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView data_SinRebaba;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView data_ListaConRebaba;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView data_ConRebaba;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView data_ListaProdElab;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView data_ProdElaborado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_MateriaPrimaPp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_p;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidadp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_ProductoElaboradoe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombree;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidade;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_MateriaPrimam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_TipoPiezam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lote;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_m;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Pieza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidadm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_MateriaPrimaP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombrep;
        private System.Windows.Forms.DataGridViewImageColumn Fotop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_MateriaPrima;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_TipoPieza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombrem;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoPieza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lotem;
        private System.Windows.Forms.DataGridViewImageColumn Fotom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_ProductoElaborado;
        private System.Windows.Forms.DataGridViewImageColumn Foto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePE;
        private PictureBox pic_Logo;
        #endregion
        private void Diseño_Forma()
        {
            pic_Logo = new System.Windows.Forms.PictureBox();
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ingredientes_Empaques));
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
            presentaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            empaqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            acercadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            panel_Ingredientes = new System.Windows.Forms.Panel();
            lbl_Cantidad_Mpp = new System.Windows.Forms.Label();
            lbl_Cantidad_Mp = new System.Windows.Forms.Label();
            lbl_Cantidad_PElaborado = new System.Windows.Forms.Label();
            txt_SinRebaba = new System.Windows.Forms.TextBox();
            button5 = new System.Windows.Forms.Button();
            bttn_AgregarSinRebaba = new System.Windows.Forms.Button();
            txt_ConRebaba = new System.Windows.Forms.TextBox();
            bttn_QuitarConRebaba = new System.Windows.Forms.Button();
            bttn_AgregarConRebaba = new System.Windows.Forms.Button();
            txt_ProdElabCant = new System.Windows.Forms.TextBox();
            bttn_QuitarProdElab = new System.Windows.Forms.Button();
            bttn_AgregarProdElab = new System.Windows.Forms.Button();
            groupBox4 = new System.Windows.Forms.GroupBox();
            data_ListaSinRebaba = new System.Windows.Forms.DataGridView();
            Id_MateriaPrimaPp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Nombre_p = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Cantidadp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            groupBox3 = new System.Windows.Forms.GroupBox();
            data_SinRebaba = new System.Windows.Forms.DataGridView();
            groupBox5 = new System.Windows.Forms.GroupBox();
            data_ListaConRebaba = new System.Windows.Forms.DataGridView();
            Id_MateriaPrimam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Id_TipoPiezam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Lote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Nombre_m = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Tipo_Pieza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Cantidadm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            groupBox2 = new System.Windows.Forms.GroupBox();
            data_ConRebaba = new System.Windows.Forms.DataGridView();
            groupBox6 = new System.Windows.Forms.GroupBox();
            data_ListaProdElab = new System.Windows.Forms.DataGridView();
            Id_ProductoElaboradoe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Nombree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Cantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            groupBox1 = new System.Windows.Forms.GroupBox();
            data_ProdElaborado = new System.Windows.Forms.DataGridView();
            errorProvider1 = new System.Windows.Forms.ErrorProvider(components);
            Id_MateriaPrimaP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Nombrep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Fotop = new System.Windows.Forms.DataGridViewImageColumn();
            Id_MateriaPrima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Id_TipoPieza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Nombrem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TipoPieza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Lotem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Fotom = new System.Windows.Forms.DataGridViewImageColumn();
            Id_ProductoElaborado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Foto = new System.Windows.Forms.DataGridViewImageColumn();
            NombrePE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            menuStrip1.SuspendLayout();
            panel_Ingredientes.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(data_ListaSinRebaba)).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(data_SinRebaba)).BeginInit();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(data_ListaConRebaba)).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(data_ConRebaba)).BeginInit();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(data_ListaProdElab)).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(data_ProdElaborado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(errorProvider1)).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(186)))), ((int)(((byte)(82)))));
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            archivoToolStripMenuItem,
            editarToolStripMenuItem,
            presentaciónToolStripMenuItem,
            ayudaToolStripMenuItem});
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(788, 24);
            menuStrip1.TabIndex = 4;
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
            archivoToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
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
            abrirToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            abrirToolStripMenuItem.Text = "&Abrir";
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new System.Drawing.Size(148, 6);
            // 
            // guardarToolStripMenuItem
            // 
            guardarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("guardarToolStripMenuItem.Image")));
            guardarToolStripMenuItem.Image = global::Shajobe.Properties.Resources.Guardar;
            guardarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            guardarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            guardarToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            guardarToolStripMenuItem.Text = "&Guardar";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(148, 6);
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(148, 6);
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
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
            editarToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            editarToolStripMenuItem.Text = "&Editar";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new System.Drawing.Size(114, 6);
            // 
            // modificarToolStripMenuItem
            // 
            modificarToolStripMenuItem.Enabled = false;
            modificarToolStripMenuItem.Image = global::Shajobe.Properties.Resources.Modificar;
            modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            modificarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            modificarToolStripMenuItem.Text = "Modificar";
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Enabled = false;
            eliminarToolStripMenuItem.Image = global::Shajobe.Properties.Resources.Borrar;
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // presentaciónToolStripMenuItem
            // 
            presentaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            empaqueToolStripMenuItem});
            presentaciónToolStripMenuItem.Name = "presentaciónToolStripMenuItem";
            presentaciónToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            presentaciónToolStripMenuItem.Text = "Presentación";
            // 
            // empaqueToolStripMenuItem
            // 
            empaqueToolStripMenuItem.Name = "empaqueToolStripMenuItem";
            empaqueToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            empaqueToolStripMenuItem.Text = "Empaque";
            empaqueToolStripMenuItem.Click += new System.EventHandler(empaqueToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            acercadeToolStripMenuItem});
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            ayudaToolStripMenuItem.Text = "Ay&uda";
            // 
            // acercadeToolStripMenuItem
            // 
            acercadeToolStripMenuItem.Name = "acercadeToolStripMenuItem";
            acercadeToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            acercadeToolStripMenuItem.Text = "&Acerca de...";
            // 
            // panel_Ingredientes
            // 
            panel_Ingredientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel_Ingredientes.Controls.Add(lbl_Cantidad_Mpp);
            panel_Ingredientes.Controls.Add(lbl_Cantidad_Mp);
            panel_Ingredientes.Controls.Add(lbl_Cantidad_PElaborado);
            panel_Ingredientes.Controls.Add(txt_SinRebaba);
            panel_Ingredientes.Controls.Add(button5);
            panel_Ingredientes.Controls.Add(bttn_AgregarSinRebaba);
            panel_Ingredientes.Controls.Add(txt_ConRebaba);
            panel_Ingredientes.Controls.Add(bttn_QuitarConRebaba);
            panel_Ingredientes.Controls.Add(bttn_AgregarConRebaba);
            panel_Ingredientes.Controls.Add(txt_ProdElabCant);
            panel_Ingredientes.Controls.Add(bttn_QuitarProdElab);
            panel_Ingredientes.Controls.Add(bttn_AgregarProdElab);
            panel_Ingredientes.Controls.Add(groupBox4);
            panel_Ingredientes.Controls.Add(groupBox3);
            panel_Ingredientes.Controls.Add(groupBox5);
            panel_Ingredientes.Controls.Add(groupBox2);
            panel_Ingredientes.Controls.Add(groupBox6);
            panel_Ingredientes.Controls.Add(groupBox1);
            panel_Ingredientes.Location = new System.Drawing.Point(-9, 27);
            panel_Ingredientes.Name = "panel_Ingredientes";
            panel_Ingredientes.Size = new System.Drawing.Size(804, 603);
            panel_Ingredientes.TabIndex = 5;
            // 
            // lbl_Cantidad_Mpp
            // 
            lbl_Cantidad_Mpp.AutoSize = true;
            lbl_Cantidad_Mpp.Location = new System.Drawing.Point(316, 466);
            lbl_Cantidad_Mpp.Name = "lbl_Cantidad_Mpp";
            lbl_Cantidad_Mpp.Size = new System.Drawing.Size(49, 13);
            lbl_Cantidad_Mpp.TabIndex = 17;
            lbl_Cantidad_Mpp.Text = "Cantidad";
            // 
            // lbl_Cantidad_Mp
            // 
            lbl_Cantidad_Mp.AutoSize = true;
            lbl_Cantidad_Mp.Location = new System.Drawing.Point(316, 261);
            lbl_Cantidad_Mp.Name = "lbl_Cantidad_Mp";
            lbl_Cantidad_Mp.Size = new System.Drawing.Size(49, 13);
            lbl_Cantidad_Mp.TabIndex = 16;
            lbl_Cantidad_Mp.Text = "Cantidad";
            // 
            // lbl_Cantidad_PElaborado
            // 
            lbl_Cantidad_PElaborado.AutoSize = true;
            lbl_Cantidad_PElaborado.Location = new System.Drawing.Point(316, 68);
            lbl_Cantidad_PElaborado.Name = "lbl_Cantidad_PElaborado";
            lbl_Cantidad_PElaborado.Size = new System.Drawing.Size(49, 13);
            lbl_Cantidad_PElaborado.TabIndex = 15;
            lbl_Cantidad_PElaborado.Text = "Cantidad";
            // 
            // txt_SinRebaba
            // 
            txt_SinRebaba.Location = new System.Drawing.Point(319, 482);
            txt_SinRebaba.MaxLength = 9;
            txt_SinRebaba.Name = "txt_SinRebaba";
            txt_SinRebaba.Size = new System.Drawing.Size(100, 20);
            txt_SinRebaba.TabIndex = 14;
            txt_SinRebaba.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txt_SinRebaba_KeyPress);
            // 
            // button5
            // 
            button5.Location = new System.Drawing.Point(448, 511);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(75, 23);
            button5.TabIndex = 13;
            button5.Text = "<<";
            button5.UseVisualStyleBackColor = true;
            // 
            // bttn_AgregarSinRebaba
            // 
            bttn_AgregarSinRebaba.Location = new System.Drawing.Point(448, 482);
            bttn_AgregarSinRebaba.Name = "bttn_AgregarSinRebaba";
            bttn_AgregarSinRebaba.Size = new System.Drawing.Size(75, 23);
            bttn_AgregarSinRebaba.TabIndex = 12;
            bttn_AgregarSinRebaba.Text = ">>";
            bttn_AgregarSinRebaba.UseVisualStyleBackColor = true;
            bttn_AgregarSinRebaba.Click += new System.EventHandler(button6_Click);
            // 
            // txt_ConRebaba
            // 
            txt_ConRebaba.Location = new System.Drawing.Point(319, 277);
            txt_ConRebaba.MaxLength = 9;
            txt_ConRebaba.Name = "txt_ConRebaba";
            txt_ConRebaba.Size = new System.Drawing.Size(100, 20);
            txt_ConRebaba.TabIndex = 11;
            txt_ConRebaba.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txt_ConRebaba_KeyPress);
            // 
            // bttn_QuitarConRebaba
            // 
            bttn_QuitarConRebaba.Location = new System.Drawing.Point(448, 306);
            bttn_QuitarConRebaba.Name = "bttn_QuitarConRebaba";
            bttn_QuitarConRebaba.Size = new System.Drawing.Size(75, 23);
            bttn_QuitarConRebaba.TabIndex = 10;
            bttn_QuitarConRebaba.Text = "<<";
            bttn_QuitarConRebaba.UseVisualStyleBackColor = true;
            // 
            // bttn_AgregarConRebaba
            // 
            bttn_AgregarConRebaba.Location = new System.Drawing.Point(448, 277);
            bttn_AgregarConRebaba.Name = "bttn_AgregarConRebaba";
            bttn_AgregarConRebaba.Size = new System.Drawing.Size(75, 23);
            bttn_AgregarConRebaba.TabIndex = 9;
            bttn_AgregarConRebaba.Text = ">>";
            bttn_AgregarConRebaba.UseVisualStyleBackColor = true;
            bttn_AgregarConRebaba.Click += new System.EventHandler(bttn_AgregarConRebaba_Click);
            // 
            // txt_ProdElabCant
            // 
            txt_ProdElabCant.Location = new System.Drawing.Point(319, 84);
            txt_ProdElabCant.MaxLength = 9;
            txt_ProdElabCant.Name = "txt_ProdElabCant";
            txt_ProdElabCant.Size = new System.Drawing.Size(100, 20);
            txt_ProdElabCant.TabIndex = 8;
            txt_ProdElabCant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txt_ProdElabCant_KeyPress);
            // 
            // bttn_QuitarProdElab
            // 
            bttn_QuitarProdElab.Location = new System.Drawing.Point(448, 113);
            bttn_QuitarProdElab.Name = "bttn_QuitarProdElab";
            bttn_QuitarProdElab.Size = new System.Drawing.Size(75, 23);
            bttn_QuitarProdElab.TabIndex = 6;
            bttn_QuitarProdElab.Text = "<<";
            bttn_QuitarProdElab.UseVisualStyleBackColor = true;
            // 
            // bttn_AgregarProdElab
            // 
            bttn_AgregarProdElab.Location = new System.Drawing.Point(448, 84);
            bttn_AgregarProdElab.Name = "bttn_AgregarProdElab";
            bttn_AgregarProdElab.Size = new System.Drawing.Size(75, 23);
            bttn_AgregarProdElab.TabIndex = 5;
            bttn_AgregarProdElab.Text = ">>";
            bttn_AgregarProdElab.UseVisualStyleBackColor = true;
            bttn_AgregarProdElab.Click += new System.EventHandler(button1_Click);
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(data_ListaSinRebaba);
            groupBox4.Location = new System.Drawing.Point(529, 395);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new System.Drawing.Size(266, 200);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Materia prima sin rebaba";
            // 
            // data_ListaSinRebaba
            // 
            data_ListaSinRebaba.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            data_ListaSinRebaba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_ListaSinRebaba.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            Id_MateriaPrimaPp,
            Nombre_p,
            Cantidadp});
            data_ListaSinRebaba.Location = new System.Drawing.Point(6, 18);
            data_ListaSinRebaba.Name = "data_ListaSinRebaba";
            data_ListaSinRebaba.Size = new System.Drawing.Size(254, 174);
            data_ListaSinRebaba.TabIndex = 24;
            // 
            // Id_MateriaPrimaPp
            // 
            Id_MateriaPrimaPp.HeaderText = "Id_MateriaPrimaP";
            Id_MateriaPrimaPp.Name = "Id_MateriaPrimaPp";
            Id_MateriaPrimaPp.Visible = false;
            // 
            // Nombre_p
            // 
            Nombre_p.HeaderText = "Nombre";
            Nombre_p.Name = "Nombre_p";
            // 
            // Cantidadp
            // 
            Cantidadp.HeaderText = "Cantidad";
            Cantidadp.Name = "Cantidadp";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(data_SinRebaba);
            groupBox3.Location = new System.Drawing.Point(6, 396);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(266, 200);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Materia prima sin rebaba";
            // 
            // data_SinRebaba
            // 
            data_SinRebaba.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            data_SinRebaba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_SinRebaba.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            Id_MateriaPrimaP,
            Nombrep,
            Fotop});
            data_SinRebaba.Location = new System.Drawing.Point(6, 17);
            data_SinRebaba.Name = "data_SinRebaba";
            data_SinRebaba.Size = new System.Drawing.Size(254, 174);
            data_SinRebaba.TabIndex = 21;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(data_ListaConRebaba);
            groupBox5.Location = new System.Drawing.Point(529, 197);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new System.Drawing.Size(266, 200);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            groupBox5.Text = "Materia prima con rebaba";
            // 
            // data_ListaConRebaba
            // 
            data_ListaConRebaba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_ListaConRebaba.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            Id_MateriaPrimam,
            Id_TipoPiezam,
            Lote,
            Nombre_m,
            Tipo_Pieza,
            Cantidadm});
            data_ListaConRebaba.Location = new System.Drawing.Point(6, 19);
            data_ListaConRebaba.Name = "data_ListaConRebaba";
            data_ListaConRebaba.Size = new System.Drawing.Size(254, 174);
            data_ListaConRebaba.TabIndex = 23;
            // 
            // Id_MateriaPrimam
            // 
            Id_MateriaPrimam.HeaderText = "Id_MateriaPrima";
            Id_MateriaPrimam.Name = "Id_MateriaPrimam";
            Id_MateriaPrimam.Visible = false;
            // 
            // Id_TipoPiezam
            // 
            Id_TipoPiezam.HeaderText = "Id_TipoPieza";
            Id_TipoPiezam.Name = "Id_TipoPiezam";
            Id_TipoPiezam.Visible = false;
            // 
            // Lote
            // 
            Lote.HeaderText = "Lote";
            Lote.Name = "Lote";
            // 
            // Nombre_m
            // 
            Nombre_m.HeaderText = "Nombre";
            Nombre_m.Name = "Nombre_m";
            // 
            // Tipo_Pieza
            // 
            Tipo_Pieza.HeaderText = "Tipo pieza";
            Tipo_Pieza.Name = "Tipo_Pieza";
            // 
            // Cantidadm
            // 
            Cantidadm.HeaderText = "Cantidad";
            Cantidadm.Name = "Cantidadm";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(data_ConRebaba);
            groupBox2.Location = new System.Drawing.Point(6, 198);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(266, 200);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Materia prima con rebaba";
            // 
            // data_ConRebaba
            // 
            data_ConRebaba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_ConRebaba.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            Id_MateriaPrima,
            Id_TipoPieza,
            Nombrem,
            TipoPieza,
            Lotem,
            Fotom});
            data_ConRebaba.Location = new System.Drawing.Point(6, 18);
            data_ConRebaba.Name = "data_ConRebaba";
            data_ConRebaba.Size = new System.Drawing.Size(254, 174);
            data_ConRebaba.TabIndex = 20;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(data_ListaProdElab);
            groupBox6.Location = new System.Drawing.Point(529, -2);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new System.Drawing.Size(266, 200);
            groupBox6.TabIndex = 2;
            groupBox6.TabStop = false;
            groupBox6.Text = "Productos elaborados";
            // 
            // data_ListaProdElab
            // 
            data_ListaProdElab.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            data_ListaProdElab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_ListaProdElab.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            Id_ProductoElaboradoe,
            Nombree,
            Cantidade});
            data_ListaProdElab.Location = new System.Drawing.Point(6, 19);
            data_ListaProdElab.Name = "data_ListaProdElab";
            data_ListaProdElab.Size = new System.Drawing.Size(254, 174);
            data_ListaProdElab.TabIndex = 22;
            // 
            // Id_ProductoElaboradoe
            // 
            Id_ProductoElaboradoe.HeaderText = "Id_ProductoElaborado";
            Id_ProductoElaboradoe.Name = "Id_ProductoElaboradoe";
            Id_ProductoElaboradoe.Visible = false;
            // 
            // Nombree
            // 
            Nombree.HeaderText = "Nombre";
            Nombree.Name = "Nombree";
            // 
            // Cantidade
            // 
            Cantidade.HeaderText = "Cantidad";
            Cantidade.Name = "Cantidade";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(data_ProdElaborado);
            groupBox1.Location = new System.Drawing.Point(6, -1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(266, 200);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Productos elaborados";
            // 
            // data_ProdElaborado
            // 
            data_ProdElaborado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            data_ProdElaborado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_ProdElaborado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            Id_ProductoElaborado,
            Foto,
            NombrePE});
            data_ProdElaborado.Location = new System.Drawing.Point(6, 18);
            data_ProdElaborado.Name = "data_ProdElaborado";
            data_ProdElaborado.Size = new System.Drawing.Size(254, 174);
            data_ProdElaborado.TabIndex = 19;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Id_MateriaPrimaP
            // 
            Id_MateriaPrimaP.HeaderText = "Id_MateriaPrimaP";
            Id_MateriaPrimaP.Name = "Id_MateriaPrimaP";
            Id_MateriaPrimaP.Visible = false;
            // 
            // Nombrep
            // 
            Nombrep.HeaderText = "Nombre";
            Nombrep.Name = "Nombrep";
            // 
            // Fotop
            // 
            Fotop.HeaderText = "Foto";
            Fotop.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            Fotop.MinimumWidth = 50;
            Fotop.Name = "Fotop";
            Fotop.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            Fotop.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            Fotop.Visible = false;
            // 
            // Id_MateriaPrima
            // 
            Id_MateriaPrima.HeaderText = "Id_MateriaPrima";
            Id_MateriaPrima.Name = "Id_MateriaPrima";
            Id_MateriaPrima.Visible = false;
            // 
            // Id_TipoPieza
            // 
            Id_TipoPieza.HeaderText = "Id_TipoPieza";
            Id_TipoPieza.Name = "Id_TipoPieza";
            Id_TipoPieza.Visible = false;
            // 
            // Nombrem
            // 
            Nombrem.HeaderText = "Nombre";
            Nombrem.Name = "Nombrem";
            // 
            // TipoPieza
            // 
            TipoPieza.HeaderText = "Tipo pieza";
            TipoPieza.Name = "TipoPieza";
            // 
            // Lotem
            // 
            Lotem.HeaderText = "Lote";
            Lotem.Name = "Lotem";
            // 
            // Fotom
            // 
            Fotom.HeaderText = "Foto";
            Fotom.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            Fotom.MinimumWidth = 50;
            Fotom.Name = "Fotom";
            Fotom.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            Fotom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            Fotom.Visible = false;
            // 
            // Id_ProductoElaborado
            // 
            Id_ProductoElaborado.HeaderText = "Id_ProductoElaborado";
            Id_ProductoElaborado.Name = "Id_ProductoElaborado";
            Id_ProductoElaborado.Visible = false;
            // 
            // Foto
            // 
            Foto.HeaderText = "Foto";
            Foto.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            Foto.MinimumWidth = 50;
            Foto.Name = "Foto";
            Foto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            Foto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            Foto.Visible = false;
            // 
            // NombrePE
            // 
            NombrePE.HeaderText = "Nombre";
            NombrePE.Name = "NombrePE";
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
            // Ingredientes_Empaques
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(228)))), ((int)(((byte)(196)))));
            ClientSize = new System.Drawing.Size(788, 630);
            Controls.Add(panel_Ingredientes);
            Controls.Add(menuStrip1);
            MaximizeBox = false;
            Name = "Ingredientes_Empaques";
            Text = "Ingredientes empaques";
            Icon = global::Shajobe.Properties.Resources.Indirecto_ICO;
            Load += new System.EventHandler(Ingredientes_Empaques_Load);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel_Ingredientes.ResumeLayout(false);
            panel_Ingredientes.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(data_ListaSinRebaba)).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(data_SinRebaba)).EndInit();
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(data_ListaConRebaba)).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(data_ConRebaba)).EndInit();
            groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(data_ListaProdElab)).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(data_ProdElaborado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(errorProvider1)).EndInit();
            AnimateWindow(Handle, 350, AnimateWindowFlags.AW_CENTER);
            AnimateWindow(Handle, 350, AnimateWindowFlags.AW_CENTER | AnimateWindowFlags.AW_SLIDE);
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        #region Eventos
        int Idp;
        private void empaqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel panel_Empaques = new System.Windows.Forms.Panel();
            Label lbl_Cantidad_Empaque = new System.Windows.Forms.Label();
            Label lbl_Cantidad_PTerminados = new System.Windows.Forms.Label();
            TextBox txt_Cantidad_Empaque = new System.Windows.Forms.TextBox();
            Button bttn_Quitar_Empaque = new System.Windows.Forms.Button();
            Button bttn_Agregar_Empaque = new System.Windows.Forms.Button();
            TextBox txt_Cantidad_PTerminados = new System.Windows.Forms.TextBox();
            Button bttn_Quitar_PTerminados = new System.Windows.Forms.Button();
            Button bttn_Agregar_PTerminados = new System.Windows.Forms.Button();
            GroupBox groupBoxProductoEmpaque = new System.Windows.Forms.GroupBox();
            DataGridView dataGridEmpaque = new System.Windows.Forms.DataGridView();
            GroupBox groupBoxProductoEmpaqueLista = new System.Windows.Forms.GroupBox();
            DataGridView dataGridEmpaque_Lista = new System.Windows.Forms.DataGridView();
            GroupBox groupBoxProductoTerminado = new System.Windows.Forms.GroupBox();
            DataGridView dataGridPTerminados = new System.Windows.Forms.DataGridView();
            GroupBox groupBoxProductoTerminadoLista = new System.Windows.Forms.GroupBox();
            DataGridView dataGridPTerminados_Lista = new System.Windows.Forms.DataGridView();
            panel_Empaques.SuspendLayout();
            groupBoxProductoEmpaque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(dataGridEmpaque)).BeginInit();
            groupBoxProductoEmpaqueLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(dataGridEmpaque_Lista)).BeginInit();
            groupBoxProductoTerminado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(dataGridPTerminados)).BeginInit();
            groupBoxProductoTerminadoLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(dataGridPTerminados_Lista)).BeginInit();
            SuspendLayout();
            // 
            // panel_Empaques
            // 
            panel_Empaques.Controls.Add(lbl_Cantidad_Empaque);
            panel_Empaques.Controls.Add(lbl_Cantidad_PTerminados);
            panel_Empaques.Controls.Add(txt_Cantidad_Empaque);
            panel_Empaques.Controls.Add(bttn_Quitar_Empaque);
            panel_Empaques.Controls.Add(bttn_Agregar_Empaque);
            panel_Empaques.Controls.Add(txt_Cantidad_PTerminados);
            panel_Empaques.Controls.Add(bttn_Quitar_PTerminados);
            panel_Empaques.Controls.Add(bttn_Agregar_PTerminados);
            panel_Empaques.Controls.Add(groupBoxProductoEmpaque);
            panel_Empaques.Controls.Add(groupBoxProductoEmpaqueLista);
            panel_Empaques.Controls.Add(groupBoxProductoTerminado);
            panel_Empaques.Controls.Add(groupBoxProductoTerminadoLista);
            panel_Empaques.Location = new System.Drawing.Point(-9, 27);
            panel_Empaques.Name = "panel_Empaques";
            panel_Empaques.Size = new System.Drawing.Size(804, 603);
            panel_Empaques.TabIndex = 1;
            // 
            // lbl_Cantidad_Empaque
            // 
            lbl_Cantidad_Empaque.AutoSize = true;
            lbl_Cantidad_Empaque.Location = new System.Drawing.Point(316, 261);
            lbl_Cantidad_Empaque.Name = "lbl_Cantidad_Empaque";
            lbl_Cantidad_Empaque.Size = new System.Drawing.Size(49, 13);
            lbl_Cantidad_Empaque.TabIndex = 16;
            lbl_Cantidad_Empaque.Text = "Cantidad";
            // 
            // lbl_Cantidad_PTerminados
            // 
            lbl_Cantidad_PTerminados.AutoSize = true;
            lbl_Cantidad_PTerminados.Location = new System.Drawing.Point(316, 68);
            lbl_Cantidad_PTerminados.Name = "lbl_Cantidad_PTerminados";
            lbl_Cantidad_PTerminados.Size = new System.Drawing.Size(49, 13);
            lbl_Cantidad_PTerminados.TabIndex = 15;
            lbl_Cantidad_PTerminados.Text = "Cantidad";
            // 
            // txt_Cantidad_Empaque
            // 
            txt_Cantidad_Empaque.Location = new System.Drawing.Point(319, 277);
            txt_Cantidad_Empaque.Name = "txt_Cantidad_Empaque";
            txt_Cantidad_Empaque.Size = new System.Drawing.Size(100, 20);
            txt_Cantidad_Empaque.TabIndex = 11;
            // 
            // bttn_Quitar_Empaque
            // 
            bttn_Quitar_Empaque.Location = new System.Drawing.Point(448, 306);
            bttn_Quitar_Empaque.Name = "bttn_Quitar_Empaque";
            bttn_Quitar_Empaque.Size = new System.Drawing.Size(75, 23);
            bttn_Quitar_Empaque.TabIndex = 10;
            bttn_Quitar_Empaque.Text = "<<";
            bttn_Quitar_Empaque.UseVisualStyleBackColor = true;
            // 
            // bttn_Agregar_Empaque
            // 
            bttn_Agregar_Empaque.Location = new System.Drawing.Point(448, 277);
            bttn_Agregar_Empaque.Name = "bttn_Agregar_Empaque";
            bttn_Agregar_Empaque.Size = new System.Drawing.Size(75, 23);
            bttn_Agregar_Empaque.TabIndex = 9;
            bttn_Agregar_Empaque.Text = ">>";
            bttn_Agregar_Empaque.UseVisualStyleBackColor = true;
            // 
            // txt_Cantidad_PTerminados
            // 
            txt_Cantidad_PTerminados.Location = new System.Drawing.Point(319, 84);
            txt_Cantidad_PTerminados.Name = "txt_Cantidad_PTerminados";
            txt_Cantidad_PTerminados.Size = new System.Drawing.Size(100, 20);
            txt_Cantidad_PTerminados.TabIndex = 8;
            // 
            // bttn_Quitar_PTerminados
            // 
            bttn_Quitar_PTerminados.Location = new System.Drawing.Point(448, 113);
            bttn_Quitar_PTerminados.Name = "bttn_Quitar_PTerminados";
            bttn_Quitar_PTerminados.Size = new System.Drawing.Size(75, 23);
            bttn_Quitar_PTerminados.TabIndex = 6;
            bttn_Quitar_PTerminados.Text = "<<";
            bttn_Quitar_PTerminados.UseVisualStyleBackColor = true;
            // 
            // bttn_Agregar_PTerminados
            // 
            bttn_Agregar_PTerminados.Location = new System.Drawing.Point(448, 84);
            bttn_Agregar_PTerminados.Name = "bttn_Agregar_PTerminados";
            bttn_Agregar_PTerminados.Size = new System.Drawing.Size(75, 23);
            bttn_Agregar_PTerminados.TabIndex = 5;
            bttn_Agregar_PTerminados.Text = ">>";
            bttn_Agregar_PTerminados.UseVisualStyleBackColor = true;
            // 
            // groupBoxProductoEmpaque
            // 
            groupBoxProductoEmpaque.Controls.Add(dataGridEmpaque);
            groupBoxProductoEmpaque.Location = new System.Drawing.Point(529, 197);
            groupBoxProductoEmpaque.Name = "groupBoxProductoEmpaque";
            groupBoxProductoEmpaque.Size = new System.Drawing.Size(266, 200);
            groupBoxProductoEmpaque.TabIndex = 4;
            groupBoxProductoEmpaque.TabStop = false;
            groupBoxProductoEmpaque.Text = "Empaques";
            // 
            // dataGridEmpaque
            // 
            dataGridEmpaque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridEmpaque.Location = new System.Drawing.Point(6, 19);
            dataGridEmpaque.Name = "dataGridEmpaque";
            dataGridEmpaque.Size = new System.Drawing.Size(254, 174);
            dataGridEmpaque.TabIndex = 23;
            // 
            // groupBoxProductoEmpaqueLista
            // 
            groupBoxProductoEmpaqueLista.Controls.Add(dataGridEmpaque_Lista);
            groupBoxProductoEmpaqueLista.Location = new System.Drawing.Point(6, 198);
            groupBoxProductoEmpaqueLista.Name = "groupBoxProductoEmpaqueLista";
            groupBoxProductoEmpaqueLista.Size = new System.Drawing.Size(266, 200);
            groupBoxProductoEmpaqueLista.TabIndex = 1;
            groupBoxProductoEmpaqueLista.TabStop = false;
            groupBoxProductoEmpaqueLista.Text = "Empaques";
            // 
            // dataGridEmpaque_Lista
            // 
            dataGridEmpaque_Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridEmpaque_Lista.Location = new System.Drawing.Point(6, 18);
            dataGridEmpaque_Lista.Name = "dataGridEmpaque_Lista";
            dataGridEmpaque_Lista.Size = new System.Drawing.Size(254, 174);
            dataGridEmpaque_Lista.TabIndex = 20;
            // 
            // groupBoxProductoTerminado
            // 
            groupBoxProductoTerminado.Controls.Add(dataGridPTerminados);
            groupBoxProductoTerminado.Location = new System.Drawing.Point(529, -1);
            groupBoxProductoTerminado.Name = "groupBoxProductoTerminado";
            groupBoxProductoTerminado.Size = new System.Drawing.Size(266, 200);
            groupBoxProductoTerminado.TabIndex = 2;
            groupBoxProductoTerminado.TabStop = false;
            groupBoxProductoTerminado.Text = "Productos terminados";
            // 
            // dataGridPTerminados
            // 
            dataGridPTerminados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPTerminados.Location = new System.Drawing.Point(6, 19);
            dataGridPTerminados.Name = "dataGridPTerminados";
            dataGridPTerminados.Size = new System.Drawing.Size(254, 174);
            dataGridPTerminados.TabIndex = 22;
            // 
            // groupBoxProductoTerminadoLista
            // 
            groupBoxProductoTerminadoLista.Controls.Add(dataGridPTerminados_Lista);
            groupBoxProductoTerminadoLista.Location = new System.Drawing.Point(6, -1);
            groupBoxProductoTerminadoLista.Name = "groupBoxProductoTerminadoLista";
            groupBoxProductoTerminadoLista.Size = new System.Drawing.Size(266, 200);
            groupBoxProductoTerminadoLista.TabIndex = 0;
            groupBoxProductoTerminadoLista.TabStop = false;
            groupBoxProductoTerminadoLista.Text = "Productos terminados";
            // 
            // dataGridPTerminados_Lista
            // 
            dataGridPTerminados_Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPTerminados_Lista.Location = new System.Drawing.Point(6, 18);
            dataGridPTerminados_Lista.Name = "dataGridPTerminados_Lista";
            dataGridPTerminados_Lista.Size = new System.Drawing.Size(254, 174);
            dataGridPTerminados_Lista.TabIndex = 19;

            //Agregando el panel a la forma
            this.Controls.Add(panel_Empaques);
            //Ocultando el panel principal ingredientes
            panel_Ingredientes.Visible = false;
            panel_Ingredientes.Enabled = false;

        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_Ingredientes.Visible = true;
            panel_Ingredientes.Enabled = true;
            //Limpiando los datagridview para actualizar nuevamente
            data_ConRebaba.Rows.Clear();
            data_ProdElaborado.Rows.Clear();
            data_SinRebaba.Rows.Clear();
            data_ListaProdElab.Rows.Clear();
            data_ListaConRebaba.Rows.Clear();
            data_ListaSinRebaba.Rows.Clear();
            //llenando campos
            Pro_Elaborado();
            Pro_ConRebaba();
            Pro_SinRebaba();
        }
        private void Ingredientes_Empaques_Load(object sender, EventArgs e)
        {
            Diseño_Forma();
            //llenando campos
            Pro_Elaborado();
            Pro_ConRebaba();
            Pro_SinRebaba();
        }
        private void Pro_Elaborado()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand coman = new OleDbCommand();
            OleDbDataReader dr;
            con.ConnectionString = ObtenerString();
            coman.Connection = con;
            coman.CommandText = "Select Id_ProductoElaborado AS Id_ProductoElaborado, Nombre AS Nombre,Foto AS Foto from Tb_ProductoElaborado";
            coman.CommandType = CommandType.Text;
            con.Open();
            data_ProdElaborado.Rows.Clear();
            dr = coman.ExecuteReader();
            while (dr.Read())
            {
                int Renglon = data_ProdElaborado.Rows.Add();
                Idp = dr.GetInt32(dr.GetOrdinal("Id_ProductoElaborado"));
                data_ProdElaborado.Rows[Renglon].Cells["Id_ProductoElaborado"].Value = dr.GetInt32(dr.GetOrdinal("Id_ProductoElaborado"));
                //Foto.Image = Image.FromFile(dr.GetString(dr.GetOrdinal("Foto")));
                data_ProdElaborado.Rows[Renglon].Cells["NombrePE"].Value = dr.GetString(dr.GetOrdinal("Nombre"));

            }
            con.Close();
        }
        private void Pro_ConRebaba()
        {

            OleDbConnection con = new OleDbConnection();
            OleDbCommand coman = new OleDbCommand();
            OleDbDataReader dr;
            con.ConnectionString = ObtenerString();
            coman.Connection = con;
            coman.CommandText = "SELECT Tb_MateriaPrima.Id_MateriaPrima AS Id_MateriaPrima, Tb_MateriaPrima.Id_TipoPieza AS Id_TipoPieza, Tb_MateriaPrima.Nombre AS Nombre, Tb_MateriaPrima.Foto AS Foto, Tb_TipoPieza.Lote As Lote, Tb_TipoPieza.Nombre AS TipoPieza FROM Tb_MateriaPrima INNER JOIN Tb_TipoPieza ON Tb_MateriaPrima.Id_TipoPieza = Tb_TipoPieza.Id_TipoPieza ";
            coman.CommandType = CommandType.Text;
            con.Open();
            data_ConRebaba.Rows.Clear();
            dr = coman.ExecuteReader();
            while (dr.Read())
            {
                int Renglon = data_ConRebaba.Rows.Add();
                Idp = dr.GetInt32(dr.GetOrdinal("Id_MateriaPrima"));
                data_ConRebaba.Rows[Renglon].Cells["Id_MateriaPrima"].Value = dr.GetInt32(dr.GetOrdinal("Id_MateriaPrima"));
                data_ConRebaba.Rows[Renglon].Cells["Id_TipoPieza"].Value = dr.GetInt32(dr.GetOrdinal("Id_TipoPieza"));
                //Fotom.Image = Image.FromFile(dr.GetString(dr.GetOrdinal("Foto")));
                data_ConRebaba.Rows[Renglon].Cells["Nombrem"].Value = dr.GetString(dr.GetOrdinal("Nombre"));
                data_ConRebaba.Rows[Renglon].Cells["TipoPieza"].Value = dr.GetString(dr.GetOrdinal("TipoPieza"));
                data_ConRebaba.Rows[Renglon].Cells["Lotem"].Value = dr.GetString(dr.GetOrdinal("Lote"));
            }
            con.Close();
        }
        private void Pro_SinRebaba()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand coman = new OleDbCommand();
            OleDbDataReader dr;
            con.ConnectionString = ObtenerString();
            coman.Connection = con;
            coman.CommandText = "SELECT Id_MateriaPrimaP,Nombre,Foto From Tb_MateriaPrimaP";
            coman.CommandType = CommandType.Text;
            con.Open();
            data_SinRebaba.Rows.Clear();
            dr = coman.ExecuteReader();
            while (dr.Read())
            {
                int Renglon = data_SinRebaba.Rows.Add();
                Idp = dr.GetInt32(dr.GetOrdinal("Id_MateriaPrimaP"));
                data_SinRebaba.Rows[Renglon].Cells["Id_MateriaPrimaP"].Value = dr.GetInt32(dr.GetOrdinal("Id_MateriaPrimaP"));
                data_SinRebaba.Rows[Renglon].Cells["Nombrep"].Value = dr.GetString(dr.GetOrdinal("Nombre"));
            }
            con.Close();
        }
        public static string ObtenerString()
        {
            return Settings.Default.ShajobeConnectionString;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = data_ProdElaborado.CurrentRow;
            if (row != null)
            {
                if (txt_ProdElabCant.Text.Trim() != "")
                {
                    int indicePe = data_ListaProdElab.Rows.Add();
                    data_ListaProdElab.Rows[indicePe].Cells["Id_ProductoElaboradoe"].Value = data_ProdElaborado.CurrentRow.Cells["Id_ProductoElaborado"].Value;
                    data_ListaProdElab.Rows[indicePe].Cells["Nombree"].Value = data_ProdElaborado.CurrentRow.Cells["NombrePE"].Value;
                    data_ListaProdElab.Rows[indicePe].Cells["Cantidade"].Value = txt_ProdElabCant.Text;
                }
                else
                {
                    MessageBox.Show("Introdusca una cantidad de producto que va a emplear", "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errorProvider1.SetError(txt_ProdElabCant, "No puedes dejar el campo vacio");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto", "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(data_ProdElaborado, "Selecciona un elemento");
            }
        }
        private void bttn_AgregarConRebaba_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = data_ConRebaba.CurrentRow;
            if (row != null)
            {
                if (txt_ConRebaba.Text.Trim() != "")
                {
                    int indiceCo = data_ListaConRebaba.Rows.Add();
                    data_ListaConRebaba.Rows[indiceCo].Cells["Id_MateriaPrimam"].Value = data_ConRebaba.CurrentRow.Cells["Id_MateriaPrima"].Value;
                    data_ListaConRebaba.Rows[indiceCo].Cells["Id_TipoPiezam"].Value = data_ConRebaba.CurrentRow.Cells["Id_TipoPieza"].Value;
                    data_ListaConRebaba.Rows[indiceCo].Cells["Lote"].Value = data_ConRebaba.CurrentRow.Cells["Lotem"].Value;
                    data_ListaConRebaba.Rows[indiceCo].Cells["Nombre_m"].Value = data_ConRebaba.CurrentRow.Cells["Nombrem"].Value;
                    data_ListaConRebaba.Rows[indiceCo].Cells["Tipo_Pieza"].Value = data_ConRebaba.CurrentRow.Cells["TipoPieza"].Value;
                    data_ListaConRebaba.Rows[indiceCo].Cells["Cantidadm"].Value = txt_ConRebaba.Text;
                }
                else
                {
                    MessageBox.Show("Introdusca una cantidad de producto que va a emplear", "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errorProvider1.SetError(txt_ConRebaba, "No puedes dejar el campo vacio");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto", "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(data_ConRebaba, "Selecciona un elemento");
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = data_ProdElaborado.CurrentRow;
            if (row != null)
            {
                if (txt_SinRebaba.Text.Trim() != "")
                {
                    int indiceSi = data_ListaSinRebaba.Rows.Add();
                    data_ListaSinRebaba.Rows[indiceSi].Cells["Id_MateriaPrimaPp"].Value = data_SinRebaba.CurrentRow.Cells["Id_MateriaPrimaP"].Value;
                    data_ListaSinRebaba.Rows[indiceSi].Cells["Nombre_p"].Value = data_SinRebaba.CurrentRow.Cells["Nombrep"].Value;
                    data_ListaSinRebaba.Rows[indiceSi].Cells["Cantidadp"].Value = txt_SinRebaba.Text;
                }
                else
                {
                    MessageBox.Show("Introdusca una cantidad de producto que va a emplear", "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errorProvider1.SetError(txt_SinRebaba, "No puedes dejar el campo vacio");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto", "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(data_ConRebaba, "Selecciona un elemento");
            }
        }
        //      VALIDACION DE CAMPOS
        private void txt_ProdElabCant_KeyPress(object sender, KeyPressEventArgs e)
        {
            //---------Apartado de numeros-------------Apartado de teclas especiales Retroceso y suprimir------------------------Uso del punto
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar < 7 || e.KeyChar > 9) && (e.KeyChar < 126 || e.KeyChar > 128) && (e.KeyChar < 45 || e.KeyChar > 47))
            {
                MessageBox.Show("Solo se aceptan numeros", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                e.Handled = true;
            }
        }
        private void txt_ConRebaba_KeyPress(object sender, KeyPressEventArgs e)
        {
            //---------Apartado de numeros-------------Apartado de teclas especiales Retroceso y suprimir------------------------Uso del punto
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar < 7 || e.KeyChar > 9) && (e.KeyChar < 126 || e.KeyChar > 128) && (e.KeyChar < 45 || e.KeyChar > 47))
            {
                MessageBox.Show("Solo se aceptan numeros", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                e.Handled = true;
            }
        }
        private void txt_SinRebaba_KeyPress(object sender, KeyPressEventArgs e)
        {
            //---------Apartado de numeros-------------Apartado de teclas especiales Retroceso y suprimir------------------------Uso del punto
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar < 7 || e.KeyChar > 9) && (e.KeyChar < 126 || e.KeyChar > 128) && (e.KeyChar < 45 || e.KeyChar > 47))
            {
                MessageBox.Show("Solo se aceptan numeros", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                e.Handled = true;
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
