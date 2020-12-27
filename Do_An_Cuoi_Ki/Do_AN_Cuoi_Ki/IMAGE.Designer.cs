
namespace Do_AN_Cuoi_Ki
{
    partial class IMAGE
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
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtxDateOfBirth = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvImage = new System.Windows.Forms.DataGridView();
            this.colLinkQRCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.picQRcode = new System.Windows.Forms.PictureBox();
            this.btnScan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQRcode)).BeginInit();
            this.SuspendLayout();
            // 
            // picIcon
            // 
            this.picIcon.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picIcon.Location = new System.Drawing.Point(729, 277);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(168, 169);
            this.picIcon.TabIndex = 0;
            this.picIcon.TabStop = false;
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(122, 37);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(195, 22);
            this.txtMSSV.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "MSSV:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(122, 82);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(195, 22);
            this.txtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // txtxDateOfBirth
            // 
            this.txtxDateOfBirth.Location = new System.Drawing.Point(122, 133);
            this.txtxDateOfBirth.Name = "txtxDateOfBirth";
            this.txtxDateOfBirth.Size = new System.Drawing.Size(195, 22);
            this.txtxDateOfBirth.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date Of Birth:";
            // 
            // dgvImage
            // 
            this.dgvImage.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvImage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLinkQRCode});
            this.dgvImage.Location = new System.Drawing.Point(15, 277);
            this.dgvImage.Name = "dgvImage";
            this.dgvImage.RowHeadersWidth = 51;
            this.dgvImage.RowTemplate.Height = 24;
            this.dgvImage.Size = new System.Drawing.Size(637, 169);
            this.dgvImage.TabIndex = 3;
            this.dgvImage.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvImage_CellMouseClick);
            // 
            // colLinkQRCode
            // 
            this.colLinkQRCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colLinkQRCode.HeaderText = "Link QRCode";
            this.colLinkQRCode.MinimumWidth = 6;
            this.colLinkQRCode.Name = "colLinkQRCode";
            this.colLinkQRCode.Width = 121;
            // 
            // picImage
            // 
            this.picImage.Location = new System.Drawing.Point(574, 24);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(380, 232);
            this.picImage.TabIndex = 4;
            this.picImage.TabStop = false;
            // 
            // picQRcode
            // 
            this.picQRcode.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picQRcode.Location = new System.Drawing.Point(350, 24);
            this.picQRcode.Name = "picQRcode";
            this.picQRcode.Size = new System.Drawing.Size(200, 185);
            this.picQRcode.TabIndex = 0;
            this.picQRcode.TabStop = false;
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(395, 228);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(92, 28);
            this.btnScan.TabIndex = 5;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // IMAGE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 478);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.dgvImage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtxDateOfBirth);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtMSSV);
            this.Controls.Add(this.picQRcode);
            this.Controls.Add(this.picIcon);
            this.Name = "IMAGE";
            this.Text = "IMAGE";
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQRcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtxDateOfBirth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvImage;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.PictureBox picQRcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLinkQRCode;
        private System.Windows.Forms.Button btnScan;
    }
}