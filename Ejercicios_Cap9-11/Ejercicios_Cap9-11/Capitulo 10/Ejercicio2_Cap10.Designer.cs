namespace Ejercicios_Cap9_11.Capitulo_10
{
    partial class Ejercicio2_Cap10
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
            this.label1 = new System.Windows.Forms.Label();
            this.Nombre_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Matricula_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.Carrera_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Nuevo_button = new System.Windows.Forms.Button();
            this.Guardar_button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Buscar_button = new System.Windows.Forms.Button();
            this.Edad_numericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Edad_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // Nombre_textBox
            // 
            this.Nombre_textBox.Location = new System.Drawing.Point(120, 138);
            this.Nombre_textBox.Name = "Nombre_textBox";
            this.Nombre_textBox.Size = new System.Drawing.Size(200, 20);
            this.Nombre_textBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Matricula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Edad";
            // 
            // Matricula_maskedTextBox
            // 
            this.Matricula_maskedTextBox.Location = new System.Drawing.Point(120, 83);
            this.Matricula_maskedTextBox.Mask = "9999-9999";
            this.Matricula_maskedTextBox.Name = "Matricula_maskedTextBox";
            this.Matricula_maskedTextBox.Size = new System.Drawing.Size(111, 20);
            this.Matricula_maskedTextBox.TabIndex = 6;
            // 
            // Carrera_textBox
            // 
            this.Carrera_textBox.Location = new System.Drawing.Point(120, 247);
            this.Carrera_textBox.Name = "Carrera_textBox";
            this.Carrera_textBox.Size = new System.Drawing.Size(200, 20);
            this.Carrera_textBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Carrera";
            // 
            // Nuevo_button
            // 
            this.Nuevo_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nuevo_button.Location = new System.Drawing.Point(97, 302);
            this.Nuevo_button.Name = "Nuevo_button";
            this.Nuevo_button.Size = new System.Drawing.Size(83, 28);
            this.Nuevo_button.TabIndex = 9;
            this.Nuevo_button.Text = "Nombre";
            this.Nuevo_button.UseVisualStyleBackColor = true;
            this.Nuevo_button.Click += new System.EventHandler(this.Nuevo_button_Click);
            // 
            // Guardar_button
            // 
            this.Guardar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardar_button.Location = new System.Drawing.Point(191, 302);
            this.Guardar_button.Name = "Guardar_button";
            this.Guardar_button.Size = new System.Drawing.Size(83, 28);
            this.Guardar_button.TabIndex = 10;
            this.Guardar_button.Text = "Guardar";
            this.Guardar_button.UseVisualStyleBackColor = true;
            this.Guardar_button.Click += new System.EventHandler(this.Guardar_button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(277, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "Registro de estudiante";
            // 
            // Buscar_button
            // 
            this.Buscar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscar_button.Location = new System.Drawing.Point(237, 78);
            this.Buscar_button.Name = "Buscar_button";
            this.Buscar_button.Size = new System.Drawing.Size(83, 28);
            this.Buscar_button.TabIndex = 12;
            this.Buscar_button.Text = "Buscar";
            this.Buscar_button.UseVisualStyleBackColor = true;
            this.Buscar_button.Click += new System.EventHandler(this.Buscar_button_Click);
            // 
            // Edad_numericUpDown
            // 
            this.Edad_numericUpDown.Location = new System.Drawing.Point(120, 188);
            this.Edad_numericUpDown.Name = "Edad_numericUpDown";
            this.Edad_numericUpDown.Size = new System.Drawing.Size(200, 20);
            this.Edad_numericUpDown.TabIndex = 13;
            // 
            // Ejercicio2_Cap10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 356);
            this.Controls.Add(this.Edad_numericUpDown);
            this.Controls.Add(this.Buscar_button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Guardar_button);
            this.Controls.Add(this.Nuevo_button);
            this.Controls.Add(this.Carrera_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Matricula_maskedTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Nombre_textBox);
            this.Controls.Add(this.label1);
            this.Name = "Ejercicio2_Cap10";
            this.Text = "Ejercicio2_Cap10";
            ((System.ComponentModel.ISupportInitialize)(this.Edad_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Nombre_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox Matricula_maskedTextBox;
        private System.Windows.Forms.TextBox Carrera_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Nuevo_button;
        private System.Windows.Forms.Button Guardar_button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Buscar_button;
        private System.Windows.Forms.NumericUpDown Edad_numericUpDown;
    }
}