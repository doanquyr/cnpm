namespace DoanQLKS
{
    partial class TINHLUONGNHANVIEN
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Giovao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.manhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cachinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tangca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tính Lương";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nhanvien,
            this.Giovao,
            this.giora,
            this.calam,
            this.Title});
            this.dataGridView1.Location = new System.Drawing.Point(18, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(716, 231);
            this.dataGridView1.TabIndex = 1;
            // 
            // nhanvien
            // 
            this.nhanvien.HeaderText = "Mã Nhân Viên";
            this.nhanvien.MinimumWidth = 6;
            this.nhanvien.Name = "nhanvien";
            this.nhanvien.Width = 125;
            // 
            // Giovao
            // 
            this.Giovao.HeaderText = "Giờ Vào";
            this.Giovao.MinimumWidth = 6;
            this.Giovao.Name = "Giovao";
            this.Giovao.Width = 125;
            // 
            // giora
            // 
            this.giora.HeaderText = "Giờ Ra";
            this.giora.MinimumWidth = 6;
            this.giora.Name = "giora";
            this.giora.Width = 125;
            // 
            // calam
            // 
            this.calam.HeaderText = "Ca Làm";
            this.calam.MinimumWidth = 6;
            this.calam.Name = "calam";
            this.calam.Width = 125;
            // 
            // Title
            // 
            this.Title.HeaderText = "Nội dung";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(122, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(702, 268);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bảng ca làm";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(122, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(702, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Tính Lương";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(122, 366);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(702, 268);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bảng tính lương";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manhanvien,
            this.ngay,
            this.Cachinh,
            this.tangca,
            this.cadem,
            this.tongngay,
            this.tongluong});
            this.dataGridView2.Location = new System.Drawing.Point(6, 23);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(690, 206);
            this.dataGridView2.TabIndex = 0;
            // 
            // manhanvien
            // 
            this.manhanvien.HeaderText = "Mã Nhân Viên";
            this.manhanvien.MinimumWidth = 6;
            this.manhanvien.Name = "manhanvien";
            this.manhanvien.Width = 125;
            // 
            // ngay
            // 
            this.ngay.HeaderText = "Ngay";
            this.ngay.MinimumWidth = 6;
            this.ngay.Name = "ngay";
            this.ngay.Width = 125;
            // 
            // Cachinh
            // 
            this.Cachinh.HeaderText = "Ca Chính";
            this.Cachinh.MinimumWidth = 6;
            this.Cachinh.Name = "Cachinh";
            this.Cachinh.Width = 125;
            // 
            // tangca
            // 
            this.tangca.HeaderText = "Tăng Ca";
            this.tangca.MinimumWidth = 6;
            this.tangca.Name = "tangca";
            this.tangca.Width = 125;
            // 
            // cadem
            // 
            this.cadem.HeaderText = "Ca Đêm";
            this.cadem.MinimumWidth = 6;
            this.cadem.Name = "cadem";
            this.cadem.Width = 125;
            // 
            // tongngay
            // 
            this.tongngay.HeaderText = "Tổng Ngày ";
            this.tongngay.MinimumWidth = 6;
            this.tongngay.Name = "tongngay";
            this.tongngay.Width = 125;
            // 
            // tongluong
            // 
            this.tongluong.HeaderText = "Tổng Lương";
            this.tongluong.MinimumWidth = 6;
            this.tongluong.Name = "tongluong";
            this.tongluong.Width = 125;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 53);
            this.button2.TabIndex = 4;
            this.button2.Text = "Chọn file excel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(118, 657);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tổng Lương tất cả nhân viên";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(344, 651);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(276, 24);
            this.textBox1.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(679, 644);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 38);
            this.button3.TabIndex = 7;
            this.button3.Text = "Xuất file excel";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // TINHLUONGNHANVIEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(135)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(846, 705);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TINHLUONGNHANVIEN";
            this.Text = "TINHLUONGNHANVIEN";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Giovao;
        private System.Windows.Forms.DataGridViewTextBoxColumn giora;
        private System.Windows.Forms.DataGridViewTextBoxColumn calam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn manhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cachinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tangca;
        private System.Windows.Forms.DataGridViewTextBoxColumn cadem;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongluong;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
    }
}