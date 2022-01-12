﻿
namespace simple_payroll_desktop.forms
{
    partial class PaySchedulesForm
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
            this.newPayScheduleButton = new System.Windows.Forms.Button();
            this.savePayScheduleButton = new System.Windows.Forms.Button();
            this.deletePayScheduleButton = new System.Windows.Forms.Button();
            this.currentPayPeriodGroupBox = new System.Windows.Forms.GroupBox();
            this.currentPayPeriodPayDayLabel = new System.Windows.Forms.Label();
            this.currentPayPeriodEndLabel = new System.Windows.Forms.Label();
            this.currentPayPeriodStartLabel = new System.Windows.Forms.Label();
            this.paySchedulesGrid = new System.Windows.Forms.DataGridView();
            this.payRateTypesComboBox = new System.Windows.Forms.ComboBox();
            this.payRateTypeLabel = new System.Windows.Forms.Label();
            this.basePeriodEndPicker = new System.Windows.Forms.DateTimePicker();
            this.basePayDayPicker = new System.Windows.Forms.DateTimePicker();
            this.basePeriodStartPicker = new System.Windows.Forms.DateTimePicker();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.basePayDayLabel = new System.Windows.Forms.Label();
            this.basePeriodEndLabel = new System.Windows.Forms.Label();
            this.basePeriodStartLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.trackingTypeLabel = new System.Windows.Forms.Label();
            this.trackingTypesComboBox = new System.Windows.Forms.ComboBox();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.currentPayPeriodGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paySchedulesGrid)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // newPayScheduleButton
            // 
            this.newPayScheduleButton.Location = new System.Drawing.Point(610, 350);
            this.newPayScheduleButton.Name = "newPayScheduleButton";
            this.newPayScheduleButton.Size = new System.Drawing.Size(75, 23);
            this.newPayScheduleButton.TabIndex = 33;
            this.newPayScheduleButton.Text = "Nuevo";
            this.newPayScheduleButton.UseVisualStyleBackColor = true;
            this.newPayScheduleButton.Click += new System.EventHandler(this.newPayScheduleButton_Click);
            // 
            // savePayScheduleButton
            // 
            this.savePayScheduleButton.Location = new System.Drawing.Point(691, 350);
            this.savePayScheduleButton.Name = "savePayScheduleButton";
            this.savePayScheduleButton.Size = new System.Drawing.Size(75, 23);
            this.savePayScheduleButton.TabIndex = 32;
            this.savePayScheduleButton.Text = "Guardar";
            this.savePayScheduleButton.UseVisualStyleBackColor = true;
            this.savePayScheduleButton.Click += new System.EventHandler(this.savePayScheduleButton_Click);
            // 
            // deletePayScheduleButton
            // 
            this.deletePayScheduleButton.Location = new System.Drawing.Point(772, 350);
            this.deletePayScheduleButton.Name = "deletePayScheduleButton";
            this.deletePayScheduleButton.Size = new System.Drawing.Size(75, 23);
            this.deletePayScheduleButton.TabIndex = 31;
            this.deletePayScheduleButton.Text = "Eliminar";
            this.deletePayScheduleButton.UseVisualStyleBackColor = true;
            // 
            // currentPayPeriodGroupBox
            // 
            this.currentPayPeriodGroupBox.Controls.Add(this.currentPayPeriodPayDayLabel);
            this.currentPayPeriodGroupBox.Controls.Add(this.currentPayPeriodEndLabel);
            this.currentPayPeriodGroupBox.Controls.Add(this.currentPayPeriodStartLabel);
            this.currentPayPeriodGroupBox.Location = new System.Drawing.Point(495, 54);
            this.currentPayPeriodGroupBox.Name = "currentPayPeriodGroupBox";
            this.currentPayPeriodGroupBox.Size = new System.Drawing.Size(353, 140);
            this.currentPayPeriodGroupBox.TabIndex = 30;
            this.currentPayPeriodGroupBox.TabStop = false;
            this.currentPayPeriodGroupBox.Text = "Período de pago actual";
            // 
            // currentPayPeriodPayDayLabel
            // 
            this.currentPayPeriodPayDayLabel.AutoSize = true;
            this.currentPayPeriodPayDayLabel.Location = new System.Drawing.Point(7, 102);
            this.currentPayPeriodPayDayLabel.Name = "currentPayPeriodPayDayLabel";
            this.currentPayPeriodPayDayLabel.Size = new System.Drawing.Size(82, 13);
            this.currentPayPeriodPayDayLabel.TabIndex = 2;
            this.currentPayPeriodPayDayLabel.Text = "Fecha de pago:";
            // 
            // currentPayPeriodEndLabel
            // 
            this.currentPayPeriodEndLabel.AutoSize = true;
            this.currentPayPeriodEndLabel.Location = new System.Drawing.Point(7, 69);
            this.currentPayPeriodEndLabel.Name = "currentPayPeriodEndLabel";
            this.currentPayPeriodEndLabel.Size = new System.Drawing.Size(32, 13);
            this.currentPayPeriodEndLabel.TabIndex = 1;
            this.currentPayPeriodEndLabel.Text = "Final:";
            // 
            // currentPayPeriodStartLabel
            // 
            this.currentPayPeriodStartLabel.AutoSize = true;
            this.currentPayPeriodStartLabel.Location = new System.Drawing.Point(7, 40);
            this.currentPayPeriodStartLabel.Name = "currentPayPeriodStartLabel";
            this.currentPayPeriodStartLabel.Size = new System.Drawing.Size(35, 13);
            this.currentPayPeriodStartLabel.TabIndex = 0;
            this.currentPayPeriodStartLabel.Text = "Inicio:";
            // 
            // paySchedulesGrid
            // 
            this.paySchedulesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.paySchedulesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paySchedulesGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.paySchedulesGrid.Location = new System.Drawing.Point(12, 396);
            this.paySchedulesGrid.Name = "paySchedulesGrid";
            this.paySchedulesGrid.RowTemplate.ReadOnly = true;
            this.paySchedulesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.paySchedulesGrid.Size = new System.Drawing.Size(836, 150);
            this.paySchedulesGrid.TabIndex = 29;
            this.paySchedulesGrid.SelectionChanged += new System.EventHandler(this.paySchedulesGrid_SelectionChanged);
            // 
            // payRateTypesComboBox
            // 
            this.payRateTypesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.payRateTypesComboBox.FormattingEnabled = true;
            this.payRateTypesComboBox.Location = new System.Drawing.Point(213, 271);
            this.payRateTypesComboBox.Name = "payRateTypesComboBox";
            this.payRateTypesComboBox.Size = new System.Drawing.Size(200, 21);
            this.payRateTypesComboBox.TabIndex = 28;
            this.payRateTypesComboBox.SelectedIndexChanged += new System.EventHandler(this.payRateTypesComboBox_SelectedIndexChanged);
            // 
            // payRateTypeLabel
            // 
            this.payRateTypeLabel.AutoSize = true;
            this.payRateTypeLabel.Location = new System.Drawing.Point(15, 274);
            this.payRateTypeLabel.Name = "payRateTypeLabel";
            this.payRateTypeLabel.Size = new System.Drawing.Size(69, 13);
            this.payRateTypeLabel.TabIndex = 27;
            this.payRateTypeLabel.Text = "Tipo de tarifa";
            // 
            // basePeriodEndPicker
            // 
            this.basePeriodEndPicker.Location = new System.Drawing.Point(213, 174);
            this.basePeriodEndPicker.Name = "basePeriodEndPicker";
            this.basePeriodEndPicker.Size = new System.Drawing.Size(200, 20);
            this.basePeriodEndPicker.TabIndex = 26;
            // 
            // basePayDayPicker
            // 
            this.basePayDayPicker.Location = new System.Drawing.Point(213, 211);
            this.basePayDayPicker.Name = "basePayDayPicker";
            this.basePayDayPicker.Size = new System.Drawing.Size(200, 20);
            this.basePayDayPicker.TabIndex = 25;
            // 
            // basePeriodStartPicker
            // 
            this.basePeriodStartPicker.Location = new System.Drawing.Point(213, 135);
            this.basePeriodStartPicker.Name = "basePeriodStartPicker";
            this.basePeriodStartPicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.basePeriodStartPicker.Size = new System.Drawing.Size(200, 20);
            this.basePeriodStartPicker.TabIndex = 24;
            this.basePeriodStartPicker.Value = new System.DateTime(2022, 1, 10, 0, 0, 0, 0);
            // 
            // typeComboBox
            // 
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(213, 87);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(200, 21);
            this.typeComboBox.TabIndex = 23;
            this.typeComboBox.SelectedIndexChanged += new System.EventHandler(this.typeComboBox_SelectedIndexChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(213, 54);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.nameTextBox.TabIndex = 22;
            // 
            // basePayDayLabel
            // 
            this.basePayDayLabel.AutoSize = true;
            this.basePayDayLabel.Location = new System.Drawing.Point(15, 217);
            this.basePayDayLabel.Name = "basePayDayLabel";
            this.basePayDayLabel.Size = new System.Drawing.Size(105, 13);
            this.basePayDayLabel.TabIndex = 21;
            this.basePayDayLabel.Text = "Fecha base de pago";
            // 
            // basePeriodEndLabel
            // 
            this.basePeriodEndLabel.AutoSize = true;
            this.basePeriodEndLabel.Location = new System.Drawing.Point(15, 180);
            this.basePeriodEndLabel.Name = "basePeriodEndLabel";
            this.basePeriodEndLabel.Size = new System.Drawing.Size(141, 13);
            this.basePeriodEndLabel.TabIndex = 20;
            this.basePeriodEndLabel.Text = "Fecha base Final de periodo";
            // 
            // basePeriodStartLabel
            // 
            this.basePeriodStartLabel.AutoSize = true;
            this.basePeriodStartLabel.Location = new System.Drawing.Point(15, 141);
            this.basePeriodStartLabel.Name = "basePeriodStartLabel";
            this.basePeriodStartLabel.Size = new System.Drawing.Size(146, 13);
            this.basePeriodStartLabel.TabIndex = 19;
            this.basePeriodStartLabel.Text = "Fecha base Inicio de período";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(15, 57);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(44, 13);
            this.nameLabel.TabIndex = 18;
            this.nameLabel.Text = "Nombre";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(12, 90);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(28, 13);
            this.typeLabel.TabIndex = 17;
            this.typeLabel.Text = "Tipo";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 566);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(863, 22);
            this.statusStrip1.TabIndex = 34;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // trackingTypeLabel
            // 
            this.trackingTypeLabel.AutoSize = true;
            this.trackingTypeLabel.Location = new System.Drawing.Point(18, 315);
            this.trackingTypeLabel.Name = "trackingTypeLabel";
            this.trackingTypeLabel.Size = new System.Drawing.Size(102, 13);
            this.trackingTypeLabel.TabIndex = 35;
            this.trackingTypeLabel.Text = "Tipo de seguimiento";
            // 
            // trackingTypesComboBox
            // 
            this.trackingTypesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.trackingTypesComboBox.FormattingEnabled = true;
            this.trackingTypesComboBox.Location = new System.Drawing.Point(213, 312);
            this.trackingTypesComboBox.Name = "trackingTypesComboBox";
            this.trackingTypesComboBox.Size = new System.Drawing.Size(200, 21);
            this.trackingTypesComboBox.TabIndex = 36;
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // PaySchedulesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 588);
            this.Controls.Add(this.trackingTypesComboBox);
            this.Controls.Add(this.trackingTypeLabel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.newPayScheduleButton);
            this.Controls.Add(this.savePayScheduleButton);
            this.Controls.Add(this.deletePayScheduleButton);
            this.Controls.Add(this.currentPayPeriodGroupBox);
            this.Controls.Add(this.paySchedulesGrid);
            this.Controls.Add(this.payRateTypesComboBox);
            this.Controls.Add(this.payRateTypeLabel);
            this.Controls.Add(this.basePeriodEndPicker);
            this.Controls.Add(this.basePayDayPicker);
            this.Controls.Add(this.basePeriodStartPicker);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.basePayDayLabel);
            this.Controls.Add(this.basePeriodEndLabel);
            this.Controls.Add(this.basePeriodStartLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.typeLabel);
            this.Name = "PaySchedulesForm";
            this.Text = "ManagePaySchedulesForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManagePaySchedulesForm_FormClosed);
            this.Load += new System.EventHandler(this.PaySchedulesForm_Load);
            this.currentPayPeriodGroupBox.ResumeLayout(false);
            this.currentPayPeriodGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paySchedulesGrid)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newPayScheduleButton;
        private System.Windows.Forms.Button savePayScheduleButton;
        private System.Windows.Forms.Button deletePayScheduleButton;
        private System.Windows.Forms.GroupBox currentPayPeriodGroupBox;
        private System.Windows.Forms.Label currentPayPeriodPayDayLabel;
        private System.Windows.Forms.Label currentPayPeriodEndLabel;
        private System.Windows.Forms.Label currentPayPeriodStartLabel;
        private System.Windows.Forms.DataGridView paySchedulesGrid;
        private System.Windows.Forms.ComboBox payRateTypesComboBox;
        private System.Windows.Forms.Label payRateTypeLabel;
        private System.Windows.Forms.DateTimePicker basePeriodEndPicker;
        private System.Windows.Forms.DateTimePicker basePayDayPicker;
        private System.Windows.Forms.DateTimePicker basePeriodStartPicker;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label basePayDayLabel;
        private System.Windows.Forms.Label basePeriodEndLabel;
        private System.Windows.Forms.Label basePeriodStartLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label trackingTypeLabel;
        private System.Windows.Forms.ComboBox trackingTypesComboBox;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
    }
}