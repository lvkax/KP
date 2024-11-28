namespace KP
{
    partial class fMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.btnProducts = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.btnCardPaying = new System.Windows.Forms.Button();
            this.lbBag = new System.Windows.Forms.Label();
            this.tbTotalCost = new System.Windows.Forms.TextBox();
            this.lbPaying = new System.Windows.Forms.Label();
            this.gvCheck = new System.Windows.Forms.DataGridView();
            this.bindSrCheck = new System.Windows.Forms.BindingSource(this.components);
            this.tbID = new System.Windows.Forms.TextBox();
            this.tb = new System.Windows.Forms.TextBox();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.lbAmount = new System.Windows.Forms.Label();
            this.btnAddtoCheck = new System.Windows.Forms.Button();
            this.btnCashPaying = new System.Windows.Forms.Button();
            this.bindSrAvailable = new System.Windows.Forms.BindingSource(this.components);
            this.btnDiscount = new System.Windows.Forms.Button();
            this.tsMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrAvailable)).BeginInit();
            this.SuspendLayout();
            // 
            // tsMain
            // 
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnProducts,
            this.toolStripSeparator1,
            this.btnExit});
            this.tsMain.Location = new System.Drawing.Point(0, 0);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(734, 25);
            this.tsMain.TabIndex = 0;
            this.tsMain.Text = "toolStrip1";
            // 
            // btnProducts
            // 
            this.btnProducts.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnProducts.Image = ((System.Drawing.Image)(resources.GetObject("btnProducts.Image")));
            this.btnProducts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(23, 22);
            this.btnProducts.Text = "Переглянути наявність";
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnExit
            // 
            this.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(23, 22);
            this.btnExit.Text = "Завершити зміну";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCardPaying
            // 
            this.btnCardPaying.BackColor = System.Drawing.Color.GreenYellow;
            this.btnCardPaying.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCardPaying.Location = new System.Drawing.Point(506, 384);
            this.btnCardPaying.Name = "btnCardPaying";
            this.btnCardPaying.Size = new System.Drawing.Size(105, 35);
            this.btnCardPaying.TabIndex = 1;
            this.btnCardPaying.Text = "Карткою";
            this.btnCardPaying.UseVisualStyleBackColor = false;
            this.btnCardPaying.Click += new System.EventHandler(this.btnCardPaying_Click);
            // 
            // lbBag
            // 
            this.lbBag.AutoSize = true;
            this.lbBag.BackColor = System.Drawing.Color.Gold;
            this.lbBag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbBag.Location = new System.Drawing.Point(299, 28);
            this.lbBag.Name = "lbBag";
            this.lbBag.Size = new System.Drawing.Size(63, 16);
            this.lbBag.TabIndex = 2;
            this.lbBag.Text = "Корзина";
            // 
            // tbTotalCost
            // 
            this.tbTotalCost.Location = new System.Drawing.Point(617, 358);
            this.tbTotalCost.Name = "tbTotalCost";
            this.tbTotalCost.ReadOnly = true;
            this.tbTotalCost.Size = new System.Drawing.Size(105, 20);
            this.tbTotalCost.TabIndex = 3;
            // 
            // lbPaying
            // 
            this.lbPaying.AutoSize = true;
            this.lbPaying.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPaying.Location = new System.Drawing.Point(540, 359);
            this.lbPaying.Name = "lbPaying";
            this.lbPaying.Size = new System.Drawing.Size(71, 15);
            this.lbPaying.TabIndex = 5;
            this.lbPaying.Text = "До оплати:";
            // 
            // gvCheck
            // 
            this.gvCheck.AutoGenerateColumns = false;
            this.gvCheck.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gvCheck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCheck.DataSource = this.bindSrCheck;
            this.gvCheck.Location = new System.Drawing.Point(302, 47);
            this.gvCheck.Name = "gvCheck";
            this.gvCheck.ReadOnly = true;
            this.gvCheck.Size = new System.Drawing.Size(420, 305);
            this.gvCheck.TabIndex = 6;
            this.gvCheck.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gvCheck_RowsAdded);
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(41, 97);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(100, 20);
            this.tbID.TabIndex = 8;
            // 
            // tb
            // 
            this.tb.Location = new System.Drawing.Point(167, 97);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(100, 20);
            this.tb.TabIndex = 9;
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(167, 97);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(100, 20);
            this.tbAmount.TabIndex = 9;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(38, 81);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(18, 13);
            this.lbID.TabIndex = 10;
            this.lbID.Text = "ID";
            // 
            // lbAmount
            // 
            this.lbAmount.AutoSize = true;
            this.lbAmount.Location = new System.Drawing.Point(164, 81);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(53, 13);
            this.lbAmount.TabIndex = 11;
            this.lbAmount.Text = "Кількість";
            // 
            // btnAddtoCheck
            // 
            this.btnAddtoCheck.BackColor = System.Drawing.Color.GreenYellow;
            this.btnAddtoCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddtoCheck.Location = new System.Drawing.Point(134, 134);
            this.btnAddtoCheck.Name = "btnAddtoCheck";
            this.btnAddtoCheck.Size = new System.Drawing.Size(133, 23);
            this.btnAddtoCheck.TabIndex = 12;
            this.btnAddtoCheck.Text = "Додати в корзину";
            this.btnAddtoCheck.UseVisualStyleBackColor = false;
            this.btnAddtoCheck.Click += new System.EventHandler(this.btnAddtoCheck_Click);
            // 
            // btnCashPaying
            // 
            this.btnCashPaying.BackColor = System.Drawing.Color.GreenYellow;
            this.btnCashPaying.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCashPaying.Location = new System.Drawing.Point(617, 384);
            this.btnCashPaying.Name = "btnCashPaying";
            this.btnCashPaying.Size = new System.Drawing.Size(105, 35);
            this.btnCashPaying.TabIndex = 13;
            this.btnCashPaying.Text = "Готівкою";
            this.btnCashPaying.UseVisualStyleBackColor = false;
            this.btnCashPaying.Click += new System.EventHandler(this.btnCashPaying_Click);
            // 
            // btnDiscount
            // 
            this.btnDiscount.BackColor = System.Drawing.Color.GreenYellow;
            this.btnDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDiscount.Location = new System.Drawing.Point(134, 163);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(133, 23);
            this.btnDiscount.TabIndex = 14;
            this.btnDiscount.Text = "Додати знижку";
            this.btnDiscount.UseVisualStyleBackColor = false;
            this.btnDiscount.Click += new System.EventHandler(this.btnDiscount_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(734, 431);
            this.Controls.Add(this.btnDiscount);
            this.Controls.Add(this.btnCashPaying);
            this.Controls.Add(this.btnAddtoCheck);
            this.Controls.Add(this.lbAmount);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.gvCheck);
            this.Controls.Add(this.lbPaying);
            this.Controls.Add(this.tbTotalCost);
            this.Controls.Add(this.lbBag);
            this.Controls.Add(this.btnCardPaying);
            this.Controls.Add(this.tsMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Магазин";
            this.Load += new System.EventHandler(this.fMain_Load);
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrAvailable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripButton btnProducts;
        private System.Windows.Forms.Button btnCardPaying;
        private System.Windows.Forms.Label lbBag;
        private System.Windows.Forms.TextBox tbTotalCost;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label lbPaying;
        private System.Windows.Forms.DataGridView gvCheck;
        private System.Windows.Forms.BindingSource bindSrCheck;
        private System.Windows.Forms.BindingSource bindSrAvailable;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.Button btnAddtoCheck;
        private System.Windows.Forms.Button btnCashPaying;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.Button btnDiscount;
    }
}

