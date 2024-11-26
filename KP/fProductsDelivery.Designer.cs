namespace KP
{
    partial class fProductsDelivery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fProductsDelivery));
            this.gvDelivery = new System.Windows.Forms.DataGridView();
            this.bindSrDelivery = new System.Windows.Forms.BindingSource(this.components);
            this.btnDeliver = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAddNewPacked = new System.Windows.Forms.ToolStripButton();
            this.btnAddNewWeighted = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.gvDelivery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrDelivery)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvDelivery
            // 
            this.gvDelivery.AutoGenerateColumns = false;
            this.gvDelivery.BackgroundColor = System.Drawing.Color.White;
            this.gvDelivery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDelivery.DataSource = this.bindSrDelivery;
            this.gvDelivery.Location = new System.Drawing.Point(0, 28);
            this.gvDelivery.Name = "gvDelivery";
            this.gvDelivery.Size = new System.Drawing.Size(351, 337);
            this.gvDelivery.TabIndex = 0;
            // 
            // btnDeliver
            // 
            this.btnDeliver.Location = new System.Drawing.Point(357, 341);
            this.btnDeliver.Name = "btnDeliver";
            this.btnDeliver.Size = new System.Drawing.Size(75, 23);
            this.btnDeliver.TabIndex = 1;
            this.btnDeliver.Text = "Поставити";
            this.btnDeliver.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddNewPacked,
            this.btnAddNewWeighted,
            this.btnEdit,
            this.btnDelete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(451, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAddNewPacked
            // 
            this.btnAddNewPacked.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddNewPacked.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewPacked.Image")));
            this.btnAddNewPacked.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddNewPacked.Name = "btnAddNewPacked";
            this.btnAddNewPacked.Size = new System.Drawing.Size(23, 22);
            this.btnAddNewPacked.Text = "Новий запакований продукт";
            this.btnAddNewPacked.Click += new System.EventHandler(this.btnAddNewPacked_Click);
            // 
            // btnAddNewWeighted
            // 
            this.btnAddNewWeighted.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddNewWeighted.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewWeighted.Image")));
            this.btnAddNewWeighted.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddNewWeighted.Name = "btnAddNewWeighted";
            this.btnAddNewWeighted.Size = new System.Drawing.Size(23, 22);
            this.btnAddNewWeighted.Text = "Новий продукт на вагу";
            this.btnAddNewWeighted.Click += new System.EventHandler(this.btnAddNewWeighted_Click);
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
            // fProductsDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(451, 376);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnDeliver);
            this.Controls.Add(this.gvDelivery);
            this.Name = "fProductsDelivery";
            this.Text = "Поставка продуктів";
            this.Load += new System.EventHandler(this.fProductsDelivery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvDelivery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrDelivery)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvDelivery;
        private System.Windows.Forms.BindingSource bindSrDelivery;
        private System.Windows.Forms.Button btnDeliver;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAddNewPacked;
        private System.Windows.Forms.ToolStripButton btnAddNewWeighted;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton btnDelete;
    }
}