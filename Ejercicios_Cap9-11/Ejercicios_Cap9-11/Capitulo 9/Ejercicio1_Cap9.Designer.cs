namespace Ejercicios_Cap9_11.Capitulo_9
{
    partial class Ejercicio1_Cap9
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
            this.Nuevo_button = new System.Windows.Forms.Button();
            this.CantidadProducto_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.PrecioProducto_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NombreProducto_textBox = new System.Windows.Forms.TextBox();
            this.Guardar_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadProducto_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioProducto_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Nuevo_button
            // 
            this.Nuevo_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nuevo_button.Location = new System.Drawing.Point(75, 216);
            this.Nuevo_button.Name = "Nuevo_button";
            this.Nuevo_button.Size = new System.Drawing.Size(95, 32);
            this.Nuevo_button.TabIndex = 0;
            this.Nuevo_button.Text = "Nuevo";
            this.Nuevo_button.UseVisualStyleBackColor = true;
            // 
            // CantidadProducto_numericUpDown
            // 
            this.CantidadProducto_numericUpDown.Location = new System.Drawing.Point(184, 75);
            this.CantidadProducto_numericUpDown.Name = "CantidadProducto_numericUpDown";
            this.CantidadProducto_numericUpDown.Size = new System.Drawing.Size(261, 20);
            this.CantidadProducto_numericUpDown.TabIndex = 2;
            // 
            // PrecioProducto_numericUpDown
            // 
            this.PrecioProducto_numericUpDown.Location = new System.Drawing.Point(184, 125);
            this.PrecioProducto_numericUpDown.Name = "PrecioProducto_numericUpDown";
            this.PrecioProducto_numericUpDown.Size = new System.Drawing.Size(261, 20);
            this.PrecioProducto_numericUpDown.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cantidad del Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Precio del Producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre del Producto";
            // 
            // NombreProducto_textBox
            // 
            this.NombreProducto_textBox.Location = new System.Drawing.Point(184, 29);
            this.NombreProducto_textBox.Name = "NombreProducto_textBox";
            this.NombreProducto_textBox.Size = new System.Drawing.Size(261, 20);
            this.NombreProducto_textBox.TabIndex = 8;
            // 
            // Guardar_button
            // 
            this.Guardar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardar_button.Location = new System.Drawing.Point(215, 216);
            this.Guardar_button.Name = "Guardar_button";
            this.Guardar_button.Size = new System.Drawing.Size(91, 32);
            this.Guardar_button.TabIndex = 9;
            this.Guardar_button.Text = "Guardar";
            this.Guardar_button.UseVisualStyleBackColor = true;
            this.Guardar_button.Click += new System.EventHandler(this.Guardar_button_Click);
            // 
            // Ejercicio1_Cap9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 259);
            this.Controls.Add(this.Guardar_button);
            this.Controls.Add(this.NombreProducto_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PrecioProducto_numericUpDown);
            this.Controls.Add(this.CantidadProducto_numericUpDown);
            this.Controls.Add(this.Nuevo_button);
            this.Name = "Ejercicio1_Cap9";
            this.Text = "Ejercicio1_Cap9";
            ((System.ComponentModel.ISupportInitialize)(this.CantidadProducto_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioProducto_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Nuevo_button;
        private System.Windows.Forms.NumericUpDown CantidadProducto_numericUpDown;
        private System.Windows.Forms.NumericUpDown PrecioProducto_numericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NombreProducto_textBox;
        private System.Windows.Forms.Button Guardar_button;
    }
}