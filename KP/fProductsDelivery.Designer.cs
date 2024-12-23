﻿namespace KP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fProductsDelivery));
            this.gvDelivery = new System.Windows.Forms.DataGridView();
            this.btnDeliver = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAddNewProduct = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnDeliveryOK = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDeliverySave = new System.Windows.Forms.ToolStripButton();
            this.btnOpenSavedDelivery = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.gvDelivery)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvDelivery
            // 
            this.gvDelivery.AllowUserToAddRows = false;
            this.gvDelivery.AllowUserToDeleteRows = false;
            this.gvDelivery.BackgroundColor = System.Drawing.Color.White;
            this.gvDelivery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDelivery.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.gvDelivery.Location = new System.Drawing.Point(0, 28);
            this.gvDelivery.Name = "gvDelivery";
            this.gvDelivery.Size = new System.Drawing.Size(333, 337);
            this.gvDelivery.TabIndex = 0;
            // 
            // btnDeliver
            // 
            this.btnDeliver.Location = new System.Drawing.Point(339, 341);
            this.btnDeliver.Name = "btnDeliver";
            this.btnDeliver.Size = new System.Drawing.Size(100, 23);
            this.btnDeliver.TabIndex = 1;
            this.btnDeliver.Text = "Поставити";
            this.btnDeliver.UseVisualStyleBackColor = true;
            this.btnDeliver.Click += new System.EventHandler(this.btnDeliver_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddNewProduct,
            this.btnEdit,
            this.btnDelete,
            this.btnDeliveryOK,
            this.toolStripSeparator1,
            this.btnDeliverySave,
            this.btnOpenSavedDelivery});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(451, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAddNewProduct
            // 
            this.btnAddNewProduct.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddNewProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewProduct.Image")));
            this.btnAddNewProduct.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddNewProduct.Name = "btnAddNewProduct";
            this.btnAddNewProduct.Size = new System.Drawing.Size(23, 22);
            this.btnAddNewProduct.Text = "Новий запакований продукт";
            this.btnAddNewProduct.ToolTipText = "Новий продукт";
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
            // btnDeliveryOK
            // 
            this.btnDeliveryOK.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDeliveryOK.Image = ((System.Drawing.Image)(resources.GetObject("btnDeliveryOK.Image")));
            this.btnDeliveryOK.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeliveryOK.Name = "btnDeliveryOK";
            this.btnDeliveryOK.Size = new System.Drawing.Size(23, 22);
            this.btnDeliveryOK.Text = "Ok";
            this.btnDeliveryOK.Click += new System.EventHandler(this.btnDeliveryOK_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnDeliverySave
            // 
            this.btnDeliverySave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDeliverySave.Image = ((System.Drawing.Image)(resources.GetObject("btnDeliverySave.Image")));
            this.btnDeliverySave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeliverySave.Name = "btnDeliverySave";
            this.btnDeliverySave.Size = new System.Drawing.Size(23, 22);
            this.btnDeliverySave.Text = "Зберегти наявність";
            this.btnDeliverySave.Click += new System.EventHandler(this.btnDeliverySave_Click);
            // 
            // btnOpenSavedDelivery
            // 
            this.btnOpenSavedDelivery.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOpenSavedDelivery.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenSavedDelivery.Image")));
            this.btnOpenSavedDelivery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpenSavedDelivery.Name = "btnOpenSavedDelivery";
            this.btnOpenSavedDelivery.Size = new System.Drawing.Size(23, 22);
            this.btnOpenSavedDelivery.Text = "Відкрити збережену наявність";
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
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvDelivery;
        private System.Windows.Forms.Button btnDeliver;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAddNewProduct;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnDeliveryOK;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnDeliverySave;
        private System.Windows.Forms.ToolStripButton btnOpenSavedDelivery;
    }
}