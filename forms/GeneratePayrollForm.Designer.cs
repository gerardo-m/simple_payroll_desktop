
namespace simple_payroll_desktop.forms
{
    partial class GeneratePayrollForm
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
            this.workerComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.payScheduleComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.additionalTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.additionalAmountSpinner = new System.Windows.Forms.NumericUpDown();
            this.additionalsGridView = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.generatePaySlipButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.previosPayPeriodButton = new System.Windows.Forms.Button();
            this.nextPayPeriodButton = new System.Windows.Forms.Button();
            this.selectedPeriodLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.statusDataLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.trackedAmountDataLabel = new System.Windows.Forms.Label();
            this.payRateDataLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.trackedDetailsDataLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.balanceDueTextBox = new System.Windows.Forms.TextBox();
            this.totalAmountTextBox = new System.Windows.Forms.TextBox();
            this.additionalsAmountTextBox = new System.Windows.Forms.TextBox();
            this.trackedAmountTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.additionalAmountSpinner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.additionalsGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trabajador";
            // 
            // workerComboBox
            // 
            this.workerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.workerComboBox.FormattingEnabled = true;
            this.workerComboBox.Location = new System.Drawing.Point(179, 73);
            this.workerComboBox.Name = "workerComboBox";
            this.workerComboBox.Size = new System.Drawing.Size(343, 21);
            this.workerComboBox.TabIndex = 1;
            this.workerComboBox.SelectedIndexChanged += new System.EventHandler(this.workerComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Calendario de pagos";
            // 
            // payScheduleComboBox
            // 
            this.payScheduleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.payScheduleComboBox.FormattingEnabled = true;
            this.payScheduleComboBox.Location = new System.Drawing.Point(179, 35);
            this.payScheduleComboBox.Name = "payScheduleComboBox";
            this.payScheduleComboBox.Size = new System.Drawing.Size(343, 21);
            this.payScheduleComboBox.TabIndex = 3;
            this.payScheduleComboBox.SelectedIndexChanged += new System.EventHandler(this.payScheduleComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Período";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.additionalTypeComboBox);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.additionalAmountSpinner);
            this.groupBox2.Controls.Add(this.additionalsGridView);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(42, 299);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(576, 266);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adicionales";
            // 
            // additionalTypeComboBox
            // 
            this.additionalTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.additionalTypeComboBox.FormattingEnabled = true;
            this.additionalTypeComboBox.Location = new System.Drawing.Point(289, 36);
            this.additionalTypeComboBox.Name = "additionalTypeComboBox";
            this.additionalTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.additionalTypeComboBox.TabIndex = 17;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(286, 20);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(28, 13);
            this.label17.TabIndex = 16;
            this.label17.Text = "Tipo";
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Location = new System.Drawing.Point(416, 74);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Guardar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(486, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Borrar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // additionalAmountSpinner
            // 
            this.additionalAmountSpinner.DecimalPlaces = 2;
            this.additionalAmountSpinner.Location = new System.Drawing.Point(433, 36);
            this.additionalAmountSpinner.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.additionalAmountSpinner.Name = "additionalAmountSpinner";
            this.additionalAmountSpinner.Size = new System.Drawing.Size(120, 20);
            this.additionalAmountSpinner.TabIndex = 5;
            // 
            // additionalsGridView
            // 
            this.additionalsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.additionalsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.additionalsGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.additionalsGridView.Location = new System.Drawing.Point(10, 116);
            this.additionalsGridView.Name = "additionalsGridView";
            this.additionalsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.additionalsGridView.Size = new System.Drawing.Size(540, 138);
            this.additionalsGridView.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(346, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Nuevo";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(427, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Monto";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(10, 36);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(259, 20);
            this.textBox5.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Concepto";
            // 
            // generatePaySlipButton
            // 
            this.generatePaySlipButton.Location = new System.Drawing.Point(482, 732);
            this.generatePaySlipButton.Name = "generatePaySlipButton";
            this.generatePaySlipButton.Size = new System.Drawing.Size(139, 23);
            this.generatePaySlipButton.TabIndex = 12;
            this.generatePaySlipButton.Text = "Generar Boleta de Pago";
            this.generatePaySlipButton.UseVisualStyleBackColor = true;
            this.generatePaySlipButton.Click += new System.EventHandler(this.generatePaySlipButton_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(290, 732);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(66, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "Guardar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.previosPayPeriodButton);
            this.panel1.Controls.Add(this.nextPayPeriodButton);
            this.panel1.Controls.Add(this.selectedPeriodLabel);
            this.panel1.Location = new System.Drawing.Point(179, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 33);
            this.panel1.TabIndex = 14;
            // 
            // previosPayPeriodButton
            // 
            this.previosPayPeriodButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.previosPayPeriodButton.Location = new System.Drawing.Point(0, 0);
            this.previosPayPeriodButton.Name = "previosPayPeriodButton";
            this.previosPayPeriodButton.Size = new System.Drawing.Size(43, 33);
            this.previosPayPeriodButton.TabIndex = 5;
            this.previosPayPeriodButton.Text = "<<";
            this.previosPayPeriodButton.UseVisualStyleBackColor = true;
            this.previosPayPeriodButton.Click += new System.EventHandler(this.previosPayPeriodButton_Click);
            // 
            // nextPayPeriodButton
            // 
            this.nextPayPeriodButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.nextPayPeriodButton.Location = new System.Drawing.Point(303, 0);
            this.nextPayPeriodButton.Name = "nextPayPeriodButton";
            this.nextPayPeriodButton.Size = new System.Drawing.Size(40, 33);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Status:";
            // 
            // statusDataLabel
            // 
            this.statusDataLabel.AutoSize = true;
            this.statusDataLabel.Location = new System.Drawing.Point(176, 166);
            this.statusDataLabel.Name = "statusDataLabel";
            this.statusDataLabel.Size = new System.Drawing.Size(58, 13);
            this.statusDataLabel.TabIndex = 17;
            this.statusDataLabel.Text = "statusData";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.trackedAmountDataLabel);
            this.groupBox1.Controls.Add(this.payRateDataLabel);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.trackedDetailsDataLabel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(42, 207);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(579, 70);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trabajo Registrado";
            // 
            // trackedAmountDataLabel
            // 
            this.trackedAmountDataLabel.AutoSize = true;
            this.trackedAmountDataLabel.Location = new System.Drawing.Point(513, 51);
            this.trackedAmountDataLabel.Name = "trackedAmountDataLabel";
            this.trackedAmountDataLabel.Size = new System.Drawing.Size(40, 13);
            this.trackedAmountDataLabel.TabIndex = 16;
            this.trackedAmountDataLabel.Text = "500.00";
            // 
            // payRateDataLabel
            // 
            this.payRateDataLabel.AutoSize = true;
            this.payRateDataLabel.Location = new System.Drawing.Point(352, 51);
            this.payRateDataLabel.Name = "payRateDataLabel";
            this.payRateDataLabel.Size = new System.Drawing.Size(40, 13);
            this.payRateDataLabel.TabIndex = 15;
            this.payRateDataLabel.Text = "100.00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(350, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Tarifa";
            // 
            // trackedDetailsDataLabel
            // 
            this.trackedDetailsDataLabel.AutoSize = true;
            this.trackedDetailsDataLabel.Location = new System.Drawing.Point(12, 51);
            this.trackedDetailsDataLabel.Name = "trackedDetailsDataLabel";
            this.trackedDetailsDataLabel.Size = new System.Drawing.Size(89, 13);
            this.trackedDetailsDataLabel.TabIndex = 12;
            this.trackedDetailsDataLabel.Text = "5 días trabajados";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(513, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Monto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tiempo trabajado:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.balanceDueTextBox);
            this.groupBox3.Controls.Add(this.totalAmountTextBox);
            this.groupBox3.Controls.Add(this.additionalsAmountTextBox);
            this.groupBox3.Controls.Add(this.trackedAmountTextBox);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Location = new System.Drawing.Point(45, 587);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(576, 118);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Totales";
            // 
            // balanceDueTextBox
            // 
            this.balanceDueTextBox.Location = new System.Drawing.Point(447, 88);
            this.balanceDueTextBox.Name = "balanceDueTextBox";
            this.balanceDueTextBox.ReadOnly = true;
            this.balanceDueTextBox.Size = new System.Drawing.Size(100, 20);
            this.balanceDueTextBox.TabIndex = 7;
            this.balanceDueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // totalAmountTextBox
            // 
            this.totalAmountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAmountTextBox.Location = new System.Drawing.Point(447, 65);
            this.totalAmountTextBox.Name = "totalAmountTextBox";
            this.totalAmountTextBox.ReadOnly = true;
            this.totalAmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalAmountTextBox.TabIndex = 6;
            this.totalAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // additionalsAmountTextBox
            // 
            this.additionalsAmountTextBox.Location = new System.Drawing.Point(447, 42);
            this.additionalsAmountTextBox.Name = "additionalsAmountTextBox";
            this.additionalsAmountTextBox.ReadOnly = true;
            this.additionalsAmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.additionalsAmountTextBox.TabIndex = 5;
            this.additionalsAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // trackedAmountTextBox
            // 
            this.trackedAmountTextBox.Location = new System.Drawing.Point(447, 17);
            this.trackedAmountTextBox.Name = "trackedAmountTextBox";
            this.trackedAmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.trackedAmountTextBox.TabIndex = 4;
            this.trackedAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 91);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "Total adeudado:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 68);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Total a pagar:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 45);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Total Adicionales:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(136, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Total por trabajo registrado:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(362, 732);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(114, 23);
            this.button5.TabIndex = 20;
            this.button5.Text = "Guardar y Cerrar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(13, 732);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 21;
            this.button6.Text = "Anular";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // GeneratePayrollForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 777);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusDataLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.generatePaySlipButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.payScheduleComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.workerComboBox);
            this.Controls.Add(this.label1);
            this.Name = "GeneratePayrollForm";
            this.Text = "GeneratePayrollForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GeneratePayrollForm_FormClosed);
            this.Load += new System.EventHandler(this.GeneratePayrollForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.additionalAmountSpinner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.additionalsGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox workerComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox payScheduleComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button generatePaySlipButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button previosPayPeriodButton;
        private System.Windows.Forms.Button nextPayPeriodButton;
        private System.Windows.Forms.Label selectedPeriodLabel;
        private System.Windows.Forms.DataGridView additionalsGridView;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label statusDataLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label trackedAmountDataLabel;
        private System.Windows.Forms.Label payRateDataLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label trackedDetailsDataLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown additionalAmountSpinner;
        private System.Windows.Forms.ComboBox additionalTypeComboBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox balanceDueTextBox;
        private System.Windows.Forms.TextBox totalAmountTextBox;
        private System.Windows.Forms.TextBox additionalsAmountTextBox;
        private System.Windows.Forms.TextBox trackedAmountTextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}