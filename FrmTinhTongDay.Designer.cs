namespace Chuong4_part1_vidu
{
    partial class FrmTinhTongDay
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
            this.txtA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.btTongDay = new System.Windows.Forms.Button();
            this.lbTongDay = new System.Windows.Forms.Label();
            this.btLamLai = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "A";
            // 
            // txtA
            // 
            this.txtA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.Location = new System.Drawing.Point(360, 17);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(120, 30);
            this.txtA.TabIndex = 1;
            this.txtA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtA_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "B";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtB
            // 
            this.txtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB.Location = new System.Drawing.Point(360, 111);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(120, 30);
            this.txtB.TabIndex = 3;
            this.txtB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtB_KeyPress);
            // 
            // btTongDay
            // 
            this.btTongDay.Location = new System.Drawing.Point(81, 206);
            this.btTongDay.Name = "btTongDay";
            this.btTongDay.Size = new System.Drawing.Size(93, 38);
            this.btTongDay.TabIndex = 4;
            this.btTongDay.Text = "TongDay";
            this.btTongDay.UseVisualStyleBackColor = true;
            this.btTongDay.Click += new System.EventHandler(this.btTongDay_Click);
            // 
            // lbTongDay
            // 
            this.lbTongDay.AutoSize = true;
            this.lbTongDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongDay.Location = new System.Drawing.Point(355, 210);
            this.lbTongDay.Name = "lbTongDay";
            this.lbTongDay.Size = new System.Drawing.Size(0, 25);
            this.lbTongDay.TabIndex = 5;
            // 
            // btLamLai
            // 
            this.btLamLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLamLai.Location = new System.Drawing.Point(81, 287);
            this.btLamLai.Name = "btLamLai";
            this.btLamLai.Size = new System.Drawing.Size(93, 46);
            this.btLamLai.TabIndex = 6;
            this.btLamLai.Text = "LamLai";
            this.btLamLai.UseVisualStyleBackColor = true;
            this.btLamLai.Click += new System.EventHandler(this.btLamLai_Click);
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Location = new System.Drawing.Point(360, 287);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(105, 46);
            this.btThoat.TabIndex = 7;
            this.btThoat.Text = "Thoat";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // FrmTinhTongDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btLamLai);
            this.Controls.Add(this.lbTongDay);
            this.Controls.Add(this.btTongDay);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label1);
            this.Name = "FrmTinhTongDay";
            this.Text = "FrmTinhTongDay";
            this.Load += new System.EventHandler(this.FrmTinhTongDay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button btTongDay;
        private System.Windows.Forms.Label lbTongDay;
        private System.Windows.Forms.Button btLamLai;
        private System.Windows.Forms.Button btThoat;
    }
}