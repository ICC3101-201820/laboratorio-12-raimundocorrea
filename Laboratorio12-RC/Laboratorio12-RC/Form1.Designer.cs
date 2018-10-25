namespace Laboratorio12_RC
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
            this.NombreBox = new System.Windows.Forms.TextBox();
            this.ProteinasBox = new System.Windows.Forms.TextBox();
            this.GrasasBox = new System.Windows.Forms.TextBox();
            this.CarbohidratosBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Comida1 = new System.Windows.Forms.ListBox();
            this.Comida2 = new System.Windows.Forms.ListBox();
            this.Comida3 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NombreBox
            // 
            this.NombreBox.Location = new System.Drawing.Point(128, 41);
            this.NombreBox.Name = "NombreBox";
            this.NombreBox.Size = new System.Drawing.Size(100, 20);
            this.NombreBox.TabIndex = 0;
            this.NombreBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ProteinasBox
            // 
            this.ProteinasBox.Location = new System.Drawing.Point(128, 91);
            this.ProteinasBox.Name = "ProteinasBox";
            this.ProteinasBox.Size = new System.Drawing.Size(100, 20);
            this.ProteinasBox.TabIndex = 1;
            // 
            // GrasasBox
            // 
            this.GrasasBox.Location = new System.Drawing.Point(128, 140);
            this.GrasasBox.Name = "GrasasBox";
            this.GrasasBox.Size = new System.Drawing.Size(100, 20);
            this.GrasasBox.TabIndex = 2;
            // 
            // CarbohidratosBox
            // 
            this.CarbohidratosBox.Location = new System.Drawing.Point(128, 183);
            this.CarbohidratosBox.Name = "CarbohidratosBox";
            this.CarbohidratosBox.Size = new System.Drawing.Size(100, 20);
            this.CarbohidratosBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(128, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(46, 91);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(51, 13);
            this.nombreLabel.TabIndex = 5;
            this.nombreLabel.Text = "Proteinas";
            this.nombreLabel.Click += new System.EventHandler(this.nombreLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Grasas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Carbohidratos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(555, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Comidas";
            // 
            // Comida1
            // 
            this.Comida1.FormattingEnabled = true;
            this.Comida1.Location = new System.Drawing.Point(421, 58);
            this.Comida1.Name = "Comida1";
            this.Comida1.Size = new System.Drawing.Size(323, 69);
            this.Comida1.TabIndex = 13;
            this.Comida1.SelectedIndexChanged += new System.EventHandler(this.Comida1_SelectedIndexChanged);
            // 
            // Comida2
            // 
            this.Comida2.FormattingEnabled = true;
            this.Comida2.Location = new System.Drawing.Point(421, 130);
            this.Comida2.Name = "Comida2";
            this.Comida2.Size = new System.Drawing.Size(323, 69);
            this.Comida2.TabIndex = 14;
            // 
            // Comida3
            // 
            this.Comida3.FormattingEnabled = true;
            this.Comida3.Location = new System.Drawing.Point(421, 205);
            this.Comida3.Name = "Comida3";
            this.Comida3.Size = new System.Drawing.Size(323, 69);
            this.Comida3.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(539, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 446);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Comida3);
            this.Controls.Add(this.Comida2);
            this.Controls.Add(this.Comida1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nombreLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CarbohidratosBox);
            this.Controls.Add(this.GrasasBox);
            this.Controls.Add(this.ProteinasBox);
            this.Controls.Add(this.NombreBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NombreBox;
        private System.Windows.Forms.TextBox ProteinasBox;
        private System.Windows.Forms.TextBox GrasasBox;
        private System.Windows.Forms.TextBox CarbohidratosBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox Comida1;
        private System.Windows.Forms.ListBox Comida2;
        private System.Windows.Forms.ListBox Comida3;
        private System.Windows.Forms.Button button2;
    }
}

