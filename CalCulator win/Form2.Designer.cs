namespace CalCulator_win
{
    partial class Form2
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TB_1 = new System.Windows.Forms.TextBox();
            this.bt_is = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dvg_1 = new System.Windows.Forms.DataGridView();
            this.dvg_3 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_3)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.TB_1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.bt_is, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.55556F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.222222F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(703, 395);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // TB_1
            // 
            this.TB_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TB_1.Location = new System.Drawing.Point(3, 3);
            this.TB_1.Multiline = true;
            this.TB_1.Name = "TB_1";
            this.TB_1.Size = new System.Drawing.Size(697, 25);
            this.TB_1.TabIndex = 0;
            // 
            // bt_is
            // 
            this.bt_is.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_is.Location = new System.Drawing.Point(3, 364);
            this.bt_is.Name = "bt_is";
            this.bt_is.Size = new System.Drawing.Size(697, 28);
            this.bt_is.TabIndex = 1;
            this.bt_is.Text = "برسی";
            this.bt_is.UseVisualStyleBackColor = true;
            this.bt_is.Click += new System.EventHandler(this.Bt_is_Click_1);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.dvg_1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dvg_3, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 34);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(697, 324);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // dvg_1
            // 
            this.dvg_1.AllowUserToAddRows = false;
            this.dvg_1.AllowUserToDeleteRows = false;
            this.dvg_1.BackgroundColor = System.Drawing.Color.White;
            this.dvg_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvg_1.GridColor = System.Drawing.Color.Black;
            this.dvg_1.Location = new System.Drawing.Point(3, 3);
            this.dvg_1.Name = "dvg_1";
            this.dvg_1.ReadOnly = true;
            this.dvg_1.Size = new System.Drawing.Size(342, 318);
            this.dvg_1.TabIndex = 3;
            // 
            // dvg_3
            // 
            this.dvg_3.AllowUserToAddRows = false;
            this.dvg_3.AllowUserToDeleteRows = false;
            this.dvg_3.BackgroundColor = System.Drawing.Color.White;
            this.dvg_3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvg_3.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dvg_3.Location = new System.Drawing.Point(351, 3);
            this.dvg_3.Name = "dvg_3";
            this.dvg_3.ReadOnly = true;
            this.dvg_3.Size = new System.Drawing.Size(343, 318);
            this.dvg_3.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 395);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvg_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox TB_1;
        private System.Windows.Forms.Button bt_is;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        public System.Windows.Forms.DataGridView dvg_1;
        public System.Windows.Forms.DataGridView dvg_3;
    }
}