using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Shajobe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region Diseño de la forma
            Container components = new System.ComponentModel.Container();
            PictureBox pic_Logo = new System.Windows.Forms.PictureBox();
            ErrorProvider errorProvider1 = new System.Windows.Forms.ErrorProvider(components);
            TextBox txt_Usuario = new System.Windows.Forms.TextBox();
            TextBox txt_Contrasena = new System.Windows.Forms.TextBox();
            Button btn_Iniciar = new System.Windows.Forms.Button();
            Label lbl_Contrasena = new System.Windows.Forms.Label();
            Label lbl_Usuario = new System.Windows.Forms.Label();
            // 
            // pic_Logo
            // 
            pic_Logo.BackgroundImage = global::Shajobe.Properties.Resources.Logo_Shajobe;
            pic_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pic_Logo.Location = new System.Drawing.Point(115, 22);
            pic_Logo.Name = "pic_Logo";
            pic_Logo.Size = new System.Drawing.Size(223, 113);
            pic_Logo.TabIndex = 13;
            pic_Logo.TabStop = false;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // txt_Usuario
            // 
            txt_Usuario.Location = new System.Drawing.Point(169, 170);
            txt_Usuario.Name = "txt_Usuario";
            txt_Usuario.Size = new System.Drawing.Size(127, 20);
            txt_Usuario.TabIndex = 12;
            // 
            // txt_Contrasena
            // 
            txt_Contrasena.Location = new System.Drawing.Point(169, 196);
            txt_Contrasena.Name = "txt_Contrasena";
            txt_Contrasena.PasswordChar = '*';
            txt_Contrasena.Size = new System.Drawing.Size(127, 20);
            txt_Contrasena.TabIndex = 11;
            // 
            // btn_Iniciar
            // 
            btn_Iniciar.BackgroundImage = global::Shajobe.Properties.Resources.Siguiente;
            btn_Iniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn_Iniciar.Location = new System.Drawing.Point(309, 161);
            btn_Iniciar.Name = "btn_Iniciar";
            btn_Iniciar.Size = new System.Drawing.Size(70, 63);
            btn_Iniciar.TabIndex = 10;
            btn_Iniciar.UseVisualStyleBackColor = true;
            btn_Iniciar.Click += new System.EventHandler(btn_Iniciar_Click);
            // 
            // lbl_Contrasena
            // 
            lbl_Contrasena.AutoSize = true;
            lbl_Contrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_Contrasena.Location = new System.Drawing.Point(59, 196);
            lbl_Contrasena.Name = "lbl_Contrasena";
            lbl_Contrasena.Size = new System.Drawing.Size(92, 20);
            lbl_Contrasena.TabIndex = 9;
            lbl_Contrasena.Text = "Contraseña";
            // 
            // lbl_Usuario
            // 
            lbl_Usuario.AutoSize = true;
            lbl_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_Usuario.Location = new System.Drawing.Point(59, 170);
            lbl_Usuario.Name = "lbl_Usuario";
            lbl_Usuario.Size = new System.Drawing.Size(64, 20);
            lbl_Usuario.TabIndex = 8;
            lbl_Usuario.Text = "Usuario";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(438, 247);
            Controls.Add(pic_Logo);
            Controls.Add(txt_Usuario);
            Controls.Add(txt_Contrasena);
            Controls.Add(btn_Iniciar);
            Controls.Add(lbl_Contrasena);
            Controls.Add(lbl_Usuario);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Icon = global::Shajobe.Properties.Resources.Icono_Shajobe;
            MaximumSize = new System.Drawing.Size(444, 271);
            MinimumSize = new System.Drawing.Size(444, 271);
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "I n i c i a r  s e s i ó n";
            Load += new System.EventHandler(Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(pic_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(errorProvider1)).EndInit();
            ResumeLayout(false);
            PerformLayout();
        #endregion
    }
}
