using System.ComponentModel;

namespace Proyecto_POO_BDD
{
    partial class seguimiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(seguimiento));
            this.button1 = new System.Windows.Forms.Button();
            this.dgbBuscar = new System.Windows.Forms.DataGridView();
            this.BtnSeguir = new System.Windows.Forms.Button();
            this.txtDui = new System.Windows.Forms.TextBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.dgbBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MidnightBlue;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(24, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Mostrar datos";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgbBuscar
            // 
            this.dgbBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbBuscar.Location = new System.Drawing.Point(25, 95);
            this.dgbBuscar.Name = "dgbBuscar";
            this.dgbBuscar.RowTemplate.Height = 28;
            this.dgbBuscar.Size = new System.Drawing.Size(773, 209);
            this.dgbBuscar.TabIndex = 1;
            // 
            // BtnSeguir
            // 
            this.BtnSeguir.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnSeguir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSeguir.Location = new System.Drawing.Point(25, 347);
            this.BtnSeguir.Name = "BtnSeguir";
            this.BtnSeguir.Size = new System.Drawing.Size(163, 44);
            this.BtnSeguir.TabIndex = 2;
            this.BtnSeguir.Text = "segunda dosis";
            this.BtnSeguir.UseVisualStyleBackColor = false;
            this.BtnSeguir.Click += new System.EventHandler(this.BtnSeguir_Click);
            // 
            // txtDui
            // 
            this.txtDui.Location = new System.Drawing.Point(194, 365);
            this.txtDui.Name = "txtDui";
            this.txtDui.Size = new System.Drawing.Size(404, 26);
            this.txtDui.TabIndex = 3;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnRegresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegresar.Location = new System.Drawing.Point(652, 347);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(159, 44);
            this.btnRegresar.TabIndex = 4;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // seguimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Proyecto_POO_BDD.Recursos.índice;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.txtDui);
            this.Controls.Add(this.BtnSeguir);
            this.Controls.Add(this.dgbBuscar);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "seguimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "seguimiento";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.seguimiento_FormClosing);
            ((System.ComponentModel.ISupportInitialize) (this.dgbBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnRegresar;

        private System.Windows.Forms.Button BtnSeguir;
        private System.Windows.Forms.TextBox txtDui;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgbBuscar;

        #endregion
    }
}