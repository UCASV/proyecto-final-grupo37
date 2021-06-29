namespace ProyectoPOO_BDD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            this.txtDui = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccionDomicilio = new System.Windows.Forms.TextBox();
            this.ComboInstitucion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCrear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEnfermedad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtDui
            // 
            this.txtDui.Location = new System.Drawing.Point(156, 95);
            this.txtDui.Name = "txtDui";
            this.txtDui.Size = new System.Drawing.Size(199, 20);
            this.txtDui.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(156, 158);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(199, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(156, 288);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(199, 20);
            this.txtTelefono.TabIndex = 3;
            // 
            // txtDireccionDomicilio
            // 
            this.txtDireccionDomicilio.Location = new System.Drawing.Point(156, 224);
            this.txtDireccionDomicilio.Name = "txtDireccionDomicilio";
            this.txtDireccionDomicilio.Size = new System.Drawing.Size(199, 20);
            this.txtDireccionDomicilio.TabIndex = 2;
            // 
            // ComboInstitucion
            // 
            this.ComboInstitucion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboInstitucion.FormattingEnabled = true;
            this.ComboInstitucion.Items.AddRange(new object[] {"Educacion", "Salud", "PNC", "Gobierno", "Fuerza Armada", "Periodismo", "Otros"});
            this.ComboInstitucion.Location = new System.Drawing.Point(155, 483);
            this.ComboInstitucion.Name = "ComboInstitucion";
            this.ComboInstitucion.Size = new System.Drawing.Size(199, 21);
            this.ComboInstitucion.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(156, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Dui";
            // 
            // BtnCrear
            // 
            this.BtnCrear.Location = new System.Drawing.Point(154, 588);
            this.BtnCrear.Name = "BtnCrear";
            this.BtnCrear.Size = new System.Drawing.Size(224, 87);
            this.BtnCrear.TabIndex = 14;
            this.BtnCrear.Text = "Crear Usuario";
            this.BtnCrear.UseVisualStyleBackColor = true;
            this.BtnCrear.Click += new System.EventHandler(this.BtnCrear_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(156, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nombre completo";
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.Location = new System.Drawing.Point(153, 360);
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Size = new System.Drawing.Size(199, 20);
            this.txtCorreoElectronico.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(157, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "Correo eletronico";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(157, 461);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 19);
            this.label4.TabIndex = 18;
            this.label4.Text = "Institucion";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(154, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "Enfermedad";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(156, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 19);
            this.label6.TabIndex = 20;
            this.label6.Text = "Numero telefónico";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(156, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(198, 19);
            this.label7.TabIndex = 21;
            this.label7.Text = "Direccion";
            // 
            // txtEnfermedad
            // 
            this.txtEnfermedad.Location = new System.Drawing.Point(155, 424);
            this.txtEnfermedad.Name = "txtEnfermedad";
            this.txtEnfermedad.Size = new System.Drawing.Size(199, 20);
            this.txtEnfermedad.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 695);
            this.Controls.Add(this.txtEnfermedad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCorreoElectronico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnCrear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboInstitucion);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDireccionDomicilio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDui);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCorreoElectronico;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEnfermedad;

        private System.Windows.Forms.Button BtnCrear;

        private System.Windows.Forms.ComboBox ComboInstitucion;

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccionDomicilio;
        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.TextBox txtDui;
        private System.Windows.Forms.TextBox txtName;

        #endregion
    }
}