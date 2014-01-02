namespace Función_trigonométrica
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.TextBox_Hipotenusa = new System.Windows.Forms.TextBox();
            this.Button_Run = new System.Windows.Forms.Button();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.TextBox_Opuesto = new System.Windows.Forms.TextBox();
            this.TextBox_Adyacente = new System.Windows.Forms.TextBox();
            this.RadioButton_Hipotenusa = new System.Windows.Forms.RadioButton();
            this.RadioButton_Opuesto = new System.Windows.Forms.RadioButton();
            this.RadioButton_Adyacente = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(341, 175);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(26, 15);
            this.Label3.TabIndex = 21;
            this.Label3.Text = "Cm";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(177, 307);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(26, 15);
            this.Label1.TabIndex = 20;
            this.Label1.Text = "Cm";
            // 
            // TextBox_Hipotenusa
            // 
            this.TextBox_Hipotenusa.Location = new System.Drawing.Point(12, 114);
            this.TextBox_Hipotenusa.Name = "TextBox_Hipotenusa";
            this.TextBox_Hipotenusa.Size = new System.Drawing.Size(52, 20);
            this.TextBox_Hipotenusa.TabIndex = 19;
            // 
            // Button_Run
            // 
            this.Button_Run.ForeColor = System.Drawing.Color.Black;
            this.Button_Run.Location = new System.Drawing.Point(157, 357);
            this.Button_Run.Name = "Button_Run";
            this.Button_Run.Size = new System.Drawing.Size(75, 23);
            this.Button_Run.TabIndex = 18;
            this.Button_Run.Text = "Run";
            this.Button_Run.UseVisualStyleBackColor = true;
            this.Button_Run.Click += new System.EventHandler(this.Button_Run_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(12, 79);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(266, 219);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 17;
            this.PictureBox1.TabStop = false;
            // 
            // TextBox_Opuesto
            // 
            this.TextBox_Opuesto.Location = new System.Drawing.Point(284, 175);
            this.TextBox_Opuesto.Name = "TextBox_Opuesto";
            this.TextBox_Opuesto.Size = new System.Drawing.Size(52, 20);
            this.TextBox_Opuesto.TabIndex = 16;
            // 
            // TextBox_Adyacente
            // 
            this.TextBox_Adyacente.Location = new System.Drawing.Point(119, 304);
            this.TextBox_Adyacente.Name = "TextBox_Adyacente";
            this.TextBox_Adyacente.Size = new System.Drawing.Size(52, 20);
            this.TextBox_Adyacente.TabIndex = 15;
            // 
            // RadioButton_Hipotenusa
            // 
            this.RadioButton_Hipotenusa.AutoSize = true;
            this.RadioButton_Hipotenusa.ForeColor = System.Drawing.Color.Black;
            this.RadioButton_Hipotenusa.Location = new System.Drawing.Point(133, 19);
            this.RadioButton_Hipotenusa.Name = "RadioButton_Hipotenusa";
            this.RadioButton_Hipotenusa.Size = new System.Drawing.Size(88, 19);
            this.RadioButton_Hipotenusa.TabIndex = 14;
            this.RadioButton_Hipotenusa.TabStop = true;
            this.RadioButton_Hipotenusa.Text = "Hipotenusa";
            this.RadioButton_Hipotenusa.UseVisualStyleBackColor = true;
            this.RadioButton_Hipotenusa.CheckedChanged += new System.EventHandler(this.RadioButton_Hipotenusa_CheckedChanged);
            // 
            // RadioButton_Opuesto
            // 
            this.RadioButton_Opuesto.AutoSize = true;
            this.RadioButton_Opuesto.ForeColor = System.Drawing.Color.Black;
            this.RadioButton_Opuesto.Location = new System.Drawing.Point(265, 19);
            this.RadioButton_Opuesto.Name = "RadioButton_Opuesto";
            this.RadioButton_Opuesto.Size = new System.Drawing.Size(71, 19);
            this.RadioButton_Opuesto.TabIndex = 13;
            this.RadioButton_Opuesto.TabStop = true;
            this.RadioButton_Opuesto.Text = "Opuesto";
            this.RadioButton_Opuesto.UseVisualStyleBackColor = true;
            this.RadioButton_Opuesto.CheckedChanged += new System.EventHandler(this.RadioButton_Opuesto_CheckedChanged);
            // 
            // RadioButton_Adyacente
            // 
            this.RadioButton_Adyacente.AutoSize = true;
            this.RadioButton_Adyacente.ForeColor = System.Drawing.Color.Black;
            this.RadioButton_Adyacente.Location = new System.Drawing.Point(12, 19);
            this.RadioButton_Adyacente.Name = "RadioButton_Adyacente";
            this.RadioButton_Adyacente.Size = new System.Drawing.Size(81, 19);
            this.RadioButton_Adyacente.TabIndex = 12;
            this.RadioButton_Adyacente.TabStop = true;
            this.RadioButton_Adyacente.Text = "Adyacente";
            this.RadioButton_Adyacente.UseVisualStyleBackColor = true;
            this.RadioButton_Adyacente.CheckedChanged += new System.EventHandler(this.RadioButton_Adyacente_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Cm";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(379, 398);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.TextBox_Hipotenusa);
            this.Controls.Add(this.Button_Run);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.TextBox_Opuesto);
            this.Controls.Add(this.TextBox_Adyacente);
            this.Controls.Add(this.RadioButton_Hipotenusa);
            this.Controls.Add(this.RadioButton_Opuesto);
            this.Controls.Add(this.RadioButton_Adyacente);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Función trigonométrica";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox TextBox_Hipotenusa;
        internal System.Windows.Forms.Button Button_Run;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.TextBox TextBox_Opuesto;
        internal System.Windows.Forms.TextBox TextBox_Adyacente;
        internal System.Windows.Forms.RadioButton RadioButton_Hipotenusa;
        internal System.Windows.Forms.RadioButton RadioButton_Opuesto;
        internal System.Windows.Forms.RadioButton RadioButton_Adyacente;
        internal System.Windows.Forms.Label label2;
    }
}

