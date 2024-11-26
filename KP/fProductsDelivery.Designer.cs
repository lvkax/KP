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
            ((System.ComponentModel.ISupportInitialize)(this.gvDelivery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrDelivery)).BeginInit();
            this.SuspendLayout();
            // 
            // gvDelivery
            // 
            this.gvDelivery.AutoGenerateColumns = false;
            this.gvDelivery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDelivery.DataSource = this.bindSrDelivery;
            this.gvDelivery.Location = new System.Drawing.Point(12, 12);
            this.gvDelivery.Name = "gvDelivery";
            this.gvDelivery.Size = new System.Drawing.Size(323, 352);
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
            // fProductsDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(451, 376);
            this.Controls.Add(this.btnDeliver);
            this.Controls.Add(this.gvDelivery);
            this.Name = "fProductsDelivery";
            this.Text = "Поставка продуктів";
            this.Load += new System.EventHandler(this.fProductsDelivery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvDelivery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrDelivery)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvDelivery;
        private System.Windows.Forms.BindingSource bindSrDelivery;
        private System.Windows.Forms.Button btnDeliver;
    }
}