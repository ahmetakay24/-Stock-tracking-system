namespace BakkalProjesi
{
    partial class StockForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockForm));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.pnLBL = new System.Windows.Forms.Label();
            this.pcBOX = new System.Windows.Forms.TextBox();
            this.ppLBL = new System.Windows.Forms.Label();
            this.spLBL = new System.Windows.Forms.Label();
            this.pnBOX = new System.Windows.Forms.TextBox();
            this.nofBOX = new System.Windows.Forms.TextBox();
            this.ppBOX = new System.Windows.Forms.TextBox();
            this.spBOX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nofLBL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(145)))), ((int)(((byte)(68)))));
            this.label1.Location = new System.Drawing.Point(676, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 89);
            this.label1.TabIndex = 3;
            this.label1.Text = "Stocks";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(23, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1139, 605);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(145)))), ((int)(((byte)(68)))));
            this.button4.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(80)))));
            this.button4.Location = new System.Drawing.Point(23, 759);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(189, 44);
            this.button4.TabIndex = 16;
            this.button4.Text = "View";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(145)))), ((int)(((byte)(68)))));
            this.updateButton.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.updateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(80)))));
            this.updateButton.Location = new System.Drawing.Point(1185, 663);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(189, 44);
            this.updateButton.TabIndex = 15;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(145)))), ((int)(((byte)(68)))));
            this.deleteButton.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.deleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(80)))));
            this.deleteButton.Location = new System.Drawing.Point(1185, 576);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(189, 44);
            this.deleteButton.TabIndex = 14;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(145)))), ((int)(((byte)(68)))));
            this.addButton.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.addButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(80)))));
            this.addButton.Location = new System.Drawing.Point(1185, 485);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(189, 44);
            this.addButton.TabIndex = 13;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // pnLBL
            // 
            this.pnLBL.Font = new System.Drawing.Font("Times New Roman", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.pnLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(145)))), ((int)(((byte)(68)))));
            this.pnLBL.Location = new System.Drawing.Point(1168, 212);
            this.pnLBL.Name = "pnLBL";
            this.pnLBL.Size = new System.Drawing.Size(219, 49);
            this.pnLBL.TabIndex = 5;
            this.pnLBL.Text = "Product Name";
            this.pnLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pcBOX
            // 
            this.pcBOX.Location = new System.Drawing.Point(1440, 153);
            this.pcBOX.Multiline = true;
            this.pcBOX.Name = "pcBOX";
            this.pcBOX.Size = new System.Drawing.Size(226, 35);
            this.pcBOX.TabIndex = 18;
            // 
            // ppLBL
            // 
            this.ppLBL.Font = new System.Drawing.Font("Times New Roman", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ppLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(145)))), ((int)(((byte)(68)))));
            this.ppLBL.Location = new System.Drawing.Point(1179, 347);
            this.ppLBL.Name = "ppLBL";
            this.ppLBL.Size = new System.Drawing.Size(219, 49);
            this.ppLBL.TabIndex = 7;
            this.ppLBL.Text = "Purchase price";
            this.ppLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // spLBL
            // 
            this.spLBL.Font = new System.Drawing.Font("Times New Roman", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.spLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(145)))), ((int)(((byte)(68)))));
            this.spLBL.Location = new System.Drawing.Point(1168, 412);
            this.spLBL.Name = "spLBL";
            this.spLBL.Size = new System.Drawing.Size(219, 49);
            this.spLBL.TabIndex = 8;
            this.spLBL.Text = "Sale price";
            this.spLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnBOX
            // 
            this.pnBOX.Location = new System.Drawing.Point(1440, 212);
            this.pnBOX.Multiline = true;
            this.pnBOX.Name = "pnBOX";
            this.pnBOX.Size = new System.Drawing.Size(226, 35);
            this.pnBOX.TabIndex = 9;
            // 
            // nofBOX
            // 
            this.nofBOX.Location = new System.Drawing.Point(1440, 291);
            this.nofBOX.Multiline = true;
            this.nofBOX.Name = "nofBOX";
            this.nofBOX.Size = new System.Drawing.Size(226, 35);
            this.nofBOX.TabIndex = 10;
            // 
            // ppBOX
            // 
            this.ppBOX.Location = new System.Drawing.Point(1440, 361);
            this.ppBOX.Multiline = true;
            this.ppBOX.Name = "ppBOX";
            this.ppBOX.Size = new System.Drawing.Size(226, 35);
            this.ppBOX.TabIndex = 11;
            // 
            // spBOX
            // 
            this.spBOX.Location = new System.Drawing.Point(1440, 426);
            this.spBOX.Multiline = true;
            this.spBOX.Name = "spBOX";
            this.spBOX.Size = new System.Drawing.Size(226, 35);
            this.spBOX.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(145)))), ((int)(((byte)(68)))));
            this.label2.Location = new System.Drawing.Point(1168, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 49);
            this.label2.TabIndex = 17;
            this.label2.Text = "Product Code";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nofLBL
            // 
            this.nofLBL.Font = new System.Drawing.Font("Times New Roman", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.nofLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(145)))), ((int)(((byte)(68)))));
            this.nofLBL.Location = new System.Drawing.Point(1168, 277);
            this.nofLBL.Name = "nofLBL";
            this.nofLBL.Size = new System.Drawing.Size(283, 49);
            this.nofLBL.TabIndex = 6;
            this.nofLBL.Text = "Number of products";
            this.nofLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1678, 844);
            this.Controls.Add(this.pcBOX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.spBOX);
            this.Controls.Add(this.ppBOX);
            this.Controls.Add(this.nofBOX);
            this.Controls.Add(this.pnBOX);
            this.Controls.Add(this.spLBL);
            this.Controls.Add(this.ppLBL);
            this.Controls.Add(this.nofLBL);
            this.Controls.Add(this.pnLBL);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StockForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Management";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label pnLBL;
        private System.Windows.Forms.TextBox pcBOX;
        private System.Windows.Forms.Label ppLBL;
        private System.Windows.Forms.Label spLBL;
        private System.Windows.Forms.TextBox pnBOX;
        private System.Windows.Forms.TextBox nofBOX;
        private System.Windows.Forms.TextBox ppBOX;
        private System.Windows.Forms.TextBox spBOX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nofLBL;
    }
}