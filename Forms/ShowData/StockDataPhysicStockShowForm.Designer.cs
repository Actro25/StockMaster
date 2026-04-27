namespace StockMaster.Forms.ShowData
{
    partial class StockDataPhysicStockShowForm
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
            flowLayoutPanelStockInfo = new System.Windows.Forms.FlowLayoutPanel();
            flowLayoutPanelId = new System.Windows.Forms.FlowLayoutPanel();
            flowLayoutPanelNameOfGood = new System.Windows.Forms.FlowLayoutPanel();
            flowLayoutPanelQuantity = new System.Windows.Forms.FlowLayoutPanel();
            quantityUpperLabel = new System.Windows.Forms.Label();
            nameOfGoodsUpperLabel = new System.Windows.Forms.Label();
            idUpperLabel = new System.Windows.Forms.Label();
            clearShearchButton = new System.Windows.Forms.Button();
            searchDataButton = new System.Windows.Forms.Button();
            searchByComboBox = new System.Windows.Forms.ComboBox();
            inputDataTextBox = new System.Windows.Forms.TextBox();
            button1 = new System.Windows.Forms.Button();
            deleteDataButton = new System.Windows.Forms.Button();
            updateDataButton = new System.Windows.Forms.Button();
            addDataButton = new System.Windows.Forms.Button();
            numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            addQuantityButton = new System.Windows.Forms.Button();
            minusQuantityButton = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            stockAccess = new System.Windows.Forms.Label();
            nameStockLabel = new System.Windows.Forms.Label();
            nameOfStockLabel = new System.Windows.Forms.Label();
            accessStock = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            flowLayoutPanelStockInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // closeFormButton
            // 
            closeFormButton.Dock = System.Windows.Forms.DockStyle.Right;
            closeFormButton.FlatAppearance.BorderSize = 0;
            closeFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            closeFormButton.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            closeFormButton.Location = new System.Drawing.Point(707, 0);
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
            panel1.Size = new System.Drawing.Size(736, 35);
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
            // flowLayoutPanelStockInfo
            // 
            flowLayoutPanelStockInfo.AutoScroll = true;
            flowLayoutPanelStockInfo.Controls.Add(flowLayoutPanelId);
            flowLayoutPanelStockInfo.Controls.Add(flowLayoutPanelNameOfGood);
            flowLayoutPanelStockInfo.Controls.Add(flowLayoutPanelQuantity);
            flowLayoutPanelStockInfo.Location = new System.Drawing.Point(12, 141);
            flowLayoutPanelStockInfo.Name = "flowLayoutPanelStockInfo";
            flowLayoutPanelStockInfo.Size = new System.Drawing.Size(532, 252);
            flowLayoutPanelStockInfo.TabIndex = 5;
            // 
            // flowLayoutPanelId
            // 
            flowLayoutPanelId.AutoSize = true;
            flowLayoutPanelId.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flowLayoutPanelId.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            flowLayoutPanelId.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanelId.Location = new System.Drawing.Point(3, 3);
            flowLayoutPanelId.MaximumSize = new System.Drawing.Size(66, 0);
            flowLayoutPanelId.MinimumSize = new System.Drawing.Size(66, 245);
            flowLayoutPanelId.Name = "flowLayoutPanelId";
            flowLayoutPanelId.Size = new System.Drawing.Size(66, 245);
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
            flowLayoutPanelNameOfGood.MinimumSize = new System.Drawing.Size(350, 245);
            flowLayoutPanelNameOfGood.Name = "flowLayoutPanelNameOfGood";
            flowLayoutPanelNameOfGood.Size = new System.Drawing.Size(350, 245);
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
            flowLayoutPanelQuantity.MinimumSize = new System.Drawing.Size(80, 245);
            flowLayoutPanelQuantity.Name = "flowLayoutPanelQuantity";
            flowLayoutPanelQuantity.Size = new System.Drawing.Size(80, 245);
            flowLayoutPanelQuantity.TabIndex = 2;
            flowLayoutPanelQuantity.WrapContents = false;
            // 
            // quantityUpperLabel
            // 
            quantityUpperLabel.AutoSize = true;
            quantityUpperLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            quantityUpperLabel.Location = new System.Drawing.Point(443, 105);
            quantityUpperLabel.Name = "quantityUpperLabel";
            quantityUpperLabel.Size = new System.Drawing.Size(77, 21);
            quantityUpperLabel.TabIndex = 18;
            quantityUpperLabel.Tag = "false";
            quantityUpperLabel.Text = "Quantity";
            // 
            // nameOfGoodsUpperLabel
            // 
            nameOfGoodsUpperLabel.AutoSize = true;
            nameOfGoodsUpperLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            nameOfGoodsUpperLabel.Location = new System.Drawing.Point(87, 105);
            nameOfGoodsUpperLabel.Name = "nameOfGoodsUpperLabel";
            nameOfGoodsUpperLabel.Size = new System.Drawing.Size(120, 21);
            nameOfGoodsUpperLabel.TabIndex = 17;
            nameOfGoodsUpperLabel.Tag = "false";
            nameOfGoodsUpperLabel.Text = "Name of good";
            // 
            // idUpperLabel
            // 
            idUpperLabel.AutoSize = true;
            idUpperLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            idUpperLabel.Location = new System.Drawing.Point(15, 105);
            idUpperLabel.Name = "idUpperLabel";
            idUpperLabel.Size = new System.Drawing.Size(25, 21);
            idUpperLabel.TabIndex = 16;
            idUpperLabel.Tag = "false";
            idUpperLabel.Text = "Id";
            // 
            // clearShearchButton
            // 
            clearShearchButton.Location = new System.Drawing.Point(423, 82);
            clearShearchButton.Name = "clearShearchButton";
            clearShearchButton.Size = new System.Drawing.Size(121, 23);
            clearShearchButton.TabIndex = 24;
            clearShearchButton.Text = "Clear search";
            clearShearchButton.UseVisualStyleBackColor = true;
            // 
            // searchDataButton
            // 
            searchDataButton.Location = new System.Drawing.Point(337, 82);
            searchDataButton.Name = "searchDataButton";
            searchDataButton.Size = new System.Drawing.Size(80, 23);
            searchDataButton.TabIndex = 23;
            searchDataButton.Text = "Search";
            searchDataButton.UseVisualStyleBackColor = true;
            // 
            // searchByComboBox
            // 
            searchByComboBox.FormattingEnabled = true;
            searchByComboBox.Items.AddRange(new object[] { "Id", "Name", "Quantity", "Date", "Price" });
            searchByComboBox.Location = new System.Drawing.Point(423, 53);
            searchByComboBox.Name = "searchByComboBox";
            searchByComboBox.Size = new System.Drawing.Size(121, 23);
            searchByComboBox.TabIndex = 22;
            searchByComboBox.Text = "Search by";
            // 
            // inputDataTextBox
            // 
            inputDataTextBox.Location = new System.Drawing.Point(21, 53);
            inputDataTextBox.Name = "inputDataTextBox";
            inputDataTextBox.Size = new System.Drawing.Size(396, 23);
            inputDataTextBox.TabIndex = 21;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.IndianRed;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            button1.Location = new System.Drawing.Point(550, 354);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(174, 37);
            button1.TabIndex = 25;
            button1.Text = "Main menu";
            button1.UseVisualStyleBackColor = false;
            // 
            // deleteDataButton
            // 
            deleteDataButton.Location = new System.Drawing.Point(550, 284);
            deleteDataButton.Name = "deleteDataButton";
            deleteDataButton.Size = new System.Drawing.Size(174, 38);
            deleteDataButton.TabIndex = 28;
            deleteDataButton.Text = "Delete data";
            deleteDataButton.UseVisualStyleBackColor = true;
            // 
            // updateDataButton
            // 
            updateDataButton.Location = new System.Drawing.Point(550, 238);
            updateDataButton.Name = "updateDataButton";
            updateDataButton.Size = new System.Drawing.Size(174, 38);
            updateDataButton.TabIndex = 27;
            updateDataButton.Text = "Update data";
            updateDataButton.UseVisualStyleBackColor = true;
            // 
            // addDataButton
            // 
            addDataButton.Location = new System.Drawing.Point(550, 194);
            addDataButton.Name = "addDataButton";
            addDataButton.Size = new System.Drawing.Size(174, 38);
            addDataButton.TabIndex = 26;
            addDataButton.Text = "Add data";
            addDataButton.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new System.Drawing.Point(550, 159);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new System.Drawing.Size(114, 23);
            numericUpDown1.TabIndex = 29;
            // 
            // addQuantityButton
            // 
            addQuantityButton.Location = new System.Drawing.Point(670, 159);
            addQuantityButton.Name = "addQuantityButton";
            addQuantityButton.Size = new System.Drawing.Size(23, 23);
            addQuantityButton.TabIndex = 30;
            addQuantityButton.Text = "+";
            addQuantityButton.UseVisualStyleBackColor = true;
            // 
            // minusQuantityButton
            // 
            minusQuantityButton.Location = new System.Drawing.Point(699, 159);
            minusQuantityButton.Name = "minusQuantityButton";
            minusQuantityButton.Size = new System.Drawing.Size(23, 23);
            minusQuantityButton.TabIndex = 31;
            minusQuantityButton.Text = "-";
            minusQuantityButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(550, 141);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(93, 15);
            label2.TabIndex = 32;
            label2.Text = "Quantity to add:";
            // 
            // stockAccess
            // 
            stockAccess.AutoSize = true;
            stockAccess.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            stockAccess.Location = new System.Drawing.Point(550, 68);
            stockAccess.Name = "stockAccess";
            stockAccess.Size = new System.Drawing.Size(44, 13);
            stockAccess.TabIndex = 34;
            stockAccess.Text = "Access:";
            // 
            // nameStockLabel
            // 
            nameStockLabel.AutoSize = true;
            nameStockLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nameStockLabel.Location = new System.Drawing.Point(550, 51);
            nameStockLabel.Name = "nameStockLabel";
            nameStockLabel.Size = new System.Drawing.Size(83, 17);
            nameStockLabel.TabIndex = 33;
            nameStockLabel.Text = "Stock name:";
            // 
            // nameOfStockLabel
            // 
            nameOfStockLabel.AutoSize = true;
            nameOfStockLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            nameOfStockLabel.Location = new System.Drawing.Point(630, 51);
            nameOfStockLabel.Name = "nameOfStockLabel";
            nameOfStockLabel.Size = new System.Drawing.Size(0, 17);
            nameOfStockLabel.TabIndex = 35;
            // 
            // accessStock
            // 
            accessStock.AutoSize = true;
            accessStock.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            accessStock.Location = new System.Drawing.Point(589, 68);
            accessStock.Name = "accessStock";
            accessStock.Size = new System.Drawing.Size(0, 13);
            accessStock.TabIndex = 36;
            // 
            // StockDataPhysicStockShowForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(736, 405);
            Controls.Add(accessStock);
            Controls.Add(nameOfStockLabel);
            Controls.Add(stockAccess);
            Controls.Add(nameStockLabel);
            Controls.Add(label2);
            Controls.Add(minusQuantityButton);
            Controls.Add(addQuantityButton);
            Controls.Add(numericUpDown1);
            Controls.Add(deleteDataButton);
            Controls.Add(updateDataButton);
            Controls.Add(addDataButton);
            Controls.Add(button1);
            Controls.Add(clearShearchButton);
            Controls.Add(searchDataButton);
            Controls.Add(searchByComboBox);
            Controls.Add(inputDataTextBox);
            Controls.Add(quantityUpperLabel);
            Controls.Add(nameOfGoodsUpperLabel);
            Controls.Add(idUpperLabel);
            Controls.Add(flowLayoutPanelStockInfo);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "StockDataPhysicStockShowForm";
            Text = "StockDataPhysicStockShowForm";
            Load += StockDataPhysicStockShowForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanelStockInfo.ResumeLayout(false);
            flowLayoutPanelStockInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button closeFormButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelStockInfo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelId;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelNameOfGood;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelQuantity;
        private System.Windows.Forms.Label quantityUpperLabel;
        private System.Windows.Forms.Label nameOfGoodsUpperLabel;
        private System.Windows.Forms.Label idUpperLabel;
        private System.Windows.Forms.Button clearShearchButton;
        private System.Windows.Forms.Button searchDataButton;
        private System.Windows.Forms.ComboBox searchByComboBox;
        private System.Windows.Forms.TextBox inputDataTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button deleteDataButton;
        private System.Windows.Forms.Button updateDataButton;
        private System.Windows.Forms.Button addDataButton;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button addQuantityButton;
        private System.Windows.Forms.Button minusQuantityButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label stockAccess;
        private System.Windows.Forms.Label nameStockLabel;
        private System.Windows.Forms.Label nameOfStockLabel;
        private System.Windows.Forms.Label accessStock;
    }
}