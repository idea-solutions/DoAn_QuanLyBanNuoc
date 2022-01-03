
namespace DoAn_QuanLyBanNuoc
{
    partial class FormManagerDrink
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManagerDrink));
            this.buttonDone = new System.Windows.Forms.Button();
            this.dataGridViewWater = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxGia = new System.Windows.Forms.TextBox();
            this.textBoxwatername = new System.Windows.Forms.TextBox();
            this.textBoxWaterID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWater)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDone
            // 
            this.buttonDone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDone.BackgroundImage")));
            this.buttonDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDone.Location = new System.Drawing.Point(12, 493);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(289, 48);
            this.buttonDone.TabIndex = 6;
            this.buttonDone.Text = "Done";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // dataGridViewWater
            // 
            this.dataGridViewWater.AllowUserToAddRows = false;
            this.dataGridViewWater.AllowUserToDeleteRows = false;
            this.dataGridViewWater.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewWater.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWater.Location = new System.Drawing.Point(307, 140);
            this.dataGridViewWater.Name = "dataGridViewWater";
            this.dataGridViewWater.ReadOnly = true;
            this.dataGridViewWater.RowHeadersWidth = 51;
            this.dataGridViewWater.RowTemplate.Height = 24;
            this.dataGridViewWater.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewWater.Size = new System.Drawing.Size(463, 401);
            this.dataGridViewWater.TabIndex = 4;
            this.dataGridViewWater.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewWater_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(210, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(434, 54);
            this.label3.TabIndex = 5;
            this.label3.Text = "Drink Management";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.textBoxGia);
            this.groupBox2.Controls.Add(this.textBoxwatername);
            this.groupBox2.Controls.Add(this.textBoxWaterID);
            this.groupBox2.Location = new System.Drawing.Point(18, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 334);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Font = new System.Drawing.Font("Consolas", 14F);
            this.button1.Location = new System.Drawing.Point(10, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(259, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Delete";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttondelete_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Font = new System.Drawing.Font("Consolas", 14F);
            this.button2.Location = new System.Drawing.Point(10, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(259, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "Insert/Update";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttoninsert_Click);
            // 
            // textBoxGia
            // 
            this.textBoxGia.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxGia.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGia.Location = new System.Drawing.Point(18, 136);
            this.textBoxGia.Multiline = true;
            this.textBoxGia.Name = "textBoxGia";
            this.textBoxGia.Size = new System.Drawing.Size(259, 40);
            this.textBoxGia.TabIndex = 0;
            this.textBoxGia.Click += new System.EventHandler(this.textBoxGia_Click);
            // 
            // textBoxwatername
            // 
            this.textBoxwatername.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxwatername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxwatername.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxwatername.Location = new System.Drawing.Point(18, 83);
            this.textBoxwatername.Multiline = true;
            this.textBoxwatername.Name = "textBoxwatername";
            this.textBoxwatername.Size = new System.Drawing.Size(259, 40);
            this.textBoxwatername.TabIndex = 0;
            this.textBoxwatername.Click += new System.EventHandler(this.textBoxwatername_Click);
            // 
            // textBoxWaterID
            // 
            this.textBoxWaterID.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxWaterID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxWaterID.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWaterID.Location = new System.Drawing.Point(18, 30);
            this.textBoxWaterID.Multiline = true;
            this.textBoxWaterID.Name = "textBoxWaterID";
            this.textBoxWaterID.Size = new System.Drawing.Size(259, 40);
            this.textBoxWaterID.TabIndex = 0;
            this.textBoxWaterID.Click += new System.EventHandler(this.textBoxWaterID_Click);
            // 
            // FormManagerDrink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.dataGridViewWater);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormManagerDrink";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Drink";
            this.Load += new System.EventHandler(this.FormManagerDrink_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWater)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.DataGridView dataGridViewWater;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxGia;
        private System.Windows.Forms.TextBox textBoxwatername;
        private System.Windows.Forms.TextBox textBoxWaterID;
    }
}