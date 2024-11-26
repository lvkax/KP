namespace KP
{
    partial class fAddProduct
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
            this.btnNewProductCancel = new System.Windows.Forms.Button();
            this.btnNewProduct = new System.Windows.Forms.Button();
            this.lbAddID = new System.Windows.Forms.Label();
            this.lbAddName = new System.Windows.Forms.Label();
            this.lbAddCost = new System.Windows.Forms.Label();
            this.lbWorP = new System.Windows.Forms.Label();
            this.tbAddID = new System.Windows.Forms.TextBox();
            this.tbAddName = new System.Windows.Forms.TextBox();
            this.tbAddCost = new System.Windows.Forms.TextBox();
            this.tbAddWorP = new System.Windows.Forms.TextBox();
            this.lbRecomended = new System.Windows.Forms.Label();
            this.tbAddPrice = new System.Windows.Forms.TextBox();
            this.lbAddPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNewProductCancel
            // 
            this.btnNewProductCancel.Location = new System.Drawing.Point(319, 191);
            this.btnNewProductCancel.Name = "btnNewProductCancel";
            this.btnNewProductCancel.Size = new System.Drawing.Size(64, 20);
            this.btnNewProductCancel.TabIndex = 0;
            this.btnNewProductCancel.Text = "Відмінити";
            this.btnNewProductCancel.UseVisualStyleBackColor = true;
            this.btnNewProductCancel.Click += new System.EventHandler(this.btnNewProductCancel_Click);
            // 
            // btnNewProduct
            // 
            this.btnNewProduct.Location = new System.Drawing.Point(402, 191);
            this.btnNewProduct.Name = "btnNewProduct";
            this.btnNewProduct.Size = new System.Drawing.Size(64, 20);
            this.btnNewProduct.TabIndex = 1;
            this.btnNewProduct.Text = "Додати";
            this.btnNewProduct.UseVisualStyleBackColor = true;
            this.btnNewProduct.Click += new System.EventHandler(this.btnNewProductOK_Click);
            // 
            // lbAddID
            // 
            this.lbAddID.AutoSize = true;
            this.lbAddID.Location = new System.Drawing.Point(12, 6);
            this.lbAddID.Name = "lbAddID";
            this.lbAddID.Size = new System.Drawing.Size(18, 13);
            this.lbAddID.TabIndex = 2;
            this.lbAddID.Text = "ID";
            // 
            // lbAddName
            // 
            this.lbAddName.AutoSize = true;
            this.lbAddName.Location = new System.Drawing.Point(12, 32);
            this.lbAddName.Name = "lbAddName";
            this.lbAddName.Size = new System.Drawing.Size(26, 13);
            this.lbAddName.TabIndex = 3;
            this.lbAddName.Text = "Ім\'я";
            // 
            // lbAddCost
            // 
            this.lbAddCost.AutoSize = true;
            this.lbAddCost.Location = new System.Drawing.Point(12, 58);
            this.lbAddCost.Name = "lbAddCost";
            this.lbAddCost.Size = new System.Drawing.Size(52, 13);
            this.lbAddCost.TabIndex = 4;
            this.lbAddCost.Text = "Ціна(грн)";
            // 
            // lbWorP
            // 
            this.lbWorP.AutoSize = true;
            this.lbWorP.Location = new System.Drawing.Point(12, 110);
            this.lbWorP.Name = "lbWorP";
            this.lbWorP.Size = new System.Drawing.Size(28, 13);
            this.lbWorP.TabIndex = 7;
            this.lbWorP.Text = "-------";
            // 
            // tbAddID
            // 
            this.tbAddID.Location = new System.Drawing.Point(158, 6);
            this.tbAddID.Name = "tbAddID";
            this.tbAddID.Size = new System.Drawing.Size(100, 20);
            this.tbAddID.TabIndex = 8;
            this.tbAddID.TextChanged += new System.EventHandler(this.tbAddID_TextChanged);
            // 
            // tbAddName
            // 
            this.tbAddName.Location = new System.Drawing.Point(158, 32);
            this.tbAddName.Name = "tbAddName";
            this.tbAddName.Size = new System.Drawing.Size(100, 20);
            this.tbAddName.TabIndex = 9;
            // 
            // tbAddCost
            // 
            this.tbAddCost.Location = new System.Drawing.Point(158, 58);
            this.tbAddCost.Name = "tbAddCost";
            this.tbAddCost.Size = new System.Drawing.Size(100, 20);
            this.tbAddCost.TabIndex = 10;
            // 
            // tbAddWorP
            // 
            this.tbAddWorP.Location = new System.Drawing.Point(158, 110);
            this.tbAddWorP.Name = "tbAddWorP";
            this.tbAddWorP.Size = new System.Drawing.Size(100, 20);
            this.tbAddWorP.TabIndex = 12;
            // 
            // lbRecomended
            // 
            this.lbRecomended.AutoSize = true;
            this.lbRecomended.Location = new System.Drawing.Point(264, 9);
            this.lbRecomended.Name = "lbRecomended";
            this.lbRecomended.Size = new System.Drawing.Size(88, 13);
            this.lbRecomended.TabIndex = 14;
            this.lbRecomended.Text = "Рекомендовано";
            // 
            // tbAddPrice
            // 
            this.tbAddPrice.Location = new System.Drawing.Point(158, 84);
            this.tbAddPrice.Name = "tbAddPrice";
            this.tbAddPrice.Size = new System.Drawing.Size(100, 20);
            this.tbAddPrice.TabIndex = 16;
            // 
            // lbAddPrice
            // 
            this.lbAddPrice.AutoSize = true;
            this.lbAddPrice.Location = new System.Drawing.Point(12, 84);
            this.lbAddPrice.Name = "lbAddPrice";
            this.lbAddPrice.Size = new System.Drawing.Size(121, 13);
            this.lbAddPrice.TabIndex = 15;
            this.lbAddPrice.Text = "Закупівельна ціна(грн)";
            // 
            // fAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 223);
            this.Controls.Add(this.tbAddPrice);
            this.Controls.Add(this.lbAddPrice);
            this.Controls.Add(this.lbRecomended);
            this.Controls.Add(this.tbAddWorP);
            this.Controls.Add(this.tbAddCost);
            this.Controls.Add(this.tbAddName);
            this.Controls.Add(this.tbAddID);
            this.Controls.Add(this.lbWorP);
            this.Controls.Add(this.lbAddCost);
            this.Controls.Add(this.lbAddName);
            this.Controls.Add(this.lbAddID);
            this.Controls.Add(this.btnNewProduct);
            this.Controls.Add(this.btnNewProductCancel);
            this.Name = "fAddProduct";
            this.Text = "Додати новий продукт";
            this.Load += new System.EventHandler(this.fAddProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewProductCancel;
        private System.Windows.Forms.Button btnNewProduct;
        private System.Windows.Forms.Label lbAddID;
        private System.Windows.Forms.Label lbAddName;
        private System.Windows.Forms.Label lbAddCost;
        private System.Windows.Forms.Label lbWorP;
        private System.Windows.Forms.TextBox tbAddID;
        private System.Windows.Forms.TextBox tbAddName;
        private System.Windows.Forms.TextBox tbAddCost;
        private System.Windows.Forms.TextBox tbAddWorP;
        private System.Windows.Forms.Label lbRecomended;
        private System.Windows.Forms.TextBox tbAddPrice;
        private System.Windows.Forms.Label lbAddPrice;
    }
}