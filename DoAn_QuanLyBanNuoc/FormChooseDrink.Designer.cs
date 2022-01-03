
namespace DoAn_QuanLyBanNuoc
{
    partial class FormChooseDrink
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChooseDrink));
            this.textBoxBan = new System.Windows.Forms.Label();
            this.dataGridViewChonNuoc = new System.Windows.Forms.DataGridView();
            this.textBoxOrder = new System.Windows.Forms.Label();
            this.buttonDone = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.textBoxSoLuong = new System.Windows.Forms.TextBox();
            this.comboBoxNuoc = new System.Windows.Forms.ComboBox();
            this.labelMoney = new System.Windows.Forms.Label();
            this.labelGia = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChonNuoc)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxBan
            // 
            this.textBoxBan.BackColor = System.Drawing.Color.Transparent;
            this.textBoxBan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBan.Font = new System.Drawing.Font("Consolas", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBan.Location = new System.Drawing.Point(18, 106);
            this.textBoxBan.Name = "textBoxBan";
            this.textBoxBan.Size = new System.Drawing.Size(169, 69);
            this.textBoxBan.TabIndex = 16;
            // 
            // dataGridViewChonNuoc
            // 
            this.dataGridViewChonNuoc.AllowUserToAddRows = false;
            this.dataGridViewChonNuoc.AllowUserToDeleteRows = false;
            this.dataGridViewChonNuoc.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewChonNuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChonNuoc.Location = new System.Drawing.Point(18, 398);
            this.dataGridViewChonNuoc.Name = "dataGridViewChonNuoc";
            this.dataGridViewChonNuoc.ReadOnly = true;
            this.dataGridViewChonNuoc.RowHeadersWidth = 51;
            this.dataGridViewChonNuoc.RowTemplate.Height = 24;
            this.dataGridViewChonNuoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewChonNuoc.Size = new System.Drawing.Size(1152, 343);
            this.dataGridViewChonNuoc.TabIndex = 15;
            this.dataGridViewChonNuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewChonNuoc_CellClick);
            // 
            // textBoxOrder
            // 
            this.textBoxOrder.BackColor = System.Drawing.Color.Transparent;
            this.textBoxOrder.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOrder.Location = new System.Drawing.Point(166, 181);
            this.textBoxOrder.Name = "textBoxOrder";
            this.textBoxOrder.Size = new System.Drawing.Size(44, 31);
            this.textBoxOrder.TabIndex = 11;
            // 
            // buttonDone
            // 
            this.buttonDone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDone.BackgroundImage")));
            this.buttonDone.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDone.Location = new System.Drawing.Point(695, 342);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(114, 40);
            this.buttonDone.TabIndex = 14;
            this.buttonDone.Text = "Done";
            this.buttonDone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.buttonEdit);
            this.groupBox1.Controls.Add(this.buttonInsert);
            this.groupBox1.Controls.Add(this.textBoxSoLuong);
            this.groupBox1.Controls.Add(this.comboBoxNuoc);
            this.groupBox1.Controls.Add(this.labelMoney);
            this.groupBox1.Controls.Add(this.labelGia);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 14F);
            this.groupBox1.Location = new System.Drawing.Point(217, 78);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(599, 258);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEdit.BackgroundImage")));
            this.buttonEdit.Location = new System.Drawing.Point(478, 166);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(114, 40);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonInsert.BackgroundImage")));
            this.buttonInsert.Location = new System.Drawing.Point(18, 166);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(139, 40);
            this.buttonInsert.TabIndex = 3;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // textBoxSoLuong
            // 
            this.textBoxSoLuong.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxSoLuong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSoLuong.Location = new System.Drawing.Point(18, 125);
            this.textBoxSoLuong.Multiline = true;
            this.textBoxSoLuong.Name = "textBoxSoLuong";
            this.textBoxSoLuong.Size = new System.Drawing.Size(574, 35);
            this.textBoxSoLuong.TabIndex = 2;
            this.textBoxSoLuong.Click += new System.EventHandler(this.textBoxSoLuong_Click);
            // 
            // comboBoxNuoc
            // 
            this.comboBoxNuoc.BackColor = System.Drawing.SystemColors.Control;
            this.comboBoxNuoc.FormattingEnabled = true;
            this.comboBoxNuoc.Location = new System.Drawing.Point(16, 28);
            this.comboBoxNuoc.Name = "comboBoxNuoc";
            this.comboBoxNuoc.Size = new System.Drawing.Size(576, 35);
            this.comboBoxNuoc.TabIndex = 1;
            this.comboBoxNuoc.SelectedIndexChanged += new System.EventHandler(this.comboBoxNuoc_SelectedIndexChanged);
            // 
            // labelMoney
            // 
            this.labelMoney.BackColor = System.Drawing.Color.Transparent;
            this.labelMoney.Location = new System.Drawing.Point(126, 209);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(471, 31);
            this.labelMoney.TabIndex = 0;
            this.labelMoney.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelGia
            // 
            this.labelGia.BackColor = System.Drawing.Color.Transparent;
            this.labelGia.Location = new System.Drawing.Point(126, 75);
            this.labelGia.Name = "labelGia";
            this.labelGia.Size = new System.Drawing.Size(466, 31);
            this.labelGia.TabIndex = 0;
            this.labelGia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 28);
            this.label6.TabIndex = 0;
            this.label6.Text = "Cost";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Payment";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 28);
            this.label1.TabIndex = 12;
            this.label1.Text = "Next Order";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(233, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 40);
            this.button1.TabIndex = 17;
            this.button1.Text = "Print bill";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(846, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(288, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(503, 54);
            this.label2.TabIndex = 19;
            this.label2.Text = "Please choose a drink";
            // 
            // FormChooseDrink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxBan);
            this.Controls.Add(this.dataGridViewChonNuoc);
            this.Controls.Add(this.textBoxOrder);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormChooseDrink";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose Drink";
            this.Load += new System.EventHandler(this.FormChooseDrink_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChonNuoc)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textBoxBan;
        private System.Windows.Forms.DataGridView dataGridViewChonNuoc;
        private System.Windows.Forms.Label textBoxOrder;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.TextBox textBoxSoLuong;
        private System.Windows.Forms.ComboBox comboBoxNuoc;
        private System.Windows.Forms.Label labelMoney;
        private System.Windows.Forms.Label labelGia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}