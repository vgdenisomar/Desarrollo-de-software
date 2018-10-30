namespace Transportes
{
    partial class Aereo
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
            this.btnregresar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtaltura = new System.Windows.Forms.TextBox();
            this.txtelices = new System.Windows.Forms.TextBox();
            this.txtalas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtllantas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnregresar
            // 
            this.btnregresar.Location = new System.Drawing.Point(178, 100);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(121, 37);
            this.btnregresar.TabIndex = 19;
            this.btnregresar.Text = "Regresar";
            this.btnregresar.UseVisualStyleBackColor = true;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(249, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Altura Maxima";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "No. elices";
            // 
            // txtaltura
            // 
            this.txtaltura.Location = new System.Drawing.Point(394, 60);
            this.txtaltura.Name = "txtaltura";
            this.txtaltura.Size = new System.Drawing.Size(49, 22);
            this.txtaltura.TabIndex = 15;
            // 
            // txtelices
            // 
            this.txtelices.Location = new System.Drawing.Point(394, 13);
            this.txtelices.Name = "txtelices";
            this.txtelices.Size = new System.Drawing.Size(49, 22);
            this.txtelices.TabIndex = 14;
            // 
            // txtalas
            // 
            this.txtalas.Location = new System.Drawing.Point(163, 10);
            this.txtalas.Name = "txtalas";
            this.txtalas.Size = new System.Drawing.Size(49, 22);
            this.txtalas.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "No. Alas";
            // 
            // txtllantas
            // 
            this.txtllantas.Location = new System.Drawing.Point(163, 55);
            this.txtllantas.Name = "txtllantas";
            this.txtllantas.Size = new System.Drawing.Size(49, 22);
            this.txtllantas.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "No. Llantas";
            // 
            // Aereo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 149);
            this.Controls.Add(this.btnregresar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtaltura);
            this.Controls.Add(this.txtelices);
            this.Controls.Add(this.txtllantas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtalas);
            this.Controls.Add(this.label1);
            this.Name = "Aereo";
            this.Text = "Aereo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnregresar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtaltura;
        private System.Windows.Forms.TextBox txtelices;
        private System.Windows.Forms.TextBox txtalas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtllantas;
        private System.Windows.Forms.Label label2;
    }
}