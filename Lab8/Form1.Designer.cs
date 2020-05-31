namespace Lab8
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
            this.VentanaPrincipal = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.localnuevo = new System.Windows.Forms.Button();
            this.InfoLocal = new System.Windows.Forms.Button();
            this.localesexistentes = new System.Windows.Forms.Button();
            this.VentanaPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // VentanaPrincipal
            // 
            this.VentanaPrincipal.Controls.Add(this.localesexistentes);
            this.VentanaPrincipal.Controls.Add(this.InfoLocal);
            this.VentanaPrincipal.Controls.Add(this.localnuevo);
            this.VentanaPrincipal.Controls.Add(this.label1);
            this.VentanaPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VentanaPrincipal.Location = new System.Drawing.Point(0, 0);
            this.VentanaPrincipal.Name = "VentanaPrincipal";
            this.VentanaPrincipal.Size = new System.Drawing.Size(800, 450);
            this.VentanaPrincipal.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ventana Principal";
            // 
            // localnuevo
            // 
            this.localnuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localnuevo.Location = new System.Drawing.Point(71, 125);
            this.localnuevo.Name = "localnuevo";
            this.localnuevo.Size = new System.Drawing.Size(151, 65);
            this.localnuevo.TabIndex = 1;
            this.localnuevo.Text = "Agregar Local Nuevo";
            this.localnuevo.UseVisualStyleBackColor = true;
            this.localnuevo.Click += new System.EventHandler(this.localnuevo_Click);
            // 
            // InfoLocal
            // 
            this.InfoLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoLocal.Location = new System.Drawing.Point(263, 125);
            this.InfoLocal.Name = "InfoLocal";
            this.InfoLocal.Size = new System.Drawing.Size(151, 65);
            this.InfoLocal.TabIndex = 2;
            this.InfoLocal.Text = "Revisar Informacion de un local";
            this.InfoLocal.UseVisualStyleBackColor = true;
            this.InfoLocal.Click += new System.EventHandler(this.InfoLocal_Click);
            // 
            // localesexistentes
            // 
            this.localesexistentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localesexistentes.Location = new System.Drawing.Point(447, 125);
            this.localesexistentes.Name = "localesexistentes";
            this.localesexistentes.Size = new System.Drawing.Size(151, 65);
            this.localesexistentes.TabIndex = 3;
            this.localesexistentes.Text = "Ver locales existentes";
            this.localesexistentes.UseVisualStyleBackColor = true;
            this.localesexistentes.Click += new System.EventHandler(this.localesexistentes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VentanaPrincipal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.VentanaPrincipal.ResumeLayout(false);
            this.VentanaPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel VentanaPrincipal;
        private System.Windows.Forms.Button localesexistentes;
        private System.Windows.Forms.Button InfoLocal;
        private System.Windows.Forms.Button localnuevo;
        private System.Windows.Forms.Label label1;
    }
}