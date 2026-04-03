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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.passwordLogInBox = new System.Windows.Forms.TextBox();
            this.userNameLogInBox = new System.Windows.Forms.TextBox();
            this.userNameLogInLabel = new System.Windows.Forms.Label();
            this.passwordLogInLabel = new System.Windows.Forms.Label();
            this.LogInButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.passwordSingUpBox = new System.Windows.Forms.TextBox();
            this.userNameSingUpBox = new System.Windows.Forms.TextBox();
            this.userNameSingUpLabell = new System.Windows.Forms.Label();
            this.passwordSingUpLabell = new System.Windows.Forms.Label();
            this.SingUpButton = new System.Windows.Forms.Button();
            this.passwordConfirmSingUpBox = new System.Windows.Forms.TextBox();
            this.passwordConfirmSingUpLabel = new System.Windows.Forms.Label();
            this.ORLabel = new System.Windows.Forms.Label();
            this.LogInLabel = new System.Windows.Forms.Label();
            this.SingUpLabel = new System.Windows.Forms.Label();
            this.accountLabel = new System.Windows.Forms.Label();
            this.userNameShowlabel = new System.Windows.Forms.Label();
            this.exitFromAccountButton = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1012, 30);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveForm);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "StockMaster";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveForm);
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
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage3.Controls.Add(this.exitFromAccountButton);
            this.tabPage3.Controls.Add(this.userNameShowlabel);
            this.tabPage3.Controls.Add(this.accountLabel);
            this.tabPage3.Controls.Add(this.SingUpLabel);
            this.tabPage3.Controls.Add(this.LogInLabel);
            this.tabPage3.Controls.Add(this.ORLabel);
            this.tabPage3.Controls.Add(this.panel4);
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1004, 477);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Log in/Sing up";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.LogInButton);
            this.panel3.Controls.Add(this.passwordLogInLabel);
            this.panel3.Controls.Add(this.userNameLogInLabel);
            this.panel3.Controls.Add(this.userNameLogInBox);
            this.panel3.Controls.Add(this.passwordLogInBox);
            this.panel3.Location = new System.Drawing.Point(69, 82);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(308, 266);
            this.panel3.TabIndex = 2;
            // 
            // passwordLogInBox
            // 
            this.passwordLogInBox.Location = new System.Drawing.Point(37, 138);
            this.passwordLogInBox.Name = "passwordLogInBox";
            this.passwordLogInBox.Size = new System.Drawing.Size(178, 20);
            this.passwordLogInBox.TabIndex = 1;
            // 
            // userNameLogInBox
            // 
            this.userNameLogInBox.Location = new System.Drawing.Point(37, 58);
            this.userNameLogInBox.Name = "userNameLogInBox";
            this.userNameLogInBox.Size = new System.Drawing.Size(178, 20);
            this.userNameLogInBox.TabIndex = 0;
            // 
            // userNameLogInLabel
            // 
            this.userNameLogInLabel.AutoSize = true;
            this.userNameLogInLabel.Location = new System.Drawing.Point(34, 42);
            this.userNameLogInLabel.Name = "userNameLogInLabel";
            this.userNameLogInLabel.Size = new System.Drawing.Size(58, 13);
            this.userNameLogInLabel.TabIndex = 2;
            this.userNameLogInLabel.Text = "Username:";
            // 
            // passwordLogInLabel
            // 
            this.passwordLogInLabel.AutoSize = true;
            this.passwordLogInLabel.Location = new System.Drawing.Point(34, 122);
            this.passwordLogInLabel.Name = "passwordLogInLabel";
            this.passwordLogInLabel.Size = new System.Drawing.Size(56, 13);
            this.passwordLogInLabel.TabIndex = 3;
            this.passwordLogInLabel.Text = "Password:";
            // 
            // LogInButton
            // 
            this.LogInButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.LogInButton.FlatAppearance.BorderSize = 0;
            this.LogInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogInButton.Location = new System.Drawing.Point(37, 219);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(233, 31);
            this.LogInButton.TabIndex = 4;
            this.LogInButton.Text = "Log In";
            this.LogInButton.UseVisualStyleBackColor = false;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.passwordConfirmSingUpLabel);
            this.panel4.Controls.Add(this.passwordConfirmSingUpBox);
            this.panel4.Controls.Add(this.SingUpButton);
            this.panel4.Controls.Add(this.passwordSingUpLabell);
            this.panel4.Controls.Add(this.userNameSingUpLabell);
            this.panel4.Controls.Add(this.userNameSingUpBox);
            this.panel4.Controls.Add(this.passwordSingUpBox);
            this.panel4.Location = new System.Drawing.Point(610, 82);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(308, 294);
            this.panel4.TabIndex = 5;
            // 
            // passwordSingUpBox
            // 
            this.passwordSingUpBox.Location = new System.Drawing.Point(37, 116);
            this.passwordSingUpBox.Name = "passwordSingUpBox";
            this.passwordSingUpBox.Size = new System.Drawing.Size(178, 20);
            this.passwordSingUpBox.TabIndex = 1;
            // 
            // userNameSingUpBox
            // 
            this.userNameSingUpBox.Location = new System.Drawing.Point(37, 58);
            this.userNameSingUpBox.Name = "userNameSingUpBox";
            this.userNameSingUpBox.Size = new System.Drawing.Size(178, 20);
            this.userNameSingUpBox.TabIndex = 0;
            // 
            // userNameSingUpLabell
            // 
            this.userNameSingUpLabell.AutoSize = true;
            this.userNameSingUpLabell.Location = new System.Drawing.Point(34, 42);
            this.userNameSingUpLabell.Name = "userNameSingUpLabell";
            this.userNameSingUpLabell.Size = new System.Drawing.Size(58, 13);
            this.userNameSingUpLabell.TabIndex = 2;
            this.userNameSingUpLabell.Text = "Username:";
            // 
            // passwordSingUpLabell
            // 
            this.passwordSingUpLabell.AutoSize = true;
            this.passwordSingUpLabell.Location = new System.Drawing.Point(34, 100);
            this.passwordSingUpLabell.Name = "passwordSingUpLabell";
            this.passwordSingUpLabell.Size = new System.Drawing.Size(56, 13);
            this.passwordSingUpLabell.TabIndex = 3;
            this.passwordSingUpLabell.Text = "Password:";
            // 
            // SingUpButton
            // 
            this.SingUpButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SingUpButton.FlatAppearance.BorderSize = 0;
            this.SingUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SingUpButton.Location = new System.Drawing.Point(37, 249);
            this.SingUpButton.Name = "SingUpButton";
            this.SingUpButton.Size = new System.Drawing.Size(233, 31);
            this.SingUpButton.TabIndex = 4;
            this.SingUpButton.Text = "Sing up";
            this.SingUpButton.UseVisualStyleBackColor = false;
            this.SingUpButton.Click += new System.EventHandler(this.SingUpButton_Click);
            // 
            // passwordConfirmSingUpBox
            // 
            this.passwordConfirmSingUpBox.Location = new System.Drawing.Point(37, 177);
            this.passwordConfirmSingUpBox.Name = "passwordConfirmSingUpBox";
            this.passwordConfirmSingUpBox.Size = new System.Drawing.Size(178, 20);
            this.passwordConfirmSingUpBox.TabIndex = 5;
            // 
            // passwordConfirmSingUpLabel
            // 
            this.passwordConfirmSingUpLabel.AutoSize = true;
            this.passwordConfirmSingUpLabel.Location = new System.Drawing.Point(34, 161);
            this.passwordConfirmSingUpLabel.Name = "passwordConfirmSingUpLabel";
            this.passwordConfirmSingUpLabel.Size = new System.Drawing.Size(93, 13);
            this.passwordConfirmSingUpLabel.TabIndex = 6;
            this.passwordConfirmSingUpLabel.Text = "Password confirm:";
            // 
            // ORLabel
            // 
            this.ORLabel.AutoSize = true;
            this.ORLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ORLabel.Location = new System.Drawing.Point(458, 199);
            this.ORLabel.Name = "ORLabel";
            this.ORLabel.Size = new System.Drawing.Size(74, 42);
            this.ORLabel.TabIndex = 6;
            this.ORLabel.Text = "OR";
            // 
            // LogInLabel
            // 
            this.LogInLabel.AutoSize = true;
            this.LogInLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogInLabel.Location = new System.Drawing.Point(65, 59);
            this.LogInLabel.Name = "LogInLabel";
            this.LogInLabel.Size = new System.Drawing.Size(52, 20);
            this.LogInLabel.TabIndex = 7;
            this.LogInLabel.Text = "Log in";
            // 
            // SingUpLabel
            // 
            this.SingUpLabel.AutoSize = true;
            this.SingUpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SingUpLabel.Location = new System.Drawing.Point(606, 59);
            this.SingUpLabel.Name = "SingUpLabel";
            this.SingUpLabel.Size = new System.Drawing.Size(66, 20);
            this.SingUpLabel.TabIndex = 8;
            this.SingUpLabel.Text = "Sing Up";
            // 
            // accountLabel
            // 
            this.accountLabel.AutoSize = true;
            this.accountLabel.Location = new System.Drawing.Point(909, 8);
            this.accountLabel.Name = "accountLabel";
            this.accountLabel.Size = new System.Drawing.Size(50, 13);
            this.accountLabel.TabIndex = 9;
            this.accountLabel.Text = "Account:";
            // 
            // userNameShowlabel
            // 
            this.userNameShowlabel.AutoSize = true;
            this.userNameShowlabel.Location = new System.Drawing.Point(965, 8);
            this.userNameShowlabel.Name = "userNameShowlabel";
            this.userNameShowlabel.Size = new System.Drawing.Size(31, 13);
            this.userNameShowlabel.TabIndex = 10;
            this.userNameShowlabel.Text = "none";
            // 
            // exitFromAccountButton
            // 
            this.exitFromAccountButton.Location = new System.Drawing.Point(912, 24);
            this.exitFromAccountButton.Name = "exitFromAccountButton";
            this.exitFromAccountButton.Size = new System.Drawing.Size(84, 22);
            this.exitFromAccountButton.TabIndex = 11;
            this.exitFromAccountButton.Text = "Exit";
            this.exitFromAccountButton.UseVisualStyleBackColor = true;
            this.exitFromAccountButton.Click += new System.EventHandler(this.exitFromAccountButton_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.flowLayoutPanel1);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1004, 477);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Stocks";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Controls.Add(this.addButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 410);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(998, 64);
            this.panel2.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.GhostWhite;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Location = new System.Drawing.Point(20, 18);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(102, 30);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Добавити";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1012, 503);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(20);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(998, 401);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1012, 533);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

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
    }
}

