
namespace Examen_Segundo_Parcial_Programacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTexto = new System.Windows.Forms.Button();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTexto
            // 
            this.btnTexto.Location = new System.Drawing.Point(12, 12);
            this.btnTexto.Name = "btnTexto";
            this.btnTexto.Size = new System.Drawing.Size(150, 80);
            this.btnTexto.TabIndex = 0;
            this.btnTexto.Text = "Leer archivo de texto";
            this.btnTexto.UseVisualStyleBackColor = true;
            this.btnTexto.Click += new System.EventHandler(this.btnTexto_Click);
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(181, 12);
            this.txtTexto.Multiline = true;
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(361, 426);
            this.txtTexto.TabIndex = 1;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(12, 98);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(150, 80);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "Limpiar cuadro de texto";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.btnTexto);
            this.Name = "Form1";
            this.Text = "Lectura de texto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTexto;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

