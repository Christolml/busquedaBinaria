namespace busquedaBinaria
{
    partial class Form1
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
            this.txtLimite = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimite = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnTamaño = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTamaño = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLimite
            // 
            this.txtLimite.Location = new System.Drawing.Point(154, 243);
            this.txtLimite.Name = "txtLimite";
            this.txtLimite.Size = new System.Drawing.Size(111, 38);
            this.txtLimite.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Limite:";
            // 
            // btnLimite
            // 
            this.btnLimite.Location = new System.Drawing.Point(130, 300);
            this.btnLimite.Name = "btnLimite";
            this.btnLimite.Size = new System.Drawing.Size(135, 45);
            this.btnLimite.TabIndex = 2;
            this.btnLimite.Text = "Limite";
            this.btnLimite.UseVisualStyleBackColor = true;
            this.btnLimite.Click += new System.EventHandler(this.btnLimite_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(154, 482);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(135, 45);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 64);
            this.label2.TabIndex = 4;
            this.label2.Text = "Número a \r\nbuscar:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(178, 425);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(111, 38);
            this.txtBuscar.TabIndex = 3;
            // 
            // btnTamaño
            // 
            this.btnTamaño.Location = new System.Drawing.Point(154, 160);
            this.btnTamaño.Name = "btnTamaño";
            this.btnTamaño.Size = new System.Drawing.Size(135, 45);
            this.btnTamaño.TabIndex = 8;
            this.btnTamaño.Text = "Tamaño";
            this.btnTamaño.UseVisualStyleBackColor = true;
            this.btnTamaño.Click += new System.EventHandler(this.btnTamaño_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 64);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tamaño del\r\n vector:";
            // 
            // txtTamaño
            // 
            this.txtTamaño.Location = new System.Drawing.Point(198, 103);
            this.txtTamaño.Name = "txtTamaño";
            this.txtTamaño.Size = new System.Drawing.Size(111, 38);
            this.txtTamaño.TabIndex = 6;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(352, 27);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(351, 401);
            this.txtResultado.TabIndex = 9;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(419, 467);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(135, 45);
            this.btnMostrar.TabIndex = 10;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 572);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnTamaño);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTamaño);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnLimite);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLimite);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLimite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimite;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnTamaño;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTamaño;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnMostrar;
    }
}

