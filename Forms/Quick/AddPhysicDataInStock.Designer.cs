namespace StockMaster.Forms.Quick
{
    partial class AddPhysicDataInStock
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
            closeFormButton = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            closeButton = new System.Windows.Forms.Button();
            cancelButton = new System.Windows.Forms.Button();
            createButton = new System.Windows.Forms.Button();
            quantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            nameOfGoodTextBox = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)quantityNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // closeFormButton
            // 
            closeFormButton.Dock = System.Windows.Forms.DockStyle.Right;
            closeFormButton.FlatAppearance.BorderSize = 0;
            closeFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            closeFormButton.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            closeFormButton.Location = new System.Drawing.Point(398, 0);
            closeFormButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            closeFormButton.Name = "closeFormButton";
            closeFormButton.Size = new System.Drawing.Size(29, 28);
            closeFormButton.TabIndex = 2;
            closeFormButton.Text = "X";
            closeFormButton.UseVisualStyleBackColor = true;
            closeFormButton.Click += closeFormButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(4, 3);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(129, 21);
            label1.TabIndex = 1;
            label1.Text = "AddDataForStock";
            label1.MouseDown += panel1_MouseDown;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.Highlight;
            panel1.Controls.Add(closeFormButton);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(closeButton);
            panel1.Cursor = System.Windows.Forms.Cursors.IBeam;
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(427, 28);
            panel1.TabIndex = 4;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // closeButton
            // 
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            closeButton.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            closeButton.Location = new System.Drawing.Point(1138, 3);
            closeButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            closeButton.Name = "closeButton";
            closeButton.Size = new System.Drawing.Size(29, 29);
            closeButton.TabIndex = 0;
            closeButton.Text = "X";
            closeButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            cancelButton.Location = new System.Drawing.Point(212, 82);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(200, 45);
            cancelButton.TabIndex = 19;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // createButton
            // 
            createButton.Location = new System.Drawing.Point(6, 82);
            createButton.Name = "createButton";
            createButton.Size = new System.Drawing.Size(200, 45);
            createButton.TabIndex = 18;
            createButton.Text = "Create";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click;
            // 
            // quantityNumericUpDown
            // 
            quantityNumericUpDown.Location = new System.Drawing.Point(212, 53);
            quantityNumericUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            quantityNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            quantityNumericUpDown.Name = "quantityNumericUpDown";
            quantityNumericUpDown.Size = new System.Drawing.Size(200, 23);
            quantityNumericUpDown.TabIndex = 17;
            quantityNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nameOfGoodTextBox
            // 
            nameOfGoodTextBox.Location = new System.Drawing.Point(6, 53);
            nameOfGoodTextBox.MaxLength = 10;
            nameOfGoodTextBox.Name = "nameOfGoodTextBox";
            nameOfGoodTextBox.Size = new System.Drawing.Size(200, 23);
            nameOfGoodTextBox.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(212, 35);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(56, 15);
            label3.TabIndex = 15;
            label3.Text = "Quantity:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 35);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(87, 15);
            label2.TabIndex = 14;
            label2.Text = "Name of good:";
            // 
            // AddPhysicDataInStock
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(427, 134);
            Controls.Add(cancelButton);
            Controls.Add(createButton);
            Controls.Add(quantityNumericUpDown);
            Controls.Add(nameOfGoodTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "AddPhysicDataInStock";
            Text = "AddPhysicDataInStock";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)quantityNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button closeFormButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.NumericUpDown quantityNumericUpDown;
        private System.Windows.Forms.TextBox nameOfGoodTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}