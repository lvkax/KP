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
            this.bindSrStore = new System.Windows.Forms.BindingSource(this.components);
            this.gvStore = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnDelivery = new System.Windows.Forms.ToolStripButton();
            this.btnAddNewProduct = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnStoreOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStore)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvStore
            // 
            this.gvStore.AutoGenerateColumns = false;
            this.gvStore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvStore.DataSource = this.bindSrStore;
            this.gvStore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvStore.Location = new System.Drawing.Point(0, 0);
            this.gvStore.Name = "gvStore";
            this.gvStore.ReadOnly = true;
            this.gvStore.Size = new System.Drawing.Size(800, 450);
            this.gvStore.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDelivery,
            this.btnAddNewProduct,
            this.btnEdit,
            this.btnDelete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
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
            // btnAddNewProduct
            // 
            this.btnAddNewProduct.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddNewProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewProduct.Image")));
            this.btnAddNewProduct.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddNewProduct.Name = "btnAddNewProduct";
            this.btnAddNewProduct.Size = new System.Drawing.Size(23, 22);
            this.btnAddNewProduct.Text = "Додати новий продукт";
            this.btnAddNewProduct.Click += new System.EventHandler(this.btnAddNewProduct_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(23, 22);
            this.btnEdit.Text = "Змінити продукт";
            // 
            // btnDelete
            // 
            this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(23, 22);
            this.btnDelete.Text = "Видалити продукт";
            // 
            // btnStoreOK
            // 
            this.btnStoreOK.BackColor = System.Drawing.Color.GreenYellow;
            this.btnStoreOK.Location = new System.Drawing.Point(713, 415);
            this.btnStoreOK.Name = "btnStoreOK";
            this.btnStoreOK.Size = new System.Drawing.Size(75, 23);
            this.btnStoreOK.TabIndex = 2;
            this.btnStoreOK.Text = "OK";
            this.btnStoreOK.UseVisualStyleBackColor = false;
            // 
            // fProductsInStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStoreOK);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gvStore);
            this.Name = "fProductsInStock";
            this.Text = "Продукти в наявності";
            ((System.ComponentModel.ISupportInitialize)(this.bindSrStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStore)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindSrStore;
        private System.Windows.Forms.DataGridView gvStore;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnDelivery;
        private System.Windows.Forms.ToolStripButton btnAddNewProduct;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.Button btnStoreOK;
    }
}