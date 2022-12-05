namespace DoanQLKS
{
    partial class QLTHEXE
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
            this.txttiemkiem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnsuathexe = new System.Windows.Forms.Button();
            this.btnxoathexe = new System.Windows.Forms.Button();
            this.btnthemthexe = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtloaixe = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtsoxe = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Cbbmakhachhang = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Cbbphieugiuxe = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmathexe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txttiemkiem
            // 
            this.txttiemkiem.Location = new System.Drawing.Point(582, 391);
            this.txttiemkiem.Name = "txttiemkiem";
            this.txttiemkiem.Size = new System.Drawing.Size(182, 22);
            this.txttiemkiem.TabIndex = 10;
            this.txttiemkiem.TextChanged += new System.EventHandler(this.txttiemkiem_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(480, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tìm kiếm";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 419);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(759, 251);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Phiếu giữ xe";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(747, 219);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnsuathexe);
            this.groupBox2.Controls.Add(this.btnxoathexe);
            this.groupBox2.Controls.Add(this.btnthemthexe);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(406, 277);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 89);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnsuathexe
            // 
            this.btnsuathexe.Location = new System.Drawing.Point(245, 38);
            this.btnsuathexe.Name = "btnsuathexe";
            this.btnsuathexe.Size = new System.Drawing.Size(101, 31);
            this.btnsuathexe.TabIndex = 2;
            this.btnsuathexe.Text = "Sửa";
            this.btnsuathexe.UseVisualStyleBackColor = true;
            this.btnsuathexe.Click += new System.EventHandler(this.btnsuathexe_Click);
            // 
            // btnxoathexe
            // 
            this.btnxoathexe.Location = new System.Drawing.Point(131, 39);
            this.btnxoathexe.Name = "btnxoathexe";
            this.btnxoathexe.Size = new System.Drawing.Size(101, 30);
            this.btnxoathexe.TabIndex = 1;
            this.btnxoathexe.Text = "Xóa";
            this.btnxoathexe.UseVisualStyleBackColor = true;
            this.btnxoathexe.Click += new System.EventHandler(this.btnxoathexe_Click);
            // 
            // btnthemthexe
            // 
            this.btnthemthexe.Location = new System.Drawing.Point(16, 37);
            this.btnthemthexe.Name = "btnthemthexe";
            this.btnthemthexe.Size = new System.Drawing.Size(101, 30);
            this.btnthemthexe.TabIndex = 0;
            this.btnthemthexe.Text = "Thêm";
            this.btnthemthexe.UseVisualStyleBackColor = true;
            this.btnthemthexe.Click += new System.EventHandler(this.btnthemthexe_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtloaixe);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtsoxe);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Cbbmakhachhang);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Cbbphieugiuxe);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtmathexe);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(752, 235);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thẻ xe";
            // 
            // txtloaixe
            // 
            this.txtloaixe.Location = new System.Drawing.Point(525, 85);
            this.txtloaixe.Name = "txtloaixe";
            this.txtloaixe.Size = new System.Drawing.Size(182, 27);
            this.txtloaixe.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(423, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Loại xe";
            // 
            // txtsoxe
            // 
            this.txtsoxe.Location = new System.Drawing.Point(525, 39);
            this.txtsoxe.Name = "txtsoxe";
            this.txtsoxe.Size = new System.Drawing.Size(182, 27);
            this.txtsoxe.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(423, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Số xe";
            // 
            // Cbbmakhachhang
            // 
            this.Cbbmakhachhang.FormattingEnabled = true;
            this.Cbbmakhachhang.Location = new System.Drawing.Point(185, 131);
            this.Cbbmakhachhang.Name = "Cbbmakhachhang";
            this.Cbbmakhachhang.Size = new System.Drawing.Size(182, 28);
            this.Cbbmakhachhang.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mã khách hàng";
            // 
            // Cbbphieugiuxe
            // 
            this.Cbbphieugiuxe.FormattingEnabled = true;
            this.Cbbphieugiuxe.Location = new System.Drawing.Point(185, 82);
            this.Cbbphieugiuxe.Name = "Cbbphieugiuxe";
            this.Cbbphieugiuxe.Size = new System.Drawing.Size(182, 28);
            this.Cbbphieugiuxe.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã phiếu giữ xe";
            // 
            // txtmathexe
            // 
            this.txtmathexe.Location = new System.Drawing.Point(185, 36);
            this.txtmathexe.Name = "txtmathexe";
            this.txtmathexe.Size = new System.Drawing.Size(182, 27);
            this.txtmathexe.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã thẻ xe";
            // 
            // QLTHEXE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(135)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(846, 705);
            this.Controls.Add(this.txttiemkiem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "QLTHEXE";
            this.Text = "QLTHEXE";
            this.Load += new System.EventHandler(this.QLTHEXE_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txttiemkiem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnsuathexe;
        private System.Windows.Forms.Button btnxoathexe;
        private System.Windows.Forms.Button btnthemthexe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtmathexe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtloaixe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtsoxe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Cbbmakhachhang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Cbbphieugiuxe;
        private System.Windows.Forms.Label label2;
    }
}