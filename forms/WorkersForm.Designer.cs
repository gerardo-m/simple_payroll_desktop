
namespace simple_payroll_desktop.forms
{
    partial class WorkersForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.lastName2TextBox = new System.Windows.Forms.TextBox();
            this.ciTextBox = new System.Windows.Forms.TextBox();
            this.payRateTypeComboBox = new System.Windows.Forms.ComboBox();
            this.payRateSpinner = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.workersGrid = new System.Windows.Forms.DataGridView();
            this.deleteWorkerButton = new System.Windows.Forms.Button();
            this.saveWorkerButton = new System.Windows.Forms.Button();
            this.newWorkerButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.payScheduleComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.denominationComboBox = new System.Windows.Forms.ComboBox();
            this.manageDenominationsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.payRateSpinner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersGrid)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(118, 56);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(220, 20);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(118, 109);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(220, 20);
            this.lastNameTextBox.TabIndex = 2;
            // 
            // lastName2TextBox
            // 
            this.lastName2TextBox.Location = new System.Drawing.Point(118, 165);
            this.lastName2TextBox.Name = "lastName2TextBox";
            this.lastName2TextBox.Size = new System.Drawing.Size(220, 20);
            this.lastName2TextBox.TabIndex = 3;
            // 
            // ciTextBox
            // 
            this.ciTextBox.Location = new System.Drawing.Point(118, 219);
            this.ciTextBox.Name = "ciTextBox";
            this.ciTextBox.Size = new System.Drawing.Size(220, 20);
            this.ciTextBox.TabIndex = 4;
            // 
            // payRateTypeComboBox
            // 
            this.payRateTypeComboBox.FormattingEnabled = true;
            this.payRateTypeComboBox.Location = new System.Drawing.Point(605, 56);
            this.payRateTypeComboBox.Name = "payRateTypeComboBox";
            this.payRateTypeComboBox.Size = new System.Drawing.Size(220, 21);
            this.payRateTypeComboBox.TabIndex = 5;
            // 
            // payRateSpinner
            // 
            this.payRateSpinner.Location = new System.Drawing.Point(605, 166);
            this.payRateSpinner.Name = "payRateSpinner";
            this.payRateSpinner.Size = new System.Drawing.Size(220, 20);
            this.payRateSpinner.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Primer apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Segundo apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "CI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(467, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tipo de tarija";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(467, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tarifa";
            // 
            // workersGrid
            // 
            this.workersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workersGrid.Location = new System.Drawing.Point(16, 350);
            this.workersGrid.Name = "workersGrid";
            this.workersGrid.ReadOnly = true;
            this.workersGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.workersGrid.Size = new System.Drawing.Size(809, 210);
            this.workersGrid.TabIndex = 12;
            // 
            // deleteWorkerButton
            // 
            this.deleteWorkerButton.Location = new System.Drawing.Point(750, 310);
            this.deleteWorkerButton.Name = "deleteWorkerButton";
            this.deleteWorkerButton.Size = new System.Drawing.Size(75, 23);
            this.deleteWorkerButton.TabIndex = 13;
            this.deleteWorkerButton.Text = "Eliminar";
            this.deleteWorkerButton.UseVisualStyleBackColor = true;
            // 
            // saveWorkerButton
            // 
            this.saveWorkerButton.Location = new System.Drawing.Point(669, 310);
            this.saveWorkerButton.Name = "saveWorkerButton";
            this.saveWorkerButton.Size = new System.Drawing.Size(75, 23);
            this.saveWorkerButton.TabIndex = 14;
            this.saveWorkerButton.Text = "Guardar";
            this.saveWorkerButton.UseVisualStyleBackColor = true;
            this.saveWorkerButton.Click += new System.EventHandler(this.saveWorkerButton_Click);
            // 
            // newWorkerButton
            // 
            this.newWorkerButton.Location = new System.Drawing.Point(588, 310);
            this.newWorkerButton.Name = "newWorkerButton";
            this.newWorkerButton.Size = new System.Drawing.Size(75, 23);
            this.newWorkerButton.TabIndex = 15;
            this.newWorkerButton.Text = "Nuevo";
            this.newWorkerButton.UseVisualStyleBackColor = true;
            this.newWorkerButton.Click += new System.EventHandler(this.newWorkerButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 572);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(853, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(88, 17);
            this.toolStripStatusLabel1.Text = "Status Message";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(467, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Calendario de pagos";
            // 
            // payScheduleComboBox
            // 
            this.payScheduleComboBox.FormattingEnabled = true;
            this.payScheduleComboBox.Location = new System.Drawing.Point(605, 109);
            this.payScheduleComboBox.Name = "payScheduleComboBox";
            this.payScheduleComboBox.Size = new System.Drawing.Size(220, 21);
            this.payScheduleComboBox.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Denominación";
            // 
            // denominationComboBox
            // 
            this.denominationComboBox.FormattingEnabled = true;
            this.denominationComboBox.Location = new System.Drawing.Point(118, 268);
            this.denominationComboBox.Name = "denominationComboBox";
            this.denominationComboBox.Size = new System.Drawing.Size(180, 21);
            this.denominationComboBox.TabIndex = 20;
            // 
            // manageDenominationsButton
            // 
            this.manageDenominationsButton.Location = new System.Drawing.Point(305, 266);
            this.manageDenominationsButton.Name = "manageDenominationsButton";
            this.manageDenominationsButton.Size = new System.Drawing.Size(33, 23);
            this.manageDenominationsButton.TabIndex = 21;
            this.manageDenominationsButton.Text = "...";
            this.manageDenominationsButton.UseVisualStyleBackColor = true;
            this.manageDenominationsButton.Click += new System.EventHandler(this.manageDenominationsButton_Click);
            // 
            // WorkersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 594);
            this.Controls.Add(this.manageDenominationsButton);
            this.Controls.Add(this.denominationComboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.payScheduleComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.newWorkerButton);
            this.Controls.Add(this.saveWorkerButton);
            this.Controls.Add(this.deleteWorkerButton);
            this.Controls.Add(this.workersGrid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.payRateSpinner);
            this.Controls.Add(this.payRateTypeComboBox);
            this.Controls.Add(this.ciTextBox);
            this.Controls.Add(this.lastName2TextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "WorkersForm";
            this.Text = "Gestionar trabajadores";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManageWorkersForm_FormClosed);
            this.Load += new System.EventHandler(this.WorkersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.payRateSpinner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersGrid)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox lastName2TextBox;
        private System.Windows.Forms.TextBox ciTextBox;
        private System.Windows.Forms.ComboBox payRateTypeComboBox;
        private System.Windows.Forms.NumericUpDown payRateSpinner;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView workersGrid;
        private System.Windows.Forms.Button deleteWorkerButton;
        private System.Windows.Forms.Button saveWorkerButton;
        private System.Windows.Forms.Button newWorkerButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox payScheduleComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox denominationComboBox;
        private System.Windows.Forms.Button manageDenominationsButton;
    }
}