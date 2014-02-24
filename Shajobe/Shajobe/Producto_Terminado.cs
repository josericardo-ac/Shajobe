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
    public partial class Producto_Terminado : Form
    {
        public Producto_Terminado()
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
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercadeToolStripMenuItem;
        private System.Windows.Forms.PictureBox pic_ProductoTerminado;
        private System.Windows.Forms.GroupBox groupBoxdatos;
        private System.Windows.Forms.TextBox txt_Tamaño;
        private System.Windows.Forms.Label lbl_Tamaño;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.Label lbl_Cantidad;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Lote;
        private System.Windows.Forms.TextBox txt_Clave;
        private System.Windows.Forms.Label lbl_Descripcion;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_Lote;
        private System.Windows.Forms.Label lbl_Clave;
        private System.Windows.Forms.GroupBox groupBoxfoto;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private PictureBox pic_Logo;
        #endregion
        private void Diseño_Forma()
        {
            pic_Logo = new System.Windows.Forms.PictureBox();
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Producto_Terminado));
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
            ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            acercadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            pic_ProductoTerminado = new System.Windows.Forms.PictureBox();
            groupBoxdatos = new System.Windows.Forms.GroupBox();
            txt_Tamaño = new System.Windows.Forms.TextBox();
            lbl_Tamaño = new System.Windows.Forms.Label();
            txt_Cantidad = new System.Windows.Forms.TextBox();
            lbl_Cantidad = new System.Windows.Forms.Label();
            txt_Descripcion = new System.Windows.Forms.TextBox();
            txt_Nombre = new System.Windows.Forms.TextBox();
            txt_Lote = new System.Windows.Forms.TextBox();
            txt_Clave = new System.Windows.Forms.TextBox();
            lbl_Descripcion = new System.Windows.Forms.Label();
            lbl_Nombre = new System.Windows.Forms.Label();
            lbl_Lote = new System.Windows.Forms.Label();
            lbl_Clave = new System.Windows.Forms.Label();
            groupBoxfoto = new System.Windows.Forms.GroupBox();
            btn_Buscar = new System.Windows.Forms.Button();
            errorProvider1 = new System.Windows.Forms.ErrorProvider(components);
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(pic_ProductoTerminado)).BeginInit();
            groupBoxdatos.SuspendLayout();
            groupBoxfoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(errorProvider1)).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(186)))), ((int)(((byte)(82)))));
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            archivoToolStripMenuItem,
            editarToolStripMenuItem,
            ayudaToolStripMenuItem});
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(594, 24);
            menuStrip1.TabIndex = 2;
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
            nuevoToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
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
            abrirToolStripMenuItem.Click += new System.EventHandler(abrirToolStripMenuItem_Click);
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
            guardarToolStripMenuItem.Click += new System.EventHandler(guardarToolStripMenuItem_Click);
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
            modificarToolStripMenuItem.Click += new System.EventHandler(modificarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Enabled = false;
            eliminarToolStripMenuItem.Image = global::Shajobe.Properties.Resources.Borrar;
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            eliminarToolStripMenuItem.Text = "Eliminar";
            eliminarToolStripMenuItem.Click += new System.EventHandler(eliminarToolStripMenuItem_Click);
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
            // pic_ProductoTerminado
            // 
            pic_ProductoTerminado.BackgroundImage = global::Shajobe.Properties.Resources.Producto;
            pic_ProductoTerminado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pic_ProductoTerminado.Location = new System.Drawing.Point(493, 24);
            pic_ProductoTerminado.Name = "pic_ProductoTerminado";
            pic_ProductoTerminado.Size = new System.Drawing.Size(85, 64);
            pic_ProductoTerminado.TabIndex = 21;
            pic_ProductoTerminado.TabStop = false;
            // 
            // groupBoxdatos
            // 
            groupBoxdatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            groupBoxdatos.Controls.Add(txt_Tamaño);
            groupBoxdatos.Controls.Add(lbl_Tamaño);
            groupBoxdatos.Controls.Add(txt_Cantidad);
            groupBoxdatos.Controls.Add(lbl_Cantidad);
            groupBoxdatos.Controls.Add(txt_Descripcion);
            groupBoxdatos.Controls.Add(txt_Nombre);
            groupBoxdatos.Controls.Add(txt_Lote);
            groupBoxdatos.Controls.Add(txt_Clave);
            groupBoxdatos.Controls.Add(lbl_Descripcion);
            groupBoxdatos.Controls.Add(lbl_Nombre);
            groupBoxdatos.Controls.Add(lbl_Lote);
            groupBoxdatos.Controls.Add(lbl_Clave);
            groupBoxdatos.Controls.Add(groupBoxfoto);
            groupBoxdatos.Location = new System.Drawing.Point(12, 49);
            groupBoxdatos.Name = "groupBoxdatos";
            groupBoxdatos.Size = new System.Drawing.Size(570, 289);
            groupBoxdatos.TabIndex = 20;
            groupBoxdatos.TabStop = false;
            groupBoxdatos.Text = "Datos del producto";
            // 
            // txt_Tamaño
            // 
            txt_Tamaño.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            txt_Tamaño.Location = new System.Drawing.Point(126, 225);
            txt_Tamaño.MaxLength = 2;
            txt_Tamaño.Name = "txt_Tamaño";
            txt_Tamaño.Size = new System.Drawing.Size(127, 20);
            txt_Tamaño.TabIndex = 59;
            txt_Tamaño.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txt_Tamaño_KeyPress);
            // 
            // lbl_Tamaño
            // 
            lbl_Tamaño.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            lbl_Tamaño.AutoSize = true;
            lbl_Tamaño.Location = new System.Drawing.Point(27, 229);
            lbl_Tamaño.Name = "lbl_Tamaño";
            lbl_Tamaño.Size = new System.Drawing.Size(46, 13);
            lbl_Tamaño.TabIndex = 58;
            lbl_Tamaño.Text = "Tamaño";
            // 
            // txt_Cantidad
            // 
            txt_Cantidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            txt_Cantidad.Location = new System.Drawing.Point(126, 199);
            txt_Cantidad.MaxLength = 9;
            txt_Cantidad.Name = "txt_Cantidad";
            txt_Cantidad.Size = new System.Drawing.Size(127, 20);
            txt_Cantidad.TabIndex = 56;
            txt_Cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txt_Cantidad_KeyPress);
            // 
            // lbl_Cantidad
            // 
            lbl_Cantidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            lbl_Cantidad.AutoSize = true;
            lbl_Cantidad.Location = new System.Drawing.Point(27, 203);
            lbl_Cantidad.Name = "lbl_Cantidad";
            lbl_Cantidad.Size = new System.Drawing.Size(49, 13);
            lbl_Cantidad.TabIndex = 55;
            lbl_Cantidad.Text = "Cantidad";
            // 
            // txt_Descripcion
            // 
            txt_Descripcion.Location = new System.Drawing.Point(126, 111);
            txt_Descripcion.MaxLength = 35;
            txt_Descripcion.Multiline = true;
            txt_Descripcion.Name = "txt_Descripcion";
            txt_Descripcion.Size = new System.Drawing.Size(127, 81);
            txt_Descripcion.TabIndex = 53;
            txt_Descripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txt_Descripcion_KeyPress);
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location = new System.Drawing.Point(126, 85);
            txt_Nombre.MaxLength = 25;
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new System.Drawing.Size(127, 20);
            txt_Nombre.TabIndex = 47;
            txt_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txt_Nombre_KeyPress);
            // 
            // txt_Lote
            // 
            txt_Lote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            txt_Lote.Location = new System.Drawing.Point(126, 60);
            txt_Lote.MaxLength = 15;
            txt_Lote.Name = "txt_Lote";
            txt_Lote.Size = new System.Drawing.Size(127, 20);
            txt_Lote.TabIndex = 46;
            txt_Lote.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txt_Lote_KeyPress);
            // 
            // txt_Clave
            // 
            txt_Clave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            txt_Clave.Enabled = false;
            txt_Clave.Location = new System.Drawing.Point(126, 35);
            txt_Clave.MaxLength = 8;
            txt_Clave.Name = "txt_Clave";
            txt_Clave.Size = new System.Drawing.Size(127, 20);
            txt_Clave.TabIndex = 37;
            // 
            // lbl_Descripcion
            // 
            lbl_Descripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            lbl_Descripcion.AutoSize = true;
            lbl_Descripcion.Location = new System.Drawing.Point(27, 115);
            lbl_Descripcion.Name = "lbl_Descripcion";
            lbl_Descripcion.Size = new System.Drawing.Size(63, 13);
            lbl_Descripcion.TabIndex = 44;
            lbl_Descripcion.Text = "Descripción";
            // 
            // lbl_Nombre
            // 
            lbl_Nombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            lbl_Nombre.AutoSize = true;
            lbl_Nombre.Location = new System.Drawing.Point(27, 89);
            lbl_Nombre.Name = "lbl_Nombre";
            lbl_Nombre.Size = new System.Drawing.Size(44, 13);
            lbl_Nombre.TabIndex = 38;
            lbl_Nombre.Text = "Nombre";
            // 
            // lbl_Lote
            // 
            lbl_Lote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            lbl_Lote.AutoSize = true;
            lbl_Lote.Location = new System.Drawing.Point(27, 64);
            lbl_Lote.Name = "lbl_Lote";
            lbl_Lote.Size = new System.Drawing.Size(28, 13);
            lbl_Lote.TabIndex = 36;
            lbl_Lote.Text = "Lote";
            // 
            // lbl_Clave
            // 
            lbl_Clave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            lbl_Clave.AutoSize = true;
            lbl_Clave.Location = new System.Drawing.Point(28, 42);
            lbl_Clave.Name = "lbl_Clave";
            lbl_Clave.Size = new System.Drawing.Size(34, 13);
            lbl_Clave.TabIndex = 35;
            lbl_Clave.Text = "Clave";
            // 
            // groupBoxfoto
            // 
            groupBoxfoto.Controls.Add(btn_Buscar);
            groupBoxfoto.Location = new System.Drawing.Point(301, 31);
            groupBoxfoto.Name = "groupBoxfoto";
            groupBoxfoto.Size = new System.Drawing.Size(237, 236);
            groupBoxfoto.TabIndex = 31;
            groupBoxfoto.TabStop = false;
            groupBoxfoto.Text = "Foto de producto";
            // 
            // btn_Buscar
            // 
            btn_Buscar.Location = new System.Drawing.Point(156, 207);
            btn_Buscar.Name = "btn_Buscar";
            btn_Buscar.Size = new System.Drawing.Size(75, 23);
            btn_Buscar.TabIndex = 33;
            btn_Buscar.Text = "Añadir imagen";
            btn_Buscar.UseVisualStyleBackColor = true;
            btn_Buscar.Click += new System.EventHandler(btn_Buscar_Click);
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // pic_Logo
            // 
            pic_Logo.BackgroundImage = global::Shajobe.Properties.Resources.Logo_Shajobe;
            pic_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pic_Logo.Location = new System.Drawing.Point(380, 380);
            pic_Logo.Name = "pic_Logo";
            pic_Logo.Size = new System.Drawing.Size(166, 84);
            pic_Logo.TabIndex = 13;
            pic_Logo.TabStop = false;
            // 
            // Producto_Terminado
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(228)))), ((int)(((byte)(196)))));
            ClientSize = new System.Drawing.Size(594, 352);
            Controls.Add(pic_ProductoTerminado);
            Controls.Add(groupBoxdatos);
            Controls.Add(menuStrip1);
            Icon = global::Shajobe.Properties.Resources.Producto_ICO;
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(600, 374);
            MinimumSize = new System.Drawing.Size(600, 374);
            Name = "Producto_Terminado";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Producto terminado";
            Load += new System.EventHandler(Producto_Terminado_Load);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(pic_ProductoTerminado)).EndInit();
            groupBoxdatos.ResumeLayout(false);
            groupBoxdatos.PerformLayout();
            groupBoxfoto.ResumeLayout(false);
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
        private String Direccion_Imagen = "";
        private TextBox[] Campos = new TextBox[5];
        private int Idp;//LO USO PARA OBTENER EL ID COMO RESULTADO DE LA BUSQUEDA
        private bool Espacios_Vacios = false;
        //-------------------------------------------------------------
        //----------------Limpia y restablece controles----------------
        //-------------------------------------------------------------
        private void Producto_Terminado_Load(object sender, EventArgs e)
        {
            Diseño_Forma();
            //Cree un mensaje de descripcion con los caracteres que debe escribir en el campo de medida
            ToolTip toolOpcion = new ToolTip();
            toolOpcion.AutoPopDelay = 5000;
            toolOpcion.InitialDelay = 1000;
            toolOpcion.ReshowDelay = 500;
            toolOpcion.ShowAlways = true;
            toolOpcion.SetToolTip(this.txt_Tamaño, "Solo escribe el tamaño con las siguientes opciones CH, M, G");
            toolOpcion.SetToolTip(this.txt_Cantidad, "Solo escribe la cantidad en Kilogramos");
            //CARACTERISTICA DE AUTOCOMPLETADO EN TXT_BUSQUEDA
            txt_Lote.AutoCompleteCustomSource = Autocomplete_Lote();
            txt_Lote.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_Lote.AutoCompleteSource = AutoCompleteSource.CustomSource;
            
        }
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Limpiar()
        {
            txt_Clave.Clear();
            txt_Lote.Clear();
            txt_Nombre.Clear();
            txt_Descripcion.Clear();
            txt_Cantidad.Clear();
            txt_Tamaño.Clear();
            errorProvider1.Clear();
            groupBoxdatos.Visible = true;
            eliminarToolStripMenuItem.Enabled = false;
            modificarToolStripMenuItem.Enabled = false;
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
            try
            {
                //Quito el panel de busqueda
                groupBoxfoto.Controls.Remove(pic_ImagenContacto);
            }
            catch (Exception)
            {
                //En caso de que no existe todavia picturebox
                //omite la instrucción de quitar dicho control
            }
        }
        //-------------------------------------------------------------
        //----------------CONFIGURACION DE CONTROLES-------------------
        //-------------------------------------------------------------        
        //Creando controles
        DataGridView data_resultado;
        TextBox txt_Busqueda;
        PictureBox pic_Lupa;
        Button bttn_Busqueda;
        Panel panel_Busqueda;
        Label lbl_Etiqueta;
        //Creando Columnas del DATAGRID
        DataGridViewTextBoxColumn Descripcion;
        DataGridViewTextBoxColumn Clave;
        DataGridViewTextBoxColumn Lote;
        DataGridViewTextBoxColumn Nombre;
        DataGridViewImageColumn Foto;
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
            Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Lote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Foto = new System.Windows.Forms.DataGridViewImageColumn();
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
            data_resultado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            data_resultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            Id,
            Clave,
            Lote,
            Nombre,
            Descripcion,
            Foto});
            data_resultado.Location = new System.Drawing.Point(21, 136);
            data_resultado.Name = "data_resultado";
            data_resultado.RowHeadersWidth = 25;
            data_resultado.RowTemplate.Height = 50;
            data_resultado.Size = new System.Drawing.Size(470, 150);
            data_resultado.TabIndex = 2;
            data_resultado.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.data_resultado_MouseDoubleClick);

            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Clave
            // 
            Clave.HeaderText = "Clave";
            Clave.Name = "Clave";
            // Clave
            // 
            Lote.HeaderText = "Lote";
            Lote.Name = "Lote";
            // 
            // Foto
            // 
            Foto.HeaderText = "Foto";
            Foto.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            Foto.Name = "Foto";
            Foto.Visible = false;
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
            lbl_Etiqueta.Text = "Escriba el nombre, lote ó clave del producto a buscar";
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
            panel_Busqueda.Location = new System.Drawing.Point(40, 30);
            panel_Busqueda.Name = "panel_Busqueda";
            panel_Busqueda.Size = new System.Drawing.Size(570, 321);
            panel_Busqueda.TabIndex = 35;
            panel_Busqueda.Visible = false;
            txt_Busqueda.Clear();
            data_resultado.Rows.Clear();
            this.Controls.Add(panel_Busqueda);
            groupBoxdatos.Visible = false;
            panel_Busqueda.Visible = true;
            panel_Busqueda.Enabled = true;
            //CARACTERISTICA DE AUTOCOMPLETADO EN TXT_BUSQUEDA
            txt_Busqueda.AutoCompleteCustomSource = Autocomplete();
            txt_Busqueda.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_Busqueda.AutoCompleteSource = AutoCompleteSource.CustomSource;

        }
        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool i = Verificar_CamposVacios();
            if (i == true)
                MessageBox.Show("Inserta todos los datos marcados", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                OleDbConnection con = null;
                OleDbTransaction tran = null;
                try
                {
                    con = new OleDbConnection(ObtenerString());
                    con.Open();
                    tran = con.BeginTransaction(System.Data.IsolationLevel.Serializable);
                    OleDbCommand comando = new OleDbCommand("SP_ProductoTerminado_Cambios", con, tran);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@Id_ProductoTerminado", Idp);
                    comando.Parameters.AddWithValue("@Lote", txt_Lote.Text);
                    comando.Parameters.AddWithValue("@Nombre", txt_Nombre.Text);
                    comando.Parameters.AddWithValue("@Descripcion", txt_Descripcion.Text);
                    comando.Parameters.AddWithValue("@Foto", Direccion_Imagen);
                    comando.Parameters.AddWithValue("@Cantidad", txt_Cantidad.Text);
                    comando.Parameters.AddWithValue("@Tamaño", txt_Tamaño.Text);
                    comando.ExecuteNonQuery();
                    tran.Commit();
                    con.Close();
                    MessageBox.Show("Datos Modificados con éxito", "Solicitud procesada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    modificarToolStripMenuItem.Enabled = false;
                    eliminarToolStripMenuItem.Enabled = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha ocurrido un error inesperado", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool i = Verificar_CamposVacios();
            if (i == true)
                MessageBox.Show("Inserta todos los datos marcados", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                OleDbConnection conexion = null;
                OleDbTransaction transaccion = null;
                try
                {
                    if (Direccion_Imagen == "")//LO UTILIZO EN CASO DE NO ESPECIFICAR UNA IMAGEN COMO FOTO AGREGUE UNA POR DEFECTO
                    {
                        Direccion_Imagen = @"C:\Shajobe\Imagenes\Producto.PNG";
                    }
                    conexion = new OleDbConnection(ObtenerString());
                    conexion.Open();
                    transaccion = conexion.BeginTransaction(System.Data.IsolationLevel.Serializable);
                    OleDbCommand comando = new OleDbCommand("SP_ProductoTerminado_Alta", conexion, transaccion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@Lote", txt_Lote.Text);
                    comando.Parameters.AddWithValue("@Nombre", txt_Nombre.Text);
                    comando.Parameters.AddWithValue("@Descripcion", txt_Descripcion.Text);
                    comando.Parameters.AddWithValue("@Foto", Direccion_Imagen);
                    comando.Parameters.AddWithValue("@Cantidad", txt_Cantidad.Text);
                    comando.Parameters.AddWithValue("@Tamaño", txt_Tamaño.Text);
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
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OleDbConnection conexion = null;
            OleDbTransaction transaccion = null;
            try
            {
                conexion = new OleDbConnection(ObtenerString());
                conexion.Open();
                transaccion = conexion.BeginTransaction(System.Data.IsolationLevel.Serializable);
                OleDbCommand comando = new OleDbCommand("SP_ProductoTerminado_Bajas", conexion, transaccion);
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
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //-------------------------------------------------------------
        //------------------Busqueda del sistema-----------------------
        //-------------------------------------------------------------
        public void BusquedaDatos(int Idp)
        {
            pic_ImagenContacto = new PictureBox();
            pic_ImagenContacto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pic_ImagenContacto.ErrorImage = global::Shajobe.Properties.Resources.Producto;
            pic_ImagenContacto.Location = new System.Drawing.Point(6, 19);
            pic_ImagenContacto.Name = "pic_ImagenContacto";
            pic_ImagenContacto.Size = new System.Drawing.Size(225, 183);
            pic_ImagenContacto.TabIndex = 32;
            pic_ImagenContacto.TabStop = false;
            groupBoxfoto.Controls.Add(pic_ImagenContacto);
            OleDbConnection con = new OleDbConnection();
            OleDbCommand coman = new OleDbCommand();
            OleDbDataReader dr;
            con.ConnectionString = ObtenerString();
            coman.Connection = con;
            coman.CommandText = "Select * from Tb_ProductoTerminado where Id_ProductoTerminado='" + Idp + "'";
            coman.CommandType = CommandType.Text;
            con.Open();
            data_resultado.Rows.Clear();
            dr = coman.ExecuteReader();
            while (dr.Read())
            {
                txt_Lote.Text = dr.GetString(dr.GetOrdinal("Lote"));
                txt_Clave.Text = dr.GetString(dr.GetOrdinal("Clave"));
                txt_Nombre.Text = dr.GetString(dr.GetOrdinal("Nombre"));
                txt_Descripcion.Text = dr.GetString(dr.GetOrdinal("Descripcion"));
                txt_Cantidad.Text = dr.GetDecimal(dr.GetOrdinal("Cantidad")).ToString("N");
                txt_Tamaño.Text = dr.GetString(dr.GetOrdinal("Tamaño"));
                pic_ImagenContacto.BackgroundImage = Image.FromFile(dr.GetString(dr.GetOrdinal("Foto")));
                Direccion_Imagen = dr.GetString(dr.GetOrdinal("Foto"));
                eliminarToolStripMenuItem.Enabled = true;
                modificarToolStripMenuItem.Enabled = true;
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
                coman.CommandText = "Select * from Tb_ProductoTerminado  where (Nombre='" + busqueda.ToUpper() + "'OR Clave='" + busqueda.ToUpper() + "'OR Lote='" + busqueda.ToUpper() + "') AND Activo='S'";
                coman.CommandType = CommandType.Text;
                con.Open();
                data_resultado.Rows.Clear();
                dr = coman.ExecuteReader();
                while (dr.Read())
                {
                    int Renglon = data_resultado.Rows.Add();
                    Idp = dr.GetInt32(dr.GetOrdinal("Id_ProductoTerminado"));
                    data_resultado.Rows[Renglon].Cells["Id"].Value = dr.GetInt32(dr.GetOrdinal("Id_ProductoTerminado"));
                    Foto.Image = Image.FromFile(dr.GetString(dr.GetOrdinal("Foto")));
                    data_resultado.Rows[Renglon].Cells["Nombre"].Value = dr.GetString(dr.GetOrdinal("Nombre"));
                    data_resultado.Rows[Renglon].Cells["Clave"].Value = dr.GetString(dr.GetOrdinal("Clave"));
                    data_resultado.Rows[Renglon].Cells["Lote"].Value = dr.GetString(dr.GetOrdinal("Lote"));
                    data_resultado.Rows[Renglon].Cells["Descripcion"].Value = dr.GetString(dr.GetOrdinal("Descripcion"));

                }
                con.Close();
            }
        }
        OpenFileDialog BuscarImagen;
        PictureBox pic_ImagenContacto;
        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            BuscarImagen = new OpenFileDialog();
            BuscarImagen.Filter = "Archivos de imagen (*.png, *.jpg)|*.png;*.jpg";
            //Aquí incluiremos los filtros que queramos.
            BuscarImagen.FileName = "";
            BuscarImagen.Title = "Buscar Imagen ó Foto";
            BuscarImagen.InitialDirectory = @"C:\Shajobe\Imagenes";
            if (BuscarImagen.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //Quito el panel de busqueda
                    groupBoxfoto.Controls.Remove(pic_ImagenContacto);
                }
                catch (Exception)
                {
                    //En caso de que no existe todavia picturebox
                    //omite la instrucción de quitar dicho control
                }

                pic_ImagenContacto = new PictureBox();
                pic_ImagenContacto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                pic_ImagenContacto.ErrorImage = global::Shajobe.Properties.Resources.Producto;
                pic_ImagenContacto.Location = new System.Drawing.Point(6, 19);
                pic_ImagenContacto.Name = "pic_ImagenContacto";
                pic_ImagenContacto.Size = new System.Drawing.Size(225, 183);
                pic_ImagenContacto.TabIndex = 32;
                pic_ImagenContacto.TabStop = false;
                groupBoxfoto.Controls.Add(pic_ImagenContacto);

                Direccion_Imagen = BuscarImagen.FileName;
                pic_ImagenContacto.ImageLocation = Direccion_Imagen;
                pic_ImagenContacto.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private void bttn_Busqueda_Click(object sender, EventArgs e)
        {
            Busqueda();
        }
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
        private bool Verificar_CamposVacios()
        {
            //Se introduce los textbox en un arreglo con el fin de identificar espacios vacios
            Campos[0] = txt_Lote;
            Campos[1] = txt_Nombre;
            Campos[2] = txt_Descripcion;
            Campos[3] = txt_Cantidad;
            Campos[4] = txt_Tamaño;
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
                    errorProvider1.SetError(txt_Lote, "No puedes dejar el campo vacio");
                    break;
                case 1:
                    errorProvider1.SetError(txt_Nombre, "No puedes dejar el campo vacio");
                    break;
                case 2:
                    errorProvider1.SetError(txt_Descripcion, "No puedes dejar el campo vacio");
                    break;
                case 3:
                    errorProvider1.SetError(txt_Cantidad, "No puedes dejar el campo vacio");
                    break;
                case 4:
                    errorProvider1.SetError(txt_Tamaño, "No puedes dejar el campo vacio");
                    break;
                default:
                    break;
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
        private void txt_Tamaño_KeyPress(object sender, KeyPressEventArgs e)
        {
            //---------Apartado de letras-----------------------------------------------------Apartado de teclas especiales Retroceso y suprimir
            if ((e.KeyChar < 65 || e.KeyChar > 90) && (e.KeyChar < 97 || e.KeyChar > 122) && (e.KeyChar < 7 || e.KeyChar > 9) && (e.KeyChar < 126 || e.KeyChar > 128))
            {
                MessageBox.Show("Solo se aceptan letras", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                e.Handled = true;
            }
        }
        private void txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //---------Apartado de letras-----------------------------------------------------Apartado de teclas especiales Retroceso y suprimir------------------------Uso del punto-------------------------- Uso del espacio
            if ((e.KeyChar < 65 || e.KeyChar > 90) && (e.KeyChar < 97 || e.KeyChar > 122) && (e.KeyChar < 7 || e.KeyChar > 9) && (e.KeyChar < 126 || e.KeyChar > 128) && (e.KeyChar < 45 || e.KeyChar > 47) && (e.KeyChar < 31 || e.KeyChar > 33))
            {
                MessageBox.Show("Solo se aceptan letras", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                e.Handled = true;
            }
        }
        private void txt_Descripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar < 65 || e.KeyChar > 90) && (e.KeyChar < 97 || e.KeyChar > 122) && (e.KeyChar < 7 || e.KeyChar > 9) && (e.KeyChar < 126 || e.KeyChar > 128) && (e.KeyChar < 45 || e.KeyChar > 47) && (e.KeyChar < 31 || e.KeyChar > 33))
            {
                MessageBox.Show("Solo se aceptan letras y numeros", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                e.Handled = true;
            }
        }
        private void txt_Lote_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar < 65 || e.KeyChar > 90) && (e.KeyChar < 97 || e.KeyChar > 122) && (e.KeyChar < 7 || e.KeyChar > 9) && (e.KeyChar < 126 || e.KeyChar > 128) && (e.KeyChar < 45 || e.KeyChar > 47) && (e.KeyChar < 31 || e.KeyChar > 33))
            {
                MessageBox.Show("Solo se aceptan letras y numeros", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                e.Handled = true;
            }
        }
        private void txt_Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            //---------Apartado de numeros-------------Apartado de teclas especiales Retroceso y suprimir------------------------Uso del punto
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar < 7 || e.KeyChar > 9) && (e.KeyChar < 126 || e.KeyChar > 128) && (e.KeyChar < 45 || e.KeyChar > 47))
            {
                MessageBox.Show("Solo se aceptan numeros", "Error de datos insertados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                e.Handled = true;
            }
        }

        //-------------------------------------------------------------
        //-------SELECCION DE DATOS DEL RESULTADO DE LA BUSQUEDA-------
        //-------------------------------------------------------------
        private void data_resultado_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Idp = Convert.ToInt32(data_resultado.CurrentRow.Cells["Id"].Value);
            Limpiar();
            BusquedaDatos(Idp);
            //Quito el panel de busqueda
            this.Controls.Remove(panel_Busqueda);
        }
        //-------------------------------------------------------------
        //----------------------AUTO COMPLETAR-------------------------
        //-------------------------------------------------------------
        //metodo para cargar la coleccion de datos para el autocomplete
        public static DataTable Datos()
        {
            DataTable dt = new DataTable();

            OleDbConnection conexion = new OleDbConnection(ObtenerString());//cadena conexion
            string consulta = "SELECT * FROM Tb_ProductoTerminado where Activo='S'"; //consulta a la tabla paises
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
                coleccion.Add(Convert.ToString(row["Clave"]));
                coleccion.Add(Convert.ToString(row["Lote"]));
            }

            return coleccion;
        }
        //Metodo para autocompletar el numero de lote
        public static DataTable Datos_Lote()
        {
            DataTable dt_Lote = new DataTable();

            OleDbConnection conexion = new OleDbConnection(ObtenerString());//cadena conexion
            string consulta_Lote = "SELECT Lote FROM Tb_AlmacenProductoElaborado where Activo='S'"; //consulta a la tabla paises
            OleDbCommand comando = new OleDbCommand(consulta_Lote, conexion);
            OleDbDataAdapter adap = new OleDbDataAdapter(comando);
            adap.Fill(dt_Lote);
            return dt_Lote;
        }
        //metodo para cargar la coleccion de datos para el autocomplete
        public static AutoCompleteStringCollection Autocomplete_Lote()
        {
            DataTable dt_Lote = Datos_Lote();

            AutoCompleteStringCollection coleccion_Lote = new AutoCompleteStringCollection();
            //recorrer y cargar los items para el autocompletado
            foreach (DataRow row in dt_Lote.Rows)
            {
                coleccion_Lote.Add(Convert.ToString(row["Lote"]));
            }
            return coleccion_Lote;
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
