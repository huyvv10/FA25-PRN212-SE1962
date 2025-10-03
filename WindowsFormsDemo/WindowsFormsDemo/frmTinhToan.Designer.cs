namespace WindowsFormsDemo
{
    partial class frmTinhToan
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnSubstract = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnQuotien = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnStd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Result";
            // 
            // txtA
            // 
            this.txtA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.Location = new System.Drawing.Point(239, 47);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(350, 34);
            this.txtA.TabIndex = 2;
            // 
            // txtB
            // 
            this.txtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB.Location = new System.Drawing.Point(239, 100);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(350, 34);
            this.txtB.TabIndex = 2;
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(239, 164);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(350, 34);
            this.txtResult.TabIndex = 2;
            // 
            // btnSum
            // 
            this.btnSum.BackColor = System.Drawing.Color.Yellow;
            this.btnSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSum.ForeColor = System.Drawing.Color.Blue;
            this.btnSum.Location = new System.Drawing.Point(71, 255);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(140, 45);
            this.btnSum.TabIndex = 3;
            this.btnSum.Text = "&Sum";
            this.btnSum.UseVisualStyleBackColor = false;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnSubstract
            // 
            this.btnSubstract.BackColor = System.Drawing.Color.Yellow;
            this.btnSubstract.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubstract.ForeColor = System.Drawing.Color.Blue;
            this.btnSubstract.Location = new System.Drawing.Point(256, 255);
            this.btnSubstract.Name = "btnSubstract";
            this.btnSubstract.Size = new System.Drawing.Size(140, 46);
            this.btnSubstract.TabIndex = 4;
            this.btnSubstract.Text = "Su&bstract";
            this.btnSubstract.UseVisualStyleBackColor = false;
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.Yellow;
            this.btnProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.ForeColor = System.Drawing.Color.Blue;
            this.btnProduct.Location = new System.Drawing.Point(441, 254);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(140, 46);
            this.btnProduct.TabIndex = 4;
            this.btnProduct.Text = "&Product";
            this.btnProduct.UseVisualStyleBackColor = false;
            // 
            // btnQuotien
            // 
            this.btnQuotien.BackColor = System.Drawing.Color.Yellow;
            this.btnQuotien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuotien.ForeColor = System.Drawing.Color.Blue;
            this.btnQuotien.Location = new System.Drawing.Point(626, 254);
            this.btnQuotien.Name = "btnQuotien";
            this.btnQuotien.Size = new System.Drawing.Size(140, 46);
            this.btnQuotien.TabIndex = 4;
            this.btnQuotien.Text = "&Quotien";
            this.btnQuotien.UseVisualStyleBackColor = false;
            this.btnQuotien.Click += new System.EventHandler(this.btnQuotien_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Yellow;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Blue;
            this.btnClose.Location = new System.Drawing.Point(626, 47);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(140, 46);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnStd
            // 
            this.btnStd.Location = new System.Drawing.Point(630, 125);
            this.btnStd.Name = "btnStd";
            this.btnStd.Size = new System.Drawing.Size(135, 44);
            this.btnStd.TabIndex = 5;
            this.btnStd.Text = "Call Student";
            this.btnStd.UseVisualStyleBackColor = true;
            this.btnStd.Click += new System.EventHandler(this.btnStd_Click);
            // 
            // frmTinhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(809, 347);
            this.Controls.Add(this.btnStd);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnQuotien);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.btnSubstract);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTinhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tinh Toan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnSubstract;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnQuotien;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnStd;
    }
}