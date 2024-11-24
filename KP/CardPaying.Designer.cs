namespace KP
{
    partial class CardPaying
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCardNo = new System.Windows.Forms.Button();
            this.btnCardYes = new System.Windows.Forms.Button();
            this.btnCardCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Товар сплачений успішно?";
            // 
            // btnCardNo
            // 
            this.btnCardNo.BackColor = System.Drawing.Color.Salmon;
            this.btnCardNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCardNo.Location = new System.Drawing.Point(137, 40);
            this.btnCardNo.Name = "btnCardNo";
            this.btnCardNo.Size = new System.Drawing.Size(92, 38);
            this.btnCardNo.TabIndex = 1;
            this.btnCardNo.Text = "Ні";
            this.btnCardNo.UseVisualStyleBackColor = false;
            this.btnCardNo.Click += new System.EventHandler(this.btnCardNo_Click);
            // 
            // btnCardYes
            // 
            this.btnCardYes.BackColor = System.Drawing.Color.GreenYellow;
            this.btnCardYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCardYes.Location = new System.Drawing.Point(12, 40);
            this.btnCardYes.Name = "btnCardYes";
            this.btnCardYes.Size = new System.Drawing.Size(92, 38);
            this.btnCardYes.TabIndex = 2;
            this.btnCardYes.Text = "Так";
            this.btnCardYes.UseVisualStyleBackColor = false;
            this.btnCardYes.Click += new System.EventHandler(this.btnCardYes_Click);
            // 
            // btnCardCancel
            // 
            this.btnCardCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCardCancel.Location = new System.Drawing.Point(15, 92);
            this.btnCardCancel.Name = "btnCardCancel";
            this.btnCardCancel.Size = new System.Drawing.Size(214, 23);
            this.btnCardCancel.TabIndex = 3;
            this.btnCardCancel.Text = "Скасувати";
            this.btnCardCancel.UseVisualStyleBackColor = true;
            this.btnCardCancel.Click += new System.EventHandler(this.btnCardCancel_Click);
            // 
            // CardPaying
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 127);
            this.Controls.Add(this.btnCardCancel);
            this.Controls.Add(this.btnCardYes);
            this.Controls.Add(this.btnCardNo);
            this.Controls.Add(this.label1);
            this.Name = "CardPaying";
            this.Text = "Оплата картою";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCardNo;
        private System.Windows.Forms.Button btnCardYes;
        private System.Windows.Forms.Button btnCardCancel;
    }
}