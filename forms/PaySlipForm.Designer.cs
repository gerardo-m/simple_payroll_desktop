
namespace simple_payroll_desktop.forms
{
    partial class PaySlipForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.extrasTableContainer = new System.Windows.Forms.TableLayoutPanel();
            this.trackedWorkAmountTextBox = new System.Windows.Forms.TextBox();
            this.trackedWorkConceptDataLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.payrollTotalTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.previouslyPaidTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.toBePaidTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.saveAndPrintButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.workerTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.extrasTableContainer);
            this.groupBox1.Location = new System.Drawing.Point(29, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 220);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adicionales";
            // 
            // extrasTableContainer
            // 
            this.extrasTableContainer.AutoSize = true;
            this.extrasTableContainer.ColumnCount = 1;
            this.extrasTableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.extrasTableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.extrasTableContainer.Location = new System.Drawing.Point(6, 30);
            this.extrasTableContainer.Name = "extrasTableContainer";
            this.extrasTableContainer.RowCount = 2;
            this.extrasTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.extrasTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.extrasTableContainer.Size = new System.Drawing.Size(531, 40);
            this.extrasTableContainer.TabIndex = 0;
            // 
            // trackedWorkAmountTextBox
            // 
            this.trackedWorkAmountTextBox.Location = new System.Drawing.Point(447, 145);
            this.trackedWorkAmountTextBox.Name = "trackedWorkAmountTextBox";
            this.trackedWorkAmountTextBox.ReadOnly = true;
            this.trackedWorkAmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.trackedWorkAmountTextBox.TabIndex = 23;
            this.trackedWorkAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // trackedWorkConceptDataLabel
            // 
            this.trackedWorkConceptDataLabel.AutoSize = true;
            this.trackedWorkConceptDataLabel.Location = new System.Drawing.Point(29, 148);
            this.trackedWorkConceptDataLabel.Name = "trackedWorkConceptDataLabel";
            this.trackedWorkConceptDataLabel.Size = new System.Drawing.Size(89, 13);
            this.trackedWorkConceptDataLabel.TabIndex = 14;
            this.trackedWorkConceptDataLabel.Text = "5 días trabajados";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(510, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Monto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Detalle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 442);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Total de planilla";
            // 
            // payrollTotalTextBox
            // 
            this.payrollTotalTextBox.Location = new System.Drawing.Point(447, 439);
            this.payrollTotalTextBox.Name = "payrollTotalTextBox";
            this.payrollTotalTextBox.ReadOnly = true;
            this.payrollTotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.payrollTotalTextBox.TabIndex = 19;
            this.payrollTotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 471);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Pagado anteriormente";
            // 
            // previouslyPaidTextBox
            // 
            this.previouslyPaidTextBox.Location = new System.Drawing.Point(447, 468);
            this.previouslyPaidTextBox.Name = "previouslyPaidTextBox";
            this.previouslyPaidTextBox.ReadOnly = true;
            this.previouslyPaidTextBox.Size = new System.Drawing.Size(100, 20);
            this.previouslyPaidTextBox.TabIndex = 21;
            this.previouslyPaidTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // amountTextBox
            // 
            this.amountTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.amountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountTextBox.Location = new System.Drawing.Point(447, 499);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(100, 20);
            this.amountTextBox.TabIndex = 15;
            this.amountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 502);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "A pagar con esta boleta";
            // 
            // toBePaidTextBox
            // 
            this.toBePaidTextBox.Location = new System.Drawing.Point(447, 531);
            this.toBePaidTextBox.Name = "toBePaidTextBox";
            this.toBePaidTextBox.ReadOnly = true;
            this.toBePaidTextBox.Size = new System.Drawing.Size(100, 20);
            this.toBePaidTextBox.TabIndex = 25;
            this.toBePaidTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 534);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Saldo pendiente";
            // 
            // saveAndPrintButton
            // 
            this.saveAndPrintButton.Location = new System.Drawing.Point(440, 576);
            this.saveAndPrintButton.Name = "saveAndPrintButton";
            this.saveAndPrintButton.Size = new System.Drawing.Size(109, 23);
            this.saveAndPrintButton.TabIndex = 26;
            this.saveAndPrintButton.Text = "Guardar E Imprimir";
            this.saveAndPrintButton.UseVisualStyleBackColor = true;
            this.saveAndPrintButton.Click += new System.EventHandler(this.saveAndPrintButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Trabajador";
            // 
            // workerTextBox
            // 
            this.workerTextBox.Location = new System.Drawing.Point(136, 32);
            this.workerTextBox.Name = "workerTextBox";
            this.workerTextBox.ReadOnly = true;
            this.workerTextBox.Size = new System.Drawing.Size(411, 20);
            this.workerTextBox.TabIndex = 28;
            // 
            // PaySlipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 620);
            this.Controls.Add(this.workerTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.saveAndPrintButton);
            this.Controls.Add(this.toBePaidTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.previouslyPaidTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.payrollTotalTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.trackedWorkAmountTextBox);
            this.Controls.Add(this.trackedWorkConceptDataLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "PaySlipForm";
            this.Text = "PaySlipForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PaySlipForm_FormClosed);
            this.Load += new System.EventHandler(this.PaySlipForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox trackedWorkAmountTextBox;
        private System.Windows.Forms.Label trackedWorkConceptDataLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox payrollTotalTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox previouslyPaidTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox toBePaidTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button saveAndPrintButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox workerTextBox;
        private System.Windows.Forms.TableLayoutPanel extrasTableContainer;
    }
}