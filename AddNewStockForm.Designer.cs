namespace StockMaster
{
    partial class AddNewStockForm
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
            panel1 = new System.Windows.Forms.Panel();
            closeFormButton = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            closeButton = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            nameOfStock = new System.Windows.Forms.TextBox();
            publicRadioButton = new System.Windows.Forms.RadioButton();
            privatRadioButton = new System.Windows.Forms.RadioButton();
            accessPrivatePanel = new System.Windows.Forms.Panel();
            infoPasswordLabel = new System.Windows.Forms.Label();
            confirmPasswordTextBox = new System.Windows.Forms.TextBox();
            passwordTextBox = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            chooseTypeOfStock = new System.Windows.Forms.ComboBox();
            importantTextPanel = new System.Windows.Forms.Panel();
            infoStockLabel = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            addButton = new System.Windows.Forms.Button();
            denyButton = new System.Windows.Forms.Button();
            panel1.SuspendLayout();
            accessPrivatePanel.SuspendLayout();
            importantTextPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.Highlight;
            panel1.Controls.Add(closeFormButton);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(closeButton);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(727, 35);
            panel1.TabIndex = 1;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // closeFormButton
            // 
            closeFormButton.Dock = System.Windows.Forms.DockStyle.Right;
            closeFormButton.FlatAppearance.BorderSize = 0;
            closeFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            closeFormButton.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            closeFormButton.Location = new System.Drawing.Point(698, 0);
            closeFormButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            closeFormButton.Name = "closeFormButton";
            closeFormButton.Size = new System.Drawing.Size(29, 35);
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
            label1.Size = new System.Drawing.Size(102, 21);
            label1.TabIndex = 1;
            label1.Text = "AddNewStock";
            label1.MouseDown += panel1_MouseDown;
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
            label2.Location = new System.Drawing.Point(24, 81);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(87, 15);
            label2.TabIndex = 2;
            label2.Text = "Name of stock:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(476, 81);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(46, 15);
            label4.TabIndex = 4;
            label4.Text = "Access:";
            // 
            // nameOfStock
            // 
            nameOfStock.Location = new System.Drawing.Point(26, 112);
            nameOfStock.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            nameOfStock.MaxLength = 10;
            nameOfStock.Name = "nameOfStock";
            nameOfStock.Size = new System.Drawing.Size(218, 23);
            nameOfStock.TabIndex = 5;
            // 
            // publicRadioButton
            // 
            publicRadioButton.AutoSize = true;
            publicRadioButton.Checked = true;
            publicRadioButton.Location = new System.Drawing.Point(479, 99);
            publicRadioButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            publicRadioButton.Name = "publicRadioButton";
            publicRadioButton.Size = new System.Drawing.Size(58, 19);
            publicRadioButton.TabIndex = 7;
            publicRadioButton.TabStop = true;
            publicRadioButton.Text = "Public";
            publicRadioButton.UseVisualStyleBackColor = true;
            publicRadioButton.CheckedChanged += publicRadioButton_CheckedChanged;
            // 
            // privatRadioButton
            // 
            privatRadioButton.AutoSize = true;
            privatRadioButton.Location = new System.Drawing.Point(479, 126);
            privatRadioButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            privatRadioButton.Name = "privatRadioButton";
            privatRadioButton.Size = new System.Drawing.Size(61, 19);
            privatRadioButton.TabIndex = 8;
            privatRadioButton.Text = "Private";
            privatRadioButton.UseVisualStyleBackColor = true;
            privatRadioButton.CheckedChanged += privatRadioButton_CheckedChanged;
            // 
            // accessPrivatePanel
            // 
            accessPrivatePanel.Controls.Add(infoPasswordLabel);
            accessPrivatePanel.Controls.Add(confirmPasswordTextBox);
            accessPrivatePanel.Controls.Add(passwordTextBox);
            accessPrivatePanel.Controls.Add(label6);
            accessPrivatePanel.Controls.Add(label5);
            accessPrivatePanel.Location = new System.Drawing.Point(482, 152);
            accessPrivatePanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            accessPrivatePanel.Name = "accessPrivatePanel";
            accessPrivatePanel.Size = new System.Drawing.Size(216, 144);
            accessPrivatePanel.TabIndex = 9;
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(24, 151);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(76, 15);
            label7.TabIndex = 10;
            label7.Text = "Kind of stock";
            // 
            // chooseTypeOfStock
            // 
            chooseTypeOfStock.FormattingEnabled = true;
            chooseTypeOfStock.Items.AddRange(new object[] { "Функціональний склад", "Фізичний склад" });
            chooseTypeOfStock.Location = new System.Drawing.Point(28, 182);
            chooseTypeOfStock.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chooseTypeOfStock.Name = "chooseTypeOfStock";
            chooseTypeOfStock.Size = new System.Drawing.Size(140, 23);
            chooseTypeOfStock.TabIndex = 11;
            chooseTypeOfStock.SelectedIndexChanged += chooseTypeOfStock_SelectedIndexChanged;
            // 
            // importantTextPanel
            // 
            importantTextPanel.Controls.Add(infoStockLabel);
            importantTextPanel.Controls.Add(label8);
            importantTextPanel.Location = new System.Drawing.Point(28, 225);
            importantTextPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            importantTextPanel.Name = "importantTextPanel";
            importantTextPanel.Size = new System.Drawing.Size(348, 75);
            importantTextPanel.TabIndex = 12;
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
            // addButton
            // 
            addButton.BackColor = System.Drawing.Color.RoyalBlue;
            addButton.FlatAppearance.BorderSize = 0;
            addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            addButton.Location = new System.Drawing.Point(26, 352);
            addButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            addButton.Name = "addButton";
            addButton.Size = new System.Drawing.Size(119, 35);
            addButton.TabIndex = 13;
            addButton.Text = "Create";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // denyButton
            // 
            denyButton.BackColor = System.Drawing.Color.CornflowerBlue;
            denyButton.FlatAppearance.BorderSize = 0;
            denyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            denyButton.Location = new System.Drawing.Point(152, 352);
            denyButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            denyButton.Name = "denyButton";
            denyButton.Size = new System.Drawing.Size(119, 35);
            denyButton.TabIndex = 14;
            denyButton.Text = "Close";
            denyButton.UseVisualStyleBackColor = false;
            denyButton.Click += denyButton_Click;
            // 
            // AddNewStockForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ButtonHighlight;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(727, 400);
            Controls.Add(denyButton);
            Controls.Add(addButton);
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
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "AddNewStockForm";
            Text = "AddNewStockForm";
            Load += AddNewStockForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            accessPrivatePanel.ResumeLayout(false);
            accessPrivatePanel.PerformLayout();
            importantTextPanel.ResumeLayout(false);
            importantTextPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button closeFormButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameOfStock;
        private System.Windows.Forms.RadioButton publicRadioButton;
        private System.Windows.Forms.RadioButton privatRadioButton;
        private System.Windows.Forms.Panel accessPrivatePanel;
        private System.Windows.Forms.TextBox confirmPasswordTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label infoPasswordLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox chooseTypeOfStock;
        private System.Windows.Forms.Panel importantTextPanel;
        private System.Windows.Forms.Label infoStockLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button denyButton;
    }
}