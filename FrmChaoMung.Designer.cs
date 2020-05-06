namespace Chuong4_part1_vidu
{
    partial class FrmChaoMung
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
            this.txtTen = new System.Windows.Forms.TextBox();
            this.lable2 = new System.Windows.Forms.Label();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ten";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(206, 49);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(162, 30);
            this.txtTen.TabIndex = 1;
            // 
            // lable2
            // 
            this.lable2.AutoSize = true;
            this.lable2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lable2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable2.Location = new System.Drawing.Point(34, 136);
            this.lable2.Name = "lable2";
            this.lable2.Size = new System.Drawing.Size(45, 25);
            this.lable2.TabIndex = 2;
            this.lable2.Text = "Lop";
            // 
            // txtLop
            // 
            this.txtLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLop.Location = new System.Drawing.Point(206, 136);
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(160, 30);
            this.txtLop.TabIndex = 3;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(37, 220);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(143, 36);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // FrmChaoMung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(730, 349);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtLop);
            this.Controls.Add(this.lable2);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.label1);
            this.Name = "FrmChaoMung";
            this.Text = "FrmChaoMung";
            this.Load += new System.EventHandler(this.FrmChaoMung_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label lable2;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.Button btnSubmit;
    }
}