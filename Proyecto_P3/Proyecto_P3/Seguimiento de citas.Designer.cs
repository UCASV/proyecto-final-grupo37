using System.ComponentModel;

namespace Proyecto_P3
{
    partial class Seguimiento_de_citas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Seguimiento_de_citas));
            this.lbdui = new System.Windows.Forms.Label();
            this.txtdui = new System.Windows.Forms.TextBox();
            this.dgvdatos = new System.Windows.Forms.DataGridView();
            this.btnpdf = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblcita = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.dgvdatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbdui
            // 
            this.lbdui.BackColor = System.Drawing.Color.Transparent;
            this.lbdui.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbdui.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbdui.Location = new System.Drawing.Point(37, 83);
            this.lbdui.Name = "lbdui";
            this.lbdui.Size = new System.Drawing.Size(46, 34);
            this.lbdui.TabIndex = 0;
            this.lbdui.Text = "Dui";
            // 
            // txtdui
            // 
            this.txtdui.Location = new System.Drawing.Point(83, 83);
            this.txtdui.Name = "txtdui";
            this.txtdui.Size = new System.Drawing.Size(174, 20);
            this.txtdui.TabIndex = 1;
            this.txtdui.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdui_KeyPress);
            // 
            // dgvdatos
            // 
            this.dgvdatos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdatos.Location = new System.Drawing.Point(12, 123);
            this.dgvdatos.Name = "dgvdatos";
            this.dgvdatos.Size = new System.Drawing.Size(505, 168);
            this.dgvdatos.TabIndex = 2;
            // 
            // btnpdf
            // 
            this.btnpdf.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnpdf.Location = new System.Drawing.Point(179, 323);
            this.btnpdf.Name = "btnpdf";
            this.btnpdf.Size = new System.Drawing.Size(168, 48);
            this.btnpdf.TabIndex = 3;
            this.btnpdf.Text = "Convertir a PDF";
            this.btnpdf.UseVisualStyleBackColor = true;
            this.btnpdf.Click += new System.EventHandler(this.btnpdf_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(312, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(217, 116);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // lblcita
            // 
            this.lblcita.BackColor = System.Drawing.Color.Transparent;
            this.lblcita.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblcita.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblcita.Location = new System.Drawing.Point(30, 9);
            this.lblcita.Name = "lblcita";
            this.lblcita.Size = new System.Drawing.Size(317, 48);
            this.lblcita.TabIndex = 6;
            this.lblcita.Text = "Ingresar el dui para obtener los datos de la cita";
            // 
            // Seguimiento_de_citas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(529, 417);
            this.Controls.Add(this.lblcita);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnpdf);
            this.Controls.Add(this.dgvdatos);
            this.Controls.Add(this.txtdui);
            this.Controls.Add(this.lbdui);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "Seguimiento_de_citas";
            this.Text = "Seguimiento de citas";
            this.Load += new System.EventHandler(this.Seguimiento_de_citas_Load);
            ((System.ComponentModel.ISupportInitialize) (this.dgvdatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblcita;

        private System.Windows.Forms.PictureBox pictureBox2;

        private System.Windows.Forms.TextBox txtdui;

        private System.Windows.Forms.DataGridView dgvdatos;
        private System.Windows.Forms.Button btnpdf;

        private System.Windows.Forms.Label lbdui;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}