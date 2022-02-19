namespace Ejercicio_2
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.EdadTextBox = new System.Windows.Forms.TextBox();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.MostrarDatosButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.MostrarDatosComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del estudiante";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Edad del estudiante";
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(286, 50);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(100, 23);
            this.NombreTextBox.TabIndex = 2;
            // 
            // EdadTextBox
            // 
            this.EdadTextBox.Location = new System.Drawing.Point(286, 106);
            this.EdadTextBox.Name = "EdadTextBox";
            this.EdadTextBox.Size = new System.Drawing.Size(100, 23);
            this.EdadTextBox.TabIndex = 3;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(509, 81);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(75, 23);
            this.GuardarButton.TabIndex = 4;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // MostrarDatosButton
            // 
            this.MostrarDatosButton.Location = new System.Drawing.Point(509, 160);
            this.MostrarDatosButton.Name = "MostrarDatosButton";
            this.MostrarDatosButton.Size = new System.Drawing.Size(98, 23);
            this.MostrarDatosButton.TabIndex = 5;
            this.MostrarDatosButton.Text = "Mostrar Datos";
            this.MostrarDatosButton.UseVisualStyleBackColor = true;
            this.MostrarDatosButton.Click += new System.EventHandler(this.MostrarDatosButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Datos";
            // 
            // MostrarDatosComboBox
            // 
            this.MostrarDatosComboBox.FormattingEnabled = true;
            this.MostrarDatosComboBox.Location = new System.Drawing.Point(286, 200);
            this.MostrarDatosComboBox.Name = "MostrarDatosComboBox";
            this.MostrarDatosComboBox.Size = new System.Drawing.Size(121, 23);
            this.MostrarDatosComboBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MostrarDatosComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MostrarDatosButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.EdadTextBox);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox NombreTextBox;
        private TextBox EdadTextBox;
        private Button GuardarButton;
        private Button MostrarDatosButton;
        private Label label3;
        private ComboBox MostrarDatosComboBox;
    }
}