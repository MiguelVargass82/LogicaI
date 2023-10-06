namespace Principal
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
            this.button1 = new System.Windows.Forms.Button();
            this.recta1 = new System.Windows.Forms.TextBox();
            this.recta2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(616, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "SALIR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // recta1
            // 
            this.recta1.Location = new System.Drawing.Point(61, 134);
            this.recta1.Name = "recta1";
            this.recta1.Size = new System.Drawing.Size(209, 26);
            this.recta1.TabIndex = 1;
            // 
            // recta2
            // 
            this.recta2.Location = new System.Drawing.Point(317, 134);
            this.recta2.Name = "recta2";
            this.recta2.Size = new System.Drawing.Size(186, 26);
            this.recta2.TabIndex = 2;
            this.recta2.TextChanged += new System.EventHandler(this.recta2_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(207, 179);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 44);
            this.button2.TabIndex = 3;
            this.button2.Text = "CALCULAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(548, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 4;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(807, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Este programa calcula la interseccion entre dos rectas que estan escritas en la n" +
    "otacion y=mx+b   o   y-y1=m(x-x1)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ecuacion 1";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(352, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ecuacion 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(486, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Recuerde que solo puede usar una notacion para las dos funciones";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 301);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.recta2);
            this.Controls.Add(this.recta1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Tag = "";
            this.Text = "Intereseccion";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox recta1;
        private System.Windows.Forms.TextBox recta2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

