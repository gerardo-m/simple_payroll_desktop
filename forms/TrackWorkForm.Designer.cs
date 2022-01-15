
namespace simple_payroll_desktop.forms
{
    partial class TrackWorkForm
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
            this.paySchedulesComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.previosPayPeriodButton = new System.Windows.Forms.Button();
            this.nextPayPeriodButton = new System.Windows.Forms.Button();
            this.selectedPeriodLabel = new System.Windows.Forms.Label();
            this.trackingBoxPanel = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.saveTrackingEntriesButton = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.workersComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecciona un calendario de pago";
            // 
            // paySchedulesComboBox
            // 
            this.paySchedulesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paySchedulesComboBox.FormattingEnabled = true;
            this.paySchedulesComboBox.Location = new System.Drawing.Point(386, 27);
            this.paySchedulesComboBox.Name = "paySchedulesComboBox";
            this.paySchedulesComboBox.Size = new System.Drawing.Size(409, 21);
            this.paySchedulesComboBox.TabIndex = 1;
            this.paySchedulesComboBox.SelectedIndexChanged += new System.EventHandler(this.paySchedulesComboBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.trackingBoxPanel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(23, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(772, 268);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Introduce los datos";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.previosPayPeriodButton);
            this.panel1.Controls.Add(this.nextPayPeriodButton);
            this.panel1.Controls.Add(this.selectedPeriodLabel);
            this.panel1.Location = new System.Drawing.Point(133, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 26);
            this.panel1.TabIndex = 7;
            // 
            // previosPayPeriodButton
            // 
            this.previosPayPeriodButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.previosPayPeriodButton.Location = new System.Drawing.Point(0, 0);
            this.previosPayPeriodButton.Name = "previosPayPeriodButton";
            this.previosPayPeriodButton.Size = new System.Drawing.Size(43, 26);
            this.previosPayPeriodButton.TabIndex = 5;
            this.previosPayPeriodButton.Text = "<<";
            this.previosPayPeriodButton.UseVisualStyleBackColor = true;
            this.previosPayPeriodButton.Click += new System.EventHandler(this.previosPayPeriodButton_Click);
            // 
            // nextPayPeriodButton
            // 
            this.nextPayPeriodButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.nextPayPeriodButton.Location = new System.Drawing.Point(234, 0);
            this.nextPayPeriodButton.Name = "nextPayPeriodButton";
            this.nextPayPeriodButton.Size = new System.Drawing.Size(40, 26);
            this.nextPayPeriodButton.TabIndex = 6;
            this.nextPayPeriodButton.Text = ">>";
            this.nextPayPeriodButton.UseVisualStyleBackColor = true;
            this.nextPayPeriodButton.Click += new System.EventHandler(this.nextPayPeriodButton_Click);
            // 
            // selectedPeriodLabel
            // 
            this.selectedPeriodLabel.AutoSize = true;
            this.selectedPeriodLabel.Location = new System.Drawing.Point(49, 11);
            this.selectedPeriodLabel.Name = "selectedPeriodLabel";
            this.selectedPeriodLabel.Size = new System.Drawing.Size(35, 13);
            this.selectedPeriodLabel.TabIndex = 4;
            this.selectedPeriodLabel.Text = "label2";
            // 
            // trackingBoxPanel
            // 
            this.trackingBoxPanel.AutoSize = true;
            this.trackingBoxPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.trackingBoxPanel.Location = new System.Drawing.Point(17, 106);
            this.trackingBoxPanel.Name = "trackingBoxPanel";
            this.trackingBoxPanel.Size = new System.Drawing.Size(6, 5);
            this.trackingBoxPanel.TabIndex = 3;
            this.trackingBoxPanel.TabStop = false;
            this.trackingBoxPanel.Text = "Trabajador";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Período";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 442);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(807, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(118, 17);
            this.statusLabel.Text = "toolStripStatusLabel1";
            // 
            // saveTrackingEntriesButton
            // 
            this.saveTrackingEntriesButton.Location = new System.Drawing.Point(720, 416);
            this.saveTrackingEntriesButton.Name = "saveTrackingEntriesButton";
            this.saveTrackingEntriesButton.Size = new System.Drawing.Size(75, 23);
            this.saveTrackingEntriesButton.TabIndex = 4;
            this.saveTrackingEntriesButton.Text = "Guardar";
            this.saveTrackingEntriesButton.UseVisualStyleBackColor = true;
            this.saveTrackingEntriesButton.Click += new System.EventHandler(this.saveTrackingEntriesButton_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(24, 71);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(61, 13);
            this.label19.TabIndex = 5;
            this.label19.Text = "Trabajador:";
            // 
            // workersComboBox
            // 
            this.workersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.workersComboBox.FormattingEnabled = true;
            this.workersComboBox.Location = new System.Drawing.Point(387, 68);
            this.workersComboBox.Name = "workersComboBox";
            this.workersComboBox.Size = new System.Drawing.Size(408, 21);
            this.workersComboBox.TabIndex = 6;
            this.workersComboBox.SelectedIndexChanged += new System.EventHandler(this.workersComboBox_SelectedIndexChanged);
            // 
            // TrackWorkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 464);
            this.Controls.Add(this.workersComboBox);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.saveTrackingEntriesButton);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.paySchedulesComboBox);
            this.Controls.Add(this.label1);
            this.Name = "TrackWorkForm";
            this.Text = "TrackWorkForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TrackWorkForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TrackWorkForm_FormClosed);
            this.Load += new System.EventHandler(this.TrackWorkForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox paySchedulesComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button saveTrackingEntriesButton;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox workersComboBox;
        private System.Windows.Forms.GroupBox trackingBoxPanel;
        private System.Windows.Forms.Button nextPayPeriodButton;
        private System.Windows.Forms.Button previosPayPeriodButton;
        private System.Windows.Forms.Label selectedPeriodLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
    }
}