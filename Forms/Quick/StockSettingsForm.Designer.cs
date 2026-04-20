namespace StockMaster.Forms.Quick
{
    partial class StockSettingsForm
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
            label1 = new System.Windows.Forms.Label();
            closeButton = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            denyButton = new System.Windows.Forms.Button();
            updateButton = new System.Windows.Forms.Button();
            importantTextPanel = new System.Windows.Forms.Panel();
            infoStockLabel = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            chooseTypeOfStock = new System.Windows.Forms.ComboBox();
            label7 = new System.Windows.Forms.Label();
            accessPrivatePanel = new System.Windows.Forms.Panel();
            infoPasswordLabel = new System.Windows.Forms.Label();
            confirmPasswordTextBox = new System.Windows.Forms.TextBox();
            passwordTextBox = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            privatRadioButton = new System.Windows.Forms.RadioButton();
            publicRadioButton = new System.Windows.Forms.RadioButton();
            nameOfStock = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            importantTextPanel.SuspendLayout();
            accessPrivatePanel.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(4, 5);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(95, 21);
            label1.TabIndex = 1;
            label1.Text = "StockSettings";
            label1.MouseDown += panel1_MouseDown;
            // 
            // closeButton
            // 
            closeButton.Dock = System.Windows.Forms.DockStyle.Right;
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            closeButton.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            closeButton.Location = new System.Drawing.Point(611, 0);
            closeButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            closeButton.Name = "closeButton";
            closeButton.Size = new System.Drawing.Size(29, 35);
            closeButton.TabIndex = 0;
            closeButton.Text = "X";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.Highlight;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(closeButton);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(640, 35);
            panel1.TabIndex = 1;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // denyButton
            // 
            denyButton.BackColor = System.Drawing.Color.CornflowerBlue;
            denyButton.FlatAppearance.BorderSize = 0;
            denyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            denyButton.Location = new System.Drawing.Point(158, 282);
            denyButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            denyButton.Name = "denyButton";
            denyButton.Size = new System.Drawing.Size(119, 35);
            denyButton.TabIndex = 25;
            denyButton.Text = "Close";
            denyButton.UseVisualStyleBackColor = false;
            denyButton.Click += denyButton_Click;
            // 
            // updateButton
            // 
            updateButton.BackColor = System.Drawing.Color.RoyalBlue;
            updateButton.FlatAppearance.BorderSize = 0;
            updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            updateButton.Location = new System.Drawing.Point(32, 282);
            updateButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            updateButton.Name = "updateButton";
            updateButton.Size = new System.Drawing.Size(119, 35);
            updateButton.TabIndex = 24;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += updateButton_Click;
            // 
            // importantTextPanel
            // 
            importantTextPanel.Controls.Add(infoStockLabel);
            importantTextPanel.Controls.Add(label8);
            importantTextPanel.Location = new System.Drawing.Point(30, 192);
            importantTextPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            importantTextPanel.Name = "importantTextPanel";
            importantTextPanel.Size = new System.Drawing.Size(348, 75);
            importantTextPanel.TabIndex = 23;
            importantTextPanel.Visible = false;
            // 
            // infoStockLabel
            // 
            infoStockLabel.AutoSize = true;
            infoStockLabel.Location = new System.Drawing.Point(20, 31);
            infoStockLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            infoStockLabel.Name = "infoStockLabel";
            infoStockLabel.Size = new System.Drawing.Size(76, 15);
            infoStockLabel.TabIndex = 13;
            infoStockLabel.Text = "Kind of stock";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            label8.Location = new System.Drawing.Point(128, 8);
            label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(72, 13);
            label8.TabIndex = 0;
            label8.Text = "Important!!!";
            // 
            // chooseTypeOfStock
            // 
            chooseTypeOfStock.FormattingEnabled = true;
            chooseTypeOfStock.Items.AddRange(new object[] { "Функціональний склад", "Фізичний склад" });
            chooseTypeOfStock.Location = new System.Drawing.Point(30, 149);
            chooseTypeOfStock.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chooseTypeOfStock.Name = "chooseTypeOfStock";
            chooseTypeOfStock.Size = new System.Drawing.Size(140, 23);
            chooseTypeOfStock.TabIndex = 22;
            chooseTypeOfStock.SelectedIndexChanged += chooseTypeOfStock_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(26, 118);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(76, 15);
            label7.TabIndex = 21;
            label7.Text = "Kind of stock";
            // 
            // accessPrivatePanel
            // 
            accessPrivatePanel.Controls.Add(infoPasswordLabel);
            accessPrivatePanel.Controls.Add(confirmPasswordTextBox);
            accessPrivatePanel.Controls.Add(passwordTextBox);
            accessPrivatePanel.Controls.Add(label6);
            accessPrivatePanel.Controls.Add(label5);
            accessPrivatePanel.Location = new System.Drawing.Point(399, 119);
            accessPrivatePanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            accessPrivatePanel.Name = "accessPrivatePanel";
            accessPrivatePanel.Size = new System.Drawing.Size(216, 144);
            accessPrivatePanel.TabIndex = 20;
            accessPrivatePanel.Visible = false;
            // 
            // infoPasswordLabel
            // 
            infoPasswordLabel.AutoSize = true;
            infoPasswordLabel.Location = new System.Drawing.Point(23, 118);
            infoPasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            infoPasswordLabel.Name = "infoPasswordLabel";
            infoPasswordLabel.Size = new System.Drawing.Size(0, 15);
            infoPasswordLabel.TabIndex = 13;
            // 
            // confirmPasswordTextBox
            // 
            confirmPasswordTextBox.Location = new System.Drawing.Point(15, 81);
            confirmPasswordTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            confirmPasswordTextBox.MaxLength = 30;
            confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            confirmPasswordTextBox.Size = new System.Drawing.Size(174, 23);
            confirmPasswordTextBox.TabIndex = 12;
            confirmPasswordTextBox.TextChanged += confirmPasswordTextBox_TextChanged;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new System.Drawing.Point(15, 36);
            passwordTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            passwordTextBox.MaxLength = 30;
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new System.Drawing.Size(174, 23);
            passwordTextBox.TabIndex = 10;
            passwordTextBox.TextChanged += passwordTextBox_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = System.Drawing.SystemColors.ControlText;
            label6.Location = new System.Drawing.Point(12, 62);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(107, 15);
            label6.TabIndex = 11;
            label6.Text = "Confirm password:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(12, 13);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(60, 15);
            label5.TabIndex = 10;
            label5.Text = "Password:";
            // 
            // privatRadioButton
            // 
            privatRadioButton.AutoSize = true;
            privatRadioButton.Location = new System.Drawing.Point(396, 93);
            privatRadioButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            privatRadioButton.Name = "privatRadioButton";
            privatRadioButton.Size = new System.Drawing.Size(61, 19);
            privatRadioButton.TabIndex = 19;
            privatRadioButton.Text = "Private";
            privatRadioButton.UseVisualStyleBackColor = true;
            privatRadioButton.CheckedChanged += privatRadioButton_CheckedChanged;
            // 
            // publicRadioButton
            // 
            publicRadioButton.AutoSize = true;
            publicRadioButton.Checked = true;
            publicRadioButton.Location = new System.Drawing.Point(396, 66);
            publicRadioButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            publicRadioButton.Name = "publicRadioButton";
            publicRadioButton.Size = new System.Drawing.Size(58, 19);
            publicRadioButton.TabIndex = 18;
            publicRadioButton.TabStop = true;
            publicRadioButton.Text = "Public";
            publicRadioButton.UseVisualStyleBackColor = true;
            publicRadioButton.CheckedChanged += publicRadioButton_CheckedChanged;
            // 
            // nameOfStock
            // 
            nameOfStock.Location = new System.Drawing.Point(28, 79);
            nameOfStock.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            nameOfStock.MaxLength = 10;
            nameOfStock.Name = "nameOfStock";
            nameOfStock.Size = new System.Drawing.Size(218, 23);
            nameOfStock.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(393, 48);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(46, 15);
            label4.TabIndex = 16;
            label4.Text = "Access:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(26, 48);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(87, 15);
            label2.TabIndex = 15;
            label2.Text = "Name of stock:";
            // 
            // StockSettingsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ButtonHighlight;
            ClientSize = new System.Drawing.Size(640, 340);
            Controls.Add(denyButton);
            Controls.Add(updateButton);
            Controls.Add(importantTextPanel);
            Controls.Add(chooseTypeOfStock);
            Controls.Add(label7);
            Controls.Add(accessPrivatePanel);
            Controls.Add(privatRadioButton);
            Controls.Add(publicRadioButton);
            Controls.Add(nameOfStock);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "StockSettingsForm";
            Text = "StockSettingsForm";
            Load += StockSettingsForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            importantTextPanel.ResumeLayout(false);
            importantTextPanel.PerformLayout();
            accessPrivatePanel.ResumeLayout(false);
            accessPrivatePanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button denyButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Panel importantTextPanel;
        private System.Windows.Forms.Label infoStockLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox chooseTypeOfStock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel accessPrivatePanel;
        private System.Windows.Forms.Label infoPasswordLabel;
        private System.Windows.Forms.TextBox confirmPasswordTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton privatRadioButton;
        private System.Windows.Forms.RadioButton publicRadioButton;
        private System.Windows.Forms.TextBox nameOfStock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}