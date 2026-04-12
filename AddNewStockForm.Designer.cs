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
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeFormButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameOfStock = new System.Windows.Forms.TextBox();
            this.publicRadioButton = new System.Windows.Forms.RadioButton();
            this.privatRadioButton = new System.Windows.Forms.RadioButton();
            this.accessPrivatePanel = new System.Windows.Forms.Panel();
            this.infoPasswordLabel = new System.Windows.Forms.Label();
            this.confirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chooseTypeOfStock = new System.Windows.Forms.ComboBox();
            this.importantTextPanel = new System.Windows.Forms.Panel();
            this.infoStockLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.denyButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.accessPrivatePanel.SuspendLayout();
            this.importantTextPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.closeFormButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(623, 30);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // closeFormButton
            // 
            this.closeFormButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeFormButton.FlatAppearance.BorderSize = 0;
            this.closeFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeFormButton.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeFormButton.Location = new System.Drawing.Point(598, 0);
            this.closeFormButton.Name = "closeFormButton";
            this.closeFormButton.Size = new System.Drawing.Size(25, 30);
            this.closeFormButton.TabIndex = 2;
            this.closeFormButton.Text = "X";
            this.closeFormButton.UseVisualStyleBackColor = true;
            this.closeFormButton.Click += new System.EventHandler(this.closeFormButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "AddNewStock";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // closeButton
            // 
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.Location = new System.Drawing.Point(975, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(25, 25);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Назва складу:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(408, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Доступ:";
            // 
            // nameOfStock
            // 
            this.nameOfStock.Location = new System.Drawing.Point(22, 97);
            this.nameOfStock.Name = "nameOfStock";
            this.nameOfStock.Size = new System.Drawing.Size(187, 20);
            this.nameOfStock.TabIndex = 5;
            // 
            // publicRadioButton
            // 
            this.publicRadioButton.AutoSize = true;
            this.publicRadioButton.Checked = true;
            this.publicRadioButton.Location = new System.Drawing.Point(411, 86);
            this.publicRadioButton.Name = "publicRadioButton";
            this.publicRadioButton.Size = new System.Drawing.Size(75, 17);
            this.publicRadioButton.TabIndex = 7;
            this.publicRadioButton.TabStop = true;
            this.publicRadioButton.Text = "Публічний";
            this.publicRadioButton.UseVisualStyleBackColor = true;
            this.publicRadioButton.CheckedChanged += new System.EventHandler(this.publicRadioButton_CheckedChanged);
            // 
            // privatRadioButton
            // 
            this.privatRadioButton.AutoSize = true;
            this.privatRadioButton.Location = new System.Drawing.Point(411, 109);
            this.privatRadioButton.Name = "privatRadioButton";
            this.privatRadioButton.Size = new System.Drawing.Size(80, 17);
            this.privatRadioButton.TabIndex = 8;
            this.privatRadioButton.Text = "Приватний";
            this.privatRadioButton.UseVisualStyleBackColor = true;
            this.privatRadioButton.CheckedChanged += new System.EventHandler(this.privatRadioButton_CheckedChanged);
            // 
            // accessPrivatePanel
            // 
            this.accessPrivatePanel.Controls.Add(this.infoPasswordLabel);
            this.accessPrivatePanel.Controls.Add(this.confirmPasswordTextBox);
            this.accessPrivatePanel.Controls.Add(this.passwordTextBox);
            this.accessPrivatePanel.Controls.Add(this.label6);
            this.accessPrivatePanel.Controls.Add(this.label5);
            this.accessPrivatePanel.Location = new System.Drawing.Point(413, 132);
            this.accessPrivatePanel.Name = "accessPrivatePanel";
            this.accessPrivatePanel.Size = new System.Drawing.Size(185, 125);
            this.accessPrivatePanel.TabIndex = 9;
            this.accessPrivatePanel.Visible = false;
            // 
            // infoPasswordLabel
            // 
            this.infoPasswordLabel.AutoSize = true;
            this.infoPasswordLabel.Location = new System.Drawing.Point(20, 102);
            this.infoPasswordLabel.Name = "infoPasswordLabel";
            this.infoPasswordLabel.Size = new System.Drawing.Size(0, 13);
            this.infoPasswordLabel.TabIndex = 13;
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(13, 70);
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(150, 20);
            this.confirmPasswordTextBox.TabIndex = 12;
            this.confirmPasswordTextBox.TextChanged += new System.EventHandler(this.confirmPasswordTextBox_TextChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(13, 31);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(150, 20);
            this.passwordTextBox.TabIndex = 10;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(10, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Підтвердження пароля:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Пароль:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Вид складу:";
            // 
            // chooseTypeOfStock
            // 
            this.chooseTypeOfStock.FormattingEnabled = true;
            this.chooseTypeOfStock.Items.AddRange(new object[] {
            "Функціональний склад",
            "Фізичний склад"});
            this.chooseTypeOfStock.Location = new System.Drawing.Point(24, 158);
            this.chooseTypeOfStock.Name = "chooseTypeOfStock";
            this.chooseTypeOfStock.Size = new System.Drawing.Size(121, 21);
            this.chooseTypeOfStock.TabIndex = 11;
            this.chooseTypeOfStock.SelectedIndexChanged += new System.EventHandler(this.chooseTypeOfStock_SelectedIndexChanged);
            // 
            // importantTextPanel
            // 
            this.importantTextPanel.Controls.Add(this.infoStockLabel);
            this.importantTextPanel.Controls.Add(this.label8);
            this.importantTextPanel.Location = new System.Drawing.Point(24, 195);
            this.importantTextPanel.Name = "importantTextPanel";
            this.importantTextPanel.Size = new System.Drawing.Size(298, 65);
            this.importantTextPanel.TabIndex = 12;
            this.importantTextPanel.Visible = false;
            // 
            // infoStockLabel
            // 
            this.infoStockLabel.AutoSize = true;
            this.infoStockLabel.Location = new System.Drawing.Point(17, 27);
            this.infoStockLabel.Name = "infoStockLabel";
            this.infoStockLabel.Size = new System.Drawing.Size(64, 13);
            this.infoStockLabel.TabIndex = 13;
            this.infoStockLabel.Text = "Тип складу";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(110, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Важливо!!!";
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Location = new System.Drawing.Point(22, 305);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(102, 30);
            this.addButton.TabIndex = 13;
            this.addButton.Text = "Створити";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // denyButton
            // 
            this.denyButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.denyButton.FlatAppearance.BorderSize = 0;
            this.denyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.denyButton.Location = new System.Drawing.Point(130, 305);
            this.denyButton.Name = "denyButton";
            this.denyButton.Size = new System.Drawing.Size(102, 30);
            this.denyButton.TabIndex = 14;
            this.denyButton.Text = "Відмінити";
            this.denyButton.UseVisualStyleBackColor = false;
            this.denyButton.Click += new System.EventHandler(this.denyButton_Click);
            // 
            // AddNewStockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(623, 347);
            this.Controls.Add(this.denyButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.importantTextPanel);
            this.Controls.Add(this.chooseTypeOfStock);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.accessPrivatePanel);
            this.Controls.Add(this.privatRadioButton);
            this.Controls.Add(this.publicRadioButton);
            this.Controls.Add(this.nameOfStock);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddNewStockForm";
            this.Text = "AddNewStockForm";
            this.Load += new System.EventHandler(this.AddNewStockForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.accessPrivatePanel.ResumeLayout(false);
            this.accessPrivatePanel.PerformLayout();
            this.importantTextPanel.ResumeLayout(false);
            this.importantTextPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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