
namespace simple_payroll_desktop
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
            this.trackWorkButton = new System.Windows.Forms.Button();
            this.generatePayrollButton = new System.Windows.Forms.Button();
            this.manageWorkersButton = new System.Windows.Forms.Button();
            this.managePaySchedulesButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // trackWorkButton
            // 
            this.trackWorkButton.Location = new System.Drawing.Point(23, 45);
            this.trackWorkButton.Name = "trackWorkButton";
            this.trackWorkButton.Size = new System.Drawing.Size(205, 188);
            this.trackWorkButton.TabIndex = 0;
            this.trackWorkButton.Text = "Registrar trabajo";
            this.trackWorkButton.UseVisualStyleBackColor = true;
            this.trackWorkButton.Click += new System.EventHandler(this.trackWorkButton_Click);
            // 
            // generatePayrollButton
            // 
            this.generatePayrollButton.Location = new System.Drawing.Point(268, 45);
            this.generatePayrollButton.Name = "generatePayrollButton";
            this.generatePayrollButton.Size = new System.Drawing.Size(205, 188);
            this.generatePayrollButton.TabIndex = 1;
            this.generatePayrollButton.Text = "Generar planilla";
            this.generatePayrollButton.UseVisualStyleBackColor = true;
            this.generatePayrollButton.Click += new System.EventHandler(this.generatePayrollButton_Click);
            // 
            // manageWorkersButton
            // 
            this.manageWorkersButton.Location = new System.Drawing.Point(23, 274);
            this.manageWorkersButton.Name = "manageWorkersButton";
            this.manageWorkersButton.Size = new System.Drawing.Size(205, 188);
            this.manageWorkersButton.TabIndex = 2;
            this.manageWorkersButton.Text = "Gestionar trabajadores";
            this.manageWorkersButton.UseVisualStyleBackColor = true;
            this.manageWorkersButton.Click += new System.EventHandler(this.manageWorkersButton_Click);
            // 
            // managePaySchedulesButton
            // 
            this.managePaySchedulesButton.Location = new System.Drawing.Point(268, 274);
            this.managePaySchedulesButton.Name = "managePaySchedulesButton";
            this.managePaySchedulesButton.Size = new System.Drawing.Size(205, 188);
            this.managePaySchedulesButton.TabIndex = 3;
            this.managePaySchedulesButton.Text = "Gestionar calendario de pagos";
            this.managePaySchedulesButton.UseVisualStyleBackColor = true;
            this.managePaySchedulesButton.Click += new System.EventHandler(this.managePaySchedulesButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(387, 490);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(86, 24);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "SALIR";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 541);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.managePaySchedulesButton);
            this.Controls.Add(this.manageWorkersButton);
            this.Controls.Add(this.generatePayrollButton);
            this.Controls.Add(this.trackWorkButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Simple Payroll Desktop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button trackWorkButton;
        private System.Windows.Forms.Button generatePayrollButton;
        private System.Windows.Forms.Button manageWorkersButton;
        private System.Windows.Forms.Button managePaySchedulesButton;
        private System.Windows.Forms.Button exitButton;
    }
}

