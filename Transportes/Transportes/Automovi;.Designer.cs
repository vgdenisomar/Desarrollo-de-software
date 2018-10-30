namespace Transportes
{
    partial class Automovi_
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdpick = new System.Windows.Forms.RadioButton();
            this.rdturismo = new System.Windows.Forms.RadioButton();
            this.rdcamion = new System.Windows.Forms.RadioButton();
            this.rdconver = new System.Windows.Forms.RadioButton();
            this.btnregresar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdconver);
            this.groupBox1.Controls.Add(this.rdcamion);
            this.groupBox1.Controls.Add(this.rdturismo);
            this.groupBox1.Controls.Add(this.rdpick);
            this.groupBox1.Location = new System.Drawing.Point(151, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de carro";
            // 
            // rdpick
            // 
            this.rdpick.AutoSize = true;
            this.rdpick.Location = new System.Drawing.Point(10, 24);
            this.rdpick.Name = "rdpick";
            this.rdpick.Size = new System.Drawing.Size(82, 21);
            this.rdpick.TabIndex = 0;
            this.rdpick.TabStop = true;
            this.rdpick.Text = "PICK UP";
            this.rdpick.UseVisualStyleBackColor = true;
            // 
            // rdturismo
            // 
            this.rdturismo.AutoSize = true;
            this.rdturismo.Location = new System.Drawing.Point(8, 58);
            this.rdturismo.Name = "rdturismo";
            this.rdturismo.Size = new System.Drawing.Size(80, 21);
            this.rdturismo.TabIndex = 1;
            this.rdturismo.TabStop = true;
            this.rdturismo.Text = "Turismo";
            this.rdturismo.UseVisualStyleBackColor = true;
            // 
            // rdcamion
            // 
            this.rdcamion.AutoSize = true;
            this.rdcamion.Location = new System.Drawing.Point(114, 58);
            this.rdcamion.Name = "rdcamion";
            this.rdcamion.Size = new System.Drawing.Size(96, 21);
            this.rdcamion.TabIndex = 2;
            this.rdcamion.TabStop = true;
            this.rdcamion.Text = "Camioneta";
            this.rdcamion.UseVisualStyleBackColor = true;
            // 
            // rdconver
            // 
            this.rdconver.AutoSize = true;
            this.rdconver.Location = new System.Drawing.Point(112, 21);
            this.rdconver.Name = "rdconver";
            this.rdconver.Size = new System.Drawing.Size(100, 21);
            this.rdconver.TabIndex = 3;
            this.rdconver.TabStop = true;
            this.rdconver.Text = "Convertible";
            this.rdconver.UseVisualStyleBackColor = true;
            // 
            // btnregresar
            // 
            this.btnregresar.Location = new System.Drawing.Point(207, 155);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(121, 37);
            this.btnregresar.TabIndex = 20;
            this.btnregresar.Text = "Regresar";
            this.btnregresar.UseVisualStyleBackColor = true;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // Automovi_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 222);
            this.Controls.Add(this.btnregresar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Automovi_";
            this.Text = "Automovi_";
            this.Load += new System.EventHandler(this.Automovi__Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdconver;
        private System.Windows.Forms.RadioButton rdcamion;
        private System.Windows.Forms.RadioButton rdturismo;
        private System.Windows.Forms.RadioButton rdpick;
        private System.Windows.Forms.Button btnregresar;
    }
}