namespace Transportes
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPasa = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtKM = new System.Windows.Forms.TextBox();
            this.txtVel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbtrans = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "No. Pasasajeros";
            // 
            // txtPasa
            // 
            this.txtPasa.Location = new System.Drawing.Point(141, 12);
            this.txtPasa.Name = "txtPasa";
            this.txtPasa.Size = new System.Drawing.Size(49, 22);
            this.txtPasa.TabIndex = 1;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(141, 57);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(49, 22);
            this.txtMarca.TabIndex = 3;
            // 
            // txtKM
            // 
            this.txtKM.Location = new System.Drawing.Point(372, 15);
            this.txtKM.Name = "txtKM";
            this.txtKM.Size = new System.Drawing.Size(49, 22);
            this.txtKM.TabIndex = 4;
            // 
            // txtVel
            // 
            this.txtVel.Location = new System.Drawing.Point(372, 62);
            this.txtVel.Name = "txtVel";
            this.txtVel.Size = new System.Drawing.Size(49, 22);
            this.txtVel.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "KM recorridos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Velocidad Maxima";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marca";
            // 
            // cmbtrans
            // 
            this.cmbtrans.FormattingEnabled = true;
            this.cmbtrans.Items.AddRange(new object[] {
            "Terrestre",
            "Marino",
            "Aereo"});
            this.cmbtrans.Location = new System.Drawing.Point(50, 111);
            this.cmbtrans.Name = "cmbtrans";
            this.cmbtrans.Size = new System.Drawing.Size(140, 24);
            this.cmbtrans.TabIndex = 8;
            this.cmbtrans.Text = "Tipo de tranporte";
            this.cmbtrans.SelectedIndexChanged += new System.EventHandler(this.cmbtrans_SelectedIndexChanged);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(259, 104);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(121, 37);
            this.btnRegistrar.TabIndex = 9;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 161);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.cmbtrans);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtVel);
            this.Controls.Add(this.txtKM);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPasa);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPasa;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtKM;
        private System.Windows.Forms.TextBox txtVel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbtrans;
        private System.Windows.Forms.Button btnRegistrar;
    }
}

