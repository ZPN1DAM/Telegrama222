namespace Telegrama222
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
            this.txtTelegrama = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.rdOren = new System.Windows.Forms.RadioButton();
            this.rdUrge = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(302, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 65);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTelegrama
            // 
            this.txtTelegrama.Location = new System.Drawing.Point(77, 56);
            this.txtTelegrama.Multiline = true;
            this.txtTelegrama.Name = "txtTelegrama";
            this.txtTelegrama.Size = new System.Drawing.Size(346, 172);
            this.txtTelegrama.TabIndex = 2;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(139, 338);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 22);
            this.txtPrecio.TabIndex = 3;
            this.txtPrecio.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // rdOren
            // 
            this.rdOren.AutoSize = true;
            this.rdOren.Location = new System.Drawing.Point(65, 289);
            this.rdOren.Name = "rdOren";
            this.rdOren.Size = new System.Drawing.Size(83, 20);
            this.rdOren.TabIndex = 4;
            this.rdOren.TabStop = true;
            this.rdOren.Text = "Ordinario";
            this.rdOren.UseVisualStyleBackColor = true;
            // 
            // rdUrge
            // 
            this.rdUrge.AutoSize = true;
            this.rdUrge.Location = new System.Drawing.Point(174, 289);
            this.rdUrge.Name = "rdUrge";
            this.rdUrge.Size = new System.Drawing.Size(76, 20);
            this.rdUrge.TabIndex = 5;
            this.rdUrge.TabStop = true;
            this.rdUrge.Text = "Urgente";
            this.rdUrge.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 441);
            this.Controls.Add(this.rdUrge);
            this.Controls.Add(this.rdOren);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtTelegrama);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTelegrama;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.RadioButton rdOren;
        private System.Windows.Forms.RadioButton rdUrge;
    }
}

