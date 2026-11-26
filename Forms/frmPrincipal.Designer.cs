namespace MundoAnimal.Forms
{
    partial class frmPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelCentral = new System.Windows.Forms.Panel();
            this.panelCentral.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCentral
            // 
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.BackColor = System.Drawing.Color.White;
            this.panelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentral.Size = new System.Drawing.Size(1280, 740);
            this.panelCentral.TabIndex = 0;
            // 
            // this
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 740);
            this.Text = "Mundo Animal – Clínica Veterinaria";
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "frmPrincipal";
            this.Controls.Add(this.panelCentral);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panelCentral.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelCentral;
    }
}
