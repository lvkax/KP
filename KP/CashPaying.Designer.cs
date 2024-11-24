namespace KP
{
    partial class CashPaying
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
            this.lbGived = new System.Windows.Forms.Label();
            this.tbGived = new System.Windows.Forms.TextBox();
            this.tbCashPaying = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbRest = new System.Windows.Forms.TextBox();
            this.lbRest = new System.Windows.Forms.Label();
            this.lbCashReceived = new System.Windows.Forms.Label();
            this.btnCashYes = new System.Windows.Forms.Button();
            this.btnCashNo = new System.Windows.Forms.Button();
            this.btnCashCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbGived
            // 
            this.lbGived.AutoSize = true;
            this.lbGived.Location = new System.Drawing.Point(16, 42);
            this.lbGived.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGived.Name = "lbGived";
            this.lbGived.Size = new System.Drawing.Size(79, 16);
            this.lbGived.TabIndex = 0;
            this.lbGived.Text = "Клієнт дав:";
            // 
            // tbGived
            // 
            this.tbGived.Location = new System.Drawing.Point(145, 38);
            this.tbGived.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbGived.Name = "tbGived";
            this.tbGived.Size = new System.Drawing.Size(132, 22);
            this.tbGived.TabIndex = 1;
            this.tbGived.Text = "0";
            this.tbGived.TextChanged += new System.EventHandler(this.tbGived_TextChanged);
            // 
            // tbCashPaying
            // 
            this.tbCashPaying.Location = new System.Drawing.Point(145, 6);
            this.tbCashPaying.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCashPaying.Name = "tbCashPaying";
            this.tbCashPaying.ReadOnly = true;
            this.tbCashPaying.Size = new System.Drawing.Size(132, 22);
            this.tbCashPaying.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "До сплати:";
            // 
            // tbRest
            // 
            this.tbRest.Location = new System.Drawing.Point(145, 70);
            this.tbRest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbRest.Name = "tbRest";
            this.tbRest.ReadOnly = true;
            this.tbRest.Size = new System.Drawing.Size(132, 22);
            this.tbRest.TabIndex = 5;
            // 
            // lbRest
            // 
            this.lbRest.AutoSize = true;
            this.lbRest.Location = new System.Drawing.Point(16, 74);
            this.lbRest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRest.Name = "lbRest";
            this.lbRest.Size = new System.Drawing.Size(101, 16);
            this.lbRest.TabIndex = 4;
            this.lbRest.Text = "Решти видати:";
            // 
            // lbCashReceived
            // 
            this.lbCashReceived.AutoSize = true;
            this.lbCashReceived.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCashReceived.Location = new System.Drawing.Point(16, 110);
            this.lbCashReceived.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCashReceived.Name = "lbCashReceived";
            this.lbCashReceived.Size = new System.Drawing.Size(232, 20);
            this.lbCashReceived.TabIndex = 6;
            this.lbCashReceived.Text = "Товар сплачений успішно?";
            // 
            // btnCashYes
            // 
            this.btnCashYes.BackColor = System.Drawing.Color.GreenYellow;
            this.btnCashYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCashYes.Location = new System.Drawing.Point(16, 149);
            this.btnCashYes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCashYes.Name = "btnCashYes";
            this.btnCashYes.Size = new System.Drawing.Size(100, 28);
            this.btnCashYes.TabIndex = 7;
            this.btnCashYes.Text = "Так";
            this.btnCashYes.UseVisualStyleBackColor = false;
            this.btnCashYes.Click += new System.EventHandler(this.btnCashYes_Click);
            // 
            // btnCashNo
            // 
            this.btnCashNo.BackColor = System.Drawing.Color.Salmon;
            this.btnCashNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCashNo.Location = new System.Drawing.Point(124, 149);
            this.btnCashNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCashNo.Name = "btnCashNo";
            this.btnCashNo.Size = new System.Drawing.Size(100, 28);
            this.btnCashNo.TabIndex = 8;
            this.btnCashNo.Text = "Ні";
            this.btnCashNo.UseVisualStyleBackColor = false;
            this.btnCashNo.Click += new System.EventHandler(this.btnCashNo_Click);
            // 
            // btnCashCancel
            // 
            this.btnCashCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCashCancel.Location = new System.Drawing.Point(232, 149);
            this.btnCashCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCashCancel.Name = "btnCashCancel";
            this.btnCashCancel.Size = new System.Drawing.Size(116, 28);
            this.btnCashCancel.TabIndex = 9;
            this.btnCashCancel.Text = "Скасувати";
            this.btnCashCancel.UseVisualStyleBackColor = true;
            this.btnCashCancel.Click += new System.EventHandler(this.btnCashCancel_Click_1);
            // 
            // CashPaying
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 192);
            this.Controls.Add(this.btnCashCancel);
            this.Controls.Add(this.btnCashNo);
            this.Controls.Add(this.btnCashYes);
            this.Controls.Add(this.lbCashReceived);
            this.Controls.Add(this.tbRest);
            this.Controls.Add(this.lbRest);
            this.Controls.Add(this.tbCashPaying);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbGived);
            this.Controls.Add(this.lbGived);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CashPaying";
            this.Text = "CashPaying";
            this.Load += new System.EventHandler(this.CashPaying_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbGived;
        private System.Windows.Forms.TextBox tbGived;
        private System.Windows.Forms.TextBox tbCashPaying;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbRest;
        private System.Windows.Forms.Label lbRest;
        private System.Windows.Forms.Label lbCashReceived;
        private System.Windows.Forms.Button btnCashYes;
        private System.Windows.Forms.Button btnCashNo;
        private System.Windows.Forms.Button btnCashCancel;
    }
}