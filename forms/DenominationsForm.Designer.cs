
namespace simple_payroll_desktop.forms
{
    partial class DenominationsForm
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
            this.denominationsListBox = new System.Windows.Forms.ListBox();
            this.deleteDenominationButton = new System.Windows.Forms.Button();
            this.saveDenominationButton = new System.Windows.Forms.Button();
            this.newDenominationButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // denominationsListBox
            // 
            this.denominationsListBox.FormattingEnabled = true;
            this.denominationsListBox.Location = new System.Drawing.Point(12, 140);
            this.denominationsListBox.Name = "denominationsListBox";
            this.denominationsListBox.Size = new System.Drawing.Size(303, 173);
            this.denominationsListBox.TabIndex = 0;
            this.denominationsListBox.SelectedIndexChanged += new System.EventHandler(this.denominationsListBox_SelectedIndexChanged);
            // 
            // deleteDenominationButton
            // 
            this.deleteDenominationButton.Location = new System.Drawing.Point(240, 101);
            this.deleteDenominationButton.Name = "deleteDenominationButton";
            this.deleteDenominationButton.Size = new System.Drawing.Size(75, 23);
            this.deleteDenominationButton.TabIndex = 1;
            this.deleteDenominationButton.Text = "Borrar";
            this.deleteDenominationButton.UseVisualStyleBackColor = true;
            this.deleteDenominationButton.Click += new System.EventHandler(this.deleteDenominationButton_Click);
            // 
            // saveDenominationButton
            // 
            this.saveDenominationButton.Location = new System.Drawing.Point(159, 101);
            this.saveDenominationButton.Name = "saveDenominationButton";
            this.saveDenominationButton.Size = new System.Drawing.Size(75, 23);
            this.saveDenominationButton.TabIndex = 2;
            this.saveDenominationButton.Text = "Guardar";
            this.saveDenominationButton.UseVisualStyleBackColor = true;
            this.saveDenominationButton.Click += new System.EventHandler(this.saveDenominationButton_Click);
            // 
            // newDenominationButton
            // 
            this.newDenominationButton.Location = new System.Drawing.Point(78, 101);
            this.newDenominationButton.Name = "newDenominationButton";
            this.newDenominationButton.Size = new System.Drawing.Size(75, 23);
            this.newDenominationButton.TabIndex = 3;
            this.newDenominationButton.Text = "Nueva";
            this.newDenominationButton.UseVisualStyleBackColor = true;
            this.newDenominationButton.Click += new System.EventHandler(this.newDenominationButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(12, 53);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(303, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 24);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(47, 13);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Nombre:";
            // 
            // DenominationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 328);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.newDenominationButton);
            this.Controls.Add(this.saveDenominationButton);
            this.Controls.Add(this.deleteDenominationButton);
            this.Controls.Add(this.denominationsListBox);
            this.Name = "DenominationsForm";
            this.Text = "Denominaciones";
            this.Load += new System.EventHandler(this.DenominationsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox denominationsListBox;
        private System.Windows.Forms.Button deleteDenominationButton;
        private System.Windows.Forms.Button saveDenominationButton;
        private System.Windows.Forms.Button newDenominationButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
    }
}