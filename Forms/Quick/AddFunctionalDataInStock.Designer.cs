namespace StockMaster
{
    partial class AddFunctionalDataInStock
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
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            nameOfGoodTextBox = new System.Windows.Forms.TextBox();
            quantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            priceTextBox = new System.Windows.Forms.TextBox();
            createButton = new System.Windows.Forms.Button();
            cancelButton = new System.Windows.Forms.Button();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
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
            label1.Location = new System.Drawing.Point(4, 5);
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
            panel1.TabIndex = 3;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(15, 44);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(87, 15);
            label2.TabIndex = 4;
            label2.Text = "Name of good:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(15, 105);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(56, 15);
            label3.TabIndex = 5;
            label3.Text = "Quantity:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(229, 44);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(83, 15);
            label4.TabIndex = 6;
            label4.Text = "Data of arrival:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(229, 104);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(36, 15);
            label5.TabIndex = 7;
            label5.Text = "Price:";
            // 
            // nameOfGoodTextBox
            // 
            nameOfGoodTextBox.Location = new System.Drawing.Point(15, 62);
            nameOfGoodTextBox.MaxLength = 10;
            nameOfGoodTextBox.Name = "nameOfGoodTextBox";
            nameOfGoodTextBox.Size = new System.Drawing.Size(182, 23);
            nameOfGoodTextBox.TabIndex = 8;
            // 
            // quantityNumericUpDown
            // 
            quantityNumericUpDown.Location = new System.Drawing.Point(15, 123);
            quantityNumericUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            quantityNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            quantityNumericUpDown.Name = "quantityNumericUpDown";
            quantityNumericUpDown.Size = new System.Drawing.Size(182, 23);
            quantityNumericUpDown.TabIndex = 9;
            quantityNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new System.Drawing.Point(229, 122);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new System.Drawing.Size(182, 23);
            priceTextBox.TabIndex = 11;
            priceTextBox.Text = "0";
            priceTextBox.KeyPress += priceTextBox_KeyPress;
            // 
            // createButton
            // 
            createButton.Location = new System.Drawing.Point(9, 160);
            createButton.Name = "createButton";
            createButton.Size = new System.Drawing.Size(200, 45);
            createButton.TabIndex = 12;
            createButton.Text = "Create";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new System.Drawing.Point(215, 160);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(200, 45);
            cancelButton.TabIndex = 13;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd.MM.yyyy HH:mm";
            dateTimePicker1.Location = new System.Drawing.Point(229, 62);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(168, 23);
            dateTimePicker1.TabIndex = 14;
            // 
            // AddFunctionalDataInStock
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(427, 217);
            Controls.Add(dateTimePicker1);
            Controls.Add(cancelButton);
            Controls.Add(createButton);
            Controls.Add(priceTextBox);
            Controls.Add(quantityNumericUpDown);
            Controls.Add(nameOfGoodTextBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "AddFunctionalDataInStock";
            Text = "AddDataInStock";
            Load += AddDataInStock_Load;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nameOfGoodTextBox;
        private System.Windows.Forms.NumericUpDown quantityNumericUpDown;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}