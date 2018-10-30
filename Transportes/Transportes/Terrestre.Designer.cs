namespace Transportes
{
    partial class Terrestre
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtpuertas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtllantas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdauto = new System.Windows.Forms.RadioButton();
            this.rdmanual = new System.Windows.Forms.RadioButton();
            this.cmbAuto = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnregresar
            // 
            this.btnregresar.Location = new System.Drawing.Point(186, 190);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(121, 37);
            this.btnregresar.TabIndex = 19;
            this.btnregresar.Text = "Regresar";
            this.btnregresar.UseVisualStyleBackColor = true;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "No. placas";
            // 
            // txtpuertas
            // 
            this.txtpuertas.Location = new System.Drawing.Point(399, 94);
            this.txtpuertas.Name = "txtpuertas";
            this.txtpuertas.Size = new System.Drawing.Size(49, 22);
            this.txtpuertas.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 12;
            // 
            // txtllantas
            // 
            this.txtllantas.Location = new System.Drawing.Point(168, 91);
            this.txtllantas.Name = "txtllantas";
            this.txtllantas.Size = new System.Drawing.Size(49, 22);
            this.txtllantas.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "No. de llantas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdauto);
            this.groupBox1.Controls.Add(this.rdmanual);
            this.groupBox1.Location = new System.Drawing.Point(80, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 59);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transmision";
            // 
            // rdauto
            // 
            this.rdauto.AutoSize = true;
            this.rdauto.Location = new System.Drawing.Point(152, 21);
            this.rdauto.Name = "rdauto";
            this.rdauto.Size = new System.Drawing.Size(99, 21);
            this.rdauto.TabIndex = 1;
            this.rdauto.TabStop = true;
            this.rdauto.Text = "Automatico";
            this.rdauto.UseVisualStyleBackColor = true;
            // 
            // rdmanual
            // 
            this.rdmanual.AutoSize = true;
            this.rdmanual.Location = new System.Drawing.Point(27, 21);
            this.rdmanual.Name = "rdmanual";
            this.rdmanual.Size = new System.Drawing.Size(75, 21);
            this.rdmanual.TabIndex = 0;
            this.rdmanual.TabStop = true;
            this.rdmanual.Text = "Manual";
            this.rdmanual.UseVisualStyleBackColor = true;
            this.rdmanual.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // cmbAuto
            // 
            this.cmbAuto.FormattingEnabled = true;
            this.cmbAuto.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cmbAuto.Location = new System.Drawing.Point(186, 32);
            this.cmbAuto.Name = "cmbAuto";
            this.cmbAuto.Size = new System.Drawing.Size(121, 24);
            this.cmbAuto.TabIndex = 20;
            this.cmbAuto.Text = "Automovil?";
            this.cmbAuto.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Terrestre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 252);
            this.Controls.Add(this.cmbAuto);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnregresar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtpuertas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtllantas);
            this.Controls.Add(this.label1);
            this.Name = "Terrestre";
            this.Text = "Terrestre";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnregresar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpuertas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtllantas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdmanual;
        private System.Windows.Forms.RadioButton rdauto;
        private System.Windows.Forms.ComboBox cmbAuto;
    }
}