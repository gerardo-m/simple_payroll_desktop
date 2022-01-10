
namespace simple_payroll_desktop.forms.controls
{
    partial class AdditionalRowForPaySlip
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Mé
        /// necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.conceptLabel = new System.Windows.Forms.Label();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.amountTextBox);
            this.panel1.Controls.Add(this.conceptLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 38);
            this.panel1.TabIndex = 0;
            // 
            // conceptLabel
            // 
            this.conceptLabel.AutoSize = true;
            this.conceptLabel.Location = new System.Drawing.Point(3, 11);
            this.conceptLabel.Name = "conceptLabel";
            this.conceptLabel.Size = new System.Drawing.Size(35, 13);
            this.conceptLabel.TabIndex = 0;
            this.conceptLabel.Text = "label1";
            // 
            // amountTextBox
            // 
            this.amountTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.amountTextBox.Location = new System.Drawing.Point(383, 8);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(100, 20);
            this.amountTextBox.TabIndex = 1;
            // 
            // AdditionalRowForPaySlip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "AdditionalRowForPaySlip";
            this.Size = new System.Drawing.Size(486, 38);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Label conceptLabel;
    }
}
