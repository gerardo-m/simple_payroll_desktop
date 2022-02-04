
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
            this.extraTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.extraAmountSpinner = new System.Windows.Forms.NumericUpDown();
            this.extrasGridView = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.extraConceptTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.button6 = new System.Windows.Forms.Button();
            this.saveAndCloseButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.generatePaySlipButton = new System.Windows.Forms.Button();
            this.saveExtraButton = new System.Windows.Forms.Button();
            this.deleteExtraButton = new System.Windows.Forms.Button();
            this.newExtraButton = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.extraAmountSpinner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.extrasGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
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
            this.groupBox2.Controls.Add(this.extraTypeComboBox);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.saveExtraButton);
            this.groupBox2.Controls.Add(this.deleteExtraButton);
            this.groupBox2.Controls.Add(this.extraAmountSpinner);
            this.groupBox2.Controls.Add(this.extrasGridView);
            this.groupBox2.Controls.Add(this.newExtraButton);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.extraConceptTextBox);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(42, 299);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(576, 282);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adicionales";
            // 
            // extraTypeComboBox
            // 
            this.extraTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.extraTypeComboBox.FormattingEnabled = true;
            this.extraTypeComboBox.Location = new System.Drawing.Point(289, 36);
            this.extraTypeComboBox.Name = "extraTypeComboBox";
            this.extraTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.extraTypeComboBox.TabIndex = 17;
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
            // extraAmountSpinner
            // 
            this.extraAmountSpinner.DecimalPlaces = 2;
            this.extraAmountSpinner.Location = new System.Drawing.Point(433, 36);
            this.extraAmountSpinner.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.extraAmountSpinner.Name = "extraAmountSpinner";
            this.extraAmountSpinner.Size = new System.Drawing.Size(120, 20);
            this.extraAmountSpinner.TabIndex = 5;
            // 
            // extrasGridView
            // 
            this.extrasGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.extrasGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.extrasGridView.Location = new System.Drawing.Point(10, 128);
            this.extrasGridView.Name = "extrasGridView";
            this.extrasGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.extrasGridView.Size = new System.Drawing.Size(540, 138);
            this.extrasGridView.TabIndex = 15;
            this.extrasGridView.SelectionChanged += new System.EventHandler(this.extrasGridView_SelectionChanged);
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
            // extraConceptTextBox
            // 
            this.extraConceptTextBox.Location = new System.Drawing.Point(10, 36);
            this.extraConceptTextBox.Name = "extraConceptTextBox";
            this.extraConceptTextBox.Size = new System.Drawing.Size(259, 20);
            this.extraConceptTextBox.TabIndex = 1;
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
            this.label15.Size = new System.Drawing.Size(69, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Total planilla:";
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
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 779);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(633, 22);
            this.statusStrip1.TabIndex = 22;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(118, 17);
            this.statusLabel.Text = "toolStripStatusLabel1";
            // 
            // button6
            // 
            this.button6.Image = global::simple_payroll_desktop.Properties.Resources.icons8_close_32;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(13, 732);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(90, 40);
            this.button6.TabIndex = 21;
            this.button6.Text = "Anular";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // saveAndCloseButton
            // 
            this.saveAndCloseButton.Image = global::simple_payroll_desktop.Properties.Resources.icons8_save_close_32;
            this.saveAndCloseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveAndCloseButton.Location = new System.Drawing.Point(322, 732);
            this.saveAndCloseButton.Name = "saveAndCloseButton";
            this.saveAndCloseButton.Size = new System.Drawing.Size(130, 40);
            this.saveAndCloseButton.TabIndex = 20;
            this.saveAndCloseButton.Text = "Guardar y Cerrar";
            this.saveAndCloseButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveAndCloseButton.UseVisualStyleBackColor = true;
            this.saveAndCloseButton.Click += new System.EventHandler(this.saveAndCloseButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Image = global::simple_payroll_desktop.Properties.Resources.icons8_save_32;
            this.saveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveButton.Location = new System.Drawing.Point(221, 732);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(90, 40);
            this.saveButton.TabIndex = 13;
            this.saveButton.Text = "Guardar";
            this.saveButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // generatePaySlipButton
            // 
            this.generatePaySlipButton.Image = global::simple_payroll_desktop.Properties.Resources.icons8_payment_check_32__1_;
            this.generatePaySlipButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.generatePaySlipButton.Location = new System.Drawing.Point(461, 732);
            this.generatePaySlipButton.Name = "generatePaySlipButton";
            this.generatePaySlipButton.Size = new System.Drawing.Size(160, 40);
            this.generatePaySlipButton.TabIndex = 12;
            this.generatePaySlipButton.Text = "Generar Boleta de Pago";
            this.generatePaySlipButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.generatePaySlipButton.UseVisualStyleBackColor = true;
            this.generatePaySlipButton.Click += new System.EventHandler(this.generatePaySlipButton_Click);
            // 
            // saveExtraButton
            // 
            this.saveExtraButton.AutoSize = true;
            this.saveExtraButton.Image = global::simple_payroll_desktop.Properties.Resources.icons8_save_32;
            this.saveExtraButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveExtraButton.Location = new System.Drawing.Point(364, 70);
            this.saveExtraButton.Name = "saveExtraButton";
            this.saveExtraButton.Size = new System.Drawing.Size(90, 40);
            this.saveExtraButton.TabIndex = 7;
            this.saveExtraButton.Text = "Guardar";
            this.saveExtraButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveExtraButton.UseVisualStyleBackColor = true;
            this.saveExtraButton.Click += new System.EventHandler(this.saveExtraButton_Click);
            // 
            // deleteExtraButton
            // 
            this.deleteExtraButton.Image = global::simple_payroll_desktop.Properties.Resources.icons8_remove_32;
            this.deleteExtraButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteExtraButton.Location = new System.Drawing.Point(460, 70);
            this.deleteExtraButton.Name = "deleteExtraButton";
            this.deleteExtraButton.Size = new System.Drawing.Size(90, 40);
            this.deleteExtraButton.TabIndex = 6;
            this.deleteExtraButton.Text = "Borrar";
            this.deleteExtraButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteExtraButton.UseVisualStyleBackColor = true;
            this.deleteExtraButton.Click += new System.EventHandler(this.deleteExtraButton_Click);
            // 
            // newExtraButton
            // 
            this.newExtraButton.Image = global::simple_payroll_desktop.Properties.Resources.icons8_add_32;
            this.newExtraButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newExtraButton.Location = new System.Drawing.Point(268, 70);
            this.newExtraButton.Name = "newExtraButton";
            this.newExtraButton.Size = new System.Drawing.Size(90, 40);
            this.newExtraButton.TabIndex = 4;
            this.newExtraButton.Text = "Nuevo";
            this.newExtraButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.newExtraButton.UseVisualStyleBackColor = true;
            this.newExtraButton.Click += new System.EventHandler(this.newExtraButton_Click);
            // 
            // GeneratePayrollForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 801);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.saveAndCloseButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusDataLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.generatePaySlipButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.payScheduleComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.workerComboBox);
            this.Controls.Add(this.label1);
            this.Name = "GeneratePayrollForm";
            this.Text = "Generar planilla";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GeneratePayrollForm_FormClosed);
            this.Load += new System.EventHandler(this.GeneratePayrollForm_Load);
            this.VisibleChanged += new System.EventHandler(this.GeneratePayrollForm_VisibleChanged);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.extraAmountSpinner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.extrasGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.Button newExtraButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox extraConceptTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button generatePaySlipButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button previosPayPeriodButton;
        private System.Windows.Forms.Button nextPayPeriodButton;
        private System.Windows.Forms.Label selectedPeriodLabel;
        private System.Windows.Forms.DataGridView extrasGridView;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label statusDataLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label trackedAmountDataLabel;
        private System.Windows.Forms.Label payRateDataLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label trackedDetailsDataLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button saveExtraButton;
        private System.Windows.Forms.Button deleteExtraButton;
        private System.Windows.Forms.NumericUpDown extraAmountSpinner;
        private System.Windows.Forms.ComboBox extraTypeComboBox;
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
        private System.Windows.Forms.Button saveAndCloseButton;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
    }
}