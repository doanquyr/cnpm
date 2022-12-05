namespace DoanQLKS
{
    partial class QLDICHVU
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
            this.CbbLDV = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnthemkh = new System.Windows.Forms.Button();
            this.txtTIMKIEMDICHVU = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridViewDICHVU = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDONVITINH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaLoaiDV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDONGIA = new System.Windows.Forms.TextBox();
            this.txtiddichvu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txttendichvu = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDICHVU)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // CbbLDV
            // 
            this.CbbLDV.FormattingEnabled = true;
            this.CbbLDV.Items.AddRange(new object[] {
            "Gym",
            "Giải trí",
            "Ăn uống",
            "Dịch vụ "});
            this.CbbLDV.Location = new System.Drawing.Point(582, 35);
            this.CbbLDV.Name = "CbbLDV";
            this.CbbLDV.Size = new System.Drawing.Size(162, 28);
            this.CbbLDV.TabIndex = 46;
            this.CbbLDV.SelectedIndexChanged += new System.EventHandler(this.CbbLDV_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(216, 26);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 31);
            this.button3.TabIndex = 44;
            this.button3.Text = "Sửa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnsuadichvu_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(111, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 31);
            this.button2.TabIndex = 43;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnxoadichvu_Click);
            // 
            // btnthemkh
            // 
            this.btnthemkh.Location = new System.Drawing.Point(6, 26);
            this.btnthemkh.Name = "btnthemkh";
            this.btnthemkh.Size = new System.Drawing.Size(88, 31);
            this.btnthemkh.TabIndex = 42;
            this.btnthemkh.Text = "Thêm";
            this.btnthemkh.UseVisualStyleBackColor = true;
            this.btnthemkh.Click += new System.EventHandler(this.btnthemdichvu_Click);
            // 
            // txtTIMKIEMDICHVU
            // 
            this.txtTIMKIEMDICHVU.Location = new System.Drawing.Point(605, 329);
            this.txtTIMKIEMDICHVU.Name = "txtTIMKIEMDICHVU";
            this.txtTIMKIEMDICHVU.Size = new System.Drawing.Size(182, 22);
            this.txtTIMKIEMDICHVU.TabIndex = 41;
            this.txtTIMKIEMDICHVU.TextChanged += new System.EventHandler(this.txtTIMKIEMDICHVU_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(494, 329);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 20);
            this.label10.TabIndex = 40;
            this.label10.Text = "Tìm Kiếm";
            // 
            // dataGridViewDICHVU
            // 
            this.dataGridViewDICHVU.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDICHVU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDICHVU.Location = new System.Drawing.Point(16, 26);
            this.dataGridViewDICHVU.Name = "dataGridViewDICHVU";
            this.dataGridViewDICHVU.ReadOnly = true;
            this.dataGridViewDICHVU.RowHeadersWidth = 51;
            this.dataGridViewDICHVU.RowTemplate.Height = 24;
            this.dataGridViewDICHVU.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDICHVU.Size = new System.Drawing.Size(736, 172);
            this.dataGridViewDICHVU.TabIndex = 39;
            this.dataGridViewDICHVU.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDICHVU_CellContentClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(421, 147);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 34;
            this.label8.Text = "Đơn Giá";
            // 
            // txtDONVITINH
            // 
            this.txtDONVITINH.Location = new System.Drawing.Point(168, 147);
            this.txtDONVITINH.Name = "txtDONVITINH";
            this.txtDONVITINH.Size = new System.Drawing.Size(162, 27);
            this.txtDONVITINH.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 149);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Đơn Vị Tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 41);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Mã dịch vụ";
            // 
            // txtMaLoaiDV
            // 
            this.txtMaLoaiDV.Location = new System.Drawing.Point(168, 87);
            this.txtMaLoaiDV.Multiline = true;
            this.txtMaLoaiDV.Name = "txtMaLoaiDV";
            this.txtMaLoaiDV.Size = new System.Drawing.Size(162, 22);
            this.txtMaLoaiDV.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Mã loại dịch vụ";
            // 
            // txtDONGIA
            // 
            this.txtDONGIA.Location = new System.Drawing.Point(582, 147);
            this.txtDONGIA.Name = "txtDONGIA";
            this.txtDONGIA.Size = new System.Drawing.Size(162, 27);
            this.txtDONGIA.TabIndex = 47;
            // 
            // txtiddichvu
            // 
            this.txtiddichvu.Location = new System.Drawing.Point(168, 41);
            this.txtiddichvu.Multiline = true;
            this.txtiddichvu.Name = "txtiddichvu";
            this.txtiddichvu.Size = new System.Drawing.Size(162, 22);
            this.txtiddichvu.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(421, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 49;
            this.label2.Text = "Tên Loại DV";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(421, 92);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 50;
            this.label6.Text = "Tên dịch vụ";
            // 
            // txttendichvu
            // 
            this.txttendichvu.Location = new System.Drawing.Point(582, 89);
            this.txttendichvu.Name = "txttendichvu";
            this.txttendichvu.Size = new System.Drawing.Size(162, 27);
            this.txttendichvu.TabIndex = 51;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txttendichvu);
            this.groupBox1.Controls.Add(this.txtMaLoaiDV);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDONVITINH);
            this.groupBox1.Controls.Add(this.txtiddichvu);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtDONGIA);
            this.groupBox1.Controls.Add(this.CbbLDV);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 202);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dịch Vụ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.btnthemkh);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(465, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 79);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Vụ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridViewDICHVU);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(17, 357);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(770, 228);
            this.groupBox3.TabIndex = 54;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dịch Vụ";
            // 
            // QLDICHVU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(135)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(846, 705);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTIMKIEMDICHVU);
            this.Controls.Add(this.label10);
            this.Name = "QLDICHVU";
            this.Text = "QLDICHVU";
            this.Load += new System.EventHandler(this.QLDICHVU_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDICHVU)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbbLDV;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnthemkh;
        private System.Windows.Forms.TextBox txtTIMKIEMDICHVU;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridViewDICHVU;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDONVITINH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaLoaiDV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDONGIA;
        private System.Windows.Forms.TextBox txtiddichvu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txttendichvu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}