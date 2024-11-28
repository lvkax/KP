namespace KP
{
    partial class fProductsInStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fProductsInStock));
            this.gvStore = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnDelivery = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnStoreOK = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnOpenSaved = new System.Windows.Forms.ToolStripButton();
            this.bindSrSrore = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gvStore)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrSrore)).BeginInit();
            this.SuspendLayout();
            // 
            // gvStore
            // 
            this.gvStore.AutoGenerateColumns = false;
            this.gvStore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvStore.DataSource = this.bindSrSrore;
            this.gvStore.Location = new System.Drawing.Point(0, 25);
            this.gvStore.Name = "gvStore";
            this.gvStore.ReadOnly = true;
            this.gvStore.Size = new System.Drawing.Size(862, 425);
            this.gvStore.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDelivery,
            this.toolStripSeparator1,
            this.btnStoreOK,
            this.toolStripSeparator2,
            this.btnSave,
            this.btnOpenSaved});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(862, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnDelivery
            // 
            this.btnDelivery.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelivery.Image = ((System.Drawing.Image)(resources.GetObject("btnDelivery.Image")));
            this.btnDelivery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelivery.Name = "btnDelivery";
            this.btnDelivery.Size = new System.Drawing.Size(23, 22);
            this.btnDelivery.Text = "Поставка продуктів";
            this.btnDelivery.Click += new System.EventHandler(this.btnDelivery_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnStoreOK
            // 
            this.btnStoreOK.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnStoreOK.Image = ((System.Drawing.Image)(resources.GetObject("btnStoreOK.Image")));
            this.btnStoreOK.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStoreOK.Name = "btnStoreOK";
            this.btnStoreOK.Size = new System.Drawing.Size(23, 22);
            this.btnStoreOK.Text = "Ok";
            this.btnStoreOK.Click += new System.EventHandler(this.btnStoreOK_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(23, 22);
            this.btnSave.Text = "Зберегти наявність";
            // 
            // btnOpenSaved
            // 
            this.btnOpenSaved.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOpenSaved.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenSaved.Image")));
            this.btnOpenSaved.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpenSaved.Name = "btnOpenSaved";
            this.btnOpenSaved.Size = new System.Drawing.Size(23, 22);
            this.btnOpenSaved.Text = "Відкрити збережену наявність";
            // 
            // fProductsInStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gvStore);
            this.Name = "fProductsInStock";
            this.Text = "Продукти в наявності";
            this.Load += new System.EventHandler(this.fProductsInStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvStore)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrSrore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView gvStore;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnDelivery;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnOpenSaved;
        private System.Windows.Forms.ToolStripButton btnStoreOK;
        private System.Windows.Forms.BindingSource bindSrSrore;
    }
}