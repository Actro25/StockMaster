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
            updateDataButton = new System.Windows.Forms.Button();
            overdueButton = new System.Windows.Forms.Button();
            arrivedButton = new System.Windows.Forms.Button();
            deleteDataButton = new System.Windows.Forms.Button();
            inputDataTextBox = new System.Windows.Forms.TextBox();
            searchByComboBox = new System.Windows.Forms.ComboBox();
            searchDataButton = new System.Windows.Forms.Button();
            idUpperLabel = new System.Windows.Forms.Label();
            nameOfGoodsUpperLabel = new System.Windows.Forms.Label();
            quantityUpperLabel = new System.Windows.Forms.Label();
            dataOfArrivalUpperLabel = new System.Windows.Forms.Label();
            priceUpperLabel = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            clearShearchButton = new System.Windows.Forms.Button();
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
            flowLayoutPanelId.BackColor = System.Drawing.SystemColors.ButtonHighlight;
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
            flowLayoutPanelNameOfGood.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            flowLayoutPanelNameOfGood.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanelNameOfGood.Location = new System.Drawing.Point(75, 3);
            flowLayoutPanelNameOfGood.MaximumSize = new System.Drawing.Size(365, 0);
            flowLayoutPanelNameOfGood.MinimumSize = new System.Drawing.Size(350, 345);
            flowLayoutPanelNameOfGood.Name = "flowLayoutPanelNameOfGood";
            flowLayoutPanelNameOfGood.Size = new System.Drawing.Size(350, 345);
            flowLayoutPanelNameOfGood.TabIndex = 1;
            flowLayoutPanelNameOfGood.WrapContents = false;
            // 
            // flowLayoutPanelQuantity
            // 
            flowLayoutPanelQuantity.AutoSize = true;
            flowLayoutPanelQuantity.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flowLayoutPanelQuantity.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            flowLayoutPanelQuantity.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanelQuantity.Location = new System.Drawing.Point(431, 3);
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
            flowLayoutPanelDateOfArrival.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            flowLayoutPanelDateOfArrival.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanelDateOfArrival.Location = new System.Drawing.Point(517, 3);
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
            flowLayoutPanelPrice.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            flowLayoutPanelPrice.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanelPrice.Location = new System.Drawing.Point(648, 3);
            flowLayoutPanelPrice.MaximumSize = new System.Drawing.Size(72, 0);
            flowLayoutPanelPrice.MinimumSize = new System.Drawing.Size(85, 345);
            flowLayoutPanelPrice.Name = "flowLayoutPanelPrice";
            flowLayoutPanelPrice.Size = new System.Drawing.Size(85, 345);
            flowLayoutPanelPrice.TabIndex = 4;
            flowLayoutPanelPrice.WrapContents = false;
            // 
            // addDataButton
            // 
            addDataButton.Location = new System.Drawing.Point(777, 154);
            addDataButton.Name = "addDataButton";
            addDataButton.Size = new System.Drawing.Size(144, 38);
            addDataButton.TabIndex = 4;
            addDataButton.Text = "Add data";
            addDataButton.UseVisualStyleBackColor = true;
            addDataButton.Click += addDataButton_Click;
            // 
            // updateDataButton
            // 
            updateDataButton.Location = new System.Drawing.Point(777, 198);
            updateDataButton.Name = "updateDataButton";
            updateDataButton.Size = new System.Drawing.Size(144, 38);
            updateDataButton.TabIndex = 6;
            updateDataButton.Text = "Update data";
            updateDataButton.UseVisualStyleBackColor = true;
            updateDataButton.Click += updateDataButton_Click;
            // 
            // overdueButton
            // 
            overdueButton.Location = new System.Drawing.Point(777, 332);
            overdueButton.Name = "overdueButton";
            overdueButton.Size = new System.Drawing.Size(144, 38);
            overdueButton.TabIndex = 9;
            overdueButton.Text = "Overdue";
            overdueButton.UseVisualStyleBackColor = true;
            overdueButton.Click += overdueButton_Click;
            // 
            // arrivedButton
            // 
            arrivedButton.Location = new System.Drawing.Point(777, 288);
            arrivedButton.Name = "arrivedButton";
            arrivedButton.Size = new System.Drawing.Size(144, 38);
            arrivedButton.TabIndex = 8;
            arrivedButton.Text = "Arrived";
            arrivedButton.UseVisualStyleBackColor = true;
            arrivedButton.Click += arrivedButton_Click;
            // 
            // deleteDataButton
            // 
            deleteDataButton.Location = new System.Drawing.Point(777, 244);
            deleteDataButton.Name = "deleteDataButton";
            deleteDataButton.Size = new System.Drawing.Size(144, 38);
            deleteDataButton.TabIndex = 7;
            deleteDataButton.Text = "Delete data";
            deleteDataButton.UseVisualStyleBackColor = true;
            deleteDataButton.Click += deleteDataButton_Click_1;
            // 
            // inputDataTextBox
            // 
            inputDataTextBox.Location = new System.Drawing.Point(12, 52);
            inputDataTextBox.Name = "inputDataTextBox";
            inputDataTextBox.Size = new System.Drawing.Size(396, 23);
            inputDataTextBox.TabIndex = 10;
            // 
            // searchByComboBox
            // 
            searchByComboBox.FormattingEnabled = true;
            searchByComboBox.Items.AddRange(new object[] { "Id", "Name", "Quantity", "Date", "Price" });
            searchByComboBox.Location = new System.Drawing.Point(417, 52);
            searchByComboBox.Name = "searchByComboBox";
            searchByComboBox.Size = new System.Drawing.Size(121, 23);
            searchByComboBox.TabIndex = 11;
            searchByComboBox.Text = "Search by";
            // 
            // searchDataButton
            // 
            searchDataButton.Location = new System.Drawing.Point(284, 81);
            searchDataButton.Name = "searchDataButton";
            searchDataButton.Size = new System.Drawing.Size(124, 34);
            searchDataButton.TabIndex = 12;
            searchDataButton.Text = "Search";
            searchDataButton.UseVisualStyleBackColor = true;
            searchDataButton.Click += searchDataButton_Click;
            // 
            // idUpperLabel
            // 
            idUpperLabel.AutoSize = true;
            idUpperLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            idUpperLabel.Location = new System.Drawing.Point(15, 118);
            idUpperLabel.Name = "idUpperLabel";
            idUpperLabel.Size = new System.Drawing.Size(25, 21);
            idUpperLabel.TabIndex = 13;
            idUpperLabel.Tag = "false";
            idUpperLabel.Text = "Id";
            idUpperLabel.Click += idUpperLabel_Click;
            // 
            // nameOfGoodsUpperLabel
            // 
            nameOfGoodsUpperLabel.AutoSize = true;
            nameOfGoodsUpperLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            nameOfGoodsUpperLabel.Location = new System.Drawing.Point(87, 118);
            nameOfGoodsUpperLabel.Name = "nameOfGoodsUpperLabel";
            nameOfGoodsUpperLabel.Size = new System.Drawing.Size(120, 21);
            nameOfGoodsUpperLabel.TabIndex = 14;
            nameOfGoodsUpperLabel.Tag = "false";
            nameOfGoodsUpperLabel.Text = "Name of good";
            nameOfGoodsUpperLabel.Click += nameOfGoodsUpperLabel_Click;
            // 
            // quantityUpperLabel
            // 
            quantityUpperLabel.AutoSize = true;
            quantityUpperLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            quantityUpperLabel.Location = new System.Drawing.Point(443, 118);
            quantityUpperLabel.Name = "quantityUpperLabel";
            quantityUpperLabel.Size = new System.Drawing.Size(77, 21);
            quantityUpperLabel.TabIndex = 15;
            quantityUpperLabel.Tag = "false";
            quantityUpperLabel.Text = "Quantity";
            quantityUpperLabel.Click += quantityUpperLabel_Click;
            // 
            // dataOfArrivalUpperLabel
            // 
            dataOfArrivalUpperLabel.AutoSize = true;
            dataOfArrivalUpperLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            dataOfArrivalUpperLabel.Location = new System.Drawing.Point(529, 118);
            dataOfArrivalUpperLabel.Name = "dataOfArrivalUpperLabel";
            dataOfArrivalUpperLabel.Size = new System.Drawing.Size(119, 21);
            dataOfArrivalUpperLabel.TabIndex = 16;
            dataOfArrivalUpperLabel.Tag = "false";
            dataOfArrivalUpperLabel.Text = "Date of arrival";
            dataOfArrivalUpperLabel.Click += dataOfArrivalUpperLabel_Click;
            // 
            // priceUpperLabel
            // 
            priceUpperLabel.AutoSize = true;
            priceUpperLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            priceUpperLabel.Location = new System.Drawing.Point(660, 118);
            priceUpperLabel.Name = "priceUpperLabel";
            priceUpperLabel.Size = new System.Drawing.Size(48, 21);
            priceUpperLabel.TabIndex = 17;
            priceUpperLabel.Tag = "false";
            priceUpperLabel.Text = "Price";
            priceUpperLabel.Click += priceUpperLabel_Click;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.IndianRed;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            button1.Location = new System.Drawing.Point(777, 469);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(144, 38);
            button1.TabIndex = 18;
            button1.Text = "Main menu";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(777, 377);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(144, 38);
            button2.TabIndex = 19;
            button2.Text = "Delete Arrived/Overdue";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // clearShearchButton
            // 
            clearShearchButton.Location = new System.Drawing.Point(414, 81);
            clearShearchButton.Name = "clearShearchButton";
            clearShearchButton.Size = new System.Drawing.Size(124, 34);
            clearShearchButton.TabIndex = 20;
            clearShearchButton.Text = "Clear search";
            clearShearchButton.UseVisualStyleBackColor = true;
            clearShearchButton.Click += clearShearchButton_Click;
            // 
            // StockDataShowForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(933, 519);
            Controls.Add(clearShearchButton);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(priceUpperLabel);
            Controls.Add(dataOfArrivalUpperLabel);
            Controls.Add(quantityUpperLabel);
            Controls.Add(nameOfGoodsUpperLabel);
            Controls.Add(idUpperLabel);
            Controls.Add(searchDataButton);
            Controls.Add(searchByComboBox);
            Controls.Add(inputDataTextBox);
            Controls.Add(overdueButton);
            Controls.Add(arrivedButton);
            Controls.Add(deleteDataButton);
            Controls.Add(updateDataButton);
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
        private System.Windows.Forms.Button updateDataButton;
        private System.Windows.Forms.Button overdueButton;
        private System.Windows.Forms.Button arrivedButton;
        private System.Windows.Forms.Button deleteDataButton;
        private System.Windows.Forms.TextBox inputDataTextBox;
        private System.Windows.Forms.ComboBox searchByComboBox;
        private System.Windows.Forms.Button searchDataButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelId;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelNameOfGood;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelQuantity;
        private System.Windows.Forms.Label idUpperLabel;
        private System.Windows.Forms.Label nameOfGoodsUpperLabel;
        private System.Windows.Forms.Label quantityUpperLabel;
        private System.Windows.Forms.Label dataOfArrivalUpperLabel;
        private System.Windows.Forms.Label priceUpperLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelDateOfArrival;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPrice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button clearShearchButton;
    }
}