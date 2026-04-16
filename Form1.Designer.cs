namespace StockMaster
{
    partial class Form1
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
            label1 = new System.Windows.Forms.Label();
            closeButton = new System.Windows.Forms.Button();
            tabPage3 = new System.Windows.Forms.TabPage();
            deleteButton = new System.Windows.Forms.Button();
            exitFromAccountButton = new System.Windows.Forms.Button();
            userNameShowlabel = new System.Windows.Forms.Label();
            accountLabel = new System.Windows.Forms.Label();
            SingUpLabel = new System.Windows.Forms.Label();
            LogInLabel = new System.Windows.Forms.Label();
            ORLabel = new System.Windows.Forms.Label();
            panel4 = new System.Windows.Forms.Panel();
            passwordConfirmSingUpLabel = new System.Windows.Forms.Label();
            passwordConfirmSingUpBox = new System.Windows.Forms.TextBox();
            SingUpButton = new System.Windows.Forms.Button();
            passwordSingUpLabell = new System.Windows.Forms.Label();
            userNameSingUpLabell = new System.Windows.Forms.Label();
            userNameSingUpBox = new System.Windows.Forms.TextBox();
            passwordSingUpBox = new System.Windows.Forms.TextBox();
            panel3 = new System.Windows.Forms.Panel();
            LogInButton = new System.Windows.Forms.Button();
            passwordLogInLabel = new System.Windows.Forms.Label();
            userNameLogInLabel = new System.Windows.Forms.Label();
            userNameLogInBox = new System.Windows.Forms.TextBox();
            passwordLogInBox = new System.Windows.Forms.TextBox();
            tabPage1 = new System.Windows.Forms.TabPage();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            panel2 = new System.Windows.Forms.Panel();
            addButton = new System.Windows.Forms.Button();
            tabControl1 = new System.Windows.Forms.TabControl();
            panel1.SuspendLayout();
            tabPage3.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            tabPage1.SuspendLayout();
            panel2.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
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
            panel1.Size = new System.Drawing.Size(1181, 35);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(4, 5);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(91, 21);
            label1.TabIndex = 1;
            label1.Text = "StockMaster";
            label1.MouseDown += panel1_MouseDown;
            // 
            // closeButton
            // 
            closeButton.Dock = System.Windows.Forms.DockStyle.Right;
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            closeButton.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            closeButton.Location = new System.Drawing.Point(1152, 0);
            closeButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            closeButton.Name = "closeButton";
            closeButton.Size = new System.Drawing.Size(29, 35);
            closeButton.TabIndex = 0;
            closeButton.Text = "X";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = System.Drawing.Color.WhiteSmoke;
            tabPage3.Controls.Add(deleteButton);
            tabPage3.Controls.Add(exitFromAccountButton);
            tabPage3.Controls.Add(userNameShowlabel);
            tabPage3.Controls.Add(accountLabel);
            tabPage3.Controls.Add(SingUpLabel);
            tabPage3.Controls.Add(LogInLabel);
            tabPage3.Controls.Add(ORLabel);
            tabPage3.Controls.Add(panel4);
            tabPage3.Controls.Add(panel3);
            tabPage3.Location = new System.Drawing.Point(4, 24);
            tabPage3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPage3.Size = new System.Drawing.Size(1173, 552);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Log in/Sing up";
            // 
            // deleteButton
            // 
            deleteButton.Location = new System.Drawing.Point(1064, 59);
            deleteButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new System.Drawing.Size(98, 25);
            deleteButton.TabIndex = 12;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // exitFromAccountButton
            // 
            exitFromAccountButton.Location = new System.Drawing.Point(1064, 28);
            exitFromAccountButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            exitFromAccountButton.Name = "exitFromAccountButton";
            exitFromAccountButton.Size = new System.Drawing.Size(98, 25);
            exitFromAccountButton.TabIndex = 11;
            exitFromAccountButton.Text = "Exit";
            exitFromAccountButton.UseVisualStyleBackColor = true;
            exitFromAccountButton.Click += exitFromAccountButton_Click;
            // 
            // userNameShowlabel
            // 
            userNameShowlabel.AutoSize = true;
            userNameShowlabel.Location = new System.Drawing.Point(1126, 9);
            userNameShowlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            userNameShowlabel.Name = "userNameShowlabel";
            userNameShowlabel.Size = new System.Drawing.Size(34, 15);
            userNameShowlabel.TabIndex = 10;
            userNameShowlabel.Text = "none";
            // 
            // accountLabel
            // 
            accountLabel.AutoSize = true;
            accountLabel.Location = new System.Drawing.Point(1060, 9);
            accountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            accountLabel.Name = "accountLabel";
            accountLabel.Size = new System.Drawing.Size(55, 15);
            accountLabel.TabIndex = 9;
            accountLabel.Text = "Account:";
            // 
            // SingUpLabel
            // 
            SingUpLabel.AutoSize = true;
            SingUpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            SingUpLabel.Location = new System.Drawing.Point(707, 68);
            SingUpLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            SingUpLabel.Name = "SingUpLabel";
            SingUpLabel.Size = new System.Drawing.Size(66, 20);
            SingUpLabel.TabIndex = 8;
            SingUpLabel.Text = "Sing Up";
            // 
            // LogInLabel
            // 
            LogInLabel.AutoSize = true;
            LogInLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            LogInLabel.Location = new System.Drawing.Point(76, 68);
            LogInLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LogInLabel.Name = "LogInLabel";
            LogInLabel.Size = new System.Drawing.Size(52, 20);
            LogInLabel.TabIndex = 7;
            LogInLabel.Text = "Log in";
            // 
            // ORLabel
            // 
            ORLabel.AutoSize = true;
            ORLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            ORLabel.Location = new System.Drawing.Point(534, 230);
            ORLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ORLabel.Name = "ORLabel";
            ORLabel.Size = new System.Drawing.Size(74, 42);
            ORLabel.TabIndex = 6;
            ORLabel.Text = "OR";
            // 
            // panel4
            // 
            panel4.BackColor = System.Drawing.SystemColors.Control;
            panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel4.Controls.Add(passwordConfirmSingUpLabel);
            panel4.Controls.Add(passwordConfirmSingUpBox);
            panel4.Controls.Add(SingUpButton);
            panel4.Controls.Add(passwordSingUpLabell);
            panel4.Controls.Add(userNameSingUpLabell);
            panel4.Controls.Add(userNameSingUpBox);
            panel4.Controls.Add(passwordSingUpBox);
            panel4.Location = new System.Drawing.Point(712, 95);
            panel4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(359, 339);
            panel4.TabIndex = 5;
            // 
            // passwordConfirmSingUpLabel
            // 
            passwordConfirmSingUpLabel.AutoSize = true;
            passwordConfirmSingUpLabel.Location = new System.Drawing.Point(40, 186);
            passwordConfirmSingUpLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            passwordConfirmSingUpLabel.Name = "passwordConfirmSingUpLabel";
            passwordConfirmSingUpLabel.Size = new System.Drawing.Size(105, 15);
            passwordConfirmSingUpLabel.TabIndex = 6;
            passwordConfirmSingUpLabel.Text = "Password confirm:";
            // 
            // passwordConfirmSingUpBox
            // 
            passwordConfirmSingUpBox.Location = new System.Drawing.Point(43, 204);
            passwordConfirmSingUpBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            passwordConfirmSingUpBox.Name = "passwordConfirmSingUpBox";
            passwordConfirmSingUpBox.Size = new System.Drawing.Size(207, 23);
            passwordConfirmSingUpBox.TabIndex = 5;
            // 
            // SingUpButton
            // 
            SingUpButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            SingUpButton.FlatAppearance.BorderSize = 0;
            SingUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            SingUpButton.Location = new System.Drawing.Point(43, 287);
            SingUpButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            SingUpButton.Name = "SingUpButton";
            SingUpButton.Size = new System.Drawing.Size(272, 36);
            SingUpButton.TabIndex = 4;
            SingUpButton.Text = "Sing up";
            SingUpButton.UseVisualStyleBackColor = false;
            SingUpButton.Click += SingUpButton_Click;
            // 
            // passwordSingUpLabell
            // 
            passwordSingUpLabell.AutoSize = true;
            passwordSingUpLabell.Location = new System.Drawing.Point(40, 115);
            passwordSingUpLabell.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            passwordSingUpLabell.Name = "passwordSingUpLabell";
            passwordSingUpLabell.Size = new System.Drawing.Size(60, 15);
            passwordSingUpLabell.TabIndex = 3;
            passwordSingUpLabell.Text = "Password:";
            // 
            // userNameSingUpLabell
            // 
            userNameSingUpLabell.AutoSize = true;
            userNameSingUpLabell.Location = new System.Drawing.Point(40, 48);
            userNameSingUpLabell.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            userNameSingUpLabell.Name = "userNameSingUpLabell";
            userNameSingUpLabell.Size = new System.Drawing.Size(63, 15);
            userNameSingUpLabell.TabIndex = 2;
            userNameSingUpLabell.Text = "Username:";
            // 
            // userNameSingUpBox
            // 
            userNameSingUpBox.Location = new System.Drawing.Point(43, 67);
            userNameSingUpBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            userNameSingUpBox.Name = "userNameSingUpBox";
            userNameSingUpBox.Size = new System.Drawing.Size(207, 23);
            userNameSingUpBox.TabIndex = 0;
            // 
            // passwordSingUpBox
            // 
            passwordSingUpBox.Location = new System.Drawing.Point(43, 134);
            passwordSingUpBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            passwordSingUpBox.Name = "passwordSingUpBox";
            passwordSingUpBox.Size = new System.Drawing.Size(207, 23);
            passwordSingUpBox.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.SystemColors.Control;
            panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel3.Controls.Add(LogInButton);
            panel3.Controls.Add(passwordLogInLabel);
            panel3.Controls.Add(userNameLogInLabel);
            panel3.Controls.Add(userNameLogInBox);
            panel3.Controls.Add(passwordLogInBox);
            panel3.Location = new System.Drawing.Point(80, 95);
            panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(359, 307);
            panel3.TabIndex = 2;
            // 
            // LogInButton
            // 
            LogInButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            LogInButton.FlatAppearance.BorderSize = 0;
            LogInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            LogInButton.Location = new System.Drawing.Point(43, 253);
            LogInButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            LogInButton.Name = "LogInButton";
            LogInButton.Size = new System.Drawing.Size(272, 36);
            LogInButton.TabIndex = 4;
            LogInButton.Text = "Log In";
            LogInButton.UseVisualStyleBackColor = false;
            LogInButton.Click += LogInButton_Click;
            // 
            // passwordLogInLabel
            // 
            passwordLogInLabel.AutoSize = true;
            passwordLogInLabel.Location = new System.Drawing.Point(40, 141);
            passwordLogInLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            passwordLogInLabel.Name = "passwordLogInLabel";
            passwordLogInLabel.Size = new System.Drawing.Size(60, 15);
            passwordLogInLabel.TabIndex = 3;
            passwordLogInLabel.Text = "Password:";
            // 
            // userNameLogInLabel
            // 
            userNameLogInLabel.AutoSize = true;
            userNameLogInLabel.Location = new System.Drawing.Point(40, 48);
            userNameLogInLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            userNameLogInLabel.Name = "userNameLogInLabel";
            userNameLogInLabel.Size = new System.Drawing.Size(63, 15);
            userNameLogInLabel.TabIndex = 2;
            userNameLogInLabel.Text = "Username:";
            // 
            // userNameLogInBox
            // 
            userNameLogInBox.Location = new System.Drawing.Point(43, 67);
            userNameLogInBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            userNameLogInBox.Name = "userNameLogInBox";
            userNameLogInBox.Size = new System.Drawing.Size(207, 23);
            userNameLogInBox.TabIndex = 0;
            // 
            // passwordLogInBox
            // 
            passwordLogInBox.Location = new System.Drawing.Point(43, 159);
            passwordLogInBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            passwordLogInBox.Name = "passwordLogInBox";
            passwordLogInBox.Size = new System.Drawing.Size(207, 23);
            passwordLogInBox.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            tabPage1.Controls.Add(flowLayoutPanel1);
            tabPage1.Controls.Add(panel2);
            tabPage1.Location = new System.Drawing.Point(4, 24);
            tabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPage1.Size = new System.Drawing.Size(1173, 552);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Stocks";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            flowLayoutPanel1.Location = new System.Drawing.Point(4, 3);
            flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(23);
            flowLayoutPanel1.Size = new System.Drawing.Size(1165, 463);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            panel2.Controls.Add(addButton);
            panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel2.Location = new System.Drawing.Point(4, 475);
            panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1165, 74);
            panel2.TabIndex = 0;
            // 
            // addButton
            // 
            addButton.BackColor = System.Drawing.Color.GhostWhite;
            addButton.FlatAppearance.BorderSize = 0;
            addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            addButton.Location = new System.Drawing.Point(23, 21);
            addButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            addButton.Name = "addButton";
            addButton.Size = new System.Drawing.Size(119, 35);
            addButton.TabIndex = 0;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl1.Location = new System.Drawing.Point(0, 35);
            tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(1181, 580);
            tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            tabControl1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ButtonFace;
            ClientSize = new System.Drawing.Size(1181, 615);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tabPage1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button exitFromAccountButton;
        private System.Windows.Forms.Label userNameShowlabel;
        private System.Windows.Forms.Label accountLabel;
        private System.Windows.Forms.Label SingUpLabel;
        private System.Windows.Forms.Label LogInLabel;
        private System.Windows.Forms.Label ORLabel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label passwordConfirmSingUpLabel;
        private System.Windows.Forms.TextBox passwordConfirmSingUpBox;
        private System.Windows.Forms.Button SingUpButton;
        private System.Windows.Forms.Label passwordSingUpLabell;
        private System.Windows.Forms.Label userNameSingUpLabell;
        private System.Windows.Forms.TextBox userNameSingUpBox;
        private System.Windows.Forms.TextBox passwordSingUpBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button LogInButton;
        private System.Windows.Forms.Label passwordLogInLabel;
        private System.Windows.Forms.Label userNameLogInLabel;
        private System.Windows.Forms.TextBox userNameLogInBox;
        private System.Windows.Forms.TextBox passwordLogInBox;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button deleteButton;
    }
}

