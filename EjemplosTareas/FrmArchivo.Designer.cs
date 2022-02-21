
namespace EjemplosTareas
{
    partial class FrmArchivo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.btnEscribirDatos = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEscribirDatos
            // 
            this.btnEscribirDatos.Location = new System.Drawing.Point(12, 12);
            this.btnEscribirDatos.Name = "btnEscribirDatos";
            this.btnEscribirDatos.Size = new System.Drawing.Size(187, 29);
            this.btnEscribirDatos.TabIndex = 0;
            this.btnEscribirDatos.Text = "Escribir Datos";
            this.btnEscribirDatos.UseVisualStyleBackColor = true;
            this.btnEscribirDatos.Click += new System.EventHandler(this.btnEscribirDatos_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 1;
            // 
            // FrmArchivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnEscribirDatos);
            this.Name = "FrmArchivo";
            this.Text = "FrmArchivo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEscribirDatos;
        private System.Windows.Forms.TextBox textBox1;
    }
}