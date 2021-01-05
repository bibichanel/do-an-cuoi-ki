
namespace Do_An_Cuoi_Ki
{
    partial class fbanHang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labIdNhanVien = new System.Windows.Forms.Label();
            this.btnDeleteBill = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.picImageProduct = new System.Windows.Forms.PictureBox();
            this.panelScan = new System.Windows.Forms.Panel();
            this.picBarCode = new System.Windows.Forms.PictureBox();
            this.panelChoose = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxProduct = new System.Windows.Forms.ComboBox();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dgvAddProduct = new System.Windows.Forms.DataGridView();
            this.comboboxPerson = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelTree03 = new System.Windows.Forms.Panel();
            this.panelTree04 = new System.Windows.Forms.Panel();
            this.panelTree02 = new System.Windows.Forms.Panel();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtExcessCash = new System.Windows.Forms.TextBox();
            this.txtMoneyGivenByPerson = new System.Windows.Forms.TextBox();
            this.txtMoneyOfPerson = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtSumMoney = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSumMoney = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.panelTree01 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImageProduct)).BeginInit();
            this.panelScan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBarCode)).BeginInit();
            this.panelChoose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddProduct)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aquamarine;
            this.panel1.Controls.Add(this.labIdNhanVien);
            this.panel1.Controls.Add(this.btnDeleteBill);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.picImageProduct);
            this.panel1.Controls.Add(this.panelScan);
            this.panel1.Controls.Add(this.panelChoose);
            this.panel1.Controls.Add(this.btnSwitch);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.dgvAddProduct);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 642);
            this.panel1.TabIndex = 0;
            // 
            // labIdNhanVien
            // 
            this.labIdNhanVien.AutoSize = true;
            this.labIdNhanVien.Location = new System.Drawing.Point(3, 616);
            this.labIdNhanVien.Name = "labIdNhanVien";
            this.labIdNhanVien.Size = new System.Drawing.Size(87, 17);
            this.labIdNhanVien.TabIndex = 9;
            this.labIdNhanVien.Text = "id Nhân viên";
            // 
            // btnDeleteBill
            // 
            this.btnDeleteBill.Location = new System.Drawing.Point(68, 484);
            this.btnDeleteBill.Name = "btnDeleteBill";
            this.btnDeleteBill.Size = new System.Drawing.Size(155, 47);
            this.btnDeleteBill.TabIndex = 8;
            this.btnDeleteBill.Text = "Xóa hóa đơn hiện tại";
            this.btnDeleteBill.UseVisualStyleBackColor = true;
            this.btnDeleteBill.Click += new System.EventHandler(this.btnDeleteBill_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(290, 500);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(160, 130);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Thêm ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // picImageProduct
            // 
            this.picImageProduct.BackColor = System.Drawing.Color.White;
            this.picImageProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImageProduct.Location = new System.Drawing.Point(549, 484);
            this.picImageProduct.Name = "picImageProduct";
            this.picImageProduct.Size = new System.Drawing.Size(191, 155);
            this.picImageProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImageProduct.TabIndex = 6;
            this.picImageProduct.TabStop = false;
            // 
            // panelScan
            // 
            this.panelScan.Controls.Add(this.picBarCode);
            this.panelScan.Location = new System.Drawing.Point(279, 14);
            this.panelScan.Name = "panelScan";
            this.panelScan.Size = new System.Drawing.Size(461, 100);
            this.panelScan.TabIndex = 5;
            this.panelScan.Visible = false;
            // 
            // picBarCode
            // 
            this.picBarCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBarCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBarCode.Location = new System.Drawing.Point(0, 0);
            this.picBarCode.Name = "picBarCode";
            this.picBarCode.Size = new System.Drawing.Size(461, 100);
            this.picBarCode.TabIndex = 4;
            this.picBarCode.TabStop = false;
            // 
            // panelChoose
            // 
            this.panelChoose.Controls.Add(this.label7);
            this.panelChoose.Controls.Add(this.comboBoxProduct);
            this.panelChoose.Location = new System.Drawing.Point(279, 14);
            this.panelChoose.Name = "panelChoose";
            this.panelChoose.Size = new System.Drawing.Size(461, 100);
            this.panelChoose.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 25);
            this.label7.TabIndex = 3;
            this.label7.Text = "Thêm sản phẩm";
            // 
            // comboBoxProduct
            // 
            this.comboBoxProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxProduct.FormattingEnabled = true;
            this.comboBoxProduct.Location = new System.Drawing.Point(22, 48);
            this.comboBoxProduct.Name = "comboBoxProduct";
            this.comboBoxProduct.Size = new System.Drawing.Size(418, 44);
            this.comboBoxProduct.TabIndex = 2;
            this.comboBoxProduct.SelectedIndexChanged += new System.EventHandler(this.comboBoxProduct_SelectedIndexChanged);
            // 
            // btnSwitch
            // 
            this.btnSwitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwitch.Location = new System.Drawing.Point(9, 21);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(261, 85);
            this.btnSwitch.TabIndex = 4;
            this.btnSwitch.Text = "Chuyển đổi sang quét mã Barcode";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(68, 550);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(155, 45);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Về trang chủ";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dgvAddProduct
            // 
            this.dgvAddProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddProduct.Location = new System.Drawing.Point(-1, 131);
            this.dgvAddProduct.Name = "dgvAddProduct";
            this.dgvAddProduct.RowHeadersWidth = 51;
            this.dgvAddProduct.RowTemplate.Height = 24;
            this.dgvAddProduct.Size = new System.Drawing.Size(746, 347);
            this.dgvAddProduct.TabIndex = 0;
            this.dgvAddProduct.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAddProduct_CellEndEdit);
            this.dgvAddProduct.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAddProduct_CellValueChanged);
            this.dgvAddProduct.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvAddProduct_RowsAdded);
            this.dgvAddProduct.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvAddProduct_RowsRemoved);
            // 
            // comboboxPerson
            // 
            this.comboboxPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboboxPerson.FormattingEnabled = true;
            this.comboboxPerson.Items.AddRange(new object[] {
            "Thêm khách hàng vào đơn"});
            this.comboboxPerson.Location = new System.Drawing.Point(53, 3);
            this.comboboxPerson.Name = "comboboxPerson";
            this.comboboxPerson.Size = new System.Drawing.Size(365, 39);
            this.comboboxPerson.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panelTree03);
            this.panel2.Controls.Add(this.panelTree04);
            this.panel2.Controls.Add(this.panelTree02);
            this.panel2.Controls.Add(this.txtNote);
            this.panel2.Controls.Add(this.txtExcessCash);
            this.panel2.Controls.Add(this.txtMoneyGivenByPerson);
            this.panel2.Controls.Add(this.txtMoneyOfPerson);
            this.panel2.Controls.Add(this.txtDiscount);
            this.panel2.Controls.Add(this.txtSumMoney);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblSumMoney);
            this.panel2.Controls.Add(this.btnPay);
            this.panel2.Controls.Add(this.panelTree01);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(746, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(478, 642);
            this.panel2.TabIndex = 2;
            // 
            // panelTree03
            // 
            this.panelTree03.BackColor = System.Drawing.Color.Black;
            this.panelTree03.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTree03.Location = new System.Drawing.Point(174, 278);
            this.panelTree03.Name = "panelTree03";
            this.panelTree03.Size = new System.Drawing.Size(300, 1);
            this.panelTree03.TabIndex = 9;
            // 
            // panelTree04
            // 
            this.panelTree04.BackColor = System.Drawing.Color.Black;
            this.panelTree04.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTree04.Location = new System.Drawing.Point(1, 530);
            this.panelTree04.Name = "panelTree04";
            this.panelTree04.Size = new System.Drawing.Size(478, 1);
            this.panelTree04.TabIndex = 9;
            // 
            // panelTree02
            // 
            this.panelTree02.BackColor = System.Drawing.Color.Black;
            this.panelTree02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTree02.Location = new System.Drawing.Point(174, 159);
            this.panelTree02.Name = "panelTree02";
            this.panelTree02.Size = new System.Drawing.Size(300, 1);
            this.panelTree02.TabIndex = 9;
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.Location = new System.Drawing.Point(23, 404);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(434, 115);
            this.txtNote.TabIndex = 8;
            // 
            // txtExcessCash
            // 
            this.txtExcessCash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtExcessCash.Location = new System.Drawing.Point(224, 300);
            this.txtExcessCash.Name = "txtExcessCash";
            this.txtExcessCash.ReadOnly = true;
            this.txtExcessCash.Size = new System.Drawing.Size(233, 22);
            this.txtExcessCash.TabIndex = 8;
            this.txtExcessCash.Text = "0";
            this.txtExcessCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtExcessCash.Leave += new System.EventHandler(this.txtExcessCash_Leave);
            // 
            // txtMoneyGivenByPerson
            // 
            this.txtMoneyGivenByPerson.BackColor = System.Drawing.Color.White;
            this.txtMoneyGivenByPerson.Location = new System.Drawing.Point(224, 229);
            this.txtMoneyGivenByPerson.Name = "txtMoneyGivenByPerson";
            this.txtMoneyGivenByPerson.Size = new System.Drawing.Size(233, 22);
            this.txtMoneyGivenByPerson.TabIndex = 8;
            this.txtMoneyGivenByPerson.Text = "0";
            this.txtMoneyGivenByPerson.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMoneyGivenByPerson.TextChanged += new System.EventHandler(this.txtMoneyGivenByPerson_TextChanged);
            // 
            // txtMoneyOfPerson
            // 
            this.txtMoneyOfPerson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtMoneyOfPerson.Location = new System.Drawing.Point(224, 180);
            this.txtMoneyOfPerson.Name = "txtMoneyOfPerson";
            this.txtMoneyOfPerson.ReadOnly = true;
            this.txtMoneyOfPerson.Size = new System.Drawing.Size(233, 22);
            this.txtMoneyOfPerson.TabIndex = 8;
            this.txtMoneyOfPerson.Text = "0";
            this.txtMoneyOfPerson.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDiscount
            // 
            this.txtDiscount.BackColor = System.Drawing.Color.White;
            this.txtDiscount.Location = new System.Drawing.Point(224, 115);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(233, 22);
            this.txtDiscount.TabIndex = 8;
            this.txtDiscount.Text = "0";
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            // 
            // txtSumMoney
            // 
            this.txtSumMoney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtSumMoney.Location = new System.Drawing.Point(224, 66);
            this.txtSumMoney.Name = "txtSumMoney";
            this.txtSumMoney.ReadOnly = true;
            this.txtSumMoney.Size = new System.Drawing.Size(233, 22);
            this.txtSumMoney.TabIndex = 8;
            this.txtSumMoney.Text = "0";
            this.txtSumMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSumMoney.TextChanged += new System.EventHandler(this.txtSumMoney_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ghi chú đơn hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tiền thừa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tiền khách đưa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Khách phải trả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Chiết khấu";
            // 
            // lblSumMoney
            // 
            this.lblSumMoney.AutoSize = true;
            this.lblSumMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumMoney.Location = new System.Drawing.Point(18, 62);
            this.lblSumMoney.Name = "lblSumMoney";
            this.lblSumMoney.Size = new System.Drawing.Size(99, 25);
            this.lblSumMoney.TabIndex = 7;
            this.lblSumMoney.Text = "Tổng tiền ";
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(168)))), ((int)(((byte)(79)))));
            this.btnPay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(0, 537);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(478, 105);
            this.btnPay.TabIndex = 6;
            this.btnPay.Text = "Thanh toán (F1)";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelTree01
            // 
            this.panelTree01.BackColor = System.Drawing.Color.Black;
            this.panelTree01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTree01.Location = new System.Drawing.Point(1, 48);
            this.panelTree01.Name = "panelTree01";
            this.panelTree01.Size = new System.Drawing.Size(479, 1);
            this.panelTree01.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.comboboxPerson);
            this.panel3.Controls.Add(this.btnAddPerson);
            this.panel3.Controls.Add(this.picIcon);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(478, 46);
            this.panel3.TabIndex = 4;
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.BackColor = System.Drawing.Color.White;
            this.btnAddPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPerson.Location = new System.Drawing.Point(424, 0);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(50, 48);
            this.btnAddPerson.TabIndex = 2;
            this.btnAddPerson.Text = "+";
            this.btnAddPerson.UseVisualStyleBackColor = false;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // picIcon
            // 
            this.picIcon.Cursor = System.Windows.Forms.Cursors.Default;
            this.picIcon.Image = global::Do_An_Cuoi_Ki.Properties.Resources.magnifying_glass;
            this.picIcon.Location = new System.Drawing.Point(3, 3);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(44, 39);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcon.TabIndex = 3;
            this.picIcon.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // fbanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 642);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fbanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fbanHang";
            this.Load += new System.EventHandler(this.fbanHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImageProduct)).EndInit();
            this.panelScan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBarCode)).EndInit();
            this.panelChoose.ResumeLayout(false);
            this.panelChoose.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddProduct)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboboxPerson;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelTree01;
        private System.Windows.Forms.Panel panelTree03;
        private System.Windows.Forms.Panel panelTree02;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtSumMoney;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSumMoney;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.TextBox txtMoneyGivenByPerson;
        private System.Windows.Forms.TextBox txtMoneyOfPerson;
        private System.Windows.Forms.Panel panelTree04;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.TextBox txtExcessCash;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvAddProduct;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelChoose;
        private System.Windows.Forms.Panel panelScan;
        private System.Windows.Forms.PictureBox picBarCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxProduct;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.PictureBox picImageProduct;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDeleteBill;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labIdNhanVien;
    }
}