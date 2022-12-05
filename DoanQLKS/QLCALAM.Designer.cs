namespace DoanQLKS
{
    partial class QLCALAM
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
            this.btnsuacalam = new System.Windows.Forms.Button();
            this.btnxoacalam = new System.Windows.Forms.Button();
            this.btnthemcalam = new System.Windows.Forms.Button();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridViewcalam = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtmacalam = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickergiobatdau = new System.Windows.Forms.DateTimePicker();
            this.Cbbnhanvien = new System.Windows.Forms.ComboBox();
            this.dateTimePickergioketthuc = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txttennhanvien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewcalam)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnsuacalam
            // 
            this.btnsuacalam.Location = new System.Drawing.Point(109, 26);
            this.btnsuacalam.Name = "btnsuacalam";
            this.btnsuacalam.Size = new System.Drawing.Size(88, 31);
            this.btnsuacalam.TabIndex = 105;
            this.btnsuacalam.Text = "Sửa";
            this.btnsuacalam.UseVisualStyleBackColor = true;
            this.btnsuacalam.Click += new System.EventHandler(this.btnsuacalam_Click);
            // 
            // btnxoacalam
            // 
            this.btnxoacalam.Location = new System.Drawing.Point(203, 26);
            this.btnxoacalam.Name = "btnxoacalam";
            this.btnxoacalam.Size = new System.Drawing.Size(88, 31);
            this.btnxoacalam.TabIndex = 104;
            this.btnxoacalam.Text = "Xóa";
            this.btnxoacalam.UseVisualStyleBackColor = true;
            this.btnxoacalam.Click += new System.EventHandler(this.btnxoacalam_Click);
            // 
            // btnthemcalam
            // 
            this.btnthemcalam.Location = new System.Drawing.Point(15, 26);
            this.btnthemcalam.Name = "btnthemcalam";
            this.btnthemcalam.Size = new System.Drawing.Size(88, 31);
            this.btnthemcalam.TabIndex = 103;
            this.btnthemcalam.Text = "Thêm";
            this.btnthemcalam.UseVisualStyleBackColor = true;
            this.btnthemcalam.Click += new System.EventHandler(this.btnthemcalam_Click);
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(563, 243);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(221, 22);
            this.txtTK.TabIndex = 102;
            this.txtTK.TextChanged += new System.EventHandler(this.txtTK_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(458, 243);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 20);
            this.label10.TabIndex = 101;
            this.label10.Text = "Tìm Kiếm";
            // 
            // dataGridViewcalam
            // 
            this.dataGridViewcalam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewcalam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewcalam.Location = new System.Drawing.Point(6, 21);
            this.dataGridViewcalam.Name = "dataGridViewcalam";
            this.dataGridViewcalam.ReadOnly = true;
            this.dataGridViewcalam.RowHeadersWidth = 51;
            this.dataGridViewcalam.RowTemplate.Height = 24;
            this.dataGridViewcalam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewcalam.Size = new System.Drawing.Size(756, 206);
            this.dataGridViewcalam.TabIndex = 100;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtmacalam);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txttennhanvien);
            this.groupBox1.Controls.Add(this.dateTimePickergiobatdau);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Cbbnhanvien);
            this.groupBox1.Controls.Add(this.dateTimePickergioketthuc);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 222);
            this.groupBox1.TabIndex = 116;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ca làm";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnthemcalam);
            this.groupBox2.Controls.Add(this.btnxoacalam);
            this.groupBox2.Controls.Add(this.btnsuacalam);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(462, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(299, 83);
            this.groupBox2.TabIndex = 117;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // txtmacalam
            // 
            this.txtmacalam.Location = new System.Drawing.Point(219, 27);
            this.txtmacalam.Name = "txtmacalam";
            this.txtmacalam.Size = new System.Drawing.Size(147, 27);
            this.txtmacalam.TabIndex = 115;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(7, 61);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 20);
            this.label13.TabIndex = 91;
            this.label13.Text = "Mã Nhân Viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 133);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 94;
            this.label5.Text = "Giờ Bắt Đầu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 173);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 96;
            this.label2.Text = "Giờ Kết Thúc";
            // 
            // dateTimePickergiobatdau
            // 
            this.dateTimePickergiobatdau.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickergiobatdau.Location = new System.Drawing.Point(219, 133);
            this.dateTimePickergiobatdau.Name = "dateTimePickergiobatdau";
            this.dateTimePickergiobatdau.Size = new System.Drawing.Size(147, 27);
            this.dateTimePickergiobatdau.TabIndex = 106;
            // 
            // Cbbnhanvien
            // 
            this.Cbbnhanvien.FormattingEnabled = true;
            this.Cbbnhanvien.Items.AddRange(new object[] {
            "Nam",
            "Nu"});
            this.Cbbnhanvien.Location = new System.Drawing.Point(219, 62);
            this.Cbbnhanvien.Name = "Cbbnhanvien";
            this.Cbbnhanvien.Size = new System.Drawing.Size(147, 28);
            this.Cbbnhanvien.TabIndex = 107;
            this.Cbbnhanvien.SelectedIndexChanged += new System.EventHandler(this.Cbbnhanvien_SelectedIndexChanged);
            // 
            // dateTimePickergioketthuc
            // 
            this.dateTimePickergioketthuc.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickergioketthuc.Location = new System.Drawing.Point(219, 173);
            this.dateTimePickergioketthuc.Name = "dateTimePickergioketthuc";
            this.dateTimePickergioketthuc.Size = new System.Drawing.Size(147, 27);
            this.dateTimePickergioketthuc.TabIndex = 111;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 112;
            this.label1.Text = "Tên Nhân Viên";
            // 
            // txttennhanvien
            // 
            this.txttennhanvien.Location = new System.Drawing.Point(219, 96);
            this.txttennhanvien.Name = "txttennhanvien";
            this.txttennhanvien.Size = new System.Drawing.Size(147, 27);
            this.txttennhanvien.TabIndex = 113;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 114;
            this.label3.Text = "Mã Ca Làm";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridViewcalam);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 266);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(772, 239);
            this.groupBox3.TabIndex = 118;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ca Làm";
            // 
            // QLCALAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(135)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(846, 705);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.label10);
            this.Name = "QLCALAM";
            this.Text = "QLCALAM";
            this.Load += new System.EventHandler(this.QLCALAM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewcalam)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnsuacalam;
        private System.Windows.Forms.Button btnxoacalam;
        private System.Windows.Forms.Button btnthemcalam;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridViewcalam;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtmacalam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttennhanvien;
        private System.Windows.Forms.DateTimePicker dateTimePickergiobatdau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cbbnhanvien;
        private System.Windows.Forms.DateTimePicker dateTimePickergioketthuc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}