namespace StockMaster
{
    partial class StockDataShowForm
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
            flowLayoutPanelStockInfo = new System.Windows.Forms.FlowLayoutPanel();
            flowLayoutPanelId = new System.Windows.Forms.FlowLayoutPanel();
            flowLayoutPanelNameOfGood = new System.Windows.Forms.FlowLayoutPanel();
            flowLayoutPanelQuantity = new System.Windows.Forms.FlowLayoutPanel();
            flowLayoutPanelDateOfArrival = new System.Windows.Forms.FlowLayoutPanel();
            flowLayoutPanelPrice = new System.Windows.Forms.FlowLayoutPanel();
            addDataButton = new System.Windows.Forms.Button();
            moreInformationButton = new System.Windows.Forms.Button();
            changeDataButton = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            button5 = new System.Windows.Forms.Button();
            deleteDataButton = new System.Windows.Forms.Button();
            inputDataTextBox = new System.Windows.Forms.TextBox();
            searchByComboBox = new System.Windows.Forms.ComboBox();
            searchDataButton = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            flowLayoutPanelStockInfo.SuspendLayout();
            SuspendLayout();
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
            panel1.Size = new System.Drawing.Size(933, 35);
            panel1.TabIndex = 2;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // closeFormButton
            // 
            closeFormButton.Dock = System.Windows.Forms.DockStyle.Right;
            closeFormButton.FlatAppearance.BorderSize = 0;
            closeFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            closeFormButton.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            closeFormButton.Location = new System.Drawing.Point(904, 0);
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
            label1.Size = new System.Drawing.Size(77, 21);
            label1.TabIndex = 1;
            label1.Text = "StockData";
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
            // flowLayoutPanelStockInfo
            // 
            flowLayoutPanelStockInfo.AutoScroll = true;
            flowLayoutPanelStockInfo.Controls.Add(flowLayoutPanelId);
            flowLayoutPanelStockInfo.Controls.Add(flowLayoutPanelNameOfGood);
            flowLayoutPanelStockInfo.Controls.Add(flowLayoutPanelQuantity);
            flowLayoutPanelStockInfo.Controls.Add(flowLayoutPanelDateOfArrival);
            flowLayoutPanelStockInfo.Controls.Add(flowLayoutPanelPrice);
            flowLayoutPanelStockInfo.Location = new System.Drawing.Point(12, 155);
            flowLayoutPanelStockInfo.Name = "flowLayoutPanelStockInfo";
            flowLayoutPanelStockInfo.Size = new System.Drawing.Size(756, 352);
            flowLayoutPanelStockInfo.TabIndex = 3;
            // 
            // flowLayoutPanelId
            // 
            flowLayoutPanelId.AutoSize = true;
            flowLayoutPanelId.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flowLayoutPanelId.BackColor = System.Drawing.Color.LightSkyBlue;
            flowLayoutPanelId.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanelId.Location = new System.Drawing.Point(3, 3);
            flowLayoutPanelId.MaximumSize = new System.Drawing.Size(66, 0);
            flowLayoutPanelId.MinimumSize = new System.Drawing.Size(66, 345);
            flowLayoutPanelId.Name = "flowLayoutPanelId";
            flowLayoutPanelId.Size = new System.Drawing.Size(66, 345);
            flowLayoutPanelId.TabIndex = 0;
            flowLayoutPanelId.WrapContents = false;
            // 
            // flowLayoutPanelNameOfGood
            // 
            flowLayoutPanelNameOfGood.AutoSize = true;
            flowLayoutPanelNameOfGood.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flowLayoutPanelNameOfGood.BackColor = System.Drawing.Color.RoyalBlue;
            flowLayoutPanelNameOfGood.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanelNameOfGood.Location = new System.Drawing.Point(75, 3);
            flowLayoutPanelNameOfGood.MaximumSize = new System.Drawing.Size(365, 0);
            flowLayoutPanelNameOfGood.MinimumSize = new System.Drawing.Size(365, 345);
            flowLayoutPanelNameOfGood.Name = "flowLayoutPanelNameOfGood";
            flowLayoutPanelNameOfGood.Size = new System.Drawing.Size(365, 345);
            flowLayoutPanelNameOfGood.TabIndex = 1;
            flowLayoutPanelNameOfGood.WrapContents = false;
            // 
            // flowLayoutPanelQuantity
            // 
            flowLayoutPanelQuantity.AutoSize = true;
            flowLayoutPanelQuantity.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flowLayoutPanelQuantity.BackColor = System.Drawing.Color.LightSkyBlue;
            flowLayoutPanelQuantity.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanelQuantity.Location = new System.Drawing.Point(446, 3);
            flowLayoutPanelQuantity.MaximumSize = new System.Drawing.Size(80, 0);
            flowLayoutPanelQuantity.MinimumSize = new System.Drawing.Size(80, 345);
            flowLayoutPanelQuantity.Name = "flowLayoutPanelQuantity";
            flowLayoutPanelQuantity.Size = new System.Drawing.Size(80, 345);
            flowLayoutPanelQuantity.TabIndex = 2;
            flowLayoutPanelQuantity.WrapContents = false;
            // 
            // flowLayoutPanelDateOfArrival
            // 
            flowLayoutPanelDateOfArrival.AutoSize = true;
            flowLayoutPanelDateOfArrival.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flowLayoutPanelDateOfArrival.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanelDateOfArrival.Location = new System.Drawing.Point(532, 3);
            flowLayoutPanelDateOfArrival.MaximumSize = new System.Drawing.Size(125, 0);
            flowLayoutPanelDateOfArrival.MinimumSize = new System.Drawing.Size(125, 345);
            flowLayoutPanelDateOfArrival.Name = "flowLayoutPanelDateOfArrival";
            flowLayoutPanelDateOfArrival.Size = new System.Drawing.Size(125, 345);
            flowLayoutPanelDateOfArrival.TabIndex = 3;
            flowLayoutPanelDateOfArrival.WrapContents = false;
            // 
            // flowLayoutPanelPrice
            // 
            flowLayoutPanelPrice.AutoSize = true;
            flowLayoutPanelPrice.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flowLayoutPanelPrice.BackColor = System.Drawing.Color.LightSkyBlue;
            flowLayoutPanelPrice.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanelPrice.Location = new System.Drawing.Point(663, 3);
            flowLayoutPanelPrice.MaximumSize = new System.Drawing.Size(72, 0);
            flowLayoutPanelPrice.MinimumSize = new System.Drawing.Size(72, 345);
            flowLayoutPanelPrice.Name = "flowLayoutPanelPrice";
            flowLayoutPanelPrice.Size = new System.Drawing.Size(72, 345);
            flowLayoutPanelPrice.TabIndex = 4;
            flowLayoutPanelPrice.WrapContents = false;
            // 
            // addDataButton
            // 
            addDataButton.Location = new System.Drawing.Point(777, 111);
            addDataButton.Name = "addDataButton";
            addDataButton.Size = new System.Drawing.Size(144, 38);
            addDataButton.TabIndex = 4;
            addDataButton.Text = "Add";
            addDataButton.UseVisualStyleBackColor = true;
            addDataButton.Click += addDataButton_Click;
            // 
            // moreInformationButton
            // 
            moreInformationButton.Location = new System.Drawing.Point(777, 155);
            moreInformationButton.Name = "moreInformationButton";
            moreInformationButton.Size = new System.Drawing.Size(144, 38);
            moreInformationButton.TabIndex = 5;
            moreInformationButton.Text = "More information";
            moreInformationButton.UseVisualStyleBackColor = true;
            // 
            // changeDataButton
            // 
            changeDataButton.Location = new System.Drawing.Point(777, 199);
            changeDataButton.Name = "changeDataButton";
            changeDataButton.Size = new System.Drawing.Size(144, 38);
            changeDataButton.TabIndex = 6;
            changeDataButton.Text = "Change data";
            changeDataButton.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(777, 333);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(144, 38);
            button4.TabIndex = 9;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new System.Drawing.Point(777, 289);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(144, 38);
            button5.TabIndex = 8;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // deleteDataButton
            // 
            deleteDataButton.Location = new System.Drawing.Point(777, 245);
            deleteDataButton.Name = "deleteDataButton";
            deleteDataButton.Size = new System.Drawing.Size(144, 38);
            deleteDataButton.TabIndex = 7;
            deleteDataButton.Text = "Delete data";
            deleteDataButton.UseVisualStyleBackColor = true;
            // 
            // inputDataTextBox
            // 
            inputDataTextBox.Location = new System.Drawing.Point(12, 74);
            inputDataTextBox.Name = "inputDataTextBox";
            inputDataTextBox.Size = new System.Drawing.Size(388, 23);
            inputDataTextBox.TabIndex = 10;
            // 
            // searchByComboBox
            // 
            searchByComboBox.FormattingEnabled = true;
            searchByComboBox.Items.AddRange(new object[] { "Search by" });
            searchByComboBox.Location = new System.Drawing.Point(417, 74);
            searchByComboBox.Name = "searchByComboBox";
            searchByComboBox.Size = new System.Drawing.Size(121, 23);
            searchByComboBox.TabIndex = 11;
            // 
            // searchDataButton
            // 
            searchDataButton.Location = new System.Drawing.Point(556, 74);
            searchDataButton.Name = "searchDataButton";
            searchDataButton.Size = new System.Drawing.Size(109, 23);
            searchDataButton.TabIndex = 12;
            searchDataButton.Text = "Search";
            searchDataButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            label2.Location = new System.Drawing.Point(15, 118);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(25, 21);
            label2.TabIndex = 13;
            label2.Text = "Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            label3.Location = new System.Drawing.Point(87, 118);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(120, 21);
            label3.TabIndex = 14;
            label3.Text = "Name of good";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            label4.Location = new System.Drawing.Point(458, 118);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(77, 21);
            label4.TabIndex = 15;
            label4.Text = "Quantity";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            label5.Location = new System.Drawing.Point(544, 118);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(119, 21);
            label5.TabIndex = 16;
            label5.Text = "Date of arrival";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            label6.Location = new System.Drawing.Point(675, 118);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(48, 21);
            label6.TabIndex = 17;
            label6.Text = "Price";
            // 
            // StockDataShowForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(933, 519);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(searchDataButton);
            Controls.Add(searchByComboBox);
            Controls.Add(inputDataTextBox);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(deleteDataButton);
            Controls.Add(changeDataButton);
            Controls.Add(moreInformationButton);
            Controls.Add(addDataButton);
            Controls.Add(flowLayoutPanelStockInfo);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "StockDataShowForm";
            Text = "StockDataShowForm";
            Load += StockDataShowForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanelStockInfo.ResumeLayout(false);
            flowLayoutPanelStockInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button closeFormButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelStockInfo;
        private System.Windows.Forms.Button addDataButton;
        private System.Windows.Forms.Button moreInformationButton;
        private System.Windows.Forms.Button changeDataButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button deleteDataButton;
        private System.Windows.Forms.TextBox inputDataTextBox;
        private System.Windows.Forms.ComboBox searchByComboBox;
        private System.Windows.Forms.Button searchDataButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelId;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelNameOfGood;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelDateOfArrival;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPrice;
    }
}