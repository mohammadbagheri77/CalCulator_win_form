namespace CalCulator_win
{
    partial class data
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
            this.lb_show = new System.Windows.Forms.Label();
            this.btn_2 = new System.Windows.Forms.Button();
            this.dvg_2 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_2)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lb_show, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dvg_2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.222222F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.77778F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.22222F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(677, 354);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lb_show
            // 
            this.lb_show.AutoSize = true;
            this.lb_show.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_show.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lb_show.Location = new System.Drawing.Point(3, 0);
            this.lb_show.Name = "lb_show";
            this.lb_show.Size = new System.Drawing.Size(671, 21);
            this.lb_show.TabIndex = 0;
            this.lb_show.Text = "نمایش";
            this.lb_show.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_2
            // 
            this.btn_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_2.Location = new System.Drawing.Point(3, 319);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(671, 32);
            this.btn_2.TabIndex = 1;
            this.btn_2.Text = "نمایش";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.Btn_2_Click);
            // 
            // dvg_2
            // 
            this.dvg_2.BackgroundColor = System.Drawing.Color.White;
            this.dvg_2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvg_2.Location = new System.Drawing.Point(3, 24);
            this.dvg_2.Name = "dvg_2";
            this.dvg_2.Size = new System.Drawing.Size(671, 289);
            this.dvg_2.TabIndex = 2;
            // 
            // data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 354);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "data";
            this.Text = "data";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Label lb_show;
        private System.Windows.Forms.Button btn_2;
        public System.Windows.Forms.DataGridView dvg_2;
    }
}