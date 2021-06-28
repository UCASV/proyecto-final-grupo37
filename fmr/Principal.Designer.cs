using System.ComponentModel;

namespace Proyecto_POO_BDD
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnVacunacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegistrar.Location = new System.Drawing.Point(25, 275);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(208, 71);
            this.btnRegistrar.TabIndex = 0;
            this.btnRegistrar.Text = "Verificar Registros";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnVacunacion
            // 
            this.btnVacunacion.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnVacunacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVacunacion.Location = new System.Drawing.Point(25, 160);
            this.btnVacunacion.Name = "btnVacunacion";
            this.btnVacunacion.Size = new System.Drawing.Size(208, 71);
            this.btnVacunacion.TabIndex = 1;
            this.btnVacunacion.Text = "Nuevo ciudadano";
            this.btnVacunacion.UseVisualStyleBackColor = false;
            this.btnVacunacion.Click += new System.EventHandler(this.btnVacunacion_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Proyecto_POO_BDD.Recursos.photo5161255744723593540;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(675, 450);
            this.Controls.Add(this.btnVacunacion);
            this.Controls.Add(this.btnRegistrar);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnVacunacion;

        #endregion
    }
}